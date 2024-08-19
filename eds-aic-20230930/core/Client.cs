// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Eds_aic20230930.Models;

namespace AlibabaCloud.SDK.Eds_aic20230930
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("eds-aic", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 绑定密钥对
         *
         * @param request AttachKeyPairRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachKeyPairResponse
         */
        public AttachKeyPairResponse AttachKeyPairWithOptions(AttachKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairId))
            {
                query["KeyPairId"] = request.KeyPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachKeyPair",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachKeyPairResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 绑定密钥对
         *
         * @param request AttachKeyPairRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachKeyPairResponse
         */
        public async Task<AttachKeyPairResponse> AttachKeyPairWithOptionsAsync(AttachKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairId))
            {
                query["KeyPairId"] = request.KeyPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachKeyPair",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachKeyPairResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 绑定密钥对
         *
         * @param request AttachKeyPairRequest
         * @return AttachKeyPairResponse
         */
        public AttachKeyPairResponse AttachKeyPair(AttachKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachKeyPairWithOptions(request, runtime);
        }

        /**
         * @summary 绑定密钥对
         *
         * @param request AttachKeyPairRequest
         * @return AttachKeyPairResponse
         */
        public async Task<AttachKeyPairResponse> AttachKeyPairAsync(AttachKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachKeyPairWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 为用户授权/解授权安卓实例
         *
         * @param request AuthorizeAndroidInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AuthorizeAndroidInstanceResponse
         */
        public AuthorizeAndroidInstanceResponse AuthorizeAndroidInstanceWithOptions(AuthorizeAndroidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizeUserId))
            {
                query["AuthorizeUserId"] = request.AuthorizeUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnAuthorizeUserId))
            {
                query["UnAuthorizeUserId"] = request.UnAuthorizeUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeAndroidInstance",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeAndroidInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 为用户授权/解授权安卓实例
         *
         * @param request AuthorizeAndroidInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AuthorizeAndroidInstanceResponse
         */
        public async Task<AuthorizeAndroidInstanceResponse> AuthorizeAndroidInstanceWithOptionsAsync(AuthorizeAndroidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizeUserId))
            {
                query["AuthorizeUserId"] = request.AuthorizeUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnAuthorizeUserId))
            {
                query["UnAuthorizeUserId"] = request.UnAuthorizeUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeAndroidInstance",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeAndroidInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 为用户授权/解授权安卓实例
         *
         * @param request AuthorizeAndroidInstanceRequest
         * @return AuthorizeAndroidInstanceResponse
         */
        public AuthorizeAndroidInstanceResponse AuthorizeAndroidInstance(AuthorizeAndroidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthorizeAndroidInstanceWithOptions(request, runtime);
        }

        /**
         * @summary 为用户授权/解授权安卓实例
         *
         * @param request AuthorizeAndroidInstanceRequest
         * @return AuthorizeAndroidInstanceResponse
         */
        public async Task<AuthorizeAndroidInstanceResponse> AuthorizeAndroidInstanceAsync(AuthorizeAndroidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthorizeAndroidInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request BackupFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BackupFileResponse
         */
        public BackupFileResponse BackupFileWithOptions(BackupFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIdList))
            {
                query["AndroidInstanceIdList"] = request.AndroidInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFilePath))
            {
                query["BackupFilePath"] = request.BackupFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFilePathList))
            {
                query["SourceFilePathList"] = request.SourceFilePathList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadEndpoint))
            {
                query["UploadEndpoint"] = request.UploadEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadType))
            {
                query["UploadType"] = request.UploadType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BackupFile",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BackupFileResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request BackupFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BackupFileResponse
         */
        public async Task<BackupFileResponse> BackupFileWithOptionsAsync(BackupFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIdList))
            {
                query["AndroidInstanceIdList"] = request.AndroidInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFilePath))
            {
                query["BackupFilePath"] = request.BackupFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFilePathList))
            {
                query["SourceFilePathList"] = request.SourceFilePathList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadEndpoint))
            {
                query["UploadEndpoint"] = request.UploadEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadType))
            {
                query["UploadType"] = request.UploadType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BackupFile",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BackupFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request BackupFileRequest
         * @return BackupFileResponse
         */
        public BackupFileResponse BackupFile(BackupFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BackupFileWithOptions(request, runtime);
        }

        /**
         * @param request BackupFileRequest
         * @return BackupFileResponse
         */
        public async Task<BackupFileResponse> BackupFileAsync(BackupFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BackupFileWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 检查资源库存
         *
         * @param request CheckResourceStockRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckResourceStockResponse
         */
        public CheckResourceStockResponse CheckResourceStockWithOptions(CheckResourceStockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcpSpecId))
            {
                query["AcpSpecId"] = request.AcpSpecId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuAcceleration))
            {
                query["GpuAcceleration"] = request.GpuAcceleration;
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
                Action = "CheckResourceStock",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckResourceStockResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 检查资源库存
         *
         * @param request CheckResourceStockRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckResourceStockResponse
         */
        public async Task<CheckResourceStockResponse> CheckResourceStockWithOptionsAsync(CheckResourceStockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcpSpecId))
            {
                query["AcpSpecId"] = request.AcpSpecId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuAcceleration))
            {
                query["GpuAcceleration"] = request.GpuAcceleration;
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
                Action = "CheckResourceStock",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckResourceStockResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 检查资源库存
         *
         * @param request CheckResourceStockRequest
         * @return CheckResourceStockResponse
         */
        public CheckResourceStockResponse CheckResourceStock(CheckResourceStockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckResourceStockWithOptions(request, runtime);
        }

        /**
         * @summary 检查资源库存
         *
         * @param request CheckResourceStockRequest
         * @return CheckResourceStockResponse
         */
        public async Task<CheckResourceStockResponse> CheckResourceStockAsync(CheckResourceStockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckResourceStockWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建安卓实例组
         *
         * @param request CreateAndroidInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAndroidInstanceGroupResponse
         */
        public CreateAndroidInstanceGroupResponse CreateAndroidInstanceGroupWithOptions(CreateAndroidInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuAcceleration))
            {
                query["GpuAcceleration"] = request.GpuAcceleration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupName))
            {
                query["InstanceGroupName"] = request.InstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupSpec))
            {
                query["InstanceGroupSpec"] = request.InstanceGroupSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberOfInstances))
            {
                query["NumberOfInstances"] = request.NumberOfInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupId))
            {
                query["PolicyGroupId"] = request.PolicyGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAndroidInstanceGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAndroidInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建安卓实例组
         *
         * @param request CreateAndroidInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAndroidInstanceGroupResponse
         */
        public async Task<CreateAndroidInstanceGroupResponse> CreateAndroidInstanceGroupWithOptionsAsync(CreateAndroidInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuAcceleration))
            {
                query["GpuAcceleration"] = request.GpuAcceleration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupName))
            {
                query["InstanceGroupName"] = request.InstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupSpec))
            {
                query["InstanceGroupSpec"] = request.InstanceGroupSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberOfInstances))
            {
                query["NumberOfInstances"] = request.NumberOfInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupId))
            {
                query["PolicyGroupId"] = request.PolicyGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAndroidInstanceGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAndroidInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建安卓实例组
         *
         * @param request CreateAndroidInstanceGroupRequest
         * @return CreateAndroidInstanceGroupResponse
         */
        public CreateAndroidInstanceGroupResponse CreateAndroidInstanceGroup(CreateAndroidInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAndroidInstanceGroupWithOptions(request, runtime);
        }

        /**
         * @summary 创建安卓实例组
         *
         * @param request CreateAndroidInstanceGroupRequest
         * @return CreateAndroidInstanceGroupResponse
         */
        public async Task<CreateAndroidInstanceGroupResponse> CreateAndroidInstanceGroupAsync(CreateAndroidInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAndroidInstanceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppResponse
         */
        public CreateAppResponse CreateAppWithOptions(CreateAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconUrl))
            {
                query["IconUrl"] = request.IconUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstallParam))
            {
                query["InstallParam"] = request.InstallParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAppUrl))
            {
                query["OssAppUrl"] = request.OssAppUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApp",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppResponse
         */
        public async Task<CreateAppResponse> CreateAppWithOptionsAsync(CreateAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconUrl))
            {
                query["IconUrl"] = request.IconUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstallParam))
            {
                query["InstallParam"] = request.InstallParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAppUrl))
            {
                query["OssAppUrl"] = request.OssAppUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApp",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateAppRequest
         * @return CreateAppResponse
         */
        public CreateAppResponse CreateApp(CreateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppWithOptions(request, runtime);
        }

        /**
         * @param request CreateAppRequest
         * @return CreateAppResponse
         */
        public async Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建自定义镜像
         *
         * @param request CreateCustomImageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCustomImageResponse
         */
        public CreateCustomImageResponse CreateCustomImageWithOptions(CreateCustomImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                body["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomImage",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomImageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建自定义镜像
         *
         * @param request CreateCustomImageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCustomImageResponse
         */
        public async Task<CreateCustomImageResponse> CreateCustomImageWithOptionsAsync(CreateCustomImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                body["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomImage",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建自定义镜像
         *
         * @param request CreateCustomImageRequest
         * @return CreateCustomImageResponse
         */
        public CreateCustomImageResponse CreateCustomImage(CreateCustomImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomImageWithOptions(request, runtime);
        }

        /**
         * @summary 创建自定义镜像
         *
         * @param request CreateCustomImageRequest
         * @return CreateCustomImageResponse
         */
        public async Task<CreateCustomImageResponse> CreateCustomImageAsync(CreateCustomImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomImageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建密钥对
         *
         * @param request CreateKeyPairRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateKeyPairResponse
         */
        public CreateKeyPairResponse CreateKeyPairWithOptions(CreateKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKeyPair",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKeyPairResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建密钥对
         *
         * @param request CreateKeyPairRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateKeyPairResponse
         */
        public async Task<CreateKeyPairResponse> CreateKeyPairWithOptionsAsync(CreateKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKeyPair",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKeyPairResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建密钥对
         *
         * @param request CreateKeyPairRequest
         * @return CreateKeyPairResponse
         */
        public CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateKeyPairWithOptions(request, runtime);
        }

        /**
         * @summary 创建密钥对
         *
         * @param request CreateKeyPairRequest
         * @return CreateKeyPairResponse
         */
        public async Task<CreateKeyPairResponse> CreateKeyPairAsync(CreateKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateKeyPairWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建策略
         *
         * @param tmpReq CreatePolicyGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePolicyGroupResponse
         */
        public CreatePolicyGroupResponse CreatePolicyGroupWithOptions(CreatePolicyGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePolicyGroupShrinkRequest request = new CreatePolicyGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetRedirectPolicy))
            {
                request.NetRedirectPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetRedirectPolicy, "NetRedirectPolicy", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CameraRedirect))
            {
                body["CameraRedirect"] = request.CameraRedirect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clipboard))
            {
                body["Clipboard"] = request.Clipboard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Html5FileTransfer))
            {
                body["Html5FileTransfer"] = request.Html5FileTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalDrive))
            {
                body["LocalDrive"] = request.LocalDrive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetRedirectPolicyShrink))
            {
                body["NetRedirectPolicy"] = request.NetRedirectPolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupName))
            {
                body["PolicyGroupName"] = request.PolicyGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolutionHeight))
            {
                body["ResolutionHeight"] = request.ResolutionHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolutionWidth))
            {
                body["ResolutionWidth"] = request.ResolutionWidth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicyGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicyGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建策略
         *
         * @param tmpReq CreatePolicyGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePolicyGroupResponse
         */
        public async Task<CreatePolicyGroupResponse> CreatePolicyGroupWithOptionsAsync(CreatePolicyGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePolicyGroupShrinkRequest request = new CreatePolicyGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetRedirectPolicy))
            {
                request.NetRedirectPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetRedirectPolicy, "NetRedirectPolicy", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CameraRedirect))
            {
                body["CameraRedirect"] = request.CameraRedirect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clipboard))
            {
                body["Clipboard"] = request.Clipboard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Html5FileTransfer))
            {
                body["Html5FileTransfer"] = request.Html5FileTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalDrive))
            {
                body["LocalDrive"] = request.LocalDrive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetRedirectPolicyShrink))
            {
                body["NetRedirectPolicy"] = request.NetRedirectPolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupName))
            {
                body["PolicyGroupName"] = request.PolicyGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolutionHeight))
            {
                body["ResolutionHeight"] = request.ResolutionHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolutionWidth))
            {
                body["ResolutionWidth"] = request.ResolutionWidth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicyGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicyGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建策略
         *
         * @param request CreatePolicyGroupRequest
         * @return CreatePolicyGroupResponse
         */
        public CreatePolicyGroupResponse CreatePolicyGroup(CreatePolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePolicyGroupWithOptions(request, runtime);
        }

        /**
         * @summary 创建策略
         *
         * @param request CreatePolicyGroupRequest
         * @return CreatePolicyGroupResponse
         */
        public async Task<CreatePolicyGroupResponse> CreatePolicyGroupAsync(CreatePolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePolicyGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除安卓实例组
         *
         * @param request DeleteAndroidInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAndroidInstanceGroupResponse
         */
        public DeleteAndroidInstanceGroupResponse DeleteAndroidInstanceGroupWithOptions(DeleteAndroidInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIds))
            {
                query["InstanceGroupIds"] = request.InstanceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAndroidInstanceGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAndroidInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除安卓实例组
         *
         * @param request DeleteAndroidInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAndroidInstanceGroupResponse
         */
        public async Task<DeleteAndroidInstanceGroupResponse> DeleteAndroidInstanceGroupWithOptionsAsync(DeleteAndroidInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIds))
            {
                query["InstanceGroupIds"] = request.InstanceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAndroidInstanceGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAndroidInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除安卓实例组
         *
         * @param request DeleteAndroidInstanceGroupRequest
         * @return DeleteAndroidInstanceGroupResponse
         */
        public DeleteAndroidInstanceGroupResponse DeleteAndroidInstanceGroup(DeleteAndroidInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAndroidInstanceGroupWithOptions(request, runtime);
        }

        /**
         * @summary 删除安卓实例组
         *
         * @param request DeleteAndroidInstanceGroupRequest
         * @return DeleteAndroidInstanceGroupResponse
         */
        public async Task<DeleteAndroidInstanceGroupResponse> DeleteAndroidInstanceGroupAsync(DeleteAndroidInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAndroidInstanceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除app
         *
         * @param request DeleteAppsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppsResponse
         */
        public DeleteAppsResponse DeleteAppsWithOptions(DeleteAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIdList))
            {
                query["AppIdList"] = request.AppIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApps",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除app
         *
         * @param request DeleteAppsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppsResponse
         */
        public async Task<DeleteAppsResponse> DeleteAppsWithOptionsAsync(DeleteAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIdList))
            {
                query["AppIdList"] = request.AppIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApps",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除app
         *
         * @param request DeleteAppsRequest
         * @return DeleteAppsResponse
         */
        public DeleteAppsResponse DeleteApps(DeleteAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppsWithOptions(request, runtime);
        }

        /**
         * @summary 删除app
         *
         * @param request DeleteAppsRequest
         * @return DeleteAppsResponse
         */
        public async Task<DeleteAppsResponse> DeleteAppsAsync(DeleteAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppsWithOptionsAsync(request, runtime);
        }

        /**
         * @param tmpReq DeleteImagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteImagesResponse
         */
        public DeleteImagesResponse DeleteImagesWithOptions(DeleteImagesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteImagesShrinkRequest request = new DeleteImagesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageIds))
            {
                request.ImageIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageIds, "ImageIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageIdsShrink))
            {
                body["ImageIds"] = request.ImageIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteImages",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteImagesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param tmpReq DeleteImagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteImagesResponse
         */
        public async Task<DeleteImagesResponse> DeleteImagesWithOptionsAsync(DeleteImagesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteImagesShrinkRequest request = new DeleteImagesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageIds))
            {
                request.ImageIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageIds, "ImageIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageIdsShrink))
            {
                body["ImageIds"] = request.ImageIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteImages",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteImagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteImagesRequest
         * @return DeleteImagesResponse
         */
        public DeleteImagesResponse DeleteImages(DeleteImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteImagesWithOptions(request, runtime);
        }

        /**
         * @param request DeleteImagesRequest
         * @return DeleteImagesResponse
         */
        public async Task<DeleteImagesResponse> DeleteImagesAsync(DeleteImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteImagesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除密钥对
         *
         * @param request DeleteKeyPairsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteKeyPairsResponse
         */
        public DeleteKeyPairsResponse DeleteKeyPairsWithOptions(DeleteKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairIds))
            {
                query["KeyPairIds"] = request.KeyPairIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKeyPairs",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKeyPairsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除密钥对
         *
         * @param request DeleteKeyPairsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteKeyPairsResponse
         */
        public async Task<DeleteKeyPairsResponse> DeleteKeyPairsWithOptionsAsync(DeleteKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairIds))
            {
                query["KeyPairIds"] = request.KeyPairIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKeyPairs",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKeyPairsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除密钥对
         *
         * @param request DeleteKeyPairsRequest
         * @return DeleteKeyPairsResponse
         */
        public DeleteKeyPairsResponse DeleteKeyPairs(DeleteKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteKeyPairsWithOptions(request, runtime);
        }

        /**
         * @summary 删除密钥对
         *
         * @param request DeleteKeyPairsRequest
         * @return DeleteKeyPairsResponse
         */
        public async Task<DeleteKeyPairsResponse> DeleteKeyPairsAsync(DeleteKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteKeyPairsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除策略
         *
         * @param request DeletePolicyGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePolicyGroupResponse
         */
        public DeletePolicyGroupResponse DeletePolicyGroupWithOptions(DeletePolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupIds))
            {
                query["PolicyGroupIds"] = request.PolicyGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicyGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除策略
         *
         * @param request DeletePolicyGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePolicyGroupResponse
         */
        public async Task<DeletePolicyGroupResponse> DeletePolicyGroupWithOptionsAsync(DeletePolicyGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupIds))
            {
                query["PolicyGroupIds"] = request.PolicyGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicyGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除策略
         *
         * @param request DeletePolicyGroupRequest
         * @return DeletePolicyGroupResponse
         */
        public DeletePolicyGroupResponse DeletePolicyGroup(DeletePolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePolicyGroupWithOptions(request, runtime);
        }

        /**
         * @summary 删除策略
         *
         * @param request DeletePolicyGroupRequest
         * @return DeletePolicyGroupResponse
         */
        public async Task<DeletePolicyGroupResponse> DeletePolicyGroupAsync(DeletePolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePolicyGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询实例组
         *
         * @param request DescribeAndroidInstanceGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAndroidInstanceGroupsResponse
         */
        public DescribeAndroidInstanceGroupsResponse DescribeAndroidInstanceGroupsWithOptions(DescribeAndroidInstanceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIds))
            {
                query["InstanceGroupIds"] = request.InstanceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupName))
            {
                query["InstanceGroupName"] = request.InstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairId))
            {
                query["KeyPairId"] = request.KeyPairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupId))
            {
                query["PolicyGroupId"] = request.PolicyGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                query["SaleMode"] = request.SaleMode;
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
                Action = "DescribeAndroidInstanceGroups",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAndroidInstanceGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询实例组
         *
         * @param request DescribeAndroidInstanceGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAndroidInstanceGroupsResponse
         */
        public async Task<DescribeAndroidInstanceGroupsResponse> DescribeAndroidInstanceGroupsWithOptionsAsync(DescribeAndroidInstanceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIds))
            {
                query["InstanceGroupIds"] = request.InstanceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupName))
            {
                query["InstanceGroupName"] = request.InstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairId))
            {
                query["KeyPairId"] = request.KeyPairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupId))
            {
                query["PolicyGroupId"] = request.PolicyGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                query["SaleMode"] = request.SaleMode;
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
                Action = "DescribeAndroidInstanceGroups",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAndroidInstanceGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询实例组
         *
         * @param request DescribeAndroidInstanceGroupsRequest
         * @return DescribeAndroidInstanceGroupsResponse
         */
        public DescribeAndroidInstanceGroupsResponse DescribeAndroidInstanceGroups(DescribeAndroidInstanceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAndroidInstanceGroupsWithOptions(request, runtime);
        }

        /**
         * @summary 查询实例组
         *
         * @param request DescribeAndroidInstanceGroupsRequest
         * @return DescribeAndroidInstanceGroupsResponse
         */
        public async Task<DescribeAndroidInstanceGroupsResponse> DescribeAndroidInstanceGroupsAsync(DescribeAndroidInstanceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAndroidInstanceGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询安卓实例列表
         *
         * @param request DescribeAndroidInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAndroidInstancesResponse
         */
        public DescribeAndroidInstancesResponse DescribeAndroidInstancesWithOptions(DescribeAndroidInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceName))
            {
                query["AndroidInstanceName"] = request.AndroidInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupId))
            {
                query["InstanceGroupId"] = request.InstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIds))
            {
                query["InstanceGroupIds"] = request.InstanceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairId))
            {
                query["KeyPairId"] = request.KeyPairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                query["SaleMode"] = request.SaleMode;
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
                Action = "DescribeAndroidInstances",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAndroidInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询安卓实例列表
         *
         * @param request DescribeAndroidInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAndroidInstancesResponse
         */
        public async Task<DescribeAndroidInstancesResponse> DescribeAndroidInstancesWithOptionsAsync(DescribeAndroidInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceName))
            {
                query["AndroidInstanceName"] = request.AndroidInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupId))
            {
                query["InstanceGroupId"] = request.InstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIds))
            {
                query["InstanceGroupIds"] = request.InstanceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairId))
            {
                query["KeyPairId"] = request.KeyPairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleMode))
            {
                query["SaleMode"] = request.SaleMode;
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
                Action = "DescribeAndroidInstances",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAndroidInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询安卓实例列表
         *
         * @param request DescribeAndroidInstancesRequest
         * @return DescribeAndroidInstancesResponse
         */
        public DescribeAndroidInstancesResponse DescribeAndroidInstances(DescribeAndroidInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAndroidInstancesWithOptions(request, runtime);
        }

        /**
         * @summary 查询安卓实例列表
         *
         * @param request DescribeAndroidInstancesRequest
         * @return DescribeAndroidInstancesResponse
         */
        public async Task<DescribeAndroidInstancesResponse> DescribeAndroidInstancesAsync(DescribeAndroidInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAndroidInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询app
         *
         * @param request DescribeAppsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppsResponse
         */
        public DescribeAppsResponse DescribeAppsWithOptions(DescribeAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIdList))
            {
                query["AppIdList"] = request.AppIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstallationStatus))
            {
                query["InstallationStatus"] = request.InstallationStatus;
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
                Action = "DescribeApps",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询app
         *
         * @param request DescribeAppsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppsResponse
         */
        public async Task<DescribeAppsResponse> DescribeAppsWithOptionsAsync(DescribeAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIdList))
            {
                query["AppIdList"] = request.AppIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstallationStatus))
            {
                query["InstallationStatus"] = request.InstallationStatus;
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
                Action = "DescribeApps",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询app
         *
         * @param request DescribeAppsRequest
         * @return DescribeAppsResponse
         */
        public DescribeAppsResponse DescribeApps(DescribeAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppsWithOptions(request, runtime);
        }

        /**
         * @summary 查询app
         *
         * @param request DescribeAppsRequest
         * @return DescribeAppsResponse
         */
        public async Task<DescribeAppsResponse> DescribeAppsAsync(DescribeAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeBackupFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupFilesResponse
         */
        public DescribeBackupFilesResponse DescribeBackupFilesWithOptions(DescribeBackupFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceId))
            {
                query["AndroidInstanceId"] = request.AndroidInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceName))
            {
                query["AndroidInstanceName"] = request.AndroidInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFileId))
            {
                query["BackupFileId"] = request.BackupFileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFileName))
            {
                query["BackupFileName"] = request.BackupFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupId))
            {
                query["InstanceGroupId"] = request.InstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupFiles",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupFilesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeBackupFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupFilesResponse
         */
        public async Task<DescribeBackupFilesResponse> DescribeBackupFilesWithOptionsAsync(DescribeBackupFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceId))
            {
                query["AndroidInstanceId"] = request.AndroidInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceName))
            {
                query["AndroidInstanceName"] = request.AndroidInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFileId))
            {
                query["BackupFileId"] = request.BackupFileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFileName))
            {
                query["BackupFileName"] = request.BackupFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                query["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupId))
            {
                query["InstanceGroupId"] = request.InstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupFiles",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupFilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeBackupFilesRequest
         * @return DescribeBackupFilesResponse
         */
        public DescribeBackupFilesResponse DescribeBackupFiles(DescribeBackupFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupFilesWithOptions(request, runtime);
        }

        /**
         * @param request DescribeBackupFilesRequest
         * @return DescribeBackupFilesResponse
         */
        public async Task<DescribeBackupFilesResponse> DescribeBackupFilesAsync(DescribeBackupFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupFilesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeImageListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeImageListResponse
         */
        public DescribeImageListResponse DescribeImageListWithOptions(DescribeImageListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                body["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                body["ImageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeImageList",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeImageListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeImageListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeImageListResponse
         */
        public async Task<DescribeImageListResponse> DescribeImageListWithOptionsAsync(DescribeImageListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                body["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                body["ImageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeImageList",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeImageListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeImageListRequest
         * @return DescribeImageListResponse
         */
        public DescribeImageListResponse DescribeImageList(DescribeImageListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImageListWithOptions(request, runtime);
        }

        /**
         * @param request DescribeImageListRequest
         * @return DescribeImageListResponse
         */
        public async Task<DescribeImageListResponse> DescribeImageListAsync(DescribeImageListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImageListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询命令结果
         *
         * @param request DescribeInvocationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInvocationsResponse
         */
        public DescribeInvocationsResponse DescribeInvocationsWithOptions(DescribeInvocationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvocationId))
            {
                query["InvocationId"] = request.InvocationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInvocations",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInvocationsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询命令结果
         *
         * @param request DescribeInvocationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInvocationsResponse
         */
        public async Task<DescribeInvocationsResponse> DescribeInvocationsWithOptionsAsync(DescribeInvocationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvocationId))
            {
                query["InvocationId"] = request.InvocationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInvocations",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInvocationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询命令结果
         *
         * @param request DescribeInvocationsRequest
         * @return DescribeInvocationsResponse
         */
        public DescribeInvocationsResponse DescribeInvocations(DescribeInvocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInvocationsWithOptions(request, runtime);
        }

        /**
         * @summary 查询命令结果
         *
         * @param request DescribeInvocationsRequest
         * @return DescribeInvocationsResponse
         */
        public async Task<DescribeInvocationsResponse> DescribeInvocationsAsync(DescribeInvocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInvocationsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询密钥对
         *
         * @param request DescribeKeyPairsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeKeyPairsResponse
         */
        public DescribeKeyPairsResponse DescribeKeyPairsWithOptions(DescribeKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairIds))
            {
                query["KeyPairIds"] = request.KeyPairIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
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
                Action = "DescribeKeyPairs",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeKeyPairsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询密钥对
         *
         * @param request DescribeKeyPairsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeKeyPairsResponse
         */
        public async Task<DescribeKeyPairsResponse> DescribeKeyPairsWithOptionsAsync(DescribeKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairIds))
            {
                query["KeyPairIds"] = request.KeyPairIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
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
                Action = "DescribeKeyPairs",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeKeyPairsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询密钥对
         *
         * @param request DescribeKeyPairsRequest
         * @return DescribeKeyPairsResponse
         */
        public DescribeKeyPairsResponse DescribeKeyPairs(DescribeKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeKeyPairsWithOptions(request, runtime);
        }

        /**
         * @summary 查询密钥对
         *
         * @param request DescribeKeyPairsRequest
         * @return DescribeKeyPairsResponse
         */
        public async Task<DescribeKeyPairsResponse> DescribeKeyPairsAsync(DescribeKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeKeyPairsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询地域
         *
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2023-09-30",
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

        /**
         * @summary 查询地域
         *
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2023-09-30",
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

        /**
         * @summary 查询地域
         *
         * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(runtime);
        }

        /**
         * @summary 查询地域
         *
         * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(runtime);
        }

        /**
         * @summary 查询规格
         *
         * @param request DescribeSpecRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSpecResponse
         */
        public DescribeSpecResponse DescribeSpecWithOptions(DescribeSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecIds))
            {
                query["SpecIds"] = request.SpecIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecStatus))
            {
                query["SpecStatus"] = request.SpecStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSpec",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSpecResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询规格
         *
         * @param request DescribeSpecRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSpecResponse
         */
        public async Task<DescribeSpecResponse> DescribeSpecWithOptionsAsync(DescribeSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecIds))
            {
                query["SpecIds"] = request.SpecIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecStatus))
            {
                query["SpecStatus"] = request.SpecStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSpec",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询规格
         *
         * @param request DescribeSpecRequest
         * @return DescribeSpecResponse
         */
        public DescribeSpecResponse DescribeSpec(DescribeSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSpecWithOptions(request, runtime);
        }

        /**
         * @summary 查询规格
         *
         * @param request DescribeSpecRequest
         * @return DescribeSpecResponse
         */
        public async Task<DescribeSpecResponse> DescribeSpecAsync(DescribeSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSpecWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询异步任务
         *
         * @param request DescribeTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTasksResponse
         */
        public DescribeTasksResponse DescribeTasksWithOptions(DescribeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeId))
            {
                query["InvokeId"] = request.InvokeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                query["TaskIds"] = request.TaskIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                query["TaskStatus"] = request.TaskStatus;
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
                Action = "DescribeTasks",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询异步任务
         *
         * @param request DescribeTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTasksResponse
         */
        public async Task<DescribeTasksResponse> DescribeTasksWithOptionsAsync(DescribeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeId))
            {
                query["InvokeId"] = request.InvokeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                query["TaskIds"] = request.TaskIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                query["TaskStatus"] = request.TaskStatus;
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
                Action = "DescribeTasks",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询异步任务
         *
         * @param request DescribeTasksRequest
         * @return DescribeTasksResponse
         */
        public DescribeTasksResponse DescribeTasks(DescribeTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTasksWithOptions(request, runtime);
        }

        /**
         * @summary 查询异步任务
         *
         * @param request DescribeTasksRequest
         * @return DescribeTasksResponse
         */
        public async Task<DescribeTasksResponse> DescribeTasksAsync(DescribeTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 解绑密钥对
         *
         * @param request DetachKeyPairRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachKeyPairResponse
         */
        public DetachKeyPairResponse DetachKeyPairWithOptions(DetachKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairId))
            {
                query["KeyPairId"] = request.KeyPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachKeyPair",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachKeyPairResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 解绑密钥对
         *
         * @param request DetachKeyPairRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachKeyPairResponse
         */
        public async Task<DetachKeyPairResponse> DetachKeyPairWithOptionsAsync(DetachKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairId))
            {
                query["KeyPairId"] = request.KeyPairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachKeyPair",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachKeyPairResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 解绑密钥对
         *
         * @param request DetachKeyPairRequest
         * @return DetachKeyPairResponse
         */
        public DetachKeyPairResponse DetachKeyPair(DetachKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachKeyPairWithOptions(request, runtime);
        }

        /**
         * @summary 解绑密钥对
         *
         * @param request DetachKeyPairRequest
         * @return DetachKeyPairResponse
         */
        public async Task<DetachKeyPairResponse> DetachKeyPairAsync(DetachKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachKeyPairWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 自定义镜像分发
         *
         * @param request DistributeImageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DistributeImageResponse
         */
        public DistributeImageResponse DistributeImageWithOptions(DistributeImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributeRegionList))
            {
                body["DistributeRegionList"] = request.DistributeRegionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DistributeImage",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DistributeImageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 自定义镜像分发
         *
         * @param request DistributeImageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DistributeImageResponse
         */
        public async Task<DistributeImageResponse> DistributeImageWithOptionsAsync(DistributeImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributeRegionList))
            {
                body["DistributeRegionList"] = request.DistributeRegionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DistributeImage",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DistributeImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 自定义镜像分发
         *
         * @param request DistributeImageRequest
         * @return DistributeImageResponse
         */
        public DistributeImageResponse DistributeImage(DistributeImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DistributeImageWithOptions(request, runtime);
        }

        /**
         * @summary 自定义镜像分发
         *
         * @param request DistributeImageRequest
         * @return DistributeImageResponse
         */
        public async Task<DistributeImageResponse> DistributeImageAsync(DistributeImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DistributeImageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 实例组缩容
         *
         * @param request DowngradeAndroidInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DowngradeAndroidInstanceGroupResponse
         */
        public DowngradeAndroidInstanceGroupResponse DowngradeAndroidInstanceGroupWithOptions(DowngradeAndroidInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupId))
            {
                query["InstanceGroupId"] = request.InstanceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DowngradeAndroidInstanceGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DowngradeAndroidInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 实例组缩容
         *
         * @param request DowngradeAndroidInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DowngradeAndroidInstanceGroupResponse
         */
        public async Task<DowngradeAndroidInstanceGroupResponse> DowngradeAndroidInstanceGroupWithOptionsAsync(DowngradeAndroidInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupId))
            {
                query["InstanceGroupId"] = request.InstanceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DowngradeAndroidInstanceGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DowngradeAndroidInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 实例组缩容
         *
         * @param request DowngradeAndroidInstanceGroupRequest
         * @return DowngradeAndroidInstanceGroupResponse
         */
        public DowngradeAndroidInstanceGroupResponse DowngradeAndroidInstanceGroup(DowngradeAndroidInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DowngradeAndroidInstanceGroupWithOptions(request, runtime);
        }

        /**
         * @summary 实例组缩容
         *
         * @param request DowngradeAndroidInstanceGroupRequest
         * @return DowngradeAndroidInstanceGroupResponse
         */
        public async Task<DowngradeAndroidInstanceGroupResponse> DowngradeAndroidInstanceGroupAsync(DowngradeAndroidInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DowngradeAndroidInstanceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 云手机拉取文件到OSS
         *
         * @param request FetchFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FetchFileResponse
         */
        public FetchFileResponse FetchFileWithOptions(FetchFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIdList))
            {
                query["AndroidInstanceIdList"] = request.AndroidInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFilePath))
            {
                query["SourceFilePath"] = request.SourceFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadEndpoint))
            {
                query["UploadEndpoint"] = request.UploadEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadType))
            {
                query["UploadType"] = request.UploadType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadUrl))
            {
                query["UploadUrl"] = request.UploadUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FetchFile",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FetchFileResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 云手机拉取文件到OSS
         *
         * @param request FetchFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FetchFileResponse
         */
        public async Task<FetchFileResponse> FetchFileWithOptionsAsync(FetchFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIdList))
            {
                query["AndroidInstanceIdList"] = request.AndroidInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFilePath))
            {
                query["SourceFilePath"] = request.SourceFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadEndpoint))
            {
                query["UploadEndpoint"] = request.UploadEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadType))
            {
                query["UploadType"] = request.UploadType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadUrl))
            {
                query["UploadUrl"] = request.UploadUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FetchFile",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FetchFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 云手机拉取文件到OSS
         *
         * @param request FetchFileRequest
         * @return FetchFileResponse
         */
        public FetchFileResponse FetchFile(FetchFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FetchFileWithOptions(request, runtime);
        }

        /**
         * @summary 云手机拉取文件到OSS
         *
         * @param request FetchFileRequest
         * @return FetchFileResponse
         */
        public async Task<FetchFileResponse> FetchFileAsync(FetchFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FetchFileWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetAdbSecureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAdbSecureResponse
         */
        public GetAdbSecureResponse GetAdbSecureWithOptions(GetAdbSecureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAdbSecure",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdbSecureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetAdbSecureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAdbSecureResponse
         */
        public async Task<GetAdbSecureResponse> GetAdbSecureWithOptionsAsync(GetAdbSecureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAdbSecure",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdbSecureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetAdbSecureRequest
         * @return GetAdbSecureResponse
         */
        public GetAdbSecureResponse GetAdbSecure(GetAdbSecureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAdbSecureWithOptions(request, runtime);
        }

        /**
         * @param request GetAdbSecureRequest
         * @return GetAdbSecureResponse
         */
        public async Task<GetAdbSecureResponse> GetAdbSecureAsync(GetAdbSecureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAdbSecureWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ImportKeyPairRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImportKeyPairResponse
         */
        public ImportKeyPairResponse ImportKeyPairWithOptions(ImportKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicKeyBody))
            {
                query["PublicKeyBody"] = request.PublicKeyBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportKeyPair",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportKeyPairResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ImportKeyPairRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImportKeyPairResponse
         */
        public async Task<ImportKeyPairResponse> ImportKeyPairWithOptionsAsync(ImportKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicKeyBody))
            {
                query["PublicKeyBody"] = request.PublicKeyBody;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportKeyPair",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportKeyPairResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ImportKeyPairRequest
         * @return ImportKeyPairResponse
         */
        public ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportKeyPairWithOptions(request, runtime);
        }

        /**
         * @param request ImportKeyPairRequest
         * @return ImportKeyPairResponse
         */
        public async Task<ImportKeyPairResponse> ImportKeyPairAsync(ImportKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportKeyPairWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 安装app到实例组
         *
         * @param request InstallAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallAppResponse
         */
        public InstallAppResponse InstallAppWithOptions(InstallAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIdList))
            {
                query["AppIdList"] = request.AppIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIdList))
            {
                query["InstanceGroupIdList"] = request.InstanceGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                query["InstanceIdList"] = request.InstanceIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallApp",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallAppResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 安装app到实例组
         *
         * @param request InstallAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallAppResponse
         */
        public async Task<InstallAppResponse> InstallAppWithOptionsAsync(InstallAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIdList))
            {
                query["AppIdList"] = request.AppIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIdList))
            {
                query["InstanceGroupIdList"] = request.InstanceGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                query["InstanceIdList"] = request.InstanceIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallApp",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 安装app到实例组
         *
         * @param request InstallAppRequest
         * @return InstallAppResponse
         */
        public InstallAppResponse InstallApp(InstallAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstallAppWithOptions(request, runtime);
        }

        /**
         * @summary 安装app到实例组
         *
         * @param request InstallAppRequest
         * @return InstallAppResponse
         */
        public async Task<InstallAppResponse> InstallAppAsync(InstallAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstallAppWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询Policy列表
         *
         * @param request ListPolicyGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPolicyGroupsResponse
         */
        public ListPolicyGroupsResponse ListPolicyGroupsWithOptions(ListPolicyGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupIds))
            {
                body["PolicyGroupIds"] = request.PolicyGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupName))
            {
                body["PolicyGroupName"] = request.PolicyGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicyGroups",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPolicyGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询Policy列表
         *
         * @param request ListPolicyGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPolicyGroupsResponse
         */
        public async Task<ListPolicyGroupsResponse> ListPolicyGroupsWithOptionsAsync(ListPolicyGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupIds))
            {
                body["PolicyGroupIds"] = request.PolicyGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupName))
            {
                body["PolicyGroupName"] = request.PolicyGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicyGroups",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPolicyGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询Policy列表
         *
         * @param request ListPolicyGroupsRequest
         * @return ListPolicyGroupsResponse
         */
        public ListPolicyGroupsResponse ListPolicyGroups(ListPolicyGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPolicyGroupsWithOptions(request, runtime);
        }

        /**
         * @summary 查询Policy列表
         *
         * @param request ListPolicyGroupsRequest
         * @return ListPolicyGroupsResponse
         */
        public async Task<ListPolicyGroupsResponse> ListPolicyGroupsAsync(ListPolicyGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPolicyGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改安卓实例信息
         *
         * @param request ModifyAndroidInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAndroidInstanceResponse
         */
        public ModifyAndroidInstanceResponse ModifyAndroidInstanceWithOptions(ModifyAndroidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceId))
            {
                query["AndroidInstanceId"] = request.AndroidInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewAndroidInstanceName))
            {
                query["NewAndroidInstanceName"] = request.NewAndroidInstanceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAndroidInstance",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAndroidInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改安卓实例信息
         *
         * @param request ModifyAndroidInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAndroidInstanceResponse
         */
        public async Task<ModifyAndroidInstanceResponse> ModifyAndroidInstanceWithOptionsAsync(ModifyAndroidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceId))
            {
                query["AndroidInstanceId"] = request.AndroidInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewAndroidInstanceName))
            {
                query["NewAndroidInstanceName"] = request.NewAndroidInstanceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAndroidInstance",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAndroidInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改安卓实例信息
         *
         * @param request ModifyAndroidInstanceRequest
         * @return ModifyAndroidInstanceResponse
         */
        public ModifyAndroidInstanceResponse ModifyAndroidInstance(ModifyAndroidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAndroidInstanceWithOptions(request, runtime);
        }

        /**
         * @summary 修改安卓实例信息
         *
         * @param request ModifyAndroidInstanceRequest
         * @return ModifyAndroidInstanceResponse
         */
        public async Task<ModifyAndroidInstanceResponse> ModifyAndroidInstanceAsync(ModifyAndroidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAndroidInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改安卓实例组
         *
         * @param request ModifyAndroidInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAndroidInstanceGroupResponse
         */
        public ModifyAndroidInstanceGroupResponse ModifyAndroidInstanceGroupWithOptions(ModifyAndroidInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupId))
            {
                query["InstanceGroupId"] = request.InstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewInstanceGroupName))
            {
                query["NewInstanceGroupName"] = request.NewInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupId))
            {
                query["PolicyGroupId"] = request.PolicyGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAndroidInstanceGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAndroidInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改安卓实例组
         *
         * @param request ModifyAndroidInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAndroidInstanceGroupResponse
         */
        public async Task<ModifyAndroidInstanceGroupResponse> ModifyAndroidInstanceGroupWithOptionsAsync(ModifyAndroidInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupId))
            {
                query["InstanceGroupId"] = request.InstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewInstanceGroupName))
            {
                query["NewInstanceGroupName"] = request.NewInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupId))
            {
                query["PolicyGroupId"] = request.PolicyGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAndroidInstanceGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAndroidInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改安卓实例组
         *
         * @param request ModifyAndroidInstanceGroupRequest
         * @return ModifyAndroidInstanceGroupResponse
         */
        public ModifyAndroidInstanceGroupResponse ModifyAndroidInstanceGroup(ModifyAndroidInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAndroidInstanceGroupWithOptions(request, runtime);
        }

        /**
         * @summary 修改安卓实例组
         *
         * @param request ModifyAndroidInstanceGroupRequest
         * @return ModifyAndroidInstanceGroupResponse
         */
        public async Task<ModifyAndroidInstanceGroupResponse> ModifyAndroidInstanceGroupAsync(ModifyAndroidInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAndroidInstanceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改app
         *
         * @param request ModifyAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAppResponse
         */
        public ModifyAppResponse ModifyAppWithOptions(ModifyAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconUrl))
            {
                query["IconUrl"] = request.IconUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyApp",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改app
         *
         * @param request ModifyAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAppResponse
         */
        public async Task<ModifyAppResponse> ModifyAppWithOptionsAsync(ModifyAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IconUrl))
            {
                query["IconUrl"] = request.IconUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyApp",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改app
         *
         * @param request ModifyAppRequest
         * @return ModifyAppResponse
         */
        public ModifyAppResponse ModifyApp(ModifyAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppWithOptions(request, runtime);
        }

        /**
         * @summary 修改app
         *
         * @param request ModifyAppRequest
         * @return ModifyAppResponse
         */
        public async Task<ModifyAppResponse> ModifyAppAsync(ModifyAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改密钥对名称
         *
         * @param request ModifyKeyPairNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyKeyPairNameResponse
         */
        public ModifyKeyPairNameResponse ModifyKeyPairNameWithOptions(ModifyKeyPairNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairId))
            {
                query["KeyPairId"] = request.KeyPairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewKeyPairName))
            {
                query["NewKeyPairName"] = request.NewKeyPairName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyKeyPairName",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyKeyPairNameResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改密钥对名称
         *
         * @param request ModifyKeyPairNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyKeyPairNameResponse
         */
        public async Task<ModifyKeyPairNameResponse> ModifyKeyPairNameWithOptionsAsync(ModifyKeyPairNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairId))
            {
                query["KeyPairId"] = request.KeyPairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewKeyPairName))
            {
                query["NewKeyPairName"] = request.NewKeyPairName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyKeyPairName",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyKeyPairNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改密钥对名称
         *
         * @param request ModifyKeyPairNameRequest
         * @return ModifyKeyPairNameResponse
         */
        public ModifyKeyPairNameResponse ModifyKeyPairName(ModifyKeyPairNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyKeyPairNameWithOptions(request, runtime);
        }

        /**
         * @summary 修改密钥对名称
         *
         * @param request ModifyKeyPairNameRequest
         * @return ModifyKeyPairNameResponse
         */
        public async Task<ModifyKeyPairNameResponse> ModifyKeyPairNameAsync(ModifyKeyPairNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyKeyPairNameWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改policy
         *
         * @param tmpReq ModifyPolicyGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPolicyGroupResponse
         */
        public ModifyPolicyGroupResponse ModifyPolicyGroupWithOptions(ModifyPolicyGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyPolicyGroupShrinkRequest request = new ModifyPolicyGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetRedirectPolicy))
            {
                request.NetRedirectPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetRedirectPolicy, "NetRedirectPolicy", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CameraRedirect))
            {
                body["CameraRedirect"] = request.CameraRedirect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clipboard))
            {
                body["Clipboard"] = request.Clipboard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Html5FileTransfer))
            {
                body["Html5FileTransfer"] = request.Html5FileTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalDrive))
            {
                body["LocalDrive"] = request.LocalDrive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetRedirectPolicyShrink))
            {
                body["NetRedirectPolicy"] = request.NetRedirectPolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupId))
            {
                body["PolicyGroupId"] = request.PolicyGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupName))
            {
                body["PolicyGroupName"] = request.PolicyGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolutionHeight))
            {
                body["ResolutionHeight"] = request.ResolutionHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolutionWidth))
            {
                body["ResolutionWidth"] = request.ResolutionWidth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPolicyGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPolicyGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改policy
         *
         * @param tmpReq ModifyPolicyGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPolicyGroupResponse
         */
        public async Task<ModifyPolicyGroupResponse> ModifyPolicyGroupWithOptionsAsync(ModifyPolicyGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyPolicyGroupShrinkRequest request = new ModifyPolicyGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetRedirectPolicy))
            {
                request.NetRedirectPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetRedirectPolicy, "NetRedirectPolicy", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CameraRedirect))
            {
                body["CameraRedirect"] = request.CameraRedirect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clipboard))
            {
                body["Clipboard"] = request.Clipboard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Html5FileTransfer))
            {
                body["Html5FileTransfer"] = request.Html5FileTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalDrive))
            {
                body["LocalDrive"] = request.LocalDrive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetRedirectPolicyShrink))
            {
                body["NetRedirectPolicy"] = request.NetRedirectPolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupId))
            {
                body["PolicyGroupId"] = request.PolicyGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyGroupName))
            {
                body["PolicyGroupName"] = request.PolicyGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolutionHeight))
            {
                body["ResolutionHeight"] = request.ResolutionHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResolutionWidth))
            {
                body["ResolutionWidth"] = request.ResolutionWidth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPolicyGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPolicyGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改policy
         *
         * @param request ModifyPolicyGroupRequest
         * @return ModifyPolicyGroupResponse
         */
        public ModifyPolicyGroupResponse ModifyPolicyGroup(ModifyPolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPolicyGroupWithOptions(request, runtime);
        }

        /**
         * @summary 修改policy
         *
         * @param request ModifyPolicyGroupRequest
         * @return ModifyPolicyGroupResponse
         */
        public async Task<ModifyPolicyGroupResponse> ModifyPolicyGroupAsync(ModifyPolicyGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPolicyGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 重启安卓实例
         *
         * @param request RebootAndroidInstancesInGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RebootAndroidInstancesInGroupResponse
         */
        public RebootAndroidInstancesInGroupResponse RebootAndroidInstancesInGroupWithOptions(RebootAndroidInstancesInGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceStop))
            {
                query["ForceStop"] = request.ForceStop;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebootAndroidInstancesInGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebootAndroidInstancesInGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 重启安卓实例
         *
         * @param request RebootAndroidInstancesInGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RebootAndroidInstancesInGroupResponse
         */
        public async Task<RebootAndroidInstancesInGroupResponse> RebootAndroidInstancesInGroupWithOptionsAsync(RebootAndroidInstancesInGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceStop))
            {
                query["ForceStop"] = request.ForceStop;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebootAndroidInstancesInGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebootAndroidInstancesInGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 重启安卓实例
         *
         * @param request RebootAndroidInstancesInGroupRequest
         * @return RebootAndroidInstancesInGroupResponse
         */
        public RebootAndroidInstancesInGroupResponse RebootAndroidInstancesInGroup(RebootAndroidInstancesInGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RebootAndroidInstancesInGroupWithOptions(request, runtime);
        }

        /**
         * @summary 重启安卓实例
         *
         * @param request RebootAndroidInstancesInGroupRequest
         * @return RebootAndroidInstancesInGroupResponse
         */
        public async Task<RebootAndroidInstancesInGroupResponse> RebootAndroidInstancesInGroupAsync(RebootAndroidInstancesInGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RebootAndroidInstancesInGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 文件恢复
         *
         * @param request RecoveryFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecoveryFileResponse
         */
        public RecoveryFileResponse RecoveryFileWithOptions(RecoveryFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIdList))
            {
                query["AndroidInstanceIdList"] = request.AndroidInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFileId))
            {
                query["BackupFileId"] = request.BackupFileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFilePath))
            {
                query["BackupFilePath"] = request.BackupFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadEndpoint))
            {
                query["UploadEndpoint"] = request.UploadEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadType))
            {
                query["UploadType"] = request.UploadType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecoveryFile",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecoveryFileResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 文件恢复
         *
         * @param request RecoveryFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecoveryFileResponse
         */
        public async Task<RecoveryFileResponse> RecoveryFileWithOptionsAsync(RecoveryFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIdList))
            {
                query["AndroidInstanceIdList"] = request.AndroidInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFileId))
            {
                query["BackupFileId"] = request.BackupFileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupFilePath))
            {
                query["BackupFilePath"] = request.BackupFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadEndpoint))
            {
                query["UploadEndpoint"] = request.UploadEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadType))
            {
                query["UploadType"] = request.UploadType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecoveryFile",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecoveryFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 文件恢复
         *
         * @param request RecoveryFileRequest
         * @return RecoveryFileResponse
         */
        public RecoveryFileResponse RecoveryFile(RecoveryFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecoveryFileWithOptions(request, runtime);
        }

        /**
         * @summary 文件恢复
         *
         * @param request RecoveryFileRequest
         * @return RecoveryFileResponse
         */
        public async Task<RecoveryFileResponse> RecoveryFileAsync(RecoveryFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecoveryFileWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 续费安卓实例组
         *
         * @param request RenewAndroidInstanceGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenewAndroidInstanceGroupsResponse
         */
        public RenewAndroidInstanceGroupsResponse RenewAndroidInstanceGroupsWithOptions(RenewAndroidInstanceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIds))
            {
                query["InstanceGroupIds"] = request.InstanceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewAndroidInstanceGroups",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewAndroidInstanceGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 续费安卓实例组
         *
         * @param request RenewAndroidInstanceGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenewAndroidInstanceGroupsResponse
         */
        public async Task<RenewAndroidInstanceGroupsResponse> RenewAndroidInstanceGroupsWithOptionsAsync(RenewAndroidInstanceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIds))
            {
                query["InstanceGroupIds"] = request.InstanceGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewAndroidInstanceGroups",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewAndroidInstanceGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 续费安卓实例组
         *
         * @param request RenewAndroidInstanceGroupsRequest
         * @return RenewAndroidInstanceGroupsResponse
         */
        public RenewAndroidInstanceGroupsResponse RenewAndroidInstanceGroups(RenewAndroidInstanceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewAndroidInstanceGroupsWithOptions(request, runtime);
        }

        /**
         * @summary 续费安卓实例组
         *
         * @param request RenewAndroidInstanceGroupsRequest
         * @return RenewAndroidInstanceGroupsResponse
         */
        public async Task<RenewAndroidInstanceGroupsResponse> RenewAndroidInstanceGroupsAsync(RenewAndroidInstanceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewAndroidInstanceGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 重置安卓实例
         *
         * @param request ResetAndroidInstancesInGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetAndroidInstancesInGroupResponse
         */
        public ResetAndroidInstancesInGroupResponse ResetAndroidInstancesInGroupWithOptions(ResetAndroidInstancesInGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetAndroidInstancesInGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetAndroidInstancesInGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 重置安卓实例
         *
         * @param request ResetAndroidInstancesInGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetAndroidInstancesInGroupResponse
         */
        public async Task<ResetAndroidInstancesInGroupResponse> ResetAndroidInstancesInGroupWithOptionsAsync(ResetAndroidInstancesInGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetAndroidInstancesInGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetAndroidInstancesInGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 重置安卓实例
         *
         * @param request ResetAndroidInstancesInGroupRequest
         * @return ResetAndroidInstancesInGroupResponse
         */
        public ResetAndroidInstancesInGroupResponse ResetAndroidInstancesInGroup(ResetAndroidInstancesInGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetAndroidInstancesInGroupWithOptions(request, runtime);
        }

        /**
         * @summary 重置安卓实例
         *
         * @param request ResetAndroidInstancesInGroupRequest
         * @return ResetAndroidInstancesInGroupResponse
         */
        public async Task<ResetAndroidInstancesInGroupResponse> ResetAndroidInstancesInGroupAsync(ResetAndroidInstancesInGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetAndroidInstancesInGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 通过eds agent通道下发命令
         *
         * @param request RunCommandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunCommandResponse
         */
        public RunCommandResponse RunCommandWithOptions(RunCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandContent))
            {
                query["CommandContent"] = request.CommandContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCommand",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCommandResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 通过eds agent通道下发命令
         *
         * @param request RunCommandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunCommandResponse
         */
        public async Task<RunCommandResponse> RunCommandWithOptionsAsync(RunCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandContent))
            {
                query["CommandContent"] = request.CommandContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCommand",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCommandResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 通过eds agent通道下发命令
         *
         * @param request RunCommandRequest
         * @return RunCommandResponse
         */
        public RunCommandResponse RunCommand(RunCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunCommandWithOptions(request, runtime);
        }

        /**
         * @summary 通过eds agent通道下发命令
         *
         * @param request RunCommandRequest
         * @return RunCommandResponse
         */
        public async Task<RunCommandResponse> RunCommandAsync(RunCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunCommandWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 推送文件到云手机
         *
         * @param request SendFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendFileResponse
         */
        public SendFileResponse SendFileWithOptions(SendFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIdList))
            {
                query["AndroidInstanceIdList"] = request.AndroidInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFilePath))
            {
                query["SourceFilePath"] = request.SourceFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadEndpoint))
            {
                query["UploadEndpoint"] = request.UploadEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadType))
            {
                query["UploadType"] = request.UploadType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadUrl))
            {
                query["UploadUrl"] = request.UploadUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendFile",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendFileResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 推送文件到云手机
         *
         * @param request SendFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendFileResponse
         */
        public async Task<SendFileResponse> SendFileWithOptionsAsync(SendFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIdList))
            {
                query["AndroidInstanceIdList"] = request.AndroidInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceFilePath))
            {
                query["SourceFilePath"] = request.SourceFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadEndpoint))
            {
                query["UploadEndpoint"] = request.UploadEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadType))
            {
                query["UploadType"] = request.UploadType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadUrl))
            {
                query["UploadUrl"] = request.UploadUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendFile",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 推送文件到云手机
         *
         * @param request SendFileRequest
         * @return SendFileResponse
         */
        public SendFileResponse SendFile(SendFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendFileWithOptions(request, runtime);
        }

        /**
         * @summary 推送文件到云手机
         *
         * @param request SendFileRequest
         * @return SendFileResponse
         */
        public async Task<SendFileResponse> SendFileAsync(SendFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendFileWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SetAdbSecureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetAdbSecureResponse
         */
        public SetAdbSecureResponse SetAdbSecureWithOptions(SetAdbSecureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
                Action = "SetAdbSecure",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAdbSecureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request SetAdbSecureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetAdbSecureResponse
         */
        public async Task<SetAdbSecureResponse> SetAdbSecureWithOptionsAsync(SetAdbSecureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
                Action = "SetAdbSecure",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAdbSecureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request SetAdbSecureRequest
         * @return SetAdbSecureResponse
         */
        public SetAdbSecureResponse SetAdbSecure(SetAdbSecureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAdbSecureWithOptions(request, runtime);
        }

        /**
         * @param request SetAdbSecureRequest
         * @return SetAdbSecureResponse
         */
        public async Task<SetAdbSecureResponse> SetAdbSecureAsync(SetAdbSecureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAdbSecureWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 实例开机
         *
         * @param request StartAndroidInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartAndroidInstanceResponse
         */
        public StartAndroidInstanceResponse StartAndroidInstanceWithOptions(StartAndroidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartAndroidInstance",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartAndroidInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 实例开机
         *
         * @param request StartAndroidInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartAndroidInstanceResponse
         */
        public async Task<StartAndroidInstanceResponse> StartAndroidInstanceWithOptionsAsync(StartAndroidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartAndroidInstance",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartAndroidInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 实例开机
         *
         * @param request StartAndroidInstanceRequest
         * @return StartAndroidInstanceResponse
         */
        public StartAndroidInstanceResponse StartAndroidInstance(StartAndroidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartAndroidInstanceWithOptions(request, runtime);
        }

        /**
         * @summary 实例开机
         *
         * @param request StartAndroidInstanceRequest
         * @return StartAndroidInstanceResponse
         */
        public async Task<StartAndroidInstanceResponse> StartAndroidInstanceAsync(StartAndroidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartAndroidInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 实例关机
         *
         * @param request StopAndroidInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopAndroidInstanceResponse
         */
        public StopAndroidInstanceResponse StopAndroidInstanceWithOptions(StopAndroidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceStop))
            {
                query["ForceStop"] = request.ForceStop;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopAndroidInstance",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopAndroidInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 实例关机
         *
         * @param request StopAndroidInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopAndroidInstanceResponse
         */
        public async Task<StopAndroidInstanceResponse> StopAndroidInstanceWithOptionsAsync(StopAndroidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidInstanceIds))
            {
                query["AndroidInstanceIds"] = request.AndroidInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceStop))
            {
                query["ForceStop"] = request.ForceStop;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopAndroidInstance",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopAndroidInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 实例关机
         *
         * @param request StopAndroidInstanceRequest
         * @return StopAndroidInstanceResponse
         */
        public StopAndroidInstanceResponse StopAndroidInstance(StopAndroidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopAndroidInstanceWithOptions(request, runtime);
        }

        /**
         * @summary 实例关机
         *
         * @param request StopAndroidInstanceRequest
         * @return StopAndroidInstanceResponse
         */
        public async Task<StopAndroidInstanceResponse> StopAndroidInstanceAsync(StopAndroidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopAndroidInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 卸载app
         *
         * @param request UninstallAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UninstallAppResponse
         */
        public UninstallAppResponse UninstallAppWithOptions(UninstallAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIdList))
            {
                query["AppIdList"] = request.AppIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIdList))
            {
                query["InstanceGroupIdList"] = request.InstanceGroupIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallApp",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallAppResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 卸载app
         *
         * @param request UninstallAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UninstallAppResponse
         */
        public async Task<UninstallAppResponse> UninstallAppWithOptionsAsync(UninstallAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIdList))
            {
                query["AppIdList"] = request.AppIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIdList))
            {
                query["InstanceGroupIdList"] = request.InstanceGroupIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallApp",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 卸载app
         *
         * @param request UninstallAppRequest
         * @return UninstallAppResponse
         */
        public UninstallAppResponse UninstallApp(UninstallAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UninstallAppWithOptions(request, runtime);
        }

        /**
         * @summary 卸载app
         *
         * @param request UninstallAppRequest
         * @return UninstallAppResponse
         */
        public async Task<UninstallAppResponse> UninstallAppAsync(UninstallAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UninstallAppWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改自定义镜像名称
         *
         * @param request UpdateCustomImageNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCustomImageNameResponse
         */
        public UpdateCustomImageNameResponse UpdateCustomImageNameWithOptions(UpdateCustomImageNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                body["ImageName"] = request.ImageName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomImageName",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomImageNameResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改自定义镜像名称
         *
         * @param request UpdateCustomImageNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCustomImageNameResponse
         */
        public async Task<UpdateCustomImageNameResponse> UpdateCustomImageNameWithOptionsAsync(UpdateCustomImageNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                body["ImageName"] = request.ImageName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomImageName",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomImageNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改自定义镜像名称
         *
         * @param request UpdateCustomImageNameRequest
         * @return UpdateCustomImageNameResponse
         */
        public UpdateCustomImageNameResponse UpdateCustomImageName(UpdateCustomImageNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCustomImageNameWithOptions(request, runtime);
        }

        /**
         * @summary 修改自定义镜像名称
         *
         * @param request UpdateCustomImageNameRequest
         * @return UpdateCustomImageNameResponse
         */
        public async Task<UpdateCustomImageNameResponse> UpdateCustomImageNameAsync(UpdateCustomImageNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCustomImageNameWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 实例组变更镜像
         *
         * @param request UpdateInstanceGroupImageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceGroupImageResponse
         */
        public UpdateInstanceGroupImageResponse UpdateInstanceGroupImageWithOptions(UpdateInstanceGroupImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIds))
            {
                body["InstanceGroupIds"] = request.InstanceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceGroupImage",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceGroupImageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 实例组变更镜像
         *
         * @param request UpdateInstanceGroupImageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceGroupImageResponse
         */
        public async Task<UpdateInstanceGroupImageResponse> UpdateInstanceGroupImageWithOptionsAsync(UpdateInstanceGroupImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupIds))
            {
                body["InstanceGroupIds"] = request.InstanceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceGroupImage",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceGroupImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 实例组变更镜像
         *
         * @param request UpdateInstanceGroupImageRequest
         * @return UpdateInstanceGroupImageResponse
         */
        public UpdateInstanceGroupImageResponse UpdateInstanceGroupImage(UpdateInstanceGroupImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceGroupImageWithOptions(request, runtime);
        }

        /**
         * @summary 实例组变更镜像
         *
         * @param request UpdateInstanceGroupImageRequest
         * @return UpdateInstanceGroupImageResponse
         */
        public async Task<UpdateInstanceGroupImageResponse> UpdateInstanceGroupImageAsync(UpdateInstanceGroupImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceGroupImageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 安卓实例组扩容
         *
         * @param request UpgradeAndroidInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeAndroidInstanceGroupResponse
         */
        public UpgradeAndroidInstanceGroupResponse UpgradeAndroidInstanceGroupWithOptions(UpgradeAndroidInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncreaseNumberOfInstance))
            {
                query["IncreaseNumberOfInstance"] = request.IncreaseNumberOfInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupId))
            {
                query["InstanceGroupId"] = request.InstanceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeAndroidInstanceGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeAndroidInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 安卓实例组扩容
         *
         * @param request UpgradeAndroidInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeAndroidInstanceGroupResponse
         */
        public async Task<UpgradeAndroidInstanceGroupResponse> UpgradeAndroidInstanceGroupWithOptionsAsync(UpgradeAndroidInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncreaseNumberOfInstance))
            {
                query["IncreaseNumberOfInstance"] = request.IncreaseNumberOfInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceGroupId))
            {
                query["InstanceGroupId"] = request.InstanceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeAndroidInstanceGroup",
                Version = "2023-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeAndroidInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 安卓实例组扩容
         *
         * @param request UpgradeAndroidInstanceGroupRequest
         * @return UpgradeAndroidInstanceGroupResponse
         */
        public UpgradeAndroidInstanceGroupResponse UpgradeAndroidInstanceGroup(UpgradeAndroidInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeAndroidInstanceGroupWithOptions(request, runtime);
        }

        /**
         * @summary 安卓实例组扩容
         *
         * @param request UpgradeAndroidInstanceGroupRequest
         * @return UpgradeAndroidInstanceGroupResponse
         */
        public async Task<UpgradeAndroidInstanceGroupResponse> UpgradeAndroidInstanceGroupAsync(UpgradeAndroidInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeAndroidInstanceGroupWithOptionsAsync(request, runtime);
        }

    }
}
