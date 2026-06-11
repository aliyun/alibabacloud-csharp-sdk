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
        /// <para>Adds a user to a specified workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUserToDataAgentWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddUserToDataAgentWorkspaceResponse
        /// </returns>
        public AddUserToDataAgentWorkspaceResponse AddUserToDataAgentWorkspaceWithOptions(AddUserToDataAgentWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
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
                Action = "AddUserToDataAgentWorkspace",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserToDataAgentWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a user to a specified workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUserToDataAgentWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddUserToDataAgentWorkspaceResponse
        /// </returns>
        public async Task<AddUserToDataAgentWorkspaceResponse> AddUserToDataAgentWorkspaceWithOptionsAsync(AddUserToDataAgentWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
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
                Action = "AddUserToDataAgentWorkspace",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserToDataAgentWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a user to a specified workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUserToDataAgentWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// AddUserToDataAgentWorkspaceResponse
        /// </returns>
        public AddUserToDataAgentWorkspaceResponse AddUserToDataAgentWorkspace(AddUserToDataAgentWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUserToDataAgentWorkspaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a user to a specified workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUserToDataAgentWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// AddUserToDataAgentWorkspaceResponse
        /// </returns>
        public async Task<AddUserToDataAgentWorkspaceResponse> AddUserToDataAgentWorkspaceAsync(AddUserToDataAgentWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUserToDataAgentWorkspaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates partitions for a data lake table in a batch.</para>
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
        /// <para>Creates partitions for a data lake table in a batch.</para>
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
        /// <para>Creates partitions for a data lake table in a batch.</para>
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
        /// <para>Creates partitions for a data lake table in a batch.</para>
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
        /// <para>Batch deletes partitions from a data lake table.</para>
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
        /// <para>Batch deletes partitions from a data lake table.</para>
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
        /// <para>Batch deletes partitions from a data lake table.</para>
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
        /// <para>Batch deletes partitions from a data lake table.</para>
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
        /// <para>Update partitions in a data lake table in batch.</para>
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
        /// <para>Update partitions in a data lake table in batch.</para>
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
        /// <para>Update partitions in a data lake table in batch.</para>
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
        /// <para>Update partitions in a data lake table in batch.</para>
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
        /// <para>Update an Airflow instance\&quot;s custom configuration</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Configure the airflow\.cfg file for DMS Airflow.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ConfigAirflowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigAirflowResponse
        /// </returns>
        public ConfigAirflowResponse ConfigAirflowWithOptions(ConfigAirflowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ConfigAirflowShrinkRequest request = new ConfigAirflowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomAirflowCfg))
            {
                request.CustomAirflowCfgShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomAirflowCfg, "CustomAirflowCfg", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirflowId))
            {
                query["AirflowId"] = request.AirflowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAirflowCfgShrink))
            {
                query["CustomAirflowCfg"] = request.CustomAirflowCfgShrink;
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
                Action = "ConfigAirflow",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigAirflowResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update an Airflow instance\&quot;s custom configuration</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Configure the airflow\.cfg file for DMS Airflow.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ConfigAirflowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfigAirflowResponse
        /// </returns>
        public async Task<ConfigAirflowResponse> ConfigAirflowWithOptionsAsync(ConfigAirflowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ConfigAirflowShrinkRequest request = new ConfigAirflowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomAirflowCfg))
            {
                request.CustomAirflowCfgShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomAirflowCfg, "CustomAirflowCfg", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirflowId))
            {
                query["AirflowId"] = request.AirflowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAirflowCfgShrink))
            {
                query["CustomAirflowCfg"] = request.CustomAirflowCfgShrink;
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
                Action = "ConfigAirflow",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigAirflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update an Airflow instance\&quot;s custom configuration</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Configure the airflow\.cfg file for DMS Airflow.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfigAirflowRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigAirflowResponse
        /// </returns>
        public ConfigAirflowResponse ConfigAirflow(ConfigAirflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigAirflowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update an Airflow instance\&quot;s custom configuration</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Configure the airflow\.cfg file for DMS Airflow.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConfigAirflowRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfigAirflowResponse
        /// </returns>
        public async Task<ConfigAirflowResponse> ConfigAirflowAsync(ConfigAirflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigAirflowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Airflow instance in a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an Airflow instance in a workspace.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateAirflowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAirflowResponse
        /// </returns>
        public CreateAirflowResponse CreateAirflowWithOptions(CreateAirflowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAirflowShrinkRequest request = new CreateAirflowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataMountInfoList))
            {
                request.DataMountInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataMountInfoList, "DataMountInfoList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirflowName))
            {
                query["AirflowName"] = request.AirflowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirflowVersion))
            {
                query["AirflowVersion"] = request.AirflowVersion;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataMountInfoListShrink))
            {
                query["DataMountInfoList"] = request.DataMountInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableServerless))
            {
                query["EnableServerless"] = request.EnableServerless;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GracefulShutdownTimeout))
            {
                query["GracefulShutdownTimeout"] = request.GracefulShutdownTimeout;
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
        /// <para>Creates an Airflow instance in a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an Airflow instance in a workspace.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateAirflowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAirflowResponse
        /// </returns>
        public async Task<CreateAirflowResponse> CreateAirflowWithOptionsAsync(CreateAirflowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAirflowShrinkRequest request = new CreateAirflowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataMountInfoList))
            {
                request.DataMountInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataMountInfoList, "DataMountInfoList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirflowName))
            {
                query["AirflowName"] = request.AirflowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AirflowVersion))
            {
                query["AirflowVersion"] = request.AirflowVersion;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataMountInfoListShrink))
            {
                query["DataMountInfoList"] = request.DataMountInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableServerless))
            {
                query["EnableServerless"] = request.EnableServerless;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GracefulShutdownTimeout))
            {
                query["GracefulShutdownTimeout"] = request.GracefulShutdownTimeout;
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
        /// <para>Creates an Airflow instance in a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an Airflow instance in a workspace.</para>
        /// </description>
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
        /// <para>Creates an Airflow instance in a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an Airflow instance in a workspace.</para>
        /// </description>
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
        /// <para>Obtains logon credentials for an Airflow instance hosted by Data Management Service (DMS). Use the returned token and host endpoint to construct a logon URL for the Airflow web UI.</para>
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
        /// <para>Obtains logon credentials for an Airflow instance hosted by Data Management Service (DMS). Use the returned token and host endpoint to construct a logon URL for the Airflow web UI.</para>
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
        /// <para>Obtains logon credentials for an Airflow instance hosted by Data Management Service (DMS). Use the returned token and host endpoint to construct a logon URL for the Airflow web UI.</para>
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
        /// <para>Obtains logon credentials for an Airflow instance hosted by Data Management Service (DMS). Use the returned token and host endpoint to construct a logon URL for the Airflow web UI.</para>
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
        /// <para>Create a custom agent in your personal space or a workspace.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateCustomAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomAgentResponse
        /// </returns>
        public CreateCustomAgentResponse CreateCustomAgentWithOptions(CreateCustomAgentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCustomAgentShrinkRequest request = new CreateCustomAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CallbackConfig))
            {
                request.CallbackConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CallbackConfig, "CallbackConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExecutionConfig))
            {
                request.ExecutionConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExecutionConfig, "ExecutionConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.KnowledgeConfigList))
            {
                request.KnowledgeConfigListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.KnowledgeConfigList, "KnowledgeConfigList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleTaskConfig))
            {
                request.ScheduleTaskConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleTaskConfig, "ScheduleTaskConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackConfigShrink))
            {
                query["CallbackConfig"] = request.CallbackConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataJson))
            {
                query["DataJson"] = request.DataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionConfigShrink))
            {
                query["ExecutionConfig"] = request.ExecutionConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instruction))
            {
                query["Instruction"] = request.Instruction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Knowledge))
            {
                query["Knowledge"] = request.Knowledge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeConfigListShrink))
            {
                query["KnowledgeConfigList"] = request.KnowledgeConfigListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedSessionId))
            {
                query["RelatedSessionId"] = request.RelatedSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTaskConfigShrink))
            {
                query["ScheduleTaskConfig"] = request.ScheduleTaskConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextReportConfig))
            {
                query["TextReportConfig"] = request.TextReportConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebReportConfig))
            {
                query["WebReportConfig"] = request.WebReportConfig;
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
                Action = "CreateCustomAgent",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a custom agent in your personal space or a workspace.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateCustomAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomAgentResponse
        /// </returns>
        public async Task<CreateCustomAgentResponse> CreateCustomAgentWithOptionsAsync(CreateCustomAgentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCustomAgentShrinkRequest request = new CreateCustomAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CallbackConfig))
            {
                request.CallbackConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CallbackConfig, "CallbackConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExecutionConfig))
            {
                request.ExecutionConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExecutionConfig, "ExecutionConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.KnowledgeConfigList))
            {
                request.KnowledgeConfigListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.KnowledgeConfigList, "KnowledgeConfigList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleTaskConfig))
            {
                request.ScheduleTaskConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleTaskConfig, "ScheduleTaskConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackConfigShrink))
            {
                query["CallbackConfig"] = request.CallbackConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataJson))
            {
                query["DataJson"] = request.DataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionConfigShrink))
            {
                query["ExecutionConfig"] = request.ExecutionConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instruction))
            {
                query["Instruction"] = request.Instruction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Knowledge))
            {
                query["Knowledge"] = request.Knowledge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeConfigListShrink))
            {
                query["KnowledgeConfigList"] = request.KnowledgeConfigListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedSessionId))
            {
                query["RelatedSessionId"] = request.RelatedSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTaskConfigShrink))
            {
                query["ScheduleTaskConfig"] = request.ScheduleTaskConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextReportConfig))
            {
                query["TextReportConfig"] = request.TextReportConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebReportConfig))
            {
                query["WebReportConfig"] = request.WebReportConfig;
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
                Action = "CreateCustomAgent",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a custom agent in your personal space or a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomAgentResponse
        /// </returns>
        public CreateCustomAgentResponse CreateCustomAgent(CreateCustomAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a custom agent in your personal space or a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomAgentResponse
        /// </returns>
        public async Task<CreateCustomAgentResponse> CreateCustomAgentAsync(CreateCustomAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a DataAgent knowledge base. The knowledge base creator has read and write permissions. Other workspace members have permission to use it.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataAgentKnowledgeBaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataAgentKnowledgeBaseResponse
        /// </returns>
        public CreateDataAgentKnowledgeBaseResponse CreateDataAgentKnowledgeBaseWithOptions(CreateDataAgentKnowledgeBaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromKbUuid))
            {
                query["FromKbUuid"] = request.FromKbUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "CreateDataAgentKnowledgeBase",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataAgentKnowledgeBaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a DataAgent knowledge base. The knowledge base creator has read and write permissions. Other workspace members have permission to use it.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataAgentKnowledgeBaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataAgentKnowledgeBaseResponse
        /// </returns>
        public async Task<CreateDataAgentKnowledgeBaseResponse> CreateDataAgentKnowledgeBaseWithOptionsAsync(CreateDataAgentKnowledgeBaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromKbUuid))
            {
                query["FromKbUuid"] = request.FromKbUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "CreateDataAgentKnowledgeBase",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataAgentKnowledgeBaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a DataAgent knowledge base. The knowledge base creator has read and write permissions. Other workspace members have permission to use it.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataAgentKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataAgentKnowledgeBaseResponse
        /// </returns>
        public CreateDataAgentKnowledgeBaseResponse CreateDataAgentKnowledgeBase(CreateDataAgentKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataAgentKnowledgeBaseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a DataAgent knowledge base. The knowledge base creator has read and write permissions. Other workspace members have permission to use it.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataAgentKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataAgentKnowledgeBaseResponse
        /// </returns>
        public async Task<CreateDataAgentKnowledgeBaseResponse> CreateDataAgentKnowledgeBaseAsync(CreateDataAgentKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataAgentKnowledgeBaseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a DataAgent session</para>
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
        /// <para>Create a DataAgent session</para>
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
        /// <para>Create a DataAgent session</para>
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
        /// <para>Create a DataAgent session</para>
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
        /// <para>Creates a DataAgent workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataAgentWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataAgentWorkspaceResponse
        /// </returns>
        public CreateDataAgentWorkspaceResponse CreateDataAgentWorkspaceWithOptions(CreateDataAgentWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSessionShareEnabled))
            {
                query["IsSessionShareEnabled"] = request.IsSessionShareEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceDesc))
            {
                query["WorkspaceDesc"] = request.WorkspaceDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                query["WorkspaceName"] = request.WorkspaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataAgentWorkspace",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataAgentWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a DataAgent workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataAgentWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataAgentWorkspaceResponse
        /// </returns>
        public async Task<CreateDataAgentWorkspaceResponse> CreateDataAgentWorkspaceWithOptionsAsync(CreateDataAgentWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSessionShareEnabled))
            {
                query["IsSessionShareEnabled"] = request.IsSessionShareEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceDesc))
            {
                query["WorkspaceDesc"] = request.WorkspaceDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                query["WorkspaceName"] = request.WorkspaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataAgentWorkspace",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataAgentWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a DataAgent workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataAgentWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataAgentWorkspaceResponse
        /// </returns>
        public CreateDataAgentWorkspaceResponse CreateDataAgentWorkspace(CreateDataAgentWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataAgentWorkspaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a DataAgent workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDataAgentWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataAgentWorkspaceResponse
        /// </returns>
        public async Task<CreateDataAgentWorkspaceResponse> CreateDataAgentWorkspaceAsync(CreateDataAgentWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataAgentWorkspaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data lake database.</para>
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
        /// <para>Creates a data lake database.</para>
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
        /// <para>Creates a data lake database.</para>
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
        /// <para>Creates a data lake database.</para>
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
        /// <para>Creates a user-defined function (UDF) for a data lake.</para>
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
        /// <para>Creates a user-defined function (UDF) for a data lake.</para>
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
        /// <para>Creates a user-defined function (UDF) for a data lake.</para>
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
        /// <para>Creates a user-defined function (UDF) for a data lake.</para>
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
        /// <para>Creates a partition for a data lake table.</para>
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
        /// <para>Creates a partition for a data lake table.</para>
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
        /// <para>Creates a partition for a data lake table.</para>
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
        /// <para>Creates a partition for a data lake table.</para>
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
        /// <para>Creates a data lake table in Data Management (DMS).</para>
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
        /// <para>Creates a data lake table in Data Management (DMS).</para>
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
        /// <para>Creates a data lake table in Data Management (DMS).</para>
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
        /// <para>Creates a data lake table in Data Management (DMS).</para>
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
        /// <para>Deletes an Airflow instance.</para>
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
        /// <para>Deletes an Airflow instance.</para>
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
        /// <para>Deletes an Airflow instance.</para>
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
        /// <para>Deletes an Airflow instance.</para>
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
        /// <para>Delete a custom agent in your personal workspace or a shared workspace. Note: Only custom agents that are newly created or offline can be deleted.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomAgentResponse
        /// </returns>
        public DeleteCustomAgentResponse DeleteCustomAgentWithOptions(DeleteCustomAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAgentId))
            {
                query["CustomAgentId"] = request.CustomAgentId;
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
                Action = "DeleteCustomAgent",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a custom agent in your personal workspace or a shared workspace. Note: Only custom agents that are newly created or offline can be deleted.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomAgentResponse
        /// </returns>
        public async Task<DeleteCustomAgentResponse> DeleteCustomAgentWithOptionsAsync(DeleteCustomAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAgentId))
            {
                query["CustomAgentId"] = request.CustomAgentId;
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
                Action = "DeleteCustomAgent",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a custom agent in your personal workspace or a shared workspace. Note: Only custom agents that are newly created or offline can be deleted.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomAgentResponse
        /// </returns>
        public DeleteCustomAgentResponse DeleteCustomAgent(DeleteCustomAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a custom agent in your personal workspace or a shared workspace. Note: Only custom agents that are newly created or offline can be deleted.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomAgentResponse
        /// </returns>
        public async Task<DeleteCustomAgentResponse> DeleteCustomAgentAsync(DeleteCustomAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a DataAgent knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataAgentKnowledgeBaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataAgentKnowledgeBaseResponse
        /// </returns>
        public DeleteDataAgentKnowledgeBaseResponse DeleteDataAgentKnowledgeBaseWithOptions(DeleteDataAgentKnowledgeBaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                query["KbUuid"] = request.KbUuid;
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
                Action = "DeleteDataAgentKnowledgeBase",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataAgentKnowledgeBaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a DataAgent knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataAgentKnowledgeBaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataAgentKnowledgeBaseResponse
        /// </returns>
        public async Task<DeleteDataAgentKnowledgeBaseResponse> DeleteDataAgentKnowledgeBaseWithOptionsAsync(DeleteDataAgentKnowledgeBaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                query["KbUuid"] = request.KbUuid;
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
                Action = "DeleteDataAgentKnowledgeBase",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataAgentKnowledgeBaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a DataAgent knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataAgentKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataAgentKnowledgeBaseResponse
        /// </returns>
        public DeleteDataAgentKnowledgeBaseResponse DeleteDataAgentKnowledgeBase(DeleteDataAgentKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataAgentKnowledgeBaseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a DataAgent knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataAgentKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataAgentKnowledgeBaseResponse
        /// </returns>
        public async Task<DeleteDataAgentKnowledgeBaseResponse> DeleteDataAgentKnowledgeBaseAsync(DeleteDataAgentKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataAgentKnowledgeBaseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a DataAgent workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataAgentWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataAgentWorkspaceResponse
        /// </returns>
        public DeleteDataAgentWorkspaceResponse DeleteDataAgentWorkspaceWithOptions(DeleteDataAgentWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
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
                Action = "DeleteDataAgentWorkspace",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataAgentWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a DataAgent workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataAgentWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataAgentWorkspaceResponse
        /// </returns>
        public async Task<DeleteDataAgentWorkspaceResponse> DeleteDataAgentWorkspaceWithOptionsAsync(DeleteDataAgentWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
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
                Action = "DeleteDataAgentWorkspace",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataAgentWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a DataAgent workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataAgentWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataAgentWorkspaceResponse
        /// </returns>
        public DeleteDataAgentWorkspaceResponse DeleteDataAgentWorkspace(DeleteDataAgentWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataAgentWorkspaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a DataAgent workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataAgentWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataAgentWorkspaceResponse
        /// </returns>
        public async Task<DeleteDataAgentWorkspaceResponse> DeleteDataAgentWorkspaceAsync(DeleteDataAgentWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataAgentWorkspaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a data lake database.</para>
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
        /// <para>Deletes a data lake database.</para>
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
        /// <para>Deletes a data lake database.</para>
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
        /// <para>Deletes a data lake database.</para>
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
        /// <para>Deletes a user-defined function in a data lake.</para>
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
        /// <para>Deletes a user-defined function in a data lake.</para>
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
        /// <para>Deletes a user-defined function in a data lake.</para>
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
        /// <para>Deletes a user-defined function in a data lake.</para>
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
        /// <para>Deletes a partition from a data lake table.</para>
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
        /// <para>Deletes a partition from a data lake table.</para>
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
        /// <para>Deletes a partition from a data lake table.</para>
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
        /// <para>Deletes a partition from a data lake table.</para>
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
        /// <para>Deletes a data lake table.</para>
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
        /// <para>Deletes a data lake table.</para>
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
        /// <para>Deletes a data lake table.</para>
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
        /// <para>Deletes a data lake table.</para>
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
        /// <para>Deletes a document from a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDocumentResponse
        /// </returns>
        public DeleteDocumentResponse DeleteDocumentWithOptions(DeleteDocumentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentName))
            {
                body["DocumentName"] = request.DocumentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                body["KbUuid"] = request.KbUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDocument",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a document from a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDocumentResponse
        /// </returns>
        public async Task<DeleteDocumentResponse> DeleteDocumentWithOptionsAsync(DeleteDocumentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentName))
            {
                body["DocumentName"] = request.DocumentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                body["KbUuid"] = request.KbUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDocument",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a document from a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDocumentResponse
        /// </returns>
        public DeleteDocumentResponse DeleteDocument(DeleteDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDocumentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a document from a specified knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDocumentResponse
        /// </returns>
        public async Task<DeleteDocumentResponse> DeleteDocumentAsync(DeleteDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDocumentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes chunks from a document in a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteDocumentChunksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDocumentChunksResponse
        /// </returns>
        public DeleteDocumentChunksResponse DeleteDocumentChunksWithOptions(DeleteDocumentChunksRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteDocumentChunksShrinkRequest request = new DeleteDocumentChunksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChunkIds))
            {
                request.ChunkIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChunkIds, "ChunkIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkIdsShrink))
            {
                body["ChunkIds"] = request.ChunkIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentName))
            {
                body["DocumentName"] = request.DocumentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                body["KbUuid"] = request.KbUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDocumentChunks",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDocumentChunksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes chunks from a document in a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteDocumentChunksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDocumentChunksResponse
        /// </returns>
        public async Task<DeleteDocumentChunksResponse> DeleteDocumentChunksWithOptionsAsync(DeleteDocumentChunksRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteDocumentChunksShrinkRequest request = new DeleteDocumentChunksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChunkIds))
            {
                request.ChunkIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChunkIds, "ChunkIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkIdsShrink))
            {
                body["ChunkIds"] = request.ChunkIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentName))
            {
                body["DocumentName"] = request.DocumentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                body["KbUuid"] = request.KbUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDocumentChunks",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDocumentChunksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes chunks from a document in a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDocumentChunksRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDocumentChunksResponse
        /// </returns>
        public DeleteDocumentChunksResponse DeleteDocumentChunks(DeleteDocumentChunksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDocumentChunksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes chunks from a document in a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDocumentChunksRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDocumentChunksResponse
        /// </returns>
        public async Task<DeleteDocumentChunksResponse> DeleteDocumentChunksAsync(DeleteDocumentChunksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDocumentChunksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteFileUpload</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFileUploadRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFileUploadResponse
        /// </returns>
        public DeleteFileUploadResponse DeleteFileUploadWithOptions(DeleteFileUploadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallFrom))
            {
                query["CallFrom"] = request.CallFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DmsUnit))
            {
                query["DmsUnit"] = request.DmsUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFileUpload",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFileUploadResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteFileUpload</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFileUploadRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFileUploadResponse
        /// </returns>
        public async Task<DeleteFileUploadResponse> DeleteFileUploadWithOptionsAsync(DeleteFileUploadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallFrom))
            {
                query["CallFrom"] = request.CallFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DmsUnit))
            {
                query["DmsUnit"] = request.DmsUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFileUpload",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFileUploadResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteFileUpload</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFileUploadRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFileUploadResponse
        /// </returns>
        public DeleteFileUploadResponse DeleteFileUpload(DeleteFileUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFileUploadWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteFileUpload</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFileUploadRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFileUploadResponse
        /// </returns>
        public async Task<DeleteFileUploadResponse> DeleteFileUploadAsync(DeleteFileUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFileUploadWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a code file or directory from a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation permanently removes a specified code file or directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceCodeResponse
        /// </returns>
        public DeleteWorkspaceCodeResponse DeleteWorkspaceCodeWithOptions(DeleteWorkspaceCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Repo))
            {
                query["Repo"] = request.Repo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Symlink))
            {
                query["Symlink"] = request.Symlink;
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
                Action = "DeleteWorkspaceCode",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkspaceCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a code file or directory from a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation permanently removes a specified code file or directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceCodeResponse
        /// </returns>
        public async Task<DeleteWorkspaceCodeResponse> DeleteWorkspaceCodeWithOptionsAsync(DeleteWorkspaceCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Repo))
            {
                query["Repo"] = request.Repo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Symlink))
            {
                query["Symlink"] = request.Symlink;
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
                Action = "DeleteWorkspaceCode",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkspaceCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a code file or directory from a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation permanently removes a specified code file or directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceCodeResponse
        /// </returns>
        public DeleteWorkspaceCodeResponse DeleteWorkspaceCode(DeleteWorkspaceCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWorkspaceCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a code file or directory from a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation permanently removes a specified code file or directory.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceCodeResponse
        /// </returns>
        public async Task<DeleteWorkspaceCodeResponse> DeleteWorkspaceCodeAsync(DeleteWorkspaceCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWorkspaceCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para><c>DescribeCustomAgent</c> retrieves the details of a custom agent by its agent ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomAgentResponse
        /// </returns>
        public DescribeCustomAgentResponse DescribeCustomAgentWithOptions(DescribeCustomAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAgentId))
            {
                query["CustomAgentId"] = request.CustomAgentId;
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
                Action = "DescribeCustomAgent",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para><c>DescribeCustomAgent</c> retrieves the details of a custom agent by its agent ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomAgentResponse
        /// </returns>
        public async Task<DescribeCustomAgentResponse> DescribeCustomAgentWithOptionsAsync(DescribeCustomAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAgentId))
            {
                query["CustomAgentId"] = request.CustomAgentId;
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
                Action = "DescribeCustomAgent",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para><c>DescribeCustomAgent</c> retrieves the details of a custom agent by its agent ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomAgentResponse
        /// </returns>
        public DescribeCustomAgentResponse DescribeCustomAgent(DescribeCustomAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para><c>DescribeCustomAgent</c> retrieves the details of a custom agent by its agent ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomAgentResponse
        /// </returns>
        public async Task<DescribeCustomAgentResponse> DescribeCustomAgentAsync(DescribeCustomAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Gets the details of a DataAgent session.</para>
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
        /// <para>Gets the details of a DataAgent session.</para>
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
        /// <para>Gets the details of a DataAgent session.</para>
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
        /// <para>Gets the details of a DataAgent session.</para>
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
        /// <para>Retrieves the details of a specific document.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDocumentResponse
        /// </returns>
        public DescribeDocumentResponse DescribeDocumentWithOptions(DescribeDocumentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentName))
            {
                body["DocumentName"] = request.DocumentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                body["KbUuid"] = request.KbUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDocument",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specific document.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDocumentResponse
        /// </returns>
        public async Task<DescribeDocumentResponse> DescribeDocumentWithOptionsAsync(DescribeDocumentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentName))
            {
                body["DocumentName"] = request.DocumentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                body["KbUuid"] = request.KbUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDocument",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specific document.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDocumentResponse
        /// </returns>
        public DescribeDocumentResponse DescribeDocument(DescribeDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDocumentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specific document.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDocumentResponse
        /// </returns>
        public async Task<DescribeDocumentResponse> DescribeDocumentAsync(DescribeDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDocumentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeFileUploadSignature</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFileUploadSignatureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFileUploadSignatureResponse
        /// </returns>
        public DescribeFileUploadSignatureResponse DescribeFileUploadSignatureWithOptions(DescribeFileUploadSignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallFrom))
            {
                query["CallFrom"] = request.CallFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DmsUnit))
            {
                query["DmsUnit"] = request.DmsUnit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFileUploadSignature",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFileUploadSignatureResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeFileUploadSignature</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFileUploadSignatureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFileUploadSignatureResponse
        /// </returns>
        public async Task<DescribeFileUploadSignatureResponse> DescribeFileUploadSignatureWithOptionsAsync(DescribeFileUploadSignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallFrom))
            {
                query["CallFrom"] = request.CallFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DmsUnit))
            {
                query["DmsUnit"] = request.DmsUnit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFileUploadSignature",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFileUploadSignatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeFileUploadSignature</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFileUploadSignatureRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFileUploadSignatureResponse
        /// </returns>
        public DescribeFileUploadSignatureResponse DescribeFileUploadSignature(DescribeFileUploadSignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFileUploadSignatureWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeFileUploadSignature</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFileUploadSignatureRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFileUploadSignatureResponse
        /// </returns>
        public async Task<DescribeFileUploadSignatureResponse> DescribeFileUploadSignatureAsync(DescribeFileUploadSignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFileUploadSignatureWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the statistics of a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeKnowledgeBaseStatsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeKnowledgeBaseStatsResponse
        /// </returns>
        public DescribeKnowledgeBaseStatsResponse DescribeKnowledgeBaseStatsWithOptions(DescribeKnowledgeBaseStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                query["KbUuid"] = request.KbUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeKnowledgeBaseStats",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeKnowledgeBaseStatsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the statistics of a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeKnowledgeBaseStatsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeKnowledgeBaseStatsResponse
        /// </returns>
        public async Task<DescribeKnowledgeBaseStatsResponse> DescribeKnowledgeBaseStatsWithOptionsAsync(DescribeKnowledgeBaseStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                query["KbUuid"] = request.KbUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeKnowledgeBaseStats",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeKnowledgeBaseStatsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the statistics of a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeKnowledgeBaseStatsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeKnowledgeBaseStatsResponse
        /// </returns>
        public DescribeKnowledgeBaseStatsResponse DescribeKnowledgeBaseStats(DescribeKnowledgeBaseStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeKnowledgeBaseStatsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the statistics of a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeKnowledgeBaseStatsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeKnowledgeBaseStatsResponse
        /// </returns>
        public async Task<DescribeKnowledgeBaseStatsResponse> DescribeKnowledgeBaseStatsAsync(DescribeKnowledgeBaseStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeKnowledgeBaseStatsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a signature to upload a document to a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeKnowledgeBaseUploadSignatureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeKnowledgeBaseUploadSignatureResponse
        /// </returns>
        public DescribeKnowledgeBaseUploadSignatureResponse DescribeKnowledgeBaseUploadSignatureWithOptions(DescribeKnowledgeBaseUploadSignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                query["KbUuid"] = request.KbUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeKnowledgeBaseUploadSignature",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeKnowledgeBaseUploadSignatureResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a signature to upload a document to a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeKnowledgeBaseUploadSignatureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeKnowledgeBaseUploadSignatureResponse
        /// </returns>
        public async Task<DescribeKnowledgeBaseUploadSignatureResponse> DescribeKnowledgeBaseUploadSignatureWithOptionsAsync(DescribeKnowledgeBaseUploadSignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                query["KbUuid"] = request.KbUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeKnowledgeBaseUploadSignature",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeKnowledgeBaseUploadSignatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a signature to upload a document to a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeKnowledgeBaseUploadSignatureRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeKnowledgeBaseUploadSignatureResponse
        /// </returns>
        public DescribeKnowledgeBaseUploadSignatureResponse DescribeKnowledgeBaseUploadSignature(DescribeKnowledgeBaseUploadSignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeKnowledgeBaseUploadSignatureWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a signature to upload a document to a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeKnowledgeBaseUploadSignatureRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeKnowledgeBaseUploadSignatureResponse
        /// </returns>
        public async Task<DescribeKnowledgeBaseUploadSignatureResponse> DescribeKnowledgeBaseUploadSignatureAsync(DescribeKnowledgeBaseUploadSignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeKnowledgeBaseUploadSignatureWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>FileUploadCallback</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileUploadCallbackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FileUploadCallbackResponse
        /// </returns>
        public FileUploadCallbackResponse FileUploadCallbackWithOptions(FileUploadCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallFrom))
            {
                query["CallFrom"] = request.CallFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DmsUnit))
            {
                query["DmsUnit"] = request.DmsUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                query["FileSize"] = request.FileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filename))
            {
                query["Filename"] = request.Filename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadLocation))
            {
                query["UploadLocation"] = request.UploadLocation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FileUploadCallback",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileUploadCallbackResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>FileUploadCallback</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileUploadCallbackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FileUploadCallbackResponse
        /// </returns>
        public async Task<FileUploadCallbackResponse> FileUploadCallbackWithOptionsAsync(FileUploadCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallFrom))
            {
                query["CallFrom"] = request.CallFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DmsUnit))
            {
                query["DmsUnit"] = request.DmsUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                query["FileSize"] = request.FileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filename))
            {
                query["Filename"] = request.Filename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadLocation))
            {
                query["UploadLocation"] = request.UploadLocation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FileUploadCallback",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileUploadCallbackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>FileUploadCallback</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileUploadCallbackRequest
        /// </param>
        /// 
        /// <returns>
        /// FileUploadCallbackResponse
        /// </returns>
        public FileUploadCallbackResponse FileUploadCallback(FileUploadCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FileUploadCallbackWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>FileUploadCallback</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileUploadCallbackRequest
        /// </param>
        /// 
        /// <returns>
        /// FileUploadCallbackResponse
        /// </returns>
        public async Task<FileUploadCallbackResponse> FileUploadCallbackAsync(FileUploadCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FileUploadCallbackWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration and status of an Airflow instance.</para>
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
        /// <para>Queries the configuration and status of an Airflow instance.</para>
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
        /// <para>Queries the configuration and status of an Airflow instance.</para>
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
        /// <para>Queries the configuration and status of an Airflow instance.</para>
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
        /// <para>Retrieves chat content from a specific checkpoint by specifying a session ID and an agent ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request</h2>
        /// <list type="bullet">
        /// <item><description>The response is an SSE stream. Each event follows the<c>SSEEvent</c> schema and includes metadata, such as the message level.</description></item>
        /// <item><description>The <c>content</c> field contains either message text or a JSON object, as determined by the <c>content_type</c> field.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Retrieves chat content from a specific checkpoint by specifying a session ID and an agent ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request</h2>
        /// <list type="bullet">
        /// <item><description>The response is an SSE stream. Each event follows the<c>SSEEvent</c> schema and includes metadata, such as the message level.</description></item>
        /// <item><description>The <c>content</c> field contains either message text or a JSON object, as determined by the <c>content_type</c> field.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Retrieves chat content from a specific checkpoint by specifying a session ID and an agent ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request</h2>
        /// <list type="bullet">
        /// <item><description>The response is an SSE stream. Each event follows the<c>SSEEvent</c> schema and includes metadata, such as the message level.</description></item>
        /// <item><description>The <c>content</c> field contains either message text or a JSON object, as determined by the <c>content_type</c> field.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Retrieves chat content from a specific checkpoint by specifying a session ID and an agent ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request</h2>
        /// <list type="bullet">
        /// <item><description>The response is an SSE stream. Each event follows the<c>SSEEvent</c> schema and includes metadata, such as the message level.</description></item>
        /// <item><description>The <c>content</c> field contains either message text or a JSON object, as determined by the <c>content_type</c> field.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Retrieves information about a RAM user that belongs to an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataAgentSubAccountInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataAgentSubAccountInfoResponse
        /// </returns>
        public GetDataAgentSubAccountInfoResponse GetDataAgentSubAccountInfoWithOptions(GetDataAgentSubAccountInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DmsUnit))
            {
                query["DmsUnit"] = request.DmsUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubAccountId))
            {
                query["SubAccountId"] = request.SubAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataAgentSubAccountInfo",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataAgentSubAccountInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about a RAM user that belongs to an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataAgentSubAccountInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataAgentSubAccountInfoResponse
        /// </returns>
        public async Task<GetDataAgentSubAccountInfoResponse> GetDataAgentSubAccountInfoWithOptionsAsync(GetDataAgentSubAccountInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DmsUnit))
            {
                query["DmsUnit"] = request.DmsUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubAccountId))
            {
                query["SubAccountId"] = request.SubAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataAgentSubAccountInfo",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataAgentSubAccountInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about a RAM user that belongs to an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataAgentSubAccountInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataAgentSubAccountInfoResponse
        /// </returns>
        public GetDataAgentSubAccountInfoResponse GetDataAgentSubAccountInfo(GetDataAgentSubAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataAgentSubAccountInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about a RAM user that belongs to an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataAgentSubAccountInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataAgentSubAccountInfoResponse
        /// </returns>
        public async Task<GetDataAgentSubAccountInfoResponse> GetDataAgentSubAccountInfoAsync(GetDataAgentSubAccountInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataAgentSubAccountInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves workspace details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataAgentWorkspaceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataAgentWorkspaceInfoResponse
        /// </returns>
        public GetDataAgentWorkspaceInfoResponse GetDataAgentWorkspaceInfoWithOptions(GetDataAgentWorkspaceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
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
                Action = "GetDataAgentWorkspaceInfo",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataAgentWorkspaceInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves workspace details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataAgentWorkspaceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataAgentWorkspaceInfoResponse
        /// </returns>
        public async Task<GetDataAgentWorkspaceInfoResponse> GetDataAgentWorkspaceInfoWithOptionsAsync(GetDataAgentWorkspaceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
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
                Action = "GetDataAgentWorkspaceInfo",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataAgentWorkspaceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves workspace details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataAgentWorkspaceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataAgentWorkspaceInfoResponse
        /// </returns>
        public GetDataAgentWorkspaceInfoResponse GetDataAgentWorkspaceInfo(GetDataAgentWorkspaceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataAgentWorkspaceInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves workspace details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDataAgentWorkspaceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataAgentWorkspaceInfoResponse
        /// </returns>
        public async Task<GetDataAgentWorkspaceInfoResponse> GetDataAgentWorkspaceInfoAsync(GetDataAgentWorkspaceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataAgentWorkspaceInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the data catalog of a data lake.</para>
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
        /// <para>Retrieves the data catalog of a data lake.</para>
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
        /// <para>Retrieves the data catalog of a data lake.</para>
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
        /// <para>Retrieves the data catalog of a data lake.</para>
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
        /// <para>Retrieves information about a database in a data lake.</para>
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
        /// <para>Retrieves information about a database in a data lake.</para>
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
        /// <para>Retrieves information about a database in a data lake.</para>
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
        /// <para>Retrieves information about a database in a data lake.</para>
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
        /// <para>Retrieves the details of a user-defined function in a data lake.</para>
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
        /// <para>Retrieves the details of a user-defined function in a data lake.</para>
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
        /// <para>Retrieves the details of a user-defined function in a data lake.</para>
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
        /// <para>Retrieves the details of a user-defined function in a data lake.</para>
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
        /// <para>Retrieves the details of a data lakehouse table partition.</para>
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
        /// <para>Retrieves the details of a data lakehouse table partition.</para>
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
        /// <para>Retrieves the details of a data lakehouse table partition.</para>
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
        /// <para>Retrieves the details of a data lakehouse table partition.</para>
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
        /// <para>Retrieves information about a table in a data lake.</para>
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
        /// <para>Retrieves information about a table in a data lake.</para>
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
        /// <para>Retrieves information about a table in a data lake.</para>
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
        /// <para>Retrieves information about a table in a data lake.</para>
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
        /// <para>Submits a task to schedule and run a Notebook file.</para>
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
        /// <para>Submits a task to schedule and run a Notebook file.</para>
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
        /// <para>Submits a task to schedule and run a Notebook file.</para>
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
        /// <para>Submits a task to schedule and run a Notebook file.</para>
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
        /// <para>Retrieves the execution status of a Notebook task.</para>
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
        /// <para>Retrieves the execution status of a Notebook task.</para>
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
        /// <para>Retrieves the execution status of a Notebook task.</para>
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
        /// <para>Retrieves the execution status of a Notebook task.</para>
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
        /// <para>Retrieves the content of a code file from a workspace. The response header includes the file\&quot;s modification time (<c>mtime</c>).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the content of a specified code file from a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWorkspaceCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceCodeResponse
        /// </returns>
        public GetWorkspaceCodeResponse GetWorkspaceCodeWithOptions(GetWorkspaceCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iac))
            {
                query["Iac"] = request.Iac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
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
                Action = "GetWorkspaceCode",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the content of a code file from a workspace. The response header includes the file\&quot;s modification time (<c>mtime</c>).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the content of a specified code file from a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWorkspaceCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceCodeResponse
        /// </returns>
        public async Task<GetWorkspaceCodeResponse> GetWorkspaceCodeWithOptionsAsync(GetWorkspaceCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iac))
            {
                query["Iac"] = request.Iac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
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
                Action = "GetWorkspaceCode",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the content of a code file from a workspace. The response header includes the file\&quot;s modification time (<c>mtime</c>).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the content of a specified code file from a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWorkspaceCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceCodeResponse
        /// </returns>
        public GetWorkspaceCodeResponse GetWorkspaceCode(GetWorkspaceCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkspaceCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the content of a code file from a workspace. The response header includes the file\&quot;s modification time (<c>mtime</c>).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the content of a specified code file from a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWorkspaceCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceCodeResponse
        /// </returns>
        public async Task<GetWorkspaceCodeResponse> GetWorkspaceCodeAsync(GetWorkspaceCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkspaceCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the deployment configuration of a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the deployment configuration of a workspace. The configuration includes details such as repository and branch information, and directories to exclude.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWorkspaceCodePublishSettingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceCodePublishSettingResponse
        /// </returns>
        public GetWorkspaceCodePublishSettingResponse GetWorkspaceCodePublishSettingWithOptions(GetWorkspaceCodePublishSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetWorkspaceCodePublishSetting",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceCodePublishSettingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the deployment configuration of a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the deployment configuration of a workspace. The configuration includes details such as repository and branch information, and directories to exclude.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWorkspaceCodePublishSettingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceCodePublishSettingResponse
        /// </returns>
        public async Task<GetWorkspaceCodePublishSettingResponse> GetWorkspaceCodePublishSettingWithOptionsAsync(GetWorkspaceCodePublishSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetWorkspaceCodePublishSetting",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceCodePublishSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the deployment configuration of a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the deployment configuration of a workspace. The configuration includes details such as repository and branch information, and directories to exclude.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWorkspaceCodePublishSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceCodePublishSettingResponse
        /// </returns>
        public GetWorkspaceCodePublishSettingResponse GetWorkspaceCodePublishSetting(GetWorkspaceCodePublishSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkspaceCodePublishSettingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the deployment configuration of a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation retrieves the deployment configuration of a workspace. The configuration includes details such as repository and branch information, and directories to exclude.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWorkspaceCodePublishSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceCodePublishSettingResponse
        /// </returns>
        public async Task<GetWorkspaceCodePublishSettingResponse> GetWorkspaceCodePublishSettingAsync(GetWorkspaceCodePublishSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkspaceCodePublishSettingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns the quota for a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the resource quotas and instance status for a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWorkspaceQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceQuotaResponse
        /// </returns>
        public GetWorkspaceQuotaResponse GetWorkspaceQuotaWithOptions(GetWorkspaceQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetWorkspaceQuota",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceQuotaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns the quota for a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the resource quotas and instance status for a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWorkspaceQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceQuotaResponse
        /// </returns>
        public async Task<GetWorkspaceQuotaResponse> GetWorkspaceQuotaWithOptionsAsync(GetWorkspaceQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetWorkspaceQuota",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns the quota for a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the resource quotas and instance status for a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWorkspaceQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceQuotaResponse
        /// </returns>
        public GetWorkspaceQuotaResponse GetWorkspaceQuota(GetWorkspaceQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkspaceQuotaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns the quota for a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the resource quotas and instance status for a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetWorkspaceQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceQuotaResponse
        /// </returns>
        public async Task<GetWorkspaceQuotaResponse> GetWorkspaceQuotaAsync(GetWorkspaceQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkspaceQuotaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the available Airflow versions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the available Airflow versions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAirflowVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAirflowVersionsResponse
        /// </returns>
        public ListAirflowVersionsResponse ListAirflowVersionsWithOptions(ListAirflowVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListAirflowVersions",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAirflowVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the available Airflow versions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the available Airflow versions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAirflowVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAirflowVersionsResponse
        /// </returns>
        public async Task<ListAirflowVersionsResponse> ListAirflowVersionsWithOptionsAsync(ListAirflowVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListAirflowVersions",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAirflowVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the available Airflow versions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the available Airflow versions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAirflowVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAirflowVersionsResponse
        /// </returns>
        public ListAirflowVersionsResponse ListAirflowVersions(ListAirflowVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAirflowVersionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the available Airflow versions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the available Airflow versions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListAirflowVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAirflowVersionsResponse
        /// </returns>
        public async Task<ListAirflowVersionsResponse> ListAirflowVersionsAsync(ListAirflowVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAirflowVersionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of Airflow instances in a workspace.</para>
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
        /// <para>Retrieves a list of Airflow instances in a workspace.</para>
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
        /// <para>Retrieves a list of Airflow instances in a workspace.</para>
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
        /// <para>Retrieves a list of Airflow instances in a workspace.</para>
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
        /// <para>ListCustomAgent returns a list of all custom agents from the personal space and workspaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCustomAgentResponse
        /// </returns>
        public ListCustomAgentResponse ListCustomAgentWithOptions(ListCustomAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryAllReleased))
            {
                query["QueryAllReleased"] = request.QueryAllReleased;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "ListCustomAgent",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListCustomAgent returns a list of all custom agents from the personal space and workspaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCustomAgentResponse
        /// </returns>
        public async Task<ListCustomAgentResponse> ListCustomAgentWithOptionsAsync(ListCustomAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryAllReleased))
            {
                query["QueryAllReleased"] = request.QueryAllReleased;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "ListCustomAgent",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListCustomAgent returns a list of all custom agents from the personal space and workspaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCustomAgentResponse
        /// </returns>
        public ListCustomAgentResponse ListCustomAgent(ListCustomAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCustomAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListCustomAgent returns a list of all custom agents from the personal space and workspaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCustomAgentResponse
        /// </returns>
        public async Task<ListCustomAgentResponse> ListCustomAgentAsync(ListCustomAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCustomAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve a list of Data Agent session descriptions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataAgentSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataAgentSessionResponse
        /// </returns>
        public ListDataAgentSessionResponse ListDataAgentSessionWithOptions(ListDataAgentSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndTime))
            {
                query["CreateEndTime"] = request.CreateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartTime))
            {
                query["CreateStartTime"] = request.CreateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAgentId))
            {
                query["CustomAgentId"] = request.CustomAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSaved))
            {
                query["IsSaved"] = request.IsSaved;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
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
                Action = "ListDataAgentSession",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataAgentSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve a list of Data Agent session descriptions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataAgentSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataAgentSessionResponse
        /// </returns>
        public async Task<ListDataAgentSessionResponse> ListDataAgentSessionWithOptionsAsync(ListDataAgentSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndTime))
            {
                query["CreateEndTime"] = request.CreateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartTime))
            {
                query["CreateStartTime"] = request.CreateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAgentId))
            {
                query["CustomAgentId"] = request.CustomAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSaved))
            {
                query["IsSaved"] = request.IsSaved;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
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
                Action = "ListDataAgentSession",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataAgentSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve a list of Data Agent session descriptions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataAgentSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataAgentSessionResponse
        /// </returns>
        public ListDataAgentSessionResponse ListDataAgentSession(ListDataAgentSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataAgentSessionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve a list of Data Agent session descriptions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataAgentSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataAgentSessionResponse
        /// </returns>
        public async Task<ListDataAgentSessionResponse> ListDataAgentSessionAsync(ListDataAgentSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataAgentSessionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves paginated collaboration workspaces for an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataAgentWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataAgentWorkspaceResponse
        /// </returns>
        public ListDataAgentWorkspaceResponse ListDataAgentWorkspaceWithOptions(ListDataAgentWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                query["WorkspaceName"] = request.WorkspaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceType))
            {
                query["WorkspaceType"] = request.WorkspaceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataAgentWorkspace",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataAgentWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves paginated collaboration workspaces for an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataAgentWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataAgentWorkspaceResponse
        /// </returns>
        public async Task<ListDataAgentWorkspaceResponse> ListDataAgentWorkspaceWithOptionsAsync(ListDataAgentWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                query["WorkspaceName"] = request.WorkspaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceType))
            {
                query["WorkspaceType"] = request.WorkspaceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataAgentWorkspace",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataAgentWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves paginated collaboration workspaces for an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataAgentWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataAgentWorkspaceResponse
        /// </returns>
        public ListDataAgentWorkspaceResponse ListDataAgentWorkspace(ListDataAgentWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataAgentWorkspaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves paginated collaboration workspaces for an Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataAgentWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataAgentWorkspaceResponse
        /// </returns>
        public async Task<ListDataAgentWorkspaceResponse> ListDataAgentWorkspaceAsync(ListDataAgentWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataAgentWorkspaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all members in a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataAgentWorkspaceMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataAgentWorkspaceMemberResponse
        /// </returns>
        public ListDataAgentWorkspaceMemberResponse ListDataAgentWorkspaceMemberWithOptions(ListDataAgentWorkspaceMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMemberId))
            {
                query["SearchMemberId"] = request.SearchMemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchRoleName))
            {
                query["SearchRoleName"] = request.SearchRoleName;
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
                Action = "ListDataAgentWorkspaceMember",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataAgentWorkspaceMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all members in a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataAgentWorkspaceMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataAgentWorkspaceMemberResponse
        /// </returns>
        public async Task<ListDataAgentWorkspaceMemberResponse> ListDataAgentWorkspaceMemberWithOptionsAsync(ListDataAgentWorkspaceMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMemberId))
            {
                query["SearchMemberId"] = request.SearchMemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchRoleName))
            {
                query["SearchRoleName"] = request.SearchRoleName;
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
                Action = "ListDataAgentWorkspaceMember",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataAgentWorkspaceMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all members in a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataAgentWorkspaceMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataAgentWorkspaceMemberResponse
        /// </returns>
        public ListDataAgentWorkspaceMemberResponse ListDataAgentWorkspaceMember(ListDataAgentWorkspaceMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataAgentWorkspaceMemberWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all members in a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataAgentWorkspaceMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataAgentWorkspaceMemberResponse
        /// </returns>
        public async Task<ListDataAgentWorkspaceMemberResponse> ListDataAgentWorkspaceMemberAsync(ListDataAgentWorkspaceMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataAgentWorkspaceMemberWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists user-uploaded files in a data center, excluding databases.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataCenterDatabaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataCenterDatabaseResponse
        /// </returns>
        public ListDataCenterDatabaseResponse ListDataCenterDatabaseWithOptions(ListDataCenterDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallFrom))
            {
                query["CallFrom"] = request.CallFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DmsUnit))
            {
                query["DmsUnit"] = request.DmsUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportType))
            {
                query["ImportType"] = request.ImportType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataCenterDatabase",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataCenterDatabaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists user-uploaded files in a data center, excluding databases.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataCenterDatabaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataCenterDatabaseResponse
        /// </returns>
        public async Task<ListDataCenterDatabaseResponse> ListDataCenterDatabaseWithOptionsAsync(ListDataCenterDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallFrom))
            {
                query["CallFrom"] = request.CallFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DmsUnit))
            {
                query["DmsUnit"] = request.DmsUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportType))
            {
                query["ImportType"] = request.ImportType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataCenterDatabase",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataCenterDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists user-uploaded files in a data center, excluding databases.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataCenterDatabaseRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataCenterDatabaseResponse
        /// </returns>
        public ListDataCenterDatabaseResponse ListDataCenterDatabase(ListDataCenterDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataCenterDatabaseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists user-uploaded files in a data center, excluding databases.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataCenterDatabaseRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataCenterDatabaseResponse
        /// </returns>
        public async Task<ListDataCenterDatabaseResponse> ListDataCenterDatabaseAsync(ListDataCenterDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataCenterDatabaseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of user-uploaded tables from the data center, for file types only.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataCenterTableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataCenterTableResponse
        /// </returns>
        public ListDataCenterTableResponse ListDataCenterTableWithOptions(ListDataCenterTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallFrom))
            {
                query["CallFrom"] = request.CallFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DmsUnit))
            {
                query["DmsUnit"] = request.DmsUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportType))
            {
                query["ImportType"] = request.ImportType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
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
                Action = "ListDataCenterTable",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataCenterTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of user-uploaded tables from the data center, for file types only.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataCenterTableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataCenterTableResponse
        /// </returns>
        public async Task<ListDataCenterTableResponse> ListDataCenterTableWithOptionsAsync(ListDataCenterTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallFrom))
            {
                query["CallFrom"] = request.CallFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DmsUnit))
            {
                query["DmsUnit"] = request.DmsUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportType))
            {
                query["ImportType"] = request.ImportType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
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
                Action = "ListDataCenterTable",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataCenterTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of user-uploaded tables from the data center, for file types only.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataCenterTableRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataCenterTableResponse
        /// </returns>
        public ListDataCenterTableResponse ListDataCenterTable(ListDataCenterTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataCenterTableWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of user-uploaded tables from the data center, for file types only.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataCenterTableRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataCenterTableResponse
        /// </returns>
        public async Task<ListDataCenterTableResponse> ListDataCenterTableAsync(ListDataCenterTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataCenterTableWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of data lake catalogs.</para>
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
        /// <para>Retrieves a list of data lake catalogs.</para>
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
        /// <para>Retrieves a list of data lake catalogs.</para>
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
        /// <para>Retrieves a list of data lake catalogs.</para>
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
        /// <para>Retrieves a list of databases in a data lake.</para>
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
        /// <para>Retrieves a list of databases in a data lake.</para>
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
        /// <para>Retrieves a list of databases in a data lake.</para>
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
        /// <para>Retrieves a list of databases in a data lake.</para>
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
        /// <para>Retrieves a list of data lake functions.</para>
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
        /// <para>Retrieves a list of data lake functions.</para>
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
        /// <para>Retrieves a list of data lake functions.</para>
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
        /// <para>Retrieves a list of data lake functions.</para>
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
        /// <para>Retrieves a list of data lake function names.</para>
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
        /// <para>Retrieves a list of data lake function names.</para>
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
        /// <para>Retrieves a list of data lake function names.</para>
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
        /// <para>Retrieves a list of data lake function names.</para>
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
        /// <para>Retrieves the list of partitions of a data lake table.</para>
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
        /// <para>Retrieves the list of partitions of a data lake table.</para>
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
        /// <para>Retrieves the list of partitions of a data lake table.</para>
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
        /// <para>Retrieves the list of partitions of a data lake table.</para>
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
        /// <para>Retrieves a list of partitions for a data lake table based on filter conditions.</para>
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
        /// <para>Retrieves a list of partitions for a data lake table based on filter conditions.</para>
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
        /// <para>Retrieves a list of partitions for a data lake table based on filter conditions.</para>
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
        /// <para>Retrieves a list of partitions for a data lake table based on filter conditions.</para>
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
        /// <para>Retrieves a list of partition names for a data lake table.</para>
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
        /// <para>Retrieves a list of partition names for a data lake table.</para>
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
        /// <para>Retrieves a list of partition names for a data lake table.</para>
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
        /// <para>Retrieves a list of partition names for a data lake table.</para>
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
        /// <para>Retrieves a list of data lake tables.</para>
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
        /// <para>Retrieves a list of data lake tables.</para>
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
        /// <para>Retrieves a list of data lake tables.</para>
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
        /// <para>Retrieves a list of data lake tables.</para>
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
        /// <para>Retrieves a list of data lake table names.</para>
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
        /// <para>Retrieves a list of data lake table names.</para>
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
        /// <para>Retrieves a list of data lake table names.</para>
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
        /// <para>Retrieves a list of data lake table names.</para>
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
        /// <para>Retrieves the basic information about tables in a data lake.</para>
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
        /// <para>Retrieves the basic information about tables in a data lake.</para>
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
        /// <para>Retrieves the basic information about tables in a data lake.</para>
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
        /// <para>Retrieves the basic information about tables in a data lake.</para>
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
        /// <para>Queries a list of chunks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDocumentChunksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDocumentChunksResponse
        /// </returns>
        public ListDocumentChunksResponse ListDocumentChunksWithOptions(ListDocumentChunksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkTitlePattern))
            {
                body["ChunkTitlePattern"] = request.ChunkTitlePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentName))
            {
                body["DocumentName"] = request.DocumentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                body["KbUuid"] = request.KbUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortFieldName))
            {
                body["SortFieldName"] = request.SortFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["SortOrder"] = request.SortOrder;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDocumentChunks",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDocumentChunksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of chunks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDocumentChunksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDocumentChunksResponse
        /// </returns>
        public async Task<ListDocumentChunksResponse> ListDocumentChunksWithOptionsAsync(ListDocumentChunksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkTitlePattern))
            {
                body["ChunkTitlePattern"] = request.ChunkTitlePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentName))
            {
                body["DocumentName"] = request.DocumentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                body["KbUuid"] = request.KbUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortFieldName))
            {
                body["SortFieldName"] = request.SortFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["SortOrder"] = request.SortOrder;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDocumentChunks",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDocumentChunksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of chunks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDocumentChunksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDocumentChunksResponse
        /// </returns>
        public ListDocumentChunksResponse ListDocumentChunks(ListDocumentChunksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDocumentChunksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of chunks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDocumentChunksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDocumentChunksResponse
        /// </returns>
        public async Task<ListDocumentChunksResponse> ListDocumentChunksAsync(ListDocumentChunksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDocumentChunksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the documents in a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDocumentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDocumentsResponse
        /// </returns>
        public ListDocumentsResponse ListDocumentsWithOptions(ListDocumentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                body["KbUuid"] = request.KbUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamePattern))
            {
                body["NamePattern"] = request.NamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortFieldName))
            {
                body["SortFieldName"] = request.SortFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["SortOrder"] = request.SortOrder;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDocuments",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDocumentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the documents in a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDocumentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDocumentsResponse
        /// </returns>
        public async Task<ListDocumentsResponse> ListDocumentsWithOptionsAsync(ListDocumentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                body["KbUuid"] = request.KbUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamePattern))
            {
                body["NamePattern"] = request.NamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortFieldName))
            {
                body["SortFieldName"] = request.SortFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["SortOrder"] = request.SortOrder;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDocuments",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDocumentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the documents in a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDocumentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDocumentsResponse
        /// </returns>
        public ListDocumentsResponse ListDocuments(ListDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDocumentsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the documents in a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDocumentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDocumentsResponse
        /// </returns>
        public async Task<ListDocumentsResponse> ListDocumentsAsync(ListDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDocumentsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListFileUpload</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFileUploadRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFileUploadResponse
        /// </returns>
        public ListFileUploadResponse ListFileUploadWithOptions(ListFileUploadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallFrom))
            {
                query["CallFrom"] = request.CallFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DmsUnit))
            {
                query["DmsUnit"] = request.DmsUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadLinkExpire))
            {
                query["DownloadLinkExpire"] = request.DownloadLinkExpire;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileCategory))
            {
                query["FileCategory"] = request.FileCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileFrom))
            {
                query["FileFrom"] = request.FileFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortColumn))
            {
                query["SortColumn"] = request.SortColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortDirection))
            {
                query["SortDirection"] = request.SortDirection;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFileUpload",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFileUploadResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListFileUpload</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFileUploadRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFileUploadResponse
        /// </returns>
        public async Task<ListFileUploadResponse> ListFileUploadWithOptionsAsync(ListFileUploadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallFrom))
            {
                query["CallFrom"] = request.CallFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DmsUnit))
            {
                query["DmsUnit"] = request.DmsUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadLinkExpire))
            {
                query["DownloadLinkExpire"] = request.DownloadLinkExpire;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileCategory))
            {
                query["FileCategory"] = request.FileCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileFrom))
            {
                query["FileFrom"] = request.FileFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortColumn))
            {
                query["SortColumn"] = request.SortColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortDirection))
            {
                query["SortDirection"] = request.SortDirection;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFileUpload",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFileUploadResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListFileUpload</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFileUploadRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFileUploadResponse
        /// </returns>
        public ListFileUploadResponse ListFileUpload(ListFileUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFileUploadWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListFileUpload</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFileUploadRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFileUploadResponse
        /// </returns>
        public async Task<ListFileUploadResponse> ListFileUploadAsync(ListFileUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFileUploadWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns a paginated list of knowledge bases.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKnowledgeBasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBasesResponse
        /// </returns>
        public ListKnowledgeBasesResponse ListKnowledgeBasesWithOptions(ListKnowledgeBasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamePattern))
            {
                body["NamePattern"] = request.NamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortFieldName))
            {
                body["SortFieldName"] = request.SortFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKnowledgeBases",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKnowledgeBasesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns a paginated list of knowledge bases.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKnowledgeBasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBasesResponse
        /// </returns>
        public async Task<ListKnowledgeBasesResponse> ListKnowledgeBasesWithOptionsAsync(ListKnowledgeBasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                body["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamePattern))
            {
                body["NamePattern"] = request.NamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortFieldName))
            {
                body["SortFieldName"] = request.SortFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKnowledgeBases",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKnowledgeBasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns a paginated list of knowledge bases.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKnowledgeBasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBasesResponse
        /// </returns>
        public ListKnowledgeBasesResponse ListKnowledgeBases(ListKnowledgeBasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListKnowledgeBasesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Returns a paginated list of knowledge bases.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKnowledgeBasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKnowledgeBasesResponse
        /// </returns>
        public async Task<ListKnowledgeBasesResponse> ListKnowledgeBasesAsync(ListKnowledgeBasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListKnowledgeBasesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists code files and directories at a specified path in a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation lists the code files and directories at a specified path in a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWorkspaceCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspaceCodeResponse
        /// </returns>
        public ListWorkspaceCodeResponse ListWorkspaceCodeWithOptions(ListWorkspaceCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
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
                Action = "ListWorkspaceCode",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspaceCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists code files and directories at a specified path in a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation lists the code files and directories at a specified path in a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWorkspaceCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspaceCodeResponse
        /// </returns>
        public async Task<ListWorkspaceCodeResponse> ListWorkspaceCodeWithOptionsAsync(ListWorkspaceCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
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
                Action = "ListWorkspaceCode",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspaceCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists code files and directories at a specified path in a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation lists the code files and directories at a specified path in a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWorkspaceCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspaceCodeResponse
        /// </returns>
        public ListWorkspaceCodeResponse ListWorkspaceCode(ListWorkspaceCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWorkspaceCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists code files and directories at a specified path in a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation lists the code files and directories at a specified path in a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWorkspaceCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspaceCodeResponse
        /// </returns>
        public async Task<ListWorkspaceCodeResponse> ListWorkspaceCodeAsync(ListWorkspaceCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWorkspaceCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify a custom agent in a personal space or workspace</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyCustomAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyCustomAgentResponse
        /// </returns>
        public ModifyCustomAgentResponse ModifyCustomAgentWithOptions(ModifyCustomAgentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyCustomAgentShrinkRequest request = new ModifyCustomAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CallbackConfig))
            {
                request.CallbackConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CallbackConfig, "CallbackConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExecutionConfig))
            {
                request.ExecutionConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExecutionConfig, "ExecutionConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.KnowledgeConfigList))
            {
                request.KnowledgeConfigListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.KnowledgeConfigList, "KnowledgeConfigList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleTaskConfig))
            {
                request.ScheduleTaskConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleTaskConfig, "ScheduleTaskConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackConfigShrink))
            {
                query["CallbackConfig"] = request.CallbackConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAgentId))
            {
                query["CustomAgentId"] = request.CustomAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataJson))
            {
                query["DataJson"] = request.DataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionConfigShrink))
            {
                query["ExecutionConfig"] = request.ExecutionConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instruction))
            {
                query["Instruction"] = request.Instruction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Knowledge))
            {
                query["Knowledge"] = request.Knowledge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeConfigListShrink))
            {
                query["KnowledgeConfigList"] = request.KnowledgeConfigListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedSessionId))
            {
                query["RelatedSessionId"] = request.RelatedSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTaskConfigShrink))
            {
                query["ScheduleTaskConfig"] = request.ScheduleTaskConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextReportConfig))
            {
                query["TextReportConfig"] = request.TextReportConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebReportConfig))
            {
                query["WebReportConfig"] = request.WebReportConfig;
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
                Action = "ModifyCustomAgent",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCustomAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify a custom agent in a personal space or workspace</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyCustomAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyCustomAgentResponse
        /// </returns>
        public async Task<ModifyCustomAgentResponse> ModifyCustomAgentWithOptionsAsync(ModifyCustomAgentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyCustomAgentShrinkRequest request = new ModifyCustomAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CallbackConfig))
            {
                request.CallbackConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CallbackConfig, "CallbackConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExecutionConfig))
            {
                request.ExecutionConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExecutionConfig, "ExecutionConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.KnowledgeConfigList))
            {
                request.KnowledgeConfigListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.KnowledgeConfigList, "KnowledgeConfigList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleTaskConfig))
            {
                request.ScheduleTaskConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleTaskConfig, "ScheduleTaskConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackConfigShrink))
            {
                query["CallbackConfig"] = request.CallbackConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAgentId))
            {
                query["CustomAgentId"] = request.CustomAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataJson))
            {
                query["DataJson"] = request.DataJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionConfigShrink))
            {
                query["ExecutionConfig"] = request.ExecutionConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instruction))
            {
                query["Instruction"] = request.Instruction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Knowledge))
            {
                query["Knowledge"] = request.Knowledge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeConfigListShrink))
            {
                query["KnowledgeConfigList"] = request.KnowledgeConfigListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedSessionId))
            {
                query["RelatedSessionId"] = request.RelatedSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTaskConfigShrink))
            {
                query["ScheduleTaskConfig"] = request.ScheduleTaskConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextReportConfig))
            {
                query["TextReportConfig"] = request.TextReportConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebReportConfig))
            {
                query["WebReportConfig"] = request.WebReportConfig;
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
                Action = "ModifyCustomAgent",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCustomAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify a custom agent in a personal space or workspace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyCustomAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyCustomAgentResponse
        /// </returns>
        public ModifyCustomAgentResponse ModifyCustomAgent(ModifyCustomAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCustomAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify a custom agent in a personal space or workspace</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyCustomAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyCustomAgentResponse
        /// </returns>
        public async Task<ModifyCustomAgentResponse> ModifyCustomAgentAsync(ModifyCustomAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCustomAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Operate custom agents in personal spaces and workspaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateCustomAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateCustomAgentResponse
        /// </returns>
        public OperateCustomAgentResponse OperateCustomAgentWithOptions(OperateCustomAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAgentId))
            {
                query["CustomAgentId"] = request.CustomAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
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
                Action = "OperateCustomAgent",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateCustomAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Operate custom agents in personal spaces and workspaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateCustomAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateCustomAgentResponse
        /// </returns>
        public async Task<OperateCustomAgentResponse> OperateCustomAgentWithOptionsAsync(OperateCustomAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAgentId))
            {
                query["CustomAgentId"] = request.CustomAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
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
                Action = "OperateCustomAgent",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateCustomAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Operate custom agents in personal spaces and workspaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateCustomAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateCustomAgentResponse
        /// </returns>
        public OperateCustomAgentResponse OperateCustomAgent(OperateCustomAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateCustomAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Operate custom agents in personal spaces and workspaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateCustomAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateCustomAgentResponse
        /// </returns>
        public async Task<OperateCustomAgentResponse> OperateCustomAgentAsync(OperateCustomAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateCustomAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Redeploy an Airflow instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Redeploys an Airflow instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RedeployAirflowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RedeployAirflowResponse
        /// </returns>
        public RedeployAirflowResponse RedeployAirflowWithOptions(RedeployAirflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RedeployAirflow",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RedeployAirflowResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Redeploy an Airflow instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Redeploys an Airflow instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RedeployAirflowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RedeployAirflowResponse
        /// </returns>
        public async Task<RedeployAirflowResponse> RedeployAirflowWithOptionsAsync(RedeployAirflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RedeployAirflow",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RedeployAirflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Redeploy an Airflow instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Redeploys an Airflow instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RedeployAirflowRequest
        /// </param>
        /// 
        /// <returns>
        /// RedeployAirflowResponse
        /// </returns>
        public RedeployAirflowResponse RedeployAirflow(RedeployAirflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RedeployAirflowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Redeploy an Airflow instance</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Redeploys an Airflow instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RedeployAirflowRequest
        /// </param>
        /// 
        /// <returns>
        /// RedeployAirflowResponse
        /// </returns>
        public async Task<RedeployAirflowResponse> RedeployAirflowAsync(RedeployAirflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RedeployAirflowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a user from a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveUserToDataAgentWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserToDataAgentWorkspaceResponse
        /// </returns>
        public RemoveUserToDataAgentWorkspaceResponse RemoveUserToDataAgentWorkspaceWithOptions(RemoveUserToDataAgentWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
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
                Action = "RemoveUserToDataAgentWorkspace",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUserToDataAgentWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a user from a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveUserToDataAgentWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserToDataAgentWorkspaceResponse
        /// </returns>
        public async Task<RemoveUserToDataAgentWorkspaceResponse> RemoveUserToDataAgentWorkspaceWithOptionsAsync(RemoveUserToDataAgentWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
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
                Action = "RemoveUserToDataAgentWorkspace",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUserToDataAgentWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a user from a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveUserToDataAgentWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserToDataAgentWorkspaceResponse
        /// </returns>
        public RemoveUserToDataAgentWorkspaceResponse RemoveUserToDataAgentWorkspace(RemoveUserToDataAgentWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveUserToDataAgentWorkspaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes a user from a workspace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveUserToDataAgentWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserToDataAgentWorkspaceResponse
        /// </returns>
        public async Task<RemoveUserToDataAgentWorkspaceResponse> RemoveUserToDataAgentWorkspaceAsync(RemoveUserToDataAgentWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveUserToDataAgentWorkspaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query a knowledge base</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RetrieveKnowledgeBaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetrieveKnowledgeBaseResponse
        /// </returns>
        public RetrieveKnowledgeBaseResponse RetrieveKnowledgeBaseWithOptions(RetrieveKnowledgeBaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                body["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HybridSearch))
            {
                body["HybridSearch"] = request.HybridSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HybridSearchArgs))
            {
                body["HybridSearchArgs"] = request.HybridSearchArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeMetadataFields))
            {
                body["IncludeMetadataFields"] = request.IncludeMetadataFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeVector))
            {
                body["IncludeVector"] = request.IncludeVector;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                body["KbUuid"] = request.KbUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                body["Metrics"] = request.Metrics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallWindow))
            {
                body["RecallWindow"] = request.RecallWindow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankFactor))
            {
                body["RerankFactor"] = request.RerankFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["TopK"] = request.TopK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetrieveKnowledgeBase",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveKnowledgeBaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query a knowledge base</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RetrieveKnowledgeBaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetrieveKnowledgeBaseResponse
        /// </returns>
        public async Task<RetrieveKnowledgeBaseResponse> RetrieveKnowledgeBaseWithOptionsAsync(RetrieveKnowledgeBaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                body["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HybridSearch))
            {
                body["HybridSearch"] = request.HybridSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HybridSearchArgs))
            {
                body["HybridSearchArgs"] = request.HybridSearchArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeMetadataFields))
            {
                body["IncludeMetadataFields"] = request.IncludeMetadataFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeVector))
            {
                body["IncludeVector"] = request.IncludeVector;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                body["KbUuid"] = request.KbUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                body["Metrics"] = request.Metrics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallWindow))
            {
                body["RecallWindow"] = request.RecallWindow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RerankFactor))
            {
                body["RerankFactor"] = request.RerankFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopK))
            {
                body["TopK"] = request.TopK;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetrieveKnowledgeBase",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveKnowledgeBaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query a knowledge base</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RetrieveKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// RetrieveKnowledgeBaseResponse
        /// </returns>
        public RetrieveKnowledgeBaseResponse RetrieveKnowledgeBase(RetrieveKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RetrieveKnowledgeBaseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query a knowledge base</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RetrieveKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// RetrieveKnowledgeBaseResponse
        /// </returns>
        public async Task<RetrieveKnowledgeBaseResponse> RetrieveKnowledgeBaseAsync(RetrieveKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RetrieveKnowledgeBaseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves code in a workspace and creates the file if it does not exist.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Saves code in a workspace and optionally publishes it to a repository.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SaveWorkspaceCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveWorkspaceCodeResponse
        /// </returns>
        public SaveWorkspaceCodeResponse SaveWorkspaceCodeWithOptions(SaveWorkspaceCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                body["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iac))
            {
                body["Iac"] = request.Iac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mtime))
            {
                body["Mtime"] = request.Mtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Repo))
            {
                body["Repo"] = request.Repo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveWorkspaceCode",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveWorkspaceCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves code in a workspace and creates the file if it does not exist.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Saves code in a workspace and optionally publishes it to a repository.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SaveWorkspaceCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveWorkspaceCodeResponse
        /// </returns>
        public async Task<SaveWorkspaceCodeResponse> SaveWorkspaceCodeWithOptionsAsync(SaveWorkspaceCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                body["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iac))
            {
                body["Iac"] = request.Iac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mtime))
            {
                body["Mtime"] = request.Mtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Repo))
            {
                body["Repo"] = request.Repo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveWorkspaceCode",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveWorkspaceCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves code in a workspace and creates the file if it does not exist.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Saves code in a workspace and optionally publishes it to a repository.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SaveWorkspaceCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveWorkspaceCodeResponse
        /// </returns>
        public SaveWorkspaceCodeResponse SaveWorkspaceCode(SaveWorkspaceCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveWorkspaceCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves code in a workspace and creates the file if it does not exist.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Saves code in a workspace and optionally publishes it to a repository.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SaveWorkspaceCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveWorkspaceCodeResponse
        /// </returns>
        public async Task<SaveWorkspaceCodeResponse> SaveWorkspaceCodeAsync(SaveWorkspaceCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveWorkspaceCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a user message to a specified session or ends the session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request</h2>
        /// <list type="bullet">
        /// <item><description>The <c>agent_id</c> and <c>session_id</c> fields are required.</description></item>
        /// <item><description>The <c>message_type</c> field defaults to <c>primary</c>. Set it to <c>additional</c> to append information or to <c>cancel</c> to end the session.</description></item>
        /// <item><description>The <c>reply_to</c> field specifies which agent message the current message is a response to. It defaults to <c>0</c>.</description></item>
        /// <item><description>When <c>message_type</c> is <c>additional</c>, the <c>question</c> field is required.</description></item>
        /// <item><description>Use the <c>quoted_message</c> field to reference a previous user message.</description></item>
        /// <item><description>The optional fields <c>data_source</c>, <c>dms_user</c>, <c>db_metadata</c>, and <c>session_config</c> provide more detailed context.</description></item>
        /// </list>
        /// </description>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSources))
            {
                request.DataSourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSources, "DataSources", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourcesShrink))
            {
                query["DataSources"] = request.DataSourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                query["MessageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentSessionId))
            {
                query["ParentSessionId"] = request.ParentSessionId;
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
        /// <para>Sends a user message to a specified session or ends the session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request</h2>
        /// <list type="bullet">
        /// <item><description>The <c>agent_id</c> and <c>session_id</c> fields are required.</description></item>
        /// <item><description>The <c>message_type</c> field defaults to <c>primary</c>. Set it to <c>additional</c> to append information or to <c>cancel</c> to end the session.</description></item>
        /// <item><description>The <c>reply_to</c> field specifies which agent message the current message is a response to. It defaults to <c>0</c>.</description></item>
        /// <item><description>When <c>message_type</c> is <c>additional</c>, the <c>question</c> field is required.</description></item>
        /// <item><description>Use the <c>quoted_message</c> field to reference a previous user message.</description></item>
        /// <item><description>The optional fields <c>data_source</c>, <c>dms_user</c>, <c>db_metadata</c>, and <c>session_config</c> provide more detailed context.</description></item>
        /// </list>
        /// </description>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSources))
            {
                request.DataSourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSources, "DataSources", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourcesShrink))
            {
                query["DataSources"] = request.DataSourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                query["MessageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentSessionId))
            {
                query["ParentSessionId"] = request.ParentSessionId;
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
        /// <para>Sends a user message to a specified session or ends the session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request</h2>
        /// <list type="bullet">
        /// <item><description>The <c>agent_id</c> and <c>session_id</c> fields are required.</description></item>
        /// <item><description>The <c>message_type</c> field defaults to <c>primary</c>. Set it to <c>additional</c> to append information or to <c>cancel</c> to end the session.</description></item>
        /// <item><description>The <c>reply_to</c> field specifies which agent message the current message is a response to. It defaults to <c>0</c>.</description></item>
        /// <item><description>When <c>message_type</c> is <c>additional</c>, the <c>question</c> field is required.</description></item>
        /// <item><description>Use the <c>quoted_message</c> field to reference a previous user message.</description></item>
        /// <item><description>The optional fields <c>data_source</c>, <c>dms_user</c>, <c>db_metadata</c>, and <c>session_config</c> provide more detailed context.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Sends a user message to a specified session or ends the session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request</h2>
        /// <list type="bullet">
        /// <item><description>The <c>agent_id</c> and <c>session_id</c> fields are required.</description></item>
        /// <item><description>The <c>message_type</c> field defaults to <c>primary</c>. Set it to <c>additional</c> to append information or to <c>cancel</c> to end the session.</description></item>
        /// <item><description>The <c>reply_to</c> field specifies which agent message the current message is a response to. It defaults to <c>0</c>.</description></item>
        /// <item><description>When <c>message_type</c> is <c>additional</c>, the <c>question</c> field is required.</description></item>
        /// <item><description>Use the <c>quoted_message</c> field to reference a previous user message.</description></item>
        /// <item><description>The optional fields <c>data_source</c>, <c>dms_user</c>, <c>db_metadata</c>, and <c>session_config</c> provide more detailed context.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Sets the code deployment configuration for a workspace. This is an asynchronous operation that returns a key. Use this key to query the operation\&quot;s status by calling the WorkspaceActionStatus operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets the default code deployment configuration for a workspace. This configuration includes the Git repository branch and the directories to exclude from deployment.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetWorkspaceCodePublishSettingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetWorkspaceCodePublishSettingResponse
        /// </returns>
        public SetWorkspaceCodePublishSettingResponse SetWorkspaceCodePublishSettingWithOptions(SetWorkspaceCodePublishSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetWorkspaceCodePublishSetting",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetWorkspaceCodePublishSettingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the code deployment configuration for a workspace. This is an asynchronous operation that returns a key. Use this key to query the operation\&quot;s status by calling the WorkspaceActionStatus operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets the default code deployment configuration for a workspace. This configuration includes the Git repository branch and the directories to exclude from deployment.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetWorkspaceCodePublishSettingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetWorkspaceCodePublishSettingResponse
        /// </returns>
        public async Task<SetWorkspaceCodePublishSettingResponse> SetWorkspaceCodePublishSettingWithOptionsAsync(SetWorkspaceCodePublishSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetWorkspaceCodePublishSetting",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetWorkspaceCodePublishSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the code deployment configuration for a workspace. This is an asynchronous operation that returns a key. Use this key to query the operation\&quot;s status by calling the WorkspaceActionStatus operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets the default code deployment configuration for a workspace. This configuration includes the Git repository branch and the directories to exclude from deployment.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetWorkspaceCodePublishSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// SetWorkspaceCodePublishSettingResponse
        /// </returns>
        public SetWorkspaceCodePublishSettingResponse SetWorkspaceCodePublishSetting(SetWorkspaceCodePublishSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetWorkspaceCodePublishSettingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the code deployment configuration for a workspace. This is an asynchronous operation that returns a key. Use this key to query the operation\&quot;s status by calling the WorkspaceActionStatus operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets the default code deployment configuration for a workspace. This configuration includes the Git repository branch and the directories to exclude from deployment.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetWorkspaceCodePublishSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// SetWorkspaceCodePublishSettingResponse
        /// </returns>
        public async Task<SetWorkspaceCodePublishSettingResponse> SetWorkspaceCodePublishSettingAsync(SetWorkspaceCodePublishSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetWorkspaceCodePublishSettingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the quota for a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets the quota for a specific workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetWorkspaceQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetWorkspaceQuotaResponse
        /// </returns>
        public SetWorkspaceQuotaResponse SetWorkspaceQuotaWithOptions(SetWorkspaceQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CuQuota))
            {
                query["CuQuota"] = request.CuQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
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
                Action = "SetWorkspaceQuota",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetWorkspaceQuotaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the quota for a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets the quota for a specific workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetWorkspaceQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetWorkspaceQuotaResponse
        /// </returns>
        public async Task<SetWorkspaceQuotaResponse> SetWorkspaceQuotaWithOptionsAsync(SetWorkspaceQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CuQuota))
            {
                query["CuQuota"] = request.CuQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
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
                Action = "SetWorkspaceQuota",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetWorkspaceQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the quota for a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets the quota for a specific workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetWorkspaceQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// SetWorkspaceQuotaResponse
        /// </returns>
        public SetWorkspaceQuotaResponse SetWorkspaceQuota(SetWorkspaceQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetWorkspaceQuotaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the quota for a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets the quota for a specific workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetWorkspaceQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// SetWorkspaceQuotaResponse
        /// </returns>
        public async Task<SetWorkspaceQuotaResponse> SetWorkspaceQuotaAsync(SetWorkspaceQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetWorkspaceQuotaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the properties of an Airflow instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateAirflowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAirflowResponse
        /// </returns>
        public UpdateAirflowResponse UpdateAirflowWithOptions(UpdateAirflowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAirflowShrinkRequest request = new UpdateAirflowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataMountInfoList))
            {
                request.DataMountInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataMountInfoList, "DataMountInfoList", "json");
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataMountInfoListShrink))
            {
                query["DataMountInfoList"] = request.DataMountInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableServerless))
            {
                query["EnableServerless"] = request.EnableServerless;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GracefulShutdownTimeout))
            {
                query["GracefulShutdownTimeout"] = request.GracefulShutdownTimeout;
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
        /// <para>Updates the properties of an Airflow instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateAirflowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAirflowResponse
        /// </returns>
        public async Task<UpdateAirflowResponse> UpdateAirflowWithOptionsAsync(UpdateAirflowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAirflowShrinkRequest request = new UpdateAirflowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataMountInfoList))
            {
                request.DataMountInfoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataMountInfoList, "DataMountInfoList", "json");
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataMountInfoListShrink))
            {
                query["DataMountInfoList"] = request.DataMountInfoListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableServerless))
            {
                query["EnableServerless"] = request.EnableServerless;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GracefulShutdownTimeout))
            {
                query["GracefulShutdownTimeout"] = request.GracefulShutdownTimeout;
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
        /// <para>Updates the properties of an Airflow instance.</para>
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
        /// <para>Updates the properties of an Airflow instance.</para>
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
        /// <para>Updates workspace information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataAgentSpaceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataAgentSpaceInfoResponse
        /// </returns>
        public UpdateDataAgentSpaceInfoResponse UpdateDataAgentSpaceInfoWithOptions(UpdateDataAgentSpaceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSessionShareEnabled))
            {
                query["IsSessionShareEnabled"] = request.IsSessionShareEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceDesc))
            {
                query["WorkspaceDesc"] = request.WorkspaceDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                query["WorkspaceName"] = request.WorkspaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataAgentSpaceInfo",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataAgentSpaceInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates workspace information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataAgentSpaceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataAgentSpaceInfoResponse
        /// </returns>
        public async Task<UpdateDataAgentSpaceInfoResponse> UpdateDataAgentSpaceInfoWithOptionsAsync(UpdateDataAgentSpaceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSessionShareEnabled))
            {
                query["IsSessionShareEnabled"] = request.IsSessionShareEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceDesc))
            {
                query["WorkspaceDesc"] = request.WorkspaceDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                query["WorkspaceName"] = request.WorkspaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataAgentSpaceInfo",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataAgentSpaceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates workspace information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataAgentSpaceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataAgentSpaceInfoResponse
        /// </returns>
        public UpdateDataAgentSpaceInfoResponse UpdateDataAgentSpaceInfo(UpdateDataAgentSpaceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataAgentSpaceInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates workspace information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataAgentSpaceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataAgentSpaceInfoResponse
        /// </returns>
        public async Task<UpdateDataAgentSpaceInfoResponse> UpdateDataAgentSpaceInfoAsync(UpdateDataAgentSpaceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataAgentSpaceInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the role of a workspace member.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataAgentWorkspaceMemberRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataAgentWorkspaceMemberRoleResponse
        /// </returns>
        public UpdateDataAgentWorkspaceMemberRoleResponse UpdateDataAgentWorkspaceMemberRoleWithOptions(UpdateDataAgentWorkspaceMemberRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
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
                Action = "UpdateDataAgentWorkspaceMemberRole",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataAgentWorkspaceMemberRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the role of a workspace member.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataAgentWorkspaceMemberRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataAgentWorkspaceMemberRoleResponse
        /// </returns>
        public async Task<UpdateDataAgentWorkspaceMemberRoleResponse> UpdateDataAgentWorkspaceMemberRoleWithOptionsAsync(UpdateDataAgentWorkspaceMemberRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DMSUnit))
            {
                query["DMSUnit"] = request.DMSUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
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
                Action = "UpdateDataAgentWorkspaceMemberRole",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataAgentWorkspaceMemberRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the role of a workspace member.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataAgentWorkspaceMemberRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataAgentWorkspaceMemberRoleResponse
        /// </returns>
        public UpdateDataAgentWorkspaceMemberRoleResponse UpdateDataAgentWorkspaceMemberRole(UpdateDataAgentWorkspaceMemberRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataAgentWorkspaceMemberRoleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the role of a workspace member.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataAgentWorkspaceMemberRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataAgentWorkspaceMemberRoleResponse
        /// </returns>
        public async Task<UpdateDataAgentWorkspaceMemberRoleResponse> UpdateDataAgentWorkspaceMemberRoleAsync(UpdateDataAgentWorkspaceMemberRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataAgentWorkspaceMemberRoleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information of a data lakehouse database.</para>
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
        /// <para>Updates the information of a data lakehouse database.</para>
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
        /// <para>Updates the information of a data lakehouse database.</para>
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
        /// <para>Updates the information of a data lakehouse database.</para>
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
        /// <para>Update a user-defined function in a data lake.</para>
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
        /// <para>Update a user-defined function in a data lake.</para>
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
        /// <para>Update a user-defined function in a data lake.</para>
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
        /// <para>Update a user-defined function in a data lake.</para>
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
        /// <para>Updates the partition information of a data lake table.</para>
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
        /// <para>Updates the partition information of a data lake table.</para>
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
        /// <para>Updates the partition information of a data lake table.</para>
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
        /// <para>Updates the partition information of a data lake table.</para>
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
        /// <para>Updates the information of a data lake table.</para>
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
        /// <para>Updates the information of a data lake table.</para>
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
        /// <para>Updates the information of a data lake table.</para>
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
        /// <para>Updates the information of a data lake table.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the description of a document.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDocumentResponse
        /// </returns>
        public UpdateDocumentResponse UpdateDocumentWithOptions(UpdateDocumentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentName))
            {
                body["DocumentName"] = request.DocumentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                body["KbUuid"] = request.KbUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDescription))
            {
                body["NewDescription"] = request.NewDescription;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDocument",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the description of a document.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDocumentResponse
        /// </returns>
        public async Task<UpdateDocumentResponse> UpdateDocumentWithOptionsAsync(UpdateDocumentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentName))
            {
                body["DocumentName"] = request.DocumentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                body["KbUuid"] = request.KbUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDescription))
            {
                body["NewDescription"] = request.NewDescription;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDocument",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the description of a document.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDocumentResponse
        /// </returns>
        public UpdateDocumentResponse UpdateDocument(UpdateDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDocumentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the description of a document.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDocumentResponse
        /// </returns>
        public async Task<UpdateDocumentResponse> UpdateDocumentAsync(UpdateDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDocumentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseResponse
        /// </returns>
        public UpdateKnowledgeBaseResponse UpdateKnowledgeBaseWithOptions(UpdateKnowledgeBaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                query["KbUuid"] = request.KbUuid;
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
                Action = "UpdateKnowledgeBase",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKnowledgeBaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseResponse
        /// </returns>
        public async Task<UpdateKnowledgeBaseResponse> UpdateKnowledgeBaseWithOptionsAsync(UpdateKnowledgeBaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                query["KbUuid"] = request.KbUuid;
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
                Action = "UpdateKnowledgeBase",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKnowledgeBaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseResponse
        /// </returns>
        public UpdateKnowledgeBaseResponse UpdateKnowledgeBase(UpdateKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateKnowledgeBaseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateKnowledgeBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKnowledgeBaseResponse
        /// </returns>
        public async Task<UpdateKnowledgeBaseResponse> UpdateKnowledgeBaseAsync(UpdateKnowledgeBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateKnowledgeBaseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a document to a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UploadDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadDocumentResponse
        /// </returns>
        public UploadDocumentResponse UploadDocumentWithOptions(UploadDocumentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UploadDocumentShrinkRequest request = new UploadDocumentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Separators))
            {
                request.SeparatorsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Separators, "Separators", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkOverlap))
            {
                body["ChunkOverlap"] = request.ChunkOverlap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkSize))
            {
                body["ChunkSize"] = request.ChunkSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentLoaderName))
            {
                body["DocumentLoaderName"] = request.DocumentLoaderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                body["KbUuid"] = request.KbUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeparatorsShrink))
            {
                body["Separators"] = request.SeparatorsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SplitterModel))
            {
                body["SplitterModel"] = request.SplitterModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextSplitterName))
            {
                body["TextSplitterName"] = request.TextSplitterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VlEnhance))
            {
                body["VlEnhance"] = request.VlEnhance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhTitleEnhance))
            {
                body["ZhTitleEnhance"] = request.ZhTitleEnhance;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadDocument",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a document to a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UploadDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadDocumentResponse
        /// </returns>
        public async Task<UploadDocumentResponse> UploadDocumentWithOptionsAsync(UploadDocumentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UploadDocumentShrinkRequest request = new UploadDocumentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Separators))
            {
                request.SeparatorsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Separators, "Separators", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkOverlap))
            {
                body["ChunkOverlap"] = request.ChunkOverlap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChunkSize))
            {
                body["ChunkSize"] = request.ChunkSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentLoaderName))
            {
                body["DocumentLoaderName"] = request.DocumentLoaderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                body["KbUuid"] = request.KbUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeparatorsShrink))
            {
                body["Separators"] = request.SeparatorsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SplitterModel))
            {
                body["SplitterModel"] = request.SplitterModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextSplitterName))
            {
                body["TextSplitterName"] = request.TextSplitterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VlEnhance))
            {
                body["VlEnhance"] = request.VlEnhance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhTitleEnhance))
            {
                body["ZhTitleEnhance"] = request.ZhTitleEnhance;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadDocument",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a document to a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadDocumentResponse
        /// </returns>
        public UploadDocumentResponse UploadDocument(UploadDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadDocumentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a document to a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadDocumentResponse
        /// </returns>
        public async Task<UploadDocumentResponse> UploadDocumentAsync(UploadDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadDocumentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upserts document chunks into a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpsertDocumentChunksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpsertDocumentChunksResponse
        /// </returns>
        public UpsertDocumentChunksResponse UpsertDocumentChunksWithOptions(UpsertDocumentChunksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Chunks))
            {
                body["Chunks"] = request.Chunks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentName))
            {
                body["DocumentName"] = request.DocumentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                body["KbUuid"] = request.KbUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpsertDocumentChunks",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpsertDocumentChunksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upserts document chunks into a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpsertDocumentChunksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpsertDocumentChunksResponse
        /// </returns>
        public async Task<UpsertDocumentChunksResponse> UpsertDocumentChunksWithOptionsAsync(UpsertDocumentChunksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Chunks))
            {
                body["Chunks"] = request.Chunks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentName))
            {
                body["DocumentName"] = request.DocumentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KbUuid))
            {
                body["KbUuid"] = request.KbUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpsertDocumentChunks",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpsertDocumentChunksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upserts document chunks into a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpsertDocumentChunksRequest
        /// </param>
        /// 
        /// <returns>
        /// UpsertDocumentChunksResponse
        /// </returns>
        public UpsertDocumentChunksResponse UpsertDocumentChunks(UpsertDocumentChunksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpsertDocumentChunksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upserts document chunks into a knowledge base.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpsertDocumentChunksRequest
        /// </param>
        /// 
        /// <returns>
        /// UpsertDocumentChunksResponse
        /// </returns>
        public async Task<UpsertDocumentChunksResponse> UpsertDocumentChunksAsync(UpsertDocumentChunksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpsertDocumentChunksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log of an asynchronous task in a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Pass the <c>key</c> to view the execution log of the corresponding asynchronous task. Use this API for troubleshooting.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// WorkspaceActionLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WorkspaceActionLogResponse
        /// </returns>
        public WorkspaceActionLogResponse WorkspaceActionLogWithOptions(WorkspaceActionLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
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
                Action = "WorkspaceActionLog",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WorkspaceActionLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log of an asynchronous task in a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Pass the <c>key</c> to view the execution log of the corresponding asynchronous task. Use this API for troubleshooting.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// WorkspaceActionLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WorkspaceActionLogResponse
        /// </returns>
        public async Task<WorkspaceActionLogResponse> WorkspaceActionLogWithOptionsAsync(WorkspaceActionLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
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
                Action = "WorkspaceActionLog",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WorkspaceActionLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log of an asynchronous task in a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Pass the <c>key</c> to view the execution log of the corresponding asynchronous task. Use this API for troubleshooting.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// WorkspaceActionLogRequest
        /// </param>
        /// 
        /// <returns>
        /// WorkspaceActionLogResponse
        /// </returns>
        public WorkspaceActionLogResponse WorkspaceActionLog(WorkspaceActionLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return WorkspaceActionLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log of an asynchronous task in a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Pass the <c>key</c> to view the execution log of the corresponding asynchronous task. Use this API for troubleshooting.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// WorkspaceActionLogRequest
        /// </param>
        /// 
        /// <returns>
        /// WorkspaceActionLogResponse
        /// </returns>
        public async Task<WorkspaceActionLogResponse> WorkspaceActionLogAsync(WorkspaceActionLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await WorkspaceActionLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an asynchronous task in a workspace. Operations such as a deployment return a key. Call this operation with the key to retrieve the task\&quot;s status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Provide the key returned by an asynchronous action, such as a deployment, to retrieve the task\&quot;s status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// WorkspaceActionStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WorkspaceActionStatusResponse
        /// </returns>
        public WorkspaceActionStatusResponse WorkspaceActionStatusWithOptions(WorkspaceActionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
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
                Action = "WorkspaceActionStatus",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WorkspaceActionStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an asynchronous task in a workspace. Operations such as a deployment return a key. Call this operation with the key to retrieve the task\&quot;s status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Provide the key returned by an asynchronous action, such as a deployment, to retrieve the task\&quot;s status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// WorkspaceActionStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WorkspaceActionStatusResponse
        /// </returns>
        public async Task<WorkspaceActionStatusResponse> WorkspaceActionStatusWithOptionsAsync(WorkspaceActionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
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
                Action = "WorkspaceActionStatus",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WorkspaceActionStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an asynchronous task in a workspace. Operations such as a deployment return a key. Call this operation with the key to retrieve the task\&quot;s status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Provide the key returned by an asynchronous action, such as a deployment, to retrieve the task\&quot;s status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// WorkspaceActionStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// WorkspaceActionStatusResponse
        /// </returns>
        public WorkspaceActionStatusResponse WorkspaceActionStatus(WorkspaceActionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return WorkspaceActionStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an asynchronous task in a workspace. Operations such as a deployment return a key. Call this operation with the key to retrieve the task\&quot;s status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Provide the key returned by an asynchronous action, such as a deployment, to retrieve the task\&quot;s status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// WorkspaceActionStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// WorkspaceActionStatusResponse
        /// </returns>
        public async Task<WorkspaceActionStatusResponse> WorkspaceActionStatusAsync(WorkspaceActionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await WorkspaceActionStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This asynchronous API returns a key. Use this key to query the WorkspaceActionStatus API for the code deployment status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deploys the code in a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// WorkspaceCodePublishRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WorkspaceCodePublishResponse
        /// </returns>
        public WorkspaceCodePublishResponse WorkspaceCodePublishWithOptions(WorkspaceCodePublishRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WorkspaceCodePublish",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WorkspaceCodePublishResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This asynchronous API returns a key. Use this key to query the WorkspaceActionStatus API for the code deployment status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deploys the code in a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// WorkspaceCodePublishRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WorkspaceCodePublishResponse
        /// </returns>
        public async Task<WorkspaceCodePublishResponse> WorkspaceCodePublishWithOptionsAsync(WorkspaceCodePublishRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WorkspaceCodePublish",
                Version = "2025-04-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WorkspaceCodePublishResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This asynchronous API returns a key. Use this key to query the WorkspaceActionStatus API for the code deployment status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deploys the code in a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// WorkspaceCodePublishRequest
        /// </param>
        /// 
        /// <returns>
        /// WorkspaceCodePublishResponse
        /// </returns>
        public WorkspaceCodePublishResponse WorkspaceCodePublish(WorkspaceCodePublishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return WorkspaceCodePublishWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This asynchronous API returns a key. Use this key to query the WorkspaceActionStatus API for the code deployment status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deploys the code in a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// WorkspaceCodePublishRequest
        /// </param>
        /// 
        /// <returns>
        /// WorkspaceCodePublishResponse
        /// </returns>
        public async Task<WorkspaceCodePublishResponse> WorkspaceCodePublishAsync(WorkspaceCodePublishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await WorkspaceCodePublishWithOptionsAsync(request, runtime);
        }

    }
}
