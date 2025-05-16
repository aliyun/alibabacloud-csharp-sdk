// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AIWorkSpace20210204.Models;

namespace AlibabaCloud.SDK.AIWorkSpace20210204
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("aiworkspace", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Receives and processes system event messages sent by DataWorks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation can be called only by the internal system and cannot be called by external users.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AcceptDataworksEventRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AcceptDataworksEventResponse
        /// </returns>
        public AcceptDataworksEventResponse AcceptDataworksEventWithOptions(AcceptDataworksEventRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                body["MessageId"] = request.MessageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AcceptDataworksEvent",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/action/acceptdataworksevent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcceptDataworksEventResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Receives and processes system event messages sent by DataWorks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation can be called only by the internal system and cannot be called by external users.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AcceptDataworksEventRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AcceptDataworksEventResponse
        /// </returns>
        public async Task<AcceptDataworksEventResponse> AcceptDataworksEventWithOptionsAsync(AcceptDataworksEventRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                body["MessageId"] = request.MessageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AcceptDataworksEvent",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/action/acceptdataworksevent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcceptDataworksEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Receives and processes system event messages sent by DataWorks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation can be called only by the internal system and cannot be called by external users.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AcceptDataworksEventRequest
        /// </param>
        /// 
        /// <returns>
        /// AcceptDataworksEventResponse
        /// </returns>
        public AcceptDataworksEventResponse AcceptDataworksEvent(AcceptDataworksEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AcceptDataworksEventWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Receives and processes system event messages sent by DataWorks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation can be called only by the internal system and cannot be called by external users.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AcceptDataworksEventRequest
        /// </param>
        /// 
        /// <returns>
        /// AcceptDataworksEventResponse
        /// </returns>
        public async Task<AcceptDataworksEventResponse> AcceptDataworksEventAsync(AcceptDataworksEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AcceptDataworksEventWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a custom image to a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddImageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddImageResponse
        /// </returns>
        public AddImageResponse AddImageWithOptions(AddImageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                body["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddImage",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/images",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a custom image to a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddImageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddImageResponse
        /// </returns>
        public async Task<AddImageResponse> AddImageWithOptionsAsync(AddImageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                body["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddImage",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/images",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a custom image to a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddImageRequest
        /// </param>
        /// 
        /// <returns>
        /// AddImageResponse
        /// </returns>
        public AddImageResponse AddImage(AddImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddImageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a custom image to a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddImageRequest
        /// </param>
        /// 
        /// <returns>
        /// AddImageResponse
        /// </returns>
        public async Task<AddImageResponse> AddImageAsync(AddImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddImageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to an image.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddImageLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddImageLabelsResponse
        /// </returns>
        public AddImageLabelsResponse AddImageLabelsWithOptions(string ImageId, AddImageLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddImageLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/images/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ImageId) + "/labels",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddImageLabelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to an image.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddImageLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddImageLabelsResponse
        /// </returns>
        public async Task<AddImageLabelsResponse> AddImageLabelsWithOptionsAsync(string ImageId, AddImageLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddImageLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/images/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ImageId) + "/labels",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddImageLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to an image.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddImageLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// AddImageLabelsResponse
        /// </returns>
        public AddImageLabelsResponse AddImageLabels(string ImageId, AddImageLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddImageLabelsWithOptions(ImageId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to an image.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddImageLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// AddImageLabelsResponse
        /// </returns>
        public async Task<AddImageLabelsResponse> AddImageLabelsAsync(string ImageId, AddImageLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddImageLabelsWithOptionsAsync(ImageId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a role to a member in a workspace. After you add a role to a member, the member is granted the permissions of the role.</para>
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
        /// AddMemberRoleResponse
        /// </returns>
        public AddMemberRoleResponse AddMemberRoleWithOptions(string WorkspaceId, string MemberId, string RoleName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMemberRole",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MemberId) + "/roles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RoleName),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMemberRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a role to a member in a workspace. After you add a role to a member, the member is granted the permissions of the role.</para>
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
        /// AddMemberRoleResponse
        /// </returns>
        public async Task<AddMemberRoleResponse> AddMemberRoleWithOptionsAsync(string WorkspaceId, string MemberId, string RoleName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMemberRole",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MemberId) + "/roles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RoleName),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMemberRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a role to a member in a workspace. After you add a role to a member, the member is granted the permissions of the role.</para>
        /// </summary>
        /// 
        /// <returns>
        /// AddMemberRoleResponse
        /// </returns>
        public AddMemberRoleResponse AddMemberRole(string WorkspaceId, string MemberId, string RoleName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddMemberRoleWithOptions(WorkspaceId, MemberId, RoleName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a role to a member in a workspace. After you add a role to a member, the member is granted the permissions of the role.</para>
        /// </summary>
        /// 
        /// <returns>
        /// AddMemberRoleResponse
        /// </returns>
        public async Task<AddMemberRoleResponse> AddMemberRoleAsync(string WorkspaceId, string MemberId, string RoleName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddMemberRoleWithOptionsAsync(WorkspaceId, MemberId, RoleName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the resource group to which a resource belongs based on the ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroupWithOptions(ChangeResourceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                body["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/resourcegroups/action/changeresourcegroup",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the resource group to which a resource belongs based on the ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupWithOptionsAsync(ChangeResourceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                body["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/resourcegroups/action/changeresourcegroup",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the resource group to which a resource belongs based on the ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroup(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ChangeResourceGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the resource group to which a resource belongs based on the ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ChangeResourceGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a code build in Platform for AI (PAI). You can configure Git branches and commit IDs. After the code build is created, you can reference the code build in a Deep Learning Containers (DLC) job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCodeSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCodeSourceResponse
        /// </returns>
        public CreateCodeSourceResponse CreateCodeSourceWithOptions(CreateCodeSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeBranch))
            {
                body["CodeBranch"] = request.CodeBranch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeCommit))
            {
                body["CodeCommit"] = request.CodeCommit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepo))
            {
                body["CodeRepo"] = request.CodeRepo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepoAccessToken))
            {
                body["CodeRepoAccessToken"] = request.CodeRepoAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepoUserName))
            {
                body["CodeRepoUserName"] = request.CodeRepoUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountPath))
            {
                body["MountPath"] = request.MountPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCodeSource",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/codesources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCodeSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a code build in Platform for AI (PAI). You can configure Git branches and commit IDs. After the code build is created, you can reference the code build in a Deep Learning Containers (DLC) job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCodeSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCodeSourceResponse
        /// </returns>
        public async Task<CreateCodeSourceResponse> CreateCodeSourceWithOptionsAsync(CreateCodeSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeBranch))
            {
                body["CodeBranch"] = request.CodeBranch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeCommit))
            {
                body["CodeCommit"] = request.CodeCommit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepo))
            {
                body["CodeRepo"] = request.CodeRepo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepoAccessToken))
            {
                body["CodeRepoAccessToken"] = request.CodeRepoAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepoUserName))
            {
                body["CodeRepoUserName"] = request.CodeRepoUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountPath))
            {
                body["MountPath"] = request.MountPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCodeSource",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/codesources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCodeSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a code build in Platform for AI (PAI). You can configure Git branches and commit IDs. After the code build is created, you can reference the code build in a Deep Learning Containers (DLC) job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCodeSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCodeSourceResponse
        /// </returns>
        public CreateCodeSourceResponse CreateCodeSource(CreateCodeSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCodeSourceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a code build in Platform for AI (PAI). You can configure Git branches and commit IDs. After the code build is created, you can reference the code build in a Deep Learning Containers (DLC) job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCodeSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCodeSourceResponse
        /// </returns>
        public async Task<CreateCodeSourceResponse> CreateCodeSourceAsync(CreateCodeSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCodeSourceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConnectionResponse
        /// </returns>
        public CreateConnectionResponse CreateConnectionWithOptions(CreateConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configs))
            {
                body["Configs"] = request.Configs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                body["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionType))
            {
                body["ConnectionType"] = request.ConnectionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Models))
            {
                body["Models"] = request.Models;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceMeta))
            {
                body["ResourceMeta"] = request.ResourceMeta;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Secrets))
            {
                body["Secrets"] = request.Secrets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConnection",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/connections",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConnectionResponse
        /// </returns>
        public async Task<CreateConnectionResponse> CreateConnectionWithOptionsAsync(CreateConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configs))
            {
                body["Configs"] = request.Configs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                body["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionType))
            {
                body["ConnectionType"] = request.ConnectionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Models))
            {
                body["Models"] = request.Models;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceMeta))
            {
                body["ResourceMeta"] = request.ResourceMeta;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Secrets))
            {
                body["Secrets"] = request.Secrets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConnection",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/connections",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConnectionResponse
        /// </returns>
        public CreateConnectionResponse CreateConnection(CreateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateConnectionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConnectionResponse
        /// </returns>
        public async Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateConnectionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetResponse
        /// </returns>
        public CreateDatasetResponse CreateDatasetWithOptions(CreateDatasetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCount))
            {
                body["DataCount"] = request.DataCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSize))
            {
                body["DataSize"] = request.DataSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                body["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportInfo))
            {
                body["ImportInfo"] = request.ImportInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountAccessReadWriteRoleIdList))
            {
                body["MountAccessReadWriteRoleIdList"] = request.MountAccessReadWriteRoleIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Property))
            {
                body["Property"] = request.Property;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                body["Provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderType))
            {
                body["ProviderType"] = request.ProviderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDatasetId))
            {
                body["SourceDatasetId"] = request.SourceDatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDatasetVersion))
            {
                body["SourceDatasetVersion"] = request.SourceDatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionDescription))
            {
                body["VersionDescription"] = request.VersionDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionLabels))
            {
                body["VersionLabels"] = request.VersionLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataset",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetResponse
        /// </returns>
        public async Task<CreateDatasetResponse> CreateDatasetWithOptionsAsync(CreateDatasetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCount))
            {
                body["DataCount"] = request.DataCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSize))
            {
                body["DataSize"] = request.DataSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                body["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportInfo))
            {
                body["ImportInfo"] = request.ImportInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountAccessReadWriteRoleIdList))
            {
                body["MountAccessReadWriteRoleIdList"] = request.MountAccessReadWriteRoleIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Property))
            {
                body["Property"] = request.Property;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                body["Provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProviderType))
            {
                body["ProviderType"] = request.ProviderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDatasetId))
            {
                body["SourceDatasetId"] = request.SourceDatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDatasetVersion))
            {
                body["SourceDatasetVersion"] = request.SourceDatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionDescription))
            {
                body["VersionDescription"] = request.VersionDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionLabels))
            {
                body["VersionLabels"] = request.VersionLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataset",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetResponse
        /// </returns>
        public CreateDatasetResponse CreateDataset(CreateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDatasetWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetResponse
        /// </returns>
        public async Task<CreateDatasetResponse> CreateDatasetAsync(CreateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDatasetWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates the metadata records of multiple files in a dataset at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetFileMetasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetFileMetasResponse
        /// </returns>
        public CreateDatasetFileMetasResponse CreateDatasetFileMetasWithOptions(string DatasetId, CreateDatasetFileMetasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetFileMetas))
            {
                body["DatasetFileMetas"] = request.DatasetFileMetas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetVersion))
            {
                body["DatasetVersion"] = request.DatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatasetFileMetas",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetfilemetas",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasetFileMetasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates the metadata records of multiple files in a dataset at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetFileMetasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetFileMetasResponse
        /// </returns>
        public async Task<CreateDatasetFileMetasResponse> CreateDatasetFileMetasWithOptionsAsync(string DatasetId, CreateDatasetFileMetasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetFileMetas))
            {
                body["DatasetFileMetas"] = request.DatasetFileMetas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetVersion))
            {
                body["DatasetVersion"] = request.DatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatasetFileMetas",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetfilemetas",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasetFileMetasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates the metadata records of multiple files in a dataset at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetFileMetasRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetFileMetasResponse
        /// </returns>
        public CreateDatasetFileMetasResponse CreateDatasetFileMetas(string DatasetId, CreateDatasetFileMetasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDatasetFileMetasWithOptions(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates the metadata records of multiple files in a dataset at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetFileMetasRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetFileMetasResponse
        /// </returns>
        public async Task<CreateDatasetFileMetasResponse> CreateDatasetFileMetasAsync(string DatasetId, CreateDatasetFileMetasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDatasetFileMetasWithOptionsAsync(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dataset job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetJobResponse
        /// </returns>
        public CreateDatasetJobResponse CreateDatasetJobWithOptions(string DatasetId, CreateDatasetJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetVersion))
            {
                body["DatasetVersion"] = request.DatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobAction))
            {
                body["JobAction"] = request.JobAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobMode))
            {
                body["JobMode"] = request.JobMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobSpec))
            {
                body["JobSpec"] = request.JobSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatasetJob",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetjobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasetJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dataset job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetJobResponse
        /// </returns>
        public async Task<CreateDatasetJobResponse> CreateDatasetJobWithOptionsAsync(string DatasetId, CreateDatasetJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetVersion))
            {
                body["DatasetVersion"] = request.DatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobAction))
            {
                body["JobAction"] = request.JobAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobMode))
            {
                body["JobMode"] = request.JobMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobSpec))
            {
                body["JobSpec"] = request.JobSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatasetJob",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetjobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasetJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dataset job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetJobResponse
        /// </returns>
        public CreateDatasetJobResponse CreateDatasetJob(string DatasetId, CreateDatasetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDatasetJobWithOptions(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dataset job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetJobResponse
        /// </returns>
        public async Task<CreateDatasetJobResponse> CreateDatasetJobAsync(string DatasetId, CreateDatasetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDatasetJobWithOptionsAsync(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a job configuration for a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetJobConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetJobConfigResponse
        /// </returns>
        public CreateDatasetJobConfigResponse CreateDatasetJobConfigWithOptions(string DatasetId, CreateDatasetJobConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigType))
            {
                body["ConfigType"] = request.ConfigType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatasetJobConfig",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetjobconfigs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasetJobConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a job configuration for a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetJobConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetJobConfigResponse
        /// </returns>
        public async Task<CreateDatasetJobConfigResponse> CreateDatasetJobConfigWithOptionsAsync(string DatasetId, CreateDatasetJobConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigType))
            {
                body["ConfigType"] = request.ConfigType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatasetJobConfig",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetjobconfigs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasetJobConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a job configuration for a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetJobConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetJobConfigResponse
        /// </returns>
        public CreateDatasetJobConfigResponse CreateDatasetJobConfig(string DatasetId, CreateDatasetJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDatasetJobConfigWithOptions(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a job configuration for a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetJobConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetJobConfigResponse
        /// </returns>
        public async Task<CreateDatasetJobConfigResponse> CreateDatasetJobConfigAsync(string DatasetId, CreateDatasetJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDatasetJobConfigWithOptionsAsync(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates tags for a dataset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The tag key and value are not empty strings and cannot exceed 128 characters in length.</description></item>
        /// <item><description>The tag key cannot start with any of the following strings: &quot;aliyun&quot;, &quot;acs&quot;, &quot;http://&quot;, and &quot;https://&quot;.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDatasetLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetLabelsResponse
        /// </returns>
        public CreateDatasetLabelsResponse CreateDatasetLabelsWithOptions(string DatasetId, CreateDatasetLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatasetLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/labels",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasetLabelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates tags for a dataset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The tag key and value are not empty strings and cannot exceed 128 characters in length.</description></item>
        /// <item><description>The tag key cannot start with any of the following strings: &quot;aliyun&quot;, &quot;acs&quot;, &quot;http://&quot;, and &quot;https://&quot;.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDatasetLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetLabelsResponse
        /// </returns>
        public async Task<CreateDatasetLabelsResponse> CreateDatasetLabelsWithOptionsAsync(string DatasetId, CreateDatasetLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatasetLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/labels",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasetLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates tags for a dataset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The tag key and value are not empty strings and cannot exceed 128 characters in length.</description></item>
        /// <item><description>The tag key cannot start with any of the following strings: &quot;aliyun&quot;, &quot;acs&quot;, &quot;http://&quot;, and &quot;https://&quot;.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDatasetLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetLabelsResponse
        /// </returns>
        public CreateDatasetLabelsResponse CreateDatasetLabels(string DatasetId, CreateDatasetLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDatasetLabelsWithOptions(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates tags for a dataset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The tag key and value are not empty strings and cannot exceed 128 characters in length.</description></item>
        /// <item><description>The tag key cannot start with any of the following strings: &quot;aliyun&quot;, &quot;acs&quot;, &quot;http://&quot;, and &quot;https://&quot;.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDatasetLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetLabelsResponse
        /// </returns>
        public async Task<CreateDatasetLabelsResponse> CreateDatasetLabelsAsync(string DatasetId, CreateDatasetLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDatasetLabelsWithOptionsAsync(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dataset version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetVersionResponse
        /// </returns>
        public CreateDatasetVersionResponse CreateDatasetVersionWithOptions(string DatasetId, CreateDatasetVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCount))
            {
                body["DataCount"] = request.DataCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSize))
            {
                body["DataSize"] = request.DataSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportInfo))
            {
                body["ImportInfo"] = request.ImportInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Property))
            {
                body["Property"] = request.Property;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatasetVersion",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasetVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dataset version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetVersionResponse
        /// </returns>
        public async Task<CreateDatasetVersionResponse> CreateDatasetVersionWithOptionsAsync(string DatasetId, CreateDatasetVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCount))
            {
                body["DataCount"] = request.DataCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSize))
            {
                body["DataSize"] = request.DataSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportInfo))
            {
                body["ImportInfo"] = request.ImportInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Property))
            {
                body["Property"] = request.Property;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatasetVersion",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasetVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dataset version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetVersionResponse
        /// </returns>
        public CreateDatasetVersionResponse CreateDatasetVersion(string DatasetId, CreateDatasetVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDatasetVersionWithOptions(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a dataset version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetVersionResponse
        /// </returns>
        public async Task<CreateDatasetVersionResponse> CreateDatasetVersionAsync(string DatasetId, CreateDatasetVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDatasetVersionWithOptionsAsync(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates tags for a dataset version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetVersionLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetVersionLabelsResponse
        /// </returns>
        public CreateDatasetVersionLabelsResponse CreateDatasetVersionLabelsWithOptions(string DatasetId, string VersionName, CreateDatasetVersionLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatasetVersionLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VersionName) + "/labels",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasetVersionLabelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates tags for a dataset version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetVersionLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetVersionLabelsResponse
        /// </returns>
        public async Task<CreateDatasetVersionLabelsResponse> CreateDatasetVersionLabelsWithOptionsAsync(string DatasetId, string VersionName, CreateDatasetVersionLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatasetVersionLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VersionName) + "/labels",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasetVersionLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates tags for a dataset version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetVersionLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetVersionLabelsResponse
        /// </returns>
        public CreateDatasetVersionLabelsResponse CreateDatasetVersionLabels(string DatasetId, string VersionName, CreateDatasetVersionLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDatasetVersionLabelsWithOptions(DatasetId, VersionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates tags for a dataset version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasetVersionLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasetVersionLabelsResponse
        /// </returns>
        public async Task<CreateDatasetVersionLabelsResponse> CreateDatasetVersionLabelsAsync(string DatasetId, string VersionName, CreateDatasetVersionLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDatasetVersionLabelsWithOptionsAsync(DatasetId, VersionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an experiment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentResponse
        /// </returns>
        public CreateExperimentResponse CreateExperimentWithOptions(CreateExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactUri))
            {
                body["ArtifactUri"] = request.ArtifactUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExperiment",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an experiment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentResponse
        /// </returns>
        public async Task<CreateExperimentResponse> CreateExperimentWithOptionsAsync(CreateExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactUri))
            {
                body["ArtifactUri"] = request.ArtifactUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExperiment",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an experiment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentResponse
        /// </returns>
        public CreateExperimentResponse CreateExperiment(CreateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateExperimentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an experiment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentResponse
        /// </returns>
        public async Task<CreateExperimentResponse> CreateExperimentAsync(CreateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateExperimentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a user to a workspace as a member. You can add multiple users as members.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemberRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMemberResponse
        /// </returns>
        public CreateMemberResponse CreateMemberWithOptions(string WorkspaceId, CreateMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["Members"] = request.Members;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMember",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a user to a workspace as a member. You can add multiple users as members.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemberRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMemberResponse
        /// </returns>
        public async Task<CreateMemberResponse> CreateMemberWithOptionsAsync(string WorkspaceId, CreateMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["Members"] = request.Members;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMember",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a user to a workspace as a member. You can add multiple users as members.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMemberResponse
        /// </returns>
        public CreateMemberResponse CreateMember(string WorkspaceId, CreateMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMemberWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a user to a workspace as a member. You can add multiple users as members.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMemberResponse
        /// </returns>
        public async Task<CreateMemberResponse> CreateMemberAsync(string WorkspaceId, CreateMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMemberWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model. A model is a collection of model versions. When you create a model, you must specify the model name and description.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelResponse
        /// </returns>
        public CreateModelResponse CreateModelWithOptions(CreateModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["ExtraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelDescription))
            {
                body["ModelDescription"] = request.ModelDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelDoc))
            {
                body["ModelDoc"] = request.ModelDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                body["ModelName"] = request.ModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                body["ModelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNumber))
            {
                body["OrderNumber"] = request.OrderNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                body["Origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Task))
            {
                body["Task"] = request.Task;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModel",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model. A model is a collection of model versions. When you create a model, you must specify the model name and description.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelResponse
        /// </returns>
        public async Task<CreateModelResponse> CreateModelWithOptionsAsync(CreateModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["ExtraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelDescription))
            {
                body["ModelDescription"] = request.ModelDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelDoc))
            {
                body["ModelDoc"] = request.ModelDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                body["ModelName"] = request.ModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                body["ModelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNumber))
            {
                body["OrderNumber"] = request.OrderNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                body["Origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Task))
            {
                body["Task"] = request.Task;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModel",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model. A model is a collection of model versions. When you create a model, you must specify the model name and description.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelResponse
        /// </returns>
        public CreateModelResponse CreateModel(CreateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateModelWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model. A model is a collection of model versions. When you create a model, you must specify the model name and description.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelResponse
        /// </returns>
        public async Task<CreateModelResponse> CreateModelAsync(CreateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateModelWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a tag for a model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelLabelsResponse
        /// </returns>
        public CreateModelLabelsResponse CreateModelLabelsWithOptions(string ModelId, CreateModelLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/labels",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelLabelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a tag for a model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelLabelsResponse
        /// </returns>
        public async Task<CreateModelLabelsResponse> CreateModelLabelsWithOptionsAsync(string ModelId, CreateModelLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/labels",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a tag for a model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelLabelsResponse
        /// </returns>
        public CreateModelLabelsResponse CreateModelLabels(string ModelId, CreateModelLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateModelLabelsWithOptions(ModelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a tag for a model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelLabelsResponse
        /// </returns>
        public async Task<CreateModelLabelsResponse> CreateModelLabelsAsync(string ModelId, CreateModelLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateModelLabelsWithOptionsAsync(ModelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new version for the specified model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelVersionResponse
        /// </returns>
        public CreateModelVersionResponse CreateModelVersionWithOptions(string ModelId, CreateModelVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovalStatus))
            {
                body["ApprovalStatus"] = request.ApprovalStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompressionSpec))
            {
                body["CompressionSpec"] = request.CompressionSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationSpec))
            {
                body["EvaluationSpec"] = request.EvaluationSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["ExtraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormatType))
            {
                body["FormatType"] = request.FormatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrameworkType))
            {
                body["FrameworkType"] = request.FrameworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InferenceSpec))
            {
                body["InferenceSpec"] = request.InferenceSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                body["Metrics"] = request.Metrics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainingSpec))
            {
                body["TrainingSpec"] = request.TrainingSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionDescription))
            {
                body["VersionDescription"] = request.VersionDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                body["VersionName"] = request.VersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelVersion",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new version for the specified model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelVersionResponse
        /// </returns>
        public async Task<CreateModelVersionResponse> CreateModelVersionWithOptionsAsync(string ModelId, CreateModelVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovalStatus))
            {
                body["ApprovalStatus"] = request.ApprovalStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompressionSpec))
            {
                body["CompressionSpec"] = request.CompressionSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationSpec))
            {
                body["EvaluationSpec"] = request.EvaluationSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["ExtraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormatType))
            {
                body["FormatType"] = request.FormatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrameworkType))
            {
                body["FrameworkType"] = request.FrameworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InferenceSpec))
            {
                body["InferenceSpec"] = request.InferenceSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                body["Metrics"] = request.Metrics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainingSpec))
            {
                body["TrainingSpec"] = request.TrainingSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionDescription))
            {
                body["VersionDescription"] = request.VersionDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                body["VersionName"] = request.VersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelVersion",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new version for the specified model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelVersionResponse
        /// </returns>
        public CreateModelVersionResponse CreateModelVersion(string ModelId, CreateModelVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateModelVersionWithOptions(ModelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new version for the specified model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelVersionResponse
        /// </returns>
        public async Task<CreateModelVersionResponse> CreateModelVersionAsync(string ModelId, CreateModelVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateModelVersionWithOptionsAsync(ModelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a tag for a model version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelVersionLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelVersionLabelsResponse
        /// </returns>
        public CreateModelVersionLabelsResponse CreateModelVersionLabelsWithOptions(string ModelId, string VersionName, CreateModelVersionLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelVersionLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VersionName) + "/labels",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelVersionLabelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a tag for a model version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelVersionLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModelVersionLabelsResponse
        /// </returns>
        public async Task<CreateModelVersionLabelsResponse> CreateModelVersionLabelsWithOptionsAsync(string ModelId, string VersionName, CreateModelVersionLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModelVersionLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VersionName) + "/labels",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelVersionLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a tag for a model version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelVersionLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelVersionLabelsResponse
        /// </returns>
        public CreateModelVersionLabelsResponse CreateModelVersionLabels(string ModelId, string VersionName, CreateModelVersionLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateModelVersionLabelsWithOptions(ModelId, VersionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a tag for a model version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModelVersionLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModelVersionLabelsResponse
        /// </returns>
        public async Task<CreateModelVersionLabelsResponse> CreateModelVersionLabelsAsync(string ModelId, string VersionName, CreateModelVersionLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateModelVersionLabelsWithOptionsAsync(ModelId, VersionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a pay-as-you-go order for DataWorks, OSS, PAI, or MaxCompute.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProductOrdersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProductOrdersResponse
        /// </returns>
        public CreateProductOrdersResponse CreateProductOrdersWithOptions(CreateProductOrdersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                body["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Products))
            {
                body["Products"] = request.Products;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProductOrders",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/productorders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProductOrdersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a pay-as-you-go order for DataWorks, OSS, PAI, or MaxCompute.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProductOrdersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProductOrdersResponse
        /// </returns>
        public async Task<CreateProductOrdersResponse> CreateProductOrdersWithOptionsAsync(CreateProductOrdersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                body["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Products))
            {
                body["Products"] = request.Products;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProductOrders",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/productorders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProductOrdersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a pay-as-you-go order for DataWorks, OSS, PAI, or MaxCompute.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProductOrdersRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProductOrdersResponse
        /// </returns>
        public CreateProductOrdersResponse CreateProductOrders(CreateProductOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProductOrdersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a pay-as-you-go order for DataWorks, OSS, PAI, or MaxCompute.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProductOrdersRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProductOrdersResponse
        /// </returns>
        public async Task<CreateProductOrdersResponse> CreateProductOrdersAsync(CreateProductOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProductOrdersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a run. A run is an experiment that can be associated with a specific workload or simply a code execution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRunResponse
        /// </returns>
        public CreateRunResponse CreateRunWithOptions(CreateRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentId))
            {
                body["ExperimentId"] = request.ExperimentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRun",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/runs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a run. A run is an experiment that can be associated with a specific workload or simply a code execution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRunResponse
        /// </returns>
        public async Task<CreateRunResponse> CreateRunWithOptionsAsync(CreateRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentId))
            {
                body["ExperimentId"] = request.ExperimentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRun",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/runs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a run. A run is an experiment that can be associated with a specific workload or simply a code execution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRunRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRunResponse
        /// </returns>
        public CreateRunResponse CreateRun(CreateRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRunWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a run. A run is an experiment that can be associated with a specific workload or simply a code execution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRunRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRunResponse
        /// </returns>
        public async Task<CreateRunResponse> CreateRunAsync(CreateRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRunWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public CreateWorkspaceResponse CreateWorkspaceWithOptions(CreateWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvTypes))
            {
                body["EnvTypes"] = request.EnvTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                body["WorkspaceName"] = request.WorkspaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspace",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public async Task<CreateWorkspaceResponse> CreateWorkspaceWithOptionsAsync(CreateWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvTypes))
            {
                body["EnvTypes"] = request.EnvTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                body["WorkspaceName"] = request.WorkspaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspace",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateWorkspaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public async Task<CreateWorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateWorkspaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates resources with a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResourceResponse
        /// </returns>
        public CreateWorkspaceResourceResponse CreateWorkspaceResourceWithOptions(string WorkspaceId, CreateWorkspaceResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["Option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                body["Resources"] = request.Resources;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspaceResource",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/resources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates resources with a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResourceResponse
        /// </returns>
        public async Task<CreateWorkspaceResourceResponse> CreateWorkspaceResourceWithOptionsAsync(string WorkspaceId, CreateWorkspaceResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                body["Option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                body["Resources"] = request.Resources;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspaceResource",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/resources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates resources with a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResourceResponse
        /// </returns>
        public CreateWorkspaceResourceResponse CreateWorkspaceResource(string WorkspaceId, CreateWorkspaceResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateWorkspaceResourceWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates resources with a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResourceResponse
        /// </returns>
        public async Task<CreateWorkspaceResourceResponse> CreateWorkspaceResourceAsync(string WorkspaceId, CreateWorkspaceResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateWorkspaceResourceWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a code source based on the provided ID.</para>
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
        /// DeleteCodeSourceResponse
        /// </returns>
        public DeleteCodeSourceResponse DeleteCodeSourceWithOptions(string CodeSourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCodeSource",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/codesources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CodeSourceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCodeSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a code source based on the provided ID.</para>
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
        /// DeleteCodeSourceResponse
        /// </returns>
        public async Task<DeleteCodeSourceResponse> DeleteCodeSourceWithOptionsAsync(string CodeSourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCodeSource",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/codesources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CodeSourceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCodeSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a code source based on the provided ID.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteCodeSourceResponse
        /// </returns>
        public DeleteCodeSourceResponse DeleteCodeSource(string CodeSourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteCodeSourceWithOptions(CodeSourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a code source based on the provided ID.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteCodeSourceResponse
        /// </returns>
        public async Task<DeleteCodeSourceResponse> DeleteCodeSourceAsync(string CodeSourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteCodeSourceWithOptionsAsync(CodeSourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes workspace configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteConfigResponse
        /// </returns>
        public DeleteConfigResponse DeleteConfigWithOptions(string WorkspaceId, string ConfigKey, DeleteConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                query["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConfig",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ConfigKey),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes workspace configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteConfigResponse
        /// </returns>
        public async Task<DeleteConfigResponse> DeleteConfigWithOptionsAsync(string WorkspaceId, string ConfigKey, DeleteConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                query["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConfig",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ConfigKey),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes workspace configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteConfigResponse
        /// </returns>
        public DeleteConfigResponse DeleteConfig(string WorkspaceId, string ConfigKey, DeleteConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConfigWithOptions(WorkspaceId, ConfigKey, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes workspace configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteConfigResponse
        /// </returns>
        public async Task<DeleteConfigResponse> DeleteConfigAsync(string WorkspaceId, string ConfigKey, DeleteConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConfigWithOptionsAsync(WorkspaceId, ConfigKey, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a connection.</para>
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
        /// DeleteConnectionResponse
        /// </returns>
        public DeleteConnectionResponse DeleteConnectionWithOptions(string ConnectionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConnection",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ConnectionId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a connection.</para>
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
        /// DeleteConnectionResponse
        /// </returns>
        public async Task<DeleteConnectionResponse> DeleteConnectionWithOptionsAsync(string ConnectionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConnection",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ConnectionId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a connection.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteConnectionResponse
        /// </returns>
        public DeleteConnectionResponse DeleteConnection(string ConnectionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConnectionWithOptions(ConnectionId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a connection.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteConnectionResponse
        /// </returns>
        public async Task<DeleteConnectionResponse> DeleteConnectionAsync(string ConnectionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConnectionWithOptionsAsync(ConnectionId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataset.</para>
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
        /// DeleteDatasetResponse
        /// </returns>
        public DeleteDatasetResponse DeleteDatasetWithOptions(string DatasetId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataset",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataset.</para>
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
        /// DeleteDatasetResponse
        /// </returns>
        public async Task<DeleteDatasetResponse> DeleteDatasetWithOptionsAsync(string DatasetId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataset",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataset.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteDatasetResponse
        /// </returns>
        public DeleteDatasetResponse DeleteDataset(string DatasetId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDatasetWithOptions(DatasetId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataset.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteDatasetResponse
        /// </returns>
        public async Task<DeleteDatasetResponse> DeleteDatasetAsync(string DatasetId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDatasetWithOptionsAsync(DatasetId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the metadata records of multiple files in a dataset at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetFileMetasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetFileMetasResponse
        /// </returns>
        public DeleteDatasetFileMetasResponse DeleteDatasetFileMetasWithOptions(string DatasetId, DeleteDatasetFileMetasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetFileMetaIds))
            {
                query["DatasetFileMetaIds"] = request.DatasetFileMetaIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetVersion))
            {
                query["DatasetVersion"] = request.DatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatasetFileMetas",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetfilemetas",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetFileMetasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the metadata records of multiple files in a dataset at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetFileMetasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetFileMetasResponse
        /// </returns>
        public async Task<DeleteDatasetFileMetasResponse> DeleteDatasetFileMetasWithOptionsAsync(string DatasetId, DeleteDatasetFileMetasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetFileMetaIds))
            {
                query["DatasetFileMetaIds"] = request.DatasetFileMetaIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetVersion))
            {
                query["DatasetVersion"] = request.DatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatasetFileMetas",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetfilemetas",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetFileMetasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the metadata records of multiple files in a dataset at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetFileMetasRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetFileMetasResponse
        /// </returns>
        public DeleteDatasetFileMetasResponse DeleteDatasetFileMetas(string DatasetId, DeleteDatasetFileMetasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDatasetFileMetasWithOptions(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the metadata records of multiple files in a dataset at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetFileMetasRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetFileMetasResponse
        /// </returns>
        public async Task<DeleteDatasetFileMetasResponse> DeleteDatasetFileMetasAsync(string DatasetId, DeleteDatasetFileMetasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDatasetFileMetasWithOptionsAsync(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataset job.</para>
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
        /// DeleteDatasetJobResponse
        /// </returns>
        public DeleteDatasetJobResponse DeleteDatasetJobWithOptions(string DatasetId, string DatasetJobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatasetJob",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetJobId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataset job.</para>
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
        /// DeleteDatasetJobResponse
        /// </returns>
        public async Task<DeleteDatasetJobResponse> DeleteDatasetJobWithOptionsAsync(string DatasetId, string DatasetJobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatasetJob",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetJobId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataset job.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteDatasetJobResponse
        /// </returns>
        public DeleteDatasetJobResponse DeleteDatasetJob(string DatasetId, string DatasetJobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDatasetJobWithOptions(DatasetId, DatasetJobId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataset job.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteDatasetJobResponse
        /// </returns>
        public async Task<DeleteDatasetJobResponse> DeleteDatasetJobAsync(string DatasetId, string DatasetJobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDatasetJobWithOptionsAsync(DatasetId, DatasetJobId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a job configuration for a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetJobConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetJobConfigResponse
        /// </returns>
        public DeleteDatasetJobConfigResponse DeleteDatasetJobConfigWithOptions(string DatasetId, string DatasetJobConfigId, DeleteDatasetJobConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatasetJobConfig",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetjobconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetJobConfigId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetJobConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a job configuration for a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetJobConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetJobConfigResponse
        /// </returns>
        public async Task<DeleteDatasetJobConfigResponse> DeleteDatasetJobConfigWithOptionsAsync(string DatasetId, string DatasetJobConfigId, DeleteDatasetJobConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatasetJobConfig",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetjobconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetJobConfigId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetJobConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a job configuration for a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetJobConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetJobConfigResponse
        /// </returns>
        public DeleteDatasetJobConfigResponse DeleteDatasetJobConfig(string DatasetId, string DatasetJobConfigId, DeleteDatasetJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDatasetJobConfigWithOptions(DatasetId, DatasetJobConfigId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a job configuration for a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetJobConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetJobConfigResponse
        /// </returns>
        public async Task<DeleteDatasetJobConfigResponse> DeleteDatasetJobConfigAsync(string DatasetId, string DatasetJobConfigId, DeleteDatasetJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDatasetJobConfigWithOptionsAsync(DatasetId, DatasetJobConfigId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataset tag.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetLabelsResponse
        /// </returns>
        public DeleteDatasetLabelsResponse DeleteDatasetLabelsWithOptions(string DatasetId, DeleteDatasetLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelKeys))
            {
                query["LabelKeys"] = request.LabelKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatasetLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/labels",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetLabelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataset tag.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetLabelsResponse
        /// </returns>
        public async Task<DeleteDatasetLabelsResponse> DeleteDatasetLabelsWithOptionsAsync(string DatasetId, DeleteDatasetLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelKeys))
            {
                query["LabelKeys"] = request.LabelKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatasetLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/labels",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataset tag.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetLabelsResponse
        /// </returns>
        public DeleteDatasetLabelsResponse DeleteDatasetLabels(string DatasetId, DeleteDatasetLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDatasetLabelsWithOptions(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataset tag.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetLabelsResponse
        /// </returns>
        public async Task<DeleteDatasetLabelsResponse> DeleteDatasetLabelsAsync(string DatasetId, DeleteDatasetLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDatasetLabelsWithOptionsAsync(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the information about a specified version of a dataset. Version v1 cannot be deleted by using this operation. When you call the DeleteDataset operation to delete a dataset, it can be deleted at the same time.</para>
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
        /// DeleteDatasetVersionResponse
        /// </returns>
        public DeleteDatasetVersionResponse DeleteDatasetVersionWithOptions(string DatasetId, string VersionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatasetVersion",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VersionName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the information about a specified version of a dataset. Version v1 cannot be deleted by using this operation. When you call the DeleteDataset operation to delete a dataset, it can be deleted at the same time.</para>
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
        /// DeleteDatasetVersionResponse
        /// </returns>
        public async Task<DeleteDatasetVersionResponse> DeleteDatasetVersionWithOptionsAsync(string DatasetId, string VersionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatasetVersion",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VersionName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the information about a specified version of a dataset. Version v1 cannot be deleted by using this operation. When you call the DeleteDataset operation to delete a dataset, it can be deleted at the same time.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteDatasetVersionResponse
        /// </returns>
        public DeleteDatasetVersionResponse DeleteDatasetVersion(string DatasetId, string VersionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDatasetVersionWithOptions(DatasetId, VersionName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the information about a specified version of a dataset. Version v1 cannot be deleted by using this operation. When you call the DeleteDataset operation to delete a dataset, it can be deleted at the same time.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteDatasetVersionResponse
        /// </returns>
        public async Task<DeleteDatasetVersionResponse> DeleteDatasetVersionAsync(string DatasetId, string VersionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDatasetVersionWithOptionsAsync(DatasetId, VersionName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes tags for a dataset version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetVersionLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetVersionLabelsResponse
        /// </returns>
        public DeleteDatasetVersionLabelsResponse DeleteDatasetVersionLabelsWithOptions(string DatasetId, string VersionName, DeleteDatasetVersionLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keys))
            {
                query["Keys"] = request.Keys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatasetVersionLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VersionName) + "/labels",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetVersionLabelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes tags for a dataset version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetVersionLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetVersionLabelsResponse
        /// </returns>
        public async Task<DeleteDatasetVersionLabelsResponse> DeleteDatasetVersionLabelsWithOptionsAsync(string DatasetId, string VersionName, DeleteDatasetVersionLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keys))
            {
                query["Keys"] = request.Keys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatasetVersionLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VersionName) + "/labels",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetVersionLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes tags for a dataset version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetVersionLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetVersionLabelsResponse
        /// </returns>
        public DeleteDatasetVersionLabelsResponse DeleteDatasetVersionLabels(string DatasetId, string VersionName, DeleteDatasetVersionLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDatasetVersionLabelsWithOptions(DatasetId, VersionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes tags for a dataset version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDatasetVersionLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDatasetVersionLabelsResponse
        /// </returns>
        public async Task<DeleteDatasetVersionLabelsResponse> DeleteDatasetVersionLabelsAsync(string DatasetId, string VersionName, DeleteDatasetVersionLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDatasetVersionLabelsWithOptionsAsync(DatasetId, VersionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an experiment.</para>
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
        /// DeleteExperimentResponse
        /// </returns>
        public DeleteExperimentResponse DeleteExperimentWithOptions(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExperiment",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an experiment.</para>
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
        /// DeleteExperimentResponse
        /// </returns>
        public async Task<DeleteExperimentResponse> DeleteExperimentWithOptionsAsync(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExperiment",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an experiment.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteExperimentResponse
        /// </returns>
        public DeleteExperimentResponse DeleteExperiment(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteExperimentWithOptions(ExperimentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an experiment.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteExperimentResponse
        /// </returns>
        public async Task<DeleteExperimentResponse> DeleteExperimentAsync(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteExperimentWithOptionsAsync(ExperimentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an experiment tag.</para>
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
        /// DeleteExperimentLabelResponse
        /// </returns>
        public DeleteExperimentLabelResponse DeleteExperimentLabelWithOptions(string ExperimentId, string Key, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExperimentLabel",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/labels/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Key),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExperimentLabelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an experiment tag.</para>
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
        /// DeleteExperimentLabelResponse
        /// </returns>
        public async Task<DeleteExperimentLabelResponse> DeleteExperimentLabelWithOptionsAsync(string ExperimentId, string Key, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExperimentLabel",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/labels/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Key),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExperimentLabelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an experiment tag.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteExperimentLabelResponse
        /// </returns>
        public DeleteExperimentLabelResponse DeleteExperimentLabel(string ExperimentId, string Key)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteExperimentLabelWithOptions(ExperimentId, Key, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an experiment tag.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteExperimentLabelResponse
        /// </returns>
        public async Task<DeleteExperimentLabelResponse> DeleteExperimentLabelAsync(string ExperimentId, string Key)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteExperimentLabelWithOptionsAsync(ExperimentId, Key, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a member from a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMembersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMembersResponse
        /// </returns>
        public DeleteMembersResponse DeleteMembersWithOptions(string WorkspaceId, DeleteMembersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberIds))
            {
                query["MemberIds"] = request.MemberIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMembers",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/members",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMembersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a member from a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMembersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMembersResponse
        /// </returns>
        public async Task<DeleteMembersResponse> DeleteMembersWithOptionsAsync(string WorkspaceId, DeleteMembersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberIds))
            {
                query["MemberIds"] = request.MemberIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMembers",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/members",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a member from a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMembersResponse
        /// </returns>
        public DeleteMembersResponse DeleteMembers(string WorkspaceId, DeleteMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMembersWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a member from a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMembersResponse
        /// </returns>
        public async Task<DeleteMembersResponse> DeleteMembersAsync(string WorkspaceId, DeleteMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMembersWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model.</para>
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
        /// DeleteModelResponse
        /// </returns>
        public DeleteModelResponse DeleteModelWithOptions(string ModelId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModel",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model.</para>
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
        /// DeleteModelResponse
        /// </returns>
        public async Task<DeleteModelResponse> DeleteModelWithOptionsAsync(string ModelId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModel",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteModelResponse
        /// </returns>
        public DeleteModelResponse DeleteModel(string ModelId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteModelWithOptions(ModelId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteModelResponse
        /// </returns>
        public async Task<DeleteModelResponse> DeleteModelAsync(string ModelId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteModelWithOptionsAsync(ModelId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the labels of a model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteModelLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelLabelsResponse
        /// </returns>
        public DeleteModelLabelsResponse DeleteModelLabelsWithOptions(string ModelId, DeleteModelLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelKeys))
            {
                query["LabelKeys"] = request.LabelKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModelLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/labels",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelLabelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the labels of a model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteModelLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelLabelsResponse
        /// </returns>
        public async Task<DeleteModelLabelsResponse> DeleteModelLabelsWithOptionsAsync(string ModelId, DeleteModelLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelKeys))
            {
                query["LabelKeys"] = request.LabelKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModelLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/labels",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the labels of a model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteModelLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelLabelsResponse
        /// </returns>
        public DeleteModelLabelsResponse DeleteModelLabels(string ModelId, DeleteModelLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteModelLabelsWithOptions(ModelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the labels of a model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteModelLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelLabelsResponse
        /// </returns>
        public async Task<DeleteModelLabelsResponse> DeleteModelLabelsAsync(string ModelId, DeleteModelLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteModelLabelsWithOptionsAsync(ModelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model version.</para>
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
        /// DeleteModelVersionResponse
        /// </returns>
        public DeleteModelVersionResponse DeleteModelVersionWithOptions(string ModelId, string VersionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModelVersion",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VersionName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model version.</para>
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
        /// DeleteModelVersionResponse
        /// </returns>
        public async Task<DeleteModelVersionResponse> DeleteModelVersionWithOptionsAsync(string ModelId, string VersionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModelVersion",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VersionName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model version.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteModelVersionResponse
        /// </returns>
        public DeleteModelVersionResponse DeleteModelVersion(string ModelId, string VersionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteModelVersionWithOptions(ModelId, VersionName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a model version.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteModelVersionResponse
        /// </returns>
        public async Task<DeleteModelVersionResponse> DeleteModelVersionAsync(string ModelId, string VersionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteModelVersionWithOptionsAsync(ModelId, VersionName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a model version tag.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteModelVersionLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelVersionLabelsResponse
        /// </returns>
        public DeleteModelVersionLabelsResponse DeleteModelVersionLabelsWithOptions(string ModelId, string VersionName, DeleteModelVersionLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelKeys))
            {
                query["LabelKeys"] = request.LabelKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModelVersionLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VersionName) + "/labels",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelVersionLabelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a model version tag.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteModelVersionLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelVersionLabelsResponse
        /// </returns>
        public async Task<DeleteModelVersionLabelsResponse> DeleteModelVersionLabelsWithOptionsAsync(string ModelId, string VersionName, DeleteModelVersionLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelKeys))
            {
                query["LabelKeys"] = request.LabelKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModelVersionLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VersionName) + "/labels",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelVersionLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a model version tag.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteModelVersionLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelVersionLabelsResponse
        /// </returns>
        public DeleteModelVersionLabelsResponse DeleteModelVersionLabels(string ModelId, string VersionName, DeleteModelVersionLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteModelVersionLabelsWithOptions(ModelId, VersionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a model version tag.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteModelVersionLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelVersionLabelsResponse
        /// </returns>
        public async Task<DeleteModelVersionLabelsResponse> DeleteModelVersionLabelsAsync(string ModelId, string VersionName, DeleteModelVersionLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteModelVersionLabelsWithOptionsAsync(ModelId, VersionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a run.</para>
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
        /// DeleteRunResponse
        /// </returns>
        public DeleteRunResponse DeleteRunWithOptions(string RunId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRun",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RunId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a run.</para>
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
        /// DeleteRunResponse
        /// </returns>
        public async Task<DeleteRunResponse> DeleteRunWithOptionsAsync(string RunId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRun",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RunId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a run.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteRunResponse
        /// </returns>
        public DeleteRunResponse DeleteRun(string RunId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRunWithOptions(RunId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a run.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteRunResponse
        /// </returns>
        public async Task<DeleteRunResponse> DeleteRunAsync(string RunId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRunWithOptionsAsync(RunId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a tag that is added to a run.</para>
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
        /// DeleteRunLabelResponse
        /// </returns>
        public DeleteRunLabelResponse DeleteRunLabelWithOptions(string RunId, string Key, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRunLabel",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RunId) + "/labels/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Key),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRunLabelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a tag that is added to a run.</para>
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
        /// DeleteRunLabelResponse
        /// </returns>
        public async Task<DeleteRunLabelResponse> DeleteRunLabelWithOptionsAsync(string RunId, string Key, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRunLabel",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RunId) + "/labels/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Key),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRunLabelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a tag that is added to a run.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteRunLabelResponse
        /// </returns>
        public DeleteRunLabelResponse DeleteRunLabel(string RunId, string Key)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRunLabelWithOptions(RunId, Key, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a tag that is added to a run.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteRunLabelResponse
        /// </returns>
        public async Task<DeleteRunLabelResponse> DeleteRunLabelAsync(string RunId, string Key)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRunLabelWithOptionsAsync(RunId, Key, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes user configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserConfigResponse
        /// </returns>
        public DeleteUserConfigResponse DeleteUserConfigWithOptions(string CategoryName, DeleteUserConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKey))
            {
                query["ConfigKey"] = request.ConfigKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserConfig",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/userconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CategoryName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes user configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserConfigResponse
        /// </returns>
        public async Task<DeleteUserConfigResponse> DeleteUserConfigWithOptionsAsync(string CategoryName, DeleteUserConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKey))
            {
                query["ConfigKey"] = request.ConfigKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserConfig",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/userconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CategoryName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes user configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserConfigResponse
        /// </returns>
        public DeleteUserConfigResponse DeleteUserConfig(string CategoryName, DeleteUserConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteUserConfigWithOptions(CategoryName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes user configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserConfigResponse
        /// </returns>
        public async Task<DeleteUserConfigResponse> DeleteUserConfigAsync(string CategoryName, DeleteUserConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteUserConfigWithOptionsAsync(CategoryName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a workspace. After you delete a workspace, the associated resources are not automatically released. You must manually release the resources.</para>
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
        /// DeleteWorkspaceResponse
        /// </returns>
        public DeleteWorkspaceResponse DeleteWorkspaceWithOptions(string WorkspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspace",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a workspace. After you delete a workspace, the associated resources are not automatically released. You must manually release the resources.</para>
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
        /// DeleteWorkspaceResponse
        /// </returns>
        public async Task<DeleteWorkspaceResponse> DeleteWorkspaceWithOptionsAsync(string WorkspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspace",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a workspace. After you delete a workspace, the associated resources are not automatically released. You must manually release the resources.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public DeleteWorkspaceResponse DeleteWorkspace(string WorkspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteWorkspaceWithOptions(WorkspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a workspace. After you delete a workspace, the associated resources are not automatically released. You must manually release the resources.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public async Task<DeleteWorkspaceResponse> DeleteWorkspaceAsync(string WorkspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteWorkspaceWithOptionsAsync(WorkspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a resource from a workspace. The resource is not deleted at the underlying layer.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResourceResponse
        /// </returns>
        public DeleteWorkspaceResourceResponse DeleteWorkspaceResourceWithOptions(string WorkspaceId, DeleteWorkspaceResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                query["Option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspaceResource",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/resources",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkspaceResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a resource from a workspace. The resource is not deleted at the underlying layer.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResourceResponse
        /// </returns>
        public async Task<DeleteWorkspaceResourceResponse> DeleteWorkspaceResourceWithOptionsAsync(string WorkspaceId, DeleteWorkspaceResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                query["Option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspaceResource",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/resources",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkspaceResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a resource from a workspace. The resource is not deleted at the underlying layer.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResourceResponse
        /// </returns>
        public DeleteWorkspaceResourceResponse DeleteWorkspaceResource(string WorkspaceId, DeleteWorkspaceResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteWorkspaceResourceWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a resource from a workspace. The resource is not deleted at the underlying layer.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResourceResponse
        /// </returns>
        public async Task<DeleteWorkspaceResourceResponse> DeleteWorkspaceResourceAsync(string WorkspaceId, DeleteWorkspaceResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteWorkspaceResourceWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a code source.</para>
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
        /// GetCodeSourceResponse
        /// </returns>
        public GetCodeSourceResponse GetCodeSourceWithOptions(string CodeSourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCodeSource",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/codesources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CodeSourceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCodeSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a code source.</para>
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
        /// GetCodeSourceResponse
        /// </returns>
        public async Task<GetCodeSourceResponse> GetCodeSourceWithOptionsAsync(string CodeSourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCodeSource",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/codesources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CodeSourceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCodeSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a code source.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCodeSourceResponse
        /// </returns>
        public GetCodeSourceResponse GetCodeSource(string CodeSourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCodeSourceWithOptions(CodeSourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a code source.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCodeSourceResponse
        /// </returns>
        public async Task<GetCodeSourceResponse> GetCodeSourceAsync(string CodeSourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCodeSourceWithOptionsAsync(CodeSourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a workspace configuration item.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConfigResponse
        /// </returns>
        public GetConfigResponse GetConfigWithOptions(string WorkspaceId, GetConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                query["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKey))
            {
                query["ConfigKey"] = request.ConfigKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfig",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a workspace configuration item.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConfigResponse
        /// </returns>
        public async Task<GetConfigResponse> GetConfigWithOptionsAsync(string WorkspaceId, GetConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                query["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKey))
            {
                query["ConfigKey"] = request.ConfigKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfig",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a workspace configuration item.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConfigResponse
        /// </returns>
        public GetConfigResponse GetConfig(string WorkspaceId, GetConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetConfigWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a workspace configuration item.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConfigResponse
        /// </returns>
        public async Task<GetConfigResponse> GetConfigAsync(string WorkspaceId, GetConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetConfigWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConnectionResponse
        /// </returns>
        public GetConnectionResponse GetConnectionWithOptions(string ConnectionId, GetConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptOption))
            {
                query["EncryptOption"] = request.EncryptOption;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConnection",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ConnectionId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConnectionResponse
        /// </returns>
        public async Task<GetConnectionResponse> GetConnectionWithOptionsAsync(string ConnectionId, GetConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptOption))
            {
                query["EncryptOption"] = request.EncryptOption;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConnection",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ConnectionId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConnectionResponse
        /// </returns>
        public GetConnectionResponse GetConnection(string ConnectionId, GetConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetConnectionWithOptions(ConnectionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConnectionResponse
        /// </returns>
        public async Task<GetConnectionResponse> GetConnectionAsync(string ConnectionId, GetConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetConnectionWithOptionsAsync(ConnectionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a dataset.</para>
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
        /// GetDatasetResponse
        /// </returns>
        public GetDatasetResponse GetDatasetWithOptions(string DatasetId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataset",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a dataset.</para>
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
        /// GetDatasetResponse
        /// </returns>
        public async Task<GetDatasetResponse> GetDatasetWithOptionsAsync(string DatasetId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataset",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a dataset.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDatasetResponse
        /// </returns>
        public GetDatasetResponse GetDataset(string DatasetId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDatasetWithOptions(DatasetId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a dataset.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDatasetResponse
        /// </returns>
        public async Task<GetDatasetResponse> GetDatasetAsync(string DatasetId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDatasetWithOptionsAsync(DatasetId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata records of specific files in a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetFileMetaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetFileMetaResponse
        /// </returns>
        public GetDatasetFileMetaResponse GetDatasetFileMetaWithOptions(string DatasetId, string DatasetFileMetaId, GetDatasetFileMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetVersion))
            {
                query["DatasetVersion"] = request.DatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatasetFileMeta",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetfilemetas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetFileMetaId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetFileMetaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata records of specific files in a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetFileMetaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetFileMetaResponse
        /// </returns>
        public async Task<GetDatasetFileMetaResponse> GetDatasetFileMetaWithOptionsAsync(string DatasetId, string DatasetFileMetaId, GetDatasetFileMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetVersion))
            {
                query["DatasetVersion"] = request.DatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatasetFileMeta",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetfilemetas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetFileMetaId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetFileMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata records of specific files in a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetFileMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetFileMetaResponse
        /// </returns>
        public GetDatasetFileMetaResponse GetDatasetFileMeta(string DatasetId, string DatasetFileMetaId, GetDatasetFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDatasetFileMetaWithOptions(DatasetId, DatasetFileMetaId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata records of specific files in a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetFileMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetFileMetaResponse
        /// </returns>
        public async Task<GetDatasetFileMetaResponse> GetDatasetFileMetaAsync(string DatasetId, string DatasetFileMetaId, GetDatasetFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDatasetFileMetaWithOptionsAsync(DatasetId, DatasetFileMetaId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains metadata statistics of a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetFileMetasStatisticsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetFileMetasStatisticsResponse
        /// </returns>
        public GetDatasetFileMetasStatisticsResponse GetDatasetFileMetasStatisticsWithOptions(string DatasetId, GetDatasetFileMetasStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregateBy))
            {
                query["AggregateBy"] = request.AggregateBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetVersion))
            {
                query["DatasetVersion"] = request.DatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatasetFileMetasStatistics",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/statistics/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetfilemetas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetFileMetasStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains metadata statistics of a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetFileMetasStatisticsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetFileMetasStatisticsResponse
        /// </returns>
        public async Task<GetDatasetFileMetasStatisticsResponse> GetDatasetFileMetasStatisticsWithOptionsAsync(string DatasetId, GetDatasetFileMetasStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregateBy))
            {
                query["AggregateBy"] = request.AggregateBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetVersion))
            {
                query["DatasetVersion"] = request.DatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatasetFileMetasStatistics",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/statistics/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetfilemetas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetFileMetasStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains metadata statistics of a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetFileMetasStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetFileMetasStatisticsResponse
        /// </returns>
        public GetDatasetFileMetasStatisticsResponse GetDatasetFileMetasStatistics(string DatasetId, GetDatasetFileMetasStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDatasetFileMetasStatisticsWithOptions(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains metadata statistics of a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetFileMetasStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetFileMetasStatisticsResponse
        /// </returns>
        public async Task<GetDatasetFileMetasStatisticsResponse> GetDatasetFileMetasStatisticsAsync(string DatasetId, GetDatasetFileMetasStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDatasetFileMetasStatisticsWithOptionsAsync(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a dataset job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetJobResponse
        /// </returns>
        public GetDatasetJobResponse GetDatasetJobWithOptions(string DatasetId, string DatasetJobId, GetDatasetJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetVersion))
            {
                query["DatasetVersion"] = request.DatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatasetJob",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetJobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a dataset job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetJobResponse
        /// </returns>
        public async Task<GetDatasetJobResponse> GetDatasetJobWithOptionsAsync(string DatasetId, string DatasetJobId, GetDatasetJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetVersion))
            {
                query["DatasetVersion"] = request.DatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatasetJob",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetJobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a dataset job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetJobResponse
        /// </returns>
        public GetDatasetJobResponse GetDatasetJob(string DatasetId, string DatasetJobId, GetDatasetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDatasetJobWithOptions(DatasetId, DatasetJobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a dataset job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetJobResponse
        /// </returns>
        public async Task<GetDatasetJobResponse> GetDatasetJobAsync(string DatasetId, string DatasetJobId, GetDatasetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDatasetJobWithOptionsAsync(DatasetId, DatasetJobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a job configuration for a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetJobConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetJobConfigResponse
        /// </returns>
        public GetDatasetJobConfigResponse GetDatasetJobConfigWithOptions(string DatasetId, string DatasetJobConfigId, GetDatasetJobConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatasetJobConfig",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetjobconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetJobConfigId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetJobConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a job configuration for a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetJobConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetJobConfigResponse
        /// </returns>
        public async Task<GetDatasetJobConfigResponse> GetDatasetJobConfigWithOptionsAsync(string DatasetId, string DatasetJobConfigId, GetDatasetJobConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatasetJobConfig",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetjobconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetJobConfigId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetJobConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a job configuration for a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetJobConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetJobConfigResponse
        /// </returns>
        public GetDatasetJobConfigResponse GetDatasetJobConfig(string DatasetId, string DatasetJobConfigId, GetDatasetJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDatasetJobConfigWithOptions(DatasetId, DatasetJobConfigId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a job configuration for a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatasetJobConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDatasetJobConfigResponse
        /// </returns>
        public async Task<GetDatasetJobConfigResponse> GetDatasetJobConfigAsync(string DatasetId, string DatasetJobConfigId, GetDatasetJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDatasetJobConfigWithOptionsAsync(DatasetId, DatasetJobConfigId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information about a specified version of a dataset.</para>
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
        /// GetDatasetVersionResponse
        /// </returns>
        public GetDatasetVersionResponse GetDatasetVersionWithOptions(string DatasetId, string VersionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatasetVersion",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VersionName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information about a specified version of a dataset.</para>
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
        /// GetDatasetVersionResponse
        /// </returns>
        public async Task<GetDatasetVersionResponse> GetDatasetVersionWithOptionsAsync(string DatasetId, string VersionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatasetVersion",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VersionName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information about a specified version of a dataset.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDatasetVersionResponse
        /// </returns>
        public GetDatasetVersionResponse GetDatasetVersion(string DatasetId, string VersionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDatasetVersionWithOptions(DatasetId, VersionName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information about a specified version of a dataset.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDatasetVersionResponse
        /// </returns>
        public async Task<GetDatasetVersionResponse> GetDatasetVersionAsync(string DatasetId, string VersionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDatasetVersionWithOptionsAsync(DatasetId, VersionName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the default workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDefaultWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDefaultWorkspaceResponse
        /// </returns>
        public GetDefaultWorkspaceResponse GetDefaultWorkspaceWithOptions(GetDefaultWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDefaultWorkspace",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/defaultWorkspaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDefaultWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the default workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDefaultWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDefaultWorkspaceResponse
        /// </returns>
        public async Task<GetDefaultWorkspaceResponse> GetDefaultWorkspaceWithOptionsAsync(GetDefaultWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDefaultWorkspace",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/defaultWorkspaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDefaultWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the default workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDefaultWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDefaultWorkspaceResponse
        /// </returns>
        public GetDefaultWorkspaceResponse GetDefaultWorkspace(GetDefaultWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDefaultWorkspaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the default workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDefaultWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDefaultWorkspaceResponse
        /// </returns>
        public async Task<GetDefaultWorkspaceResponse> GetDefaultWorkspaceAsync(GetDefaultWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDefaultWorkspaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains an experiment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentResponse
        /// </returns>
        public GetExperimentResponse GetExperimentWithOptions(string ExperimentId, GetExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperiment",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains an experiment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentResponse
        /// </returns>
        public async Task<GetExperimentResponse> GetExperimentWithOptionsAsync(string ExperimentId, GetExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperiment",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains an experiment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentResponse
        /// </returns>
        public GetExperimentResponse GetExperiment(string ExperimentId, GetExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains an experiment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentResponse
        /// </returns>
        public async Task<GetExperimentResponse> GetExperimentAsync(string ExperimentId, GetExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information about an image.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImageResponse
        /// </returns>
        public GetImageResponse GetImageWithOptions(string ImageId, GetImageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImage",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/images/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ImageId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information about an image.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImageResponse
        /// </returns>
        public async Task<GetImageResponse> GetImageWithOptionsAsync(string ImageId, GetImageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImage",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/images/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ImageId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information about an image.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImageResponse
        /// </returns>
        public GetImageResponse GetImage(string ImageId, GetImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetImageWithOptions(ImageId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information about an image.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImageResponse
        /// </returns>
        public async Task<GetImageResponse> GetImageAsync(string ImageId, GetImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetImageWithOptionsAsync(ImageId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a member in a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemberRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemberResponse
        /// </returns>
        public GetMemberResponse GetMemberWithOptions(string WorkspaceId, GetMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMember",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/member",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a member in a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemberRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMemberResponse
        /// </returns>
        public async Task<GetMemberResponse> GetMemberWithOptionsAsync(string WorkspaceId, GetMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMember",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/member",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a member in a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMemberResponse
        /// </returns>
        public GetMemberResponse GetMember(string WorkspaceId, GetMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMemberWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a member in a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMemberResponse
        /// </returns>
        public async Task<GetMemberResponse> GetMemberAsync(string WorkspaceId, GetMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMemberWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a specified model.</para>
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
        /// GetModelResponse
        /// </returns>
        public GetModelResponse GetModelWithOptions(string ModelId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModel",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a specified model.</para>
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
        /// GetModelResponse
        /// </returns>
        public async Task<GetModelResponse> GetModelWithOptionsAsync(string ModelId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModel",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a specified model.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetModelResponse
        /// </returns>
        public GetModelResponse GetModel(string ModelId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetModelWithOptions(ModelId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a specified model.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetModelResponse
        /// </returns>
        public async Task<GetModelResponse> GetModelAsync(string ModelId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetModelWithOptionsAsync(ModelId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a model version.</para>
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
        /// GetModelVersionResponse
        /// </returns>
        public GetModelVersionResponse GetModelVersionWithOptions(string ModelId, string VersionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelVersion",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VersionName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a model version.</para>
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
        /// GetModelVersionResponse
        /// </returns>
        public async Task<GetModelVersionResponse> GetModelVersionWithOptionsAsync(string ModelId, string VersionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelVersion",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VersionName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a model version.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetModelVersionResponse
        /// </returns>
        public GetModelVersionResponse GetModelVersion(string ModelId, string VersionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetModelVersionWithOptions(ModelId, VersionName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a model version.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetModelVersionResponse
        /// </returns>
        public async Task<GetModelVersionResponse> GetModelVersionAsync(string ModelId, string VersionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetModelVersionWithOptionsAsync(ModelId, VersionName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains permissions on a workspace.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetPermissionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPermissionResponse
        /// </returns>
        public GetPermissionResponse GetPermissionWithOptions(string WorkspaceId, string PermissionCode, GetPermissionRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetPermissionShrinkRequest request = new GetPermissionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Labels))
            {
                request.LabelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Labels, "Labels", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                query["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["Creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelsShrink))
            {
                query["Labels"] = request.LabelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                query["Option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPermission",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/permissions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(PermissionCode),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPermissionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains permissions on a workspace.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetPermissionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPermissionResponse
        /// </returns>
        public async Task<GetPermissionResponse> GetPermissionWithOptionsAsync(string WorkspaceId, string PermissionCode, GetPermissionRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetPermissionShrinkRequest request = new GetPermissionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Labels))
            {
                request.LabelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Labels, "Labels", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                query["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["Creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelsShrink))
            {
                query["Labels"] = request.LabelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                query["Option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPermission",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/permissions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(PermissionCode),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains permissions on a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPermissionResponse
        /// </returns>
        public GetPermissionResponse GetPermission(string WorkspaceId, string PermissionCode, GetPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPermissionWithOptions(WorkspaceId, PermissionCode, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains permissions on a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPermissionResponse
        /// </returns>
        public async Task<GetPermissionResponse> GetPermissionAsync(string WorkspaceId, string PermissionCode, GetPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPermissionWithOptionsAsync(WorkspaceId, PermissionCode, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the run information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRunResponse
        /// </returns>
        public GetRunResponse GetRunWithOptions(string RunId, GetRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRun",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RunId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the run information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRunResponse
        /// </returns>
        public async Task<GetRunResponse> GetRunWithOptionsAsync(string RunId, GetRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRun",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RunId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the run information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRunRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRunResponse
        /// </returns>
        public GetRunResponse GetRun(string RunId, GetRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRunWithOptions(RunId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the run information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRunRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRunResponse
        /// </returns>
        public async Task<GetRunResponse> GetRunAsync(string RunId, GetRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRunWithOptionsAsync(RunId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public GetWorkspaceResponse GetWorkspaceWithOptions(string WorkspaceId, GetWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspace",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public async Task<GetWorkspaceResponse> GetWorkspaceWithOptionsAsync(string WorkspaceId, GetWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspace",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public GetWorkspaceResponse GetWorkspace(string WorkspaceId, GetWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetWorkspaceWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public async Task<GetWorkspaceResponse> GetWorkspaceAsync(string WorkspaceId, GetWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetWorkspaceWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists code sources. Pagination, sorting, and filtering by condition are supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCodeSourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCodeSourcesResponse
        /// </returns>
        public ListCodeSourcesResponse ListCodeSourcesWithOptions(ListCodeSourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCodeSources",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/codesources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCodeSourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists code sources. Pagination, sorting, and filtering by condition are supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCodeSourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCodeSourcesResponse
        /// </returns>
        public async Task<ListCodeSourcesResponse> ListCodeSourcesWithOptionsAsync(ListCodeSourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCodeSources",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/codesources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCodeSourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists code sources. Pagination, sorting, and filtering by condition are supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCodeSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCodeSourcesResponse
        /// </returns>
        public ListCodeSourcesResponse ListCodeSources(ListCodeSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCodeSourcesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists code sources. Pagination, sorting, and filtering by condition are supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCodeSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCodeSourcesResponse
        /// </returns>
        public async Task<ListCodeSourcesResponse> ListCodeSourcesAsync(ListCodeSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCodeSourcesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of workspace configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListConfigsResponse
        /// </returns>
        public ListConfigsResponse ListConfigsWithOptions(string WorkspaceId, ListConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                query["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKeys))
            {
                query["ConfigKeys"] = request.ConfigKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConfigs",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConfigsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of workspace configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListConfigsResponse
        /// </returns>
        public async Task<ListConfigsResponse> ListConfigsWithOptionsAsync(string WorkspaceId, ListConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                query["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKeys))
            {
                query["ConfigKeys"] = request.ConfigKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConfigs",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of workspace configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListConfigsResponse
        /// </returns>
        public ListConfigsResponse ListConfigs(string WorkspaceId, ListConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConfigsWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of workspace configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListConfigsResponse
        /// </returns>
        public async Task<ListConfigsResponse> ListConfigsAsync(string WorkspaceId, ListConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConfigsWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists connections.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListConnectionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListConnectionsResponse
        /// </returns>
        public ListConnectionsResponse ListConnectionsWithOptions(ListConnectionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListConnectionsShrinkRequest request = new ListConnectionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConnectionIds))
            {
                request.ConnectionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConnectionIds, "ConnectionIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConnectionTypes))
            {
                request.ConnectionTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConnectionTypes, "ConnectionTypes", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ModelTypes))
            {
                request.ModelTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ModelTypes, "ModelTypes", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionIdsShrink))
            {
                query["ConnectionIds"] = request.ConnectionIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionTypesShrink))
            {
                query["ConnectionTypes"] = request.ConnectionTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptOption))
            {
                query["EncryptOption"] = request.EncryptOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTypesShrink))
            {
                query["ModelTypes"] = request.ModelTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToolCall))
            {
                query["ToolCall"] = request.ToolCall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConnections",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/connections",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConnectionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists connections.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListConnectionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListConnectionsResponse
        /// </returns>
        public async Task<ListConnectionsResponse> ListConnectionsWithOptionsAsync(ListConnectionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListConnectionsShrinkRequest request = new ListConnectionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConnectionIds))
            {
                request.ConnectionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConnectionIds, "ConnectionIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConnectionTypes))
            {
                request.ConnectionTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConnectionTypes, "ConnectionTypes", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ModelTypes))
            {
                request.ModelTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ModelTypes, "ModelTypes", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionIdsShrink))
            {
                query["ConnectionIds"] = request.ConnectionIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionTypesShrink))
            {
                query["ConnectionTypes"] = request.ConnectionTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptOption))
            {
                query["EncryptOption"] = request.EncryptOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTypesShrink))
            {
                query["ModelTypes"] = request.ModelTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToolCall))
            {
                query["ToolCall"] = request.ToolCall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConnections",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/connections",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConnectionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConnectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListConnectionsResponse
        /// </returns>
        public ListConnectionsResponse ListConnections(ListConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConnectionsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConnectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListConnectionsResponse
        /// </returns>
        public async Task<ListConnectionsResponse> ListConnectionsAsync(ListConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConnectionsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of dataset files.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDatasetFileMetasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetFileMetasResponse
        /// </returns>
        public ListDatasetFileMetasResponse ListDatasetFileMetasWithOptions(string DatasetId, ListDatasetFileMetasRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDatasetFileMetasShrinkRequest request = new ListDatasetFileMetasShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryFileTypeIncludeAny))
            {
                request.QueryFileTypeIncludeAnyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryFileTypeIncludeAny, "QueryFileTypeIncludeAny", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryTagsExclude))
            {
                request.QueryTagsExcludeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryTagsExclude, "QueryTagsExclude", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryTagsIncludeAll))
            {
                request.QueryTagsIncludeAllShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryTagsIncludeAll, "QueryTagsIncludeAll", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryTagsIncludeAny))
            {
                request.QueryTagsIncludeAnyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryTagsIncludeAny, "QueryTagsIncludeAny", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetVersion))
            {
                query["DatasetVersion"] = request.DatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndFileUpdateTime))
            {
                query["EndFileUpdateTime"] = request.EndFileUpdateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTagUpdateTime))
            {
                query["EndTagUpdateTime"] = request.EndTagUpdateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryFileDir))
            {
                query["QueryFileDir"] = request.QueryFileDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryFileName))
            {
                query["QueryFileName"] = request.QueryFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryFileTypeIncludeAnyShrink))
            {
                query["QueryFileTypeIncludeAny"] = request.QueryFileTypeIncludeAnyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryImage))
            {
                query["QueryImage"] = request.QueryImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryTagsExcludeShrink))
            {
                query["QueryTagsExclude"] = request.QueryTagsExcludeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryTagsIncludeAllShrink))
            {
                query["QueryTagsIncludeAll"] = request.QueryTagsIncludeAllShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryTagsIncludeAnyShrink))
            {
                query["QueryTagsIncludeAny"] = request.QueryTagsIncludeAnyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryText))
            {
                query["QueryText"] = request.QueryText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScoreThreshold))
            {
                query["ScoreThreshold"] = request.ScoreThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartFileUpdateTime))
            {
                query["StartFileUpdateTime"] = request.StartFileUpdateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTagUpdateTime))
            {
                query["StartTagUpdateTime"] = request.StartTagUpdateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThumbnailMode))
            {
                query["ThumbnailMode"] = request.ThumbnailMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                query["TopK"] = request.TopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatasetFileMetas",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetfilemetas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasetFileMetasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of dataset files.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDatasetFileMetasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetFileMetasResponse
        /// </returns>
        public async Task<ListDatasetFileMetasResponse> ListDatasetFileMetasWithOptionsAsync(string DatasetId, ListDatasetFileMetasRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDatasetFileMetasShrinkRequest request = new ListDatasetFileMetasShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryFileTypeIncludeAny))
            {
                request.QueryFileTypeIncludeAnyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryFileTypeIncludeAny, "QueryFileTypeIncludeAny", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryTagsExclude))
            {
                request.QueryTagsExcludeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryTagsExclude, "QueryTagsExclude", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryTagsIncludeAll))
            {
                request.QueryTagsIncludeAllShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryTagsIncludeAll, "QueryTagsIncludeAll", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryTagsIncludeAny))
            {
                request.QueryTagsIncludeAnyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryTagsIncludeAny, "QueryTagsIncludeAny", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetVersion))
            {
                query["DatasetVersion"] = request.DatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndFileUpdateTime))
            {
                query["EndFileUpdateTime"] = request.EndFileUpdateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTagUpdateTime))
            {
                query["EndTagUpdateTime"] = request.EndTagUpdateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryFileDir))
            {
                query["QueryFileDir"] = request.QueryFileDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryFileName))
            {
                query["QueryFileName"] = request.QueryFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryFileTypeIncludeAnyShrink))
            {
                query["QueryFileTypeIncludeAny"] = request.QueryFileTypeIncludeAnyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryImage))
            {
                query["QueryImage"] = request.QueryImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryTagsExcludeShrink))
            {
                query["QueryTagsExclude"] = request.QueryTagsExcludeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryTagsIncludeAllShrink))
            {
                query["QueryTagsIncludeAll"] = request.QueryTagsIncludeAllShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryTagsIncludeAnyShrink))
            {
                query["QueryTagsIncludeAny"] = request.QueryTagsIncludeAnyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryText))
            {
                query["QueryText"] = request.QueryText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScoreThreshold))
            {
                query["ScoreThreshold"] = request.ScoreThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartFileUpdateTime))
            {
                query["StartFileUpdateTime"] = request.StartFileUpdateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTagUpdateTime))
            {
                query["StartTagUpdateTime"] = request.StartTagUpdateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThumbnailMode))
            {
                query["ThumbnailMode"] = request.ThumbnailMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                query["TopK"] = request.TopK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatasetFileMetas",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetfilemetas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasetFileMetasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of dataset files.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetFileMetasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetFileMetasResponse
        /// </returns>
        public ListDatasetFileMetasResponse ListDatasetFileMetas(string DatasetId, ListDatasetFileMetasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDatasetFileMetasWithOptions(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of dataset files.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetFileMetasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetFileMetasResponse
        /// </returns>
        public async Task<ListDatasetFileMetasResponse> ListDatasetFileMetasAsync(string DatasetId, ListDatasetFileMetasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDatasetFileMetasWithOptionsAsync(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the dataset job configurations at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetJobConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetJobConfigsResponse
        /// </returns>
        public ListDatasetJobConfigsResponse ListDatasetJobConfigsWithOptions(string DatasetId, ListDatasetJobConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigType))
            {
                query["ConfigType"] = request.ConfigType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatasetJobConfigs",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetjobconfigs/",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasetJobConfigsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the dataset job configurations at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetJobConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetJobConfigsResponse
        /// </returns>
        public async Task<ListDatasetJobConfigsResponse> ListDatasetJobConfigsWithOptionsAsync(string DatasetId, ListDatasetJobConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigType))
            {
                query["ConfigType"] = request.ConfigType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatasetJobConfigs",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetjobconfigs/",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasetJobConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the dataset job configurations at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetJobConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetJobConfigsResponse
        /// </returns>
        public ListDatasetJobConfigsResponse ListDatasetJobConfigs(string DatasetId, ListDatasetJobConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDatasetJobConfigsWithOptions(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the dataset job configurations at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetJobConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetJobConfigsResponse
        /// </returns>
        public async Task<ListDatasetJobConfigsResponse> ListDatasetJobConfigsAsync(string DatasetId, ListDatasetJobConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDatasetJobConfigsWithOptionsAsync(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists jobs in a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetJobsResponse
        /// </returns>
        public ListDatasetJobsResponse ListDatasetJobsWithOptions(string DatasetId, ListDatasetJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetVersion))
            {
                query["DatasetVersion"] = request.DatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobAction))
            {
                query["JobAction"] = request.JobAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatasetJobs",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetjobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasetJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists jobs in a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetJobsResponse
        /// </returns>
        public async Task<ListDatasetJobsResponse> ListDatasetJobsWithOptionsAsync(string DatasetId, ListDatasetJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetVersion))
            {
                query["DatasetVersion"] = request.DatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobAction))
            {
                query["JobAction"] = request.JobAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatasetJobs",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetjobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasetJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists jobs in a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetJobsResponse
        /// </returns>
        public ListDatasetJobsResponse ListDatasetJobs(string DatasetId, ListDatasetJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDatasetJobsWithOptions(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists jobs in a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetJobsResponse
        /// </returns>
        public async Task<ListDatasetJobsResponse> ListDatasetJobsAsync(string DatasetId, ListDatasetJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDatasetJobsWithOptionsAsync(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists dataset versions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetVersionsResponse
        /// </returns>
        public ListDatasetVersionsResponse ListDatasetVersionsWithOptions(string DatasetId, ListDatasetVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelKeys))
            {
                query["LabelKeys"] = request.LabelKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelValues))
            {
                query["LabelValues"] = request.LabelValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                query["Properties"] = request.Properties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTypes))
            {
                query["SourceTypes"] = request.SourceTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatasetVersions",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasetVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists dataset versions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetVersionsResponse
        /// </returns>
        public async Task<ListDatasetVersionsResponse> ListDatasetVersionsWithOptionsAsync(string DatasetId, ListDatasetVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelKeys))
            {
                query["LabelKeys"] = request.LabelKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelValues))
            {
                query["LabelValues"] = request.LabelValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                query["Properties"] = request.Properties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTypes))
            {
                query["SourceTypes"] = request.SourceTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatasetVersions",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasetVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists dataset versions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetVersionsResponse
        /// </returns>
        public ListDatasetVersionsResponse ListDatasetVersions(string DatasetId, ListDatasetVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDatasetVersionsWithOptions(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists dataset versions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetVersionsResponse
        /// </returns>
        public async Task<ListDatasetVersionsResponse> ListDatasetVersionsAsync(string DatasetId, ListDatasetVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDatasetVersionsWithOptionsAsync(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the datasets in a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetsResponse
        /// </returns>
        public ListDatasetsResponse ListDatasetsWithOptions(ListDatasetsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceTypes))
            {
                query["DataSourceTypes"] = request.DataSourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTypes))
            {
                query["DataTypes"] = request.DataTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                query["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                query["Properties"] = request.Properties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["Provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDatasetId))
            {
                query["SourceDatasetId"] = request.SourceDatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTypes))
            {
                query["SourceTypes"] = request.SourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatasets",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasetsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the datasets in a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetsResponse
        /// </returns>
        public async Task<ListDatasetsResponse> ListDatasetsWithOptionsAsync(ListDatasetsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceTypes))
            {
                query["DataSourceTypes"] = request.DataSourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTypes))
            {
                query["DataTypes"] = request.DataTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                query["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                query["Properties"] = request.Properties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["Provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDatasetId))
            {
                query["SourceDatasetId"] = request.SourceDatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTypes))
            {
                query["SourceTypes"] = request.SourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatasets",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the datasets in a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetsResponse
        /// </returns>
        public ListDatasetsResponse ListDatasets(ListDatasetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDatasetsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the datasets in a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatasetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDatasetsResponse
        /// </returns>
        public async Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDatasetsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists experiments.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExperimentResponse
        /// </returns>
        public ListExperimentResponse ListExperimentWithOptions(ListExperimentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListExperimentShrinkRequest request = new ListExperimentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Options))
            {
                request.OptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Options, "Options", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionsShrink))
            {
                query["Options"] = request.OptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["PageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExperiment",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists experiments.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExperimentResponse
        /// </returns>
        public async Task<ListExperimentResponse> ListExperimentWithOptionsAsync(ListExperimentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListExperimentShrinkRequest request = new ListExperimentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Options))
            {
                request.OptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Options, "Options", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionsShrink))
            {
                query["Options"] = request.OptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["PageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExperiment",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists experiments.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExperimentResponse
        /// </returns>
        public ListExperimentResponse ListExperiment(ListExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListExperimentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists experiments.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExperimentResponse
        /// </returns>
        public async Task<ListExperimentResponse> ListExperimentAsync(ListExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListExperimentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all tags of an image.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImageLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListImageLabelsResponse
        /// </returns>
        public ListImageLabelsResponse ListImageLabelsWithOptions(ListImageLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelFilter))
            {
                query["LabelFilter"] = request.LabelFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelKeys))
            {
                query["LabelKeys"] = request.LabelKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListImageLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/image/labels",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImageLabelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all tags of an image.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImageLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListImageLabelsResponse
        /// </returns>
        public async Task<ListImageLabelsResponse> ListImageLabelsWithOptionsAsync(ListImageLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelFilter))
            {
                query["LabelFilter"] = request.LabelFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelKeys))
            {
                query["LabelKeys"] = request.LabelKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListImageLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/image/labels",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImageLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all tags of an image.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImageLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListImageLabelsResponse
        /// </returns>
        public ListImageLabelsResponse ListImageLabels(ListImageLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListImageLabelsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all tags of an image.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImageLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListImageLabelsResponse
        /// </returns>
        public async Task<ListImageLabelsResponse> ListImageLabelsAsync(ListImageLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListImageLabelsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of images.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImagesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListImagesResponse
        /// </returns>
        public ListImagesResponse ListImagesWithOptions(ListImagesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                query["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListImages",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/images",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImagesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of images.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImagesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListImagesResponse
        /// </returns>
        public async Task<ListImagesResponse> ListImagesWithOptionsAsync(ListImagesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                query["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListImages",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/images",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of images.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListImagesResponse
        /// </returns>
        public ListImagesResponse ListImages(ListImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListImagesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of images.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListImagesResponse
        /// </returns>
        public async Task<ListImagesResponse> ListImagesAsync(ListImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListImagesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the members in a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMembersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMembersResponse
        /// </returns>
        public ListMembersResponse ListMembersWithOptions(string WorkspaceId, ListMembersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberName))
            {
                query["MemberName"] = request.MemberName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Roles))
            {
                query["Roles"] = request.Roles;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMembers",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMembersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the members in a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMembersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMembersResponse
        /// </returns>
        public async Task<ListMembersResponse> ListMembersWithOptionsAsync(string WorkspaceId, ListMembersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberName))
            {
                query["MemberName"] = request.MemberName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Roles))
            {
                query["Roles"] = request.Roles;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMembers",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the members in a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMembersResponse
        /// </returns>
        public ListMembersResponse ListMembers(string WorkspaceId, ListMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMembersWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the members in a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMembersResponse
        /// </returns>
        public async Task<ListMembersResponse> ListMembersAsync(string WorkspaceId, ListMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMembersWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of model versions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelVersionsResponse
        /// </returns>
        public ListModelVersionsResponse ListModelVersionsWithOptions(string ModelId, ListModelVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovalStatus))
            {
                query["ApprovalStatus"] = request.ApprovalStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormatType))
            {
                query["FormatType"] = request.FormatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrameworkType))
            {
                query["FrameworkType"] = request.FrameworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                query["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                query["VersionName"] = request.VersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelVersions",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of model versions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelVersionsResponse
        /// </returns>
        public async Task<ListModelVersionsResponse> ListModelVersionsWithOptionsAsync(string ModelId, ListModelVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovalStatus))
            {
                query["ApprovalStatus"] = request.ApprovalStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormatType))
            {
                query["FormatType"] = request.FormatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrameworkType))
            {
                query["FrameworkType"] = request.FrameworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                query["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                query["VersionName"] = request.VersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelVersions",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of model versions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelVersionsResponse
        /// </returns>
        public ListModelVersionsResponse ListModelVersions(string ModelId, ListModelVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListModelVersionsWithOptions(ModelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of model versions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelVersionsResponse
        /// </returns>
        public async Task<ListModelVersionsResponse> ListModelVersionsAsync(string ModelId, ListModelVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListModelVersionsWithOptionsAsync(ModelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of models.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListModelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelsResponse
        /// </returns>
        public ListModelsResponse ListModelsWithOptions(ListModelsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListModelsShrinkRequest request = new ListModelsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Collections))
            {
                query["Collections"] = request.Collections;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                query["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                query["ModelName"] = request.ModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["ModelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["Origin"] = request.Origin;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Task))
            {
                query["Task"] = request.Task;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of models.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListModelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelsResponse
        /// </returns>
        public async Task<ListModelsResponse> ListModelsWithOptionsAsync(ListModelsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListModelsShrinkRequest request = new ListModelsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Collections))
            {
                query["Collections"] = request.Collections;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                query["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                query["ModelName"] = request.ModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["ModelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["Origin"] = request.Origin;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Task))
            {
                query["Task"] = request.Task;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of models.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelsResponse
        /// </returns>
        public ListModelsResponse ListModels(ListModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListModelsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of models.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelsResponse
        /// </returns>
        public async Task<ListModelsResponse> ListModelsAsync(ListModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListModelsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the permissions that a user has in a workspace.</para>
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
        /// ListPermissionsResponse
        /// </returns>
        public ListPermissionsResponse ListPermissionsWithOptions(string WorkspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPermissions",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/permissions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPermissionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the permissions that a user has in a workspace.</para>
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
        /// ListPermissionsResponse
        /// </returns>
        public async Task<ListPermissionsResponse> ListPermissionsWithOptionsAsync(string WorkspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPermissions",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/permissions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the permissions that a user has in a workspace.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListPermissionsResponse
        /// </returns>
        public ListPermissionsResponse ListPermissions(string WorkspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPermissionsWithOptions(WorkspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the permissions that a user has in a workspace.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListPermissionsResponse
        /// </returns>
        public async Task<ListPermissionsResponse> ListPermissionsAsync(string WorkspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPermissionsWithOptionsAsync(WorkspaceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProductsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProductsResponse
        /// </returns>
        public ListProductsResponse ListProductsWithOptions(ListProductsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCodes))
            {
                query["ProductCodes"] = request.ProductCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCodes))
            {
                query["ServiceCodes"] = request.ServiceCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProducts",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/products",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProductsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProductsResponse
        /// </returns>
        public async Task<ListProductsResponse> ListProductsWithOptionsAsync(ListProductsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCodes))
            {
                query["ProductCodes"] = request.ProductCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCodes))
            {
                query["ServiceCodes"] = request.ServiceCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProducts",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/products",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProductsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProductsResponse
        /// </returns>
        public ListProductsResponse ListProducts(ListProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProductsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举产品</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProductsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProductsResponse
        /// </returns>
        public async Task<ListProductsResponse> ListProductsAsync(ListProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProductsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the list of quotas.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQuotasResponse
        /// </returns>
        public ListQuotasResponse ListQuotasWithOptions(ListQuotasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuotas",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the list of quotas.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQuotasResponse
        /// </returns>
        public async Task<ListQuotasResponse> ListQuotasWithOptionsAsync(ListQuotasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuotas",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the list of quotas.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQuotasResponse
        /// </returns>
        public ListQuotasResponse ListQuotas(ListQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListQuotasWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the list of quotas.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQuotasResponse
        /// </returns>
        public async Task<ListQuotasResponse> ListQuotasAsync(ListQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListQuotasWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resources that are associated with a workspace.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                query["Option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductTypes))
            {
                query["ProductTypes"] = request.ProductTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaIds))
            {
                query["QuotaIds"] = request.QuotaIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerboseFields))
            {
                query["VerboseFields"] = request.VerboseFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResources",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources",
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
        /// <para>Queries the resources that are associated with a workspace.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                query["Option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductTypes))
            {
                query["ProductTypes"] = request.ProductTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaIds))
            {
                query["QuotaIds"] = request.QuotaIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerboseFields))
            {
                query["VerboseFields"] = request.VerboseFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResources",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resources",
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
        /// <para>Queries the resources that are associated with a workspace.</para>
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
        /// <para>Queries the resources that are associated with a workspace.</para>
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
        /// <para>Lists the metrics for a run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRunMetricsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRunMetricsResponse
        /// </returns>
        public ListRunMetricsResponse ListRunMetricsWithOptions(string RunId, ListRunMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["PageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRunMetrics",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RunId) + "/metrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRunMetricsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the metrics for a run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRunMetricsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRunMetricsResponse
        /// </returns>
        public async Task<ListRunMetricsResponse> ListRunMetricsWithOptionsAsync(string RunId, ListRunMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["PageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRunMetrics",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RunId) + "/metrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRunMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the metrics for a run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRunMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRunMetricsResponse
        /// </returns>
        public ListRunMetricsResponse ListRunMetrics(string RunId, ListRunMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRunMetricsWithOptions(RunId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the metrics for a run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRunMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRunMetricsResponse
        /// </returns>
        public async Task<ListRunMetricsResponse> ListRunMetricsAsync(string RunId, ListRunMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRunMetricsWithOptionsAsync(RunId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of runs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRunsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRunsResponse
        /// </returns>
        public ListRunsResponse ListRunsWithOptions(ListRunsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentId))
            {
                query["ExperimentId"] = request.ExperimentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreateTime))
            {
                query["GmtCreateTime"] = request.GmtCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["PageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRuns",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/runs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRunsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of runs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRunsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRunsResponse
        /// </returns>
        public async Task<ListRunsResponse> ListRunsWithOptionsAsync(ListRunsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentId))
            {
                query["ExperimentId"] = request.ExperimentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreateTime))
            {
                query["GmtCreateTime"] = request.GmtCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["PageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRuns",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/runs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRunsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of runs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRunsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRunsResponse
        /// </returns>
        public ListRunsResponse ListRuns(ListRunsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRunsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of runs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRunsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRunsResponse
        /// </returns>
        public async Task<ListRunsResponse> ListRunsAsync(ListRunsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRunsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries user information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserConfigsResponse
        /// </returns>
        public ListUserConfigsResponse ListUserConfigsWithOptions(ListUserConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryNames))
            {
                query["CategoryNames"] = request.CategoryNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKeys))
            {
                query["ConfigKeys"] = request.ConfigKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserConfigs",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/userconfigs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserConfigsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries user information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserConfigsResponse
        /// </returns>
        public async Task<ListUserConfigsResponse> ListUserConfigsWithOptionsAsync(ListUserConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryNames))
            {
                query["CategoryNames"] = request.CategoryNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKeys))
            {
                query["ConfigKeys"] = request.ConfigKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserConfigs",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/userconfigs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries user information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserConfigsResponse
        /// </returns>
        public ListUserConfigsResponse ListUserConfigs(ListUserConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUserConfigsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries user information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserConfigsResponse
        /// </returns>
        public async Task<ListUserConfigsResponse> ListUserConfigsAsync(ListUserConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUserConfigsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the users who do not belong to a workspace. These users can be added to the workspace as members.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkspaceUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspaceUsersResponse
        /// </returns>
        public ListWorkspaceUsersResponse ListWorkspaceUsersWithOptions(string WorkspaceId, ListWorkspaceUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaceUsers",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspaceUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the users who do not belong to a workspace. These users can be added to the workspace as members.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkspaceUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspaceUsersResponse
        /// </returns>
        public async Task<ListWorkspaceUsersResponse> ListWorkspaceUsersWithOptionsAsync(string WorkspaceId, ListWorkspaceUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaceUsers",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspaceUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the users who do not belong to a workspace. These users can be added to the workspace as members.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkspaceUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspaceUsersResponse
        /// </returns>
        public ListWorkspaceUsersResponse ListWorkspaceUsers(string WorkspaceId, ListWorkspaceUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWorkspaceUsersWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the users who do not belong to a workspace. These users can be added to the workspace as members.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkspaceUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspaceUsersResponse
        /// </returns>
        public async Task<ListWorkspaceUsersResponse> ListWorkspaceUsersAsync(string WorkspaceId, ListWorkspaceUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWorkspaceUsersWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all workspaces in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use the option parameter to specify query options, so as to obtain different information about the workspaces.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public ListWorkspacesResponse ListWorkspacesWithOptions(ListWorkspacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                query["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleList))
            {
                query["ModuleList"] = request.ModuleList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                query["Option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["WorkspaceIds"] = request.WorkspaceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                query["WorkspaceName"] = request.WorkspaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaces",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all workspaces in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use the option parameter to specify query options, so as to obtain different information about the workspaces.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public async Task<ListWorkspacesResponse> ListWorkspacesWithOptionsAsync(ListWorkspacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                query["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleList))
            {
                query["ModuleList"] = request.ModuleList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                query["Option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["WorkspaceIds"] = request.WorkspaceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                query["WorkspaceName"] = request.WorkspaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaces",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all workspaces in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use the option parameter to specify query options, so as to obtain different information about the workspaces.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWorkspacesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all workspaces in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use the option parameter to specify query options, so as to obtain different information about the workspaces.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public async Task<ListWorkspacesResponse> ListWorkspacesAsync(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWorkspacesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Logs multiple metrics for a run at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LogRunMetricsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LogRunMetricsResponse
        /// </returns>
        public LogRunMetricsResponse LogRunMetricsWithOptions(string RunId, LogRunMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                body["Metrics"] = request.Metrics;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LogRunMetrics",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RunId) + "/metrics/action/log",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<LogRunMetricsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Logs multiple metrics for a run at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LogRunMetricsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LogRunMetricsResponse
        /// </returns>
        public async Task<LogRunMetricsResponse> LogRunMetricsWithOptionsAsync(string RunId, LogRunMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                body["Metrics"] = request.Metrics;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LogRunMetrics",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RunId) + "/metrics/action/log",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<LogRunMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Logs multiple metrics for a run at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LogRunMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// LogRunMetricsResponse
        /// </returns>
        public LogRunMetricsResponse LogRunMetrics(string RunId, LogRunMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return LogRunMetricsWithOptions(RunId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Logs multiple metrics for a run at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LogRunMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// LogRunMetricsResponse
        /// </returns>
        public async Task<LogRunMetricsResponse> LogRunMetricsAsync(string RunId, LogRunMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await LogRunMetricsWithOptionsAsync(RunId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a private code source to a workspace to make the code source publicly accessible.</para>
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
        /// PublishCodeSourceResponse
        /// </returns>
        public PublishCodeSourceResponse PublishCodeSourceWithOptions(string CodeSourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishCodeSource",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/codesources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CodeSourceId) + "/publish",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishCodeSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a private code source to a workspace to make the code source publicly accessible.</para>
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
        /// PublishCodeSourceResponse
        /// </returns>
        public async Task<PublishCodeSourceResponse> PublishCodeSourceWithOptionsAsync(string CodeSourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishCodeSource",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/codesources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CodeSourceId) + "/publish",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishCodeSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a private code source to a workspace to make the code source publicly accessible.</para>
        /// </summary>
        /// 
        /// <returns>
        /// PublishCodeSourceResponse
        /// </returns>
        public PublishCodeSourceResponse PublishCodeSource(string CodeSourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishCodeSourceWithOptions(CodeSourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a private code source to a workspace to make the code source publicly accessible.</para>
        /// </summary>
        /// 
        /// <returns>
        /// PublishCodeSourceResponse
        /// </returns>
        public async Task<PublishCodeSourceResponse> PublishCodeSourceAsync(string CodeSourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishCodeSourceWithOptionsAsync(CodeSourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a private dataset in a workspace.</para>
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
        /// PublishDatasetResponse
        /// </returns>
        public PublishDatasetResponse PublishDatasetWithOptions(string DatasetId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishDataset",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/publish",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishDatasetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a private dataset in a workspace.</para>
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
        /// PublishDatasetResponse
        /// </returns>
        public async Task<PublishDatasetResponse> PublishDatasetWithOptionsAsync(string DatasetId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishDataset",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/publish",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a private dataset in a workspace.</para>
        /// </summary>
        /// 
        /// <returns>
        /// PublishDatasetResponse
        /// </returns>
        public PublishDatasetResponse PublishDataset(string DatasetId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishDatasetWithOptions(DatasetId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a private dataset in a workspace.</para>
        /// </summary>
        /// 
        /// <returns>
        /// PublishDatasetResponse
        /// </returns>
        public async Task<PublishDatasetResponse> PublishDatasetAsync(string DatasetId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishDatasetWithOptionsAsync(DatasetId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes an image. After the image is published, the visibility of the image is changed from PRIVATE to PUBLIC.</para>
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
        /// PublishImageResponse
        /// </returns>
        public PublishImageResponse PublishImageWithOptions(string ImageId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishImage",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/images/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ImageId) + "/publish",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes an image. After the image is published, the visibility of the image is changed from PRIVATE to PUBLIC.</para>
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
        /// PublishImageResponse
        /// </returns>
        public async Task<PublishImageResponse> PublishImageWithOptionsAsync(string ImageId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishImage",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/images/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ImageId) + "/publish",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes an image. After the image is published, the visibility of the image is changed from PRIVATE to PUBLIC.</para>
        /// </summary>
        /// 
        /// <returns>
        /// PublishImageResponse
        /// </returns>
        public PublishImageResponse PublishImage(string ImageId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishImageWithOptions(ImageId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes an image. After the image is published, the visibility of the image is changed from PRIVATE to PUBLIC.</para>
        /// </summary>
        /// 
        /// <returns>
        /// PublishImageResponse
        /// </returns>
        public async Task<PublishImageResponse> PublishImageAsync(string ImageId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishImageWithOptionsAsync(ImageId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an image.</para>
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
        /// RemoveImageResponse
        /// </returns>
        public RemoveImageResponse RemoveImageWithOptions(string ImageId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveImage",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/images/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ImageId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an image.</para>
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
        /// RemoveImageResponse
        /// </returns>
        public async Task<RemoveImageResponse> RemoveImageWithOptionsAsync(string ImageId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveImage",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/images/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ImageId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an image.</para>
        /// </summary>
        /// 
        /// <returns>
        /// RemoveImageResponse
        /// </returns>
        public RemoveImageResponse RemoveImage(string ImageId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveImageWithOptions(ImageId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an image.</para>
        /// </summary>
        /// 
        /// <returns>
        /// RemoveImageResponse
        /// </returns>
        public async Task<RemoveImageResponse> RemoveImageAsync(string ImageId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveImageWithOptionsAsync(ImageId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an image tag.</para>
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
        /// RemoveImageLabelsResponse
        /// </returns>
        public RemoveImageLabelsResponse RemoveImageLabelsWithOptions(string ImageId, string LabelKey, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveImageLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/images/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ImageId) + "/labels/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LabelKey),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveImageLabelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an image tag.</para>
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
        /// RemoveImageLabelsResponse
        /// </returns>
        public async Task<RemoveImageLabelsResponse> RemoveImageLabelsWithOptionsAsync(string ImageId, string LabelKey, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveImageLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/images/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ImageId) + "/labels/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LabelKey),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveImageLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an image tag.</para>
        /// </summary>
        /// 
        /// <returns>
        /// RemoveImageLabelsResponse
        /// </returns>
        public RemoveImageLabelsResponse RemoveImageLabels(string ImageId, string LabelKey)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveImageLabelsWithOptions(ImageId, LabelKey, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an image tag.</para>
        /// </summary>
        /// 
        /// <returns>
        /// RemoveImageLabelsResponse
        /// </returns>
        public async Task<RemoveImageLabelsResponse> RemoveImageLabelsAsync(string ImageId, string LabelKey)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveImageLabelsWithOptionsAsync(ImageId, LabelKey, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a member role.</para>
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
        /// RemoveMemberRoleResponse
        /// </returns>
        public RemoveMemberRoleResponse RemoveMemberRoleWithOptions(string WorkspaceId, string MemberId, string RoleName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveMemberRole",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MemberId) + "/roles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RoleName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveMemberRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a member role.</para>
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
        /// RemoveMemberRoleResponse
        /// </returns>
        public async Task<RemoveMemberRoleResponse> RemoveMemberRoleWithOptionsAsync(string WorkspaceId, string MemberId, string RoleName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveMemberRole",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MemberId) + "/roles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RoleName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveMemberRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a member role.</para>
        /// </summary>
        /// 
        /// <returns>
        /// RemoveMemberRoleResponse
        /// </returns>
        public RemoveMemberRoleResponse RemoveMemberRole(string WorkspaceId, string MemberId, string RoleName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveMemberRoleWithOptions(WorkspaceId, MemberId, RoleName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a member role.</para>
        /// </summary>
        /// 
        /// <returns>
        /// RemoveMemberRoleResponse
        /// </returns>
        public async Task<RemoveMemberRoleResponse> RemoveMemberRoleAsync(string WorkspaceId, string MemberId, string RoleName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveMemberRoleWithOptionsAsync(WorkspaceId, MemberId, RoleName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a experiment tag.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetExperimentLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetExperimentLabelsResponse
        /// </returns>
        public SetExperimentLabelsResponse SetExperimentLabelsWithOptions(string ExperimentId, SetExperimentLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetExperimentLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/labels",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetExperimentLabelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a experiment tag.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetExperimentLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetExperimentLabelsResponse
        /// </returns>
        public async Task<SetExperimentLabelsResponse> SetExperimentLabelsWithOptionsAsync(string ExperimentId, SetExperimentLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetExperimentLabels",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/labels",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetExperimentLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a experiment tag.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetExperimentLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// SetExperimentLabelsResponse
        /// </returns>
        public SetExperimentLabelsResponse SetExperimentLabels(string ExperimentId, SetExperimentLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SetExperimentLabelsWithOptions(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a experiment tag.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetExperimentLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// SetExperimentLabelsResponse
        /// </returns>
        public async Task<SetExperimentLabelsResponse> SetExperimentLabelsAsync(string ExperimentId, SetExperimentLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SetExperimentLabelsWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the user configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetUserConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetUserConfigsResponse
        /// </returns>
        public SetUserConfigsResponse SetUserConfigsWithOptions(SetUserConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configs))
            {
                body["Configs"] = request.Configs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetUserConfigs",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/userconfigs",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetUserConfigsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the user configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetUserConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetUserConfigsResponse
        /// </returns>
        public async Task<SetUserConfigsResponse> SetUserConfigsWithOptionsAsync(SetUserConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configs))
            {
                body["Configs"] = request.Configs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetUserConfigs",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/userconfigs",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetUserConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the user configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetUserConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// SetUserConfigsResponse
        /// </returns>
        public SetUserConfigsResponse SetUserConfigs(SetUserConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SetUserConfigsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the user configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetUserConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// SetUserConfigsResponse
        /// </returns>
        public async Task<SetUserConfigsResponse> SetUserConfigsAsync(SetUserConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SetUserConfigsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a dataset job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopDatasetJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopDatasetJobResponse
        /// </returns>
        public StopDatasetJobResponse StopDatasetJobWithOptions(string DatasetId, string DatasetJobId, StopDatasetJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetVersion))
            {
                body["DatasetVersion"] = request.DatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDatasetJob",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetJobId) + "/action/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDatasetJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a dataset job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopDatasetJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopDatasetJobResponse
        /// </returns>
        public async Task<StopDatasetJobResponse> StopDatasetJobWithOptionsAsync(string DatasetId, string DatasetJobId, StopDatasetJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetVersion))
            {
                body["DatasetVersion"] = request.DatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDatasetJob",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetJobId) + "/action/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDatasetJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a dataset job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopDatasetJobRequest
        /// </param>
        /// 
        /// <returns>
        /// StopDatasetJobResponse
        /// </returns>
        public StopDatasetJobResponse StopDatasetJob(string DatasetId, string DatasetJobId, StopDatasetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopDatasetJobWithOptions(DatasetId, DatasetJobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a dataset job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopDatasetJobRequest
        /// </param>
        /// 
        /// <returns>
        /// StopDatasetJobResponse
        /// </returns>
        public async Task<StopDatasetJobResponse> StopDatasetJobAsync(string DatasetId, string DatasetJobId, StopDatasetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopDatasetJobWithOptionsAsync(DatasetId, DatasetJobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a code build.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCodeSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCodeSourceResponse
        /// </returns>
        public UpdateCodeSourceResponse UpdateCodeSourceWithOptions(string CodeSourceId, UpdateCodeSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeBranch))
            {
                body["CodeBranch"] = request.CodeBranch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeCommit))
            {
                body["CodeCommit"] = request.CodeCommit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepo))
            {
                body["CodeRepo"] = request.CodeRepo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepoAccessToken))
            {
                body["CodeRepoAccessToken"] = request.CodeRepoAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepoUserName))
            {
                body["CodeRepoUserName"] = request.CodeRepoUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountPath))
            {
                body["MountPath"] = request.MountPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCodeSource",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/codesources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CodeSourceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCodeSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a code build.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCodeSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCodeSourceResponse
        /// </returns>
        public async Task<UpdateCodeSourceResponse> UpdateCodeSourceWithOptionsAsync(string CodeSourceId, UpdateCodeSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeBranch))
            {
                body["CodeBranch"] = request.CodeBranch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeCommit))
            {
                body["CodeCommit"] = request.CodeCommit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepo))
            {
                body["CodeRepo"] = request.CodeRepo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepoAccessToken))
            {
                body["CodeRepoAccessToken"] = request.CodeRepoAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepoUserName))
            {
                body["CodeRepoUserName"] = request.CodeRepoUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountPath))
            {
                body["MountPath"] = request.MountPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCodeSource",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/codesources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CodeSourceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCodeSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a code build.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCodeSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCodeSourceResponse
        /// </returns>
        public UpdateCodeSourceResponse UpdateCodeSource(string CodeSourceId, UpdateCodeSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateCodeSourceWithOptions(CodeSourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a code build.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCodeSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCodeSourceResponse
        /// </returns>
        public async Task<UpdateCodeSourceResponse> UpdateCodeSourceAsync(string CodeSourceId, UpdateCodeSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateCodeSourceWithOptionsAsync(CodeSourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates or adds a workspace configuration item.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateConfigResponse
        /// </returns>
        public UpdateConfigResponse UpdateConfigWithOptions(string WorkspaceId, UpdateConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                body["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKey))
            {
                body["ConfigKey"] = request.ConfigKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigValue))
            {
                body["ConfigValue"] = request.ConfigValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConfig",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/config",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates or adds a workspace configuration item.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateConfigResponse
        /// </returns>
        public async Task<UpdateConfigResponse> UpdateConfigWithOptionsAsync(string WorkspaceId, UpdateConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                body["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKey))
            {
                body["ConfigKey"] = request.ConfigKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigValue))
            {
                body["ConfigValue"] = request.ConfigValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConfig",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/config",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates or adds a workspace configuration item.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateConfigResponse
        /// </returns>
        public UpdateConfigResponse UpdateConfig(string WorkspaceId, UpdateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateConfigWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates or adds a workspace configuration item.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateConfigResponse
        /// </returns>
        public async Task<UpdateConfigResponse> UpdateConfigAsync(string WorkspaceId, UpdateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateConfigWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates or adds workspace configurations in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateConfigsResponse
        /// </returns>
        public UpdateConfigsResponse UpdateConfigsWithOptions(string WorkspaceId, UpdateConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configs))
            {
                body["Configs"] = request.Configs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConfigs",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/configs",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConfigsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates or adds workspace configurations in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateConfigsResponse
        /// </returns>
        public async Task<UpdateConfigsResponse> UpdateConfigsWithOptionsAsync(string WorkspaceId, UpdateConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configs))
            {
                body["Configs"] = request.Configs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConfigs",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/configs",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates or adds workspace configurations in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateConfigsResponse
        /// </returns>
        public UpdateConfigsResponse UpdateConfigs(string WorkspaceId, UpdateConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateConfigsWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates or adds workspace configurations in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateConfigsResponse
        /// </returns>
        public async Task<UpdateConfigsResponse> UpdateConfigsAsync(string WorkspaceId, UpdateConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateConfigsWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a connection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateConnectionResponse
        /// </returns>
        public UpdateConnectionResponse UpdateConnectionWithOptions(string ConnectionId, UpdateConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configs))
            {
                body["Configs"] = request.Configs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Models))
            {
                body["Models"] = request.Models;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Secrets))
            {
                body["Secrets"] = request.Secrets;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConnection",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ConnectionId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a connection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateConnectionResponse
        /// </returns>
        public async Task<UpdateConnectionResponse> UpdateConnectionWithOptionsAsync(string ConnectionId, UpdateConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configs))
            {
                body["Configs"] = request.Configs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Models))
            {
                body["Models"] = request.Models;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Secrets))
            {
                body["Secrets"] = request.Secrets;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConnection",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ConnectionId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a connection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateConnectionResponse
        /// </returns>
        public UpdateConnectionResponse UpdateConnection(string ConnectionId, UpdateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateConnectionWithOptions(ConnectionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a connection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateConnectionResponse
        /// </returns>
        public async Task<UpdateConnectionResponse> UpdateConnectionAsync(string ConnectionId, UpdateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateConnectionWithOptionsAsync(ConnectionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the name, description, and other information about a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetResponse
        /// </returns>
        public UpdateDatasetResponse UpdateDatasetWithOptions(string DatasetId, UpdateDatasetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountAccessReadWriteRoleIdList))
            {
                body["MountAccessReadWriteRoleIdList"] = request.MountAccessReadWriteRoleIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataset",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatasetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the name, description, and other information about a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetResponse
        /// </returns>
        public async Task<UpdateDatasetResponse> UpdateDatasetWithOptionsAsync(string DatasetId, UpdateDatasetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountAccessReadWriteRoleIdList))
            {
                body["MountAccessReadWriteRoleIdList"] = request.MountAccessReadWriteRoleIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataset",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the name, description, and other information about a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetResponse
        /// </returns>
        public UpdateDatasetResponse UpdateDataset(string DatasetId, UpdateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDatasetWithOptions(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the name, description, and other information about a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetResponse
        /// </returns>
        public async Task<UpdateDatasetResponse> UpdateDatasetAsync(string DatasetId, UpdateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDatasetWithOptionsAsync(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the metadata records of multiple files in a dataset at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetFileMetasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetFileMetasResponse
        /// </returns>
        public UpdateDatasetFileMetasResponse UpdateDatasetFileMetasWithOptions(string DatasetId, UpdateDatasetFileMetasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetFileMetas))
            {
                body["DatasetFileMetas"] = request.DatasetFileMetas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetVersion))
            {
                body["DatasetVersion"] = request.DatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagJobId))
            {
                body["TagJobId"] = request.TagJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDatasetFileMetas",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetfilemetas",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatasetFileMetasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the metadata records of multiple files in a dataset at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetFileMetasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetFileMetasResponse
        /// </returns>
        public async Task<UpdateDatasetFileMetasResponse> UpdateDatasetFileMetasWithOptionsAsync(string DatasetId, UpdateDatasetFileMetasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetFileMetas))
            {
                body["DatasetFileMetas"] = request.DatasetFileMetas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetVersion))
            {
                body["DatasetVersion"] = request.DatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagJobId))
            {
                body["TagJobId"] = request.TagJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDatasetFileMetas",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetfilemetas",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatasetFileMetasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the metadata records of multiple files in a dataset at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetFileMetasRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetFileMetasResponse
        /// </returns>
        public UpdateDatasetFileMetasResponse UpdateDatasetFileMetas(string DatasetId, UpdateDatasetFileMetasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDatasetFileMetasWithOptions(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the metadata records of multiple files in a dataset at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetFileMetasRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetFileMetasResponse
        /// </returns>
        public async Task<UpdateDatasetFileMetasResponse> UpdateDatasetFileMetasAsync(string DatasetId, UpdateDatasetFileMetasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDatasetFileMetasWithOptionsAsync(DatasetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a dataset job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetJobResponse
        /// </returns>
        public UpdateDatasetJobResponse UpdateDatasetJobWithOptions(string DatasetId, string DatasetJobId, UpdateDatasetJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetVersion))
            {
                body["DatasetVersion"] = request.DatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDatasetJob",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetJobId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatasetJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a dataset job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetJobResponse
        /// </returns>
        public async Task<UpdateDatasetJobResponse> UpdateDatasetJobWithOptionsAsync(string DatasetId, string DatasetJobId, UpdateDatasetJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetVersion))
            {
                body["DatasetVersion"] = request.DatasetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDatasetJob",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetJobId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatasetJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a dataset job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetJobRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetJobResponse
        /// </returns>
        public UpdateDatasetJobResponse UpdateDatasetJob(string DatasetId, string DatasetJobId, UpdateDatasetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDatasetJobWithOptions(DatasetId, DatasetJobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a dataset job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetJobRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetJobResponse
        /// </returns>
        public async Task<UpdateDatasetJobResponse> UpdateDatasetJobAsync(string DatasetId, string DatasetJobId, UpdateDatasetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDatasetJobWithOptionsAsync(DatasetId, DatasetJobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a job configuration for a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetJobConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetJobConfigResponse
        /// </returns>
        public UpdateDatasetJobConfigResponse UpdateDatasetJobConfigWithOptions(string DatasetId, string DatasetJobConfigId, UpdateDatasetJobConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigType))
            {
                body["ConfigType"] = request.ConfigType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDatasetJobConfig",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetjobconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetJobConfigId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatasetJobConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a job configuration for a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetJobConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetJobConfigResponse
        /// </returns>
        public async Task<UpdateDatasetJobConfigResponse> UpdateDatasetJobConfigWithOptionsAsync(string DatasetId, string DatasetJobConfigId, UpdateDatasetJobConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigType))
            {
                body["ConfigType"] = request.ConfigType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDatasetJobConfig",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/datasetjobconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetJobConfigId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatasetJobConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a job configuration for a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetJobConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetJobConfigResponse
        /// </returns>
        public UpdateDatasetJobConfigResponse UpdateDatasetJobConfig(string DatasetId, string DatasetJobConfigId, UpdateDatasetJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDatasetJobConfigWithOptions(DatasetId, DatasetJobConfigId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a job configuration for a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetJobConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetJobConfigResponse
        /// </returns>
        public async Task<UpdateDatasetJobConfigResponse> UpdateDatasetJobConfigAsync(string DatasetId, string DatasetJobConfigId, UpdateDatasetJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDatasetJobConfigWithOptionsAsync(DatasetId, DatasetJobConfigId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a specified version of a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetVersionResponse
        /// </returns>
        public UpdateDatasetVersionResponse UpdateDatasetVersionWithOptions(string DatasetId, string VersionName, UpdateDatasetVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCount))
            {
                body["DataCount"] = request.DataCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSize))
            {
                body["DataSize"] = request.DataSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDatasetVersion",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VersionName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatasetVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a specified version of a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetVersionResponse
        /// </returns>
        public async Task<UpdateDatasetVersionResponse> UpdateDatasetVersionWithOptionsAsync(string DatasetId, string VersionName, UpdateDatasetVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCount))
            {
                body["DataCount"] = request.DataCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSize))
            {
                body["DataSize"] = request.DataSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDatasetVersion",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DatasetId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VersionName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatasetVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a specified version of a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetVersionResponse
        /// </returns>
        public UpdateDatasetVersionResponse UpdateDatasetVersion(string DatasetId, string VersionName, UpdateDatasetVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDatasetVersionWithOptions(DatasetId, VersionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a specified version of a dataset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDatasetVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDatasetVersionResponse
        /// </returns>
        public async Task<UpdateDatasetVersionResponse> UpdateDatasetVersionAsync(string DatasetId, string VersionName, UpdateDatasetVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDatasetVersionWithOptionsAsync(DatasetId, VersionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Specifies a workspace as the default workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDefaultWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDefaultWorkspaceResponse
        /// </returns>
        public UpdateDefaultWorkspaceResponse UpdateDefaultWorkspaceWithOptions(UpdateDefaultWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDefaultWorkspace",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/defaultWorkspaces",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDefaultWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Specifies a workspace as the default workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDefaultWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDefaultWorkspaceResponse
        /// </returns>
        public async Task<UpdateDefaultWorkspaceResponse> UpdateDefaultWorkspaceWithOptionsAsync(UpdateDefaultWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDefaultWorkspace",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/defaultWorkspaces",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDefaultWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Specifies a workspace as the default workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDefaultWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDefaultWorkspaceResponse
        /// </returns>
        public UpdateDefaultWorkspaceResponse UpdateDefaultWorkspace(UpdateDefaultWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDefaultWorkspaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Specifies a workspace as the default workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDefaultWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDefaultWorkspaceResponse
        /// </returns>
        public async Task<UpdateDefaultWorkspaceResponse> UpdateDefaultWorkspaceAsync(UpdateDefaultWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDefaultWorkspaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an experiment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentResponse
        /// </returns>
        public UpdateExperimentResponse UpdateExperimentWithOptions(string ExperimentId, UpdateExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExperiment",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an experiment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentResponse
        /// </returns>
        public async Task<UpdateExperimentResponse> UpdateExperimentWithOptionsAsync(string ExperimentId, UpdateExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExperiment",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an experiment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentResponse
        /// </returns>
        public UpdateExperimentResponse UpdateExperiment(string ExperimentId, UpdateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an experiment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentResponse
        /// </returns>
        public async Task<UpdateExperimentResponse> UpdateExperimentAsync(string ExperimentId, UpdateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the basic configuration information about a model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelResponse
        /// </returns>
        public UpdateModelResponse UpdateModelWithOptions(string ModelId, UpdateModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["ExtraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelDescription))
            {
                body["ModelDescription"] = request.ModelDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelDoc))
            {
                body["ModelDoc"] = request.ModelDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                body["ModelName"] = request.ModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                body["ModelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNumber))
            {
                body["OrderNumber"] = request.OrderNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                body["Origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Task))
            {
                body["Task"] = request.Task;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModel",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the basic configuration information about a model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelResponse
        /// </returns>
        public async Task<UpdateModelResponse> UpdateModelWithOptionsAsync(string ModelId, UpdateModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["ExtraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelDescription))
            {
                body["ModelDescription"] = request.ModelDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelDoc))
            {
                body["ModelDoc"] = request.ModelDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                body["ModelName"] = request.ModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                body["ModelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNumber))
            {
                body["OrderNumber"] = request.OrderNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                body["Origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Task))
            {
                body["Task"] = request.Task;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModel",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the basic configuration information about a model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelResponse
        /// </returns>
        public UpdateModelResponse UpdateModel(string ModelId, UpdateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateModelWithOptions(ModelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the basic configuration information about a model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelResponse
        /// </returns>
        public async Task<UpdateModelResponse> UpdateModelAsync(string ModelId, UpdateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateModelWithOptionsAsync(ModelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a model version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModelVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelVersionResponse
        /// </returns>
        public UpdateModelVersionResponse UpdateModelVersionWithOptions(string ModelId, string VersionName, UpdateModelVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovalStatus))
            {
                body["ApprovalStatus"] = request.ApprovalStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompressionSpec))
            {
                body["CompressionSpec"] = request.CompressionSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationSpec))
            {
                body["EvaluationSpec"] = request.EvaluationSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["ExtraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InferenceSpec))
            {
                body["InferenceSpec"] = request.InferenceSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                body["Metrics"] = request.Metrics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainingSpec))
            {
                body["TrainingSpec"] = request.TrainingSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionDescription))
            {
                body["VersionDescription"] = request.VersionDescription;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModelVersion",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VersionName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a model version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModelVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelVersionResponse
        /// </returns>
        public async Task<UpdateModelVersionResponse> UpdateModelVersionWithOptionsAsync(string ModelId, string VersionName, UpdateModelVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovalStatus))
            {
                body["ApprovalStatus"] = request.ApprovalStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompressionSpec))
            {
                body["CompressionSpec"] = request.CompressionSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationSpec))
            {
                body["EvaluationSpec"] = request.EvaluationSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["ExtraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InferenceSpec))
            {
                body["InferenceSpec"] = request.InferenceSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                body["Metrics"] = request.Metrics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrainingSpec))
            {
                body["TrainingSpec"] = request.TrainingSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionDescription))
            {
                body["VersionDescription"] = request.VersionDescription;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModelVersion",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VersionName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModelVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a model version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModelVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelVersionResponse
        /// </returns>
        public UpdateModelVersionResponse UpdateModelVersion(string ModelId, string VersionName, UpdateModelVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateModelVersionWithOptions(ModelId, VersionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a model version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModelVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModelVersionResponse
        /// </returns>
        public async Task<UpdateModelVersionResponse> UpdateModelVersionAsync(string ModelId, string VersionName, UpdateModelVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateModelVersionWithOptionsAsync(ModelId, VersionName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the run information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRunResponse
        /// </returns>
        public UpdateRunResponse UpdateRunWithOptions(string RunId, UpdateRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRun",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RunId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the run information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRunResponse
        /// </returns>
        public async Task<UpdateRunResponse> UpdateRunWithOptionsAsync(string RunId, UpdateRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRun",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RunId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the run information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRunRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRunResponse
        /// </returns>
        public UpdateRunResponse UpdateRun(string RunId, UpdateRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateRunWithOptions(RunId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the run information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRunRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRunResponse
        /// </returns>
        public async Task<UpdateRunResponse> UpdateRunAsync(string RunId, UpdateRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateRunWithOptionsAsync(RunId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the name and description of a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResponse
        /// </returns>
        public UpdateWorkspaceResponse UpdateWorkspaceWithOptions(string WorkspaceId, UpdateWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspace",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the name and description of a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResponse
        /// </returns>
        public async Task<UpdateWorkspaceResponse> UpdateWorkspaceWithOptionsAsync(string WorkspaceId, UpdateWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspace",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the name and description of a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResponse
        /// </returns>
        public UpdateWorkspaceResponse UpdateWorkspace(string WorkspaceId, UpdateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateWorkspaceWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the name and description of a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResponse
        /// </returns>
        public async Task<UpdateWorkspaceResponse> UpdateWorkspaceAsync(string WorkspaceId, UpdateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateWorkspaceWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the resources of a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResourceResponse
        /// </returns>
        public UpdateWorkspaceResourceResponse UpdateWorkspaceResourceWithOptions(string WorkspaceId, UpdateWorkspaceResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDefault))
            {
                body["IsDefault"] = request.IsDefault;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spec))
            {
                body["Spec"] = request.Spec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspaceResource",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/resources",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkspaceResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the resources of a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResourceResponse
        /// </returns>
        public async Task<UpdateWorkspaceResourceResponse> UpdateWorkspaceResourceWithOptionsAsync(string WorkspaceId, UpdateWorkspaceResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDefault))
            {
                body["IsDefault"] = request.IsDefault;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spec))
            {
                body["Spec"] = request.Spec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspaceResource",
                Version = "2021-02-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/resources",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkspaceResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the resources of a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResourceResponse
        /// </returns>
        public UpdateWorkspaceResourceResponse UpdateWorkspaceResource(string WorkspaceId, UpdateWorkspaceResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateWorkspaceResourceWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the resources of a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResourceResponse
        /// </returns>
        public async Task<UpdateWorkspaceResourceResponse> UpdateWorkspaceResourceAsync(string WorkspaceId, UpdateWorkspaceResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateWorkspaceResourceWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

    }
}
