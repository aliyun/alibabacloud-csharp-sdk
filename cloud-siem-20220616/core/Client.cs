// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cloud_siem20220616.Models;

namespace AlibabaCloud.SDK.Cloud_siem20220616
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cloud-siem", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddDataSourceResponse AddDataSourceWithOptions(AddDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceName))
            {
                body["DataSourceInstanceName"] = request.DataSourceInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceParams))
            {
                body["DataSourceInstanceParams"] = request.DataSourceInstanceParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceRemark))
            {
                body["DataSourceInstanceRemark"] = request.DataSourceInstanceRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDataSource",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDataSourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddDataSourceResponse> AddDataSourceWithOptionsAsync(AddDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceName))
            {
                body["DataSourceInstanceName"] = request.DataSourceInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceParams))
            {
                body["DataSourceInstanceParams"] = request.DataSourceInstanceParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceRemark))
            {
                body["DataSourceInstanceRemark"] = request.DataSourceInstanceRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDataSource",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddDataSourceResponse AddDataSource(AddDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDataSourceWithOptions(request, runtime);
        }

        public async Task<AddDataSourceResponse> AddDataSourceAsync(AddDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDataSourceWithOptionsAsync(request, runtime);
        }

        public AddDataSourceLogResponse AddDataSourceLogWithOptions(AddDataSourceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceLogs))
            {
                body["DataSourceInstanceLogs"] = request.DataSourceInstanceLogs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCode))
            {
                body["LogCode"] = request.LogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDataSourceLog",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDataSourceLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddDataSourceLogResponse> AddDataSourceLogWithOptionsAsync(AddDataSourceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceLogs))
            {
                body["DataSourceInstanceLogs"] = request.DataSourceInstanceLogs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCode))
            {
                body["LogCode"] = request.LogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDataSourceLog",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDataSourceLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddDataSourceLogResponse AddDataSourceLog(AddDataSourceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDataSourceLogWithOptions(request, runtime);
        }

        public async Task<AddDataSourceLogResponse> AddDataSourceLogAsync(AddDataSourceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDataSourceLogWithOptionsAsync(request, runtime);
        }

        public AddUserResponse AddUserWithOptions(AddUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddedUserId))
            {
                body["AddedUserId"] = request.AddedUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUser",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddUserResponse> AddUserWithOptionsAsync(AddUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddedUserId))
            {
                body["AddedUserId"] = request.AddedUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUser",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddUserResponse AddUser(AddUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUserWithOptions(request, runtime);
        }

        public async Task<AddUserResponse> AddUserAsync(AddUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUserWithOptionsAsync(request, runtime);
        }

        public AddUserSourceLogConfigResponse AddUserSourceLogConfigWithOptions(AddUserSourceLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deleted))
            {
                body["Deleted"] = request.Deleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisPlayLine))
            {
                body["DisPlayLine"] = request.DisPlayLine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLogCode))
            {
                body["SourceLogCode"] = request.SourceLogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLogInfo))
            {
                body["SourceLogInfo"] = request.SourceLogInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProdCode))
            {
                body["SourceProdCode"] = request.SourceProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserSourceLogConfig",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserSourceLogConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddUserSourceLogConfigResponse> AddUserSourceLogConfigWithOptionsAsync(AddUserSourceLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deleted))
            {
                body["Deleted"] = request.Deleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisPlayLine))
            {
                body["DisPlayLine"] = request.DisPlayLine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLogCode))
            {
                body["SourceLogCode"] = request.SourceLogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLogInfo))
            {
                body["SourceLogInfo"] = request.SourceLogInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProdCode))
            {
                body["SourceProdCode"] = request.SourceProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserSourceLogConfig",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserSourceLogConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddUserSourceLogConfigResponse AddUserSourceLogConfig(AddUserSourceLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUserSourceLogConfigWithOptions(request, runtime);
        }

        public async Task<AddUserSourceLogConfigResponse> AddUserSourceLogConfigAsync(AddUserSourceLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUserSourceLogConfigWithOptionsAsync(request, runtime);
        }

        public BatchJobCheckResponse BatchJobCheckWithOptions(BatchJobCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitId))
            {
                body["SubmitId"] = request.SubmitId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchJobCheck",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchJobCheckResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchJobCheckResponse> BatchJobCheckWithOptionsAsync(BatchJobCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitId))
            {
                body["SubmitId"] = request.SubmitId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchJobCheck",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchJobCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchJobCheckResponse BatchJobCheck(BatchJobCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchJobCheckWithOptions(request, runtime);
        }

        public async Task<BatchJobCheckResponse> BatchJobCheckAsync(BatchJobCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchJobCheckWithOptionsAsync(request, runtime);
        }

        public BatchJobSubmitResponse BatchJobSubmitWithOptions(BatchJobSubmitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonConfig))
            {
                body["JsonConfig"] = request.JsonConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchJobSubmit",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchJobSubmitResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchJobSubmitResponse> BatchJobSubmitWithOptionsAsync(BatchJobSubmitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonConfig))
            {
                body["JsonConfig"] = request.JsonConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchJobSubmit",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchJobSubmitResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchJobSubmitResponse BatchJobSubmit(BatchJobSubmitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchJobSubmitWithOptions(request, runtime);
        }

        public async Task<BatchJobSubmitResponse> BatchJobSubmitAsync(BatchJobSubmitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchJobSubmitWithOptionsAsync(request, runtime);
        }

        public BindAccountResponse BindAccountWithOptions(BindAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessId))
            {
                body["AccessId"] = request.AccessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAccount",
                Version = "2022-06-16",
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

        public async Task<BindAccountResponse> BindAccountWithOptionsAsync(BindAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessId))
            {
                body["AccessId"] = request.AccessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAccount",
                Version = "2022-06-16",
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

        public BindAccountResponse BindAccount(BindAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAccountWithOptions(request, runtime);
        }

        public async Task<BindAccountResponse> BindAccountAsync(BindAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAccountWithOptionsAsync(request, runtime);
        }

        public CloseDeliveryResponse CloseDeliveryWithOptions(CloseDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCode))
            {
                body["LogCode"] = request.LogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseDelivery",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseDeliveryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CloseDeliveryResponse> CloseDeliveryWithOptionsAsync(CloseDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCode))
            {
                body["LogCode"] = request.LogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseDelivery",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseDeliveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CloseDeliveryResponse CloseDelivery(CloseDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloseDeliveryWithOptions(request, runtime);
        }

        public async Task<CloseDeliveryResponse> CloseDeliveryAsync(CloseDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloseDeliveryWithOptionsAsync(request, runtime);
        }

        public DeleteAutomateResponseConfigResponse DeleteAutomateResponseConfigWithOptions(DeleteAutomateResponseConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAutomateResponseConfig",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAutomateResponseConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteAutomateResponseConfigResponse> DeleteAutomateResponseConfigWithOptionsAsync(DeleteAutomateResponseConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAutomateResponseConfig",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAutomateResponseConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteAutomateResponseConfigResponse DeleteAutomateResponseConfig(DeleteAutomateResponseConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAutomateResponseConfigWithOptions(request, runtime);
        }

        public async Task<DeleteAutomateResponseConfigResponse> DeleteAutomateResponseConfigAsync(DeleteAutomateResponseConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAutomateResponseConfigWithOptionsAsync(request, runtime);
        }

        public DeleteBindAccountResponse DeleteBindAccountWithOptions(DeleteBindAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessId))
            {
                body["AccessId"] = request.AccessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindId))
            {
                body["BindId"] = request.BindId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBindAccount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBindAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteBindAccountResponse> DeleteBindAccountWithOptionsAsync(DeleteBindAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessId))
            {
                body["AccessId"] = request.AccessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindId))
            {
                body["BindId"] = request.BindId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBindAccount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBindAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteBindAccountResponse DeleteBindAccount(DeleteBindAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBindAccountWithOptions(request, runtime);
        }

        public async Task<DeleteBindAccountResponse> DeleteBindAccountAsync(DeleteBindAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBindAccountWithOptionsAsync(request, runtime);
        }

        public DeleteCustomizeRuleResponse DeleteCustomizeRuleWithOptions(DeleteCustomizeRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomizeRule",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomizeRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteCustomizeRuleResponse> DeleteCustomizeRuleWithOptionsAsync(DeleteCustomizeRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomizeRule",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomizeRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteCustomizeRuleResponse DeleteCustomizeRule(DeleteCustomizeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomizeRuleWithOptions(request, runtime);
        }

        public async Task<DeleteCustomizeRuleResponse> DeleteCustomizeRuleAsync(DeleteCustomizeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomizeRuleWithOptionsAsync(request, runtime);
        }

        public DeleteDataSourceResponse DeleteDataSourceWithOptions(DeleteDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataSource",
                Version = "2022-06-16",
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

        public async Task<DeleteDataSourceResponse> DeleteDataSourceWithOptionsAsync(DeleteDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataSource",
                Version = "2022-06-16",
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

        public DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataSourceWithOptions(request, runtime);
        }

        public async Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataSourceWithOptionsAsync(request, runtime);
        }

        public DeleteDataSourceLogResponse DeleteDataSourceLogWithOptions(DeleteDataSourceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogInstanceId))
            {
                body["LogInstanceId"] = request.LogInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataSourceLog",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataSourceLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDataSourceLogResponse> DeleteDataSourceLogWithOptionsAsync(DeleteDataSourceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogInstanceId))
            {
                body["LogInstanceId"] = request.LogInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataSourceLog",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataSourceLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDataSourceLogResponse DeleteDataSourceLog(DeleteDataSourceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataSourceLogWithOptions(request, runtime);
        }

        public async Task<DeleteDataSourceLogResponse> DeleteDataSourceLogAsync(DeleteDataSourceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataSourceLogWithOptionsAsync(request, runtime);
        }

        public DeleteQuickQueryResponse DeleteQuickQueryWithOptions(DeleteQuickQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchName))
            {
                body["SearchName"] = request.SearchName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteQuickQuery",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteQuickQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteQuickQueryResponse> DeleteQuickQueryWithOptionsAsync(DeleteQuickQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchName))
            {
                body["SearchName"] = request.SearchName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteQuickQuery",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteQuickQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteQuickQueryResponse DeleteQuickQuery(DeleteQuickQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQuickQueryWithOptions(request, runtime);
        }

        public async Task<DeleteQuickQueryResponse> DeleteQuickQueryAsync(DeleteQuickQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQuickQueryWithOptionsAsync(request, runtime);
        }

        public DeleteUserResponse DeleteUserWithOptions(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddedUserId))
            {
                body["AddedUserId"] = request.AddedUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteUserResponse> DeleteUserWithOptionsAsync(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddedUserId))
            {
                body["AddedUserId"] = request.AddedUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserWithOptions(request, runtime);
        }

        public async Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserWithOptionsAsync(request, runtime);
        }

        public DeleteWhiteRuleListResponse DeleteWhiteRuleListWithOptions(DeleteWhiteRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWhiteRuleList",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWhiteRuleListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteWhiteRuleListResponse> DeleteWhiteRuleListWithOptionsAsync(DeleteWhiteRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWhiteRuleList",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWhiteRuleListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteWhiteRuleListResponse DeleteWhiteRuleList(DeleteWhiteRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWhiteRuleListWithOptions(request, runtime);
        }

        public async Task<DeleteWhiteRuleListResponse> DeleteWhiteRuleListAsync(DeleteWhiteRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWhiteRuleListWithOptionsAsync(request, runtime);
        }

        public DescribeAggregateFunctionResponse DescribeAggregateFunctionWithOptions(DescribeAggregateFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAggregateFunction",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAggregateFunctionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAggregateFunctionResponse> DescribeAggregateFunctionWithOptionsAsync(DescribeAggregateFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAggregateFunction",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAggregateFunctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAggregateFunctionResponse DescribeAggregateFunction(DescribeAggregateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAggregateFunctionWithOptions(request, runtime);
        }

        public async Task<DescribeAggregateFunctionResponse> DescribeAggregateFunctionAsync(DescribeAggregateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAggregateFunctionWithOptionsAsync(request, runtime);
        }

        public DescribeAlertSceneResponse DescribeAlertSceneWithOptions(DescribeAlertSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertScene",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAlertSceneResponse> DescribeAlertSceneWithOptionsAsync(DescribeAlertSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertScene",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertSceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAlertSceneResponse DescribeAlertScene(DescribeAlertSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertSceneWithOptions(request, runtime);
        }

        public async Task<DescribeAlertSceneResponse> DescribeAlertSceneAsync(DescribeAlertSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertSceneWithOptionsAsync(request, runtime);
        }

        public DescribeAlertSceneByEventResponse DescribeAlertSceneByEventWithOptions(DescribeAlertSceneByEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertSceneByEvent",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertSceneByEventResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAlertSceneByEventResponse> DescribeAlertSceneByEventWithOptionsAsync(DescribeAlertSceneByEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertSceneByEvent",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertSceneByEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAlertSceneByEventResponse DescribeAlertSceneByEvent(DescribeAlertSceneByEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertSceneByEventWithOptions(request, runtime);
        }

        public async Task<DescribeAlertSceneByEventResponse> DescribeAlertSceneByEventAsync(DescribeAlertSceneByEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertSceneByEventWithOptionsAsync(request, runtime);
        }

        public DescribeAlertSourceResponse DescribeAlertSourceWithOptions(DescribeAlertSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
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
                Action = "DescribeAlertSource",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertSourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAlertSourceResponse> DescribeAlertSourceWithOptionsAsync(DescribeAlertSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
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
                Action = "DescribeAlertSource",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAlertSourceResponse DescribeAlertSource(DescribeAlertSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertSourceWithOptions(request, runtime);
        }

        public async Task<DescribeAlertSourceResponse> DescribeAlertSourceAsync(DescribeAlertSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertSourceWithOptionsAsync(request, runtime);
        }

        public DescribeAlertSourceWithEventResponse DescribeAlertSourceWithEventWithOptions(DescribeAlertSourceWithEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertSourceWithEvent",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertSourceWithEventResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAlertSourceWithEventResponse> DescribeAlertSourceWithEventWithOptionsAsync(DescribeAlertSourceWithEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertSourceWithEvent",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertSourceWithEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAlertSourceWithEventResponse DescribeAlertSourceWithEvent(DescribeAlertSourceWithEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertSourceWithEventWithOptions(request, runtime);
        }

        public async Task<DescribeAlertSourceWithEventResponse> DescribeAlertSourceWithEventAsync(DescribeAlertSourceWithEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertSourceWithEventWithOptionsAsync(request, runtime);
        }

        public DescribeAlertTypeResponse DescribeAlertTypeWithOptions(DescribeAlertTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertType",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertTypeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAlertTypeResponse> DescribeAlertTypeWithOptionsAsync(DescribeAlertTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertType",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAlertTypeResponse DescribeAlertType(DescribeAlertTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertTypeWithOptions(request, runtime);
        }

        public async Task<DescribeAlertTypeResponse> DescribeAlertTypeAsync(DescribeAlertTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertTypeWithOptionsAsync(request, runtime);
        }

        public DescribeAlertsResponse DescribeAlertsWithOptions(DescribeAlertsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertTitle))
            {
                body["AlertTitle"] = request.AlertTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertUuid))
            {
                body["AlertUuid"] = request.AlertUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDefend))
            {
                body["IsDefend"] = request.IsDefend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlerts",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAlertsResponse> DescribeAlertsWithOptionsAsync(DescribeAlertsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertTitle))
            {
                body["AlertTitle"] = request.AlertTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertUuid))
            {
                body["AlertUuid"] = request.AlertUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDefend))
            {
                body["IsDefend"] = request.IsDefend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlerts",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAlertsResponse DescribeAlerts(DescribeAlertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertsWithOptions(request, runtime);
        }

        public async Task<DescribeAlertsResponse> DescribeAlertsAsync(DescribeAlertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertsWithOptionsAsync(request, runtime);
        }

        public DescribeAlertsCountResponse DescribeAlertsCountWithOptions(DescribeAlertsCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
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
                Action = "DescribeAlertsCount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertsCountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAlertsCountResponse> DescribeAlertsCountWithOptionsAsync(DescribeAlertsCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
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
                Action = "DescribeAlertsCount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertsCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAlertsCountResponse DescribeAlertsCount(DescribeAlertsCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertsCountWithOptions(request, runtime);
        }

        public async Task<DescribeAlertsCountResponse> DescribeAlertsCountAsync(DescribeAlertsCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertsCountWithOptionsAsync(request, runtime);
        }

        public DescribeAlertsWithEntityResponse DescribeAlertsWithEntityWithOptions(DescribeAlertsWithEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                body["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SophonTaskId))
            {
                body["SophonTaskId"] = request.SophonTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertsWithEntity",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertsWithEntityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAlertsWithEntityResponse> DescribeAlertsWithEntityWithOptionsAsync(DescribeAlertsWithEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                body["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SophonTaskId))
            {
                body["SophonTaskId"] = request.SophonTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertsWithEntity",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertsWithEntityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAlertsWithEntityResponse DescribeAlertsWithEntity(DescribeAlertsWithEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertsWithEntityWithOptions(request, runtime);
        }

        public async Task<DescribeAlertsWithEntityResponse> DescribeAlertsWithEntityAsync(DescribeAlertsWithEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertsWithEntityWithOptionsAsync(request, runtime);
        }

        public DescribeAlertsWithEventResponse DescribeAlertsWithEventWithOptions(DescribeAlertsWithEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertTitle))
            {
                body["AlertTitle"] = request.AlertTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDefend))
            {
                body["IsDefend"] = request.IsDefend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertsWithEvent",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertsWithEventResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAlertsWithEventResponse> DescribeAlertsWithEventWithOptionsAsync(DescribeAlertsWithEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertTitle))
            {
                body["AlertTitle"] = request.AlertTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDefend))
            {
                body["IsDefend"] = request.IsDefend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["Level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAlertsWithEvent",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAlertsWithEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAlertsWithEventResponse DescribeAlertsWithEvent(DescribeAlertsWithEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAlertsWithEventWithOptions(request, runtime);
        }

        public async Task<DescribeAlertsWithEventResponse> DescribeAlertsWithEventAsync(DescribeAlertsWithEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAlertsWithEventWithOptionsAsync(request, runtime);
        }

        public DescribeAttackTimeLineResponse DescribeAttackTimeLineWithOptions(DescribeAttackTimeLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetName))
            {
                body["AssetName"] = request.AssetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
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
                Action = "DescribeAttackTimeLine",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAttackTimeLineResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAttackTimeLineResponse> DescribeAttackTimeLineWithOptionsAsync(DescribeAttackTimeLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetName))
            {
                body["AssetName"] = request.AssetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
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
                Action = "DescribeAttackTimeLine",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAttackTimeLineResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAttackTimeLineResponse DescribeAttackTimeLine(DescribeAttackTimeLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAttackTimeLineWithOptions(request, runtime);
        }

        public async Task<DescribeAttackTimeLineResponse> DescribeAttackTimeLineAsync(DescribeAttackTimeLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAttackTimeLineWithOptionsAsync(request, runtime);
        }

        public DescribeAuthResponse DescribeAuthWithOptions(DescribeAuthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAuth",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAuthResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAuthResponse> DescribeAuthWithOptionsAsync(DescribeAuthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAuth",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAuthResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAuthResponse DescribeAuth(DescribeAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAuthWithOptions(request, runtime);
        }

        public async Task<DescribeAuthResponse> DescribeAuthAsync(DescribeAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAuthWithOptionsAsync(request, runtime);
        }

        public DescribeAutomateResponseConfigCounterResponse DescribeAutomateResponseConfigCounterWithOptions(DescribeAutomateResponseConfigCounterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutomateResponseConfigCounter",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutomateResponseConfigCounterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAutomateResponseConfigCounterResponse> DescribeAutomateResponseConfigCounterWithOptionsAsync(DescribeAutomateResponseConfigCounterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutomateResponseConfigCounter",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutomateResponseConfigCounterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAutomateResponseConfigCounterResponse DescribeAutomateResponseConfigCounter(DescribeAutomateResponseConfigCounterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutomateResponseConfigCounterWithOptions(request, runtime);
        }

        public async Task<DescribeAutomateResponseConfigCounterResponse> DescribeAutomateResponseConfigCounterAsync(DescribeAutomateResponseConfigCounterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutomateResponseConfigCounterWithOptionsAsync(request, runtime);
        }

        public DescribeAutomateResponseConfigFeatureResponse DescribeAutomateResponseConfigFeatureWithOptions(DescribeAutomateResponseConfigFeatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoResponseType))
            {
                body["AutoResponseType"] = request.AutoResponseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutomateResponseConfigFeature",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutomateResponseConfigFeatureResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAutomateResponseConfigFeatureResponse> DescribeAutomateResponseConfigFeatureWithOptionsAsync(DescribeAutomateResponseConfigFeatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoResponseType))
            {
                body["AutoResponseType"] = request.AutoResponseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutomateResponseConfigFeature",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutomateResponseConfigFeatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAutomateResponseConfigFeatureResponse DescribeAutomateResponseConfigFeature(DescribeAutomateResponseConfigFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutomateResponseConfigFeatureWithOptions(request, runtime);
        }

        public async Task<DescribeAutomateResponseConfigFeatureResponse> DescribeAutomateResponseConfigFeatureAsync(DescribeAutomateResponseConfigFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutomateResponseConfigFeatureWithOptionsAsync(request, runtime);
        }

        public DescribeAutomateResponseConfigPlayBooksResponse DescribeAutomateResponseConfigPlayBooksWithOptions(DescribeAutomateResponseConfigPlayBooksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoResponseType))
            {
                body["AutoResponseType"] = request.AutoResponseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                body["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutomateResponseConfigPlayBooks",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutomateResponseConfigPlayBooksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAutomateResponseConfigPlayBooksResponse> DescribeAutomateResponseConfigPlayBooksWithOptionsAsync(DescribeAutomateResponseConfigPlayBooksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoResponseType))
            {
                body["AutoResponseType"] = request.AutoResponseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                body["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAutomateResponseConfigPlayBooks",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAutomateResponseConfigPlayBooksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAutomateResponseConfigPlayBooksResponse DescribeAutomateResponseConfigPlayBooks(DescribeAutomateResponseConfigPlayBooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutomateResponseConfigPlayBooksWithOptions(request, runtime);
        }

        public async Task<DescribeAutomateResponseConfigPlayBooksResponse> DescribeAutomateResponseConfigPlayBooksAsync(DescribeAutomateResponseConfigPlayBooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutomateResponseConfigPlayBooksWithOptionsAsync(request, runtime);
        }

        public DescribeCloudSiemAssetsResponse DescribeCloudSiemAssetsWithOptions(DescribeCloudSiemAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetType))
            {
                body["AssetType"] = request.AssetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudSiemAssets",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudSiemAssetsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCloudSiemAssetsResponse> DescribeCloudSiemAssetsWithOptionsAsync(DescribeCloudSiemAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetType))
            {
                body["AssetType"] = request.AssetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudSiemAssets",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudSiemAssetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCloudSiemAssetsResponse DescribeCloudSiemAssets(DescribeCloudSiemAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudSiemAssetsWithOptions(request, runtime);
        }

        public async Task<DescribeCloudSiemAssetsResponse> DescribeCloudSiemAssetsAsync(DescribeCloudSiemAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudSiemAssetsWithOptionsAsync(request, runtime);
        }

        public DescribeCloudSiemAssetsCounterResponse DescribeCloudSiemAssetsCounterWithOptions(DescribeCloudSiemAssetsCounterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudSiemAssetsCounter",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudSiemAssetsCounterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCloudSiemAssetsCounterResponse> DescribeCloudSiemAssetsCounterWithOptionsAsync(DescribeCloudSiemAssetsCounterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudSiemAssetsCounter",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudSiemAssetsCounterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCloudSiemAssetsCounterResponse DescribeCloudSiemAssetsCounter(DescribeCloudSiemAssetsCounterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudSiemAssetsCounterWithOptions(request, runtime);
        }

        public async Task<DescribeCloudSiemAssetsCounterResponse> DescribeCloudSiemAssetsCounterAsync(DescribeCloudSiemAssetsCounterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudSiemAssetsCounterWithOptionsAsync(request, runtime);
        }

        public DescribeCloudSiemEventDetailResponse DescribeCloudSiemEventDetailWithOptions(DescribeCloudSiemEventDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudSiemEventDetail",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudSiemEventDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCloudSiemEventDetailResponse> DescribeCloudSiemEventDetailWithOptionsAsync(DescribeCloudSiemEventDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudSiemEventDetail",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudSiemEventDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCloudSiemEventDetailResponse DescribeCloudSiemEventDetail(DescribeCloudSiemEventDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudSiemEventDetailWithOptions(request, runtime);
        }

        public async Task<DescribeCloudSiemEventDetailResponse> DescribeCloudSiemEventDetailAsync(DescribeCloudSiemEventDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudSiemEventDetailWithOptionsAsync(request, runtime);
        }

        public DescribeCloudSiemEventsResponse DescribeCloudSiemEventsWithOptions(DescribeCloudSiemEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetId))
            {
                body["AssetId"] = request.AssetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                body["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadLevel))
            {
                body["ThreadLevel"] = request.ThreadLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudSiemEvents",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudSiemEventsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCloudSiemEventsResponse> DescribeCloudSiemEventsWithOptionsAsync(DescribeCloudSiemEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetId))
            {
                body["AssetId"] = request.AssetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                body["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadLevel))
            {
                body["ThreadLevel"] = request.ThreadLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudSiemEvents",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudSiemEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCloudSiemEventsResponse DescribeCloudSiemEvents(DescribeCloudSiemEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudSiemEventsWithOptions(request, runtime);
        }

        public async Task<DescribeCloudSiemEventsResponse> DescribeCloudSiemEventsAsync(DescribeCloudSiemEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudSiemEventsWithOptionsAsync(request, runtime);
        }

        public DescribeCsImportedProdStatusByUserResponse DescribeCsImportedProdStatusByUserWithOptions(DescribeCsImportedProdStatusByUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLogProd))
            {
                body["SourceLogProd"] = request.SourceLogProd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCsImportedProdStatusByUser",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCsImportedProdStatusByUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCsImportedProdStatusByUserResponse> DescribeCsImportedProdStatusByUserWithOptionsAsync(DescribeCsImportedProdStatusByUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLogProd))
            {
                body["SourceLogProd"] = request.SourceLogProd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCsImportedProdStatusByUser",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCsImportedProdStatusByUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCsImportedProdStatusByUserResponse DescribeCsImportedProdStatusByUser(DescribeCsImportedProdStatusByUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCsImportedProdStatusByUserWithOptions(request, runtime);
        }

        public async Task<DescribeCsImportedProdStatusByUserResponse> DescribeCsImportedProdStatusByUserAsync(DescribeCsImportedProdStatusByUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCsImportedProdStatusByUserWithOptionsAsync(request, runtime);
        }

        public DescribeCustomizeRuleResponse DescribeCustomizeRuleWithOptions(DescribeCustomizeRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomizeRule",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomizeRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCustomizeRuleResponse> DescribeCustomizeRuleWithOptionsAsync(DescribeCustomizeRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomizeRule",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomizeRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCustomizeRuleResponse DescribeCustomizeRule(DescribeCustomizeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomizeRuleWithOptions(request, runtime);
        }

        public async Task<DescribeCustomizeRuleResponse> DescribeCustomizeRuleAsync(DescribeCustomizeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomizeRuleWithOptionsAsync(request, runtime);
        }

        public DescribeCustomizeRuleCountResponse DescribeCustomizeRuleCountWithOptions(DescribeCustomizeRuleCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomizeRuleCount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomizeRuleCountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCustomizeRuleCountResponse> DescribeCustomizeRuleCountWithOptionsAsync(DescribeCustomizeRuleCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomizeRuleCount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomizeRuleCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCustomizeRuleCountResponse DescribeCustomizeRuleCount(DescribeCustomizeRuleCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomizeRuleCountWithOptions(request, runtime);
        }

        public async Task<DescribeCustomizeRuleCountResponse> DescribeCustomizeRuleCountAsync(DescribeCustomizeRuleCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomizeRuleCountWithOptionsAsync(request, runtime);
        }

        public DescribeCustomizeRuleTestResponse DescribeCustomizeRuleTestWithOptions(DescribeCustomizeRuleTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomizeRuleTest",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomizeRuleTestResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCustomizeRuleTestResponse> DescribeCustomizeRuleTestWithOptionsAsync(DescribeCustomizeRuleTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomizeRuleTest",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomizeRuleTestResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCustomizeRuleTestResponse DescribeCustomizeRuleTest(DescribeCustomizeRuleTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomizeRuleTestWithOptions(request, runtime);
        }

        public async Task<DescribeCustomizeRuleTestResponse> DescribeCustomizeRuleTestAsync(DescribeCustomizeRuleTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomizeRuleTestWithOptionsAsync(request, runtime);
        }

        public DescribeCustomizeRuleTestHistogramResponse DescribeCustomizeRuleTestHistogramWithOptions(DescribeCustomizeRuleTestHistogramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomizeRuleTestHistogram",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomizeRuleTestHistogramResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCustomizeRuleTestHistogramResponse> DescribeCustomizeRuleTestHistogramWithOptionsAsync(DescribeCustomizeRuleTestHistogramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomizeRuleTestHistogram",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomizeRuleTestHistogramResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCustomizeRuleTestHistogramResponse DescribeCustomizeRuleTestHistogram(DescribeCustomizeRuleTestHistogramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomizeRuleTestHistogramWithOptions(request, runtime);
        }

        public async Task<DescribeCustomizeRuleTestHistogramResponse> DescribeCustomizeRuleTestHistogramAsync(DescribeCustomizeRuleTestHistogramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomizeRuleTestHistogramWithOptionsAsync(request, runtime);
        }

        public DescribeDataSourceInstanceResponse DescribeDataSourceInstanceWithOptions(DescribeDataSourceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataSourceInstance",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataSourceInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDataSourceInstanceResponse> DescribeDataSourceInstanceWithOptionsAsync(DescribeDataSourceInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataSourceInstance",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataSourceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDataSourceInstanceResponse DescribeDataSourceInstance(DescribeDataSourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataSourceInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeDataSourceInstanceResponse> DescribeDataSourceInstanceAsync(DescribeDataSourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataSourceInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeDataSourceParametersResponse DescribeDataSourceParametersWithOptions(DescribeDataSourceParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataSourceParameters",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataSourceParametersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDataSourceParametersResponse> DescribeDataSourceParametersWithOptionsAsync(DescribeDataSourceParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataSourceParameters",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataSourceParametersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDataSourceParametersResponse DescribeDataSourceParameters(DescribeDataSourceParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataSourceParametersWithOptions(request, runtime);
        }

        public async Task<DescribeDataSourceParametersResponse> DescribeDataSourceParametersAsync(DescribeDataSourceParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataSourceParametersWithOptionsAsync(request, runtime);
        }

        public DescribeDisposeAndPlaybookResponse DescribeDisposeAndPlaybookWithOptions(DescribeDisposeAndPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                body["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDisposeAndPlaybook",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDisposeAndPlaybookResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDisposeAndPlaybookResponse> DescribeDisposeAndPlaybookWithOptionsAsync(DescribeDisposeAndPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                body["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDisposeAndPlaybook",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDisposeAndPlaybookResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDisposeAndPlaybookResponse DescribeDisposeAndPlaybook(DescribeDisposeAndPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDisposeAndPlaybookWithOptions(request, runtime);
        }

        public async Task<DescribeDisposeAndPlaybookResponse> DescribeDisposeAndPlaybookAsync(DescribeDisposeAndPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDisposeAndPlaybookWithOptionsAsync(request, runtime);
        }

        public DescribeDisposeStrategyPlaybookResponse DescribeDisposeStrategyPlaybookWithOptions(DescribeDisposeStrategyPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
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
                Action = "DescribeDisposeStrategyPlaybook",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDisposeStrategyPlaybookResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDisposeStrategyPlaybookResponse> DescribeDisposeStrategyPlaybookWithOptionsAsync(DescribeDisposeStrategyPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
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
                Action = "DescribeDisposeStrategyPlaybook",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDisposeStrategyPlaybookResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDisposeStrategyPlaybookResponse DescribeDisposeStrategyPlaybook(DescribeDisposeStrategyPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDisposeStrategyPlaybookWithOptions(request, runtime);
        }

        public async Task<DescribeDisposeStrategyPlaybookResponse> DescribeDisposeStrategyPlaybookAsync(DescribeDisposeStrategyPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDisposeStrategyPlaybookWithOptionsAsync(request, runtime);
        }

        public DescribeEntityInfoResponse DescribeEntityInfoWithOptions(DescribeEntityInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                body["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityIdentity))
            {
                body["EntityIdentity"] = request.EntityIdentity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SophonTaskId))
            {
                body["SophonTaskId"] = request.SophonTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEntityInfo",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEntityInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeEntityInfoResponse> DescribeEntityInfoWithOptionsAsync(DescribeEntityInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                body["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityIdentity))
            {
                body["EntityIdentity"] = request.EntityIdentity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SophonTaskId))
            {
                body["SophonTaskId"] = request.SophonTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEntityInfo",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEntityInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeEntityInfoResponse DescribeEntityInfo(DescribeEntityInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEntityInfoWithOptions(request, runtime);
        }

        public async Task<DescribeEntityInfoResponse> DescribeEntityInfoAsync(DescribeEntityInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEntityInfoWithOptionsAsync(request, runtime);
        }

        public DescribeEventCountByThreatLevelResponse DescribeEventCountByThreatLevelWithOptions(DescribeEventCountByThreatLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
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
                Action = "DescribeEventCountByThreatLevel",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventCountByThreatLevelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeEventCountByThreatLevelResponse> DescribeEventCountByThreatLevelWithOptionsAsync(DescribeEventCountByThreatLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
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
                Action = "DescribeEventCountByThreatLevel",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventCountByThreatLevelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeEventCountByThreatLevelResponse DescribeEventCountByThreatLevel(DescribeEventCountByThreatLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEventCountByThreatLevelWithOptions(request, runtime);
        }

        public async Task<DescribeEventCountByThreatLevelResponse> DescribeEventCountByThreatLevelAsync(DescribeEventCountByThreatLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEventCountByThreatLevelWithOptionsAsync(request, runtime);
        }

        public DescribeEventDisposeResponse DescribeEventDisposeWithOptions(DescribeEventDisposeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEventDispose",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventDisposeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeEventDisposeResponse> DescribeEventDisposeWithOptionsAsync(DescribeEventDisposeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEventDispose",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventDisposeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeEventDisposeResponse DescribeEventDispose(DescribeEventDisposeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEventDisposeWithOptions(request, runtime);
        }

        public async Task<DescribeEventDisposeResponse> DescribeEventDisposeAsync(DescribeEventDisposeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEventDisposeWithOptionsAsync(request, runtime);
        }

        public DescribeImportedLogCountResponse DescribeImportedLogCountWithOptions(DescribeImportedLogCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeImportedLogCount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeImportedLogCountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeImportedLogCountResponse> DescribeImportedLogCountWithOptionsAsync(DescribeImportedLogCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeImportedLogCount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeImportedLogCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeImportedLogCountResponse DescribeImportedLogCount(DescribeImportedLogCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImportedLogCountWithOptions(request, runtime);
        }

        public async Task<DescribeImportedLogCountResponse> DescribeImportedLogCountAsync(DescribeImportedLogCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImportedLogCountWithOptionsAsync(request, runtime);
        }

        public DescribeJobStatusResponse DescribeJobStatusWithOptions(DescribeJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitId))
            {
                body["SubmitId"] = request.SubmitId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJobStatus",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeJobStatusResponse> DescribeJobStatusWithOptionsAsync(DescribeJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitId))
            {
                body["SubmitId"] = request.SubmitId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJobStatus",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeJobStatusResponse DescribeJobStatus(DescribeJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeJobStatusWithOptions(request, runtime);
        }

        public async Task<DescribeJobStatusResponse> DescribeJobStatusAsync(DescribeJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeJobStatusWithOptionsAsync(request, runtime);
        }

        public DescribeLogFieldsResponse DescribeLogFieldsWithOptions(DescribeLogFieldsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSource))
            {
                body["LogSource"] = request.LogSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                body["LogType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogFields",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogFieldsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeLogFieldsResponse> DescribeLogFieldsWithOptionsAsync(DescribeLogFieldsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSource))
            {
                body["LogSource"] = request.LogSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                body["LogType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogFields",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogFieldsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeLogFieldsResponse DescribeLogFields(DescribeLogFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLogFieldsWithOptions(request, runtime);
        }

        public async Task<DescribeLogFieldsResponse> DescribeLogFieldsAsync(DescribeLogFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLogFieldsWithOptionsAsync(request, runtime);
        }

        public DescribeLogSourceResponse DescribeLogSourceWithOptions(DescribeLogSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                body["LogType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogSource",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogSourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeLogSourceResponse> DescribeLogSourceWithOptionsAsync(DescribeLogSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                body["LogType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogSource",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeLogSourceResponse DescribeLogSource(DescribeLogSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLogSourceWithOptions(request, runtime);
        }

        public async Task<DescribeLogSourceResponse> DescribeLogSourceAsync(DescribeLogSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLogSourceWithOptionsAsync(request, runtime);
        }

        public DescribeLogStoreResponse DescribeLogStoreWithOptions(DescribeLogStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogStore",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogStoreResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeLogStoreResponse> DescribeLogStoreWithOptionsAsync(DescribeLogStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogStore",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeLogStoreResponse DescribeLogStore(DescribeLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLogStoreWithOptions(request, runtime);
        }

        public async Task<DescribeLogStoreResponse> DescribeLogStoreAsync(DescribeLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLogStoreWithOptionsAsync(request, runtime);
        }

        public DescribeLogTypeResponse DescribeLogTypeWithOptions(DescribeLogTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogType",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogTypeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeLogTypeResponse> DescribeLogTypeWithOptionsAsync(DescribeLogTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLogType",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLogTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeLogTypeResponse DescribeLogType(DescribeLogTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLogTypeWithOptions(request, runtime);
        }

        public async Task<DescribeLogTypeResponse> DescribeLogTypeAsync(DescribeLogTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLogTypeWithOptionsAsync(request, runtime);
        }

        public DescribeOperatorsResponse DescribeOperatorsWithOptions(DescribeOperatorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                body["SceneType"] = request.SceneType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOperators",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOperatorsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeOperatorsResponse> DescribeOperatorsWithOptionsAsync(DescribeOperatorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                body["SceneType"] = request.SceneType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOperators",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOperatorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeOperatorsResponse DescribeOperators(DescribeOperatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOperatorsWithOptions(request, runtime);
        }

        public async Task<DescribeOperatorsResponse> DescribeOperatorsAsync(DescribeOperatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOperatorsWithOptionsAsync(request, runtime);
        }

        public DescribeProdCountResponse DescribeProdCountWithOptions(DescribeProdCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProdCount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProdCountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeProdCountResponse> DescribeProdCountWithOptionsAsync(DescribeProdCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProdCount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProdCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeProdCountResponse DescribeProdCount(DescribeProdCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProdCountWithOptions(request, runtime);
        }

        public async Task<DescribeProdCountResponse> DescribeProdCountAsync(DescribeProdCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProdCountWithOptionsAsync(request, runtime);
        }

        public DescribeScopeUsersResponse DescribeScopeUsersWithOptions(DescribeScopeUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScopeUsers",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScopeUsersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeScopeUsersResponse> DescribeScopeUsersWithOptionsAsync(DescribeScopeUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScopeUsers",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScopeUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeScopeUsersResponse DescribeScopeUsers(DescribeScopeUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScopeUsersWithOptions(request, runtime);
        }

        public async Task<DescribeScopeUsersResponse> DescribeScopeUsersAsync(DescribeScopeUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScopeUsersWithOptionsAsync(request, runtime);
        }

        public DescribeServiceStatusResponse DescribeServiceStatusWithOptions(DescribeServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceStatus",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeServiceStatusResponse> DescribeServiceStatusWithOptionsAsync(DescribeServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceStatus",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeServiceStatusResponse DescribeServiceStatus(DescribeServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServiceStatusWithOptions(request, runtime);
        }

        public async Task<DescribeServiceStatusResponse> DescribeServiceStatusAsync(DescribeServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServiceStatusWithOptionsAsync(request, runtime);
        }

        public DescribeStorageResponse DescribeStorageWithOptions(DescribeStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStorage",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStorageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeStorageResponse> DescribeStorageWithOptionsAsync(DescribeStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeStorage",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeStorageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeStorageResponse DescribeStorage(DescribeStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStorageWithOptions(request, runtime);
        }

        public async Task<DescribeStorageResponse> DescribeStorageAsync(DescribeStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStorageWithOptionsAsync(request, runtime);
        }

        public DescribeUserBuyStatusResponse DescribeUserBuyStatusWithOptions(DescribeUserBuyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserBuyStatus",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserBuyStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeUserBuyStatusResponse> DescribeUserBuyStatusWithOptionsAsync(DescribeUserBuyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserBuyStatus",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserBuyStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeUserBuyStatusResponse DescribeUserBuyStatus(DescribeUserBuyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserBuyStatusWithOptions(request, runtime);
        }

        public async Task<DescribeUserBuyStatusResponse> DescribeUserBuyStatusAsync(DescribeUserBuyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserBuyStatusWithOptionsAsync(request, runtime);
        }

        public DescribeWafScopeResponse DescribeWafScopeWithOptions(DescribeWafScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                body["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWafScope",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWafScopeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeWafScopeResponse> DescribeWafScopeWithOptionsAsync(DescribeWafScopeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                body["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWafScope",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWafScopeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeWafScopeResponse DescribeWafScope(DescribeWafScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWafScopeWithOptions(request, runtime);
        }

        public async Task<DescribeWafScopeResponse> DescribeWafScopeAsync(DescribeWafScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWafScopeWithOptionsAsync(request, runtime);
        }

        public DescribeWhiteRuleListResponse DescribeWhiteRuleListWithOptions(DescribeWhiteRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertName))
            {
                body["AlertName"] = request.AlertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWhiteRuleList",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWhiteRuleListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeWhiteRuleListResponse> DescribeWhiteRuleListWithOptionsAsync(DescribeWhiteRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertName))
            {
                body["AlertName"] = request.AlertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWhiteRuleList",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWhiteRuleListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeWhiteRuleListResponse DescribeWhiteRuleList(DescribeWhiteRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWhiteRuleListWithOptions(request, runtime);
        }

        public async Task<DescribeWhiteRuleListResponse> DescribeWhiteRuleListAsync(DescribeWhiteRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWhiteRuleListWithOptionsAsync(request, runtime);
        }

        public DoQuickFieldResponse DoQuickFieldWithOptions(DoQuickFieldRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Index))
            {
                body["Index"] = request.Index;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                body["Reverse"] = request.Reverse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["To"] = request.To;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DoQuickField",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DoQuickFieldResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DoQuickFieldResponse> DoQuickFieldWithOptionsAsync(DoQuickFieldRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Index))
            {
                body["Index"] = request.Index;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                body["Reverse"] = request.Reverse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["To"] = request.To;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DoQuickField",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DoQuickFieldResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DoQuickFieldResponse DoQuickField(DoQuickFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DoQuickFieldWithOptions(request, runtime);
        }

        public async Task<DoQuickFieldResponse> DoQuickFieldAsync(DoQuickFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DoQuickFieldWithOptionsAsync(request, runtime);
        }

        public DoSelfDelegateResponse DoSelfDelegateWithOptions(DoSelfDelegateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                body["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelegateOrNot))
            {
                body["DelegateOrNot"] = request.DelegateOrNot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DoSelfDelegate",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DoSelfDelegateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DoSelfDelegateResponse> DoSelfDelegateWithOptionsAsync(DoSelfDelegateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                body["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelegateOrNot))
            {
                body["DelegateOrNot"] = request.DelegateOrNot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DoSelfDelegate",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DoSelfDelegateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DoSelfDelegateResponse DoSelfDelegate(DoSelfDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DoSelfDelegateWithOptions(request, runtime);
        }

        public async Task<DoSelfDelegateResponse> DoSelfDelegateAsync(DoSelfDelegateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DoSelfDelegateWithOptionsAsync(request, runtime);
        }

        public EnableAccessForCloudSiemResponse EnableAccessForCloudSiemWithOptions(EnableAccessForCloudSiemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSubmit))
            {
                body["AutoSubmit"] = request.AutoSubmit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableAccessForCloudSiem",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableAccessForCloudSiemResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableAccessForCloudSiemResponse> EnableAccessForCloudSiemWithOptionsAsync(EnableAccessForCloudSiemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSubmit))
            {
                body["AutoSubmit"] = request.AutoSubmit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableAccessForCloudSiem",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableAccessForCloudSiemResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableAccessForCloudSiemResponse EnableAccessForCloudSiem(EnableAccessForCloudSiemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableAccessForCloudSiemWithOptions(request, runtime);
        }

        public async Task<EnableAccessForCloudSiemResponse> EnableAccessForCloudSiemAsync(EnableAccessForCloudSiemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableAccessForCloudSiemWithOptionsAsync(request, runtime);
        }

        public EnableServiceForCloudSiemResponse EnableServiceForCloudSiemWithOptions(EnableServiceForCloudSiemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableServiceForCloudSiem",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableServiceForCloudSiemResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableServiceForCloudSiemResponse> EnableServiceForCloudSiemWithOptionsAsync(EnableServiceForCloudSiemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableServiceForCloudSiem",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableServiceForCloudSiemResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableServiceForCloudSiemResponse EnableServiceForCloudSiem(EnableServiceForCloudSiemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableServiceForCloudSiemWithOptions(request, runtime);
        }

        public async Task<EnableServiceForCloudSiemResponse> EnableServiceForCloudSiemAsync(EnableServiceForCloudSiemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableServiceForCloudSiemWithOptionsAsync(request, runtime);
        }

        public GetCapacityResponse GetCapacityWithOptions(GetCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCapacity",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCapacityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCapacityResponse> GetCapacityWithOptionsAsync(GetCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCapacity",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCapacityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetCapacityResponse GetCapacity(GetCapacityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCapacityWithOptions(request, runtime);
        }

        public async Task<GetCapacityResponse> GetCapacityAsync(GetCapacityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCapacityWithOptionsAsync(request, runtime);
        }

        public GetHistogramsResponse GetHistogramsWithOptions(GetHistogramsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["To"] = request.To;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHistograms",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHistogramsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetHistogramsResponse> GetHistogramsWithOptionsAsync(GetHistogramsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["To"] = request.To;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHistograms",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHistogramsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetHistogramsResponse GetHistograms(GetHistogramsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHistogramsWithOptions(request, runtime);
        }

        public async Task<GetHistogramsResponse> GetHistogramsAsync(GetHistogramsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHistogramsWithOptionsAsync(request, runtime);
        }

        public GetLogsResponse GetLogsWithOptions(GetLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReverseOrNot))
            {
                body["ReverseOrNot"] = request.ReverseOrNot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["To"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Total))
            {
                body["Total"] = request.Total;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLogs",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetLogsResponse> GetLogsWithOptionsAsync(GetLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                body["PageIndex"] = request.PageIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReverseOrNot))
            {
                body["ReverseOrNot"] = request.ReverseOrNot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["To"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Total))
            {
                body["Total"] = request.Total;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLogs",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetLogsResponse GetLogs(GetLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLogsWithOptions(request, runtime);
        }

        public async Task<GetLogsResponse> GetLogsAsync(GetLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLogsWithOptionsAsync(request, runtime);
        }

        public GetQuickQueryResponse GetQuickQueryWithOptions(GetQuickQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchName))
            {
                body["SearchName"] = request.SearchName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuickQuery",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuickQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetQuickQueryResponse> GetQuickQueryWithOptionsAsync(GetQuickQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchName))
            {
                body["SearchName"] = request.SearchName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuickQuery",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuickQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetQuickQueryResponse GetQuickQuery(GetQuickQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQuickQueryWithOptions(request, runtime);
        }

        public async Task<GetQuickQueryResponse> GetQuickQueryAsync(GetQuickQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQuickQueryWithOptionsAsync(request, runtime);
        }

        public GetStorageResponse GetStorageWithOptions(GetStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStorage",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStorageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetStorageResponse> GetStorageWithOptionsAsync(GetStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStorage",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStorageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetStorageResponse GetStorage(GetStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStorageWithOptions(request, runtime);
        }

        public async Task<GetStorageResponse> GetStorageAsync(GetStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStorageWithOptionsAsync(request, runtime);
        }

        public ListAccountAccessIdResponse ListAccountAccessIdWithOptions(ListAccountAccessIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccountAccessId",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccountAccessIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAccountAccessIdResponse> ListAccountAccessIdWithOptionsAsync(ListAccountAccessIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccountAccessId",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccountAccessIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAccountAccessIdResponse ListAccountAccessId(ListAccountAccessIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccountAccessIdWithOptions(request, runtime);
        }

        public async Task<ListAccountAccessIdResponse> ListAccountAccessIdAsync(ListAccountAccessIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccountAccessIdWithOptionsAsync(request, runtime);
        }

        public ListAccountsByLogResponse ListAccountsByLogWithOptions(ListAccountsByLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCodes))
            {
                body["LogCodes"] = request.LogCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                body["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccountsByLog",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccountsByLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAccountsByLogResponse> ListAccountsByLogWithOptionsAsync(ListAccountsByLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCodes))
            {
                body["LogCodes"] = request.LogCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                body["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccountsByLog",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccountsByLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAccountsByLogResponse ListAccountsByLog(ListAccountsByLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccountsByLogWithOptions(request, runtime);
        }

        public async Task<ListAccountsByLogResponse> ListAccountsByLogAsync(ListAccountsByLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccountsByLogWithOptionsAsync(request, runtime);
        }

        public ListAllProdsResponse ListAllProdsWithOptions(ListAllProdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAllProds",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllProdsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAllProdsResponse> ListAllProdsWithOptionsAsync(ListAllProdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAllProds",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllProdsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAllProdsResponse ListAllProds(ListAllProdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAllProdsWithOptions(request, runtime);
        }

        public async Task<ListAllProdsResponse> ListAllProdsAsync(ListAllProdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAllProdsWithOptionsAsync(request, runtime);
        }

        public ListAutomateResponseConfigsResponse ListAutomateResponseConfigsWithOptions(ListAutomateResponseConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                body["ActionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoResponseType))
            {
                body["AutoResponseType"] = request.AutoResponseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAutomateResponseConfigs",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAutomateResponseConfigsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAutomateResponseConfigsResponse> ListAutomateResponseConfigsWithOptionsAsync(ListAutomateResponseConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                body["ActionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoResponseType))
            {
                body["AutoResponseType"] = request.AutoResponseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAutomateResponseConfigs",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAutomateResponseConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAutomateResponseConfigsResponse ListAutomateResponseConfigs(ListAutomateResponseConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAutomateResponseConfigsWithOptions(request, runtime);
        }

        public async Task<ListAutomateResponseConfigsResponse> ListAutomateResponseConfigsAsync(ListAutomateResponseConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAutomateResponseConfigsWithOptionsAsync(request, runtime);
        }

        public ListBindAccountResponse ListBindAccountWithOptions(ListBindAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBindAccount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBindAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListBindAccountResponse> ListBindAccountWithOptionsAsync(ListBindAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBindAccount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBindAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListBindAccountResponse ListBindAccount(ListBindAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBindAccountWithOptions(request, runtime);
        }

        public async Task<ListBindAccountResponse> ListBindAccountAsync(ListBindAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBindAccountWithOptionsAsync(request, runtime);
        }

        public ListBindDataSourcesResponse ListBindDataSourcesWithOptions(ListBindDataSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBindDataSources",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBindDataSourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListBindDataSourcesResponse> ListBindDataSourcesWithOptionsAsync(ListBindDataSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBindDataSources",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBindDataSourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListBindDataSourcesResponse ListBindDataSources(ListBindDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBindDataSourcesWithOptions(request, runtime);
        }

        public async Task<ListBindDataSourcesResponse> ListBindDataSourcesAsync(ListBindDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBindDataSourcesWithOptionsAsync(request, runtime);
        }

        public ListCloudSiemCustomizeRulesResponse ListCloudSiemCustomizeRulesWithOptions(ListCloudSiemCustomizeRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatLevel))
            {
                body["ThreatLevel"] = request.ThreatLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCloudSiemCustomizeRules",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCloudSiemCustomizeRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListCloudSiemCustomizeRulesResponse> ListCloudSiemCustomizeRulesWithOptionsAsync(ListCloudSiemCustomizeRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatLevel))
            {
                body["ThreatLevel"] = request.ThreatLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCloudSiemCustomizeRules",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCloudSiemCustomizeRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListCloudSiemCustomizeRulesResponse ListCloudSiemCustomizeRules(ListCloudSiemCustomizeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCloudSiemCustomizeRulesWithOptions(request, runtime);
        }

        public async Task<ListCloudSiemCustomizeRulesResponse> ListCloudSiemCustomizeRulesAsync(ListCloudSiemCustomizeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCloudSiemCustomizeRulesWithOptionsAsync(request, runtime);
        }

        public ListCloudSiemPredefinedRulesResponse ListCloudSiemPredefinedRulesWithOptions(ListCloudSiemPredefinedRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttCk))
            {
                body["AttCk"] = request.AttCk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTransferType))
            {
                body["EventTransferType"] = request.EventTransferType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSource))
            {
                body["LogSource"] = request.LogSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatLevel))
            {
                body["ThreatLevel"] = request.ThreatLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCloudSiemPredefinedRules",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCloudSiemPredefinedRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListCloudSiemPredefinedRulesResponse> ListCloudSiemPredefinedRulesWithOptionsAsync(ListCloudSiemPredefinedRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttCk))
            {
                body["AttCk"] = request.AttCk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTransferType))
            {
                body["EventTransferType"] = request.EventTransferType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSource))
            {
                body["LogSource"] = request.LogSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatLevel))
            {
                body["ThreatLevel"] = request.ThreatLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCloudSiemPredefinedRules",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCloudSiemPredefinedRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListCloudSiemPredefinedRulesResponse ListCloudSiemPredefinedRules(ListCloudSiemPredefinedRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCloudSiemPredefinedRulesWithOptions(request, runtime);
        }

        public async Task<ListCloudSiemPredefinedRulesResponse> ListCloudSiemPredefinedRulesAsync(ListCloudSiemPredefinedRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCloudSiemPredefinedRulesWithOptionsAsync(request, runtime);
        }

        public ListCustomizeRuleTestResultResponse ListCustomizeRuleTestResultWithOptions(ListCustomizeRuleTestResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCustomizeRuleTestResult",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomizeRuleTestResultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListCustomizeRuleTestResultResponse> ListCustomizeRuleTestResultWithOptionsAsync(ListCustomizeRuleTestResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCustomizeRuleTestResult",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomizeRuleTestResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListCustomizeRuleTestResultResponse ListCustomizeRuleTestResult(ListCustomizeRuleTestResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCustomizeRuleTestResultWithOptions(request, runtime);
        }

        public async Task<ListCustomizeRuleTestResultResponse> ListCustomizeRuleTestResultAsync(ListCustomizeRuleTestResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCustomizeRuleTestResultWithOptionsAsync(request, runtime);
        }

        public ListDataSourceLogsResponse ListDataSourceLogsWithOptions(ListDataSourceLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSourceLogs",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDataSourceLogsResponse> ListDataSourceLogsWithOptionsAsync(ListDataSourceLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSourceLogs",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDataSourceLogsResponse ListDataSourceLogs(ListDataSourceLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataSourceLogsWithOptions(request, runtime);
        }

        public async Task<ListDataSourceLogsResponse> ListDataSourceLogsAsync(ListDataSourceLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataSourceLogsWithOptionsAsync(request, runtime);
        }

        public ListDataSourceTypesResponse ListDataSourceTypesWithOptions(ListDataSourceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSourceTypes",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceTypesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDataSourceTypesResponse> ListDataSourceTypesWithOptionsAsync(ListDataSourceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSourceTypes",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceTypesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDataSourceTypesResponse ListDataSourceTypes(ListDataSourceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataSourceTypesWithOptions(request, runtime);
        }

        public async Task<ListDataSourceTypesResponse> ListDataSourceTypesAsync(ListDataSourceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataSourceTypesWithOptionsAsync(request, runtime);
        }

        public ListDeliveryResponse ListDeliveryWithOptions(ListDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDelivery",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeliveryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDeliveryResponse> ListDeliveryWithOptionsAsync(ListDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDelivery",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeliveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDeliveryResponse ListDelivery(ListDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeliveryWithOptions(request, runtime);
        }

        public async Task<ListDeliveryResponse> ListDeliveryAsync(ListDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeliveryWithOptionsAsync(request, runtime);
        }

        public ListDisposeStrategyResponse ListDisposeStrategyWithOptions(ListDisposeStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveStatus))
            {
                body["EffectiveStatus"] = request.EffectiveStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityIdentity))
            {
                body["EntityIdentity"] = request.EntityIdentity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                body["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookName))
            {
                body["PlaybookName"] = request.PlaybookName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookTypes))
            {
                body["PlaybookTypes"] = request.PlaybookTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SophonTaskId))
            {
                body["SophonTaskId"] = request.SophonTaskId;
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
                Action = "ListDisposeStrategy",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDisposeStrategyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDisposeStrategyResponse> ListDisposeStrategyWithOptionsAsync(ListDisposeStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveStatus))
            {
                body["EffectiveStatus"] = request.EffectiveStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityIdentity))
            {
                body["EntityIdentity"] = request.EntityIdentity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                body["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookName))
            {
                body["PlaybookName"] = request.PlaybookName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookTypes))
            {
                body["PlaybookTypes"] = request.PlaybookTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SophonTaskId))
            {
                body["SophonTaskId"] = request.SophonTaskId;
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
                Action = "ListDisposeStrategy",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDisposeStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDisposeStrategyResponse ListDisposeStrategy(ListDisposeStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDisposeStrategyWithOptions(request, runtime);
        }

        public async Task<ListDisposeStrategyResponse> ListDisposeStrategyAsync(ListDisposeStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDisposeStrategyWithOptionsAsync(request, runtime);
        }

        public ListImportedLogsByProdResponse ListImportedLogsByProdWithOptions(ListImportedLogsByProdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                body["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListImportedLogsByProd",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImportedLogsByProdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListImportedLogsByProdResponse> ListImportedLogsByProdWithOptionsAsync(ListImportedLogsByProdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                body["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListImportedLogsByProd",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImportedLogsByProdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListImportedLogsByProdResponse ListImportedLogsByProd(ListImportedLogsByProdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListImportedLogsByProdWithOptions(request, runtime);
        }

        public async Task<ListImportedLogsByProdResponse> ListImportedLogsByProdAsync(ListImportedLogsByProdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListImportedLogsByProdWithOptionsAsync(request, runtime);
        }

        public ListOperationResponse ListOperationWithOptions(ListOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOperation",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOperationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListOperationResponse> ListOperationWithOptionsAsync(ListOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOperation",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOperationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListOperationResponse ListOperation(ListOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOperationWithOptions(request, runtime);
        }

        public async Task<ListOperationResponse> ListOperationAsync(ListOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOperationWithOptionsAsync(request, runtime);
        }

        public ListProjectLogStoresResponse ListProjectLogStoresWithOptions(ListProjectLogStoresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLogCode))
            {
                body["SourceLogCode"] = request.SourceLogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProdCode))
            {
                body["SourceProdCode"] = request.SourceProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjectLogStores",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectLogStoresResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListProjectLogStoresResponse> ListProjectLogStoresWithOptionsAsync(ListProjectLogStoresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLogCode))
            {
                body["SourceLogCode"] = request.SourceLogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProdCode))
            {
                body["SourceProdCode"] = request.SourceProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjectLogStores",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectLogStoresResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListProjectLogStoresResponse ListProjectLogStores(ListProjectLogStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectLogStoresWithOptions(request, runtime);
        }

        public async Task<ListProjectLogStoresResponse> ListProjectLogStoresAsync(ListProjectLogStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectLogStoresWithOptionsAsync(request, runtime);
        }

        public ListQuickQueryResponse ListQuickQueryWithOptions(ListQuickQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuickQuery",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuickQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListQuickQueryResponse> ListQuickQueryWithOptionsAsync(ListQuickQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuickQuery",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuickQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListQuickQueryResponse ListQuickQuery(ListQuickQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQuickQueryWithOptions(request, runtime);
        }

        public async Task<ListQuickQueryResponse> ListQuickQueryAsync(ListQuickQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQuickQueryWithOptionsAsync(request, runtime);
        }

        public ListRdUsersResponse ListRdUsersWithOptions(ListRdUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRdUsers",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRdUsersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRdUsersResponse> ListRdUsersWithOptionsAsync(ListRdUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRdUsers",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRdUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRdUsersResponse ListRdUsers(ListRdUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRdUsersWithOptions(request, runtime);
        }

        public async Task<ListRdUsersResponse> ListRdUsersAsync(ListRdUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRdUsersWithOptionsAsync(request, runtime);
        }

        public ListUserProdLogsResponse ListUserProdLogsWithOptions(ListUserProdLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLogCode))
            {
                body["SourceLogCode"] = request.SourceLogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProdCode))
            {
                body["SourceProdCode"] = request.SourceProdCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserProdLogs",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserProdLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListUserProdLogsResponse> ListUserProdLogsWithOptionsAsync(ListUserProdLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLogCode))
            {
                body["SourceLogCode"] = request.SourceLogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProdCode))
            {
                body["SourceProdCode"] = request.SourceProdCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserProdLogs",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserProdLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListUserProdLogsResponse ListUserProdLogs(ListUserProdLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserProdLogsWithOptions(request, runtime);
        }

        public async Task<ListUserProdLogsResponse> ListUserProdLogsAsync(ListUserProdLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserProdLogsWithOptionsAsync(request, runtime);
        }

        public ListUsersByProdResponse ListUsersByProdWithOptions(ListUsersByProdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProdCode))
            {
                body["SourceProdCode"] = request.SourceProdCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsersByProd",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersByProdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListUsersByProdResponse> ListUsersByProdWithOptionsAsync(ListUsersByProdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProdCode))
            {
                body["SourceProdCode"] = request.SourceProdCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsersByProd",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersByProdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListUsersByProdResponse ListUsersByProd(ListUsersByProdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersByProdWithOptions(request, runtime);
        }

        public async Task<ListUsersByProdResponse> ListUsersByProdAsync(ListUsersByProdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersByProdWithOptionsAsync(request, runtime);
        }

        public ModifyBindAccountResponse ModifyBindAccountWithOptions(ModifyBindAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessId))
            {
                body["AccessId"] = request.AccessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindId))
            {
                body["BindId"] = request.BindId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBindAccount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBindAccountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyBindAccountResponse> ModifyBindAccountWithOptionsAsync(ModifyBindAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessId))
            {
                body["AccessId"] = request.AccessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindId))
            {
                body["BindId"] = request.BindId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyBindAccount",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyBindAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyBindAccountResponse ModifyBindAccount(ModifyBindAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBindAccountWithOptions(request, runtime);
        }

        public async Task<ModifyBindAccountResponse> ModifyBindAccountAsync(ModifyBindAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBindAccountWithOptionsAsync(request, runtime);
        }

        public ModifyDataSourceResponse ModifyDataSourceWithOptions(ModifyDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceName))
            {
                body["DataSourceInstanceName"] = request.DataSourceInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceParams))
            {
                body["DataSourceInstanceParams"] = request.DataSourceInstanceParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceRemark))
            {
                body["DataSourceInstanceRemark"] = request.DataSourceInstanceRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDataSource",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDataSourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDataSourceResponse> ModifyDataSourceWithOptionsAsync(ModifyDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceName))
            {
                body["DataSourceInstanceName"] = request.DataSourceInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceParams))
            {
                body["DataSourceInstanceParams"] = request.DataSourceInstanceParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceRemark))
            {
                body["DataSourceInstanceRemark"] = request.DataSourceInstanceRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDataSource",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDataSourceResponse ModifyDataSource(ModifyDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDataSourceWithOptions(request, runtime);
        }

        public async Task<ModifyDataSourceResponse> ModifyDataSourceAsync(ModifyDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDataSourceWithOptionsAsync(request, runtime);
        }

        public ModifyDataSourceLogResponse ModifyDataSourceLogWithOptions(ModifyDataSourceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceLogs))
            {
                body["DataSourceInstanceLogs"] = request.DataSourceInstanceLogs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCode))
            {
                body["LogCode"] = request.LogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogInstanceId))
            {
                body["LogInstanceId"] = request.LogInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDataSourceLog",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDataSourceLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyDataSourceLogResponse> ModifyDataSourceLogWithOptionsAsync(ModifyDataSourceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceId))
            {
                body["DataSourceInstanceId"] = request.DataSourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceInstanceLogs))
            {
                body["DataSourceInstanceLogs"] = request.DataSourceInstanceLogs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceType))
            {
                body["DataSourceType"] = request.DataSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCode))
            {
                body["LogCode"] = request.LogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogInstanceId))
            {
                body["LogInstanceId"] = request.LogInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDataSourceLog",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDataSourceLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyDataSourceLogResponse ModifyDataSourceLog(ModifyDataSourceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDataSourceLogWithOptions(request, runtime);
        }

        public async Task<ModifyDataSourceLogResponse> ModifyDataSourceLogAsync(ModifyDataSourceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDataSourceLogWithOptionsAsync(request, runtime);
        }

        public OpenDeliveryResponse OpenDeliveryWithOptions(OpenDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCode))
            {
                body["LogCode"] = request.LogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenDelivery",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenDeliveryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<OpenDeliveryResponse> OpenDeliveryWithOptionsAsync(OpenDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCode))
            {
                body["LogCode"] = request.LogCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenDelivery",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenDeliveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public OpenDeliveryResponse OpenDelivery(OpenDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenDeliveryWithOptions(request, runtime);
        }

        public async Task<OpenDeliveryResponse> OpenDeliveryAsync(OpenDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenDeliveryWithOptionsAsync(request, runtime);
        }

        public PostAutomateResponseConfigResponse PostAutomateResponseConfigWithOptions(PostAutomateResponseConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionConfig))
            {
                body["ActionConfig"] = request.ActionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                body["ActionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoResponseType))
            {
                body["AutoResponseType"] = request.AutoResponseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionCondition))
            {
                body["ExecutionCondition"] = request.ExecutionCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostAutomateResponseConfig",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostAutomateResponseConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PostAutomateResponseConfigResponse> PostAutomateResponseConfigWithOptionsAsync(PostAutomateResponseConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionConfig))
            {
                body["ActionConfig"] = request.ActionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                body["ActionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoResponseType))
            {
                body["AutoResponseType"] = request.AutoResponseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionCondition))
            {
                body["ExecutionCondition"] = request.ExecutionCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                body["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostAutomateResponseConfig",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostAutomateResponseConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PostAutomateResponseConfigResponse PostAutomateResponseConfig(PostAutomateResponseConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PostAutomateResponseConfigWithOptions(request, runtime);
        }

        public async Task<PostAutomateResponseConfigResponse> PostAutomateResponseConfigAsync(PostAutomateResponseConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PostAutomateResponseConfigWithOptionsAsync(request, runtime);
        }

        public PostCustomizeRuleResponse PostCustomizeRuleWithOptions(PostCustomizeRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertTypeMds))
            {
                body["AlertTypeMds"] = request.AlertTypeMds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttCk))
            {
                body["AttCk"] = request.AttCk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTransferExt))
            {
                body["EventTransferExt"] = request.EventTransferExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTransferSwitch))
            {
                body["EventTransferSwitch"] = request.EventTransferSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTransferType))
            {
                body["EventTransferType"] = request.EventTransferType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSource))
            {
                body["LogSource"] = request.LogSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSourceMds))
            {
                body["LogSourceMds"] = request.LogSourceMds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                body["LogType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogTypeMds))
            {
                body["LogTypeMds"] = request.LogTypeMds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCycle))
            {
                body["QueryCycle"] = request.QueryCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleCondition))
            {
                body["RuleCondition"] = request.RuleCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleDesc))
            {
                body["RuleDesc"] = request.RuleDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleGroup))
            {
                body["RuleGroup"] = request.RuleGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleThreshold))
            {
                body["RuleThreshold"] = request.RuleThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatLevel))
            {
                body["ThreatLevel"] = request.ThreatLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostCustomizeRule",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostCustomizeRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PostCustomizeRuleResponse> PostCustomizeRuleWithOptionsAsync(PostCustomizeRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertType))
            {
                body["AlertType"] = request.AlertType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertTypeMds))
            {
                body["AlertTypeMds"] = request.AlertTypeMds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttCk))
            {
                body["AttCk"] = request.AttCk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTransferExt))
            {
                body["EventTransferExt"] = request.EventTransferExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTransferSwitch))
            {
                body["EventTransferSwitch"] = request.EventTransferSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTransferType))
            {
                body["EventTransferType"] = request.EventTransferType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSource))
            {
                body["LogSource"] = request.LogSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSourceMds))
            {
                body["LogSourceMds"] = request.LogSourceMds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                body["LogType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogTypeMds))
            {
                body["LogTypeMds"] = request.LogTypeMds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCycle))
            {
                body["QueryCycle"] = request.QueryCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleCondition))
            {
                body["RuleCondition"] = request.RuleCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleDesc))
            {
                body["RuleDesc"] = request.RuleDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleGroup))
            {
                body["RuleGroup"] = request.RuleGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                body["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleThreshold))
            {
                body["RuleThreshold"] = request.RuleThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatLevel))
            {
                body["ThreatLevel"] = request.ThreatLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostCustomizeRule",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostCustomizeRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PostCustomizeRuleResponse PostCustomizeRule(PostCustomizeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PostCustomizeRuleWithOptions(request, runtime);
        }

        public async Task<PostCustomizeRuleResponse> PostCustomizeRuleAsync(PostCustomizeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PostCustomizeRuleWithOptionsAsync(request, runtime);
        }

        public PostCustomizeRuleTestResponse PostCustomizeRuleTestWithOptions(PostCustomizeRuleTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimulatedData))
            {
                body["SimulatedData"] = request.SimulatedData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TestType))
            {
                body["TestType"] = request.TestType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostCustomizeRuleTest",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostCustomizeRuleTestResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PostCustomizeRuleTestResponse> PostCustomizeRuleTestWithOptionsAsync(PostCustomizeRuleTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimulatedData))
            {
                body["SimulatedData"] = request.SimulatedData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TestType))
            {
                body["TestType"] = request.TestType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostCustomizeRuleTest",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostCustomizeRuleTestResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PostCustomizeRuleTestResponse PostCustomizeRuleTest(PostCustomizeRuleTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PostCustomizeRuleTestWithOptions(request, runtime);
        }

        public async Task<PostCustomizeRuleTestResponse> PostCustomizeRuleTestAsync(PostCustomizeRuleTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PostCustomizeRuleTestWithOptionsAsync(request, runtime);
        }

        public PostEventDisposeAndWhiteruleListResponse PostEventDisposeAndWhiteruleListWithOptions(PostEventDisposeAndWhiteruleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventDispose))
            {
                body["EventDispose"] = request.EventDispose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverInfo))
            {
                body["ReceiverInfo"] = request.ReceiverInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
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
                Action = "PostEventDisposeAndWhiteruleList",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostEventDisposeAndWhiteruleListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PostEventDisposeAndWhiteruleListResponse> PostEventDisposeAndWhiteruleListWithOptionsAsync(PostEventDisposeAndWhiteruleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventDispose))
            {
                body["EventDispose"] = request.EventDispose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverInfo))
            {
                body["ReceiverInfo"] = request.ReceiverInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
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
                Action = "PostEventDisposeAndWhiteruleList",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostEventDisposeAndWhiteruleListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PostEventDisposeAndWhiteruleListResponse PostEventDisposeAndWhiteruleList(PostEventDisposeAndWhiteruleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PostEventDisposeAndWhiteruleListWithOptions(request, runtime);
        }

        public async Task<PostEventDisposeAndWhiteruleListResponse> PostEventDisposeAndWhiteruleListAsync(PostEventDisposeAndWhiteruleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PostEventDisposeAndWhiteruleListWithOptionsAsync(request, runtime);
        }

        public PostEventWhiteruleListResponse PostEventWhiteruleListWithOptions(PostEventWhiteruleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteruleList))
            {
                body["WhiteruleList"] = request.WhiteruleList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostEventWhiteruleList",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostEventWhiteruleListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PostEventWhiteruleListResponse> PostEventWhiteruleListWithOptionsAsync(PostEventWhiteruleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteruleList))
            {
                body["WhiteruleList"] = request.WhiteruleList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostEventWhiteruleList",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostEventWhiteruleListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PostEventWhiteruleListResponse PostEventWhiteruleList(PostEventWhiteruleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PostEventWhiteruleListWithOptions(request, runtime);
        }

        public async Task<PostEventWhiteruleListResponse> PostEventWhiteruleListAsync(PostEventWhiteruleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PostEventWhiteruleListWithOptionsAsync(request, runtime);
        }

        public PostFinishCustomizeRuleTestResponse PostFinishCustomizeRuleTestWithOptions(PostFinishCustomizeRuleTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostFinishCustomizeRuleTest",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostFinishCustomizeRuleTestResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PostFinishCustomizeRuleTestResponse> PostFinishCustomizeRuleTestWithOptionsAsync(PostFinishCustomizeRuleTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostFinishCustomizeRuleTest",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostFinishCustomizeRuleTestResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PostFinishCustomizeRuleTestResponse PostFinishCustomizeRuleTest(PostFinishCustomizeRuleTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PostFinishCustomizeRuleTestWithOptions(request, runtime);
        }

        public async Task<PostFinishCustomizeRuleTestResponse> PostFinishCustomizeRuleTestAsync(PostFinishCustomizeRuleTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PostFinishCustomizeRuleTestWithOptionsAsync(request, runtime);
        }

        public PostRuleStatusChangeResponse PostRuleStatusChangeWithOptions(PostRuleStatusChangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                body["Ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InUse))
            {
                body["InUse"] = request.InUse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostRuleStatusChange",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostRuleStatusChangeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PostRuleStatusChangeResponse> PostRuleStatusChangeWithOptionsAsync(PostRuleStatusChangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                body["Ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InUse))
            {
                body["InUse"] = request.InUse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PostRuleStatusChange",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PostRuleStatusChangeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PostRuleStatusChangeResponse PostRuleStatusChange(PostRuleStatusChangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PostRuleStatusChangeWithOptions(request, runtime);
        }

        public async Task<PostRuleStatusChangeResponse> PostRuleStatusChangeAsync(PostRuleStatusChangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PostRuleStatusChangeWithOptionsAsync(request, runtime);
        }

        public RestoreCapacityResponse RestoreCapacityWithOptions(RestoreCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestoreCapacity",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreCapacityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RestoreCapacityResponse> RestoreCapacityWithOptionsAsync(RestoreCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestoreCapacity",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreCapacityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RestoreCapacityResponse RestoreCapacity(RestoreCapacityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestoreCapacityWithOptions(request, runtime);
        }

        public async Task<RestoreCapacityResponse> RestoreCapacityAsync(RestoreCapacityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestoreCapacityWithOptionsAsync(request, runtime);
        }

        public SaveQuickQueryResponse SaveQuickQueryWithOptions(SaveQuickQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveQuickQuery",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveQuickQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveQuickQueryResponse> SaveQuickQueryWithOptionsAsync(SaveQuickQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveQuickQuery",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveQuickQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveQuickQueryResponse SaveQuickQuery(SaveQuickQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveQuickQueryWithOptions(request, runtime);
        }

        public async Task<SaveQuickQueryResponse> SaveQuickQueryAsync(SaveQuickQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveQuickQueryWithOptionsAsync(request, runtime);
        }

        public SetStorageResponse SetStorageWithOptions(SetStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                body["Ttl"] = request.Ttl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetStorage",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetStorageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetStorageResponse> SetStorageWithOptionsAsync(SetStorageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                body["Ttl"] = request.Ttl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetStorage",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetStorageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetStorageResponse SetStorage(SetStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetStorageWithOptions(request, runtime);
        }

        public async Task<SetStorageResponse> SetStorageAsync(SetStorageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetStorageWithOptionsAsync(request, runtime);
        }

        public ShowQuickAnalysisResponse ShowQuickAnalysisWithOptions(ShowQuickAnalysisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ShowQuickAnalysis",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ShowQuickAnalysisResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ShowQuickAnalysisResponse> ShowQuickAnalysisWithOptionsAsync(ShowQuickAnalysisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ShowQuickAnalysis",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ShowQuickAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ShowQuickAnalysisResponse ShowQuickAnalysis(ShowQuickAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ShowQuickAnalysisWithOptions(request, runtime);
        }

        public async Task<ShowQuickAnalysisResponse> ShowQuickAnalysisAsync(ShowQuickAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ShowQuickAnalysisWithOptionsAsync(request, runtime);
        }

        public SubmitImportLogTasksResponse SubmitImportLogTasksWithOptions(SubmitImportLogTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accounts))
            {
                body["Accounts"] = request.Accounts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoImported))
            {
                body["AutoImported"] = request.AutoImported;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCodes))
            {
                body["LogCodes"] = request.LogCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                body["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitImportLogTasks",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitImportLogTasksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitImportLogTasksResponse> SubmitImportLogTasksWithOptionsAsync(SubmitImportLogTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accounts))
            {
                body["Accounts"] = request.Accounts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoImported))
            {
                body["AutoImported"] = request.AutoImported;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudCode))
            {
                body["CloudCode"] = request.CloudCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogCodes))
            {
                body["LogCodes"] = request.LogCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                body["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitImportLogTasks",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitImportLogTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitImportLogTasksResponse SubmitImportLogTasks(SubmitImportLogTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitImportLogTasksWithOptions(request, runtime);
        }

        public async Task<SubmitImportLogTasksResponse> SubmitImportLogTasksAsync(SubmitImportLogTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitImportLogTasksWithOptionsAsync(request, runtime);
        }

        public SubmitJobsResponse SubmitJobsWithOptions(SubmitJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonParam))
            {
                body["JsonParam"] = request.JsonParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitJobs",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitJobsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitJobsResponse> SubmitJobsWithOptionsAsync(SubmitJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonParam))
            {
                body["JsonParam"] = request.JsonParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitJobs",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitJobsResponse SubmitJobs(SubmitJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitJobsWithOptions(request, runtime);
        }

        public async Task<SubmitJobsResponse> SubmitJobsAsync(SubmitJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitJobsWithOptionsAsync(request, runtime);
        }

        public UpdateAutomateResponseConfigStatusResponse UpdateAutomateResponseConfigStatusWithOptions(UpdateAutomateResponseConfigStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                body["Ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InUse))
            {
                body["InUse"] = request.InUse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAutomateResponseConfigStatus",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAutomateResponseConfigStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateAutomateResponseConfigStatusResponse> UpdateAutomateResponseConfigStatusWithOptionsAsync(UpdateAutomateResponseConfigStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                body["Ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InUse))
            {
                body["InUse"] = request.InUse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAutomateResponseConfigStatus",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAutomateResponseConfigStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateAutomateResponseConfigStatusResponse UpdateAutomateResponseConfigStatus(UpdateAutomateResponseConfigStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAutomateResponseConfigStatusWithOptions(request, runtime);
        }

        public async Task<UpdateAutomateResponseConfigStatusResponse> UpdateAutomateResponseConfigStatusAsync(UpdateAutomateResponseConfigStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAutomateResponseConfigStatusWithOptionsAsync(request, runtime);
        }

        public UpdateWhiteRuleListResponse UpdateWhiteRuleListWithOptions(UpdateWhiteRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expression))
            {
                body["Expression"] = request.Expression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteRuleId))
            {
                body["WhiteRuleId"] = request.WhiteRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWhiteRuleList",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWhiteRuleListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateWhiteRuleListResponse> UpdateWhiteRuleListWithOptionsAsync(UpdateWhiteRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expression))
            {
                body["Expression"] = request.Expression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncidentUuid))
            {
                body["IncidentUuid"] = request.IncidentUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                body["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteRuleId))
            {
                body["WhiteRuleId"] = request.WhiteRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWhiteRuleList",
                Version = "2022-06-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWhiteRuleListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateWhiteRuleListResponse UpdateWhiteRuleList(UpdateWhiteRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWhiteRuleListWithOptions(request, runtime);
        }

        public async Task<UpdateWhiteRuleListResponse> UpdateWhiteRuleListAsync(UpdateWhiteRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWhiteRuleListWithOptionsAsync(request, runtime);
        }

    }
}
