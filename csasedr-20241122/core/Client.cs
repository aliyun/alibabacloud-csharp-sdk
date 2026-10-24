// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.CsasEdr20241122.Models;

namespace AlibabaCloud.SDK.CsasEdr20241122
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("csasedr", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Creates a client rule policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a client rule policy. The policy type is specified by PolicyType.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateClientRuleStrategyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateClientRuleStrategyResponse
        /// </returns>
        public CreateClientRuleStrategyResponse CreateClientRuleStrategyWithOptions(CreateClientRuleStrategyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateClientRuleStrategyShrinkRequest request = new CreateClientRuleStrategyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExcludeUserNameList))
            {
                request.ExcludeUserNameListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExcludeUserNameList, "ExcludeUserNameList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IncludeGroupIdList))
            {
                request.IncludeGroupIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IncludeGroupIdList, "IncludeGroupIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PortOnList))
            {
                request.PortOnListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PortOnList, "PortOnList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SoftWareOnList))
            {
                request.SoftWareOnListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SoftWareOnList, "SoftWareOnList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                query["ActionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllGroup))
            {
                query["AllGroup"] = request.AllGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovalId))
            {
                query["ApprovalId"] = request.ApprovalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cmdline))
            {
                query["Cmdline"] = request.Cmdline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeUserNameListShrink))
            {
                query["ExcludeUserNameList"] = request.ExcludeUserNameListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InSwitch))
            {
                query["InSwitch"] = request.InSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeGroupIdListShrink))
            {
                query["IncludeGroupIdList"] = request.IncludeGroupIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainButtonTextCh))
            {
                query["MainButtonTextCh"] = request.MainButtonTextCh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainButtonTextEn))
            {
                query["MainButtonTextEn"] = request.MainButtonTextEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchMode))
            {
                query["MatchMode"] = request.MatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchTargetIds))
            {
                query["MatchTargetIds"] = request.MatchTargetIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Md5List))
            {
                query["Md5List"] = request.Md5List;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinorButtonTextCh))
            {
                query["MinorButtonTextCh"] = request.MinorButtonTextCh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinorButtonTextEn))
            {
                query["MinorButtonTextEn"] = request.MinorButtonTextEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewFilePath))
            {
                query["NewFilePath"] = request.NewFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSwitch))
            {
                query["OutSwitch"] = request.OutSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCmdline))
            {
                query["ParentCmdline"] = request.ParentCmdline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentProcPath))
            {
                query["ParentProcPath"] = request.ParentProcPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortOnListShrink))
            {
                query["PortOnList"] = request.PortOnListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcPath))
            {
                query["ProcPath"] = request.ProcPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryContent))
            {
                query["RegistryContent"] = request.RegistryContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryKey))
            {
                query["RegistryKey"] = request.RegistryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectionKey))
            {
                query["SelectionKey"] = request.SelectionKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SoftWareOnListShrink))
            {
                query["SoftWareOnList"] = request.SoftWareOnListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategySourceType))
            {
                query["StrategySourceType"] = request.StrategySourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportsApproval))
            {
                query["SupportsApproval"] = request.SupportsApproval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsContent))
            {
                query["UsContent"] = request.UsContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsTitle))
            {
                query["UsTitle"] = request.UsTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhContent))
            {
                query["ZhContent"] = request.ZhContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhTitle))
            {
                query["ZhTitle"] = request.ZhTitle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClientRuleStrategy",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClientRuleStrategyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a client rule policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a client rule policy. The policy type is specified by PolicyType.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateClientRuleStrategyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateClientRuleStrategyResponse
        /// </returns>
        public async Task<CreateClientRuleStrategyResponse> CreateClientRuleStrategyWithOptionsAsync(CreateClientRuleStrategyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateClientRuleStrategyShrinkRequest request = new CreateClientRuleStrategyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExcludeUserNameList))
            {
                request.ExcludeUserNameListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExcludeUserNameList, "ExcludeUserNameList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IncludeGroupIdList))
            {
                request.IncludeGroupIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IncludeGroupIdList, "IncludeGroupIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PortOnList))
            {
                request.PortOnListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PortOnList, "PortOnList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SoftWareOnList))
            {
                request.SoftWareOnListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SoftWareOnList, "SoftWareOnList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                query["ActionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllGroup))
            {
                query["AllGroup"] = request.AllGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovalId))
            {
                query["ApprovalId"] = request.ApprovalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cmdline))
            {
                query["Cmdline"] = request.Cmdline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeUserNameListShrink))
            {
                query["ExcludeUserNameList"] = request.ExcludeUserNameListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InSwitch))
            {
                query["InSwitch"] = request.InSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeGroupIdListShrink))
            {
                query["IncludeGroupIdList"] = request.IncludeGroupIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainButtonTextCh))
            {
                query["MainButtonTextCh"] = request.MainButtonTextCh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainButtonTextEn))
            {
                query["MainButtonTextEn"] = request.MainButtonTextEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchMode))
            {
                query["MatchMode"] = request.MatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchTargetIds))
            {
                query["MatchTargetIds"] = request.MatchTargetIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Md5List))
            {
                query["Md5List"] = request.Md5List;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinorButtonTextCh))
            {
                query["MinorButtonTextCh"] = request.MinorButtonTextCh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinorButtonTextEn))
            {
                query["MinorButtonTextEn"] = request.MinorButtonTextEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewFilePath))
            {
                query["NewFilePath"] = request.NewFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSwitch))
            {
                query["OutSwitch"] = request.OutSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCmdline))
            {
                query["ParentCmdline"] = request.ParentCmdline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentProcPath))
            {
                query["ParentProcPath"] = request.ParentProcPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortOnListShrink))
            {
                query["PortOnList"] = request.PortOnListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcPath))
            {
                query["ProcPath"] = request.ProcPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryContent))
            {
                query["RegistryContent"] = request.RegistryContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryKey))
            {
                query["RegistryKey"] = request.RegistryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectionKey))
            {
                query["SelectionKey"] = request.SelectionKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SoftWareOnListShrink))
            {
                query["SoftWareOnList"] = request.SoftWareOnListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategySourceType))
            {
                query["StrategySourceType"] = request.StrategySourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportsApproval))
            {
                query["SupportsApproval"] = request.SupportsApproval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsContent))
            {
                query["UsContent"] = request.UsContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsTitle))
            {
                query["UsTitle"] = request.UsTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhContent))
            {
                query["ZhContent"] = request.ZhContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhTitle))
            {
                query["ZhTitle"] = request.ZhTitle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClientRuleStrategy",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClientRuleStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a client rule policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a client rule policy. The policy type is specified by PolicyType.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClientRuleStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateClientRuleStrategyResponse
        /// </returns>
        public CreateClientRuleStrategyResponse CreateClientRuleStrategy(CreateClientRuleStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClientRuleStrategyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a client rule policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a client rule policy. The policy type is specified by PolicyType.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClientRuleStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateClientRuleStrategyResponse
        /// </returns>
        public async Task<CreateClientRuleStrategyResponse> CreateClientRuleStrategyAsync(CreateClientRuleStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClientRuleStrategyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a general asset selection configuration and generates a SelectionKey for use in What to do next.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is used for the initialization of a general asset selection configuration and generates a SelectionKey. The addition or selection of specific assets is completed in What to do next. When you invoke this operation, it only generates the configuration object and does not save the configuration record.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSelectionConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSelectionConfigResponse
        /// </returns>
        public CreateSelectionConfigResponse CreateSelectionConfigWithOptions(CreateSelectionConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSelectionConfig",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSelectionConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a general asset selection configuration and generates a SelectionKey for use in What to do next.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is used for the initialization of a general asset selection configuration and generates a SelectionKey. The addition or selection of specific assets is completed in What to do next. When you invoke this operation, it only generates the configuration object and does not save the configuration record.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSelectionConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSelectionConfigResponse
        /// </returns>
        public async Task<CreateSelectionConfigResponse> CreateSelectionConfigWithOptionsAsync(CreateSelectionConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSelectionConfig",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSelectionConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a general asset selection configuration and generates a SelectionKey for use in What to do next.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is used for the initialization of a general asset selection configuration and generates a SelectionKey. The addition or selection of specific assets is completed in What to do next. When you invoke this operation, it only generates the configuration object and does not save the configuration record.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSelectionConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSelectionConfigResponse
        /// </returns>
        public CreateSelectionConfigResponse CreateSelectionConfig(CreateSelectionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSelectionConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a general asset selection configuration and generates a SelectionKey for use in What to do next.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is used for the initialization of a general asset selection configuration and generates a SelectionKey. The addition or selection of specific assets is completed in What to do next. When you invoke this operation, it only generates the configuration object and does not save the configuration record.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSelectionConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSelectionConfigResponse
        /// </returns>
        public async Task<CreateSelectionConfigResponse> CreateSelectionConfigAsync(CreateSelectionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSelectionConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a node to query alerting events triggered by the same rule or Alarm Metric.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSimilarSecurityEventsQueryTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSimilarSecurityEventsQueryTaskResponse
        /// </returns>
        public CreateSimilarSecurityEventsQueryTaskResponse CreateSimilarSecurityEventsQueryTaskWithOptions(CreateSimilarSecurityEventsQueryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityEventId))
            {
                query["SecurityEventId"] = request.SecurityEventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimilarEventScenarioCode))
            {
                query["SimilarEventScenarioCode"] = request.SimilarEventScenarioCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSimilarSecurityEventsQueryTask",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSimilarSecurityEventsQueryTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a node to query alerting events triggered by the same rule or Alarm Metric.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSimilarSecurityEventsQueryTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSimilarSecurityEventsQueryTaskResponse
        /// </returns>
        public async Task<CreateSimilarSecurityEventsQueryTaskResponse> CreateSimilarSecurityEventsQueryTaskWithOptionsAsync(CreateSimilarSecurityEventsQueryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityEventId))
            {
                query["SecurityEventId"] = request.SecurityEventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimilarEventScenarioCode))
            {
                query["SimilarEventScenarioCode"] = request.SimilarEventScenarioCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSimilarSecurityEventsQueryTask",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSimilarSecurityEventsQueryTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a node to query alerting events triggered by the same rule or Alarm Metric.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSimilarSecurityEventsQueryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSimilarSecurityEventsQueryTaskResponse
        /// </returns>
        public CreateSimilarSecurityEventsQueryTaskResponse CreateSimilarSecurityEventsQueryTask(CreateSimilarSecurityEventsQueryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSimilarSecurityEventsQueryTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a node to query alerting events triggered by the same rule or Alarm Metric.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSimilarSecurityEventsQueryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSimilarSecurityEventsQueryTaskResponse
        /// </returns>
        public async Task<CreateSimilarSecurityEventsQueryTaskResponse> CreateSimilarSecurityEventsQueryTaskAsync(CreateSimilarSecurityEventsQueryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSimilarSecurityEventsQueryTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes client rule policies based on a list of policy IDs.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteClientRuleStrategyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientRuleStrategyResponse
        /// </returns>
        public DeleteClientRuleStrategyResponse DeleteClientRuleStrategyWithOptions(DeleteClientRuleStrategyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteClientRuleStrategyShrinkRequest request = new DeleteClientRuleStrategyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IdList))
            {
                request.IdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IdList, "IdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdListShrink))
            {
                query["IdList"] = request.IdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteClientRuleStrategy",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClientRuleStrategyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes client rule policies based on a list of policy IDs.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteClientRuleStrategyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientRuleStrategyResponse
        /// </returns>
        public async Task<DeleteClientRuleStrategyResponse> DeleteClientRuleStrategyWithOptionsAsync(DeleteClientRuleStrategyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteClientRuleStrategyShrinkRequest request = new DeleteClientRuleStrategyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IdList))
            {
                request.IdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IdList, "IdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdListShrink))
            {
                query["IdList"] = request.IdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteClientRuleStrategy",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClientRuleStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes client rule policies based on a list of policy IDs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteClientRuleStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientRuleStrategyResponse
        /// </returns>
        public DeleteClientRuleStrategyResponse DeleteClientRuleStrategy(DeleteClientRuleStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClientRuleStrategyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes client rule policies based on a list of policy IDs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteClientRuleStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientRuleStrategyResponse
        /// </returns>
        public async Task<DeleteClientRuleStrategyResponse> DeleteClientRuleStrategyAsync(DeleteClientRuleStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClientRuleStrategyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes alert whitelist configurations in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSecurityEventMarkMissListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecurityEventMarkMissListResponse
        /// </returns>
        public DeleteSecurityEventMarkMissListResponse DeleteSecurityEventMarkMissListWithOptions(DeleteSecurityEventMarkMissListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["Ids"] = request.Ids;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSecurityEventMarkMissList",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSecurityEventMarkMissListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes alert whitelist configurations in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSecurityEventMarkMissListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecurityEventMarkMissListResponse
        /// </returns>
        public async Task<DeleteSecurityEventMarkMissListResponse> DeleteSecurityEventMarkMissListWithOptionsAsync(DeleteSecurityEventMarkMissListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["Ids"] = request.Ids;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSecurityEventMarkMissList",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSecurityEventMarkMissListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes alert whitelist configurations in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSecurityEventMarkMissListRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecurityEventMarkMissListResponse
        /// </returns>
        public DeleteSecurityEventMarkMissListResponse DeleteSecurityEventMarkMissList(DeleteSecurityEventMarkMissListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSecurityEventMarkMissListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes alert whitelist configurations in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSecurityEventMarkMissListRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecurityEventMarkMissListResponse
        /// </returns>
        public async Task<DeleteSecurityEventMarkMissListResponse> DeleteSecurityEventMarkMissListAsync(DeleteSecurityEventMarkMissListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSecurityEventMarkMissListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the effective scope mode, target list, and scope record information based on the asset scope ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAssetScopeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAssetScopeResponse
        /// </returns>
        public DescribeAssetScopeResponse DescribeAssetScopeWithOptions(DescribeAssetScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAssetScope",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAssetScopeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the effective scope mode, target list, and scope record information based on the asset scope ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAssetScopeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAssetScopeResponse
        /// </returns>
        public async Task<DescribeAssetScopeResponse> DescribeAssetScopeWithOptionsAsync(DescribeAssetScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAssetScope",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAssetScopeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the effective scope mode, target list, and scope record information based on the asset scope ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAssetScopeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAssetScopeResponse
        /// </returns>
        public DescribeAssetScopeResponse DescribeAssetScope(DescribeAssetScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAssetScopeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the effective scope mode, target list, and scope record information based on the asset scope ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAssetScopeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAssetScopeResponse
        /// </returns>
        public async Task<DescribeAssetScopeResponse> DescribeAssetScopeAsync(DescribeAssetScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAssetScopeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries security alert types.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNsasSuspEventTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNsasSuspEventTypeResponse
        /// </returns>
        public DescribeNsasSuspEventTypeResponse DescribeNsasSuspEventTypeWithOptions(DescribeNsasSuspEventTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerFieldName))
            {
                query["ContainerFieldName"] = request.ContainerFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerFieldValue))
            {
                query["ContainerFieldValue"] = request.ContainerFieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                query["Uuids"] = request.Uuids;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNsasSuspEventType",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNsasSuspEventTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries security alert types.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNsasSuspEventTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNsasSuspEventTypeResponse
        /// </returns>
        public async Task<DescribeNsasSuspEventTypeResponse> DescribeNsasSuspEventTypeWithOptionsAsync(DescribeNsasSuspEventTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerFieldName))
            {
                query["ContainerFieldName"] = request.ContainerFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerFieldValue))
            {
                query["ContainerFieldValue"] = request.ContainerFieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                query["Uuids"] = request.Uuids;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNsasSuspEventType",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNsasSuspEventTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries security alert types.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNsasSuspEventTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNsasSuspEventTypeResponse
        /// </returns>
        public DescribeNsasSuspEventTypeResponse DescribeNsasSuspEventType(DescribeNsasSuspEventTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNsasSuspEventTypeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries security alert types.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNsasSuspEventTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNsasSuspEventTypeResponse
        /// </returns>
        public async Task<DescribeNsasSuspEventTypeResponse> DescribeNsasSuspEventTypeAsync(DescribeNsasSuspEventTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNsasSuspEventTypeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the automatic whitelist rules for alerts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSecurityEventMarkMissListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityEventMarkMissListResponse
        /// </returns>
        public DescribeSecurityEventMarkMissListResponse DescribeSecurityEventMarkMissListWithOptions(DescribeSecurityEventMarkMissListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisposalWay))
            {
                query["DisposalWay"] = request.DisposalWay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                query["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecurityEventMarkMissList",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecurityEventMarkMissListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the automatic whitelist rules for alerts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSecurityEventMarkMissListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityEventMarkMissListResponse
        /// </returns>
        public async Task<DescribeSecurityEventMarkMissListResponse> DescribeSecurityEventMarkMissListWithOptionsAsync(DescribeSecurityEventMarkMissListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisposalWay))
            {
                query["DisposalWay"] = request.DisposalWay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                query["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecurityEventMarkMissList",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecurityEventMarkMissListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the automatic whitelist rules for alerts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSecurityEventMarkMissListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityEventMarkMissListResponse
        /// </returns>
        public DescribeSecurityEventMarkMissListResponse DescribeSecurityEventMarkMissList(DescribeSecurityEventMarkMissListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityEventMarkMissListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the automatic whitelist rules for alerts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSecurityEventMarkMissListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityEventMarkMissListResponse
        /// </returns>
        public async Task<DescribeSecurityEventMarkMissListResponse> DescribeSecurityEventMarkMissListAsync(DescribeSecurityEventMarkMissListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityEventMarkMissListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the processing status of security alerts based on the task ID or alert event ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSecurityEventOperationStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityEventOperationStatusResponse
        /// </returns>
        public DescribeSecurityEventOperationStatusResponse DescribeSecurityEventOperationStatusWithOptions(DescribeSecurityEventOperationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityEventIds))
            {
                query["SecurityEventIds"] = request.SecurityEventIds;
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
                Action = "DescribeSecurityEventOperationStatus",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecurityEventOperationStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the processing status of security alerts based on the task ID or alert event ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSecurityEventOperationStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityEventOperationStatusResponse
        /// </returns>
        public async Task<DescribeSecurityEventOperationStatusResponse> DescribeSecurityEventOperationStatusWithOptionsAsync(DescribeSecurityEventOperationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityEventIds))
            {
                query["SecurityEventIds"] = request.SecurityEventIds;
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
                Action = "DescribeSecurityEventOperationStatus",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecurityEventOperationStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the processing status of security alerts based on the task ID or alert event ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSecurityEventOperationStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityEventOperationStatusResponse
        /// </returns>
        public DescribeSecurityEventOperationStatusResponse DescribeSecurityEventOperationStatus(DescribeSecurityEventOperationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityEventOperationStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the processing status of security alerts based on the task ID or alert event ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSecurityEventOperationStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityEventOperationStatusResponse
        /// </returns>
        public async Task<DescribeSecurityEventOperationStatusResponse> DescribeSecurityEventOperationStatusAsync(DescribeSecurityEventOperationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityEventOperationStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the handling operations, operability, and whitelist rule configurations for a specified endpoint alert in its current state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the handling operations that can be displayed for a specified endpoint alert. When initiating a subsequent response, you must select the operation items returned in this response where UserCanOperate is true, and submit parameters as required by the response operation. The query result does not guarantee that the subsequent response will succeed.
        /// The actual returned results are affected by feature switches, canary releases, dynamic allowlists, alert templates, alert statuses, and filter conditions. The list may be empty. The examples are used to illustrate field formats or rule combinations and do not represent that a specific alert will definitely return these values. MappingMarkFields and its subfields are generic compatibility structures. The current query pipeline does not populate their elements, and you should not infer that this operation supports the corresponding capabilities based on them.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSecurityEventOperationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityEventOperationsResponse
        /// </returns>
        public DescribeSecurityEventOperationsResponse DescribeSecurityEventOperationsWithOptions(DescribeSecurityEventOperationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityEventId))
            {
                query["SecurityEventId"] = request.SecurityEventId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecurityEventOperations",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecurityEventOperationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the handling operations, operability, and whitelist rule configurations for a specified endpoint alert in its current state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the handling operations that can be displayed for a specified endpoint alert. When initiating a subsequent response, you must select the operation items returned in this response where UserCanOperate is true, and submit parameters as required by the response operation. The query result does not guarantee that the subsequent response will succeed.
        /// The actual returned results are affected by feature switches, canary releases, dynamic allowlists, alert templates, alert statuses, and filter conditions. The list may be empty. The examples are used to illustrate field formats or rule combinations and do not represent that a specific alert will definitely return these values. MappingMarkFields and its subfields are generic compatibility structures. The current query pipeline does not populate their elements, and you should not infer that this operation supports the corresponding capabilities based on them.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSecurityEventOperationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityEventOperationsResponse
        /// </returns>
        public async Task<DescribeSecurityEventOperationsResponse> DescribeSecurityEventOperationsWithOptionsAsync(DescribeSecurityEventOperationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityEventId))
            {
                query["SecurityEventId"] = request.SecurityEventId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecurityEventOperations",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecurityEventOperationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the handling operations, operability, and whitelist rule configurations for a specified endpoint alert in its current state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the handling operations that can be displayed for a specified endpoint alert. When initiating a subsequent response, you must select the operation items returned in this response where UserCanOperate is true, and submit parameters as required by the response operation. The query result does not guarantee that the subsequent response will succeed.
        /// The actual returned results are affected by feature switches, canary releases, dynamic allowlists, alert templates, alert statuses, and filter conditions. The list may be empty. The examples are used to illustrate field formats or rule combinations and do not represent that a specific alert will definitely return these values. MappingMarkFields and its subfields are generic compatibility structures. The current query pipeline does not populate their elements, and you should not infer that this operation supports the corresponding capabilities based on them.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSecurityEventOperationsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityEventOperationsResponse
        /// </returns>
        public DescribeSecurityEventOperationsResponse DescribeSecurityEventOperations(DescribeSecurityEventOperationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityEventOperationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the handling operations, operability, and whitelist rule configurations for a specified endpoint alert in its current state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation queries the handling operations that can be displayed for a specified endpoint alert. When initiating a subsequent response, you must select the operation items returned in this response where UserCanOperate is true, and submit parameters as required by the response operation. The query result does not guarantee that the subsequent response will succeed.
        /// The actual returned results are affected by feature switches, canary releases, dynamic allowlists, alert templates, alert statuses, and filter conditions. The list may be empty. The examples are used to illustrate field formats or rule combinations and do not represent that a specific alert will definitely return these values. MappingMarkFields and its subfields are generic compatibility structures. The current query pipeline does not populate their elements, and you should not infer that this operation supports the corresponding capabilities based on them.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSecurityEventOperationsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityEventOperationsResponse
        /// </returns>
        public async Task<DescribeSecurityEventOperationsResponse> DescribeSecurityEventOperationsAsync(DescribeSecurityEventOperationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityEventOperationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the handling scenarios for alerts triggered by the same rule or type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSimilarEventScenariosRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSimilarEventScenariosResponse
        /// </returns>
        public DescribeSimilarEventScenariosResponse DescribeSimilarEventScenariosWithOptions(DescribeSimilarEventScenariosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityEventId))
            {
                query["SecurityEventId"] = request.SecurityEventId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSimilarEventScenarios",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSimilarEventScenariosResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the handling scenarios for alerts triggered by the same rule or type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSimilarEventScenariosRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSimilarEventScenariosResponse
        /// </returns>
        public async Task<DescribeSimilarEventScenariosResponse> DescribeSimilarEventScenariosWithOptionsAsync(DescribeSimilarEventScenariosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityEventId))
            {
                query["SecurityEventId"] = request.SecurityEventId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSimilarEventScenarios",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSimilarEventScenariosResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the handling scenarios for alerts triggered by the same rule or type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSimilarEventScenariosRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSimilarEventScenariosResponse
        /// </returns>
        public DescribeSimilarEventScenariosResponse DescribeSimilarEventScenarios(DescribeSimilarEventScenariosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSimilarEventScenariosWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the handling scenarios for alerts triggered by the same rule or type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSimilarEventScenariosRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSimilarEventScenariosResponse
        /// </returns>
        public async Task<DescribeSimilarEventScenariosResponse> DescribeSimilarEventScenariosAsync(DescribeSimilarEventScenariosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSimilarEventScenariosWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries aggregated alerts triggered by the same rule or type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSimilarSecurityEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSimilarSecurityEventsResponse
        /// </returns>
        public DescribeSimilarSecurityEventsResponse DescribeSimilarSecurityEventsWithOptions(DescribeSimilarSecurityEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "DescribeSimilarSecurityEvents",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSimilarSecurityEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries aggregated alerts triggered by the same rule or type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSimilarSecurityEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSimilarSecurityEventsResponse
        /// </returns>
        public async Task<DescribeSimilarSecurityEventsResponse> DescribeSimilarSecurityEventsWithOptionsAsync(DescribeSimilarSecurityEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "DescribeSimilarSecurityEvents",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSimilarSecurityEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries aggregated alerts triggered by the same rule or type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSimilarSecurityEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSimilarSecurityEventsResponse
        /// </returns>
        public DescribeSimilarSecurityEventsResponse DescribeSimilarSecurityEvents(DescribeSimilarSecurityEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSimilarSecurityEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries aggregated alerts triggered by the same rule or type.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSimilarSecurityEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSimilarSecurityEventsResponse
        /// </returns>
        public async Task<DescribeSimilarSecurityEventsResponse> DescribeSimilarSecurityEventsAsync(DescribeSimilarSecurityEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSimilarSecurityEventsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries endpoint security alerts and supports filtering by alert, endpoint, and processing status.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSuspEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSuspEventsResponse
        /// </returns>
        public DescribeSuspEventsResponse DescribeSuspEventsWithOptions(DescribeSuspEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmEventName))
            {
                query["AlarmEventName"] = request.AlarmEventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmUniqueInfo))
            {
                query["AlarmUniqueInfo"] = request.AlarmUniqueInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsTypeList))
            {
                query["AssetsTypeList"] = request.AssetsTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerFieldName))
            {
                query["ContainerFieldName"] = request.ContainerFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerFieldValue))
            {
                query["ContainerFieldValue"] = request.ContainerFieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dealed))
            {
                query["Dealed"] = request.Dealed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Department))
            {
                query["Department"] = request.Department;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventNames))
            {
                query["EventNames"] = request.EventNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                query["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InnerIp))
            {
                query["InnerIp"] = request.InnerIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Levels))
            {
                query["Levels"] = request.Levels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateErrorCodeList))
            {
                query["OperateErrorCodeList"] = request.OperateErrorCodeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateTimeEnd))
            {
                query["OperateTimeEnd"] = request.OperateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateTimeStart))
            {
                query["OperateTimeStart"] = request.OperateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentEventTypes))
            {
                query["ParentEventTypes"] = request.ParentEventTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortColumn))
            {
                query["SortColumn"] = request.SortColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcIp))
            {
                query["SrcIp"] = request.SrcIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrictMode))
            {
                query["StrictMode"] = request.StrictMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeEnd))
            {
                query["TimeEnd"] = request.TimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStart))
            {
                query["TimeStart"] = request.TimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueInfo))
            {
                query["UniqueInfo"] = request.UniqueInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                query["Uuids"] = request.Uuids;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TacticId))
            {
                body["TacticId"] = request.TacticId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSuspEvents",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSuspEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries endpoint security alerts and supports filtering by alert, endpoint, and processing status.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSuspEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSuspEventsResponse
        /// </returns>
        public async Task<DescribeSuspEventsResponse> DescribeSuspEventsWithOptionsAsync(DescribeSuspEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmEventName))
            {
                query["AlarmEventName"] = request.AlarmEventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmUniqueInfo))
            {
                query["AlarmUniqueInfo"] = request.AlarmUniqueInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsTypeList))
            {
                query["AssetsTypeList"] = request.AssetsTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerFieldName))
            {
                query["ContainerFieldName"] = request.ContainerFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerFieldValue))
            {
                query["ContainerFieldValue"] = request.ContainerFieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dealed))
            {
                query["Dealed"] = request.Dealed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Department))
            {
                query["Department"] = request.Department;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventNames))
            {
                query["EventNames"] = request.EventNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                query["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InnerIp))
            {
                query["InnerIp"] = request.InnerIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Levels))
            {
                query["Levels"] = request.Levels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateErrorCodeList))
            {
                query["OperateErrorCodeList"] = request.OperateErrorCodeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateTimeEnd))
            {
                query["OperateTimeEnd"] = request.OperateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateTimeStart))
            {
                query["OperateTimeStart"] = request.OperateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentEventTypes))
            {
                query["ParentEventTypes"] = request.ParentEventTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortColumn))
            {
                query["SortColumn"] = request.SortColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcIp))
            {
                query["SrcIp"] = request.SrcIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrictMode))
            {
                query["StrictMode"] = request.StrictMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeEnd))
            {
                query["TimeEnd"] = request.TimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStart))
            {
                query["TimeStart"] = request.TimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueInfo))
            {
                query["UniqueInfo"] = request.UniqueInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                query["Uuids"] = request.Uuids;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TacticId))
            {
                body["TacticId"] = request.TacticId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSuspEvents",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSuspEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries endpoint security alerts and supports filtering by alert, endpoint, and processing status.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSuspEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSuspEventsResponse
        /// </returns>
        public DescribeSuspEventsResponse DescribeSuspEvents(DescribeSuspEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSuspEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries endpoint security alerts and supports filtering by alert, endpoint, and processing status.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSuspEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSuspEventsResponse
        /// </returns>
        public async Task<DescribeSuspEventsResponse> DescribeSuspEventsAsync(DescribeSuspEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSuspEventsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a client rule policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the detailed information of a client rule policy based on the policy ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetClientRuleStrategyDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetClientRuleStrategyDetailResponse
        /// </returns>
        public GetClientRuleStrategyDetailResponse GetClientRuleStrategyDetailWithOptions(GetClientRuleStrategyDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClientRuleStrategyDetail",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClientRuleStrategyDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a client rule policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the detailed information of a client rule policy based on the policy ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetClientRuleStrategyDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetClientRuleStrategyDetailResponse
        /// </returns>
        public async Task<GetClientRuleStrategyDetailResponse> GetClientRuleStrategyDetailWithOptionsAsync(GetClientRuleStrategyDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClientRuleStrategyDetail",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClientRuleStrategyDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a client rule policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the detailed information of a client rule policy based on the policy ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetClientRuleStrategyDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetClientRuleStrategyDetailResponse
        /// </returns>
        public GetClientRuleStrategyDetailResponse GetClientRuleStrategyDetail(GetClientRuleStrategyDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetClientRuleStrategyDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a client rule policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the detailed information of a client rule policy based on the policy ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetClientRuleStrategyDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetClientRuleStrategyDetailResponse
        /// </returns>
        public async Task<GetClientRuleStrategyDetailResponse> GetClientRuleStrategyDetailAsync(GetClientRuleStrategyDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetClientRuleStrategyDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of system rules and custom rules in proactive defense policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Counts the number of proactive defense policies (PolicyType=2) for the current account and returns the number of system rule policies and custom rule policies.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetClientRuleStrategyStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetClientRuleStrategyStatisticsResponse
        /// </returns>
        public GetClientRuleStrategyStatisticsResponse GetClientRuleStrategyStatisticsWithOptions(GetClientRuleStrategyStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClientRuleStrategyStatistics",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClientRuleStrategyStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of system rules and custom rules in proactive defense policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Counts the number of proactive defense policies (PolicyType=2) for the current account and returns the number of system rule policies and custom rule policies.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetClientRuleStrategyStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetClientRuleStrategyStatisticsResponse
        /// </returns>
        public async Task<GetClientRuleStrategyStatisticsResponse> GetClientRuleStrategyStatisticsWithOptionsAsync(GetClientRuleStrategyStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClientRuleStrategyStatistics",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClientRuleStrategyStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of system rules and custom rules in proactive defense policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Counts the number of proactive defense policies (PolicyType=2) for the current account and returns the number of system rule policies and custom rule policies.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetClientRuleStrategyStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetClientRuleStrategyStatisticsResponse
        /// </returns>
        public GetClientRuleStrategyStatisticsResponse GetClientRuleStrategyStatistics(GetClientRuleStrategyStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetClientRuleStrategyStatisticsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of system rules and custom rules in proactive defense policies.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Counts the number of proactive defense policies (PolicyType=2) for the current account and returns the number of system rule policies and custom rule policies.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetClientRuleStrategyStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetClientRuleStrategyStatisticsResponse
        /// </returns>
        public async Task<GetClientRuleStrategyStatisticsResponse> GetClientRuleStrategyStatisticsAsync(GetClientRuleStrategyStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetClientRuleStrategyStatisticsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Handles security alert events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HandleSecurityEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HandleSecurityEventsResponse
        /// </returns>
        public HandleSecurityEventsResponse HandleSecurityEventsWithOptions(HandleSecurityEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarkBatch))
            {
                query["MarkBatch"] = request.MarkBatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarkMissParam))
            {
                query["MarkMissParam"] = request.MarkMissParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationCode))
            {
                query["OperationCode"] = request.OperationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationParams))
            {
                query["OperationParams"] = request.OperationParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityEventIds))
            {
                query["SecurityEventIds"] = request.SecurityEventIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HandleSecurityEvents",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HandleSecurityEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Handles security alert events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HandleSecurityEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HandleSecurityEventsResponse
        /// </returns>
        public async Task<HandleSecurityEventsResponse> HandleSecurityEventsWithOptionsAsync(HandleSecurityEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarkBatch))
            {
                query["MarkBatch"] = request.MarkBatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarkMissParam))
            {
                query["MarkMissParam"] = request.MarkMissParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationCode))
            {
                query["OperationCode"] = request.OperationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationParams))
            {
                query["OperationParams"] = request.OperationParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityEventIds))
            {
                query["SecurityEventIds"] = request.SecurityEventIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HandleSecurityEvents",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HandleSecurityEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Handles security alert events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HandleSecurityEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// HandleSecurityEventsResponse
        /// </returns>
        public HandleSecurityEventsResponse HandleSecurityEvents(HandleSecurityEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HandleSecurityEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Handles security alert events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HandleSecurityEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// HandleSecurityEventsResponse
        /// </returns>
        public async Task<HandleSecurityEventsResponse> HandleSecurityEventsAsync(HandleSecurityEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HandleSecurityEventsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs batch operations on similar security alerts filtered by a query task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>First, call the CreateSimilarSecurityEventsQueryTask operation to create a similar alert query task. Wait until the data extraction for the task is complete and the task reaches the DataRetrieved state before you call this operation. The processing scope covers the security alerts filtered under the TaskId. This scope is determined by the similar scenario and alert configurations selected when the query task was created. The scope does not equal all alerts of the same type, nor is it fixed to alerts with the same IP address. After this operation is successfully called, the processing continues to run asynchronously in the background.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// HandleSimilarSecurityEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HandleSimilarSecurityEventsResponse
        /// </returns>
        public HandleSimilarSecurityEventsResponse HandleSimilarSecurityEventsWithOptions(HandleSimilarSecurityEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarkMissParam))
            {
                query["MarkMissParam"] = request.MarkMissParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationCode))
            {
                query["OperationCode"] = request.OperationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationParams))
            {
                query["OperationParams"] = request.OperationParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
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
                Action = "HandleSimilarSecurityEvents",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HandleSimilarSecurityEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs batch operations on similar security alerts filtered by a query task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>First, call the CreateSimilarSecurityEventsQueryTask operation to create a similar alert query task. Wait until the data extraction for the task is complete and the task reaches the DataRetrieved state before you call this operation. The processing scope covers the security alerts filtered under the TaskId. This scope is determined by the similar scenario and alert configurations selected when the query task was created. The scope does not equal all alerts of the same type, nor is it fixed to alerts with the same IP address. After this operation is successfully called, the processing continues to run asynchronously in the background.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// HandleSimilarSecurityEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HandleSimilarSecurityEventsResponse
        /// </returns>
        public async Task<HandleSimilarSecurityEventsResponse> HandleSimilarSecurityEventsWithOptionsAsync(HandleSimilarSecurityEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarkMissParam))
            {
                query["MarkMissParam"] = request.MarkMissParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationCode))
            {
                query["OperationCode"] = request.OperationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationParams))
            {
                query["OperationParams"] = request.OperationParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
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
                Action = "HandleSimilarSecurityEvents",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HandleSimilarSecurityEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs batch operations on similar security alerts filtered by a query task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>First, call the CreateSimilarSecurityEventsQueryTask operation to create a similar alert query task. Wait until the data extraction for the task is complete and the task reaches the DataRetrieved state before you call this operation. The processing scope covers the security alerts filtered under the TaskId. This scope is determined by the similar scenario and alert configurations selected when the query task was created. The scope does not equal all alerts of the same type, nor is it fixed to alerts with the same IP address. After this operation is successfully called, the processing continues to run asynchronously in the background.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// HandleSimilarSecurityEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// HandleSimilarSecurityEventsResponse
        /// </returns>
        public HandleSimilarSecurityEventsResponse HandleSimilarSecurityEvents(HandleSimilarSecurityEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HandleSimilarSecurityEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs batch operations on similar security alerts filtered by a query task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>First, call the CreateSimilarSecurityEventsQueryTask operation to create a similar alert query task. Wait until the data extraction for the task is complete and the task reaches the DataRetrieved state before you call this operation. The processing scope covers the security alerts filtered under the TaskId. This scope is determined by the similar scenario and alert configurations selected when the query task was created. The scope does not equal all alerts of the same type, nor is it fixed to alerts with the same IP address. After this operation is successfully called, the processing continues to run asynchronously in the background.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// HandleSimilarSecurityEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// HandleSimilarSecurityEventsResponse
        /// </returns>
        public async Task<HandleSimilarSecurityEventsResponse> HandleSimilarSecurityEventsAsync(HandleSimilarSecurityEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HandleSimilarSecurityEventsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the client rule policy list by using a paged query with paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query to retrieve client rule policies based on the policy type (PolicyType) with paging. You can call GetClientRuleStrategyDetail to query the details.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListClientRuleStrategyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClientRuleStrategyResponse
        /// </returns>
        public ListClientRuleStrategyResponse ListClientRuleStrategyWithOptions(ListClientRuleStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClientRuleStrategy",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClientRuleStrategyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the client rule policy list by using a paged query with paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query to retrieve client rule policies based on the policy type (PolicyType) with paging. You can call GetClientRuleStrategyDetail to query the details.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListClientRuleStrategyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClientRuleStrategyResponse
        /// </returns>
        public async Task<ListClientRuleStrategyResponse> ListClientRuleStrategyWithOptionsAsync(ListClientRuleStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClientRuleStrategy",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClientRuleStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the client rule policy list by using a paged query with paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query to retrieve client rule policies based on the policy type (PolicyType) with paging. You can call GetClientRuleStrategyDetail to query the details.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListClientRuleStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// ListClientRuleStrategyResponse
        /// </returns>
        public ListClientRuleStrategyResponse ListClientRuleStrategy(ListClientRuleStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClientRuleStrategyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the client rule policy list by using a paged query with paging.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query to retrieve client rule policies based on the policy type (PolicyType) with paging. You can call GetClientRuleStrategyDetail to query the details.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListClientRuleStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// ListClientRuleStrategyResponse
        /// </returns>
        public async Task<ListClientRuleStrategyResponse> ListClientRuleStrategyAsync(ListClientRuleStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClientRuleStrategyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries system defense rules and the switch status of rules under a specified SelectionKey by paging in a paged query.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the system rule catalog and the switch status of rules under a specified SelectionKey. You can use the returned SwitchId and the same SelectionKey to call the OperateTargetConfig operation to modify the switch status.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListSystemConfigRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSystemConfigRulesResponse
        /// </returns>
        public ListSystemConfigRulesResponse ListSystemConfigRulesWithOptions(ListSystemConfigRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListSystemConfigRulesShrinkRequest request = new ListSystemConfigRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AggregationIds))
            {
                request.AggregationIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AggregationIds, "AggregationIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RuleTypes))
            {
                request.RuleTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RuleTypes, "RuleTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregationIdsShrink))
            {
                query["AggregationIds"] = request.AggregationIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleTypesShrink))
            {
                query["RuleTypes"] = request.RuleTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectionKey))
            {
                query["SelectionKey"] = request.SelectionKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemType))
            {
                query["SystemType"] = request.SystemType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSystemConfigRules",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSystemConfigRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries system defense rules and the switch status of rules under a specified SelectionKey by paging in a paged query.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the system rule catalog and the switch status of rules under a specified SelectionKey. You can use the returned SwitchId and the same SelectionKey to call the OperateTargetConfig operation to modify the switch status.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListSystemConfigRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSystemConfigRulesResponse
        /// </returns>
        public async Task<ListSystemConfigRulesResponse> ListSystemConfigRulesWithOptionsAsync(ListSystemConfigRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListSystemConfigRulesShrinkRequest request = new ListSystemConfigRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AggregationIds))
            {
                request.AggregationIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AggregationIds, "AggregationIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RuleTypes))
            {
                request.RuleTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RuleTypes, "RuleTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregationIdsShrink))
            {
                query["AggregationIds"] = request.AggregationIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleTypesShrink))
            {
                query["RuleTypes"] = request.RuleTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectionKey))
            {
                query["SelectionKey"] = request.SelectionKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemType))
            {
                query["SystemType"] = request.SystemType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSystemConfigRules",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSystemConfigRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries system defense rules and the switch status of rules under a specified SelectionKey by paging in a paged query.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the system rule catalog and the switch status of rules under a specified SelectionKey. You can use the returned SwitchId and the same SelectionKey to call the OperateTargetConfig operation to modify the switch status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSystemConfigRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSystemConfigRulesResponse
        /// </returns>
        public ListSystemConfigRulesResponse ListSystemConfigRules(ListSystemConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSystemConfigRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries system defense rules and the switch status of rules under a specified SelectionKey by paging in a paged query.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the system rule catalog and the switch status of rules under a specified SelectionKey. You can use the returned SwitchId and the same SelectionKey to call the OperateTargetConfig operation to modify the switch status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSystemConfigRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSystemConfigRulesResponse
        /// </returns>
        public async Task<ListSystemConfigRulesResponse> ListSystemConfigRulesAsync(ListSystemConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSystemConfigRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the switch status of system rules in batches by SelectionKey.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the override configuration of rule switches for each SwitchId under the same SelectionKey. Obtain the rule SwitchId by calling ListSystemConfigRules first. Do not use this operation to replace UpdateClientRuleStrategy for updating the overall policy switch Status, and do not use software process names as system rule SwitchIds.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// OperateTargetConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateTargetConfigResponse
        /// </returns>
        public OperateTargetConfigResponse OperateTargetConfigWithOptions(OperateTargetConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            OperateTargetConfigShrinkRequest request = new OperateTargetConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SwitchIdList))
            {
                request.SwitchIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SwitchIdList, "SwitchIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectionKey))
            {
                query["SelectionKey"] = request.SelectionKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchIdListShrink))
            {
                query["SwitchIdList"] = request.SwitchIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateTargetConfig",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateTargetConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the switch status of system rules in batches by SelectionKey.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the override configuration of rule switches for each SwitchId under the same SelectionKey. Obtain the rule SwitchId by calling ListSystemConfigRules first. Do not use this operation to replace UpdateClientRuleStrategy for updating the overall policy switch Status, and do not use software process names as system rule SwitchIds.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// OperateTargetConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateTargetConfigResponse
        /// </returns>
        public async Task<OperateTargetConfigResponse> OperateTargetConfigWithOptionsAsync(OperateTargetConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            OperateTargetConfigShrinkRequest request = new OperateTargetConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SwitchIdList))
            {
                request.SwitchIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SwitchIdList, "SwitchIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectionKey))
            {
                query["SelectionKey"] = request.SelectionKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchIdListShrink))
            {
                query["SwitchIdList"] = request.SwitchIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateTargetConfig",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateTargetConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the switch status of system rules in batches by SelectionKey.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the override configuration of rule switches for each SwitchId under the same SelectionKey. Obtain the rule SwitchId by calling ListSystemConfigRules first. Do not use this operation to replace UpdateClientRuleStrategy for updating the overall policy switch Status, and do not use software process names as system rule SwitchIds.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// OperateTargetConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateTargetConfigResponse
        /// </returns>
        public OperateTargetConfigResponse OperateTargetConfig(OperateTargetConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateTargetConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the switch status of system rules in batches by SelectionKey.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the override configuration of rule switches for each SwitchId under the same SelectionKey. Obtain the rule SwitchId by calling ListSystemConfigRules first. Do not use this operation to replace UpdateClientRuleStrategy for updating the overall policy switch Status, and do not use software process names as system rule SwitchIds.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// OperateTargetConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateTargetConfigResponse
        /// </returns>
        public async Task<OperateTargetConfigResponse> OperateTargetConfigAsync(OperateTargetConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateTargetConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the effective scope mode and target list of a specified asset scope record.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAssetScopeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAssetScopeResponse
        /// </returns>
        public UpdateAssetScopeResponse UpdateAssetScopeWithOptions(UpdateAssetScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchMode))
            {
                query["MatchMode"] = request.MatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchTargetIds))
            {
                query["MatchTargetIds"] = request.MatchTargetIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAssetScope",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAssetScopeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the effective scope mode and target list of a specified asset scope record.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAssetScopeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAssetScopeResponse
        /// </returns>
        public async Task<UpdateAssetScopeResponse> UpdateAssetScopeWithOptionsAsync(UpdateAssetScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchMode))
            {
                query["MatchMode"] = request.MatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchTargetIds))
            {
                query["MatchTargetIds"] = request.MatchTargetIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAssetScope",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAssetScopeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the effective scope mode and target list of a specified asset scope record.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAssetScopeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAssetScopeResponse
        /// </returns>
        public UpdateAssetScopeResponse UpdateAssetScope(UpdateAssetScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAssetScopeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the effective scope mode and target list of a specified asset scope record.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAssetScopeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAssetScopeResponse
        /// </returns>
        public async Task<UpdateAssetScopeResponse> UpdateAssetScopeAsync(UpdateAssetScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAssetScopeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a client rule policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates a client rule policy based on the policy ID.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateClientRuleStrategyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateClientRuleStrategyResponse
        /// </returns>
        public UpdateClientRuleStrategyResponse UpdateClientRuleStrategyWithOptions(UpdateClientRuleStrategyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateClientRuleStrategyShrinkRequest request = new UpdateClientRuleStrategyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExcludeUserNameList))
            {
                request.ExcludeUserNameListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExcludeUserNameList, "ExcludeUserNameList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IncludeGroupIdList))
            {
                request.IncludeGroupIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IncludeGroupIdList, "IncludeGroupIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PortOnList))
            {
                request.PortOnListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PortOnList, "PortOnList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SoftWareOnList))
            {
                request.SoftWareOnListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SoftWareOnList, "SoftWareOnList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                query["ActionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllGroup))
            {
                query["AllGroup"] = request.AllGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovalId))
            {
                query["ApprovalId"] = request.ApprovalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cmdline))
            {
                query["Cmdline"] = request.Cmdline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeUserNameListShrink))
            {
                query["ExcludeUserNameList"] = request.ExcludeUserNameListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InSwitch))
            {
                query["InSwitch"] = request.InSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeGroupIdListShrink))
            {
                query["IncludeGroupIdList"] = request.IncludeGroupIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainButtonTextCh))
            {
                query["MainButtonTextCh"] = request.MainButtonTextCh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainButtonTextEn))
            {
                query["MainButtonTextEn"] = request.MainButtonTextEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchMode))
            {
                query["MatchMode"] = request.MatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchTargetIds))
            {
                query["MatchTargetIds"] = request.MatchTargetIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Md5List))
            {
                query["Md5List"] = request.Md5List;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinorButtonTextCh))
            {
                query["MinorButtonTextCh"] = request.MinorButtonTextCh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinorButtonTextEn))
            {
                query["MinorButtonTextEn"] = request.MinorButtonTextEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewFilePath))
            {
                query["NewFilePath"] = request.NewFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSwitch))
            {
                query["OutSwitch"] = request.OutSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCmdline))
            {
                query["ParentCmdline"] = request.ParentCmdline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentProcPath))
            {
                query["ParentProcPath"] = request.ParentProcPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortOnListShrink))
            {
                query["PortOnList"] = request.PortOnListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcPath))
            {
                query["ProcPath"] = request.ProcPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryContent))
            {
                query["RegistryContent"] = request.RegistryContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryKey))
            {
                query["RegistryKey"] = request.RegistryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SoftWareOnListShrink))
            {
                query["SoftWareOnList"] = request.SoftWareOnListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategySourceType))
            {
                query["StrategySourceType"] = request.StrategySourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportsApproval))
            {
                query["SupportsApproval"] = request.SupportsApproval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsContent))
            {
                query["UsContent"] = request.UsContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsTitle))
            {
                query["UsTitle"] = request.UsTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhContent))
            {
                query["ZhContent"] = request.ZhContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhTitle))
            {
                query["ZhTitle"] = request.ZhTitle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateClientRuleStrategy",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateClientRuleStrategyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a client rule policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates a client rule policy based on the policy ID.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateClientRuleStrategyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateClientRuleStrategyResponse
        /// </returns>
        public async Task<UpdateClientRuleStrategyResponse> UpdateClientRuleStrategyWithOptionsAsync(UpdateClientRuleStrategyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateClientRuleStrategyShrinkRequest request = new UpdateClientRuleStrategyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExcludeUserNameList))
            {
                request.ExcludeUserNameListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExcludeUserNameList, "ExcludeUserNameList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IncludeGroupIdList))
            {
                request.IncludeGroupIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IncludeGroupIdList, "IncludeGroupIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PortOnList))
            {
                request.PortOnListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PortOnList, "PortOnList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SoftWareOnList))
            {
                request.SoftWareOnListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SoftWareOnList, "SoftWareOnList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                query["ActionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllGroup))
            {
                query["AllGroup"] = request.AllGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovalId))
            {
                query["ApprovalId"] = request.ApprovalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cmdline))
            {
                query["Cmdline"] = request.Cmdline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeUserNameListShrink))
            {
                query["ExcludeUserNameList"] = request.ExcludeUserNameListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InSwitch))
            {
                query["InSwitch"] = request.InSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeGroupIdListShrink))
            {
                query["IncludeGroupIdList"] = request.IncludeGroupIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainButtonTextCh))
            {
                query["MainButtonTextCh"] = request.MainButtonTextCh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainButtonTextEn))
            {
                query["MainButtonTextEn"] = request.MainButtonTextEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchMode))
            {
                query["MatchMode"] = request.MatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchTargetIds))
            {
                query["MatchTargetIds"] = request.MatchTargetIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Md5List))
            {
                query["Md5List"] = request.Md5List;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinorButtonTextCh))
            {
                query["MinorButtonTextCh"] = request.MinorButtonTextCh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinorButtonTextEn))
            {
                query["MinorButtonTextEn"] = request.MinorButtonTextEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewFilePath))
            {
                query["NewFilePath"] = request.NewFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSwitch))
            {
                query["OutSwitch"] = request.OutSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCmdline))
            {
                query["ParentCmdline"] = request.ParentCmdline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentProcPath))
            {
                query["ParentProcPath"] = request.ParentProcPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortOnListShrink))
            {
                query["PortOnList"] = request.PortOnListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcPath))
            {
                query["ProcPath"] = request.ProcPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryContent))
            {
                query["RegistryContent"] = request.RegistryContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryKey))
            {
                query["RegistryKey"] = request.RegistryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SoftWareOnListShrink))
            {
                query["SoftWareOnList"] = request.SoftWareOnListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategySourceType))
            {
                query["StrategySourceType"] = request.StrategySourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportsApproval))
            {
                query["SupportsApproval"] = request.SupportsApproval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsContent))
            {
                query["UsContent"] = request.UsContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsTitle))
            {
                query["UsTitle"] = request.UsTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhContent))
            {
                query["ZhContent"] = request.ZhContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhTitle))
            {
                query["ZhTitle"] = request.ZhTitle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateClientRuleStrategy",
                Version = "2024-11-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateClientRuleStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a client rule policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates a client rule policy based on the policy ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateClientRuleStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateClientRuleStrategyResponse
        /// </returns>
        public UpdateClientRuleStrategyResponse UpdateClientRuleStrategy(UpdateClientRuleStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateClientRuleStrategyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a client rule policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates a client rule policy based on the policy ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateClientRuleStrategyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateClientRuleStrategyResponse
        /// </returns>
        public async Task<UpdateClientRuleStrategyResponse> UpdateClientRuleStrategyAsync(UpdateClientRuleStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateClientRuleStrategyWithOptionsAsync(request, runtime);
        }

    }
}
