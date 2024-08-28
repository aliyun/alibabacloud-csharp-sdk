// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dds20151201.Models;

namespace AlibabaCloud.SDK.Dds20151201
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "mongodb.aliyuncs.com"},
                {"cn-beijing", "mongodb.aliyuncs.com"},
                {"cn-zhangjiakou", "mongodb.cn-zhangjiakou.aliyuncs.com"},
                {"cn-huhehaote", "mongodb.cn-huhehaote.aliyuncs.com"},
                {"cn-wulanchabu", "mongodb.aliyuncs.com"},
                {"cn-hangzhou", "mongodb.aliyuncs.com"},
                {"cn-shanghai", "mongodb.aliyuncs.com"},
                {"cn-shenzhen", "mongodb.aliyuncs.com"},
                {"cn-heyuan", "mongodb.aliyuncs.com"},
                {"cn-guangzhou", "mongodb.aliyuncs.com"},
                {"cn-chengdu", "mongodb.cn-chengdu.aliyuncs.com"},
                {"cn-hongkong", "mongodb.cn-hongkong.aliyuncs.com"},
                {"ap-northeast-1", "mongodb.ap-northeast-1.aliyuncs.com"},
                {"ap-southeast-1", "mongodb.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "mongodb.ap-southeast-2.aliyuncs.com"},
                {"ap-southeast-3", "mongodb.ap-southeast-3.aliyuncs.com"},
                {"ap-southeast-5", "mongodb.ap-southeast-5.aliyuncs.com"},
                {"us-east-1", "mongodb.us-east-1.aliyuncs.com"},
                {"us-west-1", "mongodb.us-west-1.aliyuncs.com"},
                {"eu-west-1", "mongodb.eu-west-1.aliyuncs.com"},
                {"eu-central-1", "mongodb.eu-central-1.aliyuncs.com"},
                {"ap-south-1", "mongodb.ap-south-1.aliyuncs.com"},
                {"me-east-1", "mongodb.me-east-1.aliyuncs.com"},
                {"cn-hangzhou-finance", "mongodb.aliyuncs.com"},
                {"cn-shanghai-finance-1", "mongodb.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "mongodb.aliyuncs.com"},
                {"cn-north-2-gov-1", "mongodb.aliyuncs.com"},
                {"ap-northeast-2-pop", "mongodb.aliyuncs.com"},
                {"cn-beijing-finance-1", "mongodb.aliyuncs.com"},
                {"cn-beijing-finance-pop", "mongodb.aliyuncs.com"},
                {"cn-beijing-gov-1", "mongodb.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "mongodb.aliyuncs.com"},
                {"cn-edge-1", "mongodb.aliyuncs.com"},
                {"cn-fujian", "mongodb.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "mongodb.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "mongodb.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "mongodb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "mongodb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "mongodb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "mongodb.aliyuncs.com"},
                {"cn-hangzhou-test-306", "mongodb.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "mongodb.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "mongodb.aliyuncs.com"},
                {"cn-qingdao-nebula", "mongodb.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "mongodb.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "mongodb.aliyuncs.com"},
                {"cn-shanghai-inner", "mongodb.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "mongodb.aliyuncs.com"},
                {"cn-shenzhen-inner", "mongodb.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "mongodb.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "mongodb.aliyuncs.com"},
                {"cn-wuhan", "mongodb.aliyuncs.com"},
                {"cn-yushanfang", "mongodb.aliyuncs.com"},
                {"cn-zhangbei", "mongodb.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "mongodb.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "mongodb.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "mongodb.aliyuncs.com"},
                {"eu-west-1-oxs", "mongodb.aliyuncs.com"},
                {"rus-west-1-pop", "mongodb.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("dds", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary Applies for an internal endpoint for a shard or Configserver node in an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description This operation is applicable only to sharded cluster instances. For more information, see [Apply for an endpoint for a shard or Configserver node](https://help.aliyun.com/document_detail/134037.html).
         * >  The allocated endpoints can be used only for internal access. To gain Internet access, you must call the [AllocatePublicNetworkAddress](https://help.aliyun.com/document_detail/67602.html) operation to apply for public endpoints.
         *
         * @param request AllocateNodePrivateNetworkAddressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AllocateNodePrivateNetworkAddressResponse
         */
        public AllocateNodePrivateNetworkAddressResponse AllocateNodePrivateNetworkAddressWithOptions(AllocateNodePrivateNetworkAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPassword))
            {
                query["AccountPassword"] = request.AccountPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Action = "AllocateNodePrivateNetworkAddress",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllocateNodePrivateNetworkAddressResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Applies for an internal endpoint for a shard or Configserver node in an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description This operation is applicable only to sharded cluster instances. For more information, see [Apply for an endpoint for a shard or Configserver node](https://help.aliyun.com/document_detail/134037.html).
         * >  The allocated endpoints can be used only for internal access. To gain Internet access, you must call the [AllocatePublicNetworkAddress](https://help.aliyun.com/document_detail/67602.html) operation to apply for public endpoints.
         *
         * @param request AllocateNodePrivateNetworkAddressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AllocateNodePrivateNetworkAddressResponse
         */
        public async Task<AllocateNodePrivateNetworkAddressResponse> AllocateNodePrivateNetworkAddressWithOptionsAsync(AllocateNodePrivateNetworkAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPassword))
            {
                query["AccountPassword"] = request.AccountPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Action = "AllocateNodePrivateNetworkAddress",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllocateNodePrivateNetworkAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Applies for an internal endpoint for a shard or Configserver node in an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description This operation is applicable only to sharded cluster instances. For more information, see [Apply for an endpoint for a shard or Configserver node](https://help.aliyun.com/document_detail/134037.html).
         * >  The allocated endpoints can be used only for internal access. To gain Internet access, you must call the [AllocatePublicNetworkAddress](https://help.aliyun.com/document_detail/67602.html) operation to apply for public endpoints.
         *
         * @param request AllocateNodePrivateNetworkAddressRequest
         * @return AllocateNodePrivateNetworkAddressResponse
         */
        public AllocateNodePrivateNetworkAddressResponse AllocateNodePrivateNetworkAddress(AllocateNodePrivateNetworkAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocateNodePrivateNetworkAddressWithOptions(request, runtime);
        }

        /**
         * @summary Applies for an internal endpoint for a shard or Configserver node in an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description This operation is applicable only to sharded cluster instances. For more information, see [Apply for an endpoint for a shard or Configserver node](https://help.aliyun.com/document_detail/134037.html).
         * >  The allocated endpoints can be used only for internal access. To gain Internet access, you must call the [AllocatePublicNetworkAddress](https://help.aliyun.com/document_detail/67602.html) operation to apply for public endpoints.
         *
         * @param request AllocateNodePrivateNetworkAddressRequest
         * @return AllocateNodePrivateNetworkAddressResponse
         */
        public async Task<AllocateNodePrivateNetworkAddressResponse> AllocateNodePrivateNetworkAddressAsync(AllocateNodePrivateNetworkAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocateNodePrivateNetworkAddressWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Allocates a public endpoint to an instance.
         *
         * @param request AllocatePublicNetworkAddressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AllocatePublicNetworkAddressResponse
         */
        public AllocatePublicNetworkAddressResponse AllocatePublicNetworkAddressWithOptions(AllocatePublicNetworkAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AllocatePublicNetworkAddress",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllocatePublicNetworkAddressResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Allocates a public endpoint to an instance.
         *
         * @param request AllocatePublicNetworkAddressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AllocatePublicNetworkAddressResponse
         */
        public async Task<AllocatePublicNetworkAddressResponse> AllocatePublicNetworkAddressWithOptionsAsync(AllocatePublicNetworkAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AllocatePublicNetworkAddress",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllocatePublicNetworkAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Allocates a public endpoint to an instance.
         *
         * @param request AllocatePublicNetworkAddressRequest
         * @return AllocatePublicNetworkAddressResponse
         */
        public AllocatePublicNetworkAddressResponse AllocatePublicNetworkAddress(AllocatePublicNetworkAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocatePublicNetworkAddressWithOptions(request, runtime);
        }

        /**
         * @summary Allocates a public endpoint to an instance.
         *
         * @param request AllocatePublicNetworkAddressRequest
         * @return AllocatePublicNetworkAddressResponse
         */
        public async Task<AllocatePublicNetworkAddressResponse> AllocatePublicNetworkAddressAsync(AllocatePublicNetworkAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocatePublicNetworkAddressWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to check whether KMS keys are authorized to ApsaraDB for MongoDB instances.
         *
         * @description Before you enable Transparent Data Encryption (TDE) by calling the [ModifyDBInstanceTDE](https://help.aliyun.com/document_detail/131267.html) operation, you can call this operation to check whether KMS keys are authorized to ApsaraDB for MongoDB instances.
         *
         * @param request CheckCloudResourceAuthorizedRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckCloudResourceAuthorizedResponse
         */
        public CheckCloudResourceAuthorizedResponse CheckCloudResourceAuthorizedWithOptions(CheckCloudResourceAuthorizedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetRegionId))
            {
                query["TargetRegionId"] = request.TargetRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckCloudResourceAuthorized",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckCloudResourceAuthorizedResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to check whether KMS keys are authorized to ApsaraDB for MongoDB instances.
         *
         * @description Before you enable Transparent Data Encryption (TDE) by calling the [ModifyDBInstanceTDE](https://help.aliyun.com/document_detail/131267.html) operation, you can call this operation to check whether KMS keys are authorized to ApsaraDB for MongoDB instances.
         *
         * @param request CheckCloudResourceAuthorizedRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckCloudResourceAuthorizedResponse
         */
        public async Task<CheckCloudResourceAuthorizedResponse> CheckCloudResourceAuthorizedWithOptionsAsync(CheckCloudResourceAuthorizedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetRegionId))
            {
                query["TargetRegionId"] = request.TargetRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckCloudResourceAuthorized",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckCloudResourceAuthorizedResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to check whether KMS keys are authorized to ApsaraDB for MongoDB instances.
         *
         * @description Before you enable Transparent Data Encryption (TDE) by calling the [ModifyDBInstanceTDE](https://help.aliyun.com/document_detail/131267.html) operation, you can call this operation to check whether KMS keys are authorized to ApsaraDB for MongoDB instances.
         *
         * @param request CheckCloudResourceAuthorizedRequest
         * @return CheckCloudResourceAuthorizedResponse
         */
        public CheckCloudResourceAuthorizedResponse CheckCloudResourceAuthorized(CheckCloudResourceAuthorizedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckCloudResourceAuthorizedWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to check whether KMS keys are authorized to ApsaraDB for MongoDB instances.
         *
         * @description Before you enable Transparent Data Encryption (TDE) by calling the [ModifyDBInstanceTDE](https://help.aliyun.com/document_detail/131267.html) operation, you can call this operation to check whether KMS keys are authorized to ApsaraDB for MongoDB instances.
         *
         * @param request CheckCloudResourceAuthorizedRequest
         * @return CheckCloudResourceAuthorizedResponse
         */
        public async Task<CheckCloudResourceAuthorizedResponse> CheckCloudResourceAuthorizedAsync(CheckCloudResourceAuthorizedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckCloudResourceAuthorizedWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries whether the data of an ApsaraDB for MongoDB instance can be restored.
         *
         * @description This operation is applicable to replica set instances and sharded cluster instances.
         * >  After you call this operation to confirm that the data of the instance can be restored, you can call the [CreateDBInstance](https://help.aliyun.com/document_detail/61763.html) operation to restore data to a new instance.
         *
         * @param request CheckRecoveryConditionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckRecoveryConditionResponse
         */
        public CheckRecoveryConditionResponse CheckRecoveryConditionWithOptions(CheckRecoveryConditionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseNames))
            {
                query["DatabaseNames"] = request.DatabaseNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestRegion))
            {
                query["DestRegion"] = request.DestRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTime))
            {
                query["RestoreTime"] = request.RestoreTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreType))
            {
                query["RestoreType"] = request.RestoreType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDBInstance))
            {
                query["SourceDBInstance"] = request.SourceDBInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDBInstance))
            {
                query["SourceDBInstance"] = request.SourceDBInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcRegion))
            {
                query["SrcRegion"] = request.SrcRegion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckRecoveryCondition",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckRecoveryConditionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries whether the data of an ApsaraDB for MongoDB instance can be restored.
         *
         * @description This operation is applicable to replica set instances and sharded cluster instances.
         * >  After you call this operation to confirm that the data of the instance can be restored, you can call the [CreateDBInstance](https://help.aliyun.com/document_detail/61763.html) operation to restore data to a new instance.
         *
         * @param request CheckRecoveryConditionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckRecoveryConditionResponse
         */
        public async Task<CheckRecoveryConditionResponse> CheckRecoveryConditionWithOptionsAsync(CheckRecoveryConditionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseNames))
            {
                query["DatabaseNames"] = request.DatabaseNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestRegion))
            {
                query["DestRegion"] = request.DestRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTime))
            {
                query["RestoreTime"] = request.RestoreTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreType))
            {
                query["RestoreType"] = request.RestoreType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDBInstance))
            {
                query["SourceDBInstance"] = request.SourceDBInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDBInstance))
            {
                query["SourceDBInstance"] = request.SourceDBInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcRegion))
            {
                query["SrcRegion"] = request.SrcRegion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckRecoveryCondition",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckRecoveryConditionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries whether the data of an ApsaraDB for MongoDB instance can be restored.
         *
         * @description This operation is applicable to replica set instances and sharded cluster instances.
         * >  After you call this operation to confirm that the data of the instance can be restored, you can call the [CreateDBInstance](https://help.aliyun.com/document_detail/61763.html) operation to restore data to a new instance.
         *
         * @param request CheckRecoveryConditionRequest
         * @return CheckRecoveryConditionResponse
         */
        public CheckRecoveryConditionResponse CheckRecoveryCondition(CheckRecoveryConditionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckRecoveryConditionWithOptions(request, runtime);
        }

        /**
         * @summary Queries whether the data of an ApsaraDB for MongoDB instance can be restored.
         *
         * @description This operation is applicable to replica set instances and sharded cluster instances.
         * >  After you call this operation to confirm that the data of the instance can be restored, you can call the [CreateDBInstance](https://help.aliyun.com/document_detail/61763.html) operation to restore data to a new instance.
         *
         * @param request CheckRecoveryConditionRequest
         * @return CheckRecoveryConditionResponse
         */
        public async Task<CheckRecoveryConditionResponse> CheckRecoveryConditionAsync(CheckRecoveryConditionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckRecoveryConditionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an account that is granted read-only permissions for shard nodes in an ApsaraDB for MongoDB sharded cluster instance that uses cloud disks.
         *
         * @description *   You can create an account for shard nodes only in an ApsaraDB for MongoDB sharded cluster instance that uses cloud disks.
         * *   The account is granted read-only permissions.
         *
         * @param request CreateAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAccountResponse
         */
        public CreateAccountResponse CreateAccountWithOptions(CreateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPassword))
            {
                query["AccountPassword"] = request.AccountPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccount",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an account that is granted read-only permissions for shard nodes in an ApsaraDB for MongoDB sharded cluster instance that uses cloud disks.
         *
         * @description *   You can create an account for shard nodes only in an ApsaraDB for MongoDB sharded cluster instance that uses cloud disks.
         * *   The account is granted read-only permissions.
         *
         * @param request CreateAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAccountResponse
         */
        public async Task<CreateAccountResponse> CreateAccountWithOptionsAsync(CreateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPassword))
            {
                query["AccountPassword"] = request.AccountPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccount",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an account that is granted read-only permissions for shard nodes in an ApsaraDB for MongoDB sharded cluster instance that uses cloud disks.
         *
         * @description *   You can create an account for shard nodes only in an ApsaraDB for MongoDB sharded cluster instance that uses cloud disks.
         * *   The account is granted read-only permissions.
         *
         * @param request CreateAccountRequest
         * @return CreateAccountResponse
         */
        public CreateAccountResponse CreateAccount(CreateAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccountWithOptions(request, runtime);
        }

        /**
         * @summary Creates an account that is granted read-only permissions for shard nodes in an ApsaraDB for MongoDB sharded cluster instance that uses cloud disks.
         *
         * @description *   You can create an account for shard nodes only in an ApsaraDB for MongoDB sharded cluster instance that uses cloud disks.
         * *   The account is granted read-only permissions.
         *
         * @param request CreateAccountRequest
         * @return CreateAccountResponse
         */
        public async Task<CreateAccountResponse> CreateAccountAsync(CreateAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a backup set for an ApsaraDB for MongoDB instance.
         *
         * @description When you call this operation, the instance must be in the Running state.
         *
         * @param request CreateBackupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateBackupResponse
         */
        public CreateBackupResponse CreateBackupWithOptions(CreateBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupMethod))
            {
                query["BackupMethod"] = request.BackupMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBackup",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBackupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a backup set for an ApsaraDB for MongoDB instance.
         *
         * @description When you call this operation, the instance must be in the Running state.
         *
         * @param request CreateBackupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateBackupResponse
         */
        public async Task<CreateBackupResponse> CreateBackupWithOptionsAsync(CreateBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupMethod))
            {
                query["BackupMethod"] = request.BackupMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBackup",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBackupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a backup set for an ApsaraDB for MongoDB instance.
         *
         * @description When you call this operation, the instance must be in the Running state.
         *
         * @param request CreateBackupRequest
         * @return CreateBackupResponse
         */
        public CreateBackupResponse CreateBackup(CreateBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBackupWithOptions(request, runtime);
        }

        /**
         * @summary Creates a backup set for an ApsaraDB for MongoDB instance.
         *
         * @description When you call this operation, the instance must be in the Running state.
         *
         * @param request CreateBackupRequest
         * @return CreateBackupResponse
         */
        public async Task<CreateBackupResponse> CreateBackupAsync(CreateBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBackupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates or clones an ApsaraDB for MongoDB replica set instance.
         *
         * @description Make sure that you fully understand the billing methods and [pricing](https://www.aliyun.com/price/product#/mongodb/detail/mongodb_computeudr_dp_cn) of ApsaraDB for MongoDB before you call this operation.
         * For more information about the instance types of ApsaraDB for MongoDB instances, see [Instance types](https://www.alibabacloud.com/help/en/mongodb/product-overview/instance-types-1).
         * To create sharded cluster instances, you can call the [CreateShardingDBInstance](~~CreateShardingDBInstance~~) operation.
         *
         * @param request CreateDBInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDBInstanceResponse
         */
        public CreateDBInstanceResponse CreateDBInstanceWithOptions(CreateDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPassword))
            {
                query["AccountPassword"] = request.AccountPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceClass))
            {
                query["DBInstanceClass"] = request.DBInstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceDescription))
            {
                query["DBInstanceDescription"] = request.DBInstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceStorage))
            {
                query["DBInstanceStorage"] = request.DBInstanceStorage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseNames))
            {
                query["DatabaseNames"] = request.DatabaseNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Encrypted))
            {
                query["Encrypted"] = request.Encrypted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionKey))
            {
                query["EncryptionKey"] = request.EncryptionKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalSecurityGroupIds))
            {
                query["GlobalSecurityGroupIds"] = request.GlobalSecurityGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HiddenZoneId))
            {
                query["HiddenZoneId"] = request.HiddenZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionedIops))
            {
                query["ProvisionedIops"] = request.ProvisionedIops;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadonlyReplicas))
            {
                query["ReadonlyReplicas"] = request.ReadonlyReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationFactor))
            {
                query["ReplicationFactor"] = request.ReplicationFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTime))
            {
                query["RestoreTime"] = request.RestoreTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreType))
            {
                query["RestoreType"] = request.RestoreType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryZoneId))
            {
                query["SecondaryZoneId"] = request.SecondaryZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIPList))
            {
                query["SecurityIPList"] = request.SecurityIPList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDBInstanceId))
            {
                query["SrcDBInstanceId"] = request.SrcDBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcRegion))
            {
                query["SrcRegion"] = request.SrcRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageEngine))
            {
                query["StorageEngine"] = request.StorageEngine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
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
                Action = "CreateDBInstance",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDBInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates or clones an ApsaraDB for MongoDB replica set instance.
         *
         * @description Make sure that you fully understand the billing methods and [pricing](https://www.aliyun.com/price/product#/mongodb/detail/mongodb_computeudr_dp_cn) of ApsaraDB for MongoDB before you call this operation.
         * For more information about the instance types of ApsaraDB for MongoDB instances, see [Instance types](https://www.alibabacloud.com/help/en/mongodb/product-overview/instance-types-1).
         * To create sharded cluster instances, you can call the [CreateShardingDBInstance](~~CreateShardingDBInstance~~) operation.
         *
         * @param request CreateDBInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDBInstanceResponse
         */
        public async Task<CreateDBInstanceResponse> CreateDBInstanceWithOptionsAsync(CreateDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPassword))
            {
                query["AccountPassword"] = request.AccountPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceClass))
            {
                query["DBInstanceClass"] = request.DBInstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceDescription))
            {
                query["DBInstanceDescription"] = request.DBInstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceStorage))
            {
                query["DBInstanceStorage"] = request.DBInstanceStorage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseNames))
            {
                query["DatabaseNames"] = request.DatabaseNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Encrypted))
            {
                query["Encrypted"] = request.Encrypted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionKey))
            {
                query["EncryptionKey"] = request.EncryptionKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalSecurityGroupIds))
            {
                query["GlobalSecurityGroupIds"] = request.GlobalSecurityGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HiddenZoneId))
            {
                query["HiddenZoneId"] = request.HiddenZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionedIops))
            {
                query["ProvisionedIops"] = request.ProvisionedIops;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadonlyReplicas))
            {
                query["ReadonlyReplicas"] = request.ReadonlyReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationFactor))
            {
                query["ReplicationFactor"] = request.ReplicationFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTime))
            {
                query["RestoreTime"] = request.RestoreTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreType))
            {
                query["RestoreType"] = request.RestoreType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryZoneId))
            {
                query["SecondaryZoneId"] = request.SecondaryZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIPList))
            {
                query["SecurityIPList"] = request.SecurityIPList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDBInstanceId))
            {
                query["SrcDBInstanceId"] = request.SrcDBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcRegion))
            {
                query["SrcRegion"] = request.SrcRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageEngine))
            {
                query["StorageEngine"] = request.StorageEngine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
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
                Action = "CreateDBInstance",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDBInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates or clones an ApsaraDB for MongoDB replica set instance.
         *
         * @description Make sure that you fully understand the billing methods and [pricing](https://www.aliyun.com/price/product#/mongodb/detail/mongodb_computeudr_dp_cn) of ApsaraDB for MongoDB before you call this operation.
         * For more information about the instance types of ApsaraDB for MongoDB instances, see [Instance types](https://www.alibabacloud.com/help/en/mongodb/product-overview/instance-types-1).
         * To create sharded cluster instances, you can call the [CreateShardingDBInstance](~~CreateShardingDBInstance~~) operation.
         *
         * @param request CreateDBInstanceRequest
         * @return CreateDBInstanceResponse
         */
        public CreateDBInstanceResponse CreateDBInstance(CreateDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDBInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Creates or clones an ApsaraDB for MongoDB replica set instance.
         *
         * @description Make sure that you fully understand the billing methods and [pricing](https://www.aliyun.com/price/product#/mongodb/detail/mongodb_computeudr_dp_cn) of ApsaraDB for MongoDB before you call this operation.
         * For more information about the instance types of ApsaraDB for MongoDB instances, see [Instance types](https://www.alibabacloud.com/help/en/mongodb/product-overview/instance-types-1).
         * To create sharded cluster instances, you can call the [CreateShardingDBInstance](~~CreateShardingDBInstance~~) operation.
         *
         * @param request CreateDBInstanceRequest
         * @return CreateDBInstanceResponse
         */
        public async Task<CreateDBInstanceResponse> CreateDBInstanceAsync(CreateDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDBInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a global IP whitelist template.
         *
         * @param request CreateGlobalSecurityIPGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGlobalSecurityIPGroupResponse
         */
        public CreateGlobalSecurityIPGroupResponse CreateGlobalSecurityIPGroupWithOptions(CreateGlobalSecurityIPGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GIpList))
            {
                query["GIpList"] = request.GIpList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalIgName))
            {
                query["GlobalIgName"] = request.GlobalIgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGlobalSecurityIPGroup",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGlobalSecurityIPGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a global IP whitelist template.
         *
         * @param request CreateGlobalSecurityIPGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGlobalSecurityIPGroupResponse
         */
        public async Task<CreateGlobalSecurityIPGroupResponse> CreateGlobalSecurityIPGroupWithOptionsAsync(CreateGlobalSecurityIPGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GIpList))
            {
                query["GIpList"] = request.GIpList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalIgName))
            {
                query["GlobalIgName"] = request.GlobalIgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGlobalSecurityIPGroup",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGlobalSecurityIPGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a global IP whitelist template.
         *
         * @param request CreateGlobalSecurityIPGroupRequest
         * @return CreateGlobalSecurityIPGroupResponse
         */
        public CreateGlobalSecurityIPGroupResponse CreateGlobalSecurityIPGroup(CreateGlobalSecurityIPGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGlobalSecurityIPGroupWithOptions(request, runtime);
        }

        /**
         * @summary Creates a global IP whitelist template.
         *
         * @param request CreateGlobalSecurityIPGroupRequest
         * @return CreateGlobalSecurityIPGroupResponse
         */
        public async Task<CreateGlobalSecurityIPGroupResponse> CreateGlobalSecurityIPGroupAsync(CreateGlobalSecurityIPGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGlobalSecurityIPGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds a shard or mongos node to an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing) of ApsaraDB for MongoDB.
         * This operation applies only to sharded cluster instances.
         *
         * @param request CreateNodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNodeResponse
         */
        public CreateNodeResponse CreateNodeWithOptions(CreateNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPassword))
            {
                query["AccountPassword"] = request.AccountPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeClass))
            {
                query["NodeClass"] = request.NodeClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeStorage))
            {
                query["NodeStorage"] = request.NodeStorage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeType))
            {
                query["NodeType"] = request.NodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadonlyReplicas))
            {
                query["ReadonlyReplicas"] = request.ReadonlyReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShardDirect))
            {
                query["ShardDirect"] = request.ShardDirect;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNode",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds a shard or mongos node to an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing) of ApsaraDB for MongoDB.
         * This operation applies only to sharded cluster instances.
         *
         * @param request CreateNodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNodeResponse
         */
        public async Task<CreateNodeResponse> CreateNodeWithOptionsAsync(CreateNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPassword))
            {
                query["AccountPassword"] = request.AccountPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeClass))
            {
                query["NodeClass"] = request.NodeClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeStorage))
            {
                query["NodeStorage"] = request.NodeStorage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeType))
            {
                query["NodeType"] = request.NodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadonlyReplicas))
            {
                query["ReadonlyReplicas"] = request.ReadonlyReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShardDirect))
            {
                query["ShardDirect"] = request.ShardDirect;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNode",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds a shard or mongos node to an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing) of ApsaraDB for MongoDB.
         * This operation applies only to sharded cluster instances.
         *
         * @param request CreateNodeRequest
         * @return CreateNodeResponse
         */
        public CreateNodeResponse CreateNode(CreateNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNodeWithOptions(request, runtime);
        }

        /**
         * @summary Adds a shard or mongos node to an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing) of ApsaraDB for MongoDB.
         * This operation applies only to sharded cluster instances.
         *
         * @param request CreateNodeRequest
         * @return CreateNodeResponse
         */
        public async Task<CreateNodeResponse> CreateNodeAsync(CreateNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNodeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Batch adds mongos or shard nodes for a sharded cluster instance.
         *
         * @description Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/product/apsaradb-for-mongodb/pricing) of ApsaraDB for MongoDB. 
         * This operation is applicable only to sharded cluster instances.
         *
         * @param request CreateNodeBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNodeBatchResponse
         */
        public CreateNodeBatchResponse CreateNodeBatchWithOptions(CreateNodeBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPassword))
            {
                query["AccountPassword"] = request.AccountPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromApp))
            {
                query["FromApp"] = request.FromApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodesInfo))
            {
                query["NodesInfo"] = request.NodesInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShardDirect))
            {
                query["ShardDirect"] = request.ShardDirect;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNodeBatch",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNodeBatchResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Batch adds mongos or shard nodes for a sharded cluster instance.
         *
         * @description Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/product/apsaradb-for-mongodb/pricing) of ApsaraDB for MongoDB. 
         * This operation is applicable only to sharded cluster instances.
         *
         * @param request CreateNodeBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNodeBatchResponse
         */
        public async Task<CreateNodeBatchResponse> CreateNodeBatchWithOptionsAsync(CreateNodeBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPassword))
            {
                query["AccountPassword"] = request.AccountPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromApp))
            {
                query["FromApp"] = request.FromApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodesInfo))
            {
                query["NodesInfo"] = request.NodesInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShardDirect))
            {
                query["ShardDirect"] = request.ShardDirect;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNodeBatch",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNodeBatchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Batch adds mongos or shard nodes for a sharded cluster instance.
         *
         * @description Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/product/apsaradb-for-mongodb/pricing) of ApsaraDB for MongoDB. 
         * This operation is applicable only to sharded cluster instances.
         *
         * @param request CreateNodeBatchRequest
         * @return CreateNodeBatchResponse
         */
        public CreateNodeBatchResponse CreateNodeBatch(CreateNodeBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNodeBatchWithOptions(request, runtime);
        }

        /**
         * @summary Batch adds mongos or shard nodes for a sharded cluster instance.
         *
         * @description Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/product/apsaradb-for-mongodb/pricing) of ApsaraDB for MongoDB. 
         * This operation is applicable only to sharded cluster instances.
         *
         * @param request CreateNodeBatchRequest
         * @return CreateNodeBatchResponse
         */
        public async Task<CreateNodeBatchResponse> CreateNodeBatchAsync(CreateNodeBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNodeBatchWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates or clones an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description *   Make sure that you fully understand the billing methods and [pricing](https://www.aliyun.com/price/product#/mongodb/detail) of ApsaraDB for MongoDB before you call this operation.
         * *   For more information about the instance types of ApsaraDB for MongoDB, see [Instance types](https://help.aliyun.com/document_detail/57141.html).
         * *   To create standalone instances and replica set instances, you can call the [CreateDBInstance](https://help.aliyun.com/document_detail/61763.html) operation.
         *
         * @param request CreateShardingDBInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateShardingDBInstanceResponse
         */
        public CreateShardingDBInstanceResponse CreateShardingDBInstanceWithOptions(CreateShardingDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPassword))
            {
                query["AccountPassword"] = request.AccountPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigServer))
            {
                query["ConfigServer"] = request.ConfigServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceDescription))
            {
                query["DBInstanceDescription"] = request.DBInstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestRegion))
            {
                query["DestRegion"] = request.DestRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Encrypted))
            {
                query["Encrypted"] = request.Encrypted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionKey))
            {
                query["EncryptionKey"] = request.EncryptionKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalSecurityGroupIds))
            {
                query["GlobalSecurityGroupIds"] = request.GlobalSecurityGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HiddenZoneId))
            {
                query["HiddenZoneId"] = request.HiddenZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mongos))
            {
                query["Mongos"] = request.Mongos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolType))
            {
                query["ProtocolType"] = request.ProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionedIops))
            {
                query["ProvisionedIops"] = request.ProvisionedIops;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaSet))
            {
                query["ReplicaSet"] = request.ReplicaSet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTime))
            {
                query["RestoreTime"] = request.RestoreTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreType))
            {
                query["RestoreType"] = request.RestoreType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryZoneId))
            {
                query["SecondaryZoneId"] = request.SecondaryZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIPList))
            {
                query["SecurityIPList"] = request.SecurityIPList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDBInstanceId))
            {
                query["SrcDBInstanceId"] = request.SrcDBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcRegion))
            {
                query["SrcRegion"] = request.SrcRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageEngine))
            {
                query["StorageEngine"] = request.StorageEngine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
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
                Action = "CreateShardingDBInstance",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateShardingDBInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates or clones an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description *   Make sure that you fully understand the billing methods and [pricing](https://www.aliyun.com/price/product#/mongodb/detail) of ApsaraDB for MongoDB before you call this operation.
         * *   For more information about the instance types of ApsaraDB for MongoDB, see [Instance types](https://help.aliyun.com/document_detail/57141.html).
         * *   To create standalone instances and replica set instances, you can call the [CreateDBInstance](https://help.aliyun.com/document_detail/61763.html) operation.
         *
         * @param request CreateShardingDBInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateShardingDBInstanceResponse
         */
        public async Task<CreateShardingDBInstanceResponse> CreateShardingDBInstanceWithOptionsAsync(CreateShardingDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPassword))
            {
                query["AccountPassword"] = request.AccountPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigServer))
            {
                query["ConfigServer"] = request.ConfigServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceDescription))
            {
                query["DBInstanceDescription"] = request.DBInstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestRegion))
            {
                query["DestRegion"] = request.DestRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Encrypted))
            {
                query["Encrypted"] = request.Encrypted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionKey))
            {
                query["EncryptionKey"] = request.EncryptionKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalSecurityGroupIds))
            {
                query["GlobalSecurityGroupIds"] = request.GlobalSecurityGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HiddenZoneId))
            {
                query["HiddenZoneId"] = request.HiddenZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mongos))
            {
                query["Mongos"] = request.Mongos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolType))
            {
                query["ProtocolType"] = request.ProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionedIops))
            {
                query["ProvisionedIops"] = request.ProvisionedIops;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaSet))
            {
                query["ReplicaSet"] = request.ReplicaSet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTime))
            {
                query["RestoreTime"] = request.RestoreTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreType))
            {
                query["RestoreType"] = request.RestoreType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryZoneId))
            {
                query["SecondaryZoneId"] = request.SecondaryZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIPList))
            {
                query["SecurityIPList"] = request.SecurityIPList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDBInstanceId))
            {
                query["SrcDBInstanceId"] = request.SrcDBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcRegion))
            {
                query["SrcRegion"] = request.SrcRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageEngine))
            {
                query["StorageEngine"] = request.StorageEngine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
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
                Action = "CreateShardingDBInstance",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateShardingDBInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates or clones an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description *   Make sure that you fully understand the billing methods and [pricing](https://www.aliyun.com/price/product#/mongodb/detail) of ApsaraDB for MongoDB before you call this operation.
         * *   For more information about the instance types of ApsaraDB for MongoDB, see [Instance types](https://help.aliyun.com/document_detail/57141.html).
         * *   To create standalone instances and replica set instances, you can call the [CreateDBInstance](https://help.aliyun.com/document_detail/61763.html) operation.
         *
         * @param request CreateShardingDBInstanceRequest
         * @return CreateShardingDBInstanceResponse
         */
        public CreateShardingDBInstanceResponse CreateShardingDBInstance(CreateShardingDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateShardingDBInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Creates or clones an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description *   Make sure that you fully understand the billing methods and [pricing](https://www.aliyun.com/price/product#/mongodb/detail) of ApsaraDB for MongoDB before you call this operation.
         * *   For more information about the instance types of ApsaraDB for MongoDB, see [Instance types](https://help.aliyun.com/document_detail/57141.html).
         * *   To create standalone instances and replica set instances, you can call the [CreateDBInstance](https://help.aliyun.com/document_detail/61763.html) operation.
         *
         * @param request CreateShardingDBInstanceRequest
         * @return CreateShardingDBInstanceResponse
         */
        public async Task<CreateShardingDBInstanceResponse> CreateShardingDBInstanceAsync(CreateShardingDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateShardingDBInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Releases an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the instance meets the following requirements
         * *   The instance is in the Running state.
         * *   The billing method of the instance is pay-as-you-go.
         * > After an instance is released, all data in the instance is cleared and cannot be recovered. Proceed with caution.
         *
         * @param request DeleteDBInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDBInstanceResponse
         */
        public DeleteDBInstanceResponse DeleteDBInstanceWithOptions(DeleteDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDBInstance",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDBInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Releases an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the instance meets the following requirements
         * *   The instance is in the Running state.
         * *   The billing method of the instance is pay-as-you-go.
         * > After an instance is released, all data in the instance is cleared and cannot be recovered. Proceed with caution.
         *
         * @param request DeleteDBInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDBInstanceResponse
         */
        public async Task<DeleteDBInstanceResponse> DeleteDBInstanceWithOptionsAsync(DeleteDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDBInstance",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDBInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Releases an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the instance meets the following requirements
         * *   The instance is in the Running state.
         * *   The billing method of the instance is pay-as-you-go.
         * > After an instance is released, all data in the instance is cleared and cannot be recovered. Proceed with caution.
         *
         * @param request DeleteDBInstanceRequest
         * @return DeleteDBInstanceResponse
         */
        public DeleteDBInstanceResponse DeleteDBInstance(DeleteDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDBInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Releases an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the instance meets the following requirements
         * *   The instance is in the Running state.
         * *   The billing method of the instance is pay-as-you-go.
         * > After an instance is released, all data in the instance is cleared and cannot be recovered. Proceed with caution.
         *
         * @param request DeleteDBInstanceRequest
         * @return DeleteDBInstanceResponse
         */
        public async Task<DeleteDBInstanceResponse> DeleteDBInstanceAsync(DeleteDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDBInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a global IP whitelist template.
         *
         * @param request DeleteGlobalSecurityIPGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGlobalSecurityIPGroupResponse
         */
        public DeleteGlobalSecurityIPGroupResponse DeleteGlobalSecurityIPGroupWithOptions(DeleteGlobalSecurityIPGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalIgName))
            {
                query["GlobalIgName"] = request.GlobalIgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalSecurityGroupId))
            {
                query["GlobalSecurityGroupId"] = request.GlobalSecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGlobalSecurityIPGroup",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGlobalSecurityIPGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a global IP whitelist template.
         *
         * @param request DeleteGlobalSecurityIPGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGlobalSecurityIPGroupResponse
         */
        public async Task<DeleteGlobalSecurityIPGroupResponse> DeleteGlobalSecurityIPGroupWithOptionsAsync(DeleteGlobalSecurityIPGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalIgName))
            {
                query["GlobalIgName"] = request.GlobalIgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalSecurityGroupId))
            {
                query["GlobalSecurityGroupId"] = request.GlobalSecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGlobalSecurityIPGroup",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGlobalSecurityIPGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a global IP whitelist template.
         *
         * @param request DeleteGlobalSecurityIPGroupRequest
         * @return DeleteGlobalSecurityIPGroupResponse
         */
        public DeleteGlobalSecurityIPGroupResponse DeleteGlobalSecurityIPGroup(DeleteGlobalSecurityIPGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGlobalSecurityIPGroupWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a global IP whitelist template.
         *
         * @param request DeleteGlobalSecurityIPGroupRequest
         * @return DeleteGlobalSecurityIPGroupResponse
         */
        public async Task<DeleteGlobalSecurityIPGroupResponse> DeleteGlobalSecurityIPGroupAsync(DeleteGlobalSecurityIPGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGlobalSecurityIPGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a shard or mongos node from an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description Before you call this operation, make sure that the instance meets the following requirements:
         * *   The instance is in the Running state.
         * *   The instance is a sharded cluster instance.
         * *   The billing method of the instance is pay-as-you-go.
         * *   The number of the shard or mongos nodes in the instance is greater than two.
         *
         * @param request DeleteNodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNodeResponse
         */
        public DeleteNodeResponse DeleteNodeWithOptions(DeleteNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNode",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a shard or mongos node from an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description Before you call this operation, make sure that the instance meets the following requirements:
         * *   The instance is in the Running state.
         * *   The instance is a sharded cluster instance.
         * *   The billing method of the instance is pay-as-you-go.
         * *   The number of the shard or mongos nodes in the instance is greater than two.
         *
         * @param request DeleteNodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNodeResponse
         */
        public async Task<DeleteNodeResponse> DeleteNodeWithOptionsAsync(DeleteNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNode",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a shard or mongos node from an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description Before you call this operation, make sure that the instance meets the following requirements:
         * *   The instance is in the Running state.
         * *   The instance is a sharded cluster instance.
         * *   The billing method of the instance is pay-as-you-go.
         * *   The number of the shard or mongos nodes in the instance is greater than two.
         *
         * @param request DeleteNodeRequest
         * @return DeleteNodeResponse
         */
        public DeleteNodeResponse DeleteNode(DeleteNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNodeWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a shard or mongos node from an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description Before you call this operation, make sure that the instance meets the following requirements:
         * *   The instance is in the Running state.
         * *   The instance is a sharded cluster instance.
         * *   The billing method of the instance is pay-as-you-go.
         * *   The number of the shard or mongos nodes in the instance is greater than two.
         *
         * @param request DeleteNodeRequest
         * @return DeleteNodeResponse
         */
        public async Task<DeleteNodeResponse> DeleteNodeAsync(DeleteNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNodeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the database accounts of an ApsaraDB for MongoDB instance.
         *
         * @description >  This operation can be used to query only the information of the root account.
         *
         * @param request DescribeAccountsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccountsResponse
         */
        public DescribeAccountsResponse DescribeAccountsWithOptions(DescribeAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccounts",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccountsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the database accounts of an ApsaraDB for MongoDB instance.
         *
         * @description >  This operation can be used to query only the information of the root account.
         *
         * @param request DescribeAccountsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccountsResponse
         */
        public async Task<DescribeAccountsResponse> DescribeAccountsWithOptionsAsync(DescribeAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccounts",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccountsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the database accounts of an ApsaraDB for MongoDB instance.
         *
         * @description >  This operation can be used to query only the information of the root account.
         *
         * @param request DescribeAccountsRequest
         * @return DescribeAccountsResponse
         */
        public DescribeAccountsResponse DescribeAccounts(DescribeAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccountsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the database accounts of an ApsaraDB for MongoDB instance.
         *
         * @description >  This operation can be used to query only the information of the root account.
         *
         * @param request DescribeAccountsRequest
         * @return DescribeAccountsResponse
         */
        public async Task<DescribeAccountsResponse> DescribeAccountsAsync(DescribeAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccountsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the number of operation and maintenance tasks on an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeActiveOperationTaskCountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeActiveOperationTaskCountResponse
         */
        public DescribeActiveOperationTaskCountResponse DescribeActiveOperationTaskCountWithOptions(DescribeActiveOperationTaskCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeActiveOperationTaskCount",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeActiveOperationTaskCountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the number of operation and maintenance tasks on an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeActiveOperationTaskCountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeActiveOperationTaskCountResponse
         */
        public async Task<DescribeActiveOperationTaskCountResponse> DescribeActiveOperationTaskCountWithOptionsAsync(DescribeActiveOperationTaskCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeActiveOperationTaskCount",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeActiveOperationTaskCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the number of operation and maintenance tasks on an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeActiveOperationTaskCountRequest
         * @return DescribeActiveOperationTaskCountResponse
         */
        public DescribeActiveOperationTaskCountResponse DescribeActiveOperationTaskCount(DescribeActiveOperationTaskCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeActiveOperationTaskCountWithOptions(request, runtime);
        }

        /**
         * @summary Queries the number of operation and maintenance tasks on an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeActiveOperationTaskCountRequest
         * @return DescribeActiveOperationTaskCountResponse
         */
        public async Task<DescribeActiveOperationTaskCountResponse> DescribeActiveOperationTaskCountAsync(DescribeActiveOperationTaskCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeActiveOperationTaskCountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the types of Operation and Maintenance tasks and the number of tasks of each type for an ApsaraDB for MongoDB instance.
         *
         * @description This operation is no longer updated and will be unavailable.
         *
         * @param request DescribeActiveOperationTaskTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeActiveOperationTaskTypeResponse
         */
        public DescribeActiveOperationTaskTypeResponse DescribeActiveOperationTaskTypeWithOptions(DescribeActiveOperationTaskTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsHistory))
            {
                query["IsHistory"] = request.IsHistory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeActiveOperationTaskType",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeActiveOperationTaskTypeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the types of Operation and Maintenance tasks and the number of tasks of each type for an ApsaraDB for MongoDB instance.
         *
         * @description This operation is no longer updated and will be unavailable.
         *
         * @param request DescribeActiveOperationTaskTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeActiveOperationTaskTypeResponse
         */
        public async Task<DescribeActiveOperationTaskTypeResponse> DescribeActiveOperationTaskTypeWithOptionsAsync(DescribeActiveOperationTaskTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsHistory))
            {
                query["IsHistory"] = request.IsHistory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeActiveOperationTaskType",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeActiveOperationTaskTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the types of Operation and Maintenance tasks and the number of tasks of each type for an ApsaraDB for MongoDB instance.
         *
         * @description This operation is no longer updated and will be unavailable.
         *
         * @param request DescribeActiveOperationTaskTypeRequest
         * @return DescribeActiveOperationTaskTypeResponse
         */
        public DescribeActiveOperationTaskTypeResponse DescribeActiveOperationTaskType(DescribeActiveOperationTaskTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeActiveOperationTaskTypeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the types of Operation and Maintenance tasks and the number of tasks of each type for an ApsaraDB for MongoDB instance.
         *
         * @description This operation is no longer updated and will be unavailable.
         *
         * @param request DescribeActiveOperationTaskTypeRequest
         * @return DescribeActiveOperationTaskTypeResponse
         */
        public async Task<DescribeActiveOperationTaskTypeResponse> DescribeActiveOperationTaskTypeAsync(DescribeActiveOperationTaskTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeActiveOperationTaskTypeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of operation and maintenance tasks initiated for an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeActiveOperationTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeActiveOperationTasksResponse
         */
        public DescribeActiveOperationTasksResponse DescribeActiveOperationTasksWithOptions(DescribeActiveOperationTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowCancel))
            {
                query["AllowCancel"] = request.AllowCancel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowChange))
            {
                query["AllowChange"] = request.AllowChange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeLevel))
            {
                query["ChangeLevel"] = request.ChangeLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbType))
            {
                query["DbType"] = request.DbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InsName))
            {
                query["InsName"] = request.InsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "DescribeActiveOperationTasks",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeActiveOperationTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of operation and maintenance tasks initiated for an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeActiveOperationTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeActiveOperationTasksResponse
         */
        public async Task<DescribeActiveOperationTasksResponse> DescribeActiveOperationTasksWithOptionsAsync(DescribeActiveOperationTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowCancel))
            {
                query["AllowCancel"] = request.AllowCancel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowChange))
            {
                query["AllowChange"] = request.AllowChange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeLevel))
            {
                query["ChangeLevel"] = request.ChangeLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbType))
            {
                query["DbType"] = request.DbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InsName))
            {
                query["InsName"] = request.InsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "DescribeActiveOperationTasks",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeActiveOperationTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of operation and maintenance tasks initiated for an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeActiveOperationTasksRequest
         * @return DescribeActiveOperationTasksResponse
         */
        public DescribeActiveOperationTasksResponse DescribeActiveOperationTasks(DescribeActiveOperationTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeActiveOperationTasksWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of operation and maintenance tasks initiated for an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeActiveOperationTasksRequest
         * @return DescribeActiveOperationTasksResponse
         */
        public async Task<DescribeActiveOperationTasksResponse> DescribeActiveOperationTasksAsync(DescribeActiveOperationTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeActiveOperationTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the types of entries in the audit log collected for an ApsaraDB for MongoDB instance.
         *
         * @description *   The instance must be in the running state when you call this operation.
         * *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeAuditLogFilterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAuditLogFilterResponse
         */
        public DescribeAuditLogFilterResponse DescribeAuditLogFilterWithOptions(DescribeAuditLogFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                query["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAuditLogFilter",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAuditLogFilterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the types of entries in the audit log collected for an ApsaraDB for MongoDB instance.
         *
         * @description *   The instance must be in the running state when you call this operation.
         * *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeAuditLogFilterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAuditLogFilterResponse
         */
        public async Task<DescribeAuditLogFilterResponse> DescribeAuditLogFilterWithOptionsAsync(DescribeAuditLogFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                query["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAuditLogFilter",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAuditLogFilterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the types of entries in the audit log collected for an ApsaraDB for MongoDB instance.
         *
         * @description *   The instance must be in the running state when you call this operation.
         * *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeAuditLogFilterRequest
         * @return DescribeAuditLogFilterResponse
         */
        public DescribeAuditLogFilterResponse DescribeAuditLogFilter(DescribeAuditLogFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAuditLogFilterWithOptions(request, runtime);
        }

        /**
         * @summary Queries the types of entries in the audit log collected for an ApsaraDB for MongoDB instance.
         *
         * @description *   The instance must be in the running state when you call this operation.
         * *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeAuditLogFilterRequest
         * @return DescribeAuditLogFilterResponse
         */
        public async Task<DescribeAuditLogFilterResponse> DescribeAuditLogFilterAsync(DescribeAuditLogFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAuditLogFilterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries whether the audit log feature is enabled for an ApsaraDB for MongoDB instance.
         *
         * @description *   The instance must be in the running state when you call this operation.
         * *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeAuditPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAuditPolicyResponse
         */
        public DescribeAuditPolicyResponse DescribeAuditPolicyWithOptions(DescribeAuditPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAuditPolicy",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAuditPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries whether the audit log feature is enabled for an ApsaraDB for MongoDB instance.
         *
         * @description *   The instance must be in the running state when you call this operation.
         * *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeAuditPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAuditPolicyResponse
         */
        public async Task<DescribeAuditPolicyResponse> DescribeAuditPolicyWithOptionsAsync(DescribeAuditPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAuditPolicy",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAuditPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries whether the audit log feature is enabled for an ApsaraDB for MongoDB instance.
         *
         * @description *   The instance must be in the running state when you call this operation.
         * *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeAuditPolicyRequest
         * @return DescribeAuditPolicyResponse
         */
        public DescribeAuditPolicyResponse DescribeAuditPolicy(DescribeAuditPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAuditPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Queries whether the audit log feature is enabled for an ApsaraDB for MongoDB instance.
         *
         * @description *   The instance must be in the running state when you call this operation.
         * *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeAuditPolicyRequest
         * @return DescribeAuditPolicyResponse
         */
        public async Task<DescribeAuditPolicyResponse> DescribeAuditPolicyAsync(DescribeAuditPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAuditPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the audit logs of an ApsaraDB for MongoDB instance.
         *
         * @description *   When you call this operation, ensure that the audit log feature of the instance is enabled. Otherwise, the operation returns an empty audit log.
         * *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeAuditRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAuditRecordsResponse
         */
        public DescribeAuditRecordsResponse DescribeAuditRecordsWithOptions(DescribeAuditRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                query["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Form))
            {
                query["Form"] = request.Form;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalOperator))
            {
                query["LogicalOperator"] = request.LogicalOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeywords))
            {
                query["QueryKeywords"] = request.QueryKeywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.User))
            {
                query["User"] = request.User;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAuditRecords",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAuditRecordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the audit logs of an ApsaraDB for MongoDB instance.
         *
         * @description *   When you call this operation, ensure that the audit log feature of the instance is enabled. Otherwise, the operation returns an empty audit log.
         * *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeAuditRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAuditRecordsResponse
         */
        public async Task<DescribeAuditRecordsResponse> DescribeAuditRecordsWithOptionsAsync(DescribeAuditRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                query["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Form))
            {
                query["Form"] = request.Form;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalOperator))
            {
                query["LogicalOperator"] = request.LogicalOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeywords))
            {
                query["QueryKeywords"] = request.QueryKeywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.User))
            {
                query["User"] = request.User;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAuditRecords",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAuditRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the audit logs of an ApsaraDB for MongoDB instance.
         *
         * @description *   When you call this operation, ensure that the audit log feature of the instance is enabled. Otherwise, the operation returns an empty audit log.
         * *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeAuditRecordsRequest
         * @return DescribeAuditRecordsResponse
         */
        public DescribeAuditRecordsResponse DescribeAuditRecords(DescribeAuditRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAuditRecordsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the audit logs of an ApsaraDB for MongoDB instance.
         *
         * @description *   When you call this operation, ensure that the audit log feature of the instance is enabled. Otherwise, the operation returns an empty audit log.
         * *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeAuditRecordsRequest
         * @return DescribeAuditRecordsResponse
         */
        public async Task<DescribeAuditRecordsResponse> DescribeAuditRecordsAsync(DescribeAuditRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAuditRecordsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of the zones that are supported by an ApsaraDB for MongoDB instance.
         *
         * @description Queries the zones in which an ApsaraDB for MongoDB instance can be deployed under specified purchase conditions. The region ID is required in the purchase condition.
         *
         * @param request DescribeAvailabilityZonesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAvailabilityZonesResponse
         */
        public DescribeAvailabilityZonesResponse DescribeAvailabilityZonesWithOptions(DescribeAvailabilityZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceClass))
            {
                query["DBInstanceClass"] = request.DBInstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbType))
            {
                query["DbType"] = request.DbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeSecondaryZoneId))
            {
                query["ExcludeSecondaryZoneId"] = request.ExcludeSecondaryZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeZoneId))
            {
                query["ExcludeZoneId"] = request.ExcludeZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargeType))
            {
                query["InstanceChargeType"] = request.InstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MongoType))
            {
                query["MongoType"] = request.MongoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationFactor))
            {
                query["ReplicationFactor"] = request.ReplicationFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageSupport))
            {
                query["StorageSupport"] = request.StorageSupport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
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
                Action = "DescribeAvailabilityZones",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailabilityZonesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of the zones that are supported by an ApsaraDB for MongoDB instance.
         *
         * @description Queries the zones in which an ApsaraDB for MongoDB instance can be deployed under specified purchase conditions. The region ID is required in the purchase condition.
         *
         * @param request DescribeAvailabilityZonesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAvailabilityZonesResponse
         */
        public async Task<DescribeAvailabilityZonesResponse> DescribeAvailabilityZonesWithOptionsAsync(DescribeAvailabilityZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceClass))
            {
                query["DBInstanceClass"] = request.DBInstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbType))
            {
                query["DbType"] = request.DbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeSecondaryZoneId))
            {
                query["ExcludeSecondaryZoneId"] = request.ExcludeSecondaryZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeZoneId))
            {
                query["ExcludeZoneId"] = request.ExcludeZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargeType))
            {
                query["InstanceChargeType"] = request.InstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MongoType))
            {
                query["MongoType"] = request.MongoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationFactor))
            {
                query["ReplicationFactor"] = request.ReplicationFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageSupport))
            {
                query["StorageSupport"] = request.StorageSupport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
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
                Action = "DescribeAvailabilityZones",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailabilityZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of the zones that are supported by an ApsaraDB for MongoDB instance.
         *
         * @description Queries the zones in which an ApsaraDB for MongoDB instance can be deployed under specified purchase conditions. The region ID is required in the purchase condition.
         *
         * @param request DescribeAvailabilityZonesRequest
         * @return DescribeAvailabilityZonesResponse
         */
        public DescribeAvailabilityZonesResponse DescribeAvailabilityZones(DescribeAvailabilityZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailabilityZonesWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of the zones that are supported by an ApsaraDB for MongoDB instance.
         *
         * @description Queries the zones in which an ApsaraDB for MongoDB instance can be deployed under specified purchase conditions. The region ID is required in the purchase condition.
         *
         * @param request DescribeAvailabilityZonesRequest
         * @return DescribeAvailabilityZonesResponse
         */
        public async Task<DescribeAvailabilityZonesResponse> DescribeAvailabilityZonesAsync(DescribeAvailabilityZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailabilityZonesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query the engine versions to which an ApsaraDB for MongoDB instance can be upgraded.
         *
         * @param request DescribeAvailableEngineVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAvailableEngineVersionResponse
         */
        public DescribeAvailableEngineVersionResponse DescribeAvailableEngineVersionWithOptions(DescribeAvailableEngineVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableEngineVersion",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableEngineVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the engine versions to which an ApsaraDB for MongoDB instance can be upgraded.
         *
         * @param request DescribeAvailableEngineVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAvailableEngineVersionResponse
         */
        public async Task<DescribeAvailableEngineVersionResponse> DescribeAvailableEngineVersionWithOptionsAsync(DescribeAvailableEngineVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableEngineVersion",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableEngineVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the engine versions to which an ApsaraDB for MongoDB instance can be upgraded.
         *
         * @param request DescribeAvailableEngineVersionRequest
         * @return DescribeAvailableEngineVersionResponse
         */
        public DescribeAvailableEngineVersionResponse DescribeAvailableEngineVersion(DescribeAvailableEngineVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableEngineVersionWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query the engine versions to which an ApsaraDB for MongoDB instance can be upgraded.
         *
         * @param request DescribeAvailableEngineVersionRequest
         * @return DescribeAvailableEngineVersionResponse
         */
        public async Task<DescribeAvailableEngineVersionResponse> DescribeAvailableEngineVersionAsync(DescribeAvailableEngineVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableEngineVersionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the available resources in the specified zone.
         *
         * @param request DescribeAvailableResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAvailableResourceResponse
         */
        public DescribeAvailableResourceResponse DescribeAvailableResourceWithOptions(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceClass))
            {
                query["DBInstanceClass"] = request.DBInstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbType))
            {
                query["DbType"] = request.DbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargeType))
            {
                query["InstanceChargeType"] = request.InstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationFactor))
            {
                query["ReplicationFactor"] = request.ReplicationFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
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
                Action = "DescribeAvailableResource",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the available resources in the specified zone.
         *
         * @param request DescribeAvailableResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAvailableResourceResponse
         */
        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceWithOptionsAsync(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceClass))
            {
                query["DBInstanceClass"] = request.DBInstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbType))
            {
                query["DbType"] = request.DbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargeType))
            {
                query["InstanceChargeType"] = request.InstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationFactor))
            {
                query["ReplicationFactor"] = request.ReplicationFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
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
                Action = "DescribeAvailableResource",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the available resources in the specified zone.
         *
         * @param request DescribeAvailableResourceRequest
         * @return DescribeAvailableResourceResponse
         */
        public DescribeAvailableResourceResponse DescribeAvailableResource(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableResourceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the available resources in the specified zone.
         *
         * @param request DescribeAvailableResourceRequest
         * @return DescribeAvailableResourceResponse
         */
        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceAsync(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the databases at a specified time or the databases in a specified backup set before you restore a database for an ApsaraDB for MongoDB instance.
         *
         * @description You can call the [CreateDBInstance](https://help.aliyun.com/document_detail/61763.html) operation to restore a database for an ApsaraDB for MongoDB instance. For more information, see [Restore one database of an ApsaraDB for MongoDB instance](https://help.aliyun.com/document_detail/112274.html).
         * Before you call this operation, make sure that the instance meets the following requirements:
         * *   The instance was created after March 26, 2019.
         * *   The instance is located in the China (Qingdao), China (Beijing), China (Zhangjiakou), China (Hohhot), China (Hangzhou), China (Shanghai), China (Shenzhen), or Singapore region. Other regions are not supported.
         * *   The instance is a replica set instance.
         * *   The instance runs MongoDB 3.4, MongoDB 4.0, or MongoDB 4.2. In addition, the instance uses local disks to store data.
         * *   The storage engine of the instance is WiredTiger.
         *
         * @param request DescribeBackupDBsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupDBsResponse
         */
        public DescribeBackupDBsResponse DescribeBackupDBsWithOptions(DescribeBackupDBsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTime))
            {
                query["RestoreTime"] = request.RestoreTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDBInstance))
            {
                query["SourceDBInstance"] = request.SourceDBInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDBInstance))
            {
                query["SourceDBInstance"] = request.SourceDBInstance;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupDBs",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupDBsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the databases at a specified time or the databases in a specified backup set before you restore a database for an ApsaraDB for MongoDB instance.
         *
         * @description You can call the [CreateDBInstance](https://help.aliyun.com/document_detail/61763.html) operation to restore a database for an ApsaraDB for MongoDB instance. For more information, see [Restore one database of an ApsaraDB for MongoDB instance](https://help.aliyun.com/document_detail/112274.html).
         * Before you call this operation, make sure that the instance meets the following requirements:
         * *   The instance was created after March 26, 2019.
         * *   The instance is located in the China (Qingdao), China (Beijing), China (Zhangjiakou), China (Hohhot), China (Hangzhou), China (Shanghai), China (Shenzhen), or Singapore region. Other regions are not supported.
         * *   The instance is a replica set instance.
         * *   The instance runs MongoDB 3.4, MongoDB 4.0, or MongoDB 4.2. In addition, the instance uses local disks to store data.
         * *   The storage engine of the instance is WiredTiger.
         *
         * @param request DescribeBackupDBsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupDBsResponse
         */
        public async Task<DescribeBackupDBsResponse> DescribeBackupDBsWithOptionsAsync(DescribeBackupDBsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTime))
            {
                query["RestoreTime"] = request.RestoreTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDBInstance))
            {
                query["SourceDBInstance"] = request.SourceDBInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDBInstance))
            {
                query["SourceDBInstance"] = request.SourceDBInstance;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupDBs",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupDBsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the databases at a specified time or the databases in a specified backup set before you restore a database for an ApsaraDB for MongoDB instance.
         *
         * @description You can call the [CreateDBInstance](https://help.aliyun.com/document_detail/61763.html) operation to restore a database for an ApsaraDB for MongoDB instance. For more information, see [Restore one database of an ApsaraDB for MongoDB instance](https://help.aliyun.com/document_detail/112274.html).
         * Before you call this operation, make sure that the instance meets the following requirements:
         * *   The instance was created after March 26, 2019.
         * *   The instance is located in the China (Qingdao), China (Beijing), China (Zhangjiakou), China (Hohhot), China (Hangzhou), China (Shanghai), China (Shenzhen), or Singapore region. Other regions are not supported.
         * *   The instance is a replica set instance.
         * *   The instance runs MongoDB 3.4, MongoDB 4.0, or MongoDB 4.2. In addition, the instance uses local disks to store data.
         * *   The storage engine of the instance is WiredTiger.
         *
         * @param request DescribeBackupDBsRequest
         * @return DescribeBackupDBsResponse
         */
        public DescribeBackupDBsResponse DescribeBackupDBs(DescribeBackupDBsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupDBsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the databases at a specified time or the databases in a specified backup set before you restore a database for an ApsaraDB for MongoDB instance.
         *
         * @description You can call the [CreateDBInstance](https://help.aliyun.com/document_detail/61763.html) operation to restore a database for an ApsaraDB for MongoDB instance. For more information, see [Restore one database of an ApsaraDB for MongoDB instance](https://help.aliyun.com/document_detail/112274.html).
         * Before you call this operation, make sure that the instance meets the following requirements:
         * *   The instance was created after March 26, 2019.
         * *   The instance is located in the China (Qingdao), China (Beijing), China (Zhangjiakou), China (Hohhot), China (Hangzhou), China (Shanghai), China (Shenzhen), or Singapore region. Other regions are not supported.
         * *   The instance is a replica set instance.
         * *   The instance runs MongoDB 3.4, MongoDB 4.0, or MongoDB 4.2. In addition, the instance uses local disks to store data.
         * *   The storage engine of the instance is WiredTiger.
         *
         * @param request DescribeBackupDBsRequest
         * @return DescribeBackupDBsResponse
         */
        public async Task<DescribeBackupDBsResponse> DescribeBackupDBsAsync(DescribeBackupDBsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupDBsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the backup policy of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeBackupPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupPolicyResponse
         */
        public DescribeBackupPolicyResponse DescribeBackupPolicyWithOptions(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcRegion))
            {
                query["SrcRegion"] = request.SrcRegion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupPolicy",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the backup policy of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeBackupPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupPolicyResponse
         */
        public async Task<DescribeBackupPolicyResponse> DescribeBackupPolicyWithOptionsAsync(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcRegion))
            {
                query["SrcRegion"] = request.SrcRegion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupPolicy",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the backup policy of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeBackupPolicyRequest
         * @return DescribeBackupPolicyResponse
         */
        public DescribeBackupPolicyResponse DescribeBackupPolicy(DescribeBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Queries the backup policy of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeBackupPolicyRequest
         * @return DescribeBackupPolicyResponse
         */
        public async Task<DescribeBackupPolicyResponse> DescribeBackupPolicyAsync(DescribeBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the storage used for backup in an ApsaraDB for MongoDB replica set or sharded cluster instance that uses cloud disks. Note that you are charged only for the backup-used storage of each shard in a sharded cluster instance. You can call this operation only to query the storage used by a single shard in the instance for backup.
         *
         * @param request DescribeBackupStorageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupStorageResponse
         */
        public DescribeBackupStorageResponse DescribeBackupStorageWithOptions(DescribeBackupStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupStorage",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupStorageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the storage used for backup in an ApsaraDB for MongoDB replica set or sharded cluster instance that uses cloud disks. Note that you are charged only for the backup-used storage of each shard in a sharded cluster instance. You can call this operation only to query the storage used by a single shard in the instance for backup.
         *
         * @param request DescribeBackupStorageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupStorageResponse
         */
        public async Task<DescribeBackupStorageResponse> DescribeBackupStorageWithOptionsAsync(DescribeBackupStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupStorage",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupStorageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the storage used for backup in an ApsaraDB for MongoDB replica set or sharded cluster instance that uses cloud disks. Note that you are charged only for the backup-used storage of each shard in a sharded cluster instance. You can call this operation only to query the storage used by a single shard in the instance for backup.
         *
         * @param request DescribeBackupStorageRequest
         * @return DescribeBackupStorageResponse
         */
        public DescribeBackupStorageResponse DescribeBackupStorage(DescribeBackupStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupStorageWithOptions(request, runtime);
        }

        /**
         * @summary Queries the storage used for backup in an ApsaraDB for MongoDB replica set or sharded cluster instance that uses cloud disks. Note that you are charged only for the backup-used storage of each shard in a sharded cluster instance. You can call this operation only to query the storage used by a single shard in the instance for backup.
         *
         * @param request DescribeBackupStorageRequest
         * @return DescribeBackupStorageResponse
         */
        public async Task<DescribeBackupStorageResponse> DescribeBackupStorageAsync(DescribeBackupStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupStorageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries backup tasks running in an ApsaraDB for MongoDB replica set or sharded cluster instance that uses cloud disks.
         *
         * @param request DescribeBackupTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupTasksResponse
         */
        public DescribeBackupTasksResponse DescribeBackupTasksWithOptions(DescribeBackupTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupTasks",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries backup tasks running in an ApsaraDB for MongoDB replica set or sharded cluster instance that uses cloud disks.
         *
         * @param request DescribeBackupTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupTasksResponse
         */
        public async Task<DescribeBackupTasksResponse> DescribeBackupTasksWithOptionsAsync(DescribeBackupTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupTasks",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries backup tasks running in an ApsaraDB for MongoDB replica set or sharded cluster instance that uses cloud disks.
         *
         * @param request DescribeBackupTasksRequest
         * @return DescribeBackupTasksResponse
         */
        public DescribeBackupTasksResponse DescribeBackupTasks(DescribeBackupTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupTasksWithOptions(request, runtime);
        }

        /**
         * @summary Queries backup tasks running in an ApsaraDB for MongoDB replica set or sharded cluster instance that uses cloud disks.
         *
         * @param request DescribeBackupTasksRequest
         * @return DescribeBackupTasksResponse
         */
        public async Task<DescribeBackupTasksResponse> DescribeBackupTasksAsync(DescribeBackupTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the backup sets of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeBackupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupsResponse
         */
        public DescribeBackupsResponse DescribeBackupsWithOptions(DescribeBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestRegion))
            {
                query["DestRegion"] = request.DestRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcRegion))
            {
                query["SrcRegion"] = request.SrcRegion;
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
                Action = "DescribeBackups",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the backup sets of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeBackupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupsResponse
         */
        public async Task<DescribeBackupsResponse> DescribeBackupsWithOptionsAsync(DescribeBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestRegion))
            {
                query["DestRegion"] = request.DestRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcRegion))
            {
                query["SrcRegion"] = request.SrcRegion;
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
                Action = "DescribeBackups",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the backup sets of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeBackupsRequest
         * @return DescribeBackupsResponse
         */
        public DescribeBackupsResponse DescribeBackups(DescribeBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the backup sets of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeBackupsRequest
         * @return DescribeBackupsResponse
         */
        public async Task<DescribeBackupsResponse> DescribeBackupsAsync(DescribeBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the backup sets of an ApsaraDB for MongoDB sharded cluster instance that uses cloud disks.
         *
         * @description For a sharded cluster instance that is created before October 19, 2023 and uses cloud disks, you must call the [TransferClusterBackup](https://help.aliyun.com/document_detail/2587931.html) operation to switch the instance from the shard backup mode to the cluster backup mode before you call the DescribeClusterBackups operation.
         * By default, cloud disk-based sharded cluster instances that are created after October 19, 2023 are in the cluster backup mode.
         *
         * @param request DescribeClusterBackupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterBackupsResponse
         */
        public DescribeClusterBackupsResponse DescribeClusterBackupsWithOptions(DescribeClusterBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestRegion))
            {
                query["DestRegion"] = request.DestRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOnlyGetClusterBackUp))
            {
                query["IsOnlyGetClusterBackUp"] = request.IsOnlyGetClusterBackUp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcRegion))
            {
                query["SrcRegion"] = request.SrcRegion;
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
                Action = "DescribeClusterBackups",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterBackupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the backup sets of an ApsaraDB for MongoDB sharded cluster instance that uses cloud disks.
         *
         * @description For a sharded cluster instance that is created before October 19, 2023 and uses cloud disks, you must call the [TransferClusterBackup](https://help.aliyun.com/document_detail/2587931.html) operation to switch the instance from the shard backup mode to the cluster backup mode before you call the DescribeClusterBackups operation.
         * By default, cloud disk-based sharded cluster instances that are created after October 19, 2023 are in the cluster backup mode.
         *
         * @param request DescribeClusterBackupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterBackupsResponse
         */
        public async Task<DescribeClusterBackupsResponse> DescribeClusterBackupsWithOptionsAsync(DescribeClusterBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestRegion))
            {
                query["DestRegion"] = request.DestRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOnlyGetClusterBackUp))
            {
                query["IsOnlyGetClusterBackUp"] = request.IsOnlyGetClusterBackUp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcRegion))
            {
                query["SrcRegion"] = request.SrcRegion;
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
                Action = "DescribeClusterBackups",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterBackupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the backup sets of an ApsaraDB for MongoDB sharded cluster instance that uses cloud disks.
         *
         * @description For a sharded cluster instance that is created before October 19, 2023 and uses cloud disks, you must call the [TransferClusterBackup](https://help.aliyun.com/document_detail/2587931.html) operation to switch the instance from the shard backup mode to the cluster backup mode before you call the DescribeClusterBackups operation.
         * By default, cloud disk-based sharded cluster instances that are created after October 19, 2023 are in the cluster backup mode.
         *
         * @param request DescribeClusterBackupsRequest
         * @return DescribeClusterBackupsResponse
         */
        public DescribeClusterBackupsResponse DescribeClusterBackups(DescribeClusterBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterBackupsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the backup sets of an ApsaraDB for MongoDB sharded cluster instance that uses cloud disks.
         *
         * @description For a sharded cluster instance that is created before October 19, 2023 and uses cloud disks, you must call the [TransferClusterBackup](https://help.aliyun.com/document_detail/2587931.html) operation to switch the instance from the shard backup mode to the cluster backup mode before you call the DescribeClusterBackups operation.
         * By default, cloud disk-based sharded cluster instances that are created after October 19, 2023 are in the cluster backup mode.
         *
         * @param request DescribeClusterBackupsRequest
         * @return DescribeClusterBackupsResponse
         */
        public async Task<DescribeClusterBackupsResponse> DescribeClusterBackupsAsync(DescribeClusterBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterBackupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the time range to which you can restore the data of an ApsaraDB for MongoDB sharded cluster instance that uses cloud disks.
         *
         * @description *   The instance is an ApsaraDB for MongoDB sharded cluster instance that runs MongoDB 4.4 or later and uses enhanced SSDs (ESSDs) to store data.
         * *   You can call the TransferClusterBackup operation only for instances that are created before October 19, 2023 to switch the instances to the cluster backup mode. The DescribeClusterRecoverTime operation is applicable only to instances that are switched to the cluster backup mode or instances that are created on or after October 19, 2023.
         *
         * @param request DescribeClusterRecoverTimeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterRecoverTimeResponse
         */
        public DescribeClusterRecoverTimeResponse DescribeClusterRecoverTimeWithOptions(DescribeClusterRecoverTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterRecoverTime",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterRecoverTimeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the time range to which you can restore the data of an ApsaraDB for MongoDB sharded cluster instance that uses cloud disks.
         *
         * @description *   The instance is an ApsaraDB for MongoDB sharded cluster instance that runs MongoDB 4.4 or later and uses enhanced SSDs (ESSDs) to store data.
         * *   You can call the TransferClusterBackup operation only for instances that are created before October 19, 2023 to switch the instances to the cluster backup mode. The DescribeClusterRecoverTime operation is applicable only to instances that are switched to the cluster backup mode or instances that are created on or after October 19, 2023.
         *
         * @param request DescribeClusterRecoverTimeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterRecoverTimeResponse
         */
        public async Task<DescribeClusterRecoverTimeResponse> DescribeClusterRecoverTimeWithOptionsAsync(DescribeClusterRecoverTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterRecoverTime",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterRecoverTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the time range to which you can restore the data of an ApsaraDB for MongoDB sharded cluster instance that uses cloud disks.
         *
         * @description *   The instance is an ApsaraDB for MongoDB sharded cluster instance that runs MongoDB 4.4 or later and uses enhanced SSDs (ESSDs) to store data.
         * *   You can call the TransferClusterBackup operation only for instances that are created before October 19, 2023 to switch the instances to the cluster backup mode. The DescribeClusterRecoverTime operation is applicable only to instances that are switched to the cluster backup mode or instances that are created on or after October 19, 2023.
         *
         * @param request DescribeClusterRecoverTimeRequest
         * @return DescribeClusterRecoverTimeResponse
         */
        public DescribeClusterRecoverTimeResponse DescribeClusterRecoverTime(DescribeClusterRecoverTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterRecoverTimeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the time range to which you can restore the data of an ApsaraDB for MongoDB sharded cluster instance that uses cloud disks.
         *
         * @description *   The instance is an ApsaraDB for MongoDB sharded cluster instance that runs MongoDB 4.4 or later and uses enhanced SSDs (ESSDs) to store data.
         * *   You can call the TransferClusterBackup operation only for instances that are created before October 19, 2023 to switch the instances to the cluster backup mode. The DescribeClusterRecoverTime operation is applicable only to instances that are switched to the cluster backup mode or instances that are created on or after October 19, 2023.
         *
         * @param request DescribeClusterRecoverTimeRequest
         * @return DescribeClusterRecoverTimeResponse
         */
        public async Task<DescribeClusterRecoverTimeResponse> DescribeClusterRecoverTimeAsync(DescribeClusterRecoverTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterRecoverTimeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeDBInstanceAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBInstanceAttributeResponse
         */
        public DescribeDBInstanceAttributeResponse DescribeDBInstanceAttributeWithOptions(DescribeDBInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDelete))
            {
                query["IsDelete"] = request.IsDelete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceAttribute",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceAttributeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeDBInstanceAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBInstanceAttributeResponse
         */
        public async Task<DescribeDBInstanceAttributeResponse> DescribeDBInstanceAttributeWithOptionsAsync(DescribeDBInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDelete))
            {
                query["IsDelete"] = request.IsDelete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceAttribute",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeDBInstanceAttributeRequest
         * @return DescribeDBInstanceAttributeResponse
         */
        public DescribeDBInstanceAttributeResponse DescribeDBInstanceAttribute(DescribeDBInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeDBInstanceAttributeRequest
         * @return DescribeDBInstanceAttributeResponse
         */
        public async Task<DescribeDBInstanceAttributeResponse> DescribeDBInstanceAttributeAsync(DescribeDBInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of a key for an ApsaraDB for MongoDB instance.
         *
         * @description When you call the DescribeDBInstanceEncryptionKey operation, the instance must have transparent data encryption (TDE) enabled in BYOK mode. You can call the [ModifyDBInstanceTDE](https://help.aliyun.com/document_detail/131267.html) operation to enable TDE.
         *
         * @param request DescribeDBInstanceEncryptionKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBInstanceEncryptionKeyResponse
         */
        public DescribeDBInstanceEncryptionKeyResponse DescribeDBInstanceEncryptionKeyWithOptions(DescribeDBInstanceEncryptionKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionKey))
            {
                query["EncryptionKey"] = request.EncryptionKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceEncryptionKey",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceEncryptionKeyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a key for an ApsaraDB for MongoDB instance.
         *
         * @description When you call the DescribeDBInstanceEncryptionKey operation, the instance must have transparent data encryption (TDE) enabled in BYOK mode. You can call the [ModifyDBInstanceTDE](https://help.aliyun.com/document_detail/131267.html) operation to enable TDE.
         *
         * @param request DescribeDBInstanceEncryptionKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBInstanceEncryptionKeyResponse
         */
        public async Task<DescribeDBInstanceEncryptionKeyResponse> DescribeDBInstanceEncryptionKeyWithOptionsAsync(DescribeDBInstanceEncryptionKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionKey))
            {
                query["EncryptionKey"] = request.EncryptionKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceEncryptionKey",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceEncryptionKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a key for an ApsaraDB for MongoDB instance.
         *
         * @description When you call the DescribeDBInstanceEncryptionKey operation, the instance must have transparent data encryption (TDE) enabled in BYOK mode. You can call the [ModifyDBInstanceTDE](https://help.aliyun.com/document_detail/131267.html) operation to enable TDE.
         *
         * @param request DescribeDBInstanceEncryptionKeyRequest
         * @return DescribeDBInstanceEncryptionKeyResponse
         */
        public DescribeDBInstanceEncryptionKeyResponse DescribeDBInstanceEncryptionKey(DescribeDBInstanceEncryptionKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceEncryptionKeyWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of a key for an ApsaraDB for MongoDB instance.
         *
         * @description When you call the DescribeDBInstanceEncryptionKey operation, the instance must have transparent data encryption (TDE) enabled in BYOK mode. You can call the [ModifyDBInstanceTDE](https://help.aliyun.com/document_detail/131267.html) operation to enable TDE.
         *
         * @param request DescribeDBInstanceEncryptionKeyRequest
         * @return DescribeDBInstanceEncryptionKeyResponse
         */
        public async Task<DescribeDBInstanceEncryptionKeyResponse> DescribeDBInstanceEncryptionKeyAsync(DescribeDBInstanceEncryptionKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceEncryptionKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the collection frequency of monitoring data for an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeDBInstanceMonitorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBInstanceMonitorResponse
         */
        public DescribeDBInstanceMonitorResponse DescribeDBInstanceMonitorWithOptions(DescribeDBInstanceMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceMonitor",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceMonitorResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the collection frequency of monitoring data for an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeDBInstanceMonitorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBInstanceMonitorResponse
         */
        public async Task<DescribeDBInstanceMonitorResponse> DescribeDBInstanceMonitorWithOptionsAsync(DescribeDBInstanceMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceMonitor",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the collection frequency of monitoring data for an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeDBInstanceMonitorRequest
         * @return DescribeDBInstanceMonitorResponse
         */
        public DescribeDBInstanceMonitorResponse DescribeDBInstanceMonitor(DescribeDBInstanceMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceMonitorWithOptions(request, runtime);
        }

        /**
         * @summary Queries the collection frequency of monitoring data for an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeDBInstanceMonitorRequest
         * @return DescribeDBInstanceMonitorResponse
         */
        public async Task<DescribeDBInstanceMonitorResponse> DescribeDBInstanceMonitorAsync(DescribeDBInstanceMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceMonitorWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the performance data of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeDBInstancePerformanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBInstancePerformanceResponse
         */
        public DescribeDBInstancePerformanceResponse DescribeDBInstancePerformanceWithOptions(DescribeDBInstancePerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaSetRole))
            {
                query["ReplicaSetRole"] = request.ReplicaSetRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
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
                Action = "DescribeDBInstancePerformance",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstancePerformanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the performance data of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeDBInstancePerformanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBInstancePerformanceResponse
         */
        public async Task<DescribeDBInstancePerformanceResponse> DescribeDBInstancePerformanceWithOptionsAsync(DescribeDBInstancePerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaSetRole))
            {
                query["ReplicaSetRole"] = request.ReplicaSetRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
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
                Action = "DescribeDBInstancePerformance",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstancePerformanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the performance data of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeDBInstancePerformanceRequest
         * @return DescribeDBInstancePerformanceResponse
         */
        public DescribeDBInstancePerformanceResponse DescribeDBInstancePerformance(DescribeDBInstancePerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstancePerformanceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the performance data of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeDBInstancePerformanceRequest
         * @return DescribeDBInstancePerformanceResponse
         */
        public async Task<DescribeDBInstancePerformanceResponse> DescribeDBInstancePerformanceAsync(DescribeDBInstancePerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstancePerformanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the Secure Sockets Layer (SSL) settings of an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the following requirements are met:
         * *   The instance is in the Running state.
         * *   The instance is a replica set instance.
         * *   The instance runs MongoDB 3.4 or later.
         *
         * @param request DescribeDBInstanceSSLRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBInstanceSSLResponse
         */
        public DescribeDBInstanceSSLResponse DescribeDBInstanceSSLWithOptions(DescribeDBInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceSSL",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceSSLResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the Secure Sockets Layer (SSL) settings of an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the following requirements are met:
         * *   The instance is in the Running state.
         * *   The instance is a replica set instance.
         * *   The instance runs MongoDB 3.4 or later.
         *
         * @param request DescribeDBInstanceSSLRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBInstanceSSLResponse
         */
        public async Task<DescribeDBInstanceSSLResponse> DescribeDBInstanceSSLWithOptionsAsync(DescribeDBInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceSSL",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceSSLResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the Secure Sockets Layer (SSL) settings of an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the following requirements are met:
         * *   The instance is in the Running state.
         * *   The instance is a replica set instance.
         * *   The instance runs MongoDB 3.4 or later.
         *
         * @param request DescribeDBInstanceSSLRequest
         * @return DescribeDBInstanceSSLResponse
         */
        public DescribeDBInstanceSSLResponse DescribeDBInstanceSSL(DescribeDBInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceSSLWithOptions(request, runtime);
        }

        /**
         * @summary Queries the Secure Sockets Layer (SSL) settings of an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the following requirements are met:
         * *   The instance is in the Running state.
         * *   The instance is a replica set instance.
         * *   The instance runs MongoDB 3.4 or later.
         *
         * @param request DescribeDBInstanceSSLRequest
         * @return DescribeDBInstanceSSLResponse
         */
        public async Task<DescribeDBInstanceSSLResponse> DescribeDBInstanceSSLAsync(DescribeDBInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceSSLWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the primary/secondary switching logs of an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the ApsaraDB for MongoDB instance meets the following requirements:
         * *   The instance is a replica set or sharded cluster instance.
         * *   The instance uses local physical disks to store data.
         *
         * @param request DescribeDBInstanceSwitchLogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBInstanceSwitchLogResponse
         */
        public DescribeDBInstanceSwitchLogResponse DescribeDBInstanceSwitchLogWithOptions(DescribeDBInstanceSwitchLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Action = "DescribeDBInstanceSwitchLog",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceSwitchLogResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the primary/secondary switching logs of an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the ApsaraDB for MongoDB instance meets the following requirements:
         * *   The instance is a replica set or sharded cluster instance.
         * *   The instance uses local physical disks to store data.
         *
         * @param request DescribeDBInstanceSwitchLogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBInstanceSwitchLogResponse
         */
        public async Task<DescribeDBInstanceSwitchLogResponse> DescribeDBInstanceSwitchLogWithOptionsAsync(DescribeDBInstanceSwitchLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Action = "DescribeDBInstanceSwitchLog",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceSwitchLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the primary/secondary switching logs of an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the ApsaraDB for MongoDB instance meets the following requirements:
         * *   The instance is a replica set or sharded cluster instance.
         * *   The instance uses local physical disks to store data.
         *
         * @param request DescribeDBInstanceSwitchLogRequest
         * @return DescribeDBInstanceSwitchLogResponse
         */
        public DescribeDBInstanceSwitchLogResponse DescribeDBInstanceSwitchLog(DescribeDBInstanceSwitchLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceSwitchLogWithOptions(request, runtime);
        }

        /**
         * @summary Queries the primary/secondary switching logs of an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the ApsaraDB for MongoDB instance meets the following requirements:
         * *   The instance is a replica set or sharded cluster instance.
         * *   The instance uses local physical disks to store data.
         *
         * @param request DescribeDBInstanceSwitchLogRequest
         * @return DescribeDBInstanceSwitchLogResponse
         */
        public async Task<DescribeDBInstanceSwitchLogResponse> DescribeDBInstanceSwitchLogAsync(DescribeDBInstanceSwitchLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceSwitchLogWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries whether Transparent Data Encryption (TDE) is enabled for an ApsaraDB for MongoDB instance.
         *
         * @description >  For more information about TDE, see [TDE](https://help.aliyun.com/document_detail/131048.html).
         * Before you call this operation, make sure that the instance meets the following requirements:
         * *   The instance is a replica set or sharded cluster instance.
         * *   The storage engine of the instance is WiredTiger.
         * *   The database engine version of the instance is 4.0 or 4.2. If the database engine version is earlier than 4.0, you can call the [UpgradeDBInstanceEngineVersion](https://help.aliyun.com/document_detail/67608.html) operation to upgrade the database engine.
         *
         * @param request DescribeDBInstanceTDEInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBInstanceTDEInfoResponse
         */
        public DescribeDBInstanceTDEInfoResponse DescribeDBInstanceTDEInfoWithOptions(DescribeDBInstanceTDEInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceTDEInfo",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceTDEInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries whether Transparent Data Encryption (TDE) is enabled for an ApsaraDB for MongoDB instance.
         *
         * @description >  For more information about TDE, see [TDE](https://help.aliyun.com/document_detail/131048.html).
         * Before you call this operation, make sure that the instance meets the following requirements:
         * *   The instance is a replica set or sharded cluster instance.
         * *   The storage engine of the instance is WiredTiger.
         * *   The database engine version of the instance is 4.0 or 4.2. If the database engine version is earlier than 4.0, you can call the [UpgradeDBInstanceEngineVersion](https://help.aliyun.com/document_detail/67608.html) operation to upgrade the database engine.
         *
         * @param request DescribeDBInstanceTDEInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBInstanceTDEInfoResponse
         */
        public async Task<DescribeDBInstanceTDEInfoResponse> DescribeDBInstanceTDEInfoWithOptionsAsync(DescribeDBInstanceTDEInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceTDEInfo",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceTDEInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries whether Transparent Data Encryption (TDE) is enabled for an ApsaraDB for MongoDB instance.
         *
         * @description >  For more information about TDE, see [TDE](https://help.aliyun.com/document_detail/131048.html).
         * Before you call this operation, make sure that the instance meets the following requirements:
         * *   The instance is a replica set or sharded cluster instance.
         * *   The storage engine of the instance is WiredTiger.
         * *   The database engine version of the instance is 4.0 or 4.2. If the database engine version is earlier than 4.0, you can call the [UpgradeDBInstanceEngineVersion](https://help.aliyun.com/document_detail/67608.html) operation to upgrade the database engine.
         *
         * @param request DescribeDBInstanceTDEInfoRequest
         * @return DescribeDBInstanceTDEInfoResponse
         */
        public DescribeDBInstanceTDEInfoResponse DescribeDBInstanceTDEInfo(DescribeDBInstanceTDEInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceTDEInfoWithOptions(request, runtime);
        }

        /**
         * @summary Queries whether Transparent Data Encryption (TDE) is enabled for an ApsaraDB for MongoDB instance.
         *
         * @description >  For more information about TDE, see [TDE](https://help.aliyun.com/document_detail/131048.html).
         * Before you call this operation, make sure that the instance meets the following requirements:
         * *   The instance is a replica set or sharded cluster instance.
         * *   The storage engine of the instance is WiredTiger.
         * *   The database engine version of the instance is 4.0 or 4.2. If the database engine version is earlier than 4.0, you can call the [UpgradeDBInstanceEngineVersion](https://help.aliyun.com/document_detail/67608.html) operation to upgrade the database engine.
         *
         * @param request DescribeDBInstanceTDEInfoRequest
         * @return DescribeDBInstanceTDEInfoResponse
         */
        public async Task<DescribeDBInstanceTDEInfoResponse> DescribeDBInstanceTDEInfoAsync(DescribeDBInstanceTDEInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceTDEInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of ApsaraDB for MongoDB instances.
         *
         * @description The list of replica set and standalone instances is displayed when the **DBInstanceType** parameter uses the default value **replicate**. To query a list of sharded cluster instances, you must set the **DBInstanceType** parameter to **sharding**.
         *
         * @param request DescribeDBInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBInstancesResponse
         */
        public DescribeDBInstancesResponse DescribeDBInstancesWithOptions(DescribeDBInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionDomain))
            {
                query["ConnectionDomain"] = request.ConnectionDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceClass))
            {
                query["DBInstanceClass"] = request.DBInstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceDescription))
            {
                query["DBInstanceDescription"] = request.DBInstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceStatus))
            {
                query["DBInstanceStatus"] = request.DBInstanceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceType))
            {
                query["DBInstanceType"] = request.DBInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBNodeType))
            {
                query["DBNodeType"] = request.DBNodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expired))
            {
                query["Expired"] = request.Expired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationFactor))
            {
                query["ReplicationFactor"] = request.ReplicationFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
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
                Action = "DescribeDBInstances",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of ApsaraDB for MongoDB instances.
         *
         * @description The list of replica set and standalone instances is displayed when the **DBInstanceType** parameter uses the default value **replicate**. To query a list of sharded cluster instances, you must set the **DBInstanceType** parameter to **sharding**.
         *
         * @param request DescribeDBInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBInstancesResponse
         */
        public async Task<DescribeDBInstancesResponse> DescribeDBInstancesWithOptionsAsync(DescribeDBInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionDomain))
            {
                query["ConnectionDomain"] = request.ConnectionDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceClass))
            {
                query["DBInstanceClass"] = request.DBInstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceDescription))
            {
                query["DBInstanceDescription"] = request.DBInstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceStatus))
            {
                query["DBInstanceStatus"] = request.DBInstanceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceType))
            {
                query["DBInstanceType"] = request.DBInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBNodeType))
            {
                query["DBNodeType"] = request.DBNodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expired))
            {
                query["Expired"] = request.Expired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationFactor))
            {
                query["ReplicationFactor"] = request.ReplicationFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
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
                Action = "DescribeDBInstances",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of ApsaraDB for MongoDB instances.
         *
         * @description The list of replica set and standalone instances is displayed when the **DBInstanceType** parameter uses the default value **replicate**. To query a list of sharded cluster instances, you must set the **DBInstanceType** parameter to **sharding**.
         *
         * @param request DescribeDBInstancesRequest
         * @return DescribeDBInstancesResponse
         */
        public DescribeDBInstancesResponse DescribeDBInstances(DescribeDBInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstancesWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of ApsaraDB for MongoDB instances.
         *
         * @description The list of replica set and standalone instances is displayed when the **DBInstanceType** parameter uses the default value **replicate**. To query a list of sharded cluster instances, you must set the **DBInstanceType** parameter to **sharding**.
         *
         * @param request DescribeDBInstancesRequest
         * @return DescribeDBInstancesResponse
         */
        public async Task<DescribeDBInstancesResponse> DescribeDBInstancesAsync(DescribeDBInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the overview information of one or more ApsaraDB for MongoDB instances.
         *
         * @description *   If you do not specify an instance when you call this operation, the overview information of all instances in a specific region within this account is returned.
         * *   Paged query is disabled for this operation.
         *
         * @param request DescribeDBInstancesOverviewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBInstancesOverviewResponse
         */
        public DescribeDBInstancesOverviewResponse DescribeDBInstancesOverviewWithOptions(DescribeDBInstancesOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceClass))
            {
                query["InstanceClass"] = request.InstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceStatus))
            {
                query["InstanceStatus"] = request.InstanceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
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
                Action = "DescribeDBInstancesOverview",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstancesOverviewResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the overview information of one or more ApsaraDB for MongoDB instances.
         *
         * @description *   If you do not specify an instance when you call this operation, the overview information of all instances in a specific region within this account is returned.
         * *   Paged query is disabled for this operation.
         *
         * @param request DescribeDBInstancesOverviewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBInstancesOverviewResponse
         */
        public async Task<DescribeDBInstancesOverviewResponse> DescribeDBInstancesOverviewWithOptionsAsync(DescribeDBInstancesOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceClass))
            {
                query["InstanceClass"] = request.InstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceStatus))
            {
                query["InstanceStatus"] = request.InstanceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
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
                Action = "DescribeDBInstancesOverview",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstancesOverviewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the overview information of one or more ApsaraDB for MongoDB instances.
         *
         * @description *   If you do not specify an instance when you call this operation, the overview information of all instances in a specific region within this account is returned.
         * *   Paged query is disabled for this operation.
         *
         * @param request DescribeDBInstancesOverviewRequest
         * @return DescribeDBInstancesOverviewResponse
         */
        public DescribeDBInstancesOverviewResponse DescribeDBInstancesOverview(DescribeDBInstancesOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstancesOverviewWithOptions(request, runtime);
        }

        /**
         * @summary Queries the overview information of one or more ApsaraDB for MongoDB instances.
         *
         * @description *   If you do not specify an instance when you call this operation, the overview information of all instances in a specific region within this account is returned.
         * *   Paged query is disabled for this operation.
         *
         * @param request DescribeDBInstancesOverviewRequest
         * @return DescribeDBInstancesOverviewResponse
         */
        public async Task<DescribeDBInstancesOverviewResponse> DescribeDBInstancesOverviewAsync(DescribeDBInstancesOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstancesOverviewWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries entries in error logs of an ApsaraDB for MongoDB instance.
         *
         * @description *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeErrorLogRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeErrorLogRecordsResponse
         */
        public DescribeErrorLogRecordsResponse DescribeErrorLogRecordsWithOptions(DescribeErrorLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBName))
            {
                query["DBName"] = request.DBName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalOperator))
            {
                query["LogicalOperator"] = request.LogicalOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeywords))
            {
                query["QueryKeywords"] = request.QueryKeywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                query["RoleType"] = request.RoleType;
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
                Action = "DescribeErrorLogRecords",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeErrorLogRecordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries entries in error logs of an ApsaraDB for MongoDB instance.
         *
         * @description *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeErrorLogRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeErrorLogRecordsResponse
         */
        public async Task<DescribeErrorLogRecordsResponse> DescribeErrorLogRecordsWithOptionsAsync(DescribeErrorLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBName))
            {
                query["DBName"] = request.DBName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalOperator))
            {
                query["LogicalOperator"] = request.LogicalOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeywords))
            {
                query["QueryKeywords"] = request.QueryKeywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                query["RoleType"] = request.RoleType;
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
                Action = "DescribeErrorLogRecords",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeErrorLogRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries entries in error logs of an ApsaraDB for MongoDB instance.
         *
         * @description *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeErrorLogRecordsRequest
         * @return DescribeErrorLogRecordsResponse
         */
        public DescribeErrorLogRecordsResponse DescribeErrorLogRecords(DescribeErrorLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeErrorLogRecordsWithOptions(request, runtime);
        }

        /**
         * @summary Queries entries in error logs of an ApsaraDB for MongoDB instance.
         *
         * @description *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeErrorLogRecordsRequest
         * @return DescribeErrorLogRecordsResponse
         */
        public async Task<DescribeErrorLogRecordsResponse> DescribeErrorLogRecordsAsync(DescribeErrorLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeErrorLogRecordsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the global IP whitelist template of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeGlobalSecurityIPGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGlobalSecurityIPGroupResponse
         */
        public DescribeGlobalSecurityIPGroupResponse DescribeGlobalSecurityIPGroupWithOptions(DescribeGlobalSecurityIPGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGlobalSecurityIPGroup",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGlobalSecurityIPGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the global IP whitelist template of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeGlobalSecurityIPGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGlobalSecurityIPGroupResponse
         */
        public async Task<DescribeGlobalSecurityIPGroupResponse> DescribeGlobalSecurityIPGroupWithOptionsAsync(DescribeGlobalSecurityIPGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGlobalSecurityIPGroup",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGlobalSecurityIPGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the global IP whitelist template of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeGlobalSecurityIPGroupRequest
         * @return DescribeGlobalSecurityIPGroupResponse
         */
        public DescribeGlobalSecurityIPGroupResponse DescribeGlobalSecurityIPGroup(DescribeGlobalSecurityIPGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGlobalSecurityIPGroupWithOptions(request, runtime);
        }

        /**
         * @summary Queries the global IP whitelist template of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeGlobalSecurityIPGroupRequest
         * @return DescribeGlobalSecurityIPGroupResponse
         */
        public async Task<DescribeGlobalSecurityIPGroupResponse> DescribeGlobalSecurityIPGroupAsync(DescribeGlobalSecurityIPGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGlobalSecurityIPGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the global IP whitelist templates associated with an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeGlobalSecurityIPGroupRelationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGlobalSecurityIPGroupRelationResponse
         */
        public DescribeGlobalSecurityIPGroupRelationResponse DescribeGlobalSecurityIPGroupRelationWithOptions(DescribeGlobalSecurityIPGroupRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGlobalSecurityIPGroupRelation",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGlobalSecurityIPGroupRelationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the global IP whitelist templates associated with an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeGlobalSecurityIPGroupRelationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGlobalSecurityIPGroupRelationResponse
         */
        public async Task<DescribeGlobalSecurityIPGroupRelationResponse> DescribeGlobalSecurityIPGroupRelationWithOptionsAsync(DescribeGlobalSecurityIPGroupRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGlobalSecurityIPGroupRelation",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGlobalSecurityIPGroupRelationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the global IP whitelist templates associated with an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeGlobalSecurityIPGroupRelationRequest
         * @return DescribeGlobalSecurityIPGroupRelationResponse
         */
        public DescribeGlobalSecurityIPGroupRelationResponse DescribeGlobalSecurityIPGroupRelation(DescribeGlobalSecurityIPGroupRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGlobalSecurityIPGroupRelationWithOptions(request, runtime);
        }

        /**
         * @summary Queries the global IP whitelist templates associated with an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeGlobalSecurityIPGroupRelationRequest
         * @return DescribeGlobalSecurityIPGroupRelationResponse
         */
        public async Task<DescribeGlobalSecurityIPGroupRelationResponse> DescribeGlobalSecurityIPGroupRelationAsync(DescribeGlobalSecurityIPGroupRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGlobalSecurityIPGroupRelationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of tasks in the task center.
         *
         * @param request DescribeHistoryTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeHistoryTasksResponse
         */
        public DescribeHistoryTasksResponse DescribeHistoryTasksWithOptions(DescribeHistoryTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromExecTime))
            {
                query["FromExecTime"] = request.FromExecTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromStartTime))
            {
                query["FromStartTime"] = request.FromStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToExecTime))
            {
                query["ToExecTime"] = request.ToExecTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToStartTime))
            {
                query["ToStartTime"] = request.ToStartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHistoryTasks",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHistoryTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of tasks in the task center.
         *
         * @param request DescribeHistoryTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeHistoryTasksResponse
         */
        public async Task<DescribeHistoryTasksResponse> DescribeHistoryTasksWithOptionsAsync(DescribeHistoryTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromExecTime))
            {
                query["FromExecTime"] = request.FromExecTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromStartTime))
            {
                query["FromStartTime"] = request.FromStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToExecTime))
            {
                query["ToExecTime"] = request.ToExecTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToStartTime))
            {
                query["ToStartTime"] = request.ToStartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHistoryTasks",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHistoryTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of tasks in the task center.
         *
         * @param request DescribeHistoryTasksRequest
         * @return DescribeHistoryTasksResponse
         */
        public DescribeHistoryTasksResponse DescribeHistoryTasks(DescribeHistoryTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHistoryTasksWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of tasks in the task center.
         *
         * @param request DescribeHistoryTasksRequest
         * @return DescribeHistoryTasksResponse
         */
        public async Task<DescribeHistoryTasksResponse> DescribeHistoryTasksAsync(DescribeHistoryTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHistoryTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the overview of a task in the task center.
         *
         * @param request DescribeHistoryTasksStatRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeHistoryTasksStatResponse
         */
        public DescribeHistoryTasksStatResponse DescribeHistoryTasksStatWithOptions(DescribeHistoryTasksStatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromExecTime))
            {
                query["FromExecTime"] = request.FromExecTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromStartTime))
            {
                query["FromStartTime"] = request.FromStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToExecTime))
            {
                query["ToExecTime"] = request.ToExecTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToStartTime))
            {
                query["ToStartTime"] = request.ToStartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHistoryTasksStat",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHistoryTasksStatResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the overview of a task in the task center.
         *
         * @param request DescribeHistoryTasksStatRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeHistoryTasksStatResponse
         */
        public async Task<DescribeHistoryTasksStatResponse> DescribeHistoryTasksStatWithOptionsAsync(DescribeHistoryTasksStatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromExecTime))
            {
                query["FromExecTime"] = request.FromExecTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromStartTime))
            {
                query["FromStartTime"] = request.FromStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToExecTime))
            {
                query["ToExecTime"] = request.ToExecTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToStartTime))
            {
                query["ToStartTime"] = request.ToStartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHistoryTasksStat",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHistoryTasksStatResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the overview of a task in the task center.
         *
         * @param request DescribeHistoryTasksStatRequest
         * @return DescribeHistoryTasksStatResponse
         */
        public DescribeHistoryTasksStatResponse DescribeHistoryTasksStat(DescribeHistoryTasksStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHistoryTasksStatWithOptions(request, runtime);
        }

        /**
         * @summary Queries the overview of a task in the task center.
         *
         * @param request DescribeHistoryTasksStatRequest
         * @return DescribeHistoryTasksStatResponse
         */
        public async Task<DescribeHistoryTasksStatResponse> DescribeHistoryTasksStatAsync(DescribeHistoryTasksStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHistoryTasksStatWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query whether auto-renewal is enabled for an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable to subscription instances.
         *
         * @param request DescribeInstanceAutoRenewalAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceAutoRenewalAttributeResponse
         */
        public DescribeInstanceAutoRenewalAttributeResponse DescribeInstanceAutoRenewalAttributeWithOptions(DescribeInstanceAutoRenewalAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceType))
            {
                query["DBInstanceType"] = request.DBInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceAutoRenewalAttribute",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceAutoRenewalAttributeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query whether auto-renewal is enabled for an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable to subscription instances.
         *
         * @param request DescribeInstanceAutoRenewalAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceAutoRenewalAttributeResponse
         */
        public async Task<DescribeInstanceAutoRenewalAttributeResponse> DescribeInstanceAutoRenewalAttributeWithOptionsAsync(DescribeInstanceAutoRenewalAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceType))
            {
                query["DBInstanceType"] = request.DBInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceAutoRenewalAttribute",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceAutoRenewalAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query whether auto-renewal is enabled for an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable to subscription instances.
         *
         * @param request DescribeInstanceAutoRenewalAttributeRequest
         * @return DescribeInstanceAutoRenewalAttributeResponse
         */
        public DescribeInstanceAutoRenewalAttributeResponse DescribeInstanceAutoRenewalAttribute(DescribeInstanceAutoRenewalAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceAutoRenewalAttributeWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query whether auto-renewal is enabled for an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable to subscription instances.
         *
         * @param request DescribeInstanceAutoRenewalAttributeRequest
         * @return DescribeInstanceAutoRenewalAttributeResponse
         */
        public async Task<DescribeInstanceAutoRenewalAttributeResponse> DescribeInstanceAutoRenewalAttributeAsync(DescribeInstanceAutoRenewalAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceAutoRenewalAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the time required to restore the data of an ApsaraDB for MongoDB replica set instance that uses cloud disks.
         *
         * @param request DescribeInstanceRecoverTimeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceRecoverTimeResponse
         */
        public DescribeInstanceRecoverTimeResponse DescribeInstanceRecoverTimeWithOptions(DescribeInstanceRecoverTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceRecoverTime",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceRecoverTimeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the time required to restore the data of an ApsaraDB for MongoDB replica set instance that uses cloud disks.
         *
         * @param request DescribeInstanceRecoverTimeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceRecoverTimeResponse
         */
        public async Task<DescribeInstanceRecoverTimeResponse> DescribeInstanceRecoverTimeWithOptionsAsync(DescribeInstanceRecoverTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceRecoverTime",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceRecoverTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the time required to restore the data of an ApsaraDB for MongoDB replica set instance that uses cloud disks.
         *
         * @param request DescribeInstanceRecoverTimeRequest
         * @return DescribeInstanceRecoverTimeResponse
         */
        public DescribeInstanceRecoverTimeResponse DescribeInstanceRecoverTime(DescribeInstanceRecoverTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceRecoverTimeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the time required to restore the data of an ApsaraDB for MongoDB replica set instance that uses cloud disks.
         *
         * @param request DescribeInstanceRecoverTimeRequest
         * @return DescribeInstanceRecoverTimeResponse
         */
        public async Task<DescribeInstanceRecoverTimeResponse> DescribeInstanceRecoverTimeAsync(DescribeInstanceRecoverTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceRecoverTimeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the release notes of the minor versions of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeKernelReleaseNotesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeKernelReleaseNotesResponse
         */
        public DescribeKernelReleaseNotesResponse DescribeKernelReleaseNotesWithOptions(DescribeKernelReleaseNotesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KernelVersion))
            {
                query["KernelVersion"] = request.KernelVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeKernelReleaseNotes",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeKernelReleaseNotesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the release notes of the minor versions of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeKernelReleaseNotesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeKernelReleaseNotesResponse
         */
        public async Task<DescribeKernelReleaseNotesResponse> DescribeKernelReleaseNotesWithOptionsAsync(DescribeKernelReleaseNotesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KernelVersion))
            {
                query["KernelVersion"] = request.KernelVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeKernelReleaseNotes",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeKernelReleaseNotesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the release notes of the minor versions of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeKernelReleaseNotesRequest
         * @return DescribeKernelReleaseNotesResponse
         */
        public DescribeKernelReleaseNotesResponse DescribeKernelReleaseNotes(DescribeKernelReleaseNotesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeKernelReleaseNotesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the release notes of the minor versions of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeKernelReleaseNotesRequest
         * @return DescribeKernelReleaseNotesResponse
         */
        public async Task<DescribeKernelReleaseNotesResponse> DescribeKernelReleaseNotesAsync(DescribeKernelReleaseNotesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeKernelReleaseNotesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries Key Management Service (KMS) keys that are available for disk encryption.
         *
         * @description Queried keys are available only for disk encryption.
         *
         * @param request DescribeKmsKeysRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeKmsKeysResponse
         */
        public DescribeKmsKeysResponse DescribeKmsKeysWithOptions(DescribeKmsKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeKmsKeys",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeKmsKeysResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries Key Management Service (KMS) keys that are available for disk encryption.
         *
         * @description Queried keys are available only for disk encryption.
         *
         * @param request DescribeKmsKeysRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeKmsKeysResponse
         */
        public async Task<DescribeKmsKeysResponse> DescribeKmsKeysWithOptionsAsync(DescribeKmsKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeKmsKeys",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeKmsKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries Key Management Service (KMS) keys that are available for disk encryption.
         *
         * @description Queried keys are available only for disk encryption.
         *
         * @param request DescribeKmsKeysRequest
         * @return DescribeKmsKeysResponse
         */
        public DescribeKmsKeysResponse DescribeKmsKeys(DescribeKmsKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeKmsKeysWithOptions(request, runtime);
        }

        /**
         * @summary Queries Key Management Service (KMS) keys that are available for disk encryption.
         *
         * @description Queried keys are available only for disk encryption.
         *
         * @param request DescribeKmsKeysRequest
         * @return DescribeKmsKeysResponse
         */
        public async Task<DescribeKmsKeysResponse> DescribeKmsKeysAsync(DescribeKmsKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeKmsKeysWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the logging configurations of an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * This operation depends on the audit log feature of ApsaraDB for MongoDB. You can enable the audit log feature based on your business requirements. For more information, see [Enable the audit log feature](https://help.aliyun.com/document_detail/59903.html).
         * *   Starting from January 6, 2022, the official edition of the audit log feature has been launched in all regions, and new applications for the free trial edition have ended. For more information, see [Notice on official launch of the pay-as-you-go audit log feature and no more application for the free trial edition](https://help.aliyun.com/document_detail/377480.html)
         * *   You are charged for the official edition of the audit log feature based on the storage capacity that is consumed by audit logs and the retention period of the audit logs. For more information, see [Pricing of ApsaraDB for MongoDB instances](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing).
         *
         * @param request DescribeMongoDBLogConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMongoDBLogConfigResponse
         */
        public DescribeMongoDBLogConfigResponse DescribeMongoDBLogConfigWithOptions(DescribeMongoDBLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMongoDBLogConfig",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMongoDBLogConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the logging configurations of an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * This operation depends on the audit log feature of ApsaraDB for MongoDB. You can enable the audit log feature based on your business requirements. For more information, see [Enable the audit log feature](https://help.aliyun.com/document_detail/59903.html).
         * *   Starting from January 6, 2022, the official edition of the audit log feature has been launched in all regions, and new applications for the free trial edition have ended. For more information, see [Notice on official launch of the pay-as-you-go audit log feature and no more application for the free trial edition](https://help.aliyun.com/document_detail/377480.html)
         * *   You are charged for the official edition of the audit log feature based on the storage capacity that is consumed by audit logs and the retention period of the audit logs. For more information, see [Pricing of ApsaraDB for MongoDB instances](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing).
         *
         * @param request DescribeMongoDBLogConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMongoDBLogConfigResponse
         */
        public async Task<DescribeMongoDBLogConfigResponse> DescribeMongoDBLogConfigWithOptionsAsync(DescribeMongoDBLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMongoDBLogConfig",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMongoDBLogConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the logging configurations of an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * This operation depends on the audit log feature of ApsaraDB for MongoDB. You can enable the audit log feature based on your business requirements. For more information, see [Enable the audit log feature](https://help.aliyun.com/document_detail/59903.html).
         * *   Starting from January 6, 2022, the official edition of the audit log feature has been launched in all regions, and new applications for the free trial edition have ended. For more information, see [Notice on official launch of the pay-as-you-go audit log feature and no more application for the free trial edition](https://help.aliyun.com/document_detail/377480.html)
         * *   You are charged for the official edition of the audit log feature based on the storage capacity that is consumed by audit logs and the retention period of the audit logs. For more information, see [Pricing of ApsaraDB for MongoDB instances](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing).
         *
         * @param request DescribeMongoDBLogConfigRequest
         * @return DescribeMongoDBLogConfigResponse
         */
        public DescribeMongoDBLogConfigResponse DescribeMongoDBLogConfig(DescribeMongoDBLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMongoDBLogConfigWithOptions(request, runtime);
        }

        /**
         * @summary Queries the logging configurations of an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * This operation depends on the audit log feature of ApsaraDB for MongoDB. You can enable the audit log feature based on your business requirements. For more information, see [Enable the audit log feature](https://help.aliyun.com/document_detail/59903.html).
         * *   Starting from January 6, 2022, the official edition of the audit log feature has been launched in all regions, and new applications for the free trial edition have ended. For more information, see [Notice on official launch of the pay-as-you-go audit log feature and no more application for the free trial edition](https://help.aliyun.com/document_detail/377480.html)
         * *   You are charged for the official edition of the audit log feature based on the storage capacity that is consumed by audit logs and the retention period of the audit logs. For more information, see [Pricing of ApsaraDB for MongoDB instances](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing).
         *
         * @param request DescribeMongoDBLogConfigRequest
         * @return DescribeMongoDBLogConfigResponse
         */
        public async Task<DescribeMongoDBLogConfigResponse> DescribeMongoDBLogConfigAsync(DescribeMongoDBLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMongoDBLogConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the parameter modification records of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeParameterModificationHistoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeParameterModificationHistoryResponse
         */
        public DescribeParameterModificationHistoryResponse DescribeParameterModificationHistoryWithOptions(DescribeParameterModificationHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CharacterType))
            {
                query["CharacterType"] = request.CharacterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Action = "DescribeParameterModificationHistory",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeParameterModificationHistoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the parameter modification records of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeParameterModificationHistoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeParameterModificationHistoryResponse
         */
        public async Task<DescribeParameterModificationHistoryResponse> DescribeParameterModificationHistoryWithOptionsAsync(DescribeParameterModificationHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CharacterType))
            {
                query["CharacterType"] = request.CharacterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Action = "DescribeParameterModificationHistory",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeParameterModificationHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the parameter modification records of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeParameterModificationHistoryRequest
         * @return DescribeParameterModificationHistoryResponse
         */
        public DescribeParameterModificationHistoryResponse DescribeParameterModificationHistory(DescribeParameterModificationHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeParameterModificationHistoryWithOptions(request, runtime);
        }

        /**
         * @summary Queries the parameter modification records of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeParameterModificationHistoryRequest
         * @return DescribeParameterModificationHistoryResponse
         */
        public async Task<DescribeParameterModificationHistoryResponse> DescribeParameterModificationHistoryAsync(DescribeParameterModificationHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeParameterModificationHistoryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the list of default parameter templates for ApsaraDB for MongoDB instances.
         *
         * @param request DescribeParameterTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeParameterTemplatesResponse
         */
        public DescribeParameterTemplatesResponse DescribeParameterTemplatesWithOptions(DescribeParameterTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeParameterTemplates",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeParameterTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the list of default parameter templates for ApsaraDB for MongoDB instances.
         *
         * @param request DescribeParameterTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeParameterTemplatesResponse
         */
        public async Task<DescribeParameterTemplatesResponse> DescribeParameterTemplatesWithOptionsAsync(DescribeParameterTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeParameterTemplates",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeParameterTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the list of default parameter templates for ApsaraDB for MongoDB instances.
         *
         * @param request DescribeParameterTemplatesRequest
         * @return DescribeParameterTemplatesResponse
         */
        public DescribeParameterTemplatesResponse DescribeParameterTemplates(DescribeParameterTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeParameterTemplatesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the list of default parameter templates for ApsaraDB for MongoDB instances.
         *
         * @param request DescribeParameterTemplatesRequest
         * @return DescribeParameterTemplatesResponse
         */
        public async Task<DescribeParameterTemplatesResponse> DescribeParameterTemplatesAsync(DescribeParameterTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeParameterTemplatesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the parameter settings of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeParametersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeParametersResponse
         */
        public DescribeParametersResponse DescribeParametersWithOptions(DescribeParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CharacterType))
            {
                query["CharacterType"] = request.CharacterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParam))
            {
                query["ExtraParam"] = request.ExtraParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeParameters",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeParametersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the parameter settings of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeParametersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeParametersResponse
         */
        public async Task<DescribeParametersResponse> DescribeParametersWithOptionsAsync(DescribeParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CharacterType))
            {
                query["CharacterType"] = request.CharacterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParam))
            {
                query["ExtraParam"] = request.ExtraParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeParameters",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeParametersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the parameter settings of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeParametersRequest
         * @return DescribeParametersResponse
         */
        public DescribeParametersResponse DescribeParameters(DescribeParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeParametersWithOptions(request, runtime);
        }

        /**
         * @summary Queries the parameter settings of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeParametersRequest
         * @return DescribeParametersResponse
         */
        public async Task<DescribeParametersResponse> DescribeParametersAsync(DescribeParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeParametersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the fees incurred when you create, upgrade, or renew an ApsaraDB for MongoDB instance.
         *
         * @param request DescribePriceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePriceResponse
         */
        public DescribePriceResponse DescribePriceWithOptions(DescribePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                query["CommodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstances))
            {
                query["DBInstances"] = request.DBInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderParamOut))
            {
                query["OrderParamOut"] = request.OrderParamOut;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePrice",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePriceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the fees incurred when you create, upgrade, or renew an ApsaraDB for MongoDB instance.
         *
         * @param request DescribePriceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePriceResponse
         */
        public async Task<DescribePriceResponse> DescribePriceWithOptionsAsync(DescribePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                query["CommodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstances))
            {
                query["DBInstances"] = request.DBInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderParamOut))
            {
                query["OrderParamOut"] = request.OrderParamOut;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePrice",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the fees incurred when you create, upgrade, or renew an ApsaraDB for MongoDB instance.
         *
         * @param request DescribePriceRequest
         * @return DescribePriceResponse
         */
        public DescribePriceResponse DescribePrice(DescribePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePriceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the fees incurred when you create, upgrade, or renew an ApsaraDB for MongoDB instance.
         *
         * @param request DescribePriceRequest
         * @return DescribePriceResponse
         */
        public async Task<DescribePriceResponse> DescribePriceAsync(DescribePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePriceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all regions and zones supported for an ApsaraDB for MongoDB instance.
         *
         * @description >  To query available regions and zones in which an ApsaraDB for MongoDB instance can be created, call the [DescribeAvailableResource](https://help.aliyun.com/document_detail/149719.html) operation.
         *
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2015-12-01",
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
         * @summary Queries all regions and zones supported for an ApsaraDB for MongoDB instance.
         *
         * @description >  To query available regions and zones in which an ApsaraDB for MongoDB instance can be created, call the [DescribeAvailableResource](https://help.aliyun.com/document_detail/149719.html) operation.
         *
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2015-12-01",
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
         * @summary Queries all regions and zones supported for an ApsaraDB for MongoDB instance.
         *
         * @description >  To query available regions and zones in which an ApsaraDB for MongoDB instance can be created, call the [DescribeAvailableResource](https://help.aliyun.com/document_detail/149719.html) operation.
         *
         * @param request DescribeRegionsRequest
         * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        /**
         * @summary Queries all regions and zones supported for an ApsaraDB for MongoDB instance.
         *
         * @description >  To query available regions and zones in which an ApsaraDB for MongoDB instance can be created, call the [DescribeAvailableResource](https://help.aliyun.com/document_detail/149719.html) operation.
         *
         * @param request DescribeRegionsRequest
         * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the monthly renewal price of an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable to subscription instances.
         *
         * @param request DescribeRenewalPriceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRenewalPriceResponse
         */
        public DescribeRenewalPriceResponse DescribeRenewalPriceWithOptions(DescribeRenewalPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRenewalPrice",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRenewalPriceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the monthly renewal price of an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable to subscription instances.
         *
         * @param request DescribeRenewalPriceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRenewalPriceResponse
         */
        public async Task<DescribeRenewalPriceResponse> DescribeRenewalPriceWithOptionsAsync(DescribeRenewalPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRenewalPrice",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRenewalPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the monthly renewal price of an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable to subscription instances.
         *
         * @param request DescribeRenewalPriceRequest
         * @return DescribeRenewalPriceResponse
         */
        public DescribeRenewalPriceResponse DescribeRenewalPrice(DescribeRenewalPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRenewalPriceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the monthly renewal price of an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable to subscription instances.
         *
         * @param request DescribeRenewalPriceRequest
         * @return DescribeRenewalPriceResponse
         */
        public async Task<DescribeRenewalPriceResponse> DescribeRenewalPriceAsync(DescribeRenewalPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRenewalPriceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the role and connection information of an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable to replica set instances and standalone instances, but not to sharded cluster instances.
         *
         * @param request DescribeReplicaSetRoleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeReplicaSetRoleResponse
         */
        public DescribeReplicaSetRoleResponse DescribeReplicaSetRoleWithOptions(DescribeReplicaSetRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeReplicaSetRole",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeReplicaSetRoleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the role and connection information of an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable to replica set instances and standalone instances, but not to sharded cluster instances.
         *
         * @param request DescribeReplicaSetRoleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeReplicaSetRoleResponse
         */
        public async Task<DescribeReplicaSetRoleResponse> DescribeReplicaSetRoleWithOptionsAsync(DescribeReplicaSetRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeReplicaSetRole",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeReplicaSetRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the role and connection information of an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable to replica set instances and standalone instances, but not to sharded cluster instances.
         *
         * @param request DescribeReplicaSetRoleRequest
         * @return DescribeReplicaSetRoleResponse
         */
        public DescribeReplicaSetRoleResponse DescribeReplicaSetRole(DescribeReplicaSetRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeReplicaSetRoleWithOptions(request, runtime);
        }

        /**
         * @summary Queries the role and connection information of an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable to replica set instances and standalone instances, but not to sharded cluster instances.
         *
         * @param request DescribeReplicaSetRoleRequest
         * @return DescribeReplicaSetRoleResponse
         */
        public async Task<DescribeReplicaSetRoleResponse> DescribeReplicaSetRoleAsync(DescribeReplicaSetRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeReplicaSetRoleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the role and zone of each node in an ApsaraDB for MongoDB instance.
         *
         * @description > For more information, see [View the zone of a node](https://help.aliyun.com/document_detail/123825.html).
         * This operation is applicable to replica set instances and sharded cluster instances, but cannot be performed on standalone instances.
         *
         * @param request DescribeRoleZoneInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRoleZoneInfoResponse
         */
        public DescribeRoleZoneInfoResponse DescribeRoleZoneInfoWithOptions(DescribeRoleZoneInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRoleZoneInfo",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRoleZoneInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the role and zone of each node in an ApsaraDB for MongoDB instance.
         *
         * @description > For more information, see [View the zone of a node](https://help.aliyun.com/document_detail/123825.html).
         * This operation is applicable to replica set instances and sharded cluster instances, but cannot be performed on standalone instances.
         *
         * @param request DescribeRoleZoneInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRoleZoneInfoResponse
         */
        public async Task<DescribeRoleZoneInfoResponse> DescribeRoleZoneInfoWithOptionsAsync(DescribeRoleZoneInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRoleZoneInfo",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRoleZoneInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the role and zone of each node in an ApsaraDB for MongoDB instance.
         *
         * @description > For more information, see [View the zone of a node](https://help.aliyun.com/document_detail/123825.html).
         * This operation is applicable to replica set instances and sharded cluster instances, but cannot be performed on standalone instances.
         *
         * @param request DescribeRoleZoneInfoRequest
         * @return DescribeRoleZoneInfoResponse
         */
        public DescribeRoleZoneInfoResponse DescribeRoleZoneInfo(DescribeRoleZoneInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRoleZoneInfoWithOptions(request, runtime);
        }

        /**
         * @summary Queries the role and zone of each node in an ApsaraDB for MongoDB instance.
         *
         * @description > For more information, see [View the zone of a node](https://help.aliyun.com/document_detail/123825.html).
         * This operation is applicable to replica set instances and sharded cluster instances, but cannot be performed on standalone instances.
         *
         * @param request DescribeRoleZoneInfoRequest
         * @return DescribeRoleZoneInfoResponse
         */
        public async Task<DescribeRoleZoneInfoResponse> DescribeRoleZoneInfoAsync(DescribeRoleZoneInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRoleZoneInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries entries in operational logs of an ApsaraDB for MongoDB instance.
         *
         * @description *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeRunningLogRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRunningLogRecordsResponse
         */
        public DescribeRunningLogRecordsResponse DescribeRunningLogRecordsWithOptions(DescribeRunningLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBName))
            {
                query["DBName"] = request.DBName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalOperator))
            {
                query["LogicalOperator"] = request.LogicalOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeywords))
            {
                query["QueryKeywords"] = request.QueryKeywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                query["RoleType"] = request.RoleType;
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
                Action = "DescribeRunningLogRecords",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRunningLogRecordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries entries in operational logs of an ApsaraDB for MongoDB instance.
         *
         * @description *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeRunningLogRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRunningLogRecordsResponse
         */
        public async Task<DescribeRunningLogRecordsResponse> DescribeRunningLogRecordsWithOptionsAsync(DescribeRunningLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBName))
            {
                query["DBName"] = request.DBName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalOperator))
            {
                query["LogicalOperator"] = request.LogicalOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeywords))
            {
                query["QueryKeywords"] = request.QueryKeywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                query["RoleType"] = request.RoleType;
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
                Action = "DescribeRunningLogRecords",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRunningLogRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries entries in operational logs of an ApsaraDB for MongoDB instance.
         *
         * @description *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeRunningLogRecordsRequest
         * @return DescribeRunningLogRecordsResponse
         */
        public DescribeRunningLogRecordsResponse DescribeRunningLogRecords(DescribeRunningLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRunningLogRecordsWithOptions(request, runtime);
        }

        /**
         * @summary Queries entries in operational logs of an ApsaraDB for MongoDB instance.
         *
         * @description *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeRunningLogRecordsRequest
         * @return DescribeRunningLogRecordsResponse
         */
        public async Task<DescribeRunningLogRecordsResponse> DescribeRunningLogRecordsAsync(DescribeRunningLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRunningLogRecordsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query ECS security groups that are bound to an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeSecurityGroupConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSecurityGroupConfigurationResponse
         */
        public DescribeSecurityGroupConfigurationResponse DescribeSecurityGroupConfigurationWithOptions(DescribeSecurityGroupConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecurityGroupConfiguration",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecurityGroupConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query ECS security groups that are bound to an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeSecurityGroupConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSecurityGroupConfigurationResponse
         */
        public async Task<DescribeSecurityGroupConfigurationResponse> DescribeSecurityGroupConfigurationWithOptionsAsync(DescribeSecurityGroupConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecurityGroupConfiguration",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecurityGroupConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query ECS security groups that are bound to an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeSecurityGroupConfigurationRequest
         * @return DescribeSecurityGroupConfigurationResponse
         */
        public DescribeSecurityGroupConfigurationResponse DescribeSecurityGroupConfiguration(DescribeSecurityGroupConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityGroupConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query ECS security groups that are bound to an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeSecurityGroupConfigurationRequest
         * @return DescribeSecurityGroupConfigurationResponse
         */
        public async Task<DescribeSecurityGroupConfigurationResponse> DescribeSecurityGroupConfigurationAsync(DescribeSecurityGroupConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityGroupConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query the IP whitelists of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeSecurityIpsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSecurityIpsResponse
         */
        public DescribeSecurityIpsResponse DescribeSecurityIpsWithOptions(DescribeSecurityIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowHDMIps))
            {
                query["ShowHDMIps"] = request.ShowHDMIps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecurityIps",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecurityIpsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the IP whitelists of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeSecurityIpsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSecurityIpsResponse
         */
        public async Task<DescribeSecurityIpsResponse> DescribeSecurityIpsWithOptionsAsync(DescribeSecurityIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowHDMIps))
            {
                query["ShowHDMIps"] = request.ShowHDMIps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecurityIps",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecurityIpsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the IP whitelists of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeSecurityIpsRequest
         * @return DescribeSecurityIpsResponse
         */
        public DescribeSecurityIpsResponse DescribeSecurityIps(DescribeSecurityIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityIpsWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query the IP whitelists of an ApsaraDB for MongoDB instance.
         *
         * @param request DescribeSecurityIpsRequest
         * @return DescribeSecurityIpsResponse
         */
        public async Task<DescribeSecurityIpsResponse> DescribeSecurityIpsAsync(DescribeSecurityIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityIpsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries connection information about an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description This operation is applicable only to sharded cluster instances.
         *
         * @param request DescribeShardingNetworkAddressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeShardingNetworkAddressResponse
         */
        public DescribeShardingNetworkAddressResponse DescribeShardingNetworkAddressWithOptions(DescribeShardingNetworkAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeShardingNetworkAddress",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeShardingNetworkAddressResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries connection information about an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description This operation is applicable only to sharded cluster instances.
         *
         * @param request DescribeShardingNetworkAddressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeShardingNetworkAddressResponse
         */
        public async Task<DescribeShardingNetworkAddressResponse> DescribeShardingNetworkAddressWithOptionsAsync(DescribeShardingNetworkAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeShardingNetworkAddress",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeShardingNetworkAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries connection information about an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description This operation is applicable only to sharded cluster instances.
         *
         * @param request DescribeShardingNetworkAddressRequest
         * @return DescribeShardingNetworkAddressResponse
         */
        public DescribeShardingNetworkAddressResponse DescribeShardingNetworkAddress(DescribeShardingNetworkAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeShardingNetworkAddressWithOptions(request, runtime);
        }

        /**
         * @summary Queries connection information about an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description This operation is applicable only to sharded cluster instances.
         *
         * @param request DescribeShardingNetworkAddressRequest
         * @return DescribeShardingNetworkAddressResponse
         */
        public async Task<DescribeShardingNetworkAddressResponse> DescribeShardingNetworkAddressAsync(DescribeShardingNetworkAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeShardingNetworkAddressWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of entries in slow query logs of an ApsaraDB for MongoDB instance.
         *
         * @description *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeSlowLogRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSlowLogRecordsResponse
         */
        public DescribeSlowLogRecordsResponse DescribeSlowLogRecordsWithOptions(DescribeSlowLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBName))
            {
                query["DBName"] = request.DBName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalOperator))
            {
                query["LogicalOperator"] = request.LogicalOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeywords))
            {
                query["QueryKeywords"] = request.QueryKeywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Action = "DescribeSlowLogRecords",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlowLogRecordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of entries in slow query logs of an ApsaraDB for MongoDB instance.
         *
         * @description *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeSlowLogRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSlowLogRecordsResponse
         */
        public async Task<DescribeSlowLogRecordsResponse> DescribeSlowLogRecordsWithOptionsAsync(DescribeSlowLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBName))
            {
                query["DBName"] = request.DBName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalOperator))
            {
                query["LogicalOperator"] = request.LogicalOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeywords))
            {
                query["QueryKeywords"] = request.QueryKeywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Action = "DescribeSlowLogRecords",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlowLogRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of entries in slow query logs of an ApsaraDB for MongoDB instance.
         *
         * @description *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeSlowLogRecordsRequest
         * @return DescribeSlowLogRecordsResponse
         */
        public DescribeSlowLogRecordsResponse DescribeSlowLogRecords(DescribeSlowLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSlowLogRecordsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of entries in slow query logs of an ApsaraDB for MongoDB instance.
         *
         * @description *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request DescribeSlowLogRecordsRequest
         * @return DescribeSlowLogRecordsResponse
         */
        public async Task<DescribeSlowLogRecordsResponse> DescribeSlowLogRecordsAsync(DescribeSlowLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSlowLogRecordsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all tags in a specified region.
         *
         * @param request DescribeTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTagsResponse
         */
        public DescribeTagsResponse DescribeTagsWithOptions(DescribeTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Action = "DescribeTags",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTagsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries all tags in a specified region.
         *
         * @param request DescribeTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTagsResponse
         */
        public async Task<DescribeTagsResponse> DescribeTagsWithOptionsAsync(DescribeTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Action = "DescribeTags",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries all tags in a specified region.
         *
         * @param request DescribeTagsRequest
         * @return DescribeTagsResponse
         */
        public DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTagsWithOptions(request, runtime);
        }

        /**
         * @summary Queries all tags in a specified region.
         *
         * @param request DescribeTagsRequest
         * @return DescribeTagsResponse
         */
        public async Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTagsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the list of custom keys for an ApsaraDB for MongoDB instance.
         *
         * @description You can use the custom key obtained by calling the DescribeUserEncryptionKeyList operation to enable TDE. For more information, see [ModifyDBInstanceTDE](https://help.aliyun.com/document_detail/131267.html).
         *
         * @param request DescribeUserEncryptionKeyListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserEncryptionKeyListResponse
         */
        public DescribeUserEncryptionKeyListResponse DescribeUserEncryptionKeyListWithOptions(DescribeUserEncryptionKeyListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetRegionId))
            {
                query["TargetRegionId"] = request.TargetRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserEncryptionKeyList",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserEncryptionKeyListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the list of custom keys for an ApsaraDB for MongoDB instance.
         *
         * @description You can use the custom key obtained by calling the DescribeUserEncryptionKeyList operation to enable TDE. For more information, see [ModifyDBInstanceTDE](https://help.aliyun.com/document_detail/131267.html).
         *
         * @param request DescribeUserEncryptionKeyListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserEncryptionKeyListResponse
         */
        public async Task<DescribeUserEncryptionKeyListResponse> DescribeUserEncryptionKeyListWithOptionsAsync(DescribeUserEncryptionKeyListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetRegionId))
            {
                query["TargetRegionId"] = request.TargetRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserEncryptionKeyList",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserEncryptionKeyListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the list of custom keys for an ApsaraDB for MongoDB instance.
         *
         * @description You can use the custom key obtained by calling the DescribeUserEncryptionKeyList operation to enable TDE. For more information, see [ModifyDBInstanceTDE](https://help.aliyun.com/document_detail/131267.html).
         *
         * @param request DescribeUserEncryptionKeyListRequest
         * @return DescribeUserEncryptionKeyListResponse
         */
        public DescribeUserEncryptionKeyListResponse DescribeUserEncryptionKeyList(DescribeUserEncryptionKeyListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserEncryptionKeyListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the list of custom keys for an ApsaraDB for MongoDB instance.
         *
         * @description You can use the custom key obtained by calling the DescribeUserEncryptionKeyList operation to enable TDE. For more information, see [ModifyDBInstanceTDE](https://help.aliyun.com/document_detail/131267.html).
         *
         * @param request DescribeUserEncryptionKeyListRequest
         * @return DescribeUserEncryptionKeyListResponse
         */
        public async Task<DescribeUserEncryptionKeyListResponse> DescribeUserEncryptionKeyListAsync(DescribeUserEncryptionKeyListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserEncryptionKeyListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Destroys an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the instance meets the following requirements:
         * *   The instance is a replica set instance or a sharded cluster instance that uses local disks.
         * *   The billing method of the instance is subscription.
         * *   The instance has expired and is in the **Locking** state.
         * **
         * **Warning** Data cannot be restored after the instance is destroyed. Proceed with caution.
         *
         * @param request DestroyInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DestroyInstanceResponse
         */
        public DestroyInstanceResponse DestroyInstanceWithOptions(DestroyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DestroyInstance",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DestroyInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Destroys an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the instance meets the following requirements:
         * *   The instance is a replica set instance or a sharded cluster instance that uses local disks.
         * *   The billing method of the instance is subscription.
         * *   The instance has expired and is in the **Locking** state.
         * **
         * **Warning** Data cannot be restored after the instance is destroyed. Proceed with caution.
         *
         * @param request DestroyInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DestroyInstanceResponse
         */
        public async Task<DestroyInstanceResponse> DestroyInstanceWithOptionsAsync(DestroyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DestroyInstance",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DestroyInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Destroys an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the instance meets the following requirements:
         * *   The instance is a replica set instance or a sharded cluster instance that uses local disks.
         * *   The billing method of the instance is subscription.
         * *   The instance has expired and is in the **Locking** state.
         * **
         * **Warning** Data cannot be restored after the instance is destroyed. Proceed with caution.
         *
         * @param request DestroyInstanceRequest
         * @return DestroyInstanceResponse
         */
        public DestroyInstanceResponse DestroyInstance(DestroyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DestroyInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Destroys an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the instance meets the following requirements:
         * *   The instance is a replica set instance or a sharded cluster instance that uses local disks.
         * *   The billing method of the instance is subscription.
         * *   The instance has expired and is in the **Locking** state.
         * **
         * **Warning** Data cannot be restored after the instance is destroyed. Proceed with caution.
         *
         * @param request DestroyInstanceRequest
         * @return DestroyInstanceResponse
         */
        public async Task<DestroyInstanceResponse> DestroyInstanceAsync(DestroyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DestroyInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Checks whether sufficient resources are available in a region in which you want to create or upgrade an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable to replica set instances and sharded cluster instances. You can call this operation to check whether resources are sufficient for creating an instance, upgrading a replica set or sharded cluster instance, or upgrading a single node of the sharded cluster instance.
         * > You can call this operation a maximum of 200 times per minute.
         *
         * @param request EvaluateResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EvaluateResourceResponse
         */
        public EvaluateResourceResponse EvaluateResourceWithOptions(EvaluateResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceClass))
            {
                query["DBInstanceClass"] = request.DBInstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadonlyReplicas))
            {
                query["ReadonlyReplicas"] = request.ReadonlyReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationFactor))
            {
                query["ReplicationFactor"] = request.ReplicationFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShardsInfo))
            {
                query["ShardsInfo"] = request.ShardsInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Storage))
            {
                query["Storage"] = request.Storage;
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
                Action = "EvaluateResource",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EvaluateResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Checks whether sufficient resources are available in a region in which you want to create or upgrade an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable to replica set instances and sharded cluster instances. You can call this operation to check whether resources are sufficient for creating an instance, upgrading a replica set or sharded cluster instance, or upgrading a single node of the sharded cluster instance.
         * > You can call this operation a maximum of 200 times per minute.
         *
         * @param request EvaluateResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EvaluateResourceResponse
         */
        public async Task<EvaluateResourceResponse> EvaluateResourceWithOptionsAsync(EvaluateResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceClass))
            {
                query["DBInstanceClass"] = request.DBInstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadonlyReplicas))
            {
                query["ReadonlyReplicas"] = request.ReadonlyReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationFactor))
            {
                query["ReplicationFactor"] = request.ReplicationFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShardsInfo))
            {
                query["ShardsInfo"] = request.ShardsInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Storage))
            {
                query["Storage"] = request.Storage;
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
                Action = "EvaluateResource",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EvaluateResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Checks whether sufficient resources are available in a region in which you want to create or upgrade an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable to replica set instances and sharded cluster instances. You can call this operation to check whether resources are sufficient for creating an instance, upgrading a replica set or sharded cluster instance, or upgrading a single node of the sharded cluster instance.
         * > You can call this operation a maximum of 200 times per minute.
         *
         * @param request EvaluateResourceRequest
         * @return EvaluateResourceResponse
         */
        public EvaluateResourceResponse EvaluateResource(EvaluateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EvaluateResourceWithOptions(request, runtime);
        }

        /**
         * @summary Checks whether sufficient resources are available in a region in which you want to create or upgrade an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable to replica set instances and sharded cluster instances. You can call this operation to check whether resources are sufficient for creating an instance, upgrading a replica set or sharded cluster instance, or upgrading a single node of the sharded cluster instance.
         * > You can call this operation a maximum of 200 times per minute.
         *
         * @param request EvaluateResourceRequest
         * @return EvaluateResourceResponse
         */
        public async Task<EvaluateResourceResponse> EvaluateResourceAsync(EvaluateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EvaluateResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the relationship between ApsaraDB for MongoDB instances and tags.
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Version = "2015-12-01",
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
         * @summary Queries the relationship between ApsaraDB for MongoDB instances and tags.
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Version = "2015-12-01",
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
         * @summary Queries the relationship between ApsaraDB for MongoDB instances and tags.
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
         * @summary Queries the relationship between ApsaraDB for MongoDB instances and tags.
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
         * @summary Migrates an ApsaraDB for MongoDB instance to a specific zone.
         *
         * @description *   This operation is available only for replica set instances that run MongoDB 4.2 or earlier and sharded cluster instances.
         * *   If you have applied for a public endpoint for the ApsaraDB for MongoDB instance, you must call the [ReleasePublicNetworkAddress](https://help.aliyun.com/document_detail/67604.html) operation to release the public endpoint before you call the MigrateAvailableZone operation.
         * *   Transparent data encryption (TDE) is disabled for the ApsaraDB for MongoDB instance.
         * *   The source zone and the destination zone belong to the same region.
         * *   A vSwitch is created in the destination zone. This prerequisite must be met if the instance resides in a virtual private cloud (VPC). For more information about how to create a vSwitch, see [Work with vSwitches](https://help.aliyun.com/document_detail/65387.html).
         *
         * @param request MigrateAvailableZoneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MigrateAvailableZoneResponse
         */
        public MigrateAvailableZoneResponse MigrateAvailableZoneWithOptions(MigrateAvailableZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                query["EffectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HiddenZoneId))
            {
                query["HiddenZoneId"] = request.HiddenZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryZoneId))
            {
                query["SecondaryZoneId"] = request.SecondaryZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vswitch))
            {
                query["Vswitch"] = request.Vswitch;
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
                Action = "MigrateAvailableZone",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MigrateAvailableZoneResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Migrates an ApsaraDB for MongoDB instance to a specific zone.
         *
         * @description *   This operation is available only for replica set instances that run MongoDB 4.2 or earlier and sharded cluster instances.
         * *   If you have applied for a public endpoint for the ApsaraDB for MongoDB instance, you must call the [ReleasePublicNetworkAddress](https://help.aliyun.com/document_detail/67604.html) operation to release the public endpoint before you call the MigrateAvailableZone operation.
         * *   Transparent data encryption (TDE) is disabled for the ApsaraDB for MongoDB instance.
         * *   The source zone and the destination zone belong to the same region.
         * *   A vSwitch is created in the destination zone. This prerequisite must be met if the instance resides in a virtual private cloud (VPC). For more information about how to create a vSwitch, see [Work with vSwitches](https://help.aliyun.com/document_detail/65387.html).
         *
         * @param request MigrateAvailableZoneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MigrateAvailableZoneResponse
         */
        public async Task<MigrateAvailableZoneResponse> MigrateAvailableZoneWithOptionsAsync(MigrateAvailableZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                query["EffectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HiddenZoneId))
            {
                query["HiddenZoneId"] = request.HiddenZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondaryZoneId))
            {
                query["SecondaryZoneId"] = request.SecondaryZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vswitch))
            {
                query["Vswitch"] = request.Vswitch;
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
                Action = "MigrateAvailableZone",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MigrateAvailableZoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Migrates an ApsaraDB for MongoDB instance to a specific zone.
         *
         * @description *   This operation is available only for replica set instances that run MongoDB 4.2 or earlier and sharded cluster instances.
         * *   If you have applied for a public endpoint for the ApsaraDB for MongoDB instance, you must call the [ReleasePublicNetworkAddress](https://help.aliyun.com/document_detail/67604.html) operation to release the public endpoint before you call the MigrateAvailableZone operation.
         * *   Transparent data encryption (TDE) is disabled for the ApsaraDB for MongoDB instance.
         * *   The source zone and the destination zone belong to the same region.
         * *   A vSwitch is created in the destination zone. This prerequisite must be met if the instance resides in a virtual private cloud (VPC). For more information about how to create a vSwitch, see [Work with vSwitches](https://help.aliyun.com/document_detail/65387.html).
         *
         * @param request MigrateAvailableZoneRequest
         * @return MigrateAvailableZoneResponse
         */
        public MigrateAvailableZoneResponse MigrateAvailableZone(MigrateAvailableZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MigrateAvailableZoneWithOptions(request, runtime);
        }

        /**
         * @summary Migrates an ApsaraDB for MongoDB instance to a specific zone.
         *
         * @description *   This operation is available only for replica set instances that run MongoDB 4.2 or earlier and sharded cluster instances.
         * *   If you have applied for a public endpoint for the ApsaraDB for MongoDB instance, you must call the [ReleasePublicNetworkAddress](https://help.aliyun.com/document_detail/67604.html) operation to release the public endpoint before you call the MigrateAvailableZone operation.
         * *   Transparent data encryption (TDE) is disabled for the ApsaraDB for MongoDB instance.
         * *   The source zone and the destination zone belong to the same region.
         * *   A vSwitch is created in the destination zone. This prerequisite must be met if the instance resides in a virtual private cloud (VPC). For more information about how to create a vSwitch, see [Work with vSwitches](https://help.aliyun.com/document_detail/65387.html).
         *
         * @param request MigrateAvailableZoneRequest
         * @return MigrateAvailableZoneResponse
         */
        public async Task<MigrateAvailableZoneResponse> MigrateAvailableZoneAsync(MigrateAvailableZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MigrateAvailableZoneWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to migrate an ApsaraDB for MongoDB instance to another zone.
         *
         * @description This operation is applicable only to replica set instances, but not to standalone instances or sharded cluster instances.
         * >  If you have applied for a public endpoint of the instance, you must first call the [ReleasePublicNetworkAddress](https://help.aliyun.com/document_detail/67604.html) operation to release the public endpoint.
         *
         * @param request MigrateToOtherZoneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MigrateToOtherZoneResponse
         */
        public MigrateToOtherZoneResponse MigrateToOtherZoneWithOptions(MigrateToOtherZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                query["EffectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
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
                Action = "MigrateToOtherZone",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MigrateToOtherZoneResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to migrate an ApsaraDB for MongoDB instance to another zone.
         *
         * @description This operation is applicable only to replica set instances, but not to standalone instances or sharded cluster instances.
         * >  If you have applied for a public endpoint of the instance, you must first call the [ReleasePublicNetworkAddress](https://help.aliyun.com/document_detail/67604.html) operation to release the public endpoint.
         *
         * @param request MigrateToOtherZoneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MigrateToOtherZoneResponse
         */
        public async Task<MigrateToOtherZoneResponse> MigrateToOtherZoneWithOptionsAsync(MigrateToOtherZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                query["EffectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
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
                Action = "MigrateToOtherZone",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MigrateToOtherZoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to migrate an ApsaraDB for MongoDB instance to another zone.
         *
         * @description This operation is applicable only to replica set instances, but not to standalone instances or sharded cluster instances.
         * >  If you have applied for a public endpoint of the instance, you must first call the [ReleasePublicNetworkAddress](https://help.aliyun.com/document_detail/67604.html) operation to release the public endpoint.
         *
         * @param request MigrateToOtherZoneRequest
         * @return MigrateToOtherZoneResponse
         */
        public MigrateToOtherZoneResponse MigrateToOtherZone(MigrateToOtherZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MigrateToOtherZoneWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to migrate an ApsaraDB for MongoDB instance to another zone.
         *
         * @description This operation is applicable only to replica set instances, but not to standalone instances or sharded cluster instances.
         * >  If you have applied for a public endpoint of the instance, you must first call the [ReleasePublicNetworkAddress](https://help.aliyun.com/document_detail/67604.html) operation to release the public endpoint.
         *
         * @param request MigrateToOtherZoneRequest
         * @return MigrateToOtherZoneResponse
         */
        public async Task<MigrateToOtherZoneResponse> MigrateToOtherZoneAsync(MigrateToOtherZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MigrateToOtherZoneWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the description of the root account in an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyAccountDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAccountDescriptionResponse
         */
        public ModifyAccountDescriptionResponse ModifyAccountDescriptionWithOptions(ModifyAccountDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountDescription))
            {
                query["AccountDescription"] = request.AccountDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAccountDescription",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAccountDescriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the description of the root account in an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyAccountDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAccountDescriptionResponse
         */
        public async Task<ModifyAccountDescriptionResponse> ModifyAccountDescriptionWithOptionsAsync(ModifyAccountDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountDescription))
            {
                query["AccountDescription"] = request.AccountDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAccountDescription",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAccountDescriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the description of the root account in an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyAccountDescriptionRequest
         * @return ModifyAccountDescriptionResponse
         */
        public ModifyAccountDescriptionResponse ModifyAccountDescription(ModifyAccountDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAccountDescriptionWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the description of the root account in an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyAccountDescriptionRequest
         * @return ModifyAccountDescriptionResponse
         */
        public async Task<ModifyAccountDescriptionResponse> ModifyAccountDescriptionAsync(ModifyAccountDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAccountDescriptionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the switching time of scheduled O\\\\\\&M tasks for an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyActiveOperationTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyActiveOperationTasksResponse
         */
        public ModifyActiveOperationTasksResponse ModifyActiveOperationTasksWithOptions(ModifyActiveOperationTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["Ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImmediateStart))
            {
                query["ImmediateStart"] = request.ImmediateStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchTime))
            {
                query["SwitchTime"] = request.SwitchTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyActiveOperationTasks",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyActiveOperationTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the switching time of scheduled O\\\\\\&M tasks for an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyActiveOperationTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyActiveOperationTasksResponse
         */
        public async Task<ModifyActiveOperationTasksResponse> ModifyActiveOperationTasksWithOptionsAsync(ModifyActiveOperationTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["Ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImmediateStart))
            {
                query["ImmediateStart"] = request.ImmediateStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchTime))
            {
                query["SwitchTime"] = request.SwitchTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyActiveOperationTasks",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyActiveOperationTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the switching time of scheduled O\\\\\\&M tasks for an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyActiveOperationTasksRequest
         * @return ModifyActiveOperationTasksResponse
         */
        public ModifyActiveOperationTasksResponse ModifyActiveOperationTasks(ModifyActiveOperationTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyActiveOperationTasksWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the switching time of scheduled O\\\\\\&M tasks for an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyActiveOperationTasksRequest
         * @return ModifyActiveOperationTasksResponse
         */
        public async Task<ModifyActiveOperationTasksResponse> ModifyActiveOperationTasksAsync(ModifyActiveOperationTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyActiveOperationTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the types of logs collected by the audit log feature of an ApsaraDB for MongoDB instance.
         *
         * @description *   The instance must be in the running state when you call this operation.
         * *   This operation is applicable only to **general-purpose local-disk** or **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request ModifyAuditLogFilterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAuditLogFilterResponse
         */
        public ModifyAuditLogFilterResponse ModifyAuditLogFilterWithOptions(ModifyAuditLogFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                query["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAuditLogFilter",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAuditLogFilterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the types of logs collected by the audit log feature of an ApsaraDB for MongoDB instance.
         *
         * @description *   The instance must be in the running state when you call this operation.
         * *   This operation is applicable only to **general-purpose local-disk** or **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request ModifyAuditLogFilterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAuditLogFilterResponse
         */
        public async Task<ModifyAuditLogFilterResponse> ModifyAuditLogFilterWithOptionsAsync(ModifyAuditLogFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                query["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAuditLogFilter",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAuditLogFilterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the types of logs collected by the audit log feature of an ApsaraDB for MongoDB instance.
         *
         * @description *   The instance must be in the running state when you call this operation.
         * *   This operation is applicable only to **general-purpose local-disk** or **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request ModifyAuditLogFilterRequest
         * @return ModifyAuditLogFilterResponse
         */
        public ModifyAuditLogFilterResponse ModifyAuditLogFilter(ModifyAuditLogFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAuditLogFilterWithOptions(request, runtime);
        }

        /**
         * @summary Queries the types of logs collected by the audit log feature of an ApsaraDB for MongoDB instance.
         *
         * @description *   The instance must be in the running state when you call this operation.
         * *   This operation is applicable only to **general-purpose local-disk** or **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request ModifyAuditLogFilterRequest
         * @return ModifyAuditLogFilterResponse
         */
        public async Task<ModifyAuditLogFilterResponse> ModifyAuditLogFilterAsync(ModifyAuditLogFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAuditLogFilterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables or disables the audit log feature or configures the log storage duration for an ApsaraDB for MongoDB instance.
         *
         * @description *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request ModifyAuditPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAuditPolicyResponse
         */
        public ModifyAuditPolicyResponse ModifyAuditPolicyWithOptions(ModifyAuditPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditLogSwitchSource))
            {
                query["AuditLogSwitchSource"] = request.AuditLogSwitchSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoragePeriod))
            {
                query["StoragePeriod"] = request.StoragePeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAuditPolicy",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAuditPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables or disables the audit log feature or configures the log storage duration for an ApsaraDB for MongoDB instance.
         *
         * @description *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request ModifyAuditPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAuditPolicyResponse
         */
        public async Task<ModifyAuditPolicyResponse> ModifyAuditPolicyWithOptionsAsync(ModifyAuditPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditLogSwitchSource))
            {
                query["AuditLogSwitchSource"] = request.AuditLogSwitchSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoragePeriod))
            {
                query["StoragePeriod"] = request.StoragePeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAuditPolicy",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAuditPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables or disables the audit log feature or configures the log storage duration for an ApsaraDB for MongoDB instance.
         *
         * @description *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request ModifyAuditPolicyRequest
         * @return ModifyAuditPolicyResponse
         */
        public ModifyAuditPolicyResponse ModifyAuditPolicy(ModifyAuditPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAuditPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Enables or disables the audit log feature or configures the log storage duration for an ApsaraDB for MongoDB instance.
         *
         * @description *   This operation is applicable only to **general-purpose local-disk** and **dedicated local-disk** instances.
         * *   You can call this operation up to 30 times per minute. To call this operation at a higher frequency, use a Logstore. For more information, see [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request ModifyAuditPolicyRequest
         * @return ModifyAuditPolicyResponse
         */
        public async Task<ModifyAuditPolicyResponse> ModifyAuditPolicyAsync(ModifyAuditPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAuditPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a backup policy for an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyBackupPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyBackupPolicyResponse
         */
        public ModifyBackupPolicyResponse ModifyBackupPolicyWithOptions(ModifyBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupInterval))
            {
                query["BackupInterval"] = request.BackupInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupRetentionPeriod))
            {
                query["BackupRetentionPeriod"] = request.BackupRetentionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupRetentionPolicyOnClusterDeletion))
            {
                query["BackupRetentionPolicyOnClusterDeletion"] = request.BackupRetentionPolicyOnClusterDeletion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossBackupPeriod))
            {
                query["CrossBackupPeriod"] = request.CrossBackupPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossBackupType))
            {
                query["CrossBackupType"] = request.CrossBackupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossLogRetentionType))
            {
                query["CrossLogRetentionType"] = request.CrossLogRetentionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossLogRetentionValue))
            {
                query["CrossLogRetentionValue"] = request.CrossLogRetentionValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossRetentionType))
            {
                query["CrossRetentionType"] = request.CrossRetentionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossRetentionValue))
            {
                query["CrossRetentionValue"] = request.CrossRetentionValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestRegion))
            {
                query["DestRegion"] = request.DestRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableBackupLog))
            {
                query["EnableBackupLog"] = request.EnableBackupLog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCrossLogBackup))
            {
                query["EnableCrossLogBackup"] = request.EnableCrossLogBackup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighFrequencyBackupRetention))
            {
                query["HighFrequencyBackupRetention"] = request.HighFrequencyBackupRetention;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogBackupRetentionPeriod))
            {
                query["LogBackupRetentionPeriod"] = request.LogBackupRetentionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferredBackupPeriod))
            {
                query["PreferredBackupPeriod"] = request.PreferredBackupPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferredBackupTime))
            {
                query["PreferredBackupTime"] = request.PreferredBackupTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotBackupType))
            {
                query["SnapshotBackupType"] = request.SnapshotBackupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcRegion))
            {
                query["SrcRegion"] = request.SrcRegion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBackupPolicy",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBackupPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies a backup policy for an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyBackupPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyBackupPolicyResponse
         */
        public async Task<ModifyBackupPolicyResponse> ModifyBackupPolicyWithOptionsAsync(ModifyBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupInterval))
            {
                query["BackupInterval"] = request.BackupInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupRetentionPeriod))
            {
                query["BackupRetentionPeriod"] = request.BackupRetentionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupRetentionPolicyOnClusterDeletion))
            {
                query["BackupRetentionPolicyOnClusterDeletion"] = request.BackupRetentionPolicyOnClusterDeletion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossBackupPeriod))
            {
                query["CrossBackupPeriod"] = request.CrossBackupPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossBackupType))
            {
                query["CrossBackupType"] = request.CrossBackupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossLogRetentionType))
            {
                query["CrossLogRetentionType"] = request.CrossLogRetentionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossLogRetentionValue))
            {
                query["CrossLogRetentionValue"] = request.CrossLogRetentionValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossRetentionType))
            {
                query["CrossRetentionType"] = request.CrossRetentionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossRetentionValue))
            {
                query["CrossRetentionValue"] = request.CrossRetentionValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestRegion))
            {
                query["DestRegion"] = request.DestRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableBackupLog))
            {
                query["EnableBackupLog"] = request.EnableBackupLog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCrossLogBackup))
            {
                query["EnableCrossLogBackup"] = request.EnableCrossLogBackup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HighFrequencyBackupRetention))
            {
                query["HighFrequencyBackupRetention"] = request.HighFrequencyBackupRetention;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogBackupRetentionPeriod))
            {
                query["LogBackupRetentionPeriod"] = request.LogBackupRetentionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferredBackupPeriod))
            {
                query["PreferredBackupPeriod"] = request.PreferredBackupPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferredBackupTime))
            {
                query["PreferredBackupTime"] = request.PreferredBackupTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotBackupType))
            {
                query["SnapshotBackupType"] = request.SnapshotBackupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcRegion))
            {
                query["SrcRegion"] = request.SrcRegion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBackupPolicy",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBackupPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a backup policy for an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyBackupPolicyRequest
         * @return ModifyBackupPolicyResponse
         */
        public ModifyBackupPolicyResponse ModifyBackupPolicy(ModifyBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBackupPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a backup policy for an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyBackupPolicyRequest
         * @return ModifyBackupPolicyResponse
         */
        public async Task<ModifyBackupPolicyResponse> ModifyBackupPolicyAsync(ModifyBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBackupPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the endpoint that is used to connect to an ApsaraDB for MongoDB instance.
         *
         * @description You can modify the connection strings and ports of the following instances:
         * *   You can modify the connection strings of instances that use local or cloud disks.
         * *   You can only modify the ports of instances that use cloud disks.
         *
         * @param request ModifyDBInstanceConnectionStringRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBInstanceConnectionStringResponse
         */
        public ModifyDBInstanceConnectionStringResponse ModifyDBInstanceConnectionStringWithOptions(ModifyDBInstanceConnectionStringRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentConnectionString))
            {
                query["CurrentConnectionString"] = request.CurrentConnectionString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewConnectionString))
            {
                query["NewConnectionString"] = request.NewConnectionString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPort))
            {
                query["NewPort"] = request.NewPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceConnectionString",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceConnectionStringResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the endpoint that is used to connect to an ApsaraDB for MongoDB instance.
         *
         * @description You can modify the connection strings and ports of the following instances:
         * *   You can modify the connection strings of instances that use local or cloud disks.
         * *   You can only modify the ports of instances that use cloud disks.
         *
         * @param request ModifyDBInstanceConnectionStringRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBInstanceConnectionStringResponse
         */
        public async Task<ModifyDBInstanceConnectionStringResponse> ModifyDBInstanceConnectionStringWithOptionsAsync(ModifyDBInstanceConnectionStringRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentConnectionString))
            {
                query["CurrentConnectionString"] = request.CurrentConnectionString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewConnectionString))
            {
                query["NewConnectionString"] = request.NewConnectionString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPort))
            {
                query["NewPort"] = request.NewPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceConnectionString",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceConnectionStringResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the endpoint that is used to connect to an ApsaraDB for MongoDB instance.
         *
         * @description You can modify the connection strings and ports of the following instances:
         * *   You can modify the connection strings of instances that use local or cloud disks.
         * *   You can only modify the ports of instances that use cloud disks.
         *
         * @param request ModifyDBInstanceConnectionStringRequest
         * @return ModifyDBInstanceConnectionStringResponse
         */
        public ModifyDBInstanceConnectionStringResponse ModifyDBInstanceConnectionString(ModifyDBInstanceConnectionStringRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceConnectionStringWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the endpoint that is used to connect to an ApsaraDB for MongoDB instance.
         *
         * @description You can modify the connection strings and ports of the following instances:
         * *   You can modify the connection strings of instances that use local or cloud disks.
         * *   You can only modify the ports of instances that use cloud disks.
         *
         * @param request ModifyDBInstanceConnectionStringRequest
         * @return ModifyDBInstanceConnectionStringResponse
         */
        public async Task<ModifyDBInstanceConnectionStringResponse> ModifyDBInstanceConnectionStringAsync(ModifyDBInstanceConnectionStringRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceConnectionStringWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the name of an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyDBInstanceDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBInstanceDescriptionResponse
         */
        public ModifyDBInstanceDescriptionResponse ModifyDBInstanceDescriptionWithOptions(ModifyDBInstanceDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceDescription))
            {
                query["DBInstanceDescription"] = request.DBInstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceDescription",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceDescriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the name of an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyDBInstanceDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBInstanceDescriptionResponse
         */
        public async Task<ModifyDBInstanceDescriptionResponse> ModifyDBInstanceDescriptionWithOptionsAsync(ModifyDBInstanceDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceDescription))
            {
                query["DBInstanceDescription"] = request.DBInstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceDescription",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceDescriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the name of an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyDBInstanceDescriptionRequest
         * @return ModifyDBInstanceDescriptionResponse
         */
        public ModifyDBInstanceDescriptionResponse ModifyDBInstanceDescription(ModifyDBInstanceDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceDescriptionWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the name of an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyDBInstanceDescriptionRequest
         * @return ModifyDBInstanceDescriptionResponse
         */
        public async Task<ModifyDBInstanceDescriptionResponse> ModifyDBInstanceDescriptionAsync(ModifyDBInstanceDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceDescriptionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the disk type of an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyDBInstanceDiskTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBInstanceDiskTypeResponse
         */
        public ModifyDBInstanceDiskTypeResponse ModifyDBInstanceDiskTypeWithOptions(ModifyDBInstanceDiskTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbInstanceStorageType))
            {
                query["DbInstanceStorageType"] = request.DbInstanceStorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParam))
            {
                query["ExtraParam"] = request.ExtraParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionedIops))
            {
                query["ProvisionedIops"] = request.ProvisionedIops;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceDiskType",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceDiskTypeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the disk type of an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyDBInstanceDiskTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBInstanceDiskTypeResponse
         */
        public async Task<ModifyDBInstanceDiskTypeResponse> ModifyDBInstanceDiskTypeWithOptionsAsync(ModifyDBInstanceDiskTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbInstanceStorageType))
            {
                query["DbInstanceStorageType"] = request.DbInstanceStorageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParam))
            {
                query["ExtraParam"] = request.ExtraParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionedIops))
            {
                query["ProvisionedIops"] = request.ProvisionedIops;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceDiskType",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceDiskTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the disk type of an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyDBInstanceDiskTypeRequest
         * @return ModifyDBInstanceDiskTypeResponse
         */
        public ModifyDBInstanceDiskTypeResponse ModifyDBInstanceDiskType(ModifyDBInstanceDiskTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceDiskTypeWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the disk type of an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyDBInstanceDiskTypeRequest
         * @return ModifyDBInstanceDiskTypeResponse
         */
        public async Task<ModifyDBInstanceDiskTypeResponse> ModifyDBInstanceDiskTypeAsync(ModifyDBInstanceDiskTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceDiskTypeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the maintenance window of an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyDBInstanceMaintainTimeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBInstanceMaintainTimeResponse
         */
        public ModifyDBInstanceMaintainTimeResponse ModifyDBInstanceMaintainTimeWithOptions(ModifyDBInstanceMaintainTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaintainEndTime))
            {
                query["MaintainEndTime"] = request.MaintainEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaintainStartTime))
            {
                query["MaintainStartTime"] = request.MaintainStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceMaintainTime",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceMaintainTimeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the maintenance window of an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyDBInstanceMaintainTimeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBInstanceMaintainTimeResponse
         */
        public async Task<ModifyDBInstanceMaintainTimeResponse> ModifyDBInstanceMaintainTimeWithOptionsAsync(ModifyDBInstanceMaintainTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaintainEndTime))
            {
                query["MaintainEndTime"] = request.MaintainEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaintainStartTime))
            {
                query["MaintainStartTime"] = request.MaintainStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceMaintainTime",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceMaintainTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the maintenance window of an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyDBInstanceMaintainTimeRequest
         * @return ModifyDBInstanceMaintainTimeResponse
         */
        public ModifyDBInstanceMaintainTimeResponse ModifyDBInstanceMaintainTime(ModifyDBInstanceMaintainTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceMaintainTimeWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the maintenance window of an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyDBInstanceMaintainTimeRequest
         * @return ModifyDBInstanceMaintainTimeResponse
         */
        public async Task<ModifyDBInstanceMaintainTimeResponse> ModifyDBInstanceMaintainTimeAsync(ModifyDBInstanceMaintainTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceMaintainTimeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to set the monitoring granularity for an ApsaraDB for MongoDB instance.
         *
         * @description >  This operation is applicable only to the ApsaraDB for MongoDB console of the previous version due to the change in the feature of adjusting collection intervals of monitoring data.
         * Before you call this operation, make sure that the following requirements are met:
         * *   A replica set or sharded cluster instance is used.
         * *   MongoDB 3.4 (the latest minor version) or MongoDB 4.0 is selected.
         *
         * @param request ModifyDBInstanceMonitorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBInstanceMonitorResponse
         */
        public ModifyDBInstanceMonitorResponse ModifyDBInstanceMonitorWithOptions(ModifyDBInstanceMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceMonitor",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceMonitorResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to set the monitoring granularity for an ApsaraDB for MongoDB instance.
         *
         * @description >  This operation is applicable only to the ApsaraDB for MongoDB console of the previous version due to the change in the feature of adjusting collection intervals of monitoring data.
         * Before you call this operation, make sure that the following requirements are met:
         * *   A replica set or sharded cluster instance is used.
         * *   MongoDB 3.4 (the latest minor version) or MongoDB 4.0 is selected.
         *
         * @param request ModifyDBInstanceMonitorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBInstanceMonitorResponse
         */
        public async Task<ModifyDBInstanceMonitorResponse> ModifyDBInstanceMonitorWithOptionsAsync(ModifyDBInstanceMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceMonitor",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to set the monitoring granularity for an ApsaraDB for MongoDB instance.
         *
         * @description >  This operation is applicable only to the ApsaraDB for MongoDB console of the previous version due to the change in the feature of adjusting collection intervals of monitoring data.
         * Before you call this operation, make sure that the following requirements are met:
         * *   A replica set or sharded cluster instance is used.
         * *   MongoDB 3.4 (the latest minor version) or MongoDB 4.0 is selected.
         *
         * @param request ModifyDBInstanceMonitorRequest
         * @return ModifyDBInstanceMonitorResponse
         */
        public ModifyDBInstanceMonitorResponse ModifyDBInstanceMonitor(ModifyDBInstanceMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceMonitorWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to set the monitoring granularity for an ApsaraDB for MongoDB instance.
         *
         * @description >  This operation is applicable only to the ApsaraDB for MongoDB console of the previous version due to the change in the feature of adjusting collection intervals of monitoring data.
         * Before you call this operation, make sure that the following requirements are met:
         * *   A replica set or sharded cluster instance is used.
         * *   MongoDB 3.4 (the latest minor version) or MongoDB 4.0 is selected.
         *
         * @param request ModifyDBInstanceMonitorRequest
         * @return ModifyDBInstanceMonitorResponse
         */
        public async Task<ModifyDBInstanceMonitorResponse> ModifyDBInstanceMonitorAsync(ModifyDBInstanceMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceMonitorWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Extends the retention period of the classic network endpoint of an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the instance meets the following requirements:
         * *   The instance is in the Running state.
         * *   The network of the instance is in hybrid access mode.
         * >  This operation is supported by replica set instances and sharded cluster instances. This operation is not supported by standalone instances.
         *
         * @param request ModifyDBInstanceNetExpireTimeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBInstanceNetExpireTimeResponse
         */
        public ModifyDBInstanceNetExpireTimeResponse ModifyDBInstanceNetExpireTimeWithOptions(ModifyDBInstanceNetExpireTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassicExpendExpiredDays))
            {
                query["ClassicExpendExpiredDays"] = request.ClassicExpendExpiredDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionString))
            {
                query["ConnectionString"] = request.ConnectionString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceNetExpireTime",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceNetExpireTimeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Extends the retention period of the classic network endpoint of an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the instance meets the following requirements:
         * *   The instance is in the Running state.
         * *   The network of the instance is in hybrid access mode.
         * >  This operation is supported by replica set instances and sharded cluster instances. This operation is not supported by standalone instances.
         *
         * @param request ModifyDBInstanceNetExpireTimeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBInstanceNetExpireTimeResponse
         */
        public async Task<ModifyDBInstanceNetExpireTimeResponse> ModifyDBInstanceNetExpireTimeWithOptionsAsync(ModifyDBInstanceNetExpireTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassicExpendExpiredDays))
            {
                query["ClassicExpendExpiredDays"] = request.ClassicExpendExpiredDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionString))
            {
                query["ConnectionString"] = request.ConnectionString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceNetExpireTime",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceNetExpireTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Extends the retention period of the classic network endpoint of an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the instance meets the following requirements:
         * *   The instance is in the Running state.
         * *   The network of the instance is in hybrid access mode.
         * >  This operation is supported by replica set instances and sharded cluster instances. This operation is not supported by standalone instances.
         *
         * @param request ModifyDBInstanceNetExpireTimeRequest
         * @return ModifyDBInstanceNetExpireTimeResponse
         */
        public ModifyDBInstanceNetExpireTimeResponse ModifyDBInstanceNetExpireTime(ModifyDBInstanceNetExpireTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceNetExpireTimeWithOptions(request, runtime);
        }

        /**
         * @summary Extends the retention period of the classic network endpoint of an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the instance meets the following requirements:
         * *   The instance is in the Running state.
         * *   The network of the instance is in hybrid access mode.
         * >  This operation is supported by replica set instances and sharded cluster instances. This operation is not supported by standalone instances.
         *
         * @param request ModifyDBInstanceNetExpireTimeRequest
         * @return ModifyDBInstanceNetExpireTimeResponse
         */
        public async Task<ModifyDBInstanceNetExpireTimeResponse> ModifyDBInstanceNetExpireTimeAsync(ModifyDBInstanceNetExpireTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceNetExpireTimeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the network type of an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable to replica set instances and sharded cluster instances, but not standalone instances. You can call this operation to change the network of an instance from a classic network to a VPC.
         *
         * @param request ModifyDBInstanceNetworkTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBInstanceNetworkTypeResponse
         */
        public ModifyDBInstanceNetworkTypeResponse ModifyDBInstanceNetworkTypeWithOptions(ModifyDBInstanceNetworkTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassicExpiredDays))
            {
                query["ClassicExpiredDays"] = request.ClassicExpiredDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainClassic))
            {
                query["RetainClassic"] = request.RetainClassic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
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
                Action = "ModifyDBInstanceNetworkType",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceNetworkTypeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes the network type of an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable to replica set instances and sharded cluster instances, but not standalone instances. You can call this operation to change the network of an instance from a classic network to a VPC.
         *
         * @param request ModifyDBInstanceNetworkTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBInstanceNetworkTypeResponse
         */
        public async Task<ModifyDBInstanceNetworkTypeResponse> ModifyDBInstanceNetworkTypeWithOptionsAsync(ModifyDBInstanceNetworkTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClassicExpiredDays))
            {
                query["ClassicExpiredDays"] = request.ClassicExpiredDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainClassic))
            {
                query["RetainClassic"] = request.RetainClassic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
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
                Action = "ModifyDBInstanceNetworkType",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceNetworkTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes the network type of an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable to replica set instances and sharded cluster instances, but not standalone instances. You can call this operation to change the network of an instance from a classic network to a VPC.
         *
         * @param request ModifyDBInstanceNetworkTypeRequest
         * @return ModifyDBInstanceNetworkTypeResponse
         */
        public ModifyDBInstanceNetworkTypeResponse ModifyDBInstanceNetworkType(ModifyDBInstanceNetworkTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceNetworkTypeWithOptions(request, runtime);
        }

        /**
         * @summary Changes the network type of an ApsaraDB for MongoDB instance.
         *
         * @description This operation is applicable to replica set instances and sharded cluster instances, but not standalone instances. You can call this operation to change the network of an instance from a classic network to a VPC.
         *
         * @param request ModifyDBInstanceNetworkTypeRequest
         * @return ModifyDBInstanceNetworkTypeResponse
         */
        public async Task<ModifyDBInstanceNetworkTypeResponse> ModifyDBInstanceNetworkTypeAsync(ModifyDBInstanceNetworkTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceNetworkTypeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the SSL settings of an ApsaraDB for MongoDB instance.
         *
         * @description ## Usage
         * Before you call this operation, make sure that the following requirements are met:
         * *   The instance is in the running state.
         * *   The instance is a replica set instance.
         * *   The engine version of the instance is 3.4 or 4.0.
         * >  When you enable or disable SSL encryption or update the SSL certificate, the instance restarts. We recommend that you call this operation during off-peak hours.
         *
         * @param request ModifyDBInstanceSSLRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBInstanceSSLResponse
         */
        public ModifyDBInstanceSSLResponse ModifyDBInstanceSSLWithOptions(ModifyDBInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLAction))
            {
                query["SSLAction"] = request.SSLAction;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceSSL",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceSSLResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the SSL settings of an ApsaraDB for MongoDB instance.
         *
         * @description ## Usage
         * Before you call this operation, make sure that the following requirements are met:
         * *   The instance is in the running state.
         * *   The instance is a replica set instance.
         * *   The engine version of the instance is 3.4 or 4.0.
         * >  When you enable or disable SSL encryption or update the SSL certificate, the instance restarts. We recommend that you call this operation during off-peak hours.
         *
         * @param request ModifyDBInstanceSSLRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBInstanceSSLResponse
         */
        public async Task<ModifyDBInstanceSSLResponse> ModifyDBInstanceSSLWithOptionsAsync(ModifyDBInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLAction))
            {
                query["SSLAction"] = request.SSLAction;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceSSL",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceSSLResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the SSL settings of an ApsaraDB for MongoDB instance.
         *
         * @description ## Usage
         * Before you call this operation, make sure that the following requirements are met:
         * *   The instance is in the running state.
         * *   The instance is a replica set instance.
         * *   The engine version of the instance is 3.4 or 4.0.
         * >  When you enable or disable SSL encryption or update the SSL certificate, the instance restarts. We recommend that you call this operation during off-peak hours.
         *
         * @param request ModifyDBInstanceSSLRequest
         * @return ModifyDBInstanceSSLResponse
         */
        public ModifyDBInstanceSSLResponse ModifyDBInstanceSSL(ModifyDBInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceSSLWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the SSL settings of an ApsaraDB for MongoDB instance.
         *
         * @description ## Usage
         * Before you call this operation, make sure that the following requirements are met:
         * *   The instance is in the running state.
         * *   The instance is a replica set instance.
         * *   The engine version of the instance is 3.4 or 4.0.
         * >  When you enable or disable SSL encryption or update the SSL certificate, the instance restarts. We recommend that you call this operation during off-peak hours.
         *
         * @param request ModifyDBInstanceSSLRequest
         * @return ModifyDBInstanceSSLResponse
         */
        public async Task<ModifyDBInstanceSSLResponse> ModifyDBInstanceSSLAsync(ModifyDBInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceSSLWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the specifications or storage space of an ApsaraDB for MongoDB standalone, replica set, or serverless instance. Serverless instances are available only on the China site (aliyun.com).
         *
         * @description Before you call this operation, make sure that you understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing) of ApsaraDB for MongoDB.
         * This operation applies only to standalone and replica set instances. To modify the specifications of sharded cluster instances, you can call the [ModifyNodeSpec](https://help.aliyun.com/document_detail/61911.html), [CreateNode](https://help.aliyun.com/document_detail/61922.html), [DeleteNode](https://help.aliyun.com/document_detail/61816.html), or [ModifyNodeSpecBatch](https://help.aliyun.com/document_detail/61923.html) operation.
         *
         * @param request ModifyDBInstanceSpecRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBInstanceSpecResponse
         */
        public ModifyDBInstanceSpecResponse ModifyDBInstanceSpecWithOptions(ModifyDBInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceClass))
            {
                query["DBInstanceClass"] = request.DBInstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceStorage))
            {
                query["DBInstanceStorage"] = request.DBInstanceStorage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                query["EffectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParam))
            {
                query["ExtraParam"] = request.ExtraParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadonlyReplicas))
            {
                query["ReadonlyReplicas"] = request.ReadonlyReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationFactor))
            {
                query["ReplicationFactor"] = request.ReplicationFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceSpec",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceSpecResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the specifications or storage space of an ApsaraDB for MongoDB standalone, replica set, or serverless instance. Serverless instances are available only on the China site (aliyun.com).
         *
         * @description Before you call this operation, make sure that you understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing) of ApsaraDB for MongoDB.
         * This operation applies only to standalone and replica set instances. To modify the specifications of sharded cluster instances, you can call the [ModifyNodeSpec](https://help.aliyun.com/document_detail/61911.html), [CreateNode](https://help.aliyun.com/document_detail/61922.html), [DeleteNode](https://help.aliyun.com/document_detail/61816.html), or [ModifyNodeSpecBatch](https://help.aliyun.com/document_detail/61923.html) operation.
         *
         * @param request ModifyDBInstanceSpecRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBInstanceSpecResponse
         */
        public async Task<ModifyDBInstanceSpecResponse> ModifyDBInstanceSpecWithOptionsAsync(ModifyDBInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceClass))
            {
                query["DBInstanceClass"] = request.DBInstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceStorage))
            {
                query["DBInstanceStorage"] = request.DBInstanceStorage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                query["EffectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraParam))
            {
                query["ExtraParam"] = request.ExtraParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadonlyReplicas))
            {
                query["ReadonlyReplicas"] = request.ReadonlyReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationFactor))
            {
                query["ReplicationFactor"] = request.ReplicationFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceSpec",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the specifications or storage space of an ApsaraDB for MongoDB standalone, replica set, or serverless instance. Serverless instances are available only on the China site (aliyun.com).
         *
         * @description Before you call this operation, make sure that you understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing) of ApsaraDB for MongoDB.
         * This operation applies only to standalone and replica set instances. To modify the specifications of sharded cluster instances, you can call the [ModifyNodeSpec](https://help.aliyun.com/document_detail/61911.html), [CreateNode](https://help.aliyun.com/document_detail/61922.html), [DeleteNode](https://help.aliyun.com/document_detail/61816.html), or [ModifyNodeSpecBatch](https://help.aliyun.com/document_detail/61923.html) operation.
         *
         * @param request ModifyDBInstanceSpecRequest
         * @return ModifyDBInstanceSpecResponse
         */
        public ModifyDBInstanceSpecResponse ModifyDBInstanceSpec(ModifyDBInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceSpecWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the specifications or storage space of an ApsaraDB for MongoDB standalone, replica set, or serverless instance. Serverless instances are available only on the China site (aliyun.com).
         *
         * @description Before you call this operation, make sure that you understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing) of ApsaraDB for MongoDB.
         * This operation applies only to standalone and replica set instances. To modify the specifications of sharded cluster instances, you can call the [ModifyNodeSpec](https://help.aliyun.com/document_detail/61911.html), [CreateNode](https://help.aliyun.com/document_detail/61922.html), [DeleteNode](https://help.aliyun.com/document_detail/61816.html), or [ModifyNodeSpecBatch](https://help.aliyun.com/document_detail/61923.html) operation.
         *
         * @param request ModifyDBInstanceSpecRequest
         * @return ModifyDBInstanceSpecResponse
         */
        public async Task<ModifyDBInstanceSpecResponse> ModifyDBInstanceSpecAsync(ModifyDBInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceSpecWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the transparent data encryption (TDE) status of an ApsaraDB for MongoDB instance.
         *
         * @description TDE allows you to perform real-time I/O encryption and decryption on data files. Data is encrypted before it is written to a disk and is decrypted when it is read from the disk to the memory. For more information, see [Configure TDE](https://help.aliyun.com/document_detail/131048.html).
         * >  TDE cannot be disabled after it is enabled.
         * Before you call this operation, make sure that the ApsaraDB for MongoDB instance meets the following requirements:
         * *   A replica set or sharded cluster instance is used.
         * *   The storage engine of the instance is WiredTiger.
         * *   The instance uses local disks to store data.
         * *   The database engine version of the instance is 4.0 or 4.2. If the database engine version is earlier than 4.0, you can call the [UpgradeDBInstanceEngineVersion](https://help.aliyun.com/document_detail/67608.html) operation to upgrade the database engine.
         *
         * @param request ModifyDBInstanceTDERequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBInstanceTDEResponse
         */
        public ModifyDBInstanceTDEResponse ModifyDBInstanceTDEWithOptions(ModifyDBInstanceTDERequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionKey))
            {
                query["EncryptionKey"] = request.EncryptionKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptorName))
            {
                query["EncryptorName"] = request.EncryptorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleARN))
            {
                query["RoleARN"] = request.RoleARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TDEStatus))
            {
                query["TDEStatus"] = request.TDEStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceTDE",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceTDEResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the transparent data encryption (TDE) status of an ApsaraDB for MongoDB instance.
         *
         * @description TDE allows you to perform real-time I/O encryption and decryption on data files. Data is encrypted before it is written to a disk and is decrypted when it is read from the disk to the memory. For more information, see [Configure TDE](https://help.aliyun.com/document_detail/131048.html).
         * >  TDE cannot be disabled after it is enabled.
         * Before you call this operation, make sure that the ApsaraDB for MongoDB instance meets the following requirements:
         * *   A replica set or sharded cluster instance is used.
         * *   The storage engine of the instance is WiredTiger.
         * *   The instance uses local disks to store data.
         * *   The database engine version of the instance is 4.0 or 4.2. If the database engine version is earlier than 4.0, you can call the [UpgradeDBInstanceEngineVersion](https://help.aliyun.com/document_detail/67608.html) operation to upgrade the database engine.
         *
         * @param request ModifyDBInstanceTDERequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBInstanceTDEResponse
         */
        public async Task<ModifyDBInstanceTDEResponse> ModifyDBInstanceTDEWithOptionsAsync(ModifyDBInstanceTDERequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionKey))
            {
                query["EncryptionKey"] = request.EncryptionKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptorName))
            {
                query["EncryptorName"] = request.EncryptorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleARN))
            {
                query["RoleARN"] = request.RoleARN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TDEStatus))
            {
                query["TDEStatus"] = request.TDEStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceTDE",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceTDEResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the transparent data encryption (TDE) status of an ApsaraDB for MongoDB instance.
         *
         * @description TDE allows you to perform real-time I/O encryption and decryption on data files. Data is encrypted before it is written to a disk and is decrypted when it is read from the disk to the memory. For more information, see [Configure TDE](https://help.aliyun.com/document_detail/131048.html).
         * >  TDE cannot be disabled after it is enabled.
         * Before you call this operation, make sure that the ApsaraDB for MongoDB instance meets the following requirements:
         * *   A replica set or sharded cluster instance is used.
         * *   The storage engine of the instance is WiredTiger.
         * *   The instance uses local disks to store data.
         * *   The database engine version of the instance is 4.0 or 4.2. If the database engine version is earlier than 4.0, you can call the [UpgradeDBInstanceEngineVersion](https://help.aliyun.com/document_detail/67608.html) operation to upgrade the database engine.
         *
         * @param request ModifyDBInstanceTDERequest
         * @return ModifyDBInstanceTDEResponse
         */
        public ModifyDBInstanceTDEResponse ModifyDBInstanceTDE(ModifyDBInstanceTDERequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceTDEWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the transparent data encryption (TDE) status of an ApsaraDB for MongoDB instance.
         *
         * @description TDE allows you to perform real-time I/O encryption and decryption on data files. Data is encrypted before it is written to a disk and is decrypted when it is read from the disk to the memory. For more information, see [Configure TDE](https://help.aliyun.com/document_detail/131048.html).
         * >  TDE cannot be disabled after it is enabled.
         * Before you call this operation, make sure that the ApsaraDB for MongoDB instance meets the following requirements:
         * *   A replica set or sharded cluster instance is used.
         * *   The storage engine of the instance is WiredTiger.
         * *   The instance uses local disks to store data.
         * *   The database engine version of the instance is 4.0 or 4.2. If the database engine version is earlier than 4.0, you can call the [UpgradeDBInstanceEngineVersion](https://help.aliyun.com/document_detail/67608.html) operation to upgrade the database engine.
         *
         * @param request ModifyDBInstanceTDERequest
         * @return ModifyDBInstanceTDEResponse
         */
        public async Task<ModifyDBInstanceTDEResponse> ModifyDBInstanceTDEAsync(ModifyDBInstanceTDERequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceTDEWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the global IP whitelist template associated with an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyGlobalSecurityIPGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyGlobalSecurityIPGroupResponse
         */
        public ModifyGlobalSecurityIPGroupResponse ModifyGlobalSecurityIPGroupWithOptions(ModifyGlobalSecurityIPGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GIpList))
            {
                query["GIpList"] = request.GIpList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalIgName))
            {
                query["GlobalIgName"] = request.GlobalIgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalSecurityGroupId))
            {
                query["GlobalSecurityGroupId"] = request.GlobalSecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGlobalSecurityIPGroup",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyGlobalSecurityIPGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the global IP whitelist template associated with an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyGlobalSecurityIPGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyGlobalSecurityIPGroupResponse
         */
        public async Task<ModifyGlobalSecurityIPGroupResponse> ModifyGlobalSecurityIPGroupWithOptionsAsync(ModifyGlobalSecurityIPGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GIpList))
            {
                query["GIpList"] = request.GIpList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalIgName))
            {
                query["GlobalIgName"] = request.GlobalIgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalSecurityGroupId))
            {
                query["GlobalSecurityGroupId"] = request.GlobalSecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGlobalSecurityIPGroup",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyGlobalSecurityIPGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the global IP whitelist template associated with an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyGlobalSecurityIPGroupRequest
         * @return ModifyGlobalSecurityIPGroupResponse
         */
        public ModifyGlobalSecurityIPGroupResponse ModifyGlobalSecurityIPGroup(ModifyGlobalSecurityIPGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyGlobalSecurityIPGroupWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the global IP whitelist template associated with an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyGlobalSecurityIPGroupRequest
         * @return ModifyGlobalSecurityIPGroupResponse
         */
        public async Task<ModifyGlobalSecurityIPGroupResponse> ModifyGlobalSecurityIPGroupAsync(ModifyGlobalSecurityIPGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyGlobalSecurityIPGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the name of a global IP whitelist template associated with an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyGlobalSecurityIPGroupNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyGlobalSecurityIPGroupNameResponse
         */
        public ModifyGlobalSecurityIPGroupNameResponse ModifyGlobalSecurityIPGroupNameWithOptions(ModifyGlobalSecurityIPGroupNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalIgName))
            {
                query["GlobalIgName"] = request.GlobalIgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalSecurityGroupId))
            {
                query["GlobalSecurityGroupId"] = request.GlobalSecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGlobalSecurityIPGroupName",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyGlobalSecurityIPGroupNameResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the name of a global IP whitelist template associated with an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyGlobalSecurityIPGroupNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyGlobalSecurityIPGroupNameResponse
         */
        public async Task<ModifyGlobalSecurityIPGroupNameResponse> ModifyGlobalSecurityIPGroupNameWithOptionsAsync(ModifyGlobalSecurityIPGroupNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalIgName))
            {
                query["GlobalIgName"] = request.GlobalIgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalSecurityGroupId))
            {
                query["GlobalSecurityGroupId"] = request.GlobalSecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGlobalSecurityIPGroupName",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyGlobalSecurityIPGroupNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the name of a global IP whitelist template associated with an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyGlobalSecurityIPGroupNameRequest
         * @return ModifyGlobalSecurityIPGroupNameResponse
         */
        public ModifyGlobalSecurityIPGroupNameResponse ModifyGlobalSecurityIPGroupName(ModifyGlobalSecurityIPGroupNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyGlobalSecurityIPGroupNameWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the name of a global IP whitelist template associated with an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyGlobalSecurityIPGroupNameRequest
         * @return ModifyGlobalSecurityIPGroupNameResponse
         */
        public async Task<ModifyGlobalSecurityIPGroupNameResponse> ModifyGlobalSecurityIPGroupNameAsync(ModifyGlobalSecurityIPGroupNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyGlobalSecurityIPGroupNameWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the mapping between a global whitelist template and an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyGlobalSecurityIPGroupRelationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyGlobalSecurityIPGroupRelationResponse
         */
        public ModifyGlobalSecurityIPGroupRelationResponse ModifyGlobalSecurityIPGroupRelationWithOptions(ModifyGlobalSecurityIPGroupRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalSecurityGroupId))
            {
                query["GlobalSecurityGroupId"] = request.GlobalSecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGlobalSecurityIPGroupRelation",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyGlobalSecurityIPGroupRelationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the mapping between a global whitelist template and an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyGlobalSecurityIPGroupRelationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyGlobalSecurityIPGroupRelationResponse
         */
        public async Task<ModifyGlobalSecurityIPGroupRelationResponse> ModifyGlobalSecurityIPGroupRelationWithOptionsAsync(ModifyGlobalSecurityIPGroupRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalSecurityGroupId))
            {
                query["GlobalSecurityGroupId"] = request.GlobalSecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyGlobalSecurityIPGroupRelation",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyGlobalSecurityIPGroupRelationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the mapping between a global whitelist template and an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyGlobalSecurityIPGroupRelationRequest
         * @return ModifyGlobalSecurityIPGroupRelationResponse
         */
        public ModifyGlobalSecurityIPGroupRelationResponse ModifyGlobalSecurityIPGroupRelation(ModifyGlobalSecurityIPGroupRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyGlobalSecurityIPGroupRelationWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the mapping between a global whitelist template and an ApsaraDB for MongoDB instance.
         *
         * @param request ModifyGlobalSecurityIPGroupRelationRequest
         * @return ModifyGlobalSecurityIPGroupRelationResponse
         */
        public async Task<ModifyGlobalSecurityIPGroupRelationResponse> ModifyGlobalSecurityIPGroupRelationAsync(ModifyGlobalSecurityIPGroupRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyGlobalSecurityIPGroupRelationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables or disables auto-renewal for an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing).
         * This operation is applicable to subscription instances.
         * >  When auto-renewal is enabled, your payment will be collected nine days before the expiration date of ApsaraDB for MongoDB. Ensure that your account has sufficient balance.
         *
         * @param request ModifyInstanceAutoRenewalAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceAutoRenewalAttributeResponse
         */
        public ModifyInstanceAutoRenewalAttributeResponse ModifyInstanceAutoRenewalAttributeWithOptions(ModifyInstanceAutoRenewalAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceAutoRenewalAttribute",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceAutoRenewalAttributeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables or disables auto-renewal for an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing).
         * This operation is applicable to subscription instances.
         * >  When auto-renewal is enabled, your payment will be collected nine days before the expiration date of ApsaraDB for MongoDB. Ensure that your account has sufficient balance.
         *
         * @param request ModifyInstanceAutoRenewalAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceAutoRenewalAttributeResponse
         */
        public async Task<ModifyInstanceAutoRenewalAttributeResponse> ModifyInstanceAutoRenewalAttributeWithOptionsAsync(ModifyInstanceAutoRenewalAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceAutoRenewalAttribute",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceAutoRenewalAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables or disables auto-renewal for an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing).
         * This operation is applicable to subscription instances.
         * >  When auto-renewal is enabled, your payment will be collected nine days before the expiration date of ApsaraDB for MongoDB. Ensure that your account has sufficient balance.
         *
         * @param request ModifyInstanceAutoRenewalAttributeRequest
         * @return ModifyInstanceAutoRenewalAttributeResponse
         */
        public ModifyInstanceAutoRenewalAttributeResponse ModifyInstanceAutoRenewalAttribute(ModifyInstanceAutoRenewalAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceAutoRenewalAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Enables or disables auto-renewal for an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing).
         * This operation is applicable to subscription instances.
         * >  When auto-renewal is enabled, your payment will be collected nine days before the expiration date of ApsaraDB for MongoDB. Ensure that your account has sufficient balance.
         *
         * @param request ModifyInstanceAutoRenewalAttributeRequest
         * @return ModifyInstanceAutoRenewalAttributeResponse
         */
        public async Task<ModifyInstanceAutoRenewalAttributeResponse> ModifyInstanceAutoRenewalAttributeAsync(ModifyInstanceAutoRenewalAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceAutoRenewalAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disables password-free access over Virtual Private Cloud (VPC) for an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the ApsaraDB for MongoDB instance meets the following requirements:
         * *   The instance is a replica set or sharded cluster instance.
         * *   The database engine version of the instance is 4.0 (with the minor version of mongodb_20190408_3.0.11 or later) or 4.2. You can call the [DescribeDBInstanceAttribute](https://help.aliyun.com/document_detail/62010.html) operation to view the database engine version of the instance. If necessary, you can call the [UpgradeDBInstanceEngineVersion](https://help.aliyun.com/document_detail/67608.html) operation to upgrade the database engine version of the instance.
         * *   The network type of the instance must be VPC. If the network type of the instance is classic network, you must call the [ModifyDBInstanceNetworkType](https://help.aliyun.com/document_detail/62138.html) operation to change the network type to VPC.
         * *   You can only disable but not enable password-free access over VPC.
         *
         * @param request ModifyInstanceVpcAuthModeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceVpcAuthModeResponse
         */
        public ModifyInstanceVpcAuthModeResponse ModifyInstanceVpcAuthModeWithOptions(ModifyInstanceVpcAuthModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcAuthMode))
            {
                query["VpcAuthMode"] = request.VpcAuthMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceVpcAuthMode",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceVpcAuthModeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Disables password-free access over Virtual Private Cloud (VPC) for an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the ApsaraDB for MongoDB instance meets the following requirements:
         * *   The instance is a replica set or sharded cluster instance.
         * *   The database engine version of the instance is 4.0 (with the minor version of mongodb_20190408_3.0.11 or later) or 4.2. You can call the [DescribeDBInstanceAttribute](https://help.aliyun.com/document_detail/62010.html) operation to view the database engine version of the instance. If necessary, you can call the [UpgradeDBInstanceEngineVersion](https://help.aliyun.com/document_detail/67608.html) operation to upgrade the database engine version of the instance.
         * *   The network type of the instance must be VPC. If the network type of the instance is classic network, you must call the [ModifyDBInstanceNetworkType](https://help.aliyun.com/document_detail/62138.html) operation to change the network type to VPC.
         * *   You can only disable but not enable password-free access over VPC.
         *
         * @param request ModifyInstanceVpcAuthModeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceVpcAuthModeResponse
         */
        public async Task<ModifyInstanceVpcAuthModeResponse> ModifyInstanceVpcAuthModeWithOptionsAsync(ModifyInstanceVpcAuthModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcAuthMode))
            {
                query["VpcAuthMode"] = request.VpcAuthMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceVpcAuthMode",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceVpcAuthModeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Disables password-free access over Virtual Private Cloud (VPC) for an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the ApsaraDB for MongoDB instance meets the following requirements:
         * *   The instance is a replica set or sharded cluster instance.
         * *   The database engine version of the instance is 4.0 (with the minor version of mongodb_20190408_3.0.11 or later) or 4.2. You can call the [DescribeDBInstanceAttribute](https://help.aliyun.com/document_detail/62010.html) operation to view the database engine version of the instance. If necessary, you can call the [UpgradeDBInstanceEngineVersion](https://help.aliyun.com/document_detail/67608.html) operation to upgrade the database engine version of the instance.
         * *   The network type of the instance must be VPC. If the network type of the instance is classic network, you must call the [ModifyDBInstanceNetworkType](https://help.aliyun.com/document_detail/62138.html) operation to change the network type to VPC.
         * *   You can only disable but not enable password-free access over VPC.
         *
         * @param request ModifyInstanceVpcAuthModeRequest
         * @return ModifyInstanceVpcAuthModeResponse
         */
        public ModifyInstanceVpcAuthModeResponse ModifyInstanceVpcAuthMode(ModifyInstanceVpcAuthModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceVpcAuthModeWithOptions(request, runtime);
        }

        /**
         * @summary Disables password-free access over Virtual Private Cloud (VPC) for an ApsaraDB for MongoDB instance.
         *
         * @description Before you call this operation, make sure that the ApsaraDB for MongoDB instance meets the following requirements:
         * *   The instance is a replica set or sharded cluster instance.
         * *   The database engine version of the instance is 4.0 (with the minor version of mongodb_20190408_3.0.11 or later) or 4.2. You can call the [DescribeDBInstanceAttribute](https://help.aliyun.com/document_detail/62010.html) operation to view the database engine version of the instance. If necessary, you can call the [UpgradeDBInstanceEngineVersion](https://help.aliyun.com/document_detail/67608.html) operation to upgrade the database engine version of the instance.
         * *   The network type of the instance must be VPC. If the network type of the instance is classic network, you must call the [ModifyDBInstanceNetworkType](https://help.aliyun.com/document_detail/62138.html) operation to change the network type to VPC.
         * *   You can only disable but not enable password-free access over VPC.
         *
         * @param request ModifyInstanceVpcAuthModeRequest
         * @return ModifyInstanceVpcAuthModeResponse
         */
        public async Task<ModifyInstanceVpcAuthModeResponse> ModifyInstanceVpcAuthModeAsync(ModifyInstanceVpcAuthModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceVpcAuthModeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the specifications and storage capacity of a node of an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing) of ApsaraDB for MongoDB.
         * > This operation is applicable only to sharded cluster instances.
         *
         * @param request ModifyNodeSpecRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyNodeSpecResponse
         */
        public ModifyNodeSpecResponse ModifyNodeSpecWithOptions(ModifyNodeSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                query["EffectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromApp))
            {
                query["FromApp"] = request.FromApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeClass))
            {
                query["NodeClass"] = request.NodeClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeStorage))
            {
                query["NodeStorage"] = request.NodeStorage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadonlyReplicas))
            {
                query["ReadonlyReplicas"] = request.ReadonlyReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchTime))
            {
                query["SwitchTime"] = request.SwitchTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyNodeSpec",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNodeSpecResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes the specifications and storage capacity of a node of an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing) of ApsaraDB for MongoDB.
         * > This operation is applicable only to sharded cluster instances.
         *
         * @param request ModifyNodeSpecRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyNodeSpecResponse
         */
        public async Task<ModifyNodeSpecResponse> ModifyNodeSpecWithOptionsAsync(ModifyNodeSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                query["EffectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromApp))
            {
                query["FromApp"] = request.FromApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeClass))
            {
                query["NodeClass"] = request.NodeClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeStorage))
            {
                query["NodeStorage"] = request.NodeStorage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadonlyReplicas))
            {
                query["ReadonlyReplicas"] = request.ReadonlyReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchTime))
            {
                query["SwitchTime"] = request.SwitchTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyNodeSpec",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNodeSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes the specifications and storage capacity of a node of an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing) of ApsaraDB for MongoDB.
         * > This operation is applicable only to sharded cluster instances.
         *
         * @param request ModifyNodeSpecRequest
         * @return ModifyNodeSpecResponse
         */
        public ModifyNodeSpecResponse ModifyNodeSpec(ModifyNodeSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNodeSpecWithOptions(request, runtime);
        }

        /**
         * @summary Changes the specifications and storage capacity of a node of an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing) of ApsaraDB for MongoDB.
         * > This operation is applicable only to sharded cluster instances.
         *
         * @param request ModifyNodeSpecRequest
         * @return ModifyNodeSpecResponse
         */
        public async Task<ModifyNodeSpecResponse> ModifyNodeSpecAsync(ModifyNodeSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNodeSpecWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the configurations of mongos or shard nodes in an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description Make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing) of ApsaraDB for MongoDB before you call this operation.
         * This operation is applicable only to sharded cluster instances.
         * When you upgrade or downgrade the configurations of multiple sharded cluster instances in batches, the specifications of the instances are limited. For example, if you want to expand the storage capacity of the instances, the storage capacity of the instances after expansion must be greater than the current capacity. When the specifications of multiple sharded cluster instances are different, limits are defined based on the specifications of a random sharded cluster instance. In this case, you may be unable to upgrade or downgrade the configurations of the instances. In this case, we recommend that you call the ModifyNodeSpec operation to individually change the configurations of each sharded cluster instance.
         *
         * @param request ModifyNodeSpecBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyNodeSpecBatchResponse
         */
        public ModifyNodeSpecBatchResponse ModifyNodeSpecBatchWithOptions(ModifyNodeSpecBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                query["EffectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodesInfo))
            {
                query["NodesInfo"] = request.NodesInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyNodeSpecBatch",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNodeSpecBatchResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes the configurations of mongos or shard nodes in an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description Make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing) of ApsaraDB for MongoDB before you call this operation.
         * This operation is applicable only to sharded cluster instances.
         * When you upgrade or downgrade the configurations of multiple sharded cluster instances in batches, the specifications of the instances are limited. For example, if you want to expand the storage capacity of the instances, the storage capacity of the instances after expansion must be greater than the current capacity. When the specifications of multiple sharded cluster instances are different, limits are defined based on the specifications of a random sharded cluster instance. In this case, you may be unable to upgrade or downgrade the configurations of the instances. In this case, we recommend that you call the ModifyNodeSpec operation to individually change the configurations of each sharded cluster instance.
         *
         * @param request ModifyNodeSpecBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyNodeSpecBatchResponse
         */
        public async Task<ModifyNodeSpecBatchResponse> ModifyNodeSpecBatchWithOptionsAsync(ModifyNodeSpecBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTime))
            {
                query["EffectiveTime"] = request.EffectiveTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodesInfo))
            {
                query["NodesInfo"] = request.NodesInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyNodeSpecBatch",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNodeSpecBatchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes the configurations of mongos or shard nodes in an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description Make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing) of ApsaraDB for MongoDB before you call this operation.
         * This operation is applicable only to sharded cluster instances.
         * When you upgrade or downgrade the configurations of multiple sharded cluster instances in batches, the specifications of the instances are limited. For example, if you want to expand the storage capacity of the instances, the storage capacity of the instances after expansion must be greater than the current capacity. When the specifications of multiple sharded cluster instances are different, limits are defined based on the specifications of a random sharded cluster instance. In this case, you may be unable to upgrade or downgrade the configurations of the instances. In this case, we recommend that you call the ModifyNodeSpec operation to individually change the configurations of each sharded cluster instance.
         *
         * @param request ModifyNodeSpecBatchRequest
         * @return ModifyNodeSpecBatchResponse
         */
        public ModifyNodeSpecBatchResponse ModifyNodeSpecBatch(ModifyNodeSpecBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNodeSpecBatchWithOptions(request, runtime);
        }

        /**
         * @summary Changes the configurations of mongos or shard nodes in an ApsaraDB for MongoDB sharded cluster instance.
         *
         * @description Make sure that you fully understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing) of ApsaraDB for MongoDB before you call this operation.
         * This operation is applicable only to sharded cluster instances.
         * When you upgrade or downgrade the configurations of multiple sharded cluster instances in batches, the specifications of the instances are limited. For example, if you want to expand the storage capacity of the instances, the storage capacity of the instances after expansion must be greater than the current capacity. When the specifications of multiple sharded cluster instances are different, limits are defined based on the specifications of a random sharded cluster instance. In this case, you may be unable to upgrade or downgrade the configurations of the instances. In this case, we recommend that you call the ModifyNodeSpec operation to individually change the configurations of each sharded cluster instance.
         *
         * @param request ModifyNodeSpecBatchRequest
         * @return ModifyNodeSpecBatchResponse
         */
        public async Task<ModifyNodeSpecBatchResponse> ModifyNodeSpecBatchAsync(ModifyNodeSpecBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNodeSpecBatchWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the parameters of an ApsaraDB for MongoDB instance.
         *
         * @description *   The instance must be in the Running state when you call this operation.
         * *   If you call this operation to modify specific instance parameters and the modification for part of the parameters can take effect only after an instance restart, the instance is automatically restarted after this operation is called. You can call the [DescribeParameterTemplates](https://help.aliyun.com/document_detail/67618.html) operation to query the parameters that take effect only after the instance is restarted.
         *
         * @param request ModifyParametersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyParametersResponse
         */
        public ModifyParametersResponse ModifyParametersWithOptions(ModifyParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CharacterType))
            {
                query["CharacterType"] = request.CharacterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyParameters",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyParametersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the parameters of an ApsaraDB for MongoDB instance.
         *
         * @description *   The instance must be in the Running state when you call this operation.
         * *   If you call this operation to modify specific instance parameters and the modification for part of the parameters can take effect only after an instance restart, the instance is automatically restarted after this operation is called. You can call the [DescribeParameterTemplates](https://help.aliyun.com/document_detail/67618.html) operation to query the parameters that take effect only after the instance is restarted.
         *
         * @param request ModifyParametersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyParametersResponse
         */
        public async Task<ModifyParametersResponse> ModifyParametersWithOptionsAsync(ModifyParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CharacterType))
            {
                query["CharacterType"] = request.CharacterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyParameters",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyParametersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the parameters of an ApsaraDB for MongoDB instance.
         *
         * @description *   The instance must be in the Running state when you call this operation.
         * *   If you call this operation to modify specific instance parameters and the modification for part of the parameters can take effect only after an instance restart, the instance is automatically restarted after this operation is called. You can call the [DescribeParameterTemplates](https://help.aliyun.com/document_detail/67618.html) operation to query the parameters that take effect only after the instance is restarted.
         *
         * @param request ModifyParametersRequest
         * @return ModifyParametersResponse
         */
        public ModifyParametersResponse ModifyParameters(ModifyParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyParametersWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the parameters of an ApsaraDB for MongoDB instance.
         *
         * @description *   The instance must be in the Running state when you call this operation.
         * *   If you call this operation to modify specific instance parameters and the modification for part of the parameters can take effect only after an instance restart, the instance is automatically restarted after this operation is called. You can call the [DescribeParameterTemplates](https://help.aliyun.com/document_detail/67618.html) operation to query the parameters that take effect only after the instance is restarted.
         *
         * @param request ModifyParametersRequest
         * @return ModifyParametersResponse
         */
        public async Task<ModifyParametersResponse> ModifyParametersAsync(ModifyParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyParametersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Moves an ApsaraDB for MongoDB instance to a specified resource group.
         *
         * @description Resource Management allows you to build an organizational structure for resources based on your business requirements. You can use resource directories, folders, accounts, and resource groups to hierarchically organize and manage resources. For more information, see [What is Resource Management?](https://help.aliyun.com/document_detail/94475.html)
         *
         * @param request ModifyResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyResourceGroupResponse
         */
        public ModifyResourceGroupResponse ModifyResourceGroupWithOptions(ModifyResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyResourceGroup",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Moves an ApsaraDB for MongoDB instance to a specified resource group.
         *
         * @description Resource Management allows you to build an organizational structure for resources based on your business requirements. You can use resource directories, folders, accounts, and resource groups to hierarchically organize and manage resources. For more information, see [What is Resource Management?](https://help.aliyun.com/document_detail/94475.html)
         *
         * @param request ModifyResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyResourceGroupResponse
         */
        public async Task<ModifyResourceGroupResponse> ModifyResourceGroupWithOptionsAsync(ModifyResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyResourceGroup",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Moves an ApsaraDB for MongoDB instance to a specified resource group.
         *
         * @description Resource Management allows you to build an organizational structure for resources based on your business requirements. You can use resource directories, folders, accounts, and resource groups to hierarchically organize and manage resources. For more information, see [What is Resource Management?](https://help.aliyun.com/document_detail/94475.html)
         *
         * @param request ModifyResourceGroupRequest
         * @return ModifyResourceGroupResponse
         */
        public ModifyResourceGroupResponse ModifyResourceGroup(ModifyResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyResourceGroupWithOptions(request, runtime);
        }

        /**
         * @summary Moves an ApsaraDB for MongoDB instance to a specified resource group.
         *
         * @description Resource Management allows you to build an organizational structure for resources based on your business requirements. You can use resource directories, folders, accounts, and resource groups to hierarchically organize and manage resources. For more information, see [What is Resource Management?](https://help.aliyun.com/document_detail/94475.html)
         *
         * @param request ModifyResourceGroupRequest
         * @return ModifyResourceGroupResponse
         */
        public async Task<ModifyResourceGroupResponse> ModifyResourceGroupAsync(ModifyResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to modify an ECS Security group that is bound to an ApsaraDB for MongoDB instance.
         *
         * @description >  For a sharded cluster instance, the bound ECS security group takes effect only for mongos nodes.
         *
         * @param request ModifySecurityGroupConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifySecurityGroupConfigurationResponse
         */
        public ModifySecurityGroupConfigurationResponse ModifySecurityGroupConfigurationWithOptions(ModifySecurityGroupConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySecurityGroupConfiguration",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySecurityGroupConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to modify an ECS Security group that is bound to an ApsaraDB for MongoDB instance.
         *
         * @description >  For a sharded cluster instance, the bound ECS security group takes effect only for mongos nodes.
         *
         * @param request ModifySecurityGroupConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifySecurityGroupConfigurationResponse
         */
        public async Task<ModifySecurityGroupConfigurationResponse> ModifySecurityGroupConfigurationWithOptionsAsync(ModifySecurityGroupConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySecurityGroupConfiguration",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySecurityGroupConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to modify an ECS Security group that is bound to an ApsaraDB for MongoDB instance.
         *
         * @description >  For a sharded cluster instance, the bound ECS security group takes effect only for mongos nodes.
         *
         * @param request ModifySecurityGroupConfigurationRequest
         * @return ModifySecurityGroupConfigurationResponse
         */
        public ModifySecurityGroupConfigurationResponse ModifySecurityGroupConfiguration(ModifySecurityGroupConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySecurityGroupConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to modify an ECS Security group that is bound to an ApsaraDB for MongoDB instance.
         *
         * @description >  For a sharded cluster instance, the bound ECS security group takes effect only for mongos nodes.
         *
         * @param request ModifySecurityGroupConfigurationRequest
         * @return ModifySecurityGroupConfigurationResponse
         */
        public async Task<ModifySecurityGroupConfigurationResponse> ModifySecurityGroupConfigurationAsync(ModifySecurityGroupConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySecurityGroupConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the IP address whitelist of an ApsaraDB for MongoDB instance.
         *
         * @param request ModifySecurityIpsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifySecurityIpsResponse
         */
        public ModifySecurityIpsResponse ModifySecurityIpsWithOptions(ModifySecurityIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMode))
            {
                query["ModifyMode"] = request.ModifyMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIpGroupAttribute))
            {
                query["SecurityIpGroupAttribute"] = request.SecurityIpGroupAttribute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIpGroupName))
            {
                query["SecurityIpGroupName"] = request.SecurityIpGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIps))
            {
                query["SecurityIps"] = request.SecurityIps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySecurityIps",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySecurityIpsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the IP address whitelist of an ApsaraDB for MongoDB instance.
         *
         * @param request ModifySecurityIpsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifySecurityIpsResponse
         */
        public async Task<ModifySecurityIpsResponse> ModifySecurityIpsWithOptionsAsync(ModifySecurityIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMode))
            {
                query["ModifyMode"] = request.ModifyMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIpGroupAttribute))
            {
                query["SecurityIpGroupAttribute"] = request.SecurityIpGroupAttribute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIpGroupName))
            {
                query["SecurityIpGroupName"] = request.SecurityIpGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIps))
            {
                query["SecurityIps"] = request.SecurityIps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySecurityIps",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySecurityIpsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the IP address whitelist of an ApsaraDB for MongoDB instance.
         *
         * @param request ModifySecurityIpsRequest
         * @return ModifySecurityIpsResponse
         */
        public ModifySecurityIpsResponse ModifySecurityIps(ModifySecurityIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySecurityIpsWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the IP address whitelist of an ApsaraDB for MongoDB instance.
         *
         * @param request ModifySecurityIpsRequest
         * @return ModifySecurityIpsResponse
         */
        public async Task<ModifySecurityIpsResponse> ModifySecurityIpsAsync(ModifySecurityIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySecurityIpsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the information of a task in the task center for an ApsaraDB for MongoDB instance.
         *
         * @description The actions performed by this operation for a task vary based on the current state of the task. The supported actions for a task can be obtained from the value of the actionInfo parameter in the DescribeHistoryTasks operation.
         *
         * @param request ModifyTaskInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTaskInfoResponse
         */
        public ModifyTaskInfoResponse ModifyTaskInfoWithOptions(ModifyTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionParams))
            {
                query["ActionParams"] = request.ActionParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StepName))
            {
                query["StepName"] = request.StepName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskAction))
            {
                query["TaskAction"] = request.TaskAction;
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
                Action = "ModifyTaskInfo",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTaskInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the information of a task in the task center for an ApsaraDB for MongoDB instance.
         *
         * @description The actions performed by this operation for a task vary based on the current state of the task. The supported actions for a task can be obtained from the value of the actionInfo parameter in the DescribeHistoryTasks operation.
         *
         * @param request ModifyTaskInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTaskInfoResponse
         */
        public async Task<ModifyTaskInfoResponse> ModifyTaskInfoWithOptionsAsync(ModifyTaskInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionParams))
            {
                query["ActionParams"] = request.ActionParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StepName))
            {
                query["StepName"] = request.StepName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskAction))
            {
                query["TaskAction"] = request.TaskAction;
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
                Action = "ModifyTaskInfo",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTaskInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the information of a task in the task center for an ApsaraDB for MongoDB instance.
         *
         * @description The actions performed by this operation for a task vary based on the current state of the task. The supported actions for a task can be obtained from the value of the actionInfo parameter in the DescribeHistoryTasks operation.
         *
         * @param request ModifyTaskInfoRequest
         * @return ModifyTaskInfoResponse
         */
        public ModifyTaskInfoResponse ModifyTaskInfo(ModifyTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTaskInfoWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the information of a task in the task center for an ApsaraDB for MongoDB instance.
         *
         * @description The actions performed by this operation for a task vary based on the current state of the task. The supported actions for a task can be obtained from the value of the actionInfo parameter in the DescribeHistoryTasks operation.
         *
         * @param request ModifyTaskInfoRequest
         * @return ModifyTaskInfoResponse
         */
        public async Task<ModifyTaskInfoResponse> ModifyTaskInfoAsync(ModifyTaskInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTaskInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Releases the internal endpoint of a shard or Configserver node in a sharded cluster instance.
         *
         * @description *   This operation can be used to release the internal endpoint of a shard or Configserver node in a sharded cluster instance. For more information, see [Release the endpoint of a shard or Configserver node](https://help.aliyun.com/document_detail/134067.html).
         * *   To release the public endpoint of a shard or Configserver node in a sharded cluster instance, you can call the [ReleasePublicNetworkAddress](https://help.aliyun.com/document_detail/67604.html) operation.
         *
         * @param request ReleaseNodePrivateNetworkAddressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseNodePrivateNetworkAddressResponse
         */
        public ReleaseNodePrivateNetworkAddressResponse ReleaseNodePrivateNetworkAddressWithOptions(ReleaseNodePrivateNetworkAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionType))
            {
                query["ConnectionType"] = request.ConnectionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseNodePrivateNetworkAddress",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseNodePrivateNetworkAddressResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Releases the internal endpoint of a shard or Configserver node in a sharded cluster instance.
         *
         * @description *   This operation can be used to release the internal endpoint of a shard or Configserver node in a sharded cluster instance. For more information, see [Release the endpoint of a shard or Configserver node](https://help.aliyun.com/document_detail/134067.html).
         * *   To release the public endpoint of a shard or Configserver node in a sharded cluster instance, you can call the [ReleasePublicNetworkAddress](https://help.aliyun.com/document_detail/67604.html) operation.
         *
         * @param request ReleaseNodePrivateNetworkAddressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseNodePrivateNetworkAddressResponse
         */
        public async Task<ReleaseNodePrivateNetworkAddressResponse> ReleaseNodePrivateNetworkAddressWithOptionsAsync(ReleaseNodePrivateNetworkAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionType))
            {
                query["ConnectionType"] = request.ConnectionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseNodePrivateNetworkAddress",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseNodePrivateNetworkAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Releases the internal endpoint of a shard or Configserver node in a sharded cluster instance.
         *
         * @description *   This operation can be used to release the internal endpoint of a shard or Configserver node in a sharded cluster instance. For more information, see [Release the endpoint of a shard or Configserver node](https://help.aliyun.com/document_detail/134067.html).
         * *   To release the public endpoint of a shard or Configserver node in a sharded cluster instance, you can call the [ReleasePublicNetworkAddress](https://help.aliyun.com/document_detail/67604.html) operation.
         *
         * @param request ReleaseNodePrivateNetworkAddressRequest
         * @return ReleaseNodePrivateNetworkAddressResponse
         */
        public ReleaseNodePrivateNetworkAddressResponse ReleaseNodePrivateNetworkAddress(ReleaseNodePrivateNetworkAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseNodePrivateNetworkAddressWithOptions(request, runtime);
        }

        /**
         * @summary Releases the internal endpoint of a shard or Configserver node in a sharded cluster instance.
         *
         * @description *   This operation can be used to release the internal endpoint of a shard or Configserver node in a sharded cluster instance. For more information, see [Release the endpoint of a shard or Configserver node](https://help.aliyun.com/document_detail/134067.html).
         * *   To release the public endpoint of a shard or Configserver node in a sharded cluster instance, you can call the [ReleasePublicNetworkAddress](https://help.aliyun.com/document_detail/67604.html) operation.
         *
         * @param request ReleaseNodePrivateNetworkAddressRequest
         * @return ReleaseNodePrivateNetworkAddressResponse
         */
        public async Task<ReleaseNodePrivateNetworkAddressResponse> ReleaseNodePrivateNetworkAddressAsync(ReleaseNodePrivateNetworkAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseNodePrivateNetworkAddressWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Releases the public endpoint of an ApsaraDB for MongoDB instance.
         *
         * @param request ReleasePublicNetworkAddressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleasePublicNetworkAddressResponse
         */
        public ReleasePublicNetworkAddressResponse ReleasePublicNetworkAddressWithOptions(ReleasePublicNetworkAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionType))
            {
                query["ConnectionType"] = request.ConnectionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleasePublicNetworkAddress",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleasePublicNetworkAddressResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Releases the public endpoint of an ApsaraDB for MongoDB instance.
         *
         * @param request ReleasePublicNetworkAddressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleasePublicNetworkAddressResponse
         */
        public async Task<ReleasePublicNetworkAddressResponse> ReleasePublicNetworkAddressWithOptionsAsync(ReleasePublicNetworkAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionType))
            {
                query["ConnectionType"] = request.ConnectionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleasePublicNetworkAddress",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleasePublicNetworkAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Releases the public endpoint of an ApsaraDB for MongoDB instance.
         *
         * @param request ReleasePublicNetworkAddressRequest
         * @return ReleasePublicNetworkAddressResponse
         */
        public ReleasePublicNetworkAddressResponse ReleasePublicNetworkAddress(ReleasePublicNetworkAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleasePublicNetworkAddressWithOptions(request, runtime);
        }

        /**
         * @summary Releases the public endpoint of an ApsaraDB for MongoDB instance.
         *
         * @param request ReleasePublicNetworkAddressRequest
         * @return ReleasePublicNetworkAddressResponse
         */
        public async Task<ReleasePublicNetworkAddressResponse> ReleasePublicNetworkAddressAsync(ReleasePublicNetworkAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleasePublicNetworkAddressWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Manually renews an ApsaraDB for MongoDB subscription instance.
         *
         * @description Make sure that you fully understand the billing methods and pricing of ApsaraDB for MongoDB before you call this operation. For more information about the pricing of ApsaraDB for MongoDB, visit the [pricing tab of the product buy page](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing).
         * This operation is only applicable to instances that use the subscription billing method.
         *
         * @param request RenewDBInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenewDBInstanceResponse
         */
        public RenewDBInstanceResponse RenewDBInstanceWithOptions(RenewDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewDBInstance",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewDBInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Manually renews an ApsaraDB for MongoDB subscription instance.
         *
         * @description Make sure that you fully understand the billing methods and pricing of ApsaraDB for MongoDB before you call this operation. For more information about the pricing of ApsaraDB for MongoDB, visit the [pricing tab of the product buy page](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing).
         * This operation is only applicable to instances that use the subscription billing method.
         *
         * @param request RenewDBInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenewDBInstanceResponse
         */
        public async Task<RenewDBInstanceResponse> RenewDBInstanceWithOptionsAsync(RenewDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewDBInstance",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewDBInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Manually renews an ApsaraDB for MongoDB subscription instance.
         *
         * @description Make sure that you fully understand the billing methods and pricing of ApsaraDB for MongoDB before you call this operation. For more information about the pricing of ApsaraDB for MongoDB, visit the [pricing tab of the product buy page](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing).
         * This operation is only applicable to instances that use the subscription billing method.
         *
         * @param request RenewDBInstanceRequest
         * @return RenewDBInstanceResponse
         */
        public RenewDBInstanceResponse RenewDBInstance(RenewDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewDBInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Manually renews an ApsaraDB for MongoDB subscription instance.
         *
         * @description Make sure that you fully understand the billing methods and pricing of ApsaraDB for MongoDB before you call this operation. For more information about the pricing of ApsaraDB for MongoDB, visit the [pricing tab of the product buy page](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing).
         * This operation is only applicable to instances that use the subscription billing method.
         *
         * @param request RenewDBInstanceRequest
         * @return RenewDBInstanceResponse
         */
        public async Task<RenewDBInstanceResponse> RenewDBInstanceAsync(RenewDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewDBInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Resets the password of the root account in an ApsaraDB for MongoDB instance.
         *
         * @description >  This operation can be used to reset only the password of the root account of an instance.
         *
         * @param request ResetAccountPasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetAccountPasswordResponse
         */
        public ResetAccountPasswordResponse ResetAccountPasswordWithOptions(ResetAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPassword))
            {
                query["AccountPassword"] = request.AccountPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CharacterType))
            {
                query["CharacterType"] = request.CharacterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetAccountPassword",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetAccountPasswordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Resets the password of the root account in an ApsaraDB for MongoDB instance.
         *
         * @description >  This operation can be used to reset only the password of the root account of an instance.
         *
         * @param request ResetAccountPasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetAccountPasswordResponse
         */
        public async Task<ResetAccountPasswordResponse> ResetAccountPasswordWithOptionsAsync(ResetAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPassword))
            {
                query["AccountPassword"] = request.AccountPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CharacterType))
            {
                query["CharacterType"] = request.CharacterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetAccountPassword",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetAccountPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Resets the password of the root account in an ApsaraDB for MongoDB instance.
         *
         * @description >  This operation can be used to reset only the password of the root account of an instance.
         *
         * @param request ResetAccountPasswordRequest
         * @return ResetAccountPasswordResponse
         */
        public ResetAccountPasswordResponse ResetAccountPassword(ResetAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetAccountPasswordWithOptions(request, runtime);
        }

        /**
         * @summary Resets the password of the root account in an ApsaraDB for MongoDB instance.
         *
         * @description >  This operation can be used to reset only the password of the root account of an instance.
         *
         * @param request ResetAccountPasswordRequest
         * @return ResetAccountPasswordResponse
         */
        public async Task<ResetAccountPasswordResponse> ResetAccountPasswordAsync(ResetAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetAccountPasswordWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Restarts an ApsaraDB for MongoDB instance.
         *
         * @description This operation can also be used to restart an instance, or restart a shard or mongos node in a sharded cluster instance.
         *
         * @param request RestartDBInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestartDBInstanceResponse
         */
        public RestartDBInstanceResponse RestartDBInstanceWithOptions(RestartDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartDBInstance",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartDBInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Restarts an ApsaraDB for MongoDB instance.
         *
         * @description This operation can also be used to restart an instance, or restart a shard or mongos node in a sharded cluster instance.
         *
         * @param request RestartDBInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestartDBInstanceResponse
         */
        public async Task<RestartDBInstanceResponse> RestartDBInstanceWithOptionsAsync(RestartDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartDBInstance",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartDBInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Restarts an ApsaraDB for MongoDB instance.
         *
         * @description This operation can also be used to restart an instance, or restart a shard or mongos node in a sharded cluster instance.
         *
         * @param request RestartDBInstanceRequest
         * @return RestartDBInstanceResponse
         */
        public RestartDBInstanceResponse RestartDBInstance(RestartDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartDBInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Restarts an ApsaraDB for MongoDB instance.
         *
         * @description This operation can also be used to restart an instance, or restart a shard or mongos node in a sharded cluster instance.
         *
         * @param request RestartDBInstanceRequest
         * @return RestartDBInstanceResponse
         */
        public async Task<RestartDBInstanceResponse> RestartDBInstanceAsync(RestartDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartDBInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 重启副本集单个节点
         *
         * @param request RestartNodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestartNodeResponse
         */
        public RestartNodeResponse RestartNodeWithOptions(RestartNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartNode",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartNodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 重启副本集单个节点
         *
         * @param request RestartNodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestartNodeResponse
         */
        public async Task<RestartNodeResponse> RestartNodeWithOptionsAsync(RestartNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["RoleId"] = request.RoleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartNode",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 重启副本集单个节点
         *
         * @param request RestartNodeRequest
         * @return RestartNodeResponse
         */
        public RestartNodeResponse RestartNode(RestartNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartNodeWithOptions(request, runtime);
        }

        /**
         * @summary 重启副本集单个节点
         *
         * @param request RestartNodeRequest
         * @return RestartNodeResponse
         */
        public async Task<RestartNodeResponse> RestartNodeAsync(RestartNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartNodeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Switches the primary and secondary nodes for an ApsaraDB for MongoDB instance.
         *
         * @description The instance must be running when you call this operation.
         * > 
         * *   This operation is applicable to replica set instances and sharded cluster instances, but cannot be performed on standalone instances.
         * *   On replica set instances, the switch is performed between instances. On sharded cluster instances, the switch is performed between shards.
         *
         * @param request SwitchDBInstanceHARequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SwitchDBInstanceHAResponse
         */
        public SwitchDBInstanceHAResponse SwitchDBInstanceHAWithOptions(SwitchDBInstanceHARequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIds))
            {
                query["RoleIds"] = request.RoleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchMode))
            {
                query["SwitchMode"] = request.SwitchMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchDBInstanceHA",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchDBInstanceHAResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Switches the primary and secondary nodes for an ApsaraDB for MongoDB instance.
         *
         * @description The instance must be running when you call this operation.
         * > 
         * *   This operation is applicable to replica set instances and sharded cluster instances, but cannot be performed on standalone instances.
         * *   On replica set instances, the switch is performed between instances. On sharded cluster instances, the switch is performed between shards.
         *
         * @param request SwitchDBInstanceHARequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SwitchDBInstanceHAResponse
         */
        public async Task<SwitchDBInstanceHAResponse> SwitchDBInstanceHAWithOptionsAsync(SwitchDBInstanceHARequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIds))
            {
                query["RoleIds"] = request.RoleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchMode))
            {
                query["SwitchMode"] = request.SwitchMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchDBInstanceHA",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchDBInstanceHAResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Switches the primary and secondary nodes for an ApsaraDB for MongoDB instance.
         *
         * @description The instance must be running when you call this operation.
         * > 
         * *   This operation is applicable to replica set instances and sharded cluster instances, but cannot be performed on standalone instances.
         * *   On replica set instances, the switch is performed between instances. On sharded cluster instances, the switch is performed between shards.
         *
         * @param request SwitchDBInstanceHARequest
         * @return SwitchDBInstanceHAResponse
         */
        public SwitchDBInstanceHAResponse SwitchDBInstanceHA(SwitchDBInstanceHARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchDBInstanceHAWithOptions(request, runtime);
        }

        /**
         * @summary Switches the primary and secondary nodes for an ApsaraDB for MongoDB instance.
         *
         * @description The instance must be running when you call this operation.
         * > 
         * *   This operation is applicable to replica set instances and sharded cluster instances, but cannot be performed on standalone instances.
         * *   On replica set instances, the switch is performed between instances. On sharded cluster instances, the switch is performed between shards.
         *
         * @param request SwitchDBInstanceHARequest
         * @return SwitchDBInstanceHAResponse
         */
        public async Task<SwitchDBInstanceHAResponse> SwitchDBInstanceHAAsync(SwitchDBInstanceHARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchDBInstanceHAWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Binds tags to ApsaraDB for MongoDB instances.
         *
         * @description If you have a large number of instances, you can create multiple tags, bind the tags to the instances, and filter the instances by tag.
         * *   A tag consists of a key and a value. Each key must be unique in a region for an Alibaba Cloud account. Different keys can be mapped to the same value.
         * *   If the tag that you specify does not exist, this tag is automatically created and bound to the specified instance.
         * *   If a tag that has the same key is already bound to the instance, the new tag overwrites the existing tag.
         * *   You can bind up to 20 tags to each instance.
         * *   You can bind tags to up to 50 instances each time you call the operation.
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Version = "2015-12-01",
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
         * @summary Binds tags to ApsaraDB for MongoDB instances.
         *
         * @description If you have a large number of instances, you can create multiple tags, bind the tags to the instances, and filter the instances by tag.
         * *   A tag consists of a key and a value. Each key must be unique in a region for an Alibaba Cloud account. Different keys can be mapped to the same value.
         * *   If the tag that you specify does not exist, this tag is automatically created and bound to the specified instance.
         * *   If a tag that has the same key is already bound to the instance, the new tag overwrites the existing tag.
         * *   You can bind up to 20 tags to each instance.
         * *   You can bind tags to up to 50 instances each time you call the operation.
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Version = "2015-12-01",
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
         * @summary Binds tags to ApsaraDB for MongoDB instances.
         *
         * @description If you have a large number of instances, you can create multiple tags, bind the tags to the instances, and filter the instances by tag.
         * *   A tag consists of a key and a value. Each key must be unique in a region for an Alibaba Cloud account. Different keys can be mapped to the same value.
         * *   If the tag that you specify does not exist, this tag is automatically created and bound to the specified instance.
         * *   If a tag that has the same key is already bound to the instance, the new tag overwrites the existing tag.
         * *   You can bind up to 20 tags to each instance.
         * *   You can bind tags to up to 50 instances each time you call the operation.
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
         * @summary Binds tags to ApsaraDB for MongoDB instances.
         *
         * @description If you have a large number of instances, you can create multiple tags, bind the tags to the instances, and filter the instances by tag.
         * *   A tag consists of a key and a value. Each key must be unique in a region for an Alibaba Cloud account. Different keys can be mapped to the same value.
         * *   If the tag that you specify does not exist, this tag is automatically created and bound to the specified instance.
         * *   If a tag that has the same key is already bound to the instance, the new tag overwrites the existing tag.
         * *   You can bind up to 20 tags to each instance.
         * *   You can bind tags to up to 50 instances each time you call the operation.
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
         * @summary Switches the backup mode of an ApsaraDB for MongoDB sharded cluster instance to the cluster backup mode. After the instance is switched to the cluster backup mode, the instance supports high-frequency backup.
         *
         * @description *   The instance is an ApsaraDB for MongoDB sharded cluster instance that runs MongoDB 4.4 or later and uses enhanced SSDs (ESSDs) to store data.
         * *   You can call the TransferClusterBackup operation only for instances that are created before October 19, 2023 to switch the instances to the cluster backup mode. Cloud disk-based sharded cluster instances that are created on or after October 19, 2023 are set to the cluster backup mode by default.
         *
         * @param request TransferClusterBackupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TransferClusterBackupResponse
         */
        public TransferClusterBackupResponse TransferClusterBackupWithOptions(TransferClusterBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferClusterBackup",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferClusterBackupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Switches the backup mode of an ApsaraDB for MongoDB sharded cluster instance to the cluster backup mode. After the instance is switched to the cluster backup mode, the instance supports high-frequency backup.
         *
         * @description *   The instance is an ApsaraDB for MongoDB sharded cluster instance that runs MongoDB 4.4 or later and uses enhanced SSDs (ESSDs) to store data.
         * *   You can call the TransferClusterBackup operation only for instances that are created before October 19, 2023 to switch the instances to the cluster backup mode. Cloud disk-based sharded cluster instances that are created on or after October 19, 2023 are set to the cluster backup mode by default.
         *
         * @param request TransferClusterBackupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TransferClusterBackupResponse
         */
        public async Task<TransferClusterBackupResponse> TransferClusterBackupWithOptionsAsync(TransferClusterBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferClusterBackup",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferClusterBackupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Switches the backup mode of an ApsaraDB for MongoDB sharded cluster instance to the cluster backup mode. After the instance is switched to the cluster backup mode, the instance supports high-frequency backup.
         *
         * @description *   The instance is an ApsaraDB for MongoDB sharded cluster instance that runs MongoDB 4.4 or later and uses enhanced SSDs (ESSDs) to store data.
         * *   You can call the TransferClusterBackup operation only for instances that are created before October 19, 2023 to switch the instances to the cluster backup mode. Cloud disk-based sharded cluster instances that are created on or after October 19, 2023 are set to the cluster backup mode by default.
         *
         * @param request TransferClusterBackupRequest
         * @return TransferClusterBackupResponse
         */
        public TransferClusterBackupResponse TransferClusterBackup(TransferClusterBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferClusterBackupWithOptions(request, runtime);
        }

        /**
         * @summary Switches the backup mode of an ApsaraDB for MongoDB sharded cluster instance to the cluster backup mode. After the instance is switched to the cluster backup mode, the instance supports high-frequency backup.
         *
         * @description *   The instance is an ApsaraDB for MongoDB sharded cluster instance that runs MongoDB 4.4 or later and uses enhanced SSDs (ESSDs) to store data.
         * *   You can call the TransferClusterBackup operation only for instances that are created before October 19, 2023 to switch the instances to the cluster backup mode. Cloud disk-based sharded cluster instances that are created on or after October 19, 2023 are set to the cluster backup mode by default.
         *
         * @param request TransferClusterBackupRequest
         * @return TransferClusterBackupResponse
         */
        public async Task<TransferClusterBackupResponse> TransferClusterBackupAsync(TransferClusterBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferClusterBackupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the billing method of an instance from pay-as-you-go to subscription or from subscription to pay-as-you-go.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and [pricing](https://www.aliyun.com/price/product#/mongodb/detail) of ApsaraDB for MongoDB.
         * Before you call this API operation, make sure that the ApsaraDB for MongoDB instance meets the following requirements:
         * *   The instance is in the Running state.
         * *   Your instance has no unpaid billing method change orders.
         * *   The instance type is available for purchase. For more information about unavailable instance types, see [Instance types](https://help.aliyun.com/document_detail/57141.html).
         * > To change the billing method of an instance whose instance type is no longer available to purchase, call the [ModifyDBInstanceSpec](https://help.aliyun.com/document_detail/61816.html) or [ModifyNodeSpec](https://help.aliyun.com/document_detail/61923.html) operation to first change the instance type.
         *
         * @param request TransformInstanceChargeTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TransformInstanceChargeTypeResponse
         */
        public TransformInstanceChargeTypeResponse TransformInstanceChargeTypeWithOptions(TransformInstanceChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransformInstanceChargeType",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransformInstanceChargeTypeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes the billing method of an instance from pay-as-you-go to subscription or from subscription to pay-as-you-go.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and [pricing](https://www.aliyun.com/price/product#/mongodb/detail) of ApsaraDB for MongoDB.
         * Before you call this API operation, make sure that the ApsaraDB for MongoDB instance meets the following requirements:
         * *   The instance is in the Running state.
         * *   Your instance has no unpaid billing method change orders.
         * *   The instance type is available for purchase. For more information about unavailable instance types, see [Instance types](https://help.aliyun.com/document_detail/57141.html).
         * > To change the billing method of an instance whose instance type is no longer available to purchase, call the [ModifyDBInstanceSpec](https://help.aliyun.com/document_detail/61816.html) or [ModifyNodeSpec](https://help.aliyun.com/document_detail/61923.html) operation to first change the instance type.
         *
         * @param request TransformInstanceChargeTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TransformInstanceChargeTypeResponse
         */
        public async Task<TransformInstanceChargeTypeResponse> TransformInstanceChargeTypeWithOptionsAsync(TransformInstanceChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransformInstanceChargeType",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransformInstanceChargeTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes the billing method of an instance from pay-as-you-go to subscription or from subscription to pay-as-you-go.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and [pricing](https://www.aliyun.com/price/product#/mongodb/detail) of ApsaraDB for MongoDB.
         * Before you call this API operation, make sure that the ApsaraDB for MongoDB instance meets the following requirements:
         * *   The instance is in the Running state.
         * *   Your instance has no unpaid billing method change orders.
         * *   The instance type is available for purchase. For more information about unavailable instance types, see [Instance types](https://help.aliyun.com/document_detail/57141.html).
         * > To change the billing method of an instance whose instance type is no longer available to purchase, call the [ModifyDBInstanceSpec](https://help.aliyun.com/document_detail/61816.html) or [ModifyNodeSpec](https://help.aliyun.com/document_detail/61923.html) operation to first change the instance type.
         *
         * @param request TransformInstanceChargeTypeRequest
         * @return TransformInstanceChargeTypeResponse
         */
        public TransformInstanceChargeTypeResponse TransformInstanceChargeType(TransformInstanceChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransformInstanceChargeTypeWithOptions(request, runtime);
        }

        /**
         * @summary Changes the billing method of an instance from pay-as-you-go to subscription or from subscription to pay-as-you-go.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and [pricing](https://www.aliyun.com/price/product#/mongodb/detail) of ApsaraDB for MongoDB.
         * Before you call this API operation, make sure that the ApsaraDB for MongoDB instance meets the following requirements:
         * *   The instance is in the Running state.
         * *   Your instance has no unpaid billing method change orders.
         * *   The instance type is available for purchase. For more information about unavailable instance types, see [Instance types](https://help.aliyun.com/document_detail/57141.html).
         * > To change the billing method of an instance whose instance type is no longer available to purchase, call the [ModifyDBInstanceSpec](https://help.aliyun.com/document_detail/61816.html) or [ModifyNodeSpec](https://help.aliyun.com/document_detail/61923.html) operation to first change the instance type.
         *
         * @param request TransformInstanceChargeTypeRequest
         * @return TransformInstanceChargeTypeResponse
         */
        public async Task<TransformInstanceChargeTypeResponse> TransformInstanceChargeTypeAsync(TransformInstanceChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransformInstanceChargeTypeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the billing method of an ApsaraDB for MongoDB instance from pay-as-you-go to subscription.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing).
         * A subscription instance cannot be changed to a pay-as-you-go instance. To avoid wasting resources, proceed with caution.
         * Before you call this API operation, make sure that the ApsaraDB for MongoDB instance meets the following requirements:
         * *   The instance is in the running state.
         * *   The billing method of the instance is pay-as-you-go.
         * *   The instance has no unpaid subscription orders.
         * *   The instance type is available for purchase. For more information about unavailable instance types, see [Instance types](https://help.aliyun.com/document_detail/57141.html).
         * >  To change the billing method of an instance whose instance type is no longer available to subscription, call the [ModifyDBInstanceSpec](https://help.aliyun.com/document_detail/61816.html) or [ModifyNodeSpec](https://help.aliyun.com/document_detail/61923.html) operation to first change the instance type.
         *
         * @param request TransformToPrePaidRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TransformToPrePaidResponse
         */
        public TransformToPrePaidResponse TransformToPrePaidWithOptions(TransformToPrePaidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransformToPrePaid",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransformToPrePaidResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes the billing method of an ApsaraDB for MongoDB instance from pay-as-you-go to subscription.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing).
         * A subscription instance cannot be changed to a pay-as-you-go instance. To avoid wasting resources, proceed with caution.
         * Before you call this API operation, make sure that the ApsaraDB for MongoDB instance meets the following requirements:
         * *   The instance is in the running state.
         * *   The billing method of the instance is pay-as-you-go.
         * *   The instance has no unpaid subscription orders.
         * *   The instance type is available for purchase. For more information about unavailable instance types, see [Instance types](https://help.aliyun.com/document_detail/57141.html).
         * >  To change the billing method of an instance whose instance type is no longer available to subscription, call the [ModifyDBInstanceSpec](https://help.aliyun.com/document_detail/61816.html) or [ModifyNodeSpec](https://help.aliyun.com/document_detail/61923.html) operation to first change the instance type.
         *
         * @param request TransformToPrePaidRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TransformToPrePaidResponse
         */
        public async Task<TransformToPrePaidResponse> TransformToPrePaidWithOptionsAsync(TransformToPrePaidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                query["BusinessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransformToPrePaid",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransformToPrePaidResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes the billing method of an ApsaraDB for MongoDB instance from pay-as-you-go to subscription.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing).
         * A subscription instance cannot be changed to a pay-as-you-go instance. To avoid wasting resources, proceed with caution.
         * Before you call this API operation, make sure that the ApsaraDB for MongoDB instance meets the following requirements:
         * *   The instance is in the running state.
         * *   The billing method of the instance is pay-as-you-go.
         * *   The instance has no unpaid subscription orders.
         * *   The instance type is available for purchase. For more information about unavailable instance types, see [Instance types](https://help.aliyun.com/document_detail/57141.html).
         * >  To change the billing method of an instance whose instance type is no longer available to subscription, call the [ModifyDBInstanceSpec](https://help.aliyun.com/document_detail/61816.html) or [ModifyNodeSpec](https://help.aliyun.com/document_detail/61923.html) operation to first change the instance type.
         *
         * @param request TransformToPrePaidRequest
         * @return TransformToPrePaidResponse
         */
        public TransformToPrePaidResponse TransformToPrePaid(TransformToPrePaidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransformToPrePaidWithOptions(request, runtime);
        }

        /**
         * @summary Changes the billing method of an ApsaraDB for MongoDB instance from pay-as-you-go to subscription.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and [pricing](https://www.alibabacloud.com/zh/product/apsaradb-for-mongodb/pricing).
         * A subscription instance cannot be changed to a pay-as-you-go instance. To avoid wasting resources, proceed with caution.
         * Before you call this API operation, make sure that the ApsaraDB for MongoDB instance meets the following requirements:
         * *   The instance is in the running state.
         * *   The billing method of the instance is pay-as-you-go.
         * *   The instance has no unpaid subscription orders.
         * *   The instance type is available for purchase. For more information about unavailable instance types, see [Instance types](https://help.aliyun.com/document_detail/57141.html).
         * >  To change the billing method of an instance whose instance type is no longer available to subscription, call the [ModifyDBInstanceSpec](https://help.aliyun.com/document_detail/61816.html) or [ModifyNodeSpec](https://help.aliyun.com/document_detail/61923.html) operation to first change the instance type.
         *
         * @param request TransformToPrePaidRequest
         * @return TransformToPrePaidResponse
         */
        public async Task<TransformToPrePaidResponse> TransformToPrePaidAsync(TransformToPrePaidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransformToPrePaidWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Removes a tag if the tag is not added to another instance.
         *
         * @description > 
         * *   You can remove up to 20 tags at a time.
         * *   If you remove a tag from all instances, the tag is automatically deleted.
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Version = "2015-12-01",
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
         * @summary Removes a tag if the tag is not added to another instance.
         *
         * @description > 
         * *   You can remove up to 20 tags at a time.
         * *   If you remove a tag from all instances, the tag is automatically deleted.
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Version = "2015-12-01",
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
         * @summary Removes a tag if the tag is not added to another instance.
         *
         * @description > 
         * *   You can remove up to 20 tags at a time.
         * *   If you remove a tag from all instances, the tag is automatically deleted.
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
         * @summary Removes a tag if the tag is not added to another instance.
         *
         * @description > 
         * *   You can remove up to 20 tags at a time.
         * *   If you remove a tag from all instances, the tag is automatically deleted.
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
         * @summary Upgrades the database version of an ApsaraDB for MongoDB instance.
         *
         * @description The instance must be in the running state when you call this operation.
         * > * The available database versions depend on the storage engine used by the instance. For more information, see [Upgrades of MongoDB major versions](https://help.aliyun.com/document_detail/398673.html). You can also call the [DescribeAvailableEngineVersion](https://help.aliyun.com/document_detail/141355.html) operation to query the available database versions.
         * > * You cannot downgrade the MongoDB version of an instance after you upgrade it.
         * > * The instance is automatically restarted for two to three times during the upgrade process. Make sure that you upgrade the instance during off-peak hours.
         *
         * @param request UpgradeDBInstanceEngineVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeDBInstanceEngineVersionResponse
         */
        public UpgradeDBInstanceEngineVersionResponse UpgradeDBInstanceEngineVersionWithOptions(UpgradeDBInstanceEngineVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeDBInstanceEngineVersion",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeDBInstanceEngineVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Upgrades the database version of an ApsaraDB for MongoDB instance.
         *
         * @description The instance must be in the running state when you call this operation.
         * > * The available database versions depend on the storage engine used by the instance. For more information, see [Upgrades of MongoDB major versions](https://help.aliyun.com/document_detail/398673.html). You can also call the [DescribeAvailableEngineVersion](https://help.aliyun.com/document_detail/141355.html) operation to query the available database versions.
         * > * You cannot downgrade the MongoDB version of an instance after you upgrade it.
         * > * The instance is automatically restarted for two to three times during the upgrade process. Make sure that you upgrade the instance during off-peak hours.
         *
         * @param request UpgradeDBInstanceEngineVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeDBInstanceEngineVersionResponse
         */
        public async Task<UpgradeDBInstanceEngineVersionResponse> UpgradeDBInstanceEngineVersionWithOptionsAsync(UpgradeDBInstanceEngineVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeDBInstanceEngineVersion",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeDBInstanceEngineVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Upgrades the database version of an ApsaraDB for MongoDB instance.
         *
         * @description The instance must be in the running state when you call this operation.
         * > * The available database versions depend on the storage engine used by the instance. For more information, see [Upgrades of MongoDB major versions](https://help.aliyun.com/document_detail/398673.html). You can also call the [DescribeAvailableEngineVersion](https://help.aliyun.com/document_detail/141355.html) operation to query the available database versions.
         * > * You cannot downgrade the MongoDB version of an instance after you upgrade it.
         * > * The instance is automatically restarted for two to three times during the upgrade process. Make sure that you upgrade the instance during off-peak hours.
         *
         * @param request UpgradeDBInstanceEngineVersionRequest
         * @return UpgradeDBInstanceEngineVersionResponse
         */
        public UpgradeDBInstanceEngineVersionResponse UpgradeDBInstanceEngineVersion(UpgradeDBInstanceEngineVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeDBInstanceEngineVersionWithOptions(request, runtime);
        }

        /**
         * @summary Upgrades the database version of an ApsaraDB for MongoDB instance.
         *
         * @description The instance must be in the running state when you call this operation.
         * > * The available database versions depend on the storage engine used by the instance. For more information, see [Upgrades of MongoDB major versions](https://help.aliyun.com/document_detail/398673.html). You can also call the [DescribeAvailableEngineVersion](https://help.aliyun.com/document_detail/141355.html) operation to query the available database versions.
         * > * You cannot downgrade the MongoDB version of an instance after you upgrade it.
         * > * The instance is automatically restarted for two to three times during the upgrade process. Make sure that you upgrade the instance during off-peak hours.
         *
         * @param request UpgradeDBInstanceEngineVersionRequest
         * @return UpgradeDBInstanceEngineVersionResponse
         */
        public async Task<UpgradeDBInstanceEngineVersionResponse> UpgradeDBInstanceEngineVersionAsync(UpgradeDBInstanceEngineVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeDBInstanceEngineVersionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Upgrades the minor version of an ApsaraDB for MongoDB instance.
         *
         * @description When you call the UpgradeDBInstanceKernelVersion operation, the instance must be in the Running state.
         * > * The UpgradeDBInstanceKernelVersion operation is applicable to replica set and sharded cluster instances, but not to standalone instances.
         * > * The instance will be restarted once during the upgrade. Call this operation during off-peak hours.
         *
         * @param request UpgradeDBInstanceKernelVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeDBInstanceKernelVersionResponse
         */
        public UpgradeDBInstanceKernelVersionResponse UpgradeDBInstanceKernelVersionWithOptions(UpgradeDBInstanceKernelVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeDBInstanceKernelVersion",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeDBInstanceKernelVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Upgrades the minor version of an ApsaraDB for MongoDB instance.
         *
         * @description When you call the UpgradeDBInstanceKernelVersion operation, the instance must be in the Running state.
         * > * The UpgradeDBInstanceKernelVersion operation is applicable to replica set and sharded cluster instances, but not to standalone instances.
         * > * The instance will be restarted once during the upgrade. Call this operation during off-peak hours.
         *
         * @param request UpgradeDBInstanceKernelVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeDBInstanceKernelVersionResponse
         */
        public async Task<UpgradeDBInstanceKernelVersionResponse> UpgradeDBInstanceKernelVersionWithOptionsAsync(UpgradeDBInstanceKernelVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeDBInstanceKernelVersion",
                Version = "2015-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeDBInstanceKernelVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Upgrades the minor version of an ApsaraDB for MongoDB instance.
         *
         * @description When you call the UpgradeDBInstanceKernelVersion operation, the instance must be in the Running state.
         * > * The UpgradeDBInstanceKernelVersion operation is applicable to replica set and sharded cluster instances, but not to standalone instances.
         * > * The instance will be restarted once during the upgrade. Call this operation during off-peak hours.
         *
         * @param request UpgradeDBInstanceKernelVersionRequest
         * @return UpgradeDBInstanceKernelVersionResponse
         */
        public UpgradeDBInstanceKernelVersionResponse UpgradeDBInstanceKernelVersion(UpgradeDBInstanceKernelVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeDBInstanceKernelVersionWithOptions(request, runtime);
        }

        /**
         * @summary Upgrades the minor version of an ApsaraDB for MongoDB instance.
         *
         * @description When you call the UpgradeDBInstanceKernelVersion operation, the instance must be in the Running state.
         * > * The UpgradeDBInstanceKernelVersion operation is applicable to replica set and sharded cluster instances, but not to standalone instances.
         * > * The instance will be restarted once during the upgrade. Call this operation during off-peak hours.
         *
         * @param request UpgradeDBInstanceKernelVersionRequest
         * @return UpgradeDBInstanceKernelVersionResponse
         */
        public async Task<UpgradeDBInstanceKernelVersionResponse> UpgradeDBInstanceKernelVersionAsync(UpgradeDBInstanceKernelVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeDBInstanceKernelVersionWithOptionsAsync(request, runtime);
        }

    }
}
