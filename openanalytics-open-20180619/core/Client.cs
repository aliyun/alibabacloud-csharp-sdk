// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Openanalytics_open20180619.Models;

namespace AlibabaCloud.SDK.Openanalytics_open20180619
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing", "openanalytics.cn-beijing.aliyuncs.com"},
                {"cn-zhangjiakou", "openanalytics.cn-zhangjiakou.aliyuncs.com"},
                {"cn-hangzhou", "openanalytics.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai", "openanalytics.cn-shanghai.aliyuncs.com"},
                {"cn-shenzhen", "openanalytics.cn-shenzhen.aliyuncs.com"},
                {"cn-hongkong", "openanalytics.cn-hongkong.aliyuncs.com"},
                {"ap-southeast-1", "openanalytics.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "datalakeanalytics.ap-southeast-2.aliyuncs.com"},
                {"ap-southeast-3", "openanalytics.ap-southeast-3.aliyuncs.com"},
                {"ap-northeast-1", "datalakeanalytics.ap-northeast-1.aliyuncs.com"},
                {"eu-west-1", "openanalytics.eu-west-1.aliyuncs.com"},
                {"us-west-1", "openanalytics.us-west-1.aliyuncs.com"},
                {"us-east-1", "datalakeanalytics.us-east-1.aliyuncs.com"},
                {"eu-central-1", "datalakeanalytics.eu-central-1.aliyuncs.com"},
                {"ap-south-1", "openanalytics.ap-south-1.aliyuncs.com"},
                {"ap-northeast-2-pop", "openanalytics.ap-northeast-1.aliyuncs.com"},
                {"ap-southeast-5", "openanalytics.ap-southeast-5.aliyuncs.com"},
                {"cn-beijing-finance-1", "openanalytics.aliyuncs.com"},
                {"cn-beijing-finance-pop", "openanalytics.aliyuncs.com"},
                {"cn-beijing-gov-1", "openanalytics.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "openanalytics.aliyuncs.com"},
                {"cn-chengdu", "openanalytics.aliyuncs.com"},
                {"cn-edge-1", "openanalytics.aliyuncs.com"},
                {"cn-fujian", "openanalytics.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "openanalytics.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "openanalytics.aliyuncs.com"},
                {"cn-hangzhou-finance", "openanalytics.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "openanalytics.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "openanalytics.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "openanalytics.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "openanalytics.aliyuncs.com"},
                {"cn-hangzhou-test-306", "openanalytics.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "openanalytics.aliyuncs.com"},
                {"cn-huhehaote", "openanalytics.cn-huhehaote.aliyuncs.com"},
                {"cn-north-2-gov-1", "openanalytics.aliyuncs.com"},
                {"cn-qingdao", "openanalytics.cn-qingdao.aliyuncs.com"},
                {"cn-qingdao-nebula", "openanalytics.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "openanalytics.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "openanalytics.aliyuncs.com"},
                {"cn-shanghai-finance-1", "openanalytics.aliyuncs.com"},
                {"cn-shanghai-inner", "openanalytics.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "openanalytics.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "openanalytics.aliyuncs.com"},
                {"cn-shenzhen-inner", "openanalytics.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "openanalytics.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "openanalytics.aliyuncs.com"},
                {"cn-wuhan", "openanalytics.aliyuncs.com"},
                {"cn-yushanfang", "openanalytics.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "openanalytics.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "openanalytics.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "openanalytics.aliyuncs.com"},
                {"eu-west-1-oxs", "openanalytics.ap-northeast-1.aliyuncs.com"},
                {"me-east-1", "openanalytics.me-east-1.aliyuncs.com"},
                {"rus-west-1-pop", "openanalytics.ap-northeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("openanalytics-open", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /// <param name="request">
        /// CancelSparkStatementRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelSparkStatementResponse
        /// </returns>
        public CancelSparkStatementResponse CancelSparkStatementWithOptions(CancelSparkStatementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatementId))
            {
                body["StatementId"] = request.StatementId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelSparkStatement",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelSparkStatementResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CancelSparkStatementRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelSparkStatementResponse
        /// </returns>
        public async Task<CancelSparkStatementResponse> CancelSparkStatementWithOptionsAsync(CancelSparkStatementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatementId))
            {
                body["StatementId"] = request.StatementId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelSparkStatement",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelSparkStatementResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CancelSparkStatementRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelSparkStatementResponse
        /// </returns>
        public CancelSparkStatementResponse CancelSparkStatement(CancelSparkStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelSparkStatementWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CancelSparkStatementRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelSparkStatementResponse
        /// </returns>
        public async Task<CancelSparkStatementResponse> CancelSparkStatementAsync(CancelSparkStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelSparkStatementWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Component))
            {
                body["Component"] = request.Component;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
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
                Action = "CreateInstance",
                Version = "2018-06-19",
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

        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Component))
            {
                body["Component"] = request.Component;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
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
                Action = "CreateInstance",
                Version = "2018-06-19",
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

        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ExecuteSparkStatementRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteSparkStatementResponse
        /// </returns>
        public ExecuteSparkStatementResponse ExecuteSparkStatementWithOptions(ExecuteSparkStatementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Kind))
            {
                body["Kind"] = request.Kind;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteSparkStatement",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteSparkStatementResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ExecuteSparkStatementRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteSparkStatementResponse
        /// </returns>
        public async Task<ExecuteSparkStatementResponse> ExecuteSparkStatementWithOptionsAsync(ExecuteSparkStatementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Kind))
            {
                body["Kind"] = request.Kind;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteSparkStatement",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteSparkStatementResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ExecuteSparkStatementRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteSparkStatementResponse
        /// </returns>
        public ExecuteSparkStatementResponse ExecuteSparkStatement(ExecuteSparkStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteSparkStatementWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ExecuteSparkStatementRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteSparkStatementResponse
        /// </returns>
        public async Task<ExecuteSparkStatementResponse> ExecuteSparkStatementAsync(ExecuteSparkStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteSparkStatementWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetJobAttemptLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobAttemptLogResponse
        /// </returns>
        public GetJobAttemptLogResponse GetJobAttemptLogWithOptions(GetJobAttemptLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobAttemptId))
            {
                body["JobAttemptId"] = request.JobAttemptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VcName))
            {
                body["VcName"] = request.VcName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobAttemptLog",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobAttemptLogResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetJobAttemptLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobAttemptLogResponse
        /// </returns>
        public async Task<GetJobAttemptLogResponse> GetJobAttemptLogWithOptionsAsync(GetJobAttemptLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobAttemptId))
            {
                body["JobAttemptId"] = request.JobAttemptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VcName))
            {
                body["VcName"] = request.VcName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobAttemptLog",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobAttemptLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetJobAttemptLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobAttemptLogResponse
        /// </returns>
        public GetJobAttemptLogResponse GetJobAttemptLog(GetJobAttemptLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobAttemptLogWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetJobAttemptLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobAttemptLogResponse
        /// </returns>
        public async Task<GetJobAttemptLogResponse> GetJobAttemptLogAsync(GetJobAttemptLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobAttemptLogWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetJobDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobDetailResponse
        /// </returns>
        public GetJobDetailResponse GetJobDetailWithOptions(GetJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VcName))
            {
                body["VcName"] = request.VcName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobDetail",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetJobDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobDetailResponse
        /// </returns>
        public async Task<GetJobDetailResponse> GetJobDetailWithOptionsAsync(GetJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VcName))
            {
                body["VcName"] = request.VcName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobDetail",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetJobDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobDetailResponse
        /// </returns>
        public GetJobDetailResponse GetJobDetail(GetJobDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobDetailWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetJobDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobDetailResponse
        /// </returns>
        public async Task<GetJobDetailResponse> GetJobDetailAsync(GetJobDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobDetailWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetJobLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobLogResponse
        /// </returns>
        public GetJobLogResponse GetJobLogWithOptions(GetJobLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VcName))
            {
                body["VcName"] = request.VcName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobLog",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobLogResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetJobLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobLogResponse
        /// </returns>
        public async Task<GetJobLogResponse> GetJobLogWithOptionsAsync(GetJobLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VcName))
            {
                body["VcName"] = request.VcName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobLog",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetJobLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobLogResponse
        /// </returns>
        public GetJobLogResponse GetJobLog(GetJobLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobLogWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetJobLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobLogResponse
        /// </returns>
        public async Task<GetJobLogResponse> GetJobLogAsync(GetJobLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobLogWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetJobStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobStatusResponse
        /// </returns>
        public GetJobStatusResponse GetJobStatusWithOptions(GetJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VcName))
            {
                body["VcName"] = request.VcName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobStatus",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetJobStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobStatusResponse
        /// </returns>
        public async Task<GetJobStatusResponse> GetJobStatusWithOptionsAsync(GetJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VcName))
            {
                body["VcName"] = request.VcName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobStatus",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetJobStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobStatusResponse
        /// </returns>
        public GetJobStatusResponse GetJobStatus(GetJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobStatusWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetJobStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobStatusResponse
        /// </returns>
        public async Task<GetJobStatusResponse> GetJobStatusAsync(GetJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobStatusWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetSparkSessionStateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSparkSessionStateResponse
        /// </returns>
        public GetSparkSessionStateResponse GetSparkSessionStateWithOptions(GetSparkSessionStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkSessionState",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkSessionStateResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetSparkSessionStateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSparkSessionStateResponse
        /// </returns>
        public async Task<GetSparkSessionStateResponse> GetSparkSessionStateWithOptionsAsync(GetSparkSessionStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkSessionState",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkSessionStateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetSparkSessionStateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSparkSessionStateResponse
        /// </returns>
        public GetSparkSessionStateResponse GetSparkSessionState(GetSparkSessionStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSparkSessionStateWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetSparkSessionStateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSparkSessionStateResponse
        /// </returns>
        public async Task<GetSparkSessionStateResponse> GetSparkSessionStateAsync(GetSparkSessionStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSparkSessionStateWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetSparkStatementRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSparkStatementResponse
        /// </returns>
        public GetSparkStatementResponse GetSparkStatementWithOptions(GetSparkStatementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatementId))
            {
                body["StatementId"] = request.StatementId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkStatement",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkStatementResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetSparkStatementRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSparkStatementResponse
        /// </returns>
        public async Task<GetSparkStatementResponse> GetSparkStatementWithOptionsAsync(GetSparkStatementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatementId))
            {
                body["StatementId"] = request.StatementId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSparkStatement",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSparkStatementResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetSparkStatementRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSparkStatementResponse
        /// </returns>
        public GetSparkStatementResponse GetSparkStatement(GetSparkStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSparkStatementWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetSparkStatementRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSparkStatementResponse
        /// </returns>
        public async Task<GetSparkStatementResponse> GetSparkStatementAsync(GetSparkStatementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSparkStatementWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// KillSparkJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// KillSparkJobResponse
        /// </returns>
        public KillSparkJobResponse KillSparkJobWithOptions(KillSparkJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VcName))
            {
                body["VcName"] = request.VcName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillSparkJob",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KillSparkJobResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// KillSparkJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// KillSparkJobResponse
        /// </returns>
        public async Task<KillSparkJobResponse> KillSparkJobWithOptionsAsync(KillSparkJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VcName))
            {
                body["VcName"] = request.VcName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillSparkJob",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<KillSparkJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// KillSparkJobRequest
        /// </param>
        /// 
        /// <returns>
        /// KillSparkJobResponse
        /// </returns>
        public KillSparkJobResponse KillSparkJob(KillSparkJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return KillSparkJobWithOptions(request, runtime);
        }

        /// <param name="request">
        /// KillSparkJobRequest
        /// </param>
        /// 
        /// <returns>
        /// KillSparkJobResponse
        /// </returns>
        public async Task<KillSparkJobResponse> KillSparkJobAsync(KillSparkJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await KillSparkJobWithOptionsAsync(request, runtime);
        }

        /// <param name="tmpReq">
        /// ListSparkJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSparkJobResponse
        /// </returns>
        public ListSparkJobResponse ListSparkJobWithOptions(ListSparkJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListSparkJobShrinkRequest request = new ListSparkJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Condition))
            {
                request.ConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Condition, "Condition", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConditionShrink))
            {
                query["Condition"] = request.ConditionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VcName))
            {
                query["VcName"] = request.VcName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSparkJob",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSparkJobResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="tmpReq">
        /// ListSparkJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSparkJobResponse
        /// </returns>
        public async Task<ListSparkJobResponse> ListSparkJobWithOptionsAsync(ListSparkJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListSparkJobShrinkRequest request = new ListSparkJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Condition))
            {
                request.ConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Condition, "Condition", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConditionShrink))
            {
                query["Condition"] = request.ConditionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VcName))
            {
                query["VcName"] = request.VcName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSparkJob",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSparkJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListSparkJobRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSparkJobResponse
        /// </returns>
        public ListSparkJobResponse ListSparkJob(ListSparkJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSparkJobWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListSparkJobRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSparkJobResponse
        /// </returns>
        public async Task<ListSparkJobResponse> ListSparkJobAsync(ListSparkJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSparkJobWithOptionsAsync(request, runtime);
        }

        /// <param name="tmpReq">
        /// ListSparkJobAttemptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSparkJobAttemptResponse
        /// </returns>
        public ListSparkJobAttemptResponse ListSparkJobAttemptWithOptions(ListSparkJobAttemptRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListSparkJobAttemptShrinkRequest request = new ListSparkJobAttemptShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Condition))
            {
                request.ConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Condition, "Condition", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConditionShrink))
            {
                query["Condition"] = request.ConditionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VcName))
            {
                query["VcName"] = request.VcName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSparkJobAttempt",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSparkJobAttemptResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="tmpReq">
        /// ListSparkJobAttemptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSparkJobAttemptResponse
        /// </returns>
        public async Task<ListSparkJobAttemptResponse> ListSparkJobAttemptWithOptionsAsync(ListSparkJobAttemptRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListSparkJobAttemptShrinkRequest request = new ListSparkJobAttemptShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Condition))
            {
                request.ConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Condition, "Condition", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConditionShrink))
            {
                query["Condition"] = request.ConditionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VcName))
            {
                query["VcName"] = request.VcName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSparkJobAttempt",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSparkJobAttemptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListSparkJobAttemptRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSparkJobAttemptResponse
        /// </returns>
        public ListSparkJobAttemptResponse ListSparkJobAttempt(ListSparkJobAttemptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSparkJobAttemptWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListSparkJobAttemptRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSparkJobAttemptResponse
        /// </returns>
        public async Task<ListSparkJobAttemptResponse> ListSparkJobAttemptAsync(ListSparkJobAttemptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSparkJobAttemptWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListSparkStatementsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSparkStatementsResponse
        /// </returns>
        public ListSparkStatementsResponse ListSparkStatementsWithOptions(ListSparkStatementsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSparkStatements",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSparkStatementsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListSparkStatementsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSparkStatementsResponse
        /// </returns>
        public async Task<ListSparkStatementsResponse> ListSparkStatementsWithOptionsAsync(ListSparkStatementsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSparkStatements",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSparkStatementsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListSparkStatementsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSparkStatementsResponse
        /// </returns>
        public ListSparkStatementsResponse ListSparkStatements(ListSparkStatementsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSparkStatementsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListSparkStatementsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSparkStatementsResponse
        /// </returns>
        public async Task<ListSparkStatementsResponse> ListSparkStatementsAsync(ListSparkStatementsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSparkStatementsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ReleaseInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstanceResponse
        /// </returns>
        public ReleaseInstanceResponse ReleaseInstanceWithOptions(ReleaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
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
                Action = "ReleaseInstance",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ReleaseInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstanceResponse
        /// </returns>
        public async Task<ReleaseInstanceResponse> ReleaseInstanceWithOptionsAsync(ReleaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
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
                Action = "ReleaseInstance",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ReleaseInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstanceResponse
        /// </returns>
        public ReleaseInstanceResponse ReleaseInstance(ReleaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseInstanceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ReleaseInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseInstanceResponse
        /// </returns>
        public async Task<ReleaseInstanceResponse> ReleaseInstanceAsync(ReleaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseInstanceWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SubmitSparkJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitSparkJobResponse
        /// </returns>
        public SubmitSparkJobResponse SubmitSparkJobWithOptions(SubmitSparkJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigJson))
            {
                body["ConfigJson"] = request.ConfigJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VcName))
            {
                body["VcName"] = request.VcName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSparkJob",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSparkJobResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SubmitSparkJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitSparkJobResponse
        /// </returns>
        public async Task<SubmitSparkJobResponse> SubmitSparkJobWithOptionsAsync(SubmitSparkJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigJson))
            {
                body["ConfigJson"] = request.ConfigJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VcName))
            {
                body["VcName"] = request.VcName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSparkJob",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSparkJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SubmitSparkJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitSparkJobResponse
        /// </returns>
        public SubmitSparkJobResponse SubmitSparkJob(SubmitSparkJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSparkJobWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SubmitSparkJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitSparkJobResponse
        /// </returns>
        public async Task<SubmitSparkJobResponse> SubmitSparkJobAsync(SubmitSparkJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSparkJobWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SubmitSparkSQLRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitSparkSQLResponse
        /// </returns>
        public SubmitSparkSQLResponse SubmitSparkSQLWithOptions(SubmitSparkSQLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                body["Sql"] = request.Sql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VcName))
            {
                body["VcName"] = request.VcName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSparkSQL",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSparkSQLResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SubmitSparkSQLRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitSparkSQLResponse
        /// </returns>
        public async Task<SubmitSparkSQLResponse> SubmitSparkSQLWithOptionsAsync(SubmitSparkSQLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sql))
            {
                body["Sql"] = request.Sql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VcName))
            {
                body["VcName"] = request.VcName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSparkSQL",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSparkSQLResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SubmitSparkSQLRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitSparkSQLResponse
        /// </returns>
        public SubmitSparkSQLResponse SubmitSparkSQL(SubmitSparkSQLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSparkSQLWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SubmitSparkSQLRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitSparkSQLResponse
        /// </returns>
        public async Task<SubmitSparkSQLResponse> SubmitSparkSQLAsync(SubmitSparkSQLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSparkSQLWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ValidateVirtualClusterNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateVirtualClusterNameResponse
        /// </returns>
        public ValidateVirtualClusterNameResponse ValidateVirtualClusterNameWithOptions(ValidateVirtualClusterNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VcName))
            {
                body["VcName"] = request.VcName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateVirtualClusterName",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateVirtualClusterNameResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ValidateVirtualClusterNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateVirtualClusterNameResponse
        /// </returns>
        public async Task<ValidateVirtualClusterNameResponse> ValidateVirtualClusterNameWithOptionsAsync(ValidateVirtualClusterNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VcName))
            {
                body["VcName"] = request.VcName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateVirtualClusterName",
                Version = "2018-06-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateVirtualClusterNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ValidateVirtualClusterNameRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateVirtualClusterNameResponse
        /// </returns>
        public ValidateVirtualClusterNameResponse ValidateVirtualClusterName(ValidateVirtualClusterNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ValidateVirtualClusterNameWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ValidateVirtualClusterNameRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateVirtualClusterNameResponse
        /// </returns>
        public async Task<ValidateVirtualClusterNameResponse> ValidateVirtualClusterNameAsync(ValidateVirtualClusterNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ValidateVirtualClusterNameWithOptionsAsync(request, runtime);
        }

    }
}
