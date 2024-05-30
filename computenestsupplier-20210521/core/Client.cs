// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.ComputeNestSupplier20210521.Models;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("computenestsupplier", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /**
         * @param request AddServiceSharedAccountsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddServiceSharedAccountsResponse
         */
        public AddServiceSharedAccountsResponse AddServiceSharedAccountsWithOptions(AddServiceSharedAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharedAccounts))
            {
                query["SharedAccounts"] = request.SharedAccounts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddServiceSharedAccounts",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddServiceSharedAccountsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request AddServiceSharedAccountsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddServiceSharedAccountsResponse
         */
        public async Task<AddServiceSharedAccountsResponse> AddServiceSharedAccountsWithOptionsAsync(AddServiceSharedAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharedAccounts))
            {
                query["SharedAccounts"] = request.SharedAccounts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddServiceSharedAccounts",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddServiceSharedAccountsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request AddServiceSharedAccountsRequest
         * @return AddServiceSharedAccountsResponse
         */
        public AddServiceSharedAccountsResponse AddServiceSharedAccounts(AddServiceSharedAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddServiceSharedAccountsWithOptions(request, runtime);
        }

        /**
         * @param request AddServiceSharedAccountsRequest
         * @return AddServiceSharedAccountsResponse
         */
        public async Task<AddServiceSharedAccountsResponse> AddServiceSharedAccountsAsync(AddServiceSharedAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddServiceSharedAccountsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ContinueDeployServiceInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ContinueDeployServiceInstanceResponse
         */
        public ContinueDeployServiceInstanceResponse ContinueDeployServiceInstanceWithOptions(ContinueDeployServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ContinueDeployServiceInstance",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContinueDeployServiceInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ContinueDeployServiceInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ContinueDeployServiceInstanceResponse
         */
        public async Task<ContinueDeployServiceInstanceResponse> ContinueDeployServiceInstanceWithOptionsAsync(ContinueDeployServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ContinueDeployServiceInstance",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContinueDeployServiceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ContinueDeployServiceInstanceRequest
         * @return ContinueDeployServiceInstanceResponse
         */
        public ContinueDeployServiceInstanceResponse ContinueDeployServiceInstance(ContinueDeployServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ContinueDeployServiceInstanceWithOptions(request, runtime);
        }

        /**
         * @param request ContinueDeployServiceInstanceRequest
         * @return ContinueDeployServiceInstanceResponse
         */
        public async Task<ContinueDeployServiceInstanceResponse> ContinueDeployServiceInstanceAsync(ContinueDeployServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ContinueDeployServiceInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建部署物
         *
         * @param tmpReq CreateArtifactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateArtifactResponse
         */
        public CreateArtifactResponse CreateArtifactWithOptions(CreateArtifactRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateArtifactShrinkRequest request = new CreateArtifactShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ArtifactProperty))
            {
                request.ArtifactPropertyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ArtifactProperty, "ArtifactProperty", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactId))
            {
                query["ArtifactId"] = request.ArtifactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactPropertyShrink))
            {
                query["ArtifactProperty"] = request.ArtifactPropertyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactType))
            {
                query["ArtifactType"] = request.ArtifactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportRegionIds))
            {
                query["SupportRegionIds"] = request.SupportRegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                query["VersionName"] = request.VersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateArtifact",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateArtifactResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建部署物
         *
         * @param tmpReq CreateArtifactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateArtifactResponse
         */
        public async Task<CreateArtifactResponse> CreateArtifactWithOptionsAsync(CreateArtifactRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateArtifactShrinkRequest request = new CreateArtifactShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ArtifactProperty))
            {
                request.ArtifactPropertyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ArtifactProperty, "ArtifactProperty", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactId))
            {
                query["ArtifactId"] = request.ArtifactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactPropertyShrink))
            {
                query["ArtifactProperty"] = request.ArtifactPropertyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactType))
            {
                query["ArtifactType"] = request.ArtifactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportRegionIds))
            {
                query["SupportRegionIds"] = request.SupportRegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                query["VersionName"] = request.VersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateArtifact",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateArtifactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建部署物
         *
         * @param request CreateArtifactRequest
         * @return CreateArtifactResponse
         */
        public CreateArtifactResponse CreateArtifact(CreateArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateArtifactWithOptions(request, runtime);
        }

        /**
         * @summary 创建部署物
         *
         * @param request CreateArtifactRequest
         * @return CreateArtifactResponse
         */
        public async Task<CreateArtifactResponse> CreateArtifactAsync(CreateArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateArtifactWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建新服务版本
         *
         * @param request CreateServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceResponse
         */
        public CreateServiceResponse CreateServiceWithOptions(CreateServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmMetadata))
            {
                query["AlarmMetadata"] = request.AlarmMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovalType))
            {
                query["ApprovalType"] = request.ApprovalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildParameters))
            {
                query["BuildParameters"] = request.BuildParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployMetadata))
            {
                query["DeployMetadata"] = request.DeployMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                query["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSupportOperated))
            {
                query["IsSupportOperated"] = request.IsSupportOperated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseMetadata))
            {
                query["LicenseMetadata"] = request.LicenseMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogMetadata))
            {
                query["LogMetadata"] = request.LogMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationMetadata))
            {
                query["OperationMetadata"] = request.OperationMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyNames))
            {
                query["PolicyNames"] = request.PolicyNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resellable))
            {
                query["Resellable"] = request.Resellable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInfo))
            {
                query["ServiceInfo"] = request.ServiceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareType))
            {
                query["ShareType"] = request.ShareType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceServiceId))
            {
                query["SourceServiceId"] = request.SourceServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceServiceVersion))
            {
                query["SourceServiceVersion"] = request.SourceServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantType))
            {
                query["TenantType"] = request.TenantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrialDuration))
            {
                query["TrialDuration"] = request.TrialDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeMetadata))
            {
                query["UpgradeMetadata"] = request.UpgradeMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                query["VersionName"] = request.VersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateService",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建新服务版本
         *
         * @param request CreateServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceResponse
         */
        public async Task<CreateServiceResponse> CreateServiceWithOptionsAsync(CreateServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmMetadata))
            {
                query["AlarmMetadata"] = request.AlarmMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovalType))
            {
                query["ApprovalType"] = request.ApprovalType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildParameters))
            {
                query["BuildParameters"] = request.BuildParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployMetadata))
            {
                query["DeployMetadata"] = request.DeployMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                query["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSupportOperated))
            {
                query["IsSupportOperated"] = request.IsSupportOperated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseMetadata))
            {
                query["LicenseMetadata"] = request.LicenseMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogMetadata))
            {
                query["LogMetadata"] = request.LogMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationMetadata))
            {
                query["OperationMetadata"] = request.OperationMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyNames))
            {
                query["PolicyNames"] = request.PolicyNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resellable))
            {
                query["Resellable"] = request.Resellable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInfo))
            {
                query["ServiceInfo"] = request.ServiceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareType))
            {
                query["ShareType"] = request.ShareType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceServiceId))
            {
                query["SourceServiceId"] = request.SourceServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceServiceVersion))
            {
                query["SourceServiceVersion"] = request.SourceServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantType))
            {
                query["TenantType"] = request.TenantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrialDuration))
            {
                query["TrialDuration"] = request.TrialDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeMetadata))
            {
                query["UpgradeMetadata"] = request.UpgradeMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                query["VersionName"] = request.VersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateService",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建新服务版本
         *
         * @param request CreateServiceRequest
         * @return CreateServiceResponse
         */
        public CreateServiceResponse CreateService(CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServiceWithOptions(request, runtime);
        }

        /**
         * @summary 创建新服务版本
         *
         * @param request CreateServiceRequest
         * @return CreateServiceResponse
         */
        public async Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 商家侧创建服务实例
         *
         * @param tmpReq CreateServiceInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceInstanceResponse
         */
        public CreateServiceInstanceResponse CreateServiceInstanceWithOptions(CreateServiceInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateServiceInstanceShrinkRequest request = new CreateServiceInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecificationName))
            {
                query["SpecificationName"] = request.SpecificationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceInstance",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 商家侧创建服务实例
         *
         * @param tmpReq CreateServiceInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceInstanceResponse
         */
        public async Task<CreateServiceInstanceResponse> CreateServiceInstanceWithOptionsAsync(CreateServiceInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateServiceInstanceShrinkRequest request = new CreateServiceInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecificationName))
            {
                query["SpecificationName"] = request.SpecificationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceInstance",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 商家侧创建服务实例
         *
         * @param request CreateServiceInstanceRequest
         * @return CreateServiceInstanceResponse
         */
        public CreateServiceInstanceResponse CreateServiceInstance(CreateServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServiceInstanceWithOptions(request, runtime);
        }

        /**
         * @summary 商家侧创建服务实例
         *
         * @param request CreateServiceInstanceRequest
         * @return CreateServiceInstanceResponse
         */
        public async Task<CreateServiceInstanceResponse> CreateServiceInstanceAsync(CreateServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServiceInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除部署物
         *
         * @param request DeleteArtifactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteArtifactResponse
         */
        public DeleteArtifactResponse DeleteArtifactWithOptions(DeleteArtifactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactId))
            {
                query["ArtifactId"] = request.ArtifactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactVersion))
            {
                query["ArtifactVersion"] = request.ArtifactVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteArtifact",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteArtifactResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除部署物
         *
         * @param request DeleteArtifactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteArtifactResponse
         */
        public async Task<DeleteArtifactResponse> DeleteArtifactWithOptionsAsync(DeleteArtifactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactId))
            {
                query["ArtifactId"] = request.ArtifactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactVersion))
            {
                query["ArtifactVersion"] = request.ArtifactVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteArtifact",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteArtifactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除部署物
         *
         * @param request DeleteArtifactRequest
         * @return DeleteArtifactResponse
         */
        public DeleteArtifactResponse DeleteArtifact(DeleteArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteArtifactWithOptions(request, runtime);
        }

        /**
         * @summary 删除部署物
         *
         * @param request DeleteArtifactRequest
         * @return DeleteArtifactResponse
         */
        public async Task<DeleteArtifactResponse> DeleteArtifactAsync(DeleteArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteArtifactWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceResponse
         */
        public DeleteServiceResponse DeleteServiceWithOptions(DeleteServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteService",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceResponse
         */
        public async Task<DeleteServiceResponse> DeleteServiceWithOptionsAsync(DeleteServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteService",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteServiceRequest
         * @return DeleteServiceResponse
         */
        public DeleteServiceResponse DeleteService(DeleteServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteServiceWithOptions(request, runtime);
        }

        /**
         * @param request DeleteServiceRequest
         * @return DeleteServiceResponse
         */
        public async Task<DeleteServiceResponse> DeleteServiceAsync(DeleteServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteServiceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteServiceInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceInstancesResponse
         */
        public DeleteServiceInstancesResponse DeleteServiceInstancesWithOptions(DeleteServiceInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceInstances",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteServiceInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceInstancesResponse
         */
        public async Task<DeleteServiceInstancesResponse> DeleteServiceInstancesWithOptionsAsync(DeleteServiceInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceInstances",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteServiceInstancesRequest
         * @return DeleteServiceInstancesResponse
         */
        public DeleteServiceInstancesResponse DeleteServiceInstances(DeleteServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteServiceInstancesWithOptions(request, runtime);
        }

        /**
         * @param request DeleteServiceInstancesRequest
         * @return DeleteServiceInstancesResponse
         */
        public async Task<DeleteServiceInstancesResponse> DeleteServiceInstancesAsync(DeleteServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteServiceInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeployServiceInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeployServiceInstanceResponse
         */
        public DeployServiceInstanceResponse DeployServiceInstanceWithOptions(DeployServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployServiceInstance",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployServiceInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeployServiceInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeployServiceInstanceResponse
         */
        public async Task<DeployServiceInstanceResponse> DeployServiceInstanceWithOptionsAsync(DeployServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployServiceInstance",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployServiceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeployServiceInstanceRequest
         * @return DeployServiceInstanceResponse
         */
        public DeployServiceInstanceResponse DeployServiceInstance(DeployServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeployServiceInstanceWithOptions(request, runtime);
        }

        /**
         * @param request DeployServiceInstanceRequest
         * @return DeployServiceInstanceResponse
         */
        public async Task<DeployServiceInstanceResponse> DeployServiceInstanceAsync(DeployServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeployServiceInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取部署物信息
         *
         * @param request GetArtifactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetArtifactResponse
         */
        public GetArtifactResponse GetArtifactWithOptions(GetArtifactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactId))
            {
                query["ArtifactId"] = request.ArtifactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactName))
            {
                query["ArtifactName"] = request.ArtifactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactVersion))
            {
                query["ArtifactVersion"] = request.ArtifactVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArtifact",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetArtifactResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取部署物信息
         *
         * @param request GetArtifactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetArtifactResponse
         */
        public async Task<GetArtifactResponse> GetArtifactWithOptionsAsync(GetArtifactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactId))
            {
                query["ArtifactId"] = request.ArtifactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactName))
            {
                query["ArtifactName"] = request.ArtifactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactVersion))
            {
                query["ArtifactVersion"] = request.ArtifactVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArtifact",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetArtifactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取部署物信息
         *
         * @param request GetArtifactRequest
         * @return GetArtifactResponse
         */
        public GetArtifactResponse GetArtifact(GetArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetArtifactWithOptions(request, runtime);
        }

        /**
         * @summary 获取部署物信息
         *
         * @param request GetArtifactRequest
         * @return GetArtifactResponse
         */
        public async Task<GetArtifactResponse> GetArtifactAsync(GetArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetArtifactWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取部署物仓库访问凭证
         *
         * @param request GetArtifactRepositoryCredentialsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetArtifactRepositoryCredentialsResponse
         */
        public GetArtifactRepositoryCredentialsResponse GetArtifactRepositoryCredentialsWithOptions(GetArtifactRepositoryCredentialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactType))
            {
                query["ArtifactType"] = request.ArtifactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployRegionId))
            {
                query["DeployRegionId"] = request.DeployRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArtifactRepositoryCredentials",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetArtifactRepositoryCredentialsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取部署物仓库访问凭证
         *
         * @param request GetArtifactRepositoryCredentialsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetArtifactRepositoryCredentialsResponse
         */
        public async Task<GetArtifactRepositoryCredentialsResponse> GetArtifactRepositoryCredentialsWithOptionsAsync(GetArtifactRepositoryCredentialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactType))
            {
                query["ArtifactType"] = request.ArtifactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployRegionId))
            {
                query["DeployRegionId"] = request.DeployRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArtifactRepositoryCredentials",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetArtifactRepositoryCredentialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取部署物仓库访问凭证
         *
         * @param request GetArtifactRepositoryCredentialsRequest
         * @return GetArtifactRepositoryCredentialsResponse
         */
        public GetArtifactRepositoryCredentialsResponse GetArtifactRepositoryCredentials(GetArtifactRepositoryCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetArtifactRepositoryCredentialsWithOptions(request, runtime);
        }

        /**
         * @summary 获取部署物仓库访问凭证
         *
         * @param request GetArtifactRepositoryCredentialsRequest
         * @return GetArtifactRepositoryCredentialsResponse
         */
        public async Task<GetArtifactRepositoryCredentialsResponse> GetArtifactRepositoryCredentialsAsync(GetArtifactRepositoryCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetArtifactRepositoryCredentialsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询服务详情
         *
         * @param request GetServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceResponse
         */
        public GetServiceResponse GetServiceWithOptions(GetServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterAliUid))
            {
                query["FilterAliUid"] = request.FilterAliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharedAccountType))
            {
                query["SharedAccountType"] = request.SharedAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDetail))
            {
                query["ShowDetail"] = request.ShowDetail;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetService",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询服务详情
         *
         * @param request GetServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceResponse
         */
        public async Task<GetServiceResponse> GetServiceWithOptionsAsync(GetServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterAliUid))
            {
                query["FilterAliUid"] = request.FilterAliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharedAccountType))
            {
                query["SharedAccountType"] = request.SharedAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDetail))
            {
                query["ShowDetail"] = request.ShowDetail;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetService",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询服务详情
         *
         * @param request GetServiceRequest
         * @return GetServiceResponse
         */
        public GetServiceResponse GetService(GetServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceWithOptions(request, runtime);
        }

        /**
         * @summary 查询服务详情
         *
         * @param request GetServiceRequest
         * @return GetServiceResponse
         */
        public async Task<GetServiceResponse> GetServiceAsync(GetServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 计算巢服务部署询价
         *
         * @param tmpReq GetServiceEstimateCostRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceEstimateCostResponse
         */
        public GetServiceEstimateCostResponse GetServiceEstimateCostWithOptions(GetServiceEstimateCostRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetServiceEstimateCostShrinkRequest request = new GetServiceEstimateCostShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Commodity))
            {
                request.CommodityShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Commodity, "Commodity", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityShrink))
            {
                query["Commodity"] = request.CommodityShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecificationName))
            {
                query["SpecificationName"] = request.SpecificationName;
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
                Action = "GetServiceEstimateCost",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceEstimateCostResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 计算巢服务部署询价
         *
         * @param tmpReq GetServiceEstimateCostRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceEstimateCostResponse
         */
        public async Task<GetServiceEstimateCostResponse> GetServiceEstimateCostWithOptionsAsync(GetServiceEstimateCostRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetServiceEstimateCostShrinkRequest request = new GetServiceEstimateCostShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Commodity))
            {
                request.CommodityShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Commodity, "Commodity", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityShrink))
            {
                query["Commodity"] = request.CommodityShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecificationName))
            {
                query["SpecificationName"] = request.SpecificationName;
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
                Action = "GetServiceEstimateCost",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceEstimateCostResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 计算巢服务部署询价
         *
         * @param request GetServiceEstimateCostRequest
         * @return GetServiceEstimateCostResponse
         */
        public GetServiceEstimateCostResponse GetServiceEstimateCost(GetServiceEstimateCostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceEstimateCostWithOptions(request, runtime);
        }

        /**
         * @summary 计算巢服务部署询价
         *
         * @param request GetServiceEstimateCostRequest
         * @return GetServiceEstimateCostResponse
         */
        public async Task<GetServiceEstimateCostResponse> GetServiceEstimateCostAsync(GetServiceEstimateCostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceEstimateCostWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetServiceInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceInstanceResponse
         */
        public GetServiceInstanceResponse GetServiceInstanceWithOptions(GetServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceInstance",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetServiceInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceInstanceResponse
         */
        public async Task<GetServiceInstanceResponse> GetServiceInstanceWithOptionsAsync(GetServiceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceInstance",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetServiceInstanceRequest
         * @return GetServiceInstanceResponse
         */
        public GetServiceInstanceResponse GetServiceInstance(GetServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceInstanceWithOptions(request, runtime);
        }

        /**
         * @param request GetServiceInstanceRequest
         * @return GetServiceInstanceResponse
         */
        public async Task<GetServiceInstanceResponse> GetServiceInstanceAsync(GetServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取ROS模板参数限制
         *
         * @param request GetServiceTemplateParameterConstraintsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceTemplateParameterConstraintsResponse
         */
        public GetServiceTemplateParameterConstraintsResponse GetServiceTemplateParameterConstraintsWithOptions(GetServiceTemplateParameterConstraintsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployRegionId))
            {
                query["DeployRegionId"] = request.DeployRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePrivateVpcConnection))
            {
                query["EnablePrivateVpcConnection"] = request.EnablePrivateVpcConnection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
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
                Action = "GetServiceTemplateParameterConstraints",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceTemplateParameterConstraintsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取ROS模板参数限制
         *
         * @param request GetServiceTemplateParameterConstraintsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceTemplateParameterConstraintsResponse
         */
        public async Task<GetServiceTemplateParameterConstraintsResponse> GetServiceTemplateParameterConstraintsWithOptionsAsync(GetServiceTemplateParameterConstraintsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployRegionId))
            {
                query["DeployRegionId"] = request.DeployRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePrivateVpcConnection))
            {
                query["EnablePrivateVpcConnection"] = request.EnablePrivateVpcConnection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
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
                Action = "GetServiceTemplateParameterConstraints",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceTemplateParameterConstraintsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取ROS模板参数限制
         *
         * @param request GetServiceTemplateParameterConstraintsRequest
         * @return GetServiceTemplateParameterConstraintsResponse
         */
        public GetServiceTemplateParameterConstraintsResponse GetServiceTemplateParameterConstraints(GetServiceTemplateParameterConstraintsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceTemplateParameterConstraintsWithOptions(request, runtime);
        }

        /**
         * @summary 获取ROS模板参数限制
         *
         * @param request GetServiceTemplateParameterConstraintsRequest
         * @return GetServiceTemplateParameterConstraintsResponse
         */
        public async Task<GetServiceTemplateParameterConstraintsResponse> GetServiceTemplateParameterConstraintsAsync(GetServiceTemplateParameterConstraintsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceTemplateParameterConstraintsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetUploadCredentialsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUploadCredentialsResponse
         */
        public GetUploadCredentialsResponse GetUploadCredentialsWithOptions(GetUploadCredentialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUploadCredentials",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadCredentialsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetUploadCredentialsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUploadCredentialsResponse
         */
        public async Task<GetUploadCredentialsResponse> GetUploadCredentialsWithOptionsAsync(GetUploadCredentialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUploadCredentials",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadCredentialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetUploadCredentialsRequest
         * @return GetUploadCredentialsResponse
         */
        public GetUploadCredentialsResponse GetUploadCredentials(GetUploadCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUploadCredentialsWithOptions(request, runtime);
        }

        /**
         * @param request GetUploadCredentialsRequest
         * @return GetUploadCredentialsResponse
         */
        public async Task<GetUploadCredentialsResponse> GetUploadCredentialsAsync(GetUploadCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUploadCredentialsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 展示部署物
         *
         * @param request ListAcrImageRepositoriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAcrImageRepositoriesResponse
         */
        public ListAcrImageRepositoriesResponse ListAcrImageRepositoriesWithOptions(ListAcrImageRepositoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactType))
            {
                query["ArtifactType"] = request.ArtifactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAcrImageRepositories",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAcrImageRepositoriesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 展示部署物
         *
         * @param request ListAcrImageRepositoriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAcrImageRepositoriesResponse
         */
        public async Task<ListAcrImageRepositoriesResponse> ListAcrImageRepositoriesWithOptionsAsync(ListAcrImageRepositoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactType))
            {
                query["ArtifactType"] = request.ArtifactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAcrImageRepositories",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAcrImageRepositoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 展示部署物
         *
         * @param request ListAcrImageRepositoriesRequest
         * @return ListAcrImageRepositoriesResponse
         */
        public ListAcrImageRepositoriesResponse ListAcrImageRepositories(ListAcrImageRepositoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAcrImageRepositoriesWithOptions(request, runtime);
        }

        /**
         * @summary 展示部署物
         *
         * @param request ListAcrImageRepositoriesRequest
         * @return ListAcrImageRepositoriesResponse
         */
        public async Task<ListAcrImageRepositoriesResponse> ListAcrImageRepositoriesAsync(ListAcrImageRepositoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAcrImageRepositoriesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 展示部署物
         *
         * @param request ListAcrImageTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAcrImageTagsResponse
         */
        public ListAcrImageTagsResponse ListAcrImageTagsWithOptions(ListAcrImageTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactType))
            {
                query["ArtifactType"] = request.ArtifactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAcrImageTags",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAcrImageTagsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 展示部署物
         *
         * @param request ListAcrImageTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAcrImageTagsResponse
         */
        public async Task<ListAcrImageTagsResponse> ListAcrImageTagsWithOptionsAsync(ListAcrImageTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactType))
            {
                query["ArtifactType"] = request.ArtifactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAcrImageTags",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAcrImageTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 展示部署物
         *
         * @param request ListAcrImageTagsRequest
         * @return ListAcrImageTagsResponse
         */
        public ListAcrImageTagsResponse ListAcrImageTags(ListAcrImageTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAcrImageTagsWithOptions(request, runtime);
        }

        /**
         * @summary 展示部署物
         *
         * @param request ListAcrImageTagsRequest
         * @return ListAcrImageTagsResponse
         */
        public async Task<ListAcrImageTagsResponse> ListAcrImageTagsAsync(ListAcrImageTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAcrImageTagsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 展示部署物版本
         *
         * @param request ListArtifactVersionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListArtifactVersionsResponse
         */
        public ListArtifactVersionsResponse ListArtifactVersionsWithOptions(ListArtifactVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactId))
            {
                query["ArtifactId"] = request.ArtifactId;
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
                Action = "ListArtifactVersions",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListArtifactVersionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 展示部署物版本
         *
         * @param request ListArtifactVersionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListArtifactVersionsResponse
         */
        public async Task<ListArtifactVersionsResponse> ListArtifactVersionsWithOptionsAsync(ListArtifactVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactId))
            {
                query["ArtifactId"] = request.ArtifactId;
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
                Action = "ListArtifactVersions",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListArtifactVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 展示部署物版本
         *
         * @param request ListArtifactVersionsRequest
         * @return ListArtifactVersionsResponse
         */
        public ListArtifactVersionsResponse ListArtifactVersions(ListArtifactVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListArtifactVersionsWithOptions(request, runtime);
        }

        /**
         * @summary 展示部署物版本
         *
         * @param request ListArtifactVersionsRequest
         * @return ListArtifactVersionsResponse
         */
        public async Task<ListArtifactVersionsResponse> ListArtifactVersionsAsync(ListArtifactVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListArtifactVersionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 展示部署物
         *
         * @param request ListArtifactsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListArtifactsResponse
         */
        public ListArtifactsResponse ListArtifactsWithOptions(ListArtifactsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
                Action = "ListArtifacts",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListArtifactsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 展示部署物
         *
         * @param request ListArtifactsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListArtifactsResponse
         */
        public async Task<ListArtifactsResponse> ListArtifactsWithOptionsAsync(ListArtifactsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
                Action = "ListArtifacts",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListArtifactsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 展示部署物
         *
         * @param request ListArtifactsRequest
         * @return ListArtifactsResponse
         */
        public ListArtifactsResponse ListArtifacts(ListArtifactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListArtifactsWithOptions(request, runtime);
        }

        /**
         * @summary 展示部署物
         *
         * @param request ListArtifactsRequest
         * @return ListArtifactsResponse
         */
        public async Task<ListArtifactsResponse> ListArtifactsAsync(ListArtifactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListArtifactsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListServiceInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceInstancesResponse
         */
        public ListServiceInstancesResponse ListServiceInstancesWithOptions(ListServiceInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDeleted))
            {
                query["ShowDeleted"] = request.ShowDeleted;
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
                Action = "ListServiceInstances",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListServiceInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceInstancesResponse
         */
        public async Task<ListServiceInstancesResponse> ListServiceInstancesWithOptionsAsync(ListServiceInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDeleted))
            {
                query["ShowDeleted"] = request.ShowDeleted;
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
                Action = "ListServiceInstances",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListServiceInstancesRequest
         * @return ListServiceInstancesResponse
         */
        public ListServiceInstancesResponse ListServiceInstances(ListServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServiceInstancesWithOptions(request, runtime);
        }

        /**
         * @param request ListServiceInstancesRequest
         * @return ListServiceInstancesResponse
         */
        public async Task<ListServiceInstancesResponse> ListServiceInstancesAsync(ListServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServiceInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 商家获取服务使用申请接口
         *
         * @param request ListServiceUsagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceUsagesResponse
         */
        public ListServiceUsagesResponse ListServiceUsagesWithOptions(ListServiceUsagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierRole))
            {
                query["SupplierRole"] = request.SupplierRole;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceUsages",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceUsagesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 商家获取服务使用申请接口
         *
         * @param request ListServiceUsagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceUsagesResponse
         */
        public async Task<ListServiceUsagesResponse> ListServiceUsagesWithOptionsAsync(ListServiceUsagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierRole))
            {
                query["SupplierRole"] = request.SupplierRole;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceUsages",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceUsagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 商家获取服务使用申请接口
         *
         * @param request ListServiceUsagesRequest
         * @return ListServiceUsagesResponse
         */
        public ListServiceUsagesResponse ListServiceUsages(ListServiceUsagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServiceUsagesWithOptions(request, runtime);
        }

        /**
         * @summary 商家获取服务使用申请接口
         *
         * @param request ListServiceUsagesRequest
         * @return ListServiceUsagesResponse
         */
        public async Task<ListServiceUsagesResponse> ListServiceUsagesAsync(ListServiceUsagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServiceUsagesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询服务
         *
         * @param request ListServicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServicesResponse
         */
        public ListServicesResponse ListServicesWithOptions(ListServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllVersions))
            {
                query["AllVersions"] = request.AllVersions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
                Action = "ListServices",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServicesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询服务
         *
         * @param request ListServicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServicesResponse
         */
        public async Task<ListServicesResponse> ListServicesWithOptionsAsync(ListServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllVersions))
            {
                query["AllVersions"] = request.AllVersions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
                Action = "ListServices",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询服务
         *
         * @param request ListServicesRequest
         * @return ListServicesResponse
         */
        public ListServicesResponse ListServices(ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServicesWithOptions(request, runtime);
        }

        /**
         * @summary 查询服务
         *
         * @param request ListServicesRequest
         * @return ListServicesResponse
         */
        public async Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServicesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改服务实例资源
         *
         * @param request ModifyServiceInstanceResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyServiceInstanceResourcesResponse
         */
        public ModifyServiceInstanceResourcesResponse ModifyServiceInstanceResourcesWithOptions(ModifyServiceInstanceResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceResourcesAction))
            {
                query["ServiceInstanceResourcesAction"] = request.ServiceInstanceResourcesAction;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyServiceInstanceResources",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyServiceInstanceResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改服务实例资源
         *
         * @param request ModifyServiceInstanceResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyServiceInstanceResourcesResponse
         */
        public async Task<ModifyServiceInstanceResourcesResponse> ModifyServiceInstanceResourcesWithOptionsAsync(ModifyServiceInstanceResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceResourcesAction))
            {
                query["ServiceInstanceResourcesAction"] = request.ServiceInstanceResourcesAction;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyServiceInstanceResources",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyServiceInstanceResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改服务实例资源
         *
         * @param request ModifyServiceInstanceResourcesRequest
         * @return ModifyServiceInstanceResourcesResponse
         */
        public ModifyServiceInstanceResourcesResponse ModifyServiceInstanceResources(ModifyServiceInstanceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyServiceInstanceResourcesWithOptions(request, runtime);
        }

        /**
         * @summary 修改服务实例资源
         *
         * @param request ModifyServiceInstanceResourcesRequest
         * @return ModifyServiceInstanceResourcesResponse
         */
        public async Task<ModifyServiceInstanceResourcesResponse> ModifyServiceInstanceResourcesAsync(ModifyServiceInstanceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyServiceInstanceResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request PushMeteringDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushMeteringDataResponse
         */
        public PushMeteringDataResponse PushMeteringDataWithOptions(PushMeteringDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metering))
            {
                query["Metering"] = request.Metering;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushMeteringData",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushMeteringDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request PushMeteringDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushMeteringDataResponse
         */
        public async Task<PushMeteringDataResponse> PushMeteringDataWithOptionsAsync(PushMeteringDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metering))
            {
                query["Metering"] = request.Metering;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushMeteringData",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushMeteringDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request PushMeteringDataRequest
         * @return PushMeteringDataResponse
         */
        public PushMeteringDataResponse PushMeteringData(PushMeteringDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushMeteringDataWithOptions(request, runtime);
        }

        /**
         * @param request PushMeteringDataRequest
         * @return PushMeteringDataResponse
         */
        public async Task<PushMeteringDataResponse> PushMeteringDataAsync(PushMeteringDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushMeteringDataWithOptionsAsync(request, runtime);
        }

        /**
         * @param request RegisterServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterServiceResponse
         */
        public RegisterServiceResponse RegisterServiceWithOptions(RegisterServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterService",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request RegisterServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterServiceResponse
         */
        public async Task<RegisterServiceResponse> RegisterServiceWithOptionsAsync(RegisterServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterService",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request RegisterServiceRequest
         * @return RegisterServiceResponse
         */
        public RegisterServiceResponse RegisterService(RegisterServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterServiceWithOptions(request, runtime);
        }

        /**
         * @param request RegisterServiceRequest
         * @return RegisterServiceResponse
         */
        public async Task<RegisterServiceResponse> RegisterServiceAsync(RegisterServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterServiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 发布部署物
         *
         * @param request ReleaseArtifactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseArtifactResponse
         */
        public ReleaseArtifactResponse ReleaseArtifactWithOptions(ReleaseArtifactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactId))
            {
                query["ArtifactId"] = request.ArtifactId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseArtifact",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseArtifactResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 发布部署物
         *
         * @param request ReleaseArtifactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseArtifactResponse
         */
        public async Task<ReleaseArtifactResponse> ReleaseArtifactWithOptionsAsync(ReleaseArtifactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactId))
            {
                query["ArtifactId"] = request.ArtifactId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseArtifact",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseArtifactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 发布部署物
         *
         * @param request ReleaseArtifactRequest
         * @return ReleaseArtifactResponse
         */
        public ReleaseArtifactResponse ReleaseArtifact(ReleaseArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseArtifactWithOptions(request, runtime);
        }

        /**
         * @summary 发布部署物
         *
         * @param request ReleaseArtifactRequest
         * @return ReleaseArtifactResponse
         */
        public async Task<ReleaseArtifactResponse> ReleaseArtifactAsync(ReleaseArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseArtifactWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新部署物
         *
         * @param tmpReq UpdateArtifactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateArtifactResponse
         */
        public UpdateArtifactResponse UpdateArtifactWithOptions(UpdateArtifactRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateArtifactShrinkRequest request = new UpdateArtifactShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ArtifactProperty))
            {
                request.ArtifactPropertyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ArtifactProperty, "ArtifactProperty", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactId))
            {
                query["ArtifactId"] = request.ArtifactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactPropertyShrink))
            {
                query["ArtifactProperty"] = request.ArtifactPropertyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportRegionIds))
            {
                query["SupportRegionIds"] = request.SupportRegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                query["VersionName"] = request.VersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateArtifact",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateArtifactResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新部署物
         *
         * @param tmpReq UpdateArtifactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateArtifactResponse
         */
        public async Task<UpdateArtifactResponse> UpdateArtifactWithOptionsAsync(UpdateArtifactRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateArtifactShrinkRequest request = new UpdateArtifactShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ArtifactProperty))
            {
                request.ArtifactPropertyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ArtifactProperty, "ArtifactProperty", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactId))
            {
                query["ArtifactId"] = request.ArtifactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactPropertyShrink))
            {
                query["ArtifactProperty"] = request.ArtifactPropertyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportRegionIds))
            {
                query["SupportRegionIds"] = request.SupportRegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                query["VersionName"] = request.VersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateArtifact",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateArtifactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新部署物
         *
         * @param request UpdateArtifactRequest
         * @return UpdateArtifactResponse
         */
        public UpdateArtifactResponse UpdateArtifact(UpdateArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateArtifactWithOptions(request, runtime);
        }

        /**
         * @summary 更新部署物
         *
         * @param request UpdateArtifactRequest
         * @return UpdateArtifactResponse
         */
        public async Task<UpdateArtifactResponse> UpdateArtifactAsync(UpdateArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateArtifactWithOptionsAsync(request, runtime);
        }

        /**
         * @param tmpReq UpdateServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceResponse
         */
        public UpdateServiceResponse UpdateServiceWithOptions(UpdateServiceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateServiceShrinkRequest request = new UpdateServiceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateOption))
            {
                request.UpdateOptionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateOption, "UpdateOption", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmMetadata))
            {
                query["AlarmMetadata"] = request.AlarmMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployMetadata))
            {
                query["DeployMetadata"] = request.DeployMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                query["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSupportOperated))
            {
                query["IsSupportOperated"] = request.IsSupportOperated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseMetadata))
            {
                query["LicenseMetadata"] = request.LicenseMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogMetadata))
            {
                query["LogMetadata"] = request.LogMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationMetadata))
            {
                query["OperationMetadata"] = request.OperationMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyNames))
            {
                query["PolicyNames"] = request.PolicyNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resellable))
            {
                query["Resellable"] = request.Resellable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInfo))
            {
                query["ServiceInfo"] = request.ServiceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantType))
            {
                query["TenantType"] = request.TenantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrialDuration))
            {
                query["TrialDuration"] = request.TrialDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateOptionShrink))
            {
                query["UpdateOption"] = request.UpdateOptionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeMetadata))
            {
                query["UpgradeMetadata"] = request.UpgradeMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                query["VersionName"] = request.VersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateService",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param tmpReq UpdateServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceResponse
         */
        public async Task<UpdateServiceResponse> UpdateServiceWithOptionsAsync(UpdateServiceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateServiceShrinkRequest request = new UpdateServiceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateOption))
            {
                request.UpdateOptionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateOption, "UpdateOption", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmMetadata))
            {
                query["AlarmMetadata"] = request.AlarmMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployMetadata))
            {
                query["DeployMetadata"] = request.DeployMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                query["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSupportOperated))
            {
                query["IsSupportOperated"] = request.IsSupportOperated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseMetadata))
            {
                query["LicenseMetadata"] = request.LicenseMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogMetadata))
            {
                query["LogMetadata"] = request.LogMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationMetadata))
            {
                query["OperationMetadata"] = request.OperationMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyNames))
            {
                query["PolicyNames"] = request.PolicyNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resellable))
            {
                query["Resellable"] = request.Resellable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInfo))
            {
                query["ServiceInfo"] = request.ServiceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantType))
            {
                query["TenantType"] = request.TenantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrialDuration))
            {
                query["TrialDuration"] = request.TrialDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateOptionShrink))
            {
                query["UpdateOption"] = request.UpdateOptionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeMetadata))
            {
                query["UpgradeMetadata"] = request.UpgradeMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                query["VersionName"] = request.VersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateService",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateServiceRequest
         * @return UpdateServiceResponse
         */
        public UpdateServiceResponse UpdateService(UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateServiceWithOptions(request, runtime);
        }

        /**
         * @param request UpdateServiceRequest
         * @return UpdateServiceResponse
         */
        public async Task<UpdateServiceResponse> UpdateServiceAsync(UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateServiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新服务实例属性
         *
         * @param request UpdateServiceInstanceAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceInstanceAttributeResponse
         */
        public UpdateServiceInstanceAttributeResponse UpdateServiceInstanceAttributeWithOptions(UpdateServiceInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceInstanceAttribute",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceInstanceAttributeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新服务实例属性
         *
         * @param request UpdateServiceInstanceAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceInstanceAttributeResponse
         */
        public async Task<UpdateServiceInstanceAttributeResponse> UpdateServiceInstanceAttributeWithOptionsAsync(UpdateServiceInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceInstanceAttribute",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceInstanceAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新服务实例属性
         *
         * @param request UpdateServiceInstanceAttributeRequest
         * @return UpdateServiceInstanceAttributeResponse
         */
        public UpdateServiceInstanceAttributeResponse UpdateServiceInstanceAttribute(UpdateServiceInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateServiceInstanceAttributeWithOptions(request, runtime);
        }

        /**
         * @summary 更新服务实例属性
         *
         * @param request UpdateServiceInstanceAttributeRequest
         * @return UpdateServiceInstanceAttributeResponse
         */
        public async Task<UpdateServiceInstanceAttributeResponse> UpdateServiceInstanceAttributeAsync(UpdateServiceInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateServiceInstanceAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 变配服务实例
         *
         * @param tmpReq UpdateServiceInstanceSpecRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceInstanceSpecResponse
         */
        public UpdateServiceInstanceSpecResponse UpdateServiceInstanceSpecWithOptions(UpdateServiceInstanceSpecRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateServiceInstanceSpecShrinkRequest request = new UpdateServiceInstanceSpecShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableUserPrometheus))
            {
                query["EnableUserPrometheus"] = request.EnableUserPrometheus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationName))
            {
                query["OperationName"] = request.OperationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredefinedParametersName))
            {
                query["PredefinedParametersName"] = request.PredefinedParametersName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceInstanceSpec",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceInstanceSpecResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 变配服务实例
         *
         * @param tmpReq UpdateServiceInstanceSpecRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceInstanceSpecResponse
         */
        public async Task<UpdateServiceInstanceSpecResponse> UpdateServiceInstanceSpecWithOptionsAsync(UpdateServiceInstanceSpecRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateServiceInstanceSpecShrinkRequest request = new UpdateServiceInstanceSpecShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableUserPrometheus))
            {
                query["EnableUserPrometheus"] = request.EnableUserPrometheus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationName))
            {
                query["OperationName"] = request.OperationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredefinedParametersName))
            {
                query["PredefinedParametersName"] = request.PredefinedParametersName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceInstanceSpec",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceInstanceSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 变配服务实例
         *
         * @param request UpdateServiceInstanceSpecRequest
         * @return UpdateServiceInstanceSpecResponse
         */
        public UpdateServiceInstanceSpecResponse UpdateServiceInstanceSpec(UpdateServiceInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateServiceInstanceSpecWithOptions(request, runtime);
        }

        /**
         * @summary 变配服务实例
         *
         * @param request UpdateServiceInstanceSpecRequest
         * @return UpdateServiceInstanceSpecResponse
         */
        public async Task<UpdateServiceInstanceSpecResponse> UpdateServiceInstanceSpecAsync(UpdateServiceInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateServiceInstanceSpecWithOptionsAsync(request, runtime);
        }

        /**
         * @param tmpReq UpgradeServiceInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeServiceInstanceResponse
         */
        public UpgradeServiceInstanceResponse UpgradeServiceInstanceWithOptions(UpgradeServiceInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpgradeServiceInstanceShrinkRequest request = new UpgradeServiceInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeServiceInstance",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeServiceInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param tmpReq UpgradeServiceInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeServiceInstanceResponse
         */
        public async Task<UpgradeServiceInstanceResponse> UpgradeServiceInstanceWithOptionsAsync(UpgradeServiceInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpgradeServiceInstanceShrinkRequest request = new UpgradeServiceInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceInstanceId))
            {
                query["ServiceInstanceId"] = request.ServiceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeServiceInstance",
                Version = "2021-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeServiceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpgradeServiceInstanceRequest
         * @return UpgradeServiceInstanceResponse
         */
        public UpgradeServiceInstanceResponse UpgradeServiceInstance(UpgradeServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeServiceInstanceWithOptions(request, runtime);
        }

        /**
         * @param request UpgradeServiceInstanceRequest
         * @return UpgradeServiceInstanceResponse
         */
        public async Task<UpgradeServiceInstanceResponse> UpgradeServiceInstanceAsync(UpgradeServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeServiceInstanceWithOptionsAsync(request, runtime);
        }

    }
}
