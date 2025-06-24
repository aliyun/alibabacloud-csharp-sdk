// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.DAS20200116.Models;

namespace AlibabaCloud.SDK.DAS20200116
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-shanghai", "das.cn-shanghai.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("das", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Adds a database instance to Database Autonomy Service (DAS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call DAS, you must set the region to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddHDMInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddHDMInstanceResponse
        /// </returns>
        public AddHDMInstanceResponse AddHDMInstanceWithOptions(AddHDMInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlushAccount))
            {
                query["FlushAccount"] = request.FlushAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceAlias))
            {
                query["InstanceAlias"] = request.InstanceAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceArea))
            {
                query["InstanceArea"] = request.InstanceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddHDMInstance",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddHDMInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a database instance to Database Autonomy Service (DAS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call DAS, you must set the region to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddHDMInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddHDMInstanceResponse
        /// </returns>
        public async Task<AddHDMInstanceResponse> AddHDMInstanceWithOptionsAsync(AddHDMInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlushAccount))
            {
                query["FlushAccount"] = request.FlushAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceAlias))
            {
                query["InstanceAlias"] = request.InstanceAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceArea))
            {
                query["InstanceArea"] = request.InstanceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddHDMInstance",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddHDMInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a database instance to Database Autonomy Service (DAS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call DAS, you must set the region to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddHDMInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// AddHDMInstanceResponse
        /// </returns>
        public AddHDMInstanceResponse AddHDMInstance(AddHDMInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddHDMInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a database instance to Database Autonomy Service (DAS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call DAS, you must set the region to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddHDMInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// AddHDMInstanceResponse
        /// </returns>
        public async Task<AddHDMInstanceResponse> AddHDMInstanceAsync(AddHDMInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddHDMInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cache analysis task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>You can call this operation to analyze the data structures of ApsaraDB for Redis and the following self-developed data structures of Tair: TairString, TairHash, TairGIS, TairBloom, TairDoc, TairCpc, and TairZset. Other self-developed Tair data structures are not supported.</description></item>
        /// <item><description>If the specifications of the database instance that you want to analyze are changed, the backup file generated before the specification change cannot be analyzed.</description></item>
        /// <item><description>Tair ESSD/SSD-based instances are not supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCacheAnalysisJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCacheAnalysisJobResponse
        /// </returns>
        public CreateCacheAnalysisJobResponse CreateCacheAnalysisJobWithOptions(CreateCacheAnalysisJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Separators))
            {
                query["Separators"] = request.Separators;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCacheAnalysisJob",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCacheAnalysisJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cache analysis task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>You can call this operation to analyze the data structures of ApsaraDB for Redis and the following self-developed data structures of Tair: TairString, TairHash, TairGIS, TairBloom, TairDoc, TairCpc, and TairZset. Other self-developed Tair data structures are not supported.</description></item>
        /// <item><description>If the specifications of the database instance that you want to analyze are changed, the backup file generated before the specification change cannot be analyzed.</description></item>
        /// <item><description>Tair ESSD/SSD-based instances are not supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCacheAnalysisJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCacheAnalysisJobResponse
        /// </returns>
        public async Task<CreateCacheAnalysisJobResponse> CreateCacheAnalysisJobWithOptionsAsync(CreateCacheAnalysisJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                query["BackupSetId"] = request.BackupSetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Separators))
            {
                query["Separators"] = request.Separators;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCacheAnalysisJob",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCacheAnalysisJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cache analysis task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>You can call this operation to analyze the data structures of ApsaraDB for Redis and the following self-developed data structures of Tair: TairString, TairHash, TairGIS, TairBloom, TairDoc, TairCpc, and TairZset. Other self-developed Tair data structures are not supported.</description></item>
        /// <item><description>If the specifications of the database instance that you want to analyze are changed, the backup file generated before the specification change cannot be analyzed.</description></item>
        /// <item><description>Tair ESSD/SSD-based instances are not supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCacheAnalysisJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCacheAnalysisJobResponse
        /// </returns>
        public CreateCacheAnalysisJobResponse CreateCacheAnalysisJob(CreateCacheAnalysisJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCacheAnalysisJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a cache analysis task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>You can call this operation to analyze the data structures of ApsaraDB for Redis and the following self-developed data structures of Tair: TairString, TairHash, TairGIS, TairBloom, TairDoc, TairCpc, and TairZset. Other self-developed Tair data structures are not supported.</description></item>
        /// <item><description>If the specifications of the database instance that you want to analyze are changed, the backup file generated before the specification change cannot be analyzed.</description></item>
        /// <item><description>Tair ESSD/SSD-based instances are not supported.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCacheAnalysisJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCacheAnalysisJobResponse
        /// </returns>
        public async Task<CreateCacheAnalysisJobResponse> CreateCacheAnalysisJobAsync(CreateCacheAnalysisJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCacheAnalysisJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates stress testing tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>. Before you call this API operation, make sure that your database instances meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The source database instance is an ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition instance, or a PolarDB for MySQL Cluster Edition cluster.</description></item>
        /// <item><description>The destination database instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster.</description></item>
        /// <item><description>The source and destination database instances are connected to DAS. For information about how to connect database instances to DAS, see <a href="https://help.aliyun.com/document_detail/65405.html">Connect an Alibaba Cloud database instance to DAS</a>.</description></item>
        /// <item><description>DAS Enterprise Edition is enabled for the source and destination database instances. For more information, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCloudBenchTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCloudBenchTasksResponse
        /// </returns>
        public CreateCloudBenchTasksResponse CreateCloudBenchTasksWithOptions(CreateCloudBenchTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupTime))
            {
                query["BackupTime"] = request.BackupTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstConnectionString))
            {
                query["DstConnectionString"] = request.DstConnectionString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstInstanceId))
            {
                query["DstInstanceId"] = request.DstInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstPort))
            {
                query["DstPort"] = request.DstPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstSuperAccount))
            {
                query["DstSuperAccount"] = request.DstSuperAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstSuperPassword))
            {
                query["DstSuperPassword"] = request.DstSuperPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstType))
            {
                query["DstType"] = request.DstType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobClass))
            {
                query["DtsJobClass"] = request.DtsJobClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndState))
            {
                query["EndState"] = request.EndState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayVpcId))
            {
                query["GatewayVpcId"] = request.GatewayVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayVpcIp))
            {
                query["GatewayVpcIp"] = request.GatewayVpcIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rate))
            {
                query["Rate"] = request.Rate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestDuration))
            {
                query["RequestDuration"] = request.RequestDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestEndTime))
            {
                query["RequestEndTime"] = request.RequestEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestStartTime))
            {
                query["RequestStartTime"] = request.RequestStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmartPressureTime))
            {
                query["SmartPressureTime"] = request.SmartPressureTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcInstanceId))
            {
                query["SrcInstanceId"] = request.SrcInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcPublicIp))
            {
                query["SrcPublicIp"] = request.SrcPublicIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcSuperAccount))
            {
                query["SrcSuperAccount"] = request.SrcSuperAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcSuperPassword))
            {
                query["SrcSuperPassword"] = request.SrcSuperPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkDir))
            {
                query["WorkDir"] = request.WorkDir;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCloudBenchTasks",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCloudBenchTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates stress testing tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>. Before you call this API operation, make sure that your database instances meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The source database instance is an ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition instance, or a PolarDB for MySQL Cluster Edition cluster.</description></item>
        /// <item><description>The destination database instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster.</description></item>
        /// <item><description>The source and destination database instances are connected to DAS. For information about how to connect database instances to DAS, see <a href="https://help.aliyun.com/document_detail/65405.html">Connect an Alibaba Cloud database instance to DAS</a>.</description></item>
        /// <item><description>DAS Enterprise Edition is enabled for the source and destination database instances. For more information, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCloudBenchTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCloudBenchTasksResponse
        /// </returns>
        public async Task<CreateCloudBenchTasksResponse> CreateCloudBenchTasksWithOptionsAsync(CreateCloudBenchTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupTime))
            {
                query["BackupTime"] = request.BackupTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstConnectionString))
            {
                query["DstConnectionString"] = request.DstConnectionString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstInstanceId))
            {
                query["DstInstanceId"] = request.DstInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstPort))
            {
                query["DstPort"] = request.DstPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstSuperAccount))
            {
                query["DstSuperAccount"] = request.DstSuperAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstSuperPassword))
            {
                query["DstSuperPassword"] = request.DstSuperPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstType))
            {
                query["DstType"] = request.DstType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobClass))
            {
                query["DtsJobClass"] = request.DtsJobClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DtsJobId))
            {
                query["DtsJobId"] = request.DtsJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndState))
            {
                query["EndState"] = request.EndState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayVpcId))
            {
                query["GatewayVpcId"] = request.GatewayVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayVpcIp))
            {
                query["GatewayVpcIp"] = request.GatewayVpcIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rate))
            {
                query["Rate"] = request.Rate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestDuration))
            {
                query["RequestDuration"] = request.RequestDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestEndTime))
            {
                query["RequestEndTime"] = request.RequestEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestStartTime))
            {
                query["RequestStartTime"] = request.RequestStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmartPressureTime))
            {
                query["SmartPressureTime"] = request.SmartPressureTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcInstanceId))
            {
                query["SrcInstanceId"] = request.SrcInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcPublicIp))
            {
                query["SrcPublicIp"] = request.SrcPublicIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcSuperAccount))
            {
                query["SrcSuperAccount"] = request.SrcSuperAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcSuperPassword))
            {
                query["SrcSuperPassword"] = request.SrcSuperPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkDir))
            {
                query["WorkDir"] = request.WorkDir;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCloudBenchTasks",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCloudBenchTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates stress testing tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>. Before you call this API operation, make sure that your database instances meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The source database instance is an ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition instance, or a PolarDB for MySQL Cluster Edition cluster.</description></item>
        /// <item><description>The destination database instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster.</description></item>
        /// <item><description>The source and destination database instances are connected to DAS. For information about how to connect database instances to DAS, see <a href="https://help.aliyun.com/document_detail/65405.html">Connect an Alibaba Cloud database instance to DAS</a>.</description></item>
        /// <item><description>DAS Enterprise Edition is enabled for the source and destination database instances. For more information, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCloudBenchTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCloudBenchTasksResponse
        /// </returns>
        public CreateCloudBenchTasksResponse CreateCloudBenchTasks(CreateCloudBenchTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCloudBenchTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates stress testing tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>. Before you call this API operation, make sure that your database instances meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The source database instance is an ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition instance, or a PolarDB for MySQL Cluster Edition cluster.</description></item>
        /// <item><description>The destination database instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster.</description></item>
        /// <item><description>The source and destination database instances are connected to DAS. For information about how to connect database instances to DAS, see <a href="https://help.aliyun.com/document_detail/65405.html">Connect an Alibaba Cloud database instance to DAS</a>.</description></item>
        /// <item><description>DAS Enterprise Edition is enabled for the source and destination database instances. For more information, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCloudBenchTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCloudBenchTasksResponse
        /// </returns>
        public async Task<CreateCloudBenchTasksResponse> CreateCloudBenchTasksAsync(CreateCloudBenchTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCloudBenchTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a diagnostic report.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of Database Autonomy Service (DAS) SDK must be 1.0.3 or later.</description></item>
        /// <item><description>If you use an SDK to call DAS, you must set the region to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>RDS MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>Redis</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDiagnosticReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDiagnosticReportResponse
        /// </returns>
        public CreateDiagnosticReportResponse CreateDiagnosticReportWithOptions(CreateDiagnosticReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateDiagnosticReport",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDiagnosticReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a diagnostic report.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of Database Autonomy Service (DAS) SDK must be 1.0.3 or later.</description></item>
        /// <item><description>If you use an SDK to call DAS, you must set the region to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>RDS MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>Redis</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDiagnosticReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDiagnosticReportResponse
        /// </returns>
        public async Task<CreateDiagnosticReportResponse> CreateDiagnosticReportWithOptionsAsync(CreateDiagnosticReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateDiagnosticReport",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDiagnosticReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a diagnostic report.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of Database Autonomy Service (DAS) SDK must be 1.0.3 or later.</description></item>
        /// <item><description>If you use an SDK to call DAS, you must set the region to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>RDS MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>Redis</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDiagnosticReportRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDiagnosticReportResponse
        /// </returns>
        public CreateDiagnosticReportResponse CreateDiagnosticReport(CreateDiagnosticReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDiagnosticReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a diagnostic report.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of Database Autonomy Service (DAS) SDK must be 1.0.3 or later.</description></item>
        /// <item><description>If you use an SDK to call DAS, you must set the region to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>RDS MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>Redis</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDiagnosticReportRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDiagnosticReportResponse
        /// </returns>
        public async Task<CreateDiagnosticReportResponse> CreateDiagnosticReportAsync(CreateDiagnosticReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDiagnosticReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a task that terminates sessions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKillInstanceSessionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKillInstanceSessionTaskResponse
        /// </returns>
        public CreateKillInstanceSessionTaskResponse CreateKillInstanceSessionTaskWithOptions(CreateKillInstanceSessionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbUser))
            {
                query["DbUser"] = request.DbUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbUserPassword))
            {
                query["DbUserPassword"] = request.DbUserPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoredUsers))
            {
                query["IgnoredUsers"] = request.IgnoredUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KillAllSessions))
            {
                query["KillAllSessions"] = request.KillAllSessions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionIds))
            {
                query["SessionIds"] = request.SessionIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKillInstanceSessionTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKillInstanceSessionTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a task that terminates sessions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKillInstanceSessionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKillInstanceSessionTaskResponse
        /// </returns>
        public async Task<CreateKillInstanceSessionTaskResponse> CreateKillInstanceSessionTaskWithOptionsAsync(CreateKillInstanceSessionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbUser))
            {
                query["DbUser"] = request.DbUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbUserPassword))
            {
                query["DbUserPassword"] = request.DbUserPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoredUsers))
            {
                query["IgnoredUsers"] = request.IgnoredUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KillAllSessions))
            {
                query["KillAllSessions"] = request.KillAllSessions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionIds))
            {
                query["SessionIds"] = request.SessionIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKillInstanceSessionTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKillInstanceSessionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a task that terminates sessions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKillInstanceSessionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKillInstanceSessionTaskResponse
        /// </returns>
        public CreateKillInstanceSessionTaskResponse CreateKillInstanceSessionTask(CreateKillInstanceSessionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateKillInstanceSessionTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a task that terminates sessions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKillInstanceSessionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKillInstanceSessionTaskResponse
        /// </returns>
        public async Task<CreateKillInstanceSessionTaskResponse> CreateKillInstanceSessionTaskAsync(CreateKillInstanceSessionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateKillInstanceSessionTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建结束会话的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKillInstanceSessionTaskWithMaintainUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKillInstanceSessionTaskWithMaintainUserResponse
        /// </returns>
        public CreateKillInstanceSessionTaskWithMaintainUserResponse CreateKillInstanceSessionTaskWithMaintainUserWithOptions(CreateKillInstanceSessionTaskWithMaintainUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoredUsers))
            {
                query["IgnoredUsers"] = request.IgnoredUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KillAllSessions))
            {
                query["KillAllSessions"] = request.KillAllSessions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionIds))
            {
                query["SessionIds"] = request.SessionIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKillInstanceSessionTaskWithMaintainUser",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKillInstanceSessionTaskWithMaintainUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建结束会话的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKillInstanceSessionTaskWithMaintainUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKillInstanceSessionTaskWithMaintainUserResponse
        /// </returns>
        public async Task<CreateKillInstanceSessionTaskWithMaintainUserResponse> CreateKillInstanceSessionTaskWithMaintainUserWithOptionsAsync(CreateKillInstanceSessionTaskWithMaintainUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoredUsers))
            {
                query["IgnoredUsers"] = request.IgnoredUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KillAllSessions))
            {
                query["KillAllSessions"] = request.KillAllSessions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionIds))
            {
                query["SessionIds"] = request.SessionIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKillInstanceSessionTaskWithMaintainUser",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKillInstanceSessionTaskWithMaintainUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建结束会话的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKillInstanceSessionTaskWithMaintainUserRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKillInstanceSessionTaskWithMaintainUserResponse
        /// </returns>
        public CreateKillInstanceSessionTaskWithMaintainUserResponse CreateKillInstanceSessionTaskWithMaintainUser(CreateKillInstanceSessionTaskWithMaintainUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateKillInstanceSessionTaskWithMaintainUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建结束会话的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateKillInstanceSessionTaskWithMaintainUserRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKillInstanceSessionTaskWithMaintainUserResponse
        /// </returns>
        public async Task<CreateKillInstanceSessionTaskWithMaintainUserResponse> CreateKillInstanceSessionTaskWithMaintainUserAsync(CreateKillInstanceSessionTaskWithMaintainUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateKillInstanceSessionTaskWithMaintainUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建最近死锁分析任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLatestDeadLockAnalysisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLatestDeadLockAnalysisResponse
        /// </returns>
        public CreateLatestDeadLockAnalysisResponse CreateLatestDeadLockAnalysisWithOptions(CreateLatestDeadLockAnalysisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLatestDeadLockAnalysis",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLatestDeadLockAnalysisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建最近死锁分析任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLatestDeadLockAnalysisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLatestDeadLockAnalysisResponse
        /// </returns>
        public async Task<CreateLatestDeadLockAnalysisResponse> CreateLatestDeadLockAnalysisWithOptionsAsync(CreateLatestDeadLockAnalysisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLatestDeadLockAnalysis",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLatestDeadLockAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建最近死锁分析任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLatestDeadLockAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLatestDeadLockAnalysisResponse
        /// </returns>
        public CreateLatestDeadLockAnalysisResponse CreateLatestDeadLockAnalysis(CreateLatestDeadLockAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLatestDeadLockAnalysisWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建最近死锁分析任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLatestDeadLockAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLatestDeadLockAnalysisResponse
        /// </returns>
        public async Task<CreateLatestDeadLockAnalysisResponse> CreateLatestDeadLockAnalysisAsync(CreateLatestDeadLockAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLatestDeadLockAnalysisWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a tag to a SQL template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateQueryOptimizeTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQueryOptimizeTagResponse
        /// </returns>
        public CreateQueryOptimizeTagResponse CreateQueryOptimizeTagWithOptions(CreateQueryOptimizeTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                query["Comments"] = request.Comments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlIds))
            {
                query["SqlIds"] = request.SqlIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQueryOptimizeTag",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQueryOptimizeTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a tag to a SQL template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateQueryOptimizeTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQueryOptimizeTagResponse
        /// </returns>
        public async Task<CreateQueryOptimizeTagResponse> CreateQueryOptimizeTagWithOptionsAsync(CreateQueryOptimizeTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                query["Comments"] = request.Comments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlIds))
            {
                query["SqlIds"] = request.SqlIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQueryOptimizeTag",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQueryOptimizeTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a tag to a SQL template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateQueryOptimizeTagRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQueryOptimizeTagResponse
        /// </returns>
        public CreateQueryOptimizeTagResponse CreateQueryOptimizeTag(CreateQueryOptimizeTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQueryOptimizeTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a tag to a SQL template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateQueryOptimizeTagRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQueryOptimizeTagResponse
        /// </returns>
        public async Task<CreateQueryOptimizeTagResponse> CreateQueryOptimizeTagAsync(CreateQueryOptimizeTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQueryOptimizeTagWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an SQL statement diagnostics request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call Database Autonomy Service (DAS), you must set the region to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// <item><description>ApsaraDB RDS for SQL Server</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>PolarDB for PostgreSQL (compatible with Oracle)</description></item>
        /// <item><description>ApsaraDB for MongoDB<remarks>
        /// <para> The minor engine version of ApsaraDB RDS for PostgreSQL instances must be 20221230 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see <a href="https://help.aliyun.com/document_detail/146895.html">Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRequestDiagnosisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRequestDiagnosisResponse
        /// </returns>
        public CreateRequestDiagnosisResponse CreateRequestDiagnosisWithOptions(CreateRequestDiagnosisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                query["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                query["Sql"] = request.Sql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRequestDiagnosis",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRequestDiagnosisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an SQL statement diagnostics request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call Database Autonomy Service (DAS), you must set the region to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// <item><description>ApsaraDB RDS for SQL Server</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>PolarDB for PostgreSQL (compatible with Oracle)</description></item>
        /// <item><description>ApsaraDB for MongoDB<remarks>
        /// <para> The minor engine version of ApsaraDB RDS for PostgreSQL instances must be 20221230 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see <a href="https://help.aliyun.com/document_detail/146895.html">Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRequestDiagnosisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRequestDiagnosisResponse
        /// </returns>
        public async Task<CreateRequestDiagnosisResponse> CreateRequestDiagnosisWithOptionsAsync(CreateRequestDiagnosisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                query["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                query["Sql"] = request.Sql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRequestDiagnosis",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRequestDiagnosisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an SQL statement diagnostics request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call Database Autonomy Service (DAS), you must set the region to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// <item><description>ApsaraDB RDS for SQL Server</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>PolarDB for PostgreSQL (compatible with Oracle)</description></item>
        /// <item><description>ApsaraDB for MongoDB<remarks>
        /// <para> The minor engine version of ApsaraDB RDS for PostgreSQL instances must be 20221230 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see <a href="https://help.aliyun.com/document_detail/146895.html">Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRequestDiagnosisRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRequestDiagnosisResponse
        /// </returns>
        public CreateRequestDiagnosisResponse CreateRequestDiagnosis(CreateRequestDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRequestDiagnosisWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an SQL statement diagnostics request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call Database Autonomy Service (DAS), you must set the region to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// <item><description>ApsaraDB RDS for SQL Server</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>PolarDB for PostgreSQL (compatible with Oracle)</description></item>
        /// <item><description>ApsaraDB for MongoDB<remarks>
        /// <para> The minor engine version of ApsaraDB RDS for PostgreSQL instances must be 20221230 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see <a href="https://help.aliyun.com/document_detail/146895.html">Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRequestDiagnosisRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRequestDiagnosisResponse
        /// </returns>
        public async Task<CreateRequestDiagnosisResponse> CreateRequestDiagnosisAsync(CreateRequestDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRequestDiagnosisWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an offline task for Database Autonomy Service (DAS) Enterprise Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>You can create an offline task only for database instances for which DAS Enterprise Edition V2 or V3 is enabled. For more information about the databases and regions that are supported by various versions of DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/156204.html">Editions and supported features</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSqlLogTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSqlLogTaskResponse
        /// </returns>
        public CreateSqlLogTaskResponse CreateSqlLogTaskWithOptions(CreateSqlLogTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSqlLogTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSqlLogTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an offline task for Database Autonomy Service (DAS) Enterprise Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>You can create an offline task only for database instances for which DAS Enterprise Edition V2 or V3 is enabled. For more information about the databases and regions that are supported by various versions of DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/156204.html">Editions and supported features</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSqlLogTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSqlLogTaskResponse
        /// </returns>
        public async Task<CreateSqlLogTaskResponse> CreateSqlLogTaskWithOptionsAsync(CreateSqlLogTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSqlLogTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSqlLogTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an offline task for Database Autonomy Service (DAS) Enterprise Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>You can create an offline task only for database instances for which DAS Enterprise Edition V2 or V3 is enabled. For more information about the databases and regions that are supported by various versions of DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/156204.html">Editions and supported features</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSqlLogTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSqlLogTaskResponse
        /// </returns>
        public CreateSqlLogTaskResponse CreateSqlLogTask(CreateSqlLogTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSqlLogTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an offline task for Database Autonomy Service (DAS) Enterprise Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>You can create an offline task only for database instances for which DAS Enterprise Edition V2 or V3 is enabled. For more information about the databases and regions that are supported by various versions of DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/156204.html">Editions and supported features</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSqlLogTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSqlLogTaskResponse
        /// </returns>
        public async Task<CreateSqlLogTaskResponse> CreateSqlLogTaskAsync(CreateSqlLogTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSqlLogTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a storage analysis task to query the usage details of one or more databases and tables.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for MySQL instances, PolarDB for MySQL clusters, and ApsaraDB for MongoDB instances.</para>
        /// <list type="bullet">
        /// <item><description>For ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters, this operation works the same as the storage analysis feature of the previous version. Tasks generated by this operation cannot be viewed on the Storage Analysis page of the new version in the Database Autonomy Service (DAS) console. If you want to view the tasks and results, call the related API operation to obtain data and save data to your computer.</description></item>
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateStorageAnalysisTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateStorageAnalysisTaskResponse
        /// </returns>
        public CreateStorageAnalysisTaskResponse CreateStorageAnalysisTaskWithOptions(CreateStorageAnalysisTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
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
                Action = "CreateStorageAnalysisTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStorageAnalysisTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a storage analysis task to query the usage details of one or more databases and tables.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for MySQL instances, PolarDB for MySQL clusters, and ApsaraDB for MongoDB instances.</para>
        /// <list type="bullet">
        /// <item><description>For ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters, this operation works the same as the storage analysis feature of the previous version. Tasks generated by this operation cannot be viewed on the Storage Analysis page of the new version in the Database Autonomy Service (DAS) console. If you want to view the tasks and results, call the related API operation to obtain data and save data to your computer.</description></item>
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateStorageAnalysisTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateStorageAnalysisTaskResponse
        /// </returns>
        public async Task<CreateStorageAnalysisTaskResponse> CreateStorageAnalysisTaskWithOptionsAsync(CreateStorageAnalysisTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
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
                Action = "CreateStorageAnalysisTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStorageAnalysisTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a storage analysis task to query the usage details of one or more databases and tables.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for MySQL instances, PolarDB for MySQL clusters, and ApsaraDB for MongoDB instances.</para>
        /// <list type="bullet">
        /// <item><description>For ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters, this operation works the same as the storage analysis feature of the previous version. Tasks generated by this operation cannot be viewed on the Storage Analysis page of the new version in the Database Autonomy Service (DAS) console. If you want to view the tasks and results, call the related API operation to obtain data and save data to your computer.</description></item>
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateStorageAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateStorageAnalysisTaskResponse
        /// </returns>
        public CreateStorageAnalysisTaskResponse CreateStorageAnalysisTask(CreateStorageAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStorageAnalysisTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a storage analysis task to query the usage details of one or more databases and tables.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for MySQL instances, PolarDB for MySQL clusters, and ApsaraDB for MongoDB instances.</para>
        /// <list type="bullet">
        /// <item><description>For ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters, this operation works the same as the storage analysis feature of the previous version. Tasks generated by this operation cannot be viewed on the Storage Analysis page of the new version in the Database Autonomy Service (DAS) console. If you want to view the tasks and results, call the related API operation to obtain data and save data to your computer.</description></item>
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateStorageAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateStorageAnalysisTaskResponse
        /// </returns>
        public async Task<CreateStorageAnalysisTaskResponse> CreateStorageAnalysisTaskAsync(CreateStorageAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStorageAnalysisTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a stress testing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to handle traffic spikes in an effective manner. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCloudBenchTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCloudBenchTaskResponse
        /// </returns>
        public DeleteCloudBenchTaskResponse DeleteCloudBenchTaskWithOptions(DeleteCloudBenchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DeleteCloudBenchTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCloudBenchTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a stress testing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to handle traffic spikes in an effective manner. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCloudBenchTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCloudBenchTaskResponse
        /// </returns>
        public async Task<DeleteCloudBenchTaskResponse> DeleteCloudBenchTaskWithOptionsAsync(DeleteCloudBenchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DeleteCloudBenchTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCloudBenchTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a stress testing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to handle traffic spikes in an effective manner. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCloudBenchTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCloudBenchTaskResponse
        /// </returns>
        public DeleteCloudBenchTaskResponse DeleteCloudBenchTask(DeleteCloudBenchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCloudBenchTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a stress testing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to handle traffic spikes in an effective manner. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCloudBenchTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCloudBenchTaskResponse
        /// </returns>
        public async Task<DeleteCloudBenchTaskResponse> DeleteCloudBenchTaskAsync(DeleteCloudBenchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCloudBenchTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the metadata of a stopped DBGateway.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is used to delete the metadata of a DBGateway that is released in a stress testing task created by calling the <a href="https://help.aliyun.com/document_detail/230665.html">CreateCloudBenchTasks</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.<remarks>
        /// <para> If the heartbeat is lost between a DBGateway and the access point for more than 20 seconds, the DBGateway is considered stopped.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteStopGatewayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteStopGatewayResponse
        /// </returns>
        public DeleteStopGatewayResponse DeleteStopGatewayWithOptions(DeleteStopGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["GatewayId"] = request.GatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStopGateway",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStopGatewayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the metadata of a stopped DBGateway.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is used to delete the metadata of a DBGateway that is released in a stress testing task created by calling the <a href="https://help.aliyun.com/document_detail/230665.html">CreateCloudBenchTasks</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.<remarks>
        /// <para> If the heartbeat is lost between a DBGateway and the access point for more than 20 seconds, the DBGateway is considered stopped.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteStopGatewayRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteStopGatewayResponse
        /// </returns>
        public async Task<DeleteStopGatewayResponse> DeleteStopGatewayWithOptionsAsync(DeleteStopGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["GatewayId"] = request.GatewayId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStopGateway",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStopGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the metadata of a stopped DBGateway.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is used to delete the metadata of a DBGateway that is released in a stress testing task created by calling the <a href="https://help.aliyun.com/document_detail/230665.html">CreateCloudBenchTasks</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.<remarks>
        /// <para> If the heartbeat is lost between a DBGateway and the access point for more than 20 seconds, the DBGateway is considered stopped.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteStopGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteStopGatewayResponse
        /// </returns>
        public DeleteStopGatewayResponse DeleteStopGateway(DeleteStopGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteStopGatewayWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the metadata of a stopped DBGateway.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is used to delete the metadata of a DBGateway that is released in a stress testing task created by calling the <a href="https://help.aliyun.com/document_detail/230665.html">CreateCloudBenchTasks</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.<remarks>
        /// <para> If the heartbeat is lost between a DBGateway and the access point for more than 20 seconds, the DBGateway is considered stopped.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteStopGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteStopGatewayResponse
        /// </returns>
        public async Task<DeleteStopGatewayResponse> DeleteStopGatewayAsync(DeleteStopGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteStopGatewayWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of the auto scaling feature for an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAutoScalingConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutoScalingConfigResponse
        /// </returns>
        public DescribeAutoScalingConfigResponse DescribeAutoScalingConfigWithOptions(DescribeAutoScalingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutoScalingConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutoScalingConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of the auto scaling feature for an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAutoScalingConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutoScalingConfigResponse
        /// </returns>
        public async Task<DescribeAutoScalingConfigResponse> DescribeAutoScalingConfigWithOptionsAsync(DescribeAutoScalingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutoScalingConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutoScalingConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of the auto scaling feature for an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAutoScalingConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutoScalingConfigResponse
        /// </returns>
        public DescribeAutoScalingConfigResponse DescribeAutoScalingConfig(DescribeAutoScalingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutoScalingConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of the auto scaling feature for an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAutoScalingConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutoScalingConfigResponse
        /// </returns>
        public async Task<DescribeAutoScalingConfigResponse> DescribeAutoScalingConfigAsync(DescribeAutoScalingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutoScalingConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the auto scaling history of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation to query the history information about the automatic performance scaling only of ApsaraDB RDS for MySQL High-availability Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAutoScalingHistoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutoScalingHistoryResponse
        /// </returns>
        public DescribeAutoScalingHistoryResponse DescribeAutoScalingHistoryWithOptions(DescribeAutoScalingHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutoScalingHistory",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutoScalingHistoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the auto scaling history of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation to query the history information about the automatic performance scaling only of ApsaraDB RDS for MySQL High-availability Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAutoScalingHistoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutoScalingHistoryResponse
        /// </returns>
        public async Task<DescribeAutoScalingHistoryResponse> DescribeAutoScalingHistoryWithOptionsAsync(DescribeAutoScalingHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutoScalingHistory",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutoScalingHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the auto scaling history of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation to query the history information about the automatic performance scaling only of ApsaraDB RDS for MySQL High-availability Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAutoScalingHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutoScalingHistoryResponse
        /// </returns>
        public DescribeAutoScalingHistoryResponse DescribeAutoScalingHistory(DescribeAutoScalingHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutoScalingHistoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the auto scaling history of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation to query the history information about the automatic performance scaling only of ApsaraDB RDS for MySQL High-availability Edition instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAutoScalingHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAutoScalingHistoryResponse
        /// </returns>
        public async Task<DescribeAutoScalingHistoryResponse> DescribeAutoScalingHistoryAsync(DescribeAutoScalingHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutoScalingHistoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a cache analysis task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to ApsaraDB for Redis.<remarks>
        /// <para> You can call this operation to query the top 500 keys in a cache analysis task.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCacheAnalysisJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCacheAnalysisJobResponse
        /// </returns>
        public DescribeCacheAnalysisJobResponse DescribeCacheAnalysisJobWithOptions(DescribeCacheAnalysisJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCacheAnalysisJob",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCacheAnalysisJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a cache analysis task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to ApsaraDB for Redis.<remarks>
        /// <para> You can call this operation to query the top 500 keys in a cache analysis task.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCacheAnalysisJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCacheAnalysisJobResponse
        /// </returns>
        public async Task<DescribeCacheAnalysisJobResponse> DescribeCacheAnalysisJobWithOptionsAsync(DescribeCacheAnalysisJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCacheAnalysisJob",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCacheAnalysisJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a cache analysis task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to ApsaraDB for Redis.<remarks>
        /// <para> You can call this operation to query the top 500 keys in a cache analysis task.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCacheAnalysisJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCacheAnalysisJobResponse
        /// </returns>
        public DescribeCacheAnalysisJobResponse DescribeCacheAnalysisJob(DescribeCacheAnalysisJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCacheAnalysisJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a cache analysis task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to ApsaraDB for Redis.<remarks>
        /// <para> You can call this operation to query the top 500 keys in a cache analysis task.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCacheAnalysisJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCacheAnalysisJobResponse
        /// </returns>
        public async Task<DescribeCacheAnalysisJobResponse> DescribeCacheAnalysisJobAsync(DescribeCacheAnalysisJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCacheAnalysisJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of cache analysis tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to ApsaraDB for Redis.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCacheAnalysisJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCacheAnalysisJobsResponse
        /// </returns>
        public DescribeCacheAnalysisJobsResponse DescribeCacheAnalysisJobsWithOptions(DescribeCacheAnalysisJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "DescribeCacheAnalysisJobs",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCacheAnalysisJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of cache analysis tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to ApsaraDB for Redis.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCacheAnalysisJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCacheAnalysisJobsResponse
        /// </returns>
        public async Task<DescribeCacheAnalysisJobsResponse> DescribeCacheAnalysisJobsWithOptionsAsync(DescribeCacheAnalysisJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "DescribeCacheAnalysisJobs",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCacheAnalysisJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of cache analysis tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to ApsaraDB for Redis.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCacheAnalysisJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCacheAnalysisJobsResponse
        /// </returns>
        public DescribeCacheAnalysisJobsResponse DescribeCacheAnalysisJobs(DescribeCacheAnalysisJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCacheAnalysisJobsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of cache analysis tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to ApsaraDB for Redis.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCacheAnalysisJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCacheAnalysisJobsResponse
        /// </returns>
        public async Task<DescribeCacheAnalysisJobsResponse> DescribeCacheAnalysisJobsAsync(DescribeCacheAnalysisJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCacheAnalysisJobsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries stress testing tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCloudBenchTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudBenchTasksResponse
        /// </returns>
        public DescribeCloudBenchTasksResponse DescribeCloudBenchTasksWithOptions(DescribeCloudBenchTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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
                Action = "DescribeCloudBenchTasks",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudBenchTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries stress testing tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCloudBenchTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudBenchTasksResponse
        /// </returns>
        public async Task<DescribeCloudBenchTasksResponse> DescribeCloudBenchTasksWithOptionsAsync(DescribeCloudBenchTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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
                Action = "DescribeCloudBenchTasks",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudBenchTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries stress testing tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCloudBenchTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudBenchTasksResponse
        /// </returns>
        public DescribeCloudBenchTasksResponse DescribeCloudBenchTasks(DescribeCloudBenchTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudBenchTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries stress testing tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCloudBenchTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudBenchTasksResponse
        /// </returns>
        public async Task<DescribeCloudBenchTasksResponse> DescribeCloudBenchTasksAsync(DescribeCloudBenchTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudBenchTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a stress testing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether you need to scale up your database instance to handle workloads during peak hours. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCloudbenchTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudbenchTaskResponse
        /// </returns>
        public DescribeCloudbenchTaskResponse DescribeCloudbenchTaskWithOptions(DescribeCloudbenchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeCloudbenchTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudbenchTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a stress testing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether you need to scale up your database instance to handle workloads during peak hours. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCloudbenchTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudbenchTaskResponse
        /// </returns>
        public async Task<DescribeCloudbenchTaskResponse> DescribeCloudbenchTaskWithOptionsAsync(DescribeCloudbenchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeCloudbenchTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudbenchTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a stress testing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether you need to scale up your database instance to handle workloads during peak hours. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCloudbenchTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudbenchTaskResponse
        /// </returns>
        public DescribeCloudbenchTaskResponse DescribeCloudbenchTask(DescribeCloudbenchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudbenchTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a stress testing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether you need to scale up your database instance to handle workloads during peak hours. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCloudbenchTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudbenchTaskResponse
        /// </returns>
        public async Task<DescribeCloudbenchTaskResponse> DescribeCloudbenchTaskAsync(DescribeCloudbenchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudbenchTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a stress testing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCloudbenchTaskConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudbenchTaskConfigResponse
        /// </returns>
        public DescribeCloudbenchTaskConfigResponse DescribeCloudbenchTaskConfigWithOptions(DescribeCloudbenchTaskConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeCloudbenchTaskConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudbenchTaskConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a stress testing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCloudbenchTaskConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudbenchTaskConfigResponse
        /// </returns>
        public async Task<DescribeCloudbenchTaskConfigResponse> DescribeCloudbenchTaskConfigWithOptionsAsync(DescribeCloudbenchTaskConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeCloudbenchTaskConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudbenchTaskConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a stress testing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCloudbenchTaskConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudbenchTaskConfigResponse
        /// </returns>
        public DescribeCloudbenchTaskConfigResponse DescribeCloudbenchTaskConfig(DescribeCloudbenchTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudbenchTaskConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a stress testing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCloudbenchTaskConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudbenchTaskConfigResponse
        /// </returns>
        public async Task<DescribeCloudbenchTaskConfigResponse> DescribeCloudbenchTaskConfigAsync(DescribeCloudbenchTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudbenchTaskConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries diagnostics reports.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable to the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB for Redis</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiagnosticReportListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiagnosticReportListResponse
        /// </returns>
        public DescribeDiagnosticReportListResponse DescribeDiagnosticReportListWithOptions(DescribeDiagnosticReportListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "DescribeDiagnosticReportList",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiagnosticReportListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries diagnostics reports.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable to the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB for Redis</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiagnosticReportListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiagnosticReportListResponse
        /// </returns>
        public async Task<DescribeDiagnosticReportListResponse> DescribeDiagnosticReportListWithOptionsAsync(DescribeDiagnosticReportListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "DescribeDiagnosticReportList",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDiagnosticReportListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries diagnostics reports.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable to the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB for Redis</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiagnosticReportListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiagnosticReportListResponse
        /// </returns>
        public DescribeDiagnosticReportListResponse DescribeDiagnosticReportList(DescribeDiagnosticReportListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDiagnosticReportListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries diagnostics reports.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable to the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB for Redis</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDiagnosticReportListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDiagnosticReportListResponse
        /// </returns>
        public async Task<DescribeDiagnosticReportListResponse> DescribeDiagnosticReportListAsync(DescribeDiagnosticReportListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDiagnosticReportListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the hot keys and the large keys in the memory in real time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation sorts list, hash, set, and zset keys based on the number of elements contained in these keys. The top three keys that contain the most elements are considered large keys. If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is available only for ApsaraDB for Redis instances that meet the following requirements:<list type="bullet">
        /// <item><description>The instance is a Community Edition instance that uses a major version of 5.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).</description></item>
        /// <item><description>The ApsaraDB for Redis instance is updated to the latest minor version.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHotBigKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHotBigKeysResponse
        /// </returns>
        public DescribeHotBigKeysResponse DescribeHotBigKeysWithOptions(DescribeHotBigKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHotBigKeys",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHotBigKeysResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the hot keys and the large keys in the memory in real time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation sorts list, hash, set, and zset keys based on the number of elements contained in these keys. The top three keys that contain the most elements are considered large keys. If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is available only for ApsaraDB for Redis instances that meet the following requirements:<list type="bullet">
        /// <item><description>The instance is a Community Edition instance that uses a major version of 5.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).</description></item>
        /// <item><description>The ApsaraDB for Redis instance is updated to the latest minor version.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHotBigKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHotBigKeysResponse
        /// </returns>
        public async Task<DescribeHotBigKeysResponse> DescribeHotBigKeysWithOptionsAsync(DescribeHotBigKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHotBigKeys",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHotBigKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the hot keys and the large keys in the memory in real time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation sorts list, hash, set, and zset keys based on the number of elements contained in these keys. The top three keys that contain the most elements are considered large keys. If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is available only for ApsaraDB for Redis instances that meet the following requirements:<list type="bullet">
        /// <item><description>The instance is a Community Edition instance that uses a major version of 5.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).</description></item>
        /// <item><description>The ApsaraDB for Redis instance is updated to the latest minor version.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHotBigKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHotBigKeysResponse
        /// </returns>
        public DescribeHotBigKeysResponse DescribeHotBigKeys(DescribeHotBigKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHotBigKeysWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the hot keys and the large keys in the memory in real time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation sorts list, hash, set, and zset keys based on the number of elements contained in these keys. The top three keys that contain the most elements are considered large keys. If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is available only for ApsaraDB for Redis instances that meet the following requirements:<list type="bullet">
        /// <item><description>The instance is a Community Edition instance that uses a major version of 5.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).</description></item>
        /// <item><description>The ApsaraDB for Redis instance is updated to the latest minor version.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHotBigKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHotBigKeysResponse
        /// </returns>
        public async Task<DescribeHotBigKeysResponse> DescribeHotBigKeysAsync(DescribeHotBigKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHotBigKeysWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the hot keys of an ApsaraDB for Redis instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V1.0.2 or later.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to ApsaraDB for Redis instances that meet the following requirements:<list type="bullet">
        /// <item><description>The ApsaraDB for Redis instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).</description></item>
        /// <item><description>The ApsaraDB for Redis instance is updated to the latest minor version.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHotKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHotKeysResponse
        /// </returns>
        public DescribeHotKeysResponse DescribeHotKeysWithOptions(DescribeHotKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHotKeys",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHotKeysResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the hot keys of an ApsaraDB for Redis instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V1.0.2 or later.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to ApsaraDB for Redis instances that meet the following requirements:<list type="bullet">
        /// <item><description>The ApsaraDB for Redis instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).</description></item>
        /// <item><description>The ApsaraDB for Redis instance is updated to the latest minor version.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHotKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHotKeysResponse
        /// </returns>
        public async Task<DescribeHotKeysResponse> DescribeHotKeysWithOptionsAsync(DescribeHotKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHotKeys",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHotKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the hot keys of an ApsaraDB for Redis instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V1.0.2 or later.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to ApsaraDB for Redis instances that meet the following requirements:<list type="bullet">
        /// <item><description>The ApsaraDB for Redis instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).</description></item>
        /// <item><description>The ApsaraDB for Redis instance is updated to the latest minor version.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHotKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHotKeysResponse
        /// </returns>
        public DescribeHotKeysResponse DescribeHotKeys(DescribeHotKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHotKeysWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the hot keys of an ApsaraDB for Redis instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V1.0.2 or later.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to ApsaraDB for Redis instances that meet the following requirements:<list type="bullet">
        /// <item><description>The ApsaraDB for Redis instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).</description></item>
        /// <item><description>The ApsaraDB for Redis instance is updated to the latest minor version.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHotKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHotKeysResponse
        /// </returns>
        public async Task<DescribeHotKeysResponse> DescribeHotKeysAsync(DescribeHotKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHotKeysWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether Database Autonomy Service (DAS) Enterprise Edition V1 or V2 is enabled for a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  For more information about the database instances that support DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview of DAS Enterprise Edition</a>.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to DAS Enterprise Edition V1 and V2.<remarks>
        /// <para> We recommend that you call the <a href="https://help.aliyun.com/document_detail/2778837.html">DescribeSqlLogConfig</a> operation to query the DAS Enterprise Edition configurations of a database instance.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceDasProRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceDasProResponse
        /// </returns>
        public DescribeInstanceDasProResponse DescribeInstanceDasProWithOptions(DescribeInstanceDasProRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceDasPro",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceDasProResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether Database Autonomy Service (DAS) Enterprise Edition V1 or V2 is enabled for a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  For more information about the database instances that support DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview of DAS Enterprise Edition</a>.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to DAS Enterprise Edition V1 and V2.<remarks>
        /// <para> We recommend that you call the <a href="https://help.aliyun.com/document_detail/2778837.html">DescribeSqlLogConfig</a> operation to query the DAS Enterprise Edition configurations of a database instance.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceDasProRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceDasProResponse
        /// </returns>
        public async Task<DescribeInstanceDasProResponse> DescribeInstanceDasProWithOptionsAsync(DescribeInstanceDasProRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceDasPro",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceDasProResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether Database Autonomy Service (DAS) Enterprise Edition V1 or V2 is enabled for a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  For more information about the database instances that support DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview of DAS Enterprise Edition</a>.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to DAS Enterprise Edition V1 and V2.<remarks>
        /// <para> We recommend that you call the <a href="https://help.aliyun.com/document_detail/2778837.html">DescribeSqlLogConfig</a> operation to query the DAS Enterprise Edition configurations of a database instance.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceDasProRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceDasProResponse
        /// </returns>
        public DescribeInstanceDasProResponse DescribeInstanceDasPro(DescribeInstanceDasProRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceDasProWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether Database Autonomy Service (DAS) Enterprise Edition V1 or V2 is enabled for a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  For more information about the database instances that support DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview of DAS Enterprise Edition</a>.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to DAS Enterprise Edition V1 and V2.<remarks>
        /// <para> We recommend that you call the <a href="https://help.aliyun.com/document_detail/2778837.html">DescribeSqlLogConfig</a> operation to query the DAS Enterprise Edition configurations of a database instance.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceDasProRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceDasProResponse
        /// </returns>
        public async Task<DescribeInstanceDasProResponse> DescribeInstanceDasProAsync(DescribeInstanceDasProRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceDasProWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取执行计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQueryExplainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeQueryExplainResponse
        /// </returns>
        public DescribeQueryExplainResponse DescribeQueryExplainWithOptions(DescribeQueryExplainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schema))
            {
                body["Schema"] = request.Schema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                body["Sql"] = request.Sql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQueryExplain",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQueryExplainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取执行计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQueryExplainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeQueryExplainResponse
        /// </returns>
        public async Task<DescribeQueryExplainResponse> DescribeQueryExplainWithOptionsAsync(DescribeQueryExplainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schema))
            {
                body["Schema"] = request.Schema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                body["Sql"] = request.Sql;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQueryExplain",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQueryExplainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取执行计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQueryExplainRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeQueryExplainResponse
        /// </returns>
        public DescribeQueryExplainResponse DescribeQueryExplain(DescribeQueryExplainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeQueryExplainWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取执行计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeQueryExplainRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeQueryExplainResponse
        /// </returns>
        public async Task<DescribeQueryExplainResponse> DescribeQueryExplainAsync(DescribeQueryExplainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeQueryExplainWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeSlowLogHistogramAsync</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSlowLogHistogramAsyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlowLogHistogramAsyncResponse
        /// </returns>
        public DescribeSlowLogHistogramAsyncResponse DescribeSlowLogHistogramAsyncWithOptions(DescribeSlowLogHistogramAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlowLogHistogramAsync",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlowLogHistogramAsyncResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeSlowLogHistogramAsync</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSlowLogHistogramAsyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlowLogHistogramAsyncResponse
        /// </returns>
        public async Task<DescribeSlowLogHistogramAsyncResponse> DescribeSlowLogHistogramAsyncWithOptionsAsync(DescribeSlowLogHistogramAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlowLogHistogramAsync",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlowLogHistogramAsyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeSlowLogHistogramAsync</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSlowLogHistogramAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlowLogHistogramAsyncResponse
        /// </returns>
        public DescribeSlowLogHistogramAsyncResponse DescribeSlowLogHistogramAsync(DescribeSlowLogHistogramAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSlowLogHistogramAsyncWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeSlowLogHistogramAsync</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSlowLogHistogramAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlowLogHistogramAsyncResponse
        /// </returns>
        public async Task<DescribeSlowLogHistogramAsyncResponse> DescribeSlowLogHistogramAsyncAsync(DescribeSlowLogHistogramAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSlowLogHistogramAsyncWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看慢日志明细接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSlowLogRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlowLogRecordsResponse
        /// </returns>
        public DescribeSlowLogRecordsResponse DescribeSlowLogRecordsWithOptions(DescribeSlowLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Asc))
            {
                query["Asc"] = request.Asc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlowLogRecords",
                Version = "2020-01-16",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看慢日志明细接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSlowLogRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlowLogRecordsResponse
        /// </returns>
        public async Task<DescribeSlowLogRecordsResponse> DescribeSlowLogRecordsWithOptionsAsync(DescribeSlowLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Asc))
            {
                query["Asc"] = request.Asc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlowLogRecords",
                Version = "2020-01-16",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看慢日志明细接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSlowLogRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlowLogRecordsResponse
        /// </returns>
        public DescribeSlowLogRecordsResponse DescribeSlowLogRecords(DescribeSlowLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSlowLogRecordsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看慢日志明细接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSlowLogRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlowLogRecordsResponse
        /// </returns>
        public async Task<DescribeSlowLogRecordsResponse> DescribeSlowLogRecordsAsync(DescribeSlowLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSlowLogRecordsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>慢日志统计信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSlowLogStatisticRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlowLogStatisticResponse
        /// </returns>
        public DescribeSlowLogStatisticResponse DescribeSlowLogStatisticWithOptions(DescribeSlowLogStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Asc))
            {
                body["Asc"] = request.Asc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
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
                Action = "DescribeSlowLogStatistic",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlowLogStatisticResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>慢日志统计信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSlowLogStatisticRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlowLogStatisticResponse
        /// </returns>
        public async Task<DescribeSlowLogStatisticResponse> DescribeSlowLogStatisticWithOptionsAsync(DescribeSlowLogStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Asc))
            {
                body["Asc"] = request.Asc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
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
                Action = "DescribeSlowLogStatistic",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlowLogStatisticResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>慢日志统计信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSlowLogStatisticRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlowLogStatisticResponse
        /// </returns>
        public DescribeSlowLogStatisticResponse DescribeSlowLogStatistic(DescribeSlowLogStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSlowLogStatisticWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>慢日志统计信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSlowLogStatisticRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSlowLogStatisticResponse
        /// </returns>
        public async Task<DescribeSlowLogStatisticResponse> DescribeSlowLogStatisticAsync(DescribeSlowLogStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSlowLogStatisticWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of Database Autonomy Service (DAS) Enterprise Edition that is enabled for a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSqlLogConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSqlLogConfigResponse
        /// </returns>
        public DescribeSqlLogConfigResponse DescribeSqlLogConfigWithOptions(DescribeSqlLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DescribeSqlLogConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlLogConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of Database Autonomy Service (DAS) Enterprise Edition that is enabled for a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSqlLogConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSqlLogConfigResponse
        /// </returns>
        public async Task<DescribeSqlLogConfigResponse> DescribeSqlLogConfigWithOptionsAsync(DescribeSqlLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DescribeSqlLogConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlLogConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of Database Autonomy Service (DAS) Enterprise Edition that is enabled for a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSqlLogConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSqlLogConfigResponse
        /// </returns>
        public DescribeSqlLogConfigResponse DescribeSqlLogConfig(DescribeSqlLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSqlLogConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of Database Autonomy Service (DAS) Enterprise Edition that is enabled for a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSqlLogConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSqlLogConfigResponse
        /// </returns>
        public async Task<DescribeSqlLogConfigResponse> DescribeSqlLogConfigAsync(DescribeSqlLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSqlLogConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log details of a database instance for which Database Autonomy Service (DAS) Enterprise Edition is enabled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSqlLogRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSqlLogRecordsResponse
        /// </returns>
        public DescribeSqlLogRecordsResponse DescribeSqlLogRecordsWithOptions(DescribeSqlLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSqlLogRecords",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlLogRecordsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log details of a database instance for which Database Autonomy Service (DAS) Enterprise Edition is enabled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSqlLogRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSqlLogRecordsResponse
        /// </returns>
        public async Task<DescribeSqlLogRecordsResponse> DescribeSqlLogRecordsWithOptionsAsync(DescribeSqlLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSqlLogRecords",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlLogRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log details of a database instance for which Database Autonomy Service (DAS) Enterprise Edition is enabled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSqlLogRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSqlLogRecordsResponse
        /// </returns>
        public DescribeSqlLogRecordsResponse DescribeSqlLogRecords(DescribeSqlLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSqlLogRecordsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log details of a database instance for which Database Autonomy Service (DAS) Enterprise Edition is enabled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSqlLogRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSqlLogRecordsResponse
        /// </returns>
        public async Task<DescribeSqlLogRecordsResponse> DescribeSqlLogRecordsAsync(DescribeSqlLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSqlLogRecordsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics of Database Autonomy Service (DAS) Enterprise Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSqlLogStatisticRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSqlLogStatisticResponse
        /// </returns>
        public DescribeSqlLogStatisticResponse DescribeSqlLogStatisticWithOptions(DescribeSqlLogStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DescribeSqlLogStatistic",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlLogStatisticResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics of Database Autonomy Service (DAS) Enterprise Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSqlLogStatisticRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSqlLogStatisticResponse
        /// </returns>
        public async Task<DescribeSqlLogStatisticResponse> DescribeSqlLogStatisticWithOptionsAsync(DescribeSqlLogStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DescribeSqlLogStatistic",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlLogStatisticResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics of Database Autonomy Service (DAS) Enterprise Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSqlLogStatisticRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSqlLogStatisticResponse
        /// </returns>
        public DescribeSqlLogStatisticResponse DescribeSqlLogStatistic(DescribeSqlLogStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSqlLogStatisticWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics of Database Autonomy Service (DAS) Enterprise Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSqlLogStatisticRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSqlLogStatisticResponse
        /// </returns>
        public async Task<DescribeSqlLogStatisticResponse> DescribeSqlLogStatisticAsync(DescribeSqlLogStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSqlLogStatisticWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an offline task in Database Autonomy Service (DAS) Enterprise Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSqlLogTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSqlLogTaskResponse
        /// </returns>
        public DescribeSqlLogTaskResponse DescribeSqlLogTaskWithOptions(DescribeSqlLogTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
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
                Action = "DescribeSqlLogTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlLogTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an offline task in Database Autonomy Service (DAS) Enterprise Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSqlLogTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSqlLogTaskResponse
        /// </returns>
        public async Task<DescribeSqlLogTaskResponse> DescribeSqlLogTaskWithOptionsAsync(DescribeSqlLogTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
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
                Action = "DescribeSqlLogTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlLogTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an offline task in Database Autonomy Service (DAS) Enterprise Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSqlLogTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSqlLogTaskResponse
        /// </returns>
        public DescribeSqlLogTaskResponse DescribeSqlLogTask(DescribeSqlLogTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSqlLogTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an offline task in Database Autonomy Service (DAS) Enterprise Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSqlLogTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSqlLogTaskResponse
        /// </returns>
        public async Task<DescribeSqlLogTaskResponse> DescribeSqlLogTaskAsync(DescribeSqlLogTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSqlLogTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the audit log tasks of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSqlLogTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSqlLogTasksResponse
        /// </returns>
        public DescribeSqlLogTasksResponse DescribeSqlLogTasksWithOptions(DescribeSqlLogTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSqlLogTasks",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlLogTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the audit log tasks of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSqlLogTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSqlLogTasksResponse
        /// </returns>
        public async Task<DescribeSqlLogTasksResponse> DescribeSqlLogTasksWithOptionsAsync(DescribeSqlLogTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSqlLogTasks",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSqlLogTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the audit log tasks of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSqlLogTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSqlLogTasksResponse
        /// </returns>
        public DescribeSqlLogTasksResponse DescribeSqlLogTasks(DescribeSqlLogTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSqlLogTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the audit log tasks of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSqlLogTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSqlLogTasksResponse
        /// </returns>
        public async Task<DescribeSqlLogTasksResponse> DescribeSqlLogTasksAsync(DescribeSqlLogTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSqlLogTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the top 100 large keys over a period of time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The list, hash, set, and zset keys are sorted based on the number of elements in these keys. The top three keys that have the most elements are considered large keys.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is available only for an ApsaraDB for Redis instance of one of the following versions:<list type="bullet">
        /// <item><description>The instance is ApsaraDB for Redis Community Edition instances that use a major version of 5.0 or later or a performance-enhanced instance of the ApsaraDB for Redis Enhanced Edition (Tair).</description></item>
        /// <item><description>The ApsaraDB for Redis instance is updated to the latest minor version.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeTopBigKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTopBigKeysResponse
        /// </returns>
        public DescribeTopBigKeysResponse DescribeTopBigKeysWithOptions(DescribeTopBigKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
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
                Action = "DescribeTopBigKeys",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTopBigKeysResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the top 100 large keys over a period of time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The list, hash, set, and zset keys are sorted based on the number of elements in these keys. The top three keys that have the most elements are considered large keys.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is available only for an ApsaraDB for Redis instance of one of the following versions:<list type="bullet">
        /// <item><description>The instance is ApsaraDB for Redis Community Edition instances that use a major version of 5.0 or later or a performance-enhanced instance of the ApsaraDB for Redis Enhanced Edition (Tair).</description></item>
        /// <item><description>The ApsaraDB for Redis instance is updated to the latest minor version.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeTopBigKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTopBigKeysResponse
        /// </returns>
        public async Task<DescribeTopBigKeysResponse> DescribeTopBigKeysWithOptionsAsync(DescribeTopBigKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
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
                Action = "DescribeTopBigKeys",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTopBigKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the top 100 large keys over a period of time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The list, hash, set, and zset keys are sorted based on the number of elements in these keys. The top three keys that have the most elements are considered large keys.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is available only for an ApsaraDB for Redis instance of one of the following versions:<list type="bullet">
        /// <item><description>The instance is ApsaraDB for Redis Community Edition instances that use a major version of 5.0 or later or a performance-enhanced instance of the ApsaraDB for Redis Enhanced Edition (Tair).</description></item>
        /// <item><description>The ApsaraDB for Redis instance is updated to the latest minor version.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeTopBigKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTopBigKeysResponse
        /// </returns>
        public DescribeTopBigKeysResponse DescribeTopBigKeys(DescribeTopBigKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTopBigKeysWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the top 100 large keys over a period of time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The list, hash, set, and zset keys are sorted based on the number of elements in these keys. The top three keys that have the most elements are considered large keys.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is available only for an ApsaraDB for Redis instance of one of the following versions:<list type="bullet">
        /// <item><description>The instance is ApsaraDB for Redis Community Edition instances that use a major version of 5.0 or later or a performance-enhanced instance of the ApsaraDB for Redis Enhanced Edition (Tair).</description></item>
        /// <item><description>The ApsaraDB for Redis instance is updated to the latest minor version.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeTopBigKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTopBigKeysResponse
        /// </returns>
        public async Task<DescribeTopBigKeysResponse> DescribeTopBigKeysAsync(DescribeTopBigKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTopBigKeysWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the top 100 hotkeys over a period of time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is available only for an ApsaraDB for Redis instance of one of the following versions:<list type="bullet">
        /// <item><description>The instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).</description></item>
        /// <item><description>The ApsaraDB for Redis instance is updated to the latest minor version.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeTopHotKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTopHotKeysResponse
        /// </returns>
        public DescribeTopHotKeysResponse DescribeTopHotKeysWithOptions(DescribeTopHotKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
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
                Action = "DescribeTopHotKeys",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTopHotKeysResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the top 100 hotkeys over a period of time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is available only for an ApsaraDB for Redis instance of one of the following versions:<list type="bullet">
        /// <item><description>The instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).</description></item>
        /// <item><description>The ApsaraDB for Redis instance is updated to the latest minor version.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeTopHotKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTopHotKeysResponse
        /// </returns>
        public async Task<DescribeTopHotKeysResponse> DescribeTopHotKeysWithOptionsAsync(DescribeTopHotKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
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
                Action = "DescribeTopHotKeys",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTopHotKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the top 100 hotkeys over a period of time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is available only for an ApsaraDB for Redis instance of one of the following versions:<list type="bullet">
        /// <item><description>The instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).</description></item>
        /// <item><description>The ApsaraDB for Redis instance is updated to the latest minor version.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeTopHotKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTopHotKeysResponse
        /// </returns>
        public DescribeTopHotKeysResponse DescribeTopHotKeys(DescribeTopHotKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTopHotKeysWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the top 100 hotkeys over a period of time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the number of queries per second (QPS) of a key is greater than 3,000, the key is considered a hot key.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than 4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of Database Autonomy Service (DAS) SDK must be 1.0.2 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is available only for an ApsaraDB for Redis instance of one of the following versions:<list type="bullet">
        /// <item><description>The instance is a Community Edition instance that uses a major version of 4.0 or later or a performance-enhanced instance of the Enhanced Edition (Tair).</description></item>
        /// <item><description>The ApsaraDB for Redis instance is updated to the latest minor version.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeTopHotKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTopHotKeysResponse
        /// </returns>
        public async Task<DescribeTopHotKeysResponse> DescribeTopHotKeysAsync(DescribeTopHotKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTopHotKeysWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables all throttling rules that are in effect.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableAllSqlConcurrencyControlRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableAllSqlConcurrencyControlRulesResponse
        /// </returns>
        public DisableAllSqlConcurrencyControlRulesResponse DisableAllSqlConcurrencyControlRulesWithOptions(DisableAllSqlConcurrencyControlRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableAllSqlConcurrencyControlRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableAllSqlConcurrencyControlRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables all throttling rules that are in effect.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableAllSqlConcurrencyControlRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableAllSqlConcurrencyControlRulesResponse
        /// </returns>
        public async Task<DisableAllSqlConcurrencyControlRulesResponse> DisableAllSqlConcurrencyControlRulesWithOptionsAsync(DisableAllSqlConcurrencyControlRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableAllSqlConcurrencyControlRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableAllSqlConcurrencyControlRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables all throttling rules that are in effect.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableAllSqlConcurrencyControlRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableAllSqlConcurrencyControlRulesResponse
        /// </returns>
        public DisableAllSqlConcurrencyControlRulesResponse DisableAllSqlConcurrencyControlRules(DisableAllSqlConcurrencyControlRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableAllSqlConcurrencyControlRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables all throttling rules that are in effect.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableAllSqlConcurrencyControlRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableAllSqlConcurrencyControlRulesResponse
        /// </returns>
        public async Task<DisableAllSqlConcurrencyControlRulesResponse> DisableAllSqlConcurrencyControlRulesAsync(DisableAllSqlConcurrencyControlRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableAllSqlConcurrencyControlRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the automatic tablespace fragment recycling feature for database instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableAutoResourceOptimizeRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableAutoResourceOptimizeRulesResponse
        /// </returns>
        public DisableAutoResourceOptimizeRulesResponse DisableAutoResourceOptimizeRulesWithOptions(DisableAutoResourceOptimizeRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
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
                Action = "DisableAutoResourceOptimizeRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableAutoResourceOptimizeRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the automatic tablespace fragment recycling feature for database instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableAutoResourceOptimizeRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableAutoResourceOptimizeRulesResponse
        /// </returns>
        public async Task<DisableAutoResourceOptimizeRulesResponse> DisableAutoResourceOptimizeRulesWithOptionsAsync(DisableAutoResourceOptimizeRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
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
                Action = "DisableAutoResourceOptimizeRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableAutoResourceOptimizeRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the automatic tablespace fragment recycling feature for database instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableAutoResourceOptimizeRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableAutoResourceOptimizeRulesResponse
        /// </returns>
        public DisableAutoResourceOptimizeRulesResponse DisableAutoResourceOptimizeRules(DisableAutoResourceOptimizeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableAutoResourceOptimizeRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the automatic tablespace fragment recycling feature for database instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableAutoResourceOptimizeRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableAutoResourceOptimizeRulesResponse
        /// </returns>
        public async Task<DisableAutoResourceOptimizeRulesResponse> DisableAutoResourceOptimizeRulesAsync(DisableAutoResourceOptimizeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableAutoResourceOptimizeRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the automatic SQL throttling feature for multiple database instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableAutoThrottleRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableAutoThrottleRulesResponse
        /// </returns>
        public DisableAutoThrottleRulesResponse DisableAutoThrottleRulesWithOptions(DisableAutoThrottleRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
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
                Action = "DisableAutoThrottleRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableAutoThrottleRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the automatic SQL throttling feature for multiple database instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableAutoThrottleRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableAutoThrottleRulesResponse
        /// </returns>
        public async Task<DisableAutoThrottleRulesResponse> DisableAutoThrottleRulesWithOptionsAsync(DisableAutoThrottleRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
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
                Action = "DisableAutoThrottleRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableAutoThrottleRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the automatic SQL throttling feature for multiple database instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableAutoThrottleRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableAutoThrottleRulesResponse
        /// </returns>
        public DisableAutoThrottleRulesResponse DisableAutoThrottleRules(DisableAutoThrottleRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableAutoThrottleRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the automatic SQL throttling feature for multiple database instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableAutoThrottleRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableAutoThrottleRulesResponse
        /// </returns>
        public async Task<DisableAutoThrottleRulesResponse> DisableAutoThrottleRulesAsync(DisableAutoThrottleRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableAutoThrottleRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deactivates Database Autonomy Service (DAS) Professional Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  For more information about the database instances that support DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview</a>.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to DAS Enterprise Edition V1.<remarks>
        /// <para> We recommend that you call the <a href="https://help.aliyun.com/document_detail/2778835.html">ModifySqlLogConfig</a> operation to enable or disable DAS Enterprise Edition for a database instance. For more information about the databases and regions supported by each version of DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/156204.html">Editions and supported features</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableDasProRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableDasProResponse
        /// </returns>
        public DisableDasProResponse DisableDasProWithOptions(DisableDasProRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DisableDasPro",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableDasProResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deactivates Database Autonomy Service (DAS) Professional Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  For more information about the database instances that support DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview</a>.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to DAS Enterprise Edition V1.<remarks>
        /// <para> We recommend that you call the <a href="https://help.aliyun.com/document_detail/2778835.html">ModifySqlLogConfig</a> operation to enable or disable DAS Enterprise Edition for a database instance. For more information about the databases and regions supported by each version of DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/156204.html">Editions and supported features</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableDasProRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableDasProResponse
        /// </returns>
        public async Task<DisableDasProResponse> DisableDasProWithOptionsAsync(DisableDasProRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DisableDasPro",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableDasProResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deactivates Database Autonomy Service (DAS) Professional Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  For more information about the database instances that support DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview</a>.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to DAS Enterprise Edition V1.<remarks>
        /// <para> We recommend that you call the <a href="https://help.aliyun.com/document_detail/2778835.html">ModifySqlLogConfig</a> operation to enable or disable DAS Enterprise Edition for a database instance. For more information about the databases and regions supported by each version of DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/156204.html">Editions and supported features</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableDasProRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableDasProResponse
        /// </returns>
        public DisableDasProResponse DisableDasPro(DisableDasProRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableDasProWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deactivates Database Autonomy Service (DAS) Professional Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  For more information about the database instances that support DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview</a>.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to DAS Enterprise Edition V1.<remarks>
        /// <para> We recommend that you call the <a href="https://help.aliyun.com/document_detail/2778835.html">ModifySqlLogConfig</a> operation to enable or disable DAS Enterprise Edition for a database instance. For more information about the databases and regions supported by each version of DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/156204.html">Editions and supported features</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableDasProRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableDasProResponse
        /// </returns>
        public async Task<DisableDasProResponse> DisableDasProAsync(DisableDasProRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableDasProWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the auto scaling feature for a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to ApsaraDB for Redis instances.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableInstanceDasConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableInstanceDasConfigResponse
        /// </returns>
        public DisableInstanceDasConfigResponse DisableInstanceDasConfigWithOptions(DisableInstanceDasConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleType))
            {
                query["ScaleType"] = request.ScaleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableInstanceDasConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableInstanceDasConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the auto scaling feature for a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to ApsaraDB for Redis instances.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableInstanceDasConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableInstanceDasConfigResponse
        /// </returns>
        public async Task<DisableInstanceDasConfigResponse> DisableInstanceDasConfigWithOptionsAsync(DisableInstanceDasConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleType))
            {
                query["ScaleType"] = request.ScaleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableInstanceDasConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableInstanceDasConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the auto scaling feature for a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to ApsaraDB for Redis instances.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableInstanceDasConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableInstanceDasConfigResponse
        /// </returns>
        public DisableInstanceDasConfigResponse DisableInstanceDasConfig(DisableInstanceDasConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableInstanceDasConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the auto scaling feature for a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to ApsaraDB for Redis instances.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableInstanceDasConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableInstanceDasConfigResponse
        /// </returns>
        public async Task<DisableInstanceDasConfigResponse> DisableInstanceDasConfigAsync(DisableInstanceDasConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableInstanceDasConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a throttling rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is applicable to the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableSqlConcurrencyControlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableSqlConcurrencyControlResponse
        /// </returns>
        public DisableSqlConcurrencyControlResponse DisableSqlConcurrencyControlWithOptions(DisableSqlConcurrencyControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableSqlConcurrencyControl",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableSqlConcurrencyControlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a throttling rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is applicable to the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableSqlConcurrencyControlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableSqlConcurrencyControlResponse
        /// </returns>
        public async Task<DisableSqlConcurrencyControlResponse> DisableSqlConcurrencyControlWithOptionsAsync(DisableSqlConcurrencyControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableSqlConcurrencyControl",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableSqlConcurrencyControlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a throttling rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is applicable to the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableSqlConcurrencyControlRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableSqlConcurrencyControlResponse
        /// </returns>
        public DisableSqlConcurrencyControlResponse DisableSqlConcurrencyControl(DisableSqlConcurrencyControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableSqlConcurrencyControlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a throttling rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is applicable to the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableSqlConcurrencyControlRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableSqlConcurrencyControlResponse
        /// </returns>
        public async Task<DisableSqlConcurrencyControlResponse> DisableSqlConcurrencyControlAsync(DisableSqlConcurrencyControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableSqlConcurrencyControlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates Database Autonomy Service (DAS) Professional Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</para>
        /// <list type="bullet">
        /// <item><description>This operation is applicable only to DAS Enterprise Edition V1.<remarks>
        /// <para> We recommend that you call the <a href="https://help.aliyun.com/document_detail/2778835.html">ModifySqlLogConfig</a> operation to activate or deactivate DAS Enterprise Edition for a database instance. For more information about the databases and regions supported by each version of DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/156204.html">DAS editions and supported features</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableDasProRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableDasProResponse
        /// </returns>
        public EnableDasProResponse EnableDasProWithOptions(EnableDasProRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlRetention))
            {
                query["SqlRetention"] = request.SqlRetention;
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
                Action = "EnableDasPro",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableDasProResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates Database Autonomy Service (DAS) Professional Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</para>
        /// <list type="bullet">
        /// <item><description>This operation is applicable only to DAS Enterprise Edition V1.<remarks>
        /// <para> We recommend that you call the <a href="https://help.aliyun.com/document_detail/2778835.html">ModifySqlLogConfig</a> operation to activate or deactivate DAS Enterprise Edition for a database instance. For more information about the databases and regions supported by each version of DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/156204.html">DAS editions and supported features</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableDasProRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableDasProResponse
        /// </returns>
        public async Task<EnableDasProResponse> EnableDasProWithOptionsAsync(EnableDasProRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlRetention))
            {
                query["SqlRetention"] = request.SqlRetention;
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
                Action = "EnableDasPro",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableDasProResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates Database Autonomy Service (DAS) Professional Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</para>
        /// <list type="bullet">
        /// <item><description>This operation is applicable only to DAS Enterprise Edition V1.<remarks>
        /// <para> We recommend that you call the <a href="https://help.aliyun.com/document_detail/2778835.html">ModifySqlLogConfig</a> operation to activate or deactivate DAS Enterprise Edition for a database instance. For more information about the databases and regions supported by each version of DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/156204.html">DAS editions and supported features</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableDasProRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableDasProResponse
        /// </returns>
        public EnableDasProResponse EnableDasPro(EnableDasProRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableDasProWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates Database Autonomy Service (DAS) Professional Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</para>
        /// <list type="bullet">
        /// <item><description>This operation is applicable only to DAS Enterprise Edition V1.<remarks>
        /// <para> We recommend that you call the <a href="https://help.aliyun.com/document_detail/2778835.html">ModifySqlLogConfig</a> operation to activate or deactivate DAS Enterprise Edition for a database instance. For more information about the databases and regions supported by each version of DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/156204.html">DAS editions and supported features</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableDasProRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableDasProResponse
        /// </returns>
        public async Task<EnableDasProResponse> EnableDasProAsync(EnableDasProRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableDasProWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables SQL throttling to control the numbers of database access requests and concurrent SQL statements.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableSqlConcurrencyControlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableSqlConcurrencyControlResponse
        /// </returns>
        public EnableSqlConcurrencyControlResponse EnableSqlConcurrencyControlWithOptions(EnableSqlConcurrencyControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConcurrencyControlTime))
            {
                query["ConcurrencyControlTime"] = request.ConcurrencyControlTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                query["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlKeywords))
            {
                query["SqlKeywords"] = request.SqlKeywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlType))
            {
                query["SqlType"] = request.SqlType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableSqlConcurrencyControl",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableSqlConcurrencyControlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables SQL throttling to control the numbers of database access requests and concurrent SQL statements.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableSqlConcurrencyControlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableSqlConcurrencyControlResponse
        /// </returns>
        public async Task<EnableSqlConcurrencyControlResponse> EnableSqlConcurrencyControlWithOptionsAsync(EnableSqlConcurrencyControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConcurrencyControlTime))
            {
                query["ConcurrencyControlTime"] = request.ConcurrencyControlTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                query["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlKeywords))
            {
                query["SqlKeywords"] = request.SqlKeywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlType))
            {
                query["SqlType"] = request.SqlType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableSqlConcurrencyControl",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableSqlConcurrencyControlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables SQL throttling to control the numbers of database access requests and concurrent SQL statements.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableSqlConcurrencyControlRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableSqlConcurrencyControlResponse
        /// </returns>
        public EnableSqlConcurrencyControlResponse EnableSqlConcurrencyControl(EnableSqlConcurrencyControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableSqlConcurrencyControlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables SQL throttling to control the numbers of database access requests and concurrent SQL statements.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableSqlConcurrencyControlRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableSqlConcurrencyControlResponse
        /// </returns>
        public async Task<EnableSqlConcurrencyControlResponse> EnableSqlConcurrencyControlAsync(EnableSqlConcurrencyControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableSqlConcurrencyControlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously queries the IDs of SQL statements that generate a MySQL error code in the SQL Explorer results of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetAsyncErrorRequestListByCode is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of the <b>isFinish</b> parameter is <b>false</b> in the response, wait for 1 second and then send a request again. If the value of the <b>isFinish</b> parameter is <b>true</b>, the complete results are returned.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/163298.html">Enable and manage DAS Economy Edition and DAS Enterprise Edition</a>.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>When you call this operation, the value of the SqlId parameter changes due to the optimization of the SQL template algorithm starting from September 1, 2024. For more information, see <a href="~~2845725~~">[Notice] Optimization of the SQL template algorithm</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAsyncErrorRequestListByCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAsyncErrorRequestListByCodeResponse
        /// </returns>
        public GetAsyncErrorRequestListByCodeResponse GetAsyncErrorRequestListByCodeWithOptions(GetAsyncErrorRequestListByCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorCode))
            {
                query["ErrorCode"] = request.ErrorCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncErrorRequestListByCode",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncErrorRequestListByCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously queries the IDs of SQL statements that generate a MySQL error code in the SQL Explorer results of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetAsyncErrorRequestListByCode is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of the <b>isFinish</b> parameter is <b>false</b> in the response, wait for 1 second and then send a request again. If the value of the <b>isFinish</b> parameter is <b>true</b>, the complete results are returned.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/163298.html">Enable and manage DAS Economy Edition and DAS Enterprise Edition</a>.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>When you call this operation, the value of the SqlId parameter changes due to the optimization of the SQL template algorithm starting from September 1, 2024. For more information, see <a href="~~2845725~~">[Notice] Optimization of the SQL template algorithm</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAsyncErrorRequestListByCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAsyncErrorRequestListByCodeResponse
        /// </returns>
        public async Task<GetAsyncErrorRequestListByCodeResponse> GetAsyncErrorRequestListByCodeWithOptionsAsync(GetAsyncErrorRequestListByCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorCode))
            {
                query["ErrorCode"] = request.ErrorCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncErrorRequestListByCode",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncErrorRequestListByCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously queries the IDs of SQL statements that generate a MySQL error code in the SQL Explorer results of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetAsyncErrorRequestListByCode is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of the <b>isFinish</b> parameter is <b>false</b> in the response, wait for 1 second and then send a request again. If the value of the <b>isFinish</b> parameter is <b>true</b>, the complete results are returned.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/163298.html">Enable and manage DAS Economy Edition and DAS Enterprise Edition</a>.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>When you call this operation, the value of the SqlId parameter changes due to the optimization of the SQL template algorithm starting from September 1, 2024. For more information, see <a href="~~2845725~~">[Notice] Optimization of the SQL template algorithm</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAsyncErrorRequestListByCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAsyncErrorRequestListByCodeResponse
        /// </returns>
        public GetAsyncErrorRequestListByCodeResponse GetAsyncErrorRequestListByCode(GetAsyncErrorRequestListByCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAsyncErrorRequestListByCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously queries the IDs of SQL statements that generate a MySQL error code in the SQL Explorer results of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetAsyncErrorRequestListByCode is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of the <b>isFinish</b> parameter is <b>false</b> in the response, wait for 1 second and then send a request again. If the value of the <b>isFinish</b> parameter is <b>true</b>, the complete results are returned.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/163298.html">Enable and manage DAS Economy Edition and DAS Enterprise Edition</a>.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>When you call this operation, the value of the SqlId parameter changes due to the optimization of the SQL template algorithm starting from September 1, 2024. For more information, see <a href="~~2845725~~">[Notice] Optimization of the SQL template algorithm</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAsyncErrorRequestListByCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAsyncErrorRequestListByCodeResponse
        /// </returns>
        public async Task<GetAsyncErrorRequestListByCodeResponse> GetAsyncErrorRequestListByCodeAsync(GetAsyncErrorRequestListByCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAsyncErrorRequestListByCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously queries the MySQL error codes in SQL Explorer data and the number of SQL queries corresponding to each error code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetAsyncErrorRequestStatByCode is an asynchronous operation After a request is sent, the complete results are not returned immediately. If the value of <b>isFinish</b> is <b>false</b> in the response, wait for 1 second and then send a request again. If the value of <b>isFinish</b> is <b>true</b>, the complete results are returned.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/163298.html">Purchase DAS Enterprise Edition</a>.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAsyncErrorRequestStatByCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAsyncErrorRequestStatByCodeResponse
        /// </returns>
        public GetAsyncErrorRequestStatByCodeResponse GetAsyncErrorRequestStatByCodeWithOptions(GetAsyncErrorRequestStatByCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncErrorRequestStatByCode",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncErrorRequestStatByCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously queries the MySQL error codes in SQL Explorer data and the number of SQL queries corresponding to each error code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetAsyncErrorRequestStatByCode is an asynchronous operation After a request is sent, the complete results are not returned immediately. If the value of <b>isFinish</b> is <b>false</b> in the response, wait for 1 second and then send a request again. If the value of <b>isFinish</b> is <b>true</b>, the complete results are returned.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/163298.html">Purchase DAS Enterprise Edition</a>.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAsyncErrorRequestStatByCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAsyncErrorRequestStatByCodeResponse
        /// </returns>
        public async Task<GetAsyncErrorRequestStatByCodeResponse> GetAsyncErrorRequestStatByCodeWithOptionsAsync(GetAsyncErrorRequestStatByCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncErrorRequestStatByCode",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncErrorRequestStatByCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously queries the MySQL error codes in SQL Explorer data and the number of SQL queries corresponding to each error code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetAsyncErrorRequestStatByCode is an asynchronous operation After a request is sent, the complete results are not returned immediately. If the value of <b>isFinish</b> is <b>false</b> in the response, wait for 1 second and then send a request again. If the value of <b>isFinish</b> is <b>true</b>, the complete results are returned.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/163298.html">Purchase DAS Enterprise Edition</a>.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAsyncErrorRequestStatByCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAsyncErrorRequestStatByCodeResponse
        /// </returns>
        public GetAsyncErrorRequestStatByCodeResponse GetAsyncErrorRequestStatByCode(GetAsyncErrorRequestStatByCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAsyncErrorRequestStatByCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously queries the MySQL error codes in SQL Explorer data and the number of SQL queries corresponding to each error code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetAsyncErrorRequestStatByCode is an asynchronous operation After a request is sent, the complete results are not returned immediately. If the value of <b>isFinish</b> is <b>false</b> in the response, wait for 1 second and then send a request again. If the value of <b>isFinish</b> is <b>true</b>, the complete results are returned.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/163298.html">Purchase DAS Enterprise Edition</a>.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAsyncErrorRequestStatByCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAsyncErrorRequestStatByCodeResponse
        /// </returns>
        public async Task<GetAsyncErrorRequestStatByCodeResponse> GetAsyncErrorRequestStatByCodeAsync(GetAsyncErrorRequestStatByCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAsyncErrorRequestStatByCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously obtains the number of failed executions of SQL templates based on SQL Explorer data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetAsyncErrorRequestStatResult is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of <b>isFinish</b> is <b>false</b> in the response, wait for 1 second and then send a request again. If the value of <b>isFinish</b> is <b>true</b>, the complete results are returned.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/163298.html">Purchase DAS Enterprise Edition</a>.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAsyncErrorRequestStatResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAsyncErrorRequestStatResultResponse
        /// </returns>
        public GetAsyncErrorRequestStatResultResponse GetAsyncErrorRequestStatResultWithOptions(GetAsyncErrorRequestStatResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlIdList))
            {
                query["SqlIdList"] = request.SqlIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncErrorRequestStatResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncErrorRequestStatResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously obtains the number of failed executions of SQL templates based on SQL Explorer data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetAsyncErrorRequestStatResult is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of <b>isFinish</b> is <b>false</b> in the response, wait for 1 second and then send a request again. If the value of <b>isFinish</b> is <b>true</b>, the complete results are returned.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/163298.html">Purchase DAS Enterprise Edition</a>.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAsyncErrorRequestStatResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAsyncErrorRequestStatResultResponse
        /// </returns>
        public async Task<GetAsyncErrorRequestStatResultResponse> GetAsyncErrorRequestStatResultWithOptionsAsync(GetAsyncErrorRequestStatResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlIdList))
            {
                query["SqlIdList"] = request.SqlIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncErrorRequestStatResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncErrorRequestStatResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously obtains the number of failed executions of SQL templates based on SQL Explorer data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetAsyncErrorRequestStatResult is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of <b>isFinish</b> is <b>false</b> in the response, wait for 1 second and then send a request again. If the value of <b>isFinish</b> is <b>true</b>, the complete results are returned.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/163298.html">Purchase DAS Enterprise Edition</a>.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAsyncErrorRequestStatResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAsyncErrorRequestStatResultResponse
        /// </returns>
        public GetAsyncErrorRequestStatResultResponse GetAsyncErrorRequestStatResult(GetAsyncErrorRequestStatResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAsyncErrorRequestStatResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously obtains the number of failed executions of SQL templates based on SQL Explorer data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetAsyncErrorRequestStatResult is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of <b>isFinish</b> is <b>false</b> in the response, wait for 1 second and then send a request again. If the value of <b>isFinish</b> is <b>true</b>, the complete results are returned.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/163298.html">Purchase DAS Enterprise Edition</a>.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAsyncErrorRequestStatResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAsyncErrorRequestStatResultResponse
        /// </returns>
        public async Task<GetAsyncErrorRequestStatResultResponse> GetAsyncErrorRequestStatResultAsync(GetAsyncErrorRequestStatResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAsyncErrorRequestStatResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage of auto-increment table IDs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call DAS, you must set the region to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutoIncrementUsageStatisticRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAutoIncrementUsageStatisticResponse
        /// </returns>
        public GetAutoIncrementUsageStatisticResponse GetAutoIncrementUsageStatisticWithOptions(GetAutoIncrementUsageStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbNames))
            {
                query["DbNames"] = request.DbNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RatioFilter))
            {
                query["RatioFilter"] = request.RatioFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealTime))
            {
                query["RealTime"] = request.RealTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutoIncrementUsageStatistic",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoIncrementUsageStatisticResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage of auto-increment table IDs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call DAS, you must set the region to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutoIncrementUsageStatisticRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAutoIncrementUsageStatisticResponse
        /// </returns>
        public async Task<GetAutoIncrementUsageStatisticResponse> GetAutoIncrementUsageStatisticWithOptionsAsync(GetAutoIncrementUsageStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbNames))
            {
                query["DbNames"] = request.DbNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RatioFilter))
            {
                query["RatioFilter"] = request.RatioFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealTime))
            {
                query["RealTime"] = request.RealTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutoIncrementUsageStatistic",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoIncrementUsageStatisticResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage of auto-increment table IDs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call DAS, you must set the region to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutoIncrementUsageStatisticRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAutoIncrementUsageStatisticResponse
        /// </returns>
        public GetAutoIncrementUsageStatisticResponse GetAutoIncrementUsageStatistic(GetAutoIncrementUsageStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAutoIncrementUsageStatisticWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the usage of auto-increment table IDs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call DAS, you must set the region to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutoIncrementUsageStatisticRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAutoIncrementUsageStatisticResponse
        /// </returns>
        public async Task<GetAutoIncrementUsageStatisticResponse> GetAutoIncrementUsageStatisticAsync(GetAutoIncrementUsageStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAutoIncrementUsageStatisticWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the automatic fragment recycling rules of database instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database instance is an ApsaraDB RDS for MySQL instance of High-availability Edition.</description></item>
        /// <item><description>The database instance has four or more cores, and <b>innodb_file_per_table</b> is set to <b>ON</b>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutoResourceOptimizeRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAutoResourceOptimizeRulesResponse
        /// </returns>
        public GetAutoResourceOptimizeRulesResponse GetAutoResourceOptimizeRulesWithOptions(GetAutoResourceOptimizeRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
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
                Action = "GetAutoResourceOptimizeRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoResourceOptimizeRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the automatic fragment recycling rules of database instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database instance is an ApsaraDB RDS for MySQL instance of High-availability Edition.</description></item>
        /// <item><description>The database instance has four or more cores, and <b>innodb_file_per_table</b> is set to <b>ON</b>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutoResourceOptimizeRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAutoResourceOptimizeRulesResponse
        /// </returns>
        public async Task<GetAutoResourceOptimizeRulesResponse> GetAutoResourceOptimizeRulesWithOptionsAsync(GetAutoResourceOptimizeRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
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
                Action = "GetAutoResourceOptimizeRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoResourceOptimizeRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the automatic fragment recycling rules of database instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database instance is an ApsaraDB RDS for MySQL instance of High-availability Edition.</description></item>
        /// <item><description>The database instance has four or more cores, and <b>innodb_file_per_table</b> is set to <b>ON</b>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutoResourceOptimizeRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAutoResourceOptimizeRulesResponse
        /// </returns>
        public GetAutoResourceOptimizeRulesResponse GetAutoResourceOptimizeRules(GetAutoResourceOptimizeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAutoResourceOptimizeRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the automatic fragment recycling rules of database instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database instance is an ApsaraDB RDS for MySQL instance of High-availability Edition.</description></item>
        /// <item><description>The database instance has four or more cores, and <b>innodb_file_per_table</b> is set to <b>ON</b>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutoResourceOptimizeRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAutoResourceOptimizeRulesResponse
        /// </returns>
        public async Task<GetAutoResourceOptimizeRulesResponse> GetAutoResourceOptimizeRulesAsync(GetAutoResourceOptimizeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAutoResourceOptimizeRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the automatic SQL throttling rules of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database instance that you want to manage must be of one of the following types:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0</description></item>
        /// <item><description>PolarDB for MySQL Cluster Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutoThrottleRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAutoThrottleRulesResponse
        /// </returns>
        public GetAutoThrottleRulesResponse GetAutoThrottleRulesWithOptions(GetAutoThrottleRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
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
                Action = "GetAutoThrottleRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoThrottleRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the automatic SQL throttling rules of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database instance that you want to manage must be of one of the following types:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0</description></item>
        /// <item><description>PolarDB for MySQL Cluster Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutoThrottleRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAutoThrottleRulesResponse
        /// </returns>
        public async Task<GetAutoThrottleRulesResponse> GetAutoThrottleRulesWithOptionsAsync(GetAutoThrottleRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
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
                Action = "GetAutoThrottleRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoThrottleRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the automatic SQL throttling rules of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database instance that you want to manage must be of one of the following types:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0</description></item>
        /// <item><description>PolarDB for MySQL Cluster Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutoThrottleRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAutoThrottleRulesResponse
        /// </returns>
        public GetAutoThrottleRulesResponse GetAutoThrottleRules(GetAutoThrottleRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAutoThrottleRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the automatic SQL throttling rules of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database instance that you want to manage must be of one of the following types:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0</description></item>
        /// <item><description>PolarDB for MySQL Cluster Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutoThrottleRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAutoThrottleRulesResponse
        /// </returns>
        public async Task<GetAutoThrottleRulesResponse> GetAutoThrottleRulesAsync(GetAutoThrottleRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAutoThrottleRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of notification events of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.<remarks>
        /// <para> You can query the details of notification events only if the autonomy center is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/152139.html">Autonomy center</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutonomousNotifyEventContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAutonomousNotifyEventContentResponse
        /// </returns>
        public GetAutonomousNotifyEventContentResponse GetAutonomousNotifyEventContentWithOptions(GetAutonomousNotifyEventContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpanId))
            {
                query["SpanId"] = request.SpanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutonomousNotifyEventContent",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutonomousNotifyEventContentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of notification events of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.<remarks>
        /// <para> You can query the details of notification events only if the autonomy center is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/152139.html">Autonomy center</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutonomousNotifyEventContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAutonomousNotifyEventContentResponse
        /// </returns>
        public async Task<GetAutonomousNotifyEventContentResponse> GetAutonomousNotifyEventContentWithOptionsAsync(GetAutonomousNotifyEventContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpanId))
            {
                query["SpanId"] = request.SpanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutonomousNotifyEventContent",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutonomousNotifyEventContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of notification events of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.<remarks>
        /// <para> You can query the details of notification events only if the autonomy center is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/152139.html">Autonomy center</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutonomousNotifyEventContentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAutonomousNotifyEventContentResponse
        /// </returns>
        public GetAutonomousNotifyEventContentResponse GetAutonomousNotifyEventContent(GetAutonomousNotifyEventContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAutonomousNotifyEventContentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of notification events of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.<remarks>
        /// <para> You can query the details of notification events only if the autonomy center is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/152139.html">Autonomy center</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutonomousNotifyEventContentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAutonomousNotifyEventContentResponse
        /// </returns>
        public async Task<GetAutonomousNotifyEventContentResponse> GetAutonomousNotifyEventContentAsync(GetAutonomousNotifyEventContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAutonomousNotifyEventContentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the notification events of one or more urgency levels within a period.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.<remarks>
        /// <para> You can query the details of notification events only if the autonomy center is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/152139.html">Autonomy center</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutonomousNotifyEventsInRangeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAutonomousNotifyEventsInRangeResponse
        /// </returns>
        public GetAutonomousNotifyEventsInRangeResponse GetAutonomousNotifyEventsInRangeWithOptions(GetAutonomousNotifyEventsInRangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventContext))
            {
                query["EventContext"] = request.EventContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinLevel))
            {
                query["MinLevel"] = request.MinLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageOffset))
            {
                query["PageOffset"] = request.PageOffset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutonomousNotifyEventsInRange",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutonomousNotifyEventsInRangeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the notification events of one or more urgency levels within a period.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.<remarks>
        /// <para> You can query the details of notification events only if the autonomy center is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/152139.html">Autonomy center</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutonomousNotifyEventsInRangeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAutonomousNotifyEventsInRangeResponse
        /// </returns>
        public async Task<GetAutonomousNotifyEventsInRangeResponse> GetAutonomousNotifyEventsInRangeWithOptionsAsync(GetAutonomousNotifyEventsInRangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventContext))
            {
                query["EventContext"] = request.EventContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinLevel))
            {
                query["MinLevel"] = request.MinLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageOffset))
            {
                query["PageOffset"] = request.PageOffset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutonomousNotifyEventsInRange",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutonomousNotifyEventsInRangeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the notification events of one or more urgency levels within a period.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.<remarks>
        /// <para> You can query the details of notification events only if the autonomy center is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/152139.html">Autonomy center</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutonomousNotifyEventsInRangeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAutonomousNotifyEventsInRangeResponse
        /// </returns>
        public GetAutonomousNotifyEventsInRangeResponse GetAutonomousNotifyEventsInRange(GetAutonomousNotifyEventsInRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAutonomousNotifyEventsInRangeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the notification events of one or more urgency levels within a period.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>After your instance is connected to DAS, notification events such as snapshot capture are triggered if DAS detects changes to database monitoring metrics during anomaly detection.<remarks>
        /// <para> You can query the details of notification events only if the autonomy center is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/152139.html">Autonomy center</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAutonomousNotifyEventsInRangeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAutonomousNotifyEventsInRangeResponse
        /// </returns>
        public async Task<GetAutonomousNotifyEventsInRangeResponse> GetAutonomousNotifyEventsInRangeAsync(GetAutonomousNotifyEventsInRangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAutonomousNotifyEventsInRangeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the blocking data of an ApsaraDB RDS for SQL Server instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for SQL Server instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBlockingDetailListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBlockingDetailListResponse
        /// </returns>
        public GetBlockingDetailListResponse GetBlockingDetailListWithOptions(GetBlockingDetailListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbNameList))
            {
                query["DbNameList"] = request.DbNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryHash))
            {
                query["QueryHash"] = request.QueryHash;
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
                Action = "GetBlockingDetailList",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBlockingDetailListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the blocking data of an ApsaraDB RDS for SQL Server instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for SQL Server instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBlockingDetailListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBlockingDetailListResponse
        /// </returns>
        public async Task<GetBlockingDetailListResponse> GetBlockingDetailListWithOptionsAsync(GetBlockingDetailListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbNameList))
            {
                query["DbNameList"] = request.DbNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryHash))
            {
                query["QueryHash"] = request.QueryHash;
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
                Action = "GetBlockingDetailList",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBlockingDetailListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the blocking data of an ApsaraDB RDS for SQL Server instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for SQL Server instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBlockingDetailListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBlockingDetailListResponse
        /// </returns>
        public GetBlockingDetailListResponse GetBlockingDetailList(GetBlockingDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBlockingDetailListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the blocking data of an ApsaraDB RDS for SQL Server instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for SQL Server instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetBlockingDetailListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBlockingDetailListResponse
        /// </returns>
        public async Task<GetBlockingDetailListResponse> GetBlockingDetailListAsync(GetBlockingDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBlockingDetailListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the diagnosis of network connectivity when a user accesses a specific database instance by specifying an IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database instance that you want to manage is connected to DAS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDBInstanceConnectivityDiagnosisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDBInstanceConnectivityDiagnosisResponse
        /// </returns>
        public GetDBInstanceConnectivityDiagnosisResponse GetDBInstanceConnectivityDiagnosisWithOptions(GetDBInstanceConnectivityDiagnosisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcIp))
            {
                query["SrcIp"] = request.SrcIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDBInstanceConnectivityDiagnosis",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDBInstanceConnectivityDiagnosisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the diagnosis of network connectivity when a user accesses a specific database instance by specifying an IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database instance that you want to manage is connected to DAS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDBInstanceConnectivityDiagnosisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDBInstanceConnectivityDiagnosisResponse
        /// </returns>
        public async Task<GetDBInstanceConnectivityDiagnosisResponse> GetDBInstanceConnectivityDiagnosisWithOptionsAsync(GetDBInstanceConnectivityDiagnosisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcIp))
            {
                query["SrcIp"] = request.SrcIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDBInstanceConnectivityDiagnosis",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDBInstanceConnectivityDiagnosisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the diagnosis of network connectivity when a user accesses a specific database instance by specifying an IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database instance that you want to manage is connected to DAS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDBInstanceConnectivityDiagnosisRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDBInstanceConnectivityDiagnosisResponse
        /// </returns>
        public GetDBInstanceConnectivityDiagnosisResponse GetDBInstanceConnectivityDiagnosis(GetDBInstanceConnectivityDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDBInstanceConnectivityDiagnosisWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the diagnosis of network connectivity when a user accesses a specific database instance by specifying an IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database instance that you want to manage is connected to DAS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDBInstanceConnectivityDiagnosisRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDBInstanceConnectivityDiagnosisResponse
        /// </returns>
        public async Task<GetDBInstanceConnectivityDiagnosisResponse> GetDBInstanceConnectivityDiagnosisAsync(GetDBInstanceConnectivityDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDBInstanceConnectivityDiagnosisWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage usage of a database instance for which Database Autonomy Service (DAS) Enterprise Edition V1 or V2 is enabled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  For information about the database instances that support this operation, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview of DAS Enterprise Edition</a>.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to DAS Enterprise Edition V1 and V2.<remarks>
        /// <para> We recommend that you call the <a href="https://help.aliyun.com/document_detail/2778836.html">DescribeSqlLogStatistic</a> operation to query the data statistics of a database instance for which DAS Enterprise Edition is enabled.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDasProServiceUsageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDasProServiceUsageResponse
        /// </returns>
        public GetDasProServiceUsageResponse GetDasProServiceUsageWithOptions(GetDasProServiceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetDasProServiceUsage",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDasProServiceUsageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage usage of a database instance for which Database Autonomy Service (DAS) Enterprise Edition V1 or V2 is enabled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  For information about the database instances that support this operation, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview of DAS Enterprise Edition</a>.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to DAS Enterprise Edition V1 and V2.<remarks>
        /// <para> We recommend that you call the <a href="https://help.aliyun.com/document_detail/2778836.html">DescribeSqlLogStatistic</a> operation to query the data statistics of a database instance for which DAS Enterprise Edition is enabled.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDasProServiceUsageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDasProServiceUsageResponse
        /// </returns>
        public async Task<GetDasProServiceUsageResponse> GetDasProServiceUsageWithOptionsAsync(GetDasProServiceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetDasProServiceUsage",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDasProServiceUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage usage of a database instance for which Database Autonomy Service (DAS) Enterprise Edition V1 or V2 is enabled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  For information about the database instances that support this operation, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview of DAS Enterprise Edition</a>.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to DAS Enterprise Edition V1 and V2.<remarks>
        /// <para> We recommend that you call the <a href="https://help.aliyun.com/document_detail/2778836.html">DescribeSqlLogStatistic</a> operation to query the data statistics of a database instance for which DAS Enterprise Edition is enabled.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDasProServiceUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDasProServiceUsageResponse
        /// </returns>
        public GetDasProServiceUsageResponse GetDasProServiceUsage(GetDasProServiceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDasProServiceUsageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage usage of a database instance for which Database Autonomy Service (DAS) Enterprise Edition V1 or V2 is enabled.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  For information about the database instances that support this operation, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview of DAS Enterprise Edition</a>.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable only to DAS Enterprise Edition V1 and V2.<remarks>
        /// <para> We recommend that you call the <a href="https://help.aliyun.com/document_detail/2778836.html">DescribeSqlLogStatistic</a> operation to query the data statistics of a database instance for which DAS Enterprise Edition is enabled.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDasProServiceUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDasProServiceUsageResponse
        /// </returns>
        public async Task<GetDasProServiceUsageResponse> GetDasProServiceUsageAsync(GetDasProServiceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDasProServiceUsageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the hot data of audit logs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable to PolarDB for MySQL, ApsaraDB RDS for MySQL, ApsaraDB RDS for PostgreSQL, and ApsaraDB RDS for SQL Server.<remarks>
        /// <para> The beginning of the time range to query can be up to seven days earlier than the current time. The interval between the start time and the end time cannot exceed one day. This operation can return a maximum of 10,000 entries.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDasSQLLogHotDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDasSQLLogHotDataResponse
        /// </returns>
        public GetDasSQLLogHotDataResponse GetDasSQLLogHotDataWithOptions(GetDasSQLLogHotDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildDBInstanceIDs))
            {
                body["ChildDBInstanceIDs"] = request.ChildDBInstanceIDs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBName))
            {
                body["DBName"] = request.DBName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                body["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fail))
            {
                body["Fail"] = request.Fail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostAddress))
            {
                body["HostAddress"] = request.HostAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalOperator))
            {
                body["LogicalOperator"] = request.LogicalOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxLatancy))
            {
                body["MaxLatancy"] = request.MaxLatancy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRecordsPerPage))
            {
                body["MaxRecordsPerPage"] = request.MaxRecordsPerPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRows))
            {
                body["MaxRows"] = request.MaxRows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxScanRows))
            {
                body["MaxScanRows"] = request.MaxScanRows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSpillCnt))
            {
                body["MaxSpillCnt"] = request.MaxSpillCnt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinLatancy))
            {
                body["MinLatancy"] = request.MinLatancy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinRows))
            {
                body["MinRows"] = request.MinRows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinScanRows))
            {
                body["MinScanRows"] = request.MinScanRows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinSpillCnt))
            {
                body["MinSpillCnt"] = request.MinSpillCnt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumbers))
            {
                body["PageNumbers"] = request.PageNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeyword))
            {
                body["QueryKeyword"] = request.QueryKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortKey))
            {
                body["SortKey"] = request.SortKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortMethod))
            {
                body["SortMethod"] = request.SortMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlType))
            {
                body["SqlType"] = request.SqlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                body["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadID))
            {
                body["ThreadID"] = request.ThreadID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceId))
            {
                body["TraceId"] = request.TraceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionId))
            {
                body["TransactionId"] = request.TransactionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDasSQLLogHotData",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDasSQLLogHotDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the hot data of audit logs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable to PolarDB for MySQL, ApsaraDB RDS for MySQL, ApsaraDB RDS for PostgreSQL, and ApsaraDB RDS for SQL Server.<remarks>
        /// <para> The beginning of the time range to query can be up to seven days earlier than the current time. The interval between the start time and the end time cannot exceed one day. This operation can return a maximum of 10,000 entries.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDasSQLLogHotDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDasSQLLogHotDataResponse
        /// </returns>
        public async Task<GetDasSQLLogHotDataResponse> GetDasSQLLogHotDataWithOptionsAsync(GetDasSQLLogHotDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildDBInstanceIDs))
            {
                body["ChildDBInstanceIDs"] = request.ChildDBInstanceIDs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBName))
            {
                body["DBName"] = request.DBName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                body["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fail))
            {
                body["Fail"] = request.Fail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostAddress))
            {
                body["HostAddress"] = request.HostAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalOperator))
            {
                body["LogicalOperator"] = request.LogicalOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxLatancy))
            {
                body["MaxLatancy"] = request.MaxLatancy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRecordsPerPage))
            {
                body["MaxRecordsPerPage"] = request.MaxRecordsPerPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxRows))
            {
                body["MaxRows"] = request.MaxRows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxScanRows))
            {
                body["MaxScanRows"] = request.MaxScanRows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSpillCnt))
            {
                body["MaxSpillCnt"] = request.MaxSpillCnt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinLatancy))
            {
                body["MinLatancy"] = request.MinLatancy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinRows))
            {
                body["MinRows"] = request.MinRows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinScanRows))
            {
                body["MinScanRows"] = request.MinScanRows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinSpillCnt))
            {
                body["MinSpillCnt"] = request.MinSpillCnt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumbers))
            {
                body["PageNumbers"] = request.PageNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeyword))
            {
                body["QueryKeyword"] = request.QueryKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortKey))
            {
                body["SortKey"] = request.SortKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortMethod))
            {
                body["SortMethod"] = request.SortMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlType))
            {
                body["SqlType"] = request.SqlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                body["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadID))
            {
                body["ThreadID"] = request.ThreadID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceId))
            {
                body["TraceId"] = request.TraceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransactionId))
            {
                body["TransactionId"] = request.TransactionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDasSQLLogHotData",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDasSQLLogHotDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the hot data of audit logs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable to PolarDB for MySQL, ApsaraDB RDS for MySQL, ApsaraDB RDS for PostgreSQL, and ApsaraDB RDS for SQL Server.<remarks>
        /// <para> The beginning of the time range to query can be up to seven days earlier than the current time. The interval between the start time and the end time cannot exceed one day. This operation can return a maximum of 10,000 entries.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDasSQLLogHotDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDasSQLLogHotDataResponse
        /// </returns>
        public GetDasSQLLogHotDataResponse GetDasSQLLogHotData(GetDasSQLLogHotDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDasSQLLogHotDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the hot data of audit logs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation is applicable to PolarDB for MySQL, ApsaraDB RDS for MySQL, ApsaraDB RDS for PostgreSQL, and ApsaraDB RDS for SQL Server.<remarks>
        /// <para> The beginning of the time range to query can be up to seven days earlier than the current time. The interval between the start time and the end time cannot exceed one day. This operation can return a maximum of 10,000 entries.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDasSQLLogHotDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDasSQLLogHotDataResponse
        /// </returns>
        public async Task<GetDasSQLLogHotDataResponse> GetDasSQLLogHotDataAsync(GetDasSQLLogHotDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDasSQLLogHotDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个死锁详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeadLockDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeadLockDetailResponse
        /// </returns>
        public GetDeadLockDetailResponse GetDeadLockDetailWithOptions(GetDeadLockDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextId))
            {
                query["TextId"] = request.TextId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeadLockDetail",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeadLockDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个死锁详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeadLockDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeadLockDetailResponse
        /// </returns>
        public async Task<GetDeadLockDetailResponse> GetDeadLockDetailWithOptionsAsync(GetDeadLockDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextId))
            {
                query["TextId"] = request.TextId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeadLockDetail",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeadLockDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个死锁详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeadLockDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeadLockDetailResponse
        /// </returns>
        public GetDeadLockDetailResponse GetDeadLockDetail(GetDeadLockDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeadLockDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询单个死锁详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeadLockDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeadLockDetailResponse
        /// </returns>
        public async Task<GetDeadLockDetailResponse> GetDeadLockDetailAsync(GetDeadLockDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeadLockDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the deadlock details of an ApsaraDB RDS for SQL Server instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for SQL Server instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDeadLockDetailListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeadLockDetailListResponse
        /// </returns>
        public GetDeadLockDetailListResponse GetDeadLockDetailListWithOptions(GetDeadLockDetailListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbNameList))
            {
                query["DbNameList"] = request.DbNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "GetDeadLockDetailList",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeadLockDetailListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the deadlock details of an ApsaraDB RDS for SQL Server instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for SQL Server instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDeadLockDetailListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeadLockDetailListResponse
        /// </returns>
        public async Task<GetDeadLockDetailListResponse> GetDeadLockDetailListWithOptionsAsync(GetDeadLockDetailListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbNameList))
            {
                query["DbNameList"] = request.DbNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "GetDeadLockDetailList",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeadLockDetailListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the deadlock details of an ApsaraDB RDS for SQL Server instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for SQL Server instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDeadLockDetailListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeadLockDetailListResponse
        /// </returns>
        public GetDeadLockDetailListResponse GetDeadLockDetailList(GetDeadLockDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeadLockDetailListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the deadlock details of an ApsaraDB RDS for SQL Server instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for SQL Server instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDeadLockDetailListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeadLockDetailListResponse
        /// </returns>
        public async Task<GetDeadLockDetailListResponse> GetDeadLockDetailListAsync(GetDeadLockDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeadLockDetailListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取历史死锁记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeadLockHistoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeadLockHistoryResponse
        /// </returns>
        public GetDeadLockHistoryResponse GetDeadLockHistoryWithOptions(GetDeadLockHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
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
                Action = "GetDeadLockHistory",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeadLockHistoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取历史死锁记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeadLockHistoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeadLockHistoryResponse
        /// </returns>
        public async Task<GetDeadLockHistoryResponse> GetDeadLockHistoryWithOptionsAsync(GetDeadLockHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
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
                Action = "GetDeadLockHistory",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeadLockHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取历史死锁记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeadLockHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeadLockHistoryResponse
        /// </returns>
        public GetDeadLockHistoryResponse GetDeadLockHistory(GetDeadLockHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeadLockHistoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取历史死锁记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeadLockHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeadLockHistoryResponse
        /// </returns>
        public async Task<GetDeadLockHistoryResponse> GetDeadLockHistoryAsync(GetDeadLockHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeadLockHistoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询时间范围内基于错误日志分析的死锁数量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeadlockHistogramRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeadlockHistogramResponse
        /// </returns>
        public GetDeadlockHistogramResponse GetDeadlockHistogramWithOptions(GetDeadlockHistogramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
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
                Action = "GetDeadlockHistogram",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeadlockHistogramResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询时间范围内基于错误日志分析的死锁数量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeadlockHistogramRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeadlockHistogramResponse
        /// </returns>
        public async Task<GetDeadlockHistogramResponse> GetDeadlockHistogramWithOptionsAsync(GetDeadlockHistogramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
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
                Action = "GetDeadlockHistogram",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeadlockHistogramResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询时间范围内基于错误日志分析的死锁数量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeadlockHistogramRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeadlockHistogramResponse
        /// </returns>
        public GetDeadlockHistogramResponse GetDeadlockHistogram(GetDeadlockHistogramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeadlockHistogramWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询时间范围内基于错误日志分析的死锁数量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeadlockHistogramRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeadlockHistogramResponse
        /// </returns>
        public async Task<GetDeadlockHistogramResponse> GetDeadlockHistogramAsync(GetDeadlockHistogramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeadlockHistogramWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetEndpointSwitchTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEndpointSwitchTaskResponse
        /// </returns>
        public GetEndpointSwitchTaskResponse GetEndpointSwitchTaskWithOptions(GetEndpointSwitchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                query["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipAuth))
            {
                query["skipAuth"] = request.SkipAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                query["timestamp"] = request.Timestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEndpointSwitchTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEndpointSwitchTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetEndpointSwitchTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEndpointSwitchTaskResponse
        /// </returns>
        public async Task<GetEndpointSwitchTaskResponse> GetEndpointSwitchTaskWithOptionsAsync(GetEndpointSwitchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                query["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipAuth))
            {
                query["skipAuth"] = request.SkipAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                query["timestamp"] = request.Timestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEndpointSwitchTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEndpointSwitchTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetEndpointSwitchTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEndpointSwitchTaskResponse
        /// </returns>
        public GetEndpointSwitchTaskResponse GetEndpointSwitchTask(GetEndpointSwitchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEndpointSwitchTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetEndpointSwitchTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEndpointSwitchTaskResponse
        /// </returns>
        public async Task<GetEndpointSwitchTaskResponse> GetEndpointSwitchTaskAsync(GetEndpointSwitchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEndpointSwitchTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously queries information about failed SQL queries in SQL Explorer data. You can query up to 20 failed SQL queries within the specific time range.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetErrorRequestSample is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of <b>isFinish</b> is <b>false</b> in the response, wait for 1 second and then send a request again. If the value of <b>isFinish</b> is <b>true</b>, the complete results are returned.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/163298.html">Purchase DAS Enterprise Edition</a>.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetErrorRequestSampleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetErrorRequestSampleResponse
        /// </returns>
        public GetErrorRequestSampleResponse GetErrorRequestSampleWithOptions(GetErrorRequestSampleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                query["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetErrorRequestSample",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetErrorRequestSampleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously queries information about failed SQL queries in SQL Explorer data. You can query up to 20 failed SQL queries within the specific time range.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetErrorRequestSample is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of <b>isFinish</b> is <b>false</b> in the response, wait for 1 second and then send a request again. If the value of <b>isFinish</b> is <b>true</b>, the complete results are returned.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/163298.html">Purchase DAS Enterprise Edition</a>.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetErrorRequestSampleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetErrorRequestSampleResponse
        /// </returns>
        public async Task<GetErrorRequestSampleResponse> GetErrorRequestSampleWithOptionsAsync(GetErrorRequestSampleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                query["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetErrorRequestSample",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetErrorRequestSampleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously queries information about failed SQL queries in SQL Explorer data. You can query up to 20 failed SQL queries within the specific time range.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetErrorRequestSample is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of <b>isFinish</b> is <b>false</b> in the response, wait for 1 second and then send a request again. If the value of <b>isFinish</b> is <b>true</b>, the complete results are returned.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/163298.html">Purchase DAS Enterprise Edition</a>.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetErrorRequestSampleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetErrorRequestSampleResponse
        /// </returns>
        public GetErrorRequestSampleResponse GetErrorRequestSample(GetErrorRequestSampleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetErrorRequestSampleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously queries information about failed SQL queries in SQL Explorer data. You can query up to 20 failed SQL queries within the specific time range.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetErrorRequestSample is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of <b>isFinish</b> is <b>false</b> in the response, wait for 1 second and then send a request again. If the value of <b>isFinish</b> is <b>true</b>, the complete results are returned.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This API operation supports only ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters for which Database Autonomy Service (DAS) Enterprise Edition is enabled. For more information, see <a href="https://help.aliyun.com/document_detail/163298.html">Purchase DAS Enterprise Edition</a>.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetErrorRequestSampleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetErrorRequestSampleResponse
        /// </returns>
        public async Task<GetErrorRequestSampleResponse> GetErrorRequestSampleAsync(GetErrorRequestSampleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetErrorRequestSampleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the event subscription settings of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database instance that you want to manage is connected to DAS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEventSubscriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEventSubscriptionResponse
        /// </returns>
        public GetEventSubscriptionResponse GetEventSubscriptionWithOptions(GetEventSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEventSubscription",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the event subscription settings of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database instance that you want to manage is connected to DAS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEventSubscriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEventSubscriptionResponse
        /// </returns>
        public async Task<GetEventSubscriptionResponse> GetEventSubscriptionWithOptionsAsync(GetEventSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEventSubscription",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the event subscription settings of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database instance that you want to manage is connected to DAS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEventSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEventSubscriptionResponse
        /// </returns>
        public GetEventSubscriptionResponse GetEventSubscription(GetEventSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEventSubscriptionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the event subscription settings of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database instance that you want to manage is connected to DAS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetEventSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEventSubscriptionResponse
        /// </returns>
        public async Task<GetEventSubscriptionResponse> GetEventSubscriptionAsync(GetEventSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEventSubscriptionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Collects the full request statistics in the SQL Explorer results of a database instance by access source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see <a href="https://help.aliyun.com/document_detail/204096.html">SQL Explorer</a>.</para>
        /// <list type="bullet">
        /// <item><description>For more information about database instances that support this feature, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview</a>.</description></item>
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFullRequestOriginStatByInstanceIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFullRequestOriginStatByInstanceIdResponse
        /// </returns>
        public GetFullRequestOriginStatByInstanceIdResponse GetFullRequestOriginStatByInstanceIdWithOptions(GetFullRequestOriginStatByInstanceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Asc))
            {
                query["Asc"] = request.Asc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlType))
            {
                query["SqlType"] = request.SqlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
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
                Action = "GetFullRequestOriginStatByInstanceId",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFullRequestOriginStatByInstanceIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Collects the full request statistics in the SQL Explorer results of a database instance by access source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see <a href="https://help.aliyun.com/document_detail/204096.html">SQL Explorer</a>.</para>
        /// <list type="bullet">
        /// <item><description>For more information about database instances that support this feature, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview</a>.</description></item>
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFullRequestOriginStatByInstanceIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFullRequestOriginStatByInstanceIdResponse
        /// </returns>
        public async Task<GetFullRequestOriginStatByInstanceIdResponse> GetFullRequestOriginStatByInstanceIdWithOptionsAsync(GetFullRequestOriginStatByInstanceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Asc))
            {
                query["Asc"] = request.Asc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlType))
            {
                query["SqlType"] = request.SqlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
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
                Action = "GetFullRequestOriginStatByInstanceId",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFullRequestOriginStatByInstanceIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Collects the full request statistics in the SQL Explorer results of a database instance by access source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see <a href="https://help.aliyun.com/document_detail/204096.html">SQL Explorer</a>.</para>
        /// <list type="bullet">
        /// <item><description>For more information about database instances that support this feature, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview</a>.</description></item>
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFullRequestOriginStatByInstanceIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFullRequestOriginStatByInstanceIdResponse
        /// </returns>
        public GetFullRequestOriginStatByInstanceIdResponse GetFullRequestOriginStatByInstanceId(GetFullRequestOriginStatByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFullRequestOriginStatByInstanceIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Collects the full request statistics in the SQL Explorer results of a database instance by access source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see <a href="https://help.aliyun.com/document_detail/204096.html">SQL Explorer</a>.</para>
        /// <list type="bullet">
        /// <item><description>For more information about database instances that support this feature, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview</a>.</description></item>
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFullRequestOriginStatByInstanceIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFullRequestOriginStatByInstanceIdResponse
        /// </returns>
        public async Task<GetFullRequestOriginStatByInstanceIdResponse> GetFullRequestOriginStatByInstanceIdAsync(GetFullRequestOriginStatByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFullRequestOriginStatByInstanceIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries sample SQL statements in the SQL Explorer data of a database instance by SQL ID. You can query up to 20 sample SQL statements.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see <a href="https://help.aliyun.com/document_detail/204096.html">SQL Explorer</a>.</para>
        /// <list type="bullet">
        /// <item><description>For more information about the database engines that support SQL Explorer, see <a href="https://help.aliyun.com/document_detail/204096.html">SQL Explorer</a>.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFullRequestSampleByInstanceIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFullRequestSampleByInstanceIdResponse
        /// </returns>
        public GetFullRequestSampleByInstanceIdResponse GetFullRequestSampleByInstanceIdWithOptions(GetFullRequestSampleByInstanceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                body["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFullRequestSampleByInstanceId",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFullRequestSampleByInstanceIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries sample SQL statements in the SQL Explorer data of a database instance by SQL ID. You can query up to 20 sample SQL statements.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see <a href="https://help.aliyun.com/document_detail/204096.html">SQL Explorer</a>.</para>
        /// <list type="bullet">
        /// <item><description>For more information about the database engines that support SQL Explorer, see <a href="https://help.aliyun.com/document_detail/204096.html">SQL Explorer</a>.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFullRequestSampleByInstanceIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFullRequestSampleByInstanceIdResponse
        /// </returns>
        public async Task<GetFullRequestSampleByInstanceIdResponse> GetFullRequestSampleByInstanceIdWithOptionsAsync(GetFullRequestSampleByInstanceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                body["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                body["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFullRequestSampleByInstanceId",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFullRequestSampleByInstanceIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries sample SQL statements in the SQL Explorer data of a database instance by SQL ID. You can query up to 20 sample SQL statements.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see <a href="https://help.aliyun.com/document_detail/204096.html">SQL Explorer</a>.</para>
        /// <list type="bullet">
        /// <item><description>For more information about the database engines that support SQL Explorer, see <a href="https://help.aliyun.com/document_detail/204096.html">SQL Explorer</a>.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFullRequestSampleByInstanceIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFullRequestSampleByInstanceIdResponse
        /// </returns>
        public GetFullRequestSampleByInstanceIdResponse GetFullRequestSampleByInstanceId(GetFullRequestSampleByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFullRequestSampleByInstanceIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries sample SQL statements in the SQL Explorer data of a database instance by SQL ID. You can query up to 20 sample SQL statements.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see <a href="https://help.aliyun.com/document_detail/204096.html">SQL Explorer</a>.</para>
        /// <list type="bullet">
        /// <item><description>For more information about the database engines that support SQL Explorer, see <a href="https://help.aliyun.com/document_detail/204096.html">SQL Explorer</a>.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFullRequestSampleByInstanceIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFullRequestSampleByInstanceIdResponse
        /// </returns>
        public async Task<GetFullRequestSampleByInstanceIdResponse> GetFullRequestSampleByInstanceIdAsync(GetFullRequestSampleByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFullRequestSampleByInstanceIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously collects the full request statistics in the SQL Explorer results of a database instance by SQL ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetFullRequestStatResultByInstanceId is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of the isFinish parameter is <b>false</b> in the response, wait for 1 second and then send a request again. If the value of the isFinish parameter is <b>true</b>, the complete results are returned.
        /// The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see <a href="https://help.aliyun.com/document_detail/204096.html">SQL Explorer</a>.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For more information about database instances that support this feature, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview of DAS Enterprise Edition</a>.</description></item>
        /// <item><description>If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>When you call this operation, the value of the SqlId parameter changes due to the optimization of the SQL template algorithm starting from September 1, 2024. For more information, see <a href="~~2845725~~">[Notice] Optimization of the SQL template algorithm</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFullRequestStatResultByInstanceIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFullRequestStatResultByInstanceIdResponse
        /// </returns>
        public GetFullRequestStatResultByInstanceIdResponse GetFullRequestStatResultByInstanceIdWithOptions(GetFullRequestStatResultByInstanceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Asc))
            {
                query["Asc"] = request.Asc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginHost))
            {
                query["OriginHost"] = request.OriginHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                query["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlType))
            {
                query["SqlType"] = request.SqlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
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
                Action = "GetFullRequestStatResultByInstanceId",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFullRequestStatResultByInstanceIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously collects the full request statistics in the SQL Explorer results of a database instance by SQL ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetFullRequestStatResultByInstanceId is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of the isFinish parameter is <b>false</b> in the response, wait for 1 second and then send a request again. If the value of the isFinish parameter is <b>true</b>, the complete results are returned.
        /// The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see <a href="https://help.aliyun.com/document_detail/204096.html">SQL Explorer</a>.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For more information about database instances that support this feature, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview of DAS Enterprise Edition</a>.</description></item>
        /// <item><description>If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>When you call this operation, the value of the SqlId parameter changes due to the optimization of the SQL template algorithm starting from September 1, 2024. For more information, see <a href="~~2845725~~">[Notice] Optimization of the SQL template algorithm</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFullRequestStatResultByInstanceIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFullRequestStatResultByInstanceIdResponse
        /// </returns>
        public async Task<GetFullRequestStatResultByInstanceIdResponse> GetFullRequestStatResultByInstanceIdWithOptionsAsync(GetFullRequestStatResultByInstanceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Asc))
            {
                query["Asc"] = request.Asc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.End))
            {
                query["End"] = request.End;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginHost))
            {
                query["OriginHost"] = request.OriginHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                query["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlType))
            {
                query["SqlType"] = request.SqlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
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
                Action = "GetFullRequestStatResultByInstanceId",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFullRequestStatResultByInstanceIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously collects the full request statistics in the SQL Explorer results of a database instance by SQL ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetFullRequestStatResultByInstanceId is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of the isFinish parameter is <b>false</b> in the response, wait for 1 second and then send a request again. If the value of the isFinish parameter is <b>true</b>, the complete results are returned.
        /// The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see <a href="https://help.aliyun.com/document_detail/204096.html">SQL Explorer</a>.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For more information about database instances that support this feature, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview of DAS Enterprise Edition</a>.</description></item>
        /// <item><description>If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>When you call this operation, the value of the SqlId parameter changes due to the optimization of the SQL template algorithm starting from September 1, 2024. For more information, see <a href="~~2845725~~">[Notice] Optimization of the SQL template algorithm</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFullRequestStatResultByInstanceIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFullRequestStatResultByInstanceIdResponse
        /// </returns>
        public GetFullRequestStatResultByInstanceIdResponse GetFullRequestStatResultByInstanceId(GetFullRequestStatResultByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFullRequestStatResultByInstanceIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously collects the full request statistics in the SQL Explorer results of a database instance by SQL ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetFullRequestStatResultByInstanceId is an asynchronous operation. After a request is sent, the complete results are not returned immediately. If the value of the isFinish parameter is <b>false</b> in the response, wait for 1 second and then send a request again. If the value of the isFinish parameter is <b>true</b>, the complete results are returned.
        /// The SQL Explorer feature allows you to check the health status of SQL statements and troubleshoot performance issues. For more information, see <a href="https://help.aliyun.com/document_detail/204096.html">SQL Explorer</a>.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For more information about database instances that support this feature, see <a href="https://help.aliyun.com/document_detail/190912.html">Overview of DAS Enterprise Edition</a>.</description></item>
        /// <item><description>If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>When you call this operation, the value of the SqlId parameter changes due to the optimization of the SQL template algorithm starting from September 1, 2024. For more information, see <a href="~~2845725~~">[Notice] Optimization of the SQL template algorithm</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetFullRequestStatResultByInstanceIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFullRequestStatResultByInstanceIdResponse
        /// </returns>
        public async Task<GetFullRequestStatResultByInstanceIdResponse> GetFullRequestStatResultByInstanceIdAsync(GetFullRequestStatResultByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFullRequestStatResultByInstanceIdWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetHDMAliyunResourceSyncResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHDMAliyunResourceSyncResultResponse
        /// </returns>
        public GetHDMAliyunResourceSyncResultResponse GetHDMAliyunResourceSyncResultWithOptions(GetHDMAliyunResourceSyncResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                query["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipAuth))
            {
                query["skipAuth"] = request.SkipAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                query["timestamp"] = request.Timestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHDMAliyunResourceSyncResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHDMAliyunResourceSyncResultResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetHDMAliyunResourceSyncResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHDMAliyunResourceSyncResultResponse
        /// </returns>
        public async Task<GetHDMAliyunResourceSyncResultResponse> GetHDMAliyunResourceSyncResultWithOptionsAsync(GetHDMAliyunResourceSyncResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                query["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipAuth))
            {
                query["skipAuth"] = request.SkipAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                query["timestamp"] = request.Timestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHDMAliyunResourceSyncResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHDMAliyunResourceSyncResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetHDMAliyunResourceSyncResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHDMAliyunResourceSyncResultResponse
        /// </returns>
        public GetHDMAliyunResourceSyncResultResponse GetHDMAliyunResourceSyncResult(GetHDMAliyunResourceSyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHDMAliyunResourceSyncResultWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetHDMAliyunResourceSyncResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHDMAliyunResourceSyncResultResponse
        /// </returns>
        public async Task<GetHDMAliyunResourceSyncResultResponse> GetHDMAliyunResourceSyncResultAsync(GetHDMAliyunResourceSyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHDMAliyunResourceSyncResultWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetHDMLastAliyunResourceSyncResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHDMLastAliyunResourceSyncResultResponse
        /// </returns>
        public GetHDMLastAliyunResourceSyncResultResponse GetHDMLastAliyunResourceSyncResultWithOptions(GetHDMLastAliyunResourceSyncResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                query["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipAuth))
            {
                query["skipAuth"] = request.SkipAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                query["timestamp"] = request.Timestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHDMLastAliyunResourceSyncResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHDMLastAliyunResourceSyncResultResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetHDMLastAliyunResourceSyncResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHDMLastAliyunResourceSyncResultResponse
        /// </returns>
        public async Task<GetHDMLastAliyunResourceSyncResultResponse> GetHDMLastAliyunResourceSyncResultWithOptionsAsync(GetHDMLastAliyunResourceSyncResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Context))
            {
                query["__context"] = request.Context;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKey))
            {
                query["accessKey"] = request.AccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                query["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipAuth))
            {
                query["skipAuth"] = request.SkipAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                query["timestamp"] = request.Timestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHDMLastAliyunResourceSyncResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHDMLastAliyunResourceSyncResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetHDMLastAliyunResourceSyncResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHDMLastAliyunResourceSyncResultResponse
        /// </returns>
        public GetHDMLastAliyunResourceSyncResultResponse GetHDMLastAliyunResourceSyncResult(GetHDMLastAliyunResourceSyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHDMLastAliyunResourceSyncResultWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetHDMLastAliyunResourceSyncResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHDMLastAliyunResourceSyncResultResponse
        /// </returns>
        public async Task<GetHDMLastAliyunResourceSyncResultResponse> GetHDMLastAliyunResourceSyncResultAsync(GetHDMLastAliyunResourceSyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHDMLastAliyunResourceSyncResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of an inspection that is performed on a database instance by using the inspection and scoring feature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the inspection and scoring feature. This feature allows you to inspect and score the health status of your instance on a regular basis. This helps you obtain information about the status of your databases. For more information, see <a href="https://help.aliyun.com/document_detail/205659.html">Inspection and scoring</a>.
        /// Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This operation is applicable only to ApsaraDB RDS for MySQL databases, self-managed MySQL databases hosted on Elastic Compute Service (ECS) instances, self-managed MySQL databases in data centers, ApsaraDB for Redis databases, and PolarDB for MySQL databases.</description></item>
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of DAS SDK must be V1.0.3 or later.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceInspectionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceInspectionsResponse
        /// </returns>
        public GetInstanceInspectionsResponse GetInstanceInspectionsWithOptions(GetInstanceInspectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceArea))
            {
                query["InstanceArea"] = request.InstanceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMap))
            {
                query["SearchMap"] = request.SearchMap;
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
                Action = "GetInstanceInspections",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceInspectionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of an inspection that is performed on a database instance by using the inspection and scoring feature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the inspection and scoring feature. This feature allows you to inspect and score the health status of your instance on a regular basis. This helps you obtain information about the status of your databases. For more information, see <a href="https://help.aliyun.com/document_detail/205659.html">Inspection and scoring</a>.
        /// Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This operation is applicable only to ApsaraDB RDS for MySQL databases, self-managed MySQL databases hosted on Elastic Compute Service (ECS) instances, self-managed MySQL databases in data centers, ApsaraDB for Redis databases, and PolarDB for MySQL databases.</description></item>
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of DAS SDK must be V1.0.3 or later.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceInspectionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceInspectionsResponse
        /// </returns>
        public async Task<GetInstanceInspectionsResponse> GetInstanceInspectionsWithOptionsAsync(GetInstanceInspectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceArea))
            {
                query["InstanceArea"] = request.InstanceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMap))
            {
                query["SearchMap"] = request.SearchMap;
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
                Action = "GetInstanceInspections",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceInspectionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of an inspection that is performed on a database instance by using the inspection and scoring feature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the inspection and scoring feature. This feature allows you to inspect and score the health status of your instance on a regular basis. This helps you obtain information about the status of your databases. For more information, see <a href="https://help.aliyun.com/document_detail/205659.html">Inspection and scoring</a>.
        /// Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This operation is applicable only to ApsaraDB RDS for MySQL databases, self-managed MySQL databases hosted on Elastic Compute Service (ECS) instances, self-managed MySQL databases in data centers, ApsaraDB for Redis databases, and PolarDB for MySQL databases.</description></item>
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of DAS SDK must be V1.0.3 or later.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceInspectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceInspectionsResponse
        /// </returns>
        public GetInstanceInspectionsResponse GetInstanceInspections(GetInstanceInspectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceInspectionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of an inspection that is performed on a database instance by using the inspection and scoring feature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the inspection and scoring feature. This feature allows you to inspect and score the health status of your instance on a regular basis. This helps you obtain information about the status of your databases. For more information, see <a href="https://help.aliyun.com/document_detail/205659.html">Inspection and scoring</a>.
        /// Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>This operation is applicable only to ApsaraDB RDS for MySQL databases, self-managed MySQL databases hosted on Elastic Compute Service (ECS) instances, self-managed MySQL databases in data centers, ApsaraDB for Redis databases, and PolarDB for MySQL databases.</description></item>
        /// <item><description>If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of DAS SDK must be V1.0.3 or later.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceInspectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceInspectionsResponse
        /// </returns>
        public async Task<GetInstanceInspectionsResponse> GetInstanceInspectionsAsync(GetInstanceInspectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceInspectionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of all missing indexes of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for SQL Server instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceMissingIndexListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceMissingIndexListResponse
        /// </returns>
        public GetInstanceMissingIndexListResponse GetInstanceMissingIndexListWithOptions(GetInstanceMissingIndexListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvgTotalUserCost))
            {
                query["AvgTotalUserCost"] = request.AvgTotalUserCost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvgUserImpact))
            {
                query["AvgUserImpact"] = request.AvgUserImpact;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexCount))
            {
                query["IndexCount"] = request.IndexCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectName))
            {
                query["ObjectName"] = request.ObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedPages))
            {
                query["ReservedPages"] = request.ReservedPages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedSize))
            {
                query["ReservedSize"] = request.ReservedSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowCount))
            {
                query["RowCount"] = request.RowCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueCompiles))
            {
                query["UniqueCompiles"] = request.UniqueCompiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserScans))
            {
                query["UserScans"] = request.UserScans;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSeeks))
            {
                query["UserSeeks"] = request.UserSeeks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceMissingIndexList",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceMissingIndexListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of all missing indexes of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for SQL Server instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceMissingIndexListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceMissingIndexListResponse
        /// </returns>
        public async Task<GetInstanceMissingIndexListResponse> GetInstanceMissingIndexListWithOptionsAsync(GetInstanceMissingIndexListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvgTotalUserCost))
            {
                query["AvgTotalUserCost"] = request.AvgTotalUserCost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvgUserImpact))
            {
                query["AvgUserImpact"] = request.AvgUserImpact;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexCount))
            {
                query["IndexCount"] = request.IndexCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectName))
            {
                query["ObjectName"] = request.ObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedPages))
            {
                query["ReservedPages"] = request.ReservedPages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedSize))
            {
                query["ReservedSize"] = request.ReservedSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RowCount))
            {
                query["RowCount"] = request.RowCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueCompiles))
            {
                query["UniqueCompiles"] = request.UniqueCompiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserScans))
            {
                query["UserScans"] = request.UserScans;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSeeks))
            {
                query["UserSeeks"] = request.UserSeeks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceMissingIndexList",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceMissingIndexListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of all missing indexes of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for SQL Server instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceMissingIndexListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceMissingIndexListResponse
        /// </returns>
        public GetInstanceMissingIndexListResponse GetInstanceMissingIndexList(GetInstanceMissingIndexListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceMissingIndexListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of all missing indexes of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for SQL Server instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceMissingIndexListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceMissingIndexListResponse
        /// </returns>
        public async Task<GetInstanceMissingIndexListResponse> GetInstanceMissingIndexListAsync(GetInstanceMissingIndexListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceMissingIndexListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries statistics on automatic SQL optimization events within a period of time, such as the total number of optimization events and the maximum improvement.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database engine is ApsaraDB RDS for MySQL or PolarDB for MySQL.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceSqlOptimizeStatisticRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceSqlOptimizeStatisticResponse
        /// </returns>
        public GetInstanceSqlOptimizeStatisticResponse GetInstanceSqlOptimizeStatisticWithOptions(GetInstanceSqlOptimizeStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterEnable))
            {
                query["FilterEnable"] = request.FilterEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseMerging))
            {
                query["UseMerging"] = request.UseMerging;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceSqlOptimizeStatistic",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceSqlOptimizeStatisticResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries statistics on automatic SQL optimization events within a period of time, such as the total number of optimization events and the maximum improvement.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database engine is ApsaraDB RDS for MySQL or PolarDB for MySQL.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceSqlOptimizeStatisticRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceSqlOptimizeStatisticResponse
        /// </returns>
        public async Task<GetInstanceSqlOptimizeStatisticResponse> GetInstanceSqlOptimizeStatisticWithOptionsAsync(GetInstanceSqlOptimizeStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterEnable))
            {
                query["FilterEnable"] = request.FilterEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseMerging))
            {
                query["UseMerging"] = request.UseMerging;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceSqlOptimizeStatistic",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceSqlOptimizeStatisticResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries statistics on automatic SQL optimization events within a period of time, such as the total number of optimization events and the maximum improvement.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database engine is ApsaraDB RDS for MySQL or PolarDB for MySQL.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceSqlOptimizeStatisticRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceSqlOptimizeStatisticResponse
        /// </returns>
        public GetInstanceSqlOptimizeStatisticResponse GetInstanceSqlOptimizeStatistic(GetInstanceSqlOptimizeStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceSqlOptimizeStatisticWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries statistics on automatic SQL optimization events within a period of time, such as the total number of optimization events and the maximum improvement.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database engine is ApsaraDB RDS for MySQL or PolarDB for MySQL.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceSqlOptimizeStatisticRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceSqlOptimizeStatisticResponse
        /// </returns>
        public async Task<GetInstanceSqlOptimizeStatisticResponse> GetInstanceSqlOptimizeStatisticAsync(GetInstanceSqlOptimizeStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceSqlOptimizeStatisticWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of a task that terminates sessions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetKillInstanceSessionTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKillInstanceSessionTaskResultResponse
        /// </returns>
        public GetKillInstanceSessionTaskResultResponse GetKillInstanceSessionTaskResultWithOptions(GetKillInstanceSessionTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
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
                Action = "GetKillInstanceSessionTaskResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKillInstanceSessionTaskResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of a task that terminates sessions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetKillInstanceSessionTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKillInstanceSessionTaskResultResponse
        /// </returns>
        public async Task<GetKillInstanceSessionTaskResultResponse> GetKillInstanceSessionTaskResultWithOptionsAsync(GetKillInstanceSessionTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
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
                Action = "GetKillInstanceSessionTaskResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKillInstanceSessionTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of a task that terminates sessions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetKillInstanceSessionTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKillInstanceSessionTaskResultResponse
        /// </returns>
        public GetKillInstanceSessionTaskResultResponse GetKillInstanceSessionTaskResult(GetKillInstanceSessionTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetKillInstanceSessionTaskResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of a task that terminates sessions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetKillInstanceSessionTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKillInstanceSessionTaskResultResponse
        /// </returns>
        public async Task<GetKillInstanceSessionTaskResultResponse> GetKillInstanceSessionTaskResultAsync(GetKillInstanceSessionTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetKillInstanceSessionTaskResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current sessions of an ApsaraDB for MongoDB (MongoDB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to MongoDB instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMongoDBCurrentOpRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMongoDBCurrentOpResponse
        /// </returns>
        public GetMongoDBCurrentOpResponse GetMongoDBCurrentOpWithOptions(GetMongoDBCurrentOpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterDoc))
            {
                query["FilterDoc"] = request.FilterDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
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
                Action = "GetMongoDBCurrentOp",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMongoDBCurrentOpResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current sessions of an ApsaraDB for MongoDB (MongoDB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to MongoDB instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMongoDBCurrentOpRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMongoDBCurrentOpResponse
        /// </returns>
        public async Task<GetMongoDBCurrentOpResponse> GetMongoDBCurrentOpWithOptionsAsync(GetMongoDBCurrentOpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterDoc))
            {
                query["FilterDoc"] = request.FilterDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
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
                Action = "GetMongoDBCurrentOp",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMongoDBCurrentOpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current sessions of an ApsaraDB for MongoDB (MongoDB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to MongoDB instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMongoDBCurrentOpRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMongoDBCurrentOpResponse
        /// </returns>
        public GetMongoDBCurrentOpResponse GetMongoDBCurrentOp(GetMongoDBCurrentOpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMongoDBCurrentOpWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current sessions of an ApsaraDB for MongoDB (MongoDB) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to MongoDB instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMongoDBCurrentOpRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMongoDBCurrentOpResponse
        /// </returns>
        public async Task<GetMongoDBCurrentOpResponse> GetMongoDBCurrentOpAsync(GetMongoDBCurrentOpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMongoDBCurrentOpWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously queries the sessions of an instance and collects statistics on the sessions based on dimensions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetMySQLAllSessionAsync is an asynchronous operation. After a request is sent, the system does not return complete results but returns a request ID. You need to use the request ID to initiate requests until the value of the <b>isFinish</b> field in the returned results is <b>true</b>, the complete results are returned. This indicates that to obtain complete data, you must call this operation at least twice.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This operation is applicable only to ApsaraDB RDS for MySQL instances, PolarDB for MySQL clusters, and PolarDB-X 2.0 instances.</description></item>
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMySQLAllSessionAsyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMySQLAllSessionAsyncResponse
        /// </returns>
        public GetMySQLAllSessionAsyncResponse GetMySQLAllSessionAsyncWithOptions(GetMySQLAllSessionAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultId))
            {
                query["ResultId"] = request.ResultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMySQLAllSessionAsync",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMySQLAllSessionAsyncResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously queries the sessions of an instance and collects statistics on the sessions based on dimensions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetMySQLAllSessionAsync is an asynchronous operation. After a request is sent, the system does not return complete results but returns a request ID. You need to use the request ID to initiate requests until the value of the <b>isFinish</b> field in the returned results is <b>true</b>, the complete results are returned. This indicates that to obtain complete data, you must call this operation at least twice.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This operation is applicable only to ApsaraDB RDS for MySQL instances, PolarDB for MySQL clusters, and PolarDB-X 2.0 instances.</description></item>
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMySQLAllSessionAsyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMySQLAllSessionAsyncResponse
        /// </returns>
        public async Task<GetMySQLAllSessionAsyncResponse> GetMySQLAllSessionAsyncWithOptionsAsync(GetMySQLAllSessionAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultId))
            {
                query["ResultId"] = request.ResultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMySQLAllSessionAsync",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMySQLAllSessionAsyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously queries the sessions of an instance and collects statistics on the sessions based on dimensions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetMySQLAllSessionAsync is an asynchronous operation. After a request is sent, the system does not return complete results but returns a request ID. You need to use the request ID to initiate requests until the value of the <b>isFinish</b> field in the returned results is <b>true</b>, the complete results are returned. This indicates that to obtain complete data, you must call this operation at least twice.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This operation is applicable only to ApsaraDB RDS for MySQL instances, PolarDB for MySQL clusters, and PolarDB-X 2.0 instances.</description></item>
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMySQLAllSessionAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMySQLAllSessionAsyncResponse
        /// </returns>
        public GetMySQLAllSessionAsyncResponse GetMySQLAllSessionAsync(GetMySQLAllSessionAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMySQLAllSessionAsyncWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously queries the sessions of an instance and collects statistics on the sessions based on dimensions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> GetMySQLAllSessionAsync is an asynchronous operation. After a request is sent, the system does not return complete results but returns a request ID. You need to use the request ID to initiate requests until the value of the <b>isFinish</b> field in the returned results is <b>true</b>, the complete results are returned. This indicates that to obtain complete data, you must call this operation at least twice.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This operation is applicable only to ApsaraDB RDS for MySQL instances, PolarDB for MySQL clusters, and PolarDB-X 2.0 instances.</description></item>
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMySQLAllSessionAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMySQLAllSessionAsyncResponse
        /// </returns>
        public async Task<GetMySQLAllSessionAsyncResponse> GetMySQLAllSessionAsyncAsync(GetMySQLAllSessionAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMySQLAllSessionAsyncWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access frequency statistics and hot data on partitions of a PolarDB-X 2.0 instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call this operation. The data is returned in a special format and is complex to parse. You can use the <a href="https://help.aliyun.com/document_detail/470302.html">heatmap</a> feature of Database Autonomy Service (DAS) to query the data.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPartitionsHeatmapRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPartitionsHeatmapResponse
        /// </returns>
        public GetPartitionsHeatmapResponse GetPartitionsHeatmapWithOptions(GetPartitionsHeatmapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRange))
            {
                query["TimeRange"] = request.TimeRange;
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
                Action = "GetPartitionsHeatmap",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPartitionsHeatmapResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access frequency statistics and hot data on partitions of a PolarDB-X 2.0 instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call this operation. The data is returned in a special format and is complex to parse. You can use the <a href="https://help.aliyun.com/document_detail/470302.html">heatmap</a> feature of Database Autonomy Service (DAS) to query the data.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPartitionsHeatmapRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPartitionsHeatmapResponse
        /// </returns>
        public async Task<GetPartitionsHeatmapResponse> GetPartitionsHeatmapWithOptionsAsync(GetPartitionsHeatmapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRange))
            {
                query["TimeRange"] = request.TimeRange;
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
                Action = "GetPartitionsHeatmap",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPartitionsHeatmapResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access frequency statistics and hot data on partitions of a PolarDB-X 2.0 instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call this operation. The data is returned in a special format and is complex to parse. You can use the <a href="https://help.aliyun.com/document_detail/470302.html">heatmap</a> feature of Database Autonomy Service (DAS) to query the data.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPartitionsHeatmapRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPartitionsHeatmapResponse
        /// </returns>
        public GetPartitionsHeatmapResponse GetPartitionsHeatmap(GetPartitionsHeatmapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPartitionsHeatmapWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access frequency statistics and hot data on partitions of a PolarDB-X 2.0 instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call this operation. The data is returned in a special format and is complex to parse. You can use the <a href="https://help.aliyun.com/document_detail/470302.html">heatmap</a> feature of Database Autonomy Service (DAS) to query the data.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPartitionsHeatmapRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPartitionsHeatmapResponse
        /// </returns>
        public async Task<GetPartitionsHeatmapResponse> GetPartitionsHeatmapAsync(GetPartitionsHeatmapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPartitionsHeatmapWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the trend of a metric for the new version of the performance insight feature of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.</description></item>
        /// <item><description>The new version of the performance insight feature is enabled for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/469117.html">Performance insight (new version)</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPfsMetricTrendsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPfsMetricTrendsResponse
        /// </returns>
        public GetPfsMetricTrendsResponse GetPfsMetricTrendsWithOptions(GetPfsMetricTrendsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metric))
            {
                body["Metric"] = request.Metric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPfsMetricTrends",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPfsMetricTrendsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the trend of a metric for the new version of the performance insight feature of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.</description></item>
        /// <item><description>The new version of the performance insight feature is enabled for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/469117.html">Performance insight (new version)</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPfsMetricTrendsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPfsMetricTrendsResponse
        /// </returns>
        public async Task<GetPfsMetricTrendsResponse> GetPfsMetricTrendsWithOptionsAsync(GetPfsMetricTrendsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metric))
            {
                body["Metric"] = request.Metric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPfsMetricTrends",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPfsMetricTrendsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the trend of a metric for the new version of the performance insight feature of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.</description></item>
        /// <item><description>The new version of the performance insight feature is enabled for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/469117.html">Performance insight (new version)</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPfsMetricTrendsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPfsMetricTrendsResponse
        /// </returns>
        public GetPfsMetricTrendsResponse GetPfsMetricTrends(GetPfsMetricTrendsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPfsMetricTrendsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the trend of a metric for the new version of the performance insight feature of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.</description></item>
        /// <item><description>The new version of the performance insight feature is enabled for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/469117.html">Performance insight (new version)</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPfsMetricTrendsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPfsMetricTrendsResponse
        /// </returns>
        public async Task<GetPfsMetricTrendsResponse> GetPfsMetricTrendsAsync(GetPfsMetricTrendsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPfsMetricTrendsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the SQL sample data for the new version of the performance insight feature of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.</description></item>
        /// <item><description>The new version of the performance insight feature is enabled for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/469117.html">Performance insight (new version)</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPfsSqlSampleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPfsSqlSampleResponse
        /// </returns>
        public GetPfsSqlSampleResponse GetPfsSqlSampleWithOptions(GetPfsSqlSampleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPfsSqlSample",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPfsSqlSampleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the SQL sample data for the new version of the performance insight feature of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.</description></item>
        /// <item><description>The new version of the performance insight feature is enabled for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/469117.html">Performance insight (new version)</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPfsSqlSampleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPfsSqlSampleResponse
        /// </returns>
        public async Task<GetPfsSqlSampleResponse> GetPfsSqlSampleWithOptionsAsync(GetPfsSqlSampleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPfsSqlSample",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPfsSqlSampleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the SQL sample data for the new version of the performance insight feature of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.</description></item>
        /// <item><description>The new version of the performance insight feature is enabled for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/469117.html">Performance insight (new version)</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPfsSqlSampleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPfsSqlSampleResponse
        /// </returns>
        public GetPfsSqlSampleResponse GetPfsSqlSample(GetPfsSqlSampleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPfsSqlSampleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the SQL sample data for the new version of the performance insight feature of a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.</description></item>
        /// <item><description>The new version of the performance insight feature is enabled for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/469117.html">Performance insight (new version)</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPfsSqlSampleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPfsSqlSampleResponse
        /// </returns>
        public async Task<GetPfsSqlSampleResponse> GetPfsSqlSampleAsync(GetPfsSqlSampleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPfsSqlSampleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the full request data generated by the new version of the performance insight feature of a database instance based on the SQL ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.</description></item>
        /// <item><description>The new version of the performance insight feature is enabled for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/469117.html">Performance insight (new version)</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPfsSqlSummariesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPfsSqlSummariesResponse
        /// </returns>
        public GetPfsSqlSummariesResponse GetPfsSqlSummariesWithOptions(GetPfsSqlSummariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Asc))
            {
                body["Asc"] = request.Asc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                body["Keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPfsSqlSummaries",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPfsSqlSummariesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the full request data generated by the new version of the performance insight feature of a database instance based on the SQL ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.</description></item>
        /// <item><description>The new version of the performance insight feature is enabled for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/469117.html">Performance insight (new version)</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPfsSqlSummariesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPfsSqlSummariesResponse
        /// </returns>
        public async Task<GetPfsSqlSummariesResponse> GetPfsSqlSummariesWithOptionsAsync(GetPfsSqlSummariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Asc))
            {
                body["Asc"] = request.Asc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                body["Keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                body["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPfsSqlSummaries",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPfsSqlSummariesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the full request data generated by the new version of the performance insight feature of a database instance based on the SQL ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.</description></item>
        /// <item><description>The new version of the performance insight feature is enabled for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/469117.html">Performance insight (new version)</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPfsSqlSummariesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPfsSqlSummariesResponse
        /// </returns>
        public GetPfsSqlSummariesResponse GetPfsSqlSummaries(GetPfsSqlSummariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPfsSqlSummariesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the full request data generated by the new version of the performance insight feature of a database instance based on the SQL ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this API operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>An ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster is connected to DAS.</description></item>
        /// <item><description>The new version of the performance insight feature is enabled for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/469117.html">Performance insight (new version)</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPfsSqlSummariesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPfsSqlSummariesResponse
        /// </returns>
        public async Task<GetPfsSqlSummariesResponse> GetPfsSqlSummariesAsync(GetPfsSqlSummariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPfsSqlSummariesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about SQL templates based on query governance data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.</para>
        /// <list type="bullet">
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeDataStatsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeDataStatsResponse
        /// </returns>
        public GetQueryOptimizeDataStatsResponse GetQueryOptimizeDataStatsWithOptions(GetQueryOptimizeDataStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeDataStats",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeDataStatsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about SQL templates based on query governance data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.</para>
        /// <list type="bullet">
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeDataStatsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeDataStatsResponse
        /// </returns>
        public async Task<GetQueryOptimizeDataStatsResponse> GetQueryOptimizeDataStatsWithOptionsAsync(GetQueryOptimizeDataStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeDataStats",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeDataStatsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about SQL templates based on query governance data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.</para>
        /// <list type="bullet">
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeDataStatsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeDataStatsResponse
        /// </returns>
        public GetQueryOptimizeDataStatsResponse GetQueryOptimizeDataStats(GetQueryOptimizeDataStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueryOptimizeDataStatsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about SQL templates based on query governance data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.</para>
        /// <list type="bullet">
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeDataStatsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeDataStatsResponse
        /// </returns>
        public async Task<GetQueryOptimizeDataStatsResponse> GetQueryOptimizeDataStatsAsync(GetQueryOptimizeDataStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueryOptimizeDataStatsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the best-performing and worst-performing instances based on query governance data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.</para>
        /// <list type="bullet">
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeDataTopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeDataTopResponse
        /// </returns>
        public GetQueryOptimizeDataTopResponse GetQueryOptimizeDataTopWithOptions(GetQueryOptimizeDataTopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeDataTop",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeDataTopResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the best-performing and worst-performing instances based on query governance data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.</para>
        /// <list type="bullet">
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeDataTopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeDataTopResponse
        /// </returns>
        public async Task<GetQueryOptimizeDataTopResponse> GetQueryOptimizeDataTopWithOptionsAsync(GetQueryOptimizeDataTopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeDataTop",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeDataTopResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the best-performing and worst-performing instances based on query governance data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.</para>
        /// <list type="bullet">
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeDataTopRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeDataTopResponse
        /// </returns>
        public GetQueryOptimizeDataTopResponse GetQueryOptimizeDataTop(GetQueryOptimizeDataTopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueryOptimizeDataTopWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the best-performing and worst-performing instances based on query governance data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use an Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.</para>
        /// <list type="bullet">
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeDataTopRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeDataTopResponse
        /// </returns>
        public async Task<GetQueryOptimizeDataTopResponse> GetQueryOptimizeDataTopAsync(GetQueryOptimizeDataTopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueryOptimizeDataTopWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries query governance trend data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.</para>
        /// <list type="bullet">
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeDataTrendRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeDataTrendResponse
        /// </returns>
        public GetQueryOptimizeDataTrendResponse GetQueryOptimizeDataTrendWithOptions(GetQueryOptimizeDataTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeDataTrend",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeDataTrendResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries query governance trend data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.</para>
        /// <list type="bullet">
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeDataTrendRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeDataTrendResponse
        /// </returns>
        public async Task<GetQueryOptimizeDataTrendResponse> GetQueryOptimizeDataTrendWithOptionsAsync(GetQueryOptimizeDataTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeDataTrend",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeDataTrendResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries query governance trend data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.</para>
        /// <list type="bullet">
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeDataTrendRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeDataTrendResponse
        /// </returns>
        public GetQueryOptimizeDataTrendResponse GetQueryOptimizeDataTrend(GetQueryOptimizeDataTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueryOptimizeDataTrendWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries query governance trend data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.</para>
        /// <list type="bullet">
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeDataTrendRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeDataTrendResponse
        /// </returns>
        public async Task<GetQueryOptimizeDataTrendResponse> GetQueryOptimizeDataTrendAsync(GetQueryOptimizeDataTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueryOptimizeDataTrendWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the failed SQL statements under a SQL template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.</para>
        /// <list type="bullet">
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeExecErrorSampleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeExecErrorSampleResponse
        /// </returns>
        public GetQueryOptimizeExecErrorSampleResponse GetQueryOptimizeExecErrorSampleWithOptions(GetQueryOptimizeExecErrorSampleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                query["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                query["Time"] = request.Time;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeExecErrorSample",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeExecErrorSampleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the failed SQL statements under a SQL template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.</para>
        /// <list type="bullet">
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeExecErrorSampleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeExecErrorSampleResponse
        /// </returns>
        public async Task<GetQueryOptimizeExecErrorSampleResponse> GetQueryOptimizeExecErrorSampleWithOptionsAsync(GetQueryOptimizeExecErrorSampleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                query["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                query["Time"] = request.Time;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeExecErrorSample",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeExecErrorSampleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the failed SQL statements under a SQL template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.</para>
        /// <list type="bullet">
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeExecErrorSampleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeExecErrorSampleResponse
        /// </returns>
        public GetQueryOptimizeExecErrorSampleResponse GetQueryOptimizeExecErrorSample(GetQueryOptimizeExecErrorSampleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueryOptimizeExecErrorSampleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the failed SQL statements under a SQL template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.</para>
        /// <list type="bullet">
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeExecErrorSampleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeExecErrorSampleResponse
        /// </returns>
        public async Task<GetQueryOptimizeExecErrorSampleResponse> GetQueryOptimizeExecErrorSampleAsync(GetQueryOptimizeExecErrorSampleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueryOptimizeExecErrorSampleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries SQL templates that failed to be executed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeExecErrorStatsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeExecErrorStatsResponse
        /// </returns>
        public GetQueryOptimizeExecErrorStatsResponse GetQueryOptimizeExecErrorStatsWithOptions(GetQueryOptimizeExecErrorStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeExecErrorStats",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeExecErrorStatsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries SQL templates that failed to be executed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeExecErrorStatsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeExecErrorStatsResponse
        /// </returns>
        public async Task<GetQueryOptimizeExecErrorStatsResponse> GetQueryOptimizeExecErrorStatsWithOptionsAsync(GetQueryOptimizeExecErrorStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeExecErrorStats",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeExecErrorStatsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries SQL templates that failed to be executed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeExecErrorStatsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeExecErrorStatsResponse
        /// </returns>
        public GetQueryOptimizeExecErrorStatsResponse GetQueryOptimizeExecErrorStats(GetQueryOptimizeExecErrorStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueryOptimizeExecErrorStatsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries SQL templates that failed to be executed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeExecErrorStatsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeExecErrorStatsResponse
        /// </returns>
        public async Task<GetQueryOptimizeExecErrorStatsResponse> GetQueryOptimizeExecErrorStatsAsync(GetQueryOptimizeExecErrorStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueryOptimizeExecErrorStatsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags added by the query governance feature to specified database instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.</para>
        /// <list type="bullet">
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeRuleListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeRuleListResponse
        /// </returns>
        public GetQueryOptimizeRuleListResponse GetQueryOptimizeRuleListWithOptions(GetQueryOptimizeRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeRuleList",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeRuleListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags added by the query governance feature to specified database instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.</para>
        /// <list type="bullet">
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeRuleListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeRuleListResponse
        /// </returns>
        public async Task<GetQueryOptimizeRuleListResponse> GetQueryOptimizeRuleListWithOptionsAsync(GetQueryOptimizeRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeRuleList",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeRuleListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags added by the query governance feature to specified database instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.</para>
        /// <list type="bullet">
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeRuleListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeRuleListResponse
        /// </returns>
        public GetQueryOptimizeRuleListResponse GetQueryOptimizeRuleList(GetQueryOptimizeRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueryOptimizeRuleListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags added by the query governance feature to specified database instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V2.1.8. We recommend that you use the latest version.</para>
        /// <list type="bullet">
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V2.1.8 or later.</description></item>
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeRuleListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeRuleListResponse
        /// </returns>
        public async Task<GetQueryOptimizeRuleListResponse> GetQueryOptimizeRuleListAsync(GetQueryOptimizeRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueryOptimizeRuleListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a share URL provided by the query governance feature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeShareUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeShareUrlResponse
        /// </returns>
        public GetQueryOptimizeShareUrlResponse GetQueryOptimizeShareUrlWithOptions(GetQueryOptimizeShareUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Asc))
            {
                query["Asc"] = request.Asc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbNames))
            {
                query["DbNames"] = request.DbNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                query["Keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalOperator))
            {
                query["LogicalOperator"] = request.LogicalOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyOptimizedSql))
            {
                query["OnlyOptimizedSql"] = request.OnlyOptimizedSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                query["Rules"] = request.Rules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlIds))
            {
                query["SqlIds"] = request.SqlIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagNames))
            {
                query["TagNames"] = request.TagNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                query["Time"] = request.Time;
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
                Action = "GetQueryOptimizeShareUrl",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeShareUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a share URL provided by the query governance feature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeShareUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeShareUrlResponse
        /// </returns>
        public async Task<GetQueryOptimizeShareUrlResponse> GetQueryOptimizeShareUrlWithOptionsAsync(GetQueryOptimizeShareUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Asc))
            {
                query["Asc"] = request.Asc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbNames))
            {
                query["DbNames"] = request.DbNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                query["Keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogicalOperator))
            {
                query["LogicalOperator"] = request.LogicalOperator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyOptimizedSql))
            {
                query["OnlyOptimizedSql"] = request.OnlyOptimizedSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                query["Rules"] = request.Rules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlIds))
            {
                query["SqlIds"] = request.SqlIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagNames))
            {
                query["TagNames"] = request.TagNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                query["Time"] = request.Time;
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
                Action = "GetQueryOptimizeShareUrl",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeShareUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a share URL provided by the query governance feature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeShareUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeShareUrlResponse
        /// </returns>
        public GetQueryOptimizeShareUrlResponse GetQueryOptimizeShareUrl(GetQueryOptimizeShareUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueryOptimizeShareUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a share URL provided by the query governance feature.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeShareUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeShareUrlResponse
        /// </returns>
        public async Task<GetQueryOptimizeShareUrlResponse> GetQueryOptimizeShareUrlAsync(GetQueryOptimizeShareUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueryOptimizeShareUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries suggestions provided by query governance for optimizing an SQL template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeSolutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeSolutionResponse
        /// </returns>
        public GetQueryOptimizeSolutionResponse GetQueryOptimizeSolutionWithOptions(GetQueryOptimizeSolutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleIds))
            {
                query["RuleIds"] = request.RuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                query["SqlId"] = request.SqlId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeSolution",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeSolutionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries suggestions provided by query governance for optimizing an SQL template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeSolutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeSolutionResponse
        /// </returns>
        public async Task<GetQueryOptimizeSolutionResponse> GetQueryOptimizeSolutionWithOptionsAsync(GetQueryOptimizeSolutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleIds))
            {
                query["RuleIds"] = request.RuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                query["SqlId"] = request.SqlId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeSolution",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeSolutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries suggestions provided by query governance for optimizing an SQL template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeSolutionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeSolutionResponse
        /// </returns>
        public GetQueryOptimizeSolutionResponse GetQueryOptimizeSolution(GetQueryOptimizeSolutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueryOptimizeSolutionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries suggestions provided by query governance for optimizing an SQL template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeSolutionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeSolutionResponse
        /// </returns>
        public async Task<GetQueryOptimizeSolutionResponse> GetQueryOptimizeSolutionAsync(GetQueryOptimizeSolutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueryOptimizeSolutionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags of a SQL statement.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeTagResponse
        /// </returns>
        public GetQueryOptimizeTagResponse GetQueryOptimizeTagWithOptions(GetQueryOptimizeTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                query["SqlId"] = request.SqlId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeTag",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags of a SQL statement.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeTagResponse
        /// </returns>
        public async Task<GetQueryOptimizeTagResponse> GetQueryOptimizeTagWithOptionsAsync(GetQueryOptimizeTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                query["SqlId"] = request.SqlId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryOptimizeTag",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryOptimizeTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags of a SQL statement.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeTagRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeTagResponse
        /// </returns>
        public GetQueryOptimizeTagResponse GetQueryOptimizeTag(GetQueryOptimizeTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueryOptimizeTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags of a SQL statement.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you use Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetQueryOptimizeTagRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueryOptimizeTagResponse
        /// </returns>
        public async Task<GetQueryOptimizeTagResponse> GetQueryOptimizeTagAsync(GetQueryOptimizeTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueryOptimizeTagWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current session on an ApsaraDB for Redis instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB for Redis instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.<remarks>
        /// <para> This operation cannot be used to query sessions generated in direct connection mode on ApsaraDB for Redis cluster instances.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRedisAllSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRedisAllSessionResponse
        /// </returns>
        public GetRedisAllSessionResponse GetRedisAllSessionWithOptions(GetRedisAllSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRedisAllSession",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRedisAllSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current session on an ApsaraDB for Redis instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB for Redis instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.<remarks>
        /// <para> This operation cannot be used to query sessions generated in direct connection mode on ApsaraDB for Redis cluster instances.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRedisAllSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRedisAllSessionResponse
        /// </returns>
        public async Task<GetRedisAllSessionResponse> GetRedisAllSessionWithOptionsAsync(GetRedisAllSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRedisAllSession",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRedisAllSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current session on an ApsaraDB for Redis instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB for Redis instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.<remarks>
        /// <para> This operation cannot be used to query sessions generated in direct connection mode on ApsaraDB for Redis cluster instances.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRedisAllSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRedisAllSessionResponse
        /// </returns>
        public GetRedisAllSessionResponse GetRedisAllSession(GetRedisAllSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRedisAllSessionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current session on an ApsaraDB for Redis instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB for Redis instances.</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.<remarks>
        /// <para> This operation cannot be used to query sessions generated in direct connection mode on ApsaraDB for Redis cluster instances.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRedisAllSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRedisAllSessionResponse
        /// </returns>
        public async Task<GetRedisAllSessionResponse> GetRedisAllSessionAsync(GetRedisAllSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRedisAllSessionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries SQL diagnostics records by pages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// <item><description>ApsaraDB RDS for SQL Server</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>PolarDB for PostgreSQL (Compatible with Oracle)</description></item>
        /// <item><description>ApsaraDB for MongoDB<remarks>
        /// <para> The minor engine version of the Apsara RDS for PostgreSQL instance must be 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see <a href="https://help.aliyun.com/document_detail/146895.html">Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRequestDiagnosisPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRequestDiagnosisPageResponse
        /// </returns>
        public GetRequestDiagnosisPageResponse GetRequestDiagnosisPageWithOptions(GetRequestDiagnosisPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "GetRequestDiagnosisPage",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRequestDiagnosisPageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries SQL diagnostics records by pages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// <item><description>ApsaraDB RDS for SQL Server</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>PolarDB for PostgreSQL (Compatible with Oracle)</description></item>
        /// <item><description>ApsaraDB for MongoDB<remarks>
        /// <para> The minor engine version of the Apsara RDS for PostgreSQL instance must be 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see <a href="https://help.aliyun.com/document_detail/146895.html">Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRequestDiagnosisPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRequestDiagnosisPageResponse
        /// </returns>
        public async Task<GetRequestDiagnosisPageResponse> GetRequestDiagnosisPageWithOptionsAsync(GetRequestDiagnosisPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "GetRequestDiagnosisPage",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRequestDiagnosisPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries SQL diagnostics records by pages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// <item><description>ApsaraDB RDS for SQL Server</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>PolarDB for PostgreSQL (Compatible with Oracle)</description></item>
        /// <item><description>ApsaraDB for MongoDB<remarks>
        /// <para> The minor engine version of the Apsara RDS for PostgreSQL instance must be 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see <a href="https://help.aliyun.com/document_detail/146895.html">Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRequestDiagnosisPageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRequestDiagnosisPageResponse
        /// </returns>
        public GetRequestDiagnosisPageResponse GetRequestDiagnosisPage(GetRequestDiagnosisPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRequestDiagnosisPageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries SQL diagnostics records by pages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL</description></item>
        /// <item><description>ApsaraDB RDS for SQL Server</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>PolarDB for PostgreSQL (Compatible with Oracle)</description></item>
        /// <item><description>ApsaraDB for MongoDB<remarks>
        /// <para> The minor engine version of the Apsara RDS for PostgreSQL instance must be 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see <a href="https://help.aliyun.com/document_detail/146895.html">Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRequestDiagnosisPageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRequestDiagnosisPageResponse
        /// </returns>
        public async Task<GetRequestDiagnosisPageResponse> GetRequestDiagnosisPageAsync(GetRequestDiagnosisPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRequestDiagnosisPageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of an SQL diagnostics task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>You cannot call this operation to query the diagnostic result of the automatic SQL optimization feature.</description></item>
        /// <item><description>This operation is applicable to the following database engines:<list type="bullet">
        /// <item><description>RDS MySQL</description></item>
        /// <item><description>RDS PostgreSQL</description></item>
        /// <item><description>RDS SQL Server</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>PolarDB for PostgreSQL (Compatible with Oracle)</description></item>
        /// <item><description>ApsaraDB for MongoDB<remarks>
        /// <para> If your instance is an ApsaraDB RDS for PostgreSQL instance, make sure that the minor engine version of your instance is 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see <a href="https://help.aliyun.com/document_detail/146895.html">Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRequestDiagnosisResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRequestDiagnosisResultResponse
        /// </returns>
        public GetRequestDiagnosisResultResponse GetRequestDiagnosisResultWithOptions(GetRequestDiagnosisResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                query["SqlId"] = request.SqlId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRequestDiagnosisResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRequestDiagnosisResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of an SQL diagnostics task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>You cannot call this operation to query the diagnostic result of the automatic SQL optimization feature.</description></item>
        /// <item><description>This operation is applicable to the following database engines:<list type="bullet">
        /// <item><description>RDS MySQL</description></item>
        /// <item><description>RDS PostgreSQL</description></item>
        /// <item><description>RDS SQL Server</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>PolarDB for PostgreSQL (Compatible with Oracle)</description></item>
        /// <item><description>ApsaraDB for MongoDB<remarks>
        /// <para> If your instance is an ApsaraDB RDS for PostgreSQL instance, make sure that the minor engine version of your instance is 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see <a href="https://help.aliyun.com/document_detail/146895.html">Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRequestDiagnosisResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRequestDiagnosisResultResponse
        /// </returns>
        public async Task<GetRequestDiagnosisResultResponse> GetRequestDiagnosisResultWithOptionsAsync(GetRequestDiagnosisResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                query["SqlId"] = request.SqlId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRequestDiagnosisResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRequestDiagnosisResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of an SQL diagnostics task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>You cannot call this operation to query the diagnostic result of the automatic SQL optimization feature.</description></item>
        /// <item><description>This operation is applicable to the following database engines:<list type="bullet">
        /// <item><description>RDS MySQL</description></item>
        /// <item><description>RDS PostgreSQL</description></item>
        /// <item><description>RDS SQL Server</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>PolarDB for PostgreSQL (Compatible with Oracle)</description></item>
        /// <item><description>ApsaraDB for MongoDB<remarks>
        /// <para> If your instance is an ApsaraDB RDS for PostgreSQL instance, make sure that the minor engine version of your instance is 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see <a href="https://help.aliyun.com/document_detail/146895.html">Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRequestDiagnosisResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRequestDiagnosisResultResponse
        /// </returns>
        public GetRequestDiagnosisResultResponse GetRequestDiagnosisResult(GetRequestDiagnosisResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRequestDiagnosisResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of an SQL diagnostics task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>You cannot call this operation to query the diagnostic result of the automatic SQL optimization feature.</description></item>
        /// <item><description>This operation is applicable to the following database engines:<list type="bullet">
        /// <item><description>RDS MySQL</description></item>
        /// <item><description>RDS PostgreSQL</description></item>
        /// <item><description>RDS SQL Server</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// <item><description>PolarDB for PostgreSQL (Compatible with Oracle)</description></item>
        /// <item><description>ApsaraDB for MongoDB<remarks>
        /// <para> If your instance is an ApsaraDB RDS for PostgreSQL instance, make sure that the minor engine version of your instance is 20220130 or later. For more information about how to check and update the minor engine version of an ApsaraDB RDS for PostgreSQL instance, see <a href="https://help.aliyun.com/document_detail/146895.html">Update the minor engine version of an ApsaraDB RDS for PostgreSQL instance</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRequestDiagnosisResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRequestDiagnosisResultResponse
        /// </returns>
        public async Task<GetRequestDiagnosisResultResponse> GetRequestDiagnosisResultAsync(GetRequestDiagnosisResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRequestDiagnosisResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the throttling rules that are in effect.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRunningSqlConcurrencyControlRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRunningSqlConcurrencyControlRulesResponse
        /// </returns>
        public GetRunningSqlConcurrencyControlRulesResponse GetRunningSqlConcurrencyControlRulesWithOptions(GetRunningSqlConcurrencyControlRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Action = "GetRunningSqlConcurrencyControlRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRunningSqlConcurrencyControlRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the throttling rules that are in effect.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRunningSqlConcurrencyControlRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRunningSqlConcurrencyControlRulesResponse
        /// </returns>
        public async Task<GetRunningSqlConcurrencyControlRulesResponse> GetRunningSqlConcurrencyControlRulesWithOptionsAsync(GetRunningSqlConcurrencyControlRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Action = "GetRunningSqlConcurrencyControlRules",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRunningSqlConcurrencyControlRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the throttling rules that are in effect.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRunningSqlConcurrencyControlRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRunningSqlConcurrencyControlRulesResponse
        /// </returns>
        public GetRunningSqlConcurrencyControlRulesResponse GetRunningSqlConcurrencyControlRules(GetRunningSqlConcurrencyControlRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRunningSqlConcurrencyControlRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the throttling rules that are in effect.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRunningSqlConcurrencyControlRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRunningSqlConcurrencyControlRulesResponse
        /// </returns>
        public async Task<GetRunningSqlConcurrencyControlRulesResponse> GetRunningSqlConcurrencyControlRulesAsync(GetRunningSqlConcurrencyControlRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRunningSqlConcurrencyControlRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a throttling keyword string based on an SQL statement.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlConcurrencyControlKeywordsFromSqlTextRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSqlConcurrencyControlKeywordsFromSqlTextResponse
        /// </returns>
        public GetSqlConcurrencyControlKeywordsFromSqlTextResponse GetSqlConcurrencyControlKeywordsFromSqlTextWithOptions(GetSqlConcurrencyControlKeywordsFromSqlTextRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlText))
            {
                query["SqlText"] = request.SqlText;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSqlConcurrencyControlKeywordsFromSqlText",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlConcurrencyControlKeywordsFromSqlTextResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a throttling keyword string based on an SQL statement.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlConcurrencyControlKeywordsFromSqlTextRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSqlConcurrencyControlKeywordsFromSqlTextResponse
        /// </returns>
        public async Task<GetSqlConcurrencyControlKeywordsFromSqlTextResponse> GetSqlConcurrencyControlKeywordsFromSqlTextWithOptionsAsync(GetSqlConcurrencyControlKeywordsFromSqlTextRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlText))
            {
                query["SqlText"] = request.SqlText;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSqlConcurrencyControlKeywordsFromSqlText",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlConcurrencyControlKeywordsFromSqlTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a throttling keyword string based on an SQL statement.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlConcurrencyControlKeywordsFromSqlTextRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSqlConcurrencyControlKeywordsFromSqlTextResponse
        /// </returns>
        public GetSqlConcurrencyControlKeywordsFromSqlTextResponse GetSqlConcurrencyControlKeywordsFromSqlText(GetSqlConcurrencyControlKeywordsFromSqlTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSqlConcurrencyControlKeywordsFromSqlTextWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a throttling keyword string based on an SQL statement.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlConcurrencyControlKeywordsFromSqlTextRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSqlConcurrencyControlKeywordsFromSqlTextResponse
        /// </returns>
        public async Task<GetSqlConcurrencyControlKeywordsFromSqlTextResponse> GetSqlConcurrencyControlKeywordsFromSqlTextAsync(GetSqlConcurrencyControlKeywordsFromSqlTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSqlConcurrencyControlKeywordsFromSqlTextWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the throttling rules that are being executed or have been triggered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlConcurrencyControlRulesHistoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSqlConcurrencyControlRulesHistoryResponse
        /// </returns>
        public GetSqlConcurrencyControlRulesHistoryResponse GetSqlConcurrencyControlRulesHistoryWithOptions(GetSqlConcurrencyControlRulesHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Action = "GetSqlConcurrencyControlRulesHistory",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlConcurrencyControlRulesHistoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the throttling rules that are being executed or have been triggered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlConcurrencyControlRulesHistoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSqlConcurrencyControlRulesHistoryResponse
        /// </returns>
        public async Task<GetSqlConcurrencyControlRulesHistoryResponse> GetSqlConcurrencyControlRulesHistoryWithOptionsAsync(GetSqlConcurrencyControlRulesHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Action = "GetSqlConcurrencyControlRulesHistory",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlConcurrencyControlRulesHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the throttling rules that are being executed or have been triggered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlConcurrencyControlRulesHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSqlConcurrencyControlRulesHistoryResponse
        /// </returns>
        public GetSqlConcurrencyControlRulesHistoryResponse GetSqlConcurrencyControlRulesHistory(GetSqlConcurrencyControlRulesHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSqlConcurrencyControlRulesHistoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the throttling rules that are being executed or have been triggered.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports the following database engines:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL</description></item>
        /// <item><description>PolarDB for MySQL</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlConcurrencyControlRulesHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSqlConcurrencyControlRulesHistoryResponse
        /// </returns>
        public async Task<GetSqlConcurrencyControlRulesHistoryResponse> GetSqlConcurrencyControlRulesHistoryAsync(GetSqlConcurrencyControlRulesHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSqlConcurrencyControlRulesHistoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries optimization suggestions that are generated by the SQL diagnostics feature of Database Autonomy Service (DAS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The SQL diagnostics feature provides optimization suggestions for instances based on diagnostics results. You can use the optimization suggestions to optimize instance indexes. For more information, see <a href="https://help.aliyun.com/document_detail/167895.html">Automatic SQL optimization</a>.</para>
        /// <remarks>
        /// <para> You can call this operation to query only the optimization suggestions that are automatically generated by the SQL diagnostics feature.
        /// Before you call this operation, take note of the following items:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This operation is applicable to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</description></item>
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlOptimizeAdviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSqlOptimizeAdviceResponse
        /// </returns>
        public GetSqlOptimizeAdviceResponse GetSqlOptimizeAdviceWithOptions(GetSqlOptimizeAdviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDt))
            {
                query["EndDt"] = request.EndDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDt))
            {
                query["StartDt"] = request.StartDt;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSqlOptimizeAdvice",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlOptimizeAdviceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries optimization suggestions that are generated by the SQL diagnostics feature of Database Autonomy Service (DAS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The SQL diagnostics feature provides optimization suggestions for instances based on diagnostics results. You can use the optimization suggestions to optimize instance indexes. For more information, see <a href="https://help.aliyun.com/document_detail/167895.html">Automatic SQL optimization</a>.</para>
        /// <remarks>
        /// <para> You can call this operation to query only the optimization suggestions that are automatically generated by the SQL diagnostics feature.
        /// Before you call this operation, take note of the following items:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This operation is applicable to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</description></item>
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlOptimizeAdviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSqlOptimizeAdviceResponse
        /// </returns>
        public async Task<GetSqlOptimizeAdviceResponse> GetSqlOptimizeAdviceWithOptionsAsync(GetSqlOptimizeAdviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDt))
            {
                query["EndDt"] = request.EndDt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Engine))
            {
                query["Engine"] = request.Engine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDt))
            {
                query["StartDt"] = request.StartDt;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSqlOptimizeAdvice",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSqlOptimizeAdviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries optimization suggestions that are generated by the SQL diagnostics feature of Database Autonomy Service (DAS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The SQL diagnostics feature provides optimization suggestions for instances based on diagnostics results. You can use the optimization suggestions to optimize instance indexes. For more information, see <a href="https://help.aliyun.com/document_detail/167895.html">Automatic SQL optimization</a>.</para>
        /// <remarks>
        /// <para> You can call this operation to query only the optimization suggestions that are automatically generated by the SQL diagnostics feature.
        /// Before you call this operation, take note of the following items:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This operation is applicable to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</description></item>
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlOptimizeAdviceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSqlOptimizeAdviceResponse
        /// </returns>
        public GetSqlOptimizeAdviceResponse GetSqlOptimizeAdvice(GetSqlOptimizeAdviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSqlOptimizeAdviceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries optimization suggestions that are generated by the SQL diagnostics feature of Database Autonomy Service (DAS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The SQL diagnostics feature provides optimization suggestions for instances based on diagnostics results. You can use the optimization suggestions to optimize instance indexes. For more information, see <a href="https://help.aliyun.com/document_detail/167895.html">Automatic SQL optimization</a>.</para>
        /// <remarks>
        /// <para> You can call this operation to query only the optimization suggestions that are automatically generated by the SQL diagnostics feature.
        /// Before you call this operation, take note of the following items:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This operation is applicable to ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters.</description></item>
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSqlOptimizeAdviceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSqlOptimizeAdviceResponse
        /// </returns>
        public async Task<GetSqlOptimizeAdviceResponse> GetSqlOptimizeAdviceAsync(GetSqlOptimizeAdviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSqlOptimizeAdviceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and results of a storage analysis task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> The physical file size indicates the actual size of an obtained file. Only specific deployment modes of database instances support the display of physical file sizes. The statistics on tables are obtained from <c>information_schema.tables</c>. Statistics in MySQL are not updated in real time. Therefore, the statistics may be different from the physical file sizes. If you want to obtain the latest data, you can execute the <c>ANALYZE TABLE</c> statement on the relevant tables during off-peak hours.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This operation is applicable only to ApsaraDB RDS for MySQL instances, PolarDB for MySQL clusters, and ApsaraDB for MongoDB instances.</description></item>
        /// <item><description>For ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters, this operation works the same as the storage analysis feature of the previous version. Tasks generated by this operation cannot be viewed on the Storage Analysis page of the new version in the Database Autonomy Service (DAS) console. If you want to view the tasks and results, call the related API operation to obtain data and save data to your computer.</description></item>
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStorageAnalysisResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStorageAnalysisResultResponse
        /// </returns>
        public GetStorageAnalysisResultResponse GetStorageAnalysisResultWithOptions(GetStorageAnalysisResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
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
                Action = "GetStorageAnalysisResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStorageAnalysisResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and results of a storage analysis task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> The physical file size indicates the actual size of an obtained file. Only specific deployment modes of database instances support the display of physical file sizes. The statistics on tables are obtained from <c>information_schema.tables</c>. Statistics in MySQL are not updated in real time. Therefore, the statistics may be different from the physical file sizes. If you want to obtain the latest data, you can execute the <c>ANALYZE TABLE</c> statement on the relevant tables during off-peak hours.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This operation is applicable only to ApsaraDB RDS for MySQL instances, PolarDB for MySQL clusters, and ApsaraDB for MongoDB instances.</description></item>
        /// <item><description>For ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters, this operation works the same as the storage analysis feature of the previous version. Tasks generated by this operation cannot be viewed on the Storage Analysis page of the new version in the Database Autonomy Service (DAS) console. If you want to view the tasks and results, call the related API operation to obtain data and save data to your computer.</description></item>
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStorageAnalysisResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStorageAnalysisResultResponse
        /// </returns>
        public async Task<GetStorageAnalysisResultResponse> GetStorageAnalysisResultWithOptionsAsync(GetStorageAnalysisResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
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
                Action = "GetStorageAnalysisResult",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStorageAnalysisResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and results of a storage analysis task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> The physical file size indicates the actual size of an obtained file. Only specific deployment modes of database instances support the display of physical file sizes. The statistics on tables are obtained from <c>information_schema.tables</c>. Statistics in MySQL are not updated in real time. Therefore, the statistics may be different from the physical file sizes. If you want to obtain the latest data, you can execute the <c>ANALYZE TABLE</c> statement on the relevant tables during off-peak hours.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This operation is applicable only to ApsaraDB RDS for MySQL instances, PolarDB for MySQL clusters, and ApsaraDB for MongoDB instances.</description></item>
        /// <item><description>For ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters, this operation works the same as the storage analysis feature of the previous version. Tasks generated by this operation cannot be viewed on the Storage Analysis page of the new version in the Database Autonomy Service (DAS) console. If you want to view the tasks and results, call the related API operation to obtain data and save data to your computer.</description></item>
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStorageAnalysisResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStorageAnalysisResultResponse
        /// </returns>
        public GetStorageAnalysisResultResponse GetStorageAnalysisResult(GetStorageAnalysisResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStorageAnalysisResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status and results of a storage analysis task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> The physical file size indicates the actual size of an obtained file. Only specific deployment modes of database instances support the display of physical file sizes. The statistics on tables are obtained from <c>information_schema.tables</c>. Statistics in MySQL are not updated in real time. Therefore, the statistics may be different from the physical file sizes. If you want to obtain the latest data, you can execute the <c>ANALYZE TABLE</c> statement on the relevant tables during off-peak hours.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This operation is applicable only to ApsaraDB RDS for MySQL instances, PolarDB for MySQL clusters, and ApsaraDB for MongoDB instances.</description></item>
        /// <item><description>For ApsaraDB RDS for MySQL instances and PolarDB for MySQL clusters, this operation works the same as the storage analysis feature of the previous version. Tasks generated by this operation cannot be viewed on the Storage Analysis page of the new version in the Database Autonomy Service (DAS) console. If you want to view the tasks and results, call the related API operation to obtain data and save data to your computer.</description></item>
        /// <item><description>If you use an Alibaba Cloud SDK or DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetStorageAnalysisResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStorageAnalysisResultResponse
        /// </returns>
        public async Task<GetStorageAnalysisResultResponse> GetStorageAnalysisResultAsync(GetStorageAnalysisResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStorageAnalysisResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminates all sessions on an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB for Redis.</para>
        /// <list type="bullet">
        /// <item><description>If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V1.0.2 or later.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// KillInstanceAllSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// KillInstanceAllSessionResponse
        /// </returns>
        public KillInstanceAllSessionResponse KillInstanceAllSessionWithOptions(KillInstanceAllSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillInstanceAllSession",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KillInstanceAllSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminates all sessions on an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB for Redis.</para>
        /// <list type="bullet">
        /// <item><description>If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V1.0.2 or later.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// KillInstanceAllSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// KillInstanceAllSessionResponse
        /// </returns>
        public async Task<KillInstanceAllSessionResponse> KillInstanceAllSessionWithOptionsAsync(KillInstanceAllSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillInstanceAllSession",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KillInstanceAllSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminates all sessions on an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB for Redis.</para>
        /// <list type="bullet">
        /// <item><description>If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V1.0.2 or later.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// KillInstanceAllSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// KillInstanceAllSessionResponse
        /// </returns>
        public KillInstanceAllSessionResponse KillInstanceAllSession(KillInstanceAllSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return KillInstanceAllSessionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminates all sessions on an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation is applicable only to ApsaraDB for Redis.</para>
        /// <list type="bullet">
        /// <item><description>If you use Alibaba Cloud SDK, make sure that the aliyun-sdk-core version is later than V4.3.3. We recommend that you use the latest version.</description></item>
        /// <item><description>The version of your Database Autonomy Service (DAS) SDK must be V1.0.2 or later.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// KillInstanceAllSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// KillInstanceAllSessionResponse
        /// </returns>
        public async Task<KillInstanceAllSessionResponse> KillInstanceAllSessionAsync(KillInstanceAllSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await KillInstanceAllSessionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the auto scaling configurations of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the following auto scaling configurations of an instance: <b>auto scaling for specifications</b>, <b>automatic storage expansion</b>, <b>automatic bandwidth adjustment</b>, and <b>auto scaling for resources</b>.</para>
        /// <list type="bullet">
        /// <item><description>You can modify the configurations of the <b>auto scaling feature for specifications</b> for the following types of database instances:<list type="bullet">
        /// <item><description>PolarDB for MySQL Cluster Edition instances. For more information about the feature and the billing rules, see <a href="https://help.aliyun.com/document_detail/169686.html">Automatic performance scaling</a>.</description></item>
        /// <item><description>ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or enhanced SSDs (ESSDs). For more information about the feature and the billing rules, see <a href="https://help.aliyun.com/document_detail/169686.html">Automatic performance scaling</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can modify the configurations of the <b>automatic storage expansion</b> feature for the following types of database instances:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or ESSDs. For more information about the feature and the billing rules, see <a href="https://help.aliyun.com/document_detail/173345.html">Automatic space expansion</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can modify the configurations of the <b>automatic bandwidth adjustment</b> feature for the following types of database instances:<list type="bullet">
        /// <item><description>ApsaraDB for Redis Classic (Local Disk-based) Edition instances. For more information about the feature and the billing rules, see <a href="https://help.aliyun.com/document_detail/216312.html">Automatic bandwidth adjustment</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can modify the configurations of the <b>auto scaling feature for resources</b> for the following types of database instances:<list type="bullet">
        /// <item><description>General-purpose ApsaraDB RDS for MySQL Enterprise Edition instances. For more information about the feature and the billing rules, see <a href="https://help.aliyun.com/document_detail/169686.html">Automatic performance scaling</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAutoScalingConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAutoScalingConfigResponse
        /// </returns>
        public ModifyAutoScalingConfigResponse ModifyAutoScalingConfigWithOptions(ModifyAutoScalingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shard))
            {
                query["Shard"] = request.Shard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spec))
            {
                query["Spec"] = request.Spec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Storage))
            {
                query["Storage"] = request.Storage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAutoScalingConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAutoScalingConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the auto scaling configurations of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the following auto scaling configurations of an instance: <b>auto scaling for specifications</b>, <b>automatic storage expansion</b>, <b>automatic bandwidth adjustment</b>, and <b>auto scaling for resources</b>.</para>
        /// <list type="bullet">
        /// <item><description>You can modify the configurations of the <b>auto scaling feature for specifications</b> for the following types of database instances:<list type="bullet">
        /// <item><description>PolarDB for MySQL Cluster Edition instances. For more information about the feature and the billing rules, see <a href="https://help.aliyun.com/document_detail/169686.html">Automatic performance scaling</a>.</description></item>
        /// <item><description>ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or enhanced SSDs (ESSDs). For more information about the feature and the billing rules, see <a href="https://help.aliyun.com/document_detail/169686.html">Automatic performance scaling</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can modify the configurations of the <b>automatic storage expansion</b> feature for the following types of database instances:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or ESSDs. For more information about the feature and the billing rules, see <a href="https://help.aliyun.com/document_detail/173345.html">Automatic space expansion</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can modify the configurations of the <b>automatic bandwidth adjustment</b> feature for the following types of database instances:<list type="bullet">
        /// <item><description>ApsaraDB for Redis Classic (Local Disk-based) Edition instances. For more information about the feature and the billing rules, see <a href="https://help.aliyun.com/document_detail/216312.html">Automatic bandwidth adjustment</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can modify the configurations of the <b>auto scaling feature for resources</b> for the following types of database instances:<list type="bullet">
        /// <item><description>General-purpose ApsaraDB RDS for MySQL Enterprise Edition instances. For more information about the feature and the billing rules, see <a href="https://help.aliyun.com/document_detail/169686.html">Automatic performance scaling</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAutoScalingConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAutoScalingConfigResponse
        /// </returns>
        public async Task<ModifyAutoScalingConfigResponse> ModifyAutoScalingConfigWithOptionsAsync(ModifyAutoScalingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shard))
            {
                query["Shard"] = request.Shard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spec))
            {
                query["Spec"] = request.Spec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Storage))
            {
                query["Storage"] = request.Storage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAutoScalingConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAutoScalingConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the auto scaling configurations of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the following auto scaling configurations of an instance: <b>auto scaling for specifications</b>, <b>automatic storage expansion</b>, <b>automatic bandwidth adjustment</b>, and <b>auto scaling for resources</b>.</para>
        /// <list type="bullet">
        /// <item><description>You can modify the configurations of the <b>auto scaling feature for specifications</b> for the following types of database instances:<list type="bullet">
        /// <item><description>PolarDB for MySQL Cluster Edition instances. For more information about the feature and the billing rules, see <a href="https://help.aliyun.com/document_detail/169686.html">Automatic performance scaling</a>.</description></item>
        /// <item><description>ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or enhanced SSDs (ESSDs). For more information about the feature and the billing rules, see <a href="https://help.aliyun.com/document_detail/169686.html">Automatic performance scaling</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can modify the configurations of the <b>automatic storage expansion</b> feature for the following types of database instances:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or ESSDs. For more information about the feature and the billing rules, see <a href="https://help.aliyun.com/document_detail/173345.html">Automatic space expansion</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can modify the configurations of the <b>automatic bandwidth adjustment</b> feature for the following types of database instances:<list type="bullet">
        /// <item><description>ApsaraDB for Redis Classic (Local Disk-based) Edition instances. For more information about the feature and the billing rules, see <a href="https://help.aliyun.com/document_detail/216312.html">Automatic bandwidth adjustment</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can modify the configurations of the <b>auto scaling feature for resources</b> for the following types of database instances:<list type="bullet">
        /// <item><description>General-purpose ApsaraDB RDS for MySQL Enterprise Edition instances. For more information about the feature and the billing rules, see <a href="https://help.aliyun.com/document_detail/169686.html">Automatic performance scaling</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAutoScalingConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAutoScalingConfigResponse
        /// </returns>
        public ModifyAutoScalingConfigResponse ModifyAutoScalingConfig(ModifyAutoScalingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAutoScalingConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the auto scaling configurations of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the following auto scaling configurations of an instance: <b>auto scaling for specifications</b>, <b>automatic storage expansion</b>, <b>automatic bandwidth adjustment</b>, and <b>auto scaling for resources</b>.</para>
        /// <list type="bullet">
        /// <item><description>You can modify the configurations of the <b>auto scaling feature for specifications</b> for the following types of database instances:<list type="bullet">
        /// <item><description>PolarDB for MySQL Cluster Edition instances. For more information about the feature and the billing rules, see <a href="https://help.aliyun.com/document_detail/169686.html">Automatic performance scaling</a>.</description></item>
        /// <item><description>ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or enhanced SSDs (ESSDs). For more information about the feature and the billing rules, see <a href="https://help.aliyun.com/document_detail/169686.html">Automatic performance scaling</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can modify the configurations of the <b>automatic storage expansion</b> feature for the following types of database instances:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL High-availability Edition instances that use standard SSDs or ESSDs. For more information about the feature and the billing rules, see <a href="https://help.aliyun.com/document_detail/173345.html">Automatic space expansion</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can modify the configurations of the <b>automatic bandwidth adjustment</b> feature for the following types of database instances:<list type="bullet">
        /// <item><description>ApsaraDB for Redis Classic (Local Disk-based) Edition instances. For more information about the feature and the billing rules, see <a href="https://help.aliyun.com/document_detail/216312.html">Automatic bandwidth adjustment</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You can modify the configurations of the <b>auto scaling feature for resources</b> for the following types of database instances:<list type="bullet">
        /// <item><description>General-purpose ApsaraDB RDS for MySQL Enterprise Edition instances. For more information about the feature and the billing rules, see <a href="https://help.aliyun.com/document_detail/169686.html">Automatic performance scaling</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If you use an Alibaba Cloud SDK or Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAutoScalingConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAutoScalingConfigResponse
        /// </returns>
        public async Task<ModifyAutoScalingConfigResponse> ModifyAutoScalingConfigAsync(ModifyAutoScalingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAutoScalingConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or configures Database Autonomy Service (DAS) Enterprise Edition for a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>By default, the latest version of DAS Enterprise Edition that supports the database instance is enabled. For information about the databases and regions that are supported by different versions of DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/156204.html">Editions and supported features</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifySqlLogConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySqlLogConfigResponse
        /// </returns>
        public ModifySqlLogConfigResponse ModifySqlLogConfigWithOptions(ModifySqlLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAudit))
            {
                query["EnableAudit"] = request.EnableAudit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotRetention))
            {
                body["HotRetention"] = request.HotRetention;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestEnable))
            {
                body["RequestEnable"] = request.RequestEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Retention))
            {
                body["Retention"] = request.Retention;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySqlLogConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySqlLogConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or configures Database Autonomy Service (DAS) Enterprise Edition for a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>By default, the latest version of DAS Enterprise Edition that supports the database instance is enabled. For information about the databases and regions that are supported by different versions of DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/156204.html">Editions and supported features</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifySqlLogConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySqlLogConfigResponse
        /// </returns>
        public async Task<ModifySqlLogConfigResponse> ModifySqlLogConfigWithOptionsAsync(ModifySqlLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAudit))
            {
                query["EnableAudit"] = request.EnableAudit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotRetention))
            {
                body["HotRetention"] = request.HotRetention;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestEnable))
            {
                body["RequestEnable"] = request.RequestEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Retention))
            {
                body["Retention"] = request.Retention;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySqlLogConfig",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySqlLogConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or configures Database Autonomy Service (DAS) Enterprise Edition for a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>By default, the latest version of DAS Enterprise Edition that supports the database instance is enabled. For information about the databases and regions that are supported by different versions of DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/156204.html">Editions and supported features</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifySqlLogConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySqlLogConfigResponse
        /// </returns>
        public ModifySqlLogConfigResponse ModifySqlLogConfig(ModifySqlLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySqlLogConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or configures Database Autonomy Service (DAS) Enterprise Edition for a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a DAS SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>By default, the latest version of DAS Enterprise Edition that supports the database instance is enabled. For information about the databases and regions that are supported by different versions of DAS Enterprise Edition, see <a href="https://help.aliyun.com/document_detail/156204.html">Editions and supported features</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifySqlLogConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySqlLogConfigResponse
        /// </returns>
        public async Task<ModifySqlLogConfigResponse> ModifySqlLogConfigAsync(ModifySqlLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySqlLogConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs a stress testing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RunCloudBenchTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCloudBenchTaskResponse
        /// </returns>
        public RunCloudBenchTaskResponse RunCloudBenchTaskWithOptions(RunCloudBenchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "RunCloudBenchTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCloudBenchTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs a stress testing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RunCloudBenchTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCloudBenchTaskResponse
        /// </returns>
        public async Task<RunCloudBenchTaskResponse> RunCloudBenchTaskWithOptionsAsync(RunCloudBenchTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "RunCloudBenchTask",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCloudBenchTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs a stress testing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RunCloudBenchTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCloudBenchTaskResponse
        /// </returns>
        public RunCloudBenchTaskResponse RunCloudBenchTask(RunCloudBenchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunCloudBenchTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs a stress testing task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Database Autonomy Service (DAS) provides the intelligent stress testing feature. This feature helps you check whether your instance needs to be scaled up to effectively handle traffic spikes. For more information, see <a href="https://help.aliyun.com/document_detail/155068.html">Intelligent stress testing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RunCloudBenchTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCloudBenchTaskResponse
        /// </returns>
        public async Task<RunCloudBenchTaskResponse> RunCloudBenchTaskAsync(RunCloudBenchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunCloudBenchTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the event subscription settings for a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>Make sure that the database instance that you want to manage is connected to DAS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetEventSubscriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetEventSubscriptionResponse
        /// </returns>
        public SetEventSubscriptionResponse SetEventSubscriptionWithOptions(SetEventSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                query["Active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                query["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroupName))
            {
                query["ContactGroupName"] = request.ContactGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatchRule))
            {
                query["DispatchRule"] = request.DispatchRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventContext))
            {
                query["EventContext"] = request.EventContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinInterval))
            {
                query["MinInterval"] = request.MinInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Severity))
            {
                query["Severity"] = request.Severity;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetEventSubscription",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetEventSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the event subscription settings for a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>Make sure that the database instance that you want to manage is connected to DAS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetEventSubscriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetEventSubscriptionResponse
        /// </returns>
        public async Task<SetEventSubscriptionResponse> SetEventSubscriptionWithOptionsAsync(SetEventSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                query["Active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                query["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroupName))
            {
                query["ContactGroupName"] = request.ContactGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatchRule))
            {
                query["DispatchRule"] = request.DispatchRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventContext))
            {
                query["EventContext"] = request.EventContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinInterval))
            {
                query["MinInterval"] = request.MinInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Severity))
            {
                query["Severity"] = request.Severity;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetEventSubscription",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetEventSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the event subscription settings for a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>Make sure that the database instance that you want to manage is connected to DAS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetEventSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// SetEventSubscriptionResponse
        /// </returns>
        public SetEventSubscriptionResponse SetEventSubscription(SetEventSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetEventSubscriptionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Configures the event subscription settings for a database instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud SDK or a Database Autonomy Service (DAS) SDK to call this operation, we recommend that you use the latest version of the SDK.</description></item>
        /// <item><description>If you use an SDK to call the API operations of DAS, you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>Make sure that the database instance that you want to manage is connected to DAS.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetEventSubscriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// SetEventSubscriptionResponse
        /// </returns>
        public async Task<SetEventSubscriptionResponse> SetEventSubscriptionAsync(SetEventSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetEventSubscriptionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously configures parameters related to the automatic fragment recycling feature for multiple database instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> Asynchronous calls do not immediately return the complete results. To obtain the complete results, you must use the value of <b>ResultId</b> returned in the response to re-initiate the call until the value of <b>isFinish</b> is <b>true</b>.**** In this case, you must call this operation at least twice.
        /// Before you call this operation, take note of the following items:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database instances must be an ApsaraDB RDS for MySQL High-availability Edition instance.</description></item>
        /// <item><description>DAS Enterprise Edition must be enabled for the database instance. You can call the call <a href="https://help.aliyun.com/document_detail/413866.html">DescribeInstanceDasPro</a> operation to query whether DAS Enterprise Edition is enabled.</description></item>
        /// <item><description>The database instance has four or more CPU cores, and <b>innodb_file_per_table</b> is set to <b>ON</b>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAutoResourceOptimizeRulesAsyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAutoResourceOptimizeRulesAsyncResponse
        /// </returns>
        public UpdateAutoResourceOptimizeRulesAsyncResponse UpdateAutoResourceOptimizeRulesAsyncWithOptions(UpdateAutoResourceOptimizeRulesAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultId))
            {
                query["ResultId"] = request.ResultId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableFragmentationRatio))
            {
                query["TableFragmentationRatio"] = request.TableFragmentationRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableSpaceSize))
            {
                query["TableSpaceSize"] = request.TableSpaceSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAutoResourceOptimizeRulesAsync",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAutoResourceOptimizeRulesAsyncResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously configures parameters related to the automatic fragment recycling feature for multiple database instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> Asynchronous calls do not immediately return the complete results. To obtain the complete results, you must use the value of <b>ResultId</b> returned in the response to re-initiate the call until the value of <b>isFinish</b> is <b>true</b>.**** In this case, you must call this operation at least twice.
        /// Before you call this operation, take note of the following items:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database instances must be an ApsaraDB RDS for MySQL High-availability Edition instance.</description></item>
        /// <item><description>DAS Enterprise Edition must be enabled for the database instance. You can call the call <a href="https://help.aliyun.com/document_detail/413866.html">DescribeInstanceDasPro</a> operation to query whether DAS Enterprise Edition is enabled.</description></item>
        /// <item><description>The database instance has four or more CPU cores, and <b>innodb_file_per_table</b> is set to <b>ON</b>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAutoResourceOptimizeRulesAsyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAutoResourceOptimizeRulesAsyncResponse
        /// </returns>
        public async Task<UpdateAutoResourceOptimizeRulesAsyncResponse> UpdateAutoResourceOptimizeRulesAsyncWithOptionsAsync(UpdateAutoResourceOptimizeRulesAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultId))
            {
                query["ResultId"] = request.ResultId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableFragmentationRatio))
            {
                query["TableFragmentationRatio"] = request.TableFragmentationRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableSpaceSize))
            {
                query["TableSpaceSize"] = request.TableSpaceSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAutoResourceOptimizeRulesAsync",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAutoResourceOptimizeRulesAsyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously configures parameters related to the automatic fragment recycling feature for multiple database instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> Asynchronous calls do not immediately return the complete results. To obtain the complete results, you must use the value of <b>ResultId</b> returned in the response to re-initiate the call until the value of <b>isFinish</b> is <b>true</b>.**** In this case, you must call this operation at least twice.
        /// Before you call this operation, take note of the following items:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database instances must be an ApsaraDB RDS for MySQL High-availability Edition instance.</description></item>
        /// <item><description>DAS Enterprise Edition must be enabled for the database instance. You can call the call <a href="https://help.aliyun.com/document_detail/413866.html">DescribeInstanceDasPro</a> operation to query whether DAS Enterprise Edition is enabled.</description></item>
        /// <item><description>The database instance has four or more CPU cores, and <b>innodb_file_per_table</b> is set to <b>ON</b>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAutoResourceOptimizeRulesAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAutoResourceOptimizeRulesAsyncResponse
        /// </returns>
        public UpdateAutoResourceOptimizeRulesAsyncResponse UpdateAutoResourceOptimizeRulesAsync(UpdateAutoResourceOptimizeRulesAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAutoResourceOptimizeRulesAsyncWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously configures parameters related to the automatic fragment recycling feature for multiple database instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> Asynchronous calls do not immediately return the complete results. To obtain the complete results, you must use the value of <b>ResultId</b> returned in the response to re-initiate the call until the value of <b>isFinish</b> is <b>true</b>.**** In this case, you must call this operation at least twice.
        /// Before you call this operation, take note of the following items:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call the API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The database instances must be an ApsaraDB RDS for MySQL High-availability Edition instance.</description></item>
        /// <item><description>DAS Enterprise Edition must be enabled for the database instance. You can call the call <a href="https://help.aliyun.com/document_detail/413866.html">DescribeInstanceDasPro</a> operation to query whether DAS Enterprise Edition is enabled.</description></item>
        /// <item><description>The database instance has four or more CPU cores, and <b>innodb_file_per_table</b> is set to <b>ON</b>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAutoResourceOptimizeRulesAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAutoResourceOptimizeRulesAsyncResponse
        /// </returns>
        public async Task<UpdateAutoResourceOptimizeRulesAsyncResponse> UpdateAutoResourceOptimizeRulesAsyncAsync(UpdateAutoResourceOptimizeRulesAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAutoResourceOptimizeRulesAsyncWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables, modifies, or disables the automatic SQL optimization feature for multiple database instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>DAS Enterprise Edition must be enabled for the database instance that you want to manage. To enable DAS Enterprise Edition for a database instance, you can call the <a href="https://help.aliyun.com/document_detail/411645.html">EnableDasPro</a> operation.</description></item>
        /// <item><description>The autonomy service must be enabled for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/152139.html">Autonomy center</a>.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition</description></item>
        /// <item><description>PolarDB for MySQL Cluster Edition</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAutoSqlOptimizeStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAutoSqlOptimizeStatusResponse
        /// </returns>
        public UpdateAutoSqlOptimizeStatusResponse UpdateAutoSqlOptimizeStatusWithOptions(UpdateAutoSqlOptimizeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                query["Instances"] = request.Instances;
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
                Action = "UpdateAutoSqlOptimizeStatus",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAutoSqlOptimizeStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables, modifies, or disables the automatic SQL optimization feature for multiple database instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>DAS Enterprise Edition must be enabled for the database instance that you want to manage. To enable DAS Enterprise Edition for a database instance, you can call the <a href="https://help.aliyun.com/document_detail/411645.html">EnableDasPro</a> operation.</description></item>
        /// <item><description>The autonomy service must be enabled for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/152139.html">Autonomy center</a>.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition</description></item>
        /// <item><description>PolarDB for MySQL Cluster Edition</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAutoSqlOptimizeStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAutoSqlOptimizeStatusResponse
        /// </returns>
        public async Task<UpdateAutoSqlOptimizeStatusResponse> UpdateAutoSqlOptimizeStatusWithOptionsAsync(UpdateAutoSqlOptimizeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                query["Instances"] = request.Instances;
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
                Action = "UpdateAutoSqlOptimizeStatus",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAutoSqlOptimizeStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables, modifies, or disables the automatic SQL optimization feature for multiple database instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>DAS Enterprise Edition must be enabled for the database instance that you want to manage. To enable DAS Enterprise Edition for a database instance, you can call the <a href="https://help.aliyun.com/document_detail/411645.html">EnableDasPro</a> operation.</description></item>
        /// <item><description>The autonomy service must be enabled for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/152139.html">Autonomy center</a>.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition</description></item>
        /// <item><description>PolarDB for MySQL Cluster Edition</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAutoSqlOptimizeStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAutoSqlOptimizeStatusResponse
        /// </returns>
        public UpdateAutoSqlOptimizeStatusResponse UpdateAutoSqlOptimizeStatus(UpdateAutoSqlOptimizeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAutoSqlOptimizeStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables, modifies, or disables the automatic SQL optimization feature for multiple database instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>DAS Enterprise Edition must be enabled for the database instance that you want to manage. To enable DAS Enterprise Edition for a database instance, you can call the <a href="https://help.aliyun.com/document_detail/411645.html">EnableDasPro</a> operation.</description></item>
        /// <item><description>The autonomy service must be enabled for the database instance. For more information, see <a href="https://help.aliyun.com/document_detail/152139.html">Autonomy center</a>.</description></item>
        /// <item><description>This operation supports the following database engines:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition</description></item>
        /// <item><description>PolarDB for MySQL Cluster Edition</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAutoSqlOptimizeStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAutoSqlOptimizeStatusResponse
        /// </returns>
        public async Task<UpdateAutoSqlOptimizeStatusResponse> UpdateAutoSqlOptimizeStatusAsync(UpdateAutoSqlOptimizeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAutoSqlOptimizeStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously configures parameters related to the automatic SQL throttling feature for multiple database instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> Asynchronous calls do not immediately return the complete results. To obtain the complete results, you must use the value of <b>ResultId</b> returned in the response to re-initiate the call until the value of <b>isFinish</b> is <b>true</b>.**** In this case, you must call this operation at least twice.
        /// Before you call this operation, take note of the following items:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The autonomy service must be enabled for the database instance that you want to manage. For more information, see <a href="https://help.aliyun.com/document_detail/152139.html">Autonomy center</a>.</description></item>
        /// <item><description>The database instance that you want to manage must be of one of the following types:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0</description></item>
        /// <item><description>PolarDB for MySQL Cluster Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAutoThrottleRulesAsyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAutoThrottleRulesAsyncResponse
        /// </returns>
        public UpdateAutoThrottleRulesAsyncResponse UpdateAutoThrottleRulesAsyncWithOptions(UpdateAutoThrottleRulesAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AbnormalDuration))
            {
                query["AbnormalDuration"] = request.AbnormalDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveSessions))
            {
                query["ActiveSessions"] = request.ActiveSessions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowThrottleEndTime))
            {
                query["AllowThrottleEndTime"] = request.AllowThrottleEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowThrottleStartTime))
            {
                query["AllowThrottleStartTime"] = request.AllowThrottleStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoKillSession))
            {
                query["AutoKillSession"] = request.AutoKillSession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuSessionRelation))
            {
                query["CpuSessionRelation"] = request.CpuSessionRelation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuUsage))
            {
                query["CpuUsage"] = request.CpuUsage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxThrottleTime))
            {
                query["MaxThrottleTime"] = request.MaxThrottleTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultId))
            {
                query["ResultId"] = request.ResultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAutoThrottleRulesAsync",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAutoThrottleRulesAsyncResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously configures parameters related to the automatic SQL throttling feature for multiple database instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> Asynchronous calls do not immediately return the complete results. To obtain the complete results, you must use the value of <b>ResultId</b> returned in the response to re-initiate the call until the value of <b>isFinish</b> is <b>true</b>.**** In this case, you must call this operation at least twice.
        /// Before you call this operation, take note of the following items:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The autonomy service must be enabled for the database instance that you want to manage. For more information, see <a href="https://help.aliyun.com/document_detail/152139.html">Autonomy center</a>.</description></item>
        /// <item><description>The database instance that you want to manage must be of one of the following types:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0</description></item>
        /// <item><description>PolarDB for MySQL Cluster Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAutoThrottleRulesAsyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAutoThrottleRulesAsyncResponse
        /// </returns>
        public async Task<UpdateAutoThrottleRulesAsyncResponse> UpdateAutoThrottleRulesAsyncWithOptionsAsync(UpdateAutoThrottleRulesAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AbnormalDuration))
            {
                query["AbnormalDuration"] = request.AbnormalDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveSessions))
            {
                query["ActiveSessions"] = request.ActiveSessions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowThrottleEndTime))
            {
                query["AllowThrottleEndTime"] = request.AllowThrottleEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowThrottleStartTime))
            {
                query["AllowThrottleStartTime"] = request.AllowThrottleStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoKillSession))
            {
                query["AutoKillSession"] = request.AutoKillSession;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsoleContext))
            {
                query["ConsoleContext"] = request.ConsoleContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuSessionRelation))
            {
                query["CpuSessionRelation"] = request.CpuSessionRelation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuUsage))
            {
                query["CpuUsage"] = request.CpuUsage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxThrottleTime))
            {
                query["MaxThrottleTime"] = request.MaxThrottleTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultId))
            {
                query["ResultId"] = request.ResultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAutoThrottleRulesAsync",
                Version = "2020-01-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAutoThrottleRulesAsyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously configures parameters related to the automatic SQL throttling feature for multiple database instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> Asynchronous calls do not immediately return the complete results. To obtain the complete results, you must use the value of <b>ResultId</b> returned in the response to re-initiate the call until the value of <b>isFinish</b> is <b>true</b>.**** In this case, you must call this operation at least twice.
        /// Before you call this operation, take note of the following items:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The autonomy service must be enabled for the database instance that you want to manage. For more information, see <a href="https://help.aliyun.com/document_detail/152139.html">Autonomy center</a>.</description></item>
        /// <item><description>The database instance that you want to manage must be of one of the following types:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0</description></item>
        /// <item><description>PolarDB for MySQL Cluster Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAutoThrottleRulesAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAutoThrottleRulesAsyncResponse
        /// </returns>
        public UpdateAutoThrottleRulesAsyncResponse UpdateAutoThrottleRulesAsync(UpdateAutoThrottleRulesAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAutoThrottleRulesAsyncWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Asynchronously configures parameters related to the automatic SQL throttling feature for multiple database instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> Asynchronous calls do not immediately return the complete results. To obtain the complete results, you must use the value of <b>ResultId</b> returned in the response to re-initiate the call until the value of <b>isFinish</b> is <b>true</b>.**** In this case, you must call this operation at least twice.
        /// Before you call this operation, take note of the following items:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you use an SDK to call API operations of Database Autonomy Service (DAS), you must set the region ID to cn-shanghai.</description></item>
        /// <item><description>The autonomy service must be enabled for the database instance that you want to manage. For more information, see <a href="https://help.aliyun.com/document_detail/152139.html">Autonomy center</a>.</description></item>
        /// <item><description>The database instance that you want to manage must be of one of the following types:<list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL High-availability Edition or Enterprise Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0</description></item>
        /// <item><description>PolarDB for MySQL Cluster Edition that runs MySQL 5.6, MySQL 5.7, or MySQL 8.0</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAutoThrottleRulesAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAutoThrottleRulesAsyncResponse
        /// </returns>
        public async Task<UpdateAutoThrottleRulesAsyncResponse> UpdateAutoThrottleRulesAsyncAsync(UpdateAutoThrottleRulesAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAutoThrottleRulesAsyncWithOptionsAsync(request, runtime);
        }

    }
}
