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

        public ContinueCreateStackResponse ContinueCreateStack(ContinueCreateStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ContinueCreateStackWithOptions(request, runtime);
        }

        public async Task<ContinueCreateStackResponse> ContinueCreateStackAsync(ContinueCreateStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ContinueCreateStackWithOptionsAsync(request, runtime);
        }

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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                query["TemplateBody"] = request.TemplateBody;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                query["TemplateBody"] = request.TemplateBody;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        public CreateChangeSetResponse CreateChangeSet(CreateChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateChangeSetWithOptions(request, runtime);
        }

        public async Task<CreateChangeSetResponse> CreateChangeSetAsync(CreateChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateChangeSetWithOptionsAsync(request, runtime);
        }

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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                query["TemplateBody"] = request.TemplateBody;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                query["TemplateBody"] = request.TemplateBody;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        public CreateStackResponse CreateStack(CreateStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStackWithOptions(request, runtime);
        }

        public async Task<CreateStackResponse> CreateStackAsync(CreateStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStackWithOptionsAsync(request, runtime);
        }

        public CreateStackGroupResponse CreateStackGroupWithOptions(CreateStackGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateStackGroupShrinkRequest request = new CreateStackGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AutoDeployment.ToMap()))
            {
                request.AutoDeploymentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AutoDeployment.ToMap(), "AutoDeployment", "json");
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

        public async Task<CreateStackGroupResponse> CreateStackGroupWithOptionsAsync(CreateStackGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateStackGroupShrinkRequest request = new CreateStackGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AutoDeployment.ToMap()))
            {
                request.AutoDeploymentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AutoDeployment.ToMap(), "AutoDeployment", "json");
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

        public CreateStackGroupResponse CreateStackGroup(CreateStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStackGroupWithOptions(request, runtime);
        }

        public async Task<CreateStackGroupResponse> CreateStackGroupAsync(CreateStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStackGroupWithOptionsAsync(request, runtime);
        }

        public CreateStackInstancesResponse CreateStackInstancesWithOptions(CreateStackInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateStackInstancesShrinkRequest request = new CreateStackInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountIds))
            {
                request.AccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountIds, "AccountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeploymentTargets.ToMap()))
            {
                request.DeploymentTargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeploymentTargets.ToMap(), "DeploymentTargets", "json");
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

        public async Task<CreateStackInstancesResponse> CreateStackInstancesWithOptionsAsync(CreateStackInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateStackInstancesShrinkRequest request = new CreateStackInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountIds))
            {
                request.AccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountIds, "AccountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeploymentTargets.ToMap()))
            {
                request.DeploymentTargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeploymentTargets.ToMap(), "DeploymentTargets", "json");
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

        public CreateStackInstancesResponse CreateStackInstances(CreateStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStackInstancesWithOptions(request, runtime);
        }

        public async Task<CreateStackInstancesResponse> CreateStackInstancesAsync(CreateStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStackInstancesWithOptionsAsync(request, runtime);
        }

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

        public CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTemplateWithOptions(request, runtime);
        }

        public async Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTemplateWithOptionsAsync(request, runtime);
        }

        public CreateTemplateScratchResponse CreateTemplateScratchWithOptions(CreateTemplateScratchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTemplateScratchShrinkRequest request = new CreateTemplateScratchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PreferenceParameters))
            {
                request.PreferenceParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PreferenceParameters, "PreferenceParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceResourceGroup.ToMap()))
            {
                request.SourceResourceGroupShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceResourceGroup.ToMap(), "SourceResourceGroup", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceResources))
            {
                request.SourceResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceResources, "SourceResources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceTag.ToMap()))
            {
                request.SourceTagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceTag.ToMap(), "SourceTag", "json");
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

        public async Task<CreateTemplateScratchResponse> CreateTemplateScratchWithOptionsAsync(CreateTemplateScratchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTemplateScratchShrinkRequest request = new CreateTemplateScratchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PreferenceParameters))
            {
                request.PreferenceParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PreferenceParameters, "PreferenceParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceResourceGroup.ToMap()))
            {
                request.SourceResourceGroupShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceResourceGroup.ToMap(), "SourceResourceGroup", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceResources))
            {
                request.SourceResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceResources, "SourceResources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceTag.ToMap()))
            {
                request.SourceTagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceTag.ToMap(), "SourceTag", "json");
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

        public CreateTemplateScratchResponse CreateTemplateScratch(CreateTemplateScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTemplateScratchWithOptions(request, runtime);
        }

        public async Task<CreateTemplateScratchResponse> CreateTemplateScratchAsync(CreateTemplateScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTemplateScratchWithOptionsAsync(request, runtime);
        }

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

        public DeleteChangeSetResponse DeleteChangeSet(DeleteChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteChangeSetWithOptions(request, runtime);
        }

        public async Task<DeleteChangeSetResponse> DeleteChangeSetAsync(DeleteChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteChangeSetWithOptionsAsync(request, runtime);
        }

        public DeleteStackResponse DeleteStackWithOptions(DeleteStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        public DeleteStackGroupResponse DeleteStackGroup(DeleteStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteStackGroupWithOptions(request, runtime);
        }

        public async Task<DeleteStackGroupResponse> DeleteStackGroupAsync(DeleteStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteStackGroupWithOptionsAsync(request, runtime);
        }

        public DeleteStackInstancesResponse DeleteStackInstancesWithOptions(DeleteStackInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteStackInstancesShrinkRequest request = new DeleteStackInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountIds))
            {
                request.AccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountIds, "AccountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeploymentTargets.ToMap()))
            {
                request.DeploymentTargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeploymentTargets.ToMap(), "DeploymentTargets", "json");
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

        public async Task<DeleteStackInstancesResponse> DeleteStackInstancesWithOptionsAsync(DeleteStackInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteStackInstancesShrinkRequest request = new DeleteStackInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountIds))
            {
                request.AccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountIds, "AccountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeploymentTargets.ToMap()))
            {
                request.DeploymentTargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeploymentTargets.ToMap(), "DeploymentTargets", "json");
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

        public DeleteStackInstancesResponse DeleteStackInstances(DeleteStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteStackInstancesWithOptions(request, runtime);
        }

        public async Task<DeleteStackInstancesResponse> DeleteStackInstancesAsync(DeleteStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteStackInstancesWithOptionsAsync(request, runtime);
        }

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

        public DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTemplateWithOptionsAsync(request, runtime);
        }

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

        public DeleteTemplateScratchResponse DeleteTemplateScratch(DeleteTemplateScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTemplateScratchWithOptions(request, runtime);
        }

        public async Task<DeleteTemplateScratchResponse> DeleteTemplateScratchAsync(DeleteTemplateScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTemplateScratchWithOptionsAsync(request, runtime);
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

        public ExecuteChangeSetResponse ExecuteChangeSet(ExecuteChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteChangeSetWithOptions(request, runtime);
        }

        public async Task<ExecuteChangeSetResponse> ExecuteChangeSetAsync(ExecuteChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteChangeSetWithOptionsAsync(request, runtime);
        }

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

        public GenerateTemplateByScratchResponse GenerateTemplateByScratch(GenerateTemplateByScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateTemplateByScratchWithOptions(request, runtime);
        }

        public async Task<GenerateTemplateByScratchResponse> GenerateTemplateByScratchAsync(GenerateTemplateByScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateTemplateByScratchWithOptionsAsync(request, runtime);
        }

        public GenerateTemplatePolicyResponse GenerateTemplatePolicyWithOptions(GenerateTemplatePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        public async Task<GenerateTemplatePolicyResponse> GenerateTemplatePolicyWithOptionsAsync(GenerateTemplatePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        public GenerateTemplatePolicyResponse GenerateTemplatePolicy(GenerateTemplatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateTemplatePolicyWithOptions(request, runtime);
        }

        public async Task<GenerateTemplatePolicyResponse> GenerateTemplatePolicyAsync(GenerateTemplatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateTemplatePolicyWithOptionsAsync(request, runtime);
        }

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

        public GetChangeSetResponse GetChangeSet(GetChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetChangeSetWithOptions(request, runtime);
        }

        public async Task<GetChangeSetResponse> GetChangeSetAsync(GetChangeSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetChangeSetWithOptionsAsync(request, runtime);
        }

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

        public GetFeatureDetailsResponse GetFeatureDetails(GetFeatureDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFeatureDetailsWithOptions(request, runtime);
        }

        public async Task<GetFeatureDetailsResponse> GetFeatureDetailsAsync(GetFeatureDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFeatureDetailsWithOptionsAsync(request, runtime);
        }

        public GetResourceTypeResponse GetResourceTypeWithOptions(GetResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        public async Task<GetResourceTypeResponse> GetResourceTypeWithOptionsAsync(GetResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        public GetResourceTypeResponse GetResourceType(GetResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceTypeWithOptions(request, runtime);
        }

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

        public GetServiceProvisionsResponse GetServiceProvisions(GetServiceProvisionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceProvisionsWithOptions(request, runtime);
        }

        public async Task<GetServiceProvisionsResponse> GetServiceProvisionsAsync(GetServiceProvisionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceProvisionsWithOptionsAsync(request, runtime);
        }

        public GetStackResponse GetStackWithOptions(GetStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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

        public async Task<GetStackResponse> GetStackWithOptionsAsync(GetStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
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

        public GetStackResponse GetStack(GetStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStackWithOptions(request, runtime);
        }

        public async Task<GetStackResponse> GetStackAsync(GetStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStackWithOptionsAsync(request, runtime);
        }

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

        public GetStackDriftDetectionStatusResponse GetStackDriftDetectionStatus(GetStackDriftDetectionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStackDriftDetectionStatusWithOptions(request, runtime);
        }

        public async Task<GetStackDriftDetectionStatusResponse> GetStackDriftDetectionStatusAsync(GetStackDriftDetectionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStackDriftDetectionStatusWithOptionsAsync(request, runtime);
        }

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

        public GetStackGroupResponse GetStackGroup(GetStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStackGroupWithOptions(request, runtime);
        }

        public async Task<GetStackGroupResponse> GetStackGroupAsync(GetStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStackGroupWithOptionsAsync(request, runtime);
        }

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

        public GetStackGroupOperationResponse GetStackGroupOperation(GetStackGroupOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStackGroupOperationWithOptions(request, runtime);
        }

        public async Task<GetStackGroupOperationResponse> GetStackGroupOperationAsync(GetStackGroupOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStackGroupOperationWithOptionsAsync(request, runtime);
        }

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

        public GetStackInstanceResponse GetStackInstance(GetStackInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStackInstanceWithOptions(request, runtime);
        }

        public async Task<GetStackInstanceResponse> GetStackInstanceAsync(GetStackInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStackInstanceWithOptionsAsync(request, runtime);
        }

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

        public GetStackPolicyResponse GetStackPolicy(GetStackPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStackPolicyWithOptions(request, runtime);
        }

        public async Task<GetStackPolicyResponse> GetStackPolicyAsync(GetStackPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStackPolicyWithOptionsAsync(request, runtime);
        }

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

        public GetStackResourceResponse GetStackResource(GetStackResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStackResourceWithOptions(request, runtime);
        }

        public async Task<GetStackResourceResponse> GetStackResourceAsync(GetStackResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStackResourceWithOptionsAsync(request, runtime);
        }

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

        public GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateWithOptions(request, runtime);
        }

        public async Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateWithOptionsAsync(request, runtime);
        }

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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                query["TemplateBody"] = request.TemplateBody;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                query["TemplateBody"] = request.TemplateBody;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        public GetTemplateEstimateCostResponse GetTemplateEstimateCost(GetTemplateEstimateCostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateEstimateCostWithOptions(request, runtime);
        }

        public async Task<GetTemplateEstimateCostResponse> GetTemplateEstimateCostAsync(GetTemplateEstimateCostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateEstimateCostWithOptionsAsync(request, runtime);
        }

        public GetTemplateParameterConstraintsResponse GetTemplateParameterConstraintsWithOptions(GetTemplateParameterConstraintsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetTemplateParameterConstraintsShrinkRequest request = new GetTemplateParameterConstraintsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ParametersKeyFilter))
            {
                request.ParametersKeyFilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ParametersKeyFilter, "ParametersKeyFilter", "json");
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

        public async Task<GetTemplateParameterConstraintsResponse> GetTemplateParameterConstraintsWithOptionsAsync(GetTemplateParameterConstraintsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetTemplateParameterConstraintsShrinkRequest request = new GetTemplateParameterConstraintsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ParametersKeyFilter))
            {
                request.ParametersKeyFilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ParametersKeyFilter, "ParametersKeyFilter", "json");
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

        public GetTemplateParameterConstraintsResponse GetTemplateParameterConstraints(GetTemplateParameterConstraintsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateParameterConstraintsWithOptions(request, runtime);
        }

        public async Task<GetTemplateParameterConstraintsResponse> GetTemplateParameterConstraintsAsync(GetTemplateParameterConstraintsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateParameterConstraintsWithOptionsAsync(request, runtime);
        }

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

        public GetTemplateScratchResponse GetTemplateScratch(GetTemplateScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateScratchWithOptions(request, runtime);
        }

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

        public ListResourceTypesResponse ListResourceTypesWithOptions(ListResourceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
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

        public async Task<ListResourceTypesResponse> ListResourceTypesWithOptionsAsync(ListResourceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
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

        public ListResourceTypesResponse ListResourceTypes(ListResourceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceTypesWithOptions(request, runtime);
        }

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

        public ListStackGroupOperationResultsResponse ListStackGroupOperationResults(ListStackGroupOperationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStackGroupOperationResultsWithOptions(request, runtime);
        }

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

        public ListStackGroupsResponse ListStackGroups(ListStackGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStackGroupsWithOptions(request, runtime);
        }

        public async Task<ListStackGroupsResponse> ListStackGroupsAsync(ListStackGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStackGroupsWithOptionsAsync(request, runtime);
        }

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

        public ListStackInstancesResponse ListStackInstances(ListStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStackInstancesWithOptions(request, runtime);
        }

        public async Task<ListStackInstancesResponse> ListStackInstancesAsync(ListStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStackInstancesWithOptionsAsync(request, runtime);
        }

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

        public ListStackOperationRisksResponse ListStackOperationRisks(ListStackOperationRisksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStackOperationRisksWithOptions(request, runtime);
        }

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

        public ListStackResourcesResponse ListStackResources(ListStackResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStackResourcesWithOptions(request, runtime);
        }

        public async Task<ListStackResourcesResponse> ListStackResourcesAsync(ListStackResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStackResourcesWithOptionsAsync(request, runtime);
        }

        public ListStacksResponse ListStacksWithOptions(ListStacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        public async Task<ListStacksResponse> ListStacksWithOptionsAsync(ListStacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        public ListStacksResponse ListStacks(ListStacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStacksWithOptions(request, runtime);
        }

        public async Task<ListStacksResponse> ListStacksAsync(ListStacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStacksWithOptionsAsync(request, runtime);
        }

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

        public ListTagKeysResponse ListTagKeys(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagKeysWithOptions(request, runtime);
        }

        public async Task<ListTagKeysResponse> ListTagKeysAsync(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagKeysWithOptionsAsync(request, runtime);
        }

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

        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

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

        public ListTagValuesResponse ListTagValues(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagValuesWithOptions(request, runtime);
        }

        public async Task<ListTagValuesResponse> ListTagValuesAsync(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagValuesWithOptionsAsync(request, runtime);
        }

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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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

        public ListTemplateScratchesResponse ListTemplateScratches(ListTemplateScratchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTemplateScratchesWithOptions(request, runtime);
        }

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

        public MoveResourceGroupResponse MoveResourceGroup(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveResourceGroupWithOptions(request, runtime);
        }

        public async Task<MoveResourceGroupResponse> MoveResourceGroupAsync(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveResourceGroupWithOptionsAsync(request, runtime);
        }

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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                query["TemplateBody"] = request.TemplateBody;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                query["TemplateBody"] = request.TemplateBody;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        public PreviewStackResponse PreviewStack(PreviewStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PreviewStackWithOptions(request, runtime);
        }

        public async Task<PreviewStackResponse> PreviewStackAsync(PreviewStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PreviewStackWithOptionsAsync(request, runtime);
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

        public SetStackPolicyResponse SetStackPolicy(SetStackPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetStackPolicyWithOptions(request, runtime);
        }

        public async Task<SetStackPolicyResponse> SetStackPolicyAsync(SetStackPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetStackPolicyWithOptionsAsync(request, runtime);
        }

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

        public SetTemplatePermissionResponse SetTemplatePermission(SetTemplatePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetTemplatePermissionWithOptions(request, runtime);
        }

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

        public StopStackGroupOperationResponse StopStackGroupOperation(StopStackGroupOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopStackGroupOperationWithOptions(request, runtime);
        }

        public async Task<StopStackGroupOperationResponse> StopStackGroupOperationAsync(StopStackGroupOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopStackGroupOperationWithOptionsAsync(request, runtime);
        }

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

        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

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

        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutInMinutes))
            {
                query["TimeoutInMinutes"] = request.TimeoutInMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePreviousParameters))
            {
                query["UsePreviousParameters"] = request.UsePreviousParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutInMinutes))
            {
                query["TimeoutInMinutes"] = request.TimeoutInMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePreviousParameters))
            {
                query["UsePreviousParameters"] = request.UsePreviousParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        public UpdateStackResponse UpdateStack(UpdateStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateStackWithOptions(request, runtime);
        }

        public async Task<UpdateStackResponse> UpdateStackAsync(UpdateStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateStackWithOptionsAsync(request, runtime);
        }

        public UpdateStackGroupResponse UpdateStackGroupWithOptions(UpdateStackGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateStackGroupShrinkRequest request = new UpdateStackGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountIds))
            {
                request.AccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountIds, "AccountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AutoDeployment.ToMap()))
            {
                request.AutoDeploymentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AutoDeployment.ToMap(), "AutoDeployment", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeploymentTargets.ToMap()))
            {
                request.DeploymentTargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeploymentTargets.ToMap(), "DeploymentTargets", "json");
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

        public async Task<UpdateStackGroupResponse> UpdateStackGroupWithOptionsAsync(UpdateStackGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateStackGroupShrinkRequest request = new UpdateStackGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountIds))
            {
                request.AccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountIds, "AccountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AutoDeployment.ToMap()))
            {
                request.AutoDeploymentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AutoDeployment.ToMap(), "AutoDeployment", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeploymentTargets.ToMap()))
            {
                request.DeploymentTargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeploymentTargets.ToMap(), "DeploymentTargets", "json");
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

        public UpdateStackGroupResponse UpdateStackGroup(UpdateStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateStackGroupWithOptions(request, runtime);
        }

        public async Task<UpdateStackGroupResponse> UpdateStackGroupAsync(UpdateStackGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateStackGroupWithOptionsAsync(request, runtime);
        }

        public UpdateStackInstancesResponse UpdateStackInstancesWithOptions(UpdateStackInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateStackInstancesShrinkRequest request = new UpdateStackInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountIds))
            {
                request.AccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountIds, "AccountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeploymentTargets.ToMap()))
            {
                request.DeploymentTargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeploymentTargets.ToMap(), "DeploymentTargets", "json");
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

        public async Task<UpdateStackInstancesResponse> UpdateStackInstancesWithOptionsAsync(UpdateStackInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateStackInstancesShrinkRequest request = new UpdateStackInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountIds))
            {
                request.AccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountIds, "AccountIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeploymentTargets.ToMap()))
            {
                request.DeploymentTargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeploymentTargets.ToMap(), "DeploymentTargets", "json");
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

        public UpdateStackInstancesResponse UpdateStackInstances(UpdateStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateStackInstancesWithOptions(request, runtime);
        }

        public async Task<UpdateStackInstancesResponse> UpdateStackInstancesAsync(UpdateStackInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateStackInstancesWithOptionsAsync(request, runtime);
        }

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

        public UpdateStackTemplateByResourcesResponse UpdateStackTemplateByResources(UpdateStackTemplateByResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateStackTemplateByResourcesWithOptions(request, runtime);
        }

        public async Task<UpdateStackTemplateByResourcesResponse> UpdateStackTemplateByResourcesAsync(UpdateStackTemplateByResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateStackTemplateByResourcesWithOptionsAsync(request, runtime);
        }

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

        public UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTemplateWithOptions(request, runtime);
        }

        public async Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTemplateWithOptionsAsync(request, runtime);
        }

        public UpdateTemplateScratchResponse UpdateTemplateScratchWithOptions(UpdateTemplateScratchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTemplateScratchShrinkRequest request = new UpdateTemplateScratchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PreferenceParameters))
            {
                request.PreferenceParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PreferenceParameters, "PreferenceParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceResourceGroup.ToMap()))
            {
                request.SourceResourceGroupShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceResourceGroup.ToMap(), "SourceResourceGroup", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceResources))
            {
                request.SourceResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceResources, "SourceResources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceTag.ToMap()))
            {
                request.SourceTagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceTag.ToMap(), "SourceTag", "json");
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

        public async Task<UpdateTemplateScratchResponse> UpdateTemplateScratchWithOptionsAsync(UpdateTemplateScratchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTemplateScratchShrinkRequest request = new UpdateTemplateScratchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PreferenceParameters))
            {
                request.PreferenceParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PreferenceParameters, "PreferenceParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceResourceGroup.ToMap()))
            {
                request.SourceResourceGroupShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceResourceGroup.ToMap(), "SourceResourceGroup", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceResources))
            {
                request.SourceResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceResources, "SourceResources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceTag.ToMap()))
            {
                request.SourceTagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceTag.ToMap(), "SourceTag", "json");
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

        public UpdateTemplateScratchResponse UpdateTemplateScratch(UpdateTemplateScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTemplateScratchWithOptions(request, runtime);
        }

        public async Task<UpdateTemplateScratchResponse> UpdateTemplateScratchAsync(UpdateTemplateScratchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTemplateScratchWithOptionsAsync(request, runtime);
        }

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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                query["TemplateBody"] = request.TemplateBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidationOption))
            {
                query["ValidationOption"] = request.ValidationOption;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateBody))
            {
                query["TemplateBody"] = request.TemplateBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidationOption))
            {
                query["ValidationOption"] = request.ValidationOption;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        public ValidateTemplateResponse ValidateTemplate(ValidateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ValidateTemplateWithOptions(request, runtime);
        }

        public async Task<ValidateTemplateResponse> ValidateTemplateAsync(ValidateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ValidateTemplateWithOptionsAsync(request, runtime);
        }

    }
}
