// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Adb20211201.Models;

namespace AlibabaCloud.SDK.Adb20211201
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "adb.aliyuncs.com"},
                {"cn-beijing", "adb.aliyuncs.com"},
                {"cn-hangzhou", "adb.aliyuncs.com"},
                {"cn-shanghai", "adb.aliyuncs.com"},
                {"cn-shenzhen", "adb.aliyuncs.com"},
                {"cn-hongkong", "adb.aliyuncs.com"},
                {"ap-southeast-1", "adb.aliyuncs.com"},
                {"us-west-1", "adb.aliyuncs.com"},
                {"us-east-1", "adb.aliyuncs.com"},
                {"cn-hangzhou-finance", "adb.aliyuncs.com"},
                {"cn-north-2-gov-1", "adb.aliyuncs.com"},
                {"ap-northeast-2-pop", "adb.ap-northeast-1.aliyuncs.com"},
                {"cn-beijing-finance-1", "adb.aliyuncs.com"},
                {"cn-beijing-finance-pop", "adb.aliyuncs.com"},
                {"cn-beijing-gov-1", "adb.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "adb.aliyuncs.com"},
                {"cn-edge-1", "adb.aliyuncs.com"},
                {"cn-fujian", "adb.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "adb.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "adb.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "adb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "adb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "adb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "adb.aliyuncs.com"},
                {"cn-hangzhou-test-306", "adb.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "adb.aliyuncs.com"},
                {"cn-qingdao-nebula", "adb.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "adb.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "adb.aliyuncs.com"},
                {"cn-shanghai-finance-1", "adb.aliyuncs.com"},
                {"cn-shanghai-inner", "adb.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "adb.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "adb.aliyuncs.com"},
                {"cn-shenzhen-inner", "adb.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "adb.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "adb.aliyuncs.com"},
                {"cn-wuhan", "adb.aliyuncs.com"},
                {"cn-yushanfang", "adb.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "adb.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "adb.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "adb.aliyuncs.com"},
                {"eu-west-1-oxs", "adb.ap-northeast-1.aliyuncs.com"},
                {"me-east-1", "adb.ap-northeast-1.aliyuncs.com"},
                {"rus-west-1-pop", "adb.ap-northeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("adb", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary Applies for a public endpoint for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request AllocateClusterPublicConnectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AllocateClusterPublicConnectionResponse
         */
        public AllocateClusterPublicConnectionResponse AllocateClusterPublicConnectionWithOptions(AllocateClusterPublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionStringPrefix))
            {
                query["ConnectionStringPrefix"] = request.ConnectionStringPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "AllocateClusterPublicConnection",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllocateClusterPublicConnectionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Applies for a public endpoint for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request AllocateClusterPublicConnectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AllocateClusterPublicConnectionResponse
         */
        public async Task<AllocateClusterPublicConnectionResponse> AllocateClusterPublicConnectionWithOptionsAsync(AllocateClusterPublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionStringPrefix))
            {
                query["ConnectionStringPrefix"] = request.ConnectionStringPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "AllocateClusterPublicConnection",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllocateClusterPublicConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Applies for a public endpoint for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request AllocateClusterPublicConnectionRequest
         * @return AllocateClusterPublicConnectionResponse
         */
        public AllocateClusterPublicConnectionResponse AllocateClusterPublicConnection(AllocateClusterPublicConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocateClusterPublicConnectionWithOptions(request, runtime);
        }

        /**
         * @summary Applies for a public endpoint for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request AllocateClusterPublicConnectionRequest
         * @return AllocateClusterPublicConnectionResponse
         */
        public async Task<AllocateClusterPublicConnectionResponse> AllocateClusterPublicConnectionAsync(AllocateClusterPublicConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocateClusterPublicConnectionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Attaches an elastic network interface (ENI) to an AnalyticDB for MySQL Data Lakehouse Edition cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request AttachUserENIRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachUserENIResponse
         */
        public AttachUserENIResponse AttachUserENIWithOptions(AttachUserENIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachUserENI",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachUserENIResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Attaches an elastic network interface (ENI) to an AnalyticDB for MySQL Data Lakehouse Edition cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request AttachUserENIRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachUserENIResponse
         */
        public async Task<AttachUserENIResponse> AttachUserENIWithOptionsAsync(AttachUserENIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachUserENI",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachUserENIResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Attaches an elastic network interface (ENI) to an AnalyticDB for MySQL Data Lakehouse Edition cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request AttachUserENIRequest
         * @return AttachUserENIResponse
         */
        public AttachUserENIResponse AttachUserENI(AttachUserENIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachUserENIWithOptions(request, runtime);
        }

        /**
         * @summary Attaches an elastic network interface (ENI) to an AnalyticDB for MySQL Data Lakehouse Edition cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request AttachUserENIRequest
         * @return AttachUserENIResponse
         */
        public async Task<AttachUserENIResponse> AttachUserENIAsync(AttachUserENIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachUserENIWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Associates a standard account of an AnalyticDB for MySQL cluster with a Resource Access Management (RAM) user.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request BindAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindAccountResponse
         */
        public BindAccountResponse BindAccountWithOptions(BindAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamUser))
            {
                query["RamUser"] = request.RamUser;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAccount",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Associates a standard account of an AnalyticDB for MySQL cluster with a Resource Access Management (RAM) user.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request BindAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindAccountResponse
         */
        public async Task<BindAccountResponse> BindAccountWithOptionsAsync(BindAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamUser))
            {
                query["RamUser"] = request.RamUser;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAccount",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Associates a standard account of an AnalyticDB for MySQL cluster with a Resource Access Management (RAM) user.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request BindAccountRequest
         * @return BindAccountResponse
         */
        public BindAccountResponse BindAccount(BindAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAccountWithOptions(request, runtime);
        }

        /**
         * @summary Associates a standard account of an AnalyticDB for MySQL cluster with a Resource Access Management (RAM) user.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request BindAccountRequest
         * @return BindAccountResponse
         */
        public async Task<BindAccountResponse> BindAccountAsync(BindAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Associates a resource group with a database account.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request BindDBResourceGroupWithUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindDBResourceGroupWithUserResponse
         */
        public BindDBResourceGroupWithUserResponse BindDBResourceGroupWithUserWithOptions(BindDBResourceGroupWithUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupUser))
            {
                query["GroupUser"] = request.GroupUser;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindDBResourceGroupWithUser",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindDBResourceGroupWithUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Associates a resource group with a database account.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request BindDBResourceGroupWithUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindDBResourceGroupWithUserResponse
         */
        public async Task<BindDBResourceGroupWithUserResponse> BindDBResourceGroupWithUserWithOptionsAsync(BindDBResourceGroupWithUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupUser))
            {
                query["GroupUser"] = request.GroupUser;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindDBResourceGroupWithUser",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindDBResourceGroupWithUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Associates a resource group with a database account.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request BindDBResourceGroupWithUserRequest
         * @return BindDBResourceGroupWithUserResponse
         */
        public BindDBResourceGroupWithUserResponse BindDBResourceGroupWithUser(BindDBResourceGroupWithUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindDBResourceGroupWithUserWithOptions(request, runtime);
        }

        /**
         * @summary Associates a resource group with a database account.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request BindDBResourceGroupWithUserRequest
         * @return BindDBResourceGroupWithUserResponse
         */
        public async Task<BindDBResourceGroupWithUserResponse> BindDBResourceGroupWithUserAsync(BindDBResourceGroupWithUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindDBResourceGroupWithUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries whether a database account of an AnalyticDB for MySQL cluster is associated with a Resource Access Management (RAM) user.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request CheckBindRamUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckBindRamUserResponse
         */
        public CheckBindRamUserResponse CheckBindRamUserWithOptions(CheckBindRamUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "CheckBindRamUser",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckBindRamUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries whether a database account of an AnalyticDB for MySQL cluster is associated with a Resource Access Management (RAM) user.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request CheckBindRamUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckBindRamUserResponse
         */
        public async Task<CheckBindRamUserResponse> CheckBindRamUserWithOptionsAsync(CheckBindRamUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "CheckBindRamUser",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckBindRamUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries whether a database account of an AnalyticDB for MySQL cluster is associated with a Resource Access Management (RAM) user.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request CheckBindRamUserRequest
         * @return CheckBindRamUserResponse
         */
        public CheckBindRamUserResponse CheckBindRamUser(CheckBindRamUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckBindRamUserWithOptions(request, runtime);
        }

        /**
         * @summary Queries whether a database account of an AnalyticDB for MySQL cluster is associated with a Resource Access Management (RAM) user.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request CheckBindRamUserRequest
         * @return CheckBindRamUserResponse
         */
        public async Task<CheckBindRamUserResponse> CheckBindRamUserAsync(CheckBindRamUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckBindRamUserWithOptionsAsync(request, runtime);
        }

        /**
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request CheckSampleDataSetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckSampleDataSetResponse
         */
        public CheckSampleDataSetResponse CheckSampleDataSetWithOptions(CheckSampleDataSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckSampleDataSet",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckSampleDataSetResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request CheckSampleDataSetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckSampleDataSetResponse
         */
        public async Task<CheckSampleDataSetResponse> CheckSampleDataSetWithOptionsAsync(CheckSampleDataSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckSampleDataSet",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckSampleDataSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request CheckSampleDataSetRequest
         * @return CheckSampleDataSetResponse
         */
        public CheckSampleDataSetResponse CheckSampleDataSet(CheckSampleDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckSampleDataSetWithOptions(request, runtime);
        }

        /**
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request CheckSampleDataSetRequest
         * @return CheckSampleDataSetResponse
         */
        public async Task<CheckSampleDataSetResponse> CheckSampleDataSetAsync(CheckSampleDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckSampleDataSetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a database account for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request CreateAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAccountResponse
         */
        public CreateAccountResponse CreateAccountWithOptions(CreateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPassword))
            {
                query["AccountPassword"] = request.AccountPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "CreateAccount",
                Version = "2021-12-01",
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
         * @summary Creates a database account for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request CreateAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAccountResponse
         */
        public async Task<CreateAccountResponse> CreateAccountWithOptionsAsync(CreateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPassword))
            {
                query["AccountPassword"] = request.AccountPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["AccountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "CreateAccount",
                Version = "2021-12-01",
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
         * @summary Creates a database account for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
         * @summary Creates a database account for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
         * @summary Creates an AnalyticDB for MySQL Data Lakehouse Edition cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request CreateDBClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDBClusterResponse
         */
        public CreateDBClusterResponse CreateDBClusterWithOptions(CreateDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputeResource))
            {
                query["ComputeResource"] = request.ComputeResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterDescription))
            {
                query["DBClusterDescription"] = request.DBClusterDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterNetworkType))
            {
                query["DBClusterNetworkType"] = request.DBClusterNetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterVersion))
            {
                query["DBClusterVersion"] = request.DBClusterVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskEncryption))
            {
                query["DiskEncryption"] = request.DiskEncryption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableDefaultResourcePool))
            {
                query["EnableDefaultResourcePool"] = request.EnableDefaultResourcePool;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KmsId))
            {
                query["KmsId"] = request.KmsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductForm))
            {
                query["ProductForm"] = request.ProductForm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedNodeCount))
            {
                query["ReservedNodeCount"] = request.ReservedNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedNodeSize))
            {
                query["ReservedNodeSize"] = request.ReservedNodeSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreToTime))
            {
                query["RestoreToTime"] = request.RestoreToTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreType))
            {
                query["RestoreType"] = request.RestoreType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDbClusterId))
            {
                query["SourceDbClusterId"] = request.SourceDbClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageResource))
            {
                query["StorageResource"] = request.StorageResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedTime))
            {
                query["UsedTime"] = request.UsedTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VPCId))
            {
                query["VPCId"] = request.VPCId;
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
                Action = "CreateDBCluster",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDBClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an AnalyticDB for MySQL Data Lakehouse Edition cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request CreateDBClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDBClusterResponse
         */
        public async Task<CreateDBClusterResponse> CreateDBClusterWithOptionsAsync(CreateDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputeResource))
            {
                query["ComputeResource"] = request.ComputeResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterDescription))
            {
                query["DBClusterDescription"] = request.DBClusterDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterNetworkType))
            {
                query["DBClusterNetworkType"] = request.DBClusterNetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterVersion))
            {
                query["DBClusterVersion"] = request.DBClusterVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskEncryption))
            {
                query["DiskEncryption"] = request.DiskEncryption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableDefaultResourcePool))
            {
                query["EnableDefaultResourcePool"] = request.EnableDefaultResourcePool;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KmsId))
            {
                query["KmsId"] = request.KmsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                query["PayType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductForm))
            {
                query["ProductForm"] = request.ProductForm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedNodeCount))
            {
                query["ReservedNodeCount"] = request.ReservedNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedNodeSize))
            {
                query["ReservedNodeSize"] = request.ReservedNodeSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreToTime))
            {
                query["RestoreToTime"] = request.RestoreToTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreType))
            {
                query["RestoreType"] = request.RestoreType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDbClusterId))
            {
                query["SourceDbClusterId"] = request.SourceDbClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageResource))
            {
                query["StorageResource"] = request.StorageResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedTime))
            {
                query["UsedTime"] = request.UsedTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VPCId))
            {
                query["VPCId"] = request.VPCId;
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
                Action = "CreateDBCluster",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDBClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an AnalyticDB for MySQL Data Lakehouse Edition cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request CreateDBClusterRequest
         * @return CreateDBClusterResponse
         */
        public CreateDBClusterResponse CreateDBCluster(CreateDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDBClusterWithOptions(request, runtime);
        }

        /**
         * @summary Creates an AnalyticDB for MySQL Data Lakehouse Edition cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request CreateDBClusterRequest
         * @return CreateDBClusterResponse
         */
        public async Task<CreateDBClusterResponse> CreateDBClusterAsync(CreateDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDBClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a resource group for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param tmpReq CreateDBResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDBResourceGroupResponse
         */
        public CreateDBResourceGroupResponse CreateDBResourceGroupWithOptions(CreateDBResourceGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDBResourceGroupShrinkRequest request = new CreateDBResourceGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EngineParams))
            {
                request.EngineParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EngineParams, "EngineParams", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rules))
            {
                request.RulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rules, "Rules", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterMode))
            {
                query["ClusterMode"] = request.ClusterMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterSizeResource))
            {
                query["ClusterSizeResource"] = request.ClusterSizeResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSpot))
            {
                query["EnableSpot"] = request.EnableSpot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineParamsShrink))
            {
                query["EngineParams"] = request.EngineParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxClusterCount))
            {
                query["MaxClusterCount"] = request.MaxClusterCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxComputeResource))
            {
                query["MaxComputeResource"] = request.MaxComputeResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinClusterCount))
            {
                query["MinClusterCount"] = request.MinClusterCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinComputeResource))
            {
                query["MinComputeResource"] = request.MinComputeResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RulesShrink))
            {
                query["Rules"] = request.RulesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDBResourceGroup",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDBResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a resource group for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param tmpReq CreateDBResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDBResourceGroupResponse
         */
        public async Task<CreateDBResourceGroupResponse> CreateDBResourceGroupWithOptionsAsync(CreateDBResourceGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDBResourceGroupShrinkRequest request = new CreateDBResourceGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EngineParams))
            {
                request.EngineParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EngineParams, "EngineParams", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rules))
            {
                request.RulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rules, "Rules", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterMode))
            {
                query["ClusterMode"] = request.ClusterMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterSizeResource))
            {
                query["ClusterSizeResource"] = request.ClusterSizeResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSpot))
            {
                query["EnableSpot"] = request.EnableSpot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineParamsShrink))
            {
                query["EngineParams"] = request.EngineParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxClusterCount))
            {
                query["MaxClusterCount"] = request.MaxClusterCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxComputeResource))
            {
                query["MaxComputeResource"] = request.MaxComputeResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinClusterCount))
            {
                query["MinClusterCount"] = request.MinClusterCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinComputeResource))
            {
                query["MinComputeResource"] = request.MinComputeResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RulesShrink))
            {
                query["Rules"] = request.RulesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDBResourceGroup",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDBResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a resource group for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request CreateDBResourceGroupRequest
         * @return CreateDBResourceGroupResponse
         */
        public CreateDBResourceGroupResponse CreateDBResourceGroup(CreateDBResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDBResourceGroupWithOptions(request, runtime);
        }

        /**
         * @summary Creates a resource group for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request CreateDBResourceGroupRequest
         * @return CreateDBResourceGroupResponse
         */
        public async Task<CreateDBResourceGroupResponse> CreateDBResourceGroupAsync(CreateDBResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDBResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a scaling plan for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request CreateElasticPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateElasticPlanResponse
         */
        public CreateElasticPlanResponse CreateElasticPlanWithOptions(CreateElasticPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoScale))
            {
                query["AutoScale"] = request.AutoScale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CronExpression))
            {
                query["CronExpression"] = request.CronExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticPlanName))
            {
                query["ElasticPlanName"] = request.ElasticPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                query["ResourceGroupName"] = request.ResourceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSize))
            {
                query["TargetSize"] = request.TargetSize;
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
                Action = "CreateElasticPlan",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateElasticPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a scaling plan for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request CreateElasticPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateElasticPlanResponse
         */
        public async Task<CreateElasticPlanResponse> CreateElasticPlanWithOptionsAsync(CreateElasticPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoScale))
            {
                query["AutoScale"] = request.AutoScale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CronExpression))
            {
                query["CronExpression"] = request.CronExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticPlanName))
            {
                query["ElasticPlanName"] = request.ElasticPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                query["ResourceGroupName"] = request.ResourceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSize))
            {
                query["TargetSize"] = request.TargetSize;
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
                Action = "CreateElasticPlan",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateElasticPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a scaling plan for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request CreateElasticPlanRequest
         * @return CreateElasticPlanResponse
         */
        public CreateElasticPlanResponse CreateElasticPlan(CreateElasticPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateElasticPlanWithOptions(request, runtime);
        }

        /**
         * @summary Creates a scaling plan for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request CreateElasticPlanRequest
         * @return CreateElasticPlanResponse
         */
        public async Task<CreateElasticPlanResponse> CreateElasticPlanAsync(CreateElasticPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateElasticPlanWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an Object Storage Service (OSS) subdirectory.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request CreateOssSubDirectoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOssSubDirectoryResponse
         */
        public CreateOssSubDirectoryResponse CreateOssSubDirectoryWithOptions(CreateOssSubDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["Path"] = request.Path;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOssSubDirectory",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOssSubDirectoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an Object Storage Service (OSS) subdirectory.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request CreateOssSubDirectoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOssSubDirectoryResponse
         */
        public async Task<CreateOssSubDirectoryResponse> CreateOssSubDirectoryWithOptionsAsync(CreateOssSubDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["Path"] = request.Path;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOssSubDirectory",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOssSubDirectoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an Object Storage Service (OSS) subdirectory.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request CreateOssSubDirectoryRequest
         * @return CreateOssSubDirectoryResponse
         */
        public CreateOssSubDirectoryResponse CreateOssSubDirectory(CreateOssSubDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOssSubDirectoryWithOptions(request, runtime);
        }

        /**
         * @summary Creates an Object Storage Service (OSS) subdirectory.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request CreateOssSubDirectoryRequest
         * @return CreateOssSubDirectoryResponse
         */
        public async Task<CreateOssSubDirectoryResponse> CreateOssSubDirectoryAsync(CreateOssSubDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOssSubDirectoryWithOptionsAsync(request, runtime);
        }

        /**
         * @param tmpReq CreatePerformanceViewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePerformanceViewResponse
         */
        public CreatePerformanceViewResponse CreatePerformanceViewWithOptions(CreatePerformanceViewRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePerformanceViewShrinkRequest request = new CreatePerformanceViewShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ViewDetail))
            {
                request.ViewDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ViewDetail, "ViewDetail", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromViewType))
            {
                query["CreateFromViewType"] = request.CreateFromViewType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FillOriginViewKeys))
            {
                query["FillOriginViewKeys"] = request.FillOriginViewKeys;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewDetailShrink))
            {
                query["ViewDetail"] = request.ViewDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewName))
            {
                query["ViewName"] = request.ViewName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePerformanceView",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePerformanceViewResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param tmpReq CreatePerformanceViewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePerformanceViewResponse
         */
        public async Task<CreatePerformanceViewResponse> CreatePerformanceViewWithOptionsAsync(CreatePerformanceViewRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePerformanceViewShrinkRequest request = new CreatePerformanceViewShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ViewDetail))
            {
                request.ViewDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ViewDetail, "ViewDetail", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateFromViewType))
            {
                query["CreateFromViewType"] = request.CreateFromViewType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FillOriginViewKeys))
            {
                query["FillOriginViewKeys"] = request.FillOriginViewKeys;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewDetailShrink))
            {
                query["ViewDetail"] = request.ViewDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewName))
            {
                query["ViewName"] = request.ViewName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePerformanceView",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePerformanceViewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreatePerformanceViewRequest
         * @return CreatePerformanceViewResponse
         */
        public CreatePerformanceViewResponse CreatePerformanceView(CreatePerformanceViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePerformanceViewWithOptions(request, runtime);
        }

        /**
         * @param request CreatePerformanceViewRequest
         * @return CreatePerformanceViewResponse
         */
        public async Task<CreatePerformanceViewResponse> CreatePerformanceViewAsync(CreatePerformanceViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePerformanceViewWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a Spark application template.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request CreateSparkTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSparkTemplateResponse
         */
        public CreateSparkTemplateResponse CreateSparkTemplateWithOptions(CreateSparkTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["AppType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["ParentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSparkTemplate",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSparkTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a Spark application template.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request CreateSparkTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSparkTemplateResponse
         */
        public async Task<CreateSparkTemplateResponse> CreateSparkTemplateWithOptionsAsync(CreateSparkTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["AppType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["ParentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSparkTemplate",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSparkTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a Spark application template.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request CreateSparkTemplateRequest
         * @return CreateSparkTemplateResponse
         */
        public CreateSparkTemplateResponse CreateSparkTemplate(CreateSparkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSparkTemplateWithOptions(request, runtime);
        }

        /**
         * @summary Creates a Spark application template.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request CreateSparkTemplateRequest
         * @return CreateSparkTemplateResponse
         */
        public async Task<CreateSparkTemplateResponse> CreateSparkTemplateAsync(CreateSparkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSparkTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a database account from an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "DeleteAccount",
                Version = "2021-12-01",
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
         * @summary Deletes a database account from an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "DeleteAccount",
                Version = "2021-12-01",
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
         * @summary Deletes a database account from an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
         * @summary Deletes a database account from an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
         * @summary Deletes an AnalyticDB for MySQL cluster.
         *
         * @description ### [](#)
         * *   You can call this operation to delete only subscription clusters.
         * *   For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DeleteDBClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDBClusterResponse
         */
        public DeleteDBClusterResponse DeleteDBClusterWithOptions(DeleteDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDBCluster",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDBClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an AnalyticDB for MySQL cluster.
         *
         * @description ### [](#)
         * *   You can call this operation to delete only subscription clusters.
         * *   For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DeleteDBClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDBClusterResponse
         */
        public async Task<DeleteDBClusterResponse> DeleteDBClusterWithOptionsAsync(DeleteDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDBCluster",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDBClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an AnalyticDB for MySQL cluster.
         *
         * @description ### [](#)
         * *   You can call this operation to delete only subscription clusters.
         * *   For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DeleteDBClusterRequest
         * @return DeleteDBClusterResponse
         */
        public DeleteDBClusterResponse DeleteDBCluster(DeleteDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDBClusterWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an AnalyticDB for MySQL cluster.
         *
         * @description ### [](#)
         * *   You can call this operation to delete only subscription clusters.
         * *   For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DeleteDBClusterRequest
         * @return DeleteDBClusterResponse
         */
        public async Task<DeleteDBClusterResponse> DeleteDBClusterAsync(DeleteDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDBClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a resource group from an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DeleteDBResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDBResourceGroupResponse
         */
        public DeleteDBResourceGroupResponse DeleteDBResourceGroupWithOptions(DeleteDBResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDBResourceGroup",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDBResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a resource group from an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DeleteDBResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDBResourceGroupResponse
         */
        public async Task<DeleteDBResourceGroupResponse> DeleteDBResourceGroupWithOptionsAsync(DeleteDBResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDBResourceGroup",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDBResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a resource group from an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DeleteDBResourceGroupRequest
         * @return DeleteDBResourceGroupResponse
         */
        public DeleteDBResourceGroupResponse DeleteDBResourceGroup(DeleteDBResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDBResourceGroupWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a resource group from an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DeleteDBResourceGroupRequest
         * @return DeleteDBResourceGroupResponse
         */
        public async Task<DeleteDBResourceGroupResponse> DeleteDBResourceGroupAsync(DeleteDBResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDBResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a scaling plan from an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DeleteElasticPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteElasticPlanResponse
         */
        public DeleteElasticPlanResponse DeleteElasticPlanWithOptions(DeleteElasticPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticPlanName))
            {
                query["ElasticPlanName"] = request.ElasticPlanName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteElasticPlan",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteElasticPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a scaling plan from an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DeleteElasticPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteElasticPlanResponse
         */
        public async Task<DeleteElasticPlanResponse> DeleteElasticPlanWithOptionsAsync(DeleteElasticPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticPlanName))
            {
                query["ElasticPlanName"] = request.ElasticPlanName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteElasticPlan",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteElasticPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a scaling plan from an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DeleteElasticPlanRequest
         * @return DeleteElasticPlanResponse
         */
        public DeleteElasticPlanResponse DeleteElasticPlan(DeleteElasticPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteElasticPlanWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a scaling plan from an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DeleteElasticPlanRequest
         * @return DeleteElasticPlanResponse
         */
        public async Task<DeleteElasticPlanResponse> DeleteElasticPlanAsync(DeleteElasticPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteElasticPlanWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeletePerformanceViewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePerformanceViewResponse
         */
        public DeletePerformanceViewResponse DeletePerformanceViewWithOptions(DeletePerformanceViewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewName))
            {
                query["ViewName"] = request.ViewName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePerformanceView",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePerformanceViewResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeletePerformanceViewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePerformanceViewResponse
         */
        public async Task<DeletePerformanceViewResponse> DeletePerformanceViewWithOptionsAsync(DeletePerformanceViewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewName))
            {
                query["ViewName"] = request.ViewName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePerformanceView",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePerformanceViewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeletePerformanceViewRequest
         * @return DeletePerformanceViewResponse
         */
        public DeletePerformanceViewResponse DeletePerformanceView(DeletePerformanceViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePerformanceViewWithOptions(request, runtime);
        }

        /**
         * @param request DeletePerformanceViewRequest
         * @return DeletePerformanceViewResponse
         */
        public async Task<DeletePerformanceViewResponse> DeletePerformanceViewAsync(DeletePerformanceViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePerformanceViewWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a worflow instance from an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DeleteProcessInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProcessInstanceResponse
         */
        public DeleteProcessInstanceResponse DeleteProcessInstanceWithOptions(DeleteProcessInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                query["ProcessInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectCode))
            {
                query["ProjectCode"] = request.ProjectCode;
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
                Action = "DeleteProcessInstance",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProcessInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a worflow instance from an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DeleteProcessInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProcessInstanceResponse
         */
        public async Task<DeleteProcessInstanceResponse> DeleteProcessInstanceWithOptionsAsync(DeleteProcessInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                query["ProcessInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectCode))
            {
                query["ProjectCode"] = request.ProjectCode;
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
                Action = "DeleteProcessInstance",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProcessInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a worflow instance from an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DeleteProcessInstanceRequest
         * @return DeleteProcessInstanceResponse
         */
        public DeleteProcessInstanceResponse DeleteProcessInstance(DeleteProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProcessInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a worflow instance from an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DeleteProcessInstanceRequest
         * @return DeleteProcessInstanceResponse
         */
        public async Task<DeleteProcessInstanceResponse> DeleteProcessInstanceAsync(DeleteProcessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProcessInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes Spark template files.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request DeleteSparkTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSparkTemplateResponse
         */
        public DeleteSparkTemplateResponse DeleteSparkTemplateWithOptions(DeleteSparkTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSparkTemplate",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSparkTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes Spark template files.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request DeleteSparkTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSparkTemplateResponse
         */
        public async Task<DeleteSparkTemplateResponse> DeleteSparkTemplateWithOptionsAsync(DeleteSparkTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSparkTemplate",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSparkTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes Spark template files.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request DeleteSparkTemplateRequest
         * @return DeleteSparkTemplateResponse
         */
        public DeleteSparkTemplateResponse DeleteSparkTemplate(DeleteSparkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSparkTemplateWithOptions(request, runtime);
        }

        /**
         * @summary Deletes Spark template files.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request DeleteSparkTemplateRequest
         * @return DeleteSparkTemplateResponse
         */
        public async Task<DeleteSparkTemplateResponse> DeleteSparkTemplateAsync(DeleteSparkTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSparkTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes Spark template files.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DeleteSparkTemplateFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSparkTemplateFileResponse
         */
        public DeleteSparkTemplateFileResponse DeleteSparkTemplateFileWithOptions(DeleteSparkTemplateFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSparkTemplateFile",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSparkTemplateFileResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes Spark template files.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DeleteSparkTemplateFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSparkTemplateFileResponse
         */
        public async Task<DeleteSparkTemplateFileResponse> DeleteSparkTemplateFileWithOptionsAsync(DeleteSparkTemplateFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSparkTemplateFile",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSparkTemplateFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes Spark template files.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DeleteSparkTemplateFileRequest
         * @return DeleteSparkTemplateFileResponse
         */
        public DeleteSparkTemplateFileResponse DeleteSparkTemplateFile(DeleteSparkTemplateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSparkTemplateFileWithOptions(request, runtime);
        }

        /**
         * @summary Deletes Spark template files.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DeleteSparkTemplateFileRequest
         * @return DeleteSparkTemplateFileResponse
         */
        public async Task<DeleteSparkTemplateFileResponse> DeleteSparkTemplateFileAsync(DeleteSparkTemplateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSparkTemplateFileWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the permissions of a database account on all permission levels.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeAccountAllPrivilegesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccountAllPrivilegesResponse
         */
        public DescribeAccountAllPrivilegesResponse DescribeAccountAllPrivilegesWithOptions(DescribeAccountAllPrivilegesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
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
                Action = "DescribeAccountAllPrivileges",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccountAllPrivilegesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the permissions of a database account on all permission levels.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeAccountAllPrivilegesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccountAllPrivilegesResponse
         */
        public async Task<DescribeAccountAllPrivilegesResponse> DescribeAccountAllPrivilegesWithOptionsAsync(DescribeAccountAllPrivilegesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
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
                Action = "DescribeAccountAllPrivileges",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccountAllPrivilegesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the permissions of a database account on all permission levels.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeAccountAllPrivilegesRequest
         * @return DescribeAccountAllPrivilegesResponse
         */
        public DescribeAccountAllPrivilegesResponse DescribeAccountAllPrivileges(DescribeAccountAllPrivilegesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccountAllPrivilegesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the permissions of a database account on all permission levels.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeAccountAllPrivilegesRequest
         * @return DescribeAccountAllPrivilegesResponse
         */
        public async Task<DescribeAccountAllPrivilegesResponse> DescribeAccountAllPrivilegesAsync(DescribeAccountAllPrivilegesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccountAllPrivilegesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the databases, tables, and columns on which a database account has permissions.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeAccountPrivilegeObjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccountPrivilegeObjectsResponse
         */
        public DescribeAccountPrivilegeObjectsResponse DescribeAccountPrivilegeObjectsWithOptions(DescribeAccountPrivilegeObjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnPrivilegeObject))
            {
                query["ColumnPrivilegeObject"] = request.ColumnPrivilegeObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabasePrivilegeObject))
            {
                query["DatabasePrivilegeObject"] = request.DatabasePrivilegeObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivilegeType))
            {
                query["PrivilegeType"] = request.PrivilegeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TablePrivilegeObject))
            {
                query["TablePrivilegeObject"] = request.TablePrivilegeObject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccountPrivilegeObjects",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccountPrivilegeObjectsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the databases, tables, and columns on which a database account has permissions.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeAccountPrivilegeObjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccountPrivilegeObjectsResponse
         */
        public async Task<DescribeAccountPrivilegeObjectsResponse> DescribeAccountPrivilegeObjectsWithOptionsAsync(DescribeAccountPrivilegeObjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnPrivilegeObject))
            {
                query["ColumnPrivilegeObject"] = request.ColumnPrivilegeObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabasePrivilegeObject))
            {
                query["DatabasePrivilegeObject"] = request.DatabasePrivilegeObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivilegeType))
            {
                query["PrivilegeType"] = request.PrivilegeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TablePrivilegeObject))
            {
                query["TablePrivilegeObject"] = request.TablePrivilegeObject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccountPrivilegeObjects",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccountPrivilegeObjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the databases, tables, and columns on which a database account has permissions.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeAccountPrivilegeObjectsRequest
         * @return DescribeAccountPrivilegeObjectsResponse
         */
        public DescribeAccountPrivilegeObjectsResponse DescribeAccountPrivilegeObjects(DescribeAccountPrivilegeObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccountPrivilegeObjectsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the databases, tables, and columns on which a database account has permissions.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeAccountPrivilegeObjectsRequest
         * @return DescribeAccountPrivilegeObjectsResponse
         */
        public async Task<DescribeAccountPrivilegeObjectsResponse> DescribeAccountPrivilegeObjectsAsync(DescribeAccountPrivilegeObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccountPrivilegeObjectsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取某一ADB账户的权限
         *
         * @param request DescribeAccountPrivilegesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccountPrivilegesResponse
         */
        public DescribeAccountPrivilegesResponse DescribeAccountPrivilegesWithOptions(DescribeAccountPrivilegesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnPrivilegeObject))
            {
                query["ColumnPrivilegeObject"] = request.ColumnPrivilegeObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabasePrivilegeObject))
            {
                query["DatabasePrivilegeObject"] = request.DatabasePrivilegeObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivilegeType))
            {
                query["PrivilegeType"] = request.PrivilegeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TablePrivilegeObject))
            {
                query["TablePrivilegeObject"] = request.TablePrivilegeObject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccountPrivileges",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccountPrivilegesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取某一ADB账户的权限
         *
         * @param request DescribeAccountPrivilegesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccountPrivilegesResponse
         */
        public async Task<DescribeAccountPrivilegesResponse> DescribeAccountPrivilegesWithOptionsAsync(DescribeAccountPrivilegesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnPrivilegeObject))
            {
                query["ColumnPrivilegeObject"] = request.ColumnPrivilegeObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabasePrivilegeObject))
            {
                query["DatabasePrivilegeObject"] = request.DatabasePrivilegeObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivilegeType))
            {
                query["PrivilegeType"] = request.PrivilegeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TablePrivilegeObject))
            {
                query["TablePrivilegeObject"] = request.TablePrivilegeObject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccountPrivileges",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccountPrivilegesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取某一ADB账户的权限
         *
         * @param request DescribeAccountPrivilegesRequest
         * @return DescribeAccountPrivilegesResponse
         */
        public DescribeAccountPrivilegesResponse DescribeAccountPrivileges(DescribeAccountPrivilegesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccountPrivilegesWithOptions(request, runtime);
        }

        /**
         * @summary 获取某一ADB账户的权限
         *
         * @param request DescribeAccountPrivilegesRequest
         * @return DescribeAccountPrivilegesResponse
         */
        public async Task<DescribeAccountPrivilegesResponse> DescribeAccountPrivilegesAsync(DescribeAccountPrivilegesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccountPrivilegesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the database accounts of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccounts",
                Version = "2021-12-01",
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
         * @summary Queries the database accounts of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccounts",
                Version = "2021-12-01",
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
         * @summary Queries the database accounts of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
         * @summary Queries the database accounts of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
         * @summary Queries the information about table columns for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeAdbMySqlColumnsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAdbMySqlColumnsResponse
         */
        public DescribeAdbMySqlColumnsResponse DescribeAdbMySqlColumnsWithOptions(DescribeAdbMySqlColumnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schema))
            {
                query["Schema"] = request.Schema;
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
                Action = "DescribeAdbMySqlColumns",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAdbMySqlColumnsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about table columns for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeAdbMySqlColumnsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAdbMySqlColumnsResponse
         */
        public async Task<DescribeAdbMySqlColumnsResponse> DescribeAdbMySqlColumnsWithOptionsAsync(DescribeAdbMySqlColumnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schema))
            {
                query["Schema"] = request.Schema;
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
                Action = "DescribeAdbMySqlColumns",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAdbMySqlColumnsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about table columns for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeAdbMySqlColumnsRequest
         * @return DescribeAdbMySqlColumnsResponse
         */
        public DescribeAdbMySqlColumnsResponse DescribeAdbMySqlColumns(DescribeAdbMySqlColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAdbMySqlColumnsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about table columns for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeAdbMySqlColumnsRequest
         * @return DescribeAdbMySqlColumnsResponse
         */
        public async Task<DescribeAdbMySqlColumnsResponse> DescribeAdbMySqlColumnsAsync(DescribeAdbMySqlColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAdbMySqlColumnsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of databases for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeAdbMySqlSchemasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAdbMySqlSchemasResponse
         */
        public DescribeAdbMySqlSchemasResponse DescribeAdbMySqlSchemasWithOptions(DescribeAdbMySqlSchemasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "DescribeAdbMySqlSchemas",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAdbMySqlSchemasResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of databases for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeAdbMySqlSchemasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAdbMySqlSchemasResponse
         */
        public async Task<DescribeAdbMySqlSchemasResponse> DescribeAdbMySqlSchemasWithOptionsAsync(DescribeAdbMySqlSchemasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "DescribeAdbMySqlSchemas",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAdbMySqlSchemasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of databases for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeAdbMySqlSchemasRequest
         * @return DescribeAdbMySqlSchemasResponse
         */
        public DescribeAdbMySqlSchemasResponse DescribeAdbMySqlSchemas(DescribeAdbMySqlSchemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAdbMySqlSchemasWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of databases for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeAdbMySqlSchemasRequest
         * @return DescribeAdbMySqlSchemasResponse
         */
        public async Task<DescribeAdbMySqlSchemasResponse> DescribeAdbMySqlSchemasAsync(DescribeAdbMySqlSchemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAdbMySqlSchemasWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of tables for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeAdbMySqlTablesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAdbMySqlTablesResponse
         */
        public DescribeAdbMySqlTablesResponse DescribeAdbMySqlTablesWithOptions(DescribeAdbMySqlTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schema))
            {
                query["Schema"] = request.Schema;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAdbMySqlTables",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAdbMySqlTablesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of tables for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeAdbMySqlTablesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAdbMySqlTablesResponse
         */
        public async Task<DescribeAdbMySqlTablesResponse> DescribeAdbMySqlTablesWithOptionsAsync(DescribeAdbMySqlTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schema))
            {
                query["Schema"] = request.Schema;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAdbMySqlTables",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAdbMySqlTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of tables for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeAdbMySqlTablesRequest
         * @return DescribeAdbMySqlTablesResponse
         */
        public DescribeAdbMySqlTablesResponse DescribeAdbMySqlTables(DescribeAdbMySqlTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAdbMySqlTablesWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of tables for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeAdbMySqlTablesRequest
         * @return DescribeAdbMySqlTablesResponse
         */
        public async Task<DescribeAdbMySqlTablesResponse> DescribeAdbMySqlTablesAsync(DescribeAdbMySqlTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAdbMySqlTablesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of databases, tables, and columns in an AnalyticDB for MySQL cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeAllDataSourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAllDataSourceResponse
         */
        public DescribeAllDataSourceResponse DescribeAllDataSourceWithOptions(DescribeAllDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["SchemaName"] = request.SchemaName;
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
                Action = "DescribeAllDataSource",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAllDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of databases, tables, and columns in an AnalyticDB for MySQL cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeAllDataSourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAllDataSourceResponse
         */
        public async Task<DescribeAllDataSourceResponse> DescribeAllDataSourceWithOptionsAsync(DescribeAllDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["SchemaName"] = request.SchemaName;
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
                Action = "DescribeAllDataSource",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAllDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of databases, tables, and columns in an AnalyticDB for MySQL cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeAllDataSourceRequest
         * @return DescribeAllDataSourceResponse
         */
        public DescribeAllDataSourceResponse DescribeAllDataSource(DescribeAllDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAllDataSourceWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of databases, tables, and columns in an AnalyticDB for MySQL cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeAllDataSourceRequest
         * @return DescribeAllDataSourceResponse
         */
        public async Task<DescribeAllDataSourceResponse> DescribeAllDataSourceAsync(DescribeAllDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAllDataSourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the logs of a real-time data ingestion job for an AnalyticDB for MySQL cluster.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeApsActionLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApsActionLogsResponse
         */
        public DescribeApsActionLogsResponse DescribeApsActionLogsWithOptions(DescribeApsActionLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stage))
            {
                query["Stage"] = request.Stage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkloadId))
            {
                query["WorkloadId"] = request.WorkloadId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApsActionLogs",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApsActionLogsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the logs of a real-time data ingestion job for an AnalyticDB for MySQL cluster.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeApsActionLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApsActionLogsResponse
         */
        public async Task<DescribeApsActionLogsResponse> DescribeApsActionLogsWithOptionsAsync(DescribeApsActionLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stage))
            {
                query["Stage"] = request.Stage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkloadId))
            {
                query["WorkloadId"] = request.WorkloadId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApsActionLogs",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApsActionLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the logs of a real-time data ingestion job for an AnalyticDB for MySQL cluster.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeApsActionLogsRequest
         * @return DescribeApsActionLogsResponse
         */
        public DescribeApsActionLogsResponse DescribeApsActionLogs(DescribeApsActionLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApsActionLogsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the logs of a real-time data ingestion job for an AnalyticDB for MySQL cluster.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeApsActionLogsRequest
         * @return DescribeApsActionLogsResponse
         */
        public async Task<DescribeApsActionLogsResponse> DescribeApsActionLogsAsync(DescribeApsActionLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApsActionLogsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about resource groups of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeApsResourceGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApsResourceGroupsResponse
         */
        public DescribeApsResourceGroupsResponse DescribeApsResourceGroupsWithOptions(DescribeApsResourceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkloadId))
            {
                body["WorkloadId"] = request.WorkloadId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApsResourceGroups",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApsResourceGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about resource groups of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeApsResourceGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApsResourceGroupsResponse
         */
        public async Task<DescribeApsResourceGroupsResponse> DescribeApsResourceGroupsWithOptionsAsync(DescribeApsResourceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkloadId))
            {
                body["WorkloadId"] = request.WorkloadId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApsResourceGroups",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApsResourceGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about resource groups of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeApsResourceGroupsRequest
         * @return DescribeApsResourceGroupsResponse
         */
        public DescribeApsResourceGroupsResponse DescribeApsResourceGroups(DescribeApsResourceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApsResourceGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about resource groups of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeApsResourceGroupsRequest
         * @return DescribeApsResourceGroupsResponse
         */
        public async Task<DescribeApsResourceGroupsResponse> DescribeApsResourceGroupsAsync(DescribeApsResourceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApsResourceGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the SQL audit logs of an AnalyticDB for MySQL cluster.
         *
         * @description *   SQL audit logs can be queried only when SQL audit is enabled. Only SQL audit logs within the last 30 days can be queried. If SQL audit was disabled and re-enabled, only SQL audit logs from the time when SQL audit was re-enabled can be queried. The following operations are not recorded in SQL audit logs: **INSERT INTO VALUES**, **REPLACE INTO VALUES**, and **UPSERT INTO VALUES**.
         * *   For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeAuditLogRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAuditLogRecordsResponse
         */
        public DescribeAuditLogRecordsResponse DescribeAuditLogRecordsWithOptions(DescribeAuditLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBName))
            {
                query["DBName"] = request.DBName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostAddress))
            {
                query["HostAddress"] = request.HostAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUser))
            {
                query["ProxyUser"] = request.ProxyUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeyword))
            {
                query["QueryKeyword"] = request.QueryKeyword;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlType))
            {
                query["SqlType"] = request.SqlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Succeed))
            {
                query["Succeed"] = request.Succeed;
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
                Action = "DescribeAuditLogRecords",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAuditLogRecordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the SQL audit logs of an AnalyticDB for MySQL cluster.
         *
         * @description *   SQL audit logs can be queried only when SQL audit is enabled. Only SQL audit logs within the last 30 days can be queried. If SQL audit was disabled and re-enabled, only SQL audit logs from the time when SQL audit was re-enabled can be queried. The following operations are not recorded in SQL audit logs: **INSERT INTO VALUES**, **REPLACE INTO VALUES**, and **UPSERT INTO VALUES**.
         * *   For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeAuditLogRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAuditLogRecordsResponse
         */
        public async Task<DescribeAuditLogRecordsResponse> DescribeAuditLogRecordsWithOptionsAsync(DescribeAuditLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBName))
            {
                query["DBName"] = request.DBName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostAddress))
            {
                query["HostAddress"] = request.HostAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUser))
            {
                query["ProxyUser"] = request.ProxyUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeyword))
            {
                query["QueryKeyword"] = request.QueryKeyword;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlType))
            {
                query["SqlType"] = request.SqlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Succeed))
            {
                query["Succeed"] = request.Succeed;
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
                Action = "DescribeAuditLogRecords",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAuditLogRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the SQL audit logs of an AnalyticDB for MySQL cluster.
         *
         * @description *   SQL audit logs can be queried only when SQL audit is enabled. Only SQL audit logs within the last 30 days can be queried. If SQL audit was disabled and re-enabled, only SQL audit logs from the time when SQL audit was re-enabled can be queried. The following operations are not recorded in SQL audit logs: **INSERT INTO VALUES**, **REPLACE INTO VALUES**, and **UPSERT INTO VALUES**.
         * *   For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeAuditLogRecordsRequest
         * @return DescribeAuditLogRecordsResponse
         */
        public DescribeAuditLogRecordsResponse DescribeAuditLogRecords(DescribeAuditLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAuditLogRecordsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the SQL audit logs of an AnalyticDB for MySQL cluster.
         *
         * @description *   SQL audit logs can be queried only when SQL audit is enabled. Only SQL audit logs within the last 30 days can be queried. If SQL audit was disabled and re-enabled, only SQL audit logs from the time when SQL audit was re-enabled can be queried. The following operations are not recorded in SQL audit logs: **INSERT INTO VALUES**, **REPLACE INTO VALUES**, and **UPSERT INTO VALUES**.
         * *   For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeAuditLogRecordsRequest
         * @return DescribeAuditLogRecordsResponse
         */
        public async Task<DescribeAuditLogRecordsResponse> DescribeAuditLogRecordsAsync(DescribeAuditLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAuditLogRecordsWithOptionsAsync(request, runtime);
        }

        /**
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeBackupPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupPolicyResponse
         */
        public DescribeBackupPolicyResponse DescribeBackupPolicyWithOptions(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "DescribeBackupPolicy",
                Version = "2021-12-01",
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
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeBackupPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupPolicyResponse
         */
        public async Task<DescribeBackupPolicyResponse> DescribeBackupPolicyWithOptionsAsync(DescribeBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "DescribeBackupPolicy",
                Version = "2021-12-01",
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
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Version = "2021-12-01",
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
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Version = "2021-12-01",
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
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
         * @summary Queries the IP address whitelists of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeClusterAccessWhiteListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterAccessWhiteListResponse
         */
        public DescribeClusterAccessWhiteListResponse DescribeClusterAccessWhiteListWithOptions(DescribeClusterAccessWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterAccessWhiteList",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterAccessWhiteListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the IP address whitelists of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeClusterAccessWhiteListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterAccessWhiteListResponse
         */
        public async Task<DescribeClusterAccessWhiteListResponse> DescribeClusterAccessWhiteListWithOptionsAsync(DescribeClusterAccessWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterAccessWhiteList",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterAccessWhiteListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the IP address whitelists of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeClusterAccessWhiteListRequest
         * @return DescribeClusterAccessWhiteListResponse
         */
        public DescribeClusterAccessWhiteListResponse DescribeClusterAccessWhiteList(DescribeClusterAccessWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterAccessWhiteListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the IP address whitelists of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeClusterAccessWhiteListRequest
         * @return DescribeClusterAccessWhiteListResponse
         */
        public async Task<DescribeClusterAccessWhiteListResponse> DescribeClusterAccessWhiteListAsync(DescribeClusterAccessWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterAccessWhiteListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the network information about an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeClusterNetInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterNetInfoResponse
         */
        public DescribeClusterNetInfoResponse DescribeClusterNetInfoWithOptions(DescribeClusterNetInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "DescribeClusterNetInfo",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterNetInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the network information about an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeClusterNetInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterNetInfoResponse
         */
        public async Task<DescribeClusterNetInfoResponse> DescribeClusterNetInfoWithOptionsAsync(DescribeClusterNetInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "DescribeClusterNetInfo",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterNetInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the network information about an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeClusterNetInfoRequest
         * @return DescribeClusterNetInfoResponse
         */
        public DescribeClusterNetInfoResponse DescribeClusterNetInfo(DescribeClusterNetInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterNetInfoWithOptions(request, runtime);
        }

        /**
         * @summary Queries the network information about an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeClusterNetInfoRequest
         * @return DescribeClusterNetInfoResponse
         */
        public async Task<DescribeClusterNetInfoResponse> DescribeClusterNetInfoAsync(DescribeClusterNetInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterNetInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取集群资源统计
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeClusterResourceDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterResourceDetailResponse
         */
        public DescribeClusterResourceDetailResponse DescribeClusterResourceDetailWithOptions(DescribeClusterResourceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterResourceDetail",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterResourceDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取集群资源统计
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeClusterResourceDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterResourceDetailResponse
         */
        public async Task<DescribeClusterResourceDetailResponse> DescribeClusterResourceDetailWithOptionsAsync(DescribeClusterResourceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterResourceDetail",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterResourceDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取集群资源统计
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeClusterResourceDetailRequest
         * @return DescribeClusterResourceDetailResponse
         */
        public DescribeClusterResourceDetailResponse DescribeClusterResourceDetail(DescribeClusterResourceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterResourceDetailWithOptions(request, runtime);
        }

        /**
         * @summary 获取集群资源统计
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeClusterResourceDetailRequest
         * @return DescribeClusterResourceDetailResponse
         */
        public async Task<DescribeClusterResourceDetailResponse> DescribeClusterResourceDetailAsync(DescribeClusterResourceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterResourceDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取实例资源统计
         *
         * @param request DescribeClusterResourceUsageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterResourceUsageResponse
         */
        public DescribeClusterResourceUsageResponse DescribeClusterResourceUsageWithOptions(DescribeClusterResourceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterResourceUsage",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterResourceUsageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取实例资源统计
         *
         * @param request DescribeClusterResourceUsageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterResourceUsageResponse
         */
        public async Task<DescribeClusterResourceUsageResponse> DescribeClusterResourceUsageWithOptionsAsync(DescribeClusterResourceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterResourceUsage",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterResourceUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取实例资源统计
         *
         * @param request DescribeClusterResourceUsageRequest
         * @return DescribeClusterResourceUsageResponse
         */
        public DescribeClusterResourceUsageResponse DescribeClusterResourceUsage(DescribeClusterResourceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterResourceUsageWithOptions(request, runtime);
        }

        /**
         * @summary 获取实例资源统计
         *
         * @param request DescribeClusterResourceUsageRequest
         * @return DescribeClusterResourceUsageResponse
         */
        public async Task<DescribeClusterResourceUsageResponse> DescribeClusterResourceUsageAsync(DescribeClusterResourceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterResourceUsageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of columns in a table.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeColumnsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeColumnsResponse
         */
        public DescribeColumnsResponse DescribeColumnsWithOptions(DescribeColumnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["SchemaName"] = request.SchemaName;
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
                Action = "DescribeColumns",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeColumnsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of columns in a table.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeColumnsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeColumnsResponse
         */
        public async Task<DescribeColumnsResponse> DescribeColumnsWithOptionsAsync(DescribeColumnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["SchemaName"] = request.SchemaName;
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
                Action = "DescribeColumns",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeColumnsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of columns in a table.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeColumnsRequest
         * @return DescribeColumnsResponse
         */
        public DescribeColumnsResponse DescribeColumns(DescribeColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeColumnsWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of columns in a table.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeColumnsRequest
         * @return DescribeColumnsResponse
         */
        public async Task<DescribeColumnsResponse> DescribeColumnsAsync(DescribeColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeColumnsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取实例计算资源使用统计
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeComputeResourceUsageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeComputeResourceUsageResponse
         */
        public DescribeComputeResourceUsageResponse DescribeComputeResourceUsageWithOptions(DescribeComputeResourceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                query["ResourceGroupName"] = request.ResourceGroupName;
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
                Action = "DescribeComputeResourceUsage",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeComputeResourceUsageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取实例计算资源使用统计
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeComputeResourceUsageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeComputeResourceUsageResponse
         */
        public async Task<DescribeComputeResourceUsageResponse> DescribeComputeResourceUsageWithOptionsAsync(DescribeComputeResourceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                query["ResourceGroupName"] = request.ResourceGroupName;
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
                Action = "DescribeComputeResourceUsage",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeComputeResourceUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取实例计算资源使用统计
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeComputeResourceUsageRequest
         * @return DescribeComputeResourceUsageResponse
         */
        public DescribeComputeResourceUsageResponse DescribeComputeResourceUsage(DescribeComputeResourceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeComputeResourceUsageWithOptions(request, runtime);
        }

        /**
         * @summary 获取实例计算资源使用统计
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeComputeResourceUsageRequest
         * @return DescribeComputeResourceUsageResponse
         */
        public async Task<DescribeComputeResourceUsageResponse> DescribeComputeResourceUsageAsync(DescribeComputeResourceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeComputeResourceUsageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClusterAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBClusterAttributeResponse
         */
        public DescribeDBClusterAttributeResponse DescribeDBClusterAttributeWithOptions(DescribeDBClusterAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBClusterAttribute",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBClusterAttributeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClusterAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBClusterAttributeResponse
         */
        public async Task<DescribeDBClusterAttributeResponse> DescribeDBClusterAttributeWithOptionsAsync(DescribeDBClusterAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBClusterAttribute",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBClusterAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClusterAttributeRequest
         * @return DescribeDBClusterAttributeResponse
         */
        public DescribeDBClusterAttributeResponse DescribeDBClusterAttribute(DescribeDBClusterAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBClusterAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClusterAttributeRequest
         * @return DescribeDBClusterAttributeResponse
         */
        public async Task<DescribeDBClusterAttributeResponse> DescribeDBClusterAttributeAsync(DescribeDBClusterAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBClusterAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the health status of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClusterHealthStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBClusterHealthStatusResponse
         */
        public DescribeDBClusterHealthStatusResponse DescribeDBClusterHealthStatusWithOptions(DescribeDBClusterHealthStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "DescribeDBClusterHealthStatus",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBClusterHealthStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the health status of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClusterHealthStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBClusterHealthStatusResponse
         */
        public async Task<DescribeDBClusterHealthStatusResponse> DescribeDBClusterHealthStatusWithOptionsAsync(DescribeDBClusterHealthStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "DescribeDBClusterHealthStatus",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBClusterHealthStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the health status of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClusterHealthStatusRequest
         * @return DescribeDBClusterHealthStatusResponse
         */
        public DescribeDBClusterHealthStatusResponse DescribeDBClusterHealthStatus(DescribeDBClusterHealthStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBClusterHealthStatusWithOptions(request, runtime);
        }

        /**
         * @summary Queries the health status of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClusterHealthStatusRequest
         * @return DescribeDBClusterHealthStatusResponse
         */
        public async Task<DescribeDBClusterHealthStatusResponse> DescribeDBClusterHealthStatusAsync(DescribeDBClusterHealthStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBClusterHealthStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the performance data of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClusterPerformanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBClusterPerformanceResponse
         */
        public DescribeDBClusterPerformanceResponse DescribeDBClusterPerformanceWithOptions(DescribeDBClusterPerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcePools))
            {
                query["ResourcePools"] = request.ResourcePools;
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
                Action = "DescribeDBClusterPerformance",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBClusterPerformanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the performance data of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClusterPerformanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBClusterPerformanceResponse
         */
        public async Task<DescribeDBClusterPerformanceResponse> DescribeDBClusterPerformanceWithOptionsAsync(DescribeDBClusterPerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcePools))
            {
                query["ResourcePools"] = request.ResourcePools;
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
                Action = "DescribeDBClusterPerformance",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBClusterPerformanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the performance data of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClusterPerformanceRequest
         * @return DescribeDBClusterPerformanceResponse
         */
        public DescribeDBClusterPerformanceResponse DescribeDBClusterPerformance(DescribeDBClusterPerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBClusterPerformanceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the performance data of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClusterPerformanceRequest
         * @return DescribeDBClusterPerformanceResponse
         */
        public async Task<DescribeDBClusterPerformanceResponse> DescribeDBClusterPerformanceAsync(DescribeDBClusterPerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBClusterPerformanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the storage overview information of an AnalyticDB for MySQL cluster, such as the total data size, hot data size, cold data size, and data growth.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClusterSpaceSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBClusterSpaceSummaryResponse
         */
        public DescribeDBClusterSpaceSummaryResponse DescribeDBClusterSpaceSummaryWithOptions(DescribeDBClusterSpaceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "DescribeDBClusterSpaceSummary",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBClusterSpaceSummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the storage overview information of an AnalyticDB for MySQL cluster, such as the total data size, hot data size, cold data size, and data growth.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClusterSpaceSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBClusterSpaceSummaryResponse
         */
        public async Task<DescribeDBClusterSpaceSummaryResponse> DescribeDBClusterSpaceSummaryWithOptionsAsync(DescribeDBClusterSpaceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "DescribeDBClusterSpaceSummary",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBClusterSpaceSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the storage overview information of an AnalyticDB for MySQL cluster, such as the total data size, hot data size, cold data size, and data growth.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClusterSpaceSummaryRequest
         * @return DescribeDBClusterSpaceSummaryResponse
         */
        public DescribeDBClusterSpaceSummaryResponse DescribeDBClusterSpaceSummary(DescribeDBClusterSpaceSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBClusterSpaceSummaryWithOptions(request, runtime);
        }

        /**
         * @summary Queries the storage overview information of an AnalyticDB for MySQL cluster, such as the total data size, hot data size, cold data size, and data growth.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClusterSpaceSummaryRequest
         * @return DescribeDBClusterSpaceSummaryResponse
         */
        public async Task<DescribeDBClusterSpaceSummaryResponse> DescribeDBClusterSpaceSummaryAsync(DescribeDBClusterSpaceSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBClusterSpaceSummaryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the status of AnalyticDB for MySQL Data Lakehouse Edition clusters within a region.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClusterStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBClusterStatusResponse
         */
        public DescribeDBClusterStatusResponse DescribeDBClusterStatusWithOptions(DescribeDBClusterStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDBClusterStatus",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBClusterStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the status of AnalyticDB for MySQL Data Lakehouse Edition clusters within a region.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClusterStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBClusterStatusResponse
         */
        public async Task<DescribeDBClusterStatusResponse> DescribeDBClusterStatusWithOptionsAsync(DescribeDBClusterStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDBClusterStatus",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBClusterStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the status of AnalyticDB for MySQL Data Lakehouse Edition clusters within a region.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClusterStatusRequest
         * @return DescribeDBClusterStatusResponse
         */
        public DescribeDBClusterStatusResponse DescribeDBClusterStatus(DescribeDBClusterStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBClusterStatusWithOptions(request, runtime);
        }

        /**
         * @summary Queries the status of AnalyticDB for MySQL Data Lakehouse Edition clusters within a region.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClusterStatusRequest
         * @return DescribeDBClusterStatusResponse
         */
        public async Task<DescribeDBClusterStatusResponse> DescribeDBClusterStatusAsync(DescribeDBClusterStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBClusterStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about AnalyticDB for MySQL Data Lakehouse Edition clusters within a region.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClustersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBClustersResponse
         */
        public DescribeDBClustersResponse DescribeDBClustersWithOptions(DescribeDBClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterDescription))
            {
                query["DBClusterDescription"] = request.DBClusterDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterIds))
            {
                query["DBClusterIds"] = request.DBClusterIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterStatus))
            {
                query["DBClusterStatus"] = request.DBClusterStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterVersion))
            {
                query["DBClusterVersion"] = request.DBClusterVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersion))
            {
                query["ProductVersion"] = request.ProductVersion;
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
                Action = "DescribeDBClusters",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBClustersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about AnalyticDB for MySQL Data Lakehouse Edition clusters within a region.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClustersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBClustersResponse
         */
        public async Task<DescribeDBClustersResponse> DescribeDBClustersWithOptionsAsync(DescribeDBClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterDescription))
            {
                query["DBClusterDescription"] = request.DBClusterDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterIds))
            {
                query["DBClusterIds"] = request.DBClusterIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterStatus))
            {
                query["DBClusterStatus"] = request.DBClusterStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterVersion))
            {
                query["DBClusterVersion"] = request.DBClusterVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersion))
            {
                query["ProductVersion"] = request.ProductVersion;
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
                Action = "DescribeDBClusters",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBClustersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about AnalyticDB for MySQL Data Lakehouse Edition clusters within a region.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClustersRequest
         * @return DescribeDBClustersResponse
         */
        public DescribeDBClustersResponse DescribeDBClusters(DescribeDBClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBClustersWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about AnalyticDB for MySQL Data Lakehouse Edition clusters within a region.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBClustersRequest
         * @return DescribeDBClustersResponse
         */
        public async Task<DescribeDBClustersResponse> DescribeDBClustersAsync(DescribeDBClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBClustersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about resource groups of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBResourceGroupResponse
         */
        public DescribeDBResourceGroupResponse DescribeDBResourceGroupWithOptions(DescribeDBResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBResourceGroup",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about resource groups of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDBResourceGroupResponse
         */
        public async Task<DescribeDBResourceGroupResponse> DescribeDBResourceGroupWithOptionsAsync(DescribeDBResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBResourceGroup",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about resource groups of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBResourceGroupRequest
         * @return DescribeDBResourceGroupResponse
         */
        public DescribeDBResourceGroupResponse DescribeDBResourceGroup(DescribeDBResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBResourceGroupWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about resource groups of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeDBResourceGroupRequest
         * @return DescribeDBResourceGroupResponse
         */
        public async Task<DescribeDBResourceGroupResponse> DescribeDBResourceGroupAsync(DescribeDBResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the deduplicated statistics of resource groups, databases, usernames, and source IP addresses about SQL statements that meet a query condition for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeDiagnosisDimensionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDiagnosisDimensionsResponse
         */
        public DescribeDiagnosisDimensionsResponse DescribeDiagnosisDimensionsWithOptions(DescribeDiagnosisDimensionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCondition))
            {
                query["QueryCondition"] = request.QueryCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeDiagnosisDimensions",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiagnosisDimensionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the deduplicated statistics of resource groups, databases, usernames, and source IP addresses about SQL statements that meet a query condition for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeDiagnosisDimensionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDiagnosisDimensionsResponse
         */
        public async Task<DescribeDiagnosisDimensionsResponse> DescribeDiagnosisDimensionsWithOptionsAsync(DescribeDiagnosisDimensionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCondition))
            {
                query["QueryCondition"] = request.QueryCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeDiagnosisDimensions",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiagnosisDimensionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the deduplicated statistics of resource groups, databases, usernames, and source IP addresses about SQL statements that meet a query condition for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeDiagnosisDimensionsRequest
         * @return DescribeDiagnosisDimensionsResponse
         */
        public DescribeDiagnosisDimensionsResponse DescribeDiagnosisDimensions(DescribeDiagnosisDimensionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDiagnosisDimensionsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the deduplicated statistics of resource groups, databases, usernames, and source IP addresses about SQL statements that meet a query condition for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeDiagnosisDimensionsRequest
         * @return DescribeDiagnosisDimensionsResponse
         */
        public async Task<DescribeDiagnosisDimensionsResponse> DescribeDiagnosisDimensionsAsync(DescribeDiagnosisDimensionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDiagnosisDimensionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the diagnostic information about SQL statements that meet a query condition for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeDiagnosisRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDiagnosisRecordsResponse
         */
        public DescribeDiagnosisRecordsResponse DescribeDiagnosisRecordsWithOptions(DescribeDiagnosisRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                query["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                query["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPeakMemory))
            {
                query["MaxPeakMemory"] = request.MaxPeakMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxScanSize))
            {
                query["MaxScanSize"] = request.MaxScanSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinPeakMemory))
            {
                query["MinPeakMemory"] = request.MinPeakMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinScanSize))
            {
                query["MinScanSize"] = request.MinScanSize;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PatternId))
            {
                query["PatternId"] = request.PatternId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCondition))
            {
                query["QueryCondition"] = request.QueryCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroup))
            {
                query["ResourceGroup"] = request.ResourceGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiagnosisRecords",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiagnosisRecordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the diagnostic information about SQL statements that meet a query condition for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeDiagnosisRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDiagnosisRecordsResponse
         */
        public async Task<DescribeDiagnosisRecordsResponse> DescribeDiagnosisRecordsWithOptionsAsync(DescribeDiagnosisRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                query["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                query["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPeakMemory))
            {
                query["MaxPeakMemory"] = request.MaxPeakMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxScanSize))
            {
                query["MaxScanSize"] = request.MaxScanSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinPeakMemory))
            {
                query["MinPeakMemory"] = request.MinPeakMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinScanSize))
            {
                query["MinScanSize"] = request.MinScanSize;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PatternId))
            {
                query["PatternId"] = request.PatternId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCondition))
            {
                query["QueryCondition"] = request.QueryCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroup))
            {
                query["ResourceGroup"] = request.ResourceGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiagnosisRecords",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiagnosisRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the diagnostic information about SQL statements that meet a query condition for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeDiagnosisRecordsRequest
         * @return DescribeDiagnosisRecordsResponse
         */
        public DescribeDiagnosisRecordsResponse DescribeDiagnosisRecords(DescribeDiagnosisRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDiagnosisRecordsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the diagnostic information about SQL statements that meet a query condition for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeDiagnosisRecordsRequest
         * @return DescribeDiagnosisRecordsResponse
         */
        public async Task<DescribeDiagnosisRecordsResponse> DescribeDiagnosisRecordsAsync(DescribeDiagnosisRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDiagnosisRecordsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the execution information about an SQL statement, including the execution plan, execution information, resource usage, and self-diagnostics results.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeDiagnosisSQLInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDiagnosisSQLInfoResponse
         */
        public DescribeDiagnosisSQLInfoResponse DescribeDiagnosisSQLInfoWithOptions(DescribeDiagnosisSQLInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiagnosisSQLInfo",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiagnosisSQLInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the execution information about an SQL statement, including the execution plan, execution information, resource usage, and self-diagnostics results.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeDiagnosisSQLInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDiagnosisSQLInfoResponse
         */
        public async Task<DescribeDiagnosisSQLInfoResponse> DescribeDiagnosisSQLInfoWithOptionsAsync(DescribeDiagnosisSQLInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDiagnosisSQLInfo",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiagnosisSQLInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the execution information about an SQL statement, including the execution plan, execution information, resource usage, and self-diagnostics results.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeDiagnosisSQLInfoRequest
         * @return DescribeDiagnosisSQLInfoResponse
         */
        public DescribeDiagnosisSQLInfoResponse DescribeDiagnosisSQLInfo(DescribeDiagnosisSQLInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDiagnosisSQLInfoWithOptions(request, runtime);
        }

        /**
         * @summary Queries the execution information about an SQL statement, including the execution plan, execution information, resource usage, and self-diagnostics results.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeDiagnosisSQLInfoRequest
         * @return DescribeDiagnosisSQLInfoResponse
         */
        public async Task<DescribeDiagnosisSQLInfoResponse> DescribeDiagnosisSQLInfoAsync(DescribeDiagnosisSQLInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDiagnosisSQLInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the last five SQL query download tasks of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeDownloadRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDownloadRecordsResponse
         */
        public DescribeDownloadRecordsResponse DescribeDownloadRecordsWithOptions(DescribeDownloadRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeDownloadRecords",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDownloadRecordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the last five SQL query download tasks of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeDownloadRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDownloadRecordsResponse
         */
        public async Task<DescribeDownloadRecordsResponse> DescribeDownloadRecordsWithOptionsAsync(DescribeDownloadRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeDownloadRecords",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDownloadRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the last five SQL query download tasks of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeDownloadRecordsRequest
         * @return DescribeDownloadRecordsResponse
         */
        public DescribeDownloadRecordsResponse DescribeDownloadRecords(DescribeDownloadRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDownloadRecordsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the last five SQL query download tasks of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeDownloadRecordsRequest
         * @return DescribeDownloadRecordsResponse
         */
        public async Task<DescribeDownloadRecordsResponse> DescribeDownloadRecordsAsync(DescribeDownloadRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDownloadRecordsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about a scaling plan for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeElasticPlanAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeElasticPlanAttributeResponse
         */
        public DescribeElasticPlanAttributeResponse DescribeElasticPlanAttributeWithOptions(DescribeElasticPlanAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticPlanName))
            {
                query["ElasticPlanName"] = request.ElasticPlanName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeElasticPlanAttribute",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeElasticPlanAttributeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a scaling plan for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeElasticPlanAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeElasticPlanAttributeResponse
         */
        public async Task<DescribeElasticPlanAttributeResponse> DescribeElasticPlanAttributeWithOptionsAsync(DescribeElasticPlanAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticPlanName))
            {
                query["ElasticPlanName"] = request.ElasticPlanName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeElasticPlanAttribute",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeElasticPlanAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a scaling plan for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeElasticPlanAttributeRequest
         * @return DescribeElasticPlanAttributeResponse
         */
        public DescribeElasticPlanAttributeResponse DescribeElasticPlanAttribute(DescribeElasticPlanAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeElasticPlanAttributeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about a scaling plan for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeElasticPlanAttributeRequest
         * @return DescribeElasticPlanAttributeResponse
         */
        public async Task<DescribeElasticPlanAttributeResponse> DescribeElasticPlanAttributeAsync(DescribeElasticPlanAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeElasticPlanAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of scaling plan jobs for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeElasticPlanJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeElasticPlanJobsResponse
         */
        public DescribeElasticPlanJobsResponse DescribeElasticPlanJobsWithOptions(DescribeElasticPlanJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticPlanName))
            {
                query["ElasticPlanName"] = request.ElasticPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                query["ResourceGroupName"] = request.ResourceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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
                Action = "DescribeElasticPlanJobs",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeElasticPlanJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of scaling plan jobs for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeElasticPlanJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeElasticPlanJobsResponse
         */
        public async Task<DescribeElasticPlanJobsResponse> DescribeElasticPlanJobsWithOptionsAsync(DescribeElasticPlanJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticPlanName))
            {
                query["ElasticPlanName"] = request.ElasticPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                query["ResourceGroupName"] = request.ResourceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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
                Action = "DescribeElasticPlanJobs",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeElasticPlanJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of scaling plan jobs for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeElasticPlanJobsRequest
         * @return DescribeElasticPlanJobsResponse
         */
        public DescribeElasticPlanJobsResponse DescribeElasticPlanJobs(DescribeElasticPlanJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeElasticPlanJobsWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of scaling plan jobs for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeElasticPlanJobsRequest
         * @return DescribeElasticPlanJobsResponse
         */
        public async Task<DescribeElasticPlanJobsResponse> DescribeElasticPlanJobsAsync(DescribeElasticPlanJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeElasticPlanJobsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the resource specifications that are supported by different types of scaling plans of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeElasticPlanSpecificationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeElasticPlanSpecificationsResponse
         */
        public DescribeElasticPlanSpecificationsResponse DescribeElasticPlanSpecificationsWithOptions(DescribeElasticPlanSpecificationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                query["ResourceGroupName"] = request.ResourceGroupName;
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
                Action = "DescribeElasticPlanSpecifications",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeElasticPlanSpecificationsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the resource specifications that are supported by different types of scaling plans of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeElasticPlanSpecificationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeElasticPlanSpecificationsResponse
         */
        public async Task<DescribeElasticPlanSpecificationsResponse> DescribeElasticPlanSpecificationsWithOptionsAsync(DescribeElasticPlanSpecificationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                query["ResourceGroupName"] = request.ResourceGroupName;
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
                Action = "DescribeElasticPlanSpecifications",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeElasticPlanSpecificationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the resource specifications that are supported by different types of scaling plans of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeElasticPlanSpecificationsRequest
         * @return DescribeElasticPlanSpecificationsResponse
         */
        public DescribeElasticPlanSpecificationsResponse DescribeElasticPlanSpecifications(DescribeElasticPlanSpecificationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeElasticPlanSpecificationsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the resource specifications that are supported by different types of scaling plans of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeElasticPlanSpecificationsRequest
         * @return DescribeElasticPlanSpecificationsResponse
         */
        public async Task<DescribeElasticPlanSpecificationsResponse> DescribeElasticPlanSpecificationsAsync(DescribeElasticPlanSpecificationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeElasticPlanSpecificationsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries scaling plans of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeElasticPlansRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeElasticPlansResponse
         */
        public DescribeElasticPlansResponse DescribeElasticPlansWithOptions(DescribeElasticPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticPlanName))
            {
                query["ElasticPlanName"] = request.ElasticPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                query["ResourceGroupName"] = request.ResourceGroupName;
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
                Action = "DescribeElasticPlans",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeElasticPlansResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries scaling plans of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeElasticPlansRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeElasticPlansResponse
         */
        public async Task<DescribeElasticPlansResponse> DescribeElasticPlansWithOptionsAsync(DescribeElasticPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticPlanName))
            {
                query["ElasticPlanName"] = request.ElasticPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                query["ResourceGroupName"] = request.ResourceGroupName;
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
                Action = "DescribeElasticPlans",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeElasticPlansResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries scaling plans of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeElasticPlansRequest
         * @return DescribeElasticPlansResponse
         */
        public DescribeElasticPlansResponse DescribeElasticPlans(DescribeElasticPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeElasticPlansWithOptions(request, runtime);
        }

        /**
         * @summary Queries scaling plans of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeElasticPlansRequest
         * @return DescribeElasticPlansResponse
         */
        public async Task<DescribeElasticPlansResponse> DescribeElasticPlansAsync(DescribeElasticPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeElasticPlansWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the permission level and permissions supported for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @param request DescribeEnabledPrivilegesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEnabledPrivilegesResponse
         */
        public DescribeEnabledPrivilegesResponse DescribeEnabledPrivilegesWithOptions(DescribeEnabledPrivilegesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEnabledPrivileges",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEnabledPrivilegesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the permission level and permissions supported for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @param request DescribeEnabledPrivilegesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEnabledPrivilegesResponse
         */
        public async Task<DescribeEnabledPrivilegesResponse> DescribeEnabledPrivilegesWithOptionsAsync(DescribeEnabledPrivilegesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEnabledPrivileges",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEnabledPrivilegesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the permission level and permissions supported for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @param request DescribeEnabledPrivilegesRequest
         * @return DescribeEnabledPrivilegesResponse
         */
        public DescribeEnabledPrivilegesResponse DescribeEnabledPrivileges(DescribeEnabledPrivilegesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEnabledPrivilegesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the permission level and permissions supported for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @param request DescribeEnabledPrivilegesRequest
         * @return DescribeEnabledPrivilegesResponse
         */
        public async Task<DescribeEnabledPrivilegesResponse> DescribeEnabledPrivilegesAsync(DescribeEnabledPrivilegesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEnabledPrivilegesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about tables that have excessive primary key fields in an AnalyticDB for MySQL Data Lakehouse Edition (V5.0) cluster.
         *
         * @param request DescribeExcessivePrimaryKeysRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExcessivePrimaryKeysResponse
         */
        public DescribeExcessivePrimaryKeysResponse DescribeExcessivePrimaryKeysWithOptions(DescribeExcessivePrimaryKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
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
                Action = "DescribeExcessivePrimaryKeys",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExcessivePrimaryKeysResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about tables that have excessive primary key fields in an AnalyticDB for MySQL Data Lakehouse Edition (V5.0) cluster.
         *
         * @param request DescribeExcessivePrimaryKeysRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExcessivePrimaryKeysResponse
         */
        public async Task<DescribeExcessivePrimaryKeysResponse> DescribeExcessivePrimaryKeysWithOptionsAsync(DescribeExcessivePrimaryKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
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
                Action = "DescribeExcessivePrimaryKeys",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExcessivePrimaryKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about tables that have excessive primary key fields in an AnalyticDB for MySQL Data Lakehouse Edition (V5.0) cluster.
         *
         * @param request DescribeExcessivePrimaryKeysRequest
         * @return DescribeExcessivePrimaryKeysResponse
         */
        public DescribeExcessivePrimaryKeysResponse DescribeExcessivePrimaryKeys(DescribeExcessivePrimaryKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExcessivePrimaryKeysWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about tables that have excessive primary key fields in an AnalyticDB for MySQL Data Lakehouse Edition (V5.0) cluster.
         *
         * @param request DescribeExcessivePrimaryKeysRequest
         * @return DescribeExcessivePrimaryKeysResponse
         */
        public async Task<DescribeExcessivePrimaryKeysResponse> DescribeExcessivePrimaryKeysAsync(DescribeExcessivePrimaryKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExcessivePrimaryKeysWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取作业资源使用统计
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeJobResourceUsageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeJobResourceUsageResponse
         */
        public DescribeJobResourceUsageResponse DescribeJobResourceUsageWithOptions(DescribeJobResourceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeJobResourceUsage",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobResourceUsageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取作业资源使用统计
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeJobResourceUsageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeJobResourceUsageResponse
         */
        public async Task<DescribeJobResourceUsageResponse> DescribeJobResourceUsageWithOptionsAsync(DescribeJobResourceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeJobResourceUsage",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobResourceUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取作业资源使用统计
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeJobResourceUsageRequest
         * @return DescribeJobResourceUsageResponse
         */
        public DescribeJobResourceUsageResponse DescribeJobResourceUsage(DescribeJobResourceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeJobResourceUsageWithOptions(request, runtime);
        }

        /**
         * @summary 获取作业资源使用统计
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeJobResourceUsageRequest
         * @return DescribeJobResourceUsageResponse
         */
        public async Task<DescribeJobResourceUsageResponse> DescribeJobResourceUsageAsync(DescribeJobResourceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeJobResourceUsageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about performance metrics of an SQL pattern such as the query duration and average memory usage for an AnalyticDB for MySQL cluster within a time range.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribePatternPerformanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePatternPerformanceResponse
         */
        public DescribePatternPerformanceResponse DescribePatternPerformanceWithOptions(DescribePatternPerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PatternId))
            {
                query["PatternId"] = request.PatternId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribePatternPerformance",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePatternPerformanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about performance metrics of an SQL pattern such as the query duration and average memory usage for an AnalyticDB for MySQL cluster within a time range.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribePatternPerformanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePatternPerformanceResponse
         */
        public async Task<DescribePatternPerformanceResponse> DescribePatternPerformanceWithOptionsAsync(DescribePatternPerformanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PatternId))
            {
                query["PatternId"] = request.PatternId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribePatternPerformance",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePatternPerformanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about performance metrics of an SQL pattern such as the query duration and average memory usage for an AnalyticDB for MySQL cluster within a time range.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribePatternPerformanceRequest
         * @return DescribePatternPerformanceResponse
         */
        public DescribePatternPerformanceResponse DescribePatternPerformance(DescribePatternPerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePatternPerformanceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about performance metrics of an SQL pattern such as the query duration and average memory usage for an AnalyticDB for MySQL cluster within a time range.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribePatternPerformanceRequest
         * @return DescribePatternPerformanceResponse
         */
        public async Task<DescribePatternPerformanceResponse> DescribePatternPerformanceAsync(DescribePatternPerformanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePatternPerformanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribePerformanceViewAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePerformanceViewAttributeResponse
         */
        public DescribePerformanceViewAttributeResponse DescribePerformanceViewAttributeWithOptions(DescribePerformanceViewAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewName))
            {
                query["ViewName"] = request.ViewName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePerformanceViewAttribute",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePerformanceViewAttributeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribePerformanceViewAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePerformanceViewAttributeResponse
         */
        public async Task<DescribePerformanceViewAttributeResponse> DescribePerformanceViewAttributeWithOptionsAsync(DescribePerformanceViewAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewName))
            {
                query["ViewName"] = request.ViewName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePerformanceViewAttribute",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePerformanceViewAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribePerformanceViewAttributeRequest
         * @return DescribePerformanceViewAttributeResponse
         */
        public DescribePerformanceViewAttributeResponse DescribePerformanceViewAttribute(DescribePerformanceViewAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePerformanceViewAttributeWithOptions(request, runtime);
        }

        /**
         * @param request DescribePerformanceViewAttributeRequest
         * @return DescribePerformanceViewAttributeResponse
         */
        public async Task<DescribePerformanceViewAttributeResponse> DescribePerformanceViewAttributeAsync(DescribePerformanceViewAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePerformanceViewAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribePerformanceViewsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePerformanceViewsResponse
         */
        public DescribePerformanceViewsResponse DescribePerformanceViewsWithOptions(DescribePerformanceViewsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "DescribePerformanceViews",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePerformanceViewsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribePerformanceViewsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePerformanceViewsResponse
         */
        public async Task<DescribePerformanceViewsResponse> DescribePerformanceViewsWithOptionsAsync(DescribePerformanceViewsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "DescribePerformanceViews",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePerformanceViewsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribePerformanceViewsRequest
         * @return DescribePerformanceViewsResponse
         */
        public DescribePerformanceViewsResponse DescribePerformanceViews(DescribePerformanceViewsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePerformanceViewsWithOptions(request, runtime);
        }

        /**
         * @param request DescribePerformanceViewsRequest
         * @return DescribePerformanceViewsResponse
         */
        public async Task<DescribePerformanceViewsResponse> DescribePerformanceViewsAsync(DescribePerformanceViewsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePerformanceViewsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of regions and zones in which AnalyticDB for MySQL Data Lakehouse Edition (V3.0) is available.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
                Version = "2021-12-01",
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
         * @summary Queries a list of regions and zones in which AnalyticDB for MySQL Data Lakehouse Edition (V3.0) is available.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
                Version = "2021-12-01",
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
         * @summary Queries a list of regions and zones in which AnalyticDB for MySQL Data Lakehouse Edition (V3.0) is available.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
         * @summary Queries a list of regions and zones in which AnalyticDB for MySQL Data Lakehouse Edition (V3.0) is available.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
         * @summary Queries a list of SQL patterns for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster within a time range.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeSQLPatternsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSQLPatternsResponse
         */
        public DescribeSQLPatternsResponse DescribeSQLPatternsWithOptions(DescribeSQLPatternsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeSQLPatterns",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLPatternsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of SQL patterns for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster within a time range.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeSQLPatternsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSQLPatternsResponse
         */
        public async Task<DescribeSQLPatternsResponse> DescribeSQLPatternsWithOptionsAsync(DescribeSQLPatternsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeSQLPatterns",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLPatternsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of SQL patterns for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster within a time range.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeSQLPatternsRequest
         * @return DescribeSQLPatternsResponse
         */
        public DescribeSQLPatternsResponse DescribeSQLPatterns(DescribeSQLPatternsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSQLPatternsWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of SQL patterns for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster within a time range.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeSQLPatternsRequest
         * @return DescribeSQLPatternsResponse
         */
        public async Task<DescribeSQLPatternsResponse> DescribeSQLPatternsAsync(DescribeSQLPatternsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSQLPatternsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of databases in an AnalyticDB for MySQL cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeSchemasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSchemasResponse
         */
        public DescribeSchemasResponse DescribeSchemasWithOptions(DescribeSchemasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "DescribeSchemas",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSchemasResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of databases in an AnalyticDB for MySQL cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeSchemasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSchemasResponse
         */
        public async Task<DescribeSchemasResponse> DescribeSchemasWithOptionsAsync(DescribeSchemasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "DescribeSchemas",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSchemasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of databases in an AnalyticDB for MySQL cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeSchemasRequest
         * @return DescribeSchemasResponse
         */
        public DescribeSchemasResponse DescribeSchemas(DescribeSchemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSchemasWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of databases in an AnalyticDB for MySQL cluster.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeSchemasRequest
         * @return DescribeSchemasResponse
         */
        public async Task<DescribeSchemasResponse> DescribeSchemasAsync(DescribeSchemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSchemasWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the execution logs of Spark code.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeSparkCodeLogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSparkCodeLogResponse
         */
        public DescribeSparkCodeLogResponse DescribeSparkCodeLogWithOptions(DescribeSparkCodeLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
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
                Action = "DescribeSparkCodeLog",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSparkCodeLogResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the execution logs of Spark code.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeSparkCodeLogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSparkCodeLogResponse
         */
        public async Task<DescribeSparkCodeLogResponse> DescribeSparkCodeLogWithOptionsAsync(DescribeSparkCodeLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
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
                Action = "DescribeSparkCodeLog",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSparkCodeLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the execution logs of Spark code.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeSparkCodeLogRequest
         * @return DescribeSparkCodeLogResponse
         */
        public DescribeSparkCodeLogResponse DescribeSparkCodeLog(DescribeSparkCodeLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSparkCodeLogWithOptions(request, runtime);
        }

        /**
         * @summary Queries the execution logs of Spark code.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeSparkCodeLogRequest
         * @return DescribeSparkCodeLogResponse
         */
        public async Task<DescribeSparkCodeLogResponse> DescribeSparkCodeLogAsync(DescribeSparkCodeLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSparkCodeLogWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the execution result of Spark code.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeSparkCodeOutputRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSparkCodeOutputResponse
         */
        public DescribeSparkCodeOutputResponse DescribeSparkCodeOutputWithOptions(DescribeSparkCodeOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
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
                Action = "DescribeSparkCodeOutput",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSparkCodeOutputResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the execution result of Spark code.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeSparkCodeOutputRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSparkCodeOutputResponse
         */
        public async Task<DescribeSparkCodeOutputResponse> DescribeSparkCodeOutputWithOptionsAsync(DescribeSparkCodeOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
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
                Action = "DescribeSparkCodeOutput",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSparkCodeOutputResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the execution result of Spark code.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeSparkCodeOutputRequest
         * @return DescribeSparkCodeOutputResponse
         */
        public DescribeSparkCodeOutputResponse DescribeSparkCodeOutput(DescribeSparkCodeOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSparkCodeOutputWithOptions(request, runtime);
        }

        /**
         * @summary Queries the execution result of Spark code.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeSparkCodeOutputRequest
         * @return DescribeSparkCodeOutputResponse
         */
        public async Task<DescribeSparkCodeOutputResponse> DescribeSparkCodeOutputAsync(DescribeSparkCodeOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSparkCodeOutputWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the URL of the web UI for a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeSparkCodeWebUiRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSparkCodeWebUiResponse
         */
        public DescribeSparkCodeWebUiResponse DescribeSparkCodeWebUiWithOptions(DescribeSparkCodeWebUiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
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
                Action = "DescribeSparkCodeWebUi",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSparkCodeWebUiResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the URL of the web UI for a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeSparkCodeWebUiRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSparkCodeWebUiResponse
         */
        public async Task<DescribeSparkCodeWebUiResponse> DescribeSparkCodeWebUiWithOptionsAsync(DescribeSparkCodeWebUiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
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
                Action = "DescribeSparkCodeWebUi",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSparkCodeWebUiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the URL of the web UI for a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeSparkCodeWebUiRequest
         * @return DescribeSparkCodeWebUiResponse
         */
        public DescribeSparkCodeWebUiResponse DescribeSparkCodeWebUi(DescribeSparkCodeWebUiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSparkCodeWebUiWithOptions(request, runtime);
        }

        /**
         * @summary Queries the URL of the web UI for a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeSparkCodeWebUiRequest
         * @return DescribeSparkCodeWebUiResponse
         */
        public async Task<DescribeSparkCodeWebUiResponse> DescribeSparkCodeWebUiAsync(DescribeSparkCodeWebUiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSparkCodeWebUiWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about SQL patterns of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster within a time range.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeSqlPatternRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSqlPatternResponse
         */
        public DescribeSqlPatternResponse DescribeSqlPatternWithOptions(DescribeSqlPatternRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlPattern))
            {
                query["SqlPattern"] = request.SqlPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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
                Action = "DescribeSqlPattern",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlPatternResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about SQL patterns of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster within a time range.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeSqlPatternRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSqlPatternResponse
         */
        public async Task<DescribeSqlPatternResponse> DescribeSqlPatternWithOptionsAsync(DescribeSqlPatternRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlPattern))
            {
                query["SqlPattern"] = request.SqlPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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
                Action = "DescribeSqlPattern",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlPatternResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about SQL patterns of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster within a time range.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeSqlPatternRequest
         * @return DescribeSqlPatternResponse
         */
        public DescribeSqlPatternResponse DescribeSqlPattern(DescribeSqlPatternRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSqlPatternWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about SQL patterns of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster within a time range.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeSqlPatternRequest
         * @return DescribeSqlPatternResponse
         */
        public async Task<DescribeSqlPatternResponse> DescribeSqlPatternAsync(DescribeSqlPatternRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSqlPatternWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the storage resource usage of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @param request DescribeStorageResourceUsageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeStorageResourceUsageResponse
         */
        public DescribeStorageResourceUsageResponse DescribeStorageResourceUsageWithOptions(DescribeStorageResourceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeStorageResourceUsage",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStorageResourceUsageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the storage resource usage of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @param request DescribeStorageResourceUsageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeStorageResourceUsageResponse
         */
        public async Task<DescribeStorageResourceUsageResponse> DescribeStorageResourceUsageWithOptionsAsync(DescribeStorageResourceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeStorageResourceUsage",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStorageResourceUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the storage resource usage of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @param request DescribeStorageResourceUsageRequest
         * @return DescribeStorageResourceUsageResponse
         */
        public DescribeStorageResourceUsageResponse DescribeStorageResourceUsage(DescribeStorageResourceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStorageResourceUsageWithOptions(request, runtime);
        }

        /**
         * @summary Queries the storage resource usage of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @param request DescribeStorageResourceUsageRequest
         * @return DescribeStorageResourceUsageResponse
         */
        public async Task<DescribeStorageResourceUsageResponse> DescribeStorageResourceUsageAsync(DescribeStorageResourceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStorageResourceUsageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the number of accesses to a table or all tables in an AnalyticDB for MySQL cluster on a date.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeTableAccessCountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTableAccessCountResponse
         */
        public DescribeTableAccessCountResponse DescribeTableAccessCountWithOptions(DescribeTableAccessCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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
                Action = "DescribeTableAccessCount",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTableAccessCountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the number of accesses to a table or all tables in an AnalyticDB for MySQL cluster on a date.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeTableAccessCountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTableAccessCountResponse
         */
        public async Task<DescribeTableAccessCountResponse> DescribeTableAccessCountWithOptionsAsync(DescribeTableAccessCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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
                Action = "DescribeTableAccessCount",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTableAccessCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the number of accesses to a table or all tables in an AnalyticDB for MySQL cluster on a date.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeTableAccessCountRequest
         * @return DescribeTableAccessCountResponse
         */
        public DescribeTableAccessCountResponse DescribeTableAccessCount(DescribeTableAccessCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTableAccessCountWithOptions(request, runtime);
        }

        /**
         * @summary Queries the number of accesses to a table or all tables in an AnalyticDB for MySQL cluster on a date.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DescribeTableAccessCountRequest
         * @return DescribeTableAccessCountResponse
         */
        public async Task<DescribeTableAccessCountResponse> DescribeTableAccessCountAsync(DescribeTableAccessCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTableAccessCountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of tables in a database.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeTablesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTablesResponse
         */
        public DescribeTablesResponse DescribeTablesWithOptions(DescribeTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["SchemaName"] = request.SchemaName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTables",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTablesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of tables in a database.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeTablesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTablesResponse
         */
        public async Task<DescribeTablesResponse> DescribeTablesWithOptionsAsync(DescribeTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["SchemaName"] = request.SchemaName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTables",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of tables in a database.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeTablesRequest
         * @return DescribeTablesResponse
         */
        public DescribeTablesResponse DescribeTables(DescribeTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTablesWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of tables in a database.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request DescribeTablesRequest
         * @return DescribeTablesResponse
         */
        public async Task<DescribeTablesResponse> DescribeTablesAsync(DescribeTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTablesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询配额
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeUserQuotaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserQuotaResponse
         */
        public DescribeUserQuotaResponse DescribeUserQuotaWithOptions(DescribeUserQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserQuota",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserQuotaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询配额
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeUserQuotaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserQuotaResponse
         */
        public async Task<DescribeUserQuotaResponse> DescribeUserQuotaWithOptionsAsync(DescribeUserQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserQuota",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询配额
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeUserQuotaRequest
         * @return DescribeUserQuotaResponse
         */
        public DescribeUserQuotaResponse DescribeUserQuota(DescribeUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserQuotaWithOptions(request, runtime);
        }

        /**
         * @summary 查询配额
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DescribeUserQuotaRequest
         * @return DescribeUserQuotaResponse
         */
        public async Task<DescribeUserQuotaResponse> DescribeUserQuotaAsync(DescribeUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserQuotaWithOptionsAsync(request, runtime);
        }

        /**
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DetachUserENIRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachUserENIResponse
         */
        public DetachUserENIResponse DetachUserENIWithOptions(DetachUserENIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachUserENI",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachUserENIResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DetachUserENIRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachUserENIResponse
         */
        public async Task<DetachUserENIResponse> DetachUserENIWithOptionsAsync(DetachUserENIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachUserENI",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachUserENIResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DetachUserENIRequest
         * @return DetachUserENIResponse
         */
        public DetachUserENIResponse DetachUserENI(DetachUserENIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachUserENIWithOptions(request, runtime);
        }

        /**
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DetachUserENIRequest
         * @return DetachUserENIResponse
         */
        public async Task<DetachUserENIResponse> DetachUserENIAsync(DetachUserENIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachUserENIWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disables a scaling plan for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DisableElasticPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableElasticPlanResponse
         */
        public DisableElasticPlanResponse DisableElasticPlanWithOptions(DisableElasticPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticPlanName))
            {
                query["ElasticPlanName"] = request.ElasticPlanName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableElasticPlan",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableElasticPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Disables a scaling plan for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DisableElasticPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableElasticPlanResponse
         */
        public async Task<DisableElasticPlanResponse> DisableElasticPlanWithOptionsAsync(DisableElasticPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticPlanName))
            {
                query["ElasticPlanName"] = request.ElasticPlanName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableElasticPlan",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableElasticPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Disables a scaling plan for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DisableElasticPlanRequest
         * @return DisableElasticPlanResponse
         */
        public DisableElasticPlanResponse DisableElasticPlan(DisableElasticPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableElasticPlanWithOptions(request, runtime);
        }

        /**
         * @summary Disables a scaling plan for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request DisableElasticPlanRequest
         * @return DisableElasticPlanResponse
         */
        public async Task<DisableElasticPlanResponse> DisableElasticPlanAsync(DisableElasticPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableElasticPlanWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Downloads the diagnostic information about SQL statements that meet a query condition for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DownloadDiagnosisRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DownloadDiagnosisRecordsResponse
         */
        public DownloadDiagnosisRecordsResponse DownloadDiagnosisRecordsWithOptions(DownloadDiagnosisRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                query["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                query["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPeakMemory))
            {
                query["MaxPeakMemory"] = request.MaxPeakMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxScanSize))
            {
                query["MaxScanSize"] = request.MaxScanSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinPeakMemory))
            {
                query["MinPeakMemory"] = request.MinPeakMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinScanSize))
            {
                query["MinScanSize"] = request.MinScanSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCondition))
            {
                query["QueryCondition"] = request.QueryCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroup))
            {
                query["ResourceGroup"] = request.ResourceGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadDiagnosisRecords",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadDiagnosisRecordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Downloads the diagnostic information about SQL statements that meet a query condition for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DownloadDiagnosisRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DownloadDiagnosisRecordsResponse
         */
        public async Task<DownloadDiagnosisRecordsResponse> DownloadDiagnosisRecordsWithOptionsAsync(DownloadDiagnosisRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                query["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                query["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPeakMemory))
            {
                query["MaxPeakMemory"] = request.MaxPeakMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxScanSize))
            {
                query["MaxScanSize"] = request.MaxScanSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinPeakMemory))
            {
                query["MinPeakMemory"] = request.MinPeakMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinScanSize))
            {
                query["MinScanSize"] = request.MinScanSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCondition))
            {
                query["QueryCondition"] = request.QueryCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroup))
            {
                query["ResourceGroup"] = request.ResourceGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadDiagnosisRecords",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadDiagnosisRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Downloads the diagnostic information about SQL statements that meet a query condition for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DownloadDiagnosisRecordsRequest
         * @return DownloadDiagnosisRecordsResponse
         */
        public DownloadDiagnosisRecordsResponse DownloadDiagnosisRecords(DownloadDiagnosisRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadDiagnosisRecordsWithOptions(request, runtime);
        }

        /**
         * @summary Downloads the diagnostic information about SQL statements that meet a query condition for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request DownloadDiagnosisRecordsRequest
         * @return DownloadDiagnosisRecordsResponse
         */
        public async Task<DownloadDiagnosisRecordsResponse> DownloadDiagnosisRecordsAsync(DownloadDiagnosisRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadDiagnosisRecordsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables a scaling plan for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request EnableElasticPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableElasticPlanResponse
         */
        public EnableElasticPlanResponse EnableElasticPlanWithOptions(EnableElasticPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticPlanName))
            {
                query["ElasticPlanName"] = request.ElasticPlanName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableElasticPlan",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableElasticPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables a scaling plan for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request EnableElasticPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableElasticPlanResponse
         */
        public async Task<EnableElasticPlanResponse> EnableElasticPlanWithOptionsAsync(EnableElasticPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticPlanName))
            {
                query["ElasticPlanName"] = request.ElasticPlanName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableElasticPlan",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableElasticPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables a scaling plan for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request EnableElasticPlanRequest
         * @return EnableElasticPlanResponse
         */
        public EnableElasticPlanResponse EnableElasticPlan(EnableElasticPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableElasticPlanWithOptions(request, runtime);
        }

        /**
         * @summary Enables a scaling plan for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request EnableElasticPlanRequest
         * @return EnableElasticPlanResponse
         */
        public async Task<EnableElasticPlanResponse> EnableElasticPlanAsync(EnableElasticPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableElasticPlanWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries whether a running SQL engine exists.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request ExistRunningSQLEngineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExistRunningSQLEngineResponse
         */
        public ExistRunningSQLEngineResponse ExistRunningSQLEngineWithOptions(ExistRunningSQLEngineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                body["ResourceGroupName"] = request.ResourceGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExistRunningSQLEngine",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExistRunningSQLEngineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries whether a running SQL engine exists.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request ExistRunningSQLEngineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExistRunningSQLEngineResponse
         */
        public async Task<ExistRunningSQLEngineResponse> ExistRunningSQLEngineWithOptionsAsync(ExistRunningSQLEngineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                body["ResourceGroupName"] = request.ResourceGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExistRunningSQLEngine",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExistRunningSQLEngineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries whether a running SQL engine exists.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request ExistRunningSQLEngineRequest
         * @return ExistRunningSQLEngineResponse
         */
        public ExistRunningSQLEngineResponse ExistRunningSQLEngine(ExistRunningSQLEngineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExistRunningSQLEngineWithOptions(request, runtime);
        }

        /**
         * @summary Queries whether a running SQL engine exists.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request ExistRunningSQLEngineRequest
         * @return ExistRunningSQLEngineResponse
         */
        public async Task<ExistRunningSQLEngineResponse> ExistRunningSQLEngineAsync(ExistRunningSQLEngineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExistRunningSQLEngineWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about databases.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetDatabaseObjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDatabaseObjectsResponse
         */
        public GetDatabaseObjectsResponse GetDatabaseObjectsWithOptions(GetDatabaseObjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterOwner))
            {
                query["FilterOwner"] = request.FilterOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterSchemaName))
            {
                query["FilterSchemaName"] = request.FilterSchemaName;
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
                Action = "GetDatabaseObjects",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatabaseObjectsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about databases.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetDatabaseObjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDatabaseObjectsResponse
         */
        public async Task<GetDatabaseObjectsResponse> GetDatabaseObjectsWithOptionsAsync(GetDatabaseObjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterOwner))
            {
                query["FilterOwner"] = request.FilterOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterSchemaName))
            {
                query["FilterSchemaName"] = request.FilterSchemaName;
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
                Action = "GetDatabaseObjects",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatabaseObjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about databases.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetDatabaseObjectsRequest
         * @return GetDatabaseObjectsResponse
         */
        public GetDatabaseObjectsResponse GetDatabaseObjects(GetDatabaseObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDatabaseObjectsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about databases.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetDatabaseObjectsRequest
         * @return GetDatabaseObjectsResponse
         */
        public async Task<GetDatabaseObjectsResponse> GetDatabaseObjectsAsync(GetDatabaseObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDatabaseObjectsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about the retry log of a Spark application.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetSparkAppAttemptLogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkAppAttemptLogResponse
         */
        public GetSparkAppAttemptLogResponse GetSparkAppAttemptLogWithOptions(GetSparkAppAttemptLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttemptId))
            {
                body["AttemptId"] = request.AttemptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogLength))
            {
                body["LogLength"] = request.LogLength;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkAppAttemptLog",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkAppAttemptLogResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about the retry log of a Spark application.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetSparkAppAttemptLogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkAppAttemptLogResponse
         */
        public async Task<GetSparkAppAttemptLogResponse> GetSparkAppAttemptLogWithOptionsAsync(GetSparkAppAttemptLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttemptId))
            {
                body["AttemptId"] = request.AttemptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogLength))
            {
                body["LogLength"] = request.LogLength;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkAppAttemptLog",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkAppAttemptLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about the retry log of a Spark application.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetSparkAppAttemptLogRequest
         * @return GetSparkAppAttemptLogResponse
         */
        public GetSparkAppAttemptLogResponse GetSparkAppAttemptLog(GetSparkAppAttemptLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSparkAppAttemptLogWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about the retry log of a Spark application.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetSparkAppAttemptLogRequest
         * @return GetSparkAppAttemptLogResponse
         */
        public async Task<GetSparkAppAttemptLogResponse> GetSparkAppAttemptLogAsync(GetSparkAppAttemptLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSparkAppAttemptLogWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about an Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkAppInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkAppInfoResponse
         */
        public GetSparkAppInfoResponse GetSparkAppInfoWithOptions(GetSparkAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkAppInfo",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkAppInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about an Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkAppInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkAppInfoResponse
         */
        public async Task<GetSparkAppInfoResponse> GetSparkAppInfoWithOptionsAsync(GetSparkAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkAppInfo",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkAppInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about an Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkAppInfoRequest
         * @return GetSparkAppInfoResponse
         */
        public GetSparkAppInfoResponse GetSparkAppInfo(GetSparkAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSparkAppInfoWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about an Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkAppInfoRequest
         * @return GetSparkAppInfoResponse
         */
        public async Task<GetSparkAppInfoResponse> GetSparkAppInfoAsync(GetSparkAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSparkAppInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the logs of a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkAppLogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkAppLogResponse
         */
        public GetSparkAppLogResponse GetSparkAppLogWithOptions(GetSparkAppLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogLength))
            {
                body["LogLength"] = request.LogLength;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkAppLog",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkAppLogResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the logs of a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkAppLogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkAppLogResponse
         */
        public async Task<GetSparkAppLogResponse> GetSparkAppLogWithOptionsAsync(GetSparkAppLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogLength))
            {
                body["LogLength"] = request.LogLength;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkAppLog",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkAppLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the logs of a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkAppLogRequest
         * @return GetSparkAppLogResponse
         */
        public GetSparkAppLogResponse GetSparkAppLog(GetSparkAppLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSparkAppLogWithOptions(request, runtime);
        }

        /**
         * @summary Queries the logs of a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkAppLogRequest
         * @return GetSparkAppLogResponse
         */
        public async Task<GetSparkAppLogResponse> GetSparkAppLogAsync(GetSparkAppLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSparkAppLogWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the metrics of a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkAppMetricsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkAppMetricsResponse
         */
        public GetSparkAppMetricsResponse GetSparkAppMetricsWithOptions(GetSparkAppMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkAppMetrics",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkAppMetricsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the metrics of a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkAppMetricsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkAppMetricsResponse
         */
        public async Task<GetSparkAppMetricsResponse> GetSparkAppMetricsWithOptionsAsync(GetSparkAppMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkAppMetrics",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkAppMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the metrics of a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkAppMetricsRequest
         * @return GetSparkAppMetricsResponse
         */
        public GetSparkAppMetricsResponse GetSparkAppMetrics(GetSparkAppMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSparkAppMetricsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the metrics of a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkAppMetricsRequest
         * @return GetSparkAppMetricsResponse
         */
        public async Task<GetSparkAppMetricsResponse> GetSparkAppMetricsAsync(GetSparkAppMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSparkAppMetricsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the status of a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkAppStateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkAppStateResponse
         */
        public GetSparkAppStateResponse GetSparkAppStateWithOptions(GetSparkAppStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkAppState",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkAppStateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the status of a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkAppStateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkAppStateResponse
         */
        public async Task<GetSparkAppStateResponse> GetSparkAppStateWithOptionsAsync(GetSparkAppStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkAppState",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkAppStateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the status of a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkAppStateRequest
         * @return GetSparkAppStateResponse
         */
        public GetSparkAppStateResponse GetSparkAppState(GetSparkAppStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSparkAppStateWithOptions(request, runtime);
        }

        /**
         * @summary Queries the status of a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkAppStateRequest
         * @return GetSparkAppStateResponse
         */
        public async Task<GetSparkAppStateResponse> GetSparkAppStateAsync(GetSparkAppStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSparkAppStateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the URL of the web UI for a Spark application.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetSparkAppWebUiAddressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkAppWebUiAddressResponse
         */
        public GetSparkAppWebUiAddressResponse GetSparkAppWebUiAddressWithOptions(GetSparkAppWebUiAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkAppWebUiAddress",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkAppWebUiAddressResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the URL of the web UI for a Spark application.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetSparkAppWebUiAddressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkAppWebUiAddressResponse
         */
        public async Task<GetSparkAppWebUiAddressResponse> GetSparkAppWebUiAddressWithOptionsAsync(GetSparkAppWebUiAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkAppWebUiAddress",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkAppWebUiAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the URL of the web UI for a Spark application.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetSparkAppWebUiAddressRequest
         * @return GetSparkAppWebUiAddressResponse
         */
        public GetSparkAppWebUiAddressResponse GetSparkAppWebUiAddress(GetSparkAppWebUiAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSparkAppWebUiAddressWithOptions(request, runtime);
        }

        /**
         * @summary Queries the URL of the web UI for a Spark application.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetSparkAppWebUiAddressRequest
         * @return GetSparkAppWebUiAddressResponse
         */
        public async Task<GetSparkAppWebUiAddressResponse> GetSparkAppWebUiAddressAsync(GetSparkAppWebUiAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSparkAppWebUiAddressWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the Spark log configuration of an AnalyticDB for MySQL cluster, including the default Spark log path.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkConfigLogPathRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkConfigLogPathResponse
         */
        public GetSparkConfigLogPathResponse GetSparkConfigLogPathWithOptions(GetSparkConfigLogPathRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkConfigLogPath",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkConfigLogPathResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the Spark log configuration of an AnalyticDB for MySQL cluster, including the default Spark log path.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkConfigLogPathRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkConfigLogPathResponse
         */
        public async Task<GetSparkConfigLogPathResponse> GetSparkConfigLogPathWithOptionsAsync(GetSparkConfigLogPathRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkConfigLogPath",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkConfigLogPathResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the Spark log configuration of an AnalyticDB for MySQL cluster, including the default Spark log path.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkConfigLogPathRequest
         * @return GetSparkConfigLogPathResponse
         */
        public GetSparkConfigLogPathResponse GetSparkConfigLogPath(GetSparkConfigLogPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSparkConfigLogPathWithOptions(request, runtime);
        }

        /**
         * @summary Queries the Spark log configuration of an AnalyticDB for MySQL cluster, including the default Spark log path.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkConfigLogPathRequest
         * @return GetSparkConfigLogPathResponse
         */
        public async Task<GetSparkConfigLogPathResponse> GetSparkConfigLogPathAsync(GetSparkConfigLogPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSparkConfigLogPathWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the common definitions of Spark applications.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkDefinitionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkDefinitionsResponse
         */
        public GetSparkDefinitionsResponse GetSparkDefinitionsWithOptions(GetSparkDefinitionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkDefinitions",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkDefinitionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the common definitions of Spark applications.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkDefinitionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkDefinitionsResponse
         */
        public async Task<GetSparkDefinitionsResponse> GetSparkDefinitionsWithOptionsAsync(GetSparkDefinitionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkDefinitions",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkDefinitionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the common definitions of Spark applications.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkDefinitionsRequest
         * @return GetSparkDefinitionsResponse
         */
        public GetSparkDefinitionsResponse GetSparkDefinitions(GetSparkDefinitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSparkDefinitionsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the common definitions of Spark applications.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkDefinitionsRequest
         * @return GetSparkDefinitionsResponse
         */
        public async Task<GetSparkDefinitionsResponse> GetSparkDefinitionsAsync(GetSparkDefinitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSparkDefinitionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the results of a Spark log analysis task.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetSparkLogAnalyzeTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkLogAnalyzeTaskResponse
         */
        public GetSparkLogAnalyzeTaskResponse GetSparkLogAnalyzeTaskWithOptions(GetSparkLogAnalyzeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkLogAnalyzeTask",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkLogAnalyzeTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the results of a Spark log analysis task.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetSparkLogAnalyzeTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkLogAnalyzeTaskResponse
         */
        public async Task<GetSparkLogAnalyzeTaskResponse> GetSparkLogAnalyzeTaskWithOptionsAsync(GetSparkLogAnalyzeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkLogAnalyzeTask",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkLogAnalyzeTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the results of a Spark log analysis task.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetSparkLogAnalyzeTaskRequest
         * @return GetSparkLogAnalyzeTaskResponse
         */
        public GetSparkLogAnalyzeTaskResponse GetSparkLogAnalyzeTask(GetSparkLogAnalyzeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSparkLogAnalyzeTaskWithOptions(request, runtime);
        }

        /**
         * @summary Queries the results of a Spark log analysis task.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetSparkLogAnalyzeTaskRequest
         * @return GetSparkLogAnalyzeTaskResponse
         */
        public async Task<GetSparkLogAnalyzeTaskResponse> GetSparkLogAnalyzeTaskAsync(GetSparkLogAnalyzeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSparkLogAnalyzeTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the state information about the Spark SQL engine.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkSQLEngineStateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkSQLEngineStateResponse
         */
        public GetSparkSQLEngineStateResponse GetSparkSQLEngineStateWithOptions(GetSparkSQLEngineStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                body["ResourceGroupName"] = request.ResourceGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkSQLEngineState",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkSQLEngineStateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the state information about the Spark SQL engine.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkSQLEngineStateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkSQLEngineStateResponse
         */
        public async Task<GetSparkSQLEngineStateResponse> GetSparkSQLEngineStateWithOptionsAsync(GetSparkSQLEngineStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                body["ResourceGroupName"] = request.ResourceGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkSQLEngineState",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkSQLEngineStateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the state information about the Spark SQL engine.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkSQLEngineStateRequest
         * @return GetSparkSQLEngineStateResponse
         */
        public GetSparkSQLEngineStateResponse GetSparkSQLEngineState(GetSparkSQLEngineStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSparkSQLEngineStateWithOptions(request, runtime);
        }

        /**
         * @summary Queries the state information about the Spark SQL engine.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkSQLEngineStateRequest
         * @return GetSparkSQLEngineStateResponse
         */
        public async Task<GetSparkSQLEngineStateResponse> GetSparkSQLEngineStateAsync(GetSparkSQLEngineStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSparkSQLEngineStateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the content of a Spark application template.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkTemplateFileContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkTemplateFileContentResponse
         */
        public GetSparkTemplateFileContentResponse GetSparkTemplateFileContentWithOptions(GetSparkTemplateFileContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkTemplateFileContent",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkTemplateFileContentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the content of a Spark application template.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkTemplateFileContentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkTemplateFileContentResponse
         */
        public async Task<GetSparkTemplateFileContentResponse> GetSparkTemplateFileContentWithOptionsAsync(GetSparkTemplateFileContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkTemplateFileContent",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkTemplateFileContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the content of a Spark application template.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkTemplateFileContentRequest
         * @return GetSparkTemplateFileContentResponse
         */
        public GetSparkTemplateFileContentResponse GetSparkTemplateFileContent(GetSparkTemplateFileContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSparkTemplateFileContentWithOptions(request, runtime);
        }

        /**
         * @summary Queries the content of a Spark application template.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkTemplateFileContentRequest
         * @return GetSparkTemplateFileContentResponse
         */
        public async Task<GetSparkTemplateFileContentResponse> GetSparkTemplateFileContentAsync(GetSparkTemplateFileContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSparkTemplateFileContentWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the directory structure of Spark applications.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkTemplateFolderTreeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkTemplateFolderTreeResponse
         */
        public GetSparkTemplateFolderTreeResponse GetSparkTemplateFolderTreeWithOptions(GetSparkTemplateFolderTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkTemplateFolderTree",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkTemplateFolderTreeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the directory structure of Spark applications.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkTemplateFolderTreeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkTemplateFolderTreeResponse
         */
        public async Task<GetSparkTemplateFolderTreeResponse> GetSparkTemplateFolderTreeWithOptionsAsync(GetSparkTemplateFolderTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkTemplateFolderTree",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkTemplateFolderTreeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the directory structure of Spark applications.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkTemplateFolderTreeRequest
         * @return GetSparkTemplateFolderTreeResponse
         */
        public GetSparkTemplateFolderTreeResponse GetSparkTemplateFolderTree(GetSparkTemplateFolderTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSparkTemplateFolderTreeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the directory structure of Spark applications.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request GetSparkTemplateFolderTreeRequest
         * @return GetSparkTemplateFolderTreeResponse
         */
        public async Task<GetSparkTemplateFolderTreeResponse> GetSparkTemplateFolderTreeAsync(GetSparkTemplateFolderTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSparkTemplateFolderTreeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the directory structure of Spark applications.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetSparkTemplateFullTreeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkTemplateFullTreeResponse
         */
        public GetSparkTemplateFullTreeResponse GetSparkTemplateFullTreeWithOptions(GetSparkTemplateFullTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkTemplateFullTree",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkTemplateFullTreeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the directory structure of Spark applications.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetSparkTemplateFullTreeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSparkTemplateFullTreeResponse
         */
        public async Task<GetSparkTemplateFullTreeResponse> GetSparkTemplateFullTreeWithOptionsAsync(GetSparkTemplateFullTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkTemplateFullTree",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkTemplateFullTreeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the directory structure of Spark applications.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetSparkTemplateFullTreeRequest
         * @return GetSparkTemplateFullTreeResponse
         */
        public GetSparkTemplateFullTreeResponse GetSparkTemplateFullTree(GetSparkTemplateFullTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSparkTemplateFullTreeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the directory structure of Spark applications.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetSparkTemplateFullTreeRequest
         * @return GetSparkTemplateFullTreeResponse
         */
        public async Task<GetSparkTemplateFullTreeResponse> GetSparkTemplateFullTreeAsync(GetSparkTemplateFullTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSparkTemplateFullTreeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取表
         *
         * @param request GetTableRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTableResponse
         */
        public GetTableResponse GetTableWithOptions(GetTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "GetTable",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取表
         *
         * @param request GetTableRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTableResponse
         */
        public async Task<GetTableResponse> GetTableWithOptionsAsync(GetTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "GetTable",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取表
         *
         * @param request GetTableRequest
         * @return GetTableResponse
         */
        public GetTableResponse GetTable(GetTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTableWithOptions(request, runtime);
        }

        /**
         * @summary 获取表
         *
         * @param request GetTableRequest
         * @return GetTableResponse
         */
        public async Task<GetTableResponse> GetTableAsync(GetTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTableWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about columns.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetTableColumnsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTableColumnsResponse
         */
        public GetTableColumnsResponse GetTableColumnsWithOptions(GetTableColumnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnName))
            {
                query["ColumnName"] = request.ColumnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["SchemaName"] = request.SchemaName;
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
                Action = "GetTableColumns",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableColumnsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about columns.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetTableColumnsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTableColumnsResponse
         */
        public async Task<GetTableColumnsResponse> GetTableColumnsWithOptionsAsync(GetTableColumnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnName))
            {
                query["ColumnName"] = request.ColumnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["SchemaName"] = request.SchemaName;
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
                Action = "GetTableColumns",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableColumnsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about columns.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetTableColumnsRequest
         * @return GetTableColumnsResponse
         */
        public GetTableColumnsResponse GetTableColumns(GetTableColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTableColumnsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about columns.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetTableColumnsRequest
         * @return GetTableColumnsResponse
         */
        public async Task<GetTableColumnsResponse> GetTableColumnsAsync(GetTableColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTableColumnsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the statement that is used to create a table.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetTableDDLRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTableDDLResponse
         */
        public GetTableDDLResponse GetTableDDLWithOptions(GetTableDDLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["SchemaName"] = request.SchemaName;
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
                Action = "GetTableDDL",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableDDLResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the statement that is used to create a table.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetTableDDLRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTableDDLResponse
         */
        public async Task<GetTableDDLResponse> GetTableDDLWithOptionsAsync(GetTableDDLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["SchemaName"] = request.SchemaName;
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
                Action = "GetTableDDL",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableDDLResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the statement that is used to create a table.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetTableDDLRequest
         * @return GetTableDDLResponse
         */
        public GetTableDDLResponse GetTableDDL(GetTableDDLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTableDDLWithOptions(request, runtime);
        }

        /**
         * @summary Queries the statement that is used to create a table.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetTableDDLRequest
         * @return GetTableDDLResponse
         */
        public async Task<GetTableDDLResponse> GetTableDDLAsync(GetTableDDLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTableDDLWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取table概要信息
         *
         * @param request GetTableObjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTableObjectsResponse
         */
        public GetTableObjectsResponse GetTableObjectsWithOptions(GetTableObjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterDescription))
            {
                query["FilterDescription"] = request.FilterDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterOwner))
            {
                query["FilterOwner"] = request.FilterOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterTblName))
            {
                query["FilterTblName"] = request.FilterTblName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterTblType))
            {
                query["FilterTblType"] = request.FilterTblType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["SchemaName"] = request.SchemaName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableObjects",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableObjectsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取table概要信息
         *
         * @param request GetTableObjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTableObjectsResponse
         */
        public async Task<GetTableObjectsResponse> GetTableObjectsWithOptionsAsync(GetTableObjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterDescription))
            {
                query["FilterDescription"] = request.FilterDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterOwner))
            {
                query["FilterOwner"] = request.FilterOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterTblName))
            {
                query["FilterTblName"] = request.FilterTblName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterTblType))
            {
                query["FilterTblType"] = request.FilterTblType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["SchemaName"] = request.SchemaName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableObjects",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableObjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取table概要信息
         *
         * @param request GetTableObjectsRequest
         * @return GetTableObjectsResponse
         */
        public GetTableObjectsResponse GetTableObjects(GetTableObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTableObjectsWithOptions(request, runtime);
        }

        /**
         * @summary 获取table概要信息
         *
         * @param request GetTableObjectsRequest
         * @return GetTableObjectsResponse
         */
        public async Task<GetTableObjectsResponse> GetTableObjectsAsync(GetTableObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTableObjectsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the statement that is used to create a view.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetViewDDLRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetViewDDLResponse
         */
        public GetViewDDLResponse GetViewDDLWithOptions(GetViewDDLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["SchemaName"] = request.SchemaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewName))
            {
                query["ViewName"] = request.ViewName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetViewDDL",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetViewDDLResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the statement that is used to create a view.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetViewDDLRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetViewDDLResponse
         */
        public async Task<GetViewDDLResponse> GetViewDDLWithOptionsAsync(GetViewDDLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["SchemaName"] = request.SchemaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewName))
            {
                query["ViewName"] = request.ViewName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetViewDDL",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetViewDDLResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the statement that is used to create a view.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetViewDDLRequest
         * @return GetViewDDLResponse
         */
        public GetViewDDLResponse GetViewDDL(GetViewDDLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetViewDDLWithOptions(request, runtime);
        }

        /**
         * @summary Queries the statement that is used to create a view.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetViewDDLRequest
         * @return GetViewDDLResponse
         */
        public async Task<GetViewDDLResponse> GetViewDDLAsync(GetViewDDLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetViewDDLWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about views.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetViewObjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetViewObjectsResponse
         */
        public GetViewObjectsResponse GetViewObjectsWithOptions(GetViewObjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterOwner))
            {
                query["FilterOwner"] = request.FilterOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterViewName))
            {
                query["FilterViewName"] = request.FilterViewName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterViewType))
            {
                query["FilterViewType"] = request.FilterViewType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["SchemaName"] = request.SchemaName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetViewObjects",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetViewObjectsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about views.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetViewObjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetViewObjectsResponse
         */
        public async Task<GetViewObjectsResponse> GetViewObjectsWithOptionsAsync(GetViewObjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterOwner))
            {
                query["FilterOwner"] = request.FilterOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterViewName))
            {
                query["FilterViewName"] = request.FilterViewName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterViewType))
            {
                query["FilterViewType"] = request.FilterViewType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["SchemaName"] = request.SchemaName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetViewObjects",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetViewObjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about views.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetViewObjectsRequest
         * @return GetViewObjectsResponse
         */
        public GetViewObjectsResponse GetViewObjects(GetViewObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetViewObjectsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about views.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request GetViewObjectsRequest
         * @return GetViewObjectsResponse
         */
        public async Task<GetViewObjectsResponse> GetViewObjectsAsync(GetViewObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetViewObjectsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Terminates a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request KillSparkAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return KillSparkAppResponse
         */
        public KillSparkAppResponse KillSparkAppWithOptions(KillSparkAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillSparkApp",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KillSparkAppResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Terminates a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request KillSparkAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return KillSparkAppResponse
         */
        public async Task<KillSparkAppResponse> KillSparkAppWithOptionsAsync(KillSparkAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillSparkApp",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KillSparkAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Terminates a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request KillSparkAppRequest
         * @return KillSparkAppResponse
         */
        public KillSparkAppResponse KillSparkApp(KillSparkAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return KillSparkAppWithOptions(request, runtime);
        }

        /**
         * @summary Terminates a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request KillSparkAppRequest
         * @return KillSparkAppResponse
         */
        public async Task<KillSparkAppResponse> KillSparkAppAsync(KillSparkAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await KillSparkAppWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Terminates a Spark log analysis task and queries the information about the analysis task.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request KillSparkLogAnalyzeTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return KillSparkLogAnalyzeTaskResponse
         */
        public KillSparkLogAnalyzeTaskResponse KillSparkLogAnalyzeTaskWithOptions(KillSparkLogAnalyzeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillSparkLogAnalyzeTask",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KillSparkLogAnalyzeTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Terminates a Spark log analysis task and queries the information about the analysis task.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request KillSparkLogAnalyzeTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return KillSparkLogAnalyzeTaskResponse
         */
        public async Task<KillSparkLogAnalyzeTaskResponse> KillSparkLogAnalyzeTaskWithOptionsAsync(KillSparkLogAnalyzeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillSparkLogAnalyzeTask",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KillSparkLogAnalyzeTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Terminates a Spark log analysis task and queries the information about the analysis task.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request KillSparkLogAnalyzeTaskRequest
         * @return KillSparkLogAnalyzeTaskResponse
         */
        public KillSparkLogAnalyzeTaskResponse KillSparkLogAnalyzeTask(KillSparkLogAnalyzeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return KillSparkLogAnalyzeTaskWithOptions(request, runtime);
        }

        /**
         * @summary Terminates a Spark log analysis task and queries the information about the analysis task.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request KillSparkLogAnalyzeTaskRequest
         * @return KillSparkLogAnalyzeTaskResponse
         */
        public async Task<KillSparkLogAnalyzeTaskResponse> KillSparkLogAnalyzeTaskAsync(KillSparkLogAnalyzeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await KillSparkLogAnalyzeTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Shuts down a Spark SQL engine.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request KillSparkSQLEngineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return KillSparkSQLEngineResponse
         */
        public KillSparkSQLEngineResponse KillSparkSQLEngineWithOptions(KillSparkSQLEngineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                body["ResourceGroupName"] = request.ResourceGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillSparkSQLEngine",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KillSparkSQLEngineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Shuts down a Spark SQL engine.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request KillSparkSQLEngineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return KillSparkSQLEngineResponse
         */
        public async Task<KillSparkSQLEngineResponse> KillSparkSQLEngineWithOptionsAsync(KillSparkSQLEngineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                body["ResourceGroupName"] = request.ResourceGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillSparkSQLEngine",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KillSparkSQLEngineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Shuts down a Spark SQL engine.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request KillSparkSQLEngineRequest
         * @return KillSparkSQLEngineResponse
         */
        public KillSparkSQLEngineResponse KillSparkSQLEngine(KillSparkSQLEngineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return KillSparkSQLEngineWithOptions(request, runtime);
        }

        /**
         * @summary Shuts down a Spark SQL engine.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request KillSparkSQLEngineRequest
         * @return KillSparkSQLEngineResponse
         */
        public async Task<KillSparkSQLEngineResponse> KillSparkSQLEngineAsync(KillSparkSQLEngineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await KillSparkSQLEngineWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about retry attempts of a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request ListSparkAppAttemptsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSparkAppAttemptsResponse
         */
        public ListSparkAppAttemptsResponse ListSparkAppAttemptsWithOptions(ListSparkAppAttemptsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "ListSparkAppAttempts",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSparkAppAttemptsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about retry attempts of a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request ListSparkAppAttemptsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSparkAppAttemptsResponse
         */
        public async Task<ListSparkAppAttemptsResponse> ListSparkAppAttemptsWithOptionsAsync(ListSparkAppAttemptsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "ListSparkAppAttempts",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSparkAppAttemptsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about retry attempts of a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request ListSparkAppAttemptsRequest
         * @return ListSparkAppAttemptsResponse
         */
        public ListSparkAppAttemptsResponse ListSparkAppAttempts(ListSparkAppAttemptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSparkAppAttemptsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about retry attempts of a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request ListSparkAppAttemptsRequest
         * @return ListSparkAppAttemptsResponse
         */
        public async Task<ListSparkAppAttemptsResponse> ListSparkAppAttemptsAsync(ListSparkAppAttemptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSparkAppAttemptsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the Spark applications that run on an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @param request ListSparkAppsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSparkAppsResponse
         */
        public ListSparkAppsResponse ListSparkAppsWithOptions(ListSparkAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                query["ResourceGroupName"] = request.ResourceGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSparkApps",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSparkAppsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the Spark applications that run on an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @param request ListSparkAppsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSparkAppsResponse
         */
        public async Task<ListSparkAppsResponse> ListSparkAppsWithOptionsAsync(ListSparkAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                query["ResourceGroupName"] = request.ResourceGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSparkApps",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSparkAppsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the Spark applications that run on an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @param request ListSparkAppsRequest
         * @return ListSparkAppsResponse
         */
        public ListSparkAppsResponse ListSparkApps(ListSparkAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSparkAppsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the Spark applications that run on an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @param request ListSparkAppsRequest
         * @return ListSparkAppsResponse
         */
        public async Task<ListSparkAppsResponse> ListSparkAppsAsync(ListSparkAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSparkAppsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of Spark log analysis tasks.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request ListSparkLogAnalyzeTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSparkLogAnalyzeTasksResponse
         */
        public ListSparkLogAnalyzeTasksResponse ListSparkLogAnalyzeTasksWithOptions(ListSparkLogAnalyzeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSparkLogAnalyzeTasks",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSparkLogAnalyzeTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of Spark log analysis tasks.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request ListSparkLogAnalyzeTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSparkLogAnalyzeTasksResponse
         */
        public async Task<ListSparkLogAnalyzeTasksResponse> ListSparkLogAnalyzeTasksWithOptionsAsync(ListSparkLogAnalyzeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSparkLogAnalyzeTasks",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSparkLogAnalyzeTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of Spark log analysis tasks.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request ListSparkLogAnalyzeTasksRequest
         * @return ListSparkLogAnalyzeTasksResponse
         */
        public ListSparkLogAnalyzeTasksResponse ListSparkLogAnalyzeTasks(ListSparkLogAnalyzeTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSparkLogAnalyzeTasksWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of Spark log analysis tasks.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request ListSparkLogAnalyzeTasksRequest
         * @return ListSparkLogAnalyzeTasksResponse
         */
        public async Task<ListSparkLogAnalyzeTasksResponse> ListSparkLogAnalyzeTasksAsync(ListSparkLogAnalyzeTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSparkLogAnalyzeTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all Spark template file IDs of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request ListSparkTemplateFileIdsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSparkTemplateFileIdsResponse
         */
        public ListSparkTemplateFileIdsResponse ListSparkTemplateFileIdsWithOptions(ListSparkTemplateFileIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSparkTemplateFileIds",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSparkTemplateFileIdsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries all Spark template file IDs of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request ListSparkTemplateFileIdsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSparkTemplateFileIdsResponse
         */
        public async Task<ListSparkTemplateFileIdsResponse> ListSparkTemplateFileIdsWithOptionsAsync(ListSparkTemplateFileIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSparkTemplateFileIds",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSparkTemplateFileIdsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries all Spark template file IDs of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request ListSparkTemplateFileIdsRequest
         * @return ListSparkTemplateFileIdsResponse
         */
        public ListSparkTemplateFileIdsResponse ListSparkTemplateFileIds(ListSparkTemplateFileIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSparkTemplateFileIdsWithOptions(request, runtime);
        }

        /**
         * @summary Queries all Spark template file IDs of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request ListSparkTemplateFileIdsRequest
         * @return ListSparkTemplateFileIdsResponse
         */
        public async Task<ListSparkTemplateFileIdsResponse> ListSparkTemplateFileIdsAsync(ListSparkTemplateFileIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSparkTemplateFileIdsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Loads a built-in dataset.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request LoadSampleDataSetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return LoadSampleDataSetResponse
         */
        public LoadSampleDataSetResponse LoadSampleDataSetWithOptions(LoadSampleDataSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LoadSampleDataSet",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoadSampleDataSetResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Loads a built-in dataset.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request LoadSampleDataSetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return LoadSampleDataSetResponse
         */
        public async Task<LoadSampleDataSetResponse> LoadSampleDataSetWithOptionsAsync(LoadSampleDataSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LoadSampleDataSet",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LoadSampleDataSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Loads a built-in dataset.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request LoadSampleDataSetRequest
         * @return LoadSampleDataSetResponse
         */
        public LoadSampleDataSetResponse LoadSampleDataSet(LoadSampleDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LoadSampleDataSetWithOptions(request, runtime);
        }

        /**
         * @summary Loads a built-in dataset.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request LoadSampleDataSetRequest
         * @return LoadSampleDataSetResponse
         */
        public async Task<LoadSampleDataSetResponse> LoadSampleDataSetAsync(LoadSampleDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LoadSampleDataSetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the description of a database account for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "ModifyAccountDescription",
                Version = "2021-12-01",
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
         * @summary Modifies the description of a database account for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "ModifyAccountDescription",
                Version = "2021-12-01",
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
         * @summary Modifies the description of a database account for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
         * @summary Modifies the description of a database account for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
         * @summary Modifies the permissions of a database account.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param tmpReq ModifyAccountPrivilegesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAccountPrivilegesResponse
         */
        public ModifyAccountPrivilegesResponse ModifyAccountPrivilegesWithOptions(ModifyAccountPrivilegesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyAccountPrivilegesShrinkRequest request = new ModifyAccountPrivilegesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountPrivileges))
            {
                request.AccountPrivilegesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountPrivileges, "AccountPrivileges", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPrivilegesShrink))
            {
                query["AccountPrivileges"] = request.AccountPrivilegesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "ModifyAccountPrivileges",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAccountPrivilegesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the permissions of a database account.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param tmpReq ModifyAccountPrivilegesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAccountPrivilegesResponse
         */
        public async Task<ModifyAccountPrivilegesResponse> ModifyAccountPrivilegesWithOptionsAsync(ModifyAccountPrivilegesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyAccountPrivilegesShrinkRequest request = new ModifyAccountPrivilegesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountPrivileges))
            {
                request.AccountPrivilegesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountPrivileges, "AccountPrivileges", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPrivilegesShrink))
            {
                query["AccountPrivileges"] = request.AccountPrivilegesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "ModifyAccountPrivileges",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAccountPrivilegesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the permissions of a database account.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyAccountPrivilegesRequest
         * @return ModifyAccountPrivilegesResponse
         */
        public ModifyAccountPrivilegesResponse ModifyAccountPrivileges(ModifyAccountPrivilegesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAccountPrivilegesWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the permissions of a database account.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyAccountPrivilegesRequest
         * @return ModifyAccountPrivilegesResponse
         */
        public async Task<ModifyAccountPrivilegesResponse> ModifyAccountPrivilegesAsync(ModifyAccountPrivilegesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAccountPrivilegesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the SQL audit settings of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyAuditLogConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAuditLogConfigResponse
         */
        public ModifyAuditLogConfigResponse ModifyAuditLogConfigWithOptions(ModifyAuditLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditLogStatus))
            {
                query["AuditLogStatus"] = request.AuditLogStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "ModifyAuditLogConfig",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAuditLogConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the SQL audit settings of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyAuditLogConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAuditLogConfigResponse
         */
        public async Task<ModifyAuditLogConfigResponse> ModifyAuditLogConfigWithOptionsAsync(ModifyAuditLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditLogStatus))
            {
                query["AuditLogStatus"] = request.AuditLogStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "ModifyAuditLogConfig",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAuditLogConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the SQL audit settings of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyAuditLogConfigRequest
         * @return ModifyAuditLogConfigResponse
         */
        public ModifyAuditLogConfigResponse ModifyAuditLogConfig(ModifyAuditLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAuditLogConfigWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the SQL audit settings of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyAuditLogConfigRequest
         * @return ModifyAuditLogConfigResponse
         */
        public async Task<ModifyAuditLogConfigResponse> ModifyAuditLogConfigAsync(ModifyAuditLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAuditLogConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the backup policy of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyBackupPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyBackupPolicyResponse
         */
        public ModifyBackupPolicyResponse ModifyBackupPolicyWithOptions(ModifyBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupRetentionPeriod))
            {
                query["BackupRetentionPeriod"] = request.BackupRetentionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableBackupLog))
            {
                query["EnableBackupLog"] = request.EnableBackupLog;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBackupPolicy",
                Version = "2021-12-01",
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
         * @summary Modifies the backup policy of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyBackupPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyBackupPolicyResponse
         */
        public async Task<ModifyBackupPolicyResponse> ModifyBackupPolicyWithOptionsAsync(ModifyBackupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupRetentionPeriod))
            {
                query["BackupRetentionPeriod"] = request.BackupRetentionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableBackupLog))
            {
                query["EnableBackupLog"] = request.EnableBackupLog;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBackupPolicy",
                Version = "2021-12-01",
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
         * @summary Modifies the backup policy of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
         * @summary Modifies the backup policy of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
         * @summary Modifies the IP address whitelist of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request ModifyClusterAccessWhiteListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyClusterAccessWhiteListResponse
         */
        public ModifyClusterAccessWhiteListResponse ModifyClusterAccessWhiteListWithOptions(ModifyClusterAccessWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterIPArrayAttribute))
            {
                query["DBClusterIPArrayAttribute"] = request.DBClusterIPArrayAttribute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterIPArrayName))
            {
                query["DBClusterIPArrayName"] = request.DBClusterIPArrayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMode))
            {
                query["ModifyMode"] = request.ModifyMode;
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
                Action = "ModifyClusterAccessWhiteList",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterAccessWhiteListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the IP address whitelist of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request ModifyClusterAccessWhiteListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyClusterAccessWhiteListResponse
         */
        public async Task<ModifyClusterAccessWhiteListResponse> ModifyClusterAccessWhiteListWithOptionsAsync(ModifyClusterAccessWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterIPArrayAttribute))
            {
                query["DBClusterIPArrayAttribute"] = request.DBClusterIPArrayAttribute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterIPArrayName))
            {
                query["DBClusterIPArrayName"] = request.DBClusterIPArrayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMode))
            {
                query["ModifyMode"] = request.ModifyMode;
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
                Action = "ModifyClusterAccessWhiteList",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterAccessWhiteListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the IP address whitelist of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request ModifyClusterAccessWhiteListRequest
         * @return ModifyClusterAccessWhiteListResponse
         */
        public ModifyClusterAccessWhiteListResponse ModifyClusterAccessWhiteList(ModifyClusterAccessWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyClusterAccessWhiteListWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the IP address whitelist of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request ModifyClusterAccessWhiteListRequest
         * @return ModifyClusterAccessWhiteListResponse
         */
        public async Task<ModifyClusterAccessWhiteListResponse> ModifyClusterAccessWhiteListAsync(ModifyClusterAccessWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyClusterAccessWhiteListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the public endpoint of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyClusterConnectionStringRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyClusterConnectionStringResponse
         */
        public ModifyClusterConnectionStringResponse ModifyClusterConnectionStringWithOptions(ModifyClusterConnectionStringRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionStringPrefix))
            {
                query["ConnectionStringPrefix"] = request.ConnectionStringPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentConnectionString))
            {
                query["CurrentConnectionString"] = request.CurrentConnectionString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterConnectionString",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterConnectionStringResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the public endpoint of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyClusterConnectionStringRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyClusterConnectionStringResponse
         */
        public async Task<ModifyClusterConnectionStringResponse> ModifyClusterConnectionStringWithOptionsAsync(ModifyClusterConnectionStringRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionStringPrefix))
            {
                query["ConnectionStringPrefix"] = request.ConnectionStringPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentConnectionString))
            {
                query["CurrentConnectionString"] = request.CurrentConnectionString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterConnectionString",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterConnectionStringResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the public endpoint of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyClusterConnectionStringRequest
         * @return ModifyClusterConnectionStringResponse
         */
        public ModifyClusterConnectionStringResponse ModifyClusterConnectionString(ModifyClusterConnectionStringRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyClusterConnectionStringWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the public endpoint of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyClusterConnectionStringRequest
         * @return ModifyClusterConnectionStringResponse
         */
        public async Task<ModifyClusterConnectionStringResponse> ModifyClusterConnectionStringAsync(ModifyClusterConnectionStringRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyClusterConnectionStringWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the configurations of an AnalyticDB for MySQL Data Lakehouse Edition cluster.
         *
         * @description ### [](#)
         * *   During a scaling event, you are not allowed to execute the `SUBMIT JOB` statement to submit asynchronous jobs. If your business requires asynchronous jobs, perform scaling during appropriate periods.
         * *   When you scale a cluster, data in the cluster is migrated for redistribution. The amount of time that is required to migrate data is proportional to the data volume. During a scaling event, the services provided by the cluster are not interrupted. When you downgrade cluster specifications, data migration may require up to dozens of hours to complete. Proceed with caution especially if your cluster contains a large amount of data.
         * *   If the cluster has a built-in dataset loaded, make sure that the cluster has reserved storage resources of at least 24 AnalyticDB compute units (ACUs). Otherwise, the built-in dataset cannot be used.
         * *   When the scaling process is about to end, transient connections may occur. We recommend that you scale your cluster during off-peak hours or make sure that your application is configured to automatically reconnect to your cluster.
         * *   You can change an AnalyticDB for MySQL cluster from Data Warehouse Edition to Data Lakehouse Edition, but not the other way around. For more information, see Change a cluster from Data Warehouse Edition to Data Lakehouse Edition.
         * *   For information about the endpoints of the current service, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyDBClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBClusterResponse
         */
        public ModifyDBClusterResponse ModifyDBClusterWithOptions(ModifyDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputeResource))
            {
                query["ComputeResource"] = request.ComputeResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableDefaultResourcePool))
            {
                query["EnableDefaultResourcePool"] = request.EnableDefaultResourcePool;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedNodeCount))
            {
                query["ReservedNodeCount"] = request.ReservedNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedNodeSize))
            {
                query["ReservedNodeSize"] = request.ReservedNodeSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageResource))
            {
                query["StorageResource"] = request.StorageResource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBCluster",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes the configurations of an AnalyticDB for MySQL Data Lakehouse Edition cluster.
         *
         * @description ### [](#)
         * *   During a scaling event, you are not allowed to execute the `SUBMIT JOB` statement to submit asynchronous jobs. If your business requires asynchronous jobs, perform scaling during appropriate periods.
         * *   When you scale a cluster, data in the cluster is migrated for redistribution. The amount of time that is required to migrate data is proportional to the data volume. During a scaling event, the services provided by the cluster are not interrupted. When you downgrade cluster specifications, data migration may require up to dozens of hours to complete. Proceed with caution especially if your cluster contains a large amount of data.
         * *   If the cluster has a built-in dataset loaded, make sure that the cluster has reserved storage resources of at least 24 AnalyticDB compute units (ACUs). Otherwise, the built-in dataset cannot be used.
         * *   When the scaling process is about to end, transient connections may occur. We recommend that you scale your cluster during off-peak hours or make sure that your application is configured to automatically reconnect to your cluster.
         * *   You can change an AnalyticDB for MySQL cluster from Data Warehouse Edition to Data Lakehouse Edition, but not the other way around. For more information, see Change a cluster from Data Warehouse Edition to Data Lakehouse Edition.
         * *   For information about the endpoints of the current service, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyDBClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBClusterResponse
         */
        public async Task<ModifyDBClusterResponse> ModifyDBClusterWithOptionsAsync(ModifyDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputeResource))
            {
                query["ComputeResource"] = request.ComputeResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableDefaultResourcePool))
            {
                query["EnableDefaultResourcePool"] = request.EnableDefaultResourcePool;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedNodeCount))
            {
                query["ReservedNodeCount"] = request.ReservedNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedNodeSize))
            {
                query["ReservedNodeSize"] = request.ReservedNodeSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageResource))
            {
                query["StorageResource"] = request.StorageResource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBCluster",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes the configurations of an AnalyticDB for MySQL Data Lakehouse Edition cluster.
         *
         * @description ### [](#)
         * *   During a scaling event, you are not allowed to execute the `SUBMIT JOB` statement to submit asynchronous jobs. If your business requires asynchronous jobs, perform scaling during appropriate periods.
         * *   When you scale a cluster, data in the cluster is migrated for redistribution. The amount of time that is required to migrate data is proportional to the data volume. During a scaling event, the services provided by the cluster are not interrupted. When you downgrade cluster specifications, data migration may require up to dozens of hours to complete. Proceed with caution especially if your cluster contains a large amount of data.
         * *   If the cluster has a built-in dataset loaded, make sure that the cluster has reserved storage resources of at least 24 AnalyticDB compute units (ACUs). Otherwise, the built-in dataset cannot be used.
         * *   When the scaling process is about to end, transient connections may occur. We recommend that you scale your cluster during off-peak hours or make sure that your application is configured to automatically reconnect to your cluster.
         * *   You can change an AnalyticDB for MySQL cluster from Data Warehouse Edition to Data Lakehouse Edition, but not the other way around. For more information, see Change a cluster from Data Warehouse Edition to Data Lakehouse Edition.
         * *   For information about the endpoints of the current service, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyDBClusterRequest
         * @return ModifyDBClusterResponse
         */
        public ModifyDBClusterResponse ModifyDBCluster(ModifyDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBClusterWithOptions(request, runtime);
        }

        /**
         * @summary Changes the configurations of an AnalyticDB for MySQL Data Lakehouse Edition cluster.
         *
         * @description ### [](#)
         * *   During a scaling event, you are not allowed to execute the `SUBMIT JOB` statement to submit asynchronous jobs. If your business requires asynchronous jobs, perform scaling during appropriate periods.
         * *   When you scale a cluster, data in the cluster is migrated for redistribution. The amount of time that is required to migrate data is proportional to the data volume. During a scaling event, the services provided by the cluster are not interrupted. When you downgrade cluster specifications, data migration may require up to dozens of hours to complete. Proceed with caution especially if your cluster contains a large amount of data.
         * *   If the cluster has a built-in dataset loaded, make sure that the cluster has reserved storage resources of at least 24 AnalyticDB compute units (ACUs). Otherwise, the built-in dataset cannot be used.
         * *   When the scaling process is about to end, transient connections may occur. We recommend that you scale your cluster during off-peak hours or make sure that your application is configured to automatically reconnect to your cluster.
         * *   You can change an AnalyticDB for MySQL cluster from Data Warehouse Edition to Data Lakehouse Edition, but not the other way around. For more information, see Change a cluster from Data Warehouse Edition to Data Lakehouse Edition.
         * *   For information about the endpoints of the current service, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyDBClusterRequest
         * @return ModifyDBClusterResponse
         */
        public async Task<ModifyDBClusterResponse> ModifyDBClusterAsync(ModifyDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the description of an AnalyticDB for MySQL cluster to facilitate the maintenance and management of the cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyDBClusterDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBClusterDescriptionResponse
         */
        public ModifyDBClusterDescriptionResponse ModifyDBClusterDescriptionWithOptions(ModifyDBClusterDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterDescription))
            {
                query["DBClusterDescription"] = request.DBClusterDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBClusterDescription",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBClusterDescriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the description of an AnalyticDB for MySQL cluster to facilitate the maintenance and management of the cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyDBClusterDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBClusterDescriptionResponse
         */
        public async Task<ModifyDBClusterDescriptionResponse> ModifyDBClusterDescriptionWithOptionsAsync(ModifyDBClusterDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterDescription))
            {
                query["DBClusterDescription"] = request.DBClusterDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBClusterDescription",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBClusterDescriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the description of an AnalyticDB for MySQL cluster to facilitate the maintenance and management of the cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyDBClusterDescriptionRequest
         * @return ModifyDBClusterDescriptionResponse
         */
        public ModifyDBClusterDescriptionResponse ModifyDBClusterDescription(ModifyDBClusterDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBClusterDescriptionWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the description of an AnalyticDB for MySQL cluster to facilitate the maintenance and management of the cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyDBClusterDescriptionRequest
         * @return ModifyDBClusterDescriptionResponse
         */
        public async Task<ModifyDBClusterDescriptionResponse> ModifyDBClusterDescriptionAsync(ModifyDBClusterDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBClusterDescriptionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the maintenance window of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyDBClusterMaintainTimeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBClusterMaintainTimeResponse
         */
        public ModifyDBClusterMaintainTimeResponse ModifyDBClusterMaintainTimeWithOptions(ModifyDBClusterMaintainTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaintainTime))
            {
                query["MaintainTime"] = request.MaintainTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBClusterMaintainTime",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBClusterMaintainTimeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the maintenance window of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyDBClusterMaintainTimeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBClusterMaintainTimeResponse
         */
        public async Task<ModifyDBClusterMaintainTimeResponse> ModifyDBClusterMaintainTimeWithOptionsAsync(ModifyDBClusterMaintainTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaintainTime))
            {
                query["MaintainTime"] = request.MaintainTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBClusterMaintainTime",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBClusterMaintainTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the maintenance window of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyDBClusterMaintainTimeRequest
         * @return ModifyDBClusterMaintainTimeResponse
         */
        public ModifyDBClusterMaintainTimeResponse ModifyDBClusterMaintainTime(ModifyDBClusterMaintainTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBClusterMaintainTimeWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the maintenance window of an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyDBClusterMaintainTimeRequest
         * @return ModifyDBClusterMaintainTimeResponse
         */
        public async Task<ModifyDBClusterMaintainTimeResponse> ModifyDBClusterMaintainTimeAsync(ModifyDBClusterMaintainTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBClusterMaintainTimeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the amount of reserved computing resources for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param tmpReq ModifyDBResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBResourceGroupResponse
         */
        public ModifyDBResourceGroupResponse ModifyDBResourceGroupWithOptions(ModifyDBResourceGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyDBResourceGroupShrinkRequest request = new ModifyDBResourceGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EngineParams))
            {
                request.EngineParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EngineParams, "EngineParams", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rules))
            {
                request.RulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rules, "Rules", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterMode))
            {
                query["ClusterMode"] = request.ClusterMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterSizeResource))
            {
                query["ClusterSizeResource"] = request.ClusterSizeResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSpot))
            {
                query["EnableSpot"] = request.EnableSpot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineParamsShrink))
            {
                query["EngineParams"] = request.EngineParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxClusterCount))
            {
                query["MaxClusterCount"] = request.MaxClusterCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxComputeResource))
            {
                query["MaxComputeResource"] = request.MaxComputeResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinClusterCount))
            {
                query["MinClusterCount"] = request.MinClusterCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinComputeResource))
            {
                query["MinComputeResource"] = request.MinComputeResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RulesShrink))
            {
                query["Rules"] = request.RulesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBResourceGroup",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the amount of reserved computing resources for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param tmpReq ModifyDBResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDBResourceGroupResponse
         */
        public async Task<ModifyDBResourceGroupResponse> ModifyDBResourceGroupWithOptionsAsync(ModifyDBResourceGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyDBResourceGroupShrinkRequest request = new ModifyDBResourceGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EngineParams))
            {
                request.EngineParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EngineParams, "EngineParams", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rules))
            {
                request.RulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rules, "Rules", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterMode))
            {
                query["ClusterMode"] = request.ClusterMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterSizeResource))
            {
                query["ClusterSizeResource"] = request.ClusterSizeResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSpot))
            {
                query["EnableSpot"] = request.EnableSpot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineParamsShrink))
            {
                query["EngineParams"] = request.EngineParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxClusterCount))
            {
                query["MaxClusterCount"] = request.MaxClusterCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxComputeResource))
            {
                query["MaxComputeResource"] = request.MaxComputeResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinClusterCount))
            {
                query["MinClusterCount"] = request.MinClusterCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinComputeResource))
            {
                query["MinComputeResource"] = request.MinComputeResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RulesShrink))
            {
                query["Rules"] = request.RulesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBResourceGroup",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the amount of reserved computing resources for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyDBResourceGroupRequest
         * @return ModifyDBResourceGroupResponse
         */
        public ModifyDBResourceGroupResponse ModifyDBResourceGroup(ModifyDBResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBResourceGroupWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the amount of reserved computing resources for an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ModifyDBResourceGroupRequest
         * @return ModifyDBResourceGroupResponse
         */
        public async Task<ModifyDBResourceGroupResponse> ModifyDBResourceGroupAsync(ModifyDBResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a scaling plan for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request ModifyElasticPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyElasticPlanResponse
         */
        public ModifyElasticPlanResponse ModifyElasticPlanWithOptions(ModifyElasticPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CronExpression))
            {
                query["CronExpression"] = request.CronExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticPlanName))
            {
                query["ElasticPlanName"] = request.ElasticPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSize))
            {
                query["TargetSize"] = request.TargetSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyElasticPlan",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyElasticPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies a scaling plan for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request ModifyElasticPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyElasticPlanResponse
         */
        public async Task<ModifyElasticPlanResponse> ModifyElasticPlanWithOptionsAsync(ModifyElasticPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CronExpression))
            {
                query["CronExpression"] = request.CronExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticPlanName))
            {
                query["ElasticPlanName"] = request.ElasticPlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSize))
            {
                query["TargetSize"] = request.TargetSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyElasticPlan",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyElasticPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a scaling plan for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request ModifyElasticPlanRequest
         * @return ModifyElasticPlanResponse
         */
        public ModifyElasticPlanResponse ModifyElasticPlan(ModifyElasticPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyElasticPlanWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a scaling plan for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see Endpoints.
         *
         * @param request ModifyElasticPlanRequest
         * @return ModifyElasticPlanResponse
         */
        public async Task<ModifyElasticPlanResponse> ModifyElasticPlanAsync(ModifyElasticPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyElasticPlanWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the information about a custom monitoring view.
         *
         * @param tmpReq ModifyPerformanceViewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPerformanceViewResponse
         */
        public ModifyPerformanceViewResponse ModifyPerformanceViewWithOptions(ModifyPerformanceViewRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyPerformanceViewShrinkRequest request = new ModifyPerformanceViewShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ViewDetail))
            {
                request.ViewDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ViewDetail, "ViewDetail", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewDetailShrink))
            {
                query["ViewDetail"] = request.ViewDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewName))
            {
                query["ViewName"] = request.ViewName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPerformanceView",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPerformanceViewResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the information about a custom monitoring view.
         *
         * @param tmpReq ModifyPerformanceViewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPerformanceViewResponse
         */
        public async Task<ModifyPerformanceViewResponse> ModifyPerformanceViewWithOptionsAsync(ModifyPerformanceViewRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyPerformanceViewShrinkRequest request = new ModifyPerformanceViewShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ViewDetail))
            {
                request.ViewDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ViewDetail, "ViewDetail", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewDetailShrink))
            {
                query["ViewDetail"] = request.ViewDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewName))
            {
                query["ViewName"] = request.ViewName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPerformanceView",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPerformanceViewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the information about a custom monitoring view.
         *
         * @param request ModifyPerformanceViewRequest
         * @return ModifyPerformanceViewResponse
         */
        public ModifyPerformanceViewResponse ModifyPerformanceView(ModifyPerformanceViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPerformanceViewWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the information about a custom monitoring view.
         *
         * @param request ModifyPerformanceViewRequest
         * @return ModifyPerformanceViewResponse
         */
        public async Task<ModifyPerformanceViewResponse> ModifyPerformanceViewAsync(ModifyPerformanceViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPerformanceViewWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Preloads metrics for a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request PreloadSparkAppMetricsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PreloadSparkAppMetricsResponse
         */
        public PreloadSparkAppMetricsResponse PreloadSparkAppMetricsWithOptions(PreloadSparkAppMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreloadSparkAppMetrics",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreloadSparkAppMetricsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Preloads metrics for a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request PreloadSparkAppMetricsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PreloadSparkAppMetricsResponse
         */
        public async Task<PreloadSparkAppMetricsResponse> PreloadSparkAppMetricsWithOptionsAsync(PreloadSparkAppMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreloadSparkAppMetrics",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreloadSparkAppMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Preloads metrics for a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request PreloadSparkAppMetricsRequest
         * @return PreloadSparkAppMetricsResponse
         */
        public PreloadSparkAppMetricsResponse PreloadSparkAppMetrics(PreloadSparkAppMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PreloadSparkAppMetricsWithOptions(request, runtime);
        }

        /**
         * @summary Preloads metrics for a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request PreloadSparkAppMetricsRequest
         * @return PreloadSparkAppMetricsResponse
         */
        public async Task<PreloadSparkAppMetricsResponse> PreloadSparkAppMetricsAsync(PreloadSparkAppMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PreloadSparkAppMetricsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Releases the public endpoint of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ReleaseClusterPublicConnectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseClusterPublicConnectionResponse
         */
        public ReleaseClusterPublicConnectionResponse ReleaseClusterPublicConnectionWithOptions(ReleaseClusterPublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "ReleaseClusterPublicConnection",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseClusterPublicConnectionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Releases the public endpoint of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ReleaseClusterPublicConnectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseClusterPublicConnectionResponse
         */
        public async Task<ReleaseClusterPublicConnectionResponse> ReleaseClusterPublicConnectionWithOptionsAsync(ReleaseClusterPublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "ReleaseClusterPublicConnection",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseClusterPublicConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Releases the public endpoint of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ReleaseClusterPublicConnectionRequest
         * @return ReleaseClusterPublicConnectionResponse
         */
        public ReleaseClusterPublicConnectionResponse ReleaseClusterPublicConnection(ReleaseClusterPublicConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseClusterPublicConnectionWithOptions(request, runtime);
        }

        /**
         * @summary Releases the public endpoint of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ReleaseClusterPublicConnectionRequest
         * @return ReleaseClusterPublicConnectionResponse
         */
        public async Task<ReleaseClusterPublicConnectionResponse> ReleaseClusterPublicConnectionAsync(ReleaseClusterPublicConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseClusterPublicConnectionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Renames a Spark template file.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request RenameSparkTemplateFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenameSparkTemplateFileResponse
         */
        public RenameSparkTemplateFileResponse RenameSparkTemplateFileWithOptions(RenameSparkTemplateFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenameSparkTemplateFile",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenameSparkTemplateFileResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Renames a Spark template file.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request RenameSparkTemplateFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenameSparkTemplateFileResponse
         */
        public async Task<RenameSparkTemplateFileResponse> RenameSparkTemplateFileWithOptionsAsync(RenameSparkTemplateFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenameSparkTemplateFile",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenameSparkTemplateFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Renames a Spark template file.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request RenameSparkTemplateFileRequest
         * @return RenameSparkTemplateFileResponse
         */
        public RenameSparkTemplateFileResponse RenameSparkTemplateFile(RenameSparkTemplateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenameSparkTemplateFileWithOptions(request, runtime);
        }

        /**
         * @summary Renames a Spark template file.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request RenameSparkTemplateFileRequest
         * @return RenameSparkTemplateFileResponse
         */
        public async Task<RenameSparkTemplateFileResponse> RenameSparkTemplateFileAsync(RenameSparkTemplateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenameSparkTemplateFileWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Resets the password of a database account for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ResetAccountPasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetAccountPasswordResponse
         */
        public ResetAccountPasswordResponse ResetAccountPasswordWithOptions(ResetAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPassword))
            {
                query["AccountPassword"] = request.AccountPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "ResetAccountPassword",
                Version = "2021-12-01",
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
         * @summary Resets the password of a database account for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request ResetAccountPasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetAccountPasswordResponse
         */
        public async Task<ResetAccountPasswordResponse> ResetAccountPasswordWithOptionsAsync(ResetAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPassword))
            {
                query["AccountPassword"] = request.AccountPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
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
                Action = "ResetAccountPassword",
                Version = "2021-12-01",
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
         * @summary Resets the password of a database account for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
         * @summary Resets the password of a database account for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
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
         * @summary Modifies the Spark log configuration.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request SetSparkAppLogRootPathRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetSparkAppLogRootPathResponse
         */
        public SetSparkAppLogRootPathResponse SetSparkAppLogRootPathWithOptions(SetSparkAppLogRootPathRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssLogPath))
            {
                body["OssLogPath"] = request.OssLogPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseDefaultOss))
            {
                body["UseDefaultOss"] = request.UseDefaultOss;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSparkAppLogRootPath",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSparkAppLogRootPathResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the Spark log configuration.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request SetSparkAppLogRootPathRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetSparkAppLogRootPathResponse
         */
        public async Task<SetSparkAppLogRootPathResponse> SetSparkAppLogRootPathWithOptionsAsync(SetSparkAppLogRootPathRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssLogPath))
            {
                body["OssLogPath"] = request.OssLogPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseDefaultOss))
            {
                body["UseDefaultOss"] = request.UseDefaultOss;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSparkAppLogRootPath",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSparkAppLogRootPathResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the Spark log configuration.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request SetSparkAppLogRootPathRequest
         * @return SetSparkAppLogRootPathResponse
         */
        public SetSparkAppLogRootPathResponse SetSparkAppLogRootPath(SetSparkAppLogRootPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetSparkAppLogRootPathWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the Spark log configuration.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request SetSparkAppLogRootPathRequest
         * @return SetSparkAppLogRootPathResponse
         */
        public async Task<SetSparkAppLogRootPathResponse> SetSparkAppLogRootPathAsync(SetSparkAppLogRootPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetSparkAppLogRootPathWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Starts the Spark SQL engine.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request StartSparkSQLEngineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartSparkSQLEngineResponse
         */
        public StartSparkSQLEngineResponse StartSparkSQLEngineWithOptions(StartSparkSQLEngineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jars))
            {
                body["Jars"] = request.Jars;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxExecutor))
            {
                body["MaxExecutor"] = request.MaxExecutor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinExecutor))
            {
                body["MinExecutor"] = request.MinExecutor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                body["ResourceGroupName"] = request.ResourceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlotNum))
            {
                body["SlotNum"] = request.SlotNum;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartSparkSQLEngine",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartSparkSQLEngineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Starts the Spark SQL engine.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request StartSparkSQLEngineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartSparkSQLEngineResponse
         */
        public async Task<StartSparkSQLEngineResponse> StartSparkSQLEngineWithOptionsAsync(StartSparkSQLEngineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jars))
            {
                body["Jars"] = request.Jars;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxExecutor))
            {
                body["MaxExecutor"] = request.MaxExecutor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinExecutor))
            {
                body["MinExecutor"] = request.MinExecutor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                body["ResourceGroupName"] = request.ResourceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlotNum))
            {
                body["SlotNum"] = request.SlotNum;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartSparkSQLEngine",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartSparkSQLEngineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Starts the Spark SQL engine.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request StartSparkSQLEngineRequest
         * @return StartSparkSQLEngineResponse
         */
        public StartSparkSQLEngineResponse StartSparkSQLEngine(StartSparkSQLEngineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartSparkSQLEngineWithOptions(request, runtime);
        }

        /**
         * @summary Starts the Spark SQL engine.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request StartSparkSQLEngineRequest
         * @return StartSparkSQLEngineResponse
         */
        public async Task<StartSparkSQLEngineResponse> StartSparkSQLEngineAsync(StartSparkSQLEngineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartSparkSQLEngineWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Submits a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request SubmitSparkAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitSparkAppResponse
         */
        public SubmitSparkAppResponse SubmitSparkAppWithOptions(SubmitSparkAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSource))
            {
                body["AgentSource"] = request.AgentSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                body["AgentVersion"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["AppType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                body["ResourceGroupName"] = request.ResourceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateFileId))
            {
                body["TemplateFileId"] = request.TemplateFileId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSparkApp",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSparkAppResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Submits a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request SubmitSparkAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitSparkAppResponse
         */
        public async Task<SubmitSparkAppResponse> SubmitSparkAppWithOptionsAsync(SubmitSparkAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentSource))
            {
                body["AgentSource"] = request.AgentSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentVersion))
            {
                body["AgentVersion"] = request.AgentVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["AppType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                body["ResourceGroupName"] = request.ResourceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateFileId))
            {
                body["TemplateFileId"] = request.TemplateFileId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSparkApp",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSparkAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Submits a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request SubmitSparkAppRequest
         * @return SubmitSparkAppResponse
         */
        public SubmitSparkAppResponse SubmitSparkApp(SubmitSparkAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSparkAppWithOptions(request, runtime);
        }

        /**
         * @summary Submits a Spark application.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request SubmitSparkAppRequest
         * @return SubmitSparkAppResponse
         */
        public async Task<SubmitSparkAppResponse> SubmitSparkAppAsync(SubmitSparkAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSparkAppWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Submits a Spark log analysis task and queries the analysis results.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request SubmitSparkLogAnalyzeTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitSparkLogAnalyzeTaskResponse
         */
        public SubmitSparkLogAnalyzeTaskResponse SubmitSparkLogAnalyzeTaskWithOptions(SubmitSparkLogAnalyzeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSparkLogAnalyzeTask",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSparkLogAnalyzeTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Submits a Spark log analysis task and queries the analysis results.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request SubmitSparkLogAnalyzeTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitSparkLogAnalyzeTaskResponse
         */
        public async Task<SubmitSparkLogAnalyzeTaskResponse> SubmitSparkLogAnalyzeTaskWithOptionsAsync(SubmitSparkLogAnalyzeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSparkLogAnalyzeTask",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSparkLogAnalyzeTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Submits a Spark log analysis task and queries the analysis results.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request SubmitSparkLogAnalyzeTaskRequest
         * @return SubmitSparkLogAnalyzeTaskResponse
         */
        public SubmitSparkLogAnalyzeTaskResponse SubmitSparkLogAnalyzeTask(SubmitSparkLogAnalyzeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSparkLogAnalyzeTaskWithOptions(request, runtime);
        }

        /**
         * @summary Submits a Spark log analysis task and queries the analysis results.
         *
         * @description *   General endpoint: `adb.aliyuncs.com`.
         * *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         *
         * @param request SubmitSparkLogAnalyzeTaskRequest
         * @return SubmitSparkLogAnalyzeTaskResponse
         */
        public async Task<SubmitSparkLogAnalyzeTaskResponse> SubmitSparkLogAnalyzeTaskAsync(SubmitSparkLogAnalyzeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSparkLogAnalyzeTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disassociates a standard account of an AnalyticDB for MySQL cluster from a Resource Access Management (RAM) user.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request UnbindAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindAccountResponse
         */
        public UnbindAccountResponse UnbindAccountWithOptions(UnbindAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindAccount",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Disassociates a standard account of an AnalyticDB for MySQL cluster from a Resource Access Management (RAM) user.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request UnbindAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindAccountResponse
         */
        public async Task<UnbindAccountResponse> UnbindAccountWithOptionsAsync(UnbindAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindAccount",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Disassociates a standard account of an AnalyticDB for MySQL cluster from a Resource Access Management (RAM) user.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request UnbindAccountRequest
         * @return UnbindAccountResponse
         */
        public UnbindAccountResponse UnbindAccount(UnbindAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindAccountWithOptions(request, runtime);
        }

        /**
         * @summary Disassociates a standard account of an AnalyticDB for MySQL cluster from a Resource Access Management (RAM) user.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request UnbindAccountRequest
         * @return UnbindAccountResponse
         */
        public async Task<UnbindAccountResponse> UnbindAccountAsync(UnbindAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disassociates resource groups from database accounts for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request UnbindDBResourceGroupWithUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindDBResourceGroupWithUserResponse
         */
        public UnbindDBResourceGroupWithUserResponse UnbindDBResourceGroupWithUserWithOptions(UnbindDBResourceGroupWithUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupUser))
            {
                query["GroupUser"] = request.GroupUser;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindDBResourceGroupWithUser",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindDBResourceGroupWithUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Disassociates resource groups from database accounts for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request UnbindDBResourceGroupWithUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindDBResourceGroupWithUserResponse
         */
        public async Task<UnbindDBResourceGroupWithUserResponse> UnbindDBResourceGroupWithUserWithOptionsAsync(UnbindDBResourceGroupWithUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupUser))
            {
                query["GroupUser"] = request.GroupUser;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindDBResourceGroupWithUser",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindDBResourceGroupWithUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Disassociates resource groups from database accounts for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request UnbindDBResourceGroupWithUserRequest
         * @return UnbindDBResourceGroupWithUserResponse
         */
        public UnbindDBResourceGroupWithUserResponse UnbindDBResourceGroupWithUser(UnbindDBResourceGroupWithUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindDBResourceGroupWithUserWithOptions(request, runtime);
        }

        /**
         * @summary Disassociates resource groups from database accounts for an AnalyticDB for MySQL cluster.
         *
         * @description For information about the endpoints of AnalyticDB for MySQL, see [Endpoints](https://help.aliyun.com/document_detail/612373.html).
         *
         * @param request UnbindDBResourceGroupWithUserRequest
         * @return UnbindDBResourceGroupWithUserResponse
         */
        public async Task<UnbindDBResourceGroupWithUserResponse> UnbindDBResourceGroupWithUserAsync(UnbindDBResourceGroupWithUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindDBResourceGroupWithUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates a Spark application template.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request UpdateSparkTemplateFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSparkTemplateFileResponse
         */
        public UpdateSparkTemplateFileResponse UpdateSparkTemplateFileWithOptions(UpdateSparkTemplateFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                body["ResourceGroupName"] = request.ResourceGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSparkTemplateFile",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSparkTemplateFileResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates a Spark application template.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request UpdateSparkTemplateFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSparkTemplateFileResponse
         */
        public async Task<UpdateSparkTemplateFileResponse> UpdateSparkTemplateFileWithOptionsAsync(UpdateSparkTemplateFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                body["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupName))
            {
                body["ResourceGroupName"] = request.ResourceGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSparkTemplateFile",
                Version = "2021-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSparkTemplateFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates a Spark application template.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request UpdateSparkTemplateFileRequest
         * @return UpdateSparkTemplateFileResponse
         */
        public UpdateSparkTemplateFileResponse UpdateSparkTemplateFile(UpdateSparkTemplateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSparkTemplateFileWithOptions(request, runtime);
        }

        /**
         * @summary Updates a Spark application template.
         *
         * @description *   Regional public endpoint: `adb.<region-id>.aliyuncs.com`. Example: `adb.cn-hangzhou.aliyuncs.com`.
         * *   Regional Virtual Private Cloud (VPC) endpoint: `adb-vpc.<region-id>.aliyuncs.com`. Example: `adb-vpc.cn-hangzhou.aliyuncs.com`.
         * >  If HTTP status code 409 is returned when you call this operation in the China (Qingdao), China (Shenzhen), China (Guangzhou), or China (Hong Kong) region, contact technical support.
         *
         * @param request UpdateSparkTemplateFileRequest
         * @return UpdateSparkTemplateFileResponse
         */
        public async Task<UpdateSparkTemplateFileResponse> UpdateSparkTemplateFileAsync(UpdateSparkTemplateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSparkTemplateFileWithOptionsAsync(request, runtime);
        }

    }
}
