// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.ROS20190910.Models;

namespace AlibabaCloud.SDK.ROS20190910
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "ros.aliyuncs.com"},
                {"ap-northeast-2", "ros.aliyuncs.com"},
                {"ap-southeast-1", "ros.aliyuncs.com"},
                {"ap-southeast-2", "ros.aliyuncs.com"},
                {"ap-southeast-3", "ros.aliyuncs.com"},
                {"ap-southeast-5", "ros.aliyuncs.com"},
                {"ap-southeast-6", "ros.aliyuncs.com"},
                {"ap-southeast-7", "ros.aliyuncs.com"},
                {"ap-southeast-8", "ros.aliyuncs.com"},
                {"cn-beijing", "ros.aliyuncs.com"},
                {"cn-chengdu", "ros.aliyuncs.com"},
                {"cn-fuzhou", "ros.aliyuncs.com"},
                {"cn-guangzhou", "ros.aliyuncs.com"},
                {"cn-hangzhou", "ros.aliyuncs.com"},
                {"cn-heyuan", "ros.aliyuncs.com"},
                {"cn-hongkong", "ros.aliyuncs.com"},
                {"cn-huhehaote", "ros.aliyuncs.com"},
                {"cn-nanjing", "ros.aliyuncs.com"},
                {"cn-qingdao", "ros.aliyuncs.com"},
                {"cn-shanghai", "ros.aliyuncs.com"},
                {"cn-shenzhen", "ros.aliyuncs.com"},
                {"cn-wuhan-lr", "ros.aliyuncs.com"},
                {"cn-wulanchabu", "ros.aliyuncs.com"},
                {"cn-zhangjiakou", "ros.aliyuncs.com"},
                {"cn-zhengzhou-jva", "ros.aliyuncs.com"},
                {"cn-zhongwei", "ros.aliyuncs.com"},
                {"eu-central-1", "ros.aliyuncs.com"},
                {"eu-west-1", "ros.aliyuncs.com"},
                {"eu-west-2", "ros.aliyuncs.com"},
                {"na-south-1", "ros.aliyuncs.com"},
                {"sa-east-1", "ros.aliyuncs.com"},
                {"us-east-1", "ros.aliyuncs.com"},
                {"us-southeast-1", "ros.aliyuncs.com"},
                {"us-west-1", "ros.aliyuncs.com"},
                {"ap-south-1", "ros.aliyuncs.com"},
                {"me-central-1", "ros.aliyuncs.com"},
                {"me-east-1", "ros.aliyuncs.com"},
                {"cn-hangzhou-finance", "ros.aliyuncs.com"},
                {"cn-heyuan-acdr-1", "ros.aliyuncs.com"},
                {"cn-shanghai-finance-1", "ros.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "ros.aliyuncs.com"},
                {"cn-wulanchabu-gic-1", "ros.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("ros", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Cancels operations on a stack.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelStackOperationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelStackOperationResponse
        /// </returns>
        public CancelStackOperationResponse CancelStackOperationWithOptions(CancelStackOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedStackOperations))
            {
                query["AllowedStackOperations"] = request.AllowedStackOperations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CancelType))
            {
                query["CancelType"] = request.CancelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelStackOperation",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelStackOperationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels operations on a stack.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelStackOperationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelStackOperationResponse
        /// </returns>
        public async Task<CancelStackOperationResponse> CancelStackOperationWithOptionsAsync(CancelStackOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedStackOperations))
            {
                query["AllowedStackOperations"] = request.AllowedStackOperations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CancelType))
            {
                query["CancelType"] = request.CancelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelStackOperation",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelStackOperationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels operations on a stack.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelStackOperationRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelStackOperationResponse
        /// </returns>
        public CancelStackOperationResponse CancelStackOperation(CancelStackOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelStackOperationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels operations on a stack.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelStackOperationRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelStackOperationResponse
        /// </returns>
        public async Task<CancelStackOperationResponse> CancelStackOperationAsync(CancelStackOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelStackOperationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an update operation on a stack. You can call this operation to cancel an update operation on a stack when the stack is being updated or created.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelUpdateStackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelUpdateStackResponse
        /// </returns>
        public CancelUpdateStackResponse CancelUpdateStackWithOptions(CancelUpdateStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CancelType))
            {
                query["CancelType"] = request.CancelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelUpdateStack",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelUpdateStackResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an update operation on a stack. You can call this operation to cancel an update operation on a stack when the stack is being updated or created.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelUpdateStackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelUpdateStackResponse
        /// </returns>
        public async Task<CancelUpdateStackResponse> CancelUpdateStackWithOptionsAsync(CancelUpdateStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CancelType))
            {
                query["CancelType"] = request.CancelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelUpdateStack",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelUpdateStackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an update operation on a stack. You can call this operation to cancel an update operation on a stack when the stack is being updated or created.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelUpdateStackRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelUpdateStackResponse
        /// </returns>
        public CancelUpdateStackResponse CancelUpdateStack(CancelUpdateStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelUpdateStackWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an update operation on a stack. You can call this operation to cancel an update operation on a stack when the stack is being updated or created.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelUpdateStackRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelUpdateStackResponse
        /// </returns>
        public async Task<CancelUpdateStackResponse> CancelUpdateStackAsync(CancelUpdateStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelUpdateStackWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Continues to create a stack after the stack fails to be created.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to continue to create a stack after the stack fails to be created. In this example, the stack whose ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c> is created in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ContinueCreateStackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ContinueCreateStackResponse
        /// </returns>
        public ContinueCreateStackResponse ContinueCreateStackWithOptions(ContinueCreateStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parallelism))
            {
                query["Parallelism"] = request.Parallelism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                query["RamRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecreatingOptions))
            {
                query["RecreatingOptions"] = request.RecreatingOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecreatingResources))
            {
                query["RecreatingResources"] = request.RecreatingResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                query["TemplateBody"] = request.TemplateBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ContinueCreateStack",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContinueCreateStackResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Continues to create a stack after the stack fails to be created.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to continue to create a stack after the stack fails to be created. In this example, the stack whose ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c> is created in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ContinueCreateStackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ContinueCreateStackResponse
        /// </returns>
        public async Task<ContinueCreateStackResponse> ContinueCreateStackWithOptionsAsync(ContinueCreateStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parallelism))
            {
                query["Parallelism"] = request.Parallelism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                query["RamRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecreatingOptions))
            {
                query["RecreatingOptions"] = request.RecreatingOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecreatingResources))
            {
                query["RecreatingResources"] = request.RecreatingResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                query["TemplateBody"] = request.TemplateBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ContinueCreateStack",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContinueCreateStackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Continues to create a stack after the stack fails to be created.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to continue to create a stack after the stack fails to be created. In this example, the stack whose ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c> is created in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ContinueCreateStackRequest
        /// </param>
        /// 
        /// <returns>
        /// ContinueCreateStackResponse
        /// </returns>
        public ContinueCreateStackResponse ContinueCreateStack(ContinueCreateStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ContinueCreateStackWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Continues to create a stack after the stack fails to be created.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to continue to create a stack after the stack fails to be created. In this example, the stack whose ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c> is created in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ContinueCreateStackRequest
        /// </param>
        /// 
        /// <returns>
        /// ContinueCreateStackResponse
        /// </returns>
        public async Task<ContinueCreateStackResponse> ContinueCreateStackAsync(ContinueCreateStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ContinueCreateStackWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create AI Task</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API allows users to create an AI task based on the specified task type, covering a range of capabilities from natural language understanding to resource stack deployment. Users need to provide the task type and any required parameters, and the API will return a unique TaskId for tracking the status and results of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAITaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAITaskResponse
        /// </returns>
        public CreateAITaskResponse CreateAITaskWithOptions(CreateAITaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                query["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Template))
            {
                body["Template"] = request.Template;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAITask",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAITaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create AI Task</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API allows users to create an AI task based on the specified task type, covering a range of capabilities from natural language understanding to resource stack deployment. Users need to provide the task type and any required parameters, and the API will return a unique TaskId for tracking the status and results of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAITaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAITaskResponse
        /// </returns>
        public async Task<CreateAITaskResponse> CreateAITaskWithOptionsAsync(CreateAITaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                query["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Template))
            {
                body["Template"] = request.Template;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAITask",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAITaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create AI Task</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API allows users to create an AI task based on the specified task type, covering a range of capabilities from natural language understanding to resource stack deployment. Users need to provide the task type and any required parameters, and the API will return a unique TaskId for tracking the status and results of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAITaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAITaskResponse
        /// </returns>
        public CreateAITaskResponse CreateAITask(CreateAITaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAITaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create AI Task</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API allows users to create an AI task based on the specified task type, covering a range of capabilities from natural language understanding to resource stack deployment. Users need to provide the task type and any required parameters, and the API will return a unique TaskId for tracking the status and results of the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAITaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAITaskResponse
        /// </returns>
        public async Task<CreateAITaskResponse> CreateAITaskAsync(CreateAITaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAITaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a change set for a stack so you can preview changes before execution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Scenarios</h3>
        /// <h4>Create a stack using a change set</h4>
        /// <para>To manage cloud resources and preview creation results before the stack is created, set <c>ChangeSetType</c> to CREATE. <a href="https://help.aliyun.com/document_detail/155649.html">Change sets</a>.</para>
        /// <h4>Update a stack using a change set</h4>
        /// <para>To preview the impact of an update before applying changes, set <c>ChangeSetType</c> to UPDATE. <a href="https://help.aliyun.com/document_detail/155649.html">Change sets</a>.</para>
        /// <h4>Create a stack from existing resources</h4>
        /// <para>To import existing cloud resources into a new stack, set <c>ChangeSetType</c> to IMPORT. <a href="https://help.aliyun.com/document_detail/193454.html">Overview</a>.</para>
        /// <h4>Import existing resources to a stack</h4>
        /// <para>To import existing resources into an existing stack, set <c>ChangeSetType</c> to IMPORT. <a href="https://help.aliyun.com/document_detail/193454.html">Overview</a>.</para>
        /// <h3>Limits</h3>
        /// <list type="bullet">
        /// <item><description>Only stacks in specific states can be updated using change sets. <a href="https://help.aliyun.com/document_detail/155873.html">Update a stack using a change set</a>.</description></item>
        /// <item><description>A stack can have a maximum of 20 change sets at a time.</description></item>
        /// <item><description>A change set shows only the changes to a stack. It does not indicate whether the stack will be successfully updated.</description></item>
        /// <item><description>A change set does not check for issues such as exceeded account quotas, non-updatable resources, or insufficient permissions. These issues can cause the stack update to fail. If the update fails, ROS attempts to roll back resources to their previous state.
        /// In this example, a change set named <c>MyChangeSet</c> is created in the China (Hangzhou) region (<c>cn-hangzhou</c>) to update the template of stack <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c> to <c>{&quot;ROSTemplateFormatVersion&quot;:&quot;2015-09-01&quot;}</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateChangeSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChangeSetResponse
        /// </returns>
        public CreateChangeSetResponse CreateChangeSetWithOptions(CreateChangeSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSetName))
            {
                query["ChangeSetName"] = request.ChangeSetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSetType))
            {
                query["ChangeSetType"] = request.ChangeSetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableRollback))
            {
                query["DisableRollback"] = request.DisableRollback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationURLs))
            {
                query["NotificationURLs"] = request.NotificationURLs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parallelism))
            {
                query["Parallelism"] = request.Parallelism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                query["RamRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplacementOption))
            {
                query["ReplacementOption"] = request.ReplacementOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcesToImport))
            {
                query["ResourcesToImport"] = request.ResourcesToImport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackName))
            {
                query["StackName"] = request.StackName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyBody))
            {
                query["StackPolicyBody"] = request.StackPolicyBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyDuringUpdateBody))
            {
                query["StackPolicyDuringUpdateBody"] = request.StackPolicyDuringUpdateBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyDuringUpdateURL))
            {
                query["StackPolicyDuringUpdateURL"] = request.StackPolicyDuringUpdateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyURL))
            {
                query["StackPolicyURL"] = request.StackPolicyURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaintResources))
            {
                query["TaintResources"] = request.TaintResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchId))
            {
                query["TemplateScratchId"] = request.TemplateScratchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutInMinutes))
            {
                query["TimeoutInMinutes"] = request.TimeoutInMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePreviousParameters))
            {
                query["UsePreviousParameters"] = request.UsePreviousParameters;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChangeSet",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChangeSetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a change set for a stack so you can preview changes before execution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Scenarios</h3>
        /// <h4>Create a stack using a change set</h4>
        /// <para>To manage cloud resources and preview creation results before the stack is created, set <c>ChangeSetType</c> to CREATE. <a href="https://help.aliyun.com/document_detail/155649.html">Change sets</a>.</para>
        /// <h4>Update a stack using a change set</h4>
        /// <para>To preview the impact of an update before applying changes, set <c>ChangeSetType</c> to UPDATE. <a href="https://help.aliyun.com/document_detail/155649.html">Change sets</a>.</para>
        /// <h4>Create a stack from existing resources</h4>
        /// <para>To import existing cloud resources into a new stack, set <c>ChangeSetType</c> to IMPORT. <a href="https://help.aliyun.com/document_detail/193454.html">Overview</a>.</para>
        /// <h4>Import existing resources to a stack</h4>
        /// <para>To import existing resources into an existing stack, set <c>ChangeSetType</c> to IMPORT. <a href="https://help.aliyun.com/document_detail/193454.html">Overview</a>.</para>
        /// <h3>Limits</h3>
        /// <list type="bullet">
        /// <item><description>Only stacks in specific states can be updated using change sets. <a href="https://help.aliyun.com/document_detail/155873.html">Update a stack using a change set</a>.</description></item>
        /// <item><description>A stack can have a maximum of 20 change sets at a time.</description></item>
        /// <item><description>A change set shows only the changes to a stack. It does not indicate whether the stack will be successfully updated.</description></item>
        /// <item><description>A change set does not check for issues such as exceeded account quotas, non-updatable resources, or insufficient permissions. These issues can cause the stack update to fail. If the update fails, ROS attempts to roll back resources to their previous state.
        /// In this example, a change set named <c>MyChangeSet</c> is created in the China (Hangzhou) region (<c>cn-hangzhou</c>) to update the template of stack <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c> to <c>{&quot;ROSTemplateFormatVersion&quot;:&quot;2015-09-01&quot;}</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateChangeSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChangeSetResponse
        /// </returns>
        public async Task<CreateChangeSetResponse> CreateChangeSetWithOptionsAsync(CreateChangeSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSetName))
            {
                query["ChangeSetName"] = request.ChangeSetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSetType))
            {
                query["ChangeSetType"] = request.ChangeSetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableRollback))
            {
                query["DisableRollback"] = request.DisableRollback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationURLs))
            {
                query["NotificationURLs"] = request.NotificationURLs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parallelism))
            {
                query["Parallelism"] = request.Parallelism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                query["RamRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplacementOption))
            {
                query["ReplacementOption"] = request.ReplacementOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcesToImport))
            {
                query["ResourcesToImport"] = request.ResourcesToImport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackName))
            {
                query["StackName"] = request.StackName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyBody))
            {
                query["StackPolicyBody"] = request.StackPolicyBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyDuringUpdateBody))
            {
                query["StackPolicyDuringUpdateBody"] = request.StackPolicyDuringUpdateBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyDuringUpdateURL))
            {
                query["StackPolicyDuringUpdateURL"] = request.StackPolicyDuringUpdateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyURL))
            {
                query["StackPolicyURL"] = request.StackPolicyURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaintResources))
            {
                query["TaintResources"] = request.TaintResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchId))
            {
                query["TemplateScratchId"] = request.TemplateScratchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutInMinutes))
            {
                query["TimeoutInMinutes"] = request.TimeoutInMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePreviousParameters))
            {
                query["UsePreviousParameters"] = request.UsePreviousParameters;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChangeSet",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChangeSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a change set for a stack so you can preview changes before execution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Scenarios</h3>
        /// <h4>Create a stack using a change set</h4>
        /// <para>To manage cloud resources and preview creation results before the stack is created, set <c>ChangeSetType</c> to CREATE. <a href="https://help.aliyun.com/document_detail/155649.html">Change sets</a>.</para>
        /// <h4>Update a stack using a change set</h4>
        /// <para>To preview the impact of an update before applying changes, set <c>ChangeSetType</c> to UPDATE. <a href="https://help.aliyun.com/document_detail/155649.html">Change sets</a>.</para>
        /// <h4>Create a stack from existing resources</h4>
        /// <para>To import existing cloud resources into a new stack, set <c>ChangeSetType</c> to IMPORT. <a href="https://help.aliyun.com/document_detail/193454.html">Overview</a>.</para>
        /// <h4>Import existing resources to a stack</h4>
        /// <para>To import existing resources into an existing stack, set <c>ChangeSetType</c> to IMPORT. <a href="https://help.aliyun.com/document_detail/193454.html">Overview</a>.</para>
        /// <h3>Limits</h3>
        /// <list type="bullet">
        /// <item><description>Only stacks in specific states can be updated using change sets. <a href="https://help.aliyun.com/document_detail/155873.html">Update a stack using a change set</a>.</description></item>
        /// <item><description>A stack can have a maximum of 20 change sets at a time.</description></item>
        /// <item><description>A change set shows only the changes to a stack. It does not indicate whether the stack will be successfully updated.</description></item>
        /// <item><description>A change set does not check for issues such as exceeded account quotas, non-updatable resources, or insufficient permissions. These issues can cause the stack update to fail. If the update fails, ROS attempts to roll back resources to their previous state.
        /// In this example, a change set named <c>MyChangeSet</c> is created in the China (Hangzhou) region (<c>cn-hangzhou</c>) to update the template of stack <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c> to <c>{&quot;ROSTemplateFormatVersion&quot;:&quot;2015-09-01&quot;}</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateChangeSetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChangeSetResponse
        /// </returns>
        public CreateChangeSetResponse CreateChangeSet(CreateChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateChangeSetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a change set for a stack so you can preview changes before execution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Scenarios</h3>
        /// <h4>Create a stack using a change set</h4>
        /// <para>To manage cloud resources and preview creation results before the stack is created, set <c>ChangeSetType</c> to CREATE. <a href="https://help.aliyun.com/document_detail/155649.html">Change sets</a>.</para>
        /// <h4>Update a stack using a change set</h4>
        /// <para>To preview the impact of an update before applying changes, set <c>ChangeSetType</c> to UPDATE. <a href="https://help.aliyun.com/document_detail/155649.html">Change sets</a>.</para>
        /// <h4>Create a stack from existing resources</h4>
        /// <para>To import existing cloud resources into a new stack, set <c>ChangeSetType</c> to IMPORT. <a href="https://help.aliyun.com/document_detail/193454.html">Overview</a>.</para>
        /// <h4>Import existing resources to a stack</h4>
        /// <para>To import existing resources into an existing stack, set <c>ChangeSetType</c> to IMPORT. <a href="https://help.aliyun.com/document_detail/193454.html">Overview</a>.</para>
        /// <h3>Limits</h3>
        /// <list type="bullet">
        /// <item><description>Only stacks in specific states can be updated using change sets. <a href="https://help.aliyun.com/document_detail/155873.html">Update a stack using a change set</a>.</description></item>
        /// <item><description>A stack can have a maximum of 20 change sets at a time.</description></item>
        /// <item><description>A change set shows only the changes to a stack. It does not indicate whether the stack will be successfully updated.</description></item>
        /// <item><description>A change set does not check for issues such as exceeded account quotas, non-updatable resources, or insufficient permissions. These issues can cause the stack update to fail. If the update fails, ROS attempts to roll back resources to their previous state.
        /// In this example, a change set named <c>MyChangeSet</c> is created in the China (Hangzhou) region (<c>cn-hangzhou</c>) to update the template of stack <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c> to <c>{&quot;ROSTemplateFormatVersion&quot;:&quot;2015-09-01&quot;}</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateChangeSetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChangeSetResponse
        /// </returns>
        public async Task<CreateChangeSetResponse> CreateChangeSetAsync(CreateChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateChangeSetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dignosis task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDiagnosticRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDiagnosticResponse
        /// </returns>
        public CreateDiagnosticResponse CreateDiagnosticWithOptions(CreateDiagnosticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiagnosticKey))
            {
                query["DiagnosticKey"] = request.DiagnosticKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiagnosticType))
            {
                query["DiagnosticType"] = request.DiagnosticType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDiagnostic",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDiagnosticResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dignosis task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDiagnosticRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDiagnosticResponse
        /// </returns>
        public async Task<CreateDiagnosticResponse> CreateDiagnosticWithOptionsAsync(CreateDiagnosticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiagnosticKey))
            {
                query["DiagnosticKey"] = request.DiagnosticKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiagnosticType))
            {
                query["DiagnosticType"] = request.DiagnosticType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDiagnostic",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDiagnosticResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dignosis task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDiagnosticRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDiagnosticResponse
        /// </returns>
        public CreateDiagnosticResponse CreateDiagnostic(CreateDiagnosticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDiagnosticWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dignosis task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDiagnosticRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDiagnosticResponse
        /// </returns>
        public async Task<CreateDiagnosticResponse> CreateDiagnosticAsync(CreateDiagnosticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDiagnosticWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a stack from a ROS template to deploy a group of resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A stack is the management unit for ROS resources (<a href="https://help.aliyun.com/document_detail/172973.html">Overview</a>). Limits:</para>
        /// <list type="bullet">
        /// <item><description>Each Alibaba Cloud account can create up to 200 stacks.</description></item>
        /// <item><description>Each stack can contain up to 200 resources.
        /// The following example creates a stack named <c>MyStack</c> in the China (Hangzhou) region with <c>TemplateBody</c> set to <c>{&quot;ROSTemplateFormatVersion&quot;:&quot;2015-09-01&quot;}</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateStackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateStackResponse
        /// </returns>
        public CreateStackResponse CreateStackWithOptions(CreateStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateOption))
            {
                query["CreateOption"] = request.CreateOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateOptions))
            {
                query["CreateOptions"] = request.CreateOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                query["DeletionProtection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableRollback))
            {
                query["DisableRollback"] = request.DisableRollback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationURLs))
            {
                query["NotificationURLs"] = request.NotificationURLs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parallelism))
            {
                query["Parallelism"] = request.Parallelism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                query["RamRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackName))
            {
                query["StackName"] = request.StackName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyBody))
            {
                query["StackPolicyBody"] = request.StackPolicyBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyURL))
            {
                query["StackPolicyURL"] = request.StackPolicyURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchId))
            {
                query["TemplateScratchId"] = request.TemplateScratchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchRegionId))
            {
                query["TemplateScratchRegionId"] = request.TemplateScratchRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutInMinutes))
            {
                query["TimeoutInMinutes"] = request.TimeoutInMinutes;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStack",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStackResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a stack from a ROS template to deploy a group of resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A stack is the management unit for ROS resources (<a href="https://help.aliyun.com/document_detail/172973.html">Overview</a>). Limits:</para>
        /// <list type="bullet">
        /// <item><description>Each Alibaba Cloud account can create up to 200 stacks.</description></item>
        /// <item><description>Each stack can contain up to 200 resources.
        /// The following example creates a stack named <c>MyStack</c> in the China (Hangzhou) region with <c>TemplateBody</c> set to <c>{&quot;ROSTemplateFormatVersion&quot;:&quot;2015-09-01&quot;}</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateStackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateStackResponse
        /// </returns>
        public async Task<CreateStackResponse> CreateStackWithOptionsAsync(CreateStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateOption))
            {
                query["CreateOption"] = request.CreateOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateOptions))
            {
                query["CreateOptions"] = request.CreateOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                query["DeletionProtection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableRollback))
            {
                query["DisableRollback"] = request.DisableRollback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationURLs))
            {
                query["NotificationURLs"] = request.NotificationURLs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parallelism))
            {
                query["Parallelism"] = request.Parallelism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                query["RamRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackName))
            {
                query["StackName"] = request.StackName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyBody))
            {
                query["StackPolicyBody"] = request.StackPolicyBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyURL))
            {
                query["StackPolicyURL"] = request.StackPolicyURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchId))
            {
                query["TemplateScratchId"] = request.TemplateScratchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchRegionId))
            {
                query["TemplateScratchRegionId"] = request.TemplateScratchRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutInMinutes))
            {
                query["TimeoutInMinutes"] = request.TimeoutInMinutes;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStack",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a stack from a ROS template to deploy a group of resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A stack is the management unit for ROS resources (<a href="https://help.aliyun.com/document_detail/172973.html">Overview</a>). Limits:</para>
        /// <list type="bullet">
        /// <item><description>Each Alibaba Cloud account can create up to 200 stacks.</description></item>
        /// <item><description>Each stack can contain up to 200 resources.
        /// The following example creates a stack named <c>MyStack</c> in the China (Hangzhou) region with <c>TemplateBody</c> set to <c>{&quot;ROSTemplateFormatVersion&quot;:&quot;2015-09-01&quot;}</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateStackRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateStackResponse
        /// </returns>
        public CreateStackResponse CreateStack(CreateStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStackWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a stack from a ROS template to deploy a group of resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A stack is the management unit for ROS resources (<a href="https://help.aliyun.com/document_detail/172973.html">Overview</a>). Limits:</para>
        /// <list type="bullet">
        /// <item><description>Each Alibaba Cloud account can create up to 200 stacks.</description></item>
        /// <item><description>Each stack can contain up to 200 resources.
        /// The following example creates a stack named <c>MyStack</c> in the China (Hangzhou) region with <c>TemplateBody</c> set to <c>{&quot;ROSTemplateFormatVersion&quot;:&quot;2015-09-01&quot;}</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateStackRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateStackResponse
        /// </returns>
        public async Task<CreateStackResponse> CreateStackAsync(CreateStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStackWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a stack group from an ROS template to create stacks across multiple Alibaba Cloud accounts and regions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A stack group manages multiple ROS stacks as a unit, enabling you to create stacks across Alibaba Cloud accounts and regions.
        /// Stack groups support two permission models:</para>
        /// <list type="bullet">
        /// <item><description>Self-managed: Both the administrator and execution accounts are Alibaba Cloud accounts.</description></item>
        /// <item><description>Service-managed: The administrator account is the management account or delegated administrator account of a resource directory. The execution account is a member account of that directory.
        /// <a href="https://help.aliyun.com/document_detail/154578.html">Overview</a>.
        /// This example creates a self-managed stack group named <c>MyStackGroup</c> in the <c>China (Hangzhou)</c> region using template <c>5ecd1e10-b0e9-4389-a565-e4c15efc****</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateStackGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateStackGroupResponse
        /// </returns>
        public CreateStackGroupResponse CreateStackGroupWithOptions(CreateStackGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateStackGroupShrinkRequest request = new CreateStackGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AutoDeployment))
            {
                request.AutoDeploymentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AutoDeployment, "AutoDeployment", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdministrationRoleName))
            {
                query["AdministrationRoleName"] = request.AdministrationRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDeploymentShrink))
            {
                query["AutoDeployment"] = request.AutoDeploymentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Capabilities))
            {
                query["Capabilities"] = request.Capabilities;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionRoleName))
            {
                query["ExecutionRoleName"] = request.ExecutionRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionModel))
            {
                query["PermissionModel"] = request.PermissionModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackArn))
            {
                query["StackArn"] = request.StackArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStackGroup",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStackGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a stack group from an ROS template to create stacks across multiple Alibaba Cloud accounts and regions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A stack group manages multiple ROS stacks as a unit, enabling you to create stacks across Alibaba Cloud accounts and regions.
        /// Stack groups support two permission models:</para>
        /// <list type="bullet">
        /// <item><description>Self-managed: Both the administrator and execution accounts are Alibaba Cloud accounts.</description></item>
        /// <item><description>Service-managed: The administrator account is the management account or delegated administrator account of a resource directory. The execution account is a member account of that directory.
        /// <a href="https://help.aliyun.com/document_detail/154578.html">Overview</a>.
        /// This example creates a self-managed stack group named <c>MyStackGroup</c> in the <c>China (Hangzhou)</c> region using template <c>5ecd1e10-b0e9-4389-a565-e4c15efc****</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateStackGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateStackGroupResponse
        /// </returns>
        public async Task<CreateStackGroupResponse> CreateStackGroupWithOptionsAsync(CreateStackGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateStackGroupShrinkRequest request = new CreateStackGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AutoDeployment))
            {
                request.AutoDeploymentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AutoDeployment, "AutoDeployment", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdministrationRoleName))
            {
                query["AdministrationRoleName"] = request.AdministrationRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDeploymentShrink))
            {
                query["AutoDeployment"] = request.AutoDeploymentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Capabilities))
            {
                query["Capabilities"] = request.Capabilities;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionRoleName))
            {
                query["ExecutionRoleName"] = request.ExecutionRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionModel))
            {
                query["PermissionModel"] = request.PermissionModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackArn))
            {
                query["StackArn"] = request.StackArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStackGroup",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStackGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a stack group from an ROS template to create stacks across multiple Alibaba Cloud accounts and regions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A stack group manages multiple ROS stacks as a unit, enabling you to create stacks across Alibaba Cloud accounts and regions.
        /// Stack groups support two permission models:</para>
        /// <list type="bullet">
        /// <item><description>Self-managed: Both the administrator and execution accounts are Alibaba Cloud accounts.</description></item>
        /// <item><description>Service-managed: The administrator account is the management account or delegated administrator account of a resource directory. The execution account is a member account of that directory.
        /// <a href="https://help.aliyun.com/document_detail/154578.html">Overview</a>.
        /// This example creates a self-managed stack group named <c>MyStackGroup</c> in the <c>China (Hangzhou)</c> region using template <c>5ecd1e10-b0e9-4389-a565-e4c15efc****</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateStackGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateStackGroupResponse
        /// </returns>
        public CreateStackGroupResponse CreateStackGroup(CreateStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStackGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a stack group from an ROS template to create stacks across multiple Alibaba Cloud accounts and regions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A stack group manages multiple ROS stacks as a unit, enabling you to create stacks across Alibaba Cloud accounts and regions.
        /// Stack groups support two permission models:</para>
        /// <list type="bullet">
        /// <item><description>Self-managed: Both the administrator and execution accounts are Alibaba Cloud accounts.</description></item>
        /// <item><description>Service-managed: The administrator account is the management account or delegated administrator account of a resource directory. The execution account is a member account of that directory.
        /// <a href="https://help.aliyun.com/document_detail/154578.html">Overview</a>.
        /// This example creates a self-managed stack group named <c>MyStackGroup</c> in the <c>China (Hangzhou)</c> region using template <c>5ecd1e10-b0e9-4389-a565-e4c15efc****</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateStackGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateStackGroupResponse
        /// </returns>
        public async Task<CreateStackGroupResponse> CreateStackGroupAsync(CreateStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStackGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates stack instances for one or more accounts in the specified regions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <para>Ensure that a stack group is created. For more information, see <a href="https://help.aliyun.com/document_detail/151333.html">CreateStackGroup</a>.</para>
        /// <h3>Scenarios</h3>
        /// <h4>Create stacks across accounts</h4>
        /// <para>To create identical resources in multiple accounts, an administrator account can create a stack group, add multiple destination accounts, and deploy resources in a single region. This process creates multiple stacks in different accounts within the same region, improving deployment efficiency.</para>
        /// <h4>Create stacks across regions</h4>
        /// <para>To create identical resources in multiple regions, an administrator account can create a stack group, add a destination account, and deploy resources in multiple regions. This process creates multiple stacks in different regions within the same account, improving deployment efficiency.</para>
        /// <h4>Create stacks across accounts and regions</h4>
        /// <para>To create identical resources in multiple accounts across multiple regions, an administrator account can create a stack group, add multiple destination accounts, and deploy resources in multiple regions. This process creates multiple stacks in different accounts across different regions, improving deployment efficiency.
        /// This topic provides an example of creating stacks in the China (Hangzhou) and China (Beijing) regions in the Alibaba Cloud accounts <c>151266687691****</c> and <c>141261387191****</c>. The example uses a stack group named <c>MyStackGroup</c> that is created in the China (Hangzhou) region and uses self-managed permissions.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateStackInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateStackInstancesResponse
        /// </returns>
        public CreateStackInstancesResponse CreateStackInstancesWithOptions(CreateStackInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateStackInstancesShrinkRequest request = new CreateStackInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountIds))
            {
                request.AccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountIds, "AccountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeploymentTargets))
            {
                request.DeploymentTargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeploymentTargets, "DeploymentTargets", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperationPreferences))
            {
                request.OperationPreferencesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperationPreferences, "OperationPreferences", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RegionIds))
            {
                request.RegionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RegionIds, "RegionIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIdsShrink))
            {
                query["AccountIds"] = request.AccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentOptions))
            {
                query["DeploymentOptions"] = request.DeploymentOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentTargetsShrink))
            {
                query["DeploymentTargets"] = request.DeploymentTargetsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableRollback))
            {
                query["DisableRollback"] = request.DisableRollback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationDescription))
            {
                query["OperationDescription"] = request.OperationDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationPreferencesShrink))
            {
                query["OperationPreferences"] = request.OperationPreferencesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParameterOverrides))
            {
                query["ParameterOverrides"] = request.ParameterOverrides;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsShrink))
            {
                query["RegionIds"] = request.RegionIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutInMinutes))
            {
                query["TimeoutInMinutes"] = request.TimeoutInMinutes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStackInstances",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStackInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates stack instances for one or more accounts in the specified regions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <para>Ensure that a stack group is created. For more information, see <a href="https://help.aliyun.com/document_detail/151333.html">CreateStackGroup</a>.</para>
        /// <h3>Scenarios</h3>
        /// <h4>Create stacks across accounts</h4>
        /// <para>To create identical resources in multiple accounts, an administrator account can create a stack group, add multiple destination accounts, and deploy resources in a single region. This process creates multiple stacks in different accounts within the same region, improving deployment efficiency.</para>
        /// <h4>Create stacks across regions</h4>
        /// <para>To create identical resources in multiple regions, an administrator account can create a stack group, add a destination account, and deploy resources in multiple regions. This process creates multiple stacks in different regions within the same account, improving deployment efficiency.</para>
        /// <h4>Create stacks across accounts and regions</h4>
        /// <para>To create identical resources in multiple accounts across multiple regions, an administrator account can create a stack group, add multiple destination accounts, and deploy resources in multiple regions. This process creates multiple stacks in different accounts across different regions, improving deployment efficiency.
        /// This topic provides an example of creating stacks in the China (Hangzhou) and China (Beijing) regions in the Alibaba Cloud accounts <c>151266687691****</c> and <c>141261387191****</c>. The example uses a stack group named <c>MyStackGroup</c> that is created in the China (Hangzhou) region and uses self-managed permissions.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateStackInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateStackInstancesResponse
        /// </returns>
        public async Task<CreateStackInstancesResponse> CreateStackInstancesWithOptionsAsync(CreateStackInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateStackInstancesShrinkRequest request = new CreateStackInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountIds))
            {
                request.AccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountIds, "AccountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeploymentTargets))
            {
                request.DeploymentTargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeploymentTargets, "DeploymentTargets", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperationPreferences))
            {
                request.OperationPreferencesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperationPreferences, "OperationPreferences", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RegionIds))
            {
                request.RegionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RegionIds, "RegionIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIdsShrink))
            {
                query["AccountIds"] = request.AccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentOptions))
            {
                query["DeploymentOptions"] = request.DeploymentOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentTargetsShrink))
            {
                query["DeploymentTargets"] = request.DeploymentTargetsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableRollback))
            {
                query["DisableRollback"] = request.DisableRollback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationDescription))
            {
                query["OperationDescription"] = request.OperationDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationPreferencesShrink))
            {
                query["OperationPreferences"] = request.OperationPreferencesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParameterOverrides))
            {
                query["ParameterOverrides"] = request.ParameterOverrides;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsShrink))
            {
                query["RegionIds"] = request.RegionIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutInMinutes))
            {
                query["TimeoutInMinutes"] = request.TimeoutInMinutes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStackInstances",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStackInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates stack instances for one or more accounts in the specified regions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <para>Ensure that a stack group is created. For more information, see <a href="https://help.aliyun.com/document_detail/151333.html">CreateStackGroup</a>.</para>
        /// <h3>Scenarios</h3>
        /// <h4>Create stacks across accounts</h4>
        /// <para>To create identical resources in multiple accounts, an administrator account can create a stack group, add multiple destination accounts, and deploy resources in a single region. This process creates multiple stacks in different accounts within the same region, improving deployment efficiency.</para>
        /// <h4>Create stacks across regions</h4>
        /// <para>To create identical resources in multiple regions, an administrator account can create a stack group, add a destination account, and deploy resources in multiple regions. This process creates multiple stacks in different regions within the same account, improving deployment efficiency.</para>
        /// <h4>Create stacks across accounts and regions</h4>
        /// <para>To create identical resources in multiple accounts across multiple regions, an administrator account can create a stack group, add multiple destination accounts, and deploy resources in multiple regions. This process creates multiple stacks in different accounts across different regions, improving deployment efficiency.
        /// This topic provides an example of creating stacks in the China (Hangzhou) and China (Beijing) regions in the Alibaba Cloud accounts <c>151266687691****</c> and <c>141261387191****</c>. The example uses a stack group named <c>MyStackGroup</c> that is created in the China (Hangzhou) region and uses self-managed permissions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateStackInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateStackInstancesResponse
        /// </returns>
        public CreateStackInstancesResponse CreateStackInstances(CreateStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStackInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates stack instances for one or more accounts in the specified regions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Prerequisites</h3>
        /// <para>Ensure that a stack group is created. For more information, see <a href="https://help.aliyun.com/document_detail/151333.html">CreateStackGroup</a>.</para>
        /// <h3>Scenarios</h3>
        /// <h4>Create stacks across accounts</h4>
        /// <para>To create identical resources in multiple accounts, an administrator account can create a stack group, add multiple destination accounts, and deploy resources in a single region. This process creates multiple stacks in different accounts within the same region, improving deployment efficiency.</para>
        /// <h4>Create stacks across regions</h4>
        /// <para>To create identical resources in multiple regions, an administrator account can create a stack group, add a destination account, and deploy resources in multiple regions. This process creates multiple stacks in different regions within the same account, improving deployment efficiency.</para>
        /// <h4>Create stacks across accounts and regions</h4>
        /// <para>To create identical resources in multiple accounts across multiple regions, an administrator account can create a stack group, add multiple destination accounts, and deploy resources in multiple regions. This process creates multiple stacks in different accounts across different regions, improving deployment efficiency.
        /// This topic provides an example of creating stacks in the China (Hangzhou) and China (Beijing) regions in the Alibaba Cloud accounts <c>151266687691****</c> and <c>141261387191****</c>. The example uses a stack group named <c>MyStackGroup</c> that is created in the China (Hangzhou) region and uses self-managed permissions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateStackInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateStackInstancesResponse
        /// </returns>
        public async Task<CreateStackInstancesResponse> CreateStackInstancesAsync(CreateStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStackInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to create a template named <c>MyTemplate</c> in the China (Hangzhou) region (<c>cn-hangzhou</c>). The <c>TemplateBody</c> parameter is set to <c>{&quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;}</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public CreateTemplateResponse CreateTemplateWithOptions(CreateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidationOptions))
            {
                query["ValidationOptions"] = request.ValidationOptions;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplate",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to create a template named <c>MyTemplate</c> in the China (Hangzhou) region (<c>cn-hangzhou</c>). The <c>TemplateBody</c> parameter is set to <c>{&quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;}</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public async Task<CreateTemplateResponse> CreateTemplateWithOptionsAsync(CreateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidationOptions))
            {
                query["ValidationOptions"] = request.ValidationOptions;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplate",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to create a template named <c>MyTemplate</c> in the China (Hangzhou) region (<c>cn-hangzhou</c>). The <c>TemplateBody</c> parameter is set to <c>{&quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;}</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to create a template named <c>MyTemplate</c> in the China (Hangzhou) region (<c>cn-hangzhou</c>). The <c>TemplateBody</c> parameter is set to <c>{&quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;}</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public async Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates templatescratch: scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Limits</h3>
        /// <para>Only specific resource types support the resource scenario feature. For more information, refer to <a href="https://help.aliyun.com/document_detail/353175.html">Resource types that support scenarios</a>.</para>
        /// <h3>Description</h3>
        /// <para>Resource Orchestration Service (ROS) provides the resource scenario feature. You can select a resource scope in the UI and perform operations such as replication or management of a group of resources, helping simplify resource management. For more information about resource scenarios, refer to <a href="https://help.aliyun.com/document_detail/352074.html">Overview</a>.</para>
        /// <h4>Resource replication scenario</h4>
        /// <para>If you want to replicate a collection of resources and dependencies between the resources, you can create a resource replication scenario. This type of scenario lets you replicate all existing resources within the specified scope and generate a collection of resources that have the same architecture as the existing resources. For more information, refer to <a href="https://help.aliyun.com/document_detail/353133.html">Resource replication scenario</a>.</para>
        /// <h4>Resource profiling scenario</h4>
        /// <para>If the relationships between resources that you want to create are complicated, you can create a resource profiling scenario to preview the overall resource architecture or the architecture starting from a specific resource. This helps simplify resource management. For more information, refer to <a href="https://help.aliyun.com/document_detail/2591901.html">Resource detection scenario</a>.</para>
        /// <h4>Resource management scenario</h4>
        /// <para>If you need to import a collection of existing resources into a new resource stack for unified management, you can create a resource management scenario. For more information, refer to <a href="https://help.aliyun.com/document_detail/353163.html">Resource management scenario</a>.</para>
        /// <h4>Resource migration scenario</h4>
        /// <para>If you want to migrate a collection of resources and dependencies between the resources, you can create a resource migration scenario. When you migrate the resources, ROS generates a stack. You can view the migration progress on the Stacks tab of the scenario details page. After you migrate the resources, you can delete source resources. For more information, refer to <a href="https://help.aliyun.com/document_detail/379902.html">Resource migration scenario</a>.
        /// This topic provides an example of how to create a resource replication scenario in the China (Hangzhou) region to replicate a virtual private cloud (VPC) with the ID of <c>vpc-bp1m6fww66xbntjyc****</c>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateTemplateScratchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateScratchResponse
        /// </returns>
        public CreateTemplateScratchResponse CreateTemplateScratchWithOptions(CreateTemplateScratchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTemplateScratchShrinkRequest request = new CreateTemplateScratchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PreferenceParameters))
            {
                request.PreferenceParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PreferenceParameters, "PreferenceParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceResourceGroup))
            {
                request.SourceResourceGroupShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceResourceGroup, "SourceResourceGroup", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceResources))
            {
                request.SourceResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceResources, "SourceResources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceTag))
            {
                request.SourceTagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceTag, "SourceTag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionMode))
            {
                query["ExecutionMode"] = request.ExecutionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalIdStrategy))
            {
                query["LogicalIdStrategy"] = request.LogicalIdStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferenceParametersShrink))
            {
                query["PreferenceParameters"] = request.PreferenceParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceResourceGroupShrink))
            {
                query["SourceResourceGroup"] = request.SourceResourceGroupShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceResourcesShrink))
            {
                query["SourceResources"] = request.SourceResourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTagShrink))
            {
                query["SourceTag"] = request.SourceTagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchType))
            {
                query["TemplateScratchType"] = request.TemplateScratchType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplateScratch",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplateScratchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates templatescratch: scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Limits</h3>
        /// <para>Only specific resource types support the resource scenario feature. For more information, refer to <a href="https://help.aliyun.com/document_detail/353175.html">Resource types that support scenarios</a>.</para>
        /// <h3>Description</h3>
        /// <para>Resource Orchestration Service (ROS) provides the resource scenario feature. You can select a resource scope in the UI and perform operations such as replication or management of a group of resources, helping simplify resource management. For more information about resource scenarios, refer to <a href="https://help.aliyun.com/document_detail/352074.html">Overview</a>.</para>
        /// <h4>Resource replication scenario</h4>
        /// <para>If you want to replicate a collection of resources and dependencies between the resources, you can create a resource replication scenario. This type of scenario lets you replicate all existing resources within the specified scope and generate a collection of resources that have the same architecture as the existing resources. For more information, refer to <a href="https://help.aliyun.com/document_detail/353133.html">Resource replication scenario</a>.</para>
        /// <h4>Resource profiling scenario</h4>
        /// <para>If the relationships between resources that you want to create are complicated, you can create a resource profiling scenario to preview the overall resource architecture or the architecture starting from a specific resource. This helps simplify resource management. For more information, refer to <a href="https://help.aliyun.com/document_detail/2591901.html">Resource detection scenario</a>.</para>
        /// <h4>Resource management scenario</h4>
        /// <para>If you need to import a collection of existing resources into a new resource stack for unified management, you can create a resource management scenario. For more information, refer to <a href="https://help.aliyun.com/document_detail/353163.html">Resource management scenario</a>.</para>
        /// <h4>Resource migration scenario</h4>
        /// <para>If you want to migrate a collection of resources and dependencies between the resources, you can create a resource migration scenario. When you migrate the resources, ROS generates a stack. You can view the migration progress on the Stacks tab of the scenario details page. After you migrate the resources, you can delete source resources. For more information, refer to <a href="https://help.aliyun.com/document_detail/379902.html">Resource migration scenario</a>.
        /// This topic provides an example of how to create a resource replication scenario in the China (Hangzhou) region to replicate a virtual private cloud (VPC) with the ID of <c>vpc-bp1m6fww66xbntjyc****</c>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateTemplateScratchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateScratchResponse
        /// </returns>
        public async Task<CreateTemplateScratchResponse> CreateTemplateScratchWithOptionsAsync(CreateTemplateScratchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTemplateScratchShrinkRequest request = new CreateTemplateScratchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PreferenceParameters))
            {
                request.PreferenceParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PreferenceParameters, "PreferenceParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceResourceGroup))
            {
                request.SourceResourceGroupShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceResourceGroup, "SourceResourceGroup", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceResources))
            {
                request.SourceResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceResources, "SourceResources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceTag))
            {
                request.SourceTagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceTag, "SourceTag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionMode))
            {
                query["ExecutionMode"] = request.ExecutionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalIdStrategy))
            {
                query["LogicalIdStrategy"] = request.LogicalIdStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferenceParametersShrink))
            {
                query["PreferenceParameters"] = request.PreferenceParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceResourceGroupShrink))
            {
                query["SourceResourceGroup"] = request.SourceResourceGroupShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceResourcesShrink))
            {
                query["SourceResources"] = request.SourceResourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTagShrink))
            {
                query["SourceTag"] = request.SourceTagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchType))
            {
                query["TemplateScratchType"] = request.TemplateScratchType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplateScratch",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplateScratchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates templatescratch: scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Limits</h3>
        /// <para>Only specific resource types support the resource scenario feature. For more information, refer to <a href="https://help.aliyun.com/document_detail/353175.html">Resource types that support scenarios</a>.</para>
        /// <h3>Description</h3>
        /// <para>Resource Orchestration Service (ROS) provides the resource scenario feature. You can select a resource scope in the UI and perform operations such as replication or management of a group of resources, helping simplify resource management. For more information about resource scenarios, refer to <a href="https://help.aliyun.com/document_detail/352074.html">Overview</a>.</para>
        /// <h4>Resource replication scenario</h4>
        /// <para>If you want to replicate a collection of resources and dependencies between the resources, you can create a resource replication scenario. This type of scenario lets you replicate all existing resources within the specified scope and generate a collection of resources that have the same architecture as the existing resources. For more information, refer to <a href="https://help.aliyun.com/document_detail/353133.html">Resource replication scenario</a>.</para>
        /// <h4>Resource profiling scenario</h4>
        /// <para>If the relationships between resources that you want to create are complicated, you can create a resource profiling scenario to preview the overall resource architecture or the architecture starting from a specific resource. This helps simplify resource management. For more information, refer to <a href="https://help.aliyun.com/document_detail/2591901.html">Resource detection scenario</a>.</para>
        /// <h4>Resource management scenario</h4>
        /// <para>If you need to import a collection of existing resources into a new resource stack for unified management, you can create a resource management scenario. For more information, refer to <a href="https://help.aliyun.com/document_detail/353163.html">Resource management scenario</a>.</para>
        /// <h4>Resource migration scenario</h4>
        /// <para>If you want to migrate a collection of resources and dependencies between the resources, you can create a resource migration scenario. When you migrate the resources, ROS generates a stack. You can view the migration progress on the Stacks tab of the scenario details page. After you migrate the resources, you can delete source resources. For more information, refer to <a href="https://help.aliyun.com/document_detail/379902.html">Resource migration scenario</a>.
        /// This topic provides an example of how to create a resource replication scenario in the China (Hangzhou) region to replicate a virtual private cloud (VPC) with the ID of <c>vpc-bp1m6fww66xbntjyc****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTemplateScratchRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateScratchResponse
        /// </returns>
        public CreateTemplateScratchResponse CreateTemplateScratch(CreateTemplateScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTemplateScratchWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates templatescratch: scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Limits</h3>
        /// <para>Only specific resource types support the resource scenario feature. For more information, refer to <a href="https://help.aliyun.com/document_detail/353175.html">Resource types that support scenarios</a>.</para>
        /// <h3>Description</h3>
        /// <para>Resource Orchestration Service (ROS) provides the resource scenario feature. You can select a resource scope in the UI and perform operations such as replication or management of a group of resources, helping simplify resource management. For more information about resource scenarios, refer to <a href="https://help.aliyun.com/document_detail/352074.html">Overview</a>.</para>
        /// <h4>Resource replication scenario</h4>
        /// <para>If you want to replicate a collection of resources and dependencies between the resources, you can create a resource replication scenario. This type of scenario lets you replicate all existing resources within the specified scope and generate a collection of resources that have the same architecture as the existing resources. For more information, refer to <a href="https://help.aliyun.com/document_detail/353133.html">Resource replication scenario</a>.</para>
        /// <h4>Resource profiling scenario</h4>
        /// <para>If the relationships between resources that you want to create are complicated, you can create a resource profiling scenario to preview the overall resource architecture or the architecture starting from a specific resource. This helps simplify resource management. For more information, refer to <a href="https://help.aliyun.com/document_detail/2591901.html">Resource detection scenario</a>.</para>
        /// <h4>Resource management scenario</h4>
        /// <para>If you need to import a collection of existing resources into a new resource stack for unified management, you can create a resource management scenario. For more information, refer to <a href="https://help.aliyun.com/document_detail/353163.html">Resource management scenario</a>.</para>
        /// <h4>Resource migration scenario</h4>
        /// <para>If you want to migrate a collection of resources and dependencies between the resources, you can create a resource migration scenario. When you migrate the resources, ROS generates a stack. You can view the migration progress on the Stacks tab of the scenario details page. After you migrate the resources, you can delete source resources. For more information, refer to <a href="https://help.aliyun.com/document_detail/379902.html">Resource migration scenario</a>.
        /// This topic provides an example of how to create a resource replication scenario in the China (Hangzhou) region to replicate a virtual private cloud (VPC) with the ID of <c>vpc-bp1m6fww66xbntjyc****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTemplateScratchRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateScratchResponse
        /// </returns>
        public async Task<CreateTemplateScratchResponse> CreateTemplateScratchAsync(CreateTemplateScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTemplateScratchWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes change sets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that the following requirements are met:<list type="bullet">
        /// <item><description>The status of the change set is CREATE_COMPLETE, CREATE_FAILED, or DELETE_FAILED.</description></item>
        /// <item><description>The execution status is UNAVAILABLE or AVAILABLE.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>After a change set is executed, other change sets associated with the same stack as this change set are also deleted.</description></item>
        /// <item><description>After a stack is deleted, change sets associated with the stack are deleted.</description></item>
        /// <item><description>If a change set of the CREATE type is deleted, you must delete stacks associated with the change set.
        /// In this example, a change set whose ID is <c>1f6521a4-05af-4975-afe9-bc4b45ad****</c> is deleted. The change set is created in the China (Hangzhou) region.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteChangeSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteChangeSetResponse
        /// </returns>
        public DeleteChangeSetResponse DeleteChangeSetWithOptions(DeleteChangeSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSetId))
            {
                query["ChangeSetId"] = request.ChangeSetId;
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
                Action = "DeleteChangeSet",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteChangeSetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes change sets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that the following requirements are met:<list type="bullet">
        /// <item><description>The status of the change set is CREATE_COMPLETE, CREATE_FAILED, or DELETE_FAILED.</description></item>
        /// <item><description>The execution status is UNAVAILABLE or AVAILABLE.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>After a change set is executed, other change sets associated with the same stack as this change set are also deleted.</description></item>
        /// <item><description>After a stack is deleted, change sets associated with the stack are deleted.</description></item>
        /// <item><description>If a change set of the CREATE type is deleted, you must delete stacks associated with the change set.
        /// In this example, a change set whose ID is <c>1f6521a4-05af-4975-afe9-bc4b45ad****</c> is deleted. The change set is created in the China (Hangzhou) region.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteChangeSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteChangeSetResponse
        /// </returns>
        public async Task<DeleteChangeSetResponse> DeleteChangeSetWithOptionsAsync(DeleteChangeSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSetId))
            {
                query["ChangeSetId"] = request.ChangeSetId;
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
                Action = "DeleteChangeSet",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteChangeSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes change sets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that the following requirements are met:<list type="bullet">
        /// <item><description>The status of the change set is CREATE_COMPLETE, CREATE_FAILED, or DELETE_FAILED.</description></item>
        /// <item><description>The execution status is UNAVAILABLE or AVAILABLE.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>After a change set is executed, other change sets associated with the same stack as this change set are also deleted.</description></item>
        /// <item><description>After a stack is deleted, change sets associated with the stack are deleted.</description></item>
        /// <item><description>If a change set of the CREATE type is deleted, you must delete stacks associated with the change set.
        /// In this example, a change set whose ID is <c>1f6521a4-05af-4975-afe9-bc4b45ad****</c> is deleted. The change set is created in the China (Hangzhou) region.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteChangeSetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteChangeSetResponse
        /// </returns>
        public DeleteChangeSetResponse DeleteChangeSet(DeleteChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteChangeSetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes change sets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that the following requirements are met:<list type="bullet">
        /// <item><description>The status of the change set is CREATE_COMPLETE, CREATE_FAILED, or DELETE_FAILED.</description></item>
        /// <item><description>The execution status is UNAVAILABLE or AVAILABLE.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>After a change set is executed, other change sets associated with the same stack as this change set are also deleted.</description></item>
        /// <item><description>After a stack is deleted, change sets associated with the stack are deleted.</description></item>
        /// <item><description>If a change set of the CREATE type is deleted, you must delete stacks associated with the change set.
        /// In this example, a change set whose ID is <c>1f6521a4-05af-4975-afe9-bc4b45ad****</c> is deleted. The change set is created in the China (Hangzhou) region.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteChangeSetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteChangeSetResponse
        /// </returns>
        public async Task<DeleteChangeSetResponse> DeleteChangeSetAsync(DeleteChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteChangeSetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a diagnostic record.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDiagnosticRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDiagnosticResponse
        /// </returns>
        public DeleteDiagnosticResponse DeleteDiagnosticWithOptions(DeleteDiagnosticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDiagnostic",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDiagnosticResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a diagnostic record.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDiagnosticRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDiagnosticResponse
        /// </returns>
        public async Task<DeleteDiagnosticResponse> DeleteDiagnosticWithOptionsAsync(DeleteDiagnosticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDiagnostic",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDiagnosticResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a diagnostic record.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDiagnosticRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDiagnosticResponse
        /// </returns>
        public DeleteDiagnosticResponse DeleteDiagnostic(DeleteDiagnosticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDiagnosticWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a diagnostic record.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDiagnosticRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDiagnosticResponse
        /// </returns>
        public async Task<DeleteDiagnosticResponse> DeleteDiagnosticAsync(DeleteDiagnosticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDiagnosticWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a stack, optionally retaining resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteStackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteStackResponse
        /// </returns>
        public DeleteStackResponse DeleteStackWithOptions(DeleteStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteOptions))
            {
                query["DeleteOptions"] = request.DeleteOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parallelism))
            {
                query["Parallelism"] = request.Parallelism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                query["RamRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainAllResources))
            {
                query["RetainAllResources"] = request.RetainAllResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainResources))
            {
                query["RetainResources"] = request.RetainResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStack",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStackResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a stack, optionally retaining resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteStackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteStackResponse
        /// </returns>
        public async Task<DeleteStackResponse> DeleteStackWithOptionsAsync(DeleteStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteOptions))
            {
                query["DeleteOptions"] = request.DeleteOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parallelism))
            {
                query["Parallelism"] = request.Parallelism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                query["RamRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainAllResources))
            {
                query["RetainAllResources"] = request.RetainAllResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainResources))
            {
                query["RetainResources"] = request.RetainResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStack",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a stack, optionally retaining resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteStackRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteStackResponse
        /// </returns>
        public DeleteStackResponse DeleteStack(DeleteStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteStackWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a stack, optionally retaining resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteStackRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteStackResponse
        /// </returns>
        public async Task<DeleteStackResponse> DeleteStackAsync(DeleteStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteStackWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a stack group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A stack group can be deleted only when the stack group does not contain stacks. You can call the <a href="https://help.aliyun.com/document_detail/151715.html">DeleteStackInstances</a> operation to delete stacks.
        /// This topic provides an example on how to delete a stack group. In this example, a stack group named <c>MyStackGroup</c> in the China (Hangzhou) region is deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteStackGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteStackGroupResponse
        /// </returns>
        public DeleteStackGroupResponse DeleteStackGroupWithOptions(DeleteStackGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStackGroup",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStackGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a stack group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A stack group can be deleted only when the stack group does not contain stacks. You can call the <a href="https://help.aliyun.com/document_detail/151715.html">DeleteStackInstances</a> operation to delete stacks.
        /// This topic provides an example on how to delete a stack group. In this example, a stack group named <c>MyStackGroup</c> in the China (Hangzhou) region is deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteStackGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteStackGroupResponse
        /// </returns>
        public async Task<DeleteStackGroupResponse> DeleteStackGroupWithOptionsAsync(DeleteStackGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStackGroup",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStackGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a stack group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A stack group can be deleted only when the stack group does not contain stacks. You can call the <a href="https://help.aliyun.com/document_detail/151715.html">DeleteStackInstances</a> operation to delete stacks.
        /// This topic provides an example on how to delete a stack group. In this example, a stack group named <c>MyStackGroup</c> in the China (Hangzhou) region is deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteStackGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteStackGroupResponse
        /// </returns>
        public DeleteStackGroupResponse DeleteStackGroup(DeleteStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteStackGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a stack group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A stack group can be deleted only when the stack group does not contain stacks. You can call the <a href="https://help.aliyun.com/document_detail/151715.html">DeleteStackInstances</a> operation to delete stacks.
        /// This topic provides an example on how to delete a stack group. In this example, a stack group named <c>MyStackGroup</c> in the China (Hangzhou) region is deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteStackGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteStackGroupResponse
        /// </returns>
        public async Task<DeleteStackGroupResponse> DeleteStackGroupAsync(DeleteStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteStackGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes stack instances from specified accounts and regions. You can choose to retain the resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to delete a stack instance from the <c>MyStackGroup</c> stack group. The stack group uses self-managed permissions and is in the China (Hangzhou) region. This example deletes the stack instance that is deployed in the China (Beijing) region for the Alibaba Cloud account <c>151266687691****</c>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteStackInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteStackInstancesResponse
        /// </returns>
        public DeleteStackInstancesResponse DeleteStackInstancesWithOptions(DeleteStackInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteStackInstancesShrinkRequest request = new DeleteStackInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountIds))
            {
                request.AccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountIds, "AccountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeploymentTargets))
            {
                request.DeploymentTargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeploymentTargets, "DeploymentTargets", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperationPreferences))
            {
                request.OperationPreferencesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperationPreferences, "OperationPreferences", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RegionIds))
            {
                request.RegionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RegionIds, "RegionIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIdsShrink))
            {
                query["AccountIds"] = request.AccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentTargetsShrink))
            {
                query["DeploymentTargets"] = request.DeploymentTargetsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationDescription))
            {
                query["OperationDescription"] = request.OperationDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationPreferencesShrink))
            {
                query["OperationPreferences"] = request.OperationPreferencesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsShrink))
            {
                query["RegionIds"] = request.RegionIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainStacks))
            {
                query["RetainStacks"] = request.RetainStacks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStackInstances",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStackInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes stack instances from specified accounts and regions. You can choose to retain the resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to delete a stack instance from the <c>MyStackGroup</c> stack group. The stack group uses self-managed permissions and is in the China (Hangzhou) region. This example deletes the stack instance that is deployed in the China (Beijing) region for the Alibaba Cloud account <c>151266687691****</c>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteStackInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteStackInstancesResponse
        /// </returns>
        public async Task<DeleteStackInstancesResponse> DeleteStackInstancesWithOptionsAsync(DeleteStackInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteStackInstancesShrinkRequest request = new DeleteStackInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountIds))
            {
                request.AccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountIds, "AccountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeploymentTargets))
            {
                request.DeploymentTargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeploymentTargets, "DeploymentTargets", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperationPreferences))
            {
                request.OperationPreferencesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperationPreferences, "OperationPreferences", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RegionIds))
            {
                request.RegionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RegionIds, "RegionIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIdsShrink))
            {
                query["AccountIds"] = request.AccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentTargetsShrink))
            {
                query["DeploymentTargets"] = request.DeploymentTargetsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationDescription))
            {
                query["OperationDescription"] = request.OperationDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationPreferencesShrink))
            {
                query["OperationPreferences"] = request.OperationPreferencesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsShrink))
            {
                query["RegionIds"] = request.RegionIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainStacks))
            {
                query["RetainStacks"] = request.RetainStacks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStackInstances",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStackInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes stack instances from specified accounts and regions. You can choose to retain the resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to delete a stack instance from the <c>MyStackGroup</c> stack group. The stack group uses self-managed permissions and is in the China (Hangzhou) region. This example deletes the stack instance that is deployed in the China (Beijing) region for the Alibaba Cloud account <c>151266687691****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteStackInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteStackInstancesResponse
        /// </returns>
        public DeleteStackInstancesResponse DeleteStackInstances(DeleteStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteStackInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes stack instances from specified accounts and regions. You can choose to retain the resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to delete a stack instance from the <c>MyStackGroup</c> stack group. The stack group uses self-managed permissions and is in the China (Hangzhou) region. This example deletes the stack instance that is deployed in the China (Beijing) region for the Alibaba Cloud account <c>151266687691****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteStackInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteStackInstancesResponse
        /// </returns>
        public async Task<DeleteStackInstancesResponse> DeleteStackInstancesAsync(DeleteStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteStackInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If a template is shared with other Alibaba Cloud accounts, unshare it before deletion.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public DeleteTemplateResponse DeleteTemplateWithOptions(DeleteTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DeleteTemplate",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If a template is shared with other Alibaba Cloud accounts, unshare it before deletion.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public async Task<DeleteTemplateResponse> DeleteTemplateWithOptionsAsync(DeleteTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DeleteTemplate",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If a template is shared with other Alibaba Cloud accounts, unshare it before deletion.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If a template is shared with other Alibaba Cloud accounts, unshare it before deletion.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this topic, a scenario whose ID is <c>ts-4f83704400994409****</c> is deleted in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTemplateScratchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateScratchResponse
        /// </returns>
        public DeleteTemplateScratchResponse DeleteTemplateScratchWithOptions(DeleteTemplateScratchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchId))
            {
                query["TemplateScratchId"] = request.TemplateScratchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplateScratch",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplateScratchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this topic, a scenario whose ID is <c>ts-4f83704400994409****</c> is deleted in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTemplateScratchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateScratchResponse
        /// </returns>
        public async Task<DeleteTemplateScratchResponse> DeleteTemplateScratchWithOptionsAsync(DeleteTemplateScratchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchId))
            {
                query["TemplateScratchId"] = request.TemplateScratchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplateScratch",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplateScratchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this topic, a scenario whose ID is <c>ts-4f83704400994409****</c> is deleted in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTemplateScratchRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateScratchResponse
        /// </returns>
        public DeleteTemplateScratchResponse DeleteTemplateScratch(DeleteTemplateScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTemplateScratchWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this topic, a scenario whose ID is <c>ts-4f83704400994409****</c> is deleted in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteTemplateScratchRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateScratchResponse
        /// </returns>
        public async Task<DeleteTemplateScratchResponse> DeleteTemplateScratchAsync(DeleteTemplateScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTemplateScratchWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a resource type or a specific version of a resource type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>If you delete a resource type, it can no longer be used in ROS.</description></item>
        /// <item><description>If you delete a version of a resource type, that version can no longer be used in ROS.</description></item>
        /// <item><description>You can delete a resource type only if it has a single version. If a resource type has multiple versions, you must delete the other versions first.</description></item>
        /// <item><description>You cannot delete the default version if the resource type has more than one version.</description></item>
        /// <item><description>If a resource type has only one version, deleting that version also deletes the resource type.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeregisterResourceTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeregisterResourceTypeResponse
        /// </returns>
        public DeregisterResourceTypeResponse DeregisterResourceTypeWithOptions(DeregisterResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeregisterResourceType",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeregisterResourceTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a resource type or a specific version of a resource type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>If you delete a resource type, it can no longer be used in ROS.</description></item>
        /// <item><description>If you delete a version of a resource type, that version can no longer be used in ROS.</description></item>
        /// <item><description>You can delete a resource type only if it has a single version. If a resource type has multiple versions, you must delete the other versions first.</description></item>
        /// <item><description>You cannot delete the default version if the resource type has more than one version.</description></item>
        /// <item><description>If a resource type has only one version, deleting that version also deletes the resource type.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeregisterResourceTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeregisterResourceTypeResponse
        /// </returns>
        public async Task<DeregisterResourceTypeResponse> DeregisterResourceTypeWithOptionsAsync(DeregisterResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeregisterResourceType",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeregisterResourceTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a resource type or a specific version of a resource type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>If you delete a resource type, it can no longer be used in ROS.</description></item>
        /// <item><description>If you delete a version of a resource type, that version can no longer be used in ROS.</description></item>
        /// <item><description>You can delete a resource type only if it has a single version. If a resource type has multiple versions, you must delete the other versions first.</description></item>
        /// <item><description>You cannot delete the default version if the resource type has more than one version.</description></item>
        /// <item><description>If a resource type has only one version, deleting that version also deletes the resource type.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeregisterResourceTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeregisterResourceTypeResponse
        /// </returns>
        public DeregisterResourceTypeResponse DeregisterResourceType(DeregisterResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeregisterResourceTypeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a resource type or a specific version of a resource type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>If you delete a resource type, it can no longer be used in ROS.</description></item>
        /// <item><description>If you delete a version of a resource type, that version can no longer be used in ROS.</description></item>
        /// <item><description>You can delete a resource type only if it has a single version. If a resource type has multiple versions, you must delete the other versions first.</description></item>
        /// <item><description>You cannot delete the default version if the resource type has more than one version.</description></item>
        /// <item><description>If a resource type has only one version, deleting that version also deletes the resource type.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeregisterResourceTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeregisterResourceTypeResponse
        /// </returns>
        public async Task<DeregisterResourceTypeResponse> DeregisterResourceTypeAsync(DeregisterResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeregisterResourceTypeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of available regions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of available regions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of available regions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of available regions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs drift detection on resources in a stack to check whether the resources have drifted from the expected template configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetectStackDriftRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectStackDriftResponse
        /// </returns>
        public DetectStackDriftResponse DetectStackDriftWithOptions(DetectStackDriftRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalResourceId))
            {
                query["LogicalResourceId"] = request.LogicalResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectStackDrift",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectStackDriftResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs drift detection on resources in a stack to check whether the resources have drifted from the expected template configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetectStackDriftRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectStackDriftResponse
        /// </returns>
        public async Task<DetectStackDriftResponse> DetectStackDriftWithOptionsAsync(DetectStackDriftRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalResourceId))
            {
                query["LogicalResourceId"] = request.LogicalResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectStackDrift",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectStackDriftResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs drift detection on resources in a stack to check whether the resources have drifted from the expected template configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetectStackDriftRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectStackDriftResponse
        /// </returns>
        public DetectStackDriftResponse DetectStackDrift(DetectStackDriftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectStackDriftWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs drift detection on resources in a stack to check whether the resources have drifted from the expected template configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetectStackDriftRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectStackDriftResponse
        /// </returns>
        public async Task<DetectStackDriftResponse> DetectStackDriftAsync(DetectStackDriftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectStackDriftWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs drift detection on stack groups to check whether the stack groups have drifted from the expected template configurations.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DetectStackGroupDriftRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectStackGroupDriftResponse
        /// </returns>
        public DetectStackGroupDriftResponse DetectStackGroupDriftWithOptions(DetectStackGroupDriftRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetectStackGroupDriftShrinkRequest request = new DetectStackGroupDriftShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperationPreferences))
            {
                request.OperationPreferencesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperationPreferences, "OperationPreferences", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationPreferencesShrink))
            {
                query["OperationPreferences"] = request.OperationPreferencesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectStackGroupDrift",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectStackGroupDriftResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs drift detection on stack groups to check whether the stack groups have drifted from the expected template configurations.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DetectStackGroupDriftRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectStackGroupDriftResponse
        /// </returns>
        public async Task<DetectStackGroupDriftResponse> DetectStackGroupDriftWithOptionsAsync(DetectStackGroupDriftRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetectStackGroupDriftShrinkRequest request = new DetectStackGroupDriftShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperationPreferences))
            {
                request.OperationPreferencesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperationPreferences, "OperationPreferences", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationPreferencesShrink))
            {
                query["OperationPreferences"] = request.OperationPreferencesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectStackGroupDrift",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectStackGroupDriftResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs drift detection on stack groups to check whether the stack groups have drifted from the expected template configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetectStackGroupDriftRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectStackGroupDriftResponse
        /// </returns>
        public DetectStackGroupDriftResponse DetectStackGroupDrift(DetectStackGroupDriftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectStackGroupDriftWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs drift detection on stack groups to check whether the stack groups have drifted from the expected template configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetectStackGroupDriftRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectStackGroupDriftResponse
        /// </returns>
        public async Task<DetectStackGroupDriftResponse> DetectStackGroupDriftAsync(DetectStackGroupDriftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectStackGroupDriftWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs drift detection on resources in a stack to determine whether the resources have drifted from the expected configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetectStackResourceDriftRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectStackResourceDriftResponse
        /// </returns>
        public DetectStackResourceDriftResponse DetectStackResourceDriftWithOptions(DetectStackResourceDriftRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalResourceId))
            {
                query["LogicalResourceId"] = request.LogicalResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectStackResourceDrift",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectStackResourceDriftResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs drift detection on resources in a stack to determine whether the resources have drifted from the expected configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetectStackResourceDriftRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetectStackResourceDriftResponse
        /// </returns>
        public async Task<DetectStackResourceDriftResponse> DetectStackResourceDriftWithOptionsAsync(DetectStackResourceDriftRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalResourceId))
            {
                query["LogicalResourceId"] = request.LogicalResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectStackResourceDrift",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectStackResourceDriftResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs drift detection on resources in a stack to determine whether the resources have drifted from the expected configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetectStackResourceDriftRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectStackResourceDriftResponse
        /// </returns>
        public DetectStackResourceDriftResponse DetectStackResourceDrift(DetectStackResourceDriftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectStackResourceDriftWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs drift detection on resources in a stack to determine whether the resources have drifted from the expected configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetectStackResourceDriftRequest
        /// </param>
        /// 
        /// <returns>
        /// DetectStackResourceDriftResponse
        /// </returns>
        public async Task<DetectStackResourceDriftResponse> DetectStackResourceDriftAsync(DetectStackResourceDriftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectStackResourceDriftWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables trusted service access.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Description</h3>
        /// <para>Enables trusted service access.</para>
        /// </description>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableServiceAccessResponse
        /// </returns>
        public EnableServiceAccessResponse EnableServiceAccessWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableServiceAccess",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableServiceAccessResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables trusted service access.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Description</h3>
        /// <para>Enables trusted service access.</para>
        /// </description>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableServiceAccessResponse
        /// </returns>
        public async Task<EnableServiceAccessResponse> EnableServiceAccessWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableServiceAccess",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableServiceAccessResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables trusted service access.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Description</h3>
        /// <para>Enables trusted service access.</para>
        /// </description>
        /// 
        /// <returns>
        /// EnableServiceAccessResponse
        /// </returns>
        public EnableServiceAccessResponse EnableServiceAccess()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableServiceAccessWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables trusted service access.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Description</h3>
        /// <para>Enables trusted service access.</para>
        /// </description>
        /// 
        /// <returns>
        /// EnableServiceAccessResponse
        /// </returns>
        public async Task<EnableServiceAccessResponse> EnableServiceAccessAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableServiceAccessWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables services in a batch.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Description</h3>
        /// <para>This operation enables multiple Alibaba Cloud services in a batch.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// EnableServicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableServicesResponse
        /// </returns>
        public EnableServicesResponse EnableServicesWithOptions(EnableServicesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EnableServicesShrinkRequest request = new EnableServicesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ServiceNames))
            {
                request.ServiceNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ServiceNames, "ServiceNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceNamesShrink))
            {
                query["ServiceNames"] = request.ServiceNamesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableServices",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableServicesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables services in a batch.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Description</h3>
        /// <para>This operation enables multiple Alibaba Cloud services in a batch.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// EnableServicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableServicesResponse
        /// </returns>
        public async Task<EnableServicesResponse> EnableServicesWithOptionsAsync(EnableServicesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EnableServicesShrinkRequest request = new EnableServicesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ServiceNames))
            {
                request.ServiceNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ServiceNames, "ServiceNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceNamesShrink))
            {
                query["ServiceNames"] = request.ServiceNamesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableServices",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables services in a batch.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Description</h3>
        /// <para>This operation enables multiple Alibaba Cloud services in a batch.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableServicesResponse
        /// </returns>
        public EnableServicesResponse EnableServices(EnableServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableServicesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables services in a batch.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Description</h3>
        /// <para>This operation enables multiple Alibaba Cloud services in a batch.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableServicesResponse
        /// </returns>
        public async Task<EnableServicesResponse> EnableServicesAsync(EnableServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableServicesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes change sets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the change set whose ID is <c>1f6521a4-05af-4975-afe9-bc4b45ad****</c> is executed. The change set is created in the <c>China (Hangzhou)</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecuteChangeSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteChangeSetResponse
        /// </returns>
        public ExecuteChangeSetResponse ExecuteChangeSetWithOptions(ExecuteChangeSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSetId))
            {
                query["ChangeSetId"] = request.ChangeSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
                Action = "ExecuteChangeSet",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteChangeSetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes change sets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the change set whose ID is <c>1f6521a4-05af-4975-afe9-bc4b45ad****</c> is executed. The change set is created in the <c>China (Hangzhou)</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecuteChangeSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteChangeSetResponse
        /// </returns>
        public async Task<ExecuteChangeSetResponse> ExecuteChangeSetWithOptionsAsync(ExecuteChangeSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSetId))
            {
                query["ChangeSetId"] = request.ChangeSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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
                Action = "ExecuteChangeSet",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteChangeSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes change sets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the change set whose ID is <c>1f6521a4-05af-4975-afe9-bc4b45ad****</c> is executed. The change set is created in the <c>China (Hangzhou)</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecuteChangeSetRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteChangeSetResponse
        /// </returns>
        public ExecuteChangeSetResponse ExecuteChangeSet(ExecuteChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteChangeSetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes change sets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the change set whose ID is <c>1f6521a4-05af-4975-afe9-bc4b45ad****</c> is executed. The change set is created in the <c>China (Hangzhou)</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecuteChangeSetRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteChangeSetResponse
        /// </returns>
        public async Task<ExecuteChangeSetResponse> ExecuteChangeSetAsync(ExecuteChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteChangeSetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a template for a resource scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, a template is generated for a resource management scenario that resides in the China (Hangzhou) region. The ID of the resource scenario is <c>ts-aa9c62feab844a6b****</c>.</para>
        /// <remarks>
        /// <para>You cannot generate a template for a resource detection scenario.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateTemplateByScratchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateTemplateByScratchResponse
        /// </returns>
        public GenerateTemplateByScratchResponse GenerateTemplateByScratchWithOptions(GenerateTemplateByScratchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionRegionId))
            {
                query["ProvisionRegionId"] = request.ProvisionRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchId))
            {
                query["TemplateScratchId"] = request.TemplateScratchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateTemplateByScratch",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateTemplateByScratchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a template for a resource scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, a template is generated for a resource management scenario that resides in the China (Hangzhou) region. The ID of the resource scenario is <c>ts-aa9c62feab844a6b****</c>.</para>
        /// <remarks>
        /// <para>You cannot generate a template for a resource detection scenario.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateTemplateByScratchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateTemplateByScratchResponse
        /// </returns>
        public async Task<GenerateTemplateByScratchResponse> GenerateTemplateByScratchWithOptionsAsync(GenerateTemplateByScratchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionRegionId))
            {
                query["ProvisionRegionId"] = request.ProvisionRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchId))
            {
                query["TemplateScratchId"] = request.TemplateScratchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateTemplateByScratch",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateTemplateByScratchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a template for a resource scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, a template is generated for a resource management scenario that resides in the China (Hangzhou) region. The ID of the resource scenario is <c>ts-aa9c62feab844a6b****</c>.</para>
        /// <remarks>
        /// <para>You cannot generate a template for a resource detection scenario.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateTemplateByScratchRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateTemplateByScratchResponse
        /// </returns>
        public GenerateTemplateByScratchResponse GenerateTemplateByScratch(GenerateTemplateByScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateTemplateByScratchWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a template for a resource scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, a template is generated for a resource management scenario that resides in the China (Hangzhou) region. The ID of the resource scenario is <c>ts-aa9c62feab844a6b****</c>.</para>
        /// <remarks>
        /// <para>You cannot generate a template for a resource detection scenario.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateTemplateByScratchRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateTemplateByScratchResponse
        /// </returns>
        public async Task<GenerateTemplateByScratchResponse> GenerateTemplateByScratchAsync(GenerateTemplateByScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateTemplateByScratchWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates the policy information required by a specified template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the policies required by the template include Enterprise Distributed Application Service (EDAS), log on to your Alibaba Cloud account and upgrade the RAM permissions for the Resource Access Management (RAM) users that require authorization.
        /// This topic provides an example of how to generate access policies for a template whose ID is <c>5ecd1e10-b0e9-4389-a565-e4c15efc****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateTemplatePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateTemplatePolicyResponse
        /// </returns>
        public GenerateTemplatePolicyResponse GenerateTemplatePolicyWithOptions(GenerateTemplatePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateOptions))
            {
                query["GenerateOptions"] = request.GenerateOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationTypes))
            {
                query["OperationTypes"] = request.OperationTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                query["TemplateBody"] = request.TemplateBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateTemplatePolicy",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateTemplatePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates the policy information required by a specified template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the policies required by the template include Enterprise Distributed Application Service (EDAS), log on to your Alibaba Cloud account and upgrade the RAM permissions for the Resource Access Management (RAM) users that require authorization.
        /// This topic provides an example of how to generate access policies for a template whose ID is <c>5ecd1e10-b0e9-4389-a565-e4c15efc****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateTemplatePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateTemplatePolicyResponse
        /// </returns>
        public async Task<GenerateTemplatePolicyResponse> GenerateTemplatePolicyWithOptionsAsync(GenerateTemplatePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateOptions))
            {
                query["GenerateOptions"] = request.GenerateOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationTypes))
            {
                query["OperationTypes"] = request.OperationTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                query["TemplateBody"] = request.TemplateBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateTemplatePolicy",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateTemplatePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates the policy information required by a specified template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the policies required by the template include Enterprise Distributed Application Service (EDAS), log on to your Alibaba Cloud account and upgrade the RAM permissions for the Resource Access Management (RAM) users that require authorization.
        /// This topic provides an example of how to generate access policies for a template whose ID is <c>5ecd1e10-b0e9-4389-a565-e4c15efc****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateTemplatePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateTemplatePolicyResponse
        /// </returns>
        public GenerateTemplatePolicyResponse GenerateTemplatePolicy(GenerateTemplatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateTemplatePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates the policy information required by a specified template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the policies required by the template include Enterprise Distributed Application Service (EDAS), log on to your Alibaba Cloud account and upgrade the RAM permissions for the Resource Access Management (RAM) users that require authorization.
        /// This topic provides an example of how to generate access policies for a template whose ID is <c>5ecd1e10-b0e9-4389-a565-e4c15efc****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateTemplatePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateTemplatePolicyResponse
        /// </returns>
        public async Task<GenerateTemplatePolicyResponse> GenerateTemplatePolicyAsync(GenerateTemplatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateTemplatePolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an AI task by task ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAITaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAITaskResponse
        /// </returns>
        public GetAITaskResponse GetAITaskWithOptions(GetAITaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputOption))
            {
                query["OutputOption"] = request.OutputOption;
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
                Action = "GetAITask",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAITaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an AI task by task ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAITaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAITaskResponse
        /// </returns>
        public async Task<GetAITaskResponse> GetAITaskWithOptionsAsync(GetAITaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputOption))
            {
                query["OutputOption"] = request.OutputOption;
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
                Action = "GetAITask",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAITaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an AI task by task ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAITaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAITaskResponse
        /// </returns>
        public GetAITaskResponse GetAITask(GetAITaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAITaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an AI task by task ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAITaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAITaskResponse
        /// </returns>
        public async Task<GetAITaskResponse> GetAITaskAsync(GetAITaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAITaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns details for a specified change set, optionally including the details of its associated template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic demonstrates how to query a change set with the ID <c>4c11658d-bd47-4dd0-ba64-727edc62****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetChangeSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChangeSetResponse
        /// </returns>
        public GetChangeSetResponse GetChangeSetWithOptions(GetChangeSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSetId))
            {
                query["ChangeSetId"] = request.ChangeSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowTemplate))
            {
                query["ShowTemplate"] = request.ShowTemplate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChangeSet",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChangeSetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns details for a specified change set, optionally including the details of its associated template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic demonstrates how to query a change set with the ID <c>4c11658d-bd47-4dd0-ba64-727edc62****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetChangeSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChangeSetResponse
        /// </returns>
        public async Task<GetChangeSetResponse> GetChangeSetWithOptionsAsync(GetChangeSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSetId))
            {
                query["ChangeSetId"] = request.ChangeSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowTemplate))
            {
                query["ShowTemplate"] = request.ShowTemplate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChangeSet",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChangeSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns details for a specified change set, optionally including the details of its associated template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic demonstrates how to query a change set with the ID <c>4c11658d-bd47-4dd0-ba64-727edc62****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetChangeSetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChangeSetResponse
        /// </returns>
        public GetChangeSetResponse GetChangeSet(GetChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetChangeSetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns details for a specified change set, optionally including the details of its associated template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic demonstrates how to query a change set with the ID <c>4c11658d-bd47-4dd0-ba64-727edc62****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetChangeSetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChangeSetResponse
        /// </returns>
        public async Task<GetChangeSetResponse> GetChangeSetAsync(GetChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetChangeSetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the diagnosis details based on a specified diagnostic report ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDiagnosticRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDiagnosticResponse
        /// </returns>
        public GetDiagnosticResponse GetDiagnosticWithOptions(GetDiagnosticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDiagnostic",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDiagnosticResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the diagnosis details based on a specified diagnostic report ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDiagnosticRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDiagnosticResponse
        /// </returns>
        public async Task<GetDiagnosticResponse> GetDiagnosticWithOptionsAsync(GetDiagnosticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                query["ReportId"] = request.ReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDiagnostic",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDiagnosticResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the diagnosis details based on a specified diagnostic report ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDiagnosticRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDiagnosticResponse
        /// </returns>
        public GetDiagnosticResponse GetDiagnostic(GetDiagnosticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDiagnosticWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the diagnosis details based on a specified diagnostic report ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDiagnosticRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDiagnosticResponse
        /// </returns>
        public async Task<GetDiagnosticResponse> GetDiagnosticAsync(GetDiagnosticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDiagnosticWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of features that are supported by Resource Orchestration Service (ROS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the Terraform hosting, resource cleaner, and scenario features.
        /// This topic provides an example on how to query the details of features supported by ROS in the China (Hangzhou) region. The details include Terraform versions, provider versions, and supported resource types.</para>
        /// <remarks>
        /// <para>In the Examples section, only part of the sample code is provided.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFeatureDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFeatureDetailsResponse
        /// </returns>
        public GetFeatureDetailsResponse GetFeatureDetailsWithOptions(GetFeatureDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Feature))
            {
                query["Feature"] = request.Feature;
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
                Action = "GetFeatureDetails",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFeatureDetailsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of features that are supported by Resource Orchestration Service (ROS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the Terraform hosting, resource cleaner, and scenario features.
        /// This topic provides an example on how to query the details of features supported by ROS in the China (Hangzhou) region. The details include Terraform versions, provider versions, and supported resource types.</para>
        /// <remarks>
        /// <para>In the Examples section, only part of the sample code is provided.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFeatureDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFeatureDetailsResponse
        /// </returns>
        public async Task<GetFeatureDetailsResponse> GetFeatureDetailsWithOptionsAsync(GetFeatureDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Feature))
            {
                query["Feature"] = request.Feature;
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
                Action = "GetFeatureDetails",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFeatureDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of features that are supported by Resource Orchestration Service (ROS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the Terraform hosting, resource cleaner, and scenario features.
        /// This topic provides an example on how to query the details of features supported by ROS in the China (Hangzhou) region. The details include Terraform versions, provider versions, and supported resource types.</para>
        /// <remarks>
        /// <para>In the Examples section, only part of the sample code is provided.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFeatureDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFeatureDetailsResponse
        /// </returns>
        public GetFeatureDetailsResponse GetFeatureDetails(GetFeatureDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFeatureDetailsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of features that are supported by Resource Orchestration Service (ROS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the Terraform hosting, resource cleaner, and scenario features.
        /// This topic provides an example on how to query the details of features supported by ROS in the China (Hangzhou) region. The details include Terraform versions, provider versions, and supported resource types.</para>
        /// <remarks>
        /// <para>In the Examples section, only part of the sample code is provided.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFeatureDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFeatureDetailsResponse
        /// </returns>
        public async Task<GetFeatureDetailsResponse> GetFeatureDetailsAsync(GetFeatureDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFeatureDetailsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a resource type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the details of the <c>ALIYUN::ROS::WaitConditionHandle</c> resource type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetResourceTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceTypeResponse
        /// </returns>
        public GetResourceTypeResponse GetResourceTypeWithOptions(GetResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceType",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a resource type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the details of the <c>ALIYUN::ROS::WaitConditionHandle</c> resource type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetResourceTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceTypeResponse
        /// </returns>
        public async Task<GetResourceTypeResponse> GetResourceTypeWithOptionsAsync(GetResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceType",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a resource type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the details of the <c>ALIYUN::ROS::WaitConditionHandle</c> resource type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetResourceTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceTypeResponse
        /// </returns>
        public GetResourceTypeResponse GetResourceType(GetResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceTypeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a resource type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the details of the <c>ALIYUN::ROS::WaitConditionHandle</c> resource type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetResourceTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceTypeResponse
        /// </returns>
        public async Task<GetResourceTypeResponse> GetResourceTypeAsync(GetResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceTypeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a sample template based on a resource type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceTypeTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceTypeTemplateResponse
        /// </returns>
        public GetResourceTypeTemplateResponse GetResourceTypeTemplateWithOptions(GetResourceTypeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceTypeTemplate",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceTypeTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a sample template based on a resource type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceTypeTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceTypeTemplateResponse
        /// </returns>
        public async Task<GetResourceTypeTemplateResponse> GetResourceTypeTemplateWithOptionsAsync(GetResourceTypeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceTypeTemplate",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceTypeTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a sample template based on a resource type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceTypeTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceTypeTemplateResponse
        /// </returns>
        public GetResourceTypeTemplateResponse GetResourceTypeTemplate(GetResourceTypeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceTypeTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a sample template based on a resource type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceTypeTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceTypeTemplateResponse
        /// </returns>
        public async Task<GetResourceTypeTemplateResponse> GetResourceTypeTemplateAsync(GetResourceTypeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceTypeTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access status of a trusted service.</para>
        /// </summary>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceAccessResponse
        /// </returns>
        public GetServiceAccessResponse GetServiceAccessWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceAccess",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceAccessResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access status of a trusted service.</para>
        /// </summary>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceAccessResponse
        /// </returns>
        public async Task<GetServiceAccessResponse> GetServiceAccessWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceAccess",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceAccessResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access status of a trusted service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetServiceAccessResponse
        /// </returns>
        public GetServiceAccessResponse GetServiceAccess()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceAccessWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the access status of a trusted service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetServiceAccessResponse
        /// </returns>
        public async Task<GetServiceAccessResponse> GetServiceAccessAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceAccessWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the activation status of an Alibaba Cloud service and information about its service-linked roles.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Usage notes</h3>
        /// <para>This topic provides an example of how to query the activation status of Elastic High Performance Computing (EHPC) and information about the service-linked roles for EHPC in the China (Hangzhou) region.</para>
        /// <remarks>
        /// <para>Make sure that you have the permissions to call the <a href="https://help.aliyun.com/document_detail/28711.html">GetRole</a> operation.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// GetServiceProvisionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceProvisionsResponse
        /// </returns>
        public GetServiceProvisionsResponse GetServiceProvisionsWithOptions(GetServiceProvisionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Services))
            {
                query["Services"] = request.Services;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceProvisions",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceProvisionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the activation status of an Alibaba Cloud service and information about its service-linked roles.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Usage notes</h3>
        /// <para>This topic provides an example of how to query the activation status of Elastic High Performance Computing (EHPC) and information about the service-linked roles for EHPC in the China (Hangzhou) region.</para>
        /// <remarks>
        /// <para>Make sure that you have the permissions to call the <a href="https://help.aliyun.com/document_detail/28711.html">GetRole</a> operation.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// GetServiceProvisionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceProvisionsResponse
        /// </returns>
        public async Task<GetServiceProvisionsResponse> GetServiceProvisionsWithOptionsAsync(GetServiceProvisionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Services))
            {
                query["Services"] = request.Services;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceProvisions",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceProvisionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the activation status of an Alibaba Cloud service and information about its service-linked roles.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Usage notes</h3>
        /// <para>This topic provides an example of how to query the activation status of Elastic High Performance Computing (EHPC) and information about the service-linked roles for EHPC in the China (Hangzhou) region.</para>
        /// <remarks>
        /// <para>Make sure that you have the permissions to call the <a href="https://help.aliyun.com/document_detail/28711.html">GetRole</a> operation.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// GetServiceProvisionsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetServiceProvisionsResponse
        /// </returns>
        public GetServiceProvisionsResponse GetServiceProvisions(GetServiceProvisionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceProvisionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the activation status of an Alibaba Cloud service and information about its service-linked roles.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Usage notes</h3>
        /// <para>This topic provides an example of how to query the activation status of Elastic High Performance Computing (EHPC) and information about the service-linked roles for EHPC in the China (Hangzhou) region.</para>
        /// <remarks>
        /// <para>Make sure that you have the permissions to call the <a href="https://help.aliyun.com/document_detail/28711.html">GetRole</a> operation.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// GetServiceProvisionsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetServiceProvisionsResponse
        /// </returns>
        public async Task<GetServiceProvisionsResponse> GetServiceProvisionsAsync(GetServiceProvisionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceProvisionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries stack information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the information of a stack whose ID is <c>c754d2a4-28f1-46df-b557-9586173a****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStackResponse
        /// </returns>
        public GetStackResponse GetStackWithOptions(GetStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogOption))
            {
                query["LogOption"] = request.LogOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputOption))
            {
                query["OutputOption"] = request.OutputOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowResourceProgress))
            {
                query["ShowResourceProgress"] = request.ShowResourceProgress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStack",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStackResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries stack information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the information of a stack whose ID is <c>c754d2a4-28f1-46df-b557-9586173a****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStackResponse
        /// </returns>
        public async Task<GetStackResponse> GetStackWithOptionsAsync(GetStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogOption))
            {
                query["LogOption"] = request.LogOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputOption))
            {
                query["OutputOption"] = request.OutputOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowResourceProgress))
            {
                query["ShowResourceProgress"] = request.ShowResourceProgress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStack",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries stack information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the information of a stack whose ID is <c>c754d2a4-28f1-46df-b557-9586173a****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStackResponse
        /// </returns>
        public GetStackResponse GetStack(GetStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStackWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries stack information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the information of a stack whose ID is <c>c754d2a4-28f1-46df-b557-9586173a****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStackResponse
        /// </returns>
        public async Task<GetStackResponse> GetStackAsync(GetStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStackWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the drift detection status of a stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this topic, the status of a drift detection operation whose ID is <c>a7044f0d-6f2e-4128-a307-4524ef88****</c> is queried. The operation is performed in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackDriftDetectionStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStackDriftDetectionStatusResponse
        /// </returns>
        public GetStackDriftDetectionStatusResponse GetStackDriftDetectionStatusWithOptions(GetStackDriftDetectionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriftDetectionId))
            {
                query["DriftDetectionId"] = request.DriftDetectionId;
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
                Action = "GetStackDriftDetectionStatus",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStackDriftDetectionStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the drift detection status of a stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this topic, the status of a drift detection operation whose ID is <c>a7044f0d-6f2e-4128-a307-4524ef88****</c> is queried. The operation is performed in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackDriftDetectionStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStackDriftDetectionStatusResponse
        /// </returns>
        public async Task<GetStackDriftDetectionStatusResponse> GetStackDriftDetectionStatusWithOptionsAsync(GetStackDriftDetectionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DriftDetectionId))
            {
                query["DriftDetectionId"] = request.DriftDetectionId;
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
                Action = "GetStackDriftDetectionStatus",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStackDriftDetectionStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the drift detection status of a stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this topic, the status of a drift detection operation whose ID is <c>a7044f0d-6f2e-4128-a307-4524ef88****</c> is queried. The operation is performed in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackDriftDetectionStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStackDriftDetectionStatusResponse
        /// </returns>
        public GetStackDriftDetectionStatusResponse GetStackDriftDetectionStatus(GetStackDriftDetectionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStackDriftDetectionStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the drift detection status of a stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this topic, the status of a drift detection operation whose ID is <c>a7044f0d-6f2e-4128-a307-4524ef88****</c> is queried. The operation is performed in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackDriftDetectionStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStackDriftDetectionStatusResponse
        /// </returns>
        public async Task<GetStackDriftDetectionStatusResponse> GetStackDriftDetectionStatusAsync(GetStackDriftDetectionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStackDriftDetectionStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a stack group by its name in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query a stack group named <c>MyStackGroup</c>. The stack group is in the China (Hangzhou) region and uses the self-managed permission mode.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStackGroupResponse
        /// </returns>
        public GetStackGroupResponse GetStackGroupWithOptions(GetStackGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupId))
            {
                query["StackGroupId"] = request.StackGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStackGroup",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStackGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a stack group by its name in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query a stack group named <c>MyStackGroup</c>. The stack group is in the China (Hangzhou) region and uses the self-managed permission mode.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStackGroupResponse
        /// </returns>
        public async Task<GetStackGroupResponse> GetStackGroupWithOptionsAsync(GetStackGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupId))
            {
                query["StackGroupId"] = request.StackGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStackGroup",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStackGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a stack group by its name in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query a stack group named <c>MyStackGroup</c>. The stack group is in the China (Hangzhou) region and uses the self-managed permission mode.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStackGroupResponse
        /// </returns>
        public GetStackGroupResponse GetStackGroup(GetStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStackGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a stack group by its name in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query a stack group named <c>MyStackGroup</c>. The stack group is in the China (Hangzhou) region and uses the self-managed permission mode.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStackGroupResponse
        /// </returns>
        public async Task<GetStackGroupResponse> GetStackGroupAsync(GetStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStackGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a stack group operation in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the information about the stack group operation whose ID is <c>6da106ca-1784-4a6f-a7e1-e723863d****</c> is queried. The stack group named <c>MyStackGroup</c> is granted self-managed permissions and deployed in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackGroupOperationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStackGroupOperationResponse
        /// </returns>
        public GetStackGroupOperationResponse GetStackGroupOperationWithOptions(GetStackGroupOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationId))
            {
                query["OperationId"] = request.OperationId;
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
                Action = "GetStackGroupOperation",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStackGroupOperationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a stack group operation in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the information about the stack group operation whose ID is <c>6da106ca-1784-4a6f-a7e1-e723863d****</c> is queried. The stack group named <c>MyStackGroup</c> is granted self-managed permissions and deployed in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackGroupOperationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStackGroupOperationResponse
        /// </returns>
        public async Task<GetStackGroupOperationResponse> GetStackGroupOperationWithOptionsAsync(GetStackGroupOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationId))
            {
                query["OperationId"] = request.OperationId;
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
                Action = "GetStackGroupOperation",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStackGroupOperationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a stack group operation in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the information about the stack group operation whose ID is <c>6da106ca-1784-4a6f-a7e1-e723863d****</c> is queried. The stack group named <c>MyStackGroup</c> is granted self-managed permissions and deployed in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackGroupOperationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStackGroupOperationResponse
        /// </returns>
        public GetStackGroupOperationResponse GetStackGroupOperation(GetStackGroupOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStackGroupOperationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a stack group operation in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the information about the stack group operation whose ID is <c>6da106ca-1784-4a6f-a7e1-e723863d****</c> is queried. The stack group named <c>MyStackGroup</c> is granted self-managed permissions and deployed in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackGroupOperationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStackGroupOperationResponse
        /// </returns>
        public async Task<GetStackGroupOperationResponse> GetStackGroupOperationAsync(GetStackGroupOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStackGroupOperationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a stack instance that is associated with a stack group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the information about a stack instance associated with a stack group named <c>MyStackGroup</c> is queried. The stack instance is deployed in the China (Beijing) region within the <c>151266687691****</c> Alibaba Cloud account. The stack group is granted self-managed permissions and deployed in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStackInstanceResponse
        /// </returns>
        public GetStackInstanceResponse GetStackInstanceWithOptions(GetStackInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputOption))
            {
                query["OutputOption"] = request.OutputOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackInstanceAccountId))
            {
                query["StackInstanceAccountId"] = request.StackInstanceAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackInstanceRegionId))
            {
                query["StackInstanceRegionId"] = request.StackInstanceRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStackInstance",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStackInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a stack instance that is associated with a stack group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the information about a stack instance associated with a stack group named <c>MyStackGroup</c> is queried. The stack instance is deployed in the China (Beijing) region within the <c>151266687691****</c> Alibaba Cloud account. The stack group is granted self-managed permissions and deployed in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStackInstanceResponse
        /// </returns>
        public async Task<GetStackInstanceResponse> GetStackInstanceWithOptionsAsync(GetStackInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputOption))
            {
                query["OutputOption"] = request.OutputOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackInstanceAccountId))
            {
                query["StackInstanceAccountId"] = request.StackInstanceAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackInstanceRegionId))
            {
                query["StackInstanceRegionId"] = request.StackInstanceRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStackInstance",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStackInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a stack instance that is associated with a stack group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the information about a stack instance associated with a stack group named <c>MyStackGroup</c> is queried. The stack instance is deployed in the China (Beijing) region within the <c>151266687691****</c> Alibaba Cloud account. The stack group is granted self-managed permissions and deployed in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStackInstanceResponse
        /// </returns>
        public GetStackInstanceResponse GetStackInstance(GetStackInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStackInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a stack instance that is associated with a stack group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the information about a stack instance associated with a stack group named <c>MyStackGroup</c> is queried. The stack instance is deployed in the China (Beijing) region within the <c>151266687691****</c> Alibaba Cloud account. The stack group is granted self-managed permissions and deployed in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStackInstanceResponse
        /// </returns>
        public async Task<GetStackInstanceResponse> GetStackInstanceAsync(GetStackInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStackInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the stack policy of a specified stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This example queries the stack policy of stack <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStackPolicyResponse
        /// </returns>
        public GetStackPolicyResponse GetStackPolicyWithOptions(GetStackPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStackPolicy",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStackPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the stack policy of a specified stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This example queries the stack policy of stack <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStackPolicyResponse
        /// </returns>
        public async Task<GetStackPolicyResponse> GetStackPolicyWithOptionsAsync(GetStackPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStackPolicy",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStackPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the stack policy of a specified stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This example queries the stack policy of stack <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStackPolicyResponse
        /// </returns>
        public GetStackPolicyResponse GetStackPolicy(GetStackPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStackPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the stack policy of a specified stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This example queries the stack policy of stack <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStackPolicyResponse
        /// </returns>
        public async Task<GetStackPolicyResponse> GetStackPolicyAsync(GetStackPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStackPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query a resource in a specific stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the details of a resource named <c>WebServer</c> in a stack whose ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStackResourceResponse
        /// </returns>
        public GetStackResourceResponse GetStackResourceWithOptions(GetStackResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalResourceId))
            {
                query["LogicalResourceId"] = request.LogicalResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAttributes))
            {
                query["ResourceAttributes"] = request.ResourceAttributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowResourceAttributes))
            {
                query["ShowResourceAttributes"] = request.ShowResourceAttributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStackResource",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStackResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query a resource in a specific stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the details of a resource named <c>WebServer</c> in a stack whose ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStackResourceResponse
        /// </returns>
        public async Task<GetStackResourceResponse> GetStackResourceWithOptionsAsync(GetStackResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalResourceId))
            {
                query["LogicalResourceId"] = request.LogicalResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAttributes))
            {
                query["ResourceAttributes"] = request.ResourceAttributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowResourceAttributes))
            {
                query["ShowResourceAttributes"] = request.ShowResourceAttributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStackResource",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStackResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query a resource in a specific stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the details of a resource named <c>WebServer</c> in a stack whose ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStackResourceResponse
        /// </returns>
        public GetStackResourceResponse GetStackResource(GetStackResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStackResourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query a resource in a specific stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the details of a resource named <c>WebServer</c> in a stack whose ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStackResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStackResourceResponse
        /// </returns>
        public async Task<GetStackResourceResponse> GetStackResourceAsync(GetStackResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStackResourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a template based on stacks, stack groups, change sets, or any custom template information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the details of a template whose ID is <c>5ecd1e10-b0e9-4389-a565-e4c15efc****</c> is queried. The region ID of the template is <c>cn-hangzhou</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public GetTemplateResponse GetTemplateWithOptions(GetTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSetId))
            {
                query["ChangeSetId"] = request.ChangeSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludePermission))
            {
                query["IncludePermission"] = request.IncludePermission;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeTags))
            {
                query["IncludeTags"] = request.IncludeTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateStage))
            {
                query["TemplateStage"] = request.TemplateStage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplate",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a template based on stacks, stack groups, change sets, or any custom template information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the details of a template whose ID is <c>5ecd1e10-b0e9-4389-a565-e4c15efc****</c> is queried. The region ID of the template is <c>cn-hangzhou</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public async Task<GetTemplateResponse> GetTemplateWithOptionsAsync(GetTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSetId))
            {
                query["ChangeSetId"] = request.ChangeSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludePermission))
            {
                query["IncludePermission"] = request.IncludePermission;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeTags))
            {
                query["IncludeTags"] = request.IncludeTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateStage))
            {
                query["TemplateStage"] = request.TemplateStage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplate",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a template based on stacks, stack groups, change sets, or any custom template information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the details of a template whose ID is <c>5ecd1e10-b0e9-4389-a565-e4c15efc****</c> is queried. The region ID of the template is <c>cn-hangzhou</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a template based on stacks, stack groups, change sets, or any custom template information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the details of a template whose ID is <c>5ecd1e10-b0e9-4389-a565-e4c15efc****</c> is queried. The region ID of the template is <c>cn-hangzhou</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public async Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the estimated prices of the resources in a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <list type="bullet">
        /// <item><description>For more information about the resources that support price inquiry in Resource Orchestration Service (ROS) templates, see the &quot;<b>Resource types that support price inquiry</b>&quot; section of the <a href="https://help.aliyun.com/document_detail/203165.html">Estimate resource prices</a> topic.</description></item>
        /// <item><description>For more information about the resources that support price inquiry in Terraform templates, see the &quot;<b>ROS resources supported by Terraform</b>&quot; section of the <a href="https://help.aliyun.com/document_detail/184389.html">ROS features and resources supported by Terraform</a> topic.
        /// The following sample code provides an example on how to query the estimated price of an elastic IP address (EIP) that you want to create based on a template. In this example, the following template is used:</description></item>
        /// </list>
        /// <pre><c>{
        ///   &quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;,
        ///   &quot;Parameters&quot;: {
        ///     &quot;Isp&quot;: {
        ///       &quot;Type&quot;: &quot;String&quot;,
        ///       &quot;Default&quot;: &quot;BGP&quot;
        ///     },
        ///     &quot;Name&quot;: {
        ///       &quot;Type&quot;: &quot;String&quot;,
        ///       &quot;Default&quot;: &quot;test&quot;
        ///     },
        ///     &quot;Netmode&quot;: {
        ///       &quot;Type&quot;: &quot;String&quot;,
        ///       &quot;Default&quot;: &quot;public&quot;
        ///     },
        ///     &quot;Bandwidth&quot;: {
        ///       &quot;Type&quot;: &quot;Number&quot;,
        ///       &quot;Default&quot;: 5
        ///     }
        ///   },
        ///   &quot;Resources&quot;: {
        ///     &quot;NewEip&quot;: {
        ///       &quot;Type&quot;: &quot;ALIYUN::VPC::EIP&quot;,
        ///       &quot;Properties&quot;: {
        ///         &quot;InstanceChargeType&quot;: &quot;Prepaid&quot;,
        ///         &quot;PricingCycle&quot;: &quot;Month&quot;,
        ///         &quot;Isp&quot;: {
        ///           &quot;Ref&quot;: &quot;Isp&quot;
        ///         },
        ///         &quot;Period&quot;: 1,
        ///         &quot;DeletionProtection&quot;: false,
        ///         &quot;AutoPay&quot;: false,
        ///         &quot;Name&quot;: {
        ///           &quot;Ref&quot;: &quot;Name&quot;
        ///         },
        ///         &quot;InternetChargeType&quot;: &quot;PayByTraffic&quot;,
        ///         &quot;Netmode&quot;: {
        ///           &quot;Ref&quot;: &quot;Netmode&quot;
        ///         },
        ///         &quot;Bandwidth&quot;: {
        ///           &quot;Ref&quot;: &quot;Bandwidth&quot;
        ///         }
        ///       }
        ///     }
        ///   }
        /// }
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTemplateEstimateCostRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateEstimateCostResponse
        /// </returns>
        public GetTemplateEstimateCostResponse GetTemplateEstimateCostWithOptions(GetTemplateEstimateCostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchId))
            {
                query["TemplateScratchId"] = request.TemplateScratchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchRegionId))
            {
                query["TemplateScratchRegionId"] = request.TemplateScratchRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateEstimateCost",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateEstimateCostResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the estimated prices of the resources in a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <list type="bullet">
        /// <item><description>For more information about the resources that support price inquiry in Resource Orchestration Service (ROS) templates, see the &quot;<b>Resource types that support price inquiry</b>&quot; section of the <a href="https://help.aliyun.com/document_detail/203165.html">Estimate resource prices</a> topic.</description></item>
        /// <item><description>For more information about the resources that support price inquiry in Terraform templates, see the &quot;<b>ROS resources supported by Terraform</b>&quot; section of the <a href="https://help.aliyun.com/document_detail/184389.html">ROS features and resources supported by Terraform</a> topic.
        /// The following sample code provides an example on how to query the estimated price of an elastic IP address (EIP) that you want to create based on a template. In this example, the following template is used:</description></item>
        /// </list>
        /// <pre><c>{
        ///   &quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;,
        ///   &quot;Parameters&quot;: {
        ///     &quot;Isp&quot;: {
        ///       &quot;Type&quot;: &quot;String&quot;,
        ///       &quot;Default&quot;: &quot;BGP&quot;
        ///     },
        ///     &quot;Name&quot;: {
        ///       &quot;Type&quot;: &quot;String&quot;,
        ///       &quot;Default&quot;: &quot;test&quot;
        ///     },
        ///     &quot;Netmode&quot;: {
        ///       &quot;Type&quot;: &quot;String&quot;,
        ///       &quot;Default&quot;: &quot;public&quot;
        ///     },
        ///     &quot;Bandwidth&quot;: {
        ///       &quot;Type&quot;: &quot;Number&quot;,
        ///       &quot;Default&quot;: 5
        ///     }
        ///   },
        ///   &quot;Resources&quot;: {
        ///     &quot;NewEip&quot;: {
        ///       &quot;Type&quot;: &quot;ALIYUN::VPC::EIP&quot;,
        ///       &quot;Properties&quot;: {
        ///         &quot;InstanceChargeType&quot;: &quot;Prepaid&quot;,
        ///         &quot;PricingCycle&quot;: &quot;Month&quot;,
        ///         &quot;Isp&quot;: {
        ///           &quot;Ref&quot;: &quot;Isp&quot;
        ///         },
        ///         &quot;Period&quot;: 1,
        ///         &quot;DeletionProtection&quot;: false,
        ///         &quot;AutoPay&quot;: false,
        ///         &quot;Name&quot;: {
        ///           &quot;Ref&quot;: &quot;Name&quot;
        ///         },
        ///         &quot;InternetChargeType&quot;: &quot;PayByTraffic&quot;,
        ///         &quot;Netmode&quot;: {
        ///           &quot;Ref&quot;: &quot;Netmode&quot;
        ///         },
        ///         &quot;Bandwidth&quot;: {
        ///           &quot;Ref&quot;: &quot;Bandwidth&quot;
        ///         }
        ///       }
        ///     }
        ///   }
        /// }
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTemplateEstimateCostRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateEstimateCostResponse
        /// </returns>
        public async Task<GetTemplateEstimateCostResponse> GetTemplateEstimateCostWithOptionsAsync(GetTemplateEstimateCostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchId))
            {
                query["TemplateScratchId"] = request.TemplateScratchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchRegionId))
            {
                query["TemplateScratchRegionId"] = request.TemplateScratchRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateEstimateCost",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateEstimateCostResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the estimated prices of the resources in a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <list type="bullet">
        /// <item><description>For more information about the resources that support price inquiry in Resource Orchestration Service (ROS) templates, see the &quot;<b>Resource types that support price inquiry</b>&quot; section of the <a href="https://help.aliyun.com/document_detail/203165.html">Estimate resource prices</a> topic.</description></item>
        /// <item><description>For more information about the resources that support price inquiry in Terraform templates, see the &quot;<b>ROS resources supported by Terraform</b>&quot; section of the <a href="https://help.aliyun.com/document_detail/184389.html">ROS features and resources supported by Terraform</a> topic.
        /// The following sample code provides an example on how to query the estimated price of an elastic IP address (EIP) that you want to create based on a template. In this example, the following template is used:</description></item>
        /// </list>
        /// <pre><c>{
        ///   &quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;,
        ///   &quot;Parameters&quot;: {
        ///     &quot;Isp&quot;: {
        ///       &quot;Type&quot;: &quot;String&quot;,
        ///       &quot;Default&quot;: &quot;BGP&quot;
        ///     },
        ///     &quot;Name&quot;: {
        ///       &quot;Type&quot;: &quot;String&quot;,
        ///       &quot;Default&quot;: &quot;test&quot;
        ///     },
        ///     &quot;Netmode&quot;: {
        ///       &quot;Type&quot;: &quot;String&quot;,
        ///       &quot;Default&quot;: &quot;public&quot;
        ///     },
        ///     &quot;Bandwidth&quot;: {
        ///       &quot;Type&quot;: &quot;Number&quot;,
        ///       &quot;Default&quot;: 5
        ///     }
        ///   },
        ///   &quot;Resources&quot;: {
        ///     &quot;NewEip&quot;: {
        ///       &quot;Type&quot;: &quot;ALIYUN::VPC::EIP&quot;,
        ///       &quot;Properties&quot;: {
        ///         &quot;InstanceChargeType&quot;: &quot;Prepaid&quot;,
        ///         &quot;PricingCycle&quot;: &quot;Month&quot;,
        ///         &quot;Isp&quot;: {
        ///           &quot;Ref&quot;: &quot;Isp&quot;
        ///         },
        ///         &quot;Period&quot;: 1,
        ///         &quot;DeletionProtection&quot;: false,
        ///         &quot;AutoPay&quot;: false,
        ///         &quot;Name&quot;: {
        ///           &quot;Ref&quot;: &quot;Name&quot;
        ///         },
        ///         &quot;InternetChargeType&quot;: &quot;PayByTraffic&quot;,
        ///         &quot;Netmode&quot;: {
        ///           &quot;Ref&quot;: &quot;Netmode&quot;
        ///         },
        ///         &quot;Bandwidth&quot;: {
        ///           &quot;Ref&quot;: &quot;Bandwidth&quot;
        ///         }
        ///       }
        ///     }
        ///   }
        /// }
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTemplateEstimateCostRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateEstimateCostResponse
        /// </returns>
        public GetTemplateEstimateCostResponse GetTemplateEstimateCost(GetTemplateEstimateCostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateEstimateCostWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the estimated prices of the resources in a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <list type="bullet">
        /// <item><description>For more information about the resources that support price inquiry in Resource Orchestration Service (ROS) templates, see the &quot;<b>Resource types that support price inquiry</b>&quot; section of the <a href="https://help.aliyun.com/document_detail/203165.html">Estimate resource prices</a> topic.</description></item>
        /// <item><description>For more information about the resources that support price inquiry in Terraform templates, see the &quot;<b>ROS resources supported by Terraform</b>&quot; section of the <a href="https://help.aliyun.com/document_detail/184389.html">ROS features and resources supported by Terraform</a> topic.
        /// The following sample code provides an example on how to query the estimated price of an elastic IP address (EIP) that you want to create based on a template. In this example, the following template is used:</description></item>
        /// </list>
        /// <pre><c>{
        ///   &quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;,
        ///   &quot;Parameters&quot;: {
        ///     &quot;Isp&quot;: {
        ///       &quot;Type&quot;: &quot;String&quot;,
        ///       &quot;Default&quot;: &quot;BGP&quot;
        ///     },
        ///     &quot;Name&quot;: {
        ///       &quot;Type&quot;: &quot;String&quot;,
        ///       &quot;Default&quot;: &quot;test&quot;
        ///     },
        ///     &quot;Netmode&quot;: {
        ///       &quot;Type&quot;: &quot;String&quot;,
        ///       &quot;Default&quot;: &quot;public&quot;
        ///     },
        ///     &quot;Bandwidth&quot;: {
        ///       &quot;Type&quot;: &quot;Number&quot;,
        ///       &quot;Default&quot;: 5
        ///     }
        ///   },
        ///   &quot;Resources&quot;: {
        ///     &quot;NewEip&quot;: {
        ///       &quot;Type&quot;: &quot;ALIYUN::VPC::EIP&quot;,
        ///       &quot;Properties&quot;: {
        ///         &quot;InstanceChargeType&quot;: &quot;Prepaid&quot;,
        ///         &quot;PricingCycle&quot;: &quot;Month&quot;,
        ///         &quot;Isp&quot;: {
        ///           &quot;Ref&quot;: &quot;Isp&quot;
        ///         },
        ///         &quot;Period&quot;: 1,
        ///         &quot;DeletionProtection&quot;: false,
        ///         &quot;AutoPay&quot;: false,
        ///         &quot;Name&quot;: {
        ///           &quot;Ref&quot;: &quot;Name&quot;
        ///         },
        ///         &quot;InternetChargeType&quot;: &quot;PayByTraffic&quot;,
        ///         &quot;Netmode&quot;: {
        ///           &quot;Ref&quot;: &quot;Netmode&quot;
        ///         },
        ///         &quot;Bandwidth&quot;: {
        ///           &quot;Ref&quot;: &quot;Bandwidth&quot;
        ///         }
        ///       }
        ///     }
        ///   }
        /// }
        /// </c></pre>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTemplateEstimateCostRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateEstimateCostResponse
        /// </returns>
        public async Task<GetTemplateEstimateCostResponse> GetTemplateEstimateCostAsync(GetTemplateEstimateCostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateEstimateCostWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the valid values of the parameters in a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Description</h3>
        /// <para>This topic provides an example of how to query the valid values for the <c>ZoneInfo</c> parameter in a template specific to the China (Hangzhou) region. The template is <c>{ &quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;, &quot;Parameters&quot;: { &quot;ZoneInfo&quot;: { &quot;Type&quot;: &quot;String&quot; }, &quot;InstanceType&quot;: { &quot;Type&quot;: &quot;String&quot; } }, &quot;Resources&quot;: { &quot;ECS&quot;: { &quot;Type&quot;: &quot;ALIYUN::ECS::Instance&quot;, &quot;Properties&quot;: { &quot;ZoneId&quot;: { &quot;Ref&quot;: &quot;ZoneInfo&quot; }, &quot;InstanceType&quot;: { &quot;Ref&quot;: &quot;InstanceType&quot; } } } } }</c>.
        /// For more information about the queryable parameters and template content, refer to <a href="https://help.aliyun.com/document_detail/432820.html">Query parameter constraints</a>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GetTemplateParameterConstraintsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateParameterConstraintsResponse
        /// </returns>
        public GetTemplateParameterConstraintsResponse GetTemplateParameterConstraintsWithOptions(GetTemplateParameterConstraintsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetTemplateParameterConstraintsShrinkRequest request = new GetTemplateParameterConstraintsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ParametersKeyFilter))
            {
                request.ParametersKeyFilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ParametersKeyFilter, "ParametersKeyFilter", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ParametersOrder))
            {
                request.ParametersOrderShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ParametersOrder, "ParametersOrder", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersKeyFilterShrink))
            {
                query["ParametersKeyFilter"] = request.ParametersKeyFilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersOrderShrink))
            {
                query["ParametersOrder"] = request.ParametersOrderShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateParameterConstraints",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateParameterConstraintsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the valid values of the parameters in a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Description</h3>
        /// <para>This topic provides an example of how to query the valid values for the <c>ZoneInfo</c> parameter in a template specific to the China (Hangzhou) region. The template is <c>{ &quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;, &quot;Parameters&quot;: { &quot;ZoneInfo&quot;: { &quot;Type&quot;: &quot;String&quot; }, &quot;InstanceType&quot;: { &quot;Type&quot;: &quot;String&quot; } }, &quot;Resources&quot;: { &quot;ECS&quot;: { &quot;Type&quot;: &quot;ALIYUN::ECS::Instance&quot;, &quot;Properties&quot;: { &quot;ZoneId&quot;: { &quot;Ref&quot;: &quot;ZoneInfo&quot; }, &quot;InstanceType&quot;: { &quot;Ref&quot;: &quot;InstanceType&quot; } } } } }</c>.
        /// For more information about the queryable parameters and template content, refer to <a href="https://help.aliyun.com/document_detail/432820.html">Query parameter constraints</a>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GetTemplateParameterConstraintsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateParameterConstraintsResponse
        /// </returns>
        public async Task<GetTemplateParameterConstraintsResponse> GetTemplateParameterConstraintsWithOptionsAsync(GetTemplateParameterConstraintsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetTemplateParameterConstraintsShrinkRequest request = new GetTemplateParameterConstraintsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ParametersKeyFilter))
            {
                request.ParametersKeyFilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ParametersKeyFilter, "ParametersKeyFilter", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ParametersOrder))
            {
                request.ParametersOrderShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ParametersOrder, "ParametersOrder", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersKeyFilterShrink))
            {
                query["ParametersKeyFilter"] = request.ParametersKeyFilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersOrderShrink))
            {
                query["ParametersOrder"] = request.ParametersOrderShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateParameterConstraints",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateParameterConstraintsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the valid values of the parameters in a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Description</h3>
        /// <para>This topic provides an example of how to query the valid values for the <c>ZoneInfo</c> parameter in a template specific to the China (Hangzhou) region. The template is <c>{ &quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;, &quot;Parameters&quot;: { &quot;ZoneInfo&quot;: { &quot;Type&quot;: &quot;String&quot; }, &quot;InstanceType&quot;: { &quot;Type&quot;: &quot;String&quot; } }, &quot;Resources&quot;: { &quot;ECS&quot;: { &quot;Type&quot;: &quot;ALIYUN::ECS::Instance&quot;, &quot;Properties&quot;: { &quot;ZoneId&quot;: { &quot;Ref&quot;: &quot;ZoneInfo&quot; }, &quot;InstanceType&quot;: { &quot;Ref&quot;: &quot;InstanceType&quot; } } } } }</c>.
        /// For more information about the queryable parameters and template content, refer to <a href="https://help.aliyun.com/document_detail/432820.html">Query parameter constraints</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTemplateParameterConstraintsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateParameterConstraintsResponse
        /// </returns>
        public GetTemplateParameterConstraintsResponse GetTemplateParameterConstraints(GetTemplateParameterConstraintsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateParameterConstraintsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the valid values of the parameters in a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Description</h3>
        /// <para>This topic provides an example of how to query the valid values for the <c>ZoneInfo</c> parameter in a template specific to the China (Hangzhou) region. The template is <c>{ &quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;, &quot;Parameters&quot;: { &quot;ZoneInfo&quot;: { &quot;Type&quot;: &quot;String&quot; }, &quot;InstanceType&quot;: { &quot;Type&quot;: &quot;String&quot; } }, &quot;Resources&quot;: { &quot;ECS&quot;: { &quot;Type&quot;: &quot;ALIYUN::ECS::Instance&quot;, &quot;Properties&quot;: { &quot;ZoneId&quot;: { &quot;Ref&quot;: &quot;ZoneInfo&quot; }, &quot;InstanceType&quot;: { &quot;Ref&quot;: &quot;InstanceType&quot; } } } } }</c>.
        /// For more information about the queryable parameters and template content, refer to <a href="https://help.aliyun.com/document_detail/432820.html">Query parameter constraints</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTemplateParameterConstraintsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateParameterConstraintsResponse
        /// </returns>
        public async Task<GetTemplateParameterConstraintsResponse> GetTemplateParameterConstraintsAsync(GetTemplateParameterConstraintsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateParameterConstraintsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推荐参数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRecommendParametersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateRecommendParametersResponse
        /// </returns>
        public GetTemplateRecommendParametersResponse GetTemplateRecommendParametersWithOptions(GetTemplateRecommendParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                query["TemplateBody"] = request.TemplateBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateRecommendParameters",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateRecommendParametersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推荐参数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRecommendParametersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateRecommendParametersResponse
        /// </returns>
        public async Task<GetTemplateRecommendParametersResponse> GetTemplateRecommendParametersWithOptionsAsync(GetTemplateRecommendParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                query["TemplateBody"] = request.TemplateBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateRecommendParameters",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateRecommendParametersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推荐参数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRecommendParametersRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateRecommendParametersResponse
        /// </returns>
        public GetTemplateRecommendParametersResponse GetTemplateRecommendParameters(GetTemplateRecommendParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateRecommendParametersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推荐参数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRecommendParametersRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateRecommendParametersResponse
        /// </returns>
        public async Task<GetTemplateRecommendParametersResponse> GetTemplateRecommendParametersAsync(GetTemplateRecommendParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateRecommendParametersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a resource scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the details of the resource scenario <c>ts-7f7a704cf71c49a6****</c> in the China (Hangzhou) region and display source node data.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTemplateScratchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateScratchResponse
        /// </returns>
        public GetTemplateScratchResponse GetTemplateScratchWithOptions(GetTemplateScratchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDataOption))
            {
                query["ShowDataOption"] = request.ShowDataOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchId))
            {
                query["TemplateScratchId"] = request.TemplateScratchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateScratch",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateScratchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a resource scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the details of the resource scenario <c>ts-7f7a704cf71c49a6****</c> in the China (Hangzhou) region and display source node data.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTemplateScratchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateScratchResponse
        /// </returns>
        public async Task<GetTemplateScratchResponse> GetTemplateScratchWithOptionsAsync(GetTemplateScratchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDataOption))
            {
                query["ShowDataOption"] = request.ShowDataOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchId))
            {
                query["TemplateScratchId"] = request.TemplateScratchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateScratch",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateScratchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a resource scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the details of the resource scenario <c>ts-7f7a704cf71c49a6****</c> in the China (Hangzhou) region and display source node data.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTemplateScratchRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateScratchResponse
        /// </returns>
        public GetTemplateScratchResponse GetTemplateScratch(GetTemplateScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateScratchWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a resource scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the details of the resource scenario <c>ts-7f7a704cf71c49a6****</c> in the China (Hangzhou) region and display source node data.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTemplateScratchRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateScratchResponse
        /// </returns>
        public async Task<GetTemplateScratchResponse> GetTemplateScratchAsync(GetTemplateScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateScratchWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a template resource by using the relevant template, stack, stack group, or change set.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateSummaryResponse
        /// </returns>
        public GetTemplateSummaryResponse GetTemplateSummaryWithOptions(GetTemplateSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSetId))
            {
                query["ChangeSetId"] = request.ChangeSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                query["TemplateBody"] = request.TemplateBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateSummary",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a template resource by using the relevant template, stack, stack group, or change set.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateSummaryResponse
        /// </returns>
        public async Task<GetTemplateSummaryResponse> GetTemplateSummaryWithOptionsAsync(GetTemplateSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSetId))
            {
                query["ChangeSetId"] = request.ChangeSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                query["TemplateBody"] = request.TemplateBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateSummary",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a template resource by using the relevant template, stack, stack group, or change set.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateSummaryResponse
        /// </returns>
        public GetTemplateSummaryResponse GetTemplateSummary(GetTemplateSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateSummaryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a template resource by using the relevant template, stack, stack group, or change set.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateSummaryResponse
        /// </returns>
        public async Task<GetTemplateSummaryResponse> GetTemplateSummaryAsync(GetTemplateSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateSummaryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Import stacks from multiple different accounts into a stack group.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ImportStacksToStackGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportStacksToStackGroupResponse
        /// </returns>
        public ImportStacksToStackGroupResponse ImportStacksToStackGroupWithOptions(ImportStacksToStackGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportStacksToStackGroupShrinkRequest request = new ImportStacksToStackGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperationPreferences))
            {
                request.OperationPreferencesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperationPreferences, "OperationPreferences", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceDirectoryFolderIds))
            {
                request.ResourceDirectoryFolderIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceDirectoryFolderIds, "ResourceDirectoryFolderIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StackArns))
            {
                request.StackArnsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StackArns, "StackArns", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationDescription))
            {
                query["OperationDescription"] = request.OperationDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationPreferencesShrink))
            {
                query["OperationPreferences"] = request.OperationPreferencesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceDirectoryFolderIdsShrink))
            {
                query["ResourceDirectoryFolderIds"] = request.ResourceDirectoryFolderIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackArnsShrink))
            {
                query["StackArns"] = request.StackArnsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportStacksToStackGroup",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportStacksToStackGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Import stacks from multiple different accounts into a stack group.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ImportStacksToStackGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportStacksToStackGroupResponse
        /// </returns>
        public async Task<ImportStacksToStackGroupResponse> ImportStacksToStackGroupWithOptionsAsync(ImportStacksToStackGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportStacksToStackGroupShrinkRequest request = new ImportStacksToStackGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperationPreferences))
            {
                request.OperationPreferencesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperationPreferences, "OperationPreferences", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceDirectoryFolderIds))
            {
                request.ResourceDirectoryFolderIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceDirectoryFolderIds, "ResourceDirectoryFolderIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StackArns))
            {
                request.StackArnsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StackArns, "StackArns", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationDescription))
            {
                query["OperationDescription"] = request.OperationDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationPreferencesShrink))
            {
                query["OperationPreferences"] = request.OperationPreferencesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceDirectoryFolderIdsShrink))
            {
                query["ResourceDirectoryFolderIds"] = request.ResourceDirectoryFolderIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackArnsShrink))
            {
                query["StackArns"] = request.StackArnsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportStacksToStackGroup",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportStacksToStackGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Import stacks from multiple different accounts into a stack group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportStacksToStackGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportStacksToStackGroupResponse
        /// </returns>
        public ImportStacksToStackGroupResponse ImportStacksToStackGroup(ImportStacksToStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportStacksToStackGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Import stacks from multiple different accounts into a stack group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportStacksToStackGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportStacksToStackGroupResponse
        /// </returns>
        public async Task<ImportStacksToStackGroupResponse> ImportStacksToStackGroupAsync(ImportStacksToStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportStacksToStackGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the events of an AI task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAITaskEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAITaskEventsResponse
        /// </returns>
        public ListAITaskEventsResponse ListAITaskEventsWithOptions(ListAITaskEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAITaskEvents",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAITaskEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the events of an AI task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAITaskEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAITaskEventsResponse
        /// </returns>
        public async Task<ListAITaskEventsResponse> ListAITaskEventsWithOptionsAsync(ListAITaskEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAITaskEvents",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAITaskEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the events of an AI task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAITaskEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAITaskEventsResponse
        /// </returns>
        public ListAITaskEventsResponse ListAITaskEvents(ListAITaskEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAITaskEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the events of an AI task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAITaskEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAITaskEventsResponse
        /// </returns>
        public async Task<ListAITaskEventsResponse> ListAITaskEventsAsync(ListAITaskEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAITaskEventsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of AI tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAITasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAITasksResponse
        /// </returns>
        public ListAITasksResponse ListAITasksWithOptions(ListAITasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
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
                Action = "ListAITasks",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAITasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of AI tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAITasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAITasksResponse
        /// </returns>
        public async Task<ListAITasksResponse> ListAITasksWithOptionsAsync(ListAITasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
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
                Action = "ListAITasks",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAITasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of AI tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAITasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAITasksResponse
        /// </returns>
        public ListAITasksResponse ListAITasks(ListAITasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAITasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of AI tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAITasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAITasksResponse
        /// </returns>
        public async Task<ListAITasksResponse> ListAITasksAsync(ListAITasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAITasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of created change sets.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChangeSetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChangeSetsResponse
        /// </returns>
        public ListChangeSetsResponse ListChangeSetsWithOptions(ListChangeSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSetId))
            {
                query["ChangeSetId"] = request.ChangeSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSetName))
            {
                query["ChangeSetName"] = request.ChangeSetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionStatus))
            {
                query["ExecutionStatus"] = request.ExecutionStatus;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
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
                Action = "ListChangeSets",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChangeSetsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of created change sets.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChangeSetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChangeSetsResponse
        /// </returns>
        public async Task<ListChangeSetsResponse> ListChangeSetsWithOptionsAsync(ListChangeSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSetId))
            {
                query["ChangeSetId"] = request.ChangeSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSetName))
            {
                query["ChangeSetName"] = request.ChangeSetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionStatus))
            {
                query["ExecutionStatus"] = request.ExecutionStatus;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
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
                Action = "ListChangeSets",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChangeSetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of created change sets.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChangeSetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChangeSetsResponse
        /// </returns>
        public ListChangeSetsResponse ListChangeSets(ListChangeSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListChangeSetsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of created change sets.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChangeSetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChangeSetsResponse
        /// </returns>
        public async Task<ListChangeSetsResponse> ListChangeSetsAsync(ListChangeSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListChangeSetsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the message history and Pipeline snapshot temporary download URL for a specified session by session ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>When calling the V2 service, set the <c>AgentVersion</c> parameter to <c>V2</c>.</description></item>
        /// <item><description>This operation only accepts the <c>SessionId</c> of the current user\&quot;s session. It does not directly return a message array. Instead, it returns pre-signed download URLs for <c>session.jsonl</c> and <c>a2a-snapshot.json</c>.</description></item>
        /// <item><description>The download URLs are valid for 1800 seconds (30 minutes). Complete the download within the validity period.</description></item>
        /// <item><description>The URLs in the response contain signature parameters. Do not log, share, or cache them for extended periods.</description></item>
        /// <item><description><c>MaxResults</c> and <c>NextToken</c> are compatibility fields that are not consumed in V2.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListChatMessagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChatMessagesResponse
        /// </returns>
        public ListChatMessagesResponse ListChatMessagesWithOptions(ListChatMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                query["AgentVersion"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChatMessages",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChatMessagesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the message history and Pipeline snapshot temporary download URL for a specified session by session ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>When calling the V2 service, set the <c>AgentVersion</c> parameter to <c>V2</c>.</description></item>
        /// <item><description>This operation only accepts the <c>SessionId</c> of the current user\&quot;s session. It does not directly return a message array. Instead, it returns pre-signed download URLs for <c>session.jsonl</c> and <c>a2a-snapshot.json</c>.</description></item>
        /// <item><description>The download URLs are valid for 1800 seconds (30 minutes). Complete the download within the validity period.</description></item>
        /// <item><description>The URLs in the response contain signature parameters. Do not log, share, or cache them for extended periods.</description></item>
        /// <item><description><c>MaxResults</c> and <c>NextToken</c> are compatibility fields that are not consumed in V2.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListChatMessagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChatMessagesResponse
        /// </returns>
        public async Task<ListChatMessagesResponse> ListChatMessagesWithOptionsAsync(ListChatMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                query["AgentVersion"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChatMessages",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChatMessagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the message history and Pipeline snapshot temporary download URL for a specified session by session ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>When calling the V2 service, set the <c>AgentVersion</c> parameter to <c>V2</c>.</description></item>
        /// <item><description>This operation only accepts the <c>SessionId</c> of the current user\&quot;s session. It does not directly return a message array. Instead, it returns pre-signed download URLs for <c>session.jsonl</c> and <c>a2a-snapshot.json</c>.</description></item>
        /// <item><description>The download URLs are valid for 1800 seconds (30 minutes). Complete the download within the validity period.</description></item>
        /// <item><description>The URLs in the response contain signature parameters. Do not log, share, or cache them for extended periods.</description></item>
        /// <item><description><c>MaxResults</c> and <c>NextToken</c> are compatibility fields that are not consumed in V2.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListChatMessagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChatMessagesResponse
        /// </returns>
        public ListChatMessagesResponse ListChatMessages(ListChatMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListChatMessagesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the message history and Pipeline snapshot temporary download URL for a specified session by session ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>When calling the V2 service, set the <c>AgentVersion</c> parameter to <c>V2</c>.</description></item>
        /// <item><description>This operation only accepts the <c>SessionId</c> of the current user\&quot;s session. It does not directly return a message array. Instead, it returns pre-signed download URLs for <c>session.jsonl</c> and <c>a2a-snapshot.json</c>.</description></item>
        /// <item><description>The download URLs are valid for 1800 seconds (30 minutes). Complete the download within the validity period.</description></item>
        /// <item><description>The URLs in the response contain signature parameters. Do not log, share, or cache them for extended periods.</description></item>
        /// <item><description><c>MaxResults</c> and <c>NextToken</c> are compatibility fields that are not consumed in V2.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListChatMessagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChatMessagesResponse
        /// </returns>
        public async Task<ListChatMessagesResponse> ListChatMessagesAsync(ListChatMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListChatMessagesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ROS Agent V2 session list of the current user by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>Set <c>AgentVersion</c> to <c>V2</c> when calling the V2 service.</description></item>
        /// <item><description>This operation returns only sessions of the current user, sorted by <c>UpdatedAt</c> in descending order by default.</description></item>
        /// <item><description>Use the <c>Mode</c> parameter to filter sessions by mode. Valid values: <c>IaCCodeNormal</c> and <c>IaCCodePipeline</c>.</description></item>
        /// <item><description>Do not reuse an old <c>NextToken</c> after switching <c>Mode</c>.</description></item>
        /// <item><description>Use the <c>CreatedAt</c> and <c>UpdatedAt</c> fields for time information. The <c>UpdatedTime</c> field in the metadata is a compatibility field and is not returned in the current response.</description></item>
        /// <item><description>Set the <c>MaxResults</c> request parameter to specify the number of entries per page. Valid values: 1 to 100.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListChatSessionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChatSessionsResponse
        /// </returns>
        public ListChatSessionsResponse ListChatSessionsWithOptions(ListChatSessionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                query["AgentVersion"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChatSessions",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChatSessionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ROS Agent V2 session list of the current user by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>Set <c>AgentVersion</c> to <c>V2</c> when calling the V2 service.</description></item>
        /// <item><description>This operation returns only sessions of the current user, sorted by <c>UpdatedAt</c> in descending order by default.</description></item>
        /// <item><description>Use the <c>Mode</c> parameter to filter sessions by mode. Valid values: <c>IaCCodeNormal</c> and <c>IaCCodePipeline</c>.</description></item>
        /// <item><description>Do not reuse an old <c>NextToken</c> after switching <c>Mode</c>.</description></item>
        /// <item><description>Use the <c>CreatedAt</c> and <c>UpdatedAt</c> fields for time information. The <c>UpdatedTime</c> field in the metadata is a compatibility field and is not returned in the current response.</description></item>
        /// <item><description>Set the <c>MaxResults</c> request parameter to specify the number of entries per page. Valid values: 1 to 100.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListChatSessionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChatSessionsResponse
        /// </returns>
        public async Task<ListChatSessionsResponse> ListChatSessionsWithOptionsAsync(ListChatSessionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                query["AgentVersion"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChatSessions",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChatSessionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ROS Agent V2 session list of the current user by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>Set <c>AgentVersion</c> to <c>V2</c> when calling the V2 service.</description></item>
        /// <item><description>This operation returns only sessions of the current user, sorted by <c>UpdatedAt</c> in descending order by default.</description></item>
        /// <item><description>Use the <c>Mode</c> parameter to filter sessions by mode. Valid values: <c>IaCCodeNormal</c> and <c>IaCCodePipeline</c>.</description></item>
        /// <item><description>Do not reuse an old <c>NextToken</c> after switching <c>Mode</c>.</description></item>
        /// <item><description>Use the <c>CreatedAt</c> and <c>UpdatedAt</c> fields for time information. The <c>UpdatedTime</c> field in the metadata is a compatibility field and is not returned in the current response.</description></item>
        /// <item><description>Set the <c>MaxResults</c> request parameter to specify the number of entries per page. Valid values: 1 to 100.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListChatSessionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChatSessionsResponse
        /// </returns>
        public ListChatSessionsResponse ListChatSessions(ListChatSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListChatSessionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ROS Agent V2 session list of the current user by paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>Set <c>AgentVersion</c> to <c>V2</c> when calling the V2 service.</description></item>
        /// <item><description>This operation returns only sessions of the current user, sorted by <c>UpdatedAt</c> in descending order by default.</description></item>
        /// <item><description>Use the <c>Mode</c> parameter to filter sessions by mode. Valid values: <c>IaCCodeNormal</c> and <c>IaCCodePipeline</c>.</description></item>
        /// <item><description>Do not reuse an old <c>NextToken</c> after switching <c>Mode</c>.</description></item>
        /// <item><description>Use the <c>CreatedAt</c> and <c>UpdatedAt</c> fields for time information. The <c>UpdatedTime</c> field in the metadata is a compatibility field and is not returned in the current response.</description></item>
        /// <item><description>Set the <c>MaxResults</c> request parameter to specify the number of entries per page. Valid values: 1 to 100.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListChatSessionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChatSessionsResponse
        /// </returns>
        public async Task<ListChatSessionsResponse> ListChatSessionsAsync(ListChatSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListChatSessionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a diagnostic report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDiagnosticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDiagnosticsResponse
        /// </returns>
        public ListDiagnosticsResponse ListDiagnosticsWithOptions(ListDiagnosticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiagnosticKey))
            {
                query["DiagnosticKey"] = request.DiagnosticKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiagnosticProduct))
            {
                query["DiagnosticProduct"] = request.DiagnosticProduct;
            }
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDiagnostics",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDiagnosticsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a diagnostic report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDiagnosticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDiagnosticsResponse
        /// </returns>
        public async Task<ListDiagnosticsResponse> ListDiagnosticsWithOptionsAsync(ListDiagnosticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiagnosticKey))
            {
                query["DiagnosticKey"] = request.DiagnosticKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiagnosticProduct))
            {
                query["DiagnosticProduct"] = request.DiagnosticProduct;
            }
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDiagnostics",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDiagnosticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a diagnostic report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDiagnosticsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDiagnosticsResponse
        /// </returns>
        public ListDiagnosticsResponse ListDiagnostics(ListDiagnosticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDiagnosticsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a diagnostic report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDiagnosticsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDiagnosticsResponse
        /// </returns>
        public async Task<ListDiagnosticsResponse> ListDiagnosticsAsync(ListDiagnosticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDiagnosticsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of resource registration records.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceTypeRegistrationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTypeRegistrationsResponse
        /// </returns>
        public ListResourceTypeRegistrationsResponse ListResourceTypeRegistrationsWithOptions(ListResourceTypeRegistrationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrationId))
            {
                query["RegistrationId"] = request.RegistrationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
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
                Action = "ListResourceTypeRegistrations",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceTypeRegistrationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of resource registration records.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceTypeRegistrationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTypeRegistrationsResponse
        /// </returns>
        public async Task<ListResourceTypeRegistrationsResponse> ListResourceTypeRegistrationsWithOptionsAsync(ListResourceTypeRegistrationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrationId))
            {
                query["RegistrationId"] = request.RegistrationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
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
                Action = "ListResourceTypeRegistrations",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceTypeRegistrationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of resource registration records.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceTypeRegistrationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTypeRegistrationsResponse
        /// </returns>
        public ListResourceTypeRegistrationsResponse ListResourceTypeRegistrations(ListResourceTypeRegistrationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceTypeRegistrationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of resource registration records.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceTypeRegistrationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTypeRegistrationsResponse
        /// </returns>
        public async Task<ListResourceTypeRegistrationsResponse> ListResourceTypeRegistrationsAsync(ListResourceTypeRegistrationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceTypeRegistrationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of resource type versions, including resource types created by the user and those provided by Resource Orchestration Service (ROS).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceTypeVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTypeVersionsResponse
        /// </returns>
        public ListResourceTypeVersionsResponse ListResourceTypeVersionsWithOptions(ListResourceTypeVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceTypeVersions",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceTypeVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of resource type versions, including resource types created by the user and those provided by Resource Orchestration Service (ROS).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceTypeVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTypeVersionsResponse
        /// </returns>
        public async Task<ListResourceTypeVersionsResponse> ListResourceTypeVersionsWithOptionsAsync(ListResourceTypeVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceTypeVersions",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceTypeVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of resource type versions, including resource types created by the user and those provided by Resource Orchestration Service (ROS).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceTypeVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTypeVersionsResponse
        /// </returns>
        public ListResourceTypeVersionsResponse ListResourceTypeVersions(ListResourceTypeVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceTypeVersionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of resource type versions, including resource types created by the user and those provided by Resource Orchestration Service (ROS).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceTypeVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTypeVersionsResponse
        /// </returns>
        public async Task<ListResourceTypeVersionsResponse> ListResourceTypeVersionsAsync(ListResourceTypeVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceTypeVersionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of supported resource types.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the list of regular resource types supported by ROS.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceTypesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTypesResponse
        /// </returns>
        public ListResourceTypesResponse ListResourceTypesWithOptions(ListResourceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["Provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceTypes",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceTypesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of supported resource types.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the list of regular resource types supported by ROS.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceTypesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTypesResponse
        /// </returns>
        public async Task<ListResourceTypesResponse> ListResourceTypesWithOptionsAsync(ListResourceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["Provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceTypes",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceTypesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of supported resource types.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the list of regular resource types supported by ROS.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceTypesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTypesResponse
        /// </returns>
        public ListResourceTypesResponse ListResourceTypes(ListResourceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceTypesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of supported resource types.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the list of regular resource types supported by ROS.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceTypesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTypesResponse
        /// </returns>
        public async Task<ListResourceTypesResponse> ListResourceTypesAsync(ListResourceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceTypesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries events of a stack and the resources in the stack.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStackEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStackEventsResponse
        /// </returns>
        public ListStackEventsResponse ListStackEventsWithOptions(ListStackEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalResourceId))
            {
                query["LogicalResourceId"] = request.LogicalResourceId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
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
                Action = "ListStackEvents",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStackEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries events of a stack and the resources in the stack.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStackEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStackEventsResponse
        /// </returns>
        public async Task<ListStackEventsResponse> ListStackEventsWithOptionsAsync(ListStackEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalResourceId))
            {
                query["LogicalResourceId"] = request.LogicalResourceId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
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
                Action = "ListStackEvents",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStackEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries events of a stack and the resources in the stack.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStackEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStackEventsResponse
        /// </returns>
        public ListStackEventsResponse ListStackEvents(ListStackEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStackEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries events of a stack and the resources in the stack.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStackEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStackEventsResponse
        /// </returns>
        public async Task<ListStackEventsResponse> ListStackEventsAsync(ListStackEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStackEventsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of an operation on a stack group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the operation ID <c>6da106ca-1784-4a6f-a7e1-e723863d∗∗∗∗</c> is set to query the results of an operation on a stack group named <c>MyStackGroup</c>. The stack group is granted self-managed permissions and created in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStackGroupOperationResultsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStackGroupOperationResultsResponse
        /// </returns>
        public ListStackGroupOperationResultsResponse ListStackGroupOperationResultsWithOptions(ListStackGroupOperationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationId))
            {
                query["OperationId"] = request.OperationId;
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
                Action = "ListStackGroupOperationResults",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStackGroupOperationResultsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of an operation on a stack group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the operation ID <c>6da106ca-1784-4a6f-a7e1-e723863d∗∗∗∗</c> is set to query the results of an operation on a stack group named <c>MyStackGroup</c>. The stack group is granted self-managed permissions and created in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStackGroupOperationResultsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStackGroupOperationResultsResponse
        /// </returns>
        public async Task<ListStackGroupOperationResultsResponse> ListStackGroupOperationResultsWithOptionsAsync(ListStackGroupOperationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationId))
            {
                query["OperationId"] = request.OperationId;
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
                Action = "ListStackGroupOperationResults",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStackGroupOperationResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of an operation on a stack group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the operation ID <c>6da106ca-1784-4a6f-a7e1-e723863d∗∗∗∗</c> is set to query the results of an operation on a stack group named <c>MyStackGroup</c>. The stack group is granted self-managed permissions and created in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStackGroupOperationResultsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStackGroupOperationResultsResponse
        /// </returns>
        public ListStackGroupOperationResultsResponse ListStackGroupOperationResults(ListStackGroupOperationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStackGroupOperationResultsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of an operation on a stack group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the operation ID <c>6da106ca-1784-4a6f-a7e1-e723863d∗∗∗∗</c> is set to query the results of an operation on a stack group named <c>MyStackGroup</c>. The stack group is granted self-managed permissions and created in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStackGroupOperationResultsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStackGroupOperationResultsResponse
        /// </returns>
        public async Task<ListStackGroupOperationResultsResponse> ListStackGroupOperationResultsAsync(ListStackGroupOperationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStackGroupOperationResultsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about stack group operations in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStackGroupOperationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStackGroupOperationsResponse
        /// </returns>
        public ListStackGroupOperationsResponse ListStackGroupOperationsWithOptions(ListStackGroupOperationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStackGroupOperations",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStackGroupOperationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about stack group operations in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStackGroupOperationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStackGroupOperationsResponse
        /// </returns>
        public async Task<ListStackGroupOperationsResponse> ListStackGroupOperationsWithOptionsAsync(ListStackGroupOperationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStackGroupOperations",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStackGroupOperationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about stack group operations in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStackGroupOperationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStackGroupOperationsResponse
        /// </returns>
        public ListStackGroupOperationsResponse ListStackGroupOperations(ListStackGroupOperationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStackGroupOperationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about stack group operations in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStackGroupOperationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStackGroupOperationsResponse
        /// </returns>
        public async Task<ListStackGroupOperationsResponse> ListStackGroupOperationsAsync(ListStackGroupOperationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStackGroupOperationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries stack groups in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This example queries stack groups in the ACTIVE state in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStackGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStackGroupsResponse
        /// </returns>
        public ListStackGroupsResponse ListStackGroupsWithOptions(ListStackGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStackGroups",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStackGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries stack groups in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This example queries stack groups in the ACTIVE state in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStackGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStackGroupsResponse
        /// </returns>
        public async Task<ListStackGroupsResponse> ListStackGroupsWithOptionsAsync(ListStackGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStackGroups",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStackGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries stack groups in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This example queries stack groups in the ACTIVE state in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStackGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStackGroupsResponse
        /// </returns>
        public ListStackGroupsResponse ListStackGroups(ListStackGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStackGroupsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries stack groups in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This example queries stack groups in the ACTIVE state in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStackGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStackGroupsResponse
        /// </returns>
        public async Task<ListStackGroupsResponse> ListStackGroupsAsync(ListStackGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStackGroupsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of stack instances that are associated with a stack group in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the list of stack instances that are associated with a stack group named <c>MyStackGroup</c> is queried. The stack group is granted self-managed permissions and deployed in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStackInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStackInstancesResponse
        /// </returns>
        public ListStackInstancesResponse ListStackInstancesWithOptions(ListStackInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackInstanceAccountId))
            {
                query["StackInstanceAccountId"] = request.StackInstanceAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackInstanceRegionId))
            {
                query["StackInstanceRegionId"] = request.StackInstanceRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStackInstances",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStackInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of stack instances that are associated with a stack group in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the list of stack instances that are associated with a stack group named <c>MyStackGroup</c> is queried. The stack group is granted self-managed permissions and deployed in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStackInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStackInstancesResponse
        /// </returns>
        public async Task<ListStackInstancesResponse> ListStackInstancesWithOptionsAsync(ListStackInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackInstanceAccountId))
            {
                query["StackInstanceAccountId"] = request.StackInstanceAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackInstanceRegionId))
            {
                query["StackInstanceRegionId"] = request.StackInstanceRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStackInstances",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStackInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of stack instances that are associated with a stack group in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the list of stack instances that are associated with a stack group named <c>MyStackGroup</c> is queried. The stack group is granted self-managed permissions and deployed in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStackInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStackInstancesResponse
        /// </returns>
        public ListStackInstancesResponse ListStackInstances(ListStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStackInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of stack instances that are associated with a stack group in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the list of stack instances that are associated with a stack group named <c>MyStackGroup</c> is queried. The stack group is granted self-managed permissions and deployed in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStackInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStackInstancesResponse
        /// </returns>
        public async Task<ListStackInstancesResponse> ListStackInstancesAsync(ListStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStackInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detects stack-related operation risks and returns missing permissions and the causes of the risks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The ListStackOperationRisks operation is suitable for the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>You want to detect high risks that may arise in resources when you delete a stack that contains the resources, and query the cause of each risk in a resource.</description></item>
        /// <item><description>When you create a stack, the creation may fail. In this case, you can call this operation to check which types of permissions that are required to create stacks are missing.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStackOperationRisksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStackOperationRisksResponse
        /// </returns>
        public ListStackOperationRisksResponse ListStackOperationRisksWithOptions(ListStackOperationRisksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                query["OperationType"] = request.OperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                query["RamRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainAllResources))
            {
                query["RetainAllResources"] = request.RetainAllResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainResources))
            {
                query["RetainResources"] = request.RetainResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStackOperationRisks",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStackOperationRisksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detects stack-related operation risks and returns missing permissions and the causes of the risks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The ListStackOperationRisks operation is suitable for the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>You want to detect high risks that may arise in resources when you delete a stack that contains the resources, and query the cause of each risk in a resource.</description></item>
        /// <item><description>When you create a stack, the creation may fail. In this case, you can call this operation to check which types of permissions that are required to create stacks are missing.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStackOperationRisksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStackOperationRisksResponse
        /// </returns>
        public async Task<ListStackOperationRisksResponse> ListStackOperationRisksWithOptionsAsync(ListStackOperationRisksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                query["OperationType"] = request.OperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                query["RamRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainAllResources))
            {
                query["RetainAllResources"] = request.RetainAllResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainResources))
            {
                query["RetainResources"] = request.RetainResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStackOperationRisks",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStackOperationRisksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detects stack-related operation risks and returns missing permissions and the causes of the risks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The ListStackOperationRisks operation is suitable for the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>You want to detect high risks that may arise in resources when you delete a stack that contains the resources, and query the cause of each risk in a resource.</description></item>
        /// <item><description>When you create a stack, the creation may fail. In this case, you can call this operation to check which types of permissions that are required to create stacks are missing.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStackOperationRisksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStackOperationRisksResponse
        /// </returns>
        public ListStackOperationRisksResponse ListStackOperationRisks(ListStackOperationRisksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStackOperationRisksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detects stack-related operation risks and returns missing permissions and the causes of the risks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The ListStackOperationRisks operation is suitable for the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>You want to detect high risks that may arise in resources when you delete a stack that contains the resources, and query the cause of each risk in a resource.</description></item>
        /// <item><description>When you create a stack, the creation may fail. In this case, you can call this operation to check which types of permissions that are required to create stacks are missing.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStackOperationRisksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStackOperationRisksResponse
        /// </returns>
        public async Task<ListStackOperationRisksResponse> ListStackOperationRisksAsync(ListStackOperationRisksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStackOperationRisksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The query token. Set this parameter to the NextToken value returned in the last API call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStackResourceDriftsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStackResourceDriftsResponse
        /// </returns>
        public ListStackResourceDriftsResponse ListStackResourceDriftsWithOptions(ListStackResourceDriftsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceDriftStatus))
            {
                query["ResourceDriftStatus"] = request.ResourceDriftStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStackResourceDrifts",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStackResourceDriftsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The query token. Set this parameter to the NextToken value returned in the last API call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStackResourceDriftsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStackResourceDriftsResponse
        /// </returns>
        public async Task<ListStackResourceDriftsResponse> ListStackResourceDriftsWithOptionsAsync(ListStackResourceDriftsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceDriftStatus))
            {
                query["ResourceDriftStatus"] = request.ResourceDriftStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStackResourceDrifts",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStackResourceDriftsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The query token. Set this parameter to the NextToken value returned in the last API call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStackResourceDriftsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStackResourceDriftsResponse
        /// </returns>
        public ListStackResourceDriftsResponse ListStackResourceDrifts(ListStackResourceDriftsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStackResourceDriftsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The query token. Set this parameter to the NextToken value returned in the last API call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStackResourceDriftsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStackResourceDriftsResponse
        /// </returns>
        public async Task<ListStackResourceDriftsResponse> ListStackResourceDriftsAsync(ListStackResourceDriftsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStackResourceDriftsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resources in a specified stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the resources in a stack whose ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStackResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStackResourcesResponse
        /// </returns>
        public ListStackResourcesResponse ListStackResourcesWithOptions(ListStackResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStackResources",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStackResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resources in a specified stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the resources in a stack whose ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStackResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStackResourcesResponse
        /// </returns>
        public async Task<ListStackResourcesResponse> ListStackResourcesWithOptionsAsync(ListStackResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStackResources",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStackResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resources in a specified stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the resources in a stack whose ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStackResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStackResourcesResponse
        /// </returns>
        public ListStackResourcesResponse ListStackResources(ListStackResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStackResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resources in a specified stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the resources in a stack whose ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStackResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStackResourcesResponse
        /// </returns>
        public async Task<ListStackResourcesResponse> ListStackResourcesAsync(ListStackResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStackResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of stacks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Operation description</h3>
        /// <para>This topic provides an example of how to query the list of stacks in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStacksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStacksResponse
        /// </returns>
        public ListStacksResponse ListStacksWithOptions(ListStacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentStackId))
            {
                query["ParentStackId"] = request.ParentStackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowNestedStack))
            {
                query["ShowNestedStack"] = request.ShowNestedStack;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackIds))
            {
                query["StackIds"] = request.StackIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackName))
            {
                query["StackName"] = request.StackName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStacks",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStacksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of stacks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Operation description</h3>
        /// <para>This topic provides an example of how to query the list of stacks in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStacksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStacksResponse
        /// </returns>
        public async Task<ListStacksResponse> ListStacksWithOptionsAsync(ListStacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentStackId))
            {
                query["ParentStackId"] = request.ParentStackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowNestedStack))
            {
                query["ShowNestedStack"] = request.ShowNestedStack;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackIds))
            {
                query["StackIds"] = request.StackIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackName))
            {
                query["StackName"] = request.StackName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStacks",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStacksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of stacks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Operation description</h3>
        /// <para>This topic provides an example of how to query the list of stacks in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStacksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStacksResponse
        /// </returns>
        public ListStacksResponse ListStacks(ListStacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStacksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of stacks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Operation description</h3>
        /// <para>This topic provides an example of how to query the list of stacks in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListStacksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStacksResponse
        /// </returns>
        public async Task<ListStacksResponse> ListStacksAsync(ListStacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStacksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries for an overview.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Usage notes</h3>
        /// <para>This topic provides an example of how to query a list of stacks in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSummariesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSummariesResponse
        /// </returns>
        public ListSummariesResponse ListSummariesWithOptions(ListSummariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                query["Option"] = request.Option;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSummaries",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSummariesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries for an overview.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Usage notes</h3>
        /// <para>This topic provides an example of how to query a list of stacks in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSummariesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSummariesResponse
        /// </returns>
        public async Task<ListSummariesResponse> ListSummariesWithOptionsAsync(ListSummariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                query["Option"] = request.Option;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSummaries",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSummariesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries for an overview.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Usage notes</h3>
        /// <para>This topic provides an example of how to query a list of stacks in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSummariesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSummariesResponse
        /// </returns>
        public ListSummariesResponse ListSummaries(ListSummariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSummariesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries for an overview.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Usage notes</h3>
        /// <para>This topic provides an example of how to query a list of stacks in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSummariesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSummariesResponse
        /// </returns>
        public async Task<ListSummariesResponse> ListSummariesAsync(ListSummariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSummariesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag keys for stacks or templates in a specified region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the tag keys that are attached to a stack in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagKeysResponse
        /// </returns>
        public ListTagKeysResponse ListTagKeysWithOptions(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagKeys",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagKeysResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag keys for stacks or templates in a specified region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the tag keys that are attached to a stack in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagKeysResponse
        /// </returns>
        public async Task<ListTagKeysResponse> ListTagKeysWithOptionsAsync(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagKeys",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag keys for stacks or templates in a specified region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the tag keys that are attached to a stack in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagKeysResponse
        /// </returns>
        public ListTagKeysResponse ListTagKeys(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagKeysWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag keys for stacks or templates in a specified region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the tag keys that are attached to a stack in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagKeysResponse
        /// </returns>
        public async Task<ListTagKeysResponse> ListTagKeysAsync(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagKeysWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to resources in a template or stack in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <list type="bullet">
        /// <item><description>To specify the query object, specify ResourceId or Tag in the request. Tag consists of Key and Value.</description></item>
        /// <item><description>If you specify Tag and ResourceId, ROS resources that match both the parameters are returned.
        /// This topic provides an example on how to query the tags that are added to a stack. In this example, the stack ID is <c>6bc589b5-9c02-4944-8fc3-f3624234****</c>. The stack is deployed in the China (Hangzhou) region.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to resources in a template or stack in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <list type="bullet">
        /// <item><description>To specify the query object, specify ResourceId or Tag in the request. Tag consists of Key and Value.</description></item>
        /// <item><description>If you specify Tag and ResourceId, ROS resources that match both the parameters are returned.
        /// This topic provides an example on how to query the tags that are added to a stack. In this example, the stack ID is <c>6bc589b5-9c02-4944-8fc3-f3624234****</c>. The stack is deployed in the China (Hangzhou) region.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to resources in a template or stack in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <list type="bullet">
        /// <item><description>To specify the query object, specify ResourceId or Tag in the request. Tag consists of Key and Value.</description></item>
        /// <item><description>If you specify Tag and ResourceId, ROS resources that match both the parameters are returned.
        /// This topic provides an example on how to query the tags that are added to a stack. In this example, the stack ID is <c>6bc589b5-9c02-4944-8fc3-f3624234****</c>. The stack is deployed in the China (Hangzhou) region.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to resources in a template or stack in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3></h3>
        /// <list type="bullet">
        /// <item><description>To specify the query object, specify ResourceId or Tag in the request. Tag consists of Key and Value.</description></item>
        /// <item><description>If you specify Tag and ResourceId, ROS resources that match both the parameters are returned.
        /// This topic provides an example on how to query the tags that are added to a stack. In this example, the stack ID is <c>6bc589b5-9c02-4944-8fc3-f3624234****</c>. The stack is deployed in the China (Hangzhou) region.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag values that are added to resources in a template or stack in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the tag values of <c>TagKey1</c> that is added to a stack in the China (Hangzhou) region are queried.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagValuesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagValuesResponse
        /// </returns>
        public ListTagValuesResponse ListTagValuesWithOptions(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagValues",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagValuesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag values that are added to resources in a template or stack in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the tag values of <c>TagKey1</c> that is added to a stack in the China (Hangzhou) region are queried.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagValuesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagValuesResponse
        /// </returns>
        public async Task<ListTagValuesResponse> ListTagValuesWithOptionsAsync(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagValues",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagValuesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag values that are added to resources in a template or stack in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the tag values of <c>TagKey1</c> that is added to a stack in the China (Hangzhou) region are queried.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagValuesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagValuesResponse
        /// </returns>
        public ListTagValuesResponse ListTagValues(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagValuesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag values that are added to resources in a template or stack in an Alibaba Cloud region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the tag values of <c>TagKey1</c> that is added to a stack in the China (Hangzhou) region are queried.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagValuesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagValuesResponse
        /// </returns>
        public async Task<ListTagValuesResponse> ListTagValuesAsync(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagValuesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of resource scenarios.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the list of resource scenarios in the China (Hangzhou) region. The response shows that there are two resource scenarios in the China (Hangzhou) region: resource management and resource replication.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTemplateScratchesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateScratchesResponse
        /// </returns>
        public ListTemplateScratchesResponse ListTemplateScratchesWithOptions(ListTemplateScratchesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchId))
            {
                query["TemplateScratchId"] = request.TemplateScratchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchType))
            {
                query["TemplateScratchType"] = request.TemplateScratchType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplateScratches",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplateScratchesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of resource scenarios.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the list of resource scenarios in the China (Hangzhou) region. The response shows that there are two resource scenarios in the China (Hangzhou) region: resource management and resource replication.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTemplateScratchesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateScratchesResponse
        /// </returns>
        public async Task<ListTemplateScratchesResponse> ListTemplateScratchesWithOptionsAsync(ListTemplateScratchesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchId))
            {
                query["TemplateScratchId"] = request.TemplateScratchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchType))
            {
                query["TemplateScratchType"] = request.TemplateScratchType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplateScratches",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplateScratchesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of resource scenarios.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the list of resource scenarios in the China (Hangzhou) region. The response shows that there are two resource scenarios in the China (Hangzhou) region: resource management and resource replication.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTemplateScratchesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateScratchesResponse
        /// </returns>
        public ListTemplateScratchesResponse ListTemplateScratches(ListTemplateScratchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTemplateScratchesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of resource scenarios.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to query the list of resource scenarios in the China (Hangzhou) region. The response shows that there are two resource scenarios in the China (Hangzhou) region: resource management and resource replication.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTemplateScratchesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateScratchesResponse
        /// </returns>
        public async Task<ListTemplateScratchesResponse> ListTemplateScratchesAsync(ListTemplateScratchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTemplateScratchesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of versions of a template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateVersionsResponse
        /// </returns>
        public ListTemplateVersionsResponse ListTemplateVersionsWithOptions(ListTemplateVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListTemplateVersions",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplateVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of versions of a template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateVersionsResponse
        /// </returns>
        public async Task<ListTemplateVersionsResponse> ListTemplateVersionsWithOptionsAsync(ListTemplateVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListTemplateVersions",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplateVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of versions of a template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateVersionsResponse
        /// </returns>
        public ListTemplateVersionsResponse ListTemplateVersions(ListTemplateVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTemplateVersionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of versions of a template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateVersionsResponse
        /// </returns>
        public async Task<ListTemplateVersionsResponse> ListTemplateVersionsAsync(ListTemplateVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTemplateVersionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of private and shared templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public ListTemplatesResponse ListTemplatesWithOptions(ListTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeTags))
            {
                query["IncludeTags"] = request.IncludeTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareType))
            {
                query["ShareType"] = request.ShareType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
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
                Action = "ListTemplates",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of private and shared templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public async Task<ListTemplatesResponse> ListTemplatesWithOptionsAsync(ListTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeTags))
            {
                query["IncludeTags"] = request.IncludeTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareType))
            {
                query["ShareType"] = request.ShareType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
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
                Action = "ListTemplates",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of private and shared templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of private and shared templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public async Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Moves a resource to a specific resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, a stack deployed in the <c>China (Hangzhou)</c> region is moved to a specific resource group. The ID of the stack is <c>4e8611cb-251e-42b7-b9cb-3496362c****</c> and the ID of the resource group is <c>rg-acfm3peow3k****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MoveResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceGroupResponse
        /// </returns>
        public MoveResourceGroupResponse MoveResourceGroupWithOptions(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveResourceGroup",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Moves a resource to a specific resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, a stack deployed in the <c>China (Hangzhou)</c> region is moved to a specific resource group. The ID of the stack is <c>4e8611cb-251e-42b7-b9cb-3496362c****</c> and the ID of the resource group is <c>rg-acfm3peow3k****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MoveResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceGroupResponse
        /// </returns>
        public async Task<MoveResourceGroupResponse> MoveResourceGroupWithOptionsAsync(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveResourceGroup",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Moves a resource to a specific resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, a stack deployed in the <c>China (Hangzhou)</c> region is moved to a specific resource group. The ID of the stack is <c>4e8611cb-251e-42b7-b9cb-3496362c****</c> and the ID of the resource group is <c>rg-acfm3peow3k****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MoveResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceGroupResponse
        /// </returns>
        public MoveResourceGroupResponse MoveResourceGroup(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveResourceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Moves a resource to a specific resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, a stack deployed in the <c>China (Hangzhou)</c> region is moved to a specific resource group. The ID of the stack is <c>4e8611cb-251e-42b7-b9cb-3496362c****</c> and the ID of the resource group is <c>rg-acfm3peow3k****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MoveResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceGroupResponse
        /// </returns>
        public async Task<MoveResourceGroupResponse> MoveResourceGroupAsync(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveResourceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Previews the information about a stack that you want to create or update based on a template. You can call this operation to verify whether the template resources are valid.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, a stack named <c>MyStack</c> is created in the China (Hangzhou) region and previewed. The <c>TemplateBody</c> parameter of the stack is set to <c>{&quot;ROSTemplateFormatVersion&quot;:&quot;2015-09-01&quot;}</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PreviewStackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreviewStackResponse
        /// </returns>
        public PreviewStackResponse PreviewStackWithOptions(PreviewStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableRollback))
            {
                query["DisableRollback"] = request.DisableRollback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePreConfig))
            {
                query["EnablePreConfig"] = request.EnablePreConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parallelism))
            {
                query["Parallelism"] = request.Parallelism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackName))
            {
                query["StackName"] = request.StackName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyBody))
            {
                query["StackPolicyBody"] = request.StackPolicyBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyURL))
            {
                query["StackPolicyURL"] = request.StackPolicyURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaintResources))
            {
                query["TaintResources"] = request.TaintResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchId))
            {
                query["TemplateScratchId"] = request.TemplateScratchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchRegionId))
            {
                query["TemplateScratchRegionId"] = request.TemplateScratchRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutInMinutes))
            {
                query["TimeoutInMinutes"] = request.TimeoutInMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePreviousParameters))
            {
                query["UsePreviousParameters"] = request.UsePreviousParameters;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreviewStack",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreviewStackResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Previews the information about a stack that you want to create or update based on a template. You can call this operation to verify whether the template resources are valid.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, a stack named <c>MyStack</c> is created in the China (Hangzhou) region and previewed. The <c>TemplateBody</c> parameter of the stack is set to <c>{&quot;ROSTemplateFormatVersion&quot;:&quot;2015-09-01&quot;}</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PreviewStackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreviewStackResponse
        /// </returns>
        public async Task<PreviewStackResponse> PreviewStackWithOptionsAsync(PreviewStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableRollback))
            {
                query["DisableRollback"] = request.DisableRollback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePreConfig))
            {
                query["EnablePreConfig"] = request.EnablePreConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parallelism))
            {
                query["Parallelism"] = request.Parallelism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackName))
            {
                query["StackName"] = request.StackName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyBody))
            {
                query["StackPolicyBody"] = request.StackPolicyBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyURL))
            {
                query["StackPolicyURL"] = request.StackPolicyURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaintResources))
            {
                query["TaintResources"] = request.TaintResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchId))
            {
                query["TemplateScratchId"] = request.TemplateScratchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchRegionId))
            {
                query["TemplateScratchRegionId"] = request.TemplateScratchRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutInMinutes))
            {
                query["TimeoutInMinutes"] = request.TimeoutInMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePreviousParameters))
            {
                query["UsePreviousParameters"] = request.UsePreviousParameters;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreviewStack",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreviewStackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Previews the information about a stack that you want to create or update based on a template. You can call this operation to verify whether the template resources are valid.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, a stack named <c>MyStack</c> is created in the China (Hangzhou) region and previewed. The <c>TemplateBody</c> parameter of the stack is set to <c>{&quot;ROSTemplateFormatVersion&quot;:&quot;2015-09-01&quot;}</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PreviewStackRequest
        /// </param>
        /// 
        /// <returns>
        /// PreviewStackResponse
        /// </returns>
        public PreviewStackResponse PreviewStack(PreviewStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PreviewStackWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Previews the information about a stack that you want to create or update based on a template. You can call this operation to verify whether the template resources are valid.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, a stack named <c>MyStack</c> is created in the China (Hangzhou) region and previewed. The <c>TemplateBody</c> parameter of the stack is set to <c>{&quot;ROSTemplateFormatVersion&quot;:&quot;2015-09-01&quot;}</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PreviewStackRequest
        /// </param>
        /// 
        /// <returns>
        /// PreviewStackResponse
        /// </returns>
        public async Task<PreviewStackResponse> PreviewStackAsync(PreviewStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PreviewStackWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new resource type, or creates a new version for an existing resource type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Versions increase from v1.</description></item>
        /// <item><description>If you create a new resource type, v1 is used as the default version of the resource type. You can call the SetResourceType operation to change the default version of a resource type.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RegisterResourceTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterResourceTypeResponse
        /// </returns>
        public RegisterResourceTypeResponse RegisterResourceTypeWithOptions(RegisterResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterResourceType",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterResourceTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new resource type, or creates a new version for an existing resource type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Versions increase from v1.</description></item>
        /// <item><description>If you create a new resource type, v1 is used as the default version of the resource type. You can call the SetResourceType operation to change the default version of a resource type.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RegisterResourceTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterResourceTypeResponse
        /// </returns>
        public async Task<RegisterResourceTypeResponse> RegisterResourceTypeWithOptionsAsync(RegisterResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterResourceType",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterResourceTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new resource type, or creates a new version for an existing resource type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Versions increase from v1.</description></item>
        /// <item><description>If you create a new resource type, v1 is used as the default version of the resource type. You can call the SetResourceType operation to change the default version of a resource type.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RegisterResourceTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterResourceTypeResponse
        /// </returns>
        public RegisterResourceTypeResponse RegisterResourceType(RegisterResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterResourceTypeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new resource type, or creates a new version for an existing resource type.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Versions increase from v1.</description></item>
        /// <item><description>If you create a new resource type, v1 is used as the default version of the resource type. You can call the SetResourceType operation to change the default version of a resource type.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RegisterResourceTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterResourceTypeResponse
        /// </returns>
        public async Task<RegisterResourceTypeResponse> RegisterResourceTypeAsync(RegisterResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterResourceTypeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the deletion protection setting for a stack.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDeletionProtectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDeletionProtectionResponse
        /// </returns>
        public SetDeletionProtectionResponse SetDeletionProtectionWithOptions(SetDeletionProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                query["DeletionProtection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDeletionProtection",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDeletionProtectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the deletion protection setting for a stack.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDeletionProtectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDeletionProtectionResponse
        /// </returns>
        public async Task<SetDeletionProtectionResponse> SetDeletionProtectionWithOptionsAsync(SetDeletionProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                query["DeletionProtection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDeletionProtection",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDeletionProtectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the deletion protection setting for a stack.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDeletionProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDeletionProtectionResponse
        /// </returns>
        public SetDeletionProtectionResponse SetDeletionProtection(SetDeletionProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDeletionProtectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the deletion protection setting for a stack.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDeletionProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDeletionProtectionResponse
        /// </returns>
        public async Task<SetDeletionProtectionResponse> SetDeletionProtectionAsync(SetDeletionProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDeletionProtectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description of a resource type or a version of that type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetResourceTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetResourceTypeResponse
        /// </returns>
        public SetResourceTypeResponse SetResourceTypeWithOptions(SetResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultVersionId))
            {
                query["DefaultVersionId"] = request.DefaultVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetResourceType",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetResourceTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description of a resource type or a version of that type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetResourceTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetResourceTypeResponse
        /// </returns>
        public async Task<SetResourceTypeResponse> SetResourceTypeWithOptionsAsync(SetResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultVersionId))
            {
                query["DefaultVersionId"] = request.DefaultVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetResourceType",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetResourceTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description of a resource type or a version of that type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetResourceTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetResourceTypeResponse
        /// </returns>
        public SetResourceTypeResponse SetResourceType(SetResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetResourceTypeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description of a resource type or a version of that type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetResourceTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// SetResourceTypeResponse
        /// </returns>
        public async Task<SetResourceTypeResponse> SetResourceTypeAsync(SetResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetResourceTypeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a stack policy for a stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, a stack policy is configured for a stack deployed in the <c>China (Hangzhou)</c> region whose ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c>. The URL to the stack policy body is <c>oss://ros/stack-policy/demo</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetStackPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetStackPolicyResponse
        /// </returns>
        public SetStackPolicyResponse SetStackPolicyWithOptions(SetStackPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyBody))
            {
                query["StackPolicyBody"] = request.StackPolicyBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyURL))
            {
                query["StackPolicyURL"] = request.StackPolicyURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetStackPolicy",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetStackPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a stack policy for a stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, a stack policy is configured for a stack deployed in the <c>China (Hangzhou)</c> region whose ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c>. The URL to the stack policy body is <c>oss://ros/stack-policy/demo</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetStackPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetStackPolicyResponse
        /// </returns>
        public async Task<SetStackPolicyResponse> SetStackPolicyWithOptionsAsync(SetStackPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyBody))
            {
                query["StackPolicyBody"] = request.StackPolicyBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyURL))
            {
                query["StackPolicyURL"] = request.StackPolicyURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetStackPolicy",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetStackPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a stack policy for a stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, a stack policy is configured for a stack deployed in the <c>China (Hangzhou)</c> region whose ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c>. The URL to the stack policy body is <c>oss://ros/stack-policy/demo</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetStackPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// SetStackPolicyResponse
        /// </returns>
        public SetStackPolicyResponse SetStackPolicy(SetStackPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetStackPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures a stack policy for a stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, a stack policy is configured for a stack deployed in the <c>China (Hangzhou)</c> region whose ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c>. The URL to the stack policy body is <c>oss://ros/stack-policy/demo</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetStackPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// SetStackPolicyResponse
        /// </returns>
        public async Task<SetStackPolicyResponse> SetStackPolicyAsync(SetStackPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetStackPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Shares or unshares a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the template whose ID is <c>5ecd1e10-b0e9-4389-a565-e4c15efc****</c> is shared with an Alibaba Cloud account. The ID of the Alibaba Cloud account is <c>151266687691****</c>.</para>
        /// <remarks>
        /// <para>The recipient Alibaba Cloud account (ID: <c>151266687691****</c>) can authorize RAM users to use the shared template.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// SetTemplatePermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetTemplatePermissionResponse
        /// </returns>
        public SetTemplatePermissionResponse SetTemplatePermissionWithOptions(SetTemplatePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIds))
            {
                query["AccountIds"] = request.AccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareOption))
            {
                query["ShareOption"] = request.ShareOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionOption))
            {
                query["VersionOption"] = request.VersionOption;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetTemplatePermission",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetTemplatePermissionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Shares or unshares a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the template whose ID is <c>5ecd1e10-b0e9-4389-a565-e4c15efc****</c> is shared with an Alibaba Cloud account. The ID of the Alibaba Cloud account is <c>151266687691****</c>.</para>
        /// <remarks>
        /// <para>The recipient Alibaba Cloud account (ID: <c>151266687691****</c>) can authorize RAM users to use the shared template.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// SetTemplatePermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetTemplatePermissionResponse
        /// </returns>
        public async Task<SetTemplatePermissionResponse> SetTemplatePermissionWithOptionsAsync(SetTemplatePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIds))
            {
                query["AccountIds"] = request.AccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareOption))
            {
                query["ShareOption"] = request.ShareOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionOption))
            {
                query["VersionOption"] = request.VersionOption;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetTemplatePermission",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetTemplatePermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Shares or unshares a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the template whose ID is <c>5ecd1e10-b0e9-4389-a565-e4c15efc****</c> is shared with an Alibaba Cloud account. The ID of the Alibaba Cloud account is <c>151266687691****</c>.</para>
        /// <remarks>
        /// <para>The recipient Alibaba Cloud account (ID: <c>151266687691****</c>) can authorize RAM users to use the shared template.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// SetTemplatePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// SetTemplatePermissionResponse
        /// </returns>
        public SetTemplatePermissionResponse SetTemplatePermission(SetTemplatePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetTemplatePermissionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Shares or unshares a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the template whose ID is <c>5ecd1e10-b0e9-4389-a565-e4c15efc****</c> is shared with an Alibaba Cloud account. The ID of the Alibaba Cloud account is <c>151266687691****</c>.</para>
        /// <remarks>
        /// <para>The recipient Alibaba Cloud account (ID: <c>151266687691****</c>) can authorize RAM users to use the shared template.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// SetTemplatePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// SetTemplatePermissionResponse
        /// </returns>
        public async Task<SetTemplatePermissionResponse> SetTemplatePermissionAsync(SetTemplatePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetTemplatePermissionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a signal to a resource in a stack.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SignalResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SignalResourceResponse
        /// </returns>
        public SignalResourceResponse SignalResourceWithOptions(SignalResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalResourceId))
            {
                query["LogicalResourceId"] = request.LogicalResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                query["UniqueId"] = request.UniqueId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SignalResource",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SignalResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a signal to a resource in a stack.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SignalResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SignalResourceResponse
        /// </returns>
        public async Task<SignalResourceResponse> SignalResourceWithOptionsAsync(SignalResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalResourceId))
            {
                query["LogicalResourceId"] = request.LogicalResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                query["UniqueId"] = request.UniqueId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SignalResource",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SignalResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a signal to a resource in a stack.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SignalResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// SignalResourceResponse
        /// </returns>
        public SignalResourceResponse SignalResource(SignalResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SignalResourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a signal to a resource in a stack.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SignalResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// SignalResourceResponse
        /// </returns>
        public async Task<SignalResourceResponse> SignalResourceAsync(SignalResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SignalResourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns agent events through SSE streaming. Supports creating a new session or continuing an existing session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>When calling this API, ensure that <c>AgentVersion</c> is set to <c>V2</c>.</description></item>
        /// <item><description>If <c>SessionId</c> is not provided, a new session is created. If <c>SessionId</c> is provided, the existing session is continued.</description></item>
        /// <item><description>The default value of <c>Mode</c> is <c>IaCCodeNormal</c>. Only <c>IaCCodeNormal</c> and <c>IaCCodePipeline</c> modes are supported. An existing session cannot switch modes.</description></item>
        /// <item><description><c>EnableThinking</c> defaults to <c>true</c>, which specifies whether to output thinking content. This can be reset in each request.</description></item>
        /// <item><description>A maximum of 5 image attachments are supported. Each attachment can be up to 5 MiB and must be accessed through an OssObjectKey under the current user directory.</description></item>
        /// <item><description><c>ClientContext</c> is a page context JSON string with a maximum size of 16 KiB. It is valid only in <c>IaCCodeNormal</c> mode.</description></item>
        /// <item><description>The response type is <c>text/event-stream</c>. A successful HTTP connection does not indicate that the operation is complete. Continue reading SSE events until a terminal state is reached.</description></item>
        /// <item><description>When the <c>TASK_STATE_INPUT_REQUIRED</c> status is received, it indicates that user input is required. This is not a failure state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartChatRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartChatResponse
        /// </returns>
        public StartChatResponse StartChatWithOptions(StartChatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                query["AgentVersion"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attachments))
            {
                query["Attachments"] = request.Attachments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePartialMessage))
            {
                query["EnablePartialMessage"] = request.EnablePartialMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableThinking))
            {
                query["EnableThinking"] = request.EnableThinking;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartChat",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "string",
            };
            return TeaModel.ToObject<StartChatResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns agent events through SSE streaming. Supports creating a new session or continuing an existing session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>When calling this API, ensure that <c>AgentVersion</c> is set to <c>V2</c>.</description></item>
        /// <item><description>If <c>SessionId</c> is not provided, a new session is created. If <c>SessionId</c> is provided, the existing session is continued.</description></item>
        /// <item><description>The default value of <c>Mode</c> is <c>IaCCodeNormal</c>. Only <c>IaCCodeNormal</c> and <c>IaCCodePipeline</c> modes are supported. An existing session cannot switch modes.</description></item>
        /// <item><description><c>EnableThinking</c> defaults to <c>true</c>, which specifies whether to output thinking content. This can be reset in each request.</description></item>
        /// <item><description>A maximum of 5 image attachments are supported. Each attachment can be up to 5 MiB and must be accessed through an OssObjectKey under the current user directory.</description></item>
        /// <item><description><c>ClientContext</c> is a page context JSON string with a maximum size of 16 KiB. It is valid only in <c>IaCCodeNormal</c> mode.</description></item>
        /// <item><description>The response type is <c>text/event-stream</c>. A successful HTTP connection does not indicate that the operation is complete. Continue reading SSE events until a terminal state is reached.</description></item>
        /// <item><description>When the <c>TASK_STATE_INPUT_REQUIRED</c> status is received, it indicates that user input is required. This is not a failure state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartChatRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartChatResponse
        /// </returns>
        public async Task<StartChatResponse> StartChatWithOptionsAsync(StartChatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                query["AgentVersion"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attachments))
            {
                query["Attachments"] = request.Attachments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePartialMessage))
            {
                query["EnablePartialMessage"] = request.EnablePartialMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableThinking))
            {
                query["EnableThinking"] = request.EnableThinking;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartChat",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "string",
            };
            return TeaModel.ToObject<StartChatResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns agent events through SSE streaming. Supports creating a new session or continuing an existing session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>When calling this API, ensure that <c>AgentVersion</c> is set to <c>V2</c>.</description></item>
        /// <item><description>If <c>SessionId</c> is not provided, a new session is created. If <c>SessionId</c> is provided, the existing session is continued.</description></item>
        /// <item><description>The default value of <c>Mode</c> is <c>IaCCodeNormal</c>. Only <c>IaCCodeNormal</c> and <c>IaCCodePipeline</c> modes are supported. An existing session cannot switch modes.</description></item>
        /// <item><description><c>EnableThinking</c> defaults to <c>true</c>, which specifies whether to output thinking content. This can be reset in each request.</description></item>
        /// <item><description>A maximum of 5 image attachments are supported. Each attachment can be up to 5 MiB and must be accessed through an OssObjectKey under the current user directory.</description></item>
        /// <item><description><c>ClientContext</c> is a page context JSON string with a maximum size of 16 KiB. It is valid only in <c>IaCCodeNormal</c> mode.</description></item>
        /// <item><description>The response type is <c>text/event-stream</c>. A successful HTTP connection does not indicate that the operation is complete. Continue reading SSE events until a terminal state is reached.</description></item>
        /// <item><description>When the <c>TASK_STATE_INPUT_REQUIRED</c> status is received, it indicates that user input is required. This is not a failure state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartChatRequest
        /// </param>
        /// 
        /// <returns>
        /// StartChatResponse
        /// </returns>
        public StartChatResponse StartChat(StartChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartChatWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns agent events through SSE streaming. Supports creating a new session or continuing an existing session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>When calling this API, ensure that <c>AgentVersion</c> is set to <c>V2</c>.</description></item>
        /// <item><description>If <c>SessionId</c> is not provided, a new session is created. If <c>SessionId</c> is provided, the existing session is continued.</description></item>
        /// <item><description>The default value of <c>Mode</c> is <c>IaCCodeNormal</c>. Only <c>IaCCodeNormal</c> and <c>IaCCodePipeline</c> modes are supported. An existing session cannot switch modes.</description></item>
        /// <item><description><c>EnableThinking</c> defaults to <c>true</c>, which specifies whether to output thinking content. This can be reset in each request.</description></item>
        /// <item><description>A maximum of 5 image attachments are supported. Each attachment can be up to 5 MiB and must be accessed through an OssObjectKey under the current user directory.</description></item>
        /// <item><description><c>ClientContext</c> is a page context JSON string with a maximum size of 16 KiB. It is valid only in <c>IaCCodeNormal</c> mode.</description></item>
        /// <item><description>The response type is <c>text/event-stream</c>. A successful HTTP connection does not indicate that the operation is complete. Continue reading SSE events until a terminal state is reached.</description></item>
        /// <item><description>When the <c>TASK_STATE_INPUT_REQUIRED</c> status is received, it indicates that user input is required. This is not a failure state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartChatRequest
        /// </param>
        /// 
        /// <returns>
        /// StartChatResponse
        /// </returns>
        public async Task<StartChatResponse> StartChatAsync(StartChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartChatWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a running task in a specified ROS Agent V2 session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>When calling this operation, ensure that <c>AgentVersion</c> is set to <c>V2</c> to route to the correct backend service.</description></item>
        /// <item><description><c>SessionId</c> is required to identify the specific session to stop.</description></item>
        /// <item><description>In a multi-process environment, if the target session is within the calling process, a cancel signal is sent directly and the system waits for cleanup to complete. If the session is managed by another process, a cancel request is sent to the remote end through the persisted active session state, and a <c>Stopping</c> status is returned immediately.</description></item>
        /// <item><description>When no active task exists, the API returns the <c>NoActiveStream</c> status code, which is not considered an error condition.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopChatRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopChatResponse
        /// </returns>
        public StopChatResponse StopChatWithOptions(StopChatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                query["AgentVersion"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopChat",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopChatResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a running task in a specified ROS Agent V2 session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>When calling this operation, ensure that <c>AgentVersion</c> is set to <c>V2</c> to route to the correct backend service.</description></item>
        /// <item><description><c>SessionId</c> is required to identify the specific session to stop.</description></item>
        /// <item><description>In a multi-process environment, if the target session is within the calling process, a cancel signal is sent directly and the system waits for cleanup to complete. If the session is managed by another process, a cancel request is sent to the remote end through the persisted active session state, and a <c>Stopping</c> status is returned immediately.</description></item>
        /// <item><description>When no active task exists, the API returns the <c>NoActiveStream</c> status code, which is not considered an error condition.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopChatRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopChatResponse
        /// </returns>
        public async Task<StopChatResponse> StopChatWithOptionsAsync(StopChatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                query["AgentVersion"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopChat",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopChatResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a running task in a specified ROS Agent V2 session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>When calling this operation, ensure that <c>AgentVersion</c> is set to <c>V2</c> to route to the correct backend service.</description></item>
        /// <item><description><c>SessionId</c> is required to identify the specific session to stop.</description></item>
        /// <item><description>In a multi-process environment, if the target session is within the calling process, a cancel signal is sent directly and the system waits for cleanup to complete. If the session is managed by another process, a cancel request is sent to the remote end through the persisted active session state, and a <c>Stopping</c> status is returned immediately.</description></item>
        /// <item><description>When no active task exists, the API returns the <c>NoActiveStream</c> status code, which is not considered an error condition.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopChatRequest
        /// </param>
        /// 
        /// <returns>
        /// StopChatResponse
        /// </returns>
        public StopChatResponse StopChat(StopChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopChatWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a running task in a specified ROS Agent V2 session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>When calling this operation, ensure that <c>AgentVersion</c> is set to <c>V2</c> to route to the correct backend service.</description></item>
        /// <item><description><c>SessionId</c> is required to identify the specific session to stop.</description></item>
        /// <item><description>In a multi-process environment, if the target session is within the calling process, a cancel signal is sent directly and the system waits for cleanup to complete. If the session is managed by another process, a cancel request is sent to the remote end through the persisted active session state, and a <c>Stopping</c> status is returned immediately.</description></item>
        /// <item><description>When no active task exists, the API returns the <c>NoActiveStream</c> status code, which is not considered an error condition.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopChatRequest
        /// </param>
        /// 
        /// <returns>
        /// StopChatResponse
        /// </returns>
        public async Task<StopChatResponse> StopChatAsync(StopChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopChatWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops an ongoing operation in a stack group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This example stops the stack group operation <c>6da106ca-1784-4a6f-a7e1-e723863****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopStackGroupOperationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopStackGroupOperationResponse
        /// </returns>
        public StopStackGroupOperationResponse StopStackGroupOperationWithOptions(StopStackGroupOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationId))
            {
                query["OperationId"] = request.OperationId;
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
                Action = "StopStackGroupOperation",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopStackGroupOperationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops an ongoing operation in a stack group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This example stops the stack group operation <c>6da106ca-1784-4a6f-a7e1-e723863****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopStackGroupOperationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopStackGroupOperationResponse
        /// </returns>
        public async Task<StopStackGroupOperationResponse> StopStackGroupOperationWithOptionsAsync(StopStackGroupOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationId))
            {
                query["OperationId"] = request.OperationId;
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
                Action = "StopStackGroupOperation",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopStackGroupOperationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops an ongoing operation in a stack group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This example stops the stack group operation <c>6da106ca-1784-4a6f-a7e1-e723863****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopStackGroupOperationRequest
        /// </param>
        /// 
        /// <returns>
        /// StopStackGroupOperationResponse
        /// </returns>
        public StopStackGroupOperationResponse StopStackGroupOperation(StopStackGroupOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopStackGroupOperationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops an ongoing operation in a stack group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This example stops the stack group operation <c>6da106ca-1784-4a6f-a7e1-e723863****</c> in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopStackGroupOperationRequest
        /// </param>
        /// 
        /// <returns>
        /// StopStackGroupOperationResponse
        /// </returns>
        public async Task<StopStackGroupOperationResponse> StopStackGroupOperationAsync(StopStackGroupOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopStackGroupOperationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and adds tags to resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to create and add a tag to a resource stack in China (Hangzhou) region. The resource stack ID is <c>7fee80e1-8c48-4c2f-8300-0f6dc40b****</c>, with the tag key of <c>FinanceDept</c> and the tag value of <c>FinanceJoshua</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and adds tags to resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to create and add a tag to a resource stack in China (Hangzhou) region. The resource stack ID is <c>7fee80e1-8c48-4c2f-8300-0f6dc40b****</c>, with the tag key of <c>FinanceDept</c> and the tag value of <c>FinanceJoshua</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and adds tags to resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to create and add a tag to a resource stack in China (Hangzhou) region. The resource stack ID is <c>7fee80e1-8c48-4c2f-8300-0f6dc40b****</c>, with the tag key of <c>FinanceDept</c> and the tag value of <c>FinanceJoshua</c>.</para>
        /// </description>
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
            return TagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates and adds tags to resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to create and add a tag to a resource stack in China (Hangzhou) region. The resource stack ID is <c>7fee80e1-8c48-4c2f-8300-0f6dc40b****</c>, with the tag key of <c>FinanceDept</c> and the tag value of <c>FinanceJoshua</c>.</para>
        /// </description>
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
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from resources and then deletes the tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to remove all tags from a stack that is deployed in the China (Hangzhou) region. In this example, the stack ID is <c>46ec7b78-9d5e-4b21-aefd-448c90aa****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from resources and then deletes the tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to remove all tags from a stack that is deployed in the China (Hangzhou) region. In this example, the stack ID is <c>46ec7b78-9d5e-4b21-aefd-448c90aa****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from resources and then deletes the tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to remove all tags from a stack that is deployed in the China (Hangzhou) region. In this example, the stack ID is <c>46ec7b78-9d5e-4b21-aefd-448c90aa****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from resources and then deletes the tags.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to remove all tags from a stack that is deployed in the China (Hangzhou) region. In this example, the stack ID is <c>46ec7b78-9d5e-4b21-aefd-448c90aa****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the resource information of a created stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The values of Parameters and UsePreviousParameters are related. If a parameter defined in the template is not specified in Parameters:  </para>
        /// <list type="bullet">
        /// <item><description>If UsePreviousParameters is set to false: the default value of the parameter in the template is used if available. If no default value exists, you must specify the parameter in Parameters.  </description></item>
        /// <item><description>If UsePreviousParameters is set to true: if the parameter was specified when the stack was created, the specified value is used. If the parameter was not specified when the stack was created and the parameter has a default value in the template, the default value is used.</description></item>
        /// </list>
        /// <para>This topic provides an example to show how to update the template content of a stack in the China (Beijing) region to <c>{&quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;}</c>. The stack ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateStackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateStackResponse
        /// </returns>
        public UpdateStackResponse UpdateStackWithOptions(UpdateStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableRollback))
            {
                query["DisableRollback"] = request.DisableRollback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRunOptions))
            {
                query["DryRunOptions"] = request.DryRunOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parallelism))
            {
                query["Parallelism"] = request.Parallelism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                query["RamRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplacementOption))
            {
                query["ReplacementOption"] = request.ReplacementOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyBody))
            {
                query["StackPolicyBody"] = request.StackPolicyBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyDuringUpdateBody))
            {
                query["StackPolicyDuringUpdateBody"] = request.StackPolicyDuringUpdateBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyDuringUpdateURL))
            {
                query["StackPolicyDuringUpdateURL"] = request.StackPolicyDuringUpdateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyURL))
            {
                query["StackPolicyURL"] = request.StackPolicyURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaintResources))
            {
                query["TaintResources"] = request.TaintResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutInMinutes))
            {
                query["TimeoutInMinutes"] = request.TimeoutInMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePreviousParameters))
            {
                query["UsePreviousParameters"] = request.UsePreviousParameters;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStack",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStackResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the resource information of a created stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The values of Parameters and UsePreviousParameters are related. If a parameter defined in the template is not specified in Parameters:  </para>
        /// <list type="bullet">
        /// <item><description>If UsePreviousParameters is set to false: the default value of the parameter in the template is used if available. If no default value exists, you must specify the parameter in Parameters.  </description></item>
        /// <item><description>If UsePreviousParameters is set to true: if the parameter was specified when the stack was created, the specified value is used. If the parameter was not specified when the stack was created and the parameter has a default value in the template, the default value is used.</description></item>
        /// </list>
        /// <para>This topic provides an example to show how to update the template content of a stack in the China (Beijing) region to <c>{&quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;}</c>. The stack ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateStackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateStackResponse
        /// </returns>
        public async Task<UpdateStackResponse> UpdateStackWithOptionsAsync(UpdateStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableRollback))
            {
                query["DisableRollback"] = request.DisableRollback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRunOptions))
            {
                query["DryRunOptions"] = request.DryRunOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parallelism))
            {
                query["Parallelism"] = request.Parallelism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                query["RamRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplacementOption))
            {
                query["ReplacementOption"] = request.ReplacementOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyBody))
            {
                query["StackPolicyBody"] = request.StackPolicyBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyDuringUpdateBody))
            {
                query["StackPolicyDuringUpdateBody"] = request.StackPolicyDuringUpdateBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyDuringUpdateURL))
            {
                query["StackPolicyDuringUpdateURL"] = request.StackPolicyDuringUpdateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackPolicyURL))
            {
                query["StackPolicyURL"] = request.StackPolicyURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaintResources))
            {
                query["TaintResources"] = request.TaintResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutInMinutes))
            {
                query["TimeoutInMinutes"] = request.TimeoutInMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePreviousParameters))
            {
                query["UsePreviousParameters"] = request.UsePreviousParameters;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStack",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the resource information of a created stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The values of Parameters and UsePreviousParameters are related. If a parameter defined in the template is not specified in Parameters:  </para>
        /// <list type="bullet">
        /// <item><description>If UsePreviousParameters is set to false: the default value of the parameter in the template is used if available. If no default value exists, you must specify the parameter in Parameters.  </description></item>
        /// <item><description>If UsePreviousParameters is set to true: if the parameter was specified when the stack was created, the specified value is used. If the parameter was not specified when the stack was created and the parameter has a default value in the template, the default value is used.</description></item>
        /// </list>
        /// <para>This topic provides an example to show how to update the template content of a stack in the China (Beijing) region to <c>{&quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;}</c>. The stack ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateStackRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateStackResponse
        /// </returns>
        public UpdateStackResponse UpdateStack(UpdateStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateStackWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the resource information of a created stack.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The values of Parameters and UsePreviousParameters are related. If a parameter defined in the template is not specified in Parameters:  </para>
        /// <list type="bullet">
        /// <item><description>If UsePreviousParameters is set to false: the default value of the parameter in the template is used if available. If no default value exists, you must specify the parameter in Parameters.  </description></item>
        /// <item><description>If UsePreviousParameters is set to true: if the parameter was specified when the stack was created, the specified value is used. If the parameter was not specified when the stack was created and the parameter has a default value in the template, the default value is used.</description></item>
        /// </list>
        /// <para>This topic provides an example to show how to update the template content of a stack in the China (Beijing) region to <c>{&quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;}</c>. The stack ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateStackRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateStackResponse
        /// </returns>
        public async Task<UpdateStackResponse> UpdateStackAsync(UpdateStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateStackWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an existing stack group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to update the template of the stack group <c>MyStackGroup</c> to <c>{&quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;}</c>. The stack group is in the China (Hangzhou) region and uses self-managed permissions.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateStackGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateStackGroupResponse
        /// </returns>
        public UpdateStackGroupResponse UpdateStackGroupWithOptions(UpdateStackGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateStackGroupShrinkRequest request = new UpdateStackGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountIds))
            {
                request.AccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountIds, "AccountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AutoDeployment))
            {
                request.AutoDeploymentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AutoDeployment, "AutoDeployment", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeploymentTargets))
            {
                request.DeploymentTargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeploymentTargets, "DeploymentTargets", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperationPreferences))
            {
                request.OperationPreferencesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperationPreferences, "OperationPreferences", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RegionIds))
            {
                request.RegionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RegionIds, "RegionIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIdsShrink))
            {
                query["AccountIds"] = request.AccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdministrationRoleName))
            {
                query["AdministrationRoleName"] = request.AdministrationRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDeploymentShrink))
            {
                query["AutoDeployment"] = request.AutoDeploymentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Capabilities))
            {
                query["Capabilities"] = request.Capabilities;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentOptions))
            {
                query["DeploymentOptions"] = request.DeploymentOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentTargetsShrink))
            {
                query["DeploymentTargets"] = request.DeploymentTargetsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionRoleName))
            {
                query["ExecutionRoleName"] = request.ExecutionRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationDescription))
            {
                query["OperationDescription"] = request.OperationDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationPreferencesShrink))
            {
                query["OperationPreferences"] = request.OperationPreferencesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionModel))
            {
                query["PermissionModel"] = request.PermissionModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsShrink))
            {
                query["RegionIds"] = request.RegionIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStackGroup",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStackGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an existing stack group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to update the template of the stack group <c>MyStackGroup</c> to <c>{&quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;}</c>. The stack group is in the China (Hangzhou) region and uses self-managed permissions.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateStackGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateStackGroupResponse
        /// </returns>
        public async Task<UpdateStackGroupResponse> UpdateStackGroupWithOptionsAsync(UpdateStackGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateStackGroupShrinkRequest request = new UpdateStackGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountIds))
            {
                request.AccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountIds, "AccountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AutoDeployment))
            {
                request.AutoDeploymentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AutoDeployment, "AutoDeployment", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeploymentTargets))
            {
                request.DeploymentTargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeploymentTargets, "DeploymentTargets", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperationPreferences))
            {
                request.OperationPreferencesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperationPreferences, "OperationPreferences", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RegionIds))
            {
                request.RegionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RegionIds, "RegionIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIdsShrink))
            {
                query["AccountIds"] = request.AccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdministrationRoleName))
            {
                query["AdministrationRoleName"] = request.AdministrationRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDeploymentShrink))
            {
                query["AutoDeployment"] = request.AutoDeploymentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Capabilities))
            {
                query["Capabilities"] = request.Capabilities;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentOptions))
            {
                query["DeploymentOptions"] = request.DeploymentOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentTargetsShrink))
            {
                query["DeploymentTargets"] = request.DeploymentTargetsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionRoleName))
            {
                query["ExecutionRoleName"] = request.ExecutionRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationDescription))
            {
                query["OperationDescription"] = request.OperationDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationPreferencesShrink))
            {
                query["OperationPreferences"] = request.OperationPreferencesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionModel))
            {
                query["PermissionModel"] = request.PermissionModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsShrink))
            {
                query["RegionIds"] = request.RegionIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStackGroup",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStackGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an existing stack group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to update the template of the stack group <c>MyStackGroup</c> to <c>{&quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;}</c>. The stack group is in the China (Hangzhou) region and uses self-managed permissions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateStackGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateStackGroupResponse
        /// </returns>
        public UpdateStackGroupResponse UpdateStackGroup(UpdateStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateStackGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an existing stack group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to update the template of the stack group <c>MyStackGroup</c> to <c>{&quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;}</c>. The stack group is in the China (Hangzhou) region and uses self-managed permissions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateStackGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateStackGroupResponse
        /// </returns>
        public async Task<UpdateStackGroupResponse> UpdateStackGroupAsync(UpdateStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateStackGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates stack instances for one or more accounts in specified regions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to update stacks for the stack group <c>MyStackGroup</c>, which is in the China (Hangzhou) region and uses self-managed permissions. The stacks are updated for the Alibaba Cloud accounts <c>151266687691****</c> and <c>141261387191****</c> in the China (Hangzhou) and China (Beijing) regions.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateStackInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateStackInstancesResponse
        /// </returns>
        public UpdateStackInstancesResponse UpdateStackInstancesWithOptions(UpdateStackInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateStackInstancesShrinkRequest request = new UpdateStackInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountIds))
            {
                request.AccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountIds, "AccountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeploymentTargets))
            {
                request.DeploymentTargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeploymentTargets, "DeploymentTargets", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperationPreferences))
            {
                request.OperationPreferencesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperationPreferences, "OperationPreferences", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RegionIds))
            {
                request.RegionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RegionIds, "RegionIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIdsShrink))
            {
                query["AccountIds"] = request.AccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentTargetsShrink))
            {
                query["DeploymentTargets"] = request.DeploymentTargetsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationDescription))
            {
                query["OperationDescription"] = request.OperationDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationPreferencesShrink))
            {
                query["OperationPreferences"] = request.OperationPreferencesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParameterOverrides))
            {
                query["ParameterOverrides"] = request.ParameterOverrides;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsShrink))
            {
                query["RegionIds"] = request.RegionIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutInMinutes))
            {
                query["TimeoutInMinutes"] = request.TimeoutInMinutes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStackInstances",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStackInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates stack instances for one or more accounts in specified regions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to update stacks for the stack group <c>MyStackGroup</c>, which is in the China (Hangzhou) region and uses self-managed permissions. The stacks are updated for the Alibaba Cloud accounts <c>151266687691****</c> and <c>141261387191****</c> in the China (Hangzhou) and China (Beijing) regions.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateStackInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateStackInstancesResponse
        /// </returns>
        public async Task<UpdateStackInstancesResponse> UpdateStackInstancesWithOptionsAsync(UpdateStackInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateStackInstancesShrinkRequest request = new UpdateStackInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountIds))
            {
                request.AccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountIds, "AccountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeploymentTargets))
            {
                request.DeploymentTargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeploymentTargets, "DeploymentTargets", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OperationPreferences))
            {
                request.OperationPreferencesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OperationPreferences, "OperationPreferences", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RegionIds))
            {
                request.RegionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RegionIds, "RegionIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIdsShrink))
            {
                query["AccountIds"] = request.AccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentTargetsShrink))
            {
                query["DeploymentTargets"] = request.DeploymentTargetsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationDescription))
            {
                query["OperationDescription"] = request.OperationDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationPreferencesShrink))
            {
                query["OperationPreferences"] = request.OperationPreferencesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParameterOverrides))
            {
                query["ParameterOverrides"] = request.ParameterOverrides;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsShrink))
            {
                query["RegionIds"] = request.RegionIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackGroupName))
            {
                query["StackGroupName"] = request.StackGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutInMinutes))
            {
                query["TimeoutInMinutes"] = request.TimeoutInMinutes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStackInstances",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStackInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates stack instances for one or more accounts in specified regions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to update stacks for the stack group <c>MyStackGroup</c>, which is in the China (Hangzhou) region and uses self-managed permissions. The stacks are updated for the Alibaba Cloud accounts <c>151266687691****</c> and <c>141261387191****</c> in the China (Hangzhou) and China (Beijing) regions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateStackInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateStackInstancesResponse
        /// </returns>
        public UpdateStackInstancesResponse UpdateStackInstances(UpdateStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateStackInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates stack instances for one or more accounts in specified regions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example of how to update stacks for the stack group <c>MyStackGroup</c>, which is in the China (Hangzhou) region and uses self-managed permissions. The stacks are updated for the Alibaba Cloud accounts <c>151266687691****</c> and <c>141261387191****</c> in the China (Hangzhou) and China (Beijing) regions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateStackInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateStackInstancesResponse
        /// </returns>
        public async Task<UpdateStackInstancesResponse> UpdateStackInstancesAsync(UpdateStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateStackInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Eliminates stack drifts by performing drift detection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limits: You can eliminate only drift on stacks that have drifted. You must call the <a href="https://help.aliyun.com/document_detail/155094.html">DetectStackDrift</a> operation to perform drift detection on a stack, call the <a href="https://help.aliyun.com/document_detail/155097.html">GetStackDriftDetectionStatus</a> operation to query the drift status of the stack to make sure that the stack has drifted, and then call the UpdateStackTemplateByResources operation to eliminate drift.
        /// In this topic, drift is eliminated for a stack whose ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c>. The stack is deployed in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateStackTemplateByResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateStackTemplateByResourcesResponse
        /// </returns>
        public UpdateStackTemplateByResourcesResponse UpdateStackTemplateByResourcesWithOptions(UpdateStackTemplateByResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalResourceId))
            {
                query["LogicalResourceId"] = request.LogicalResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateFormat))
            {
                query["TemplateFormat"] = request.TemplateFormat;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStackTemplateByResources",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStackTemplateByResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Eliminates stack drifts by performing drift detection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limits: You can eliminate only drift on stacks that have drifted. You must call the <a href="https://help.aliyun.com/document_detail/155094.html">DetectStackDrift</a> operation to perform drift detection on a stack, call the <a href="https://help.aliyun.com/document_detail/155097.html">GetStackDriftDetectionStatus</a> operation to query the drift status of the stack to make sure that the stack has drifted, and then call the UpdateStackTemplateByResources operation to eliminate drift.
        /// In this topic, drift is eliminated for a stack whose ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c>. The stack is deployed in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateStackTemplateByResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateStackTemplateByResourcesResponse
        /// </returns>
        public async Task<UpdateStackTemplateByResourcesResponse> UpdateStackTemplateByResourcesWithOptionsAsync(UpdateStackTemplateByResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalResourceId))
            {
                query["LogicalResourceId"] = request.LogicalResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StackId))
            {
                query["StackId"] = request.StackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateFormat))
            {
                query["TemplateFormat"] = request.TemplateFormat;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStackTemplateByResources",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStackTemplateByResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Eliminates stack drifts by performing drift detection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limits: You can eliminate only drift on stacks that have drifted. You must call the <a href="https://help.aliyun.com/document_detail/155094.html">DetectStackDrift</a> operation to perform drift detection on a stack, call the <a href="https://help.aliyun.com/document_detail/155097.html">GetStackDriftDetectionStatus</a> operation to query the drift status of the stack to make sure that the stack has drifted, and then call the UpdateStackTemplateByResources operation to eliminate drift.
        /// In this topic, drift is eliminated for a stack whose ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c>. The stack is deployed in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateStackTemplateByResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateStackTemplateByResourcesResponse
        /// </returns>
        public UpdateStackTemplateByResourcesResponse UpdateStackTemplateByResources(UpdateStackTemplateByResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateStackTemplateByResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Eliminates stack drifts by performing drift detection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limits: You can eliminate only drift on stacks that have drifted. You must call the <a href="https://help.aliyun.com/document_detail/155094.html">DetectStackDrift</a> operation to perform drift detection on a stack, call the <a href="https://help.aliyun.com/document_detail/155097.html">GetStackDriftDetectionStatus</a> operation to query the drift status of the stack to make sure that the stack has drifted, and then call the UpdateStackTemplateByResources operation to eliminate drift.
        /// In this topic, drift is eliminated for a stack whose ID is <c>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</c>. The stack is deployed in the China (Hangzhou) region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateStackTemplateByResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateStackTemplateByResourcesResponse
        /// </returns>
        public async Task<UpdateStackTemplateByResourcesResponse> UpdateStackTemplateByResourcesAsync(UpdateStackTemplateByResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateStackTemplateByResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Template</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When updating a template, please note:</para>
        /// <list type="bullet">
        /// <item><description>If you specify <c>TemplateBody</c> or <c>TemplateURL</c>, the template version will be incremented by 1 after a successful update. For example, the version changes from v1 to v2.</description></item>
        /// <item><description>If neither <c>TemplateBody</c> nor <c>TemplateURL</c> is specified, the template version remains unchanged.</description></item>
        /// <item><description>A template can have up to 100 versions. If the version limit is reached, the template update will fail, and you need to recreate the template.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTemplateResponse
        /// </returns>
        public UpdateTemplateResponse UpdateTemplateWithOptions(UpdateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDraft))
            {
                query["IsDraft"] = request.IsDraft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RotateStrategy))
            {
                query["RotateStrategy"] = request.RotateStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidationOptions))
            {
                query["ValidationOptions"] = request.ValidationOptions;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTemplate",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Template</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When updating a template, please note:</para>
        /// <list type="bullet">
        /// <item><description>If you specify <c>TemplateBody</c> or <c>TemplateURL</c>, the template version will be incremented by 1 after a successful update. For example, the version changes from v1 to v2.</description></item>
        /// <item><description>If neither <c>TemplateBody</c> nor <c>TemplateURL</c> is specified, the template version remains unchanged.</description></item>
        /// <item><description>A template can have up to 100 versions. If the version limit is reached, the template update will fail, and you need to recreate the template.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTemplateResponse
        /// </returns>
        public async Task<UpdateTemplateResponse> UpdateTemplateWithOptionsAsync(UpdateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDraft))
            {
                query["IsDraft"] = request.IsDraft;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RotateStrategy))
            {
                query["RotateStrategy"] = request.RotateStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidationOptions))
            {
                query["ValidationOptions"] = request.ValidationOptions;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTemplate",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Template</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When updating a template, please note:</para>
        /// <list type="bullet">
        /// <item><description>If you specify <c>TemplateBody</c> or <c>TemplateURL</c>, the template version will be incremented by 1 after a successful update. For example, the version changes from v1 to v2.</description></item>
        /// <item><description>If neither <c>TemplateBody</c> nor <c>TemplateURL</c> is specified, the template version remains unchanged.</description></item>
        /// <item><description>A template can have up to 100 versions. If the version limit is reached, the template update will fail, and you need to recreate the template.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTemplateResponse
        /// </returns>
        public UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Template</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When updating a template, please note:</para>
        /// <list type="bullet">
        /// <item><description>If you specify <c>TemplateBody</c> or <c>TemplateURL</c>, the template version will be incremented by 1 after a successful update. For example, the version changes from v1 to v2.</description></item>
        /// <item><description>If neither <c>TemplateBody</c> nor <c>TemplateURL</c> is specified, the template version remains unchanged.</description></item>
        /// <item><description>A template can have up to 100 versions. If the version limit is reached, the template update will fail, and you need to recreate the template.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTemplateResponse
        /// </returns>
        public async Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Resource replication scenario</h3>
        /// <para>Resource Orchestration Service (ROS) allows you to update a resource replication scenario. The updates that you make to a resource replication scenario do not affect the stack that is generated by using the resource scenario. You can call the <a href="https://help.aliyun.com/document_detail/610829.html">GenerateTemplateByScratch</a> operation to generate a template for the resource scenario.</para>
        /// <h3><a href="#"></a>Resource migration scenario</h3>
        /// <list type="bullet">
        /// <item><description>If you want to update a resource migration scenario in which the migrated source resources are retained, you can delete the source resources to manage the updated resource migration scenario. You can also call the <a href="https://help.aliyun.com/document_detail/610829.html">GenerateTemplateByScratch</a> operation to generate a template for the resource scenario.
        /// \<em>\</em>
        /// <b>Note</b> Make sure that the source resources that you want to delete from a resource migration scenario are associated only with the resource scenario. Otherwise, the source resources fail to be deleted.</description></item>
        /// <item><description>If you want to update a resource migration scenario in which the migrated source resources are deleted, you can only call the <a href="https://help.aliyun.com/document_detail/610829.html">GenerateTemplateByScratch</a> operation to generate a template for the resource scenario.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Resource management scenario</h3>
        /// <para>If you want to update a resource management scenario after you use the resource scenario to manage resources, you can only call the <a href="https://help.aliyun.com/document_detail/610829.html">GenerateTemplateByScratch</a> operation to generate a template for the resource scenario.</para>
        /// <h3><a href="#"></a>Resource detection scenario</h3>
        /// <para>After you update a resource detection scenario, ROS obtains the most recent data from Resource Center and renders the architecture diagram.
        /// This topic provides an example on how to update a resource scenario. In this example, the ID of a virtual private cloud (VPC) in a resource scenario whose ID is <c>ts-7f7a704cf71c49a6****</c> is updated to <c>vpc-bp1m6fww66xbntjyc****</c>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateTemplateScratchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTemplateScratchResponse
        /// </returns>
        public UpdateTemplateScratchResponse UpdateTemplateScratchWithOptions(UpdateTemplateScratchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTemplateScratchShrinkRequest request = new UpdateTemplateScratchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PreferenceParameters))
            {
                request.PreferenceParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PreferenceParameters, "PreferenceParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceResourceGroup))
            {
                request.SourceResourceGroupShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceResourceGroup, "SourceResourceGroup", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceResources))
            {
                request.SourceResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceResources, "SourceResources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceTag))
            {
                request.SourceTagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceTag, "SourceTag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionMode))
            {
                query["ExecutionMode"] = request.ExecutionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalIdStrategy))
            {
                query["LogicalIdStrategy"] = request.LogicalIdStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferenceParametersShrink))
            {
                query["PreferenceParameters"] = request.PreferenceParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceResourceGroupShrink))
            {
                query["SourceResourceGroup"] = request.SourceResourceGroupShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceResourcesShrink))
            {
                query["SourceResources"] = request.SourceResourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTagShrink))
            {
                query["SourceTag"] = request.SourceTagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchId))
            {
                query["TemplateScratchId"] = request.TemplateScratchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTemplateScratch",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTemplateScratchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Resource replication scenario</h3>
        /// <para>Resource Orchestration Service (ROS) allows you to update a resource replication scenario. The updates that you make to a resource replication scenario do not affect the stack that is generated by using the resource scenario. You can call the <a href="https://help.aliyun.com/document_detail/610829.html">GenerateTemplateByScratch</a> operation to generate a template for the resource scenario.</para>
        /// <h3><a href="#"></a>Resource migration scenario</h3>
        /// <list type="bullet">
        /// <item><description>If you want to update a resource migration scenario in which the migrated source resources are retained, you can delete the source resources to manage the updated resource migration scenario. You can also call the <a href="https://help.aliyun.com/document_detail/610829.html">GenerateTemplateByScratch</a> operation to generate a template for the resource scenario.
        /// \<em>\</em>
        /// <b>Note</b> Make sure that the source resources that you want to delete from a resource migration scenario are associated only with the resource scenario. Otherwise, the source resources fail to be deleted.</description></item>
        /// <item><description>If you want to update a resource migration scenario in which the migrated source resources are deleted, you can only call the <a href="https://help.aliyun.com/document_detail/610829.html">GenerateTemplateByScratch</a> operation to generate a template for the resource scenario.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Resource management scenario</h3>
        /// <para>If you want to update a resource management scenario after you use the resource scenario to manage resources, you can only call the <a href="https://help.aliyun.com/document_detail/610829.html">GenerateTemplateByScratch</a> operation to generate a template for the resource scenario.</para>
        /// <h3><a href="#"></a>Resource detection scenario</h3>
        /// <para>After you update a resource detection scenario, ROS obtains the most recent data from Resource Center and renders the architecture diagram.
        /// This topic provides an example on how to update a resource scenario. In this example, the ID of a virtual private cloud (VPC) in a resource scenario whose ID is <c>ts-7f7a704cf71c49a6****</c> is updated to <c>vpc-bp1m6fww66xbntjyc****</c>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateTemplateScratchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTemplateScratchResponse
        /// </returns>
        public async Task<UpdateTemplateScratchResponse> UpdateTemplateScratchWithOptionsAsync(UpdateTemplateScratchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTemplateScratchShrinkRequest request = new UpdateTemplateScratchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PreferenceParameters))
            {
                request.PreferenceParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PreferenceParameters, "PreferenceParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceResourceGroup))
            {
                request.SourceResourceGroupShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceResourceGroup, "SourceResourceGroup", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceResources))
            {
                request.SourceResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceResources, "SourceResources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceTag))
            {
                request.SourceTagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceTag, "SourceTag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionMode))
            {
                query["ExecutionMode"] = request.ExecutionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalIdStrategy))
            {
                query["LogicalIdStrategy"] = request.LogicalIdStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferenceParametersShrink))
            {
                query["PreferenceParameters"] = request.PreferenceParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceResourceGroupShrink))
            {
                query["SourceResourceGroup"] = request.SourceResourceGroupShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceResourcesShrink))
            {
                query["SourceResources"] = request.SourceResourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTagShrink))
            {
                query["SourceTag"] = request.SourceTagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateScratchId))
            {
                query["TemplateScratchId"] = request.TemplateScratchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTemplateScratch",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTemplateScratchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Resource replication scenario</h3>
        /// <para>Resource Orchestration Service (ROS) allows you to update a resource replication scenario. The updates that you make to a resource replication scenario do not affect the stack that is generated by using the resource scenario. You can call the <a href="https://help.aliyun.com/document_detail/610829.html">GenerateTemplateByScratch</a> operation to generate a template for the resource scenario.</para>
        /// <h3><a href="#"></a>Resource migration scenario</h3>
        /// <list type="bullet">
        /// <item><description>If you want to update a resource migration scenario in which the migrated source resources are retained, you can delete the source resources to manage the updated resource migration scenario. You can also call the <a href="https://help.aliyun.com/document_detail/610829.html">GenerateTemplateByScratch</a> operation to generate a template for the resource scenario.
        /// \<em>\</em>
        /// <b>Note</b> Make sure that the source resources that you want to delete from a resource migration scenario are associated only with the resource scenario. Otherwise, the source resources fail to be deleted.</description></item>
        /// <item><description>If you want to update a resource migration scenario in which the migrated source resources are deleted, you can only call the <a href="https://help.aliyun.com/document_detail/610829.html">GenerateTemplateByScratch</a> operation to generate a template for the resource scenario.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Resource management scenario</h3>
        /// <para>If you want to update a resource management scenario after you use the resource scenario to manage resources, you can only call the <a href="https://help.aliyun.com/document_detail/610829.html">GenerateTemplateByScratch</a> operation to generate a template for the resource scenario.</para>
        /// <h3><a href="#"></a>Resource detection scenario</h3>
        /// <para>After you update a resource detection scenario, ROS obtains the most recent data from Resource Center and renders the architecture diagram.
        /// This topic provides an example on how to update a resource scenario. In this example, the ID of a virtual private cloud (VPC) in a resource scenario whose ID is <c>ts-7f7a704cf71c49a6****</c> is updated to <c>vpc-bp1m6fww66xbntjyc****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTemplateScratchRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTemplateScratchResponse
        /// </returns>
        public UpdateTemplateScratchResponse UpdateTemplateScratch(UpdateTemplateScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTemplateScratchWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a scenario.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Resource replication scenario</h3>
        /// <para>Resource Orchestration Service (ROS) allows you to update a resource replication scenario. The updates that you make to a resource replication scenario do not affect the stack that is generated by using the resource scenario. You can call the <a href="https://help.aliyun.com/document_detail/610829.html">GenerateTemplateByScratch</a> operation to generate a template for the resource scenario.</para>
        /// <h3><a href="#"></a>Resource migration scenario</h3>
        /// <list type="bullet">
        /// <item><description>If you want to update a resource migration scenario in which the migrated source resources are retained, you can delete the source resources to manage the updated resource migration scenario. You can also call the <a href="https://help.aliyun.com/document_detail/610829.html">GenerateTemplateByScratch</a> operation to generate a template for the resource scenario.
        /// \<em>\</em>
        /// <b>Note</b> Make sure that the source resources that you want to delete from a resource migration scenario are associated only with the resource scenario. Otherwise, the source resources fail to be deleted.</description></item>
        /// <item><description>If you want to update a resource migration scenario in which the migrated source resources are deleted, you can only call the <a href="https://help.aliyun.com/document_detail/610829.html">GenerateTemplateByScratch</a> operation to generate a template for the resource scenario.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Resource management scenario</h3>
        /// <para>If you want to update a resource management scenario after you use the resource scenario to manage resources, you can only call the <a href="https://help.aliyun.com/document_detail/610829.html">GenerateTemplateByScratch</a> operation to generate a template for the resource scenario.</para>
        /// <h3><a href="#"></a>Resource detection scenario</h3>
        /// <para>After you update a resource detection scenario, ROS obtains the most recent data from Resource Center and renders the architecture diagram.
        /// This topic provides an example on how to update a resource scenario. In this example, the ID of a virtual private cloud (VPC) in a resource scenario whose ID is <c>ts-7f7a704cf71c49a6****</c> is updated to <c>vpc-bp1m6fww66xbntjyc****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTemplateScratchRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTemplateScratchResponse
        /// </returns>
        public async Task<UpdateTemplateScratchResponse> UpdateTemplateScratchAsync(UpdateTemplateScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTemplateScratchWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validates a template that is used to create a stack by specifying template URL or body.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation validates only templates and does not involve user data. RAM authentication is not required.
        /// This topic provides an example of how to validate a stack template. In this example, the <c>TemplateURL</c> of the template file is <c>oss://ros/template/demo</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ValidateTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateTemplateResponse
        /// </returns>
        public ValidateTemplateResponse ValidateTemplateWithOptions(ValidateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateInfoOptions))
            {
                query["UpdateInfoOptions"] = request.UpdateInfoOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidationOption))
            {
                query["ValidationOption"] = request.ValidationOption;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateTemplate",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validates a template that is used to create a stack by specifying template URL or body.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation validates only templates and does not involve user data. RAM authentication is not required.
        /// This topic provides an example of how to validate a stack template. In this example, the <c>TemplateURL</c> of the template file is <c>oss://ros/template/demo</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ValidateTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateTemplateResponse
        /// </returns>
        public async Task<ValidateTemplateResponse> ValidateTemplateWithOptionsAsync(ValidateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateInfoOptions))
            {
                query["UpdateInfoOptions"] = request.UpdateInfoOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidationOption))
            {
                query["ValidationOption"] = request.ValidationOption;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                body["TemplateBody"] = request.TemplateBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateTemplate",
                Version = "2019-09-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validates a template that is used to create a stack by specifying template URL or body.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation validates only templates and does not involve user data. RAM authentication is not required.
        /// This topic provides an example of how to validate a stack template. In this example, the <c>TemplateURL</c> of the template file is <c>oss://ros/template/demo</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ValidateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateTemplateResponse
        /// </returns>
        public ValidateTemplateResponse ValidateTemplate(ValidateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ValidateTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validates a template that is used to create a stack by specifying template URL or body.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation validates only templates and does not involve user data. RAM authentication is not required.
        /// This topic provides an example of how to validate a stack template. In this example, the <c>TemplateURL</c> of the template file is <c>oss://ros/template/demo</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ValidateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateTemplateResponse
        /// </returns>
        public async Task<ValidateTemplateResponse> ValidateTemplateAsync(ValidateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ValidateTemplateWithOptionsAsync(request, runtime);
        }

    }
}
