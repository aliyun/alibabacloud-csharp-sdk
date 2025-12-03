// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.DFS20180620.Models;

namespace AlibabaCloud.SDK.DFS20180620
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("dfs", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>挂载VSC挂载点</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <hr>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// AttachVscMountPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachVscMountPointResponse
        /// </returns>
        public AttachVscMountPointResponse AttachVscMountPointWithOptions(AttachVscMountPointRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AttachVscMountPointShrinkRequest request = new AttachVscMountPointShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VscIds))
            {
                request.VscIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VscIds, "VscIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountPointId))
            {
                query["MountPointId"] = request.MountPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAssumeRoleChkServerPerm))
            {
                query["UseAssumeRoleChkServerPerm"] = request.UseAssumeRoleChkServerPerm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VscIdsShrink))
            {
                query["VscIds"] = request.VscIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VscName))
            {
                query["VscName"] = request.VscName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VscType))
            {
                query["VscType"] = request.VscType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachVscMountPoint",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachVscMountPointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>挂载VSC挂载点</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <hr>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// AttachVscMountPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachVscMountPointResponse
        /// </returns>
        public async Task<AttachVscMountPointResponse> AttachVscMountPointWithOptionsAsync(AttachVscMountPointRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AttachVscMountPointShrinkRequest request = new AttachVscMountPointShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VscIds))
            {
                request.VscIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VscIds, "VscIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountPointId))
            {
                query["MountPointId"] = request.MountPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAssumeRoleChkServerPerm))
            {
                query["UseAssumeRoleChkServerPerm"] = request.UseAssumeRoleChkServerPerm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VscIdsShrink))
            {
                query["VscIds"] = request.VscIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VscName))
            {
                query["VscName"] = request.VscName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VscType))
            {
                query["VscType"] = request.VscType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachVscMountPoint",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachVscMountPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>挂载VSC挂载点</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <hr>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachVscMountPointRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachVscMountPointResponse
        /// </returns>
        public AttachVscMountPointResponse AttachVscMountPoint(AttachVscMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachVscMountPointWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>挂载VSC挂载点</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <hr>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachVscMountPointRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachVscMountPointResponse
        /// </returns>
        public async Task<AttachVscMountPointResponse> AttachVscMountPointAsync(AttachVscMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachVscMountPointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量挂载VSC挂载点</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AttachVscToMountPointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachVscToMountPointsResponse
        /// </returns>
        public AttachVscToMountPointsResponse AttachVscToMountPointsWithOptions(AttachVscToMountPointsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AttachVscToMountPointsShrinkRequest request = new AttachVscToMountPointsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AttachInfos))
            {
                request.AttachInfosShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AttachInfos, "AttachInfos", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachInfosShrink))
            {
                query["AttachInfos"] = request.AttachInfosShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAssumeRoleChkServerPerm))
            {
                query["UseAssumeRoleChkServerPerm"] = request.UseAssumeRoleChkServerPerm;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachVscToMountPoints",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachVscToMountPointsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量挂载VSC挂载点</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AttachVscToMountPointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachVscToMountPointsResponse
        /// </returns>
        public async Task<AttachVscToMountPointsResponse> AttachVscToMountPointsWithOptionsAsync(AttachVscToMountPointsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AttachVscToMountPointsShrinkRequest request = new AttachVscToMountPointsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AttachInfos))
            {
                request.AttachInfosShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AttachInfos, "AttachInfos", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachInfosShrink))
            {
                query["AttachInfos"] = request.AttachInfosShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAssumeRoleChkServerPerm))
            {
                query["UseAssumeRoleChkServerPerm"] = request.UseAssumeRoleChkServerPerm;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachVscToMountPoints",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachVscToMountPointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量挂载VSC挂载点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AttachVscToMountPointsRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachVscToMountPointsResponse
        /// </returns>
        public AttachVscToMountPointsResponse AttachVscToMountPoints(AttachVscToMountPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachVscToMountPointsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量挂载VSC挂载点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AttachVscToMountPointsRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachVscToMountPointsResponse
        /// </returns>
        public async Task<AttachVscToMountPointsResponse> AttachVscToMountPointsAsync(AttachVscToMountPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachVscToMountPointsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// BindVscMountPointAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindVscMountPointAliasResponse
        /// </returns>
        public BindVscMountPointAliasResponse BindVscMountPointAliasWithOptions(BindVscMountPointAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasPrefix))
            {
                query["AliasPrefix"] = request.AliasPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountPointId))
            {
                query["MountPointId"] = request.MountPointId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindVscMountPointAlias",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindVscMountPointAliasResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// BindVscMountPointAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindVscMountPointAliasResponse
        /// </returns>
        public async Task<BindVscMountPointAliasResponse> BindVscMountPointAliasWithOptionsAsync(BindVscMountPointAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasPrefix))
            {
                query["AliasPrefix"] = request.AliasPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountPointId))
            {
                query["MountPointId"] = request.MountPointId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindVscMountPointAlias",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindVscMountPointAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// BindVscMountPointAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// BindVscMountPointAliasResponse
        /// </returns>
        public BindVscMountPointAliasResponse BindVscMountPointAlias(BindVscMountPointAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindVscMountPointAliasWithOptions(request, runtime);
        }

        /// <param name="request">
        /// BindVscMountPointAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// BindVscMountPointAliasResponse
        /// </returns>
        public async Task<BindVscMountPointAliasResponse> BindVscMountPointAliasAsync(BindVscMountPointAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindVscMountPointAliasWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateAccessGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessGroupResponse
        /// </returns>
        public CreateAccessGroupResponse CreateAccessGroupWithOptions(CreateAccessGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccessGroup",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateAccessGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessGroupResponse
        /// </returns>
        public async Task<CreateAccessGroupResponse> CreateAccessGroupWithOptionsAsync(CreateAccessGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccessGroup",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateAccessGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessGroupResponse
        /// </returns>
        public CreateAccessGroupResponse CreateAccessGroup(CreateAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccessGroupWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateAccessGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessGroupResponse
        /// </returns>
        public async Task<CreateAccessGroupResponse> CreateAccessGroupAsync(CreateAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccessGroupWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateAccessRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessRuleResponse
        /// </returns>
        public CreateAccessRuleResponse CreateAccessRuleWithOptions(CreateAccessRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupId))
            {
                query["AccessGroupId"] = request.AccessGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkSegment))
            {
                query["NetworkSegment"] = request.NetworkSegment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RWAccessType))
            {
                query["RWAccessType"] = request.RWAccessType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccessRule",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateAccessRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessRuleResponse
        /// </returns>
        public async Task<CreateAccessRuleResponse> CreateAccessRuleWithOptionsAsync(CreateAccessRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupId))
            {
                query["AccessGroupId"] = request.AccessGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkSegment))
            {
                query["NetworkSegment"] = request.NetworkSegment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RWAccessType))
            {
                query["RWAccessType"] = request.RWAccessType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccessRule",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateAccessRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessRuleResponse
        /// </returns>
        public CreateAccessRuleResponse CreateAccessRule(CreateAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccessRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateAccessRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessRuleResponse
        /// </returns>
        public async Task<CreateAccessRuleResponse> CreateAccessRuleAsync(CreateAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccessRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateFileSystemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFileSystemResponse
        /// </returns>
        public CreateFileSystemResponse CreateFileSystemWithOptions(CreateFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataRedundancyType))
            {
                query["DataRedundancyType"] = request.DataRedundancyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                query["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemName))
            {
                query["FileSystemName"] = request.FileSystemName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNumber))
            {
                query["PartitionNumber"] = request.PartitionNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolType))
            {
                query["ProtocolType"] = request.ProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionedThroughputInMiBps))
            {
                query["ProvisionedThroughputInMiBps"] = request.ProvisionedThroughputInMiBps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceCapacity))
            {
                query["SpaceCapacity"] = request.SpaceCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageSetName))
            {
                query["StorageSetName"] = request.StorageSetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThroughputMode))
            {
                query["ThroughputMode"] = request.ThroughputMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFileSystem",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFileSystemResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateFileSystemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFileSystemResponse
        /// </returns>
        public async Task<CreateFileSystemResponse> CreateFileSystemWithOptionsAsync(CreateFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataRedundancyType))
            {
                query["DataRedundancyType"] = request.DataRedundancyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedicatedClusterId))
            {
                query["DedicatedClusterId"] = request.DedicatedClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemName))
            {
                query["FileSystemName"] = request.FileSystemName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNumber))
            {
                query["PartitionNumber"] = request.PartitionNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolType))
            {
                query["ProtocolType"] = request.ProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionedThroughputInMiBps))
            {
                query["ProvisionedThroughputInMiBps"] = request.ProvisionedThroughputInMiBps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceCapacity))
            {
                query["SpaceCapacity"] = request.SpaceCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageSetName))
            {
                query["StorageSetName"] = request.StorageSetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThroughputMode))
            {
                query["ThroughputMode"] = request.ThroughputMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFileSystem",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFileSystemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateFileSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFileSystemResponse
        /// </returns>
        public CreateFileSystemResponse CreateFileSystem(CreateFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFileSystemWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateFileSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFileSystemResponse
        /// </returns>
        public async Task<CreateFileSystemResponse> CreateFileSystemAsync(CreateFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFileSystemWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateMountPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMountPointResponse
        /// </returns>
        public CreateMountPointResponse CreateMountPointWithOptions(CreateMountPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupId))
            {
                query["AccessGroupId"] = request.AccessGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePerformanceMode))
            {
                query["UsePerformanceMode"] = request.UsePerformanceMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMountPoint",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMountPointResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMountPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMountPointResponse
        /// </returns>
        public async Task<CreateMountPointResponse> CreateMountPointWithOptionsAsync(CreateMountPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupId))
            {
                query["AccessGroupId"] = request.AccessGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePerformanceMode))
            {
                query["UsePerformanceMode"] = request.UsePerformanceMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMountPoint",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMountPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateMountPointRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMountPointResponse
        /// </returns>
        public CreateMountPointResponse CreateMountPoint(CreateMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMountPointWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateMountPointRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMountPointResponse
        /// </returns>
        public async Task<CreateMountPointResponse> CreateMountPointAsync(CreateMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMountPointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateQosPolicy</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateQosPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQosPolicyResponse
        /// </returns>
        public CreateQosPolicyResponse CreateQosPolicyWithOptions(CreateQosPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateQosPolicyShrinkRequest request = new CreateQosPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FlowIds))
            {
                request.FlowIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FlowIds, "FlowIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReqTags))
            {
                request.ReqTagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReqTags, "ReqTags", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ZoneIds))
            {
                request.ZoneIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ZoneIds, "ZoneIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FederationId))
            {
                query["FederationId"] = request.FederationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowIdsShrink))
            {
                query["FlowIds"] = request.FlowIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxIOBandWidth))
            {
                query["MaxIOBandWidth"] = request.MaxIOBandWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxIOps))
            {
                query["MaxIOps"] = request.MaxIOps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxMetaQps))
            {
                query["MaxMetaQps"] = request.MaxMetaQps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTagsShrink))
            {
                query["ReqTags"] = request.ReqTagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneIdsShrink))
            {
                query["ZoneIds"] = request.ZoneIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQosPolicy",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQosPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateQosPolicy</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateQosPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQosPolicyResponse
        /// </returns>
        public async Task<CreateQosPolicyResponse> CreateQosPolicyWithOptionsAsync(CreateQosPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateQosPolicyShrinkRequest request = new CreateQosPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FlowIds))
            {
                request.FlowIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FlowIds, "FlowIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReqTags))
            {
                request.ReqTagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReqTags, "ReqTags", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ZoneIds))
            {
                request.ZoneIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ZoneIds, "ZoneIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FederationId))
            {
                query["FederationId"] = request.FederationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowIdsShrink))
            {
                query["FlowIds"] = request.FlowIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxIOBandWidth))
            {
                query["MaxIOBandWidth"] = request.MaxIOBandWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxIOps))
            {
                query["MaxIOps"] = request.MaxIOps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxMetaQps))
            {
                query["MaxMetaQps"] = request.MaxMetaQps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTagsShrink))
            {
                query["ReqTags"] = request.ReqTagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneIdsShrink))
            {
                query["ZoneIds"] = request.ZoneIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQosPolicy",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQosPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateQosPolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateQosPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQosPolicyResponse
        /// </returns>
        public CreateQosPolicyResponse CreateQosPolicy(CreateQosPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQosPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateQosPolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateQosPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQosPolicyResponse
        /// </returns>
        public async Task<CreateQosPolicyResponse> CreateQosPolicyAsync(CreateQosPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQosPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 ugo</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateUserGroupsMappingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserGroupsMappingResponse
        /// </returns>
        public CreateUserGroupsMappingResponse CreateUserGroupsMappingWithOptions(CreateUserGroupsMappingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateUserGroupsMappingShrinkRequest request = new CreateUserGroupsMappingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupNames))
            {
                request.GroupNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupNames, "GroupNames", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserGroupsMapping",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserGroupsMappingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 ugo</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateUserGroupsMappingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserGroupsMappingResponse
        /// </returns>
        public async Task<CreateUserGroupsMappingResponse> CreateUserGroupsMappingWithOptionsAsync(CreateUserGroupsMappingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateUserGroupsMappingShrinkRequest request = new CreateUserGroupsMappingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupNames))
            {
                request.GroupNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupNames, "GroupNames", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserGroupsMapping",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserGroupsMappingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 ugo</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserGroupsMappingRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserGroupsMappingResponse
        /// </returns>
        public CreateUserGroupsMappingResponse CreateUserGroupsMapping(CreateUserGroupsMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserGroupsMappingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建 ugo</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserGroupsMappingRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserGroupsMappingResponse
        /// </returns>
        public async Task<CreateUserGroupsMappingResponse> CreateUserGroupsMappingAsync(CreateUserGroupsMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserGroupsMappingWithOptionsAsync(request, runtime);
        }

        /// <param name="tmpReq">
        /// CreateVscMountPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVscMountPointResponse
        /// </returns>
        public CreateVscMountPointResponse CreateVscMountPointWithOptions(CreateVscMountPointRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateVscMountPointShrinkRequest request = new CreateVscMountPointShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVscMountPoint",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVscMountPointResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="tmpReq">
        /// CreateVscMountPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVscMountPointResponse
        /// </returns>
        public async Task<CreateVscMountPointResponse> CreateVscMountPointWithOptionsAsync(CreateVscMountPointRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateVscMountPointShrinkRequest request = new CreateVscMountPointShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVscMountPoint",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVscMountPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateVscMountPointRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVscMountPointResponse
        /// </returns>
        public CreateVscMountPointResponse CreateVscMountPoint(CreateVscMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVscMountPointWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateVscMountPointRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVscMountPointResponse
        /// </returns>
        public async Task<CreateVscMountPointResponse> CreateVscMountPointAsync(CreateVscMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVscMountPointWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteAccessGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessGroupResponse
        /// </returns>
        public DeleteAccessGroupResponse DeleteAccessGroupWithOptions(DeleteAccessGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupId))
            {
                query["AccessGroupId"] = request.AccessGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccessGroup",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteAccessGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessGroupResponse
        /// </returns>
        public async Task<DeleteAccessGroupResponse> DeleteAccessGroupWithOptionsAsync(DeleteAccessGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupId))
            {
                query["AccessGroupId"] = request.AccessGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccessGroup",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteAccessGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessGroupResponse
        /// </returns>
        public DeleteAccessGroupResponse DeleteAccessGroup(DeleteAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccessGroupWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteAccessGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessGroupResponse
        /// </returns>
        public async Task<DeleteAccessGroupResponse> DeleteAccessGroupAsync(DeleteAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccessGroupWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteAccessRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessRuleResponse
        /// </returns>
        public DeleteAccessRuleResponse DeleteAccessRuleWithOptions(DeleteAccessRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupId))
            {
                query["AccessGroupId"] = request.AccessGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRuleId))
            {
                query["AccessRuleId"] = request.AccessRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccessRule",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteAccessRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessRuleResponse
        /// </returns>
        public async Task<DeleteAccessRuleResponse> DeleteAccessRuleWithOptionsAsync(DeleteAccessRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupId))
            {
                query["AccessGroupId"] = request.AccessGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRuleId))
            {
                query["AccessRuleId"] = request.AccessRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccessRule",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteAccessRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessRuleResponse
        /// </returns>
        public DeleteAccessRuleResponse DeleteAccessRule(DeleteAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccessRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteAccessRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessRuleResponse
        /// </returns>
        public async Task<DeleteAccessRuleResponse> DeleteAccessRuleAsync(DeleteAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccessRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteFileSystemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFileSystemResponse
        /// </returns>
        public DeleteFileSystemResponse DeleteFileSystemWithOptions(DeleteFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFileSystem",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFileSystemResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteFileSystemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFileSystemResponse
        /// </returns>
        public async Task<DeleteFileSystemResponse> DeleteFileSystemWithOptionsAsync(DeleteFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFileSystem",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFileSystemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteFileSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFileSystemResponse
        /// </returns>
        public DeleteFileSystemResponse DeleteFileSystem(DeleteFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFileSystemWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteFileSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFileSystemResponse
        /// </returns>
        public async Task<DeleteFileSystemResponse> DeleteFileSystemAsync(DeleteFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFileSystemWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteMountPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMountPointResponse
        /// </returns>
        public DeleteMountPointResponse DeleteMountPointWithOptions(DeleteMountPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountPointId))
            {
                query["MountPointId"] = request.MountPointId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMountPoint",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMountPointResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteMountPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMountPointResponse
        /// </returns>
        public async Task<DeleteMountPointResponse> DeleteMountPointWithOptionsAsync(DeleteMountPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountPointId))
            {
                query["MountPointId"] = request.MountPointId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMountPoint",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMountPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteMountPointRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMountPointResponse
        /// </returns>
        public DeleteMountPointResponse DeleteMountPoint(DeleteMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMountPointWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteMountPointRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMountPointResponse
        /// </returns>
        public async Task<DeleteMountPointResponse> DeleteMountPointAsync(DeleteMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMountPointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteQosPolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteQosPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteQosPolicyResponse
        /// </returns>
        public DeleteQosPolicyResponse DeleteQosPolicyWithOptions(DeleteQosPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FederationId))
            {
                query["FederationId"] = request.FederationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QosPolicyId))
            {
                query["QosPolicyId"] = request.QosPolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteQosPolicy",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteQosPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteQosPolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteQosPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteQosPolicyResponse
        /// </returns>
        public async Task<DeleteQosPolicyResponse> DeleteQosPolicyWithOptionsAsync(DeleteQosPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FederationId))
            {
                query["FederationId"] = request.FederationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QosPolicyId))
            {
                query["QosPolicyId"] = request.QosPolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteQosPolicy",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteQosPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteQosPolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteQosPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteQosPolicyResponse
        /// </returns>
        public DeleteQosPolicyResponse DeleteQosPolicy(DeleteQosPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQosPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteQosPolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteQosPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteQosPolicyResponse
        /// </returns>
        public async Task<DeleteQosPolicyResponse> DeleteQosPolicyAsync(DeleteQosPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQosPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 ugo</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteUserGroupsMappingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserGroupsMappingResponse
        /// </returns>
        public DeleteUserGroupsMappingResponse DeleteUserGroupsMappingWithOptions(DeleteUserGroupsMappingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteUserGroupsMappingShrinkRequest request = new DeleteUserGroupsMappingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupNames))
            {
                request.GroupNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupNames, "GroupNames", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserGroupsMapping",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserGroupsMappingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 ugo</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteUserGroupsMappingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserGroupsMappingResponse
        /// </returns>
        public async Task<DeleteUserGroupsMappingResponse> DeleteUserGroupsMappingWithOptionsAsync(DeleteUserGroupsMappingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteUserGroupsMappingShrinkRequest request = new DeleteUserGroupsMappingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupNames))
            {
                request.GroupNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupNames, "GroupNames", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserGroupsMapping",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserGroupsMappingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 ugo</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserGroupsMappingRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserGroupsMappingResponse
        /// </returns>
        public DeleteUserGroupsMappingResponse DeleteUserGroupsMapping(DeleteUserGroupsMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserGroupsMappingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除 ugo</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserGroupsMappingRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserGroupsMappingResponse
        /// </returns>
        public async Task<DeleteUserGroupsMappingResponse> DeleteUserGroupsMappingAsync(DeleteUserGroupsMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserGroupsMappingWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteVscMountPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVscMountPointResponse
        /// </returns>
        public DeleteVscMountPointResponse DeleteVscMountPointWithOptions(DeleteVscMountPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountPointId))
            {
                query["MountPointId"] = request.MountPointId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVscMountPoint",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVscMountPointResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteVscMountPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVscMountPointResponse
        /// </returns>
        public async Task<DeleteVscMountPointResponse> DeleteVscMountPointWithOptionsAsync(DeleteVscMountPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountPointId))
            {
                query["MountPointId"] = request.MountPointId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVscMountPoint",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVscMountPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteVscMountPointRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVscMountPointResponse
        /// </returns>
        public DeleteVscMountPointResponse DeleteVscMountPoint(DeleteVscMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVscMountPointWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteVscMountPointRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVscMountPointResponse
        /// </returns>
        public async Task<DeleteVscMountPointResponse> DeleteVscMountPointAsync(DeleteVscMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVscMountPointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量挂载VSC挂载点</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeMountPointsVscAttachInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMountPointsVscAttachInfoResponse
        /// </returns>
        public DescribeMountPointsVscAttachInfoResponse DescribeMountPointsVscAttachInfoWithOptions(DescribeMountPointsVscAttachInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeMountPointsVscAttachInfoShrinkRequest request = new DescribeMountPointsVscAttachInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryInfos))
            {
                request.QueryInfosShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryInfos, "QueryInfos", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryInfosShrink))
            {
                query["QueryInfos"] = request.QueryInfosShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAssumeRoleChkServerPerm))
            {
                query["UseAssumeRoleChkServerPerm"] = request.UseAssumeRoleChkServerPerm;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMountPointsVscAttachInfo",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMountPointsVscAttachInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量挂载VSC挂载点</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeMountPointsVscAttachInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMountPointsVscAttachInfoResponse
        /// </returns>
        public async Task<DescribeMountPointsVscAttachInfoResponse> DescribeMountPointsVscAttachInfoWithOptionsAsync(DescribeMountPointsVscAttachInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeMountPointsVscAttachInfoShrinkRequest request = new DescribeMountPointsVscAttachInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryInfos))
            {
                request.QueryInfosShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryInfos, "QueryInfos", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryInfosShrink))
            {
                query["QueryInfos"] = request.QueryInfosShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAssumeRoleChkServerPerm))
            {
                query["UseAssumeRoleChkServerPerm"] = request.UseAssumeRoleChkServerPerm;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMountPointsVscAttachInfo",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMountPointsVscAttachInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量挂载VSC挂载点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMountPointsVscAttachInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMountPointsVscAttachInfoResponse
        /// </returns>
        public DescribeMountPointsVscAttachInfoResponse DescribeMountPointsVscAttachInfo(DescribeMountPointsVscAttachInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMountPointsVscAttachInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量挂载VSC挂载点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMountPointsVscAttachInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMountPointsVscAttachInfoResponse
        /// </returns>
        public async Task<DescribeMountPointsVscAttachInfoResponse> DescribeMountPointsVscAttachInfoAsync(DescribeMountPointsVscAttachInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMountPointsVscAttachInfoWithOptionsAsync(request, runtime);
        }

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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2018-06-20",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2018-06-20",
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
        /// <para>查询VSC挂载信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVscMountPointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVscMountPointsResponse
        /// </returns>
        public DescribeVscMountPointsResponse DescribeVscMountPointsWithOptions(DescribeVscMountPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountPointId))
            {
                query["MountPointId"] = request.MountPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VscId))
            {
                query["VscId"] = request.VscId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVscMountPoints",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVscMountPointsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询VSC挂载信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVscMountPointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVscMountPointsResponse
        /// </returns>
        public async Task<DescribeVscMountPointsResponse> DescribeVscMountPointsWithOptionsAsync(DescribeVscMountPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountPointId))
            {
                query["MountPointId"] = request.MountPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VscId))
            {
                query["VscId"] = request.VscId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVscMountPoints",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVscMountPointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询VSC挂载信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVscMountPointsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVscMountPointsResponse
        /// </returns>
        public DescribeVscMountPointsResponse DescribeVscMountPoints(DescribeVscMountPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVscMountPointsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询VSC挂载信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVscMountPointsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVscMountPointsResponse
        /// </returns>
        public async Task<DescribeVscMountPointsResponse> DescribeVscMountPointsAsync(DescribeVscMountPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVscMountPointsWithOptionsAsync(request, runtime);
        }

        /// <param name="tmpReq">
        /// DetachVscMountPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachVscMountPointResponse
        /// </returns>
        public DetachVscMountPointResponse DetachVscMountPointWithOptions(DetachVscMountPointRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetachVscMountPointShrinkRequest request = new DetachVscMountPointShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VscIds))
            {
                request.VscIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VscIds, "VscIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountPointId))
            {
                query["MountPointId"] = request.MountPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAssumeRoleChkServerPerm))
            {
                query["UseAssumeRoleChkServerPerm"] = request.UseAssumeRoleChkServerPerm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VscIdsShrink))
            {
                query["VscIds"] = request.VscIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachVscMountPoint",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachVscMountPointResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="tmpReq">
        /// DetachVscMountPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachVscMountPointResponse
        /// </returns>
        public async Task<DetachVscMountPointResponse> DetachVscMountPointWithOptionsAsync(DetachVscMountPointRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetachVscMountPointShrinkRequest request = new DetachVscMountPointShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VscIds))
            {
                request.VscIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VscIds, "VscIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountPointId))
            {
                query["MountPointId"] = request.MountPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAssumeRoleChkServerPerm))
            {
                query["UseAssumeRoleChkServerPerm"] = request.UseAssumeRoleChkServerPerm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VscIdsShrink))
            {
                query["VscIds"] = request.VscIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachVscMountPoint",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachVscMountPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DetachVscMountPointRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachVscMountPointResponse
        /// </returns>
        public DetachVscMountPointResponse DetachVscMountPoint(DetachVscMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachVscMountPointWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DetachVscMountPointRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachVscMountPointResponse
        /// </returns>
        public async Task<DetachVscMountPointResponse> DetachVscMountPointAsync(DetachVscMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachVscMountPointWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetAccessGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessGroupResponse
        /// </returns>
        public GetAccessGroupResponse GetAccessGroupWithOptions(GetAccessGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupId))
            {
                query["AccessGroupId"] = request.AccessGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessGroup",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAccessGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessGroupResponse
        /// </returns>
        public async Task<GetAccessGroupResponse> GetAccessGroupWithOptionsAsync(GetAccessGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupId))
            {
                query["AccessGroupId"] = request.AccessGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessGroup",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAccessGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessGroupResponse
        /// </returns>
        public GetAccessGroupResponse GetAccessGroup(GetAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessGroupWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetAccessGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessGroupResponse
        /// </returns>
        public async Task<GetAccessGroupResponse> GetAccessGroupAsync(GetAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessGroupWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetAccessRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessRuleResponse
        /// </returns>
        public GetAccessRuleResponse GetAccessRuleWithOptions(GetAccessRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupId))
            {
                query["AccessGroupId"] = request.AccessGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRuleId))
            {
                query["AccessRuleId"] = request.AccessRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessRule",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAccessRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessRuleResponse
        /// </returns>
        public async Task<GetAccessRuleResponse> GetAccessRuleWithOptionsAsync(GetAccessRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupId))
            {
                query["AccessGroupId"] = request.AccessGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRuleId))
            {
                query["AccessRuleId"] = request.AccessRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessRule",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAccessRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessRuleResponse
        /// </returns>
        public GetAccessRuleResponse GetAccessRule(GetAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetAccessRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessRuleResponse
        /// </returns>
        public async Task<GetAccessRuleResponse> GetAccessRuleAsync(GetAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetFileSystemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFileSystemResponse
        /// </returns>
        public GetFileSystemResponse GetFileSystemWithOptions(GetFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileSystem",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileSystemResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetFileSystemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFileSystemResponse
        /// </returns>
        public async Task<GetFileSystemResponse> GetFileSystemWithOptionsAsync(GetFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileSystem",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileSystemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetFileSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFileSystemResponse
        /// </returns>
        public GetFileSystemResponse GetFileSystem(GetFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFileSystemWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetFileSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFileSystemResponse
        /// </returns>
        public async Task<GetFileSystemResponse> GetFileSystemAsync(GetFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFileSystemWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetMountPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMountPointResponse
        /// </returns>
        public GetMountPointResponse GetMountPointWithOptions(GetMountPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountPointId))
            {
                query["MountPointId"] = request.MountPointId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMountPoint",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMountPointResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetMountPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMountPointResponse
        /// </returns>
        public async Task<GetMountPointResponse> GetMountPointWithOptionsAsync(GetMountPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountPointId))
            {
                query["MountPointId"] = request.MountPointId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMountPoint",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMountPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetMountPointRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMountPointResponse
        /// </returns>
        public GetMountPointResponse GetMountPoint(GetMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMountPointWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetMountPointRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMountPointResponse
        /// </returns>
        public async Task<GetMountPointResponse> GetMountPointAsync(GetMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMountPointWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetRegionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRegionResponse
        /// </returns>
        public GetRegionResponse GetRegionWithOptions(GetRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRegion",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRegionResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetRegionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRegionResponse
        /// </returns>
        public async Task<GetRegionResponse> GetRegionWithOptionsAsync(GetRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRegion",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRegionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetRegionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRegionResponse
        /// </returns>
        public GetRegionResponse GetRegion(GetRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRegionWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetRegionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRegionResponse
        /// </returns>
        public async Task<GetRegionResponse> GetRegionAsync(GetRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRegionWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListAccessGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAccessGroupsResponse
        /// </returns>
        public ListAccessGroupsResponse ListAccessGroupsWithOptions(ListAccessGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOffset))
            {
                query["StartOffset"] = request.StartOffset;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccessGroups",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccessGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAccessGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAccessGroupsResponse
        /// </returns>
        public async Task<ListAccessGroupsResponse> ListAccessGroupsWithOptionsAsync(ListAccessGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOffset))
            {
                query["StartOffset"] = request.StartOffset;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccessGroups",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccessGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAccessGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAccessGroupsResponse
        /// </returns>
        public ListAccessGroupsResponse ListAccessGroups(ListAccessGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccessGroupsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListAccessGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAccessGroupsResponse
        /// </returns>
        public async Task<ListAccessGroupsResponse> ListAccessGroupsAsync(ListAccessGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccessGroupsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListAccessRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAccessRulesResponse
        /// </returns>
        public ListAccessRulesResponse ListAccessRulesWithOptions(ListAccessRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupId))
            {
                query["AccessGroupId"] = request.AccessGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOffset))
            {
                query["StartOffset"] = request.StartOffset;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccessRules",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccessRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAccessRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAccessRulesResponse
        /// </returns>
        public async Task<ListAccessRulesResponse> ListAccessRulesWithOptionsAsync(ListAccessRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupId))
            {
                query["AccessGroupId"] = request.AccessGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOffset))
            {
                query["StartOffset"] = request.StartOffset;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccessRules",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccessRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAccessRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAccessRulesResponse
        /// </returns>
        public ListAccessRulesResponse ListAccessRules(ListAccessRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccessRulesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListAccessRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAccessRulesResponse
        /// </returns>
        public async Task<ListAccessRulesResponse> ListAccessRulesAsync(ListAccessRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccessRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Federation</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFederationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFederationsResponse
        /// </returns>
        public ListFederationsResponse ListFederationsWithOptions(ListFederationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FederationId))
            {
                query["FederationId"] = request.FederationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
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
                Action = "ListFederations",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFederationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Federation</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFederationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFederationsResponse
        /// </returns>
        public async Task<ListFederationsResponse> ListFederationsWithOptionsAsync(ListFederationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FederationId))
            {
                query["FederationId"] = request.FederationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
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
                Action = "ListFederations",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFederationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Federation</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFederationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFederationsResponse
        /// </returns>
        public ListFederationsResponse ListFederations(ListFederationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFederationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Federation</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFederationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFederationsResponse
        /// </returns>
        public async Task<ListFederationsResponse> ListFederationsAsync(ListFederationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFederationsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListFileSystemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFileSystemsResponse
        /// </returns>
        public ListFileSystemsResponse ListFileSystemsWithOptions(ListFileSystemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOffset))
            {
                query["StartOffset"] = request.StartOffset;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFileSystems",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFileSystemsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListFileSystemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFileSystemsResponse
        /// </returns>
        public async Task<ListFileSystemsResponse> ListFileSystemsWithOptionsAsync(ListFileSystemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOffset))
            {
                query["StartOffset"] = request.StartOffset;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFileSystems",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFileSystemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListFileSystemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFileSystemsResponse
        /// </returns>
        public ListFileSystemsResponse ListFileSystems(ListFileSystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFileSystemsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListFileSystemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFileSystemsResponse
        /// </returns>
        public async Task<ListFileSystemsResponse> ListFileSystemsAsync(ListFileSystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFileSystemsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListMountPointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMountPointsResponse
        /// </returns>
        public ListMountPointsResponse ListMountPointsWithOptions(ListMountPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOffset))
            {
                query["StartOffset"] = request.StartOffset;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMountPoints",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMountPointsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMountPointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMountPointsResponse
        /// </returns>
        public async Task<ListMountPointsResponse> ListMountPointsWithOptionsAsync(ListMountPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOffset))
            {
                query["StartOffset"] = request.StartOffset;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMountPoints",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMountPointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListMountPointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMountPointsResponse
        /// </returns>
        public ListMountPointsResponse ListMountPoints(ListMountPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMountPointsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListMountPointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMountPointsResponse
        /// </returns>
        public async Task<ListMountPointsResponse> ListMountPointsAsync(ListMountPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMountPointsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询QosPolicies</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQosPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQosPoliciesResponse
        /// </returns>
        public ListQosPoliciesResponse ListQosPoliciesWithOptions(ListQosPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FederationId))
            {
                query["FederationId"] = request.FederationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
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
                Action = "ListQosPolicies",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQosPoliciesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询QosPolicies</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQosPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQosPoliciesResponse
        /// </returns>
        public async Task<ListQosPoliciesResponse> ListQosPoliciesWithOptionsAsync(ListQosPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FederationId))
            {
                query["FederationId"] = request.FederationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
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
                Action = "ListQosPolicies",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQosPoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询QosPolicies</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQosPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQosPoliciesResponse
        /// </returns>
        public ListQosPoliciesResponse ListQosPolicies(ListQosPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQosPoliciesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询QosPolicies</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQosPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQosPoliciesResponse
        /// </returns>
        public async Task<ListQosPoliciesResponse> ListQosPoliciesAsync(ListQosPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQosPoliciesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>list ugm</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserGroupsMappingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupsMappingsResponse
        /// </returns>
        public ListUserGroupsMappingsResponse ListUserGroupsMappingsWithOptions(ListUserGroupsMappingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilesystemId))
            {
                query["FilesystemId"] = request.FilesystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
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
                Action = "ListUserGroupsMappings",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserGroupsMappingsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>list ugm</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserGroupsMappingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupsMappingsResponse
        /// </returns>
        public async Task<ListUserGroupsMappingsResponse> ListUserGroupsMappingsWithOptionsAsync(ListUserGroupsMappingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilesystemId))
            {
                query["FilesystemId"] = request.FilesystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
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
                Action = "ListUserGroupsMappings",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserGroupsMappingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>list ugm</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserGroupsMappingsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupsMappingsResponse
        /// </returns>
        public ListUserGroupsMappingsResponse ListUserGroupsMappings(ListUserGroupsMappingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserGroupsMappingsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>list ugm</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserGroupsMappingsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupsMappingsResponse
        /// </returns>
        public async Task<ListUserGroupsMappingsResponse> ListUserGroupsMappingsAsync(ListUserGroupsMappingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserGroupsMappingsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ModifyAccessGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccessGroupResponse
        /// </returns>
        public ModifyAccessGroupResponse ModifyAccessGroupWithOptions(ModifyAccessGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupId))
            {
                query["AccessGroupId"] = request.AccessGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAccessGroup",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAccessGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyAccessGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccessGroupResponse
        /// </returns>
        public async Task<ModifyAccessGroupResponse> ModifyAccessGroupWithOptionsAsync(ModifyAccessGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupId))
            {
                query["AccessGroupId"] = request.AccessGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupName))
            {
                query["AccessGroupName"] = request.AccessGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAccessGroup",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAccessGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyAccessGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccessGroupResponse
        /// </returns>
        public ModifyAccessGroupResponse ModifyAccessGroup(ModifyAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAccessGroupWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ModifyAccessGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccessGroupResponse
        /// </returns>
        public async Task<ModifyAccessGroupResponse> ModifyAccessGroupAsync(ModifyAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAccessGroupWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ModifyAccessRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccessRuleResponse
        /// </returns>
        public ModifyAccessRuleResponse ModifyAccessRuleWithOptions(ModifyAccessRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupId))
            {
                query["AccessGroupId"] = request.AccessGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRuleId))
            {
                query["AccessRuleId"] = request.AccessRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RWAccessType))
            {
                query["RWAccessType"] = request.RWAccessType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAccessRule",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAccessRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyAccessRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccessRuleResponse
        /// </returns>
        public async Task<ModifyAccessRuleResponse> ModifyAccessRuleWithOptionsAsync(ModifyAccessRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupId))
            {
                query["AccessGroupId"] = request.AccessGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRuleId))
            {
                query["AccessRuleId"] = request.AccessRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RWAccessType))
            {
                query["RWAccessType"] = request.RWAccessType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAccessRule",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAccessRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyAccessRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccessRuleResponse
        /// </returns>
        public ModifyAccessRuleResponse ModifyAccessRule(ModifyAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAccessRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ModifyAccessRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAccessRuleResponse
        /// </returns>
        public async Task<ModifyAccessRuleResponse> ModifyAccessRuleAsync(ModifyAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAccessRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ModifyFileSystemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFileSystemResponse
        /// </returns>
        public ModifyFileSystemResponse ModifyFileSystemWithOptions(ModifyFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemName))
            {
                query["FileSystemName"] = request.FileSystemName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionedThroughputInMiBps))
            {
                query["ProvisionedThroughputInMiBps"] = request.ProvisionedThroughputInMiBps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceCapacity))
            {
                query["SpaceCapacity"] = request.SpaceCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThroughputMode))
            {
                query["ThroughputMode"] = request.ThroughputMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFileSystem",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFileSystemResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyFileSystemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFileSystemResponse
        /// </returns>
        public async Task<ModifyFileSystemResponse> ModifyFileSystemWithOptionsAsync(ModifyFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemName))
            {
                query["FileSystemName"] = request.FileSystemName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionedThroughputInMiBps))
            {
                query["ProvisionedThroughputInMiBps"] = request.ProvisionedThroughputInMiBps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceCapacity))
            {
                query["SpaceCapacity"] = request.SpaceCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThroughputMode))
            {
                query["ThroughputMode"] = request.ThroughputMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFileSystem",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFileSystemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyFileSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFileSystemResponse
        /// </returns>
        public ModifyFileSystemResponse ModifyFileSystem(ModifyFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFileSystemWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ModifyFileSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFileSystemResponse
        /// </returns>
        public async Task<ModifyFileSystemResponse> ModifyFileSystemAsync(ModifyFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFileSystemWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ModifyMountPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyMountPointResponse
        /// </returns>
        public ModifyMountPointResponse ModifyMountPointWithOptions(ModifyMountPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupId))
            {
                query["AccessGroupId"] = request.AccessGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountPointId))
            {
                query["MountPointId"] = request.MountPointId;
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
                Action = "ModifyMountPoint",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMountPointResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyMountPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyMountPointResponse
        /// </returns>
        public async Task<ModifyMountPointResponse> ModifyMountPointWithOptionsAsync(ModifyMountPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessGroupId))
            {
                query["AccessGroupId"] = request.AccessGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountPointId))
            {
                query["MountPointId"] = request.MountPointId;
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
                Action = "ModifyMountPoint",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMountPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ModifyMountPointRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyMountPointResponse
        /// </returns>
        public ModifyMountPointResponse ModifyMountPoint(ModifyMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMountPointWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ModifyMountPointRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyMountPointResponse
        /// </returns>
        public async Task<ModifyMountPointResponse> ModifyMountPointAsync(ModifyMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMountPointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyQosPolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyQosPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyQosPolicyResponse
        /// </returns>
        public ModifyQosPolicyResponse ModifyQosPolicyWithOptions(ModifyQosPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FederationId))
            {
                query["FederationId"] = request.FederationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxIOBandWidth))
            {
                query["MaxIOBandWidth"] = request.MaxIOBandWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxIOps))
            {
                query["MaxIOps"] = request.MaxIOps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxMetaQps))
            {
                query["MaxMetaQps"] = request.MaxMetaQps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QosPolicyId))
            {
                query["QosPolicyId"] = request.QosPolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyQosPolicy",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyQosPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyQosPolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyQosPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyQosPolicyResponse
        /// </returns>
        public async Task<ModifyQosPolicyResponse> ModifyQosPolicyWithOptionsAsync(ModifyQosPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FederationId))
            {
                query["FederationId"] = request.FederationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputRegionId))
            {
                query["InputRegionId"] = request.InputRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxIOBandWidth))
            {
                query["MaxIOBandWidth"] = request.MaxIOBandWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxIOps))
            {
                query["MaxIOps"] = request.MaxIOps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxMetaQps))
            {
                query["MaxMetaQps"] = request.MaxMetaQps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QosPolicyId))
            {
                query["QosPolicyId"] = request.QosPolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyQosPolicy",
                Version = "2018-06-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyQosPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyQosPolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyQosPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyQosPolicyResponse
        /// </returns>
        public ModifyQosPolicyResponse ModifyQosPolicy(ModifyQosPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyQosPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ModifyQosPolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyQosPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyQosPolicyResponse
        /// </returns>
        public async Task<ModifyQosPolicyResponse> ModifyQosPolicyAsync(ModifyQosPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyQosPolicyWithOptionsAsync(request, runtime);
        }

    }
}
