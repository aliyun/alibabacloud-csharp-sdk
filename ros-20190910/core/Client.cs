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
            this._endpointRule = "central";
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

        public CancelStackOperationResponse CancelStackOperation(CancelStackOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelStackOperationWithOptions(request, runtime);
        }

        public async Task<CancelStackOperationResponse> CancelStackOperationAsync(CancelStackOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelStackOperationWithOptionsAsync(request, runtime);
        }

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

        public CancelUpdateStackResponse CancelUpdateStack(CancelUpdateStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelUpdateStackWithOptions(request, runtime);
        }

        public async Task<CancelUpdateStackResponse> CancelUpdateStackAsync(CancelUpdateStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelUpdateStackWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to continue to create a stack after the stack fails to be created. In this example, the stack whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****` is created in the China (Hangzhou) region.
          *
          * @param request ContinueCreateStackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ContinueCreateStackResponse
         */
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

        /**
          * This topic provides an example on how to continue to create a stack after the stack fails to be created. In this example, the stack whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****` is created in the China (Hangzhou) region.
          *
          * @param request ContinueCreateStackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ContinueCreateStackResponse
         */
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

        /**
          * This topic provides an example on how to continue to create a stack after the stack fails to be created. In this example, the stack whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****` is created in the China (Hangzhou) region.
          *
          * @param request ContinueCreateStackRequest
          * @return ContinueCreateStackResponse
         */
        public ContinueCreateStackResponse ContinueCreateStack(ContinueCreateStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ContinueCreateStackWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to continue to create a stack after the stack fails to be created. In this example, the stack whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****` is created in the China (Hangzhou) region.
          *
          * @param request ContinueCreateStackRequest
          * @return ContinueCreateStackResponse
         */
        public async Task<ContinueCreateStackResponse> ContinueCreateStackAsync(ContinueCreateStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ContinueCreateStackWithOptionsAsync(request, runtime);
        }

        /**
          * ### Limits
          * You can create and execute change sets to update running stacks. For more information about change sets, see [Overview](~~156038~~).
          * ### Usage notes
          * *   A stack can contain up to 20 change sets.
          * *   Change sets reflect only the changes of stacks. Change sets do not reflect whether stacks are updated.
          * *   You cannot use change sets to check the following items: whether the upper limit of your Alibaba Cloud account is reached, whether resources that cannot be updated are updated, and whether your Alibaba Cloud account has permissions to modify resources. These items may cause stack updates to fail. If stacks fail to be updated, Resource Orchestration Service (ROS) rolls back the resources to the original status.
          * In this topic, a change set named `MyChangeSet` is created in the `China (Hangzhou)` region. In this example, the template of the stack whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****` is updated to `{"ROSTemplateFormatVersion":"2015-09-01"}`.
          *
          * @param request CreateChangeSetRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateChangeSetResponse
         */
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

        /**
          * ### Limits
          * You can create and execute change sets to update running stacks. For more information about change sets, see [Overview](~~156038~~).
          * ### Usage notes
          * *   A stack can contain up to 20 change sets.
          * *   Change sets reflect only the changes of stacks. Change sets do not reflect whether stacks are updated.
          * *   You cannot use change sets to check the following items: whether the upper limit of your Alibaba Cloud account is reached, whether resources that cannot be updated are updated, and whether your Alibaba Cloud account has permissions to modify resources. These items may cause stack updates to fail. If stacks fail to be updated, Resource Orchestration Service (ROS) rolls back the resources to the original status.
          * In this topic, a change set named `MyChangeSet` is created in the `China (Hangzhou)` region. In this example, the template of the stack whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****` is updated to `{"ROSTemplateFormatVersion":"2015-09-01"}`.
          *
          * @param request CreateChangeSetRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateChangeSetResponse
         */
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

        /**
          * ### Limits
          * You can create and execute change sets to update running stacks. For more information about change sets, see [Overview](~~156038~~).
          * ### Usage notes
          * *   A stack can contain up to 20 change sets.
          * *   Change sets reflect only the changes of stacks. Change sets do not reflect whether stacks are updated.
          * *   You cannot use change sets to check the following items: whether the upper limit of your Alibaba Cloud account is reached, whether resources that cannot be updated are updated, and whether your Alibaba Cloud account has permissions to modify resources. These items may cause stack updates to fail. If stacks fail to be updated, Resource Orchestration Service (ROS) rolls back the resources to the original status.
          * In this topic, a change set named `MyChangeSet` is created in the `China (Hangzhou)` region. In this example, the template of the stack whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****` is updated to `{"ROSTemplateFormatVersion":"2015-09-01"}`.
          *
          * @param request CreateChangeSetRequest
          * @return CreateChangeSetResponse
         */
        public CreateChangeSetResponse CreateChangeSet(CreateChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateChangeSetWithOptions(request, runtime);
        }

        /**
          * ### Limits
          * You can create and execute change sets to update running stacks. For more information about change sets, see [Overview](~~156038~~).
          * ### Usage notes
          * *   A stack can contain up to 20 change sets.
          * *   Change sets reflect only the changes of stacks. Change sets do not reflect whether stacks are updated.
          * *   You cannot use change sets to check the following items: whether the upper limit of your Alibaba Cloud account is reached, whether resources that cannot be updated are updated, and whether your Alibaba Cloud account has permissions to modify resources. These items may cause stack updates to fail. If stacks fail to be updated, Resource Orchestration Service (ROS) rolls back the resources to the original status.
          * In this topic, a change set named `MyChangeSet` is created in the `China (Hangzhou)` region. In this example, the template of the stack whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****` is updated to `{"ROSTemplateFormatVersion":"2015-09-01"}`.
          *
          * @param request CreateChangeSetRequest
          * @return CreateChangeSetResponse
         */
        public async Task<CreateChangeSetResponse> CreateChangeSetAsync(CreateChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateChangeSetWithOptionsAsync(request, runtime);
        }

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

        public CreateDiagnosticResponse CreateDiagnostic(CreateDiagnosticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDiagnosticWithOptions(request, runtime);
        }

        public async Task<CreateDiagnosticResponse> CreateDiagnosticAsync(CreateDiagnosticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDiagnosticWithOptionsAsync(request, runtime);
        }

        /**
          * A stack is a collection of ROS resources that you can manage as a single unit. To create a collection of resources, you can create a stack. For more information about stacks, see [Overview](~~172973~~).\\
          * When you call the operation, take note of the following limits:
          * *   You can create up to 200 stacks within an Alibaba Cloud account.
          * *   You can create up to 200 resources in a stack.
          * This topic provides an example on how to create a stack named `MyStack` in the China (Hangzhou) region by using a template. In this example, `TemplateBody` is set to `{"ROSTemplateFormatVersion":"2015-09-01"}`.
          *
          * @param request CreateStackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateStackResponse
         */
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

        /**
          * A stack is a collection of ROS resources that you can manage as a single unit. To create a collection of resources, you can create a stack. For more information about stacks, see [Overview](~~172973~~).\\
          * When you call the operation, take note of the following limits:
          * *   You can create up to 200 stacks within an Alibaba Cloud account.
          * *   You can create up to 200 resources in a stack.
          * This topic provides an example on how to create a stack named `MyStack` in the China (Hangzhou) region by using a template. In this example, `TemplateBody` is set to `{"ROSTemplateFormatVersion":"2015-09-01"}`.
          *
          * @param request CreateStackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateStackResponse
         */
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

        /**
          * A stack is a collection of ROS resources that you can manage as a single unit. To create a collection of resources, you can create a stack. For more information about stacks, see [Overview](~~172973~~).\\
          * When you call the operation, take note of the following limits:
          * *   You can create up to 200 stacks within an Alibaba Cloud account.
          * *   You can create up to 200 resources in a stack.
          * This topic provides an example on how to create a stack named `MyStack` in the China (Hangzhou) region by using a template. In this example, `TemplateBody` is set to `{"ROSTemplateFormatVersion":"2015-09-01"}`.
          *
          * @param request CreateStackRequest
          * @return CreateStackResponse
         */
        public CreateStackResponse CreateStack(CreateStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStackWithOptions(request, runtime);
        }

        /**
          * A stack is a collection of ROS resources that you can manage as a single unit. To create a collection of resources, you can create a stack. For more information about stacks, see [Overview](~~172973~~).\\
          * When you call the operation, take note of the following limits:
          * *   You can create up to 200 stacks within an Alibaba Cloud account.
          * *   You can create up to 200 resources in a stack.
          * This topic provides an example on how to create a stack named `MyStack` in the China (Hangzhou) region by using a template. In this example, `TemplateBody` is set to `{"ROSTemplateFormatVersion":"2015-09-01"}`.
          *
          * @param request CreateStackRequest
          * @return CreateStackResponse
         */
        public async Task<CreateStackResponse> CreateStackAsync(CreateStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStackWithOptionsAsync(request, runtime);
        }

        /**
          * A stack group is a collection of ROS stacks that you can manage as a unit. You can use an ROS template of a stack group to create stacks within Alibaba Cloud accounts across regions.
          * You can create a stack group that is granted self-managed or service-managed permissions:
          * *   If you use an Alibaba Cloud account to create a self-managed stack group, the administrator account and the execution account are Alibaba Cloud accounts.
          * *   If you enable a resource directory and use the management account or a delegated administrator account of the resource directory to create a service-managed stack group, the administrator account is the management account or delegated administrator account, and the execution account is a member account of the resource directory.
          * For more information about stack groups, see [Overview](~~154578~~).
          * In this topic, a stack group named `MyStackGroup` is created in the `China (Hangzhou)` region and granted the self-managed permissions. In this example, the template whose ID is `5ecd1e10-b0e9-4389-a565-e4c15efc****` is used.
          *
          * @param tmpReq CreateStackGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateStackGroupResponse
         */
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

        /**
          * A stack group is a collection of ROS stacks that you can manage as a unit. You can use an ROS template of a stack group to create stacks within Alibaba Cloud accounts across regions.
          * You can create a stack group that is granted self-managed or service-managed permissions:
          * *   If you use an Alibaba Cloud account to create a self-managed stack group, the administrator account and the execution account are Alibaba Cloud accounts.
          * *   If you enable a resource directory and use the management account or a delegated administrator account of the resource directory to create a service-managed stack group, the administrator account is the management account or delegated administrator account, and the execution account is a member account of the resource directory.
          * For more information about stack groups, see [Overview](~~154578~~).
          * In this topic, a stack group named `MyStackGroup` is created in the `China (Hangzhou)` region and granted the self-managed permissions. In this example, the template whose ID is `5ecd1e10-b0e9-4389-a565-e4c15efc****` is used.
          *
          * @param tmpReq CreateStackGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateStackGroupResponse
         */
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

        /**
          * A stack group is a collection of ROS stacks that you can manage as a unit. You can use an ROS template of a stack group to create stacks within Alibaba Cloud accounts across regions.
          * You can create a stack group that is granted self-managed or service-managed permissions:
          * *   If you use an Alibaba Cloud account to create a self-managed stack group, the administrator account and the execution account are Alibaba Cloud accounts.
          * *   If you enable a resource directory and use the management account or a delegated administrator account of the resource directory to create a service-managed stack group, the administrator account is the management account or delegated administrator account, and the execution account is a member account of the resource directory.
          * For more information about stack groups, see [Overview](~~154578~~).
          * In this topic, a stack group named `MyStackGroup` is created in the `China (Hangzhou)` region and granted the self-managed permissions. In this example, the template whose ID is `5ecd1e10-b0e9-4389-a565-e4c15efc****` is used.
          *
          * @param request CreateStackGroupRequest
          * @return CreateStackGroupResponse
         */
        public CreateStackGroupResponse CreateStackGroup(CreateStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStackGroupWithOptions(request, runtime);
        }

        /**
          * A stack group is a collection of ROS stacks that you can manage as a unit. You can use an ROS template of a stack group to create stacks within Alibaba Cloud accounts across regions.
          * You can create a stack group that is granted self-managed or service-managed permissions:
          * *   If you use an Alibaba Cloud account to create a self-managed stack group, the administrator account and the execution account are Alibaba Cloud accounts.
          * *   If you enable a resource directory and use the management account or a delegated administrator account of the resource directory to create a service-managed stack group, the administrator account is the management account or delegated administrator account, and the execution account is a member account of the resource directory.
          * For more information about stack groups, see [Overview](~~154578~~).
          * In this topic, a stack group named `MyStackGroup` is created in the `China (Hangzhou)` region and granted the self-managed permissions. In this example, the template whose ID is `5ecd1e10-b0e9-4389-a565-e4c15efc****` is used.
          *
          * @param request CreateStackGroupRequest
          * @return CreateStackGroupResponse
         */
        public async Task<CreateStackGroupResponse> CreateStackGroupAsync(CreateStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStackGroupWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, make sure that a stack group is created. For more information, see [CreateStackGroup](~~151333~~).
          * In this topic, the stack group named `MyStackGroup` is used. The stack group is created in the China (Hangzhou) region and granted the self-managed permissions. In this example, stacks are created by using Alibaba Cloud accounts whose IDs are `151266687691****` and `141261387191****` in the China (Hangzhou) region and China (Beijing) region.
          *
          * @param tmpReq CreateStackInstancesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateStackInstancesResponse
         */
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

        /**
          * Before you call this operation, make sure that a stack group is created. For more information, see [CreateStackGroup](~~151333~~).
          * In this topic, the stack group named `MyStackGroup` is used. The stack group is created in the China (Hangzhou) region and granted the self-managed permissions. In this example, stacks are created by using Alibaba Cloud accounts whose IDs are `151266687691****` and `141261387191****` in the China (Hangzhou) region and China (Beijing) region.
          *
          * @param tmpReq CreateStackInstancesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateStackInstancesResponse
         */
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

        /**
          * Before you call this operation, make sure that a stack group is created. For more information, see [CreateStackGroup](~~151333~~).
          * In this topic, the stack group named `MyStackGroup` is used. The stack group is created in the China (Hangzhou) region and granted the self-managed permissions. In this example, stacks are created by using Alibaba Cloud accounts whose IDs are `151266687691****` and `141261387191****` in the China (Hangzhou) region and China (Beijing) region.
          *
          * @param request CreateStackInstancesRequest
          * @return CreateStackInstancesResponse
         */
        public CreateStackInstancesResponse CreateStackInstances(CreateStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStackInstancesWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, make sure that a stack group is created. For more information, see [CreateStackGroup](~~151333~~).
          * In this topic, the stack group named `MyStackGroup` is used. The stack group is created in the China (Hangzhou) region and granted the self-managed permissions. In this example, stacks are created by using Alibaba Cloud accounts whose IDs are `151266687691****` and `141261387191****` in the China (Hangzhou) region and China (Beijing) region.
          *
          * @param request CreateStackInstancesRequest
          * @return CreateStackInstancesResponse
         */
        public async Task<CreateStackInstancesResponse> CreateStackInstancesAsync(CreateStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStackInstancesWithOptionsAsync(request, runtime);
        }

        /**
          * In this topic, a custom template named `MyTemplate` is created in the `cn-hangzhou` region. The `TemplateBody` parameter of the template is set to `{"ROSTemplateFormatVersion": "2015-09-01"}`.
          *
          * @param request CreateTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateTemplateResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                query["TemplateBody"] = request.TemplateBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        /**
          * In this topic, a custom template named `MyTemplate` is created in the `cn-hangzhou` region. The `TemplateBody` parameter of the template is set to `{"ROSTemplateFormatVersion": "2015-09-01"}`.
          *
          * @param request CreateTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateTemplateResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                query["TemplateBody"] = request.TemplateBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        /**
          * In this topic, a custom template named `MyTemplate` is created in the `cn-hangzhou` region. The `TemplateBody` parameter of the template is set to `{"ROSTemplateFormatVersion": "2015-09-01"}`.
          *
          * @param request CreateTemplateRequest
          * @return CreateTemplateResponse
         */
        public CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTemplateWithOptions(request, runtime);
        }

        /**
          * In this topic, a custom template named `MyTemplate` is created in the `cn-hangzhou` region. The `TemplateBody` parameter of the template is set to `{"ROSTemplateFormatVersion": "2015-09-01"}`.
          *
          * @param request CreateTemplateRequest
          * @return CreateTemplateResponse
         */
        public async Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTemplateWithOptionsAsync(request, runtime);
        }

        /**
          * ###
          * You can call this operation to create a scenario that allows you to specify a resource scope on a visualized interface and easily replicate and manage the resources that you specify. For more information about scenarios, see [Overview](~~352074~~).
          * In this example, a scenario of the Resource Replication type is created in the China (Hangzhou) region. In the scenario, the virtual private cloud (VPC) whose ID is `vpc-bp1m6fww66xbntjyc****` is replicated.
          *
          * @param tmpReq CreateTemplateScratchRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateTemplateScratchResponse
         */
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

        /**
          * ###
          * You can call this operation to create a scenario that allows you to specify a resource scope on a visualized interface and easily replicate and manage the resources that you specify. For more information about scenarios, see [Overview](~~352074~~).
          * In this example, a scenario of the Resource Replication type is created in the China (Hangzhou) region. In the scenario, the virtual private cloud (VPC) whose ID is `vpc-bp1m6fww66xbntjyc****` is replicated.
          *
          * @param tmpReq CreateTemplateScratchRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateTemplateScratchResponse
         */
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

        /**
          * ###
          * You can call this operation to create a scenario that allows you to specify a resource scope on a visualized interface and easily replicate and manage the resources that you specify. For more information about scenarios, see [Overview](~~352074~~).
          * In this example, a scenario of the Resource Replication type is created in the China (Hangzhou) region. In the scenario, the virtual private cloud (VPC) whose ID is `vpc-bp1m6fww66xbntjyc****` is replicated.
          *
          * @param request CreateTemplateScratchRequest
          * @return CreateTemplateScratchResponse
         */
        public CreateTemplateScratchResponse CreateTemplateScratch(CreateTemplateScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTemplateScratchWithOptions(request, runtime);
        }

        /**
          * ###
          * You can call this operation to create a scenario that allows you to specify a resource scope on a visualized interface and easily replicate and manage the resources that you specify. For more information about scenarios, see [Overview](~~352074~~).
          * In this example, a scenario of the Resource Replication type is created in the China (Hangzhou) region. In the scenario, the virtual private cloud (VPC) whose ID is `vpc-bp1m6fww66xbntjyc****` is replicated.
          *
          * @param request CreateTemplateScratchRequest
          * @return CreateTemplateScratchResponse
         */
        public async Task<CreateTemplateScratchResponse> CreateTemplateScratchAsync(CreateTemplateScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTemplateScratchWithOptionsAsync(request, runtime);
        }

        /**
          * *   Before you call this operation, make sure that the following requirements are met:
          *     *   The status of the change set is CREATE_COMPLETE, CREATE_FAILED, or DELETE_FAILED.
          *     *   The execution status is UNAVAILABLE or AVAILABLE.
          * *   After a change set is executed, other change sets associated with the same stack as this change set are also deleted.
          * *   After a stack is deleted, change sets associated with the stack are deleted.
          * *   If a change set of the CREATE type is deleted, you must delete stacks associated with the change set.
          * In this example, a change set whose ID is `1f6521a4-05af-4975-afe9-bc4b45ad****` is deleted. The change set is created in the China (Hangzhou) region.
          *
          * @param request DeleteChangeSetRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteChangeSetResponse
         */
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

        /**
          * *   Before you call this operation, make sure that the following requirements are met:
          *     *   The status of the change set is CREATE_COMPLETE, CREATE_FAILED, or DELETE_FAILED.
          *     *   The execution status is UNAVAILABLE or AVAILABLE.
          * *   After a change set is executed, other change sets associated with the same stack as this change set are also deleted.
          * *   After a stack is deleted, change sets associated with the stack are deleted.
          * *   If a change set of the CREATE type is deleted, you must delete stacks associated with the change set.
          * In this example, a change set whose ID is `1f6521a4-05af-4975-afe9-bc4b45ad****` is deleted. The change set is created in the China (Hangzhou) region.
          *
          * @param request DeleteChangeSetRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteChangeSetResponse
         */
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

        /**
          * *   Before you call this operation, make sure that the following requirements are met:
          *     *   The status of the change set is CREATE_COMPLETE, CREATE_FAILED, or DELETE_FAILED.
          *     *   The execution status is UNAVAILABLE or AVAILABLE.
          * *   After a change set is executed, other change sets associated with the same stack as this change set are also deleted.
          * *   After a stack is deleted, change sets associated with the stack are deleted.
          * *   If a change set of the CREATE type is deleted, you must delete stacks associated with the change set.
          * In this example, a change set whose ID is `1f6521a4-05af-4975-afe9-bc4b45ad****` is deleted. The change set is created in the China (Hangzhou) region.
          *
          * @param request DeleteChangeSetRequest
          * @return DeleteChangeSetResponse
         */
        public DeleteChangeSetResponse DeleteChangeSet(DeleteChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteChangeSetWithOptions(request, runtime);
        }

        /**
          * *   Before you call this operation, make sure that the following requirements are met:
          *     *   The status of the change set is CREATE_COMPLETE, CREATE_FAILED, or DELETE_FAILED.
          *     *   The execution status is UNAVAILABLE or AVAILABLE.
          * *   After a change set is executed, other change sets associated with the same stack as this change set are also deleted.
          * *   After a stack is deleted, change sets associated with the stack are deleted.
          * *   If a change set of the CREATE type is deleted, you must delete stacks associated with the change set.
          * In this example, a change set whose ID is `1f6521a4-05af-4975-afe9-bc4b45ad****` is deleted. The change set is created in the China (Hangzhou) region.
          *
          * @param request DeleteChangeSetRequest
          * @return DeleteChangeSetResponse
         */
        public async Task<DeleteChangeSetResponse> DeleteChangeSetAsync(DeleteChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteChangeSetWithOptionsAsync(request, runtime);
        }

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

        public DeleteDiagnosticResponse DeleteDiagnostic(DeleteDiagnosticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDiagnosticWithOptions(request, runtime);
        }

        public async Task<DeleteDiagnosticResponse> DeleteDiagnosticAsync(DeleteDiagnosticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDiagnosticWithOptionsAsync(request, runtime);
        }

        public DeleteStackResponse DeleteStackWithOptions(DeleteStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteOptions))
            {
                query["DeleteOptions"] = request.DeleteOptions;
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

        public async Task<DeleteStackResponse> DeleteStackWithOptionsAsync(DeleteStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteOptions))
            {
                query["DeleteOptions"] = request.DeleteOptions;
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

        public DeleteStackResponse DeleteStack(DeleteStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteStackWithOptions(request, runtime);
        }

        public async Task<DeleteStackResponse> DeleteStackAsync(DeleteStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteStackWithOptionsAsync(request, runtime);
        }

        /**
          * A stack group can be deleted only when the stack group does not contain stacks. You can call the [DeleteStackInstances](~~151715~~) operation to delete stacks.
          * This topic provides an example on how to delete a stack group. In this example, a stack group named `MyStackGroup` in the China (Hangzhou) region is deleted.
          *
          * @param request DeleteStackGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteStackGroupResponse
         */
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

        /**
          * A stack group can be deleted only when the stack group does not contain stacks. You can call the [DeleteStackInstances](~~151715~~) operation to delete stacks.
          * This topic provides an example on how to delete a stack group. In this example, a stack group named `MyStackGroup` in the China (Hangzhou) region is deleted.
          *
          * @param request DeleteStackGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteStackGroupResponse
         */
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

        /**
          * A stack group can be deleted only when the stack group does not contain stacks. You can call the [DeleteStackInstances](~~151715~~) operation to delete stacks.
          * This topic provides an example on how to delete a stack group. In this example, a stack group named `MyStackGroup` in the China (Hangzhou) region is deleted.
          *
          * @param request DeleteStackGroupRequest
          * @return DeleteStackGroupResponse
         */
        public DeleteStackGroupResponse DeleteStackGroup(DeleteStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteStackGroupWithOptions(request, runtime);
        }

        /**
          * A stack group can be deleted only when the stack group does not contain stacks. You can call the [DeleteStackInstances](~~151715~~) operation to delete stacks.
          * This topic provides an example on how to delete a stack group. In this example, a stack group named `MyStackGroup` in the China (Hangzhou) region is deleted.
          *
          * @param request DeleteStackGroupRequest
          * @return DeleteStackGroupResponse
         */
        public async Task<DeleteStackGroupResponse> DeleteStackGroupAsync(DeleteStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteStackGroupWithOptionsAsync(request, runtime);
        }

        /**
          * In this topic, the stack group named `MyStackGroup` that is created in the China (Hangzhou) region is used. In this example, the stacks of the stack group that are deployed in the China (Beijing) region by using the Alibaba Cloud account whose ID is `151266687691****` are deleted.
          *
          * @param tmpReq DeleteStackInstancesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteStackInstancesResponse
         */
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

        /**
          * In this topic, the stack group named `MyStackGroup` that is created in the China (Hangzhou) region is used. In this example, the stacks of the stack group that are deployed in the China (Beijing) region by using the Alibaba Cloud account whose ID is `151266687691****` are deleted.
          *
          * @param tmpReq DeleteStackInstancesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteStackInstancesResponse
         */
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

        /**
          * In this topic, the stack group named `MyStackGroup` that is created in the China (Hangzhou) region is used. In this example, the stacks of the stack group that are deployed in the China (Beijing) region by using the Alibaba Cloud account whose ID is `151266687691****` are deleted.
          *
          * @param request DeleteStackInstancesRequest
          * @return DeleteStackInstancesResponse
         */
        public DeleteStackInstancesResponse DeleteStackInstances(DeleteStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteStackInstancesWithOptions(request, runtime);
        }

        /**
          * In this topic, the stack group named `MyStackGroup` that is created in the China (Hangzhou) region is used. In this example, the stacks of the stack group that are deployed in the China (Beijing) region by using the Alibaba Cloud account whose ID is `151266687691****` are deleted.
          *
          * @param request DeleteStackInstancesRequest
          * @return DeleteStackInstancesResponse
         */
        public async Task<DeleteStackInstancesResponse> DeleteStackInstancesAsync(DeleteStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteStackInstancesWithOptionsAsync(request, runtime);
        }

        /**
          * If a template is shared with other Alibaba Cloud accounts, you must unshare the template before you delete it.
          *
          * @param request DeleteTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteTemplateResponse
         */
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

        /**
          * If a template is shared with other Alibaba Cloud accounts, you must unshare the template before you delete it.
          *
          * @param request DeleteTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteTemplateResponse
         */
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

        /**
          * If a template is shared with other Alibaba Cloud accounts, you must unshare the template before you delete it.
          *
          * @param request DeleteTemplateRequest
          * @return DeleteTemplateResponse
         */
        public DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTemplateWithOptions(request, runtime);
        }

        /**
          * If a template is shared with other Alibaba Cloud accounts, you must unshare the template before you delete it.
          *
          * @param request DeleteTemplateRequest
          * @return DeleteTemplateResponse
         */
        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTemplateWithOptionsAsync(request, runtime);
        }

        /**
          * In this topic, a scenario whose ID is `ts-4f83704400994409****` is deleted in the China (Hangzhou) region.
          *
          * @param request DeleteTemplateScratchRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteTemplateScratchResponse
         */
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

        /**
          * In this topic, a scenario whose ID is `ts-4f83704400994409****` is deleted in the China (Hangzhou) region.
          *
          * @param request DeleteTemplateScratchRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteTemplateScratchResponse
         */
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

        /**
          * In this topic, a scenario whose ID is `ts-4f83704400994409****` is deleted in the China (Hangzhou) region.
          *
          * @param request DeleteTemplateScratchRequest
          * @return DeleteTemplateScratchResponse
         */
        public DeleteTemplateScratchResponse DeleteTemplateScratch(DeleteTemplateScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTemplateScratchWithOptions(request, runtime);
        }

        /**
          * In this topic, a scenario whose ID is `ts-4f83704400994409****` is deleted in the China (Hangzhou) region.
          *
          * @param request DeleteTemplateScratchRequest
          * @return DeleteTemplateScratchResponse
         */
        public async Task<DeleteTemplateScratchResponse> DeleteTemplateScratchAsync(DeleteTemplateScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTemplateScratchWithOptionsAsync(request, runtime);
        }

        /**
          * *   If you delete a resource type, you can no longer use the resource type in Resource Orchestration Service (ROS).
          * *   If you delete a version of a resource type, you can no longer use the version in ROS.
          * *   If a resource type has only one version, you can delete the version by calling the operation. If a resource type has more than one version, you must manually delete the remaining versions.
          * *   When a resource type has more than one version, you cannot delete the default version by calling the operation.
          * *   When a resource type has only one version, you can delete the resource type and the version by calling the operation.
          *
          * @param request DeregisterResourceTypeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeregisterResourceTypeResponse
         */
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

        /**
          * *   If you delete a resource type, you can no longer use the resource type in Resource Orchestration Service (ROS).
          * *   If you delete a version of a resource type, you can no longer use the version in ROS.
          * *   If a resource type has only one version, you can delete the version by calling the operation. If a resource type has more than one version, you must manually delete the remaining versions.
          * *   When a resource type has more than one version, you cannot delete the default version by calling the operation.
          * *   When a resource type has only one version, you can delete the resource type and the version by calling the operation.
          *
          * @param request DeregisterResourceTypeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeregisterResourceTypeResponse
         */
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

        /**
          * *   If you delete a resource type, you can no longer use the resource type in Resource Orchestration Service (ROS).
          * *   If you delete a version of a resource type, you can no longer use the version in ROS.
          * *   If a resource type has only one version, you can delete the version by calling the operation. If a resource type has more than one version, you must manually delete the remaining versions.
          * *   When a resource type has more than one version, you cannot delete the default version by calling the operation.
          * *   When a resource type has only one version, you can delete the resource type and the version by calling the operation.
          *
          * @param request DeregisterResourceTypeRequest
          * @return DeregisterResourceTypeResponse
         */
        public DeregisterResourceTypeResponse DeregisterResourceType(DeregisterResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeregisterResourceTypeWithOptions(request, runtime);
        }

        /**
          * *   If you delete a resource type, you can no longer use the resource type in Resource Orchestration Service (ROS).
          * *   If you delete a version of a resource type, you can no longer use the version in ROS.
          * *   If a resource type has only one version, you can delete the version by calling the operation. If a resource type has more than one version, you must manually delete the remaining versions.
          * *   When a resource type has more than one version, you cannot delete the default version by calling the operation.
          * *   When a resource type has only one version, you can delete the resource type and the version by calling the operation.
          *
          * @param request DeregisterResourceTypeRequest
          * @return DeregisterResourceTypeResponse
         */
        public async Task<DeregisterResourceTypeResponse> DeregisterResourceTypeAsync(DeregisterResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeregisterResourceTypeWithOptionsAsync(request, runtime);
        }

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

        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

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

        public DetectStackDriftResponse DetectStackDrift(DetectStackDriftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectStackDriftWithOptions(request, runtime);
        }

        public async Task<DetectStackDriftResponse> DetectStackDriftAsync(DetectStackDriftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectStackDriftWithOptionsAsync(request, runtime);
        }

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

        public DetectStackGroupDriftResponse DetectStackGroupDrift(DetectStackGroupDriftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectStackGroupDriftWithOptions(request, runtime);
        }

        public async Task<DetectStackGroupDriftResponse> DetectStackGroupDriftAsync(DetectStackGroupDriftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectStackGroupDriftWithOptionsAsync(request, runtime);
        }

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

        public DetectStackResourceDriftResponse DetectStackResourceDrift(DetectStackResourceDriftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectStackResourceDriftWithOptions(request, runtime);
        }

        public async Task<DetectStackResourceDriftResponse> DetectStackResourceDriftAsync(DetectStackResourceDriftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectStackResourceDriftWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, the change set whose ID is `1f6521a4-05af-4975-afe9-bc4b45ad****` is executed. The change set is created in the `China (Hangzhou)` region.
          *
          * @param request ExecuteChangeSetRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ExecuteChangeSetResponse
         */
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

        /**
          * In this example, the change set whose ID is `1f6521a4-05af-4975-afe9-bc4b45ad****` is executed. The change set is created in the `China (Hangzhou)` region.
          *
          * @param request ExecuteChangeSetRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ExecuteChangeSetResponse
         */
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

        /**
          * In this example, the change set whose ID is `1f6521a4-05af-4975-afe9-bc4b45ad****` is executed. The change set is created in the `China (Hangzhou)` region.
          *
          * @param request ExecuteChangeSetRequest
          * @return ExecuteChangeSetResponse
         */
        public ExecuteChangeSetResponse ExecuteChangeSet(ExecuteChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteChangeSetWithOptions(request, runtime);
        }

        /**
          * In this example, the change set whose ID is `1f6521a4-05af-4975-afe9-bc4b45ad****` is executed. The change set is created in the `China (Hangzhou)` region.
          *
          * @param request ExecuteChangeSetRequest
          * @return ExecuteChangeSetResponse
         */
        public async Task<ExecuteChangeSetResponse> ExecuteChangeSetAsync(ExecuteChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteChangeSetWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, a template is created for the scenario whose ID is `ts-aa9c62feab844a6b****`. The scenario is of the Resource Management type and resides in the China (Hangzhou) region.
          *
          * @param request GenerateTemplateByScratchRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GenerateTemplateByScratchResponse
         */
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

        /**
          * In this example, a template is created for the scenario whose ID is `ts-aa9c62feab844a6b****`. The scenario is of the Resource Management type and resides in the China (Hangzhou) region.
          *
          * @param request GenerateTemplateByScratchRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GenerateTemplateByScratchResponse
         */
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

        /**
          * In this example, a template is created for the scenario whose ID is `ts-aa9c62feab844a6b****`. The scenario is of the Resource Management type and resides in the China (Hangzhou) region.
          *
          * @param request GenerateTemplateByScratchRequest
          * @return GenerateTemplateByScratchResponse
         */
        public GenerateTemplateByScratchResponse GenerateTemplateByScratch(GenerateTemplateByScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateTemplateByScratchWithOptions(request, runtime);
        }

        /**
          * In this example, a template is created for the scenario whose ID is `ts-aa9c62feab844a6b****`. The scenario is of the Resource Management type and resides in the China (Hangzhou) region.
          *
          * @param request GenerateTemplateByScratchRequest
          * @return GenerateTemplateByScratchResponse
         */
        public async Task<GenerateTemplateByScratchResponse> GenerateTemplateByScratchAsync(GenerateTemplateByScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateTemplateByScratchWithOptionsAsync(request, runtime);
        }

        /**
          * If the policy information is related to Enterprise Distributed Application Service (EDAS), you must log on to your Alibaba Cloud account and grant the required permissions to the relevant RAM users.
          * In this example, a policy is generated for a template whose ID is `5ecd1e10-b0e9-4389-a565-e4c15efc****`.
          *
          * @param request GenerateTemplatePolicyRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GenerateTemplatePolicyResponse
         */
        public GenerateTemplatePolicyResponse GenerateTemplatePolicyWithOptions(GenerateTemplatePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationTypes))
            {
                query["OperationTypes"] = request.OperationTypes;
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

        /**
          * If the policy information is related to Enterprise Distributed Application Service (EDAS), you must log on to your Alibaba Cloud account and grant the required permissions to the relevant RAM users.
          * In this example, a policy is generated for a template whose ID is `5ecd1e10-b0e9-4389-a565-e4c15efc****`.
          *
          * @param request GenerateTemplatePolicyRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GenerateTemplatePolicyResponse
         */
        public async Task<GenerateTemplatePolicyResponse> GenerateTemplatePolicyWithOptionsAsync(GenerateTemplatePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationTypes))
            {
                query["OperationTypes"] = request.OperationTypes;
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

        /**
          * If the policy information is related to Enterprise Distributed Application Service (EDAS), you must log on to your Alibaba Cloud account and grant the required permissions to the relevant RAM users.
          * In this example, a policy is generated for a template whose ID is `5ecd1e10-b0e9-4389-a565-e4c15efc****`.
          *
          * @param request GenerateTemplatePolicyRequest
          * @return GenerateTemplatePolicyResponse
         */
        public GenerateTemplatePolicyResponse GenerateTemplatePolicy(GenerateTemplatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateTemplatePolicyWithOptions(request, runtime);
        }

        /**
          * If the policy information is related to Enterprise Distributed Application Service (EDAS), you must log on to your Alibaba Cloud account and grant the required permissions to the relevant RAM users.
          * In this example, a policy is generated for a template whose ID is `5ecd1e10-b0e9-4389-a565-e4c15efc****`.
          *
          * @param request GenerateTemplatePolicyRequest
          * @return GenerateTemplatePolicyResponse
         */
        public async Task<GenerateTemplatePolicyResponse> GenerateTemplatePolicyAsync(GenerateTemplatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateTemplatePolicyWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, the details of a change set whose ID is `4c11658d-bd47-4dd0-ba64-727edc62****` is queried. The change set is created in the China (Hangzhou) region.
          *
          * @param request GetChangeSetRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetChangeSetResponse
         */
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

        /**
          * In this example, the details of a change set whose ID is `4c11658d-bd47-4dd0-ba64-727edc62****` is queried. The change set is created in the China (Hangzhou) region.
          *
          * @param request GetChangeSetRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetChangeSetResponse
         */
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

        /**
          * In this example, the details of a change set whose ID is `4c11658d-bd47-4dd0-ba64-727edc62****` is queried. The change set is created in the China (Hangzhou) region.
          *
          * @param request GetChangeSetRequest
          * @return GetChangeSetResponse
         */
        public GetChangeSetResponse GetChangeSet(GetChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetChangeSetWithOptions(request, runtime);
        }

        /**
          * In this example, the details of a change set whose ID is `4c11658d-bd47-4dd0-ba64-727edc62****` is queried. The change set is created in the China (Hangzhou) region.
          *
          * @param request GetChangeSetRequest
          * @return GetChangeSetResponse
         */
        public async Task<GetChangeSetResponse> GetChangeSetAsync(GetChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetChangeSetWithOptionsAsync(request, runtime);
        }

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

        public GetDiagnosticResponse GetDiagnostic(GetDiagnosticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDiagnosticWithOptions(request, runtime);
        }

        public async Task<GetDiagnosticResponse> GetDiagnosticAsync(GetDiagnosticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDiagnosticWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation to query the Terraform hosting, resource cleaner, and scenario features.
          * This topic provides an example on how to query the details of features supported by ROS in the China (Hangzhou) region. The details include Terraform versions, provider versions, and supported resource types.
          * >  In the Examples section, only part of the sample code is provided.
          *
          * @param request GetFeatureDetailsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetFeatureDetailsResponse
         */
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

        /**
          * You can call this operation to query the Terraform hosting, resource cleaner, and scenario features.
          * This topic provides an example on how to query the details of features supported by ROS in the China (Hangzhou) region. The details include Terraform versions, provider versions, and supported resource types.
          * >  In the Examples section, only part of the sample code is provided.
          *
          * @param request GetFeatureDetailsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetFeatureDetailsResponse
         */
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

        /**
          * You can call this operation to query the Terraform hosting, resource cleaner, and scenario features.
          * This topic provides an example on how to query the details of features supported by ROS in the China (Hangzhou) region. The details include Terraform versions, provider versions, and supported resource types.
          * >  In the Examples section, only part of the sample code is provided.
          *
          * @param request GetFeatureDetailsRequest
          * @return GetFeatureDetailsResponse
         */
        public GetFeatureDetailsResponse GetFeatureDetails(GetFeatureDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFeatureDetailsWithOptions(request, runtime);
        }

        /**
          * You can call this operation to query the Terraform hosting, resource cleaner, and scenario features.
          * This topic provides an example on how to query the details of features supported by ROS in the China (Hangzhou) region. The details include Terraform versions, provider versions, and supported resource types.
          * >  In the Examples section, only part of the sample code is provided.
          *
          * @param request GetFeatureDetailsRequest
          * @return GetFeatureDetailsResponse
         */
        public async Task<GetFeatureDetailsResponse> GetFeatureDetailsAsync(GetFeatureDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFeatureDetailsWithOptionsAsync(request, runtime);
        }

        /**
          * For more information about common request parameters, see [Common parameters](~~131957~~).
          *
          * @param request GetResourceTypeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetResourceTypeResponse
         */
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

        /**
          * For more information about common request parameters, see [Common parameters](~~131957~~).
          *
          * @param request GetResourceTypeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetResourceTypeResponse
         */
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

        /**
          * For more information about common request parameters, see [Common parameters](~~131957~~).
          *
          * @param request GetResourceTypeRequest
          * @return GetResourceTypeResponse
         */
        public GetResourceTypeResponse GetResourceType(GetResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceTypeWithOptions(request, runtime);
        }

        /**
          * For more information about common request parameters, see [Common parameters](~~131957~~).
          *
          * @param request GetResourceTypeRequest
          * @return GetResourceTypeResponse
         */
        public async Task<GetResourceTypeResponse> GetResourceTypeAsync(GetResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceTypeWithOptionsAsync(request, runtime);
        }

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

        public GetResourceTypeTemplateResponse GetResourceTypeTemplate(GetResourceTypeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceTypeTemplateWithOptions(request, runtime);
        }

        public async Task<GetResourceTypeTemplateResponse> GetResourceTypeTemplateAsync(GetResourceTypeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceTypeTemplateWithOptionsAsync(request, runtime);
        }

        /**
          * ### Description
          * This topic describes how to query the activation status and the RAM roles of an Alibaba Cloud service. In this example, the Elastic High Performance Computing (E-HPC) service that is deployed in the China (Hangzhou) region is queried.
          * > Make sure that you have the permissions to call the [GetRole](~~28711~~) operation.
          *
          * @param request GetServiceProvisionsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetServiceProvisionsResponse
         */
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

        /**
          * ### Description
          * This topic describes how to query the activation status and the RAM roles of an Alibaba Cloud service. In this example, the Elastic High Performance Computing (E-HPC) service that is deployed in the China (Hangzhou) region is queried.
          * > Make sure that you have the permissions to call the [GetRole](~~28711~~) operation.
          *
          * @param request GetServiceProvisionsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetServiceProvisionsResponse
         */
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

        /**
          * ### Description
          * This topic describes how to query the activation status and the RAM roles of an Alibaba Cloud service. In this example, the Elastic High Performance Computing (E-HPC) service that is deployed in the China (Hangzhou) region is queried.
          * > Make sure that you have the permissions to call the [GetRole](~~28711~~) operation.
          *
          * @param request GetServiceProvisionsRequest
          * @return GetServiceProvisionsResponse
         */
        public GetServiceProvisionsResponse GetServiceProvisions(GetServiceProvisionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceProvisionsWithOptions(request, runtime);
        }

        /**
          * ### Description
          * This topic describes how to query the activation status and the RAM roles of an Alibaba Cloud service. In this example, the Elastic High Performance Computing (E-HPC) service that is deployed in the China (Hangzhou) region is queried.
          * > Make sure that you have the permissions to call the [GetRole](~~28711~~) operation.
          *
          * @param request GetServiceProvisionsRequest
          * @return GetServiceProvisionsResponse
         */
        public async Task<GetServiceProvisionsResponse> GetServiceProvisionsAsync(GetServiceProvisionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceProvisionsWithOptionsAsync(request, runtime);
        }

        /**
          * In this topic, the information about a stack whose ID is `c754d2a4-28f1-46df-b557-9586173a****` is queried. The stack is deployed in the China (Hangzhou) region.
          *
          * @param request GetStackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetStackResponse
         */
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

        /**
          * In this topic, the information about a stack whose ID is `c754d2a4-28f1-46df-b557-9586173a****` is queried. The stack is deployed in the China (Hangzhou) region.
          *
          * @param request GetStackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetStackResponse
         */
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

        /**
          * In this topic, the information about a stack whose ID is `c754d2a4-28f1-46df-b557-9586173a****` is queried. The stack is deployed in the China (Hangzhou) region.
          *
          * @param request GetStackRequest
          * @return GetStackResponse
         */
        public GetStackResponse GetStack(GetStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStackWithOptions(request, runtime);
        }

        /**
          * In this topic, the information about a stack whose ID is `c754d2a4-28f1-46df-b557-9586173a****` is queried. The stack is deployed in the China (Hangzhou) region.
          *
          * @param request GetStackRequest
          * @return GetStackResponse
         */
        public async Task<GetStackResponse> GetStackAsync(GetStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStackWithOptionsAsync(request, runtime);
        }

        /**
          * In this topic, the status of a drift detection operation whose ID is `a7044f0d-6f2e-4128-a307-4524ef88****` is queried. The operation is performed in the China (Hangzhou) region.
          *
          * @param request GetStackDriftDetectionStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetStackDriftDetectionStatusResponse
         */
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

        /**
          * In this topic, the status of a drift detection operation whose ID is `a7044f0d-6f2e-4128-a307-4524ef88****` is queried. The operation is performed in the China (Hangzhou) region.
          *
          * @param request GetStackDriftDetectionStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetStackDriftDetectionStatusResponse
         */
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

        /**
          * In this topic, the status of a drift detection operation whose ID is `a7044f0d-6f2e-4128-a307-4524ef88****` is queried. The operation is performed in the China (Hangzhou) region.
          *
          * @param request GetStackDriftDetectionStatusRequest
          * @return GetStackDriftDetectionStatusResponse
         */
        public GetStackDriftDetectionStatusResponse GetStackDriftDetectionStatus(GetStackDriftDetectionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStackDriftDetectionStatusWithOptions(request, runtime);
        }

        /**
          * In this topic, the status of a drift detection operation whose ID is `a7044f0d-6f2e-4128-a307-4524ef88****` is queried. The operation is performed in the China (Hangzhou) region.
          *
          * @param request GetStackDriftDetectionStatusRequest
          * @return GetStackDriftDetectionStatusResponse
         */
        public async Task<GetStackDriftDetectionStatusResponse> GetStackDriftDetectionStatusAsync(GetStackDriftDetectionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStackDriftDetectionStatusWithOptionsAsync(request, runtime);
        }

        /**
          * For more information about common request parameters, see [Common parameters](~~131957~~).
          *
          * @param request GetStackGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetStackGroupResponse
         */
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

        /**
          * For more information about common request parameters, see [Common parameters](~~131957~~).
          *
          * @param request GetStackGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetStackGroupResponse
         */
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

        /**
          * For more information about common request parameters, see [Common parameters](~~131957~~).
          *
          * @param request GetStackGroupRequest
          * @return GetStackGroupResponse
         */
        public GetStackGroupResponse GetStackGroup(GetStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStackGroupWithOptions(request, runtime);
        }

        /**
          * For more information about common request parameters, see [Common parameters](~~131957~~).
          *
          * @param request GetStackGroupRequest
          * @return GetStackGroupResponse
         */
        public async Task<GetStackGroupResponse> GetStackGroupAsync(GetStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStackGroupWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, the information about the stack group operation whose ID is `6da106ca-1784-4a6f-a7e1-e723863d****` is queried. The stack group named `MyStackGroup` is granted self-managed permissions and deployed in the China (Hangzhou) region.
          *
          * @param request GetStackGroupOperationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetStackGroupOperationResponse
         */
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

        /**
          * In this example, the information about the stack group operation whose ID is `6da106ca-1784-4a6f-a7e1-e723863d****` is queried. The stack group named `MyStackGroup` is granted self-managed permissions and deployed in the China (Hangzhou) region.
          *
          * @param request GetStackGroupOperationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetStackGroupOperationResponse
         */
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

        /**
          * In this example, the information about the stack group operation whose ID is `6da106ca-1784-4a6f-a7e1-e723863d****` is queried. The stack group named `MyStackGroup` is granted self-managed permissions and deployed in the China (Hangzhou) region.
          *
          * @param request GetStackGroupOperationRequest
          * @return GetStackGroupOperationResponse
         */
        public GetStackGroupOperationResponse GetStackGroupOperation(GetStackGroupOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStackGroupOperationWithOptions(request, runtime);
        }

        /**
          * In this example, the information about the stack group operation whose ID is `6da106ca-1784-4a6f-a7e1-e723863d****` is queried. The stack group named `MyStackGroup` is granted self-managed permissions and deployed in the China (Hangzhou) region.
          *
          * @param request GetStackGroupOperationRequest
          * @return GetStackGroupOperationResponse
         */
        public async Task<GetStackGroupOperationResponse> GetStackGroupOperationAsync(GetStackGroupOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStackGroupOperationWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, the information about a stack instance associated with a stack group named `MyStackGroup` is queried. The stack instance is deployed in the China (Beijing) region within the `151266687691****` Alibaba Cloud account. The stack group is granted self-managed permissions and deployed in the China (Hangzhou) region.
          *
          * @param request GetStackInstanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetStackInstanceResponse
         */
        public GetStackInstanceResponse GetStackInstanceWithOptions(GetStackInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
          * In this example, the information about a stack instance associated with a stack group named `MyStackGroup` is queried. The stack instance is deployed in the China (Beijing) region within the `151266687691****` Alibaba Cloud account. The stack group is granted self-managed permissions and deployed in the China (Hangzhou) region.
          *
          * @param request GetStackInstanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetStackInstanceResponse
         */
        public async Task<GetStackInstanceResponse> GetStackInstanceWithOptionsAsync(GetStackInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
          * In this example, the information about a stack instance associated with a stack group named `MyStackGroup` is queried. The stack instance is deployed in the China (Beijing) region within the `151266687691****` Alibaba Cloud account. The stack group is granted self-managed permissions and deployed in the China (Hangzhou) region.
          *
          * @param request GetStackInstanceRequest
          * @return GetStackInstanceResponse
         */
        public GetStackInstanceResponse GetStackInstance(GetStackInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStackInstanceWithOptions(request, runtime);
        }

        /**
          * In this example, the information about a stack instance associated with a stack group named `MyStackGroup` is queried. The stack instance is deployed in the China (Beijing) region within the `151266687691****` Alibaba Cloud account. The stack group is granted self-managed permissions and deployed in the China (Hangzhou) region.
          *
          * @param request GetStackInstanceRequest
          * @return GetStackInstanceResponse
         */
        public async Task<GetStackInstanceResponse> GetStackInstanceAsync(GetStackInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStackInstanceWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, the stack policy of a stack whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****` is queried. The stack is deployed in the China (Hangzhou) region.
          *
          * @param request GetStackPolicyRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetStackPolicyResponse
         */
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

        /**
          * In this example, the stack policy of a stack whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****` is queried. The stack is deployed in the China (Hangzhou) region.
          *
          * @param request GetStackPolicyRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetStackPolicyResponse
         */
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

        /**
          * In this example, the stack policy of a stack whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****` is queried. The stack is deployed in the China (Hangzhou) region.
          *
          * @param request GetStackPolicyRequest
          * @return GetStackPolicyResponse
         */
        public GetStackPolicyResponse GetStackPolicy(GetStackPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStackPolicyWithOptions(request, runtime);
        }

        /**
          * In this example, the stack policy of a stack whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****` is queried. The stack is deployed in the China (Hangzhou) region.
          *
          * @param request GetStackPolicyRequest
          * @return GetStackPolicyResponse
         */
        public async Task<GetStackPolicyResponse> GetStackPolicyAsync(GetStackPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStackPolicyWithOptionsAsync(request, runtime);
        }

        /**
          * | Http status code | Error code | Error message | Description |
          * | ---------------- | ---------- | ------------- | ----------- |
          * | 404 | ResourceNotFound | The Resource ({name}) could not be found in Stack {stack}. | The error message returned because the specified resource does not exist in the stack. name indicates the resource name. stack indicates the stack name or ID. |
          * | 404 | StackNotFound | The Stack ({name}) could not be found. | The error message returned because the stack does not exist. name indicates the name or ID of the stack. |
          *
          * @param request GetStackResourceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetStackResourceResponse
         */
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

        /**
          * | Http status code | Error code | Error message | Description |
          * | ---------------- | ---------- | ------------- | ----------- |
          * | 404 | ResourceNotFound | The Resource ({name}) could not be found in Stack {stack}. | The error message returned because the specified resource does not exist in the stack. name indicates the resource name. stack indicates the stack name or ID. |
          * | 404 | StackNotFound | The Stack ({name}) could not be found. | The error message returned because the stack does not exist. name indicates the name or ID of the stack. |
          *
          * @param request GetStackResourceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetStackResourceResponse
         */
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

        /**
          * | Http status code | Error code | Error message | Description |
          * | ---------------- | ---------- | ------------- | ----------- |
          * | 404 | ResourceNotFound | The Resource ({name}) could not be found in Stack {stack}. | The error message returned because the specified resource does not exist in the stack. name indicates the resource name. stack indicates the stack name or ID. |
          * | 404 | StackNotFound | The Stack ({name}) could not be found. | The error message returned because the stack does not exist. name indicates the name or ID of the stack. |
          *
          * @param request GetStackResourceRequest
          * @return GetStackResourceResponse
         */
        public GetStackResourceResponse GetStackResource(GetStackResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStackResourceWithOptions(request, runtime);
        }

        /**
          * | Http status code | Error code | Error message | Description |
          * | ---------------- | ---------- | ------------- | ----------- |
          * | 404 | ResourceNotFound | The Resource ({name}) could not be found in Stack {stack}. | The error message returned because the specified resource does not exist in the stack. name indicates the resource name. stack indicates the stack name or ID. |
          * | 404 | StackNotFound | The Stack ({name}) could not be found. | The error message returned because the stack does not exist. name indicates the name or ID of the stack. |
          *
          * @param request GetStackResourceRequest
          * @return GetStackResourceResponse
         */
        public async Task<GetStackResourceResponse> GetStackResourceAsync(GetStackResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStackResourceWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, the details of a template whose ID is `5ecd1e10-b0e9-4389-a565-e4c15efc****` is queried. The region ID of the template is `cn-hangzhou`.
          *
          * @param request GetTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetTemplateResponse
         */
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

        /**
          * In this example, the details of a template whose ID is `5ecd1e10-b0e9-4389-a565-e4c15efc****` is queried. The region ID of the template is `cn-hangzhou`.
          *
          * @param request GetTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetTemplateResponse
         */
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

        /**
          * In this example, the details of a template whose ID is `5ecd1e10-b0e9-4389-a565-e4c15efc****` is queried. The region ID of the template is `cn-hangzhou`.
          *
          * @param request GetTemplateRequest
          * @return GetTemplateResponse
         */
        public GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateWithOptions(request, runtime);
        }

        /**
          * In this example, the details of a template whose ID is `5ecd1e10-b0e9-4389-a565-e4c15efc****` is queried. The region ID of the template is `cn-hangzhou`.
          *
          * @param request GetTemplateRequest
          * @return GetTemplateResponse
         */
        public async Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateWithOptionsAsync(request, runtime);
        }

        /**
          * ###
          * *   For more information about the resources that support price inquiry in Resource Orchestration Service (ROS) templates, see the "**Resource types that support price inquiry**" section of the [Estimate resource prices](~~203165~~) topic.
          * *   For more information about the resources that support price inquiry in Terraform templates, see the "**ROS resources supported by Terraform**" section of the [ROS features and resources supported by Terraform](~~184389~~) topic.
          * The following sample code provides an example on how to query the estimated price of an elastic IP address (EIP) that you want to create based on a template. In this example, the following template is used:
          *     {
          *       "ROSTemplateFormatVersion": "2015-09-01",
          *       "Parameters": {
          *         "Isp": {
          *           "Type": "String",
          *           "Default": "BGP"
          *         },
          *         "Name": {
          *           "Type": "String",
          *           "Default": "test"
          *         },
          *         "Netmode": {
          *           "Type": "String",
          *           "Default": "public"
          *         },
          *         "Bandwidth": {
          *           "Type": "Number",
          *           "Default": 5
          *         }
          *       },
          *       "Resources": {
          *         "NewEip": {
          *           "Type": "ALIYUN::VPC::EIP",
          *           "Properties": {
          *             "InstanceChargeType": "Prepaid",
          *             "PricingCycle": "Month",
          *             "Isp": {
          *               "Ref": "Isp"
          *             },
          *             "Period": 1,
          *             "DeletionProtection": false,
          *             "AutoPay": false,
          *             "Name": {
          *               "Ref": "Name"
          *             },
          *             "InternetChargeType": "PayByTraffic",
          *             "Netmode": {
          *               "Ref": "Netmode"
          *             },
          *             "Bandwidth": {
          *               "Ref": "Bandwidth"
          *             }
          *           }
          *         }
          *       }
          *     }
          *
          * @param request GetTemplateEstimateCostRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetTemplateEstimateCostResponse
         */
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

        /**
          * ###
          * *   For more information about the resources that support price inquiry in Resource Orchestration Service (ROS) templates, see the "**Resource types that support price inquiry**" section of the [Estimate resource prices](~~203165~~) topic.
          * *   For more information about the resources that support price inquiry in Terraform templates, see the "**ROS resources supported by Terraform**" section of the [ROS features and resources supported by Terraform](~~184389~~) topic.
          * The following sample code provides an example on how to query the estimated price of an elastic IP address (EIP) that you want to create based on a template. In this example, the following template is used:
          *     {
          *       "ROSTemplateFormatVersion": "2015-09-01",
          *       "Parameters": {
          *         "Isp": {
          *           "Type": "String",
          *           "Default": "BGP"
          *         },
          *         "Name": {
          *           "Type": "String",
          *           "Default": "test"
          *         },
          *         "Netmode": {
          *           "Type": "String",
          *           "Default": "public"
          *         },
          *         "Bandwidth": {
          *           "Type": "Number",
          *           "Default": 5
          *         }
          *       },
          *       "Resources": {
          *         "NewEip": {
          *           "Type": "ALIYUN::VPC::EIP",
          *           "Properties": {
          *             "InstanceChargeType": "Prepaid",
          *             "PricingCycle": "Month",
          *             "Isp": {
          *               "Ref": "Isp"
          *             },
          *             "Period": 1,
          *             "DeletionProtection": false,
          *             "AutoPay": false,
          *             "Name": {
          *               "Ref": "Name"
          *             },
          *             "InternetChargeType": "PayByTraffic",
          *             "Netmode": {
          *               "Ref": "Netmode"
          *             },
          *             "Bandwidth": {
          *               "Ref": "Bandwidth"
          *             }
          *           }
          *         }
          *       }
          *     }
          *
          * @param request GetTemplateEstimateCostRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetTemplateEstimateCostResponse
         */
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

        /**
          * ###
          * *   For more information about the resources that support price inquiry in Resource Orchestration Service (ROS) templates, see the "**Resource types that support price inquiry**" section of the [Estimate resource prices](~~203165~~) topic.
          * *   For more information about the resources that support price inquiry in Terraform templates, see the "**ROS resources supported by Terraform**" section of the [ROS features and resources supported by Terraform](~~184389~~) topic.
          * The following sample code provides an example on how to query the estimated price of an elastic IP address (EIP) that you want to create based on a template. In this example, the following template is used:
          *     {
          *       "ROSTemplateFormatVersion": "2015-09-01",
          *       "Parameters": {
          *         "Isp": {
          *           "Type": "String",
          *           "Default": "BGP"
          *         },
          *         "Name": {
          *           "Type": "String",
          *           "Default": "test"
          *         },
          *         "Netmode": {
          *           "Type": "String",
          *           "Default": "public"
          *         },
          *         "Bandwidth": {
          *           "Type": "Number",
          *           "Default": 5
          *         }
          *       },
          *       "Resources": {
          *         "NewEip": {
          *           "Type": "ALIYUN::VPC::EIP",
          *           "Properties": {
          *             "InstanceChargeType": "Prepaid",
          *             "PricingCycle": "Month",
          *             "Isp": {
          *               "Ref": "Isp"
          *             },
          *             "Period": 1,
          *             "DeletionProtection": false,
          *             "AutoPay": false,
          *             "Name": {
          *               "Ref": "Name"
          *             },
          *             "InternetChargeType": "PayByTraffic",
          *             "Netmode": {
          *               "Ref": "Netmode"
          *             },
          *             "Bandwidth": {
          *               "Ref": "Bandwidth"
          *             }
          *           }
          *         }
          *       }
          *     }
          *
          * @param request GetTemplateEstimateCostRequest
          * @return GetTemplateEstimateCostResponse
         */
        public GetTemplateEstimateCostResponse GetTemplateEstimateCost(GetTemplateEstimateCostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateEstimateCostWithOptions(request, runtime);
        }

        /**
          * ###
          * *   For more information about the resources that support price inquiry in Resource Orchestration Service (ROS) templates, see the "**Resource types that support price inquiry**" section of the [Estimate resource prices](~~203165~~) topic.
          * *   For more information about the resources that support price inquiry in Terraform templates, see the "**ROS resources supported by Terraform**" section of the [ROS features and resources supported by Terraform](~~184389~~) topic.
          * The following sample code provides an example on how to query the estimated price of an elastic IP address (EIP) that you want to create based on a template. In this example, the following template is used:
          *     {
          *       "ROSTemplateFormatVersion": "2015-09-01",
          *       "Parameters": {
          *         "Isp": {
          *           "Type": "String",
          *           "Default": "BGP"
          *         },
          *         "Name": {
          *           "Type": "String",
          *           "Default": "test"
          *         },
          *         "Netmode": {
          *           "Type": "String",
          *           "Default": "public"
          *         },
          *         "Bandwidth": {
          *           "Type": "Number",
          *           "Default": 5
          *         }
          *       },
          *       "Resources": {
          *         "NewEip": {
          *           "Type": "ALIYUN::VPC::EIP",
          *           "Properties": {
          *             "InstanceChargeType": "Prepaid",
          *             "PricingCycle": "Month",
          *             "Isp": {
          *               "Ref": "Isp"
          *             },
          *             "Period": 1,
          *             "DeletionProtection": false,
          *             "AutoPay": false,
          *             "Name": {
          *               "Ref": "Name"
          *             },
          *             "InternetChargeType": "PayByTraffic",
          *             "Netmode": {
          *               "Ref": "Netmode"
          *             },
          *             "Bandwidth": {
          *               "Ref": "Bandwidth"
          *             }
          *           }
          *         }
          *       }
          *     }
          *
          * @param request GetTemplateEstimateCostRequest
          * @return GetTemplateEstimateCostResponse
         */
        public async Task<GetTemplateEstimateCostResponse> GetTemplateEstimateCostAsync(GetTemplateEstimateCostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateEstimateCostWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to query the values of a parameter. In this example, the values of the `ZoneInfo` parameter in a template that is created in the China (Hangzhou) region are queried. The template body is `{"Parameters":{"ZoneInfo":{"Type": "String"},"InstanceType": {"Type": "String"}},"ROSTemplateFormatVersion": "2015-09-01","Resources":{"ECS":{"Properties":{"ZoneId":{"Ref": "ZoneInfo"},"InstanceType": {"Ref": "InstanceType"}},"Type": "ALIYUN::ECS::Instance"}}}`.
          * For more information about the template parameters whose values you can query by calling this operation and the sample code of the template, see [Query the constraints of parameters](~~432820~~).
          *
          * @param tmpReq GetTemplateParameterConstraintsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetTemplateParameterConstraintsResponse
         */
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

        /**
          * This topic provides an example on how to query the values of a parameter. In this example, the values of the `ZoneInfo` parameter in a template that is created in the China (Hangzhou) region are queried. The template body is `{"Parameters":{"ZoneInfo":{"Type": "String"},"InstanceType": {"Type": "String"}},"ROSTemplateFormatVersion": "2015-09-01","Resources":{"ECS":{"Properties":{"ZoneId":{"Ref": "ZoneInfo"},"InstanceType": {"Ref": "InstanceType"}},"Type": "ALIYUN::ECS::Instance"}}}`.
          * For more information about the template parameters whose values you can query by calling this operation and the sample code of the template, see [Query the constraints of parameters](~~432820~~).
          *
          * @param tmpReq GetTemplateParameterConstraintsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetTemplateParameterConstraintsResponse
         */
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

        /**
          * This topic provides an example on how to query the values of a parameter. In this example, the values of the `ZoneInfo` parameter in a template that is created in the China (Hangzhou) region are queried. The template body is `{"Parameters":{"ZoneInfo":{"Type": "String"},"InstanceType": {"Type": "String"}},"ROSTemplateFormatVersion": "2015-09-01","Resources":{"ECS":{"Properties":{"ZoneId":{"Ref": "ZoneInfo"},"InstanceType": {"Ref": "InstanceType"}},"Type": "ALIYUN::ECS::Instance"}}}`.
          * For more information about the template parameters whose values you can query by calling this operation and the sample code of the template, see [Query the constraints of parameters](~~432820~~).
          *
          * @param request GetTemplateParameterConstraintsRequest
          * @return GetTemplateParameterConstraintsResponse
         */
        public GetTemplateParameterConstraintsResponse GetTemplateParameterConstraints(GetTemplateParameterConstraintsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateParameterConstraintsWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to query the values of a parameter. In this example, the values of the `ZoneInfo` parameter in a template that is created in the China (Hangzhou) region are queried. The template body is `{"Parameters":{"ZoneInfo":{"Type": "String"},"InstanceType": {"Type": "String"}},"ROSTemplateFormatVersion": "2015-09-01","Resources":{"ECS":{"Properties":{"ZoneId":{"Ref": "ZoneInfo"},"InstanceType": {"Ref": "InstanceType"}},"Type": "ALIYUN::ECS::Instance"}}}`.
          * For more information about the template parameters whose values you can query by calling this operation and the sample code of the template, see [Query the constraints of parameters](~~432820~~).
          *
          * @param request GetTemplateParameterConstraintsRequest
          * @return GetTemplateParameterConstraintsResponse
         */
        public async Task<GetTemplateParameterConstraintsResponse> GetTemplateParameterConstraintsAsync(GetTemplateParameterConstraintsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateParameterConstraintsWithOptionsAsync(request, runtime);
        }

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

        public GetTemplateRecommendParametersResponse GetTemplateRecommendParameters(GetTemplateRecommendParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateRecommendParametersWithOptions(request, runtime);
        }

        public async Task<GetTemplateRecommendParametersResponse> GetTemplateRecommendParametersAsync(GetTemplateRecommendParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateRecommendParametersWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, the details of the scenario whose ID is `ts-7f7a704cf71c49a6****` is queried. In the response, the source node data is displayed.
          *
          * @param request GetTemplateScratchRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetTemplateScratchResponse
         */
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

        /**
          * In this example, the details of the scenario whose ID is `ts-7f7a704cf71c49a6****` is queried. In the response, the source node data is displayed.
          *
          * @param request GetTemplateScratchRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetTemplateScratchResponse
         */
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

        /**
          * In this example, the details of the scenario whose ID is `ts-7f7a704cf71c49a6****` is queried. In the response, the source node data is displayed.
          *
          * @param request GetTemplateScratchRequest
          * @return GetTemplateScratchResponse
         */
        public GetTemplateScratchResponse GetTemplateScratch(GetTemplateScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateScratchWithOptions(request, runtime);
        }

        /**
          * In this example, the details of the scenario whose ID is `ts-7f7a704cf71c49a6****` is queried. In the response, the source node data is displayed.
          *
          * @param request GetTemplateScratchRequest
          * @return GetTemplateScratchResponse
         */
        public async Task<GetTemplateScratchResponse> GetTemplateScratchAsync(GetTemplateScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateScratchWithOptionsAsync(request, runtime);
        }

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

        public GetTemplateSummaryResponse GetTemplateSummary(GetTemplateSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateSummaryWithOptions(request, runtime);
        }

        public async Task<GetTemplateSummaryResponse> GetTemplateSummaryAsync(GetTemplateSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateSummaryWithOptionsAsync(request, runtime);
        }

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

        public ListChangeSetsResponse ListChangeSets(ListChangeSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListChangeSetsWithOptions(request, runtime);
        }

        public async Task<ListChangeSetsResponse> ListChangeSetsAsync(ListChangeSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListChangeSetsWithOptionsAsync(request, runtime);
        }

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

        public ListDiagnosticsResponse ListDiagnostics(ListDiagnosticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDiagnosticsWithOptions(request, runtime);
        }

        public async Task<ListDiagnosticsResponse> ListDiagnosticsAsync(ListDiagnosticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDiagnosticsWithOptionsAsync(request, runtime);
        }

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

        public ListResourceTypeRegistrationsResponse ListResourceTypeRegistrations(ListResourceTypeRegistrationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceTypeRegistrationsWithOptions(request, runtime);
        }

        public async Task<ListResourceTypeRegistrationsResponse> ListResourceTypeRegistrationsAsync(ListResourceTypeRegistrationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceTypeRegistrationsWithOptionsAsync(request, runtime);
        }

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

        public ListResourceTypeVersionsResponse ListResourceTypeVersions(ListResourceTypeVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceTypeVersionsWithOptions(request, runtime);
        }

        public async Task<ListResourceTypeVersionsResponse> ListResourceTypeVersionsAsync(ListResourceTypeVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceTypeVersionsWithOptionsAsync(request, runtime);
        }

        /**
          * For more information about errors common to all operations, see [Common error codes](/help/en/resource-orchestration-service/latest/common-error-codes).
          *
          * @param request ListResourceTypesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListResourceTypesResponse
         */
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

        /**
          * For more information about errors common to all operations, see [Common error codes](/help/en/resource-orchestration-service/latest/common-error-codes).
          *
          * @param request ListResourceTypesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListResourceTypesResponse
         */
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

        /**
          * For more information about errors common to all operations, see [Common error codes](/help/en/resource-orchestration-service/latest/common-error-codes).
          *
          * @param request ListResourceTypesRequest
          * @return ListResourceTypesResponse
         */
        public ListResourceTypesResponse ListResourceTypes(ListResourceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceTypesWithOptions(request, runtime);
        }

        /**
          * For more information about errors common to all operations, see [Common error codes](/help/en/resource-orchestration-service/latest/common-error-codes).
          *
          * @param request ListResourceTypesRequest
          * @return ListResourceTypesResponse
         */
        public async Task<ListResourceTypesResponse> ListResourceTypesAsync(ListResourceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceTypesWithOptionsAsync(request, runtime);
        }

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

        public ListStackEventsResponse ListStackEvents(ListStackEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStackEventsWithOptions(request, runtime);
        }

        public async Task<ListStackEventsResponse> ListStackEventsAsync(ListStackEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStackEventsWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, the operation ID `6da106ca-1784-4a6f-a7e1-e723863d∗∗∗∗` is set to query the results of an operation on a stack group named `MyStackGroup`. The stack group is granted self-managed permissions and created in the China (Hangzhou) region.
          *
          * @param request ListStackGroupOperationResultsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListStackGroupOperationResultsResponse
         */
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

        /**
          * In this example, the operation ID `6da106ca-1784-4a6f-a7e1-e723863d∗∗∗∗` is set to query the results of an operation on a stack group named `MyStackGroup`. The stack group is granted self-managed permissions and created in the China (Hangzhou) region.
          *
          * @param request ListStackGroupOperationResultsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListStackGroupOperationResultsResponse
         */
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

        /**
          * In this example, the operation ID `6da106ca-1784-4a6f-a7e1-e723863d∗∗∗∗` is set to query the results of an operation on a stack group named `MyStackGroup`. The stack group is granted self-managed permissions and created in the China (Hangzhou) region.
          *
          * @param request ListStackGroupOperationResultsRequest
          * @return ListStackGroupOperationResultsResponse
         */
        public ListStackGroupOperationResultsResponse ListStackGroupOperationResults(ListStackGroupOperationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStackGroupOperationResultsWithOptions(request, runtime);
        }

        /**
          * In this example, the operation ID `6da106ca-1784-4a6f-a7e1-e723863d∗∗∗∗` is set to query the results of an operation on a stack group named `MyStackGroup`. The stack group is granted self-managed permissions and created in the China (Hangzhou) region.
          *
          * @param request ListStackGroupOperationResultsRequest
          * @return ListStackGroupOperationResultsResponse
         */
        public async Task<ListStackGroupOperationResultsResponse> ListStackGroupOperationResultsAsync(ListStackGroupOperationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStackGroupOperationResultsWithOptionsAsync(request, runtime);
        }

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

        public ListStackGroupOperationsResponse ListStackGroupOperations(ListStackGroupOperationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStackGroupOperationsWithOptions(request, runtime);
        }

        public async Task<ListStackGroupOperationsResponse> ListStackGroupOperationsAsync(ListStackGroupOperationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStackGroupOperationsWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, the list of stack groups that are in the ACTIVE state and deployed in the China (Hangzhou) region is queried.
          *
          * @param request ListStackGroupsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListStackGroupsResponse
         */
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

        /**
          * In this example, the list of stack groups that are in the ACTIVE state and deployed in the China (Hangzhou) region is queried.
          *
          * @param request ListStackGroupsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListStackGroupsResponse
         */
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

        /**
          * In this example, the list of stack groups that are in the ACTIVE state and deployed in the China (Hangzhou) region is queried.
          *
          * @param request ListStackGroupsRequest
          * @return ListStackGroupsResponse
         */
        public ListStackGroupsResponse ListStackGroups(ListStackGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStackGroupsWithOptions(request, runtime);
        }

        /**
          * In this example, the list of stack groups that are in the ACTIVE state and deployed in the China (Hangzhou) region is queried.
          *
          * @param request ListStackGroupsRequest
          * @return ListStackGroupsResponse
         */
        public async Task<ListStackGroupsResponse> ListStackGroupsAsync(ListStackGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStackGroupsWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, the list of stack instances that are associated with a stack group named `MyStackGroup` is queried. The stack group is granted self-managed permissions and deployed in the China (Hangzhou) region.
          *
          * @param request ListStackInstancesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListStackInstancesResponse
         */
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

        /**
          * In this example, the list of stack instances that are associated with a stack group named `MyStackGroup` is queried. The stack group is granted self-managed permissions and deployed in the China (Hangzhou) region.
          *
          * @param request ListStackInstancesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListStackInstancesResponse
         */
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

        /**
          * In this example, the list of stack instances that are associated with a stack group named `MyStackGroup` is queried. The stack group is granted self-managed permissions and deployed in the China (Hangzhou) region.
          *
          * @param request ListStackInstancesRequest
          * @return ListStackInstancesResponse
         */
        public ListStackInstancesResponse ListStackInstances(ListStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStackInstancesWithOptions(request, runtime);
        }

        /**
          * In this example, the list of stack instances that are associated with a stack group named `MyStackGroup` is queried. The stack group is granted self-managed permissions and deployed in the China (Hangzhou) region.
          *
          * @param request ListStackInstancesRequest
          * @return ListStackInstancesResponse
         */
        public async Task<ListStackInstancesResponse> ListStackInstancesAsync(ListStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStackInstancesWithOptionsAsync(request, runtime);
        }

        /**
          * The ListStackOperationRisks operation is suitable for the following scenarios:
          * *   You want to detect high risks that may arise in resources when you delete a stack that contains the resources, and query the cause of each risk in a resource.
          * *   When you create a stack, the creation may fail. In this case, you can call this operation to check which types of permissions that are required to create stacks are missing.
          *
          * @param request ListStackOperationRisksRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListStackOperationRisksResponse
         */
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

        /**
          * The ListStackOperationRisks operation is suitable for the following scenarios:
          * *   You want to detect high risks that may arise in resources when you delete a stack that contains the resources, and query the cause of each risk in a resource.
          * *   When you create a stack, the creation may fail. In this case, you can call this operation to check which types of permissions that are required to create stacks are missing.
          *
          * @param request ListStackOperationRisksRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListStackOperationRisksResponse
         */
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

        /**
          * The ListStackOperationRisks operation is suitable for the following scenarios:
          * *   You want to detect high risks that may arise in resources when you delete a stack that contains the resources, and query the cause of each risk in a resource.
          * *   When you create a stack, the creation may fail. In this case, you can call this operation to check which types of permissions that are required to create stacks are missing.
          *
          * @param request ListStackOperationRisksRequest
          * @return ListStackOperationRisksResponse
         */
        public ListStackOperationRisksResponse ListStackOperationRisks(ListStackOperationRisksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStackOperationRisksWithOptions(request, runtime);
        }

        /**
          * The ListStackOperationRisks operation is suitable for the following scenarios:
          * *   You want to detect high risks that may arise in resources when you delete a stack that contains the resources, and query the cause of each risk in a resource.
          * *   When you create a stack, the creation may fail. In this case, you can call this operation to check which types of permissions that are required to create stacks are missing.
          *
          * @param request ListStackOperationRisksRequest
          * @return ListStackOperationRisksResponse
         */
        public async Task<ListStackOperationRisksResponse> ListStackOperationRisksAsync(ListStackOperationRisksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStackOperationRisksWithOptionsAsync(request, runtime);
        }

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

        public ListStackResourceDriftsResponse ListStackResourceDrifts(ListStackResourceDriftsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStackResourceDriftsWithOptions(request, runtime);
        }

        public async Task<ListStackResourceDriftsResponse> ListStackResourceDriftsAsync(ListStackResourceDriftsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStackResourceDriftsWithOptionsAsync(request, runtime);
        }

        /**
          * For more information about common request parameters, see [Common parameters](~~131957~~).
          *
          * @param request ListStackResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListStackResourcesResponse
         */
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

        /**
          * For more information about common request parameters, see [Common parameters](~~131957~~).
          *
          * @param request ListStackResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListStackResourcesResponse
         */
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

        /**
          * For more information about common request parameters, see [Common parameters](~~131957~~).
          *
          * @param request ListStackResourcesRequest
          * @return ListStackResourcesResponse
         */
        public ListStackResourcesResponse ListStackResources(ListStackResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStackResourcesWithOptions(request, runtime);
        }

        /**
          * For more information about common request parameters, see [Common parameters](~~131957~~).
          *
          * @param request ListStackResourcesRequest
          * @return ListStackResourcesResponse
         */
        public async Task<ListStackResourcesResponse> ListStackResourcesAsync(ListStackResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStackResourcesWithOptionsAsync(request, runtime);
        }

        /**
          * ###
          * This topic provides an example on how to query a list of stacks. In this example, the stacks that are deployed in the China (Hangzhou) region are queried.
          *
          * @param request ListStacksRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListStacksResponse
         */
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

        /**
          * ###
          * This topic provides an example on how to query a list of stacks. In this example, the stacks that are deployed in the China (Hangzhou) region are queried.
          *
          * @param request ListStacksRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListStacksResponse
         */
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

        /**
          * ###
          * This topic provides an example on how to query a list of stacks. In this example, the stacks that are deployed in the China (Hangzhou) region are queried.
          *
          * @param request ListStacksRequest
          * @return ListStacksResponse
         */
        public ListStacksResponse ListStacks(ListStacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStacksWithOptions(request, runtime);
        }

        /**
          * ###
          * This topic provides an example on how to query a list of stacks. In this example, the stacks that are deployed in the China (Hangzhou) region are queried.
          *
          * @param request ListStacksRequest
          * @return ListStacksResponse
         */
        public async Task<ListStacksResponse> ListStacksAsync(ListStacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStacksWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, the tag keys that are added to a stack in the China (Hangzhou) region are queried.
          *
          * @param request ListTagKeysRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListTagKeysResponse
         */
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

        /**
          * In this example, the tag keys that are added to a stack in the China (Hangzhou) region are queried.
          *
          * @param request ListTagKeysRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListTagKeysResponse
         */
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

        /**
          * In this example, the tag keys that are added to a stack in the China (Hangzhou) region are queried.
          *
          * @param request ListTagKeysRequest
          * @return ListTagKeysResponse
         */
        public ListTagKeysResponse ListTagKeys(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagKeysWithOptions(request, runtime);
        }

        /**
          * In this example, the tag keys that are added to a stack in the China (Hangzhou) region are queried.
          *
          * @param request ListTagKeysRequest
          * @return ListTagKeysResponse
         */
        public async Task<ListTagKeysResponse> ListTagKeysAsync(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagKeysWithOptionsAsync(request, runtime);
        }

        /**
          * ###
          * *   To specify the query object, specify ResourceId or Tag in the request. Tag consists of Key and Value.
          * *   If you specify Tag and ResourceId, ROS resources that match both the parameters are returned.
          * This topic provides an example on how to query the tags that are added to a stack. In this example, the stack ID is `6bc589b5-9c02-4944-8fc3-f3624234****`. The stack is deployed in the China (Hangzhou) region.
          *
          * @param request ListTagResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListTagResourcesResponse
         */
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

        /**
          * ###
          * *   To specify the query object, specify ResourceId or Tag in the request. Tag consists of Key and Value.
          * *   If you specify Tag and ResourceId, ROS resources that match both the parameters are returned.
          * This topic provides an example on how to query the tags that are added to a stack. In this example, the stack ID is `6bc589b5-9c02-4944-8fc3-f3624234****`. The stack is deployed in the China (Hangzhou) region.
          *
          * @param request ListTagResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListTagResourcesResponse
         */
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

        /**
          * ###
          * *   To specify the query object, specify ResourceId or Tag in the request. Tag consists of Key and Value.
          * *   If you specify Tag and ResourceId, ROS resources that match both the parameters are returned.
          * This topic provides an example on how to query the tags that are added to a stack. In this example, the stack ID is `6bc589b5-9c02-4944-8fc3-f3624234****`. The stack is deployed in the China (Hangzhou) region.
          *
          * @param request ListTagResourcesRequest
          * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /**
          * ###
          * *   To specify the query object, specify ResourceId or Tag in the request. Tag consists of Key and Value.
          * *   If you specify Tag and ResourceId, ROS resources that match both the parameters are returned.
          * This topic provides an example on how to query the tags that are added to a stack. In this example, the stack ID is `6bc589b5-9c02-4944-8fc3-f3624234****`. The stack is deployed in the China (Hangzhou) region.
          *
          * @param request ListTagResourcesRequest
          * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, the tag values of `TagKey1` that is added to a stack in the China (Hangzhou) region are queried.
          *
          * @param request ListTagValuesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListTagValuesResponse
         */
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

        /**
          * In this example, the tag values of `TagKey1` that is added to a stack in the China (Hangzhou) region are queried.
          *
          * @param request ListTagValuesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListTagValuesResponse
         */
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

        /**
          * In this example, the tag values of `TagKey1` that is added to a stack in the China (Hangzhou) region are queried.
          *
          * @param request ListTagValuesRequest
          * @return ListTagValuesResponse
         */
        public ListTagValuesResponse ListTagValues(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagValuesWithOptions(request, runtime);
        }

        /**
          * In this example, the tag values of `TagKey1` that is added to a stack in the China (Hangzhou) region are queried.
          *
          * @param request ListTagValuesRequest
          * @return ListTagValuesResponse
         */
        public async Task<ListTagValuesResponse> ListTagValuesAsync(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagValuesWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, the scenarios that are created in the China (Hangzhou) region are queried. In the response, a scenario of the Resource Management and a scenario of the Resource Replication type are returned.
          *
          * @param request ListTemplateScratchesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListTemplateScratchesResponse
         */
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

        /**
          * In this example, the scenarios that are created in the China (Hangzhou) region are queried. In the response, a scenario of the Resource Management and a scenario of the Resource Replication type are returned.
          *
          * @param request ListTemplateScratchesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListTemplateScratchesResponse
         */
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

        /**
          * In this example, the scenarios that are created in the China (Hangzhou) region are queried. In the response, a scenario of the Resource Management and a scenario of the Resource Replication type are returned.
          *
          * @param request ListTemplateScratchesRequest
          * @return ListTemplateScratchesResponse
         */
        public ListTemplateScratchesResponse ListTemplateScratches(ListTemplateScratchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTemplateScratchesWithOptions(request, runtime);
        }

        /**
          * In this example, the scenarios that are created in the China (Hangzhou) region are queried. In the response, a scenario of the Resource Management and a scenario of the Resource Replication type are returned.
          *
          * @param request ListTemplateScratchesRequest
          * @return ListTemplateScratchesResponse
         */
        public async Task<ListTemplateScratchesResponse> ListTemplateScratchesAsync(ListTemplateScratchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTemplateScratchesWithOptionsAsync(request, runtime);
        }

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

        public ListTemplateVersionsResponse ListTemplateVersions(ListTemplateVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTemplateVersionsWithOptions(request, runtime);
        }

        public async Task<ListTemplateVersionsResponse> ListTemplateVersionsAsync(ListTemplateVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTemplateVersionsWithOptionsAsync(request, runtime);
        }

        public ListTemplatesResponse ListTemplatesWithOptions(ListTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        public async Task<ListTemplatesResponse> ListTemplatesWithOptionsAsync(ListTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        public ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTemplatesWithOptions(request, runtime);
        }

        public async Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTemplatesWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, a stack deployed in the `China (Hangzhou)` region is moved to a specific resource group. The ID of the stack is `4e8611cb-251e-42b7-b9cb-3496362c****` and the ID of the resource group is `rg-acfm3peow3k****`.
          *
          * @param request MoveResourceGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return MoveResourceGroupResponse
         */
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

        /**
          * In this example, a stack deployed in the `China (Hangzhou)` region is moved to a specific resource group. The ID of the stack is `4e8611cb-251e-42b7-b9cb-3496362c****` and the ID of the resource group is `rg-acfm3peow3k****`.
          *
          * @param request MoveResourceGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return MoveResourceGroupResponse
         */
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

        /**
          * In this example, a stack deployed in the `China (Hangzhou)` region is moved to a specific resource group. The ID of the stack is `4e8611cb-251e-42b7-b9cb-3496362c****` and the ID of the resource group is `rg-acfm3peow3k****`.
          *
          * @param request MoveResourceGroupRequest
          * @return MoveResourceGroupResponse
         */
        public MoveResourceGroupResponse MoveResourceGroup(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveResourceGroupWithOptions(request, runtime);
        }

        /**
          * In this example, a stack deployed in the `China (Hangzhou)` region is moved to a specific resource group. The ID of the stack is `4e8611cb-251e-42b7-b9cb-3496362c****` and the ID of the resource group is `rg-acfm3peow3k****`.
          *
          * @param request MoveResourceGroupRequest
          * @return MoveResourceGroupResponse
         */
        public async Task<MoveResourceGroupResponse> MoveResourceGroupAsync(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to create a stack named `MyStack` in the China (Hangzhou) region by using a template and preview the information about the stack. In this example, the `template body` is `{"ROSTemplateFormatVersion":"2015-09-01"}`.
          *
          * @param request PreviewStackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PreviewStackResponse
         */
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

        /**
          * This topic provides an example on how to create a stack named `MyStack` in the China (Hangzhou) region by using a template and preview the information about the stack. In this example, the `template body` is `{"ROSTemplateFormatVersion":"2015-09-01"}`.
          *
          * @param request PreviewStackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PreviewStackResponse
         */
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

        /**
          * This topic provides an example on how to create a stack named `MyStack` in the China (Hangzhou) region by using a template and preview the information about the stack. In this example, the `template body` is `{"ROSTemplateFormatVersion":"2015-09-01"}`.
          *
          * @param request PreviewStackRequest
          * @return PreviewStackResponse
         */
        public PreviewStackResponse PreviewStack(PreviewStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PreviewStackWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to create a stack named `MyStack` in the China (Hangzhou) region by using a template and preview the information about the stack. In this example, the `template body` is `{"ROSTemplateFormatVersion":"2015-09-01"}`.
          *
          * @param request PreviewStackRequest
          * @return PreviewStackResponse
         */
        public async Task<PreviewStackResponse> PreviewStackAsync(PreviewStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PreviewStackWithOptionsAsync(request, runtime);
        }

        /**
          * *   Versions increase from v1.
          * *   If you create a new resource type, v1 is used as the default version of the resource type. You can call the SetResourceType operation to change the default version of a resource type.
          *
          * @param request RegisterResourceTypeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RegisterResourceTypeResponse
         */
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

        /**
          * *   Versions increase from v1.
          * *   If you create a new resource type, v1 is used as the default version of the resource type. You can call the SetResourceType operation to change the default version of a resource type.
          *
          * @param request RegisterResourceTypeRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RegisterResourceTypeResponse
         */
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

        /**
          * *   Versions increase from v1.
          * *   If you create a new resource type, v1 is used as the default version of the resource type. You can call the SetResourceType operation to change the default version of a resource type.
          *
          * @param request RegisterResourceTypeRequest
          * @return RegisterResourceTypeResponse
         */
        public RegisterResourceTypeResponse RegisterResourceType(RegisterResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterResourceTypeWithOptions(request, runtime);
        }

        /**
          * *   Versions increase from v1.
          * *   If you create a new resource type, v1 is used as the default version of the resource type. You can call the SetResourceType operation to change the default version of a resource type.
          *
          * @param request RegisterResourceTypeRequest
          * @return RegisterResourceTypeResponse
         */
        public async Task<RegisterResourceTypeResponse> RegisterResourceTypeAsync(RegisterResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterResourceTypeWithOptionsAsync(request, runtime);
        }

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

        public SetDeletionProtectionResponse SetDeletionProtection(SetDeletionProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDeletionProtectionWithOptions(request, runtime);
        }

        public async Task<SetDeletionProtectionResponse> SetDeletionProtectionAsync(SetDeletionProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDeletionProtectionWithOptionsAsync(request, runtime);
        }

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

        public SetResourceTypeResponse SetResourceType(SetResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetResourceTypeWithOptions(request, runtime);
        }

        public async Task<SetResourceTypeResponse> SetResourceTypeAsync(SetResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetResourceTypeWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, a stack policy is configured for a stack deployed in the `China (Hangzhou)` region whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****`. The URL to the stack policy body is `oss://ros/stack-policy/demo`.
          *
          * @param request SetStackPolicyRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetStackPolicyResponse
         */
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

        /**
          * In this example, a stack policy is configured for a stack deployed in the `China (Hangzhou)` region whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****`. The URL to the stack policy body is `oss://ros/stack-policy/demo`.
          *
          * @param request SetStackPolicyRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetStackPolicyResponse
         */
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

        /**
          * In this example, a stack policy is configured for a stack deployed in the `China (Hangzhou)` region whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****`. The URL to the stack policy body is `oss://ros/stack-policy/demo`.
          *
          * @param request SetStackPolicyRequest
          * @return SetStackPolicyResponse
         */
        public SetStackPolicyResponse SetStackPolicy(SetStackPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetStackPolicyWithOptions(request, runtime);
        }

        /**
          * In this example, a stack policy is configured for a stack deployed in the `China (Hangzhou)` region whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****`. The URL to the stack policy body is `oss://ros/stack-policy/demo`.
          *
          * @param request SetStackPolicyRequest
          * @return SetStackPolicyResponse
         */
        public async Task<SetStackPolicyResponse> SetStackPolicyAsync(SetStackPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetStackPolicyWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, the template whose ID is `5ecd1e10-b0e9-4389-a565-e4c15efc****` is shared with an Alibaba Cloud account. The ID of the Alibaba Cloud account is `151266687691****`.
          * > The recipient Alibaba Cloud account (ID: `151266687691****`) can authorize RAM users to use the shared template.
          *
          * @param request SetTemplatePermissionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetTemplatePermissionResponse
         */
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

        /**
          * In this example, the template whose ID is `5ecd1e10-b0e9-4389-a565-e4c15efc****` is shared with an Alibaba Cloud account. The ID of the Alibaba Cloud account is `151266687691****`.
          * > The recipient Alibaba Cloud account (ID: `151266687691****`) can authorize RAM users to use the shared template.
          *
          * @param request SetTemplatePermissionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetTemplatePermissionResponse
         */
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

        /**
          * In this example, the template whose ID is `5ecd1e10-b0e9-4389-a565-e4c15efc****` is shared with an Alibaba Cloud account. The ID of the Alibaba Cloud account is `151266687691****`.
          * > The recipient Alibaba Cloud account (ID: `151266687691****`) can authorize RAM users to use the shared template.
          *
          * @param request SetTemplatePermissionRequest
          * @return SetTemplatePermissionResponse
         */
        public SetTemplatePermissionResponse SetTemplatePermission(SetTemplatePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetTemplatePermissionWithOptions(request, runtime);
        }

        /**
          * In this example, the template whose ID is `5ecd1e10-b0e9-4389-a565-e4c15efc****` is shared with an Alibaba Cloud account. The ID of the Alibaba Cloud account is `151266687691****`.
          * > The recipient Alibaba Cloud account (ID: `151266687691****`) can authorize RAM users to use the shared template.
          *
          * @param request SetTemplatePermissionRequest
          * @return SetTemplatePermissionResponse
         */
        public async Task<SetTemplatePermissionResponse> SetTemplatePermissionAsync(SetTemplatePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetTemplatePermissionWithOptionsAsync(request, runtime);
        }

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

        public SignalResourceResponse SignalResource(SignalResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SignalResourceWithOptions(request, runtime);
        }

        public async Task<SignalResourceResponse> SignalResourceAsync(SignalResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SignalResourceWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to stop a stack group operation whose ID is `6da106ca-1784-4a6f-a7e1-e723863****` in the China (Hangzhou) region.
          *
          * @param request StopStackGroupOperationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StopStackGroupOperationResponse
         */
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

        /**
          * This topic provides an example on how to stop a stack group operation whose ID is `6da106ca-1784-4a6f-a7e1-e723863****` in the China (Hangzhou) region.
          *
          * @param request StopStackGroupOperationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StopStackGroupOperationResponse
         */
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

        /**
          * This topic provides an example on how to stop a stack group operation whose ID is `6da106ca-1784-4a6f-a7e1-e723863****` in the China (Hangzhou) region.
          *
          * @param request StopStackGroupOperationRequest
          * @return StopStackGroupOperationResponse
         */
        public StopStackGroupOperationResponse StopStackGroupOperation(StopStackGroupOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopStackGroupOperationWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to stop a stack group operation whose ID is `6da106ca-1784-4a6f-a7e1-e723863****` in the China (Hangzhou) region.
          *
          * @param request StopStackGroupOperationRequest
          * @return StopStackGroupOperationResponse
         */
        public async Task<StopStackGroupOperationResponse> StopStackGroupOperationAsync(StopStackGroupOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopStackGroupOperationWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to create a tag and add the tag to a stack. In this example, the stack ID is `7fee80e1-8c48-4c2f-8300-0f6dc40b****`, the tag key is `FinanceDept`, and the tag value is `FinanceJoshua`.
          *
          * @param request TagResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return TagResourcesResponse
         */
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

        /**
          * This topic provides an example on how to create a tag and add the tag to a stack. In this example, the stack ID is `7fee80e1-8c48-4c2f-8300-0f6dc40b****`, the tag key is `FinanceDept`, and the tag value is `FinanceJoshua`.
          *
          * @param request TagResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return TagResourcesResponse
         */
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

        /**
          * This topic provides an example on how to create a tag and add the tag to a stack. In this example, the stack ID is `7fee80e1-8c48-4c2f-8300-0f6dc40b****`, the tag key is `FinanceDept`, and the tag value is `FinanceJoshua`.
          *
          * @param request TagResourcesRequest
          * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to create a tag and add the tag to a stack. In this example, the stack ID is `7fee80e1-8c48-4c2f-8300-0f6dc40b****`, the tag key is `FinanceDept`, and the tag value is `FinanceJoshua`.
          *
          * @param request TagResourcesRequest
          * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to remove all tags from a stack that is deployed in the China (Hangzhou) region. In this example, the stack ID is `46ec7b78-9d5e-4b21-aefd-448c90aa****`.
          *
          * @param request UntagResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UntagResourcesResponse
         */
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

        /**
          * This topic provides an example on how to remove all tags from a stack that is deployed in the China (Hangzhou) region. In this example, the stack ID is `46ec7b78-9d5e-4b21-aefd-448c90aa****`.
          *
          * @param request UntagResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UntagResourcesResponse
         */
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

        /**
          * This topic provides an example on how to remove all tags from a stack that is deployed in the China (Hangzhou) region. In this example, the stack ID is `46ec7b78-9d5e-4b21-aefd-448c90aa****`.
          *
          * @param request UntagResourcesRequest
          * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to remove all tags from a stack that is deployed in the China (Hangzhou) region. In this example, the stack ID is `46ec7b78-9d5e-4b21-aefd-448c90aa****`.
          *
          * @param request UntagResourcesRequest
          * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        /**
          * The values of parameters in the Parameters section vary based on the value that you specify for the UsePreviousParameters parameter in the request. If you do not add the parameters that are defined in the template to the Parameters section, take note of the following items:
          * *   UsePreviousParameters is set to false: If the template parameters have default values, the default values are used. Otherwise, you must specify values for the template parameters in the Parameters section.
          * *   UsePreviousParameters is set to true: If you specify values for the template parameters when you create a stack, the values are used. If you leave the template parameters empty when you create a stack but the template parameters have default values, the default values are used.
          * This topic describes how to update a stack. In this example, the template body of a stack whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****` in the China (Beijing) region is updated to `{"ROSTemplateFormatVersion": "2015-09-01"}`.
          *
          * @param request UpdateStackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateStackResponse
         */
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

        /**
          * The values of parameters in the Parameters section vary based on the value that you specify for the UsePreviousParameters parameter in the request. If you do not add the parameters that are defined in the template to the Parameters section, take note of the following items:
          * *   UsePreviousParameters is set to false: If the template parameters have default values, the default values are used. Otherwise, you must specify values for the template parameters in the Parameters section.
          * *   UsePreviousParameters is set to true: If you specify values for the template parameters when you create a stack, the values are used. If you leave the template parameters empty when you create a stack but the template parameters have default values, the default values are used.
          * This topic describes how to update a stack. In this example, the template body of a stack whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****` in the China (Beijing) region is updated to `{"ROSTemplateFormatVersion": "2015-09-01"}`.
          *
          * @param request UpdateStackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateStackResponse
         */
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

        /**
          * The values of parameters in the Parameters section vary based on the value that you specify for the UsePreviousParameters parameter in the request. If you do not add the parameters that are defined in the template to the Parameters section, take note of the following items:
          * *   UsePreviousParameters is set to false: If the template parameters have default values, the default values are used. Otherwise, you must specify values for the template parameters in the Parameters section.
          * *   UsePreviousParameters is set to true: If you specify values for the template parameters when you create a stack, the values are used. If you leave the template parameters empty when you create a stack but the template parameters have default values, the default values are used.
          * This topic describes how to update a stack. In this example, the template body of a stack whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****` in the China (Beijing) region is updated to `{"ROSTemplateFormatVersion": "2015-09-01"}`.
          *
          * @param request UpdateStackRequest
          * @return UpdateStackResponse
         */
        public UpdateStackResponse UpdateStack(UpdateStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateStackWithOptions(request, runtime);
        }

        /**
          * The values of parameters in the Parameters section vary based on the value that you specify for the UsePreviousParameters parameter in the request. If you do not add the parameters that are defined in the template to the Parameters section, take note of the following items:
          * *   UsePreviousParameters is set to false: If the template parameters have default values, the default values are used. Otherwise, you must specify values for the template parameters in the Parameters section.
          * *   UsePreviousParameters is set to true: If you specify values for the template parameters when you create a stack, the values are used. If you leave the template parameters empty when you create a stack but the template parameters have default values, the default values are used.
          * This topic describes how to update a stack. In this example, the template body of a stack whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****` in the China (Beijing) region is updated to `{"ROSTemplateFormatVersion": "2015-09-01"}`.
          *
          * @param request UpdateStackRequest
          * @return UpdateStackResponse
         */
        public async Task<UpdateStackResponse> UpdateStackAsync(UpdateStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateStackWithOptionsAsync(request, runtime);
        }

        /**
          * The name of the stack group. The name must be unique within a region.
          * The name can be up to 255 characters in length and can contain digits, letters, hyphens (-), and underscores (\\_). The name must start with a digit or a letter.
          *
          * @param tmpReq UpdateStackGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateStackGroupResponse
         */
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

        /**
          * The name of the stack group. The name must be unique within a region.
          * The name can be up to 255 characters in length and can contain digits, letters, hyphens (-), and underscores (\\_). The name must start with a digit or a letter.
          *
          * @param tmpReq UpdateStackGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateStackGroupResponse
         */
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

        /**
          * The name of the stack group. The name must be unique within a region.
          * The name can be up to 255 characters in length and can contain digits, letters, hyphens (-), and underscores (\\_). The name must start with a digit or a letter.
          *
          * @param request UpdateStackGroupRequest
          * @return UpdateStackGroupResponse
         */
        public UpdateStackGroupResponse UpdateStackGroup(UpdateStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateStackGroupWithOptions(request, runtime);
        }

        /**
          * The name of the stack group. The name must be unique within a region.
          * The name can be up to 255 characters in length and can contain digits, letters, hyphens (-), and underscores (\\_). The name must start with a digit or a letter.
          *
          * @param request UpdateStackGroupRequest
          * @return UpdateStackGroupResponse
         */
        public async Task<UpdateStackGroupResponse> UpdateStackGroupAsync(UpdateStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateStackGroupWithOptionsAsync(request, runtime);
        }

        /**
          * In this topic, the stack group named `MyStackGroup` that is created in the China (Hangzhou) region is used. The stack group is granted the self-managed permissions. In this example, stacks of the stack group are updated by using the Alibaba Cloud accounts whose IDs are `151266687691****` and `141261387191****` in the China (Hangzhou) region and China (Beijing) region.
          *
          * @param tmpReq UpdateStackInstancesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateStackInstancesResponse
         */
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

        /**
          * In this topic, the stack group named `MyStackGroup` that is created in the China (Hangzhou) region is used. The stack group is granted the self-managed permissions. In this example, stacks of the stack group are updated by using the Alibaba Cloud accounts whose IDs are `151266687691****` and `141261387191****` in the China (Hangzhou) region and China (Beijing) region.
          *
          * @param tmpReq UpdateStackInstancesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateStackInstancesResponse
         */
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

        /**
          * In this topic, the stack group named `MyStackGroup` that is created in the China (Hangzhou) region is used. The stack group is granted the self-managed permissions. In this example, stacks of the stack group are updated by using the Alibaba Cloud accounts whose IDs are `151266687691****` and `141261387191****` in the China (Hangzhou) region and China (Beijing) region.
          *
          * @param request UpdateStackInstancesRequest
          * @return UpdateStackInstancesResponse
         */
        public UpdateStackInstancesResponse UpdateStackInstances(UpdateStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateStackInstancesWithOptions(request, runtime);
        }

        /**
          * In this topic, the stack group named `MyStackGroup` that is created in the China (Hangzhou) region is used. The stack group is granted the self-managed permissions. In this example, stacks of the stack group are updated by using the Alibaba Cloud accounts whose IDs are `151266687691****` and `141261387191****` in the China (Hangzhou) region and China (Beijing) region.
          *
          * @param request UpdateStackInstancesRequest
          * @return UpdateStackInstancesResponse
         */
        public async Task<UpdateStackInstancesResponse> UpdateStackInstancesAsync(UpdateStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateStackInstancesWithOptionsAsync(request, runtime);
        }

        /**
          * Limits: You can eliminate only drift on stacks that have drifted. You must call the [DetectStackDrift](~~155094~~) operation to perform drift detection on a stack, call the [GetStackDriftDetectionStatus](~~155097~~) operation to query the drift status of the stack to make sure that the stack has drifted, and then call the UpdateStackTemplateByResources operation to eliminate drift.
          * In this topic, drift is eliminated for a stack whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****`. The stack is deployed in the China (Hangzhou) region.
          *
          * @param request UpdateStackTemplateByResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateStackTemplateByResourcesResponse
         */
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

        /**
          * Limits: You can eliminate only drift on stacks that have drifted. You must call the [DetectStackDrift](~~155094~~) operation to perform drift detection on a stack, call the [GetStackDriftDetectionStatus](~~155097~~) operation to query the drift status of the stack to make sure that the stack has drifted, and then call the UpdateStackTemplateByResources operation to eliminate drift.
          * In this topic, drift is eliminated for a stack whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****`. The stack is deployed in the China (Hangzhou) region.
          *
          * @param request UpdateStackTemplateByResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateStackTemplateByResourcesResponse
         */
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

        /**
          * Limits: You can eliminate only drift on stacks that have drifted. You must call the [DetectStackDrift](~~155094~~) operation to perform drift detection on a stack, call the [GetStackDriftDetectionStatus](~~155097~~) operation to query the drift status of the stack to make sure that the stack has drifted, and then call the UpdateStackTemplateByResources operation to eliminate drift.
          * In this topic, drift is eliminated for a stack whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****`. The stack is deployed in the China (Hangzhou) region.
          *
          * @param request UpdateStackTemplateByResourcesRequest
          * @return UpdateStackTemplateByResourcesResponse
         */
        public UpdateStackTemplateByResourcesResponse UpdateStackTemplateByResources(UpdateStackTemplateByResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateStackTemplateByResourcesWithOptions(request, runtime);
        }

        /**
          * Limits: You can eliminate only drift on stacks that have drifted. You must call the [DetectStackDrift](~~155094~~) operation to perform drift detection on a stack, call the [GetStackDriftDetectionStatus](~~155097~~) operation to query the drift status of the stack to make sure that the stack has drifted, and then call the UpdateStackTemplateByResources operation to eliminate drift.
          * In this topic, drift is eliminated for a stack whose ID is `4a6c9851-3b0f-4f5f-b4ca-a14bf691****`. The stack is deployed in the China (Hangzhou) region.
          *
          * @param request UpdateStackTemplateByResourcesRequest
          * @return UpdateStackTemplateByResourcesResponse
         */
        public async Task<UpdateStackTemplateByResourcesResponse> UpdateStackTemplateByResourcesAsync(UpdateStackTemplateByResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateStackTemplateByResourcesWithOptionsAsync(request, runtime);
        }

        /**
          * When you update a template, take note of the following items:
          * *   If you specify TemplateBody or TemplateURL, the existing version number is automatically incremented by 1 after the template is updated. For example, the version is changed from v1 to v2.
          * *   If you do not specify TemplateBody or TemplateURL, the version number remains unchanged.
          * *   A template can have up to 100 versions. If the number of templates reaches the upper limit, the template fails to be updated. You must create another template.
          *
          * @param request UpdateTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateTemplateResponse
         */
        public UpdateTemplateResponse UpdateTemplateWithOptions(UpdateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                query["TemplateBody"] = request.TemplateBody;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        /**
          * When you update a template, take note of the following items:
          * *   If you specify TemplateBody or TemplateURL, the existing version number is automatically incremented by 1 after the template is updated. For example, the version is changed from v1 to v2.
          * *   If you do not specify TemplateBody or TemplateURL, the version number remains unchanged.
          * *   A template can have up to 100 versions. If the number of templates reaches the upper limit, the template fails to be updated. You must create another template.
          *
          * @param request UpdateTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateTemplateResponse
         */
        public async Task<UpdateTemplateResponse> UpdateTemplateWithOptionsAsync(UpdateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                query["TemplateBody"] = request.TemplateBody;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        /**
          * When you update a template, take note of the following items:
          * *   If you specify TemplateBody or TemplateURL, the existing version number is automatically incremented by 1 after the template is updated. For example, the version is changed from v1 to v2.
          * *   If you do not specify TemplateBody or TemplateURL, the version number remains unchanged.
          * *   A template can have up to 100 versions. If the number of templates reaches the upper limit, the template fails to be updated. You must create another template.
          *
          * @param request UpdateTemplateRequest
          * @return UpdateTemplateResponse
         */
        public UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTemplateWithOptions(request, runtime);
        }

        /**
          * When you update a template, take note of the following items:
          * *   If you specify TemplateBody or TemplateURL, the existing version number is automatically incremented by 1 after the template is updated. For example, the version is changed from v1 to v2.
          * *   If you do not specify TemplateBody or TemplateURL, the version number remains unchanged.
          * *   A template can have up to 100 versions. If the number of templates reaches the upper limit, the template fails to be updated. You must create another template.
          *
          * @param request UpdateTemplateRequest
          * @return UpdateTemplateResponse
         */
        public async Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTemplateWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, a scenario whose ID is `ts-7f7a704cf71c49a6****` is used. The scenario is created in the China (Hangzhou) region. In the scenario, the ID of a virtual private cloud (VPC) is updated to `vpc-bp1m6fww66xbntjyc****`.
          *
          * @param tmpReq UpdateTemplateScratchRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateTemplateScratchResponse
         */
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

        /**
          * In this example, a scenario whose ID is `ts-7f7a704cf71c49a6****` is used. The scenario is created in the China (Hangzhou) region. In the scenario, the ID of a virtual private cloud (VPC) is updated to `vpc-bp1m6fww66xbntjyc****`.
          *
          * @param tmpReq UpdateTemplateScratchRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateTemplateScratchResponse
         */
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

        /**
          * In this example, a scenario whose ID is `ts-7f7a704cf71c49a6****` is used. The scenario is created in the China (Hangzhou) region. In the scenario, the ID of a virtual private cloud (VPC) is updated to `vpc-bp1m6fww66xbntjyc****`.
          *
          * @param request UpdateTemplateScratchRequest
          * @return UpdateTemplateScratchResponse
         */
        public UpdateTemplateScratchResponse UpdateTemplateScratch(UpdateTemplateScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTemplateScratchWithOptions(request, runtime);
        }

        /**
          * In this example, a scenario whose ID is `ts-7f7a704cf71c49a6****` is used. The scenario is created in the China (Hangzhou) region. In the scenario, the ID of a virtual private cloud (VPC) is updated to `vpc-bp1m6fww66xbntjyc****`.
          *
          * @param request UpdateTemplateScratchRequest
          * @return UpdateTemplateScratchResponse
         */
        public async Task<UpdateTemplateScratchResponse> UpdateTemplateScratchAsync(UpdateTemplateScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTemplateScratchWithOptionsAsync(request, runtime);
        }

        /**
          * In this example, a template that you want to use to create a stack is validated. `TemplateURL` is set to `oss://ros/template/demo`.
          *
          * @param request ValidateTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ValidateTemplateResponse
         */
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

        /**
          * In this example, a template that you want to use to create a stack is validated. `TemplateURL` is set to `oss://ros/template/demo`.
          *
          * @param request ValidateTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ValidateTemplateResponse
         */
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

        /**
          * In this example, a template that you want to use to create a stack is validated. `TemplateURL` is set to `oss://ros/template/demo`.
          *
          * @param request ValidateTemplateRequest
          * @return ValidateTemplateResponse
         */
        public ValidateTemplateResponse ValidateTemplate(ValidateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ValidateTemplateWithOptions(request, runtime);
        }

        /**
          * In this example, a template that you want to use to create a stack is validated. `TemplateURL` is set to `oss://ros/template/demo`.
          *
          * @param request ValidateTemplateRequest
          * @return ValidateTemplateResponse
         */
        public async Task<ValidateTemplateResponse> ValidateTemplateAsync(ValidateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ValidateTemplateWithOptionsAsync(request, runtime);
        }

    }
}
