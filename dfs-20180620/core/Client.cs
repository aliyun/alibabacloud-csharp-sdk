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

        public CreateAccessGroupResponse CreateAccessGroup(CreateAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccessGroupWithOptions(request, runtime);
        }

        public async Task<CreateAccessGroupResponse> CreateAccessGroupAsync(CreateAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccessGroupWithOptionsAsync(request, runtime);
        }

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

        public CreateAccessRuleResponse CreateAccessRule(CreateAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccessRuleWithOptions(request, runtime);
        }

        public async Task<CreateAccessRuleResponse> CreateAccessRuleAsync(CreateAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccessRuleWithOptionsAsync(request, runtime);
        }

        public CreateFileSystemResponse CreateFileSystemWithOptions(CreateFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataRedundancyType))
            {
                query["DataRedundancyType"] = request.DataRedundancyType;
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

        public async Task<CreateFileSystemResponse> CreateFileSystemWithOptionsAsync(CreateFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataRedundancyType))
            {
                query["DataRedundancyType"] = request.DataRedundancyType;
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

        public CreateFileSystemResponse CreateFileSystem(CreateFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFileSystemWithOptions(request, runtime);
        }

        public async Task<CreateFileSystemResponse> CreateFileSystemAsync(CreateFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFileSystemWithOptionsAsync(request, runtime);
        }

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

        public CreateMountPointResponse CreateMountPoint(CreateMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMountPointWithOptions(request, runtime);
        }

        public async Task<CreateMountPointResponse> CreateMountPointAsync(CreateMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMountPointWithOptionsAsync(request, runtime);
        }

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

        public CreateUserGroupsMappingResponse CreateUserGroupsMapping(CreateUserGroupsMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserGroupsMappingWithOptions(request, runtime);
        }

        public async Task<CreateUserGroupsMappingResponse> CreateUserGroupsMappingAsync(CreateUserGroupsMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserGroupsMappingWithOptionsAsync(request, runtime);
        }

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

        public DeleteAccessGroupResponse DeleteAccessGroup(DeleteAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccessGroupWithOptions(request, runtime);
        }

        public async Task<DeleteAccessGroupResponse> DeleteAccessGroupAsync(DeleteAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccessGroupWithOptionsAsync(request, runtime);
        }

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

        public DeleteAccessRuleResponse DeleteAccessRule(DeleteAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccessRuleWithOptions(request, runtime);
        }

        public async Task<DeleteAccessRuleResponse> DeleteAccessRuleAsync(DeleteAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccessRuleWithOptionsAsync(request, runtime);
        }

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

        public DeleteFileSystemResponse DeleteFileSystem(DeleteFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFileSystemWithOptions(request, runtime);
        }

        public async Task<DeleteFileSystemResponse> DeleteFileSystemAsync(DeleteFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFileSystemWithOptionsAsync(request, runtime);
        }

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

        public DeleteMountPointResponse DeleteMountPoint(DeleteMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMountPointWithOptions(request, runtime);
        }

        public async Task<DeleteMountPointResponse> DeleteMountPointAsync(DeleteMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMountPointWithOptionsAsync(request, runtime);
        }

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

        public DeleteUserGroupsMappingResponse DeleteUserGroupsMapping(DeleteUserGroupsMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserGroupsMappingWithOptions(request, runtime);
        }

        public async Task<DeleteUserGroupsMappingResponse> DeleteUserGroupsMappingAsync(DeleteUserGroupsMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserGroupsMappingWithOptionsAsync(request, runtime);
        }

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

        public GetAccessGroupResponse GetAccessGroup(GetAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessGroupWithOptions(request, runtime);
        }

        public async Task<GetAccessGroupResponse> GetAccessGroupAsync(GetAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessGroupWithOptionsAsync(request, runtime);
        }

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

        public GetAccessRuleResponse GetAccessRule(GetAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessRuleWithOptions(request, runtime);
        }

        public async Task<GetAccessRuleResponse> GetAccessRuleAsync(GetAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessRuleWithOptionsAsync(request, runtime);
        }

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

        public GetFileSystemResponse GetFileSystem(GetFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFileSystemWithOptions(request, runtime);
        }

        public async Task<GetFileSystemResponse> GetFileSystemAsync(GetFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFileSystemWithOptionsAsync(request, runtime);
        }

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

        public GetMountPointResponse GetMountPoint(GetMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMountPointWithOptions(request, runtime);
        }

        public async Task<GetMountPointResponse> GetMountPointAsync(GetMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMountPointWithOptionsAsync(request, runtime);
        }

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

        public GetRegionResponse GetRegion(GetRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRegionWithOptions(request, runtime);
        }

        public async Task<GetRegionResponse> GetRegionAsync(GetRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRegionWithOptionsAsync(request, runtime);
        }

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

        public ListAccessGroupsResponse ListAccessGroups(ListAccessGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccessGroupsWithOptions(request, runtime);
        }

        public async Task<ListAccessGroupsResponse> ListAccessGroupsAsync(ListAccessGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccessGroupsWithOptionsAsync(request, runtime);
        }

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

        public ListAccessRulesResponse ListAccessRules(ListAccessRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccessRulesWithOptions(request, runtime);
        }

        public async Task<ListAccessRulesResponse> ListAccessRulesAsync(ListAccessRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccessRulesWithOptionsAsync(request, runtime);
        }

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

        public ListFileSystemsResponse ListFileSystems(ListFileSystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFileSystemsWithOptions(request, runtime);
        }

        public async Task<ListFileSystemsResponse> ListFileSystemsAsync(ListFileSystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFileSystemsWithOptionsAsync(request, runtime);
        }

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

        public ListMountPointsResponse ListMountPoints(ListMountPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMountPointsWithOptions(request, runtime);
        }

        public async Task<ListMountPointsResponse> ListMountPointsAsync(ListMountPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMountPointsWithOptionsAsync(request, runtime);
        }

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

        public ListUserGroupsMappingsResponse ListUserGroupsMappings(ListUserGroupsMappingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserGroupsMappingsWithOptions(request, runtime);
        }

        public async Task<ListUserGroupsMappingsResponse> ListUserGroupsMappingsAsync(ListUserGroupsMappingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserGroupsMappingsWithOptionsAsync(request, runtime);
        }

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

        public ModifyAccessGroupResponse ModifyAccessGroup(ModifyAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAccessGroupWithOptions(request, runtime);
        }

        public async Task<ModifyAccessGroupResponse> ModifyAccessGroupAsync(ModifyAccessGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAccessGroupWithOptionsAsync(request, runtime);
        }

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

        public ModifyAccessRuleResponse ModifyAccessRule(ModifyAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAccessRuleWithOptions(request, runtime);
        }

        public async Task<ModifyAccessRuleResponse> ModifyAccessRuleAsync(ModifyAccessRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAccessRuleWithOptionsAsync(request, runtime);
        }

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

        public ModifyFileSystemResponse ModifyFileSystem(ModifyFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFileSystemWithOptions(request, runtime);
        }

        public async Task<ModifyFileSystemResponse> ModifyFileSystemAsync(ModifyFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFileSystemWithOptionsAsync(request, runtime);
        }

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

        public ModifyMountPointResponse ModifyMountPoint(ModifyMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMountPointWithOptions(request, runtime);
        }

        public async Task<ModifyMountPointResponse> ModifyMountPointAsync(ModifyMountPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMountPointWithOptionsAsync(request, runtime);
        }

    }
}
