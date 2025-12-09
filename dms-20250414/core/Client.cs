// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dms20250414.Models;

namespace AlibabaCloud.SDK.Dms20250414
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("dms", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>批量新建湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchCreateDataLakePartitionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateDataLakePartitionsResponse
        /// </returns>
        public BatchCreateDataLakePartitionsResponse BatchCreateDataLakePartitionsWithOptions(BatchCreateDataLakePartitionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchCreateDataLakePartitionsShrinkRequest request = new BatchCreateDataLakePartitionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PartitionInputs))
            {
                request.PartitionInputsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PartitionInputs, "PartitionInputs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfNotExists))
            {
                query["IfNotExists"] = request.IfNotExists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedResult))
            {
                query["NeedResult"] = request.NeedResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionInputsShrink))
            {
                body["PartitionInputs"] = request.PartitionInputsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCreateDataLakePartitions",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateDataLakePartitionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新建湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchCreateDataLakePartitionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateDataLakePartitionsResponse
        /// </returns>
        public async Task<BatchCreateDataLakePartitionsResponse> BatchCreateDataLakePartitionsWithOptionsAsync(BatchCreateDataLakePartitionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchCreateDataLakePartitionsShrinkRequest request = new BatchCreateDataLakePartitionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PartitionInputs))
            {
                request.PartitionInputsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PartitionInputs, "PartitionInputs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfNotExists))
            {
                query["IfNotExists"] = request.IfNotExists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedResult))
            {
                query["NeedResult"] = request.NeedResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionInputsShrink))
            {
                body["PartitionInputs"] = request.PartitionInputsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCreateDataLakePartitions",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateDataLakePartitionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新建湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateDataLakePartitionsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateDataLakePartitionsResponse
        /// </returns>
        public BatchCreateDataLakePartitionsResponse BatchCreateDataLakePartitions(BatchCreateDataLakePartitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchCreateDataLakePartitionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新建湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateDataLakePartitionsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateDataLakePartitionsResponse
        /// </returns>
        public async Task<BatchCreateDataLakePartitionsResponse> BatchCreateDataLakePartitionsAsync(BatchCreateDataLakePartitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchCreateDataLakePartitionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteDataLakePartitionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteDataLakePartitionsResponse
        /// </returns>
        public BatchDeleteDataLakePartitionsResponse BatchDeleteDataLakePartitionsWithOptions(BatchDeleteDataLakePartitionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfExists))
            {
                query["IfExists"] = request.IfExists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionValuesList))
            {
                query["PartitionValuesList"] = request.PartitionValuesList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteDataLakePartitions",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteDataLakePartitionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteDataLakePartitionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteDataLakePartitionsResponse
        /// </returns>
        public async Task<BatchDeleteDataLakePartitionsResponse> BatchDeleteDataLakePartitionsWithOptionsAsync(BatchDeleteDataLakePartitionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfExists))
            {
                query["IfExists"] = request.IfExists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionValuesList))
            {
                query["PartitionValuesList"] = request.PartitionValuesList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteDataLakePartitions",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteDataLakePartitionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteDataLakePartitionsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteDataLakePartitionsResponse
        /// </returns>
        public BatchDeleteDataLakePartitionsResponse BatchDeleteDataLakePartitions(BatchDeleteDataLakePartitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDeleteDataLakePartitionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteDataLakePartitionsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteDataLakePartitionsResponse
        /// </returns>
        public async Task<BatchDeleteDataLakePartitionsResponse> BatchDeleteDataLakePartitionsAsync(BatchDeleteDataLakePartitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDeleteDataLakePartitionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchUpdateDataLakePartitionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateDataLakePartitionsResponse
        /// </returns>
        public BatchUpdateDataLakePartitionsResponse BatchUpdateDataLakePartitionsWithOptions(BatchUpdateDataLakePartitionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchUpdateDataLakePartitionsShrinkRequest request = new BatchUpdateDataLakePartitionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PartitionInputs))
            {
                request.PartitionInputsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PartitionInputs, "PartitionInputs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionInputsShrink))
            {
                body["PartitionInputs"] = request.PartitionInputsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUpdateDataLakePartitions",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateDataLakePartitionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchUpdateDataLakePartitionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateDataLakePartitionsResponse
        /// </returns>
        public async Task<BatchUpdateDataLakePartitionsResponse> BatchUpdateDataLakePartitionsWithOptionsAsync(BatchUpdateDataLakePartitionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchUpdateDataLakePartitionsShrinkRequest request = new BatchUpdateDataLakePartitionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PartitionInputs))
            {
                request.PartitionInputsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PartitionInputs, "PartitionInputs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionInputsShrink))
            {
                body["PartitionInputs"] = request.PartitionInputsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUpdateDataLakePartitions",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateDataLakePartitionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateDataLakePartitionsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateDataLakePartitionsResponse
        /// </returns>
        public BatchUpdateDataLakePartitionsResponse BatchUpdateDataLakePartitions(BatchUpdateDataLakePartitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUpdateDataLakePartitionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchUpdateDataLakePartitionsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchUpdateDataLakePartitionsResponse
        /// </returns>
        public async Task<BatchUpdateDataLakePartitionsResponse> BatchUpdateDataLakePartitionsAsync(BatchUpdateDataLakePartitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUpdateDataLakePartitionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Airflow</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAirflowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAirflowResponse
        /// </returns>
        public CreateAirflowResponse CreateAirflowWithOptions(CreateAirflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirflowName))
            {
                query["AirflowName"] = request.AirflowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSpec))
            {
                query["AppSpec"] = request.AppSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DagsDir))
            {
                query["DagsDir"] = request.DagsDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketName))
            {
                query["OssBucketName"] = request.OssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssPath))
            {
                query["OssPath"] = request.OssPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginsDir))
            {
                query["PluginsDir"] = request.PluginsDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequirementFile))
            {
                query["RequirementFile"] = request.RequirementFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartupFile))
            {
                query["StartupFile"] = request.StartupFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerServerlessReplicas))
            {
                query["WorkerServerlessReplicas"] = request.WorkerServerlessReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
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
                Action = "CreateAirflow",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAirflowResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Airflow</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAirflowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAirflowResponse
        /// </returns>
        public async Task<CreateAirflowResponse> CreateAirflowWithOptionsAsync(CreateAirflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirflowName))
            {
                query["AirflowName"] = request.AirflowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSpec))
            {
                query["AppSpec"] = request.AppSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DagsDir))
            {
                query["DagsDir"] = request.DagsDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketName))
            {
                query["OssBucketName"] = request.OssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssPath))
            {
                query["OssPath"] = request.OssPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginsDir))
            {
                query["PluginsDir"] = request.PluginsDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequirementFile))
            {
                query["RequirementFile"] = request.RequirementFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartupFile))
            {
                query["StartupFile"] = request.StartupFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerServerlessReplicas))
            {
                query["WorkerServerlessReplicas"] = request.WorkerServerlessReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
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
                Action = "CreateAirflow",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAirflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Airflow</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAirflowRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAirflowResponse
        /// </returns>
        public CreateAirflowResponse CreateAirflow(CreateAirflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAirflowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Airflow</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAirflowRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAirflowResponse
        /// </returns>
        public async Task<CreateAirflowResponse> CreateAirflowAsync(CreateAirflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAirflowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Airflow logon credential. You can use this credential to log on to the DMS-managed Airflow instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAirflowLoginTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAirflowLoginTokenResponse
        /// </returns>
        public CreateAirflowLoginTokenResponse CreateAirflowLoginTokenWithOptions(CreateAirflowLoginTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirflowId))
            {
                query["AirflowId"] = request.AirflowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAirflowLoginToken",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAirflowLoginTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Airflow logon credential. You can use this credential to log on to the DMS-managed Airflow instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAirflowLoginTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAirflowLoginTokenResponse
        /// </returns>
        public async Task<CreateAirflowLoginTokenResponse> CreateAirflowLoginTokenWithOptionsAsync(CreateAirflowLoginTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirflowId))
            {
                query["AirflowId"] = request.AirflowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAirflowLoginToken",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAirflowLoginTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Airflow logon credential. You can use this credential to log on to the DMS-managed Airflow instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAirflowLoginTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAirflowLoginTokenResponse
        /// </returns>
        public CreateAirflowLoginTokenResponse CreateAirflowLoginToken(CreateAirflowLoginTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAirflowLoginTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Airflow logon credential. You can use this credential to log on to the DMS-managed Airflow instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAirflowLoginTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAirflowLoginTokenResponse
        /// </returns>
        public async Task<CreateAirflowLoginTokenResponse> CreateAirflowLoginTokenAsync(CreateAirflowLoginTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAirflowLoginTokenWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateDataAgentSession</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDataAgentSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataAgentSessionResponse
        /// </returns>
        public CreateDataAgentSessionResponse CreateDataAgentSessionWithOptions(CreateDataAgentSessionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDataAgentSessionShrinkRequest request = new CreateDataAgentSessionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SessionConfig))
            {
                request.SessionConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SessionConfig, "SessionConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.File))
            {
                query["File"] = request.File;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionConfigShrink))
            {
                query["SessionConfig"] = request.SessionConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataAgentSession",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataAgentSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateDataAgentSession</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDataAgentSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataAgentSessionResponse
        /// </returns>
        public async Task<CreateDataAgentSessionResponse> CreateDataAgentSessionWithOptionsAsync(CreateDataAgentSessionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDataAgentSessionShrinkRequest request = new CreateDataAgentSessionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SessionConfig))
            {
                request.SessionConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SessionConfig, "SessionConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.File))
            {
                query["File"] = request.File;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionConfigShrink))
            {
                query["SessionConfig"] = request.SessionConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataAgentSession",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataAgentSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateDataAgentSession</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataAgentSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataAgentSessionResponse
        /// </returns>
        public CreateDataAgentSessionResponse CreateDataAgentSession(CreateDataAgentSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataAgentSessionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateDataAgentSession</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataAgentSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataAgentSessionResponse
        /// </returns>
        public async Task<CreateDataAgentSessionResponse> CreateDataAgentSessionAsync(CreateDataAgentSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataAgentSessionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建湖仓数据库</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDataLakeDatabaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataLakeDatabaseResponse
        /// </returns>
        public CreateDataLakeDatabaseResponse CreateDataLakeDatabaseWithOptions(CreateDataLakeDatabaseRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDataLakeDatabaseShrinkRequest request = new CreateDataLakeDatabaseShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                query["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataLakeDatabase",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataLakeDatabaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建湖仓数据库</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDataLakeDatabaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataLakeDatabaseResponse
        /// </returns>
        public async Task<CreateDataLakeDatabaseResponse> CreateDataLakeDatabaseWithOptionsAsync(CreateDataLakeDatabaseRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDataLakeDatabaseShrinkRequest request = new CreateDataLakeDatabaseShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                query["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataLakeDatabase",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataLakeDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建湖仓数据库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataLakeDatabaseRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataLakeDatabaseResponse
        /// </returns>
        public CreateDataLakeDatabaseResponse CreateDataLakeDatabase(CreateDataLakeDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataLakeDatabaseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建湖仓数据库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataLakeDatabaseRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataLakeDatabaseResponse
        /// </returns>
        public async Task<CreateDataLakeDatabaseResponse> CreateDataLakeDatabaseAsync(CreateDataLakeDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataLakeDatabaseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建湖仓自定义函数</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDataLakeFunctionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataLakeFunctionResponse
        /// </returns>
        public CreateDataLakeFunctionResponse CreateDataLakeFunctionWithOptions(CreateDataLakeFunctionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDataLakeFunctionShrinkRequest request = new CreateDataLakeFunctionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FunctionInput))
            {
                request.FunctionInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FunctionInput, "FunctionInput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionInputShrink))
            {
                body["FunctionInput"] = request.FunctionInputShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataLakeFunction",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataLakeFunctionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建湖仓自定义函数</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDataLakeFunctionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataLakeFunctionResponse
        /// </returns>
        public async Task<CreateDataLakeFunctionResponse> CreateDataLakeFunctionWithOptionsAsync(CreateDataLakeFunctionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDataLakeFunctionShrinkRequest request = new CreateDataLakeFunctionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FunctionInput))
            {
                request.FunctionInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FunctionInput, "FunctionInput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionInputShrink))
            {
                body["FunctionInput"] = request.FunctionInputShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataLakeFunction",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataLakeFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建湖仓自定义函数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataLakeFunctionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataLakeFunctionResponse
        /// </returns>
        public CreateDataLakeFunctionResponse CreateDataLakeFunction(CreateDataLakeFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataLakeFunctionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建湖仓自定义函数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataLakeFunctionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataLakeFunctionResponse
        /// </returns>
        public async Task<CreateDataLakeFunctionResponse> CreateDataLakeFunctionAsync(CreateDataLakeFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataLakeFunctionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDataLakePartitionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataLakePartitionResponse
        /// </returns>
        public CreateDataLakePartitionResponse CreateDataLakePartitionWithOptions(CreateDataLakePartitionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDataLakePartitionShrinkRequest request = new CreateDataLakePartitionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PartitionInput))
            {
                request.PartitionInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PartitionInput, "PartitionInput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfNotExists))
            {
                query["IfNotExists"] = request.IfNotExists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedResult))
            {
                query["NeedResult"] = request.NeedResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionInputShrink))
            {
                body["PartitionInput"] = request.PartitionInputShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataLakePartition",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataLakePartitionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDataLakePartitionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataLakePartitionResponse
        /// </returns>
        public async Task<CreateDataLakePartitionResponse> CreateDataLakePartitionWithOptionsAsync(CreateDataLakePartitionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDataLakePartitionShrinkRequest request = new CreateDataLakePartitionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PartitionInput))
            {
                request.PartitionInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PartitionInput, "PartitionInput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfNotExists))
            {
                query["IfNotExists"] = request.IfNotExists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedResult))
            {
                query["NeedResult"] = request.NeedResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionInputShrink))
            {
                body["PartitionInput"] = request.PartitionInputShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataLakePartition",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataLakePartitionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataLakePartitionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataLakePartitionResponse
        /// </returns>
        public CreateDataLakePartitionResponse CreateDataLakePartition(CreateDataLakePartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataLakePartitionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataLakePartitionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataLakePartitionResponse
        /// </returns>
        public async Task<CreateDataLakePartitionResponse> CreateDataLakePartitionAsync(CreateDataLakePartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataLakePartitionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建湖仓表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDataLakeTableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataLakeTableResponse
        /// </returns>
        public CreateDataLakeTableResponse CreateDataLakeTableWithOptions(CreateDataLakeTableRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDataLakeTableShrinkRequest request = new CreateDataLakeTableShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TableInput))
            {
                request.TableInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TableInput, "TableInput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableInputShrink))
            {
                body["TableInput"] = request.TableInputShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataLakeTable",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataLakeTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建湖仓表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateDataLakeTableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataLakeTableResponse
        /// </returns>
        public async Task<CreateDataLakeTableResponse> CreateDataLakeTableWithOptionsAsync(CreateDataLakeTableRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDataLakeTableShrinkRequest request = new CreateDataLakeTableShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TableInput))
            {
                request.TableInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TableInput, "TableInput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableInputShrink))
            {
                body["TableInput"] = request.TableInputShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataLakeTable",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataLakeTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建湖仓表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataLakeTableRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataLakeTableResponse
        /// </returns>
        public CreateDataLakeTableResponse CreateDataLakeTable(CreateDataLakeTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataLakeTableWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建湖仓表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataLakeTableRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataLakeTableResponse
        /// </returns>
        public async Task<CreateDataLakeTableResponse> CreateDataLakeTableAsync(CreateDataLakeTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataLakeTableWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Airflow</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAirflowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAirflowResponse
        /// </returns>
        public DeleteAirflowResponse DeleteAirflowWithOptions(DeleteAirflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirflowId))
            {
                query["AirflowId"] = request.AirflowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAirflow",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAirflowResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Airflow</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAirflowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAirflowResponse
        /// </returns>
        public async Task<DeleteAirflowResponse> DeleteAirflowWithOptionsAsync(DeleteAirflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirflowId))
            {
                query["AirflowId"] = request.AirflowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAirflow",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAirflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Airflow</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAirflowRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAirflowResponse
        /// </returns>
        public DeleteAirflowResponse DeleteAirflow(DeleteAirflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAirflowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除Airflow</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAirflowRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAirflowResponse
        /// </returns>
        public async Task<DeleteAirflowResponse> DeleteAirflowAsync(DeleteAirflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAirflowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除湖仓数据库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataLakeDatabaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataLakeDatabaseResponse
        /// </returns>
        public DeleteDataLakeDatabaseResponse DeleteDataLakeDatabaseWithOptions(DeleteDataLakeDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataLakeDatabase",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataLakeDatabaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除湖仓数据库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataLakeDatabaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataLakeDatabaseResponse
        /// </returns>
        public async Task<DeleteDataLakeDatabaseResponse> DeleteDataLakeDatabaseWithOptionsAsync(DeleteDataLakeDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataLakeDatabase",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataLakeDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除湖仓数据库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataLakeDatabaseRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataLakeDatabaseResponse
        /// </returns>
        public DeleteDataLakeDatabaseResponse DeleteDataLakeDatabase(DeleteDataLakeDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataLakeDatabaseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除湖仓数据库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataLakeDatabaseRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataLakeDatabaseResponse
        /// </returns>
        public async Task<DeleteDataLakeDatabaseResponse> DeleteDataLakeDatabaseAsync(DeleteDataLakeDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataLakeDatabaseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除湖仓自定义函数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataLakeFunctionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataLakeFunctionResponse
        /// </returns>
        public DeleteDataLakeFunctionResponse DeleteDataLakeFunctionWithOptions(DeleteDataLakeFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["FunctionName"] = request.FunctionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataLakeFunction",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataLakeFunctionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除湖仓自定义函数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataLakeFunctionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataLakeFunctionResponse
        /// </returns>
        public async Task<DeleteDataLakeFunctionResponse> DeleteDataLakeFunctionWithOptionsAsync(DeleteDataLakeFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["FunctionName"] = request.FunctionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataLakeFunction",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataLakeFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除湖仓自定义函数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataLakeFunctionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataLakeFunctionResponse
        /// </returns>
        public DeleteDataLakeFunctionResponse DeleteDataLakeFunction(DeleteDataLakeFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataLakeFunctionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除湖仓自定义函数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataLakeFunctionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataLakeFunctionResponse
        /// </returns>
        public async Task<DeleteDataLakeFunctionResponse> DeleteDataLakeFunctionAsync(DeleteDataLakeFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataLakeFunctionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteDataLakePartitionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataLakePartitionResponse
        /// </returns>
        public DeleteDataLakePartitionResponse DeleteDataLakePartitionWithOptions(DeleteDataLakePartitionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteDataLakePartitionShrinkRequest request = new DeleteDataLakePartitionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PartitionValues))
            {
                request.PartitionValuesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PartitionValues, "PartitionValues", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfExists))
            {
                query["IfExists"] = request.IfExists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionValuesShrink))
            {
                query["PartitionValues"] = request.PartitionValuesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataLakePartition",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataLakePartitionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteDataLakePartitionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataLakePartitionResponse
        /// </returns>
        public async Task<DeleteDataLakePartitionResponse> DeleteDataLakePartitionWithOptionsAsync(DeleteDataLakePartitionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteDataLakePartitionShrinkRequest request = new DeleteDataLakePartitionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PartitionValues))
            {
                request.PartitionValuesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PartitionValues, "PartitionValues", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfExists))
            {
                query["IfExists"] = request.IfExists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionValuesShrink))
            {
                query["PartitionValues"] = request.PartitionValuesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataLakePartition",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataLakePartitionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataLakePartitionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataLakePartitionResponse
        /// </returns>
        public DeleteDataLakePartitionResponse DeleteDataLakePartition(DeleteDataLakePartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataLakePartitionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataLakePartitionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataLakePartitionResponse
        /// </returns>
        public async Task<DeleteDataLakePartitionResponse> DeleteDataLakePartitionAsync(DeleteDataLakePartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataLakePartitionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除湖仓表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataLakeTableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataLakeTableResponse
        /// </returns>
        public DeleteDataLakeTableResponse DeleteDataLakeTableWithOptions(DeleteDataLakeTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataLakeTable",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataLakeTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除湖仓表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataLakeTableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataLakeTableResponse
        /// </returns>
        public async Task<DeleteDataLakeTableResponse> DeleteDataLakeTableWithOptionsAsync(DeleteDataLakeTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataLakeTable",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataLakeTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除湖仓表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataLakeTableRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataLakeTableResponse
        /// </returns>
        public DeleteDataLakeTableResponse DeleteDataLakeTable(DeleteDataLakeTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataLakeTableWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除湖仓表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataLakeTableRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataLakeTableResponse
        /// </returns>
        public async Task<DeleteDataLakeTableResponse> DeleteDataLakeTableAsync(DeleteDataLakeTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataLakeTableWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeDataAgentSession</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDataAgentSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataAgentSessionResponse
        /// </returns>
        public DescribeDataAgentSessionResponse DescribeDataAgentSessionWithOptions(DescribeDataAgentSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataAgentSession",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataAgentSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeDataAgentSession</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDataAgentSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataAgentSessionResponse
        /// </returns>
        public async Task<DescribeDataAgentSessionResponse> DescribeDataAgentSessionWithOptionsAsync(DescribeDataAgentSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataAgentSession",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataAgentSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeDataAgentSession</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDataAgentSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataAgentSessionResponse
        /// </returns>
        public DescribeDataAgentSessionResponse DescribeDataAgentSession(DescribeDataAgentSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataAgentSessionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeDataAgentSession</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDataAgentSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataAgentSessionResponse
        /// </returns>
        public async Task<DescribeDataAgentSessionResponse> DescribeDataAgentSessionAsync(DescribeDataAgentSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataAgentSessionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 Airflow</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAirflowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAirflowResponse
        /// </returns>
        public GetAirflowResponse GetAirflowWithOptions(GetAirflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirflowId))
            {
                query["AirflowId"] = request.AirflowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAirflow",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAirflowResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 Airflow</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAirflowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAirflowResponse
        /// </returns>
        public async Task<GetAirflowResponse> GetAirflowWithOptionsAsync(GetAirflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirflowId))
            {
                query["AirflowId"] = request.AirflowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAirflow",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAirflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 Airflow</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAirflowRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAirflowResponse
        /// </returns>
        public GetAirflowResponse GetAirflow(GetAirflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAirflowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 Airflow</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAirflowRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAirflowResponse
        /// </returns>
        public async Task<GetAirflowResponse> GetAirflowAsync(GetAirflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAirflowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetChatContent</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChatContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChatContentResponse
        /// </returns>
        public GetChatContentResponse GetChatContentWithOptions(GetChatContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Checkpoint))
            {
                query["Checkpoint"] = request.Checkpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChatContent",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChatContentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetChatContent</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChatContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChatContentResponse
        /// </returns>
        public async Task<GetChatContentResponse> GetChatContentWithOptionsAsync(GetChatContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Checkpoint))
            {
                query["Checkpoint"] = request.Checkpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChatContent",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChatContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetChatContent</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChatContentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChatContentResponse
        /// </returns>
        public GetChatContentResponse GetChatContent(GetChatContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetChatContentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetChatContent</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChatContentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChatContentResponse
        /// </returns>
        public async Task<GetChatContentResponse> GetChatContentAsync(GetChatContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetChatContentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取uc的数据库目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataLakeCatalogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataLakeCatalogResponse
        /// </returns>
        public GetDataLakeCatalogResponse GetDataLakeCatalogWithOptions(GetDataLakeCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataLakeCatalog",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataLakeCatalogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取uc的数据库目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataLakeCatalogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataLakeCatalogResponse
        /// </returns>
        public async Task<GetDataLakeCatalogResponse> GetDataLakeCatalogWithOptionsAsync(GetDataLakeCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataLakeCatalog",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataLakeCatalogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取uc的数据库目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataLakeCatalogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataLakeCatalogResponse
        /// </returns>
        public GetDataLakeCatalogResponse GetDataLakeCatalog(GetDataLakeCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataLakeCatalogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取uc的数据库目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataLakeCatalogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataLakeCatalogResponse
        /// </returns>
        public async Task<GetDataLakeCatalogResponse> GetDataLakeCatalogAsync(GetDataLakeCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataLakeCatalogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取UC的数据库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataLakeDatabaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataLakeDatabaseResponse
        /// </returns>
        public GetDataLakeDatabaseResponse GetDataLakeDatabaseWithOptions(GetDataLakeDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataLakeDatabase",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataLakeDatabaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取UC的数据库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataLakeDatabaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataLakeDatabaseResponse
        /// </returns>
        public async Task<GetDataLakeDatabaseResponse> GetDataLakeDatabaseWithOptionsAsync(GetDataLakeDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataLakeDatabase",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataLakeDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取UC的数据库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataLakeDatabaseRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataLakeDatabaseResponse
        /// </returns>
        public GetDataLakeDatabaseResponse GetDataLakeDatabase(GetDataLakeDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataLakeDatabaseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取UC的数据库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataLakeDatabaseRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataLakeDatabaseResponse
        /// </returns>
        public async Task<GetDataLakeDatabaseResponse> GetDataLakeDatabaseAsync(GetDataLakeDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataLakeDatabaseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取湖仓自定义函数详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataLakeFunctionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataLakeFunctionResponse
        /// </returns>
        public GetDataLakeFunctionResponse GetDataLakeFunctionWithOptions(GetDataLakeFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["FunctionName"] = request.FunctionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataLakeFunction",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataLakeFunctionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取湖仓自定义函数详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataLakeFunctionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataLakeFunctionResponse
        /// </returns>
        public async Task<GetDataLakeFunctionResponse> GetDataLakeFunctionWithOptionsAsync(GetDataLakeFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["FunctionName"] = request.FunctionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataLakeFunction",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataLakeFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取湖仓自定义函数详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataLakeFunctionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataLakeFunctionResponse
        /// </returns>
        public GetDataLakeFunctionResponse GetDataLakeFunction(GetDataLakeFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataLakeFunctionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取湖仓自定义函数详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataLakeFunctionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataLakeFunctionResponse
        /// </returns>
        public async Task<GetDataLakeFunctionResponse> GetDataLakeFunctionAsync(GetDataLakeFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataLakeFunctionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取湖仓表分区详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetDataLakePartitionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataLakePartitionResponse
        /// </returns>
        public GetDataLakePartitionResponse GetDataLakePartitionWithOptions(GetDataLakePartitionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDataLakePartitionShrinkRequest request = new GetDataLakePartitionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PartitionValues))
            {
                request.PartitionValuesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PartitionValues, "PartitionValues", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionValuesShrink))
            {
                query["PartitionValues"] = request.PartitionValuesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataLakePartition",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataLakePartitionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取湖仓表分区详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetDataLakePartitionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataLakePartitionResponse
        /// </returns>
        public async Task<GetDataLakePartitionResponse> GetDataLakePartitionWithOptionsAsync(GetDataLakePartitionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetDataLakePartitionShrinkRequest request = new GetDataLakePartitionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PartitionValues))
            {
                request.PartitionValuesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PartitionValues, "PartitionValues", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionValuesShrink))
            {
                query["PartitionValues"] = request.PartitionValuesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataLakePartition",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataLakePartitionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取湖仓表分区详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataLakePartitionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataLakePartitionResponse
        /// </returns>
        public GetDataLakePartitionResponse GetDataLakePartition(GetDataLakePartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataLakePartitionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取湖仓表分区详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataLakePartitionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataLakePartitionResponse
        /// </returns>
        public async Task<GetDataLakePartitionResponse> GetDataLakePartitionAsync(GetDataLakePartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataLakePartitionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataLakeTableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataLakeTableResponse
        /// </returns>
        public GetDataLakeTableResponse GetDataLakeTableWithOptions(GetDataLakeTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataLakeTable",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataLakeTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataLakeTableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataLakeTableResponse
        /// </returns>
        public async Task<GetDataLakeTableResponse> GetDataLakeTableWithOptionsAsync(GetDataLakeTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataLakeTable",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataLakeTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataLakeTableRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataLakeTableResponse
        /// </returns>
        public GetDataLakeTableResponse GetDataLakeTable(GetDataLakeTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataLakeTableWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataLakeTableRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataLakeTableResponse
        /// </returns>
        public async Task<GetDataLakeTableResponse> GetDataLakeTableAsync(GetDataLakeTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataLakeTableWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调度运行Notebook文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotebookAndSubmitTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNotebookAndSubmitTaskResponse
        /// </returns>
        public GetNotebookAndSubmitTaskResponse GetNotebookAndSubmitTaskWithOptions(GetNotebookAndSubmitTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Retry))
            {
                body["Retry"] = request.Retry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNotebookAndSubmitTask",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNotebookAndSubmitTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调度运行Notebook文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotebookAndSubmitTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNotebookAndSubmitTaskResponse
        /// </returns>
        public async Task<GetNotebookAndSubmitTaskResponse> GetNotebookAndSubmitTaskWithOptionsAsync(GetNotebookAndSubmitTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Retry))
            {
                body["Retry"] = request.Retry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNotebookAndSubmitTask",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNotebookAndSubmitTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调度运行Notebook文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotebookAndSubmitTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNotebookAndSubmitTaskResponse
        /// </returns>
        public GetNotebookAndSubmitTaskResponse GetNotebookAndSubmitTask(GetNotebookAndSubmitTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNotebookAndSubmitTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调度运行Notebook文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotebookAndSubmitTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNotebookAndSubmitTaskResponse
        /// </returns>
        public async Task<GetNotebookAndSubmitTaskResponse> GetNotebookAndSubmitTaskAsync(GetNotebookAndSubmitTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNotebookAndSubmitTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看Notebook任务运行结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotebookTaskStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNotebookTaskStatusResponse
        /// </returns>
        public GetNotebookTaskStatusResponse GetNotebookTaskStatusWithOptions(GetNotebookTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNotebookTaskStatus",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNotebookTaskStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看Notebook任务运行结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotebookTaskStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNotebookTaskStatusResponse
        /// </returns>
        public async Task<GetNotebookTaskStatusResponse> GetNotebookTaskStatusWithOptionsAsync(GetNotebookTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNotebookTaskStatus",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNotebookTaskStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看Notebook任务运行结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotebookTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNotebookTaskStatusResponse
        /// </returns>
        public GetNotebookTaskStatusResponse GetNotebookTaskStatus(GetNotebookTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNotebookTaskStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看Notebook任务运行结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotebookTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNotebookTaskStatusResponse
        /// </returns>
        public async Task<GetNotebookTaskStatusResponse> GetNotebookTaskStatusAsync(GetNotebookTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNotebookTaskStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出资源Airflow</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAirflowsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAirflowsResponse
        /// </returns>
        public ListAirflowsResponse ListAirflowsWithOptions(ListAirflowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                query["Skip"] = request.Skip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAirflows",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAirflowsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出资源Airflow</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAirflowsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAirflowsResponse
        /// </returns>
        public async Task<ListAirflowsResponse> ListAirflowsWithOptionsAsync(ListAirflowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                query["Skip"] = request.Skip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAirflows",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAirflowsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出资源Airflow</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAirflowsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAirflowsResponse
        /// </returns>
        public ListAirflowsResponse ListAirflows(ListAirflowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAirflowsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出资源Airflow</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAirflowsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAirflowsResponse
        /// </returns>
        public async Task<ListAirflowsResponse> ListAirflowsAsync(ListAirflowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAirflowsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取uc的数据库目录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeCatalogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeCatalogResponse
        /// </returns>
        public ListDataLakeCatalogResponse ListDataLakeCatalogWithOptions(ListDataLakeCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataLakeCatalog",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataLakeCatalogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取uc的数据库目录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeCatalogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeCatalogResponse
        /// </returns>
        public async Task<ListDataLakeCatalogResponse> ListDataLakeCatalogWithOptionsAsync(ListDataLakeCatalogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataLakeCatalog",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataLakeCatalogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取uc的数据库目录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeCatalogRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeCatalogResponse
        /// </returns>
        public ListDataLakeCatalogResponse ListDataLakeCatalog(ListDataLakeCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataLakeCatalogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取uc的数据库目录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeCatalogRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeCatalogResponse
        /// </returns>
        public async Task<ListDataLakeCatalogResponse> ListDataLakeCatalogAsync(ListDataLakeCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataLakeCatalogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeDatabaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeDatabaseResponse
        /// </returns>
        public ListDataLakeDatabaseResponse ListDataLakeDatabaseWithOptions(ListDataLakeDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataLakeDatabase",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataLakeDatabaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeDatabaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeDatabaseResponse
        /// </returns>
        public async Task<ListDataLakeDatabaseResponse> ListDataLakeDatabaseWithOptionsAsync(ListDataLakeDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataLakeDatabase",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataLakeDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeDatabaseRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeDatabaseResponse
        /// </returns>
        public ListDataLakeDatabaseResponse ListDataLakeDatabase(ListDataLakeDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataLakeDatabaseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeDatabaseRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeDatabaseResponse
        /// </returns>
        public async Task<ListDataLakeDatabaseResponse> ListDataLakeDatabaseAsync(ListDataLakeDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataLakeDatabaseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖函数列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeFunctionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeFunctionResponse
        /// </returns>
        public ListDataLakeFunctionResponse ListDataLakeFunctionWithOptions(ListDataLakeFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionNamePattern))
            {
                query["FunctionNamePattern"] = request.FunctionNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataLakeFunction",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataLakeFunctionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖函数列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeFunctionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeFunctionResponse
        /// </returns>
        public async Task<ListDataLakeFunctionResponse> ListDataLakeFunctionWithOptionsAsync(ListDataLakeFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionNamePattern))
            {
                query["FunctionNamePattern"] = request.FunctionNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataLakeFunction",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataLakeFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖函数列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeFunctionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeFunctionResponse
        /// </returns>
        public ListDataLakeFunctionResponse ListDataLakeFunction(ListDataLakeFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataLakeFunctionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖函数列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeFunctionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeFunctionResponse
        /// </returns>
        public async Task<ListDataLakeFunctionResponse> ListDataLakeFunctionAsync(ListDataLakeFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataLakeFunctionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖函数名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeFunctionNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeFunctionNameResponse
        /// </returns>
        public ListDataLakeFunctionNameResponse ListDataLakeFunctionNameWithOptions(ListDataLakeFunctionNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionNamePattern))
            {
                query["FunctionNamePattern"] = request.FunctionNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataLakeFunctionName",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataLakeFunctionNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖函数名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeFunctionNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeFunctionNameResponse
        /// </returns>
        public async Task<ListDataLakeFunctionNameResponse> ListDataLakeFunctionNameWithOptionsAsync(ListDataLakeFunctionNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionNamePattern))
            {
                query["FunctionNamePattern"] = request.FunctionNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataLakeFunctionName",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataLakeFunctionNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖函数名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeFunctionNameRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeFunctionNameResponse
        /// </returns>
        public ListDataLakeFunctionNameResponse ListDataLakeFunctionName(ListDataLakeFunctionNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataLakeFunctionNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖函数名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeFunctionNameRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeFunctionNameResponse
        /// </returns>
        public async Task<ListDataLakeFunctionNameResponse> ListDataLakeFunctionNameAsync(ListDataLakeFunctionNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataLakeFunctionNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖表分区列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDataLakePartitionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakePartitionResponse
        /// </returns>
        public ListDataLakePartitionResponse ListDataLakePartitionWithOptions(ListDataLakePartitionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDataLakePartitionShrinkRequest request = new ListDataLakePartitionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PartNames))
            {
                request.PartNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PartNames, "PartNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartNamesShrink))
            {
                body["PartNames"] = request.PartNamesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataLakePartition",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataLakePartitionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖表分区列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListDataLakePartitionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakePartitionResponse
        /// </returns>
        public async Task<ListDataLakePartitionResponse> ListDataLakePartitionWithOptionsAsync(ListDataLakePartitionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDataLakePartitionShrinkRequest request = new ListDataLakePartitionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PartNames))
            {
                request.PartNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PartNames, "PartNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartNamesShrink))
            {
                body["PartNames"] = request.PartNamesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataLakePartition",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataLakePartitionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖表分区列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakePartitionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakePartitionResponse
        /// </returns>
        public ListDataLakePartitionResponse ListDataLakePartition(ListDataLakePartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataLakePartitionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖表分区列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakePartitionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakePartitionResponse
        /// </returns>
        public async Task<ListDataLakePartitionResponse> ListDataLakePartitionAsync(ListDataLakePartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataLakePartitionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据筛选条件获取数据湖表分区列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakePartitionByFilterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakePartitionByFilterResponse
        /// </returns>
        public ListDataLakePartitionByFilterResponse ListDataLakePartitionByFilterWithOptions(ListDataLakePartitionByFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                body["Filter"] = request.Filter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataLakePartitionByFilter",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataLakePartitionByFilterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据筛选条件获取数据湖表分区列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakePartitionByFilterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakePartitionByFilterResponse
        /// </returns>
        public async Task<ListDataLakePartitionByFilterResponse> ListDataLakePartitionByFilterWithOptionsAsync(ListDataLakePartitionByFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                body["Filter"] = request.Filter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataLakePartitionByFilter",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataLakePartitionByFilterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据筛选条件获取数据湖表分区列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakePartitionByFilterRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakePartitionByFilterResponse
        /// </returns>
        public ListDataLakePartitionByFilterResponse ListDataLakePartitionByFilter(ListDataLakePartitionByFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataLakePartitionByFilterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据筛选条件获取数据湖表分区列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakePartitionByFilterRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakePartitionByFilterResponse
        /// </returns>
        public async Task<ListDataLakePartitionByFilterResponse> ListDataLakePartitionByFilterAsync(ListDataLakePartitionByFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataLakePartitionByFilterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖表分区名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakePartitionNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakePartitionNameResponse
        /// </returns>
        public ListDataLakePartitionNameResponse ListDataLakePartitionNameWithOptions(ListDataLakePartitionNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataLakePartitionName",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataLakePartitionNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖表分区名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakePartitionNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakePartitionNameResponse
        /// </returns>
        public async Task<ListDataLakePartitionNameResponse> ListDataLakePartitionNameWithOptionsAsync(ListDataLakePartitionNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataLakePartitionName",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataLakePartitionNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖表分区名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakePartitionNameRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakePartitionNameResponse
        /// </returns>
        public ListDataLakePartitionNameResponse ListDataLakePartitionName(ListDataLakePartitionNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataLakePartitionNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖表分区名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakePartitionNameRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakePartitionNameResponse
        /// </returns>
        public async Task<ListDataLakePartitionNameResponse> ListDataLakePartitionNameAsync(ListDataLakePartitionNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataLakePartitionNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖表列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeTableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeTableResponse
        /// </returns>
        public ListDataLakeTableResponse ListDataLakeTableWithOptions(ListDataLakeTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNamePattern))
            {
                query["TableNamePattern"] = request.TableNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableType))
            {
                query["TableType"] = request.TableType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataLakeTable",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataLakeTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖表列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeTableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeTableResponse
        /// </returns>
        public async Task<ListDataLakeTableResponse> ListDataLakeTableWithOptionsAsync(ListDataLakeTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNamePattern))
            {
                query["TableNamePattern"] = request.TableNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableType))
            {
                query["TableType"] = request.TableType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataLakeTable",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataLakeTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖表列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeTableRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeTableResponse
        /// </returns>
        public ListDataLakeTableResponse ListDataLakeTable(ListDataLakeTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataLakeTableWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖表列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeTableRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeTableResponse
        /// </returns>
        public async Task<ListDataLakeTableResponse> ListDataLakeTableAsync(ListDataLakeTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataLakeTableWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖表名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeTableNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeTableNameResponse
        /// </returns>
        public ListDataLakeTableNameResponse ListDataLakeTableNameWithOptions(ListDataLakeTableNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNamePattern))
            {
                query["TableNamePattern"] = request.TableNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableType))
            {
                query["TableType"] = request.TableType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataLakeTableName",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataLakeTableNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖表名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeTableNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeTableNameResponse
        /// </returns>
        public async Task<ListDataLakeTableNameResponse> ListDataLakeTableNameWithOptionsAsync(ListDataLakeTableNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNamePattern))
            {
                query["TableNamePattern"] = request.TableNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableType))
            {
                query["TableType"] = request.TableType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataLakeTableName",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataLakeTableNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖表名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeTableNameRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeTableNameResponse
        /// </returns>
        public ListDataLakeTableNameResponse ListDataLakeTableName(ListDataLakeTableNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataLakeTableNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖表名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeTableNameRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeTableNameResponse
        /// </returns>
        public async Task<ListDataLakeTableNameResponse> ListDataLakeTableNameAsync(ListDataLakeTableNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataLakeTableNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeTablebaseInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeTablebaseInfoResponse
        /// </returns>
        public ListDataLakeTablebaseInfoResponse ListDataLakeTablebaseInfoWithOptions(ListDataLakeTablebaseInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rows))
            {
                query["Rows"] = request.Rows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataLakeTablebaseInfo",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataLakeTablebaseInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeTablebaseInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeTablebaseInfoResponse
        /// </returns>
        public async Task<ListDataLakeTablebaseInfoResponse> ListDataLakeTablebaseInfoWithOptionsAsync(ListDataLakeTablebaseInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rows))
            {
                query["Rows"] = request.Rows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataLakeTablebaseInfo",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataLakeTablebaseInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeTablebaseInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeTablebaseInfoResponse
        /// </returns>
        public ListDataLakeTablebaseInfoResponse ListDataLakeTablebaseInfo(ListDataLakeTablebaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataLakeTablebaseInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取表信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataLakeTablebaseInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataLakeTablebaseInfoResponse
        /// </returns>
        public async Task<ListDataLakeTablebaseInfoResponse> ListDataLakeTablebaseInfoAsync(ListDataLakeTablebaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataLakeTablebaseInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SendChatMessage</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SendChatMessageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendChatMessageResponse
        /// </returns>
        public SendChatMessageResponse SendChatMessageWithOptions(SendChatMessageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendChatMessageShrinkRequest request = new SendChatMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSource))
            {
                request.DataSourceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSource, "DataSource", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SessionConfig))
            {
                request.SessionConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SessionConfig, "SessionConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceShrink))
            {
                query["DataSource"] = request.DataSourceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                query["MessageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Question))
            {
                query["Question"] = request.Question;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotedMessage))
            {
                query["QuotedMessage"] = request.QuotedMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplyTo))
            {
                query["ReplyTo"] = request.ReplyTo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionConfigShrink))
            {
                query["SessionConfig"] = request.SessionConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendChatMessage",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendChatMessageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SendChatMessage</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SendChatMessageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendChatMessageResponse
        /// </returns>
        public async Task<SendChatMessageResponse> SendChatMessageWithOptionsAsync(SendChatMessageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendChatMessageShrinkRequest request = new SendChatMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSource))
            {
                request.DataSourceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSource, "DataSource", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SessionConfig))
            {
                request.SessionConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SessionConfig, "SessionConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceShrink))
            {
                query["DataSource"] = request.DataSourceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                query["MessageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Question))
            {
                query["Question"] = request.Question;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotedMessage))
            {
                query["QuotedMessage"] = request.QuotedMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplyTo))
            {
                query["ReplyTo"] = request.ReplyTo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionConfigShrink))
            {
                query["SessionConfig"] = request.SessionConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendChatMessage",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendChatMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SendChatMessage</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendChatMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendChatMessageResponse
        /// </returns>
        public SendChatMessageResponse SendChatMessage(SendChatMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendChatMessageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SendChatMessage</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendChatMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendChatMessageResponse
        /// </returns>
        public async Task<SendChatMessageResponse> SendChatMessageAsync(SendChatMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendChatMessageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新UpdateAirflow</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAirflowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAirflowResponse
        /// </returns>
        public UpdateAirflowResponse UpdateAirflowWithOptions(UpdateAirflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirflowId))
            {
                query["AirflowId"] = request.AirflowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirflowName))
            {
                query["AirflowName"] = request.AirflowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSpec))
            {
                query["AppSpec"] = request.AppSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DagsDir))
            {
                query["DagsDir"] = request.DagsDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginsDir))
            {
                query["PluginsDir"] = request.PluginsDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequirementFile))
            {
                query["RequirementFile"] = request.RequirementFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartupFile))
            {
                query["StartupFile"] = request.StartupFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerServerlessReplicas))
            {
                query["WorkerServerlessReplicas"] = request.WorkerServerlessReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAirflow",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAirflowResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新UpdateAirflow</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAirflowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAirflowResponse
        /// </returns>
        public async Task<UpdateAirflowResponse> UpdateAirflowWithOptionsAsync(UpdateAirflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirflowId))
            {
                query["AirflowId"] = request.AirflowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirflowName))
            {
                query["AirflowName"] = request.AirflowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSpec))
            {
                query["AppSpec"] = request.AppSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DagsDir))
            {
                query["DagsDir"] = request.DagsDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginsDir))
            {
                query["PluginsDir"] = request.PluginsDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequirementFile))
            {
                query["RequirementFile"] = request.RequirementFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartupFile))
            {
                query["StartupFile"] = request.StartupFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerServerlessReplicas))
            {
                query["WorkerServerlessReplicas"] = request.WorkerServerlessReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAirflow",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAirflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新UpdateAirflow</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAirflowRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAirflowResponse
        /// </returns>
        public UpdateAirflowResponse UpdateAirflow(UpdateAirflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAirflowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新UpdateAirflow</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAirflowRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAirflowResponse
        /// </returns>
        public async Task<UpdateAirflowResponse> UpdateAirflowAsync(UpdateAirflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAirflowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新湖仓数据库</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateDataLakeDatabaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataLakeDatabaseResponse
        /// </returns>
        public UpdateDataLakeDatabaseResponse UpdateDataLakeDatabaseWithOptions(UpdateDataLakeDatabaseRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDataLakeDatabaseShrinkRequest request = new UpdateDataLakeDatabaseShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                query["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataLakeDatabase",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataLakeDatabaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新湖仓数据库</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateDataLakeDatabaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataLakeDatabaseResponse
        /// </returns>
        public async Task<UpdateDataLakeDatabaseResponse> UpdateDataLakeDatabaseWithOptionsAsync(UpdateDataLakeDatabaseRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDataLakeDatabaseShrinkRequest request = new UpdateDataLakeDatabaseShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                query["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataLakeDatabase",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataLakeDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新湖仓数据库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataLakeDatabaseRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataLakeDatabaseResponse
        /// </returns>
        public UpdateDataLakeDatabaseResponse UpdateDataLakeDatabase(UpdateDataLakeDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataLakeDatabaseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新湖仓数据库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataLakeDatabaseRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataLakeDatabaseResponse
        /// </returns>
        public async Task<UpdateDataLakeDatabaseResponse> UpdateDataLakeDatabaseAsync(UpdateDataLakeDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataLakeDatabaseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新湖仓自定义函数</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateDataLakeFunctionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataLakeFunctionResponse
        /// </returns>
        public UpdateDataLakeFunctionResponse UpdateDataLakeFunctionWithOptions(UpdateDataLakeFunctionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDataLakeFunctionShrinkRequest request = new UpdateDataLakeFunctionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FunctionInput))
            {
                request.FunctionInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FunctionInput, "FunctionInput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["FunctionName"] = request.FunctionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionInputShrink))
            {
                body["FunctionInput"] = request.FunctionInputShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataLakeFunction",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataLakeFunctionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新湖仓自定义函数</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateDataLakeFunctionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataLakeFunctionResponse
        /// </returns>
        public async Task<UpdateDataLakeFunctionResponse> UpdateDataLakeFunctionWithOptionsAsync(UpdateDataLakeFunctionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDataLakeFunctionShrinkRequest request = new UpdateDataLakeFunctionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FunctionInput))
            {
                request.FunctionInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FunctionInput, "FunctionInput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["FunctionName"] = request.FunctionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionInputShrink))
            {
                body["FunctionInput"] = request.FunctionInputShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataLakeFunction",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataLakeFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新湖仓自定义函数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataLakeFunctionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataLakeFunctionResponse
        /// </returns>
        public UpdateDataLakeFunctionResponse UpdateDataLakeFunction(UpdateDataLakeFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataLakeFunctionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新湖仓自定义函数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataLakeFunctionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataLakeFunctionResponse
        /// </returns>
        public async Task<UpdateDataLakeFunctionResponse> UpdateDataLakeFunctionAsync(UpdateDataLakeFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataLakeFunctionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateDataLakePartitionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataLakePartitionResponse
        /// </returns>
        public UpdateDataLakePartitionResponse UpdateDataLakePartitionWithOptions(UpdateDataLakePartitionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDataLakePartitionShrinkRequest request = new UpdateDataLakePartitionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PartitionInput))
            {
                request.PartitionInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PartitionInput, "PartitionInput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionInputShrink))
            {
                body["PartitionInput"] = request.PartitionInputShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataLakePartition",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataLakePartitionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateDataLakePartitionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataLakePartitionResponse
        /// </returns>
        public async Task<UpdateDataLakePartitionResponse> UpdateDataLakePartitionWithOptionsAsync(UpdateDataLakePartitionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDataLakePartitionShrinkRequest request = new UpdateDataLakePartitionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PartitionInput))
            {
                request.PartitionInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PartitionInput, "PartitionInput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionInputShrink))
            {
                body["PartitionInput"] = request.PartitionInputShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataLakePartition",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataLakePartitionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataLakePartitionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataLakePartitionResponse
        /// </returns>
        public UpdateDataLakePartitionResponse UpdateDataLakePartition(UpdateDataLakePartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataLakePartitionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新湖仓表分区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataLakePartitionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataLakePartitionResponse
        /// </returns>
        public async Task<UpdateDataLakePartitionResponse> UpdateDataLakePartitionAsync(UpdateDataLakePartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataLakePartitionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新湖仓表信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateDataLakeTableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataLakeTableResponse
        /// </returns>
        public UpdateDataLakeTableResponse UpdateDataLakeTableWithOptions(UpdateDataLakeTableRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDataLakeTableShrinkRequest request = new UpdateDataLakeTableShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TableInput))
            {
                request.TableInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TableInput, "TableInput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableInputShrink))
            {
                body["TableInput"] = request.TableInputShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataLakeTable",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataLakeTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新湖仓表信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateDataLakeTableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataLakeTableResponse
        /// </returns>
        public async Task<UpdateDataLakeTableResponse> UpdateDataLakeTableWithOptionsAsync(UpdateDataLakeTableRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDataLakeTableShrinkRequest request = new UpdateDataLakeTableShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TableInput))
            {
                request.TableInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TableInput, "TableInput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogName))
            {
                query["CatalogName"] = request.CatalogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tid))
            {
                query["Tid"] = request.Tid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableInputShrink))
            {
                body["TableInput"] = request.TableInputShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataLakeTable",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataLakeTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新湖仓表信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataLakeTableRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataLakeTableResponse
        /// </returns>
        public UpdateDataLakeTableResponse UpdateDataLakeTable(UpdateDataLakeTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataLakeTableWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新湖仓表信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataLakeTableRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataLakeTableResponse
        /// </returns>
        public async Task<UpdateDataLakeTableResponse> UpdateDataLakeTableAsync(UpdateDataLakeTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataLakeTableWithOptionsAsync(request, runtime);
        }

    }
}
