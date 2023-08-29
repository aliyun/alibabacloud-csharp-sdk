// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.DataLake20200710.Models;

namespace AlibabaCloud.SDK.DataLake20200710
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "datalake-daily.aliyuncs.com"},
                {"ap-northeast-2-pop", "datalake-daily.aliyuncs.com"},
                {"ap-south-1", "datalake-daily.aliyuncs.com"},
                {"ap-southeast-1", "datalake-daily.aliyuncs.com"},
                {"ap-southeast-2", "datalake-daily.aliyuncs.com"},
                {"ap-southeast-3", "datalake-daily.aliyuncs.com"},
                {"ap-southeast-5", "datalake-daily.aliyuncs.com"},
                {"cn-beijing", "dlf.cn-beijing.aliyuncs.com"},
                {"cn-beijing-finance-1", "datalake-daily.aliyuncs.com"},
                {"cn-beijing-finance-pop", "datalake-daily.aliyuncs.com"},
                {"cn-beijing-gov-1", "datalake-daily.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "datalake-daily.aliyuncs.com"},
                {"cn-chengdu", "datalake-daily.aliyuncs.com"},
                {"cn-edge-1", "datalake-daily.aliyuncs.com"},
                {"cn-fujian", "datalake-daily.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "datalake-daily.aliyuncs.com"},
                {"cn-hangzhou", "dlf.cn-hangzhou.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "datalake-daily.aliyuncs.com"},
                {"cn-hangzhou-finance", "datalake-daily.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "datalake-daily.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "datalake-daily.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "datalake-daily.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "datalake-daily.aliyuncs.com"},
                {"cn-hangzhou-test-306", "datalake-daily.aliyuncs.com"},
                {"cn-hongkong", "datalake-daily.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "datalake-daily.aliyuncs.com"},
                {"cn-huhehaote", "datalake-daily.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "datalake-daily.aliyuncs.com"},
                {"cn-north-2-gov-1", "datalake-daily.aliyuncs.com"},
                {"cn-qingdao", "datalake-daily.aliyuncs.com"},
                {"cn-qingdao-nebula", "datalake-daily.aliyuncs.com"},
                {"cn-shanghai", "dlf.cn-shanghai.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "datalake-daily.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "datalake-daily.aliyuncs.com"},
                {"cn-shanghai-finance-1", "datalake-daily.aliyuncs.com"},
                {"cn-shanghai-inner", "datalake-daily.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "datalake-daily.aliyuncs.com"},
                {"cn-shenzhen", "dlf.cn-shenzhen.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "datalake-daily.aliyuncs.com"},
                {"cn-shenzhen-inner", "datalake-daily.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "datalake-daily.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "datalake-daily.aliyuncs.com"},
                {"cn-wuhan", "datalake-daily.aliyuncs.com"},
                {"cn-wulanchabu", "datalake-daily.aliyuncs.com"},
                {"cn-yushanfang", "datalake-daily.aliyuncs.com"},
                {"cn-zhangbei", "datalake-daily.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "datalake-daily.aliyuncs.com"},
                {"cn-zhangjiakou", "datalake-daily.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "datalake-daily.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "datalake-daily.aliyuncs.com"},
                {"eu-central-1", "datalake-daily.aliyuncs.com"},
                {"eu-west-1", "datalake-daily.aliyuncs.com"},
                {"eu-west-1-oxs", "datalake-daily.aliyuncs.com"},
                {"me-east-1", "datalake-daily.aliyuncs.com"},
                {"rus-west-1-pop", "datalake-daily.aliyuncs.com"},
                {"us-east-1", "datalake-daily.aliyuncs.com"},
                {"us-west-1", "datalake-daily.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("datalake", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AbortLockResponse AbortLockWithOptions(AbortLockRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockId))
            {
                query["LockId"] = request.LockId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortLock",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/locks/abort",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortLockResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AbortLockResponse> AbortLockWithOptionsAsync(AbortLockRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockId))
            {
                query["LockId"] = request.LockId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortLock",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/locks/abort",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortLockResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AbortLockResponse AbortLock(AbortLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AbortLockWithOptions(request, headers, runtime);
        }

        public async Task<AbortLockResponse> AbortLockAsync(AbortLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AbortLockWithOptionsAsync(request, headers, runtime);
        }

        public BatchCreatePartitionsResponse BatchCreatePartitionsWithOptions(BatchCreatePartitionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfNotExists))
            {
                body["IfNotExists"] = request.IfNotExists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedResult))
            {
                body["NeedResult"] = request.NeedResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionInputs))
            {
                body["PartitionInputs"] = request.PartitionInputs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCreatePartitions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/batchcreate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreatePartitionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchCreatePartitionsResponse> BatchCreatePartitionsWithOptionsAsync(BatchCreatePartitionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfNotExists))
            {
                body["IfNotExists"] = request.IfNotExists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedResult))
            {
                body["NeedResult"] = request.NeedResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionInputs))
            {
                body["PartitionInputs"] = request.PartitionInputs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCreatePartitions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/batchcreate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreatePartitionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchCreatePartitionsResponse BatchCreatePartitions(BatchCreatePartitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchCreatePartitionsWithOptions(request, headers, runtime);
        }

        public async Task<BatchCreatePartitionsResponse> BatchCreatePartitionsAsync(BatchCreatePartitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchCreatePartitionsWithOptionsAsync(request, headers, runtime);
        }

        public BatchCreateTablesResponse BatchCreateTablesWithOptions(BatchCreateTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfNotExists))
            {
                body["IfNotExists"] = request.IfNotExists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableInputs))
            {
                body["TableInputs"] = request.TableInputs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCreateTables",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/batchcreate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateTablesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchCreateTablesResponse> BatchCreateTablesWithOptionsAsync(BatchCreateTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfNotExists))
            {
                body["IfNotExists"] = request.IfNotExists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableInputs))
            {
                body["TableInputs"] = request.TableInputs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCreateTables",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/batchcreate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchCreateTablesResponse BatchCreateTables(BatchCreateTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchCreateTablesWithOptions(request, headers, runtime);
        }

        public async Task<BatchCreateTablesResponse> BatchCreateTablesAsync(BatchCreateTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchCreateTablesWithOptionsAsync(request, headers, runtime);
        }

        public BatchDeletePartitionsResponse BatchDeletePartitionsWithOptions(BatchDeletePartitionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfExists))
            {
                body["IfExists"] = request.IfExists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionValueList))
            {
                body["PartitionValueList"] = request.PartitionValueList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeletePartitions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/batchdelete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeletePartitionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchDeletePartitionsResponse> BatchDeletePartitionsWithOptionsAsync(BatchDeletePartitionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfExists))
            {
                body["IfExists"] = request.IfExists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionValueList))
            {
                body["PartitionValueList"] = request.PartitionValueList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeletePartitions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/batchdelete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeletePartitionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchDeletePartitionsResponse BatchDeletePartitions(BatchDeletePartitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchDeletePartitionsWithOptions(request, headers, runtime);
        }

        public async Task<BatchDeletePartitionsResponse> BatchDeletePartitionsAsync(BatchDeletePartitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchDeletePartitionsWithOptionsAsync(request, headers, runtime);
        }

        public BatchDeleteTableVersionsResponse BatchDeleteTableVersionsWithOptions(BatchDeleteTableVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionIds))
            {
                body["VersionIds"] = request.VersionIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteTableVersions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/versions/batchdelete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteTableVersionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchDeleteTableVersionsResponse> BatchDeleteTableVersionsWithOptionsAsync(BatchDeleteTableVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionIds))
            {
                body["VersionIds"] = request.VersionIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteTableVersions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/versions/batchdelete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteTableVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchDeleteTableVersionsResponse BatchDeleteTableVersions(BatchDeleteTableVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchDeleteTableVersionsWithOptions(request, headers, runtime);
        }

        public async Task<BatchDeleteTableVersionsResponse> BatchDeleteTableVersionsAsync(BatchDeleteTableVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchDeleteTableVersionsWithOptionsAsync(request, headers, runtime);
        }

        public BatchDeleteTablesResponse BatchDeleteTablesWithOptions(BatchDeleteTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfExists))
            {
                body["IfExists"] = request.IfExists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNames))
            {
                body["TableNames"] = request.TableNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteTables",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/batchdelete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteTablesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchDeleteTablesResponse> BatchDeleteTablesWithOptionsAsync(BatchDeleteTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfExists))
            {
                body["IfExists"] = request.IfExists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNames))
            {
                body["TableNames"] = request.TableNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteTables",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/batchdelete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchDeleteTablesResponse BatchDeleteTables(BatchDeleteTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchDeleteTablesWithOptions(request, headers, runtime);
        }

        public async Task<BatchDeleteTablesResponse> BatchDeleteTablesAsync(BatchDeleteTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchDeleteTablesWithOptionsAsync(request, headers, runtime);
        }

        public BatchGetPartitionColumnStatisticsResponse BatchGetPartitionColumnStatisticsWithOptions(BatchGetPartitionColumnStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnNames))
            {
                body["ColumnNames"] = request.ColumnNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNames))
            {
                body["PartitionNames"] = request.PartitionNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetPartitionColumnStatistics",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/columnstatistics/batchget",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetPartitionColumnStatisticsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchGetPartitionColumnStatisticsResponse> BatchGetPartitionColumnStatisticsWithOptionsAsync(BatchGetPartitionColumnStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnNames))
            {
                body["ColumnNames"] = request.ColumnNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNames))
            {
                body["PartitionNames"] = request.PartitionNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetPartitionColumnStatistics",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/columnstatistics/batchget",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetPartitionColumnStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchGetPartitionColumnStatisticsResponse BatchGetPartitionColumnStatistics(BatchGetPartitionColumnStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchGetPartitionColumnStatisticsWithOptions(request, headers, runtime);
        }

        public async Task<BatchGetPartitionColumnStatisticsResponse> BatchGetPartitionColumnStatisticsAsync(BatchGetPartitionColumnStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchGetPartitionColumnStatisticsWithOptionsAsync(request, headers, runtime);
        }

        public BatchGetPartitionsResponse BatchGetPartitionsWithOptions(BatchGetPartitionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsShareSd))
            {
                body["IsShareSd"] = request.IsShareSd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionValueList))
            {
                body["PartitionValueList"] = request.PartitionValueList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetPartitions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/batchget",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetPartitionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchGetPartitionsResponse> BatchGetPartitionsWithOptionsAsync(BatchGetPartitionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsShareSd))
            {
                body["IsShareSd"] = request.IsShareSd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionValueList))
            {
                body["PartitionValueList"] = request.PartitionValueList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetPartitions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/batchget",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetPartitionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchGetPartitionsResponse BatchGetPartitions(BatchGetPartitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchGetPartitionsWithOptions(request, headers, runtime);
        }

        public async Task<BatchGetPartitionsResponse> BatchGetPartitionsAsync(BatchGetPartitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchGetPartitionsWithOptionsAsync(request, headers, runtime);
        }

        public BatchGetTablesResponse BatchGetTablesWithOptions(BatchGetTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNames))
            {
                body["TableNames"] = request.TableNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetTables",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/batchget",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetTablesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchGetTablesResponse> BatchGetTablesWithOptionsAsync(BatchGetTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNames))
            {
                body["TableNames"] = request.TableNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetTables",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/batchget",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchGetTablesResponse BatchGetTables(BatchGetTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchGetTablesWithOptions(request, headers, runtime);
        }

        public async Task<BatchGetTablesResponse> BatchGetTablesAsync(BatchGetTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchGetTablesWithOptionsAsync(request, headers, runtime);
        }

        public BatchGrantPermissionsResponse BatchGrantPermissionsWithOptions(BatchGrantPermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantRevokeEntries))
            {
                body["GrantRevokeEntries"] = request.GrantRevokeEntries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGrantPermissions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/permissions/batchgrant",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGrantPermissionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchGrantPermissionsResponse> BatchGrantPermissionsWithOptionsAsync(BatchGrantPermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantRevokeEntries))
            {
                body["GrantRevokeEntries"] = request.GrantRevokeEntries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGrantPermissions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/permissions/batchgrant",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGrantPermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchGrantPermissionsResponse BatchGrantPermissions(BatchGrantPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchGrantPermissionsWithOptions(request, headers, runtime);
        }

        public async Task<BatchGrantPermissionsResponse> BatchGrantPermissionsAsync(BatchGrantPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchGrantPermissionsWithOptionsAsync(request, headers, runtime);
        }

        public BatchRevokePermissionsResponse BatchRevokePermissionsWithOptions(BatchRevokePermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantRevokeEntries))
            {
                body["GrantRevokeEntries"] = request.GrantRevokeEntries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchRevokePermissions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/permissions/batchrevoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRevokePermissionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchRevokePermissionsResponse> BatchRevokePermissionsWithOptionsAsync(BatchRevokePermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantRevokeEntries))
            {
                body["GrantRevokeEntries"] = request.GrantRevokeEntries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchRevokePermissions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/permissions/batchrevoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRevokePermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchRevokePermissionsResponse BatchRevokePermissions(BatchRevokePermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchRevokePermissionsWithOptions(request, headers, runtime);
        }

        public async Task<BatchRevokePermissionsResponse> BatchRevokePermissionsAsync(BatchRevokePermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchRevokePermissionsWithOptionsAsync(request, headers, runtime);
        }

        public BatchUpdatePartitionsResponse BatchUpdatePartitionsWithOptions(BatchUpdatePartitionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionInputs))
            {
                body["PartitionInputs"] = request.PartitionInputs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUpdatePartitions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/batchupdate",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdatePartitionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchUpdatePartitionsResponse> BatchUpdatePartitionsWithOptionsAsync(BatchUpdatePartitionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionInputs))
            {
                body["PartitionInputs"] = request.PartitionInputs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUpdatePartitions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/batchupdate",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdatePartitionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchUpdatePartitionsResponse BatchUpdatePartitions(BatchUpdatePartitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchUpdatePartitionsWithOptions(request, headers, runtime);
        }

        public async Task<BatchUpdatePartitionsResponse> BatchUpdatePartitionsAsync(BatchUpdatePartitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchUpdatePartitionsWithOptionsAsync(request, headers, runtime);
        }

        public BatchUpdateTablesResponse BatchUpdateTablesWithOptions(BatchUpdateTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAsync))
            {
                body["IsAsync"] = request.IsAsync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableInputs))
            {
                body["TableInputs"] = request.TableInputs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUpdateTables",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/batchupdate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateTablesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchUpdateTablesResponse> BatchUpdateTablesWithOptionsAsync(BatchUpdateTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAsync))
            {
                body["IsAsync"] = request.IsAsync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableInputs))
            {
                body["TableInputs"] = request.TableInputs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUpdateTables",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/batchupdate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchUpdateTablesResponse BatchUpdateTables(BatchUpdateTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchUpdateTablesWithOptions(request, headers, runtime);
        }

        public async Task<BatchUpdateTablesResponse> BatchUpdateTablesAsync(BatchUpdateTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchUpdateTablesWithOptionsAsync(request, headers, runtime);
        }

        public CancelQueryResponse CancelQueryWithOptions(CancelQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryId))
            {
                query["QueryId"] = request.QueryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelQuery",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/query/cancelQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelQueryResponse> CancelQueryWithOptionsAsync(CancelQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryId))
            {
                query["QueryId"] = request.QueryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelQuery",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/query/cancelQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelQueryResponse CancelQuery(CancelQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelQueryWithOptions(request, headers, runtime);
        }

        public async Task<CancelQueryResponse> CancelQueryAsync(CancelQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelQueryWithOptionsAsync(request, headers, runtime);
        }

        public CheckPermissionsResponse CheckPermissionsWithOptions(CheckPermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckPermissions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/permissions/check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckPermissionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckPermissionsResponse> CheckPermissionsWithOptionsAsync(CheckPermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckPermissions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/permissions/check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckPermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckPermissionsResponse CheckPermissions(CheckPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CheckPermissionsWithOptions(request, headers, runtime);
        }

        public async Task<CheckPermissionsResponse> CheckPermissionsAsync(CheckPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CheckPermissionsWithOptionsAsync(request, headers, runtime);
        }

        public CreateCatalogResponse CreateCatalogWithOptions(CreateCatalogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogInput))
            {
                body["CatalogInput"] = request.CatalogInput;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCatalog",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCatalogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateCatalogResponse> CreateCatalogWithOptionsAsync(CreateCatalogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogInput))
            {
                body["CatalogInput"] = request.CatalogInput;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCatalog",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCatalogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateCatalogResponse CreateCatalog(CreateCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCatalogWithOptions(request, headers, runtime);
        }

        public async Task<CreateCatalogResponse> CreateCatalogAsync(CreateCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCatalogWithOptionsAsync(request, headers, runtime);
        }

        public CreateDatabaseResponse CreateDatabaseWithOptions(CreateDatabaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInput))
            {
                body["DatabaseInput"] = request.DatabaseInput;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatabase",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatabaseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDatabaseResponse> CreateDatabaseWithOptionsAsync(CreateDatabaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInput))
            {
                body["DatabaseInput"] = request.DatabaseInput;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatabase",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDatabaseResponse CreateDatabase(CreateDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDatabaseWithOptions(request, headers, runtime);
        }

        public async Task<CreateDatabaseResponse> CreateDatabaseAsync(CreateDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDatabaseWithOptionsAsync(request, headers, runtime);
        }

        public CreateFunctionResponse CreateFunctionWithOptions(CreateFunctionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionInput))
            {
                body["FunctionInput"] = request.FunctionInput;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFunction",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/functions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFunctionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFunctionResponse> CreateFunctionWithOptionsAsync(CreateFunctionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionInput))
            {
                body["FunctionInput"] = request.FunctionInput;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFunction",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/functions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFunctionResponse CreateFunction(CreateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFunctionWithOptions(request, headers, runtime);
        }

        public async Task<CreateFunctionResponse> CreateFunctionAsync(CreateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFunctionWithOptionsAsync(request, headers, runtime);
        }

        public CreateLockResponse CreateLockWithOptions(CreateLockRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockObjList))
            {
                body["LockObjList"] = request.LockObjList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLock",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/locks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLockResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateLockResponse> CreateLockWithOptionsAsync(CreateLockRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockObjList))
            {
                body["LockObjList"] = request.LockObjList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLock",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/locks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLockResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateLockResponse CreateLock(CreateLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLockWithOptions(request, headers, runtime);
        }

        public async Task<CreateLockResponse> CreateLockAsync(CreateLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLockWithOptionsAsync(request, headers, runtime);
        }

        public CreatePartitionResponse CreatePartitionWithOptions(CreatePartitionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfNotExists))
            {
                body["IfNotExists"] = request.IfNotExists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedResult))
            {
                body["NeedResult"] = request.NeedResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionInput))
            {
                body["PartitionInput"] = request.PartitionInput;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePartition",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePartitionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreatePartitionResponse> CreatePartitionWithOptionsAsync(CreatePartitionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfNotExists))
            {
                body["IfNotExists"] = request.IfNotExists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedResult))
            {
                body["NeedResult"] = request.NeedResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionInput))
            {
                body["PartitionInput"] = request.PartitionInput;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePartition",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePartitionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreatePartitionResponse CreatePartition(CreatePartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePartitionWithOptions(request, headers, runtime);
        }

        public async Task<CreatePartitionResponse> CreatePartitionAsync(CreatePartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePartitionWithOptionsAsync(request, headers, runtime);
        }

        public CreateRoleResponse CreateRoleWithOptions(CreateRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRole",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/roles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRoleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateRoleResponse> CreateRoleWithOptionsAsync(CreateRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRole",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/roles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateRoleResponse CreateRole(CreateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRoleWithOptions(request, headers, runtime);
        }

        public async Task<CreateRoleResponse> CreateRoleAsync(CreateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRoleWithOptionsAsync(request, headers, runtime);
        }

        public CreateTableResponse CreateTableWithOptions(CreateTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableInput))
            {
                body["TableInput"] = request.TableInput;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTable",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTableResponse> CreateTableWithOptionsAsync(CreateTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableInput))
            {
                body["TableInput"] = request.TableInput;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTable",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTableResponse CreateTable(CreateTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTableWithOptions(request, headers, runtime);
        }

        public async Task<CreateTableResponse> CreateTableAsync(CreateTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTableWithOptionsAsync(request, headers, runtime);
        }

        public DeleteCatalogResponse DeleteCatalogWithOptions(DeleteCatalogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAsync))
            {
                query["IsAsync"] = request.IsAsync;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCatalog",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCatalogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteCatalogResponse> DeleteCatalogWithOptionsAsync(DeleteCatalogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAsync))
            {
                query["IsAsync"] = request.IsAsync;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCatalog",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCatalogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteCatalogResponse DeleteCatalog(DeleteCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteCatalogWithOptions(request, headers, runtime);
        }

        public async Task<DeleteCatalogResponse> DeleteCatalogAsync(DeleteCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteCatalogWithOptionsAsync(request, headers, runtime);
        }

        public DeleteDatabaseResponse DeleteDatabaseWithOptions(DeleteDatabaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Async))
            {
                query["Async"] = request.Async;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cascade))
            {
                query["Cascade"] = request.Cascade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatabase",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatabaseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDatabaseResponse> DeleteDatabaseWithOptionsAsync(DeleteDatabaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Async))
            {
                query["Async"] = request.Async;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cascade))
            {
                query["Cascade"] = request.Cascade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDatabase",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDatabaseResponse DeleteDatabase(DeleteDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDatabaseWithOptions(request, headers, runtime);
        }

        public async Task<DeleteDatabaseResponse> DeleteDatabaseAsync(DeleteDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDatabaseWithOptionsAsync(request, headers, runtime);
        }

        public DeleteFunctionResponse DeleteFunctionWithOptions(DeleteFunctionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["FunctionName"] = request.FunctionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFunction",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/functions",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFunctionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFunctionResponse> DeleteFunctionWithOptionsAsync(DeleteFunctionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["FunctionName"] = request.FunctionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFunction",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/functions",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFunctionResponse DeleteFunction(DeleteFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFunctionWithOptions(request, headers, runtime);
        }

        public async Task<DeleteFunctionResponse> DeleteFunctionAsync(DeleteFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFunctionWithOptionsAsync(request, headers, runtime);
        }

        public DeletePartitionResponse DeletePartitionWithOptions(DeletePartitionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfExists))
            {
                body["IfExists"] = request.IfExists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionValues))
            {
                body["PartitionValues"] = request.PartitionValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePartition",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePartitionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeletePartitionResponse> DeletePartitionWithOptionsAsync(DeletePartitionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IfExists))
            {
                body["IfExists"] = request.IfExists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionValues))
            {
                body["PartitionValues"] = request.PartitionValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePartition",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePartitionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeletePartitionResponse DeletePartition(DeletePartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePartitionWithOptions(request, headers, runtime);
        }

        public async Task<DeletePartitionResponse> DeletePartitionAsync(DeletePartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePartitionWithOptionsAsync(request, headers, runtime);
        }

        public DeletePartitionColumnStatisticsResponse DeletePartitionColumnStatisticsWithOptions(DeletePartitionColumnStatisticsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeletePartitionColumnStatisticsShrinkRequest request = new DeletePartitionColumnStatisticsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ColumnNames))
            {
                request.ColumnNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ColumnNames, "ColumnNames", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PartitionNames))
            {
                request.PartitionNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PartitionNames, "PartitionNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnNamesShrink))
            {
                query["ColumnNames"] = request.ColumnNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNamesShrink))
            {
                query["PartitionNames"] = request.PartitionNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePartitionColumnStatistics",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/columnstatistics",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePartitionColumnStatisticsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeletePartitionColumnStatisticsResponse> DeletePartitionColumnStatisticsWithOptionsAsync(DeletePartitionColumnStatisticsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeletePartitionColumnStatisticsShrinkRequest request = new DeletePartitionColumnStatisticsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ColumnNames))
            {
                request.ColumnNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ColumnNames, "ColumnNames", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PartitionNames))
            {
                request.PartitionNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PartitionNames, "PartitionNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnNamesShrink))
            {
                query["ColumnNames"] = request.ColumnNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNamesShrink))
            {
                query["PartitionNames"] = request.PartitionNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePartitionColumnStatistics",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/columnstatistics",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePartitionColumnStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeletePartitionColumnStatisticsResponse DeletePartitionColumnStatistics(DeletePartitionColumnStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePartitionColumnStatisticsWithOptions(request, headers, runtime);
        }

        public async Task<DeletePartitionColumnStatisticsResponse> DeletePartitionColumnStatisticsAsync(DeletePartitionColumnStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePartitionColumnStatisticsWithOptionsAsync(request, headers, runtime);
        }

        public DeleteRoleResponse DeleteRoleWithOptions(DeleteRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRole",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/roles",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRoleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteRoleResponse> DeleteRoleWithOptionsAsync(DeleteRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRole",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/roles",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteRoleResponse DeleteRole(DeleteRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRoleWithOptions(request, headers, runtime);
        }

        public async Task<DeleteRoleResponse> DeleteRoleAsync(DeleteRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRoleWithOptionsAsync(request, headers, runtime);
        }

        public DeleteTableResponse DeleteTableWithOptions(DeleteTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTable",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTableResponse> DeleteTableWithOptionsAsync(DeleteTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTable",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTableResponse DeleteTable(DeleteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTableWithOptions(request, headers, runtime);
        }

        public async Task<DeleteTableResponse> DeleteTableAsync(DeleteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTableWithOptionsAsync(request, headers, runtime);
        }

        public DeleteTableColumnStatisticsResponse DeleteTableColumnStatisticsWithOptions(DeleteTableColumnStatisticsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteTableColumnStatisticsShrinkRequest request = new DeleteTableColumnStatisticsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ColumnNames))
            {
                request.ColumnNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ColumnNames, "ColumnNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnNamesShrink))
            {
                query["ColumnNames"] = request.ColumnNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTableColumnStatistics",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/columnstatistics",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTableColumnStatisticsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTableColumnStatisticsResponse> DeleteTableColumnStatisticsWithOptionsAsync(DeleteTableColumnStatisticsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteTableColumnStatisticsShrinkRequest request = new DeleteTableColumnStatisticsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ColumnNames))
            {
                request.ColumnNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ColumnNames, "ColumnNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnNamesShrink))
            {
                query["ColumnNames"] = request.ColumnNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTableColumnStatistics",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/columnstatistics",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTableColumnStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTableColumnStatisticsResponse DeleteTableColumnStatistics(DeleteTableColumnStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTableColumnStatisticsWithOptions(request, headers, runtime);
        }

        public async Task<DeleteTableColumnStatisticsResponse> DeleteTableColumnStatisticsAsync(DeleteTableColumnStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTableColumnStatisticsWithOptionsAsync(request, headers, runtime);
        }

        public DeleteTableVersionResponse DeleteTableVersionWithOptions(DeleteTableVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTableVersion",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/versions",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTableVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTableVersionResponse> DeleteTableVersionWithOptionsAsync(DeleteTableVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTableVersion",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/versions",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTableVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTableVersionResponse DeleteTableVersion(DeleteTableVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTableVersionWithOptions(request, headers, runtime);
        }

        public async Task<DeleteTableVersionResponse> DeleteTableVersionAsync(DeleteTableVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTableVersionWithOptionsAsync(request, headers, runtime);
        }

        public DeregisterLocationResponse DeregisterLocationWithOptions(DeregisterLocationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationId))
            {
                query["LocationId"] = request.LocationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeregisterLocation",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/locations",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeregisterLocationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeregisterLocationResponse> DeregisterLocationWithOptionsAsync(DeregisterLocationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationId))
            {
                query["LocationId"] = request.LocationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeregisterLocation",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/locations",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeregisterLocationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeregisterLocationResponse DeregisterLocation(DeregisterLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeregisterLocationWithOptions(request, headers, runtime);
        }

        public async Task<DeregisterLocationResponse> DeregisterLocationAsync(DeregisterLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeregisterLocationWithOptionsAsync(request, headers, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/service/describeRegions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/service/describeRegions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRegionsWithOptions(headers, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRegionsWithOptionsAsync(headers, runtime);
        }

        public GetAsyncTaskStatusResponse GetAsyncTaskStatusWithOptions(GetAsyncTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncTaskStatus",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncTaskStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAsyncTaskStatusResponse> GetAsyncTaskStatusWithOptionsAsync(GetAsyncTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncTaskStatus",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncTaskStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAsyncTaskStatusResponse GetAsyncTaskStatus(GetAsyncTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAsyncTaskStatusWithOptions(request, headers, runtime);
        }

        public async Task<GetAsyncTaskStatusResponse> GetAsyncTaskStatusAsync(GetAsyncTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAsyncTaskStatusWithOptionsAsync(request, headers, runtime);
        }

        public GetCatalogResponse GetCatalogWithOptions(GetCatalogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCatalog",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCatalogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCatalogResponse> GetCatalogWithOptionsAsync(GetCatalogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCatalog",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCatalogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetCatalogResponse GetCatalog(GetCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCatalogWithOptions(request, headers, runtime);
        }

        public async Task<GetCatalogResponse> GetCatalogAsync(GetCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCatalogWithOptionsAsync(request, headers, runtime);
        }

        public GetCatalogSettingsResponse GetCatalogSettingsWithOptions(GetCatalogSettingsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCatalogSettings",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/settings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCatalogSettingsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCatalogSettingsResponse> GetCatalogSettingsWithOptionsAsync(GetCatalogSettingsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCatalogSettings",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/settings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCatalogSettingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetCatalogSettingsResponse GetCatalogSettings(GetCatalogSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCatalogSettingsWithOptions(request, headers, runtime);
        }

        public async Task<GetCatalogSettingsResponse> GetCatalogSettingsAsync(GetCatalogSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCatalogSettingsWithOptionsAsync(request, headers, runtime);
        }

        public GetDatabaseResponse GetDatabaseWithOptions(GetDatabaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatabase",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatabaseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDatabaseResponse> GetDatabaseWithOptionsAsync(GetDatabaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatabase",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDatabaseResponse GetDatabase(GetDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDatabaseWithOptions(request, headers, runtime);
        }

        public async Task<GetDatabaseResponse> GetDatabaseAsync(GetDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDatabaseWithOptionsAsync(request, headers, runtime);
        }

        public GetFunctionResponse GetFunctionWithOptions(GetFunctionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["FunctionName"] = request.FunctionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunction",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/functions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFunctionResponse> GetFunctionWithOptionsAsync(GetFunctionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["FunctionName"] = request.FunctionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunction",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/functions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetFunctionResponse GetFunction(GetFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFunctionWithOptions(request, headers, runtime);
        }

        public async Task<GetFunctionResponse> GetFunctionAsync(GetFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFunctionWithOptionsAsync(request, headers, runtime);
        }

        public GetLifecycleRuleResponse GetLifecycleRuleWithOptions(GetLifecycleRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLifecycleRule",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/metastorehouse/lifecycle/rule/getLifecycleRule",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLifecycleRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetLifecycleRuleResponse> GetLifecycleRuleWithOptionsAsync(GetLifecycleRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLifecycleRule",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/metastorehouse/lifecycle/rule/getLifecycleRule",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLifecycleRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetLifecycleRuleResponse GetLifecycleRule(GetLifecycleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLifecycleRuleWithOptions(request, headers, runtime);
        }

        public async Task<GetLifecycleRuleResponse> GetLifecycleRuleAsync(GetLifecycleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLifecycleRuleWithOptionsAsync(request, headers, runtime);
        }

        public GetLockResponse GetLockWithOptions(GetLockRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockId))
            {
                query["LockId"] = request.LockId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLock",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/locks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLockResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetLockResponse> GetLockWithOptionsAsync(GetLockRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockId))
            {
                query["LockId"] = request.LockId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLock",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/locks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLockResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetLockResponse GetLock(GetLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLockWithOptions(request, headers, runtime);
        }

        public async Task<GetLockResponse> GetLockAsync(GetLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLockWithOptionsAsync(request, headers, runtime);
        }

        public GetPartitionResponse GetPartitionWithOptions(GetPartitionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionValues))
            {
                body["PartitionValues"] = request.PartitionValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPartition",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPartitionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPartitionResponse> GetPartitionWithOptionsAsync(GetPartitionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionValues))
            {
                body["PartitionValues"] = request.PartitionValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPartition",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/get",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPartitionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetPartitionResponse GetPartition(GetPartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPartitionWithOptions(request, headers, runtime);
        }

        public async Task<GetPartitionResponse> GetPartitionAsync(GetPartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPartitionWithOptionsAsync(request, headers, runtime);
        }

        public GetPartitionColumnStatisticsResponse GetPartitionColumnStatisticsWithOptions(GetPartitionColumnStatisticsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetPartitionColumnStatisticsShrinkRequest request = new GetPartitionColumnStatisticsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ColumnNames))
            {
                request.ColumnNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ColumnNames, "ColumnNames", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PartitionNames))
            {
                request.PartitionNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PartitionNames, "PartitionNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnNamesShrink))
            {
                query["ColumnNames"] = request.ColumnNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNamesShrink))
            {
                query["PartitionNames"] = request.PartitionNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPartitionColumnStatistics",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/columnstatistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPartitionColumnStatisticsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPartitionColumnStatisticsResponse> GetPartitionColumnStatisticsWithOptionsAsync(GetPartitionColumnStatisticsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetPartitionColumnStatisticsShrinkRequest request = new GetPartitionColumnStatisticsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ColumnNames))
            {
                request.ColumnNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ColumnNames, "ColumnNames", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PartitionNames))
            {
                request.PartitionNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PartitionNames, "PartitionNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnNamesShrink))
            {
                query["ColumnNames"] = request.ColumnNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNamesShrink))
            {
                query["PartitionNames"] = request.PartitionNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPartitionColumnStatistics",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/columnstatistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPartitionColumnStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetPartitionColumnStatisticsResponse GetPartitionColumnStatistics(GetPartitionColumnStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPartitionColumnStatisticsWithOptions(request, headers, runtime);
        }

        public async Task<GetPartitionColumnStatisticsResponse> GetPartitionColumnStatisticsAsync(GetPartitionColumnStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPartitionColumnStatisticsWithOptionsAsync(request, headers, runtime);
        }

        public GetQueryResultResponse GetQueryResultWithOptions(GetQueryResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryId))
            {
                query["QueryId"] = request.QueryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryResult",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/query/getQueryResult",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryResultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetQueryResultResponse> GetQueryResultWithOptionsAsync(GetQueryResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryId))
            {
                query["QueryId"] = request.QueryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueryResult",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/query/getQueryResult",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueryResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetQueryResultResponse GetQueryResult(GetQueryResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetQueryResultWithOptions(request, headers, runtime);
        }

        public async Task<GetQueryResultResponse> GetQueryResultAsync(GetQueryResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetQueryResultWithOptionsAsync(request, headers, runtime);
        }

        public GetRegionStatusResponse GetRegionStatusWithOptions(GetRegionStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRegionStatus",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/service/getRegionStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRegionStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRegionStatusResponse> GetRegionStatusWithOptionsAsync(GetRegionStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRegionStatus",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/service/getRegionStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRegionStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRegionStatusResponse GetRegionStatus(GetRegionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRegionStatusWithOptions(request, headers, runtime);
        }

        public async Task<GetRegionStatusResponse> GetRegionStatusAsync(GetRegionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRegionStatusWithOptionsAsync(request, headers, runtime);
        }

        public GetRoleResponse GetRoleWithOptions(GetRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRole",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRoleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRoleResponse> GetRoleWithOptionsAsync(GetRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRole",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRoleResponse GetRole(GetRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRoleWithOptions(request, headers, runtime);
        }

        public async Task<GetRoleResponse> GetRoleAsync(GetRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRoleWithOptionsAsync(request, headers, runtime);
        }

        public GetServiceStatusResponse GetServiceStatusWithOptions(GetServiceStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceStatus",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/service/getServiceStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetServiceStatusResponse> GetServiceStatusWithOptionsAsync(GetServiceStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceStatus",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/service/getServiceStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceStatusWithOptions(request, headers, runtime);
        }

        public async Task<GetServiceStatusResponse> GetServiceStatusAsync(GetServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceStatusWithOptionsAsync(request, headers, runtime);
        }

        public GetTableResponse GetTableWithOptions(GetTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTable",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetTableResponse> GetTableWithOptionsAsync(GetTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTable",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetTableResponse GetTable(GetTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTableWithOptions(request, headers, runtime);
        }

        public async Task<GetTableResponse> GetTableAsync(GetTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTableWithOptionsAsync(request, headers, runtime);
        }

        public GetTableColumnStatisticsResponse GetTableColumnStatisticsWithOptions(GetTableColumnStatisticsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetTableColumnStatisticsShrinkRequest request = new GetTableColumnStatisticsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ColumnNames))
            {
                request.ColumnNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ColumnNames, "ColumnNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnNamesShrink))
            {
                query["ColumnNames"] = request.ColumnNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableColumnStatistics",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/columnstatistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableColumnStatisticsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetTableColumnStatisticsResponse> GetTableColumnStatisticsWithOptionsAsync(GetTableColumnStatisticsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetTableColumnStatisticsShrinkRequest request = new GetTableColumnStatisticsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ColumnNames))
            {
                request.ColumnNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ColumnNames, "ColumnNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnNamesShrink))
            {
                query["ColumnNames"] = request.ColumnNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableColumnStatistics",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/columnstatistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableColumnStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetTableColumnStatisticsResponse GetTableColumnStatistics(GetTableColumnStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTableColumnStatisticsWithOptions(request, headers, runtime);
        }

        public async Task<GetTableColumnStatisticsResponse> GetTableColumnStatisticsAsync(GetTableColumnStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTableColumnStatisticsWithOptionsAsync(request, headers, runtime);
        }

        public GetTableProfileResponse GetTableProfileWithOptions(GetTableProfileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableProfile",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/metastorehouse/catalog/database/tableprofile",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableProfileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetTableProfileResponse> GetTableProfileWithOptionsAsync(GetTableProfileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableProfile",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/metastorehouse/catalog/database/tableprofile",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetTableProfileResponse GetTableProfile(GetTableProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTableProfileWithOptions(request, headers, runtime);
        }

        public async Task<GetTableProfileResponse> GetTableProfileAsync(GetTableProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTableProfileWithOptionsAsync(request, headers, runtime);
        }

        public GetTableVersionResponse GetTableVersionWithOptions(GetTableVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableVersion",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetTableVersionResponse> GetTableVersionWithOptionsAsync(GetTableVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableVersion",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetTableVersionResponse GetTableVersion(GetTableVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTableVersionWithOptions(request, headers, runtime);
        }

        public async Task<GetTableVersionResponse> GetTableVersionAsync(GetTableVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTableVersionWithOptionsAsync(request, headers, runtime);
        }

        public GrantPermissionsResponse GrantPermissionsWithOptions(GrantPermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accesses))
            {
                body["Accesses"] = request.Accesses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelegateAccesses))
            {
                body["DelegateAccesses"] = request.DelegateAccesses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaResource))
            {
                body["MetaResource"] = request.MetaResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Principal))
            {
                body["Principal"] = request.Principal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantPermissions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/permissions/grant",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantPermissionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GrantPermissionsResponse> GrantPermissionsWithOptionsAsync(GrantPermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accesses))
            {
                body["Accesses"] = request.Accesses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelegateAccesses))
            {
                body["DelegateAccesses"] = request.DelegateAccesses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaResource))
            {
                body["MetaResource"] = request.MetaResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Principal))
            {
                body["Principal"] = request.Principal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantPermissions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/permissions/grant",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantPermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GrantPermissionsResponse GrantPermissions(GrantPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GrantPermissionsWithOptions(request, headers, runtime);
        }

        public async Task<GrantPermissionsResponse> GrantPermissionsAsync(GrantPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GrantPermissionsWithOptionsAsync(request, headers, runtime);
        }

        public GrantRoleToUsersResponse GrantRoleToUsersWithOptions(GrantRoleToUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantRoleToUsers",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/roles/grantusers",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantRoleToUsersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GrantRoleToUsersResponse> GrantRoleToUsersWithOptionsAsync(GrantRoleToUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantRoleToUsers",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/roles/grantusers",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantRoleToUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GrantRoleToUsersResponse GrantRoleToUsers(GrantRoleToUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GrantRoleToUsersWithOptions(request, headers, runtime);
        }

        public async Task<GrantRoleToUsersResponse> GrantRoleToUsersAsync(GrantRoleToUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GrantRoleToUsersWithOptionsAsync(request, headers, runtime);
        }

        public GrantRolesToUserResponse GrantRolesToUserWithOptions(GrantRolesToUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleNames))
            {
                body["RoleNames"] = request.RoleNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.User))
            {
                body["User"] = request.User;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantRolesToUser",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/roles/grantroles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantRolesToUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GrantRolesToUserResponse> GrantRolesToUserWithOptionsAsync(GrantRolesToUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleNames))
            {
                body["RoleNames"] = request.RoleNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.User))
            {
                body["User"] = request.User;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantRolesToUser",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/roles/grantroles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantRolesToUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GrantRolesToUserResponse GrantRolesToUser(GrantRolesToUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GrantRolesToUserWithOptions(request, headers, runtime);
        }

        public async Task<GrantRolesToUserResponse> GrantRolesToUserAsync(GrantRolesToUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GrantRolesToUserWithOptionsAsync(request, headers, runtime);
        }

        public ListCatalogsResponse ListCatalogsWithOptions(ListCatalogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdPattern))
            {
                query["IdPattern"] = request.IdPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCatalogs",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCatalogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListCatalogsResponse> ListCatalogsWithOptionsAsync(ListCatalogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdPattern))
            {
                query["IdPattern"] = request.IdPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCatalogs",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCatalogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListCatalogsResponse ListCatalogs(ListCatalogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCatalogsWithOptions(request, headers, runtime);
        }

        public async Task<ListCatalogsResponse> ListCatalogsAsync(ListCatalogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCatalogsWithOptionsAsync(request, headers, runtime);
        }

        public ListDatabasesResponse ListDatabasesWithOptions(ListDatabasesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamePattern))
            {
                query["NamePattern"] = request.NamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatabases",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatabasesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDatabasesResponse> ListDatabasesWithOptionsAsync(ListDatabasesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamePattern))
            {
                query["NamePattern"] = request.NamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatabases",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatabasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDatabasesResponse ListDatabases(ListDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDatabasesWithOptions(request, headers, runtime);
        }

        public async Task<ListDatabasesResponse> ListDatabasesAsync(ListDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDatabasesWithOptionsAsync(request, headers, runtime);
        }

        public ListFunctionNamesResponse ListFunctionNamesWithOptions(ListFunctionNamesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionNamePattern))
            {
                query["FunctionNamePattern"] = request.FunctionNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctionNames",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/functions/names",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionNamesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFunctionNamesResponse> ListFunctionNamesWithOptionsAsync(ListFunctionNamesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionNamePattern))
            {
                query["FunctionNamePattern"] = request.FunctionNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctionNames",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/functions/names",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionNamesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFunctionNamesResponse ListFunctionNames(ListFunctionNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFunctionNamesWithOptions(request, headers, runtime);
        }

        public async Task<ListFunctionNamesResponse> ListFunctionNamesAsync(ListFunctionNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFunctionNamesWithOptionsAsync(request, headers, runtime);
        }

        public ListFunctionsResponse ListFunctionsWithOptions(ListFunctionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionNamePattern))
            {
                query["FunctionNamePattern"] = request.FunctionNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/functions/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFunctionsResponse> ListFunctionsWithOptionsAsync(ListFunctionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionNamePattern))
            {
                query["FunctionNamePattern"] = request.FunctionNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/functions/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFunctionsResponse ListFunctions(ListFunctionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFunctionsWithOptions(request, headers, runtime);
        }

        public async Task<ListFunctionsResponse> ListFunctionsAsync(ListFunctionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFunctionsWithOptionsAsync(request, headers, runtime);
        }

        public ListPartitionNamesResponse ListPartitionNamesWithOptions(ListPartitionNamesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                body["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartialPartValues))
            {
                body["PartialPartValues"] = request.PartialPartValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPartitionNames",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/names",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPartitionNamesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPartitionNamesResponse> ListPartitionNamesWithOptionsAsync(ListPartitionNamesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                body["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartialPartValues))
            {
                body["PartialPartValues"] = request.PartialPartValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPartitionNames",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/names",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPartitionNamesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListPartitionNamesResponse ListPartitionNames(ListPartitionNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPartitionNamesWithOptions(request, headers, runtime);
        }

        public async Task<ListPartitionNamesResponse> ListPartitionNamesAsync(ListPartitionNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPartitionNamesWithOptionsAsync(request, headers, runtime);
        }

        public ListPartitionsResponse ListPartitionsWithOptions(ListPartitionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsShareSd))
            {
                body["IsShareSd"] = request.IsShareSd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                body["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartialPartValues))
            {
                body["PartialPartValues"] = request.PartialPartValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPartitions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPartitionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPartitionsResponse> ListPartitionsWithOptionsAsync(ListPartitionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsShareSd))
            {
                body["IsShareSd"] = request.IsShareSd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                body["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartialPartValues))
            {
                body["PartialPartValues"] = request.PartialPartValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPartitions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPartitionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListPartitionsResponse ListPartitions(ListPartitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPartitionsWithOptions(request, headers, runtime);
        }

        public async Task<ListPartitionsResponse> ListPartitionsAsync(ListPartitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPartitionsWithOptionsAsync(request, headers, runtime);
        }

        public ListPartitionsByExprResponse ListPartitionsByExprWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPartitionsByExpr",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/listbyexpr",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ListPartitionsByExprResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPartitionsByExprResponse> ListPartitionsByExprWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPartitionsByExpr",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/listbyexpr",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ListPartitionsByExprResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListPartitionsByExprResponse ListPartitionsByExpr()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPartitionsByExprWithOptions(headers, runtime);
        }

        public async Task<ListPartitionsByExprResponse> ListPartitionsByExprAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPartitionsByExprWithOptionsAsync(headers, runtime);
        }

        public ListPartitionsByFilterResponse ListPartitionsByFilterWithOptions(ListPartitionsByFilterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                body["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsShareSd))
            {
                body["IsShareSd"] = request.IsShareSd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                body["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPartitionsByFilter",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/listbyfilter",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPartitionsByFilterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPartitionsByFilterResponse> ListPartitionsByFilterWithOptionsAsync(ListPartitionsByFilterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                body["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsShareSd))
            {
                body["IsShareSd"] = request.IsShareSd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                body["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPartitionsByFilter",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/listbyfilter",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPartitionsByFilterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListPartitionsByFilterResponse ListPartitionsByFilter(ListPartitionsByFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPartitionsByFilterWithOptions(request, headers, runtime);
        }

        public async Task<ListPartitionsByFilterResponse> ListPartitionsByFilterAsync(ListPartitionsByFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPartitionsByFilterWithOptionsAsync(request, headers, runtime);
        }

        public ListPermissionsResponse ListPermissionsWithOptions(ListPermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsListUserRolePermissions))
            {
                body["IsListUserRolePermissions"] = request.IsListUserRolePermissions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaResource))
            {
                body["MetaResource"] = request.MetaResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaResourceType))
            {
                body["MetaResourceType"] = request.MetaResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                body["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Principal))
            {
                body["Principal"] = request.Principal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPermissions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/permissions/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPermissionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPermissionsResponse> ListPermissionsWithOptionsAsync(ListPermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsListUserRolePermissions))
            {
                body["IsListUserRolePermissions"] = request.IsListUserRolePermissions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaResource))
            {
                body["MetaResource"] = request.MetaResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaResourceType))
            {
                body["MetaResourceType"] = request.MetaResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                body["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Principal))
            {
                body["Principal"] = request.Principal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPermissions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/permissions/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListPermissionsResponse ListPermissions(ListPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPermissionsWithOptions(request, headers, runtime);
        }

        public async Task<ListPermissionsResponse> ListPermissionsAsync(ListPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPermissionsWithOptionsAsync(request, headers, runtime);
        }

        public ListRoleUsersResponse ListRoleUsersWithOptions(ListRoleUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserNamePattern))
            {
                query["UserNamePattern"] = request.UserNamePattern;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoleUsers",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/roles/roleusers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRoleUsersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRoleUsersResponse> ListRoleUsersWithOptionsAsync(ListRoleUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserNamePattern))
            {
                query["UserNamePattern"] = request.UserNamePattern;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoleUsers",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/roles/roleusers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRoleUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRoleUsersResponse ListRoleUsers(ListRoleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRoleUsersWithOptions(request, headers, runtime);
        }

        public async Task<ListRoleUsersResponse> ListRoleUsersAsync(ListRoleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRoleUsersWithOptionsAsync(request, headers, runtime);
        }

        public ListRolesResponse ListRolesWithOptions(ListRolesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleNamePattern))
            {
                query["RoleNamePattern"] = request.RoleNamePattern;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoles",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/roles/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRolesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRolesResponse> ListRolesWithOptionsAsync(ListRolesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleNamePattern))
            {
                query["RoleNamePattern"] = request.RoleNamePattern;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoles",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/roles/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRolesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRolesResponse ListRoles(ListRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRolesWithOptions(request, headers, runtime);
        }

        public async Task<ListRolesResponse> ListRolesAsync(ListRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRolesWithOptionsAsync(request, headers, runtime);
        }

        public ListTableNamesResponse ListTableNamesWithOptions(ListTableNamesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNamePattern))
            {
                query["TableNamePattern"] = request.TableNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableType))
            {
                query["TableType"] = request.TableType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTableNames",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/names",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTableNamesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTableNamesResponse> ListTableNamesWithOptionsAsync(ListTableNamesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNamePattern))
            {
                query["TableNamePattern"] = request.TableNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableType))
            {
                query["TableType"] = request.TableType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTableNames",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/names",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTableNamesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTableNamesResponse ListTableNames(ListTableNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTableNamesWithOptions(request, headers, runtime);
        }

        public async Task<ListTableNamesResponse> ListTableNamesAsync(ListTableNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTableNamesWithOptionsAsync(request, headers, runtime);
        }

        public ListTableVersionsResponse ListTableVersionsWithOptions(ListTableVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTableVersions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/versions/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTableVersionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTableVersionsResponse> ListTableVersionsWithOptionsAsync(ListTableVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTableVersions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/versions/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTableVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTableVersionsResponse ListTableVersions(ListTableVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTableVersionsWithOptions(request, headers, runtime);
        }

        public async Task<ListTableVersionsResponse> ListTableVersionsAsync(ListTableVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTableVersionsWithOptionsAsync(request, headers, runtime);
        }

        public ListTablesResponse ListTablesWithOptions(ListTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNamePattern))
            {
                query["TableNamePattern"] = request.TableNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableType))
            {
                query["TableType"] = request.TableType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTables",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/databases/tables/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTablesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTablesResponse> ListTablesWithOptionsAsync(ListTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                query["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNamePattern))
            {
                query["TableNamePattern"] = request.TableNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableType))
            {
                query["TableType"] = request.TableType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTables",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/databases/tables/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTablesResponse ListTables(ListTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTablesWithOptions(request, headers, runtime);
        }

        public async Task<ListTablesResponse> ListTablesAsync(ListTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTablesWithOptionsAsync(request, headers, runtime);
        }

        public ListUserRolesResponse ListUserRolesWithOptions(ListUserRolesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalArn))
            {
                query["PrincipalArn"] = request.PrincipalArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleNamePattern))
            {
                query["RoleNamePattern"] = request.RoleNamePattern;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserRoles",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/roles/userroles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserRolesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListUserRolesResponse> ListUserRolesWithOptionsAsync(ListUserRolesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalArn))
            {
                query["PrincipalArn"] = request.PrincipalArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleNamePattern))
            {
                query["RoleNamePattern"] = request.RoleNamePattern;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserRoles",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/roles/userroles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserRolesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListUserRolesResponse ListUserRoles(ListUserRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUserRolesWithOptions(request, headers, runtime);
        }

        public async Task<ListUserRolesResponse> ListUserRolesAsync(ListUserRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUserRolesWithOptionsAsync(request, headers, runtime);
        }

        public RefreshLockResponse RefreshLockWithOptions(RefreshLockRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockId))
            {
                query["LockId"] = request.LockId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshLock",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/locks",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshLockResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RefreshLockResponse> RefreshLockWithOptionsAsync(RefreshLockRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockId))
            {
                query["LockId"] = request.LockId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshLock",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/locks",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshLockResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RefreshLockResponse RefreshLock(RefreshLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RefreshLockWithOptions(request, headers, runtime);
        }

        public async Task<RefreshLockResponse> RefreshLockAsync(RefreshLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RefreshLockWithOptionsAsync(request, headers, runtime);
        }

        public RegisterLocationResponse RegisterLocationWithOptions(RegisterLocationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InventoryCollectEnabled))
            {
                body["InventoryCollectEnabled"] = request.InventoryCollectEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssLogCollectEnabled))
            {
                body["OssLogCollectEnabled"] = request.OssLogCollectEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterLocation",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/locations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterLocationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RegisterLocationResponse> RegisterLocationWithOptionsAsync(RegisterLocationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InventoryCollectEnabled))
            {
                body["InventoryCollectEnabled"] = request.InventoryCollectEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["Location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssLogCollectEnabled))
            {
                body["OssLogCollectEnabled"] = request.OssLogCollectEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterLocation",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/locations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterLocationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RegisterLocationResponse RegisterLocation(RegisterLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RegisterLocationWithOptions(request, headers, runtime);
        }

        public async Task<RegisterLocationResponse> RegisterLocationAsync(RegisterLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RegisterLocationWithOptionsAsync(request, headers, runtime);
        }

        public RenamePartitionResponse RenamePartitionWithOptions(RenamePartitionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionInput))
            {
                body["PartitionInput"] = request.PartitionInput;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionValues))
            {
                body["PartitionValues"] = request.PartitionValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenamePartition",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/rename",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenamePartitionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RenamePartitionResponse> RenamePartitionWithOptionsAsync(RenamePartitionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionInput))
            {
                body["PartitionInput"] = request.PartitionInput;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionValues))
            {
                body["PartitionValues"] = request.PartitionValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenamePartition",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/rename",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenamePartitionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RenamePartitionResponse RenamePartition(RenamePartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RenamePartitionWithOptions(request, headers, runtime);
        }

        public async Task<RenamePartitionResponse> RenamePartitionAsync(RenamePartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RenamePartitionWithOptionsAsync(request, headers, runtime);
        }

        public RenameTableResponse RenameTableWithOptions(RenameTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAsync))
            {
                body["IsAsync"] = request.IsAsync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableInput))
            {
                body["TableInput"] = request.TableInput;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenameTable",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/rename",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenameTableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RenameTableResponse> RenameTableWithOptionsAsync(RenameTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAsync))
            {
                body["IsAsync"] = request.IsAsync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableInput))
            {
                body["TableInput"] = request.TableInput;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenameTable",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/rename",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenameTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RenameTableResponse RenameTable(RenameTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RenameTableWithOptions(request, headers, runtime);
        }

        public async Task<RenameTableResponse> RenameTableAsync(RenameTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RenameTableWithOptionsAsync(request, headers, runtime);
        }

        public RevokePermissionsResponse RevokePermissionsWithOptions(RevokePermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accesses))
            {
                body["Accesses"] = request.Accesses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelegateAccesses))
            {
                body["DelegateAccesses"] = request.DelegateAccesses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaResource))
            {
                body["MetaResource"] = request.MetaResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Principal))
            {
                body["Principal"] = request.Principal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokePermissions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/permissions/revoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokePermissionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RevokePermissionsResponse> RevokePermissionsWithOptionsAsync(RevokePermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accesses))
            {
                body["Accesses"] = request.Accesses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelegateAccesses))
            {
                body["DelegateAccesses"] = request.DelegateAccesses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaResource))
            {
                body["MetaResource"] = request.MetaResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Principal))
            {
                body["Principal"] = request.Principal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokePermissions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/permissions/revoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokePermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RevokePermissionsResponse RevokePermissions(RevokePermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RevokePermissionsWithOptions(request, headers, runtime);
        }

        public async Task<RevokePermissionsResponse> RevokePermissionsAsync(RevokePermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RevokePermissionsWithOptionsAsync(request, headers, runtime);
        }

        public RevokeRoleFromUsersResponse RevokeRoleFromUsersWithOptions(RevokeRoleFromUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeRoleFromUsers",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/roles/revokeusers",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeRoleFromUsersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RevokeRoleFromUsersResponse> RevokeRoleFromUsersWithOptionsAsync(RevokeRoleFromUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeRoleFromUsers",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/roles/revokeusers",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeRoleFromUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RevokeRoleFromUsersResponse RevokeRoleFromUsers(RevokeRoleFromUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RevokeRoleFromUsersWithOptions(request, headers, runtime);
        }

        public async Task<RevokeRoleFromUsersResponse> RevokeRoleFromUsersAsync(RevokeRoleFromUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RevokeRoleFromUsersWithOptionsAsync(request, headers, runtime);
        }

        public RevokeRolesFromUserResponse RevokeRolesFromUserWithOptions(RevokeRolesFromUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleNames))
            {
                body["RoleNames"] = request.RoleNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.User))
            {
                body["User"] = request.User;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeRolesFromUser",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/roles/revokeroles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeRolesFromUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RevokeRolesFromUserResponse> RevokeRolesFromUserWithOptionsAsync(RevokeRolesFromUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleNames))
            {
                body["RoleNames"] = request.RoleNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.User))
            {
                body["User"] = request.User;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeRolesFromUser",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/roles/revokeroles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeRolesFromUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RevokeRolesFromUserResponse RevokeRolesFromUser(RevokeRolesFromUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RevokeRolesFromUserWithOptions(request, headers, runtime);
        }

        public async Task<RevokeRolesFromUserResponse> RevokeRolesFromUserAsync(RevokeRolesFromUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RevokeRolesFromUserWithOptionsAsync(request, headers, runtime);
        }

        public RunMigrationWorkflowResponse RunMigrationWorkflowWithOptions(RunMigrationWorkflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunMigrationWorkflow",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/migration/workflow/run",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunMigrationWorkflowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RunMigrationWorkflowResponse> RunMigrationWorkflowWithOptionsAsync(RunMigrationWorkflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunMigrationWorkflow",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/migration/workflow/run",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunMigrationWorkflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RunMigrationWorkflowResponse RunMigrationWorkflow(RunMigrationWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunMigrationWorkflowWithOptions(request, headers, runtime);
        }

        public async Task<RunMigrationWorkflowResponse> RunMigrationWorkflowAsync(RunMigrationWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunMigrationWorkflowWithOptionsAsync(request, headers, runtime);
        }

        public SearchResponse SearchWithOptions(SearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchText))
            {
                body["SearchText"] = request.SearchText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                body["SearchType"] = request.SearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortCriteria))
            {
                body["SortCriteria"] = request.SortCriteria;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Search",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SearchResponse> SearchWithOptionsAsync(SearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchText))
            {
                body["SearchText"] = request.SearchText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                body["SearchType"] = request.SearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortCriteria))
            {
                body["SortCriteria"] = request.SortCriteria;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Search",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SearchResponse Search(SearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SearchWithOptions(request, headers, runtime);
        }

        public async Task<SearchResponse> SearchAsync(SearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SearchWithOptionsAsync(request, headers, runtime);
        }

        public SearchAcrossCatalogResponse SearchAcrossCatalogWithOptions(SearchAcrossCatalogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogIds))
            {
                body["CatalogIds"] = request.CatalogIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchText))
            {
                body["SearchText"] = request.SearchText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchTypes))
            {
                body["SearchTypes"] = request.SearchTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortCriteria))
            {
                body["SortCriteria"] = request.SortCriteria;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchAcrossCatalog",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/search/search-across-catalog",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchAcrossCatalogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SearchAcrossCatalogResponse> SearchAcrossCatalogWithOptionsAsync(SearchAcrossCatalogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogIds))
            {
                body["CatalogIds"] = request.CatalogIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchText))
            {
                body["SearchText"] = request.SearchText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchTypes))
            {
                body["SearchTypes"] = request.SearchTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortCriteria))
            {
                body["SortCriteria"] = request.SortCriteria;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchAcrossCatalog",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/search/search-across-catalog",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchAcrossCatalogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SearchAcrossCatalogResponse SearchAcrossCatalog(SearchAcrossCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SearchAcrossCatalogWithOptions(request, headers, runtime);
        }

        public async Task<SearchAcrossCatalogResponse> SearchAcrossCatalogAsync(SearchAcrossCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SearchAcrossCatalogWithOptionsAsync(request, headers, runtime);
        }

        public StopMigrationWorkflowResponse StopMigrationWorkflowWithOptions(StopMigrationWorkflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopMigrationWorkflow",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/migration/workflow/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopMigrationWorkflowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopMigrationWorkflowResponse> StopMigrationWorkflowWithOptionsAsync(StopMigrationWorkflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopMigrationWorkflow",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/migration/workflow/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopMigrationWorkflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopMigrationWorkflowResponse StopMigrationWorkflow(StopMigrationWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopMigrationWorkflowWithOptions(request, headers, runtime);
        }

        public async Task<StopMigrationWorkflowResponse> StopMigrationWorkflowAsync(StopMigrationWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopMigrationWorkflowWithOptionsAsync(request, headers, runtime);
        }

        public SubmitQueryResponse SubmitQueryWithOptions(SubmitQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["catalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                body["sql"] = request.Sql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitQuery",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/query/submitQueryRequestBody",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitQueryResponse> SubmitQueryWithOptionsAsync(SubmitQueryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["catalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                body["sql"] = request.Sql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitQuery",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/query/submitQueryRequestBody",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitQueryResponse SubmitQuery(SubmitQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SubmitQueryWithOptions(request, headers, runtime);
        }

        public async Task<SubmitQueryResponse> SubmitQueryAsync(SubmitQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SubmitQueryWithOptionsAsync(request, headers, runtime);
        }

        public UnLockResponse UnLockWithOptions(UnLockRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockId))
            {
                query["LockId"] = request.LockId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnLock",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/locks",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnLockResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnLockResponse> UnLockWithOptionsAsync(UnLockRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockId))
            {
                query["LockId"] = request.LockId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnLock",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/locks",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnLockResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnLockResponse UnLock(UnLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UnLockWithOptions(request, headers, runtime);
        }

        public async Task<UnLockResponse> UnLockAsync(UnLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UnLockWithOptionsAsync(request, headers, runtime);
        }

        public UpdateCatalogResponse UpdateCatalogWithOptions(UpdateCatalogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogInput))
            {
                body["CatalogInput"] = request.CatalogInput;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCatalog",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCatalogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateCatalogResponse> UpdateCatalogWithOptionsAsync(UpdateCatalogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogInput))
            {
                body["CatalogInput"] = request.CatalogInput;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCatalog",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCatalogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateCatalogResponse UpdateCatalog(UpdateCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateCatalogWithOptions(request, headers, runtime);
        }

        public async Task<UpdateCatalogResponse> UpdateCatalogAsync(UpdateCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateCatalogWithOptionsAsync(request, headers, runtime);
        }

        public UpdateCatalogSettingsResponse UpdateCatalogSettingsWithOptions(UpdateCatalogSettingsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogSettings))
            {
                body["CatalogSettings"] = request.CatalogSettings;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCatalogSettings",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/settings",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCatalogSettingsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateCatalogSettingsResponse> UpdateCatalogSettingsWithOptionsAsync(UpdateCatalogSettingsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogSettings))
            {
                body["CatalogSettings"] = request.CatalogSettings;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCatalogSettings",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/settings",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCatalogSettingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateCatalogSettingsResponse UpdateCatalogSettings(UpdateCatalogSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateCatalogSettingsWithOptions(request, headers, runtime);
        }

        public async Task<UpdateCatalogSettingsResponse> UpdateCatalogSettingsAsync(UpdateCatalogSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateCatalogSettingsWithOptionsAsync(request, headers, runtime);
        }

        public UpdateDatabaseResponse UpdateDatabaseWithOptions(UpdateDatabaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInput))
            {
                body["DatabaseInput"] = request.DatabaseInput;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDatabase",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatabaseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateDatabaseResponse> UpdateDatabaseWithOptionsAsync(UpdateDatabaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInput))
            {
                body["DatabaseInput"] = request.DatabaseInput;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDatabase",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateDatabaseResponse UpdateDatabase(UpdateDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDatabaseWithOptions(request, headers, runtime);
        }

        public async Task<UpdateDatabaseResponse> UpdateDatabaseAsync(UpdateDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDatabaseWithOptionsAsync(request, headers, runtime);
        }

        public UpdateFunctionResponse UpdateFunctionWithOptions(UpdateFunctionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionInput))
            {
                body["FunctionInput"] = request.FunctionInput;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                body["FunctionName"] = request.FunctionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFunction",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/functions",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFunctionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateFunctionResponse> UpdateFunctionWithOptionsAsync(UpdateFunctionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionInput))
            {
                body["FunctionInput"] = request.FunctionInput;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                body["FunctionName"] = request.FunctionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFunction",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/functions",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateFunctionResponse UpdateFunction(UpdateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFunctionWithOptions(request, headers, runtime);
        }

        public async Task<UpdateFunctionResponse> UpdateFunctionAsync(UpdateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFunctionWithOptionsAsync(request, headers, runtime);
        }

        public UpdatePartitionColumnStatisticsResponse UpdatePartitionColumnStatisticsWithOptions(UpdatePartitionColumnStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.UpdateTablePartitionColumnStatisticsRequest),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePartitionColumnStatistics",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/columnstatistics",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePartitionColumnStatisticsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdatePartitionColumnStatisticsResponse> UpdatePartitionColumnStatisticsWithOptionsAsync(UpdatePartitionColumnStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.UpdateTablePartitionColumnStatisticsRequest),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePartitionColumnStatistics",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/partitions/columnstatistics",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePartitionColumnStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdatePartitionColumnStatisticsResponse UpdatePartitionColumnStatistics(UpdatePartitionColumnStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdatePartitionColumnStatisticsWithOptions(request, headers, runtime);
        }

        public async Task<UpdatePartitionColumnStatisticsResponse> UpdatePartitionColumnStatisticsAsync(UpdatePartitionColumnStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdatePartitionColumnStatisticsWithOptionsAsync(request, headers, runtime);
        }

        public UpdatePermissionsResponse UpdatePermissionsWithOptions(UpdatePermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accesses))
            {
                body["Accesses"] = request.Accesses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelegateAccesses))
            {
                body["DelegateAccesses"] = request.DelegateAccesses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaResource))
            {
                body["MetaResource"] = request.MetaResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Principal))
            {
                body["Principal"] = request.Principal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePermissions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/permissions/",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePermissionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdatePermissionsResponse> UpdatePermissionsWithOptionsAsync(UpdatePermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accesses))
            {
                body["Accesses"] = request.Accesses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelegateAccesses))
            {
                body["DelegateAccesses"] = request.DelegateAccesses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaResource))
            {
                body["MetaResource"] = request.MetaResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Principal))
            {
                body["Principal"] = request.Principal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePermissions",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/permissions/",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdatePermissionsResponse UpdatePermissions(UpdatePermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdatePermissionsWithOptions(request, headers, runtime);
        }

        public async Task<UpdatePermissionsResponse> UpdatePermissionsAsync(UpdatePermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdatePermissionsWithOptionsAsync(request, headers, runtime);
        }

        public UpdateRegisteredLocationResponse UpdateRegisteredLocationWithOptions(UpdateRegisteredLocationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InventoryCollectEnabled))
            {
                body["InventoryCollectEnabled"] = request.InventoryCollectEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationId))
            {
                body["LocationId"] = request.LocationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssLogCollectEnabled))
            {
                body["OssLogCollectEnabled"] = request.OssLogCollectEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRegisteredLocation",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/locations",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRegisteredLocationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateRegisteredLocationResponse> UpdateRegisteredLocationWithOptionsAsync(UpdateRegisteredLocationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InventoryCollectEnabled))
            {
                body["InventoryCollectEnabled"] = request.InventoryCollectEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationId))
            {
                body["LocationId"] = request.LocationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssLogCollectEnabled))
            {
                body["OssLogCollectEnabled"] = request.OssLogCollectEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRegisteredLocation",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/webapi/locations",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRegisteredLocationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateRegisteredLocationResponse UpdateRegisteredLocation(UpdateRegisteredLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateRegisteredLocationWithOptions(request, headers, runtime);
        }

        public async Task<UpdateRegisteredLocationResponse> UpdateRegisteredLocationAsync(UpdateRegisteredLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateRegisteredLocationWithOptionsAsync(request, headers, runtime);
        }

        public UpdateRoleResponse UpdateRoleWithOptions(UpdateRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleInput))
            {
                body["RoleInput"] = request.RoleInput;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRole",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/roles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRoleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateRoleResponse> UpdateRoleWithOptionsAsync(UpdateRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleInput))
            {
                body["RoleInput"] = request.RoleInput;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRole",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/roles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateRoleResponse UpdateRole(UpdateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateRoleWithOptions(request, headers, runtime);
        }

        public async Task<UpdateRoleResponse> UpdateRoleAsync(UpdateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateRoleWithOptionsAsync(request, headers, runtime);
        }

        public UpdateRoleUsersResponse UpdateRoleUsersWithOptions(UpdateRoleUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRoleUsers",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/updateroleusers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRoleUsersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateRoleUsersResponse> UpdateRoleUsersWithOptionsAsync(UpdateRoleUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRoleUsers",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/auth/updateroleusers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRoleUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateRoleUsersResponse UpdateRoleUsers(UpdateRoleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateRoleUsersWithOptions(request, headers, runtime);
        }

        public async Task<UpdateRoleUsersResponse> UpdateRoleUsersAsync(UpdateRoleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateRoleUsersWithOptionsAsync(request, headers, runtime);
        }

        public UpdateTableResponse UpdateTableWithOptions(UpdateTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowPartitionKeyChange))
            {
                body["AllowPartitionKeyChange"] = request.AllowPartitionKeyChange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAsync))
            {
                body["IsAsync"] = request.IsAsync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipArchive))
            {
                body["SkipArchive"] = request.SkipArchive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableInput))
            {
                body["TableInput"] = request.TableInput;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTable",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateTableResponse> UpdateTableWithOptionsAsync(UpdateTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowPartitionKeyChange))
            {
                body["AllowPartitionKeyChange"] = request.AllowPartitionKeyChange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["CatalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                body["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAsync))
            {
                body["IsAsync"] = request.IsAsync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipArchive))
            {
                body["SkipArchive"] = request.SkipArchive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableInput))
            {
                body["TableInput"] = request.TableInput;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTable",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateTableResponse UpdateTable(UpdateTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTableWithOptions(request, headers, runtime);
        }

        public async Task<UpdateTableResponse> UpdateTableAsync(UpdateTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTableWithOptionsAsync(request, headers, runtime);
        }

        public UpdateTableColumnStatisticsResponse UpdateTableColumnStatisticsWithOptions(UpdateTableColumnStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.UpdateTablePartitionColumnStatisticsRequest),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTableColumnStatistics",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/columnstatistics",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTableColumnStatisticsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateTableColumnStatisticsResponse> UpdateTableColumnStatisticsWithOptionsAsync(UpdateTableColumnStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.UpdateTablePartitionColumnStatisticsRequest),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTableColumnStatistics",
                Version = "2020-07-10",
                Protocol = "HTTPS",
                Pathname = "/api/metastore/catalogs/databases/tables/columnstatistics",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTableColumnStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateTableColumnStatisticsResponse UpdateTableColumnStatistics(UpdateTableColumnStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTableColumnStatisticsWithOptions(request, headers, runtime);
        }

        public async Task<UpdateTableColumnStatisticsResponse> UpdateTableColumnStatisticsAsync(UpdateTableColumnStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTableColumnStatisticsWithOptionsAsync(request, headers, runtime);
        }

    }
}
