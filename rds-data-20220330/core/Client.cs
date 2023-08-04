// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Rds_data20220330.Models;

namespace AlibabaCloud.SDK.Rds_data20220330
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("rds-data", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public BatchExecuteStatementResponse BatchExecuteStatementWithOptions(BatchExecuteStatementRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchExecuteStatementShrinkRequest request = new BatchExecuteStatementShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ParameterSets))
            {
                request.ParameterSetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ParameterSets, "ParameterSets", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                body["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParameterSetsShrink))
            {
                body["ParameterSets"] = request.ParameterSetsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["ResourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretArn))
            {
                body["SecretArn"] = request.SecretArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                body["Sql"] = request.Sql;
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
                Action = "BatchExecuteStatement",
                Version = "2022-03-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchExecuteStatementResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchExecuteStatementResponse> BatchExecuteStatementWithOptionsAsync(BatchExecuteStatementRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchExecuteStatementShrinkRequest request = new BatchExecuteStatementShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ParameterSets))
            {
                request.ParameterSetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ParameterSets, "ParameterSets", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                body["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParameterSetsShrink))
            {
                body["ParameterSets"] = request.ParameterSetsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["ResourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretArn))
            {
                body["SecretArn"] = request.SecretArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                body["Sql"] = request.Sql;
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
                Action = "BatchExecuteStatement",
                Version = "2022-03-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchExecuteStatementResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchExecuteStatementResponse BatchExecuteStatement(BatchExecuteStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchExecuteStatementWithOptions(request, runtime);
        }

        public async Task<BatchExecuteStatementResponse> BatchExecuteStatementAsync(BatchExecuteStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchExecuteStatementWithOptionsAsync(request, runtime);
        }

        public BeginTransactionResponse BeginTransactionWithOptions(BeginTransactionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                body["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["ResourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretArn))
            {
                body["SecretArn"] = request.SecretArn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BeginTransaction",
                Version = "2022-03-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BeginTransactionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BeginTransactionResponse> BeginTransactionWithOptionsAsync(BeginTransactionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                body["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["ResourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretArn))
            {
                body["SecretArn"] = request.SecretArn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BeginTransaction",
                Version = "2022-03-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BeginTransactionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BeginTransactionResponse BeginTransaction(BeginTransactionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BeginTransactionWithOptions(request, runtime);
        }

        public async Task<BeginTransactionResponse> BeginTransactionAsync(BeginTransactionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BeginTransactionWithOptionsAsync(request, runtime);
        }

        public CommitTransactionResponse CommitTransactionWithOptions(CommitTransactionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["ResourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretArn))
            {
                body["SecretArn"] = request.SecretArn;
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
                Action = "CommitTransaction",
                Version = "2022-03-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommitTransactionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CommitTransactionResponse> CommitTransactionWithOptionsAsync(CommitTransactionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["ResourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretArn))
            {
                body["SecretArn"] = request.SecretArn;
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
                Action = "CommitTransaction",
                Version = "2022-03-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommitTransactionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CommitTransactionResponse CommitTransaction(CommitTransactionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CommitTransactionWithOptions(request, runtime);
        }

        public async Task<CommitTransactionResponse> CommitTransactionAsync(CommitTransactionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CommitTransactionWithOptionsAsync(request, runtime);
        }

        public DeleteResponse DeleteWithOptions(DeleteRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteShrinkRequest request = new DeleteShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "Filter", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                body["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                body["Filter"] = request.FilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["ResourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretArn))
            {
                body["SecretArn"] = request.SecretArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                body["Table"] = request.Table;
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
                Action = "Delete",
                Version = "2022-03-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteResponse> DeleteWithOptionsAsync(DeleteRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteShrinkRequest request = new DeleteShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "Filter", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                body["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                body["Filter"] = request.FilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["ResourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretArn))
            {
                body["SecretArn"] = request.SecretArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                body["Table"] = request.Table;
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
                Action = "Delete",
                Version = "2022-03-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteResponse Delete(DeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWithOptions(request, runtime);
        }

        public async Task<DeleteResponse> DeleteAsync(DeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWithOptionsAsync(request, runtime);
        }

        public ExecuteStatementResponse ExecuteStatementWithOptions(ExecuteStatementRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExecuteStatementShrinkRequest request = new ExecuteStatementShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResultSetOptions))
            {
                request.ResultSetOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResultSetOptions, "ResultSetOptions", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContinueAfterTimeout))
            {
                body["ContinueAfterTimeout"] = request.ContinueAfterTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                body["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormatRecordsAs))
            {
                body["FormatRecordsAs"] = request.FormatRecordsAs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeResultMetadata))
            {
                body["IncludeResultMetadata"] = request.IncludeResultMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                body["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["ResourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultSetOptionsShrink))
            {
                body["ResultSetOptions"] = request.ResultSetOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretArn))
            {
                body["SecretArn"] = request.SecretArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                body["Sql"] = request.Sql;
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
                Action = "ExecuteStatement",
                Version = "2022-03-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteStatementResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ExecuteStatementResponse> ExecuteStatementWithOptionsAsync(ExecuteStatementRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExecuteStatementShrinkRequest request = new ExecuteStatementShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResultSetOptions))
            {
                request.ResultSetOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResultSetOptions, "ResultSetOptions", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContinueAfterTimeout))
            {
                body["ContinueAfterTimeout"] = request.ContinueAfterTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                body["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormatRecordsAs))
            {
                body["FormatRecordsAs"] = request.FormatRecordsAs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeResultMetadata))
            {
                body["IncludeResultMetadata"] = request.IncludeResultMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                body["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["ResourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultSetOptionsShrink))
            {
                body["ResultSetOptions"] = request.ResultSetOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretArn))
            {
                body["SecretArn"] = request.SecretArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                body["Sql"] = request.Sql;
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
                Action = "ExecuteStatement",
                Version = "2022-03-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteStatementResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ExecuteStatementResponse ExecuteStatement(ExecuteStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteStatementWithOptions(request, runtime);
        }

        public async Task<ExecuteStatementResponse> ExecuteStatementAsync(ExecuteStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteStatementWithOptionsAsync(request, runtime);
        }

        public InsertResponse InsertWithOptions(InsertRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsertShrinkRequest request = new InsertShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Record))
            {
                request.RecordShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Record, "Record", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                body["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordShrink))
            {
                body["Record"] = request.RecordShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["ResourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretArn))
            {
                body["SecretArn"] = request.SecretArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                body["Table"] = request.Table;
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
                Action = "Insert",
                Version = "2022-03-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsertResponse> InsertWithOptionsAsync(InsertRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsertShrinkRequest request = new InsertShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Record))
            {
                request.RecordShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Record, "Record", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                body["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordShrink))
            {
                body["Record"] = request.RecordShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["ResourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretArn))
            {
                body["SecretArn"] = request.SecretArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                body["Table"] = request.Table;
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
                Action = "Insert",
                Version = "2022-03-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsertResponse Insert(InsertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InsertWithOptions(request, runtime);
        }

        public async Task<InsertResponse> InsertAsync(InsertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InsertWithOptionsAsync(request, runtime);
        }

        public InsertListResponse InsertListWithOptions(InsertListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsertListShrinkRequest request = new InsertListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Records))
            {
                request.RecordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Records, "Records", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                body["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordsShrink))
            {
                body["Records"] = request.RecordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["ResourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretArn))
            {
                body["SecretArn"] = request.SecretArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                body["Table"] = request.Table;
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
                Action = "InsertList",
                Version = "2022-03-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InsertListResponse> InsertListWithOptionsAsync(InsertListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InsertListShrinkRequest request = new InsertListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Records))
            {
                request.RecordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Records, "Records", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                body["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordsShrink))
            {
                body["Records"] = request.RecordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["ResourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretArn))
            {
                body["SecretArn"] = request.SecretArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                body["Table"] = request.Table;
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
                Action = "InsertList",
                Version = "2022-03-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InsertListResponse InsertList(InsertListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InsertListWithOptions(request, runtime);
        }

        public async Task<InsertListResponse> InsertListAsync(InsertListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InsertListWithOptionsAsync(request, runtime);
        }

        public RollbackTransactionResponse RollbackTransactionWithOptions(RollbackTransactionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["ResourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretArn))
            {
                body["SecretArn"] = request.SecretArn;
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
                Action = "RollbackTransaction",
                Version = "2022-03-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackTransactionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RollbackTransactionResponse> RollbackTransactionWithOptionsAsync(RollbackTransactionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["ResourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretArn))
            {
                body["SecretArn"] = request.SecretArn;
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
                Action = "RollbackTransaction",
                Version = "2022-03-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackTransactionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RollbackTransactionResponse RollbackTransaction(RollbackTransactionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RollbackTransactionWithOptions(request, runtime);
        }

        public async Task<RollbackTransactionResponse> RollbackTransactionAsync(RollbackTransactionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RollbackTransactionWithOptionsAsync(request, runtime);
        }

        public SelectResponse SelectWithOptions(SelectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SelectShrinkRequest request = new SelectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "Filter", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                body["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                body["Filter"] = request.FilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["ResourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretArn))
            {
                body["SecretArn"] = request.SecretArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                body["Table"] = request.Table;
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
                Action = "Select",
                Version = "2022-03-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SelectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SelectResponse> SelectWithOptionsAsync(SelectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SelectShrinkRequest request = new SelectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "Filter", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                body["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                body["Filter"] = request.FilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["ResourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretArn))
            {
                body["SecretArn"] = request.SecretArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                body["Table"] = request.Table;
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
                Action = "Select",
                Version = "2022-03-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SelectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SelectResponse Select(SelectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SelectWithOptions(request, runtime);
        }

        public async Task<SelectResponse> SelectAsync(SelectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SelectWithOptionsAsync(request, runtime);
        }

        public UpdateResponse UpdateWithOptions(UpdateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateShrinkRequest request = new UpdateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "Filter", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Record))
            {
                request.RecordShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Record, "Record", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                body["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                body["Filter"] = request.FilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordShrink))
            {
                body["Record"] = request.RecordShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["ResourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretArn))
            {
                body["SecretArn"] = request.SecretArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                body["Table"] = request.Table;
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
                Action = "Update",
                Version = "2022-03-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateResponse> UpdateWithOptionsAsync(UpdateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateShrinkRequest request = new UpdateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "Filter", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Record))
            {
                request.RecordShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Record, "Record", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                body["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                body["Filter"] = request.FilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordShrink))
            {
                body["Record"] = request.RecordShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceArn))
            {
                body["ResourceArn"] = request.ResourceArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretArn))
            {
                body["SecretArn"] = request.SecretArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                body["Table"] = request.Table;
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
                Action = "Update",
                Version = "2022-03-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateResponse Update(UpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWithOptions(request, runtime);
        }

        public async Task<UpdateResponse> UpdateAsync(UpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWithOptionsAsync(request, runtime);
        }

    }
}
