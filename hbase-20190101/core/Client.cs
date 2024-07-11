// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.HBase20190101.Models;

namespace AlibabaCloud.SDK.HBase20190101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-southeast-1", "hbase.aliyuncs.com"},
                {"cn-beijing", "hbase.aliyuncs.com"},
                {"cn-hangzhou", "hbase.aliyuncs.com"},
                {"cn-hangzhou-finance", "hbase.aliyuncs.com"},
                {"cn-hongkong", "hbase.aliyuncs.com"},
                {"cn-north-2-gov-1", "hbase.aliyuncs.com"},
                {"cn-qingdao", "hbase.aliyuncs.com"},
                {"cn-shanghai", "hbase.aliyuncs.com"},
                {"cn-shanghai-finance-1", "hbase.aliyuncs.com"},
                {"cn-shenzhen", "hbase.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "hbase.aliyuncs.com"},
                {"cn-guangzhou", "hbase.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("hbase", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @param request AddUserHdfsInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddUserHdfsInfoResponse
         */
        public AddUserHdfsInfoResponse AddUserHdfsInfoWithOptions(AddUserHdfsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                query["ExtInfo"] = request.ExtInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserHdfsInfo",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserHdfsInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request AddUserHdfsInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddUserHdfsInfoResponse
         */
        public async Task<AddUserHdfsInfoResponse> AddUserHdfsInfoWithOptionsAsync(AddUserHdfsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                query["ExtInfo"] = request.ExtInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserHdfsInfo",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserHdfsInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request AddUserHdfsInfoRequest
         * @return AddUserHdfsInfoResponse
         */
        public AddUserHdfsInfoResponse AddUserHdfsInfo(AddUserHdfsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUserHdfsInfoWithOptions(request, runtime);
        }

        /**
         * @param request AddUserHdfsInfoRequest
         * @return AddUserHdfsInfoResponse
         */
        public async Task<AddUserHdfsInfoResponse> AddUserHdfsInfoAsync(AddUserHdfsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUserHdfsInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @param request AllocatePublicNetworkAddressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AllocatePublicNetworkAddressResponse
         */
        public AllocatePublicNetworkAddressResponse AllocatePublicNetworkAddressWithOptions(AllocatePublicNetworkAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AllocatePublicNetworkAddress",
                Version = "2019-01-01",
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
         * @param request AllocatePublicNetworkAddressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AllocatePublicNetworkAddressResponse
         */
        public async Task<AllocatePublicNetworkAddressResponse> AllocatePublicNetworkAddressWithOptionsAsync(AllocatePublicNetworkAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AllocatePublicNetworkAddress",
                Version = "2019-01-01",
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
         * @param request AllocatePublicNetworkAddressRequest
         * @return AllocatePublicNetworkAddressResponse
         */
        public AllocatePublicNetworkAddressResponse AllocatePublicNetworkAddress(AllocatePublicNetworkAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocatePublicNetworkAddressWithOptions(request, runtime);
        }

        /**
         * @param request AllocatePublicNetworkAddressRequest
         * @return AllocatePublicNetworkAddressResponse
         */
        public async Task<AllocatePublicNetworkAddressResponse> AllocatePublicNetworkAddressAsync(AllocatePublicNetworkAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocatePublicNetworkAddressWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CancelActiveOperationTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelActiveOperationTasksResponse
         */
        public CancelActiveOperationTasksResponse CancelActiveOperationTasksWithOptions(CancelActiveOperationTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["Ids"] = request.Ids;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelActiveOperationTasks",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelActiveOperationTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CancelActiveOperationTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelActiveOperationTasksResponse
         */
        public async Task<CancelActiveOperationTasksResponse> CancelActiveOperationTasksWithOptionsAsync(CancelActiveOperationTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["Ids"] = request.Ids;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelActiveOperationTasks",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelActiveOperationTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CancelActiveOperationTasksRequest
         * @return CancelActiveOperationTasksResponse
         */
        public CancelActiveOperationTasksResponse CancelActiveOperationTasks(CancelActiveOperationTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelActiveOperationTasksWithOptions(request, runtime);
        }

        /**
         * @param request CancelActiveOperationTasksRequest
         * @return CancelActiveOperationTasksResponse
         */
        public async Task<CancelActiveOperationTasksResponse> CancelActiveOperationTasksAsync(CancelActiveOperationTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelActiveOperationTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CheckComponentsVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckComponentsVersionResponse
         */
        public CheckComponentsVersionResponse CheckComponentsVersionWithOptions(CheckComponentsVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Components))
            {
                query["Components"] = request.Components;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckComponentsVersion",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckComponentsVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CheckComponentsVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckComponentsVersionResponse
         */
        public async Task<CheckComponentsVersionResponse> CheckComponentsVersionWithOptionsAsync(CheckComponentsVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Components))
            {
                query["Components"] = request.Components;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckComponentsVersion",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckComponentsVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CheckComponentsVersionRequest
         * @return CheckComponentsVersionResponse
         */
        public CheckComponentsVersionResponse CheckComponentsVersion(CheckComponentsVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckComponentsVersionWithOptions(request, runtime);
        }

        /**
         * @param request CheckComponentsVersionRequest
         * @return CheckComponentsVersionResponse
         */
        public async Task<CheckComponentsVersionResponse> CheckComponentsVersionAsync(CheckComponentsVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckComponentsVersionWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CloseBackupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloseBackupResponse
         */
        public CloseBackupResponse CloseBackupWithOptions(CloseBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseBackup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseBackupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CloseBackupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloseBackupResponse
         */
        public async Task<CloseBackupResponse> CloseBackupWithOptionsAsync(CloseBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseBackup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseBackupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CloseBackupRequest
         * @return CloseBackupResponse
         */
        public CloseBackupResponse CloseBackup(CloseBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloseBackupWithOptions(request, runtime);
        }

        /**
         * @param request CloseBackupRequest
         * @return CloseBackupResponse
         */
        public async Task<CloseBackupResponse> CloseBackupAsync(CloseBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloseBackupWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ConvertInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConvertInstanceResponse
         */
        public ConvertInstanceResponse ConvertInstanceWithOptions(ConvertInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConvertInstance",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ConvertInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConvertInstanceResponse
         */
        public async Task<ConvertInstanceResponse> ConvertInstanceWithOptionsAsync(ConvertInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConvertInstance",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ConvertInstanceRequest
         * @return ConvertInstanceResponse
         */
        public ConvertInstanceResponse ConvertInstance(ConvertInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConvertInstanceWithOptions(request, runtime);
        }

        /**
         * @param request ConvertInstanceRequest
         * @return ConvertInstanceResponse
         */
        public async Task<ConvertInstanceResponse> ConvertInstanceAsync(ConvertInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConvertInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 新建账户
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccount",
                Version = "2019-01-01",
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
         * @summary 新建账户
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccount",
                Version = "2019-01-01",
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
         * @summary 新建账户
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
         * @summary 新建账户
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
         * @param request CreateBackupPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateBackupPlanResponse
         */
        public CreateBackupPlanResponse CreateBackupPlanWithOptions(CreateBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBackupPlan",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBackupPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateBackupPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateBackupPlanResponse
         */
        public async Task<CreateBackupPlanResponse> CreateBackupPlanWithOptionsAsync(CreateBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBackupPlan",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBackupPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateBackupPlanRequest
         * @return CreateBackupPlanResponse
         */
        public CreateBackupPlanResponse CreateBackupPlan(CreateBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBackupPlanWithOptions(request, runtime);
        }

        /**
         * @param request CreateBackupPlanRequest
         * @return CreateBackupPlanResponse
         */
        public async Task<CreateBackupPlanResponse> CreateBackupPlanAsync(CreateBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBackupPlanWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateClusterResponse
         */
        public CreateClusterResponse CreateClusterWithOptions(CreateClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColdStorageSize))
            {
                query["ColdStorageSize"] = request.ColdStorageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreInstanceType))
            {
                query["CoreInstanceType"] = request.CoreInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterInstanceType))
            {
                query["MasterInstanceType"] = request.MasterInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeCount))
            {
                query["NodeCount"] = request.NodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIPList))
            {
                query["SecurityIPList"] = request.SecurityIPList;
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
                Action = "CreateCluster",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateClusterResponse
         */
        public async Task<CreateClusterResponse> CreateClusterWithOptionsAsync(CreateClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColdStorageSize))
            {
                query["ColdStorageSize"] = request.ColdStorageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreInstanceType))
            {
                query["CoreInstanceType"] = request.CoreInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterInstanceType))
            {
                query["MasterInstanceType"] = request.MasterInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeCount))
            {
                query["NodeCount"] = request.NodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIPList))
            {
                query["SecurityIPList"] = request.SecurityIPList;
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
                Action = "CreateCluster",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateClusterRequest
         * @return CreateClusterResponse
         */
        public CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClusterWithOptions(request, runtime);
        }

        /**
         * @param request CreateClusterRequest
         * @return CreateClusterResponse
         */
        public async Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateGlobalResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGlobalResourceResponse
         */
        public CreateGlobalResourceResponse CreateGlobalResourceWithOptions(CreateGlobalResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
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
                Action = "CreateGlobalResource",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGlobalResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateGlobalResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGlobalResourceResponse
         */
        public async Task<CreateGlobalResourceResponse> CreateGlobalResourceWithOptionsAsync(CreateGlobalResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
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
                Action = "CreateGlobalResource",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGlobalResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateGlobalResourceRequest
         * @return CreateGlobalResourceResponse
         */
        public CreateGlobalResourceResponse CreateGlobalResource(CreateGlobalResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGlobalResourceWithOptions(request, runtime);
        }

        /**
         * @param request CreateGlobalResourceRequest
         * @return CreateGlobalResourceResponse
         */
        public async Task<CreateGlobalResourceResponse> CreateGlobalResourceAsync(CreateGlobalResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGlobalResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateHBaseSlbServerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateHBaseSlbServerResponse
         */
        public CreateHBaseSlbServerResponse CreateHBaseSlbServerWithOptions(CreateHBaseSlbServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbServer))
            {
                query["SlbServer"] = request.SlbServer;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHBaseSlbServer",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHBaseSlbServerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateHBaseSlbServerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateHBaseSlbServerResponse
         */
        public async Task<CreateHBaseSlbServerResponse> CreateHBaseSlbServerWithOptionsAsync(CreateHBaseSlbServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbServer))
            {
                query["SlbServer"] = request.SlbServer;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHBaseSlbServer",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHBaseSlbServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateHBaseSlbServerRequest
         * @return CreateHBaseSlbServerResponse
         */
        public CreateHBaseSlbServerResponse CreateHBaseSlbServer(CreateHBaseSlbServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHBaseSlbServerWithOptions(request, runtime);
        }

        /**
         * @param request CreateHBaseSlbServerRequest
         * @return CreateHBaseSlbServerResponse
         */
        public async Task<CreateHBaseSlbServerResponse> CreateHBaseSlbServerAsync(CreateHBaseSlbServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHBaseSlbServerWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateHbaseHaSlbRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateHbaseHaSlbResponse
         */
        public CreateHbaseHaSlbResponse CreateHbaseHaSlbWithOptions(CreateHbaseHaSlbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BdsId))
            {
                query["BdsId"] = request.BdsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaId))
            {
                query["HaId"] = request.HaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaTypes))
            {
                query["HaTypes"] = request.HaTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HbaseType))
            {
                query["HbaseType"] = request.HbaseType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHbaseHaSlb",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHbaseHaSlbResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateHbaseHaSlbRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateHbaseHaSlbResponse
         */
        public async Task<CreateHbaseHaSlbResponse> CreateHbaseHaSlbWithOptionsAsync(CreateHbaseHaSlbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BdsId))
            {
                query["BdsId"] = request.BdsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaId))
            {
                query["HaId"] = request.HaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaTypes))
            {
                query["HaTypes"] = request.HaTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HbaseType))
            {
                query["HbaseType"] = request.HbaseType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHbaseHaSlb",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHbaseHaSlbResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateHbaseHaSlbRequest
         * @return CreateHbaseHaSlbResponse
         */
        public CreateHbaseHaSlbResponse CreateHbaseHaSlb(CreateHbaseHaSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHbaseHaSlbWithOptions(request, runtime);
        }

        /**
         * @param request CreateHbaseHaSlbRequest
         * @return CreateHbaseHaSlbResponse
         */
        public async Task<CreateHbaseHaSlbResponse> CreateHbaseHaSlbAsync(CreateHbaseHaSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHbaseHaSlbWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateMultiZoneClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMultiZoneClusterResponse
         */
        public CreateMultiZoneClusterResponse CreateMultiZoneClusterWithOptions(CreateMultiZoneClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArbiterVSwitchId))
            {
                query["ArbiterVSwitchId"] = request.ArbiterVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArbiterZoneId))
            {
                query["ArbiterZoneId"] = request.ArbiterZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArchVersion))
            {
                query["ArchVersion"] = request.ArchVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreDiskSize))
            {
                query["CoreDiskSize"] = request.CoreDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreDiskType))
            {
                query["CoreDiskType"] = request.CoreDiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreInstanceType))
            {
                query["CoreInstanceType"] = request.CoreInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreNodeCount))
            {
                query["CoreNodeCount"] = request.CoreNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogDiskSize))
            {
                query["LogDiskSize"] = request.LogDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogDiskType))
            {
                query["LogDiskType"] = request.LogDiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogInstanceType))
            {
                query["LogInstanceType"] = request.LogInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogNodeCount))
            {
                query["LogNodeCount"] = request.LogNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterInstanceType))
            {
                query["MasterInstanceType"] = request.MasterInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiZoneCombination))
            {
                query["MultiZoneCombination"] = request.MultiZoneCombination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryVSwitchId))
            {
                query["PrimaryVSwitchId"] = request.PrimaryVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryZoneId))
            {
                query["PrimaryZoneId"] = request.PrimaryZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIPList))
            {
                query["SecurityIPList"] = request.SecurityIPList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandbyVSwitchId))
            {
                query["StandbyVSwitchId"] = request.StandbyVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandbyZoneId))
            {
                query["StandbyZoneId"] = request.StandbyZoneId;
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
                Action = "CreateMultiZoneCluster",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMultiZoneClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateMultiZoneClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMultiZoneClusterResponse
         */
        public async Task<CreateMultiZoneClusterResponse> CreateMultiZoneClusterWithOptionsAsync(CreateMultiZoneClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArbiterVSwitchId))
            {
                query["ArbiterVSwitchId"] = request.ArbiterVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArbiterZoneId))
            {
                query["ArbiterZoneId"] = request.ArbiterZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArchVersion))
            {
                query["ArchVersion"] = request.ArchVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreDiskSize))
            {
                query["CoreDiskSize"] = request.CoreDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreDiskType))
            {
                query["CoreDiskType"] = request.CoreDiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreInstanceType))
            {
                query["CoreInstanceType"] = request.CoreInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreNodeCount))
            {
                query["CoreNodeCount"] = request.CoreNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogDiskSize))
            {
                query["LogDiskSize"] = request.LogDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogDiskType))
            {
                query["LogDiskType"] = request.LogDiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogInstanceType))
            {
                query["LogInstanceType"] = request.LogInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogNodeCount))
            {
                query["LogNodeCount"] = request.LogNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterInstanceType))
            {
                query["MasterInstanceType"] = request.MasterInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiZoneCombination))
            {
                query["MultiZoneCombination"] = request.MultiZoneCombination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryVSwitchId))
            {
                query["PrimaryVSwitchId"] = request.PrimaryVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryZoneId))
            {
                query["PrimaryZoneId"] = request.PrimaryZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIPList))
            {
                query["SecurityIPList"] = request.SecurityIPList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandbyVSwitchId))
            {
                query["StandbyVSwitchId"] = request.StandbyVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandbyZoneId))
            {
                query["StandbyZoneId"] = request.StandbyZoneId;
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
                Action = "CreateMultiZoneCluster",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMultiZoneClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateMultiZoneClusterRequest
         * @return CreateMultiZoneClusterResponse
         */
        public CreateMultiZoneClusterResponse CreateMultiZoneCluster(CreateMultiZoneClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMultiZoneClusterWithOptions(request, runtime);
        }

        /**
         * @param request CreateMultiZoneClusterRequest
         * @return CreateMultiZoneClusterResponse
         */
        public async Task<CreateMultiZoneClusterResponse> CreateMultiZoneClusterAsync(CreateMultiZoneClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMultiZoneClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateRestorePlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRestorePlanResponse
         */
        public CreateRestorePlanResponse CreateRestorePlanWithOptions(CreateRestorePlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreAllTable))
            {
                query["RestoreAllTable"] = request.RestoreAllTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreByCopy))
            {
                query["RestoreByCopy"] = request.RestoreByCopy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreToDate))
            {
                query["RestoreToDate"] = request.RestoreToDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tables))
            {
                query["Tables"] = request.Tables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetClusterId))
            {
                query["TargetClusterId"] = request.TargetClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRestorePlan",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRestorePlanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateRestorePlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRestorePlanResponse
         */
        public async Task<CreateRestorePlanResponse> CreateRestorePlanWithOptionsAsync(CreateRestorePlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreAllTable))
            {
                query["RestoreAllTable"] = request.RestoreAllTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreByCopy))
            {
                query["RestoreByCopy"] = request.RestoreByCopy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreToDate))
            {
                query["RestoreToDate"] = request.RestoreToDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tables))
            {
                query["Tables"] = request.Tables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetClusterId))
            {
                query["TargetClusterId"] = request.TargetClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRestorePlan",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRestorePlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateRestorePlanRequest
         * @return CreateRestorePlanResponse
         */
        public CreateRestorePlanResponse CreateRestorePlan(CreateRestorePlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRestorePlanWithOptions(request, runtime);
        }

        /**
         * @param request CreateRestorePlanRequest
         * @return CreateRestorePlanResponse
         */
        public async Task<CreateRestorePlanResponse> CreateRestorePlanAsync(CreateRestorePlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRestorePlanWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateServerlessClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServerlessClusterResponse
         */
        public CreateServerlessClusterResponse CreateServerlessClusterWithOptions(CreateServerlessClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessCapability))
            {
                query["ServerlessCapability"] = request.ServerlessCapability;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessSpec))
            {
                query["ServerlessSpec"] = request.ServerlessSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessStorage))
            {
                query["ServerlessStorage"] = request.ServerlessStorage;
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
                Action = "CreateServerlessCluster",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServerlessClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateServerlessClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServerlessClusterResponse
         */
        public async Task<CreateServerlessClusterResponse> CreateServerlessClusterWithOptionsAsync(CreateServerlessClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessCapability))
            {
                query["ServerlessCapability"] = request.ServerlessCapability;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessSpec))
            {
                query["ServerlessSpec"] = request.ServerlessSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessStorage))
            {
                query["ServerlessStorage"] = request.ServerlessStorage;
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
                Action = "CreateServerlessCluster",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServerlessClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateServerlessClusterRequest
         * @return CreateServerlessClusterResponse
         */
        public CreateServerlessClusterResponse CreateServerlessCluster(CreateServerlessClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServerlessClusterWithOptions(request, runtime);
        }

        /**
         * @param request CreateServerlessClusterRequest
         * @return CreateServerlessClusterResponse
         */
        public async Task<CreateServerlessClusterResponse> CreateServerlessClusterAsync(CreateServerlessClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServerlessClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除账户
         *
         * @param request DeleteAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAccountResponse
         */
        public DeleteAccountResponse DeleteAccountWithOptions(DeleteAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccount",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除账户
         *
         * @param request DeleteAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAccountResponse
         */
        public async Task<DeleteAccountResponse> DeleteAccountWithOptionsAsync(DeleteAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccount",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除账户
         *
         * @param request DeleteAccountRequest
         * @return DeleteAccountResponse
         */
        public DeleteAccountResponse DeleteAccount(DeleteAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccountWithOptions(request, runtime);
        }

        /**
         * @summary 删除账户
         *
         * @param request DeleteAccountRequest
         * @return DeleteAccountResponse
         */
        public async Task<DeleteAccountResponse> DeleteAccountAsync(DeleteAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteGlobalResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGlobalResourceResponse
         */
        public DeleteGlobalResourceResponse DeleteGlobalResourceWithOptions(DeleteGlobalResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
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
                Action = "DeleteGlobalResource",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGlobalResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteGlobalResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGlobalResourceResponse
         */
        public async Task<DeleteGlobalResourceResponse> DeleteGlobalResourceWithOptionsAsync(DeleteGlobalResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
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
                Action = "DeleteGlobalResource",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGlobalResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteGlobalResourceRequest
         * @return DeleteGlobalResourceResponse
         */
        public DeleteGlobalResourceResponse DeleteGlobalResource(DeleteGlobalResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGlobalResourceWithOptions(request, runtime);
        }

        /**
         * @param request DeleteGlobalResourceRequest
         * @return DeleteGlobalResourceResponse
         */
        public async Task<DeleteGlobalResourceResponse> DeleteGlobalResourceAsync(DeleteGlobalResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGlobalResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteHBaseHaDBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteHBaseHaDBResponse
         */
        public DeleteHBaseHaDBResponse DeleteHBaseHaDBWithOptions(DeleteHBaseHaDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BdsId))
            {
                query["BdsId"] = request.BdsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaId))
            {
                query["HaId"] = request.HaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHBaseHaDB",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHBaseHaDBResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteHBaseHaDBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteHBaseHaDBResponse
         */
        public async Task<DeleteHBaseHaDBResponse> DeleteHBaseHaDBWithOptionsAsync(DeleteHBaseHaDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BdsId))
            {
                query["BdsId"] = request.BdsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaId))
            {
                query["HaId"] = request.HaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHBaseHaDB",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHBaseHaDBResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteHBaseHaDBRequest
         * @return DeleteHBaseHaDBResponse
         */
        public DeleteHBaseHaDBResponse DeleteHBaseHaDB(DeleteHBaseHaDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHBaseHaDBWithOptions(request, runtime);
        }

        /**
         * @param request DeleteHBaseHaDBRequest
         * @return DeleteHBaseHaDBResponse
         */
        public async Task<DeleteHBaseHaDBResponse> DeleteHBaseHaDBAsync(DeleteHBaseHaDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHBaseHaDBWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteHBaseSlbServerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteHBaseSlbServerResponse
         */
        public DeleteHBaseSlbServerResponse DeleteHBaseSlbServerWithOptions(DeleteHBaseSlbServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbServer))
            {
                query["SlbServer"] = request.SlbServer;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHBaseSlbServer",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHBaseSlbServerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteHBaseSlbServerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteHBaseSlbServerResponse
         */
        public async Task<DeleteHBaseSlbServerResponse> DeleteHBaseSlbServerWithOptionsAsync(DeleteHBaseSlbServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbServer))
            {
                query["SlbServer"] = request.SlbServer;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHBaseSlbServer",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHBaseSlbServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteHBaseSlbServerRequest
         * @return DeleteHBaseSlbServerResponse
         */
        public DeleteHBaseSlbServerResponse DeleteHBaseSlbServer(DeleteHBaseSlbServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHBaseSlbServerWithOptions(request, runtime);
        }

        /**
         * @param request DeleteHBaseSlbServerRequest
         * @return DeleteHBaseSlbServerResponse
         */
        public async Task<DeleteHBaseSlbServerResponse> DeleteHBaseSlbServerAsync(DeleteHBaseSlbServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHBaseSlbServerWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteHbaseHaSlbRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteHbaseHaSlbResponse
         */
        public DeleteHbaseHaSlbResponse DeleteHbaseHaSlbWithOptions(DeleteHbaseHaSlbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BdsId))
            {
                query["BdsId"] = request.BdsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaId))
            {
                query["HaId"] = request.HaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaTypes))
            {
                query["HaTypes"] = request.HaTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHbaseHaSlb",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHbaseHaSlbResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteHbaseHaSlbRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteHbaseHaSlbResponse
         */
        public async Task<DeleteHbaseHaSlbResponse> DeleteHbaseHaSlbWithOptionsAsync(DeleteHbaseHaSlbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BdsId))
            {
                query["BdsId"] = request.BdsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaId))
            {
                query["HaId"] = request.HaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaTypes))
            {
                query["HaTypes"] = request.HaTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHbaseHaSlb",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHbaseHaSlbResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteHbaseHaSlbRequest
         * @return DeleteHbaseHaSlbResponse
         */
        public DeleteHbaseHaSlbResponse DeleteHbaseHaSlb(DeleteHbaseHaSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHbaseHaSlbWithOptions(request, runtime);
        }

        /**
         * @param request DeleteHbaseHaSlbRequest
         * @return DeleteHbaseHaSlbResponse
         */
        public async Task<DeleteHbaseHaSlbResponse> DeleteHbaseHaSlbAsync(DeleteHbaseHaSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHbaseHaSlbWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceResponse
         */
        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImmediateDeleteFlag))
            {
                query["ImmediateDeleteFlag"] = request.ImmediateDeleteFlag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceResponse
         */
        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImmediateDeleteFlag))
            {
                query["ImmediateDeleteFlag"] = request.ImmediateDeleteFlag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteInstanceRequest
         * @return DeleteInstanceResponse
         */
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceWithOptions(request, runtime);
        }

        /**
         * @param request DeleteInstanceRequest
         * @return DeleteInstanceResponse
         */
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteMultiZoneClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMultiZoneClusterResponse
         */
        public DeleteMultiZoneClusterResponse DeleteMultiZoneClusterWithOptions(DeleteMultiZoneClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImmediateDeleteFlag))
            {
                query["ImmediateDeleteFlag"] = request.ImmediateDeleteFlag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMultiZoneCluster",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMultiZoneClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteMultiZoneClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMultiZoneClusterResponse
         */
        public async Task<DeleteMultiZoneClusterResponse> DeleteMultiZoneClusterWithOptionsAsync(DeleteMultiZoneClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImmediateDeleteFlag))
            {
                query["ImmediateDeleteFlag"] = request.ImmediateDeleteFlag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMultiZoneCluster",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMultiZoneClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteMultiZoneClusterRequest
         * @return DeleteMultiZoneClusterResponse
         */
        public DeleteMultiZoneClusterResponse DeleteMultiZoneCluster(DeleteMultiZoneClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMultiZoneClusterWithOptions(request, runtime);
        }

        /**
         * @param request DeleteMultiZoneClusterRequest
         * @return DeleteMultiZoneClusterResponse
         */
        public async Task<DeleteMultiZoneClusterResponse> DeleteMultiZoneClusterAsync(DeleteMultiZoneClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMultiZoneClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteServerlessClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServerlessClusterResponse
         */
        public DeleteServerlessClusterResponse DeleteServerlessClusterWithOptions(DeleteServerlessClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DeleteServerlessCluster",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServerlessClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteServerlessClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServerlessClusterResponse
         */
        public async Task<DeleteServerlessClusterResponse> DeleteServerlessClusterWithOptionsAsync(DeleteServerlessClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DeleteServerlessCluster",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServerlessClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteServerlessClusterRequest
         * @return DeleteServerlessClusterResponse
         */
        public DeleteServerlessClusterResponse DeleteServerlessCluster(DeleteServerlessClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteServerlessClusterWithOptions(request, runtime);
        }

        /**
         * @param request DeleteServerlessClusterRequest
         * @return DeleteServerlessClusterResponse
         */
        public async Task<DeleteServerlessClusterResponse> DeleteServerlessClusterAsync(DeleteServerlessClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteServerlessClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteUserHdfsInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserHdfsInfoResponse
         */
        public DeleteUserHdfsInfoResponse DeleteUserHdfsInfoWithOptions(DeleteUserHdfsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameService))
            {
                query["NameService"] = request.NameService;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserHdfsInfo",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserHdfsInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteUserHdfsInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserHdfsInfoResponse
         */
        public async Task<DeleteUserHdfsInfoResponse> DeleteUserHdfsInfoWithOptionsAsync(DeleteUserHdfsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameService))
            {
                query["NameService"] = request.NameService;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserHdfsInfo",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserHdfsInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteUserHdfsInfoRequest
         * @return DeleteUserHdfsInfoResponse
         */
        public DeleteUserHdfsInfoResponse DeleteUserHdfsInfo(DeleteUserHdfsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserHdfsInfoWithOptions(request, runtime);
        }

        /**
         * @param request DeleteUserHdfsInfoRequest
         * @return DeleteUserHdfsInfoResponse
         */
        public async Task<DeleteUserHdfsInfoResponse> DeleteUserHdfsInfoAsync(DeleteUserHdfsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserHdfsInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询账户列表
         *
         * @param request DescribeAccountsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccountsResponse
         */
        public DescribeAccountsResponse DescribeAccountsWithOptions(DescribeAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccounts",
                Version = "2019-01-01",
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
         * @summary 查询账户列表
         *
         * @param request DescribeAccountsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccountsResponse
         */
        public async Task<DescribeAccountsResponse> DescribeAccountsWithOptionsAsync(DescribeAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccounts",
                Version = "2019-01-01",
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
         * @summary 查询账户列表
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
         * @summary 查询账户列表
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
                Action = "DescribeActiveOperationTaskType",
                Version = "2019-01-01",
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
                Action = "DescribeActiveOperationTaskType",
                Version = "2019-01-01",
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
         * @param request DescribeActiveOperationTaskTypeRequest
         * @return DescribeActiveOperationTaskTypeResponse
         */
        public DescribeActiveOperationTaskTypeResponse DescribeActiveOperationTaskType(DescribeActiveOperationTaskTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeActiveOperationTaskTypeWithOptions(request, runtime);
        }

        /**
         * @param request DescribeActiveOperationTaskTypeRequest
         * @return DescribeActiveOperationTaskTypeResponse
         */
        public async Task<DescribeActiveOperationTaskTypeResponse> DescribeActiveOperationTaskTypeAsync(DescribeActiveOperationTaskTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeActiveOperationTaskTypeWithOptionsAsync(request, runtime);
        }

        /**
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
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
                Version = "2019-01-01",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
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
                Version = "2019-01-01",
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
         * @param request DescribeActiveOperationTasksRequest
         * @return DescribeActiveOperationTasksResponse
         */
        public DescribeActiveOperationTasksResponse DescribeActiveOperationTasks(DescribeActiveOperationTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeActiveOperationTasksWithOptions(request, runtime);
        }

        /**
         * @param request DescribeActiveOperationTasksRequest
         * @return DescribeActiveOperationTasksResponse
         */
        public async Task<DescribeActiveOperationTasksResponse> DescribeActiveOperationTasksAsync(DescribeActiveOperationTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeActiveOperationTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAvailableResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAvailableResourceResponse
         */
        public DescribeAvailableResourceResponse DescribeAvailableResourceWithOptions(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreInstanceType))
            {
                query["CoreInstanceType"] = request.CoreInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Version = "2019-01-01",
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
         * @param request DescribeAvailableResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAvailableResourceResponse
         */
        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceWithOptionsAsync(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreInstanceType))
            {
                query["CoreInstanceType"] = request.CoreInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Version = "2019-01-01",
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
         * @param request DescribeAvailableResourceRequest
         * @return DescribeAvailableResourceResponse
         */
        public DescribeAvailableResourceResponse DescribeAvailableResource(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableResourceWithOptions(request, runtime);
        }

        /**
         * @param request DescribeAvailableResourceRequest
         * @return DescribeAvailableResourceResponse
         */
        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceAsync(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeBackupPlanConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupPlanConfigResponse
         */
        public DescribeBackupPlanConfigResponse DescribeBackupPlanConfigWithOptions(DescribeBackupPlanConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupPlanConfig",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupPlanConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeBackupPlanConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupPlanConfigResponse
         */
        public async Task<DescribeBackupPlanConfigResponse> DescribeBackupPlanConfigWithOptionsAsync(DescribeBackupPlanConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupPlanConfig",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupPlanConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeBackupPlanConfigRequest
         * @return DescribeBackupPlanConfigResponse
         */
        public DescribeBackupPlanConfigResponse DescribeBackupPlanConfig(DescribeBackupPlanConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupPlanConfigWithOptions(request, runtime);
        }

        /**
         * @param request DescribeBackupPlanConfigRequest
         * @return DescribeBackupPlanConfigResponse
         */
        public async Task<DescribeBackupPlanConfigResponse> DescribeBackupPlanConfigAsync(DescribeBackupPlanConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupPlanConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeBackupPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupPolicyResponse
         */
        public DescribeBackupPolicyResponse DescribeBackupPolicyWithOptions(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupPolicy",
                Version = "2019-01-01",
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
         * @param request DescribeBackupPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupPolicyResponse
         */
        public async Task<DescribeBackupPolicyResponse> DescribeBackupPolicyWithOptionsAsync(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupPolicy",
                Version = "2019-01-01",
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
         * @param request DescribeBackupPolicyRequest
         * @return DescribeBackupPolicyResponse
         */
        public DescribeBackupPolicyResponse DescribeBackupPolicy(DescribeBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupPolicyWithOptions(request, runtime);
        }

        /**
         * @param request DescribeBackupPolicyRequest
         * @return DescribeBackupPolicyResponse
         */
        public async Task<DescribeBackupPolicyResponse> DescribeBackupPolicyAsync(DescribeBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeBackupStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupStatusResponse
         */
        public DescribeBackupStatusResponse DescribeBackupStatusWithOptions(DescribeBackupStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupStatus",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeBackupStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupStatusResponse
         */
        public async Task<DescribeBackupStatusResponse> DescribeBackupStatusWithOptionsAsync(DescribeBackupStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupStatus",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeBackupStatusRequest
         * @return DescribeBackupStatusResponse
         */
        public DescribeBackupStatusResponse DescribeBackupStatus(DescribeBackupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupStatusWithOptions(request, runtime);
        }

        /**
         * @param request DescribeBackupStatusRequest
         * @return DescribeBackupStatusResponse
         */
        public async Task<DescribeBackupStatusResponse> DescribeBackupStatusAsync(DescribeBackupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeBackupSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupSummaryResponse
         */
        public DescribeBackupSummaryResponse DescribeBackupSummaryWithOptions(DescribeBackupSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupSummary",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupSummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeBackupSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupSummaryResponse
         */
        public async Task<DescribeBackupSummaryResponse> DescribeBackupSummaryWithOptionsAsync(DescribeBackupSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupSummary",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeBackupSummaryRequest
         * @return DescribeBackupSummaryResponse
         */
        public DescribeBackupSummaryResponse DescribeBackupSummary(DescribeBackupSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupSummaryWithOptions(request, runtime);
        }

        /**
         * @param request DescribeBackupSummaryRequest
         * @return DescribeBackupSummaryResponse
         */
        public async Task<DescribeBackupSummaryResponse> DescribeBackupSummaryAsync(DescribeBackupSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupSummaryWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeBackupTablesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupTablesResponse
         */
        public DescribeBackupTablesResponse DescribeBackupTablesWithOptions(DescribeBackupTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupRecordId))
            {
                query["BackupRecordId"] = request.BackupRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupTables",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupTablesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeBackupTablesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupTablesResponse
         */
        public async Task<DescribeBackupTablesResponse> DescribeBackupTablesWithOptionsAsync(DescribeBackupTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupRecordId))
            {
                query["BackupRecordId"] = request.BackupRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupTables",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeBackupTablesRequest
         * @return DescribeBackupTablesResponse
         */
        public DescribeBackupTablesResponse DescribeBackupTables(DescribeBackupTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupTablesWithOptions(request, runtime);
        }

        /**
         * @param request DescribeBackupTablesRequest
         * @return DescribeBackupTablesResponse
         */
        public async Task<DescribeBackupTablesResponse> DescribeBackupTablesAsync(DescribeBackupTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupTablesWithOptionsAsync(request, runtime);
        }

        /**
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeUTC))
            {
                query["EndTimeUTC"] = request.EndTimeUTC;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeUTC))
            {
                query["StartTimeUTC"] = request.StartTimeUTC;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackups",
                Version = "2019-01-01",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeUTC))
            {
                query["EndTimeUTC"] = request.EndTimeUTC;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeUTC))
            {
                query["StartTimeUTC"] = request.StartTimeUTC;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackups",
                Version = "2019-01-01",
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
         * @param request DescribeBackupsRequest
         * @return DescribeBackupsResponse
         */
        public DescribeBackupsResponse DescribeBackups(DescribeBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeBackupsRequest
         * @return DescribeBackupsResponse
         */
        public async Task<DescribeBackupsResponse> DescribeBackupsAsync(DescribeBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeClusterConnectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterConnectionResponse
         */
        public DescribeClusterConnectionResponse DescribeClusterConnectionWithOptions(DescribeClusterConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
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
                Action = "DescribeClusterConnection",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterConnectionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeClusterConnectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterConnectionResponse
         */
        public async Task<DescribeClusterConnectionResponse> DescribeClusterConnectionWithOptionsAsync(DescribeClusterConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
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
                Action = "DescribeClusterConnection",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeClusterConnectionRequest
         * @return DescribeClusterConnectionResponse
         */
        public DescribeClusterConnectionResponse DescribeClusterConnection(DescribeClusterConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterConnectionWithOptions(request, runtime);
        }

        /**
         * @param request DescribeClusterConnectionRequest
         * @return DescribeClusterConnectionResponse
         */
        public async Task<DescribeClusterConnectionResponse> DescribeClusterConnectionAsync(DescribeClusterConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterConnectionWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeColdStorageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeColdStorageResponse
         */
        public DescribeColdStorageResponse DescribeColdStorageWithOptions(DescribeColdStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeColdStorage",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeColdStorageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeColdStorageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeColdStorageResponse
         */
        public async Task<DescribeColdStorageResponse> DescribeColdStorageWithOptionsAsync(DescribeColdStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeColdStorage",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeColdStorageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeColdStorageRequest
         * @return DescribeColdStorageResponse
         */
        public DescribeColdStorageResponse DescribeColdStorage(DescribeColdStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeColdStorageWithOptions(request, runtime);
        }

        /**
         * @param request DescribeColdStorageRequest
         * @return DescribeColdStorageResponse
         */
        public async Task<DescribeColdStorageResponse> DescribeColdStorageAsync(DescribeColdStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeColdStorageWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDBInstanceUsageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBInstanceUsageResponse
         */
        public DescribeDBInstanceUsageResponse DescribeDBInstanceUsageWithOptions(DescribeDBInstanceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceUsage",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceUsageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDBInstanceUsageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBInstanceUsageResponse
         */
        public async Task<DescribeDBInstanceUsageResponse> DescribeDBInstanceUsageWithOptionsAsync(DescribeDBInstanceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstanceUsage",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDBInstanceUsageRequest
         * @return DescribeDBInstanceUsageResponse
         */
        public DescribeDBInstanceUsageResponse DescribeDBInstanceUsage(DescribeDBInstanceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceUsageWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDBInstanceUsageRequest
         * @return DescribeDBInstanceUsageResponse
         */
        public async Task<DescribeDBInstanceUsageResponse> DescribeDBInstanceUsageAsync(DescribeDBInstanceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceUsageWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDeletedInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDeletedInstancesResponse
         */
        public DescribeDeletedInstancesResponse DescribeDeletedInstancesWithOptions(DescribeDeletedInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDeletedInstances",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDeletedInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDeletedInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDeletedInstancesResponse
         */
        public async Task<DescribeDeletedInstancesResponse> DescribeDeletedInstancesWithOptionsAsync(DescribeDeletedInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDeletedInstances",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDeletedInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDeletedInstancesRequest
         * @return DescribeDeletedInstancesResponse
         */
        public DescribeDeletedInstancesResponse DescribeDeletedInstances(DescribeDeletedInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeletedInstancesWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDeletedInstancesRequest
         * @return DescribeDeletedInstancesResponse
         */
        public async Task<DescribeDeletedInstancesResponse> DescribeDeletedInstancesAsync(DescribeDeletedInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeletedInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDiskWarningLineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDiskWarningLineResponse
         */
        public DescribeDiskWarningLineResponse DescribeDiskWarningLineWithOptions(DescribeDiskWarningLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiskWarningLine",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiskWarningLineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDiskWarningLineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDiskWarningLineResponse
         */
        public async Task<DescribeDiskWarningLineResponse> DescribeDiskWarningLineWithOptionsAsync(DescribeDiskWarningLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiskWarningLine",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiskWarningLineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDiskWarningLineRequest
         * @return DescribeDiskWarningLineResponse
         */
        public DescribeDiskWarningLineResponse DescribeDiskWarningLine(DescribeDiskWarningLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDiskWarningLineWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDiskWarningLineRequest
         * @return DescribeDiskWarningLineResponse
         */
        public async Task<DescribeDiskWarningLineResponse> DescribeDiskWarningLineAsync(DescribeDiskWarningLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDiskWarningLineWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeEndpointsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEndpointsResponse
         */
        public DescribeEndpointsResponse DescribeEndpointsWithOptions(DescribeEndpointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEndpoints",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEndpointsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeEndpointsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEndpointsResponse
         */
        public async Task<DescribeEndpointsResponse> DescribeEndpointsWithOptionsAsync(DescribeEndpointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEndpoints",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEndpointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeEndpointsRequest
         * @return DescribeEndpointsResponse
         */
        public DescribeEndpointsResponse DescribeEndpoints(DescribeEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEndpointsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeEndpointsRequest
         * @return DescribeEndpointsResponse
         */
        public async Task<DescribeEndpointsResponse> DescribeEndpointsAsync(DescribeEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEndpointsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceResponse
         */
        public DescribeInstanceResponse DescribeInstanceWithOptions(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstance",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceResponse
         */
        public async Task<DescribeInstanceResponse> DescribeInstanceWithOptionsAsync(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstance",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeInstanceRequest
         * @return DescribeInstanceResponse
         */
        public DescribeInstanceResponse DescribeInstance(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceWithOptions(request, runtime);
        }

        /**
         * @param request DescribeInstanceRequest
         * @return DescribeInstanceResponse
         */
        public async Task<DescribeInstanceResponse> DescribeInstanceAsync(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeInstanceTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceTypeResponse
         */
        public DescribeInstanceTypeResponse DescribeInstanceTypeWithOptions(DescribeInstanceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceType",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceTypeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeInstanceTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceTypeResponse
         */
        public async Task<DescribeInstanceTypeResponse> DescribeInstanceTypeWithOptionsAsync(DescribeInstanceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceType",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeInstanceTypeRequest
         * @return DescribeInstanceTypeResponse
         */
        public DescribeInstanceTypeResponse DescribeInstanceType(DescribeInstanceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceTypeWithOptions(request, runtime);
        }

        /**
         * @param request DescribeInstanceTypeRequest
         * @return DescribeInstanceTypeResponse
         */
        public async Task<DescribeInstanceTypeResponse> DescribeInstanceTypeAsync(DescribeInstanceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceTypeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstancesResponse
         */
        public DescribeInstancesResponse DescribeInstancesWithOptions(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbType))
            {
                query["DbType"] = request.DbType;
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
                Action = "DescribeInstances",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstancesResponse
         */
        public async Task<DescribeInstancesResponse> DescribeInstancesWithOptionsAsync(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbType))
            {
                query["DbType"] = request.DbType;
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
                Action = "DescribeInstances",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeInstancesRequest
         * @return DescribeInstancesResponse
         */
        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstancesWithOptions(request, runtime);
        }

        /**
         * @param request DescribeInstancesRequest
         * @return DescribeInstancesResponse
         */
        public async Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeIpWhitelistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeIpWhitelistResponse
         */
        public DescribeIpWhitelistResponse DescribeIpWhitelistWithOptions(DescribeIpWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIpWhitelist",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIpWhitelistResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeIpWhitelistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeIpWhitelistResponse
         */
        public async Task<DescribeIpWhitelistResponse> DescribeIpWhitelistWithOptionsAsync(DescribeIpWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIpWhitelist",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIpWhitelistResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeIpWhitelistRequest
         * @return DescribeIpWhitelistResponse
         */
        public DescribeIpWhitelistResponse DescribeIpWhitelist(DescribeIpWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIpWhitelistWithOptions(request, runtime);
        }

        /**
         * @param request DescribeIpWhitelistRequest
         * @return DescribeIpWhitelistResponse
         */
        public async Task<DescribeIpWhitelistResponse> DescribeIpWhitelistAsync(DescribeIpWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIpWhitelistWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeMultiZoneAvailableRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMultiZoneAvailableRegionsResponse
         */
        public DescribeMultiZoneAvailableRegionsResponse DescribeMultiZoneAvailableRegionsWithOptions(DescribeMultiZoneAvailableRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeMultiZoneAvailableRegions",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMultiZoneAvailableRegionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeMultiZoneAvailableRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMultiZoneAvailableRegionsResponse
         */
        public async Task<DescribeMultiZoneAvailableRegionsResponse> DescribeMultiZoneAvailableRegionsWithOptionsAsync(DescribeMultiZoneAvailableRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeMultiZoneAvailableRegions",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMultiZoneAvailableRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeMultiZoneAvailableRegionsRequest
         * @return DescribeMultiZoneAvailableRegionsResponse
         */
        public DescribeMultiZoneAvailableRegionsResponse DescribeMultiZoneAvailableRegions(DescribeMultiZoneAvailableRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMultiZoneAvailableRegionsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeMultiZoneAvailableRegionsRequest
         * @return DescribeMultiZoneAvailableRegionsResponse
         */
        public async Task<DescribeMultiZoneAvailableRegionsResponse> DescribeMultiZoneAvailableRegionsAsync(DescribeMultiZoneAvailableRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMultiZoneAvailableRegionsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeMultiZoneAvailableResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMultiZoneAvailableResourceResponse
         */
        public DescribeMultiZoneAvailableResourceResponse DescribeMultiZoneAvailableResourceWithOptions(DescribeMultiZoneAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneCombination))
            {
                query["ZoneCombination"] = request.ZoneCombination;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMultiZoneAvailableResource",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMultiZoneAvailableResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeMultiZoneAvailableResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMultiZoneAvailableResourceResponse
         */
        public async Task<DescribeMultiZoneAvailableResourceResponse> DescribeMultiZoneAvailableResourceWithOptionsAsync(DescribeMultiZoneAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneCombination))
            {
                query["ZoneCombination"] = request.ZoneCombination;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMultiZoneAvailableResource",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMultiZoneAvailableResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeMultiZoneAvailableResourceRequest
         * @return DescribeMultiZoneAvailableResourceResponse
         */
        public DescribeMultiZoneAvailableResourceResponse DescribeMultiZoneAvailableResource(DescribeMultiZoneAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMultiZoneAvailableResourceWithOptions(request, runtime);
        }

        /**
         * @param request DescribeMultiZoneAvailableResourceRequest
         * @return DescribeMultiZoneAvailableResourceResponse
         */
        public async Task<DescribeMultiZoneAvailableResourceResponse> DescribeMultiZoneAvailableResourceAsync(DescribeMultiZoneAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMultiZoneAvailableResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeMultiZoneClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMultiZoneClusterResponse
         */
        public DescribeMultiZoneClusterResponse DescribeMultiZoneClusterWithOptions(DescribeMultiZoneClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMultiZoneCluster",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMultiZoneClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeMultiZoneClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMultiZoneClusterResponse
         */
        public async Task<DescribeMultiZoneClusterResponse> DescribeMultiZoneClusterWithOptionsAsync(DescribeMultiZoneClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMultiZoneCluster",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMultiZoneClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeMultiZoneClusterRequest
         * @return DescribeMultiZoneClusterResponse
         */
        public DescribeMultiZoneClusterResponse DescribeMultiZoneCluster(DescribeMultiZoneClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMultiZoneClusterWithOptions(request, runtime);
        }

        /**
         * @param request DescribeMultiZoneClusterRequest
         * @return DescribeMultiZoneClusterResponse
         */
        public async Task<DescribeMultiZoneClusterResponse> DescribeMultiZoneClusterAsync(DescribeMultiZoneClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMultiZoneClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeRecoverableTimeRangeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRecoverableTimeRangeResponse
         */
        public DescribeRecoverableTimeRangeResponse DescribeRecoverableTimeRangeWithOptions(DescribeRecoverableTimeRangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecoverableTimeRange",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecoverableTimeRangeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeRecoverableTimeRangeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRecoverableTimeRangeResponse
         */
        public async Task<DescribeRecoverableTimeRangeResponse> DescribeRecoverableTimeRangeWithOptionsAsync(DescribeRecoverableTimeRangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecoverableTimeRange",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecoverableTimeRangeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeRecoverableTimeRangeRequest
         * @return DescribeRecoverableTimeRangeResponse
         */
        public DescribeRecoverableTimeRangeResponse DescribeRecoverableTimeRange(DescribeRecoverableTimeRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecoverableTimeRangeWithOptions(request, runtime);
        }

        /**
         * @param request DescribeRecoverableTimeRangeRequest
         * @return DescribeRecoverableTimeRangeResponse
         */
        public async Task<DescribeRecoverableTimeRangeResponse> DescribeRecoverableTimeRangeAsync(DescribeRecoverableTimeRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecoverableTimeRangeWithOptionsAsync(request, runtime);
        }

        /**
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2019-01-01",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2019-01-01",
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
         * @param request DescribeRegionsRequest
         * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeRegionsRequest
         * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeRestoreFullDetailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRestoreFullDetailsResponse
         */
        public DescribeRestoreFullDetailsResponse DescribeRestoreFullDetailsWithOptions(DescribeRestoreFullDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreRecordId))
            {
                query["RestoreRecordId"] = request.RestoreRecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRestoreFullDetails",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRestoreFullDetailsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeRestoreFullDetailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRestoreFullDetailsResponse
         */
        public async Task<DescribeRestoreFullDetailsResponse> DescribeRestoreFullDetailsWithOptionsAsync(DescribeRestoreFullDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreRecordId))
            {
                query["RestoreRecordId"] = request.RestoreRecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRestoreFullDetails",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRestoreFullDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeRestoreFullDetailsRequest
         * @return DescribeRestoreFullDetailsResponse
         */
        public DescribeRestoreFullDetailsResponse DescribeRestoreFullDetails(DescribeRestoreFullDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRestoreFullDetailsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeRestoreFullDetailsRequest
         * @return DescribeRestoreFullDetailsResponse
         */
        public async Task<DescribeRestoreFullDetailsResponse> DescribeRestoreFullDetailsAsync(DescribeRestoreFullDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRestoreFullDetailsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeRestoreIncrDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRestoreIncrDetailResponse
         */
        public DescribeRestoreIncrDetailResponse DescribeRestoreIncrDetailWithOptions(DescribeRestoreIncrDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreRecordId))
            {
                query["RestoreRecordId"] = request.RestoreRecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRestoreIncrDetail",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRestoreIncrDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeRestoreIncrDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRestoreIncrDetailResponse
         */
        public async Task<DescribeRestoreIncrDetailResponse> DescribeRestoreIncrDetailWithOptionsAsync(DescribeRestoreIncrDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreRecordId))
            {
                query["RestoreRecordId"] = request.RestoreRecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRestoreIncrDetail",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRestoreIncrDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeRestoreIncrDetailRequest
         * @return DescribeRestoreIncrDetailResponse
         */
        public DescribeRestoreIncrDetailResponse DescribeRestoreIncrDetail(DescribeRestoreIncrDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRestoreIncrDetailWithOptions(request, runtime);
        }

        /**
         * @param request DescribeRestoreIncrDetailRequest
         * @return DescribeRestoreIncrDetailResponse
         */
        public async Task<DescribeRestoreIncrDetailResponse> DescribeRestoreIncrDetailAsync(DescribeRestoreIncrDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRestoreIncrDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeRestoreSchemaDetailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRestoreSchemaDetailsResponse
         */
        public DescribeRestoreSchemaDetailsResponse DescribeRestoreSchemaDetailsWithOptions(DescribeRestoreSchemaDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreRecordId))
            {
                query["RestoreRecordId"] = request.RestoreRecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRestoreSchemaDetails",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRestoreSchemaDetailsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeRestoreSchemaDetailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRestoreSchemaDetailsResponse
         */
        public async Task<DescribeRestoreSchemaDetailsResponse> DescribeRestoreSchemaDetailsWithOptionsAsync(DescribeRestoreSchemaDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreRecordId))
            {
                query["RestoreRecordId"] = request.RestoreRecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRestoreSchemaDetails",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRestoreSchemaDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeRestoreSchemaDetailsRequest
         * @return DescribeRestoreSchemaDetailsResponse
         */
        public DescribeRestoreSchemaDetailsResponse DescribeRestoreSchemaDetails(DescribeRestoreSchemaDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRestoreSchemaDetailsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeRestoreSchemaDetailsRequest
         * @return DescribeRestoreSchemaDetailsResponse
         */
        public async Task<DescribeRestoreSchemaDetailsResponse> DescribeRestoreSchemaDetailsAsync(DescribeRestoreSchemaDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRestoreSchemaDetailsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeRestoreSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRestoreSummaryResponse
         */
        public DescribeRestoreSummaryResponse DescribeRestoreSummaryWithOptions(DescribeRestoreSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRestoreSummary",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRestoreSummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeRestoreSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRestoreSummaryResponse
         */
        public async Task<DescribeRestoreSummaryResponse> DescribeRestoreSummaryWithOptionsAsync(DescribeRestoreSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRestoreSummary",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRestoreSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeRestoreSummaryRequest
         * @return DescribeRestoreSummaryResponse
         */
        public DescribeRestoreSummaryResponse DescribeRestoreSummary(DescribeRestoreSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRestoreSummaryWithOptions(request, runtime);
        }

        /**
         * @param request DescribeRestoreSummaryRequest
         * @return DescribeRestoreSummaryResponse
         */
        public async Task<DescribeRestoreSummaryResponse> DescribeRestoreSummaryAsync(DescribeRestoreSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRestoreSummaryWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeRestoreTablesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRestoreTablesResponse
         */
        public DescribeRestoreTablesResponse DescribeRestoreTablesWithOptions(DescribeRestoreTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreRecordId))
            {
                query["RestoreRecordId"] = request.RestoreRecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRestoreTables",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRestoreTablesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeRestoreTablesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRestoreTablesResponse
         */
        public async Task<DescribeRestoreTablesResponse> DescribeRestoreTablesWithOptionsAsync(DescribeRestoreTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreRecordId))
            {
                query["RestoreRecordId"] = request.RestoreRecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRestoreTables",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRestoreTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeRestoreTablesRequest
         * @return DescribeRestoreTablesResponse
         */
        public DescribeRestoreTablesResponse DescribeRestoreTables(DescribeRestoreTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRestoreTablesWithOptions(request, runtime);
        }

        /**
         * @param request DescribeRestoreTablesRequest
         * @return DescribeRestoreTablesResponse
         */
        public async Task<DescribeRestoreTablesResponse> DescribeRestoreTablesAsync(DescribeRestoreTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRestoreTablesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeSecurityGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSecurityGroupsResponse
         */
        public DescribeSecurityGroupsResponse DescribeSecurityGroupsWithOptions(DescribeSecurityGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecurityGroups",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecurityGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeSecurityGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSecurityGroupsResponse
         */
        public async Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsWithOptionsAsync(DescribeSecurityGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecurityGroups",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecurityGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeSecurityGroupsRequest
         * @return DescribeSecurityGroupsResponse
         */
        public DescribeSecurityGroupsResponse DescribeSecurityGroups(DescribeSecurityGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityGroupsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeSecurityGroupsRequest
         * @return DescribeSecurityGroupsResponse
         */
        public async Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsAsync(DescribeSecurityGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeServerlessClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeServerlessClusterResponse
         */
        public DescribeServerlessClusterResponse DescribeServerlessClusterWithOptions(DescribeServerlessClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
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
                Action = "DescribeServerlessCluster",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServerlessClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeServerlessClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeServerlessClusterResponse
         */
        public async Task<DescribeServerlessClusterResponse> DescribeServerlessClusterWithOptionsAsync(DescribeServerlessClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
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
                Action = "DescribeServerlessCluster",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServerlessClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeServerlessClusterRequest
         * @return DescribeServerlessClusterResponse
         */
        public DescribeServerlessClusterResponse DescribeServerlessCluster(DescribeServerlessClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServerlessClusterWithOptions(request, runtime);
        }

        /**
         * @param request DescribeServerlessClusterRequest
         * @return DescribeServerlessClusterResponse
         */
        public async Task<DescribeServerlessClusterResponse> DescribeServerlessClusterAsync(DescribeServerlessClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServerlessClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeSubDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSubDomainResponse
         */
        public DescribeSubDomainResponse DescribeSubDomainWithOptions(DescribeSubDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeSubDomain",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSubDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeSubDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSubDomainResponse
         */
        public async Task<DescribeSubDomainResponse> DescribeSubDomainWithOptionsAsync(DescribeSubDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeSubDomain",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSubDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeSubDomainRequest
         * @return DescribeSubDomainResponse
         */
        public DescribeSubDomainResponse DescribeSubDomain(DescribeSubDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSubDomainWithOptions(request, runtime);
        }

        /**
         * @param request DescribeSubDomainRequest
         * @return DescribeSubDomainResponse
         */
        public async Task<DescribeSubDomainResponse> DescribeSubDomainAsync(DescribeSubDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSubDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @param request EnableHBaseueBackupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableHBaseueBackupResponse
         */
        public EnableHBaseueBackupResponse EnableHBaseueBackupWithOptions(EnableHBaseueBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColdStorageSize))
            {
                query["ColdStorageSize"] = request.ColdStorageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HbaseueClusterId))
            {
                query["HbaseueClusterId"] = request.HbaseueClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeCount))
            {
                query["NodeCount"] = request.NodeCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableHBaseueBackup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableHBaseueBackupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request EnableHBaseueBackupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableHBaseueBackupResponse
         */
        public async Task<EnableHBaseueBackupResponse> EnableHBaseueBackupWithOptionsAsync(EnableHBaseueBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColdStorageSize))
            {
                query["ColdStorageSize"] = request.ColdStorageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HbaseueClusterId))
            {
                query["HbaseueClusterId"] = request.HbaseueClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeCount))
            {
                query["NodeCount"] = request.NodeCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableHBaseueBackup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableHBaseueBackupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request EnableHBaseueBackupRequest
         * @return EnableHBaseueBackupResponse
         */
        public EnableHBaseueBackupResponse EnableHBaseueBackup(EnableHBaseueBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableHBaseueBackupWithOptions(request, runtime);
        }

        /**
         * @param request EnableHBaseueBackupRequest
         * @return EnableHBaseueBackupResponse
         */
        public async Task<EnableHBaseueBackupResponse> EnableHBaseueBackupAsync(EnableHBaseueBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableHBaseueBackupWithOptionsAsync(request, runtime);
        }

        /**
         * @param request EnableHBaseueModuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableHBaseueModuleResponse
         */
        public EnableHBaseueModuleResponse EnableHBaseueModuleWithOptions(EnableHBaseueModuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BdsId))
            {
                query["BdsId"] = request.BdsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreInstanceType))
            {
                query["CoreInstanceType"] = request.CoreInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HbaseueClusterId))
            {
                query["HbaseueClusterId"] = request.HbaseueClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterInstanceType))
            {
                query["MasterInstanceType"] = request.MasterInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleClusterName))
            {
                query["ModuleClusterName"] = request.ModuleClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleTypeName))
            {
                query["ModuleTypeName"] = request.ModuleTypeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeCount))
            {
                query["NodeCount"] = request.NodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswitchId))
            {
                query["VswitchId"] = request.VswitchId;
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
                Action = "EnableHBaseueModule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableHBaseueModuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request EnableHBaseueModuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableHBaseueModuleResponse
         */
        public async Task<EnableHBaseueModuleResponse> EnableHBaseueModuleWithOptionsAsync(EnableHBaseueModuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BdsId))
            {
                query["BdsId"] = request.BdsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreInstanceType))
            {
                query["CoreInstanceType"] = request.CoreInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HbaseueClusterId))
            {
                query["HbaseueClusterId"] = request.HbaseueClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterInstanceType))
            {
                query["MasterInstanceType"] = request.MasterInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleClusterName))
            {
                query["ModuleClusterName"] = request.ModuleClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleTypeName))
            {
                query["ModuleTypeName"] = request.ModuleTypeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeCount))
            {
                query["NodeCount"] = request.NodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswitchId))
            {
                query["VswitchId"] = request.VswitchId;
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
                Action = "EnableHBaseueModule",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableHBaseueModuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request EnableHBaseueModuleRequest
         * @return EnableHBaseueModuleResponse
         */
        public EnableHBaseueModuleResponse EnableHBaseueModule(EnableHBaseueModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableHBaseueModuleWithOptions(request, runtime);
        }

        /**
         * @param request EnableHBaseueModuleRequest
         * @return EnableHBaseueModuleResponse
         */
        public async Task<EnableHBaseueModuleResponse> EnableHBaseueModuleAsync(EnableHBaseueModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableHBaseueModuleWithOptionsAsync(request, runtime);
        }

        /**
         * @param request EvaluateMultiZoneResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EvaluateMultiZoneResourceResponse
         */
        public EvaluateMultiZoneResourceResponse EvaluateMultiZoneResourceWithOptions(EvaluateMultiZoneResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArbiterVSwitchId))
            {
                query["ArbiterVSwitchId"] = request.ArbiterVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArbiterZoneId))
            {
                query["ArbiterZoneId"] = request.ArbiterZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArchVersion))
            {
                query["ArchVersion"] = request.ArchVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreDiskSize))
            {
                query["CoreDiskSize"] = request.CoreDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreDiskType))
            {
                query["CoreDiskType"] = request.CoreDiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreInstanceType))
            {
                query["CoreInstanceType"] = request.CoreInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreNodeCount))
            {
                query["CoreNodeCount"] = request.CoreNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogDiskSize))
            {
                query["LogDiskSize"] = request.LogDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogDiskType))
            {
                query["LogDiskType"] = request.LogDiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogInstanceType))
            {
                query["LogInstanceType"] = request.LogInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogNodeCount))
            {
                query["LogNodeCount"] = request.LogNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterInstanceType))
            {
                query["MasterInstanceType"] = request.MasterInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiZoneCombination))
            {
                query["MultiZoneCombination"] = request.MultiZoneCombination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryVSwitchId))
            {
                query["PrimaryVSwitchId"] = request.PrimaryVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryZoneId))
            {
                query["PrimaryZoneId"] = request.PrimaryZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIPList))
            {
                query["SecurityIPList"] = request.SecurityIPList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandbyVSwitchId))
            {
                query["StandbyVSwitchId"] = request.StandbyVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandbyZoneId))
            {
                query["StandbyZoneId"] = request.StandbyZoneId;
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
                Action = "EvaluateMultiZoneResource",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EvaluateMultiZoneResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request EvaluateMultiZoneResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EvaluateMultiZoneResourceResponse
         */
        public async Task<EvaluateMultiZoneResourceResponse> EvaluateMultiZoneResourceWithOptionsAsync(EvaluateMultiZoneResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArbiterVSwitchId))
            {
                query["ArbiterVSwitchId"] = request.ArbiterVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArbiterZoneId))
            {
                query["ArbiterZoneId"] = request.ArbiterZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArchVersion))
            {
                query["ArchVersion"] = request.ArchVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreDiskSize))
            {
                query["CoreDiskSize"] = request.CoreDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreDiskType))
            {
                query["CoreDiskType"] = request.CoreDiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreInstanceType))
            {
                query["CoreInstanceType"] = request.CoreInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreNodeCount))
            {
                query["CoreNodeCount"] = request.CoreNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogDiskSize))
            {
                query["LogDiskSize"] = request.LogDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogDiskType))
            {
                query["LogDiskType"] = request.LogDiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogInstanceType))
            {
                query["LogInstanceType"] = request.LogInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogNodeCount))
            {
                query["LogNodeCount"] = request.LogNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterInstanceType))
            {
                query["MasterInstanceType"] = request.MasterInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiZoneCombination))
            {
                query["MultiZoneCombination"] = request.MultiZoneCombination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryVSwitchId))
            {
                query["PrimaryVSwitchId"] = request.PrimaryVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryZoneId))
            {
                query["PrimaryZoneId"] = request.PrimaryZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIPList))
            {
                query["SecurityIPList"] = request.SecurityIPList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandbyVSwitchId))
            {
                query["StandbyVSwitchId"] = request.StandbyVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandbyZoneId))
            {
                query["StandbyZoneId"] = request.StandbyZoneId;
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
                Action = "EvaluateMultiZoneResource",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EvaluateMultiZoneResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request EvaluateMultiZoneResourceRequest
         * @return EvaluateMultiZoneResourceResponse
         */
        public EvaluateMultiZoneResourceResponse EvaluateMultiZoneResource(EvaluateMultiZoneResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EvaluateMultiZoneResourceWithOptions(request, runtime);
        }

        /**
         * @param request EvaluateMultiZoneResourceRequest
         * @return EvaluateMultiZoneResourceResponse
         */
        public async Task<EvaluateMultiZoneResourceResponse> EvaluateMultiZoneResourceAsync(EvaluateMultiZoneResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EvaluateMultiZoneResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetMultimodeCmsUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMultimodeCmsUrlResponse
         */
        public GetMultimodeCmsUrlResponse GetMultimodeCmsUrlWithOptions(GetMultimodeCmsUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
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
                Action = "GetMultimodeCmsUrl",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMultimodeCmsUrlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetMultimodeCmsUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMultimodeCmsUrlResponse
         */
        public async Task<GetMultimodeCmsUrlResponse> GetMultimodeCmsUrlWithOptionsAsync(GetMultimodeCmsUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
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
                Action = "GetMultimodeCmsUrl",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMultimodeCmsUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetMultimodeCmsUrlRequest
         * @return GetMultimodeCmsUrlResponse
         */
        public GetMultimodeCmsUrlResponse GetMultimodeCmsUrl(GetMultimodeCmsUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMultimodeCmsUrlWithOptions(request, runtime);
        }

        /**
         * @param request GetMultimodeCmsUrlRequest
         * @return GetMultimodeCmsUrlResponse
         */
        public async Task<GetMultimodeCmsUrlResponse> GetMultimodeCmsUrlAsync(GetMultimodeCmsUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMultimodeCmsUrlWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 授权账户权限
         *
         * @param request GrantRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GrantResponse
         */
        public GrantResponse GrantWithOptions(GrantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclActions))
            {
                query["AclActions"] = request.AclActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Grant",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 授权账户权限
         *
         * @param request GrantRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GrantResponse
         */
        public async Task<GrantResponse> GrantWithOptionsAsync(GrantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclActions))
            {
                query["AclActions"] = request.AclActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Grant",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 授权账户权限
         *
         * @param request GrantRequest
         * @return GrantResponse
         */
        public GrantResponse Grant(GrantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantWithOptions(request, runtime);
        }

        /**
         * @summary 授权账户权限
         *
         * @param request GrantRequest
         * @return GrantResponse
         */
        public async Task<GrantResponse> GrantAsync(GrantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListHBaseInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHBaseInstancesResponse
         */
        public ListHBaseInstancesResponse ListHBaseInstancesWithOptions(ListHBaseInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListHBaseInstances",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHBaseInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListHBaseInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHBaseInstancesResponse
         */
        public async Task<ListHBaseInstancesResponse> ListHBaseInstancesWithOptionsAsync(ListHBaseInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListHBaseInstances",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHBaseInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListHBaseInstancesRequest
         * @return ListHBaseInstancesResponse
         */
        public ListHBaseInstancesResponse ListHBaseInstances(ListHBaseInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHBaseInstancesWithOptions(request, runtime);
        }

        /**
         * @param request ListHBaseInstancesRequest
         * @return ListHBaseInstancesResponse
         */
        public async Task<ListHBaseInstancesResponse> ListHBaseInstancesAsync(ListHBaseInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHBaseInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListInstanceServiceConfigHistoriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstanceServiceConfigHistoriesResponse
         */
        public ListInstanceServiceConfigHistoriesResponse ListInstanceServiceConfigHistoriesWithOptions(ListInstanceServiceConfigHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceServiceConfigHistories",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceServiceConfigHistoriesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListInstanceServiceConfigHistoriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstanceServiceConfigHistoriesResponse
         */
        public async Task<ListInstanceServiceConfigHistoriesResponse> ListInstanceServiceConfigHistoriesWithOptionsAsync(ListInstanceServiceConfigHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceServiceConfigHistories",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceServiceConfigHistoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListInstanceServiceConfigHistoriesRequest
         * @return ListInstanceServiceConfigHistoriesResponse
         */
        public ListInstanceServiceConfigHistoriesResponse ListInstanceServiceConfigHistories(ListInstanceServiceConfigHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstanceServiceConfigHistoriesWithOptions(request, runtime);
        }

        /**
         * @param request ListInstanceServiceConfigHistoriesRequest
         * @return ListInstanceServiceConfigHistoriesResponse
         */
        public async Task<ListInstanceServiceConfigHistoriesResponse> ListInstanceServiceConfigHistoriesAsync(ListInstanceServiceConfigHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstanceServiceConfigHistoriesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListInstanceServiceConfigurationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstanceServiceConfigurationsResponse
         */
        public ListInstanceServiceConfigurationsResponse ListInstanceServiceConfigurationsWithOptions(ListInstanceServiceConfigurationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceServiceConfigurations",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceServiceConfigurationsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListInstanceServiceConfigurationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstanceServiceConfigurationsResponse
         */
        public async Task<ListInstanceServiceConfigurationsResponse> ListInstanceServiceConfigurationsWithOptionsAsync(ListInstanceServiceConfigurationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceServiceConfigurations",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceServiceConfigurationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListInstanceServiceConfigurationsRequest
         * @return ListInstanceServiceConfigurationsResponse
         */
        public ListInstanceServiceConfigurationsResponse ListInstanceServiceConfigurations(ListInstanceServiceConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstanceServiceConfigurationsWithOptions(request, runtime);
        }

        /**
         * @param request ListInstanceServiceConfigurationsRequest
         * @return ListInstanceServiceConfigurationsResponse
         */
        public async Task<ListInstanceServiceConfigurationsResponse> ListInstanceServiceConfigurationsAsync(ListInstanceServiceConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstanceServiceConfigurationsWithOptionsAsync(request, runtime);
        }

        /**
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
                Version = "2019-01-01",
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
                Version = "2019-01-01",
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
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /**
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagsResponse
         */
        public ListTagsResponse ListTagsWithOptions(ListTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListTags",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagsResponse
         */
        public async Task<ListTagsResponse> ListTagsWithOptionsAsync(ListTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListTags",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListTagsRequest
         * @return ListTagsResponse
         */
        public ListTagsResponse ListTags(ListTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagsWithOptions(request, runtime);
        }

        /**
         * @param request ListTagsRequest
         * @return ListTagsResponse
         */
        public async Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更改账户密码
         *
         * @param request ModifyAccountPasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAccountPasswordResponse
         */
        public ModifyAccountPasswordResponse ModifyAccountPasswordWithOptions(ModifyAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewAccountPassword))
            {
                query["NewAccountPassword"] = request.NewAccountPassword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAccountPassword",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAccountPasswordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更改账户密码
         *
         * @param request ModifyAccountPasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAccountPasswordResponse
         */
        public async Task<ModifyAccountPasswordResponse> ModifyAccountPasswordWithOptionsAsync(ModifyAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewAccountPassword))
            {
                query["NewAccountPassword"] = request.NewAccountPassword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAccountPassword",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAccountPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更改账户密码
         *
         * @param request ModifyAccountPasswordRequest
         * @return ModifyAccountPasswordResponse
         */
        public ModifyAccountPasswordResponse ModifyAccountPassword(ModifyAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAccountPasswordWithOptions(request, runtime);
        }

        /**
         * @summary 更改账户密码
         *
         * @param request ModifyAccountPasswordRequest
         * @return ModifyAccountPasswordResponse
         */
        public async Task<ModifyAccountPasswordResponse> ModifyAccountPasswordAsync(ModifyAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAccountPasswordWithOptionsAsync(request, runtime);
        }

        /**
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
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
                Version = "2019-01-01",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
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
                Version = "2019-01-01",
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
         * @param request ModifyActiveOperationTasksRequest
         * @return ModifyActiveOperationTasksResponse
         */
        public ModifyActiveOperationTasksResponse ModifyActiveOperationTasks(ModifyActiveOperationTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyActiveOperationTasksWithOptions(request, runtime);
        }

        /**
         * @param request ModifyActiveOperationTasksRequest
         * @return ModifyActiveOperationTasksResponse
         */
        public async Task<ModifyActiveOperationTasksResponse> ModifyActiveOperationTasksAsync(ModifyActiveOperationTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyActiveOperationTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyBackupPlanConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyBackupPlanConfigResponse
         */
        public ModifyBackupPlanConfigResponse ModifyBackupPlanConfigWithOptions(ModifyBackupPlanConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FullBackupCycle))
            {
                query["FullBackupCycle"] = request.FullBackupCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinHFileBackupCount))
            {
                query["MinHFileBackupCount"] = request.MinHFileBackupCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextFullBackupDate))
            {
                query["NextFullBackupDate"] = request.NextFullBackupDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tables))
            {
                query["Tables"] = request.Tables;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBackupPlanConfig",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBackupPlanConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyBackupPlanConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyBackupPlanConfigResponse
         */
        public async Task<ModifyBackupPlanConfigResponse> ModifyBackupPlanConfigWithOptionsAsync(ModifyBackupPlanConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FullBackupCycle))
            {
                query["FullBackupCycle"] = request.FullBackupCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinHFileBackupCount))
            {
                query["MinHFileBackupCount"] = request.MinHFileBackupCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextFullBackupDate))
            {
                query["NextFullBackupDate"] = request.NextFullBackupDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tables))
            {
                query["Tables"] = request.Tables;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBackupPlanConfig",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBackupPlanConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyBackupPlanConfigRequest
         * @return ModifyBackupPlanConfigResponse
         */
        public ModifyBackupPlanConfigResponse ModifyBackupPlanConfig(ModifyBackupPlanConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBackupPlanConfigWithOptions(request, runtime);
        }

        /**
         * @param request ModifyBackupPlanConfigRequest
         * @return ModifyBackupPlanConfigResponse
         */
        public async Task<ModifyBackupPlanConfigResponse> ModifyBackupPlanConfigAsync(ModifyBackupPlanConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBackupPlanConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyBackupPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyBackupPolicyResponse
         */
        public ModifyBackupPolicyResponse ModifyBackupPolicyWithOptions(ModifyBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferredBackupEndTimeUTC))
            {
                query["PreferredBackupEndTimeUTC"] = request.PreferredBackupEndTimeUTC;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferredBackupPeriod))
            {
                query["PreferredBackupPeriod"] = request.PreferredBackupPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferredBackupStartTimeUTC))
            {
                query["PreferredBackupStartTimeUTC"] = request.PreferredBackupStartTimeUTC;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferredBackupTime))
            {
                query["PreferredBackupTime"] = request.PreferredBackupTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBackupPolicy",
                Version = "2019-01-01",
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
         * @param request ModifyBackupPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyBackupPolicyResponse
         */
        public async Task<ModifyBackupPolicyResponse> ModifyBackupPolicyWithOptionsAsync(ModifyBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferredBackupEndTimeUTC))
            {
                query["PreferredBackupEndTimeUTC"] = request.PreferredBackupEndTimeUTC;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferredBackupPeriod))
            {
                query["PreferredBackupPeriod"] = request.PreferredBackupPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferredBackupStartTimeUTC))
            {
                query["PreferredBackupStartTimeUTC"] = request.PreferredBackupStartTimeUTC;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreferredBackupTime))
            {
                query["PreferredBackupTime"] = request.PreferredBackupTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBackupPolicy",
                Version = "2019-01-01",
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
         * @param request ModifyBackupPolicyRequest
         * @return ModifyBackupPolicyResponse
         */
        public ModifyBackupPolicyResponse ModifyBackupPolicy(ModifyBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBackupPolicyWithOptions(request, runtime);
        }

        /**
         * @param request ModifyBackupPolicyRequest
         * @return ModifyBackupPolicyResponse
         */
        public async Task<ModifyBackupPolicyResponse> ModifyBackupPolicyAsync(ModifyBackupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBackupPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyClusterDeletionProtectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyClusterDeletionProtectionResponse
         */
        public ModifyClusterDeletionProtectionResponse ModifyClusterDeletionProtectionWithOptions(ModifyClusterDeletionProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protection))
            {
                query["Protection"] = request.Protection;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterDeletionProtection",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterDeletionProtectionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyClusterDeletionProtectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyClusterDeletionProtectionResponse
         */
        public async Task<ModifyClusterDeletionProtectionResponse> ModifyClusterDeletionProtectionWithOptionsAsync(ModifyClusterDeletionProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protection))
            {
                query["Protection"] = request.Protection;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterDeletionProtection",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterDeletionProtectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyClusterDeletionProtectionRequest
         * @return ModifyClusterDeletionProtectionResponse
         */
        public ModifyClusterDeletionProtectionResponse ModifyClusterDeletionProtection(ModifyClusterDeletionProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyClusterDeletionProtectionWithOptions(request, runtime);
        }

        /**
         * @param request ModifyClusterDeletionProtectionRequest
         * @return ModifyClusterDeletionProtectionResponse
         */
        public async Task<ModifyClusterDeletionProtectionResponse> ModifyClusterDeletionProtectionAsync(ModifyClusterDeletionProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyClusterDeletionProtectionWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyDiskWarningLineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDiskWarningLineResponse
         */
        public ModifyDiskWarningLineResponse ModifyDiskWarningLineWithOptions(ModifyDiskWarningLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarningLine))
            {
                query["WarningLine"] = request.WarningLine;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDiskWarningLine",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDiskWarningLineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyDiskWarningLineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDiskWarningLineResponse
         */
        public async Task<ModifyDiskWarningLineResponse> ModifyDiskWarningLineWithOptionsAsync(ModifyDiskWarningLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarningLine))
            {
                query["WarningLine"] = request.WarningLine;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDiskWarningLine",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDiskWarningLineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyDiskWarningLineRequest
         * @return ModifyDiskWarningLineResponse
         */
        public ModifyDiskWarningLineResponse ModifyDiskWarningLine(ModifyDiskWarningLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDiskWarningLineWithOptions(request, runtime);
        }

        /**
         * @param request ModifyDiskWarningLineRequest
         * @return ModifyDiskWarningLineResponse
         */
        public async Task<ModifyDiskWarningLineResponse> ModifyDiskWarningLineAsync(ModifyDiskWarningLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDiskWarningLineWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyInstanceMaintainTimeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceMaintainTimeResponse
         */
        public ModifyInstanceMaintainTimeResponse ModifyInstanceMaintainTimeWithOptions(ModifyInstanceMaintainTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaintainEndTime))
            {
                query["MaintainEndTime"] = request.MaintainEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaintainStartTime))
            {
                query["MaintainStartTime"] = request.MaintainStartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceMaintainTime",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceMaintainTimeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyInstanceMaintainTimeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceMaintainTimeResponse
         */
        public async Task<ModifyInstanceMaintainTimeResponse> ModifyInstanceMaintainTimeWithOptionsAsync(ModifyInstanceMaintainTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaintainEndTime))
            {
                query["MaintainEndTime"] = request.MaintainEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaintainStartTime))
            {
                query["MaintainStartTime"] = request.MaintainStartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceMaintainTime",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceMaintainTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyInstanceMaintainTimeRequest
         * @return ModifyInstanceMaintainTimeResponse
         */
        public ModifyInstanceMaintainTimeResponse ModifyInstanceMaintainTime(ModifyInstanceMaintainTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceMaintainTimeWithOptions(request, runtime);
        }

        /**
         * @param request ModifyInstanceMaintainTimeRequest
         * @return ModifyInstanceMaintainTimeResponse
         */
        public async Task<ModifyInstanceMaintainTimeResponse> ModifyInstanceMaintainTimeAsync(ModifyInstanceMaintainTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceMaintainTimeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyInstanceNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceNameResponse
         */
        public ModifyInstanceNameResponse ModifyInstanceNameWithOptions(ModifyInstanceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "ModifyInstanceName",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceNameResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyInstanceNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceNameResponse
         */
        public async Task<ModifyInstanceNameResponse> ModifyInstanceNameWithOptionsAsync(ModifyInstanceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "ModifyInstanceName",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyInstanceNameRequest
         * @return ModifyInstanceNameResponse
         */
        public ModifyInstanceNameResponse ModifyInstanceName(ModifyInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceNameWithOptions(request, runtime);
        }

        /**
         * @param request ModifyInstanceNameRequest
         * @return ModifyInstanceNameResponse
         */
        public async Task<ModifyInstanceNameResponse> ModifyInstanceNameAsync(ModifyInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceNameWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyInstanceServiceConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceServiceConfigResponse
         */
        public ModifyInstanceServiceConfigResponse ModifyInstanceServiceConfigWithOptions(ModifyInstanceServiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigureName))
            {
                query["ConfigureName"] = request.ConfigureName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigureValue))
            {
                query["ConfigureValue"] = request.ConfigureValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Restart))
            {
                query["Restart"] = request.Restart;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceServiceConfig",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceServiceConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyInstanceServiceConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceServiceConfigResponse
         */
        public async Task<ModifyInstanceServiceConfigResponse> ModifyInstanceServiceConfigWithOptionsAsync(ModifyInstanceServiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigureName))
            {
                query["ConfigureName"] = request.ConfigureName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigureValue))
            {
                query["ConfigureValue"] = request.ConfigureValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Restart))
            {
                query["Restart"] = request.Restart;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceServiceConfig",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceServiceConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyInstanceServiceConfigRequest
         * @return ModifyInstanceServiceConfigResponse
         */
        public ModifyInstanceServiceConfigResponse ModifyInstanceServiceConfig(ModifyInstanceServiceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceServiceConfigWithOptions(request, runtime);
        }

        /**
         * @param request ModifyInstanceServiceConfigRequest
         * @return ModifyInstanceServiceConfigResponse
         */
        public async Task<ModifyInstanceServiceConfigResponse> ModifyInstanceServiceConfigAsync(ModifyInstanceServiceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceServiceConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyInstanceTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceTypeResponse
         */
        public ModifyInstanceTypeResponse ModifyInstanceTypeWithOptions(ModifyInstanceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreInstanceType))
            {
                query["CoreInstanceType"] = request.CoreInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterInstanceType))
            {
                query["MasterInstanceType"] = request.MasterInstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceType",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceTypeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyInstanceTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceTypeResponse
         */
        public async Task<ModifyInstanceTypeResponse> ModifyInstanceTypeWithOptionsAsync(ModifyInstanceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreInstanceType))
            {
                query["CoreInstanceType"] = request.CoreInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterInstanceType))
            {
                query["MasterInstanceType"] = request.MasterInstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceType",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyInstanceTypeRequest
         * @return ModifyInstanceTypeResponse
         */
        public ModifyInstanceTypeResponse ModifyInstanceType(ModifyInstanceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceTypeWithOptions(request, runtime);
        }

        /**
         * @param request ModifyInstanceTypeRequest
         * @return ModifyInstanceTypeResponse
         */
        public async Task<ModifyInstanceTypeResponse> ModifyInstanceTypeAsync(ModifyInstanceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceTypeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyIpWhitelistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyIpWhitelistResponse
         */
        public ModifyIpWhitelistResponse ModifyIpWhitelistWithOptions(ModifyIpWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpList))
            {
                query["IpList"] = request.IpList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyIpWhitelist",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyIpWhitelistResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyIpWhitelistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyIpWhitelistResponse
         */
        public async Task<ModifyIpWhitelistResponse> ModifyIpWhitelistWithOptionsAsync(ModifyIpWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpList))
            {
                query["IpList"] = request.IpList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyIpWhitelist",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyIpWhitelistResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyIpWhitelistRequest
         * @return ModifyIpWhitelistResponse
         */
        public ModifyIpWhitelistResponse ModifyIpWhitelist(ModifyIpWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyIpWhitelistWithOptions(request, runtime);
        }

        /**
         * @param request ModifyIpWhitelistRequest
         * @return ModifyIpWhitelistResponse
         */
        public async Task<ModifyIpWhitelistResponse> ModifyIpWhitelistAsync(ModifyIpWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyIpWhitelistWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyMultiZoneClusterNodeTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyMultiZoneClusterNodeTypeResponse
         */
        public ModifyMultiZoneClusterNodeTypeResponse ModifyMultiZoneClusterNodeTypeWithOptions(ModifyMultiZoneClusterNodeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreInstanceType))
            {
                query["CoreInstanceType"] = request.CoreInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogInstanceType))
            {
                query["LogInstanceType"] = request.LogInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterInstanceType))
            {
                query["MasterInstanceType"] = request.MasterInstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMultiZoneClusterNodeType",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMultiZoneClusterNodeTypeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyMultiZoneClusterNodeTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyMultiZoneClusterNodeTypeResponse
         */
        public async Task<ModifyMultiZoneClusterNodeTypeResponse> ModifyMultiZoneClusterNodeTypeWithOptionsAsync(ModifyMultiZoneClusterNodeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreInstanceType))
            {
                query["CoreInstanceType"] = request.CoreInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogInstanceType))
            {
                query["LogInstanceType"] = request.LogInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterInstanceType))
            {
                query["MasterInstanceType"] = request.MasterInstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMultiZoneClusterNodeType",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMultiZoneClusterNodeTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyMultiZoneClusterNodeTypeRequest
         * @return ModifyMultiZoneClusterNodeTypeResponse
         */
        public ModifyMultiZoneClusterNodeTypeResponse ModifyMultiZoneClusterNodeType(ModifyMultiZoneClusterNodeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMultiZoneClusterNodeTypeWithOptions(request, runtime);
        }

        /**
         * @param request ModifyMultiZoneClusterNodeTypeRequest
         * @return ModifyMultiZoneClusterNodeTypeResponse
         */
        public async Task<ModifyMultiZoneClusterNodeTypeResponse> ModifyMultiZoneClusterNodeTypeAsync(ModifyMultiZoneClusterNodeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMultiZoneClusterNodeTypeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifySecurityGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifySecurityGroupsResponse
         */
        public ModifySecurityGroupsResponse ModifySecurityGroupsWithOptions(ModifySecurityGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupIds))
            {
                query["SecurityGroupIds"] = request.SecurityGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySecurityGroups",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySecurityGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifySecurityGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifySecurityGroupsResponse
         */
        public async Task<ModifySecurityGroupsResponse> ModifySecurityGroupsWithOptionsAsync(ModifySecurityGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupIds))
            {
                query["SecurityGroupIds"] = request.SecurityGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySecurityGroups",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySecurityGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifySecurityGroupsRequest
         * @return ModifySecurityGroupsResponse
         */
        public ModifySecurityGroupsResponse ModifySecurityGroups(ModifySecurityGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySecurityGroupsWithOptions(request, runtime);
        }

        /**
         * @param request ModifySecurityGroupsRequest
         * @return ModifySecurityGroupsResponse
         */
        public async Task<ModifySecurityGroupsResponse> ModifySecurityGroupsAsync(ModifySecurityGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySecurityGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyUIAccountPasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyUIAccountPasswordResponse
         */
        public ModifyUIAccountPasswordResponse ModifyUIAccountPasswordWithOptions(ModifyUIAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyUIAccountPassword",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyUIAccountPasswordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyUIAccountPasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyUIAccountPasswordResponse
         */
        public async Task<ModifyUIAccountPasswordResponse> ModifyUIAccountPasswordWithOptionsAsync(ModifyUIAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyUIAccountPassword",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyUIAccountPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyUIAccountPasswordRequest
         * @return ModifyUIAccountPasswordResponse
         */
        public ModifyUIAccountPasswordResponse ModifyUIAccountPassword(ModifyUIAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyUIAccountPasswordWithOptions(request, runtime);
        }

        /**
         * @param request ModifyUIAccountPasswordRequest
         * @return ModifyUIAccountPasswordResponse
         */
        public async Task<ModifyUIAccountPasswordResponse> ModifyUIAccountPasswordAsync(ModifyUIAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyUIAccountPasswordWithOptionsAsync(request, runtime);
        }

        /**
         * @param request MoveResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MoveResourceGroupResponse
         */
        public MoveResourceGroupResponse MoveResourceGroupWithOptions(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveResourceGroup",
                Version = "2019-01-01",
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
         * @param request MoveResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MoveResourceGroupResponse
         */
        public async Task<MoveResourceGroupResponse> MoveResourceGroupWithOptionsAsync(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveResourceGroup",
                Version = "2019-01-01",
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
         * @param request MoveResourceGroupRequest
         * @return MoveResourceGroupResponse
         */
        public MoveResourceGroupResponse MoveResourceGroup(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveResourceGroupWithOptions(request, runtime);
        }

        /**
         * @param request MoveResourceGroupRequest
         * @return MoveResourceGroupResponse
         */
        public async Task<MoveResourceGroupResponse> MoveResourceGroupAsync(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @param request OpenBackupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenBackupResponse
         */
        public OpenBackupResponse OpenBackupWithOptions(OpenBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenBackup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenBackupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request OpenBackupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenBackupResponse
         */
        public async Task<OpenBackupResponse> OpenBackupWithOptionsAsync(OpenBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenBackup",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenBackupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request OpenBackupRequest
         * @return OpenBackupResponse
         */
        public OpenBackupResponse OpenBackup(OpenBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenBackupWithOptions(request, runtime);
        }

        /**
         * @param request OpenBackupRequest
         * @return OpenBackupResponse
         */
        public async Task<OpenBackupResponse> OpenBackupAsync(OpenBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenBackupWithOptionsAsync(request, runtime);
        }

        /**
         * @param request PurgeInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PurgeInstanceResponse
         */
        public PurgeInstanceResponse PurgeInstanceWithOptions(PurgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PurgeInstance",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PurgeInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request PurgeInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PurgeInstanceResponse
         */
        public async Task<PurgeInstanceResponse> PurgeInstanceWithOptionsAsync(PurgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PurgeInstance",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PurgeInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request PurgeInstanceRequest
         * @return PurgeInstanceResponse
         */
        public PurgeInstanceResponse PurgeInstance(PurgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PurgeInstanceWithOptions(request, runtime);
        }

        /**
         * @param request PurgeInstanceRequest
         * @return PurgeInstanceResponse
         */
        public async Task<PurgeInstanceResponse> PurgeInstanceAsync(PurgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PurgeInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryHBaseHaDBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryHBaseHaDBResponse
         */
        public QueryHBaseHaDBResponse QueryHBaseHaDBWithOptions(QueryHBaseHaDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BdsId))
            {
                query["BdsId"] = request.BdsId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryHBaseHaDB",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHBaseHaDBResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QueryHBaseHaDBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryHBaseHaDBResponse
         */
        public async Task<QueryHBaseHaDBResponse> QueryHBaseHaDBWithOptionsAsync(QueryHBaseHaDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BdsId))
            {
                query["BdsId"] = request.BdsId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryHBaseHaDB",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHBaseHaDBResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QueryHBaseHaDBRequest
         * @return QueryHBaseHaDBResponse
         */
        public QueryHBaseHaDBResponse QueryHBaseHaDB(QueryHBaseHaDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryHBaseHaDBWithOptions(request, runtime);
        }

        /**
         * @param request QueryHBaseHaDBRequest
         * @return QueryHBaseHaDBResponse
         */
        public async Task<QueryHBaseHaDBResponse> QueryHBaseHaDBAsync(QueryHBaseHaDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryHBaseHaDBWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryXpackRelateDBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryXpackRelateDBResponse
         */
        public QueryXpackRelateDBResponse QueryXpackRelateDBWithOptions(QueryXpackRelateDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasSingleNode))
            {
                query["HasSingleNode"] = request.HasSingleNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelateDbType))
            {
                query["RelateDbType"] = request.RelateDbType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryXpackRelateDB",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryXpackRelateDBResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QueryXpackRelateDBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryXpackRelateDBResponse
         */
        public async Task<QueryXpackRelateDBResponse> QueryXpackRelateDBWithOptionsAsync(QueryXpackRelateDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasSingleNode))
            {
                query["HasSingleNode"] = request.HasSingleNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelateDbType))
            {
                query["RelateDbType"] = request.RelateDbType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryXpackRelateDB",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryXpackRelateDBResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QueryXpackRelateDBRequest
         * @return QueryXpackRelateDBResponse
         */
        public QueryXpackRelateDBResponse QueryXpackRelateDB(QueryXpackRelateDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryXpackRelateDBWithOptions(request, runtime);
        }

        /**
         * @param request QueryXpackRelateDBRequest
         * @return QueryXpackRelateDBResponse
         */
        public async Task<QueryXpackRelateDBResponse> QueryXpackRelateDBAsync(QueryXpackRelateDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryXpackRelateDBWithOptionsAsync(request, runtime);
        }

        /**
         * @param request RelateDbForHBaseHaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RelateDbForHBaseHaResponse
         */
        public RelateDbForHBaseHaResponse RelateDbForHBaseHaWithOptions(RelateDbForHBaseHaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaActive))
            {
                query["HaActive"] = request.HaActive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaActiveClusterKey))
            {
                query["HaActiveClusterKey"] = request.HaActiveClusterKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaActiveDBType))
            {
                query["HaActiveDBType"] = request.HaActiveDBType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaActiveHbaseFsDir))
            {
                query["HaActiveHbaseFsDir"] = request.HaActiveHbaseFsDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaActiveHdfsUri))
            {
                query["HaActiveHdfsUri"] = request.HaActiveHdfsUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaActivePassword))
            {
                query["HaActivePassword"] = request.HaActivePassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaActiveUser))
            {
                query["HaActiveUser"] = request.HaActiveUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaActiveVersion))
            {
                query["HaActiveVersion"] = request.HaActiveVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaMigrateType))
            {
                query["HaMigrateType"] = request.HaMigrateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaStandby))
            {
                query["HaStandby"] = request.HaStandby;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaStandbyClusterKey))
            {
                query["HaStandbyClusterKey"] = request.HaStandbyClusterKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaStandbyDBType))
            {
                query["HaStandbyDBType"] = request.HaStandbyDBType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaStandbyHbaseFsDir))
            {
                query["HaStandbyHbaseFsDir"] = request.HaStandbyHbaseFsDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaStandbyHdfsUri))
            {
                query["HaStandbyHdfsUri"] = request.HaStandbyHdfsUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaStandbyPassword))
            {
                query["HaStandbyPassword"] = request.HaStandbyPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaStandbyUser))
            {
                query["HaStandbyUser"] = request.HaStandbyUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaStandbyVersion))
            {
                query["HaStandbyVersion"] = request.HaStandbyVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaTables))
            {
                query["HaTables"] = request.HaTables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsActiveStandard))
            {
                query["IsActiveStandard"] = request.IsActiveStandard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsStandbyStandard))
            {
                query["IsStandbyStandard"] = request.IsStandbyStandard;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RelateDbForHBaseHa",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RelateDbForHBaseHaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request RelateDbForHBaseHaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RelateDbForHBaseHaResponse
         */
        public async Task<RelateDbForHBaseHaResponse> RelateDbForHBaseHaWithOptionsAsync(RelateDbForHBaseHaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaActive))
            {
                query["HaActive"] = request.HaActive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaActiveClusterKey))
            {
                query["HaActiveClusterKey"] = request.HaActiveClusterKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaActiveDBType))
            {
                query["HaActiveDBType"] = request.HaActiveDBType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaActiveHbaseFsDir))
            {
                query["HaActiveHbaseFsDir"] = request.HaActiveHbaseFsDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaActiveHdfsUri))
            {
                query["HaActiveHdfsUri"] = request.HaActiveHdfsUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaActivePassword))
            {
                query["HaActivePassword"] = request.HaActivePassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaActiveUser))
            {
                query["HaActiveUser"] = request.HaActiveUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaActiveVersion))
            {
                query["HaActiveVersion"] = request.HaActiveVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaMigrateType))
            {
                query["HaMigrateType"] = request.HaMigrateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaStandby))
            {
                query["HaStandby"] = request.HaStandby;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaStandbyClusterKey))
            {
                query["HaStandbyClusterKey"] = request.HaStandbyClusterKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaStandbyDBType))
            {
                query["HaStandbyDBType"] = request.HaStandbyDBType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaStandbyHbaseFsDir))
            {
                query["HaStandbyHbaseFsDir"] = request.HaStandbyHbaseFsDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaStandbyHdfsUri))
            {
                query["HaStandbyHdfsUri"] = request.HaStandbyHdfsUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaStandbyPassword))
            {
                query["HaStandbyPassword"] = request.HaStandbyPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaStandbyUser))
            {
                query["HaStandbyUser"] = request.HaStandbyUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaStandbyVersion))
            {
                query["HaStandbyVersion"] = request.HaStandbyVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaTables))
            {
                query["HaTables"] = request.HaTables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsActiveStandard))
            {
                query["IsActiveStandard"] = request.IsActiveStandard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsStandbyStandard))
            {
                query["IsStandbyStandard"] = request.IsStandbyStandard;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RelateDbForHBaseHa",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RelateDbForHBaseHaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request RelateDbForHBaseHaRequest
         * @return RelateDbForHBaseHaResponse
         */
        public RelateDbForHBaseHaResponse RelateDbForHBaseHa(RelateDbForHBaseHaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RelateDbForHBaseHaWithOptions(request, runtime);
        }

        /**
         * @param request RelateDbForHBaseHaRequest
         * @return RelateDbForHBaseHaResponse
         */
        public async Task<RelateDbForHBaseHaResponse> RelateDbForHBaseHaAsync(RelateDbForHBaseHaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RelateDbForHBaseHaWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ReleasePublicNetworkAddressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleasePublicNetworkAddressResponse
         */
        public ReleasePublicNetworkAddressResponse ReleasePublicNetworkAddressWithOptions(ReleasePublicNetworkAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleasePublicNetworkAddress",
                Version = "2019-01-01",
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
         * @param request ReleasePublicNetworkAddressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleasePublicNetworkAddressResponse
         */
        public async Task<ReleasePublicNetworkAddressResponse> ReleasePublicNetworkAddressWithOptionsAsync(ReleasePublicNetworkAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleasePublicNetworkAddress",
                Version = "2019-01-01",
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
         * @param request ReleasePublicNetworkAddressRequest
         * @return ReleasePublicNetworkAddressResponse
         */
        public ReleasePublicNetworkAddressResponse ReleasePublicNetworkAddress(ReleasePublicNetworkAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleasePublicNetworkAddressWithOptions(request, runtime);
        }

        /**
         * @param request ReleasePublicNetworkAddressRequest
         * @return ReleasePublicNetworkAddressResponse
         */
        public async Task<ReleasePublicNetworkAddressResponse> ReleasePublicNetworkAddressAsync(ReleasePublicNetworkAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleasePublicNetworkAddressWithOptionsAsync(request, runtime);
        }

        /**
         * @param request RenewInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenewInstanceResponse
         */
        public RenewInstanceResponse RenewInstanceWithOptions(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewInstance",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request RenewInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenewInstanceResponse
         */
        public async Task<RenewInstanceResponse> RenewInstanceWithOptionsAsync(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewInstance",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request RenewInstanceRequest
         * @return RenewInstanceResponse
         */
        public RenewInstanceResponse RenewInstance(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewInstanceWithOptions(request, runtime);
        }

        /**
         * @param request RenewInstanceRequest
         * @return RenewInstanceResponse
         */
        public async Task<RenewInstanceResponse> RenewInstanceAsync(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ResizeColdStorageSizeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResizeColdStorageSizeResponse
         */
        public ResizeColdStorageSizeResponse ResizeColdStorageSizeWithOptions(ResizeColdStorageSizeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColdStorageSize))
            {
                query["ColdStorageSize"] = request.ColdStorageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResizeColdStorageSize",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResizeColdStorageSizeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ResizeColdStorageSizeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResizeColdStorageSizeResponse
         */
        public async Task<ResizeColdStorageSizeResponse> ResizeColdStorageSizeWithOptionsAsync(ResizeColdStorageSizeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColdStorageSize))
            {
                query["ColdStorageSize"] = request.ColdStorageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResizeColdStorageSize",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResizeColdStorageSizeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ResizeColdStorageSizeRequest
         * @return ResizeColdStorageSizeResponse
         */
        public ResizeColdStorageSizeResponse ResizeColdStorageSize(ResizeColdStorageSizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResizeColdStorageSizeWithOptions(request, runtime);
        }

        /**
         * @param request ResizeColdStorageSizeRequest
         * @return ResizeColdStorageSizeResponse
         */
        public async Task<ResizeColdStorageSizeResponse> ResizeColdStorageSizeAsync(ResizeColdStorageSizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResizeColdStorageSizeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ResizeDiskSizeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResizeDiskSizeResponse
         */
        public ResizeDiskSizeResponse ResizeDiskSizeWithOptions(ResizeDiskSizeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeDiskSize))
            {
                query["NodeDiskSize"] = request.NodeDiskSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResizeDiskSize",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResizeDiskSizeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ResizeDiskSizeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResizeDiskSizeResponse
         */
        public async Task<ResizeDiskSizeResponse> ResizeDiskSizeWithOptionsAsync(ResizeDiskSizeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeDiskSize))
            {
                query["NodeDiskSize"] = request.NodeDiskSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResizeDiskSize",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResizeDiskSizeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ResizeDiskSizeRequest
         * @return ResizeDiskSizeResponse
         */
        public ResizeDiskSizeResponse ResizeDiskSize(ResizeDiskSizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResizeDiskSizeWithOptions(request, runtime);
        }

        /**
         * @param request ResizeDiskSizeRequest
         * @return ResizeDiskSizeResponse
         */
        public async Task<ResizeDiskSizeResponse> ResizeDiskSizeAsync(ResizeDiskSizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResizeDiskSizeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ResizeMultiZoneClusterDiskSizeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResizeMultiZoneClusterDiskSizeResponse
         */
        public ResizeMultiZoneClusterDiskSizeResponse ResizeMultiZoneClusterDiskSizeWithOptions(ResizeMultiZoneClusterDiskSizeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreDiskSize))
            {
                query["CoreDiskSize"] = request.CoreDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogDiskSize))
            {
                query["LogDiskSize"] = request.LogDiskSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResizeMultiZoneClusterDiskSize",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResizeMultiZoneClusterDiskSizeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ResizeMultiZoneClusterDiskSizeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResizeMultiZoneClusterDiskSizeResponse
         */
        public async Task<ResizeMultiZoneClusterDiskSizeResponse> ResizeMultiZoneClusterDiskSizeWithOptionsAsync(ResizeMultiZoneClusterDiskSizeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreDiskSize))
            {
                query["CoreDiskSize"] = request.CoreDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogDiskSize))
            {
                query["LogDiskSize"] = request.LogDiskSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResizeMultiZoneClusterDiskSize",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResizeMultiZoneClusterDiskSizeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ResizeMultiZoneClusterDiskSizeRequest
         * @return ResizeMultiZoneClusterDiskSizeResponse
         */
        public ResizeMultiZoneClusterDiskSizeResponse ResizeMultiZoneClusterDiskSize(ResizeMultiZoneClusterDiskSizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResizeMultiZoneClusterDiskSizeWithOptions(request, runtime);
        }

        /**
         * @param request ResizeMultiZoneClusterDiskSizeRequest
         * @return ResizeMultiZoneClusterDiskSizeResponse
         */
        public async Task<ResizeMultiZoneClusterDiskSizeResponse> ResizeMultiZoneClusterDiskSizeAsync(ResizeMultiZoneClusterDiskSizeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResizeMultiZoneClusterDiskSizeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ResizeMultiZoneClusterNodeCountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResizeMultiZoneClusterNodeCountResponse
         */
        public ResizeMultiZoneClusterNodeCountResponse ResizeMultiZoneClusterNodeCountWithOptions(ResizeMultiZoneClusterNodeCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArbiterVSwitchId))
            {
                query["ArbiterVSwitchId"] = request.ArbiterVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreNodeCount))
            {
                query["CoreNodeCount"] = request.CoreNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogNodeCount))
            {
                query["LogNodeCount"] = request.LogNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryCoreNodeCount))
            {
                query["PrimaryCoreNodeCount"] = request.PrimaryCoreNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryVSwitchId))
            {
                query["PrimaryVSwitchId"] = request.PrimaryVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandbyCoreNodeCount))
            {
                query["StandbyCoreNodeCount"] = request.StandbyCoreNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandbyVSwitchId))
            {
                query["StandbyVSwitchId"] = request.StandbyVSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResizeMultiZoneClusterNodeCount",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResizeMultiZoneClusterNodeCountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ResizeMultiZoneClusterNodeCountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResizeMultiZoneClusterNodeCountResponse
         */
        public async Task<ResizeMultiZoneClusterNodeCountResponse> ResizeMultiZoneClusterNodeCountWithOptionsAsync(ResizeMultiZoneClusterNodeCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArbiterVSwitchId))
            {
                query["ArbiterVSwitchId"] = request.ArbiterVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoreNodeCount))
            {
                query["CoreNodeCount"] = request.CoreNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogNodeCount))
            {
                query["LogNodeCount"] = request.LogNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryCoreNodeCount))
            {
                query["PrimaryCoreNodeCount"] = request.PrimaryCoreNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryVSwitchId))
            {
                query["PrimaryVSwitchId"] = request.PrimaryVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandbyCoreNodeCount))
            {
                query["StandbyCoreNodeCount"] = request.StandbyCoreNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandbyVSwitchId))
            {
                query["StandbyVSwitchId"] = request.StandbyVSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResizeMultiZoneClusterNodeCount",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResizeMultiZoneClusterNodeCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ResizeMultiZoneClusterNodeCountRequest
         * @return ResizeMultiZoneClusterNodeCountResponse
         */
        public ResizeMultiZoneClusterNodeCountResponse ResizeMultiZoneClusterNodeCount(ResizeMultiZoneClusterNodeCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResizeMultiZoneClusterNodeCountWithOptions(request, runtime);
        }

        /**
         * @param request ResizeMultiZoneClusterNodeCountRequest
         * @return ResizeMultiZoneClusterNodeCountResponse
         */
        public async Task<ResizeMultiZoneClusterNodeCountResponse> ResizeMultiZoneClusterNodeCountAsync(ResizeMultiZoneClusterNodeCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResizeMultiZoneClusterNodeCountWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ResizeNodeCountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResizeNodeCountResponse
         */
        public ResizeNodeCountResponse ResizeNodeCountWithOptions(ResizeNodeCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeCount))
            {
                query["NodeCount"] = request.NodeCount;
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
                Action = "ResizeNodeCount",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResizeNodeCountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ResizeNodeCountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResizeNodeCountResponse
         */
        public async Task<ResizeNodeCountResponse> ResizeNodeCountWithOptionsAsync(ResizeNodeCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeCount))
            {
                query["NodeCount"] = request.NodeCount;
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
                Action = "ResizeNodeCount",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResizeNodeCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ResizeNodeCountRequest
         * @return ResizeNodeCountResponse
         */
        public ResizeNodeCountResponse ResizeNodeCount(ResizeNodeCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResizeNodeCountWithOptions(request, runtime);
        }

        /**
         * @param request ResizeNodeCountRequest
         * @return ResizeNodeCountResponse
         */
        public async Task<ResizeNodeCountResponse> ResizeNodeCountAsync(ResizeNodeCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResizeNodeCountWithOptionsAsync(request, runtime);
        }

        /**
         * @param request RestartInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestartInstanceResponse
         */
        public RestartInstanceResponse RestartInstanceWithOptions(RestartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Components))
            {
                query["Components"] = request.Components;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartInstance",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request RestartInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestartInstanceResponse
         */
        public async Task<RestartInstanceResponse> RestartInstanceWithOptionsAsync(RestartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Components))
            {
                query["Components"] = request.Components;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartInstance",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request RestartInstanceRequest
         * @return RestartInstanceResponse
         */
        public RestartInstanceResponse RestartInstance(RestartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartInstanceWithOptions(request, runtime);
        }

        /**
         * @param request RestartInstanceRequest
         * @return RestartInstanceResponse
         */
        public async Task<RestartInstanceResponse> RestartInstanceAsync(RestartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 回收账户权限
         *
         * @param request RevokeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeResponse
         */
        public RevokeResponse RevokeWithOptions(RevokeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclActions))
            {
                query["AclActions"] = request.AclActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Revoke",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 回收账户权限
         *
         * @param request RevokeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeResponse
         */
        public async Task<RevokeResponse> RevokeWithOptionsAsync(RevokeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclActions))
            {
                query["AclActions"] = request.AclActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Revoke",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 回收账户权限
         *
         * @param request RevokeRequest
         * @return RevokeResponse
         */
        public RevokeResponse Revoke(RevokeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeWithOptions(request, runtime);
        }

        /**
         * @summary 回收账户权限
         *
         * @param request RevokeRequest
         * @return RevokeResponse
         */
        public async Task<RevokeResponse> RevokeAsync(RevokeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SwitchHbaseHaSlbRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SwitchHbaseHaSlbResponse
         */
        public SwitchHbaseHaSlbResponse SwitchHbaseHaSlbWithOptions(SwitchHbaseHaSlbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BdsId))
            {
                query["BdsId"] = request.BdsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaId))
            {
                query["HaId"] = request.HaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaTypes))
            {
                query["HaTypes"] = request.HaTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HbaseType))
            {
                query["HbaseType"] = request.HbaseType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchHbaseHaSlb",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchHbaseHaSlbResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request SwitchHbaseHaSlbRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SwitchHbaseHaSlbResponse
         */
        public async Task<SwitchHbaseHaSlbResponse> SwitchHbaseHaSlbWithOptionsAsync(SwitchHbaseHaSlbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BdsId))
            {
                query["BdsId"] = request.BdsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaId))
            {
                query["HaId"] = request.HaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HaTypes))
            {
                query["HaTypes"] = request.HaTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HbaseType))
            {
                query["HbaseType"] = request.HbaseType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchHbaseHaSlb",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchHbaseHaSlbResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request SwitchHbaseHaSlbRequest
         * @return SwitchHbaseHaSlbResponse
         */
        public SwitchHbaseHaSlbResponse SwitchHbaseHaSlb(SwitchHbaseHaSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchHbaseHaSlbWithOptions(request, runtime);
        }

        /**
         * @param request SwitchHbaseHaSlbRequest
         * @return SwitchHbaseHaSlbResponse
         */
        public async Task<SwitchHbaseHaSlbResponse> SwitchHbaseHaSlbAsync(SwitchHbaseHaSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchHbaseHaSlbWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 开通/关闭 扩展服务
         *
         * @param request SwitchServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SwitchServiceResponse
         */
        public SwitchServiceResponse SwitchServiceWithOptions(SwitchServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operate))
            {
                query["Operate"] = request.Operate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchService",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 开通/关闭 扩展服务
         *
         * @param request SwitchServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SwitchServiceResponse
         */
        public async Task<SwitchServiceResponse> SwitchServiceWithOptionsAsync(SwitchServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operate))
            {
                query["Operate"] = request.Operate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchService",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 开通/关闭 扩展服务
         *
         * @param request SwitchServiceRequest
         * @return SwitchServiceResponse
         */
        public SwitchServiceResponse SwitchService(SwitchServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchServiceWithOptions(request, runtime);
        }

        /**
         * @summary 开通/关闭 扩展服务
         *
         * @param request SwitchServiceRequest
         * @return SwitchServiceResponse
         */
        public async Task<SwitchServiceResponse> SwitchServiceAsync(SwitchServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchServiceWithOptionsAsync(request, runtime);
        }

        /**
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
                Version = "2019-01-01",
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
                Version = "2019-01-01",
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
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /**
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UnTagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnTagResourcesResponse
         */
        public UnTagResourcesResponse UnTagResourcesWithOptions(UnTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UnTagResources",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UnTagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnTagResourcesResponse
         */
        public async Task<UnTagResourcesResponse> UnTagResourcesWithOptionsAsync(UnTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UnTagResources",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UnTagResourcesRequest
         * @return UnTagResourcesResponse
         */
        public UnTagResourcesResponse UnTagResources(UnTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnTagResourcesWithOptions(request, runtime);
        }

        /**
         * @param request UnTagResourcesRequest
         * @return UnTagResourcesResponse
         */
        public async Task<UnTagResourcesResponse> UnTagResourcesAsync(UnTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnTagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpgradeMinorVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeMinorVersionResponse
         */
        public UpgradeMinorVersionResponse UpgradeMinorVersionWithOptions(UpgradeMinorVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Components))
            {
                query["Components"] = request.Components;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeMinorVersion",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeMinorVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpgradeMinorVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeMinorVersionResponse
         */
        public async Task<UpgradeMinorVersionResponse> UpgradeMinorVersionWithOptionsAsync(UpgradeMinorVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Components))
            {
                query["Components"] = request.Components;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeMinorVersion",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeMinorVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpgradeMinorVersionRequest
         * @return UpgradeMinorVersionResponse
         */
        public UpgradeMinorVersionResponse UpgradeMinorVersion(UpgradeMinorVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeMinorVersionWithOptions(request, runtime);
        }

        /**
         * @param request UpgradeMinorVersionRequest
         * @return UpgradeMinorVersionResponse
         */
        public async Task<UpgradeMinorVersionResponse> UpgradeMinorVersionAsync(UpgradeMinorVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeMinorVersionWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpgradeMultiZoneClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeMultiZoneClusterResponse
         */
        public UpgradeMultiZoneClusterResponse UpgradeMultiZoneClusterWithOptions(UpgradeMultiZoneClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Components))
            {
                query["Components"] = request.Components;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestartComponents))
            {
                query["RestartComponents"] = request.RestartComponents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunMode))
            {
                query["RunMode"] = request.RunMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeInsName))
            {
                query["UpgradeInsName"] = request.UpgradeInsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Versions))
            {
                query["Versions"] = request.Versions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeMultiZoneCluster",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeMultiZoneClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpgradeMultiZoneClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeMultiZoneClusterResponse
         */
        public async Task<UpgradeMultiZoneClusterResponse> UpgradeMultiZoneClusterWithOptionsAsync(UpgradeMultiZoneClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Components))
            {
                query["Components"] = request.Components;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestartComponents))
            {
                query["RestartComponents"] = request.RestartComponents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunMode))
            {
                query["RunMode"] = request.RunMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeInsName))
            {
                query["UpgradeInsName"] = request.UpgradeInsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Versions))
            {
                query["Versions"] = request.Versions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeMultiZoneCluster",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeMultiZoneClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpgradeMultiZoneClusterRequest
         * @return UpgradeMultiZoneClusterResponse
         */
        public UpgradeMultiZoneClusterResponse UpgradeMultiZoneCluster(UpgradeMultiZoneClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeMultiZoneClusterWithOptions(request, runtime);
        }

        /**
         * @param request UpgradeMultiZoneClusterRequest
         * @return UpgradeMultiZoneClusterResponse
         */
        public async Task<UpgradeMultiZoneClusterResponse> UpgradeMultiZoneClusterAsync(UpgradeMultiZoneClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeMultiZoneClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @param request XpackRelateDBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return XpackRelateDBResponse
         */
        public XpackRelateDBResponse XpackRelateDBWithOptions(XpackRelateDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbClusterIds))
            {
                query["DbClusterIds"] = request.DbClusterIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelateDbType))
            {
                query["RelateDbType"] = request.RelateDbType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "XpackRelateDB",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<XpackRelateDBResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request XpackRelateDBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return XpackRelateDBResponse
         */
        public async Task<XpackRelateDBResponse> XpackRelateDBWithOptionsAsync(XpackRelateDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbClusterIds))
            {
                query["DbClusterIds"] = request.DbClusterIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelateDbType))
            {
                query["RelateDbType"] = request.RelateDbType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "XpackRelateDB",
                Version = "2019-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<XpackRelateDBResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request XpackRelateDBRequest
         * @return XpackRelateDBResponse
         */
        public XpackRelateDBResponse XpackRelateDB(XpackRelateDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return XpackRelateDBWithOptions(request, runtime);
        }

        /**
         * @param request XpackRelateDBRequest
         * @return XpackRelateDBResponse
         */
        public async Task<XpackRelateDBResponse> XpackRelateDBAsync(XpackRelateDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await XpackRelateDBWithOptionsAsync(request, runtime);
        }

    }
}
