// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ft20210101.Models;

namespace AlibabaCloud.SDK.Ft20210101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-2-pop", "ft.aliyuncs.com"},
                {"ap-south-1", "ft.aliyuncs.com"},
                {"ap-southeast-1", "ft.aliyuncs.com"},
                {"ap-southeast-2", "ft.aliyuncs.com"},
                {"ap-southeast-3", "ft.aliyuncs.com"},
                {"ap-southeast-5", "ft.aliyuncs.com"},
                {"cn-beijing", "ft.aliyuncs.com"},
                {"cn-beijing-finance-1", "ft.aliyuncs.com"},
                {"cn-beijing-finance-pop", "ft.aliyuncs.com"},
                {"cn-beijing-gov-1", "ft.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "ft.aliyuncs.com"},
                {"cn-chengdu", "ft.aliyuncs.com"},
                {"cn-edge-1", "ft.aliyuncs.com"},
                {"cn-fujian", "ft.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "ft.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "ft.aliyuncs.com"},
                {"cn-hangzhou-finance", "ft.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "ft.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "ft.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "ft.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "ft.aliyuncs.com"},
                {"cn-hangzhou-test-306", "ft.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "ft.aliyuncs.com"},
                {"cn-huhehaote", "ft.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "ft.aliyuncs.com"},
                {"cn-qingdao", "ft.aliyuncs.com"},
                {"cn-qingdao-nebula", "ft.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "ft.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "ft.aliyuncs.com"},
                {"cn-shanghai-finance-1", "ft.aliyuncs.com"},
                {"cn-shanghai-inner", "ft.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "ft.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "ft.aliyuncs.com"},
                {"cn-shenzhen-inner", "ft.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "ft.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "ft.aliyuncs.com"},
                {"cn-wuhan", "ft.aliyuncs.com"},
                {"cn-wulanchabu", "ft.aliyuncs.com"},
                {"cn-yushanfang", "ft.aliyuncs.com"},
                {"cn-zhangbei", "ft.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "ft.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "ft.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "ft.aliyuncs.com"},
                {"eu-central-1", "ft.aliyuncs.com"},
                {"eu-west-1", "ft.aliyuncs.com"},
                {"eu-west-1-oxs", "ft.aliyuncs.com"},
                {"me-east-1", "ft.aliyuncs.com"},
                {"rus-west-1-pop", "ft.aliyuncs.com"},
                {"us-west-1", "ft.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("ft", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public DataRateLimitTestResponse DataRateLimitTestWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DataRateLimitTest",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DataRateLimitTestResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DataRateLimitTestResponse> DataRateLimitTestWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DataRateLimitTest",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DataRateLimitTestResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DataRateLimitTestResponse DataRateLimitTest()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DataRateLimitTestWithOptions(runtime);
        }

        public async Task<DataRateLimitTestResponse> DataRateLimitTestAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DataRateLimitTestWithOptionsAsync(runtime);
        }

        public NormalRpcHsfApiResponse NormalRpcHsfApiWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "NormalRpcHsfApi",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<NormalRpcHsfApiResponse>(CallApi(params_, req, runtime));
        }

        public async Task<NormalRpcHsfApiResponse> NormalRpcHsfApiWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "NormalRpcHsfApi",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<NormalRpcHsfApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        public NormalRpcHsfApiResponse NormalRpcHsfApi()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return NormalRpcHsfApiWithOptions(runtime);
        }

        public async Task<NormalRpcHsfApiResponse> NormalRpcHsfApiAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await NormalRpcHsfApiWithOptionsAsync(runtime);
        }

        public NormalRpcHttpApiResponse NormalRpcHttpApiWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "NormalRpcHttpApi",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<NormalRpcHttpApiResponse>(CallApi(params_, req, runtime));
        }

        public async Task<NormalRpcHttpApiResponse> NormalRpcHttpApiWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "NormalRpcHttpApi",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<NormalRpcHttpApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        public NormalRpcHttpApiResponse NormalRpcHttpApi()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return NormalRpcHttpApiWithOptions(runtime);
        }

        public async Task<NormalRpcHttpApiResponse> NormalRpcHttpApiAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await NormalRpcHttpApiWithOptionsAsync(runtime);
        }

        public RpcDataUploadResponse RpcDataUploadWithOptions(RpcDataUploadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query1))
            {
                query["query1"] = request.Query1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query2))
            {
                query["query2"] = request.Query2;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LargeParam))
            {
                body["largeParam"] = request.LargeParam;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RpcDataUpload",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RpcDataUploadResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RpcDataUploadResponse> RpcDataUploadWithOptionsAsync(RpcDataUploadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query1))
            {
                query["query1"] = request.Query1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query2))
            {
                query["query2"] = request.Query2;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LargeParam))
            {
                body["largeParam"] = request.LargeParam;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RpcDataUpload",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RpcDataUploadResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RpcDataUploadResponse RpcDataUpload(RpcDataUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RpcDataUploadWithOptions(request, runtime);
        }

        public async Task<RpcDataUploadResponse> RpcDataUploadAsync(RpcDataUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RpcDataUploadWithOptionsAsync(request, runtime);
        }

        public RpcDataUploadAndDownloadResponse RpcDataUploadAndDownloadWithOptions(RpcDataUploadAndDownloadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query1))
            {
                query["query1"] = request.Query1;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RpcDataUploadAndDownload",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RpcDataUploadAndDownloadResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RpcDataUploadAndDownloadResponse> RpcDataUploadAndDownloadWithOptionsAsync(RpcDataUploadAndDownloadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query1))
            {
                query["query1"] = request.Query1;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RpcDataUploadAndDownload",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RpcDataUploadAndDownloadResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RpcDataUploadAndDownloadResponse RpcDataUploadAndDownload(RpcDataUploadAndDownloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RpcDataUploadAndDownloadWithOptions(request, runtime);
        }

        public async Task<RpcDataUploadAndDownloadResponse> RpcDataUploadAndDownloadAsync(RpcDataUploadAndDownloadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RpcDataUploadAndDownloadWithOptionsAsync(request, runtime);
        }

        public RpcDataUploadTestResponse RpcDataUploadTestWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RpcDataUploadTest",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RpcDataUploadTestResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RpcDataUploadTestResponse> RpcDataUploadTestWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RpcDataUploadTest",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RpcDataUploadTestResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RpcDataUploadTestResponse RpcDataUploadTest()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RpcDataUploadTestWithOptions(runtime);
        }

        public async Task<RpcDataUploadTestResponse> RpcDataUploadTestAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RpcDataUploadTestWithOptionsAsync(runtime);
        }

    }
}
