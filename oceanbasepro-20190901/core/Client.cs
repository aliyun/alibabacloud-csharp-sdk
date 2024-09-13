// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.OceanBasePro20190901.Models;

namespace AlibabaCloud.SDK.OceanBasePro20190901
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("oceanbasepro", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary You can call this operation to close sessions in batches. Please note that this operation is executed asynchronously. After calling this operation, you need to verify it by calling DescribeProcessStatsComposition.
         *
         * @param request BatchKillProcessListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchKillProcessListResponse
         */
        public BatchKillProcessListResponse BatchKillProcessListWithOptions(BatchKillProcessListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionList))
            {
                body["SessionList"] = request.SessionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchKillProcessList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchKillProcessListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to close sessions in batches. Please note that this operation is executed asynchronously. After calling this operation, you need to verify it by calling DescribeProcessStatsComposition.
         *
         * @param request BatchKillProcessListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchKillProcessListResponse
         */
        public async Task<BatchKillProcessListResponse> BatchKillProcessListWithOptionsAsync(BatchKillProcessListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionList))
            {
                body["SessionList"] = request.SessionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchKillProcessList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchKillProcessListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to close sessions in batches. Please note that this operation is executed asynchronously. After calling this operation, you need to verify it by calling DescribeProcessStatsComposition.
         *
         * @param request BatchKillProcessListRequest
         * @return BatchKillProcessListResponse
         */
        public BatchKillProcessListResponse BatchKillProcessList(BatchKillProcessListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchKillProcessListWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to close sessions in batches. Please note that this operation is executed asynchronously. After calling this operation, you need to verify it by calling DescribeProcessStatsComposition.
         *
         * @param request BatchKillProcessListRequest
         * @return BatchKillProcessListResponse
         */
        public async Task<BatchKillProcessListResponse> BatchKillProcessListAsync(BatchKillProcessListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchKillProcessListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to close sessions between the ApsaraDB for OceanBase and the application in batches. Please note that this operation is executed asynchronously. After calling this operation, you need to verify it by calling DescribeSessionList.
         *
         * @param request BatchKillSessionListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchKillSessionListResponse
         */
        public BatchKillSessionListResponse BatchKillSessionListWithOptions(BatchKillSessionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionList))
            {
                body["SessionList"] = request.SessionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchKillSessionList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchKillSessionListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to close sessions between the ApsaraDB for OceanBase and the application in batches. Please note that this operation is executed asynchronously. After calling this operation, you need to verify it by calling DescribeSessionList.
         *
         * @param request BatchKillSessionListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchKillSessionListResponse
         */
        public async Task<BatchKillSessionListResponse> BatchKillSessionListWithOptionsAsync(BatchKillSessionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionList))
            {
                body["SessionList"] = request.SessionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchKillSessionList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchKillSessionListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to close sessions between the ApsaraDB for OceanBase and the application in batches. Please note that this operation is executed asynchronously. After calling this operation, you need to verify it by calling DescribeSessionList.
         *
         * @param request BatchKillSessionListRequest
         * @return BatchKillSessionListResponse
         */
        public BatchKillSessionListResponse BatchKillSessionList(BatchKillSessionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchKillSessionListWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to close sessions between the ApsaraDB for OceanBase and the application in batches. Please note that this operation is executed asynchronously. After calling this operation, you need to verify it by calling DescribeSessionList.
         *
         * @param request BatchKillSessionListRequest
         * @return BatchKillSessionListResponse
         */
        public async Task<BatchKillSessionListResponse> BatchKillSessionListAsync(BatchKillSessionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchKillSessionListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据记录id取消修改操作 （仅支持处于 PENDING 状态的修改记录）
         *
         * @param request CancelProjectModifyRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelProjectModifyRecordResponse
         */
        public CancelProjectModifyRecordResponse CancelProjectModifyRecordWithOptions(CancelProjectModifyRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "CancelProjectModifyRecord",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelProjectModifyRecordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 根据记录id取消修改操作 （仅支持处于 PENDING 状态的修改记录）
         *
         * @param request CancelProjectModifyRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelProjectModifyRecordResponse
         */
        public async Task<CancelProjectModifyRecordResponse> CancelProjectModifyRecordWithOptionsAsync(CancelProjectModifyRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "CancelProjectModifyRecord",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelProjectModifyRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 根据记录id取消修改操作 （仅支持处于 PENDING 状态的修改记录）
         *
         * @param request CancelProjectModifyRecordRequest
         * @return CancelProjectModifyRecordResponse
         */
        public CancelProjectModifyRecordResponse CancelProjectModifyRecord(CancelProjectModifyRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelProjectModifyRecordWithOptions(request, runtime);
        }

        /**
         * @summary 根据记录id取消修改操作 （仅支持处于 PENDING 状态的修改记录）
         *
         * @param request CancelProjectModifyRecordRequest
         * @return CancelProjectModifyRecordResponse
         */
        public async Task<CancelProjectModifyRecordResponse> CancelProjectModifyRecordAsync(CancelProjectModifyRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelProjectModifyRecordWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建备份任务下载链接
         *
         * @param request CreateBackupSetDownloadLinkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateBackupSetDownloadLinkResponse
         */
        public CreateBackupSetDownloadLinkResponse CreateBackupSetDownloadLinkWithOptions(CreateBackupSetDownloadLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                body["BackupSetId"] = request.BackupSetId;
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
                Action = "CreateBackupSetDownloadLink",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBackupSetDownloadLinkResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建备份任务下载链接
         *
         * @param request CreateBackupSetDownloadLinkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateBackupSetDownloadLinkResponse
         */
        public async Task<CreateBackupSetDownloadLinkResponse> CreateBackupSetDownloadLinkWithOptionsAsync(CreateBackupSetDownloadLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupSetId))
            {
                body["BackupSetId"] = request.BackupSetId;
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
                Action = "CreateBackupSetDownloadLink",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBackupSetDownloadLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建备份任务下载链接
         *
         * @param request CreateBackupSetDownloadLinkRequest
         * @return CreateBackupSetDownloadLinkResponse
         */
        public CreateBackupSetDownloadLinkResponse CreateBackupSetDownloadLink(CreateBackupSetDownloadLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBackupSetDownloadLinkWithOptions(request, runtime);
        }

        /**
         * @summary 创建备份任务下载链接
         *
         * @param request CreateBackupSetDownloadLinkRequest
         * @return CreateBackupSetDownloadLinkResponse
         */
        public async Task<CreateBackupSetDownloadLinkResponse> CreateBackupSetDownloadLinkAsync(CreateBackupSetDownloadLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBackupSetDownloadLinkWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The request ID.
         *
         * @param request CreateDatabaseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDatabaseResponse
         */
        public CreateDatabaseResponse CreateDatabaseWithOptions(CreateDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Collation))
            {
                body["Collation"] = request.Collation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Encoding))
            {
                body["Encoding"] = request.Encoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatabase",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatabaseResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The request ID.
         *
         * @param request CreateDatabaseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDatabaseResponse
         */
        public async Task<CreateDatabaseResponse> CreateDatabaseWithOptionsAsync(CreateDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Collation))
            {
                body["Collation"] = request.Collation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Encoding))
            {
                body["Encoding"] = request.Encoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatabase",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The request ID.
         *
         * @param request CreateDatabaseRequest
         * @return CreateDatabaseResponse
         */
        public CreateDatabaseResponse CreateDatabase(CreateDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDatabaseWithOptions(request, runtime);
        }

        /**
         * @summary The request ID.
         *
         * @param request CreateDatabaseRequest
         * @return CreateDatabaseResponse
         */
        public async Task<CreateDatabaseResponse> CreateDatabaseAsync(CreateDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDatabaseWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to create an OceanBase cluster.
         *
         * @param request CreateInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceResponse
         */
        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                body["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuArch))
            {
                body["CpuArch"] = request.CpuArch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                body["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                body["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceClass))
            {
                body["InstanceClass"] = request.InstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationOptimization))
            {
                body["IsolationOptimization"] = request.IsolationOptimization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObVersion))
            {
                body["ObVersion"] = request.ObVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                body["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryInstance))
            {
                body["PrimaryInstance"] = request.PrimaryInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryRegion))
            {
                body["PrimaryRegion"] = request.PrimaryRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaMode))
            {
                body["ReplicaMode"] = request.ReplicaMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Series))
            {
                body["Series"] = request.Series;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Zones))
            {
                body["Zones"] = request.Zones;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to create an OceanBase cluster.
         *
         * @param request CreateInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceResponse
         */
        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                body["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuArch))
            {
                body["CpuArch"] = request.CpuArch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                body["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                body["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceClass))
            {
                body["InstanceClass"] = request.InstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsolationOptimization))
            {
                body["IsolationOptimization"] = request.IsolationOptimization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObVersion))
            {
                body["ObVersion"] = request.ObVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                body["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryInstance))
            {
                body["PrimaryInstance"] = request.PrimaryInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryRegion))
            {
                body["PrimaryRegion"] = request.PrimaryRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaMode))
            {
                body["ReplicaMode"] = request.ReplicaMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Series))
            {
                body["Series"] = request.Series;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Zones))
            {
                body["Zones"] = request.Zones;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to create an OceanBase cluster.
         *
         * @param request CreateInstanceRequest
         * @return CreateInstanceResponse
         */
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to create an OceanBase cluster.
         *
         * @param request CreateInstanceRequest
         * @return CreateInstanceResponse
         */
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建标签
         *
         * @param request CreateLabelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLabelResponse
         */
        public CreateLabelResponse CreateLabelWithOptions(CreateLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLabel",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLabelResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建标签
         *
         * @param request CreateLabelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLabelResponse
         */
        public async Task<CreateLabelResponse> CreateLabelWithOptionsAsync(CreateLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLabel",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLabelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建标签
         *
         * @param request CreateLabelRequest
         * @return CreateLabelResponse
         */
        public CreateLabelResponse CreateLabel(CreateLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLabelWithOptions(request, runtime);
        }

        /**
         * @summary 创建标签
         *
         * @param request CreateLabelRequest
         * @return CreateLabelResponse
         */
        public async Task<CreateLabelResponse> CreateLabelAsync(CreateLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLabelWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建 MySQL 数据源
         *
         * @param request CreateMySqlDataSourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMySqlDataSourceResponse
         */
        public CreateMySqlDataSourceResponse CreateMySqlDataSourceWithOptions(CreateMySqlDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DgInstanceId))
            {
                body["DgInstanceId"] = request.DgInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                body["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schema))
            {
                body["Schema"] = request.Schema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseSsl))
            {
                body["UseSsl"] = request.UseSsl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMySqlDataSource",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMySqlDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建 MySQL 数据源
         *
         * @param request CreateMySqlDataSourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMySqlDataSourceResponse
         */
        public async Task<CreateMySqlDataSourceResponse> CreateMySqlDataSourceWithOptionsAsync(CreateMySqlDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DgInstanceId))
            {
                body["DgInstanceId"] = request.DgInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                body["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schema))
            {
                body["Schema"] = request.Schema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseSsl))
            {
                body["UseSsl"] = request.UseSsl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMySqlDataSource",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMySqlDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建 MySQL 数据源
         *
         * @param request CreateMySqlDataSourceRequest
         * @return CreateMySqlDataSourceResponse
         */
        public CreateMySqlDataSourceResponse CreateMySqlDataSource(CreateMySqlDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMySqlDataSourceWithOptions(request, runtime);
        }

        /**
         * @summary 创建 MySQL 数据源
         *
         * @param request CreateMySqlDataSourceRequest
         * @return CreateMySqlDataSourceResponse
         */
        public async Task<CreateMySqlDataSourceResponse> CreateMySqlDataSourceAsync(CreateMySqlDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMySqlDataSourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建 OceanBase 数据源
         *
         * @param request CreateOceanBaseDataSourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOceanBaseDataSourceResponse
         */
        public CreateOceanBaseDataSourceResponse CreateOceanBaseDataSourceWithOptions(CreateOceanBaseDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cluster))
            {
                body["Cluster"] = request.Cluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigUrl))
            {
                body["ConfigUrl"] = request.ConfigUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrcPassword))
            {
                body["DrcPassword"] = request.DrcPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrcUserName))
            {
                body["DrcUserName"] = request.DrcUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InnerDrcPassword))
            {
                body["InnerDrcPassword"] = request.InnerDrcPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProxyIp))
            {
                body["LogProxyIp"] = request.LogProxyIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProxyPort))
            {
                body["LogProxyPort"] = request.LogProxyPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                body["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenant))
            {
                body["Tenant"] = request.Tenant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOceanBaseDataSource",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOceanBaseDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建 OceanBase 数据源
         *
         * @param request CreateOceanBaseDataSourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOceanBaseDataSourceResponse
         */
        public async Task<CreateOceanBaseDataSourceResponse> CreateOceanBaseDataSourceWithOptionsAsync(CreateOceanBaseDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cluster))
            {
                body["Cluster"] = request.Cluster;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigUrl))
            {
                body["ConfigUrl"] = request.ConfigUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrcPassword))
            {
                body["DrcPassword"] = request.DrcPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrcUserName))
            {
                body["DrcUserName"] = request.DrcUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InnerDrcPassword))
            {
                body["InnerDrcPassword"] = request.InnerDrcPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProxyIp))
            {
                body["LogProxyIp"] = request.LogProxyIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProxyPort))
            {
                body["LogProxyPort"] = request.LogProxyPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                body["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenant))
            {
                body["Tenant"] = request.Tenant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOceanBaseDataSource",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOceanBaseDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建 OceanBase 数据源
         *
         * @param request CreateOceanBaseDataSourceRequest
         * @return CreateOceanBaseDataSourceResponse
         */
        public CreateOceanBaseDataSourceResponse CreateOceanBaseDataSource(CreateOceanBaseDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOceanBaseDataSourceWithOptions(request, runtime);
        }

        /**
         * @summary 创建 OceanBase 数据源
         *
         * @param request CreateOceanBaseDataSourceRequest
         * @return CreateOceanBaseDataSourceResponse
         */
        public async Task<CreateOceanBaseDataSourceResponse> CreateOceanBaseDataSourceAsync(CreateOceanBaseDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOceanBaseDataSourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to create a MySQL data source.
         *
         * @description To call this operation, you must add the IP address of the OceanBase Migration Service (OMS) server to the whitelist of the Alibaba Cloud database instance, the security rules of the ECS instance, or the security settings of your self-managed database (usually the firewall of your self-managed database) to ensure that OMS can successfully access your database instance. To obtain the IP address of the OMS server, go to the OMS data source management page in the OMS console.
         *
         * @param request CreateOmsMysqlDataSourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOmsMysqlDataSourceResponse
         */
        public CreateOmsMysqlDataSourceResponse CreateOmsMysqlDataSourceWithOptions(CreateOmsMysqlDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DgDatabaseId))
            {
                body["DgDatabaseId"] = request.DgDatabaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                body["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schema))
            {
                body["Schema"] = request.Schema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["Username"] = request.Username;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOmsMysqlDataSource",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOmsMysqlDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to create a MySQL data source.
         *
         * @description To call this operation, you must add the IP address of the OceanBase Migration Service (OMS) server to the whitelist of the Alibaba Cloud database instance, the security rules of the ECS instance, or the security settings of your self-managed database (usually the firewall of your self-managed database) to ensure that OMS can successfully access your database instance. To obtain the IP address of the OMS server, go to the OMS data source management page in the OMS console.
         *
         * @param request CreateOmsMysqlDataSourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOmsMysqlDataSourceResponse
         */
        public async Task<CreateOmsMysqlDataSourceResponse> CreateOmsMysqlDataSourceWithOptionsAsync(CreateOmsMysqlDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DgDatabaseId))
            {
                body["DgDatabaseId"] = request.DgDatabaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                body["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schema))
            {
                body["Schema"] = request.Schema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["Username"] = request.Username;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOmsMysqlDataSource",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOmsMysqlDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to create a MySQL data source.
         *
         * @description To call this operation, you must add the IP address of the OceanBase Migration Service (OMS) server to the whitelist of the Alibaba Cloud database instance, the security rules of the ECS instance, or the security settings of your self-managed database (usually the firewall of your self-managed database) to ensure that OMS can successfully access your database instance. To obtain the IP address of the OMS server, go to the OMS data source management page in the OMS console.
         *
         * @param request CreateOmsMysqlDataSourceRequest
         * @return CreateOmsMysqlDataSourceResponse
         */
        public CreateOmsMysqlDataSourceResponse CreateOmsMysqlDataSource(CreateOmsMysqlDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOmsMysqlDataSourceWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to create a MySQL data source.
         *
         * @description To call this operation, you must add the IP address of the OceanBase Migration Service (OMS) server to the whitelist of the Alibaba Cloud database instance, the security rules of the ECS instance, or the security settings of your self-managed database (usually the firewall of your self-managed database) to ensure that OMS can successfully access your database instance. To obtain the IP address of the OMS server, go to the OMS data source management page in the OMS console.
         *
         * @param request CreateOmsMysqlDataSourceRequest
         * @return CreateOmsMysqlDataSourceResponse
         */
        public async Task<CreateOmsMysqlDataSourceResponse> CreateOmsMysqlDataSourceAsync(CreateOmsMysqlDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOmsMysqlDataSourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建项目
         *
         * @param tmpReq CreateProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProjectResponse
         */
        public CreateProjectResponse CreateProjectWithOptions(CreateProjectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateProjectShrinkRequest request = new CreateProjectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CommonTransferConfig))
            {
                request.CommonTransferConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CommonTransferConfig, "CommonTransferConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FullTransferConfig))
            {
                request.FullTransferConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FullTransferConfig, "FullTransferConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IncrTransferConfig))
            {
                request.IncrTransferConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IncrTransferConfig, "IncrTransferConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelIds))
            {
                request.LabelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelIds, "LabelIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReverseIncrTransferConfig))
            {
                request.ReverseIncrTransferConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReverseIncrTransferConfig, "ReverseIncrTransferConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StructTransferConfig))
            {
                request.StructTransferConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StructTransferConfig, "StructTransferConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TransferMapping))
            {
                request.TransferMappingShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TransferMapping, "TransferMapping", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommonTransferConfigShrink))
            {
                body["CommonTransferConfig"] = request.CommonTransferConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableFullTransfer))
            {
                body["EnableFullTransfer"] = request.EnableFullTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableFullVerify))
            {
                body["EnableFullVerify"] = request.EnableFullVerify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableIncrTransfer))
            {
                body["EnableIncrTransfer"] = request.EnableIncrTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableReverseIncrTransfer))
            {
                body["EnableReverseIncrTransfer"] = request.EnableReverseIncrTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableStructTransfer))
            {
                body["EnableStructTransfer"] = request.EnableStructTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FullTransferConfigShrink))
            {
                body["FullTransferConfig"] = request.FullTransferConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncrTransferConfigShrink))
            {
                body["IncrTransferConfig"] = request.IncrTransferConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelIdsShrink))
            {
                body["LabelIds"] = request.LabelIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                body["OssKey"] = request.OssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReverseIncrTransferConfigShrink))
            {
                body["ReverseIncrTransferConfig"] = request.ReverseIncrTransferConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkEndpointId))
            {
                body["SinkEndpointId"] = request.SinkEndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointId))
            {
                body["SourceEndpointId"] = request.SourceEndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructTransferConfigShrink))
            {
                body["StructTransferConfig"] = request.StructTransferConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferMappingShrink))
            {
                body["TransferMapping"] = request.TransferMappingShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseOss))
            {
                body["UseOss"] = request.UseOss;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerGradeId))
            {
                body["WorkerGradeId"] = request.WorkerGradeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建项目
         *
         * @param tmpReq CreateProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProjectResponse
         */
        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(CreateProjectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateProjectShrinkRequest request = new CreateProjectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CommonTransferConfig))
            {
                request.CommonTransferConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CommonTransferConfig, "CommonTransferConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FullTransferConfig))
            {
                request.FullTransferConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FullTransferConfig, "FullTransferConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IncrTransferConfig))
            {
                request.IncrTransferConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IncrTransferConfig, "IncrTransferConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelIds))
            {
                request.LabelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelIds, "LabelIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReverseIncrTransferConfig))
            {
                request.ReverseIncrTransferConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReverseIncrTransferConfig, "ReverseIncrTransferConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StructTransferConfig))
            {
                request.StructTransferConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StructTransferConfig, "StructTransferConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TransferMapping))
            {
                request.TransferMappingShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TransferMapping, "TransferMapping", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommonTransferConfigShrink))
            {
                body["CommonTransferConfig"] = request.CommonTransferConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableFullTransfer))
            {
                body["EnableFullTransfer"] = request.EnableFullTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableFullVerify))
            {
                body["EnableFullVerify"] = request.EnableFullVerify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableIncrTransfer))
            {
                body["EnableIncrTransfer"] = request.EnableIncrTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableReverseIncrTransfer))
            {
                body["EnableReverseIncrTransfer"] = request.EnableReverseIncrTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableStructTransfer))
            {
                body["EnableStructTransfer"] = request.EnableStructTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FullTransferConfigShrink))
            {
                body["FullTransferConfig"] = request.FullTransferConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncrTransferConfigShrink))
            {
                body["IncrTransferConfig"] = request.IncrTransferConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelIdsShrink))
            {
                body["LabelIds"] = request.LabelIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                body["OssKey"] = request.OssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReverseIncrTransferConfigShrink))
            {
                body["ReverseIncrTransferConfig"] = request.ReverseIncrTransferConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkEndpointId))
            {
                body["SinkEndpointId"] = request.SinkEndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointId))
            {
                body["SourceEndpointId"] = request.SourceEndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructTransferConfigShrink))
            {
                body["StructTransferConfig"] = request.StructTransferConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferMappingShrink))
            {
                body["TransferMapping"] = request.TransferMappingShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseOss))
            {
                body["UseOss"] = request.UseOss;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerGradeId))
            {
                body["WorkerGradeId"] = request.WorkerGradeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建项目
         *
         * @param request CreateProjectRequest
         * @return CreateProjectResponse
         */
        public CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProjectWithOptions(request, runtime);
        }

        /**
         * @summary 创建项目
         *
         * @param request CreateProjectRequest
         * @return CreateProjectResponse
         */
        public async Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProjectWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改传输对象（加减表）(仅支持处于 RUNNING/FAILED/SUSPEND 状态的项目)
         *
         * @param tmpReq CreateProjectModifyRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProjectModifyRecordsResponse
         */
        public CreateProjectModifyRecordsResponse CreateProjectModifyRecordsWithOptions(CreateProjectModifyRecordsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateProjectModifyRecordsShrinkRequest request = new CreateProjectModifyRecordsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Databases))
            {
                request.DatabasesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Databases, "Databases", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabasesShrink))
            {
                body["Databases"] = request.DatabasesShrink;
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
                Action = "CreateProjectModifyRecords",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectModifyRecordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改传输对象（加减表）(仅支持处于 RUNNING/FAILED/SUSPEND 状态的项目)
         *
         * @param tmpReq CreateProjectModifyRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProjectModifyRecordsResponse
         */
        public async Task<CreateProjectModifyRecordsResponse> CreateProjectModifyRecordsWithOptionsAsync(CreateProjectModifyRecordsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateProjectModifyRecordsShrinkRequest request = new CreateProjectModifyRecordsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Databases))
            {
                request.DatabasesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Databases, "Databases", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabasesShrink))
            {
                body["Databases"] = request.DatabasesShrink;
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
                Action = "CreateProjectModifyRecords",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectModifyRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改传输对象（加减表）(仅支持处于 RUNNING/FAILED/SUSPEND 状态的项目)
         *
         * @param request CreateProjectModifyRecordsRequest
         * @return CreateProjectModifyRecordsResponse
         */
        public CreateProjectModifyRecordsResponse CreateProjectModifyRecords(CreateProjectModifyRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProjectModifyRecordsWithOptions(request, runtime);
        }

        /**
         * @summary 修改传输对象（加减表）(仅支持处于 RUNNING/FAILED/SUSPEND 状态的项目)
         *
         * @param request CreateProjectModifyRecordsRequest
         * @return CreateProjectModifyRecordsResponse
         */
        public async Task<CreateProjectModifyRecordsResponse> CreateProjectModifyRecordsAsync(CreateProjectModifyRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProjectModifyRecordsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建RDS PG 数据源
         *
         * @param request CreateRdsPostgreSQLDataSourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRdsPostgreSQLDataSourceResponse
         */
        public CreateRdsPostgreSQLDataSourceResponse CreateRdsPostgreSQLDataSourceWithOptions(CreateRdsPostgreSQLDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRdsPostgreSQLDataSource",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRdsPostgreSQLDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建RDS PG 数据源
         *
         * @param request CreateRdsPostgreSQLDataSourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRdsPostgreSQLDataSourceResponse
         */
        public async Task<CreateRdsPostgreSQLDataSourceResponse> CreateRdsPostgreSQLDataSourceWithOptionsAsync(CreateRdsPostgreSQLDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRdsPostgreSQLDataSource",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRdsPostgreSQLDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建RDS PG 数据源
         *
         * @param request CreateRdsPostgreSQLDataSourceRequest
         * @return CreateRdsPostgreSQLDataSourceResponse
         */
        public CreateRdsPostgreSQLDataSourceResponse CreateRdsPostgreSQLDataSource(CreateRdsPostgreSQLDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRdsPostgreSQLDataSourceWithOptions(request, runtime);
        }

        /**
         * @summary 创建RDS PG 数据源
         *
         * @param request CreateRdsPostgreSQLDataSourceRequest
         * @return CreateRdsPostgreSQLDataSourceResponse
         */
        public async Task<CreateRdsPostgreSQLDataSourceResponse> CreateRdsPostgreSQLDataSourceAsync(CreateRdsPostgreSQLDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRdsPostgreSQLDataSourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The name of the whitelist group.
         *
         * @param request CreateSecurityIpGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSecurityIpGroupResponse
         */
        public CreateSecurityIpGroupResponse CreateSecurityIpGroupWithOptions(CreateSecurityIpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIpGroupName))
            {
                body["SecurityIpGroupName"] = request.SecurityIpGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIps))
            {
                body["SecurityIps"] = request.SecurityIps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSecurityIpGroup",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSecurityIpGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The name of the whitelist group.
         *
         * @param request CreateSecurityIpGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSecurityIpGroupResponse
         */
        public async Task<CreateSecurityIpGroupResponse> CreateSecurityIpGroupWithOptionsAsync(CreateSecurityIpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIpGroupName))
            {
                body["SecurityIpGroupName"] = request.SecurityIpGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIps))
            {
                body["SecurityIps"] = request.SecurityIps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSecurityIpGroup",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSecurityIpGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The name of the whitelist group.
         *
         * @param request CreateSecurityIpGroupRequest
         * @return CreateSecurityIpGroupResponse
         */
        public CreateSecurityIpGroupResponse CreateSecurityIpGroup(CreateSecurityIpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSecurityIpGroupWithOptions(request, runtime);
        }

        /**
         * @summary The name of the whitelist group.
         *
         * @param request CreateSecurityIpGroupRequest
         * @return CreateSecurityIpGroupResponse
         */
        public async Task<CreateSecurityIpGroupResponse> CreateSecurityIpGroupAsync(CreateSecurityIpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSecurityIpGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to create a tag group.
         *
         * @param request CreateTagRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTagResponse
         */
        public CreateTagResponse CreateTagWithOptions(CreateTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                body["Key"] = request.Key;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTag",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTagResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to create a tag group.
         *
         * @param request CreateTagRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTagResponse
         */
        public async Task<CreateTagResponse> CreateTagWithOptionsAsync(CreateTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                body["Key"] = request.Key;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTag",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to create a tag group.
         *
         * @param request CreateTagRequest
         * @return CreateTagResponse
         */
        public CreateTagResponse CreateTag(CreateTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTagWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to create a tag group.
         *
         * @param request CreateTagRequest
         * @return CreateTagResponse
         */
        public async Task<CreateTagResponse> CreateTagAsync(CreateTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTagWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to create a tag.
         *
         * @param request CreateTagValueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTagValueResponse
         */
        public CreateTagValueResponse CreateTagValueWithOptions(CreateTagValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                body["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTagValue",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTagValueResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to create a tag.
         *
         * @param request CreateTagValueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTagValueResponse
         */
        public async Task<CreateTagValueResponse> CreateTagValueWithOptionsAsync(CreateTagValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                body["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTagValue",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTagValueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to create a tag.
         *
         * @param request CreateTagValueRequest
         * @return CreateTagValueResponse
         */
        public CreateTagValueResponse CreateTagValue(CreateTagValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTagValueWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to create a tag.
         *
         * @param request CreateTagValueRequest
         * @return CreateTagValueResponse
         */
        public async Task<CreateTagValueResponse> CreateTagValueAsync(CreateTagValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTagValueWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to create a tenant.
         *
         * @param tmpReq CreateTenantRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTenantResponse
         */
        public CreateTenantResponse CreateTenantWithOptions(CreateTenantRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTenantShrinkRequest request = new CreateTenantShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateParams))
            {
                request.CreateParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateParams, "CreateParams", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Charset))
            {
                body["Charset"] = request.Charset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                body["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateParamsShrink))
            {
                body["CreateParams"] = request.CreateParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogDisk))
            {
                body["LogDisk"] = request.LogDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                body["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryZone))
            {
                body["PrimaryZone"] = request.PrimaryZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadOnlyZoneList))
            {
                body["ReadOnlyZoneList"] = request.ReadOnlyZoneList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantMode))
            {
                body["TenantMode"] = request.TenantMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantName))
            {
                body["TenantName"] = request.TenantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                body["TimeZone"] = request.TimeZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitNum))
            {
                body["UnitNum"] = request.UnitNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVSwitchId))
            {
                body["UserVSwitchId"] = request.UserVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpcId))
            {
                body["UserVpcId"] = request.UserVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpcOwnerId))
            {
                body["UserVpcOwnerId"] = request.UserVpcOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTenant",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTenantResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to create a tenant.
         *
         * @param tmpReq CreateTenantRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTenantResponse
         */
        public async Task<CreateTenantResponse> CreateTenantWithOptionsAsync(CreateTenantRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTenantShrinkRequest request = new CreateTenantShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateParams))
            {
                request.CreateParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateParams, "CreateParams", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Charset))
            {
                body["Charset"] = request.Charset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                body["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateParamsShrink))
            {
                body["CreateParams"] = request.CreateParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogDisk))
            {
                body["LogDisk"] = request.LogDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                body["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryZone))
            {
                body["PrimaryZone"] = request.PrimaryZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadOnlyZoneList))
            {
                body["ReadOnlyZoneList"] = request.ReadOnlyZoneList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantMode))
            {
                body["TenantMode"] = request.TenantMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantName))
            {
                body["TenantName"] = request.TenantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                body["TimeZone"] = request.TimeZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitNum))
            {
                body["UnitNum"] = request.UnitNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVSwitchId))
            {
                body["UserVSwitchId"] = request.UserVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpcId))
            {
                body["UserVpcId"] = request.UserVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpcOwnerId))
            {
                body["UserVpcOwnerId"] = request.UserVpcOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTenant",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTenantResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to create a tenant.
         *
         * @param request CreateTenantRequest
         * @return CreateTenantResponse
         */
        public CreateTenantResponse CreateTenant(CreateTenantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTenantWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to create a tenant.
         *
         * @param request CreateTenantRequest
         * @return CreateTenantResponse
         */
        public async Task<CreateTenantResponse> CreateTenantAsync(CreateTenantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTenantWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The request ID.
         *
         * @param request CreateTenantReadOnlyConnectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTenantReadOnlyConnectionResponse
         */
        public CreateTenantReadOnlyConnectionResponse CreateTenantReadOnlyConnectionWithOptions(CreateTenantReadOnlyConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                body["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTenantReadOnlyConnection",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTenantReadOnlyConnectionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The request ID.
         *
         * @param request CreateTenantReadOnlyConnectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTenantReadOnlyConnectionResponse
         */
        public async Task<CreateTenantReadOnlyConnectionResponse> CreateTenantReadOnlyConnectionWithOptionsAsync(CreateTenantReadOnlyConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                body["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTenantReadOnlyConnection",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTenantReadOnlyConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The request ID.
         *
         * @param request CreateTenantReadOnlyConnectionRequest
         * @return CreateTenantReadOnlyConnectionResponse
         */
        public CreateTenantReadOnlyConnectionResponse CreateTenantReadOnlyConnection(CreateTenantReadOnlyConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTenantReadOnlyConnectionWithOptions(request, runtime);
        }

        /**
         * @summary The request ID.
         *
         * @param request CreateTenantReadOnlyConnectionRequest
         * @return CreateTenantReadOnlyConnectionResponse
         */
        public async Task<CreateTenantReadOnlyConnectionResponse> CreateTenantReadOnlyConnectionAsync(CreateTenantReadOnlyConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTenantReadOnlyConnectionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to create the security whitelist for the tenant.
         *
         * @param request CreateTenantSecurityIpGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTenantSecurityIpGroupResponse
         */
        public CreateTenantSecurityIpGroupResponse CreateTenantSecurityIpGroupWithOptions(CreateTenantSecurityIpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIpGroupName))
            {
                body["SecurityIpGroupName"] = request.SecurityIpGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIps))
            {
                body["SecurityIps"] = request.SecurityIps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTenantSecurityIpGroup",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTenantSecurityIpGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to create the security whitelist for the tenant.
         *
         * @param request CreateTenantSecurityIpGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTenantSecurityIpGroupResponse
         */
        public async Task<CreateTenantSecurityIpGroupResponse> CreateTenantSecurityIpGroupWithOptionsAsync(CreateTenantSecurityIpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIpGroupName))
            {
                body["SecurityIpGroupName"] = request.SecurityIpGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIps))
            {
                body["SecurityIps"] = request.SecurityIps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTenantSecurityIpGroup",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTenantSecurityIpGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to create the security whitelist for the tenant.
         *
         * @param request CreateTenantSecurityIpGroupRequest
         * @return CreateTenantSecurityIpGroupResponse
         */
        public CreateTenantSecurityIpGroupResponse CreateTenantSecurityIpGroup(CreateTenantSecurityIpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTenantSecurityIpGroupWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to create the security whitelist for the tenant.
         *
         * @param request CreateTenantSecurityIpGroupRequest
         * @return CreateTenantSecurityIpGroupResponse
         */
        public async Task<CreateTenantSecurityIpGroupResponse> CreateTenantSecurityIpGroupAsync(CreateTenantSecurityIpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTenantSecurityIpGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary CreateTenantUser
         *
         * @param request CreateTenantUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTenantUserResponse
         */
        public CreateTenantUserResponse CreateTenantUserWithOptions(CreateTenantUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionType))
            {
                body["EncryptionType"] = request.EncryptionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Roles))
            {
                body["Roles"] = request.Roles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPassword))
            {
                body["UserPassword"] = request.UserPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                body["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTenantUser",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTenantUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary CreateTenantUser
         *
         * @param request CreateTenantUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTenantUserResponse
         */
        public async Task<CreateTenantUserResponse> CreateTenantUserWithOptionsAsync(CreateTenantUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionType))
            {
                body["EncryptionType"] = request.EncryptionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Roles))
            {
                body["Roles"] = request.Roles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPassword))
            {
                body["UserPassword"] = request.UserPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                body["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTenantUser",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTenantUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary CreateTenantUser
         *
         * @param request CreateTenantUserRequest
         * @return CreateTenantUserResponse
         */
        public CreateTenantUserResponse CreateTenantUser(CreateTenantUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTenantUserWithOptions(request, runtime);
        }

        /**
         * @summary CreateTenantUser
         *
         * @param request CreateTenantUserRequest
         * @return CreateTenantUserResponse
         */
        public async Task<CreateTenantUserResponse> CreateTenantUserAsync(CreateTenantUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTenantUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除数据源
         *
         * @param request DeleteDataSourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDataSourceResponse
         */
        public DeleteDataSourceResponse DeleteDataSourceWithOptions(DeleteDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DeleteDataSource",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除数据源
         *
         * @param request DeleteDataSourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDataSourceResponse
         */
        public async Task<DeleteDataSourceResponse> DeleteDataSourceWithOptionsAsync(DeleteDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DeleteDataSource",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除数据源
         *
         * @param request DeleteDataSourceRequest
         * @return DeleteDataSourceResponse
         */
        public DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataSourceWithOptions(request, runtime);
        }

        /**
         * @summary 删除数据源
         *
         * @param request DeleteDataSourceRequest
         * @return DeleteDataSourceResponse
         */
        public async Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataSourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The request ID.
         *
         * @param request DeleteDatabasesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDatabasesResponse
         */
        public DeleteDatabasesResponse DeleteDatabasesWithOptions(DeleteDatabasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseNames))
            {
                body["DatabaseNames"] = request.DatabaseNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatabases",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatabasesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The request ID.
         *
         * @param request DeleteDatabasesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDatabasesResponse
         */
        public async Task<DeleteDatabasesResponse> DeleteDatabasesWithOptionsAsync(DeleteDatabasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseNames))
            {
                body["DatabaseNames"] = request.DatabaseNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatabases",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatabasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The request ID.
         *
         * @param request DeleteDatabasesRequest
         * @return DeleteDatabasesResponse
         */
        public DeleteDatabasesResponse DeleteDatabases(DeleteDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDatabasesWithOptions(request, runtime);
        }

        /**
         * @summary The request ID.
         *
         * @param request DeleteDatabasesRequest
         * @return DeleteDatabasesResponse
         */
        public async Task<DeleteDatabasesResponse> DeleteDatabasesAsync(DeleteDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDatabasesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to release an OceanBase cluster.
         *
         * @description Before you call this operation, ensure that the following requirements are met:
         * - The cluster is in the Running state.
         * - The cluster is a primary cluster and the billing method is pay-as-you-go.
         *
         * @param request DeleteInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstancesResponse
         */
        public DeleteInstancesResponse DeleteInstancesWithOptions(DeleteInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupRetainMode))
            {
                body["BackupRetainMode"] = request.BackupRetainMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                body["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstances",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to release an OceanBase cluster.
         *
         * @description Before you call this operation, ensure that the following requirements are met:
         * - The cluster is in the Running state.
         * - The cluster is a primary cluster and the billing method is pay-as-you-go.
         *
         * @param request DeleteInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstancesResponse
         */
        public async Task<DeleteInstancesResponse> DeleteInstancesWithOptionsAsync(DeleteInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupRetainMode))
            {
                body["BackupRetainMode"] = request.BackupRetainMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                body["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstances",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to release an OceanBase cluster.
         *
         * @description Before you call this operation, ensure that the following requirements are met:
         * - The cluster is in the Running state.
         * - The cluster is a primary cluster and the billing method is pay-as-you-go.
         *
         * @param request DeleteInstancesRequest
         * @return DeleteInstancesResponse
         */
        public DeleteInstancesResponse DeleteInstances(DeleteInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstancesWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to release an OceanBase cluster.
         *
         * @description Before you call this operation, ensure that the following requirements are met:
         * - The cluster is in the Running state.
         * - The cluster is a primary cluster and the billing method is pay-as-you-go.
         *
         * @param request DeleteInstancesRequest
         * @return DeleteInstancesResponse
         */
        public async Task<DeleteInstancesResponse> DeleteInstancesAsync(DeleteInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除项目
         *
         * @param request DeleteProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProjectResponse
         */
        public DeleteProjectResponse DeleteProjectWithOptions(DeleteProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DeleteProject",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除项目
         *
         * @param request DeleteProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProjectResponse
         */
        public async Task<DeleteProjectResponse> DeleteProjectWithOptionsAsync(DeleteProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DeleteProject",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除项目
         *
         * @param request DeleteProjectRequest
         * @return DeleteProjectResponse
         */
        public DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProjectWithOptions(request, runtime);
        }

        /**
         * @summary 删除项目
         *
         * @param request DeleteProjectRequest
         * @return DeleteProjectResponse
         */
        public async Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProjectWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The name of the deleted IP address whitelist group.
         *
         * @param request DeleteSecurityIpGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSecurityIpGroupResponse
         */
        public DeleteSecurityIpGroupResponse DeleteSecurityIpGroupWithOptions(DeleteSecurityIpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIpGroupName))
            {
                body["SecurityIpGroupName"] = request.SecurityIpGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSecurityIpGroup",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSecurityIpGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The name of the deleted IP address whitelist group.
         *
         * @param request DeleteSecurityIpGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSecurityIpGroupResponse
         */
        public async Task<DeleteSecurityIpGroupResponse> DeleteSecurityIpGroupWithOptionsAsync(DeleteSecurityIpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIpGroupName))
            {
                body["SecurityIpGroupName"] = request.SecurityIpGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSecurityIpGroup",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSecurityIpGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The name of the deleted IP address whitelist group.
         *
         * @param request DeleteSecurityIpGroupRequest
         * @return DeleteSecurityIpGroupResponse
         */
        public DeleteSecurityIpGroupResponse DeleteSecurityIpGroup(DeleteSecurityIpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSecurityIpGroupWithOptions(request, runtime);
        }

        /**
         * @summary The name of the deleted IP address whitelist group.
         *
         * @param request DeleteSecurityIpGroupRequest
         * @return DeleteSecurityIpGroupResponse
         */
        public async Task<DeleteSecurityIpGroupResponse> DeleteSecurityIpGroupAsync(DeleteSecurityIpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSecurityIpGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to delete a tag group.
         *
         * @param request DeleteTagRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTagResponse
         */
        public DeleteTagResponse DeleteTagWithOptions(DeleteTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                body["Key"] = request.Key;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTag",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTagResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to delete a tag group.
         *
         * @param request DeleteTagRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTagResponse
         */
        public async Task<DeleteTagResponse> DeleteTagWithOptionsAsync(DeleteTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                body["Key"] = request.Key;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTag",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to delete a tag group.
         *
         * @param request DeleteTagRequest
         * @return DeleteTagResponse
         */
        public DeleteTagResponse DeleteTag(DeleteTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTagWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to delete a tag group.
         *
         * @param request DeleteTagRequest
         * @return DeleteTagResponse
         */
        public async Task<DeleteTagResponse> DeleteTagAsync(DeleteTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTagWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to delete a tag from a tag group.
         *
         * @param request DeleteTagValueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTagValueResponse
         */
        public DeleteTagValueResponse DeleteTagValueWithOptions(DeleteTagValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                body["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTagValue",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTagValueResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to delete a tag from a tag group.
         *
         * @param request DeleteTagValueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTagValueResponse
         */
        public async Task<DeleteTagValueResponse> DeleteTagValueWithOptionsAsync(DeleteTagValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                body["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTagValue",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTagValueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to delete a tag from a tag group.
         *
         * @param request DeleteTagValueRequest
         * @return DeleteTagValueResponse
         */
        public DeleteTagValueResponse DeleteTagValue(DeleteTagValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTagValueWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to delete a tag from a tag group.
         *
         * @param request DeleteTagValueRequest
         * @return DeleteTagValueResponse
         */
        public async Task<DeleteTagValueResponse> DeleteTagValueAsync(DeleteTagValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTagValueWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to delete the information on the whitelist group of the tenant.
         *
         * @param request DeleteTenantSecurityIpGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTenantSecurityIpGroupResponse
         */
        public DeleteTenantSecurityIpGroupResponse DeleteTenantSecurityIpGroupWithOptions(DeleteTenantSecurityIpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIpGroupName))
            {
                body["SecurityIpGroupName"] = request.SecurityIpGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTenantSecurityIpGroup",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTenantSecurityIpGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to delete the information on the whitelist group of the tenant.
         *
         * @param request DeleteTenantSecurityIpGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTenantSecurityIpGroupResponse
         */
        public async Task<DeleteTenantSecurityIpGroupResponse> DeleteTenantSecurityIpGroupWithOptionsAsync(DeleteTenantSecurityIpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIpGroupName))
            {
                body["SecurityIpGroupName"] = request.SecurityIpGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTenantSecurityIpGroup",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTenantSecurityIpGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to delete the information on the whitelist group of the tenant.
         *
         * @param request DeleteTenantSecurityIpGroupRequest
         * @return DeleteTenantSecurityIpGroupResponse
         */
        public DeleteTenantSecurityIpGroupResponse DeleteTenantSecurityIpGroup(DeleteTenantSecurityIpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTenantSecurityIpGroupWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to delete the information on the whitelist group of the tenant.
         *
         * @param request DeleteTenantSecurityIpGroupRequest
         * @return DeleteTenantSecurityIpGroupResponse
         */
        public async Task<DeleteTenantSecurityIpGroupResponse> DeleteTenantSecurityIpGroupAsync(DeleteTenantSecurityIpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTenantSecurityIpGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to delete one or more database accounts.
         *
         * @param request DeleteTenantUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTenantUsersResponse
         */
        public DeleteTenantUsersResponse DeleteTenantUsersWithOptions(DeleteTenantUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTenantUsers",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTenantUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to delete one or more database accounts.
         *
         * @param request DeleteTenantUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTenantUsersResponse
         */
        public async Task<DeleteTenantUsersResponse> DeleteTenantUsersWithOptionsAsync(DeleteTenantUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTenantUsers",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTenantUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to delete one or more database accounts.
         *
         * @param request DeleteTenantUsersRequest
         * @return DeleteTenantUsersResponse
         */
        public DeleteTenantUsersResponse DeleteTenantUsers(DeleteTenantUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTenantUsersWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to delete one or more database accounts.
         *
         * @param request DeleteTenantUsersRequest
         * @return DeleteTenantUsersResponse
         */
        public async Task<DeleteTenantUsersResponse> DeleteTenantUsersAsync(DeleteTenantUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTenantUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The return result of the request.
         *
         * @param request DeleteTenantsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTenantsResponse
         */
        public DeleteTenantsResponse DeleteTenantsWithOptions(DeleteTenantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantIds))
            {
                body["TenantIds"] = request.TenantIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTenants",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTenantsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The return result of the request.
         *
         * @param request DeleteTenantsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTenantsResponse
         */
        public async Task<DeleteTenantsResponse> DeleteTenantsWithOptionsAsync(DeleteTenantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantIds))
            {
                body["TenantIds"] = request.TenantIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTenants",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTenantsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The return result of the request.
         *
         * @param request DeleteTenantsRequest
         * @return DeleteTenantsResponse
         */
        public DeleteTenantsResponse DeleteTenants(DeleteTenantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTenantsWithOptions(request, runtime);
        }

        /**
         * @summary The return result of the request.
         *
         * @param request DeleteTenantsRequest
         * @return DeleteTenantsResponse
         */
        public async Task<DeleteTenantsResponse> DeleteTenantsAsync(DeleteTenantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTenantsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to obtain the list of SQL statements that may have performance problems according to the diagnostic system.
         *
         * @param tmpReq DescribeAnomalySQLListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAnomalySQLListResponse
         */
        public DescribeAnomalySQLListResponse DescribeAnomalySQLListWithOptions(DescribeAnomalySQLListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeAnomalySQLListShrinkRequest request = new DescribeAnomalySQLListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterCondition))
            {
                request.FilterConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterCondition, "FilterCondition", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterConditionShrink))
            {
                body["FilterCondition"] = request.FilterConditionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIp))
            {
                body["NodeIp"] = request.NodeIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SQLId))
            {
                body["SQLId"] = request.SQLId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeyWord))
            {
                body["SearchKeyWord"] = request.SearchKeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchParameter))
            {
                body["SearchParameter"] = request.SearchParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchRule))
            {
                body["SearchRule"] = request.SearchRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                body["SearchValue"] = request.SearchValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortColumn))
            {
                body["SortColumn"] = request.SortColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAnomalySQLList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAnomalySQLListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to obtain the list of SQL statements that may have performance problems according to the diagnostic system.
         *
         * @param tmpReq DescribeAnomalySQLListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAnomalySQLListResponse
         */
        public async Task<DescribeAnomalySQLListResponse> DescribeAnomalySQLListWithOptionsAsync(DescribeAnomalySQLListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeAnomalySQLListShrinkRequest request = new DescribeAnomalySQLListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterCondition))
            {
                request.FilterConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterCondition, "FilterCondition", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterConditionShrink))
            {
                body["FilterCondition"] = request.FilterConditionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIp))
            {
                body["NodeIp"] = request.NodeIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SQLId))
            {
                body["SQLId"] = request.SQLId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeyWord))
            {
                body["SearchKeyWord"] = request.SearchKeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchParameter))
            {
                body["SearchParameter"] = request.SearchParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchRule))
            {
                body["SearchRule"] = request.SearchRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                body["SearchValue"] = request.SearchValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortColumn))
            {
                body["SortColumn"] = request.SortColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAnomalySQLList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAnomalySQLListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to obtain the list of SQL statements that may have performance problems according to the diagnostic system.
         *
         * @param request DescribeAnomalySQLListRequest
         * @return DescribeAnomalySQLListResponse
         */
        public DescribeAnomalySQLListResponse DescribeAnomalySQLList(DescribeAnomalySQLListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAnomalySQLListWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to obtain the list of SQL statements that may have performance problems according to the diagnostic system.
         *
         * @param request DescribeAnomalySQLListRequest
         * @return DescribeAnomalySQLListResponse
         */
        public async Task<DescribeAnomalySQLListResponse> DescribeAnomalySQLListAsync(DescribeAnomalySQLListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAnomalySQLListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The maximum number of CPU cores per resource unit.
         *
         * @param request DescribeAvailableCpuResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAvailableCpuResourceResponse
         */
        public DescribeAvailableCpuResourceResponse DescribeAvailableCpuResourceWithOptions(DescribeAvailableCpuResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyType))
            {
                body["ModifyType"] = request.ModifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableCpuResource",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableCpuResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The maximum number of CPU cores per resource unit.
         *
         * @param request DescribeAvailableCpuResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAvailableCpuResourceResponse
         */
        public async Task<DescribeAvailableCpuResourceResponse> DescribeAvailableCpuResourceWithOptionsAsync(DescribeAvailableCpuResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyType))
            {
                body["ModifyType"] = request.ModifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableCpuResource",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableCpuResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The maximum number of CPU cores per resource unit.
         *
         * @param request DescribeAvailableCpuResourceRequest
         * @return DescribeAvailableCpuResourceResponse
         */
        public DescribeAvailableCpuResourceResponse DescribeAvailableCpuResource(DescribeAvailableCpuResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableCpuResourceWithOptions(request, runtime);
        }

        /**
         * @summary The maximum number of CPU cores per resource unit.
         *
         * @param request DescribeAvailableCpuResourceRequest
         * @return DescribeAvailableCpuResourceResponse
         */
        public async Task<DescribeAvailableCpuResourceResponse> DescribeAvailableCpuResourceAsync(DescribeAvailableCpuResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableCpuResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query the available memory resource of an OceanBase Database tenant.
         *
         * @param request DescribeAvailableMemResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAvailableMemResourceResponse
         */
        public DescribeAvailableMemResourceResponse DescribeAvailableMemResourceWithOptions(DescribeAvailableMemResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuNum))
            {
                body["CpuNum"] = request.CpuNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitNum))
            {
                body["UnitNum"] = request.UnitNum;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableMemResource",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableMemResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the available memory resource of an OceanBase Database tenant.
         *
         * @param request DescribeAvailableMemResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAvailableMemResourceResponse
         */
        public async Task<DescribeAvailableMemResourceResponse> DescribeAvailableMemResourceWithOptionsAsync(DescribeAvailableMemResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuNum))
            {
                body["CpuNum"] = request.CpuNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitNum))
            {
                body["UnitNum"] = request.UnitNum;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableMemResource",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableMemResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the available memory resource of an OceanBase Database tenant.
         *
         * @param request DescribeAvailableMemResourceRequest
         * @return DescribeAvailableMemResourceResponse
         */
        public DescribeAvailableMemResourceResponse DescribeAvailableMemResource(DescribeAvailableMemResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableMemResourceWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query the available memory resource of an OceanBase Database tenant.
         *
         * @param request DescribeAvailableMemResourceRequest
         * @return DescribeAvailableMemResourceResponse
         */
        public async Task<DescribeAvailableMemResourceResponse> DescribeAvailableMemResourceAsync(DescribeAvailableMemResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableMemResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取集群变配页可选配置
         *
         * @param request DescribeAvailableSpecRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAvailableSpecResponse
         */
        public DescribeAvailableSpecResponse DescribeAvailableSpecWithOptions(DescribeAvailableSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spec))
            {
                body["Spec"] = request.Spec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeType))
            {
                body["UpgradeType"] = request.UpgradeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableSpec",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableSpecResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取集群变配页可选配置
         *
         * @param request DescribeAvailableSpecRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAvailableSpecResponse
         */
        public async Task<DescribeAvailableSpecResponse> DescribeAvailableSpecWithOptionsAsync(DescribeAvailableSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spec))
            {
                body["Spec"] = request.Spec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeType))
            {
                body["UpgradeType"] = request.UpgradeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableSpec",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取集群变配页可选配置
         *
         * @param request DescribeAvailableSpecRequest
         * @return DescribeAvailableSpecResponse
         */
        public DescribeAvailableSpecResponse DescribeAvailableSpec(DescribeAvailableSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableSpecWithOptions(request, runtime);
        }

        /**
         * @summary 获取集群变配页可选配置
         *
         * @param request DescribeAvailableSpecRequest
         * @return DescribeAvailableSpecResponse
         */
        public async Task<DescribeAvailableSpecResponse> DescribeAvailableSpecAsync(DescribeAvailableSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableSpecWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取集群售卖页可选配置
         *
         * @param request DescribeAvailableZoneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAvailableZoneResponse
         */
        public DescribeAvailableZoneResponse DescribeAvailableZoneWithOptions(DescribeAvailableZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuArch))
            {
                body["CpuArch"] = request.CpuArch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                body["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObVersion))
            {
                body["ObVersion"] = request.ObVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Series))
            {
                body["Series"] = request.Series;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spec))
            {
                body["Spec"] = request.Spec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableZone",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableZoneResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取集群售卖页可选配置
         *
         * @param request DescribeAvailableZoneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAvailableZoneResponse
         */
        public async Task<DescribeAvailableZoneResponse> DescribeAvailableZoneWithOptionsAsync(DescribeAvailableZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuArch))
            {
                body["CpuArch"] = request.CpuArch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                body["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObVersion))
            {
                body["ObVersion"] = request.ObVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Series))
            {
                body["Series"] = request.Series;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spec))
            {
                body["Spec"] = request.Spec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableZone",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableZoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取集群售卖页可选配置
         *
         * @param request DescribeAvailableZoneRequest
         * @return DescribeAvailableZoneResponse
         */
        public DescribeAvailableZoneResponse DescribeAvailableZone(DescribeAvailableZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableZoneWithOptions(request, runtime);
        }

        /**
         * @summary 获取集群售卖页可选配置
         *
         * @param request DescribeAvailableZoneRequest
         * @return DescribeAvailableZoneResponse
         */
        public async Task<DescribeAvailableZoneResponse> DescribeAvailableZoneAsync(DescribeAvailableZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableZoneWithOptionsAsync(request, runtime);
        }

        /**
         * @summary DescribeBackupEncryptedString
         *
         * @param request DescribeBackupEncryptedStringRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupEncryptedStringResponse
         */
        public DescribeBackupEncryptedStringResponse DescribeBackupEncryptedStringWithOptions(DescribeBackupEncryptedStringRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupEncryptedString",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupEncryptedStringResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary DescribeBackupEncryptedString
         *
         * @param request DescribeBackupEncryptedStringRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupEncryptedStringResponse
         */
        public async Task<DescribeBackupEncryptedStringResponse> DescribeBackupEncryptedStringWithOptionsAsync(DescribeBackupEncryptedStringRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupEncryptedString",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupEncryptedStringResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary DescribeBackupEncryptedString
         *
         * @param request DescribeBackupEncryptedStringRequest
         * @return DescribeBackupEncryptedStringResponse
         */
        public DescribeBackupEncryptedStringResponse DescribeBackupEncryptedString(DescribeBackupEncryptedStringRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupEncryptedStringWithOptions(request, runtime);
        }

        /**
         * @summary DescribeBackupEncryptedString
         *
         * @param request DescribeBackupEncryptedStringRequest
         * @return DescribeBackupEncryptedStringResponse
         */
        public async Task<DescribeBackupEncryptedStringResponse> DescribeBackupEncryptedStringAsync(DescribeBackupEncryptedStringRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupEncryptedStringWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query the link for downloading a backup set of OceanBase Database.
         *
         * @param request DescribeBackupSetDownloadLinkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupSetDownloadLinkResponse
         */
        public DescribeBackupSetDownloadLinkResponse DescribeBackupSetDownloadLinkWithOptions(DescribeBackupSetDownloadLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadTaskId))
            {
                body["DownloadTaskId"] = request.DownloadTaskId;
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
                Action = "DescribeBackupSetDownloadLink",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupSetDownloadLinkResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the link for downloading a backup set of OceanBase Database.
         *
         * @param request DescribeBackupSetDownloadLinkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBackupSetDownloadLinkResponse
         */
        public async Task<DescribeBackupSetDownloadLinkResponse> DescribeBackupSetDownloadLinkWithOptionsAsync(DescribeBackupSetDownloadLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadTaskId))
            {
                body["DownloadTaskId"] = request.DownloadTaskId;
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
                Action = "DescribeBackupSetDownloadLink",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupSetDownloadLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the link for downloading a backup set of OceanBase Database.
         *
         * @param request DescribeBackupSetDownloadLinkRequest
         * @return DescribeBackupSetDownloadLinkResponse
         */
        public DescribeBackupSetDownloadLinkResponse DescribeBackupSetDownloadLink(DescribeBackupSetDownloadLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupSetDownloadLinkWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query the link for downloading a backup set of OceanBase Database.
         *
         * @param request DescribeBackupSetDownloadLinkRequest
         * @return DescribeBackupSetDownloadLinkResponse
         */
        public async Task<DescribeBackupSetDownloadLinkResponse> DescribeBackupSetDownloadLinkAsync(DescribeBackupSetDownloadLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupSetDownloadLinkWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query the character sets of an OceanBase Database tenant.
         *
         * @param request DescribeCharsetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCharsetResponse
         */
        public DescribeCharsetResponse DescribeCharsetWithOptions(DescribeCharsetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Series))
            {
                body["Series"] = request.Series;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantMode))
            {
                body["TenantMode"] = request.TenantMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCharset",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCharsetResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the character sets of an OceanBase Database tenant.
         *
         * @param request DescribeCharsetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCharsetResponse
         */
        public async Task<DescribeCharsetResponse> DescribeCharsetWithOptionsAsync(DescribeCharsetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Series))
            {
                body["Series"] = request.Series;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantMode))
            {
                body["TenantMode"] = request.TenantMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCharset",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCharsetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the character sets of an OceanBase Database tenant.
         *
         * @param request DescribeCharsetRequest
         * @return DescribeCharsetResponse
         */
        public DescribeCharsetResponse DescribeCharset(DescribeCharsetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCharsetWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query the character sets of an OceanBase Database tenant.
         *
         * @param request DescribeCharsetRequest
         * @return DescribeCharsetResponse
         */
        public async Task<DescribeCharsetResponse> DescribeCharsetAsync(DescribeCharsetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCharsetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询备份集信息
         *
         * @param request DescribeDataBackupSetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataBackupSetResponse
         */
        public DescribeDataBackupSetResponse DescribeDataBackupSetWithOptions(DescribeDataBackupSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupObjectType))
            {
                body["BackupObjectType"] = request.BackupObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
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
                Action = "DescribeDataBackupSet",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataBackupSetResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询备份集信息
         *
         * @param request DescribeDataBackupSetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataBackupSetResponse
         */
        public async Task<DescribeDataBackupSetResponse> DescribeDataBackupSetWithOptionsAsync(DescribeDataBackupSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupObjectType))
            {
                body["BackupObjectType"] = request.BackupObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
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
                Action = "DescribeDataBackupSet",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataBackupSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询备份集信息
         *
         * @param request DescribeDataBackupSetRequest
         * @return DescribeDataBackupSetResponse
         */
        public DescribeDataBackupSetResponse DescribeDataBackupSet(DescribeDataBackupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataBackupSetWithOptions(request, runtime);
        }

        /**
         * @summary 查询备份集信息
         *
         * @param request DescribeDataBackupSetRequest
         * @return DescribeDataBackupSetResponse
         */
        public async Task<DescribeDataBackupSetResponse> DescribeDataBackupSetAsync(DescribeDataBackupSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataBackupSetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query databases in a tenant.
         *
         * @param request DescribeDatabasesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDatabasesResponse
         */
        public DescribeDatabasesResponse DescribeDatabasesWithOptions(DescribeDatabasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                body["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithTables))
            {
                body["WithTables"] = request.WithTables;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDatabases",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDatabasesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query databases in a tenant.
         *
         * @param request DescribeDatabasesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDatabasesResponse
         */
        public async Task<DescribeDatabasesResponse> DescribeDatabasesWithOptionsAsync(DescribeDatabasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                body["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithTables))
            {
                body["WithTables"] = request.WithTables;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDatabases",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDatabasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query databases in a tenant.
         *
         * @param request DescribeDatabasesRequest
         * @return DescribeDatabasesResponse
         */
        public DescribeDatabasesResponse DescribeDatabases(DescribeDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDatabasesWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query databases in a tenant.
         *
         * @param request DescribeDatabasesRequest
         * @return DescribeDatabasesResponse
         */
        public async Task<DescribeDatabasesResponse> DescribeDatabasesAsync(DescribeDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDatabasesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The size of used memory in the cluster, in GB.
         *
         * @param request DescribeInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceResponse
         */
        public DescribeInstanceResponse DescribeInstanceWithOptions(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConnectionLimit))
            {
                body["MaxConnectionLimit"] = request.MaxConnectionLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstance",
                Version = "2019-09-01",
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
         * @summary The size of used memory in the cluster, in GB.
         *
         * @param request DescribeInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceResponse
         */
        public async Task<DescribeInstanceResponse> DescribeInstanceWithOptionsAsync(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConnectionLimit))
            {
                body["MaxConnectionLimit"] = request.MaxConnectionLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstance",
                Version = "2019-09-01",
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
         * @summary The size of used memory in the cluster, in GB.
         *
         * @param request DescribeInstanceRequest
         * @return DescribeInstanceResponse
         */
        public DescribeInstanceResponse DescribeInstance(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceWithOptions(request, runtime);
        }

        /**
         * @summary The size of used memory in the cluster, in GB.
         *
         * @param request DescribeInstanceRequest
         * @return DescribeInstanceResponse
         */
        public async Task<DescribeInstanceResponse> DescribeInstanceAsync(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The ID of the zone.
         *
         * @param request DescribeInstanceCreatableZoneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceCreatableZoneResponse
         */
        public DescribeInstanceCreatableZoneResponse DescribeInstanceCreatableZoneWithOptions(DescribeInstanceCreatableZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeInstanceCreatableZone",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceCreatableZoneResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The ID of the zone.
         *
         * @param request DescribeInstanceCreatableZoneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceCreatableZoneResponse
         */
        public async Task<DescribeInstanceCreatableZoneResponse> DescribeInstanceCreatableZoneWithOptionsAsync(DescribeInstanceCreatableZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeInstanceCreatableZone",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceCreatableZoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The ID of the zone.
         *
         * @param request DescribeInstanceCreatableZoneRequest
         * @return DescribeInstanceCreatableZoneResponse
         */
        public DescribeInstanceCreatableZoneResponse DescribeInstanceCreatableZone(DescribeInstanceCreatableZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceCreatableZoneWithOptions(request, runtime);
        }

        /**
         * @summary The ID of the zone.
         *
         * @param request DescribeInstanceCreatableZoneRequest
         * @return DescribeInstanceCreatableZoneResponse
         */
        public async Task<DescribeInstanceCreatableZoneResponse> DescribeInstanceCreatableZoneAsync(DescribeInstanceCreatableZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceCreatableZoneWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询集群SSL配置
         *
         * @param request DescribeInstanceSSLRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceSSLResponse
         */
        public DescribeInstanceSSLResponse DescribeInstanceSSLWithOptions(DescribeInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeInstanceSSL",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceSSLResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询集群SSL配置
         *
         * @param request DescribeInstanceSSLRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceSSLResponse
         */
        public async Task<DescribeInstanceSSLResponse> DescribeInstanceSSLWithOptionsAsync(DescribeInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeInstanceSSL",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceSSLResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询集群SSL配置
         *
         * @param request DescribeInstanceSSLRequest
         * @return DescribeInstanceSSLResponse
         */
        public DescribeInstanceSSLResponse DescribeInstanceSSL(DescribeInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceSSLWithOptions(request, runtime);
        }

        /**
         * @summary 查询集群SSL配置
         *
         * @param request DescribeInstanceSSLRequest
         * @return DescribeInstanceSSLResponse
         */
        public async Task<DescribeInstanceSSLResponse> DescribeInstanceSSLAsync(DescribeInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceSSLWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query security check items of an OceanBase cluster.
         *
         * @param request DescribeInstanceSecurityConfigsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceSecurityConfigsResponse
         */
        public DescribeInstanceSecurityConfigsResponse DescribeInstanceSecurityConfigsWithOptions(DescribeInstanceSecurityConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckId))
            {
                body["CheckId"] = request.CheckId;
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
                Action = "DescribeInstanceSecurityConfigs",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceSecurityConfigsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query security check items of an OceanBase cluster.
         *
         * @param request DescribeInstanceSecurityConfigsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceSecurityConfigsResponse
         */
        public async Task<DescribeInstanceSecurityConfigsResponse> DescribeInstanceSecurityConfigsWithOptionsAsync(DescribeInstanceSecurityConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckId))
            {
                body["CheckId"] = request.CheckId;
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
                Action = "DescribeInstanceSecurityConfigs",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceSecurityConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query security check items of an OceanBase cluster.
         *
         * @param request DescribeInstanceSecurityConfigsRequest
         * @return DescribeInstanceSecurityConfigsResponse
         */
        public DescribeInstanceSecurityConfigsResponse DescribeInstanceSecurityConfigs(DescribeInstanceSecurityConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceSecurityConfigsWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query security check items of an OceanBase cluster.
         *
         * @param request DescribeInstanceSecurityConfigsRequest
         * @return DescribeInstanceSecurityConfigsResponse
         */
        public async Task<DescribeInstanceSecurityConfigsResponse> DescribeInstanceSecurityConfigsAsync(DescribeInstanceSecurityConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceSecurityConfigsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 工作台首页获取用户集群数汇总。
         *
         * @param request DescribeInstanceSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceSummaryResponse
         */
        public DescribeInstanceSummaryResponse DescribeInstanceSummaryWithOptions(DescribeInstanceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DescribeInstanceSummary",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceSummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 工作台首页获取用户集群数汇总。
         *
         * @param request DescribeInstanceSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceSummaryResponse
         */
        public async Task<DescribeInstanceSummaryResponse> DescribeInstanceSummaryWithOptionsAsync(DescribeInstanceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DescribeInstanceSummary",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 工作台首页获取用户集群数汇总。
         *
         * @param request DescribeInstanceSummaryRequest
         * @return DescribeInstanceSummaryResponse
         */
        public DescribeInstanceSummaryResponse DescribeInstanceSummary(DescribeInstanceSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceSummaryWithOptions(request, runtime);
        }

        /**
         * @summary 工作台首页获取用户集群数汇总。
         *
         * @param request DescribeInstanceSummaryRequest
         * @return DescribeInstanceSummaryResponse
         */
        public async Task<DescribeInstanceSummaryResponse> DescribeInstanceSummaryAsync(DescribeInstanceSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceSummaryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query the tags of clusters.
         *
         * @param request DescribeInstanceTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceTagsResponse
         */
        public DescribeInstanceTagsResponse DescribeInstanceTagsWithOptions(DescribeInstanceTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                body["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceTags",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceTagsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the tags of clusters.
         *
         * @param request DescribeInstanceTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceTagsResponse
         */
        public async Task<DescribeInstanceTagsResponse> DescribeInstanceTagsWithOptionsAsync(DescribeInstanceTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                body["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceTags",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the tags of clusters.
         *
         * @param request DescribeInstanceTagsRequest
         * @return DescribeInstanceTagsResponse
         */
        public DescribeInstanceTagsResponse DescribeInstanceTags(DescribeInstanceTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceTagsWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query the tags of clusters.
         *
         * @param request DescribeInstanceTagsRequest
         * @return DescribeInstanceTagsResponse
         */
        public async Task<DescribeInstanceTagsResponse> DescribeInstanceTagsAsync(DescribeInstanceTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceTagsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The return result of the request.
         *
         * @param request DescribeInstanceTenantModesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceTenantModesResponse
         */
        public DescribeInstanceTenantModesResponse DescribeInstanceTenantModesWithOptions(DescribeInstanceTenantModesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeInstanceTenantModes",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceTenantModesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The return result of the request.
         *
         * @param request DescribeInstanceTenantModesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceTenantModesResponse
         */
        public async Task<DescribeInstanceTenantModesResponse> DescribeInstanceTenantModesWithOptionsAsync(DescribeInstanceTenantModesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeInstanceTenantModes",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceTenantModesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The return result of the request.
         *
         * @param request DescribeInstanceTenantModesRequest
         * @return DescribeInstanceTenantModesResponse
         */
        public DescribeInstanceTenantModesResponse DescribeInstanceTenantModes(DescribeInstanceTenantModesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceTenantModesWithOptions(request, runtime);
        }

        /**
         * @summary The return result of the request.
         *
         * @param request DescribeInstanceTenantModesRequest
         * @return DescribeInstanceTenantModesResponse
         */
        public async Task<DescribeInstanceTenantModesResponse> DescribeInstanceTenantModesAsync(DescribeInstanceTenantModesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceTenantModesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The ID of the zone.
         *
         * @param request DescribeInstanceTopologyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceTopologyResponse
         */
        public DescribeInstanceTopologyResponse DescribeInstanceTopologyWithOptions(DescribeInstanceTopologyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeInstanceTopology",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceTopologyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The ID of the zone.
         *
         * @param request DescribeInstanceTopologyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceTopologyResponse
         */
        public async Task<DescribeInstanceTopologyResponse> DescribeInstanceTopologyWithOptionsAsync(DescribeInstanceTopologyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeInstanceTopology",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceTopologyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The ID of the zone.
         *
         * @param request DescribeInstanceTopologyRequest
         * @return DescribeInstanceTopologyResponse
         */
        public DescribeInstanceTopologyResponse DescribeInstanceTopology(DescribeInstanceTopologyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceTopologyWithOptions(request, runtime);
        }

        /**
         * @summary The ID of the zone.
         *
         * @param request DescribeInstanceTopologyRequest
         * @return DescribeInstanceTopologyResponse
         */
        public async Task<DescribeInstanceTopologyResponse> DescribeInstanceTopologyAsync(DescribeInstanceTopologyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceTopologyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to obtain the list of OceanBase clusters.
         *
         * @param request DescribeInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstancesResponse
         */
        public DescribeInstancesResponse DescribeInstancesWithOptions(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                body["SearchKey"] = request.SearchKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstances",
                Version = "2019-09-01",
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
         * @summary You can call this operation to obtain the list of OceanBase clusters.
         *
         * @param request DescribeInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstancesResponse
         */
        public async Task<DescribeInstancesResponse> DescribeInstancesWithOptionsAsync(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                body["SearchKey"] = request.SearchKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstances",
                Version = "2019-09-01",
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
         * @summary You can call this operation to obtain the list of OceanBase clusters.
         *
         * @param request DescribeInstancesRequest
         * @return DescribeInstancesResponse
         */
        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstancesWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to obtain the list of OceanBase clusters.
         *
         * @param request DescribeInstancesRequest
         * @return DescribeInstancesResponse
         */
        public async Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询监控指标数据
         *
         * @param request DescribeMetricsDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMetricsDataResponse
         */
        public DescribeMetricsDataResponse DescribeMetricsDataWithOptions(DescribeMetricsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupByLabels))
            {
                query["GroupByLabels"] = request.GroupByLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                query["Metrics"] = request.Metrics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortMetricKey))
            {
                query["SortMetricKey"] = request.SortMetricKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaType))
            {
                body["ReplicaType"] = request.ReplicaType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMetricsData",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricsDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询监控指标数据
         *
         * @param request DescribeMetricsDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMetricsDataResponse
         */
        public async Task<DescribeMetricsDataResponse> DescribeMetricsDataWithOptionsAsync(DescribeMetricsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupByLabels))
            {
                query["GroupByLabels"] = request.GroupByLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                query["Metrics"] = request.Metrics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortMetricKey))
            {
                query["SortMetricKey"] = request.SortMetricKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicaType))
            {
                body["ReplicaType"] = request.ReplicaType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMetricsData",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMetricsDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询监控指标数据
         *
         * @param request DescribeMetricsDataRequest
         * @return DescribeMetricsDataResponse
         */
        public DescribeMetricsDataResponse DescribeMetricsData(DescribeMetricsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetricsDataWithOptions(request, runtime);
        }

        /**
         * @summary 查询监控指标数据
         *
         * @param request DescribeMetricsDataRequest
         * @return DescribeMetricsDataResponse
         */
        public async Task<DescribeMetricsDataResponse> DescribeMetricsDataAsync(DescribeMetricsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetricsDataWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The list of nodes.
         *
         * @param request DescribeNodeMetricsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNodeMetricsResponse
         */
        public DescribeNodeMetricsResponse DescribeNodeMetricsWithOptions(DescribeNodeMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                body["Metrics"] = request.Metrics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIdList))
            {
                body["NodeIdList"] = request.NodeIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeName))
            {
                body["NodeName"] = request.NodeName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNodeMetrics",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNodeMetricsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The list of nodes.
         *
         * @param request DescribeNodeMetricsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNodeMetricsResponse
         */
        public async Task<DescribeNodeMetricsResponse> DescribeNodeMetricsWithOptionsAsync(DescribeNodeMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                body["Metrics"] = request.Metrics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIdList))
            {
                body["NodeIdList"] = request.NodeIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeName))
            {
                body["NodeName"] = request.NodeName;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNodeMetrics",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNodeMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The list of nodes.
         *
         * @param request DescribeNodeMetricsRequest
         * @return DescribeNodeMetricsResponse
         */
        public DescribeNodeMetricsResponse DescribeNodeMetrics(DescribeNodeMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNodeMetricsWithOptions(request, runtime);
        }

        /**
         * @summary The list of nodes.
         *
         * @param request DescribeNodeMetricsRequest
         * @return DescribeNodeMetricsResponse
         */
        public async Task<DescribeNodeMetricsResponse> DescribeNodeMetricsAsync(DescribeNodeMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNodeMetricsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this API to view the list of SQL statements that are identified as having performance issues by the diagnostic system.
         *
         * @param request DescribeOasAnomalySQLListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOasAnomalySQLListResponse
         */
        public DescribeOasAnomalySQLListResponse DescribeOasAnomalySQLListWithOptions(DescribeOasAnomalySQLListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicSql))
            {
                body["DynamicSql"] = request.DynamicSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterCondition))
            {
                body["FilterCondition"] = request.FilterCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergeDynamicSql))
            {
                body["MergeDynamicSql"] = request.MergeDynamicSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIp))
            {
                body["NodeIp"] = request.NodeIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeyWord))
            {
                body["SearchKeyWord"] = request.SearchKeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchParam))
            {
                body["SearchParam"] = request.SearchParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchRule))
            {
                body["SearchRule"] = request.SearchRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                body["SearchValue"] = request.SearchValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlTextLength))
            {
                body["SqlTextLength"] = request.SqlTextLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOasAnomalySQLList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOasAnomalySQLListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this API to view the list of SQL statements that are identified as having performance issues by the diagnostic system.
         *
         * @param request DescribeOasAnomalySQLListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOasAnomalySQLListResponse
         */
        public async Task<DescribeOasAnomalySQLListResponse> DescribeOasAnomalySQLListWithOptionsAsync(DescribeOasAnomalySQLListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicSql))
            {
                body["DynamicSql"] = request.DynamicSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterCondition))
            {
                body["FilterCondition"] = request.FilterCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergeDynamicSql))
            {
                body["MergeDynamicSql"] = request.MergeDynamicSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIp))
            {
                body["NodeIp"] = request.NodeIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeyWord))
            {
                body["SearchKeyWord"] = request.SearchKeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchParam))
            {
                body["SearchParam"] = request.SearchParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchRule))
            {
                body["SearchRule"] = request.SearchRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                body["SearchValue"] = request.SearchValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlTextLength))
            {
                body["SqlTextLength"] = request.SqlTextLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOasAnomalySQLList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOasAnomalySQLListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this API to view the list of SQL statements that are identified as having performance issues by the diagnostic system.
         *
         * @param request DescribeOasAnomalySQLListRequest
         * @return DescribeOasAnomalySQLListResponse
         */
        public DescribeOasAnomalySQLListResponse DescribeOasAnomalySQLList(DescribeOasAnomalySQLListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOasAnomalySQLListWithOptions(request, runtime);
        }

        /**
         * @summary You can call this API to view the list of SQL statements that are identified as having performance issues by the diagnostic system.
         *
         * @param request DescribeOasAnomalySQLListRequest
         * @return DescribeOasAnomalySQLListResponse
         */
        public async Task<DescribeOasAnomalySQLListResponse> DescribeOasAnomalySQLListAsync(DescribeOasAnomalySQLListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOasAnomalySQLListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this API to query detailed information about the SQL, including the SQL text, related table names, and so on.
         *
         * @param request DescribeOasSQLDetailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOasSQLDetailsResponse
         */
        public DescribeOasSQLDetailsResponse DescribeOasSQLDetailsWithOptions(DescribeOasSQLDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicSql))
            {
                body["DynamicSql"] = request.DynamicSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParseTable))
            {
                body["ParseTable"] = request.ParseTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOasSQLDetails",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOasSQLDetailsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this API to query detailed information about the SQL, including the SQL text, related table names, and so on.
         *
         * @param request DescribeOasSQLDetailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOasSQLDetailsResponse
         */
        public async Task<DescribeOasSQLDetailsResponse> DescribeOasSQLDetailsWithOptionsAsync(DescribeOasSQLDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicSql))
            {
                body["DynamicSql"] = request.DynamicSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParseTable))
            {
                body["ParseTable"] = request.ParseTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOasSQLDetails",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOasSQLDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this API to query detailed information about the SQL, including the SQL text, related table names, and so on.
         *
         * @param request DescribeOasSQLDetailsRequest
         * @return DescribeOasSQLDetailsResponse
         */
        public DescribeOasSQLDetailsResponse DescribeOasSQLDetails(DescribeOasSQLDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOasSQLDetailsWithOptions(request, runtime);
        }

        /**
         * @summary You can call this API to query detailed information about the SQL, including the SQL text, related table names, and so on.
         *
         * @param request DescribeOasSQLDetailsRequest
         * @return DescribeOasSQLDetailsResponse
         */
        public async Task<DescribeOasSQLDetailsResponse> DescribeOasSQLDetailsAsync(DescribeOasSQLDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOasSQLDetailsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this API to view the SQL execution history.
         *
         * @param request DescribeOasSQLHistoryListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOasSQLHistoryListResponse
         */
        public DescribeOasSQLHistoryListResponse DescribeOasSQLHistoryListWithOptions(DescribeOasSQLHistoryListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicSql))
            {
                body["DynamicSql"] = request.DynamicSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIp))
            {
                body["NodeIp"] = request.NodeIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOasSQLHistoryList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOasSQLHistoryListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this API to view the SQL execution history.
         *
         * @param request DescribeOasSQLHistoryListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOasSQLHistoryListResponse
         */
        public async Task<DescribeOasSQLHistoryListResponse> DescribeOasSQLHistoryListWithOptionsAsync(DescribeOasSQLHistoryListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicSql))
            {
                body["DynamicSql"] = request.DynamicSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIp))
            {
                body["NodeIp"] = request.NodeIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOasSQLHistoryList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOasSQLHistoryListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this API to view the SQL execution history.
         *
         * @param request DescribeOasSQLHistoryListRequest
         * @return DescribeOasSQLHistoryListResponse
         */
        public DescribeOasSQLHistoryListResponse DescribeOasSQLHistoryList(DescribeOasSQLHistoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOasSQLHistoryListWithOptions(request, runtime);
        }

        /**
         * @summary You can call this API to view the SQL execution history.
         *
         * @param request DescribeOasSQLHistoryListRequest
         * @return DescribeOasSQLHistoryListResponse
         */
        public async Task<DescribeOasSQLHistoryListResponse> DescribeOasSQLHistoryListAsync(DescribeOasSQLHistoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOasSQLHistoryListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this API to retrieve information about the SQL execution plan stored in the diagnostic system based on the SQL ID.
         *
         * @param request DescribeOasSQLPlansRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOasSQLPlansResponse
         */
        public DescribeOasSQLPlansResponse DescribeOasSQLPlansWithOptions(DescribeOasSQLPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicSql))
            {
                body["DynamicSql"] = request.DynamicSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanUnionHash))
            {
                body["PlanUnionHash"] = request.PlanUnionHash;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnBriefInfo))
            {
                body["ReturnBriefInfo"] = request.ReturnBriefInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOasSQLPlans",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOasSQLPlansResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this API to retrieve information about the SQL execution plan stored in the diagnostic system based on the SQL ID.
         *
         * @param request DescribeOasSQLPlansRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOasSQLPlansResponse
         */
        public async Task<DescribeOasSQLPlansResponse> DescribeOasSQLPlansWithOptionsAsync(DescribeOasSQLPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicSql))
            {
                body["DynamicSql"] = request.DynamicSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanUnionHash))
            {
                body["PlanUnionHash"] = request.PlanUnionHash;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnBriefInfo))
            {
                body["ReturnBriefInfo"] = request.ReturnBriefInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOasSQLPlans",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOasSQLPlansResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this API to retrieve information about the SQL execution plan stored in the diagnostic system based on the SQL ID.
         *
         * @param request DescribeOasSQLPlansRequest
         * @return DescribeOasSQLPlansResponse
         */
        public DescribeOasSQLPlansResponse DescribeOasSQLPlans(DescribeOasSQLPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOasSQLPlansWithOptions(request, runtime);
        }

        /**
         * @summary You can call this API to retrieve information about the SQL execution plan stored in the diagnostic system based on the SQL ID.
         *
         * @param request DescribeOasSQLPlansRequest
         * @return DescribeOasSQLPlansResponse
         */
        public async Task<DescribeOasSQLPlansResponse> DescribeOasSQLPlansAsync(DescribeOasSQLPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOasSQLPlansWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this API to view a list of slow queries.
         *
         * @param request DescribeOasSlowSQLListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOasSlowSQLListResponse
         */
        public DescribeOasSlowSQLListResponse DescribeOasSlowSQLListWithOptions(DescribeOasSlowSQLListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicSql))
            {
                body["DynamicSql"] = request.DynamicSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterCondition))
            {
                body["FilterCondition"] = request.FilterCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergeDynamicSql))
            {
                body["MergeDynamicSql"] = request.MergeDynamicSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIp))
            {
                body["NodeIp"] = request.NodeIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeyWord))
            {
                body["SearchKeyWord"] = request.SearchKeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchParam))
            {
                body["SearchParam"] = request.SearchParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchRule))
            {
                body["SearchRule"] = request.SearchRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                body["SearchValue"] = request.SearchValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlTextLength))
            {
                body["SqlTextLength"] = request.SqlTextLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOasSlowSQLList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOasSlowSQLListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this API to view a list of slow queries.
         *
         * @param request DescribeOasSlowSQLListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOasSlowSQLListResponse
         */
        public async Task<DescribeOasSlowSQLListResponse> DescribeOasSlowSQLListWithOptionsAsync(DescribeOasSlowSQLListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicSql))
            {
                body["DynamicSql"] = request.DynamicSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterCondition))
            {
                body["FilterCondition"] = request.FilterCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergeDynamicSql))
            {
                body["MergeDynamicSql"] = request.MergeDynamicSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIp))
            {
                body["NodeIp"] = request.NodeIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeyWord))
            {
                body["SearchKeyWord"] = request.SearchKeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchParam))
            {
                body["SearchParam"] = request.SearchParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchRule))
            {
                body["SearchRule"] = request.SearchRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                body["SearchValue"] = request.SearchValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlTextLength))
            {
                body["SqlTextLength"] = request.SqlTextLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOasSlowSQLList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOasSlowSQLListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this API to view a list of slow queries.
         *
         * @param request DescribeOasSlowSQLListRequest
         * @return DescribeOasSlowSQLListResponse
         */
        public DescribeOasSlowSQLListResponse DescribeOasSlowSQLList(DescribeOasSlowSQLListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOasSlowSQLListWithOptions(request, runtime);
        }

        /**
         * @summary You can call this API to view a list of slow queries.
         *
         * @param request DescribeOasSlowSQLListRequest
         * @return DescribeOasSlowSQLListResponse
         */
        public async Task<DescribeOasSlowSQLListResponse> DescribeOasSlowSQLListAsync(DescribeOasSlowSQLListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOasSlowSQLListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this API to retrieve the list of data on the SQL execution performance collected by the diagnostic system.
         *
         * @param request DescribeOasTopSQLListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOasTopSQLListResponse
         */
        public DescribeOasTopSQLListResponse DescribeOasTopSQLListWithOptions(DescribeOasTopSQLListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicSql))
            {
                body["DynamicSql"] = request.DynamicSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterCondition))
            {
                body["FilterCondition"] = request.FilterCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergeDynamicSql))
            {
                body["MergeDynamicSql"] = request.MergeDynamicSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIp))
            {
                body["NodeIp"] = request.NodeIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeyWord))
            {
                body["SearchKeyWord"] = request.SearchKeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchParam))
            {
                body["SearchParam"] = request.SearchParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchRule))
            {
                body["SearchRule"] = request.SearchRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                body["SearchValue"] = request.SearchValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlTextLength))
            {
                body["SqlTextLength"] = request.SqlTextLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOasTopSQLList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOasTopSQLListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this API to retrieve the list of data on the SQL execution performance collected by the diagnostic system.
         *
         * @param request DescribeOasTopSQLListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOasTopSQLListResponse
         */
        public async Task<DescribeOasTopSQLListResponse> DescribeOasTopSQLListWithOptionsAsync(DescribeOasTopSQLListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicSql))
            {
                body["DynamicSql"] = request.DynamicSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterCondition))
            {
                body["FilterCondition"] = request.FilterCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergeDynamicSql))
            {
                body["MergeDynamicSql"] = request.MergeDynamicSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIp))
            {
                body["NodeIp"] = request.NodeIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeyWord))
            {
                body["SearchKeyWord"] = request.SearchKeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchParam))
            {
                body["SearchParam"] = request.SearchParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchRule))
            {
                body["SearchRule"] = request.SearchRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                body["SearchValue"] = request.SearchValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlTextLength))
            {
                body["SqlTextLength"] = request.SqlTextLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOasTopSQLList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOasTopSQLListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this API to retrieve the list of data on the SQL execution performance collected by the diagnostic system.
         *
         * @param request DescribeOasTopSQLListRequest
         * @return DescribeOasTopSQLListResponse
         */
        public DescribeOasTopSQLListResponse DescribeOasTopSQLList(DescribeOasTopSQLListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOasTopSQLListWithOptions(request, runtime);
        }

        /**
         * @summary You can call this API to retrieve the list of data on the SQL execution performance collected by the diagnostic system.
         *
         * @param request DescribeOasTopSQLListRequest
         * @return DescribeOasTopSQLListResponse
         */
        public async Task<DescribeOasTopSQLListResponse> DescribeOasTopSQLListAsync(DescribeOasTopSQLListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOasTopSQLListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query the outline binding information or throttling information of an SQL statement in the database based on an SQLID.
         *
         * @param request DescribeOutlineBindingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOutlineBindingResponse
         */
        public DescribeOutlineBindingResponse DescribeOutlineBindingWithOptions(DescribeOutlineBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsConcurrentLimit))
            {
                body["IsConcurrentLimit"] = request.IsConcurrentLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SQLId))
            {
                body["SQLId"] = request.SQLId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOutlineBinding",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOutlineBindingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the outline binding information or throttling information of an SQL statement in the database based on an SQLID.
         *
         * @param request DescribeOutlineBindingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOutlineBindingResponse
         */
        public async Task<DescribeOutlineBindingResponse> DescribeOutlineBindingWithOptionsAsync(DescribeOutlineBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsConcurrentLimit))
            {
                body["IsConcurrentLimit"] = request.IsConcurrentLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SQLId))
            {
                body["SQLId"] = request.SQLId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOutlineBinding",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOutlineBindingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the outline binding information or throttling information of an SQL statement in the database based on an SQLID.
         *
         * @param request DescribeOutlineBindingRequest
         * @return DescribeOutlineBindingResponse
         */
        public DescribeOutlineBindingResponse DescribeOutlineBinding(DescribeOutlineBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOutlineBindingWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query the outline binding information or throttling information of an SQL statement in the database based on an SQLID.
         *
         * @param request DescribeOutlineBindingRequest
         * @return DescribeOutlineBindingResponse
         */
        public async Task<DescribeOutlineBindingResponse> DescribeOutlineBindingAsync(DescribeOutlineBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOutlineBindingWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Indicates whether a restart is required for changes to the parameter to take effect. Valid values: - true: A restart is required. - false: A restart is not required.
         *
         * @param request DescribeParametersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeParametersResponse
         */
        public DescribeParametersResponse DescribeParametersWithOptions(DescribeParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimension))
            {
                body["Dimension"] = request.Dimension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DimensionValue))
            {
                body["DimensionValue"] = request.DimensionValue;
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
                Action = "DescribeParameters",
                Version = "2019-09-01",
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
         * @summary Indicates whether a restart is required for changes to the parameter to take effect. Valid values: - true: A restart is required. - false: A restart is not required.
         *
         * @param request DescribeParametersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeParametersResponse
         */
        public async Task<DescribeParametersResponse> DescribeParametersWithOptionsAsync(DescribeParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimension))
            {
                body["Dimension"] = request.Dimension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DimensionValue))
            {
                body["DimensionValue"] = request.DimensionValue;
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
                Action = "DescribeParameters",
                Version = "2019-09-01",
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
         * @summary Indicates whether a restart is required for changes to the parameter to take effect. Valid values: - true: A restart is required. - false: A restart is not required.
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
         * @summary Indicates whether a restart is required for changes to the parameter to take effect. Valid values: - true: A restart is required. - false: A restart is not required.
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
         * @summary You can call this operation to query the modification history of cluster or tenant parameters.
         *
         * @param request DescribeParametersHistoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeParametersHistoryResponse
         */
        public DescribeParametersHistoryResponse DescribeParametersHistoryWithOptions(DescribeParametersHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimension))
            {
                body["Dimension"] = request.Dimension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DimensionValue))
            {
                body["DimensionValue"] = request.DimensionValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeParametersHistory",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeParametersHistoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the modification history of cluster or tenant parameters.
         *
         * @param request DescribeParametersHistoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeParametersHistoryResponse
         */
        public async Task<DescribeParametersHistoryResponse> DescribeParametersHistoryWithOptionsAsync(DescribeParametersHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimension))
            {
                body["Dimension"] = request.Dimension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DimensionValue))
            {
                body["DimensionValue"] = request.DimensionValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeParametersHistory",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeParametersHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the modification history of cluster or tenant parameters.
         *
         * @param request DescribeParametersHistoryRequest
         * @return DescribeParametersHistoryResponse
         */
        public DescribeParametersHistoryResponse DescribeParametersHistory(DescribeParametersHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeParametersHistoryWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query the modification history of cluster or tenant parameters.
         *
         * @param request DescribeParametersHistoryRequest
         * @return DescribeParametersHistoryResponse
         */
        public async Task<DescribeParametersHistoryResponse> DescribeParametersHistoryAsync(DescribeParametersHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeParametersHistoryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query session information.
         *
         * @param request DescribeProcessStatsCompositionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProcessStatsCompositionResponse
         */
        public DescribeProcessStatsCompositionResponse DescribeProcessStatsCompositionWithOptions(DescribeProcessStatsCompositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                body["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerIp))
            {
                body["ServerIp"] = request.ServerIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlText))
            {
                body["SqlText"] = request.SqlText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UId))
            {
                body["UId"] = request.UId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProcessStatsComposition",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProcessStatsCompositionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query session information.
         *
         * @param request DescribeProcessStatsCompositionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProcessStatsCompositionResponse
         */
        public async Task<DescribeProcessStatsCompositionResponse> DescribeProcessStatsCompositionWithOptionsAsync(DescribeProcessStatsCompositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                body["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerIp))
            {
                body["ServerIp"] = request.ServerIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlText))
            {
                body["SqlText"] = request.SqlText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UId))
            {
                body["UId"] = request.UId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProcessStatsComposition",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProcessStatsCompositionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query session information.
         *
         * @param request DescribeProcessStatsCompositionRequest
         * @return DescribeProcessStatsCompositionResponse
         */
        public DescribeProcessStatsCompositionResponse DescribeProcessStatsComposition(DescribeProcessStatsCompositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProcessStatsCompositionWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query session information.
         *
         * @param request DescribeProcessStatsCompositionRequest
         * @return DescribeProcessStatsCompositionResponse
         */
        public async Task<DescribeProcessStatsCompositionResponse> DescribeProcessStatsCompositionAsync(DescribeProcessStatsCompositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProcessStatsCompositionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询项目详情
         *
         * @param request DescribeProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProjectResponse
         */
        public DescribeProjectResponse DescribeProjectWithOptions(DescribeProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DescribeProject",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询项目详情
         *
         * @param request DescribeProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProjectResponse
         */
        public async Task<DescribeProjectResponse> DescribeProjectWithOptionsAsync(DescribeProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DescribeProject",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询项目详情
         *
         * @param request DescribeProjectRequest
         * @return DescribeProjectResponse
         */
        public DescribeProjectResponse DescribeProject(DescribeProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProjectWithOptions(request, runtime);
        }

        /**
         * @summary 查询项目详情
         *
         * @param request DescribeProjectRequest
         * @return DescribeProjectResponse
         */
        public async Task<DescribeProjectResponse> DescribeProjectAsync(DescribeProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProjectWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取项目的组件信息
         *
         * @param request DescribeProjectComponentsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProjectComponentsResponse
         */
        public DescribeProjectComponentsResponse DescribeProjectComponentsWithOptions(DescribeProjectComponentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DescribeProjectComponents",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectComponentsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取项目的组件信息
         *
         * @param request DescribeProjectComponentsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProjectComponentsResponse
         */
        public async Task<DescribeProjectComponentsResponse> DescribeProjectComponentsWithOptionsAsync(DescribeProjectComponentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DescribeProjectComponents",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectComponentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取项目的组件信息
         *
         * @param request DescribeProjectComponentsRequest
         * @return DescribeProjectComponentsResponse
         */
        public DescribeProjectComponentsResponse DescribeProjectComponents(DescribeProjectComponentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProjectComponentsWithOptions(request, runtime);
        }

        /**
         * @summary 获取项目的组件信息
         *
         * @param request DescribeProjectComponentsRequest
         * @return DescribeProjectComponentsResponse
         */
        public async Task<DescribeProjectComponentsResponse> DescribeProjectComponentsAsync(DescribeProjectComponentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProjectComponentsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取迁移/同步项目 Progress 信息
         *
         * @param request DescribeProjectProgressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProjectProgressResponse
         */
        public DescribeProjectProgressResponse DescribeProjectProgressWithOptions(DescribeProjectProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DescribeProjectProgress",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectProgressResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取迁移/同步项目 Progress 信息
         *
         * @param request DescribeProjectProgressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProjectProgressResponse
         */
        public async Task<DescribeProjectProgressResponse> DescribeProjectProgressWithOptionsAsync(DescribeProjectProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DescribeProjectProgress",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectProgressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取迁移/同步项目 Progress 信息
         *
         * @param request DescribeProjectProgressRequest
         * @return DescribeProjectProgressResponse
         */
        public DescribeProjectProgressResponse DescribeProjectProgress(DescribeProjectProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProjectProgressWithOptions(request, runtime);
        }

        /**
         * @summary 获取迁移/同步项目 Progress 信息
         *
         * @param request DescribeProjectProgressRequest
         * @return DescribeProjectProgressResponse
         */
        public async Task<DescribeProjectProgressResponse> DescribeProjectProgressAsync(DescribeProjectProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProjectProgressWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询项目步骤指标
         *
         * @param request DescribeProjectStepMetricRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProjectStepMetricResponse
         */
        public DescribeProjectStepMetricResponse DescribeProjectStepMetricWithOptions(DescribeProjectStepMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Aggregator))
            {
                body["Aggregator"] = request.Aggregator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTimestamp))
            {
                body["BeginTimestamp"] = request.BeginTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                body["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPointNum))
            {
                body["MaxPointNum"] = request.MaxPointNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                body["MetricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StepName))
            {
                body["StepName"] = request.StepName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProjectStepMetric",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectStepMetricResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询项目步骤指标
         *
         * @param request DescribeProjectStepMetricRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProjectStepMetricResponse
         */
        public async Task<DescribeProjectStepMetricResponse> DescribeProjectStepMetricWithOptionsAsync(DescribeProjectStepMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Aggregator))
            {
                body["Aggregator"] = request.Aggregator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTimestamp))
            {
                body["BeginTimestamp"] = request.BeginTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                body["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPointNum))
            {
                body["MaxPointNum"] = request.MaxPointNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                body["MetricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StepName))
            {
                body["StepName"] = request.StepName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProjectStepMetric",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectStepMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询项目步骤指标
         *
         * @param request DescribeProjectStepMetricRequest
         * @return DescribeProjectStepMetricResponse
         */
        public DescribeProjectStepMetricResponse DescribeProjectStepMetric(DescribeProjectStepMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProjectStepMetricWithOptions(request, runtime);
        }

        /**
         * @summary 查询项目步骤指标
         *
         * @param request DescribeProjectStepMetricRequest
         * @return DescribeProjectStepMetricResponse
         */
        public async Task<DescribeProjectStepMetricResponse> DescribeProjectStepMetricAsync(DescribeProjectStepMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProjectStepMetricWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询项目步骤
         *
         * @param request DescribeProjectStepsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProjectStepsResponse
         */
        public DescribeProjectStepsResponse DescribeProjectStepsWithOptions(DescribeProjectStepsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DescribeProjectSteps",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectStepsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询项目步骤
         *
         * @param request DescribeProjectStepsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProjectStepsResponse
         */
        public async Task<DescribeProjectStepsResponse> DescribeProjectStepsWithOptionsAsync(DescribeProjectStepsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DescribeProjectSteps",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectStepsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询项目步骤
         *
         * @param request DescribeProjectStepsRequest
         * @return DescribeProjectStepsResponse
         */
        public DescribeProjectStepsResponse DescribeProjectSteps(DescribeProjectStepsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProjectStepsWithOptions(request, runtime);
        }

        /**
         * @summary 查询项目步骤
         *
         * @param request DescribeProjectStepsRequest
         * @return DescribeProjectStepsResponse
         */
        public async Task<DescribeProjectStepsResponse> DescribeProjectStepsAsync(DescribeProjectStepsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProjectStepsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The tenant mode.   Valid values:  
         * Oracle   
         * MySQL
         *
         * @param request DescribeRecommendIndexRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRecommendIndexResponse
         */
        public DescribeRecommendIndexResponse DescribeRecommendIndexWithOptions(DescribeRecommendIndexRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SQLId))
            {
                body["SQLId"] = request.SQLId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecommendIndex",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecommendIndexResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The tenant mode.   Valid values:  
         * Oracle   
         * MySQL
         *
         * @param request DescribeRecommendIndexRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRecommendIndexResponse
         */
        public async Task<DescribeRecommendIndexResponse> DescribeRecommendIndexWithOptionsAsync(DescribeRecommendIndexRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SQLId))
            {
                body["SQLId"] = request.SQLId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecommendIndex",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecommendIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The tenant mode.   Valid values:  
         * Oracle   
         * MySQL
         *
         * @param request DescribeRecommendIndexRequest
         * @return DescribeRecommendIndexResponse
         */
        public DescribeRecommendIndexResponse DescribeRecommendIndex(DescribeRecommendIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecommendIndexWithOptions(request, runtime);
        }

        /**
         * @summary The tenant mode.   Valid values:  
         * Oracle   
         * MySQL
         *
         * @param request DescribeRecommendIndexRequest
         * @return DescribeRecommendIndexResponse
         */
        public async Task<DescribeRecommendIndexResponse> DescribeRecommendIndexAsync(DescribeRecommendIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecommendIndexWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取可恢复租户
         *
         * @param request DescribeRestorableTenantsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRestorableTenantsResponse
         */
        public DescribeRestorableTenantsResponse DescribeRestorableTenantsWithOptions(DescribeRestorableTenantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOnline))
            {
                body["IsOnline"] = request.IsOnline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRemote))
            {
                body["IsRemote"] = request.IsRemote;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                body["Method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreMode))
            {
                body["RestoreMode"] = request.RestoreMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreObjectType))
            {
                body["RestoreObjectType"] = request.RestoreObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                body["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRestorableTenants",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRestorableTenantsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取可恢复租户
         *
         * @param request DescribeRestorableTenantsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRestorableTenantsResponse
         */
        public async Task<DescribeRestorableTenantsResponse> DescribeRestorableTenantsWithOptionsAsync(DescribeRestorableTenantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOnline))
            {
                body["IsOnline"] = request.IsOnline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRemote))
            {
                body["IsRemote"] = request.IsRemote;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Method))
            {
                body["Method"] = request.Method;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreMode))
            {
                body["RestoreMode"] = request.RestoreMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreObjectType))
            {
                body["RestoreObjectType"] = request.RestoreObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                body["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRestorableTenants",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRestorableTenantsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取可恢复租户
         *
         * @param request DescribeRestorableTenantsRequest
         * @return DescribeRestorableTenantsResponse
         */
        public DescribeRestorableTenantsResponse DescribeRestorableTenants(DescribeRestorableTenantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRestorableTenantsWithOptions(request, runtime);
        }

        /**
         * @summary 获取可恢复租户
         *
         * @param request DescribeRestorableTenantsRequest
         * @return DescribeRestorableTenantsResponse
         */
        public async Task<DescribeRestorableTenantsResponse> DescribeRestorableTenantsAsync(DescribeRestorableTenantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRestorableTenantsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The username.
         *
         * @param request DescribeSQLDetailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSQLDetailsResponse
         */
        public DescribeSQLDetailsResponse DescribeSQLDetailsWithOptions(DescribeSQLDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SQLId))
            {
                body["SQLId"] = request.SQLId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSQLDetails",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLDetailsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The username.
         *
         * @param request DescribeSQLDetailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSQLDetailsResponse
         */
        public async Task<DescribeSQLDetailsResponse> DescribeSQLDetailsWithOptionsAsync(DescribeSQLDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SQLId))
            {
                body["SQLId"] = request.SQLId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSQLDetails",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The username.
         *
         * @param request DescribeSQLDetailsRequest
         * @return DescribeSQLDetailsResponse
         */
        public DescribeSQLDetailsResponse DescribeSQLDetails(DescribeSQLDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSQLDetailsWithOptions(request, runtime);
        }

        /**
         * @summary The username.
         *
         * @param request DescribeSQLDetailsRequest
         * @return DescribeSQLDetailsResponse
         */
        public async Task<DescribeSQLDetailsResponse> DescribeSQLDetailsAsync(DescribeSQLDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSQLDetailsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query the execution history of an SQL statement in a specified period based on an SQL ID.
         *
         * @param request DescribeSQLHistoryListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSQLHistoryListResponse
         */
        public DescribeSQLHistoryListResponse DescribeSQLHistoryListWithOptions(DescribeSQLHistoryListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SQLId))
            {
                body["SQLId"] = request.SQLId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSQLHistoryList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLHistoryListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the execution history of an SQL statement in a specified period based on an SQL ID.
         *
         * @param request DescribeSQLHistoryListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSQLHistoryListResponse
         */
        public async Task<DescribeSQLHistoryListResponse> DescribeSQLHistoryListWithOptionsAsync(DescribeSQLHistoryListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SQLId))
            {
                body["SQLId"] = request.SQLId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSQLHistoryList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLHistoryListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the execution history of an SQL statement in a specified period based on an SQL ID.
         *
         * @param request DescribeSQLHistoryListRequest
         * @return DescribeSQLHistoryListResponse
         */
        public DescribeSQLHistoryListResponse DescribeSQLHistoryList(DescribeSQLHistoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSQLHistoryListWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query the execution history of an SQL statement in a specified period based on an SQL ID.
         *
         * @param request DescribeSQLHistoryListRequest
         * @return DescribeSQLHistoryListResponse
         */
        public async Task<DescribeSQLHistoryListResponse> DescribeSQLHistoryListAsync(DescribeSQLHistoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSQLHistoryListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query the information about the SQL execution plans stored in the diagnostic system based on an SQL ID.
         *
         * @param request DescribeSQLPlansRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSQLPlansResponse
         */
        public DescribeSQLPlansResponse DescribeSQLPlansWithOptions(DescribeSQLPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SQLId))
            {
                body["SQLId"] = request.SQLId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSQLPlans",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLPlansResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the information about the SQL execution plans stored in the diagnostic system based on an SQL ID.
         *
         * @param request DescribeSQLPlansRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSQLPlansResponse
         */
        public async Task<DescribeSQLPlansResponse> DescribeSQLPlansWithOptionsAsync(DescribeSQLPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SQLId))
            {
                body["SQLId"] = request.SQLId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSQLPlans",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLPlansResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the information about the SQL execution plans stored in the diagnostic system based on an SQL ID.
         *
         * @param request DescribeSQLPlansRequest
         * @return DescribeSQLPlansResponse
         */
        public DescribeSQLPlansResponse DescribeSQLPlans(DescribeSQLPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSQLPlansWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query the information about the SQL execution plans stored in the diagnostic system based on an SQL ID.
         *
         * @param request DescribeSQLPlansRequest
         * @return DescribeSQLPlansResponse
         */
        public async Task<DescribeSQLPlansResponse> DescribeSQLPlansAsync(DescribeSQLPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSQLPlansWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this API to view the sample data of the execution details of the slow queries.
         *
         * @param request DescribeSQLSamplesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSQLSamplesResponse
         */
        public DescribeSQLSamplesResponse DescribeSQLSamplesWithOptions(DescribeSQLSamplesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnSqlText))
            {
                body["ReturnSqlText"] = request.ReturnSqlText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSQLSamples",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLSamplesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this API to view the sample data of the execution details of the slow queries.
         *
         * @param request DescribeSQLSamplesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSQLSamplesResponse
         */
        public async Task<DescribeSQLSamplesResponse> DescribeSQLSamplesWithOptionsAsync(DescribeSQLSamplesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnSqlText))
            {
                body["ReturnSqlText"] = request.ReturnSqlText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSQLSamples",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLSamplesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this API to view the sample data of the execution details of the slow queries.
         *
         * @param request DescribeSQLSamplesRequest
         * @return DescribeSQLSamplesResponse
         */
        public DescribeSQLSamplesResponse DescribeSQLSamples(DescribeSQLSamplesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSQLSamplesWithOptions(request, runtime);
        }

        /**
         * @summary You can call this API to view the sample data of the execution details of the slow queries.
         *
         * @param request DescribeSQLSamplesRequest
         * @return DescribeSQLSamplesResponse
         */
        public async Task<DescribeSQLSamplesResponse> DescribeSQLSamplesAsync(DescribeSQLSamplesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSQLSamplesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取单个 SQL 的调优建议，包括计划推荐和索引推荐
         *
         * @param request DescribeSQLTuningAdvicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSQLTuningAdvicesResponse
         */
        public DescribeSQLTuningAdvicesResponse DescribeSQLTuningAdvicesWithOptions(DescribeSQLTuningAdvicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSQLTuningAdvices",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLTuningAdvicesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取单个 SQL 的调优建议，包括计划推荐和索引推荐
         *
         * @param request DescribeSQLTuningAdvicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSQLTuningAdvicesResponse
         */
        public async Task<DescribeSQLTuningAdvicesResponse> DescribeSQLTuningAdvicesWithOptionsAsync(DescribeSQLTuningAdvicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSQLTuningAdvices",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSQLTuningAdvicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取单个 SQL 的调优建议，包括计划推荐和索引推荐
         *
         * @param request DescribeSQLTuningAdvicesRequest
         * @return DescribeSQLTuningAdvicesResponse
         */
        public DescribeSQLTuningAdvicesResponse DescribeSQLTuningAdvices(DescribeSQLTuningAdvicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSQLTuningAdvicesWithOptions(request, runtime);
        }

        /**
         * @summary 获取单个 SQL 的调优建议，包括计划推荐和索引推荐
         *
         * @param request DescribeSQLTuningAdvicesRequest
         * @return DescribeSQLTuningAdvicesResponse
         */
        public async Task<DescribeSQLTuningAdvicesResponse> DescribeSQLTuningAdvicesAsync(DescribeSQLTuningAdvicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSQLTuningAdvicesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询采样SQL的原始文本
         *
         * @param request DescribeSampleSqlRawTextsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSampleSqlRawTextsResponse
         */
        public DescribeSampleSqlRawTextsResponse DescribeSampleSqlRawTextsWithOptions(DescribeSampleSqlRawTextsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceId))
            {
                body["TraceId"] = request.TraceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSampleSqlRawTexts",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSampleSqlRawTextsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询采样SQL的原始文本
         *
         * @param request DescribeSampleSqlRawTextsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSampleSqlRawTextsResponse
         */
        public async Task<DescribeSampleSqlRawTextsResponse> DescribeSampleSqlRawTextsWithOptionsAsync(DescribeSampleSqlRawTextsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SqlId))
            {
                body["SqlId"] = request.SqlId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceId))
            {
                body["TraceId"] = request.TraceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSampleSqlRawTexts",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSampleSqlRawTextsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询采样SQL的原始文本
         *
         * @param request DescribeSampleSqlRawTextsRequest
         * @return DescribeSampleSqlRawTextsResponse
         */
        public DescribeSampleSqlRawTextsResponse DescribeSampleSqlRawTexts(DescribeSampleSqlRawTextsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSampleSqlRawTextsWithOptions(request, runtime);
        }

        /**
         * @summary 查询采样SQL的原始文本
         *
         * @param request DescribeSampleSqlRawTextsRequest
         * @return DescribeSampleSqlRawTextsResponse
         */
        public async Task<DescribeSampleSqlRawTextsResponse> DescribeSampleSqlRawTextsAsync(DescribeSampleSqlRawTextsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSampleSqlRawTextsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The name of the security group.
         *
         * @param request DescribeSecurityIpGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSecurityIpGroupsResponse
         */
        public DescribeSecurityIpGroupsResponse DescribeSecurityIpGroupsWithOptions(DescribeSecurityIpGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeSecurityIpGroups",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecurityIpGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The name of the security group.
         *
         * @param request DescribeSecurityIpGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSecurityIpGroupsResponse
         */
        public async Task<DescribeSecurityIpGroupsResponse> DescribeSecurityIpGroupsWithOptionsAsync(DescribeSecurityIpGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeSecurityIpGroups",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecurityIpGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The name of the security group.
         *
         * @param request DescribeSecurityIpGroupsRequest
         * @return DescribeSecurityIpGroupsResponse
         */
        public DescribeSecurityIpGroupsResponse DescribeSecurityIpGroups(DescribeSecurityIpGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityIpGroupsWithOptions(request, runtime);
        }

        /**
         * @summary The name of the security group.
         *
         * @param request DescribeSecurityIpGroupsRequest
         * @return DescribeSecurityIpGroupsResponse
         */
        public async Task<DescribeSecurityIpGroupsResponse> DescribeSecurityIpGroupsAsync(DescribeSecurityIpGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityIpGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query sessions between the ApsaraDB for OceanBase and the application.
         *
         * @param request DescribeSessionListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSessionListResponse
         */
        public DescribeSessionListResponse DescribeSessionListWithOptions(DescribeSessionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSessionList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSessionListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query sessions between the ApsaraDB for OceanBase and the application.
         *
         * @param request DescribeSessionListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSessionListResponse
         */
        public async Task<DescribeSessionListResponse> DescribeSessionListWithOptionsAsync(DescribeSessionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSessionList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSessionListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query sessions between the ApsaraDB for OceanBase and the application.
         *
         * @param request DescribeSessionListRequest
         * @return DescribeSessionListResponse
         */
        public DescribeSessionListResponse DescribeSessionList(DescribeSessionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSessionListWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query sessions between the ApsaraDB for OceanBase and the application.
         *
         * @param request DescribeSessionListRequest
         * @return DescribeSessionListResponse
         */
        public async Task<DescribeSessionListResponse> DescribeSessionListAsync(DescribeSessionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSessionListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query the execution history of an SQL statement by SQL ID that is determined as a slow SQL statement during a specified period of time.
         *
         * @param request DescribeSlowSQLHistoryListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSlowSQLHistoryListResponse
         */
        public DescribeSlowSQLHistoryListResponse DescribeSlowSQLHistoryListWithOptions(DescribeSlowSQLHistoryListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SQLId))
            {
                body["SQLId"] = request.SQLId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlowSQLHistoryList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlowSQLHistoryListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the execution history of an SQL statement by SQL ID that is determined as a slow SQL statement during a specified period of time.
         *
         * @param request DescribeSlowSQLHistoryListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSlowSQLHistoryListResponse
         */
        public async Task<DescribeSlowSQLHistoryListResponse> DescribeSlowSQLHistoryListWithOptionsAsync(DescribeSlowSQLHistoryListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SQLId))
            {
                body["SQLId"] = request.SQLId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlowSQLHistoryList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlowSQLHistoryListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the execution history of an SQL statement by SQL ID that is determined as a slow SQL statement during a specified period of time.
         *
         * @param request DescribeSlowSQLHistoryListRequest
         * @return DescribeSlowSQLHistoryListResponse
         */
        public DescribeSlowSQLHistoryListResponse DescribeSlowSQLHistoryList(DescribeSlowSQLHistoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSlowSQLHistoryListWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query the execution history of an SQL statement by SQL ID that is determined as a slow SQL statement during a specified period of time.
         *
         * @param request DescribeSlowSQLHistoryListRequest
         * @return DescribeSlowSQLHistoryListResponse
         */
        public async Task<DescribeSlowSQLHistoryListResponse> DescribeSlowSQLHistoryListAsync(DescribeSlowSQLHistoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSlowSQLHistoryListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query the list of slow SQL statements
         *
         * @param tmpReq DescribeSlowSQLListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSlowSQLListResponse
         */
        public DescribeSlowSQLListResponse DescribeSlowSQLListWithOptions(DescribeSlowSQLListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeSlowSQLListShrinkRequest request = new DescribeSlowSQLListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterCondition))
            {
                request.FilterConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterCondition, "FilterCondition", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterConditionShrink))
            {
                body["FilterCondition"] = request.FilterConditionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIp))
            {
                body["NodeIp"] = request.NodeIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SQLId))
            {
                body["SQLId"] = request.SQLId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeyWord))
            {
                body["SearchKeyWord"] = request.SearchKeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchParameter))
            {
                body["SearchParameter"] = request.SearchParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchRule))
            {
                body["SearchRule"] = request.SearchRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                body["SearchValue"] = request.SearchValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortColumn))
            {
                body["SortColumn"] = request.SortColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlowSQLList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlowSQLListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the list of slow SQL statements
         *
         * @param tmpReq DescribeSlowSQLListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSlowSQLListResponse
         */
        public async Task<DescribeSlowSQLListResponse> DescribeSlowSQLListWithOptionsAsync(DescribeSlowSQLListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeSlowSQLListShrinkRequest request = new DescribeSlowSQLListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterCondition))
            {
                request.FilterConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterCondition, "FilterCondition", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterConditionShrink))
            {
                body["FilterCondition"] = request.FilterConditionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIp))
            {
                body["NodeIp"] = request.NodeIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SQLId))
            {
                body["SQLId"] = request.SQLId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeyWord))
            {
                body["SearchKeyWord"] = request.SearchKeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchParameter))
            {
                body["SearchParameter"] = request.SearchParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchRule))
            {
                body["SearchRule"] = request.SearchRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                body["SearchValue"] = request.SearchValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortColumn))
            {
                body["SortColumn"] = request.SortColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlowSQLList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlowSQLListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the list of slow SQL statements
         *
         * @param request DescribeSlowSQLListRequest
         * @return DescribeSlowSQLListResponse
         */
        public DescribeSlowSQLListResponse DescribeSlowSQLList(DescribeSlowSQLListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSlowSQLListWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query the list of slow SQL statements
         *
         * @param request DescribeSlowSQLListRequest
         * @return DescribeSlowSQLListResponse
         */
        public async Task<DescribeSlowSQLListResponse> DescribeSlowSQLListAsync(DescribeSlowSQLListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSlowSQLListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary DescribeStandbyCreateMode
         *
         * @param request DescribeStandbyCreateModeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeStandbyCreateModeResponse
         */
        public DescribeStandbyCreateModeResponse DescribeStandbyCreateModeWithOptions(DescribeStandbyCreateModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStandbyCreateMode",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStandbyCreateModeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary DescribeStandbyCreateMode
         *
         * @param request DescribeStandbyCreateModeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeStandbyCreateModeResponse
         */
        public async Task<DescribeStandbyCreateModeResponse> DescribeStandbyCreateModeWithOptionsAsync(DescribeStandbyCreateModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStandbyCreateMode",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStandbyCreateModeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary DescribeStandbyCreateMode
         *
         * @param request DescribeStandbyCreateModeRequest
         * @return DescribeStandbyCreateModeResponse
         */
        public DescribeStandbyCreateModeResponse DescribeStandbyCreateMode(DescribeStandbyCreateModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStandbyCreateModeWithOptions(request, runtime);
        }

        /**
         * @summary DescribeStandbyCreateMode
         *
         * @param request DescribeStandbyCreateModeRequest
         * @return DescribeStandbyCreateModeResponse
         */
        public async Task<DescribeStandbyCreateModeResponse> DescribeStandbyCreateModeAsync(DescribeStandbyCreateModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStandbyCreateModeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query tags.
         *
         * @param request DescribeTagValuesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTagValuesResponse
         */
        public DescribeTagValuesResponse DescribeTagValuesWithOptions(DescribeTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTagValues",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTagValuesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query tags.
         *
         * @param request DescribeTagValuesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTagValuesResponse
         */
        public async Task<DescribeTagValuesResponse> DescribeTagValuesWithOptionsAsync(DescribeTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTagValues",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTagValuesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query tags.
         *
         * @param request DescribeTagValuesRequest
         * @return DescribeTagValuesResponse
         */
        public DescribeTagValuesResponse DescribeTagValues(DescribeTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTagValuesWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query tags.
         *
         * @param request DescribeTagValuesRequest
         * @return DescribeTagValuesResponse
         */
        public async Task<DescribeTagValuesResponse> DescribeTagValuesAsync(DescribeTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTagValuesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The ID of the VPC.
         *
         * @param request DescribeTenantRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTenantResponse
         */
        public DescribeTenantResponse DescribeTenantWithOptions(DescribeTenantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenant",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The ID of the VPC.
         *
         * @param request DescribeTenantRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTenantResponse
         */
        public async Task<DescribeTenantResponse> DescribeTenantWithOptionsAsync(DescribeTenantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenant",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The ID of the VPC.
         *
         * @param request DescribeTenantRequest
         * @return DescribeTenantResponse
         */
        public DescribeTenantResponse DescribeTenant(DescribeTenantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTenantWithOptions(request, runtime);
        }

        /**
         * @summary The ID of the VPC.
         *
         * @param request DescribeTenantRequest
         * @return DescribeTenantResponse
         */
        public async Task<DescribeTenantResponse> DescribeTenantAsync(DescribeTenantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTenantWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询租户加密信息
         *
         * @param request DescribeTenantEncryptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTenantEncryptionResponse
         */
        public DescribeTenantEncryptionResponse DescribeTenantEncryptionWithOptions(DescribeTenantEncryptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantName))
            {
                body["TenantName"] = request.TenantName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenantEncryption",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantEncryptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询租户加密信息
         *
         * @param request DescribeTenantEncryptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTenantEncryptionResponse
         */
        public async Task<DescribeTenantEncryptionResponse> DescribeTenantEncryptionWithOptionsAsync(DescribeTenantEncryptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantName))
            {
                body["TenantName"] = request.TenantName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenantEncryption",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantEncryptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询租户加密信息
         *
         * @param request DescribeTenantEncryptionRequest
         * @return DescribeTenantEncryptionResponse
         */
        public DescribeTenantEncryptionResponse DescribeTenantEncryption(DescribeTenantEncryptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTenantEncryptionWithOptions(request, runtime);
        }

        /**
         * @summary 查询租户加密信息
         *
         * @param request DescribeTenantEncryptionRequest
         * @return DescribeTenantEncryptionResponse
         */
        public async Task<DescribeTenantEncryptionResponse> DescribeTenantEncryptionAsync(DescribeTenantEncryptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTenantEncryptionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The list of tenant IDs.
         *
         * @param request DescribeTenantMetricsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTenantMetricsResponse
         */
        public DescribeTenantMetricsResponse DescribeTenantMetricsWithOptions(DescribeTenantMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                body["Metrics"] = request.Metrics;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantIdList))
            {
                body["TenantIdList"] = request.TenantIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantName))
            {
                body["TenantName"] = request.TenantName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenantMetrics",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantMetricsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The list of tenant IDs.
         *
         * @param request DescribeTenantMetricsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTenantMetricsResponse
         */
        public async Task<DescribeTenantMetricsResponse> DescribeTenantMetricsWithOptionsAsync(DescribeTenantMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                body["Metrics"] = request.Metrics;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantIdList))
            {
                body["TenantIdList"] = request.TenantIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantName))
            {
                body["TenantName"] = request.TenantName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenantMetrics",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The list of tenant IDs.
         *
         * @param request DescribeTenantMetricsRequest
         * @return DescribeTenantMetricsResponse
         */
        public DescribeTenantMetricsResponse DescribeTenantMetrics(DescribeTenantMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTenantMetricsWithOptions(request, runtime);
        }

        /**
         * @summary The list of tenant IDs.
         *
         * @param request DescribeTenantMetricsRequest
         * @return DescribeTenantMetricsResponse
         */
        public async Task<DescribeTenantMetricsResponse> DescribeTenantMetricsAsync(DescribeTenantMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTenantMetricsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query the maximum readable timestamp of a tenant.
         *
         * @param request DescribeTenantReadableScnRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTenantReadableScnResponse
         */
        public DescribeTenantReadableScnResponse DescribeTenantReadableScnWithOptions(DescribeTenantReadableScnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenantReadableScn",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantReadableScnResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the maximum readable timestamp of a tenant.
         *
         * @param request DescribeTenantReadableScnRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTenantReadableScnResponse
         */
        public async Task<DescribeTenantReadableScnResponse> DescribeTenantReadableScnWithOptionsAsync(DescribeTenantReadableScnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenantReadableScn",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantReadableScnResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the maximum readable timestamp of a tenant.
         *
         * @param request DescribeTenantReadableScnRequest
         * @return DescribeTenantReadableScnResponse
         */
        public DescribeTenantReadableScnResponse DescribeTenantReadableScn(DescribeTenantReadableScnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTenantReadableScnWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query the maximum readable timestamp of a tenant.
         *
         * @param request DescribeTenantReadableScnRequest
         * @return DescribeTenantReadableScnResponse
         */
        public async Task<DescribeTenantReadableScnResponse> DescribeTenantReadableScnAsync(DescribeTenantReadableScnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTenantReadableScnWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query security check items of an OceanBase Database tenant.
         *
         * @param request DescribeTenantSecurityConfigsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTenantSecurityConfigsResponse
         */
        public DescribeTenantSecurityConfigsResponse DescribeTenantSecurityConfigsWithOptions(DescribeTenantSecurityConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckId))
            {
                body["CheckId"] = request.CheckId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenantSecurityConfigs",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantSecurityConfigsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query security check items of an OceanBase Database tenant.
         *
         * @param request DescribeTenantSecurityConfigsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTenantSecurityConfigsResponse
         */
        public async Task<DescribeTenantSecurityConfigsResponse> DescribeTenantSecurityConfigsWithOptionsAsync(DescribeTenantSecurityConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckId))
            {
                body["CheckId"] = request.CheckId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenantSecurityConfigs",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantSecurityConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query security check items of an OceanBase Database tenant.
         *
         * @param request DescribeTenantSecurityConfigsRequest
         * @return DescribeTenantSecurityConfigsResponse
         */
        public DescribeTenantSecurityConfigsResponse DescribeTenantSecurityConfigs(DescribeTenantSecurityConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTenantSecurityConfigsWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query security check items of an OceanBase Database tenant.
         *
         * @param request DescribeTenantSecurityConfigsRequest
         * @return DescribeTenantSecurityConfigsResponse
         */
        public async Task<DescribeTenantSecurityConfigsResponse> DescribeTenantSecurityConfigsAsync(DescribeTenantSecurityConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTenantSecurityConfigsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to view the list of whitelist groups of the tenant.
         *
         * @param request DescribeTenantSecurityIpGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTenantSecurityIpGroupsResponse
         */
        public DescribeTenantSecurityIpGroupsResponse DescribeTenantSecurityIpGroupsWithOptions(DescribeTenantSecurityIpGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenantSecurityIpGroups",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantSecurityIpGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to view the list of whitelist groups of the tenant.
         *
         * @param request DescribeTenantSecurityIpGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTenantSecurityIpGroupsResponse
         */
        public async Task<DescribeTenantSecurityIpGroupsResponse> DescribeTenantSecurityIpGroupsWithOptionsAsync(DescribeTenantSecurityIpGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenantSecurityIpGroups",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantSecurityIpGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to view the list of whitelist groups of the tenant.
         *
         * @param request DescribeTenantSecurityIpGroupsRequest
         * @return DescribeTenantSecurityIpGroupsResponse
         */
        public DescribeTenantSecurityIpGroupsResponse DescribeTenantSecurityIpGroups(DescribeTenantSecurityIpGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTenantSecurityIpGroupsWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to view the list of whitelist groups of the tenant.
         *
         * @param request DescribeTenantSecurityIpGroupsRequest
         * @return DescribeTenantSecurityIpGroupsResponse
         */
        public async Task<DescribeTenantSecurityIpGroupsResponse> DescribeTenantSecurityIpGroupsAsync(DescribeTenantSecurityIpGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTenantSecurityIpGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query the tags of tenants in a cluster.
         *
         * @param request DescribeTenantTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTenantTagsResponse
         */
        public DescribeTenantTagsResponse DescribeTenantTagsWithOptions(DescribeTenantTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantIds))
            {
                body["TenantIds"] = request.TenantIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenantTags",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantTagsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the tags of tenants in a cluster.
         *
         * @param request DescribeTenantTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTenantTagsResponse
         */
        public async Task<DescribeTenantTagsResponse> DescribeTenantTagsWithOptionsAsync(DescribeTenantTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantIds))
            {
                body["TenantIds"] = request.TenantIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenantTags",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the tags of tenants in a cluster.
         *
         * @param request DescribeTenantTagsRequest
         * @return DescribeTenantTagsResponse
         */
        public DescribeTenantTagsResponse DescribeTenantTags(DescribeTenantTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTenantTagsWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query the tags of tenants in a cluster.
         *
         * @param request DescribeTenantTagsRequest
         * @return DescribeTenantTagsResponse
         */
        public async Task<DescribeTenantTagsResponse> DescribeTenantTagsAsync(DescribeTenantTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTenantTagsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to obtain the account authorization information of the tenant.
         *
         * @param request DescribeTenantUserRolesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTenantUserRolesResponse
         */
        public DescribeTenantUserRolesResponse DescribeTenantUserRolesWithOptions(DescribeTenantUserRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenantUserRoles",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantUserRolesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to obtain the account authorization information of the tenant.
         *
         * @param request DescribeTenantUserRolesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTenantUserRolesResponse
         */
        public async Task<DescribeTenantUserRolesResponse> DescribeTenantUserRolesWithOptionsAsync(DescribeTenantUserRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenantUserRoles",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantUserRolesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to obtain the account authorization information of the tenant.
         *
         * @param request DescribeTenantUserRolesRequest
         * @return DescribeTenantUserRolesResponse
         */
        public DescribeTenantUserRolesResponse DescribeTenantUserRoles(DescribeTenantUserRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTenantUserRolesWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to obtain the account authorization information of the tenant.
         *
         * @param request DescribeTenantUserRolesRequest
         * @return DescribeTenantUserRolesResponse
         */
        public async Task<DescribeTenantUserRolesResponse> DescribeTenantUserRolesAsync(DescribeTenantUserRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTenantUserRolesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The return result of the request.
         *
         * @param request DescribeTenantUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTenantUsersResponse
         */
        public DescribeTenantUsersResponse DescribeTenantUsersWithOptions(DescribeTenantUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                body["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenantUsers",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The return result of the request.
         *
         * @param request DescribeTenantUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTenantUsersResponse
         */
        public async Task<DescribeTenantUsersResponse> DescribeTenantUsersWithOptionsAsync(DescribeTenantUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                body["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenantUsers",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The return result of the request.
         *
         * @param request DescribeTenantUsersRequest
         * @return DescribeTenantUsersResponse
         */
        public DescribeTenantUsersResponse DescribeTenantUsers(DescribeTenantUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTenantUsersWithOptions(request, runtime);
        }

        /**
         * @summary The return result of the request.
         *
         * @param request DescribeTenantUsersRequest
         * @return DescribeTenantUsersResponse
         */
        public async Task<DescribeTenantUsersResponse> DescribeTenantUsersAsync(DescribeTenantUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTenantUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Indicates whether a read-only connection has been created.
         *
         * @param request DescribeTenantZonesReadRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTenantZonesReadResponse
         */
        public DescribeTenantZonesReadResponse DescribeTenantZonesReadWithOptions(DescribeTenantZonesReadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenantZonesRead",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantZonesReadResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Indicates whether a read-only connection has been created.
         *
         * @param request DescribeTenantZonesReadRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTenantZonesReadResponse
         */
        public async Task<DescribeTenantZonesReadResponse> DescribeTenantZonesReadWithOptionsAsync(DescribeTenantZonesReadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenantZonesRead",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantZonesReadResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Indicates whether a read-only connection has been created.
         *
         * @param request DescribeTenantZonesReadRequest
         * @return DescribeTenantZonesReadResponse
         */
        public DescribeTenantZonesReadResponse DescribeTenantZonesRead(DescribeTenantZonesReadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTenantZonesReadWithOptions(request, runtime);
        }

        /**
         * @summary Indicates whether a read-only connection has been created.
         *
         * @param request DescribeTenantZonesReadRequest
         * @return DescribeTenantZonesReadResponse
         */
        public async Task<DescribeTenantZonesReadResponse> DescribeTenantZonesReadAsync(DescribeTenantZonesReadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTenantZonesReadWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The total memory size of the tenant, in GB.
         *
         * @param request DescribeTenantsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTenantsResponse
         */
        public DescribeTenantsResponse DescribeTenantsWithOptions(DescribeTenantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                body["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantName))
            {
                body["TenantName"] = request.TenantName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenants",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The total memory size of the tenant, in GB.
         *
         * @param request DescribeTenantsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTenantsResponse
         */
        public async Task<DescribeTenantsResponse> DescribeTenantsWithOptionsAsync(DescribeTenantsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                body["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantName))
            {
                body["TenantName"] = request.TenantName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTenants",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTenantsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The total memory size of the tenant, in GB.
         *
         * @param request DescribeTenantsRequest
         * @return DescribeTenantsResponse
         */
        public DescribeTenantsResponse DescribeTenants(DescribeTenantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTenantsWithOptions(request, runtime);
        }

        /**
         * @summary The total memory size of the tenant, in GB.
         *
         * @param request DescribeTenantsRequest
         * @return DescribeTenantsResponse
         */
        public async Task<DescribeTenantsResponse> DescribeTenantsAsync(DescribeTenantsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTenantsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The time zones supported by the tenant.
         *
         * @param request DescribeTimeZonesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTimeZonesResponse
         */
        public DescribeTimeZonesResponse DescribeTimeZonesWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTimeZones",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTimeZonesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The time zones supported by the tenant.
         *
         * @param request DescribeTimeZonesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTimeZonesResponse
         */
        public async Task<DescribeTimeZonesResponse> DescribeTimeZonesWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTimeZones",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTimeZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The time zones supported by the tenant.
         *
         * @return DescribeTimeZonesResponse
         */
        public DescribeTimeZonesResponse DescribeTimeZones()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTimeZonesWithOptions(runtime);
        }

        /**
         * @summary The time zones supported by the tenant.
         *
         * @return DescribeTimeZonesResponse
         */
        public async Task<DescribeTimeZonesResponse> DescribeTimeZonesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTimeZonesWithOptionsAsync(runtime);
        }

        /**
         * @summary The name of the database.
         *
         * @param tmpReq DescribeTopSQLListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTopSQLListResponse
         */
        public DescribeTopSQLListResponse DescribeTopSQLListWithOptions(DescribeTopSQLListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeTopSQLListShrinkRequest request = new DescribeTopSQLListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterCondition))
            {
                request.FilterConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterCondition, "FilterCondition", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterConditionShrink))
            {
                body["FilterCondition"] = request.FilterConditionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIp))
            {
                body["NodeIp"] = request.NodeIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SQLId))
            {
                body["SQLId"] = request.SQLId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeyWord))
            {
                body["SearchKeyWord"] = request.SearchKeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchParameter))
            {
                body["SearchParameter"] = request.SearchParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchRule))
            {
                body["SearchRule"] = request.SearchRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                body["SearchValue"] = request.SearchValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortColumn))
            {
                body["SortColumn"] = request.SortColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTopSQLList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTopSQLListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The name of the database.
         *
         * @param tmpReq DescribeTopSQLListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTopSQLListResponse
         */
        public async Task<DescribeTopSQLListResponse> DescribeTopSQLListWithOptionsAsync(DescribeTopSQLListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeTopSQLListShrinkRequest request = new DescribeTopSQLListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterCondition))
            {
                request.FilterConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterCondition, "FilterCondition", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                body["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterConditionShrink))
            {
                body["FilterCondition"] = request.FilterConditionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIp))
            {
                body["NodeIp"] = request.NodeIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SQLId))
            {
                body["SQLId"] = request.SQLId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeyWord))
            {
                body["SearchKeyWord"] = request.SearchKeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchParameter))
            {
                body["SearchParameter"] = request.SearchParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchRule))
            {
                body["SearchRule"] = request.SearchRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                body["SearchValue"] = request.SearchValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortColumn))
            {
                body["SortColumn"] = request.SortColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTopSQLList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTopSQLListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The name of the database.
         *
         * @param request DescribeTopSQLListRequest
         * @return DescribeTopSQLListResponse
         */
        public DescribeTopSQLListResponse DescribeTopSQLList(DescribeTopSQLListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTopSQLListWithOptions(request, runtime);
        }

        /**
         * @summary The name of the database.
         *
         * @param request DescribeTopSQLListRequest
         * @return DescribeTopSQLListResponse
         */
        public async Task<DescribeTopSQLListResponse> DescribeTopSQLListAsync(DescribeTopSQLListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTopSQLListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The deployment mode.
         *
         * @param request DescribeZonesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeZonesResponse
         */
        public DescribeZonesResponse DescribeZonesWithOptions(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuArch))
            {
                body["CpuArch"] = request.CpuArch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                body["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Series))
            {
                body["Series"] = request.Series;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeZones",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeZonesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The deployment mode.
         *
         * @param request DescribeZonesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeZonesResponse
         */
        public async Task<DescribeZonesResponse> DescribeZonesWithOptionsAsync(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuArch))
            {
                body["CpuArch"] = request.CpuArch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                body["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Series))
            {
                body["Series"] = request.Series;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeZones",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The deployment mode.
         *
         * @param request DescribeZonesRequest
         * @return DescribeZonesResponse
         */
        public DescribeZonesResponse DescribeZones(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeZonesWithOptions(request, runtime);
        }

        /**
         * @summary The deployment mode.
         *
         * @param request DescribeZonesRequest
         * @return DescribeZonesResponse
         */
        public async Task<DescribeZonesResponse> DescribeZonesAsync(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeZonesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 公有云上传OSS 获取一个临时上传url
         *
         * @param request GetUploadOssUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUploadOssUrlResponse
         */
        public GetUploadOssUrlResponse GetUploadOssUrlWithOptions(GetUploadOssUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTimeMinutes))
            {
                body["EffectiveTimeMinutes"] = request.EffectiveTimeMinutes;
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
                Action = "GetUploadOssUrl",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadOssUrlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 公有云上传OSS 获取一个临时上传url
         *
         * @param request GetUploadOssUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUploadOssUrlResponse
         */
        public async Task<GetUploadOssUrlResponse> GetUploadOssUrlWithOptionsAsync(GetUploadOssUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveTimeMinutes))
            {
                body["EffectiveTimeMinutes"] = request.EffectiveTimeMinutes;
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
                Action = "GetUploadOssUrl",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadOssUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 公有云上传OSS 获取一个临时上传url
         *
         * @param request GetUploadOssUrlRequest
         * @return GetUploadOssUrlResponse
         */
        public GetUploadOssUrlResponse GetUploadOssUrl(GetUploadOssUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUploadOssUrlWithOptions(request, runtime);
        }

        /**
         * @summary 公有云上传OSS 获取一个临时上传url
         *
         * @param request GetUploadOssUrlRequest
         * @return GetUploadOssUrlResponse
         */
        public async Task<GetUploadOssUrlResponse> GetUploadOssUrlAsync(GetUploadOssUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUploadOssUrlWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to close a session.
         *
         * @param request KillProcessListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return KillProcessListResponse
         */
        public KillProcessListResponse KillProcessListWithOptions(KillProcessListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionList))
            {
                body["SessionList"] = request.SessionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillProcessList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KillProcessListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to close a session.
         *
         * @param request KillProcessListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return KillProcessListResponse
         */
        public async Task<KillProcessListResponse> KillProcessListWithOptionsAsync(KillProcessListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionList))
            {
                body["SessionList"] = request.SessionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillProcessList",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KillProcessListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to close a session.
         *
         * @param request KillProcessListRequest
         * @return KillProcessListResponse
         */
        public KillProcessListResponse KillProcessList(KillProcessListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return KillProcessListWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to close a session.
         *
         * @param request KillProcessListRequest
         * @return KillProcessListResponse
         */
        public async Task<KillProcessListResponse> KillProcessListAsync(KillProcessListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await KillProcessListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询标签列表
         *
         * @param request ListAllLabelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAllLabelsResponse
         */
        public ListAllLabelsResponse ListAllLabelsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAllLabels",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllLabelsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询标签列表
         *
         * @param request ListAllLabelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAllLabelsResponse
         */
        public async Task<ListAllLabelsResponse> ListAllLabelsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAllLabels",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询标签列表
         *
         * @return ListAllLabelsResponse
         */
        public ListAllLabelsResponse ListAllLabels()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAllLabelsWithOptions(runtime);
        }

        /**
         * @summary 查询标签列表
         *
         * @return ListAllLabelsResponse
         */
        public async Task<ListAllLabelsResponse> ListAllLabelsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAllLabelsWithOptionsAsync(runtime);
        }

        /**
         * @summary 查询数据源列表 (MySql、OB_MYSQL、OB_ORACLE)
         *
         * @param tmpReq ListDataSourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDataSourceResponse
         */
        public ListDataSourceResponse ListDataSourceWithOptions(ListDataSourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDataSourceShrinkRequest request = new ListDataSourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Types))
            {
                request.TypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Types, "Types", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                body["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypesShrink))
            {
                body["Types"] = request.TypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSource",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询数据源列表 (MySql、OB_MYSQL、OB_ORACLE)
         *
         * @param tmpReq ListDataSourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDataSourceResponse
         */
        public async Task<ListDataSourceResponse> ListDataSourceWithOptionsAsync(ListDataSourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDataSourceShrinkRequest request = new ListDataSourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Types))
            {
                request.TypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Types, "Types", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                body["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypesShrink))
            {
                body["Types"] = request.TypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSource",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询数据源列表 (MySql、OB_MYSQL、OB_ORACLE)
         *
         * @param request ListDataSourceRequest
         * @return ListDataSourceResponse
         */
        public ListDataSourceResponse ListDataSource(ListDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataSourceWithOptions(request, runtime);
        }

        /**
         * @summary 查询数据源列表 (MySql、OB_MYSQL、OB_ORACLE)
         *
         * @param request ListDataSourceRequest
         * @return ListDataSourceResponse
         */
        public async Task<ListDataSourceResponse> ListDataSourceAsync(ListDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataSourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询项目的全量校验结果
         *
         * @param tmpReq ListProjectFullVerifyResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProjectFullVerifyResultResponse
         */
        public ListProjectFullVerifyResultResponse ListProjectFullVerifyResultWithOptions(ListProjectFullVerifyResultRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListProjectFullVerifyResultShrinkRequest request = new ListProjectFullVerifyResultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DestSchemas))
            {
                request.DestSchemasShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DestSchemas, "DestSchemas", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceSchemas))
            {
                request.SourceSchemasShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceSchemas, "SourceSchemas", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestSchemasShrink))
            {
                body["DestSchemas"] = request.DestSchemasShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSchemasShrink))
            {
                body["SourceSchemas"] = request.SourceSchemasShrink;
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
                Action = "ListProjectFullVerifyResult",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectFullVerifyResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询项目的全量校验结果
         *
         * @param tmpReq ListProjectFullVerifyResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProjectFullVerifyResultResponse
         */
        public async Task<ListProjectFullVerifyResultResponse> ListProjectFullVerifyResultWithOptionsAsync(ListProjectFullVerifyResultRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListProjectFullVerifyResultShrinkRequest request = new ListProjectFullVerifyResultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DestSchemas))
            {
                request.DestSchemasShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DestSchemas, "DestSchemas", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceSchemas))
            {
                request.SourceSchemasShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceSchemas, "SourceSchemas", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestSchemasShrink))
            {
                body["DestSchemas"] = request.DestSchemasShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSchemasShrink))
            {
                body["SourceSchemas"] = request.SourceSchemasShrink;
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
                Action = "ListProjectFullVerifyResult",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectFullVerifyResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询项目的全量校验结果
         *
         * @param request ListProjectFullVerifyResultRequest
         * @return ListProjectFullVerifyResultResponse
         */
        public ListProjectFullVerifyResultResponse ListProjectFullVerifyResult(ListProjectFullVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectFullVerifyResultWithOptions(request, runtime);
        }

        /**
         * @summary 查询项目的全量校验结果
         *
         * @param request ListProjectFullVerifyResultRequest
         * @return ListProjectFullVerifyResultResponse
         */
        public async Task<ListProjectFullVerifyResultResponse> ListProjectFullVerifyResultAsync(ListProjectFullVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectFullVerifyResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据项目 ID 查询项目的修改记录
         *
         * @param request ListProjectModifyRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProjectModifyRecordsResponse
         */
        public ListProjectModifyRecordsResponse ListProjectModifyRecordsWithOptions(ListProjectModifyRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "ListProjectModifyRecords",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectModifyRecordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 根据项目 ID 查询项目的修改记录
         *
         * @param request ListProjectModifyRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProjectModifyRecordsResponse
         */
        public async Task<ListProjectModifyRecordsResponse> ListProjectModifyRecordsWithOptionsAsync(ListProjectModifyRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "ListProjectModifyRecords",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectModifyRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 根据项目 ID 查询项目的修改记录
         *
         * @param request ListProjectModifyRecordsRequest
         * @return ListProjectModifyRecordsResponse
         */
        public ListProjectModifyRecordsResponse ListProjectModifyRecords(ListProjectModifyRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectModifyRecordsWithOptions(request, runtime);
        }

        /**
         * @summary 根据项目 ID 查询项目的修改记录
         *
         * @param request ListProjectModifyRecordsRequest
         * @return ListProjectModifyRecordsResponse
         */
        public async Task<ListProjectModifyRecordsResponse> ListProjectModifyRecordsAsync(ListProjectModifyRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectModifyRecordsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询项目列表
         *
         * @param tmpReq ListProjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProjectsResponse
         */
        public ListProjectsResponse ListProjectsWithOptions(ListProjectsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListProjectsShrinkRequest request = new ListProjectsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelIds))
            {
                request.LabelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelIds, "LabelIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SinkEndpointTypes))
            {
                request.SinkEndpointTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SinkEndpointTypes, "SinkEndpointTypes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceEndpointTypes))
            {
                request.SourceEndpointTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceEndpointTypes, "SourceEndpointTypes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Status))
            {
                request.StatusShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Status, "Status", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelIdsShrink))
            {
                body["LabelIds"] = request.LabelIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRelatedInfo))
            {
                body["NeedRelatedInfo"] = request.NeedRelatedInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                body["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkEndpointTypesShrink))
            {
                body["SinkEndpointTypes"] = request.SinkEndpointTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointTypesShrink))
            {
                body["SourceEndpointTypes"] = request.SourceEndpointTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusShrink))
            {
                body["Status"] = request.StatusShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisibleSubProject))
            {
                body["VisibleSubProject"] = request.VisibleSubProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjects",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询项目列表
         *
         * @param tmpReq ListProjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProjectsResponse
         */
        public async Task<ListProjectsResponse> ListProjectsWithOptionsAsync(ListProjectsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListProjectsShrinkRequest request = new ListProjectsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelIds))
            {
                request.LabelIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelIds, "LabelIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SinkEndpointTypes))
            {
                request.SinkEndpointTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SinkEndpointTypes, "SinkEndpointTypes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceEndpointTypes))
            {
                request.SourceEndpointTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceEndpointTypes, "SourceEndpointTypes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Status))
            {
                request.StatusShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Status, "Status", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelIdsShrink))
            {
                body["LabelIds"] = request.LabelIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRelatedInfo))
            {
                body["NeedRelatedInfo"] = request.NeedRelatedInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                body["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkEndpointTypesShrink))
            {
                body["SinkEndpointTypes"] = request.SinkEndpointTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                body["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndpointTypesShrink))
            {
                body["SourceEndpointTypes"] = request.SourceEndpointTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusShrink))
            {
                body["Status"] = request.StatusShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisibleSubProject))
            {
                body["VisibleSubProject"] = request.VisibleSubProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjects",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询项目列表
         *
         * @param request ListProjectsRequest
         * @return ListProjectsResponse
         */
        public ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectsWithOptions(request, runtime);
        }

        /**
         * @summary 查询项目列表
         *
         * @param request ListProjectsRequest
         * @return ListProjectsResponse
         */
        public async Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询传输实例列表
         *
         * @param tmpReq ListWorkerInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWorkerInstancesResponse
         */
        public ListWorkerInstancesResponse ListWorkerInstancesWithOptions(ListWorkerInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWorkerInstancesShrinkRequest request = new ListWorkerInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Specs))
            {
                request.SpecsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Specs, "Specs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestType))
            {
                body["DestType"] = request.DestType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyBindable))
            {
                body["OnlyBindable"] = request.OnlyBindable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecsShrink))
            {
                body["Specs"] = request.SpecsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkerInstances",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkerInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询传输实例列表
         *
         * @param tmpReq ListWorkerInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWorkerInstancesResponse
         */
        public async Task<ListWorkerInstancesResponse> ListWorkerInstancesWithOptionsAsync(ListWorkerInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWorkerInstancesShrinkRequest request = new ListWorkerInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Specs))
            {
                request.SpecsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Specs, "Specs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestType))
            {
                body["DestType"] = request.DestType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyBindable))
            {
                body["OnlyBindable"] = request.OnlyBindable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecsShrink))
            {
                body["Specs"] = request.SpecsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkerInstances",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkerInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询传输实例列表
         *
         * @param request ListWorkerInstancesRequest
         * @return ListWorkerInstancesResponse
         */
        public ListWorkerInstancesResponse ListWorkerInstances(ListWorkerInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWorkerInstancesWithOptions(request, runtime);
        }

        /**
         * @summary 查询传输实例列表
         *
         * @param request ListWorkerInstancesRequest
         * @return ListWorkerInstancesResponse
         */
        public async Task<ListWorkerInstancesResponse> ListWorkerInstancesAsync(ListWorkerInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWorkerInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The request ID.
         *
         * @param request ModifyDatabaseDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDatabaseDescriptionResponse
         */
        public ModifyDatabaseDescriptionResponse ModifyDatabaseDescriptionWithOptions(ModifyDatabaseDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDatabaseDescription",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDatabaseDescriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The request ID.
         *
         * @param request ModifyDatabaseDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDatabaseDescriptionResponse
         */
        public async Task<ModifyDatabaseDescriptionResponse> ModifyDatabaseDescriptionWithOptionsAsync(ModifyDatabaseDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDatabaseDescription",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDatabaseDescriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The request ID.
         *
         * @param request ModifyDatabaseDescriptionRequest
         * @return ModifyDatabaseDescriptionResponse
         */
        public ModifyDatabaseDescriptionResponse ModifyDatabaseDescription(ModifyDatabaseDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDatabaseDescriptionWithOptions(request, runtime);
        }

        /**
         * @summary The request ID.
         *
         * @param request ModifyDatabaseDescriptionRequest
         * @return ModifyDatabaseDescriptionResponse
         */
        public async Task<ModifyDatabaseDescriptionResponse> ModifyDatabaseDescriptionAsync(ModifyDatabaseDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDatabaseDescriptionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The accounts that have privileges on the database.
         *
         * @param request ModifyDatabaseUserRolesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDatabaseUserRolesResponse
         */
        public ModifyDatabaseUserRolesResponse ModifyDatabaseUserRolesWithOptions(ModifyDatabaseUserRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDatabaseUserRoles",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDatabaseUserRolesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The accounts that have privileges on the database.
         *
         * @param request ModifyDatabaseUserRolesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDatabaseUserRolesResponse
         */
        public async Task<ModifyDatabaseUserRolesResponse> ModifyDatabaseUserRolesWithOptionsAsync(ModifyDatabaseUserRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDatabaseUserRoles",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDatabaseUserRolesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The accounts that have privileges on the database.
         *
         * @param request ModifyDatabaseUserRolesRequest
         * @return ModifyDatabaseUserRolesResponse
         */
        public ModifyDatabaseUserRolesResponse ModifyDatabaseUserRoles(ModifyDatabaseUserRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDatabaseUserRolesWithOptions(request, runtime);
        }

        /**
         * @summary The accounts that have privileges on the database.
         *
         * @param request ModifyDatabaseUserRolesRequest
         * @return ModifyDatabaseUserRolesResponse
         */
        public async Task<ModifyDatabaseUserRolesResponse> ModifyDatabaseUserRolesAsync(ModifyDatabaseUserRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDatabaseUserRolesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The name of the OceanBase cluster.
         *
         * @param request ModifyInstanceNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceNameResponse
         */
        public ModifyInstanceNameResponse ModifyInstanceNameWithOptions(ModifyInstanceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceName",
                Version = "2019-09-01",
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
         * @summary The name of the OceanBase cluster.
         *
         * @param request ModifyInstanceNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceNameResponse
         */
        public async Task<ModifyInstanceNameResponse> ModifyInstanceNameWithOptionsAsync(ModifyInstanceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceName",
                Version = "2019-09-01",
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
         * @summary The name of the OceanBase cluster.
         *
         * @param request ModifyInstanceNameRequest
         * @return ModifyInstanceNameResponse
         */
        public ModifyInstanceNameResponse ModifyInstanceName(ModifyInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceNameWithOptions(request, runtime);
        }

        /**
         * @summary The name of the OceanBase cluster.
         *
         * @param request ModifyInstanceNameRequest
         * @return ModifyInstanceNameResponse
         */
        public async Task<ModifyInstanceNameResponse> ModifyInstanceNameAsync(ModifyInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceNameWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to modify the number of nodes in a cluster.
         *
         * @param request ModifyInstanceNodeNumRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceNodeNumResponse
         */
        public ModifyInstanceNodeNumResponse ModifyInstanceNodeNumWithOptions(ModifyInstanceNodeNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeNum))
            {
                body["NodeNum"] = request.NodeNum;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceNodeNum",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceNodeNumResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to modify the number of nodes in a cluster.
         *
         * @param request ModifyInstanceNodeNumRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceNodeNumResponse
         */
        public async Task<ModifyInstanceNodeNumResponse> ModifyInstanceNodeNumWithOptionsAsync(ModifyInstanceNodeNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeNum))
            {
                body["NodeNum"] = request.NodeNum;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceNodeNum",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceNodeNumResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to modify the number of nodes in a cluster.
         *
         * @param request ModifyInstanceNodeNumRequest
         * @return ModifyInstanceNodeNumResponse
         */
        public ModifyInstanceNodeNumResponse ModifyInstanceNodeNum(ModifyInstanceNodeNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceNodeNumWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to modify the number of nodes in a cluster.
         *
         * @param request ModifyInstanceNodeNumRequest
         * @return ModifyInstanceNodeNumResponse
         */
        public async Task<ModifyInstanceNodeNumResponse> ModifyInstanceNodeNumAsync(ModifyInstanceNodeNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceNodeNumWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to modify the Secure Sockets Layer (SSL) setting for an OceanBase cluster instance.
         *
         * @description There is currently no authorization information disclosed in the API.
         *
         * @param request ModifyInstanceSSLRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceSSLResponse
         */
        public ModifyInstanceSSLResponse ModifyInstanceSSLWithOptions(ModifyInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSSL))
            {
                body["EnableSSL"] = request.EnableSSL;
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
                Action = "ModifyInstanceSSL",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceSSLResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to modify the Secure Sockets Layer (SSL) setting for an OceanBase cluster instance.
         *
         * @description There is currently no authorization information disclosed in the API.
         *
         * @param request ModifyInstanceSSLRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceSSLResponse
         */
        public async Task<ModifyInstanceSSLResponse> ModifyInstanceSSLWithOptionsAsync(ModifyInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSSL))
            {
                body["EnableSSL"] = request.EnableSSL;
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
                Action = "ModifyInstanceSSL",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceSSLResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to modify the Secure Sockets Layer (SSL) setting for an OceanBase cluster instance.
         *
         * @description There is currently no authorization information disclosed in the API.
         *
         * @param request ModifyInstanceSSLRequest
         * @return ModifyInstanceSSLResponse
         */
        public ModifyInstanceSSLResponse ModifyInstanceSSL(ModifyInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceSSLWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to modify the Secure Sockets Layer (SSL) setting for an OceanBase cluster instance.
         *
         * @description There is currently no authorization information disclosed in the API.
         *
         * @param request ModifyInstanceSSLRequest
         * @return ModifyInstanceSSLResponse
         */
        public async Task<ModifyInstanceSSLResponse> ModifyInstanceSSLAsync(ModifyInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceSSLWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to modify the cluster specifications and storage space.
         *
         * @param request ModifyInstanceSpecRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceSpecResponse
         */
        public ModifyInstanceSpecResponse ModifyInstanceSpecWithOptions(ModifyInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                body["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                body["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceClass))
            {
                body["InstanceClass"] = request.InstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeSpecNative))
            {
                body["UpgradeSpecNative"] = request.UpgradeSpecNative;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceSpec",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceSpecResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to modify the cluster specifications and storage space.
         *
         * @param request ModifyInstanceSpecRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceSpecResponse
         */
        public async Task<ModifyInstanceSpecResponse> ModifyInstanceSpecWithOptionsAsync(ModifyInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                body["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                body["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceClass))
            {
                body["InstanceClass"] = request.InstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeSpecNative))
            {
                body["UpgradeSpecNative"] = request.UpgradeSpecNative;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceSpec",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to modify the cluster specifications and storage space.
         *
         * @param request ModifyInstanceSpecRequest
         * @return ModifyInstanceSpecResponse
         */
        public ModifyInstanceSpecResponse ModifyInstanceSpec(ModifyInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceSpecWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to modify the cluster specifications and storage space.
         *
         * @param request ModifyInstanceSpecRequest
         * @return ModifyInstanceSpecResponse
         */
        public async Task<ModifyInstanceSpecResponse> ModifyInstanceSpecAsync(ModifyInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceSpecWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to modify the tags of a cluster.
         *
         * @param request ModifyInstanceTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceTagsResponse
         */
        public ModifyInstanceTagsResponse ModifyInstanceTagsWithOptions(ModifyInstanceTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceTags",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceTagsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to modify the tags of a cluster.
         *
         * @param request ModifyInstanceTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceTagsResponse
         */
        public async Task<ModifyInstanceTagsResponse> ModifyInstanceTagsWithOptionsAsync(ModifyInstanceTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceTags",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to modify the tags of a cluster.
         *
         * @param request ModifyInstanceTagsRequest
         * @return ModifyInstanceTagsResponse
         */
        public ModifyInstanceTagsResponse ModifyInstanceTags(ModifyInstanceTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceTagsWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to modify the tags of a cluster.
         *
         * @param request ModifyInstanceTagsRequest
         * @return ModifyInstanceTagsResponse
         */
        public async Task<ModifyInstanceTagsResponse> ModifyInstanceTagsAsync(ModifyInstanceTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceTagsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to modify the temporary capacity of the OceanBase cluster.
         *
         * @param request ModifyInstanceTemporaryCapacityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceTemporaryCapacityResponse
         */
        public ModifyInstanceTemporaryCapacityResponse ModifyInstanceTemporaryCapacityWithOptions(ModifyInstanceTemporaryCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                body["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spec))
            {
                body["Spec"] = request.Spec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceTemporaryCapacity",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceTemporaryCapacityResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to modify the temporary capacity of the OceanBase cluster.
         *
         * @param request ModifyInstanceTemporaryCapacityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceTemporaryCapacityResponse
         */
        public async Task<ModifyInstanceTemporaryCapacityResponse> ModifyInstanceTemporaryCapacityWithOptionsAsync(ModifyInstanceTemporaryCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                body["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                body["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spec))
            {
                body["Spec"] = request.Spec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceTemporaryCapacity",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceTemporaryCapacityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to modify the temporary capacity of the OceanBase cluster.
         *
         * @param request ModifyInstanceTemporaryCapacityRequest
         * @return ModifyInstanceTemporaryCapacityResponse
         */
        public ModifyInstanceTemporaryCapacityResponse ModifyInstanceTemporaryCapacity(ModifyInstanceTemporaryCapacityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceTemporaryCapacityWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to modify the temporary capacity of the OceanBase cluster.
         *
         * @param request ModifyInstanceTemporaryCapacityRequest
         * @return ModifyInstanceTemporaryCapacityResponse
         */
        public async Task<ModifyInstanceTemporaryCapacityResponse> ModifyInstanceTemporaryCapacityAsync(ModifyInstanceTemporaryCapacityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceTemporaryCapacityWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The modification results.
         *
         * @param request ModifyParametersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyParametersResponse
         */
        public ModifyParametersResponse ModifyParametersWithOptions(ModifyParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimension))
            {
                body["Dimension"] = request.Dimension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DimensionValue))
            {
                body["DimensionValue"] = request.DimensionValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["Parameters"] = request.Parameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyParameters",
                Version = "2019-09-01",
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
         * @summary The modification results.
         *
         * @param request ModifyParametersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyParametersResponse
         */
        public async Task<ModifyParametersResponse> ModifyParametersWithOptionsAsync(ModifyParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimension))
            {
                body["Dimension"] = request.Dimension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DimensionValue))
            {
                body["DimensionValue"] = request.DimensionValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["Parameters"] = request.Parameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyParameters",
                Version = "2019-09-01",
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
         * @summary The modification results.
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
         * @summary The modification results.
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
         * @summary The name of the security group.
         *
         * @param request ModifySecurityIpsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifySecurityIpsResponse
         */
        public ModifySecurityIpsResponse ModifySecurityIpsWithOptions(ModifySecurityIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIpGroupName))
            {
                body["SecurityIpGroupName"] = request.SecurityIpGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIps))
            {
                body["SecurityIps"] = request.SecurityIps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySecurityIps",
                Version = "2019-09-01",
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
         * @summary The name of the security group.
         *
         * @param request ModifySecurityIpsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifySecurityIpsResponse
         */
        public async Task<ModifySecurityIpsResponse> ModifySecurityIpsWithOptionsAsync(ModifySecurityIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIpGroupName))
            {
                body["SecurityIpGroupName"] = request.SecurityIpGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIps))
            {
                body["SecurityIps"] = request.SecurityIps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySecurityIps",
                Version = "2019-09-01",
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
         * @summary The name of the security group.
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
         * @summary The name of the security group.
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
         * @param request ModifyTagNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTagNameResponse
         */
        public ModifyTagNameResponse ModifyTagNameWithOptions(ModifyTagNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                body["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewKey))
            {
                body["NewKey"] = request.NewKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTagName",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTagNameResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyTagNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTagNameResponse
         */
        public async Task<ModifyTagNameResponse> ModifyTagNameWithOptionsAsync(ModifyTagNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                body["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewKey))
            {
                body["NewKey"] = request.NewKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTagName",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTagNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyTagNameRequest
         * @return ModifyTagNameResponse
         */
        public ModifyTagNameResponse ModifyTagName(ModifyTagNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTagNameWithOptions(request, runtime);
        }

        /**
         * @param request ModifyTagNameRequest
         * @return ModifyTagNameResponse
         */
        public async Task<ModifyTagNameResponse> ModifyTagNameAsync(ModifyTagNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTagNameWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to rename a tag.
         *
         * @param request ModifyTagValueNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTagValueNameResponse
         */
        public ModifyTagValueNameResponse ModifyTagValueNameWithOptions(ModifyTagValueNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                body["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewValue))
            {
                body["NewValue"] = request.NewValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTagValueName",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTagValueNameResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to rename a tag.
         *
         * @param request ModifyTagValueNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTagValueNameResponse
         */
        public async Task<ModifyTagValueNameResponse> ModifyTagValueNameWithOptionsAsync(ModifyTagValueNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                body["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewValue))
            {
                body["NewValue"] = request.NewValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTagValueName",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTagValueNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to rename a tag.
         *
         * @param request ModifyTagValueNameRequest
         * @return ModifyTagValueNameResponse
         */
        public ModifyTagValueNameResponse ModifyTagValueName(ModifyTagValueNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTagValueNameWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to rename a tag.
         *
         * @param request ModifyTagValueNameRequest
         * @return ModifyTagValueNameResponse
         */
        public async Task<ModifyTagValueNameResponse> ModifyTagValueNameAsync(ModifyTagValueNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTagValueNameWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 租户加密变更
         *
         * @param request ModifyTenantEncryptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTenantEncryptionResponse
         */
        public ModifyTenantEncryptionResponse ModifyTenantEncryptionWithOptions(ModifyTenantEncryptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionKeyId))
            {
                body["EncryptionKeyId"] = request.EncryptionKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionType))
            {
                body["EncryptionType"] = request.EncryptionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantEncryption",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantEncryptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 租户加密变更
         *
         * @param request ModifyTenantEncryptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTenantEncryptionResponse
         */
        public async Task<ModifyTenantEncryptionResponse> ModifyTenantEncryptionWithOptionsAsync(ModifyTenantEncryptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionKeyId))
            {
                body["EncryptionKeyId"] = request.EncryptionKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionType))
            {
                body["EncryptionType"] = request.EncryptionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantEncryption",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantEncryptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 租户加密变更
         *
         * @param request ModifyTenantEncryptionRequest
         * @return ModifyTenantEncryptionResponse
         */
        public ModifyTenantEncryptionResponse ModifyTenantEncryption(ModifyTenantEncryptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTenantEncryptionWithOptions(request, runtime);
        }

        /**
         * @summary 租户加密变更
         *
         * @param request ModifyTenantEncryptionRequest
         * @return ModifyTenantEncryptionResponse
         */
        public async Task<ModifyTenantEncryptionResponse> ModifyTenantEncryptionAsync(ModifyTenantEncryptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTenantEncryptionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The return result of the request.
         *
         * @param request ModifyTenantPrimaryZoneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTenantPrimaryZoneResponse
         */
        public ModifyTenantPrimaryZoneResponse ModifyTenantPrimaryZoneWithOptions(ModifyTenantPrimaryZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterIntranetAddressZone))
            {
                body["MasterIntranetAddressZone"] = request.MasterIntranetAddressZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryZone))
            {
                body["PrimaryZone"] = request.PrimaryZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantEndpointDirectId))
            {
                body["TenantEndpointDirectId"] = request.TenantEndpointDirectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantEndpointId))
            {
                body["TenantEndpointId"] = request.TenantEndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDirectVSwitchId))
            {
                body["UserDirectVSwitchId"] = request.UserDirectVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVSwitchId))
            {
                body["UserVSwitchId"] = request.UserVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpcOwnerId))
            {
                body["UserVpcOwnerId"] = request.UserVpcOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantPrimaryZone",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantPrimaryZoneResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The return result of the request.
         *
         * @param request ModifyTenantPrimaryZoneRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTenantPrimaryZoneResponse
         */
        public async Task<ModifyTenantPrimaryZoneResponse> ModifyTenantPrimaryZoneWithOptionsAsync(ModifyTenantPrimaryZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterIntranetAddressZone))
            {
                body["MasterIntranetAddressZone"] = request.MasterIntranetAddressZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryZone))
            {
                body["PrimaryZone"] = request.PrimaryZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantEndpointDirectId))
            {
                body["TenantEndpointDirectId"] = request.TenantEndpointDirectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantEndpointId))
            {
                body["TenantEndpointId"] = request.TenantEndpointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDirectVSwitchId))
            {
                body["UserDirectVSwitchId"] = request.UserDirectVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVSwitchId))
            {
                body["UserVSwitchId"] = request.UserVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserVpcOwnerId))
            {
                body["UserVpcOwnerId"] = request.UserVpcOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantPrimaryZone",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantPrimaryZoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The return result of the request.
         *
         * @param request ModifyTenantPrimaryZoneRequest
         * @return ModifyTenantPrimaryZoneResponse
         */
        public ModifyTenantPrimaryZoneResponse ModifyTenantPrimaryZone(ModifyTenantPrimaryZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTenantPrimaryZoneWithOptions(request, runtime);
        }

        /**
         * @summary The return result of the request.
         *
         * @param request ModifyTenantPrimaryZoneRequest
         * @return ModifyTenantPrimaryZoneResponse
         */
        public async Task<ModifyTenantPrimaryZoneResponse> ModifyTenantPrimaryZoneAsync(ModifyTenantPrimaryZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTenantPrimaryZoneWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to modify the specifications of a tenant in an OceanBase cluster.
         *
         * @param request ModifyTenantResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTenantResourceResponse
         */
        public ModifyTenantResourceResponse ModifyTenantResourceWithOptions(ModifyTenantResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                body["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogDisk))
            {
                body["LogDisk"] = request.LogDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                body["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadOnlyZoneList))
            {
                body["ReadOnlyZoneList"] = request.ReadOnlyZoneList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantResource",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to modify the specifications of a tenant in an OceanBase cluster.
         *
         * @param request ModifyTenantResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTenantResourceResponse
         */
        public async Task<ModifyTenantResourceResponse> ModifyTenantResourceWithOptionsAsync(ModifyTenantResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                body["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogDisk))
            {
                body["LogDisk"] = request.LogDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                body["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadOnlyZoneList))
            {
                body["ReadOnlyZoneList"] = request.ReadOnlyZoneList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantResource",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to modify the specifications of a tenant in an OceanBase cluster.
         *
         * @param request ModifyTenantResourceRequest
         * @return ModifyTenantResourceResponse
         */
        public ModifyTenantResourceResponse ModifyTenantResource(ModifyTenantResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTenantResourceWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to modify the specifications of a tenant in an OceanBase cluster.
         *
         * @param request ModifyTenantResourceRequest
         * @return ModifyTenantResourceResponse
         */
        public async Task<ModifyTenantResourceResponse> ModifyTenantResourceAsync(ModifyTenantResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTenantResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to modify the information on the whitelist group of the tenant.
         *
         * @param request ModifyTenantSecurityIpGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTenantSecurityIpGroupResponse
         */
        public ModifyTenantSecurityIpGroupResponse ModifyTenantSecurityIpGroupWithOptions(ModifyTenantSecurityIpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIpGroupName))
            {
                body["SecurityIpGroupName"] = request.SecurityIpGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIps))
            {
                body["SecurityIps"] = request.SecurityIps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantSecurityIpGroup",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantSecurityIpGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to modify the information on the whitelist group of the tenant.
         *
         * @param request ModifyTenantSecurityIpGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTenantSecurityIpGroupResponse
         */
        public async Task<ModifyTenantSecurityIpGroupResponse> ModifyTenantSecurityIpGroupWithOptionsAsync(ModifyTenantSecurityIpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIpGroupName))
            {
                body["SecurityIpGroupName"] = request.SecurityIpGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityIps))
            {
                body["SecurityIps"] = request.SecurityIps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantSecurityIpGroup",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantSecurityIpGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to modify the information on the whitelist group of the tenant.
         *
         * @param request ModifyTenantSecurityIpGroupRequest
         * @return ModifyTenantSecurityIpGroupResponse
         */
        public ModifyTenantSecurityIpGroupResponse ModifyTenantSecurityIpGroup(ModifyTenantSecurityIpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTenantSecurityIpGroupWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to modify the information on the whitelist group of the tenant.
         *
         * @param request ModifyTenantSecurityIpGroupRequest
         * @return ModifyTenantSecurityIpGroupResponse
         */
        public async Task<ModifyTenantSecurityIpGroupResponse> ModifyTenantSecurityIpGroupAsync(ModifyTenantSecurityIpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTenantSecurityIpGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to modify the tags of a tenant.
         *
         * @param request ModifyTenantTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTenantTagsResponse
         */
        public ModifyTenantTagsResponse ModifyTenantTagsWithOptions(ModifyTenantTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantTags",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantTagsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to modify the tags of a tenant.
         *
         * @param request ModifyTenantTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTenantTagsResponse
         */
        public async Task<ModifyTenantTagsResponse> ModifyTenantTagsWithOptionsAsync(ModifyTenantTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantTags",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to modify the tags of a tenant.
         *
         * @param request ModifyTenantTagsRequest
         * @return ModifyTenantTagsResponse
         */
        public ModifyTenantTagsResponse ModifyTenantTags(ModifyTenantTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTenantTagsWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to modify the tags of a tenant.
         *
         * @param request ModifyTenantTagsRequest
         * @return ModifyTenantTagsResponse
         */
        public async Task<ModifyTenantTagsResponse> ModifyTenantTagsAsync(ModifyTenantTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTenantTagsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The description of the database.
         *
         * @param request ModifyTenantUserDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTenantUserDescriptionResponse
         */
        public ModifyTenantUserDescriptionResponse ModifyTenantUserDescriptionWithOptions(ModifyTenantUserDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantUserDescription",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantUserDescriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The description of the database.
         *
         * @param request ModifyTenantUserDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTenantUserDescriptionResponse
         */
        public async Task<ModifyTenantUserDescriptionResponse> ModifyTenantUserDescriptionWithOptionsAsync(ModifyTenantUserDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantUserDescription",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantUserDescriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The description of the database.
         *
         * @param request ModifyTenantUserDescriptionRequest
         * @return ModifyTenantUserDescriptionResponse
         */
        public ModifyTenantUserDescriptionResponse ModifyTenantUserDescription(ModifyTenantUserDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTenantUserDescriptionWithOptions(request, runtime);
        }

        /**
         * @summary The description of the database.
         *
         * @param request ModifyTenantUserDescriptionRequest
         * @return ModifyTenantUserDescriptionResponse
         */
        public async Task<ModifyTenantUserDescriptionResponse> ModifyTenantUserDescriptionAsync(ModifyTenantUserDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTenantUserDescriptionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The request ID.
         *
         * @param request ModifyTenantUserPasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTenantUserPasswordResponse
         */
        public ModifyTenantUserPasswordResponse ModifyTenantUserPasswordWithOptions(ModifyTenantUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionType))
            {
                body["EncryptionType"] = request.EncryptionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPassword))
            {
                body["UserPassword"] = request.UserPassword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantUserPassword",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantUserPasswordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The request ID.
         *
         * @param request ModifyTenantUserPasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTenantUserPasswordResponse
         */
        public async Task<ModifyTenantUserPasswordResponse> ModifyTenantUserPasswordWithOptionsAsync(ModifyTenantUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionType))
            {
                body["EncryptionType"] = request.EncryptionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPassword))
            {
                body["UserPassword"] = request.UserPassword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantUserPassword",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantUserPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The request ID.
         *
         * @param request ModifyTenantUserPasswordRequest
         * @return ModifyTenantUserPasswordResponse
         */
        public ModifyTenantUserPasswordResponse ModifyTenantUserPassword(ModifyTenantUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTenantUserPasswordWithOptions(request, runtime);
        }

        /**
         * @summary The request ID.
         *
         * @param request ModifyTenantUserPasswordRequest
         * @return ModifyTenantUserPasswordResponse
         */
        public async Task<ModifyTenantUserPasswordResponse> ModifyTenantUserPasswordAsync(ModifyTenantUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTenantUserPasswordWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Indicates whether the privilege was granted to the role.
         *
         * @param request ModifyTenantUserRolesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTenantUserRolesResponse
         */
        public ModifyTenantUserRolesResponse ModifyTenantUserRolesWithOptions(ModifyTenantUserRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyType))
            {
                body["ModifyType"] = request.ModifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserRole))
            {
                body["UserRole"] = request.UserRole;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantUserRoles",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantUserRolesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Indicates whether the privilege was granted to the role.
         *
         * @param request ModifyTenantUserRolesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTenantUserRolesResponse
         */
        public async Task<ModifyTenantUserRolesResponse> ModifyTenantUserRolesWithOptionsAsync(ModifyTenantUserRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyType))
            {
                body["ModifyType"] = request.ModifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserRole))
            {
                body["UserRole"] = request.UserRole;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantUserRoles",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantUserRolesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Indicates whether the privilege was granted to the role.
         *
         * @param request ModifyTenantUserRolesRequest
         * @return ModifyTenantUserRolesResponse
         */
        public ModifyTenantUserRolesResponse ModifyTenantUserRoles(ModifyTenantUserRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTenantUserRolesWithOptions(request, runtime);
        }

        /**
         * @summary Indicates whether the privilege was granted to the role.
         *
         * @param request ModifyTenantUserRolesRequest
         * @return ModifyTenantUserRolesResponse
         */
        public async Task<ModifyTenantUserRolesResponse> ModifyTenantUserRolesAsync(ModifyTenantUserRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTenantUserRolesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary The ID of the tenant.
         *
         * @param request ModifyTenantUserStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTenantUserStatusResponse
         */
        public ModifyTenantUserStatusResponse ModifyTenantUserStatusWithOptions(ModifyTenantUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserStatus))
            {
                body["UserStatus"] = request.UserStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantUserStatus",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantUserStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The ID of the tenant.
         *
         * @param request ModifyTenantUserStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTenantUserStatusResponse
         */
        public async Task<ModifyTenantUserStatusResponse> ModifyTenantUserStatusWithOptionsAsync(ModifyTenantUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserStatus))
            {
                body["UserStatus"] = request.UserStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantUserStatus",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantUserStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The ID of the tenant.
         *
         * @param request ModifyTenantUserStatusRequest
         * @return ModifyTenantUserStatusResponse
         */
        public ModifyTenantUserStatusResponse ModifyTenantUserStatus(ModifyTenantUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTenantUserStatusWithOptions(request, runtime);
        }

        /**
         * @summary The ID of the tenant.
         *
         * @param request ModifyTenantUserStatusRequest
         * @return ModifyTenantUserStatusResponse
         */
        public async Task<ModifyTenantUserStatusResponse> ModifyTenantUserStatusAsync(ModifyTenantUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTenantUserStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 释放项目
         *
         * @param request ReleaseProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseProjectResponse
         */
        public ReleaseProjectResponse ReleaseProjectWithOptions(ReleaseProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "ReleaseProject",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 释放项目
         *
         * @param request ReleaseProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseProjectResponse
         */
        public async Task<ReleaseProjectResponse> ReleaseProjectWithOptionsAsync(ReleaseProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "ReleaseProject",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 释放项目
         *
         * @param request ReleaseProjectRequest
         * @return ReleaseProjectResponse
         */
        public ReleaseProjectResponse ReleaseProject(ReleaseProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseProjectWithOptions(request, runtime);
        }

        /**
         * @summary 释放项目
         *
         * @param request ReleaseProjectRequest
         * @return ReleaseProjectResponse
         */
        public async Task<ReleaseProjectResponse> ReleaseProjectAsync(ReleaseProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseProjectWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 释放传输实例 （未绑定项目时才可以释放）
         *
         * @param request ReleaseWorkerInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseWorkerInstanceResponse
         */
        public ReleaseWorkerInstanceResponse ReleaseWorkerInstanceWithOptions(ReleaseWorkerInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "ReleaseWorkerInstance",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseWorkerInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 释放传输实例 （未绑定项目时才可以释放）
         *
         * @param request ReleaseWorkerInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseWorkerInstanceResponse
         */
        public async Task<ReleaseWorkerInstanceResponse> ReleaseWorkerInstanceWithOptionsAsync(ReleaseWorkerInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "ReleaseWorkerInstance",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseWorkerInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 释放传输实例 （未绑定项目时才可以释放）
         *
         * @param request ReleaseWorkerInstanceRequest
         * @return ReleaseWorkerInstanceResponse
         */
        public ReleaseWorkerInstanceResponse ReleaseWorkerInstance(ReleaseWorkerInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseWorkerInstanceWithOptions(request, runtime);
        }

        /**
         * @summary 释放传输实例 （未绑定项目时才可以释放）
         *
         * @param request ReleaseWorkerInstanceRequest
         * @return ReleaseWorkerInstanceResponse
         */
        public async Task<ReleaseWorkerInstanceResponse> ReleaseWorkerInstanceAsync(ReleaseWorkerInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseWorkerInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 备实例解耦
         *
         * @param request RemoveStandbyInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveStandbyInstanceResponse
         */
        public RemoveStandbyInstanceResponse RemoveStandbyInstanceWithOptions(RemoveStandbyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Forced))
            {
                body["Forced"] = request.Forced;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInstanceId))
            {
                body["TargetInstanceId"] = request.TargetInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveStandbyInstance",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveStandbyInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 备实例解耦
         *
         * @param request RemoveStandbyInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveStandbyInstanceResponse
         */
        public async Task<RemoveStandbyInstanceResponse> RemoveStandbyInstanceWithOptionsAsync(RemoveStandbyInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Forced))
            {
                body["Forced"] = request.Forced;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInstanceId))
            {
                body["TargetInstanceId"] = request.TargetInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveStandbyInstance",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveStandbyInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 备实例解耦
         *
         * @param request RemoveStandbyInstanceRequest
         * @return RemoveStandbyInstanceResponse
         */
        public RemoveStandbyInstanceResponse RemoveStandbyInstance(RemoveStandbyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveStandbyInstanceWithOptions(request, runtime);
        }

        /**
         * @summary 备实例解耦
         *
         * @param request RemoveStandbyInstanceRequest
         * @return RemoveStandbyInstanceResponse
         */
        public async Task<RemoveStandbyInstanceResponse> RemoveStandbyInstanceAsync(RemoveStandbyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveStandbyInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 恢复项目
         *
         * @param request ResumeProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResumeProjectResponse
         */
        public ResumeProjectResponse ResumeProjectWithOptions(ResumeProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "ResumeProject",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 恢复项目
         *
         * @param request ResumeProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResumeProjectResponse
         */
        public async Task<ResumeProjectResponse> ResumeProjectWithOptionsAsync(ResumeProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "ResumeProject",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 恢复项目
         *
         * @param request ResumeProjectRequest
         * @return ResumeProjectResponse
         */
        public ResumeProjectResponse ResumeProject(ResumeProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeProjectWithOptions(request, runtime);
        }

        /**
         * @summary 恢复项目
         *
         * @param request ResumeProjectRequest
         * @return ResumeProjectResponse
         */
        public async Task<ResumeProjectResponse> ResumeProjectAsync(ResumeProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeProjectWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据修改记录 ID 重试修改操作（仅支持处于 FAILED 状态的修改记录）
         *
         * @param request RetryProjectModifyRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetryProjectModifyRecordsResponse
         */
        public RetryProjectModifyRecordsResponse RetryProjectModifyRecordsWithOptions(RetryProjectModifyRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "RetryProjectModifyRecords",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryProjectModifyRecordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 根据修改记录 ID 重试修改操作（仅支持处于 FAILED 状态的修改记录）
         *
         * @param request RetryProjectModifyRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetryProjectModifyRecordsResponse
         */
        public async Task<RetryProjectModifyRecordsResponse> RetryProjectModifyRecordsWithOptionsAsync(RetryProjectModifyRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "RetryProjectModifyRecords",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryProjectModifyRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 根据修改记录 ID 重试修改操作（仅支持处于 FAILED 状态的修改记录）
         *
         * @param request RetryProjectModifyRecordsRequest
         * @return RetryProjectModifyRecordsResponse
         */
        public RetryProjectModifyRecordsResponse RetryProjectModifyRecords(RetryProjectModifyRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RetryProjectModifyRecordsWithOptions(request, runtime);
        }

        /**
         * @summary 根据修改记录 ID 重试修改操作（仅支持处于 FAILED 状态的修改记录）
         *
         * @param request RetryProjectModifyRecordsRequest
         * @return RetryProjectModifyRecordsResponse
         */
        public async Task<RetryProjectModifyRecordsResponse> RetryProjectModifyRecordsAsync(RetryProjectModifyRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RetryProjectModifyRecordsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 启动项目
         *
         * @param request StartProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartProjectResponse
         */
        public StartProjectResponse StartProjectWithOptions(StartProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "StartProject",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 启动项目
         *
         * @param request StartProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartProjectResponse
         */
        public async Task<StartProjectResponse> StartProjectWithOptionsAsync(StartProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "StartProject",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 启动项目
         *
         * @param request StartProjectRequest
         * @return StartProjectResponse
         */
        public StartProjectResponse StartProject(StartProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartProjectWithOptions(request, runtime);
        }

        /**
         * @summary 启动项目
         *
         * @param request StartProjectRequest
         * @return StartProjectResponse
         */
        public async Task<StartProjectResponse> StartProjectAsync(StartProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartProjectWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 启动该label下的所有未启动项目
         *
         * @param request StartProjectsByLabelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartProjectsByLabelResponse
         */
        public StartProjectsByLabelResponse StartProjectsByLabelWithOptions(StartProjectsByLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "StartProjectsByLabel",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartProjectsByLabelResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 启动该label下的所有未启动项目
         *
         * @param request StartProjectsByLabelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartProjectsByLabelResponse
         */
        public async Task<StartProjectsByLabelResponse> StartProjectsByLabelWithOptionsAsync(StartProjectsByLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "StartProjectsByLabel",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartProjectsByLabelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 启动该label下的所有未启动项目
         *
         * @param request StartProjectsByLabelRequest
         * @return StartProjectsByLabelResponse
         */
        public StartProjectsByLabelResponse StartProjectsByLabel(StartProjectsByLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartProjectsByLabelWithOptions(request, runtime);
        }

        /**
         * @summary 启动该label下的所有未启动项目
         *
         * @param request StartProjectsByLabelRequest
         * @return StartProjectsByLabelResponse
         */
        public async Task<StartProjectsByLabelResponse> StartProjectsByLabelAsync(StartProjectsByLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartProjectsByLabelWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 暂停项目
         *
         * @param request StopProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopProjectResponse
         */
        public StopProjectResponse StopProjectWithOptions(StopProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "StopProject",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 暂停项目
         *
         * @param request StopProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopProjectResponse
         */
        public async Task<StopProjectResponse> StopProjectWithOptionsAsync(StopProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "StopProject",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 暂停项目
         *
         * @param request StopProjectRequest
         * @return StopProjectResponse
         */
        public StopProjectResponse StopProject(StopProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopProjectWithOptions(request, runtime);
        }

        /**
         * @summary 暂停项目
         *
         * @param request StopProjectRequest
         * @return StopProjectResponse
         */
        public async Task<StopProjectResponse> StopProjectAsync(StopProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopProjectWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据修改记录 ID 终止修改操作，不可恢复（仅支持处于 RUNNING / FAILED 状态的修改记录）
         *
         * @param request StopProjectModifyRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopProjectModifyRecordsResponse
         */
        public StopProjectModifyRecordsResponse StopProjectModifyRecordsWithOptions(StopProjectModifyRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "StopProjectModifyRecords",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopProjectModifyRecordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 根据修改记录 ID 终止修改操作，不可恢复（仅支持处于 RUNNING / FAILED 状态的修改记录）
         *
         * @param request StopProjectModifyRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopProjectModifyRecordsResponse
         */
        public async Task<StopProjectModifyRecordsResponse> StopProjectModifyRecordsWithOptionsAsync(StopProjectModifyRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "StopProjectModifyRecords",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopProjectModifyRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 根据修改记录 ID 终止修改操作，不可恢复（仅支持处于 RUNNING / FAILED 状态的修改记录）
         *
         * @param request StopProjectModifyRecordsRequest
         * @return StopProjectModifyRecordsResponse
         */
        public StopProjectModifyRecordsResponse StopProjectModifyRecords(StopProjectModifyRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopProjectModifyRecordsWithOptions(request, runtime);
        }

        /**
         * @summary 根据修改记录 ID 终止修改操作，不可恢复（仅支持处于 RUNNING / FAILED 状态的修改记录）
         *
         * @param request StopProjectModifyRecordsRequest
         * @return StopProjectModifyRecordsResponse
         */
        public async Task<StopProjectModifyRecordsResponse> StopProjectModifyRecordsAsync(StopProjectModifyRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopProjectModifyRecordsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 暂停该label下的所有运行中项目
         *
         * @param request StopProjectsByLabelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopProjectsByLabelResponse
         */
        public StopProjectsByLabelResponse StopProjectsByLabelWithOptions(StopProjectsByLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "StopProjectsByLabel",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopProjectsByLabelResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 暂停该label下的所有运行中项目
         *
         * @param request StopProjectsByLabelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopProjectsByLabelResponse
         */
        public async Task<StopProjectsByLabelResponse> StopProjectsByLabelWithOptionsAsync(StopProjectsByLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "StopProjectsByLabel",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopProjectsByLabelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 暂停该label下的所有运行中项目
         *
         * @param request StopProjectsByLabelRequest
         * @return StopProjectsByLabelResponse
         */
        public StopProjectsByLabelResponse StopProjectsByLabel(StopProjectsByLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopProjectsByLabelWithOptions(request, runtime);
        }

        /**
         * @summary 暂停该label下的所有运行中项目
         *
         * @param request StopProjectsByLabelRequest
         * @return StopProjectsByLabelResponse
         */
        public async Task<StopProjectsByLabelResponse> StopProjectsByLabelAsync(StopProjectsByLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopProjectsByLabelWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to switch between the primary and standby instances of OceanBase.
         *
         * @param request SwitchoverInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SwitchoverInstanceResponse
         */
        public SwitchoverInstanceResponse SwitchoverInstanceWithOptions(SwitchoverInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Forced))
            {
                body["Forced"] = request.Forced;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInstanceId))
            {
                body["TargetInstanceId"] = request.TargetInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchoverInstance",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchoverInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to switch between the primary and standby instances of OceanBase.
         *
         * @param request SwitchoverInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SwitchoverInstanceResponse
         */
        public async Task<SwitchoverInstanceResponse> SwitchoverInstanceWithOptionsAsync(SwitchoverInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Forced))
            {
                body["Forced"] = request.Forced;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInstanceId))
            {
                body["TargetInstanceId"] = request.TargetInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchoverInstance",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchoverInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to switch between the primary and standby instances of OceanBase.
         *
         * @param request SwitchoverInstanceRequest
         * @return SwitchoverInstanceResponse
         */
        public SwitchoverInstanceResponse SwitchoverInstance(SwitchoverInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchoverInstanceWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to switch between the primary and standby instances of OceanBase.
         *
         * @param request SwitchoverInstanceRequest
         * @return SwitchoverInstanceResponse
         */
        public async Task<SwitchoverInstanceResponse> SwitchoverInstanceAsync(SwitchoverInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchoverInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新项目配置 Action=UpdateProjectConfig
         *
         * @param tmpReq UpdateProjectConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProjectConfigResponse
         */
        public UpdateProjectConfigResponse UpdateProjectConfigWithOptions(UpdateProjectConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateProjectConfigShrinkRequest request = new UpdateProjectConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CommonTransferConfig))
            {
                request.CommonTransferConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CommonTransferConfig, "CommonTransferConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FullTransferConfig))
            {
                request.FullTransferConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FullTransferConfig, "FullTransferConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IncrTransferConfig))
            {
                request.IncrTransferConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IncrTransferConfig, "IncrTransferConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReverseIncrTransferConfig))
            {
                request.ReverseIncrTransferConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReverseIncrTransferConfig, "ReverseIncrTransferConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommonTransferConfigShrink))
            {
                body["CommonTransferConfig"] = request.CommonTransferConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FullTransferConfigShrink))
            {
                body["FullTransferConfig"] = request.FullTransferConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncrTransferConfigShrink))
            {
                body["IncrTransferConfig"] = request.IncrTransferConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReverseIncrTransferConfigShrink))
            {
                body["ReverseIncrTransferConfig"] = request.ReverseIncrTransferConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProjectConfig",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新项目配置 Action=UpdateProjectConfig
         *
         * @param tmpReq UpdateProjectConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProjectConfigResponse
         */
        public async Task<UpdateProjectConfigResponse> UpdateProjectConfigWithOptionsAsync(UpdateProjectConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateProjectConfigShrinkRequest request = new UpdateProjectConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CommonTransferConfig))
            {
                request.CommonTransferConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CommonTransferConfig, "CommonTransferConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FullTransferConfig))
            {
                request.FullTransferConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FullTransferConfig, "FullTransferConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IncrTransferConfig))
            {
                request.IncrTransferConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IncrTransferConfig, "IncrTransferConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReverseIncrTransferConfig))
            {
                request.ReverseIncrTransferConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReverseIncrTransferConfig, "ReverseIncrTransferConfig", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommonTransferConfigShrink))
            {
                body["CommonTransferConfig"] = request.CommonTransferConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FullTransferConfigShrink))
            {
                body["FullTransferConfig"] = request.FullTransferConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncrTransferConfigShrink))
            {
                body["IncrTransferConfig"] = request.IncrTransferConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReverseIncrTransferConfigShrink))
            {
                body["ReverseIncrTransferConfig"] = request.ReverseIncrTransferConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProjectConfig",
                Version = "2019-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新项目配置 Action=UpdateProjectConfig
         *
         * @param request UpdateProjectConfigRequest
         * @return UpdateProjectConfigResponse
         */
        public UpdateProjectConfigResponse UpdateProjectConfig(UpdateProjectConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProjectConfigWithOptions(request, runtime);
        }

        /**
         * @summary 更新项目配置 Action=UpdateProjectConfig
         *
         * @param request UpdateProjectConfigRequest
         * @return UpdateProjectConfigResponse
         */
        public async Task<UpdateProjectConfigResponse> UpdateProjectConfigAsync(UpdateProjectConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProjectConfigWithOptionsAsync(request, runtime);
        }

    }
}
