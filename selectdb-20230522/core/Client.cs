// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Selectdb20230522.Models;

namespace AlibabaCloud.SDK.Selectdb20230522
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("selectdb", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Applies for a public endpoint for an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AllocateInstancePublicConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AllocateInstancePublicConnectionResponse
        /// </returns>
        public AllocateInstancePublicConnectionResponse AllocateInstancePublicConnectionWithOptions(AllocateInstancePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionStringPrefix))
            {
                query["ConnectionStringPrefix"] = request.ConnectionStringPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetType))
            {
                query["NetType"] = request.NetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "AllocateInstancePublicConnection",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllocateInstancePublicConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies for a public endpoint for an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AllocateInstancePublicConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AllocateInstancePublicConnectionResponse
        /// </returns>
        public async Task<AllocateInstancePublicConnectionResponse> AllocateInstancePublicConnectionWithOptionsAsync(AllocateInstancePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionStringPrefix))
            {
                query["ConnectionStringPrefix"] = request.ConnectionStringPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetType))
            {
                query["NetType"] = request.NetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "AllocateInstancePublicConnection",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllocateInstancePublicConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies for a public endpoint for an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AllocateInstancePublicConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// AllocateInstancePublicConnectionResponse
        /// </returns>
        public AllocateInstancePublicConnectionResponse AllocateInstancePublicConnection(AllocateInstancePublicConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocateInstancePublicConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies for a public endpoint for an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AllocateInstancePublicConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// AllocateInstancePublicConnectionResponse
        /// </returns>
        public async Task<AllocateInstancePublicConnectionResponse> AllocateInstancePublicConnectionAsync(AllocateInstancePublicConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocateInstancePublicConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SelectDB实例创建前检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckCreateDBInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckCreateDBInstanceResponse
        /// </returns>
        public CheckCreateDBInstanceResponse CheckCreateDBInstanceWithOptions(CheckCreateDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CacheSize))
            {
                query["CacheSize"] = request.CacheSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionString))
            {
                query["ConnectionString"] = request.ConnectionString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceClass))
            {
                query["DBInstanceClass"] = request.DBInstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceDescription))
            {
                query["DBInstanceDescription"] = request.DBInstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIPList))
            {
                query["SecurityIPList"] = request.SecurityIPList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedTime))
            {
                query["UsedTime"] = request.UsedTime;
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
                Action = "CheckCreateDBInstance",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckCreateDBInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SelectDB实例创建前检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckCreateDBInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckCreateDBInstanceResponse
        /// </returns>
        public async Task<CheckCreateDBInstanceResponse> CheckCreateDBInstanceWithOptionsAsync(CheckCreateDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CacheSize))
            {
                query["CacheSize"] = request.CacheSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionString))
            {
                query["ConnectionString"] = request.ConnectionString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceClass))
            {
                query["DBInstanceClass"] = request.DBInstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceDescription))
            {
                query["DBInstanceDescription"] = request.DBInstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIPList))
            {
                query["SecurityIPList"] = request.SecurityIPList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedTime))
            {
                query["UsedTime"] = request.UsedTime;
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
                Action = "CheckCreateDBInstance",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckCreateDBInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SelectDB实例创建前检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckCreateDBInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckCreateDBInstanceResponse
        /// </returns>
        public CheckCreateDBInstanceResponse CheckCreateDBInstance(CheckCreateDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckCreateDBInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SelectDB实例创建前检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckCreateDBInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckCreateDBInstanceResponse
        /// </returns>
        public async Task<CheckCreateDBInstanceResponse> CheckCreateDBInstanceAsync(CheckCreateDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckCreateDBInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查服务关联角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckServiceLinkedRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckServiceLinkedRoleResponse
        /// </returns>
        public CheckServiceLinkedRoleResponse CheckServiceLinkedRoleWithOptions(CheckServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
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
                Action = "CheckServiceLinkedRole",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckServiceLinkedRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查服务关联角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckServiceLinkedRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckServiceLinkedRoleResponse
        /// </returns>
        public async Task<CheckServiceLinkedRoleResponse> CheckServiceLinkedRoleWithOptionsAsync(CheckServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
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
                Action = "CheckServiceLinkedRole",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckServiceLinkedRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查服务关联角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckServiceLinkedRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckServiceLinkedRoleResponse
        /// </returns>
        public CheckServiceLinkedRoleResponse CheckServiceLinkedRole(CheckServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckServiceLinkedRoleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检查服务关联角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckServiceLinkedRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckServiceLinkedRoleResponse
        /// </returns>
        public async Task<CheckServiceLinkedRoleResponse> CheckServiceLinkedRoleAsync(CheckServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckServiceLinkedRoleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>: For an instance that uses the pay-as-you-go billing method, you can create only pay-as-you-go clusters. For an instance that uses the subscription billing method, you can create pay-as-you-go or subscription clusters.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDBClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDBClusterResponse
        /// </returns>
        public CreateDBClusterResponse CreateDBClusterWithOptions(CreateDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CacheSize))
            {
                query["CacheSize"] = request.CacheSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterClass))
            {
                query["DBClusterClass"] = request.DBClusterClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterDescription))
            {
                query["DBClusterDescription"] = request.DBClusterDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedTime))
            {
                query["UsedTime"] = request.UsedTime;
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                body["DBInstanceId"] = request.DBInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDBCluster",
                Version = "2023-05-22",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>: For an instance that uses the pay-as-you-go billing method, you can create only pay-as-you-go clusters. For an instance that uses the subscription billing method, you can create pay-as-you-go or subscription clusters.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDBClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDBClusterResponse
        /// </returns>
        public async Task<CreateDBClusterResponse> CreateDBClusterWithOptionsAsync(CreateDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CacheSize))
            {
                query["CacheSize"] = request.CacheSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterClass))
            {
                query["DBClusterClass"] = request.DBClusterClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterDescription))
            {
                query["DBClusterDescription"] = request.DBClusterDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedTime))
            {
                query["UsedTime"] = request.UsedTime;
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                body["DBInstanceId"] = request.DBInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDBCluster",
                Version = "2023-05-22",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>: For an instance that uses the pay-as-you-go billing method, you can create only pay-as-you-go clusters. For an instance that uses the subscription billing method, you can create pay-as-you-go or subscription clusters.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDBClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDBClusterResponse
        /// </returns>
        public CreateDBClusterResponse CreateDBCluster(CreateDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDBClusterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>: For an instance that uses the pay-as-you-go billing method, you can create only pay-as-you-go clusters. For an instance that uses the subscription billing method, you can create pay-as-you-go or subscription clusters.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDBClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDBClusterResponse
        /// </returns>
        public async Task<CreateDBClusterResponse> CreateDBClusterAsync(CreateDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDBClusterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建SelectDB实例</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDBInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDBInstanceResponse
        /// </returns>
        public CreateDBInstanceResponse CreateDBInstanceWithOptions(CreateDBInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDBInstanceShrinkRequest request = new CreateDBInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CacheSize))
            {
                query["CacheSize"] = request.CacheSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionString))
            {
                query["ConnectionString"] = request.ConnectionString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceClass))
            {
                query["DBInstanceClass"] = request.DBInstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceDescription))
            {
                query["DBInstanceDescription"] = request.DBInstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIPList))
            {
                query["SecurityIPList"] = request.SecurityIPList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedTime))
            {
                query["UsedTime"] = request.UsedTime;
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDBInstance",
                Version = "2023-05-22",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建SelectDB实例</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDBInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDBInstanceResponse
        /// </returns>
        public async Task<CreateDBInstanceResponse> CreateDBInstanceWithOptionsAsync(CreateDBInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDBInstanceShrinkRequest request = new CreateDBInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CacheSize))
            {
                query["CacheSize"] = request.CacheSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionString))
            {
                query["ConnectionString"] = request.ConnectionString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceClass))
            {
                query["DBInstanceClass"] = request.DBInstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceDescription))
            {
                query["DBInstanceDescription"] = request.DBInstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineVersion))
            {
                query["EngineVersion"] = request.EngineVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIPList))
            {
                query["SecurityIPList"] = request.SecurityIPList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedTime))
            {
                query["UsedTime"] = request.UsedTime;
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDBInstance",
                Version = "2023-05-22",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建SelectDB实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDBInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDBInstanceResponse
        /// </returns>
        public CreateDBInstanceResponse CreateDBInstance(CreateDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDBInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建SelectDB实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDBInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDBInstanceResponse
        /// </returns>
        public async Task<CreateDBInstanceResponse> CreateDBInstanceAsync(CreateDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDBInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建分时弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateElasticRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateElasticRuleResponse
        /// </returns>
        public CreateElasticRuleResponse CreateElasticRuleWithOptions(CreateElasticRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterClass))
            {
                query["ClusterClass"] = request.ClusterClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbInstanceId))
            {
                query["DbInstanceId"] = request.DbInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticRuleStartTime))
            {
                query["ElasticRuleStartTime"] = request.ElasticRuleStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionPeriod))
            {
                query["ExecutionPeriod"] = request.ExecutionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "CreateElasticRule",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateElasticRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建分时弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateElasticRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateElasticRuleResponse
        /// </returns>
        public async Task<CreateElasticRuleResponse> CreateElasticRuleWithOptionsAsync(CreateElasticRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterClass))
            {
                query["ClusterClass"] = request.ClusterClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbInstanceId))
            {
                query["DbInstanceId"] = request.DbInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticRuleStartTime))
            {
                query["ElasticRuleStartTime"] = request.ElasticRuleStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionPeriod))
            {
                query["ExecutionPeriod"] = request.ExecutionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "CreateElasticRule",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateElasticRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建分时弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateElasticRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateElasticRuleResponse
        /// </returns>
        public CreateElasticRuleResponse CreateElasticRule(CreateElasticRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateElasticRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建分时弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateElasticRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateElasticRuleResponse
        /// </returns>
        public async Task<CreateElasticRuleResponse> CreateElasticRuleAsync(CreateElasticRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateElasticRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service-linked role for ApsaraDB for SelectDB.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceLinkedRoleForSelectDBRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceLinkedRoleForSelectDBResponse
        /// </returns>
        public CreateServiceLinkedRoleForSelectDBResponse CreateServiceLinkedRoleForSelectDBWithOptions(CreateServiceLinkedRoleForSelectDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
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
                Action = "CreateServiceLinkedRoleForSelectDB",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceLinkedRoleForSelectDBResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service-linked role for ApsaraDB for SelectDB.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceLinkedRoleForSelectDBRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceLinkedRoleForSelectDBResponse
        /// </returns>
        public async Task<CreateServiceLinkedRoleForSelectDBResponse> CreateServiceLinkedRoleForSelectDBWithOptionsAsync(CreateServiceLinkedRoleForSelectDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
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
                Action = "CreateServiceLinkedRoleForSelectDB",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceLinkedRoleForSelectDBResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service-linked role for ApsaraDB for SelectDB.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceLinkedRoleForSelectDBRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceLinkedRoleForSelectDBResponse
        /// </returns>
        public CreateServiceLinkedRoleForSelectDBResponse CreateServiceLinkedRoleForSelectDB(CreateServiceLinkedRoleForSelectDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServiceLinkedRoleForSelectDBWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a service-linked role for ApsaraDB for SelectDB.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceLinkedRoleForSelectDBRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceLinkedRoleForSelectDBResponse
        /// </returns>
        public async Task<CreateServiceLinkedRoleForSelectDBResponse> CreateServiceLinkedRoleForSelectDBAsync(CreateServiceLinkedRoleForSelectDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServiceLinkedRoleForSelectDBWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>释放实例下集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDBClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDBClusterResponse
        /// </returns>
        public DeleteDBClusterResponse DeleteDBClusterWithOptions(DeleteDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                body["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDBCluster",
                Version = "2023-05-22",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>释放实例下集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDBClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDBClusterResponse
        /// </returns>
        public async Task<DeleteDBClusterResponse> DeleteDBClusterWithOptionsAsync(DeleteDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                body["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDBCluster",
                Version = "2023-05-22",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>释放实例下集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDBClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDBClusterResponse
        /// </returns>
        public DeleteDBClusterResponse DeleteDBCluster(DeleteDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDBClusterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>释放实例下集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDBClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDBClusterResponse
        /// </returns>
        public async Task<DeleteDBClusterResponse> DeleteDBClusterAsync(DeleteDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDBClusterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除DB实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDBInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDBInstanceResponse
        /// </returns>
        public DeleteDBInstanceResponse DeleteDBInstanceWithOptions(DeleteDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                body["DBInstanceId"] = request.DBInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDBInstance",
                Version = "2023-05-22",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除DB实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDBInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDBInstanceResponse
        /// </returns>
        public async Task<DeleteDBInstanceResponse> DeleteDBInstanceWithOptionsAsync(DeleteDBInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                body["DBInstanceId"] = request.DBInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDBInstance",
                Version = "2023-05-22",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除DB实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDBInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDBInstanceResponse
        /// </returns>
        public DeleteDBInstanceResponse DeleteDBInstance(DeleteDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDBInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除DB实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDBInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDBInstanceResponse
        /// </returns>
        public async Task<DeleteDBInstanceResponse> DeleteDBInstanceAsync(DeleteDBInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDBInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除分时弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteElasticRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteElasticRuleResponse
        /// </returns>
        public DeleteElasticRuleResponse DeleteElasticRuleWithOptions(DeleteElasticRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbInstanceId))
            {
                query["DbInstanceId"] = request.DbInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteElasticRule",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteElasticRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除分时弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteElasticRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteElasticRuleResponse
        /// </returns>
        public async Task<DeleteElasticRuleResponse> DeleteElasticRuleWithOptionsAsync(DeleteElasticRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbInstanceId))
            {
                query["DbInstanceId"] = request.DbInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteElasticRule",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteElasticRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除分时弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteElasticRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteElasticRuleResponse
        /// </returns>
        public DeleteElasticRuleResponse DeleteElasticRule(DeleteElasticRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteElasticRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除分时弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteElasticRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteElasticRuleResponse
        /// </returns>
        public async Task<DeleteElasticRuleResponse> DeleteElasticRuleAsync(DeleteElasticRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteElasticRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all instance specifications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAllDBInstanceClassRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAllDBInstanceClassResponse
        /// </returns>
        public DescribeAllDBInstanceClassResponse DescribeAllDBInstanceClassWithOptions(DescribeAllDBInstanceClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeAllDBInstanceClass",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAllDBInstanceClassResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all instance specifications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAllDBInstanceClassRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAllDBInstanceClassResponse
        /// </returns>
        public async Task<DescribeAllDBInstanceClassResponse> DescribeAllDBInstanceClassWithOptionsAsync(DescribeAllDBInstanceClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeAllDBInstanceClass",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAllDBInstanceClassResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all instance specifications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAllDBInstanceClassRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAllDBInstanceClassResponse
        /// </returns>
        public DescribeAllDBInstanceClassResponse DescribeAllDBInstanceClass(DescribeAllDBInstanceClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAllDBInstanceClassWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all instance specifications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAllDBInstanceClassRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAllDBInstanceClassResponse
        /// </returns>
        public async Task<DescribeAllDBInstanceClassResponse> DescribeAllDBInstanceClassAsync(DescribeAllDBInstanceClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAllDBInstanceClassWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration information about a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBClusterConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBClusterConfigResponse
        /// </returns>
        public DescribeDBClusterConfigResponse DescribeDBClusterConfigWithOptions(DescribeDBClusterConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKey))
            {
                query["ConfigKey"] = request.ConfigKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
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
                Action = "DescribeDBClusterConfig",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBClusterConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration information about a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBClusterConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBClusterConfigResponse
        /// </returns>
        public async Task<DescribeDBClusterConfigResponse> DescribeDBClusterConfigWithOptionsAsync(DescribeDBClusterConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKey))
            {
                query["ConfigKey"] = request.ConfigKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
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
                Action = "DescribeDBClusterConfig",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBClusterConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration information about a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBClusterConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBClusterConfigResponse
        /// </returns>
        public DescribeDBClusterConfigResponse DescribeDBClusterConfig(DescribeDBClusterConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBClusterConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration information about a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBClusterConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBClusterConfigResponse
        /// </returns>
        public async Task<DescribeDBClusterConfigResponse> DescribeDBClusterConfigAsync(DescribeDBClusterConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBClusterConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration change logs of a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBClusterConfigChangeLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBClusterConfigChangeLogsResponse
        /// </returns>
        public DescribeDBClusterConfigChangeLogsResponse DescribeDBClusterConfigChangeLogsWithOptions(DescribeDBClusterConfigChangeLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKey))
            {
                query["ConfigKey"] = request.ConfigKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeDBClusterConfigChangeLogs",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBClusterConfigChangeLogsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration change logs of a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBClusterConfigChangeLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBClusterConfigChangeLogsResponse
        /// </returns>
        public async Task<DescribeDBClusterConfigChangeLogsResponse> DescribeDBClusterConfigChangeLogsWithOptionsAsync(DescribeDBClusterConfigChangeLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKey))
            {
                query["ConfigKey"] = request.ConfigKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeDBClusterConfigChangeLogs",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBClusterConfigChangeLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration change logs of a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBClusterConfigChangeLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBClusterConfigChangeLogsResponse
        /// </returns>
        public DescribeDBClusterConfigChangeLogsResponse DescribeDBClusterConfigChangeLogs(DescribeDBClusterConfigChangeLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBClusterConfigChangeLogsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration change logs of a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBClusterConfigChangeLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBClusterConfigChangeLogsResponse
        /// </returns>
        public async Task<DescribeDBClusterConfigChangeLogsResponse> DescribeDBClusterConfigChangeLogsAsync(DescribeDBClusterConfigChangeLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBClusterConfigChangeLogsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBInstanceAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBInstanceAttributeResponse
        /// </returns>
        public DescribeDBInstanceAttributeResponse DescribeDBInstanceAttributeWithOptions(DescribeDBInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeDBInstanceAttribute",
                Version = "2023-05-22",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBInstanceAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBInstanceAttributeResponse
        /// </returns>
        public async Task<DescribeDBInstanceAttributeResponse> DescribeDBInstanceAttributeWithOptionsAsync(DescribeDBInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeDBInstanceAttribute",
                Version = "2023-05-22",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBInstanceAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBInstanceAttributeResponse
        /// </returns>
        public DescribeDBInstanceAttributeResponse DescribeDBInstanceAttribute(DescribeDBInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBInstanceAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBInstanceAttributeResponse
        /// </returns>
        public async Task<DescribeDBInstanceAttributeResponse> DescribeDBInstanceAttributeAsync(DescribeDBInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the network information about an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBInstanceNetInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBInstanceNetInfoResponse
        /// </returns>
        public DescribeDBInstanceNetInfoResponse DescribeDBInstanceNetInfoWithOptions(DescribeDBInstanceNetInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeDBInstanceNetInfo",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceNetInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the network information about an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBInstanceNetInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBInstanceNetInfoResponse
        /// </returns>
        public async Task<DescribeDBInstanceNetInfoResponse> DescribeDBInstanceNetInfoWithOptionsAsync(DescribeDBInstanceNetInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeDBInstanceNetInfo",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDBInstanceNetInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the network information about an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBInstanceNetInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBInstanceNetInfoResponse
        /// </returns>
        public DescribeDBInstanceNetInfoResponse DescribeDBInstanceNetInfo(DescribeDBInstanceNetInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstanceNetInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the network information about an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBInstanceNetInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBInstanceNetInfoResponse
        /// </returns>
        public async Task<DescribeDBInstanceNetInfoResponse> DescribeDBInstanceNetInfoAsync(DescribeDBInstanceNetInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstanceNetInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about ApsaraDB for SelectDB instances.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeDBInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBInstancesResponse
        /// </returns>
        public DescribeDBInstancesResponse DescribeDBInstancesWithOptions(DescribeDBInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeDBInstancesShrinkRequest request = new DescribeDBInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceDescription))
            {
                query["DBInstanceDescription"] = request.DBInstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceIds))
            {
                query["DBInstanceIds"] = request.DBInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceStatus))
            {
                query["DBInstanceStatus"] = request.DBInstanceStatus;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstances",
                Version = "2023-05-22",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about ApsaraDB for SelectDB instances.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeDBInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBInstancesResponse
        /// </returns>
        public async Task<DescribeDBInstancesResponse> DescribeDBInstancesWithOptionsAsync(DescribeDBInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeDBInstancesShrinkRequest request = new DescribeDBInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceDescription))
            {
                query["DBInstanceDescription"] = request.DBInstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceIds))
            {
                query["DBInstanceIds"] = request.DBInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceStatus))
            {
                query["DBInstanceStatus"] = request.DBInstanceStatus;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDBInstances",
                Version = "2023-05-22",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about ApsaraDB for SelectDB instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBInstancesResponse
        /// </returns>
        public DescribeDBInstancesResponse DescribeDBInstances(DescribeDBInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDBInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about ApsaraDB for SelectDB instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDBInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDBInstancesResponse
        /// </returns>
        public async Task<DescribeDBInstancesResponse> DescribeDBInstancesAsync(DescribeDBInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDBInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分时弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeElasticRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeElasticRulesResponse
        /// </returns>
        public DescribeElasticRulesResponse DescribeElasticRulesWithOptions(DescribeElasticRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeElasticRules",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeElasticRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分时弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeElasticRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeElasticRulesResponse
        /// </returns>
        public async Task<DescribeElasticRulesResponse> DescribeElasticRulesWithOptionsAsync(DescribeElasticRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeElasticRules",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeElasticRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分时弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeElasticRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeElasticRulesResponse
        /// </returns>
        public DescribeElasticRulesResponse DescribeElasticRules(DescribeElasticRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeElasticRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分时弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeElasticRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeElasticRulesResponse
        /// </returns>
        public async Task<DescribeElasticRulesResponse> DescribeElasticRulesAsync(DescribeElasticRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeElasticRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IP addresses in the whitelists of an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSecurityIPListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityIPListResponse
        /// </returns>
        public DescribeSecurityIPListResponse DescribeSecurityIPListWithOptions(DescribeSecurityIPListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeSecurityIPList",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecurityIPListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IP addresses in the whitelists of an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSecurityIPListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityIPListResponse
        /// </returns>
        public async Task<DescribeSecurityIPListResponse> DescribeSecurityIPListWithOptionsAsync(DescribeSecurityIPListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeSecurityIPList",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecurityIPListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IP addresses in the whitelists of an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSecurityIPListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityIPListResponse
        /// </returns>
        public DescribeSecurityIPListResponse DescribeSecurityIPList(DescribeSecurityIPListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityIPListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IP addresses in the whitelists of an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSecurityIPListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityIPListResponse
        /// </returns>
        public async Task<DescribeSecurityIPListResponse> DescribeSecurityIPListAsync(DescribeSecurityIPListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityIPListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开关分时弹性策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnDisableScalingRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnDisableScalingRulesResponse
        /// </returns>
        public EnDisableScalingRulesResponse EnDisableScalingRulesWithOptions(EnDisableScalingRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbInstanceId))
            {
                query["DbInstanceId"] = request.DbInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRulesEnable))
            {
                query["ScalingRulesEnable"] = request.ScalingRulesEnable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnDisableScalingRules",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnDisableScalingRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开关分时弹性策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnDisableScalingRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnDisableScalingRulesResponse
        /// </returns>
        public async Task<EnDisableScalingRulesResponse> EnDisableScalingRulesWithOptionsAsync(EnDisableScalingRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbInstanceId))
            {
                query["DbInstanceId"] = request.DbInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRulesEnable))
            {
                query["ScalingRulesEnable"] = request.ScalingRulesEnable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnDisableScalingRules",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnDisableScalingRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开关分时弹性策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnDisableScalingRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// EnDisableScalingRulesResponse
        /// </returns>
        public EnDisableScalingRulesResponse EnDisableScalingRules(EnDisableScalingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnDisableScalingRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开关分时弹性策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnDisableScalingRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// EnDisableScalingRulesResponse
        /// </returns>
        public async Task<EnDisableScalingRulesResponse> EnDisableScalingRulesAsync(EnDisableScalingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnDisableScalingRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the pricing for creating a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCreateBEClusterInquiryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCreateBEClusterInquiryResponse
        /// </returns>
        public GetCreateBEClusterInquiryResponse GetCreateBEClusterInquiryWithOptions(GetCreateBEClusterInquiryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCreateBEClusterInquiry",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCreateBEClusterInquiryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the pricing for creating a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCreateBEClusterInquiryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCreateBEClusterInquiryResponse
        /// </returns>
        public async Task<GetCreateBEClusterInquiryResponse> GetCreateBEClusterInquiryWithOptionsAsync(GetCreateBEClusterInquiryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCreateBEClusterInquiry",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCreateBEClusterInquiryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the pricing for creating a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCreateBEClusterInquiryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCreateBEClusterInquiryResponse
        /// </returns>
        public GetCreateBEClusterInquiryResponse GetCreateBEClusterInquiry(GetCreateBEClusterInquiryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCreateBEClusterInquiryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the pricing for creating a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCreateBEClusterInquiryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCreateBEClusterInquiryResponse
        /// </returns>
        public async Task<GetCreateBEClusterInquiryResponse> GetCreateBEClusterInquiryAsync(GetCreateBEClusterInquiryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCreateBEClusterInquiryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the pricing for changing the specifications of a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModifyBEClusterInquiryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModifyBEClusterInquiryResponse
        /// </returns>
        public GetModifyBEClusterInquiryResponse GetModifyBEClusterInquiryWithOptions(GetModifyBEClusterInquiryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModifyBEClusterInquiry",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModifyBEClusterInquiryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the pricing for changing the specifications of a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModifyBEClusterInquiryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModifyBEClusterInquiryResponse
        /// </returns>
        public async Task<GetModifyBEClusterInquiryResponse> GetModifyBEClusterInquiryWithOptionsAsync(GetModifyBEClusterInquiryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModifyBEClusterInquiry",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModifyBEClusterInquiryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the pricing for changing the specifications of a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModifyBEClusterInquiryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModifyBEClusterInquiryResponse
        /// </returns>
        public GetModifyBEClusterInquiryResponse GetModifyBEClusterInquiry(GetModifyBEClusterInquiryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetModifyBEClusterInquiryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the pricing for changing the specifications of a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModifyBEClusterInquiryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModifyBEClusterInquiryResponse
        /// </returns>
        public async Task<GetModifyBEClusterInquiryResponse> GetModifyBEClusterInquiryAsync(GetModifyBEClusterInquiryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetModifyBEClusterInquiryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the name of a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBEClusterAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBEClusterAttributeResponse
        /// </returns>
        public ModifyBEClusterAttributeResponse ModifyBEClusterAttributeWithOptions(ModifyBEClusterAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceAttributeType))
            {
                query["InstanceAttributeType"] = request.InstanceAttributeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBEClusterAttribute",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBEClusterAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the name of a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBEClusterAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyBEClusterAttributeResponse
        /// </returns>
        public async Task<ModifyBEClusterAttributeResponse> ModifyBEClusterAttributeWithOptionsAsync(ModifyBEClusterAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceAttributeType))
            {
                query["InstanceAttributeType"] = request.InstanceAttributeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBEClusterAttribute",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBEClusterAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the name of a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBEClusterAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBEClusterAttributeResponse
        /// </returns>
        public ModifyBEClusterAttributeResponse ModifyBEClusterAttribute(ModifyBEClusterAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBEClusterAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the name of a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyBEClusterAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyBEClusterAttributeResponse
        /// </returns>
        public async Task<ModifyBEClusterAttributeResponse> ModifyBEClusterAttributeAsync(ModifyBEClusterAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBEClusterAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集群变配</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDBClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDBClusterResponse
        /// </returns>
        public ModifyDBClusterResponse ModifyDBClusterWithOptions(ModifyDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CacheSize))
            {
                query["CacheSize"] = request.CacheSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterClass))
            {
                query["DBClusterClass"] = request.DBClusterClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "ModifyDBCluster",
                Version = "2023-05-22",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集群变配</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDBClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDBClusterResponse
        /// </returns>
        public async Task<ModifyDBClusterResponse> ModifyDBClusterWithOptionsAsync(ModifyDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CacheSize))
            {
                query["CacheSize"] = request.CacheSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterClass))
            {
                query["DBClusterClass"] = request.DBClusterClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "ModifyDBCluster",
                Version = "2023-05-22",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集群变配</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDBClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDBClusterResponse
        /// </returns>
        public ModifyDBClusterResponse ModifyDBCluster(ModifyDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBClusterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集群变配</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDBClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDBClusterResponse
        /// </returns>
        public async Task<ModifyDBClusterResponse> ModifyDBClusterAsync(ModifyDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBClusterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDBClusterConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDBClusterConfigResponse
        /// </returns>
        public ModifyDBClusterConfigResponse ModifyDBClusterConfigWithOptions(ModifyDBClusterConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKey))
            {
                query["ConfigKey"] = request.ConfigKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchTimeMode))
            {
                query["SwitchTimeMode"] = request.SwitchTimeMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBClusterConfig",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBClusterConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDBClusterConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDBClusterConfigResponse
        /// </returns>
        public async Task<ModifyDBClusterConfigResponse> ModifyDBClusterConfigWithOptionsAsync(ModifyDBClusterConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigKey))
            {
                query["ConfigKey"] = request.ConfigKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchTimeMode))
            {
                query["SwitchTimeMode"] = request.SwitchTimeMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBClusterConfig",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBClusterConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDBClusterConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDBClusterConfigResponse
        /// </returns>
        public ModifyDBClusterConfigResponse ModifyDBClusterConfig(ModifyDBClusterConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBClusterConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDBClusterConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDBClusterConfigResponse
        /// </returns>
        public async Task<ModifyDBClusterConfigResponse> ModifyDBClusterConfigAsync(ModifyDBClusterConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBClusterConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the maintenance window or description of an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDBInstanceAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDBInstanceAttributeResponse
        /// </returns>
        public ModifyDBInstanceAttributeResponse ModifyDBInstanceAttributeWithOptions(ModifyDBInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceAttributeType))
            {
                query["InstanceAttributeType"] = request.InstanceAttributeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceAttribute",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the maintenance window or description of an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDBInstanceAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDBInstanceAttributeResponse
        /// </returns>
        public async Task<ModifyDBInstanceAttributeResponse> ModifyDBInstanceAttributeWithOptionsAsync(ModifyDBInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceAttributeType))
            {
                query["InstanceAttributeType"] = request.InstanceAttributeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDBInstanceAttribute",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDBInstanceAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the maintenance window or description of an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDBInstanceAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDBInstanceAttributeResponse
        /// </returns>
        public ModifyDBInstanceAttributeResponse ModifyDBInstanceAttribute(ModifyDBInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the maintenance window or description of an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyDBInstanceAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDBInstanceAttributeResponse
        /// </returns>
        public async Task<ModifyDBInstanceAttributeResponse> ModifyDBInstanceAttributeAsync(ModifyDBInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改分时弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyElasticRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyElasticRuleResponse
        /// </returns>
        public ModifyElasticRuleResponse ModifyElasticRuleWithOptions(ModifyElasticRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterClass))
            {
                query["ClusterClass"] = request.ClusterClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbInstanceId))
            {
                query["DbInstanceId"] = request.DbInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticRuleStartTime))
            {
                query["ElasticRuleStartTime"] = request.ElasticRuleStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionPeriod))
            {
                query["ExecutionPeriod"] = request.ExecutionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyElasticRule",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyElasticRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改分时弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyElasticRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyElasticRuleResponse
        /// </returns>
        public async Task<ModifyElasticRuleResponse> ModifyElasticRuleWithOptionsAsync(ModifyElasticRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterClass))
            {
                query["ClusterClass"] = request.ClusterClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbInstanceId))
            {
                query["DbInstanceId"] = request.DbInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ElasticRuleStartTime))
            {
                query["ElasticRuleStartTime"] = request.ElasticRuleStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionPeriod))
            {
                query["ExecutionPeriod"] = request.ExecutionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyElasticRule",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyElasticRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改分时弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyElasticRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyElasticRuleResponse
        /// </returns>
        public ModifyElasticRuleResponse ModifyElasticRule(ModifyElasticRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyElasticRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改分时弹性规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyElasticRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyElasticRuleResponse
        /// </returns>
        public async Task<ModifyElasticRuleResponse> ModifyElasticRuleAsync(ModifyElasticRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyElasticRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the IP addresses in a whitelist of an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySecurityIPListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySecurityIPListResponse
        /// </returns>
        public ModifySecurityIPListResponse ModifySecurityIPListWithOptions(ModifySecurityIPListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMode))
            {
                query["ModifyMode"] = request.ModifyMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIPList))
            {
                query["SecurityIPList"] = request.SecurityIPList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySecurityIPList",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySecurityIPListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the IP addresses in a whitelist of an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySecurityIPListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySecurityIPListResponse
        /// </returns>
        public async Task<ModifySecurityIPListResponse> ModifySecurityIPListWithOptionsAsync(ModifySecurityIPListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMode))
            {
                query["ModifyMode"] = request.ModifyMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIPList))
            {
                query["SecurityIPList"] = request.SecurityIPList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySecurityIPList",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySecurityIPListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the IP addresses in a whitelist of an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySecurityIPListRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySecurityIPListResponse
        /// </returns>
        public ModifySecurityIPListResponse ModifySecurityIPList(ModifySecurityIPListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySecurityIPListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the IP addresses in a whitelist of an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySecurityIPListRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySecurityIPListResponse
        /// </returns>
        public async Task<ModifySecurityIPListResponse> ModifySecurityIPListAsync(ModifySecurityIPListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySecurityIPListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases the public endpoint of an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseInstancePublicConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstancePublicConnectionResponse
        /// </returns>
        public ReleaseInstancePublicConnectionResponse ReleaseInstancePublicConnectionWithOptions(ReleaseInstancePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionString))
            {
                query["ConnectionString"] = request.ConnectionString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "ReleaseInstancePublicConnection",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseInstancePublicConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases the public endpoint of an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseInstancePublicConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstancePublicConnectionResponse
        /// </returns>
        public async Task<ReleaseInstancePublicConnectionResponse> ReleaseInstancePublicConnectionWithOptionsAsync(ReleaseInstancePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionString))
            {
                query["ConnectionString"] = request.ConnectionString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "ReleaseInstancePublicConnection",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseInstancePublicConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases the public endpoint of an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseInstancePublicConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstancePublicConnectionResponse
        /// </returns>
        public ReleaseInstancePublicConnectionResponse ReleaseInstancePublicConnection(ReleaseInstancePublicConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseInstancePublicConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases the public endpoint of an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseInstancePublicConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstancePublicConnectionResponse
        /// </returns>
        public async Task<ReleaseInstancePublicConnectionResponse> ReleaseInstancePublicConnectionAsync(ReleaseInstancePublicConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseInstancePublicConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the password of an account for an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetAccountPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetAccountPasswordResponse
        /// </returns>
        public ResetAccountPasswordResponse ResetAccountPasswordWithOptions(ResetAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetAccountPassword",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetAccountPasswordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the password of an account for an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetAccountPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetAccountPasswordResponse
        /// </returns>
        public async Task<ResetAccountPasswordResponse> ResetAccountPasswordWithOptionsAsync(ResetAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetAccountPassword",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetAccountPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the password of an account for an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetAccountPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetAccountPasswordResponse
        /// </returns>
        public ResetAccountPasswordResponse ResetAccountPassword(ResetAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetAccountPasswordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the password of an account for an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetAccountPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetAccountPasswordResponse
        /// </returns>
        public async Task<ResetAccountPasswordResponse> ResetAccountPasswordAsync(ResetAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetAccountPasswordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartDBClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartDBClusterResponse
        /// </returns>
        public RestartDBClusterResponse RestartDBClusterWithOptions(RestartDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                body["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartDBCluster",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartDBClusterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartDBClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartDBClusterResponse
        /// </returns>
        public async Task<RestartDBClusterResponse> RestartDBClusterWithOptionsAsync(RestartDBClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                body["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartDBCluster",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartDBClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartDBClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartDBClusterResponse
        /// </returns>
        public RestartDBClusterResponse RestartDBCluster(RestartDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartDBClusterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts a cluster in an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartDBClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartDBClusterResponse
        /// </returns>
        public async Task<RestartDBClusterResponse> RestartDBClusterAsync(RestartDBClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartDBClusterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停后恢复集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartBEClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartBEClusterResponse
        /// </returns>
        public StartBEClusterResponse StartBEClusterWithOptions(StartBEClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "StartBECluster",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartBEClusterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停后恢复集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartBEClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartBEClusterResponse
        /// </returns>
        public async Task<StartBEClusterResponse> StartBEClusterWithOptionsAsync(StartBEClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "StartBECluster",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartBEClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停后恢复集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartBEClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// StartBEClusterResponse
        /// </returns>
        public StartBEClusterResponse StartBECluster(StartBEClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartBEClusterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停后恢复集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartBEClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// StartBEClusterResponse
        /// </returns>
        public async Task<StartBEClusterResponse> StartBEClusterAsync(StartBEClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartBEClusterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停BE集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopBEClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopBEClusterResponse
        /// </returns>
        public StopBEClusterResponse StopBEClusterWithOptions(StopBEClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "StopBECluster",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopBEClusterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停BE集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopBEClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopBEClusterResponse
        /// </returns>
        public async Task<StopBEClusterResponse> StopBEClusterWithOptionsAsync(StopBEClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceId))
            {
                query["DBInstanceId"] = request.DBInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "StopBECluster",
                Version = "2023-05-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopBEClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停BE集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopBEClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// StopBEClusterResponse
        /// </returns>
        public StopBEClusterResponse StopBECluster(StopBEClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopBEClusterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停BE集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopBEClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// StopBEClusterResponse
        /// </returns>
        public async Task<StopBEClusterResponse> StopBEClusterAsync(StopBEClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopBEClusterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the database engine version of an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeDBInstanceEngineVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeDBInstanceEngineVersionResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchTimeMode))
            {
                query["SwitchTimeMode"] = request.SwitchTimeMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeDBInstanceEngineVersion",
                Version = "2023-05-22",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the database engine version of an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeDBInstanceEngineVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeDBInstanceEngineVersionResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchTimeMode))
            {
                query["SwitchTimeMode"] = request.SwitchTimeMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeDBInstanceEngineVersion",
                Version = "2023-05-22",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the database engine version of an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeDBInstanceEngineVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeDBInstanceEngineVersionResponse
        /// </returns>
        public UpgradeDBInstanceEngineVersionResponse UpgradeDBInstanceEngineVersion(UpgradeDBInstanceEngineVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeDBInstanceEngineVersionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the database engine version of an ApsaraDB for SelectDB instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeDBInstanceEngineVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeDBInstanceEngineVersionResponse
        /// </returns>
        public async Task<UpgradeDBInstanceEngineVersionResponse> UpgradeDBInstanceEngineVersionAsync(UpgradeDBInstanceEngineVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeDBInstanceEngineVersionWithOptionsAsync(request, runtime);
        }

    }
}
