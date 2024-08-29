// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Green20220926.Models;

namespace AlibabaCloud.SDK.Green20220926
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "green.ap-southeast-1.aliyuncs.com"},
                {"ap-south-1", "green.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "green.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-3", "green.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "green.ap-southeast-1.aliyuncs.com"},
                {"cn-chengdu", "green.aliyuncs.com"},
                {"cn-hongkong", "green.aliyuncs.com"},
                {"cn-huhehaote", "green.aliyuncs.com"},
                {"cn-qingdao", "green.aliyuncs.com"},
                {"cn-zhangjiakou", "green.aliyuncs.com"},
                {"eu-central-1", "green.ap-southeast-1.aliyuncs.com"},
                {"eu-west-1", "green.ap-southeast-1.aliyuncs.com"},
                {"me-east-1", "green.ap-southeast-1.aliyuncs.com"},
                {"us-east-1", "green.ap-southeast-1.aliyuncs.com"},
                {"cn-hangzhou-finance", "green.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "green.aliyuncs.com"},
                {"cn-shanghai-finance-1", "green.aliyuncs.com"},
                {"cn-north-2-gov-1", "green.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("green", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 创建图库
         *
         * @param request AddImageLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddImageLibResponse
         */
        public AddImageLibResponse AddImageLibWithOptions(AddImageLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                body["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibName))
            {
                body["LibName"] = request.LibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddImageLib",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddImageLibResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建图库
         *
         * @param request AddImageLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddImageLibResponse
         */
        public async Task<AddImageLibResponse> AddImageLibWithOptionsAsync(AddImageLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                body["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibName))
            {
                body["LibName"] = request.LibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddImageLib",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddImageLibResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建图库
         *
         * @param request AddImageLibRequest
         * @return AddImageLibResponse
         */
        public AddImageLibResponse AddImageLib(AddImageLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddImageLibWithOptions(request, runtime);
        }

        /**
         * @summary 创建图库
         *
         * @param request AddImageLibRequest
         * @return AddImageLibResponse
         */
        public async Task<AddImageLibResponse> AddImageLibAsync(AddImageLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddImageLibWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量添加图片
         *
         * @param request AddImages2LibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddImages2LibResponse
         */
        public AddImages2LibResponse AddImages2LibWithOptions(AddImages2LibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImgUrl))
            {
                body["ImgUrl"] = request.ImgUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibId))
            {
                body["LibId"] = request.LibId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddImages2Lib",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddImages2LibResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量添加图片
         *
         * @param request AddImages2LibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddImages2LibResponse
         */
        public async Task<AddImages2LibResponse> AddImages2LibWithOptionsAsync(AddImages2LibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImgUrl))
            {
                body["ImgUrl"] = request.ImgUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibId))
            {
                body["LibId"] = request.LibId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddImages2Lib",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddImages2LibResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量添加图片
         *
         * @param request AddImages2LibRequest
         * @return AddImages2LibResponse
         */
        public AddImages2LibResponse AddImages2Lib(AddImages2LibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddImages2LibWithOptions(request, runtime);
        }

        /**
         * @summary 批量添加图片
         *
         * @param request AddImages2LibRequest
         * @return AddImages2LibResponse
         */
        public async Task<AddImages2LibResponse> AddImages2LibAsync(AddImages2LibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddImages2LibWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建关键词库
         *
         * @param request AddKeywordLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddKeywordLibResponse
         */
        public AddKeywordLibResponse AddKeywordLibWithOptions(AddKeywordLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                body["Keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordsObject))
            {
                body["KeywordsObject"] = request.KeywordsObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibName))
            {
                body["LibName"] = request.LibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddKeywordLib",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddKeywordLibResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建关键词库
         *
         * @param request AddKeywordLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddKeywordLibResponse
         */
        public async Task<AddKeywordLibResponse> AddKeywordLibWithOptionsAsync(AddKeywordLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                body["Keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordsObject))
            {
                body["KeywordsObject"] = request.KeywordsObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibName))
            {
                body["LibName"] = request.LibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddKeywordLib",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddKeywordLibResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建关键词库
         *
         * @param request AddKeywordLibRequest
         * @return AddKeywordLibResponse
         */
        public AddKeywordLibResponse AddKeywordLib(AddKeywordLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddKeywordLibWithOptions(request, runtime);
        }

        /**
         * @summary 创建关键词库
         *
         * @param request AddKeywordLibRequest
         * @return AddKeywordLibResponse
         */
        public async Task<AddKeywordLibResponse> AddKeywordLibAsync(AddKeywordLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddKeywordLibWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 添加关键词
         *
         * @param request AddKeywordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddKeywordsResponse
         */
        public AddKeywordsResponse AddKeywordsWithOptions(AddKeywordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                body["Keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordsObject))
            {
                body["KeywordsObject"] = request.KeywordsObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibId))
            {
                body["LibId"] = request.LibId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddKeywords",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddKeywordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 添加关键词
         *
         * @param request AddKeywordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddKeywordsResponse
         */
        public async Task<AddKeywordsResponse> AddKeywordsWithOptionsAsync(AddKeywordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                body["Keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordsObject))
            {
                body["KeywordsObject"] = request.KeywordsObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibId))
            {
                body["LibId"] = request.LibId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddKeywords",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddKeywordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 添加关键词
         *
         * @param request AddKeywordsRequest
         * @return AddKeywordsResponse
         */
        public AddKeywordsResponse AddKeywords(AddKeywordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddKeywordsWithOptions(request, runtime);
        }

        /**
         * @summary 添加关键词
         *
         * @param request AddKeywordsRequest
         * @return AddKeywordsResponse
         */
        public async Task<AddKeywordsResponse> AddKeywordsAsync(AddKeywordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddKeywordsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 添加关键词
         *
         * @param request AddKeywordsToLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddKeywordsToLibResponse
         */
        public AddKeywordsToLibResponse AddKeywordsToLibWithOptions(AddKeywordsToLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                body["Keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordsObject))
            {
                body["KeywordsObject"] = request.KeywordsObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibId))
            {
                body["LibId"] = request.LibId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddKeywordsToLib",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddKeywordsToLibResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 添加关键词
         *
         * @param request AddKeywordsToLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddKeywordsToLibResponse
         */
        public async Task<AddKeywordsToLibResponse> AddKeywordsToLibWithOptionsAsync(AddKeywordsToLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keywords))
            {
                body["Keywords"] = request.Keywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordsObject))
            {
                body["KeywordsObject"] = request.KeywordsObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibId))
            {
                body["LibId"] = request.LibId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddKeywordsToLib",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddKeywordsToLibResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 添加关键词
         *
         * @param request AddKeywordsToLibRequest
         * @return AddKeywordsToLibResponse
         */
        public AddKeywordsToLibResponse AddKeywordsToLib(AddKeywordsToLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddKeywordsToLibWithOptions(request, runtime);
        }

        /**
         * @summary 添加关键词
         *
         * @param request AddKeywordsToLibRequest
         * @return AddKeywordsToLibResponse
         */
        public async Task<AddKeywordsToLibResponse> AddKeywordsToLibAsync(AddKeywordsToLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddKeywordsToLibWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 取消oss扫描任务
         *
         * @param request CancelStockOssCheckTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelStockOssCheckTaskResponse
         */
        public CancelStockOssCheckTaskResponse CancelStockOssCheckTaskWithOptions(CancelStockOssCheckTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "CancelStockOssCheckTask",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelStockOssCheckTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 取消oss扫描任务
         *
         * @param request CancelStockOssCheckTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelStockOssCheckTaskResponse
         */
        public async Task<CancelStockOssCheckTaskResponse> CancelStockOssCheckTaskWithOptionsAsync(CancelStockOssCheckTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "CancelStockOssCheckTask",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelStockOssCheckTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 取消oss扫描任务
         *
         * @param request CancelStockOssCheckTaskRequest
         * @return CancelStockOssCheckTaskResponse
         */
        public CancelStockOssCheckTaskResponse CancelStockOssCheckTask(CancelStockOssCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelStockOssCheckTaskWithOptions(request, runtime);
        }

        /**
         * @summary 取消oss扫描任务
         *
         * @param request CancelStockOssCheckTaskRequest
         * @return CancelStockOssCheckTaskResponse
         */
        public async Task<CancelStockOssCheckTaskResponse> CancelStockOssCheckTaskAsync(CancelStockOssCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelStockOssCheckTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 复制服务
         *
         * @param request CopyServiceConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CopyServiceConfigResponse
         */
        public CopyServiceConfigResponse CopyServiceConfigWithOptions(CopyServiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceDesc))
            {
                body["ServiceDesc"] = request.ServiceDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["ServiceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyServiceConfig",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyServiceConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 复制服务
         *
         * @param request CopyServiceConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CopyServiceConfigResponse
         */
        public async Task<CopyServiceConfigResponse> CopyServiceConfigWithOptionsAsync(CopyServiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceDesc))
            {
                body["ServiceDesc"] = request.ServiceDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["ServiceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyServiceConfig",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyServiceConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 复制服务
         *
         * @param request CopyServiceConfigRequest
         * @return CopyServiceConfigResponse
         */
        public CopyServiceConfigResponse CopyServiceConfig(CopyServiceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyServiceConfigWithOptions(request, runtime);
        }

        /**
         * @summary 复制服务
         *
         * @param request CopyServiceConfigRequest
         * @return CopyServiceConfigResponse
         */
        public async Task<CopyServiceConfigResponse> CopyServiceConfigAsync(CopyServiceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyServiceConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建oss扫描任务
         *
         * @param request CreatStockOssCheckTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatStockOssCheckTaskResponse
         */
        public CreatStockOssCheckTaskResponse CreatStockOssCheckTaskWithOptions(CreatStockOssCheckTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Buckets))
            {
                query["Buckets"] = request.Buckets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackId))
            {
                query["CallbackId"] = request.CallbackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistinctHistoryTasks))
            {
                query["DistinctHistoryTasks"] = request.DistinctHistoryTasks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteDate))
            {
                query["ExecuteDate"] = request.ExecuteDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteTime))
            {
                query["ExecuteTime"] = request.ExecuteTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Freeze))
            {
                query["Freeze"] = request.Freeze;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreezeHighRisk1))
            {
                query["FreezeHighRisk1"] = request.FreezeHighRisk1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreezeHighRisk2))
            {
                query["FreezeHighRisk2"] = request.FreezeHighRisk2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreezeMediumRisk1))
            {
                query["FreezeMediumRisk1"] = request.FreezeMediumRisk1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreezeMediumRisk2))
            {
                query["FreezeMediumRisk2"] = request.FreezeMediumRisk2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreezeType))
            {
                query["FreezeType"] = request.FreezeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsInc))
            {
                query["IsInc"] = request.IsInc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrefixFilterType))
            {
                query["PrefixFilterType"] = request.PrefixFilterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrefixFilters))
            {
                query["PrefixFilters"] = request.PrefixFilters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanLimit))
            {
                query["ScanLimit"] = request.ScanLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanNoFileType))
            {
                query["ScanNoFileType"] = request.ScanNoFileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanResourceType))
            {
                query["ScanResourceType"] = request.ScanResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanService))
            {
                query["ScanService"] = request.ScanService;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskCycle))
            {
                query["TaskCycle"] = request.TaskCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
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
                Action = "CreatStockOssCheckTask",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatStockOssCheckTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建oss扫描任务
         *
         * @param request CreatStockOssCheckTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatStockOssCheckTaskResponse
         */
        public async Task<CreatStockOssCheckTaskResponse> CreatStockOssCheckTaskWithOptionsAsync(CreatStockOssCheckTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Buckets))
            {
                query["Buckets"] = request.Buckets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackId))
            {
                query["CallbackId"] = request.CallbackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistinctHistoryTasks))
            {
                query["DistinctHistoryTasks"] = request.DistinctHistoryTasks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteDate))
            {
                query["ExecuteDate"] = request.ExecuteDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteTime))
            {
                query["ExecuteTime"] = request.ExecuteTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Freeze))
            {
                query["Freeze"] = request.Freeze;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreezeHighRisk1))
            {
                query["FreezeHighRisk1"] = request.FreezeHighRisk1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreezeHighRisk2))
            {
                query["FreezeHighRisk2"] = request.FreezeHighRisk2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreezeMediumRisk1))
            {
                query["FreezeMediumRisk1"] = request.FreezeMediumRisk1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreezeMediumRisk2))
            {
                query["FreezeMediumRisk2"] = request.FreezeMediumRisk2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreezeType))
            {
                query["FreezeType"] = request.FreezeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsInc))
            {
                query["IsInc"] = request.IsInc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrefixFilterType))
            {
                query["PrefixFilterType"] = request.PrefixFilterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrefixFilters))
            {
                query["PrefixFilters"] = request.PrefixFilters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanLimit))
            {
                query["ScanLimit"] = request.ScanLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanNoFileType))
            {
                query["ScanNoFileType"] = request.ScanNoFileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanResourceType))
            {
                query["ScanResourceType"] = request.ScanResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanService))
            {
                query["ScanService"] = request.ScanService;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskCycle))
            {
                query["TaskCycle"] = request.TaskCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
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
                Action = "CreatStockOssCheckTask",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatStockOssCheckTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建oss扫描任务
         *
         * @param request CreatStockOssCheckTaskRequest
         * @return CreatStockOssCheckTaskResponse
         */
        public CreatStockOssCheckTaskResponse CreatStockOssCheckTask(CreatStockOssCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatStockOssCheckTaskWithOptions(request, runtime);
        }

        /**
         * @summary 创建oss扫描任务
         *
         * @param request CreatStockOssCheckTaskRequest
         * @return CreatStockOssCheckTaskResponse
         */
        public async Task<CreatStockOssCheckTaskResponse> CreatStockOssCheckTaskAsync(CreatStockOssCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatStockOssCheckTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建oss扫描任务前检查
         *
         * @param request CreatePreCheckRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePreCheckResponse
         */
        public CreatePreCheckResponse CreatePreCheckWithOptions(CreatePreCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Buckets))
            {
                body["Buckets"] = request.Buckets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistinctHistoryTasks))
            {
                body["DistinctHistoryTasks"] = request.DistinctHistoryTasks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsInc))
            {
                body["IsInc"] = request.IsInc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                body["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrefixFilterType))
            {
                body["PrefixFilterType"] = request.PrefixFilterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrefixFilters))
            {
                body["PrefixFilters"] = request.PrefixFilters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanLimit))
            {
                body["ScanLimit"] = request.ScanLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanNoFileType))
            {
                body["ScanNoFileType"] = request.ScanNoFileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanService))
            {
                body["ScanService"] = request.ScanService;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePreCheck",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePreCheckResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建oss扫描任务前检查
         *
         * @param request CreatePreCheckRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePreCheckResponse
         */
        public async Task<CreatePreCheckResponse> CreatePreCheckWithOptionsAsync(CreatePreCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Buckets))
            {
                body["Buckets"] = request.Buckets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistinctHistoryTasks))
            {
                body["DistinctHistoryTasks"] = request.DistinctHistoryTasks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsInc))
            {
                body["IsInc"] = request.IsInc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                body["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrefixFilterType))
            {
                body["PrefixFilterType"] = request.PrefixFilterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrefixFilters))
            {
                body["PrefixFilters"] = request.PrefixFilters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanLimit))
            {
                body["ScanLimit"] = request.ScanLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanNoFileType))
            {
                body["ScanNoFileType"] = request.ScanNoFileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanService))
            {
                body["ScanService"] = request.ScanService;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePreCheck",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePreCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建oss扫描任务前检查
         *
         * @param request CreatePreCheckRequest
         * @return CreatePreCheckResponse
         */
        public CreatePreCheckResponse CreatePreCheck(CreatePreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePreCheckWithOptions(request, runtime);
        }

        /**
         * @summary 创建oss扫描任务前检查
         *
         * @param request CreatePreCheckRequest
         * @return CreatePreCheckResponse
         */
        public async Task<CreatePreCheckResponse> CreatePreCheckAsync(CreatePreCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePreCheckWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量删除
         *
         * @param request DeleteImagesFromLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteImagesFromLibResponse
         */
        public DeleteImagesFromLibResponse DeleteImagesFromLibWithOptions(DeleteImagesFromLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageIds))
            {
                body["ImageIds"] = request.ImageIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibId))
            {
                body["LibId"] = request.LibId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteImagesFromLib",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteImagesFromLibResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量删除
         *
         * @param request DeleteImagesFromLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteImagesFromLibResponse
         */
        public async Task<DeleteImagesFromLibResponse> DeleteImagesFromLibWithOptionsAsync(DeleteImagesFromLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageIds))
            {
                body["ImageIds"] = request.ImageIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibId))
            {
                body["LibId"] = request.LibId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteImagesFromLib",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteImagesFromLibResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量删除
         *
         * @param request DeleteImagesFromLibRequest
         * @return DeleteImagesFromLibResponse
         */
        public DeleteImagesFromLibResponse DeleteImagesFromLib(DeleteImagesFromLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteImagesFromLibWithOptions(request, runtime);
        }

        /**
         * @summary 批量删除
         *
         * @param request DeleteImagesFromLibRequest
         * @return DeleteImagesFromLibResponse
         */
        public async Task<DeleteImagesFromLibResponse> DeleteImagesFromLibAsync(DeleteImagesFromLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteImagesFromLibWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除关键词
         *
         * @param request DeleteKeywordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteKeywordResponse
         */
        public DeleteKeywordResponse DeleteKeywordWithOptions(DeleteKeywordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordIds))
            {
                body["KeywordIds"] = request.KeywordIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibId))
            {
                body["LibId"] = request.LibId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKeyword",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKeywordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除关键词
         *
         * @param request DeleteKeywordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteKeywordResponse
         */
        public async Task<DeleteKeywordResponse> DeleteKeywordWithOptionsAsync(DeleteKeywordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordIds))
            {
                body["KeywordIds"] = request.KeywordIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibId))
            {
                body["LibId"] = request.LibId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKeyword",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKeywordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除关键词
         *
         * @param request DeleteKeywordRequest
         * @return DeleteKeywordResponse
         */
        public DeleteKeywordResponse DeleteKeyword(DeleteKeywordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteKeywordWithOptions(request, runtime);
        }

        /**
         * @summary 删除关键词
         *
         * @param request DeleteKeywordRequest
         * @return DeleteKeywordResponse
         */
        public async Task<DeleteKeywordResponse> DeleteKeywordAsync(DeleteKeywordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteKeywordWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除关键词库
         *
         * @param request DeleteKeywordLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteKeywordLibResponse
         */
        public DeleteKeywordLibResponse DeleteKeywordLibWithOptions(DeleteKeywordLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibId))
            {
                body["LibId"] = request.LibId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKeywordLib",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKeywordLibResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除关键词库
         *
         * @param request DeleteKeywordLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteKeywordLibResponse
         */
        public async Task<DeleteKeywordLibResponse> DeleteKeywordLibWithOptionsAsync(DeleteKeywordLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibId))
            {
                body["LibId"] = request.LibId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKeywordLib",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKeywordLibResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除关键词库
         *
         * @param request DeleteKeywordLibRequest
         * @return DeleteKeywordLibResponse
         */
        public DeleteKeywordLibResponse DeleteKeywordLib(DeleteKeywordLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteKeywordLibWithOptions(request, runtime);
        }

        /**
         * @summary 删除关键词库
         *
         * @param request DeleteKeywordLibRequest
         * @return DeleteKeywordLibResponse
         */
        public async Task<DeleteKeywordLibResponse> DeleteKeywordLibAsync(DeleteKeywordLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteKeywordLibWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 导出调用量
         *
         * @param request ExportCipStatsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportCipStatsResponse
         */
        public ExportCipStatsResponse ExportCipStatsWithOptions(ExportCipStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ByMonth))
            {
                body["ByMonth"] = request.ByMonth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUid))
            {
                body["SubUid"] = request.SubUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportCipStats",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportCipStatsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 导出调用量
         *
         * @param request ExportCipStatsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportCipStatsResponse
         */
        public async Task<ExportCipStatsResponse> ExportCipStatsWithOptionsAsync(ExportCipStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ByMonth))
            {
                body["ByMonth"] = request.ByMonth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUid))
            {
                body["SubUid"] = request.SubUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportCipStats",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportCipStatsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 导出调用量
         *
         * @param request ExportCipStatsRequest
         * @return ExportCipStatsResponse
         */
        public ExportCipStatsResponse ExportCipStats(ExportCipStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportCipStatsWithOptions(request, runtime);
        }

        /**
         * @summary 导出调用量
         *
         * @param request ExportCipStatsRequest
         * @return ExportCipStatsResponse
         */
        public async Task<ExportCipStatsResponse> ExportCipStatsAsync(ExportCipStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportCipStatsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 导出关键词
         *
         * @param request ExportKeywordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportKeywordResponse
         */
        public ExportKeywordResponse ExportKeywordWithOptions(ExportKeywordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibId))
            {
                body["LibId"] = request.LibId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportKeyword",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportKeywordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 导出关键词
         *
         * @param request ExportKeywordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportKeywordResponse
         */
        public async Task<ExportKeywordResponse> ExportKeywordWithOptionsAsync(ExportKeywordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibId))
            {
                body["LibId"] = request.LibId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportKeyword",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportKeywordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 导出关键词
         *
         * @param request ExportKeywordRequest
         * @return ExportKeywordResponse
         */
        public ExportKeywordResponse ExportKeyword(ExportKeywordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportKeywordWithOptions(request, runtime);
        }

        /**
         * @summary 导出关键词
         *
         * @param request ExportKeywordRequest
         * @return ExportKeywordResponse
         */
        public async Task<ExportKeywordResponse> ExportKeywordAsync(ExportKeywordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportKeywordWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 导出oss扫描结果
         *
         * @param tmpReq ExportResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportResultResponse
         */
        public ExportResultResponse ExportResultWithOptions(ExportResultRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExportResultShrinkRequest request = new ExportResultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sort))
            {
                request.SortShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sort, "Sort", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortShrink))
            {
                body["Sort"] = request.SortShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportResult",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 导出oss扫描结果
         *
         * @param tmpReq ExportResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportResultResponse
         */
        public async Task<ExportResultResponse> ExportResultWithOptionsAsync(ExportResultRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExportResultShrinkRequest request = new ExportResultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sort))
            {
                request.SortShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sort, "Sort", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortShrink))
            {
                body["Sort"] = request.SortShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportResult",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 导出oss扫描结果
         *
         * @param request ExportResultRequest
         * @return ExportResultResponse
         */
        public ExportResultResponse ExportResult(ExportResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportResultWithOptions(request, runtime);
        }

        /**
         * @summary 导出oss扫描结果
         *
         * @param request ExportResultRequest
         * @return ExportResultResponse
         */
        public async Task<ExportResultResponse> ExportResultAsync(ExportResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 导出调用结果，excel文件
         *
         * @param tmpReq ExportScanResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportScanResultResponse
         */
        public ExportScanResultResponse ExportScanResultWithOptions(ExportScanResultRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExportScanResultShrinkRequest request = new ExportScanResultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Query))
            {
                request.QueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Query, "Query", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sort))
            {
                request.SortShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sort, "Sort", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryShrink))
            {
                body["Query"] = request.QueryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortShrink))
            {
                body["Sort"] = request.SortShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportScanResult",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportScanResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 导出调用结果，excel文件
         *
         * @param tmpReq ExportScanResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportScanResultResponse
         */
        public async Task<ExportScanResultResponse> ExportScanResultWithOptionsAsync(ExportScanResultRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExportScanResultShrinkRequest request = new ExportScanResultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Query))
            {
                request.QueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Query, "Query", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sort))
            {
                request.SortShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sort, "Sort", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryShrink))
            {
                body["Query"] = request.QueryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortShrink))
            {
                body["Sort"] = request.SortShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportScanResult",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportScanResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 导出调用结果，excel文件
         *
         * @param request ExportScanResultRequest
         * @return ExportScanResultResponse
         */
        public ExportScanResultResponse ExportScanResult(ExportScanResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportScanResultWithOptions(request, runtime);
        }

        /**
         * @summary 导出调用结果，excel文件
         *
         * @param request ExportScanResultRequest
         * @return ExportScanResultResponse
         */
        public async Task<ExportScanResultResponse> ExportScanResultAsync(ExportScanResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportScanResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 导出调用结果，excel文件
         *
         * @param tmpReq ExportTextScanResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportTextScanResultResponse
         */
        public ExportTextScanResultResponse ExportTextScanResultWithOptions(ExportTextScanResultRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExportTextScanResultShrinkRequest request = new ExportTextScanResultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Query))
            {
                request.QueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Query, "Query", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryShrink))
            {
                body["Query"] = request.QueryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportTextScanResult",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportTextScanResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 导出调用结果，excel文件
         *
         * @param tmpReq ExportTextScanResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportTextScanResultResponse
         */
        public async Task<ExportTextScanResultResponse> ExportTextScanResultWithOptionsAsync(ExportTextScanResultRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExportTextScanResultShrinkRequest request = new ExportTextScanResultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Query))
            {
                request.QueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Query, "Query", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryShrink))
            {
                body["Query"] = request.QueryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportTextScanResult",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportTextScanResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 导出调用结果，excel文件
         *
         * @param request ExportTextScanResultRequest
         * @return ExportTextScanResultResponse
         */
        public ExportTextScanResultResponse ExportTextScanResult(ExportTextScanResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportTextScanResultWithOptions(request, runtime);
        }

        /**
         * @summary 导出调用结果，excel文件
         *
         * @param request ExportTextScanResultRequest
         * @return ExportTextScanResultResponse
         */
        public async Task<ExportTextScanResultResponse> ExportTextScanResultAsync(ExportTextScanResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportTextScanResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 证据转存获取用户bucket列表
         *
         * @param request GetBackupBucketsListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBackupBucketsListResponse
         */
        public GetBackupBucketsListResponse GetBackupBucketsListWithOptions(GetBackupBucketsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetBackupBucketsList",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBackupBucketsListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 证据转存获取用户bucket列表
         *
         * @param request GetBackupBucketsListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBackupBucketsListResponse
         */
        public async Task<GetBackupBucketsListResponse> GetBackupBucketsListWithOptionsAsync(GetBackupBucketsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetBackupBucketsList",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBackupBucketsListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 证据转存获取用户bucket列表
         *
         * @param request GetBackupBucketsListRequest
         * @return GetBackupBucketsListResponse
         */
        public GetBackupBucketsListResponse GetBackupBucketsList(GetBackupBucketsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBackupBucketsListWithOptions(request, runtime);
        }

        /**
         * @summary 证据转存获取用户bucket列表
         *
         * @param request GetBackupBucketsListRequest
         * @return GetBackupBucketsListResponse
         */
        public async Task<GetBackupBucketsListResponse> GetBackupBucketsListAsync(GetBackupBucketsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBackupBucketsListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取证据转存配置
         *
         * @param request GetBackupConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBackupConfigResponse
         */
        public GetBackupConfigResponse GetBackupConfigWithOptions(GetBackupConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                query["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBackupConfig",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBackupConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取证据转存配置
         *
         * @param request GetBackupConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBackupConfigResponse
         */
        public async Task<GetBackupConfigResponse> GetBackupConfigWithOptionsAsync(GetBackupConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                query["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBackupConfig",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBackupConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取证据转存配置
         *
         * @param request GetBackupConfigRequest
         * @return GetBackupConfigResponse
         */
        public GetBackupConfigResponse GetBackupConfig(GetBackupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBackupConfigWithOptions(request, runtime);
        }

        /**
         * @summary 获取证据转存配置
         *
         * @param request GetBackupConfigRequest
         * @return GetBackupConfigResponse
         */
        public async Task<GetBackupConfigResponse> GetBackupConfigAsync(GetBackupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBackupConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 用户授权校验
         *
         * @param request GetBackupStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBackupStatusResponse
         */
        public GetBackupStatusResponse GetBackupStatusWithOptions(GetBackupStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetBackupStatus",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBackupStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 用户授权校验
         *
         * @param request GetBackupStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBackupStatusResponse
         */
        public async Task<GetBackupStatusResponse> GetBackupStatusWithOptionsAsync(GetBackupStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetBackupStatus",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBackupStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 用户授权校验
         *
         * @param request GetBackupStatusRequest
         * @return GetBackupStatusResponse
         */
        public GetBackupStatusResponse GetBackupStatus(GetBackupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBackupStatusWithOptions(request, runtime);
        }

        /**
         * @summary 用户授权校验
         *
         * @param request GetBackupStatusRequest
         * @return GetBackupStatusResponse
         */
        public async Task<GetBackupStatusResponse> GetBackupStatusAsync(GetBackupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBackupStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary bucket列表
         *
         * @param request GetBucketsListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBucketsListResponse
         */
        public GetBucketsListResponse GetBucketsListWithOptions(GetBucketsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetBucketsList",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBucketsListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary bucket列表
         *
         * @param request GetBucketsListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBucketsListResponse
         */
        public async Task<GetBucketsListResponse> GetBucketsListWithOptionsAsync(GetBucketsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetBucketsList",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBucketsListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary bucket列表
         *
         * @param request GetBucketsListRequest
         * @return GetBucketsListResponse
         */
        public GetBucketsListResponse GetBucketsList(GetBucketsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBucketsListWithOptions(request, runtime);
        }

        /**
         * @summary bucket列表
         *
         * @param request GetBucketsListRequest
         * @return GetBucketsListResponse
         */
        public async Task<GetBucketsListResponse> GetBucketsListAsync(GetBucketsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBucketsListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询调用量
         *
         * @param request GetCipStatsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCipStatsResponse
         */
        public GetCipStatsResponse GetCipStatsWithOptions(GetCipStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ByMonth))
            {
                body["ByMonth"] = request.ByMonth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUid))
            {
                body["SubUid"] = request.SubUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCipStats",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCipStatsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询调用量
         *
         * @param request GetCipStatsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCipStatsResponse
         */
        public async Task<GetCipStatsResponse> GetCipStatsWithOptionsAsync(GetCipStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ByMonth))
            {
                body["ByMonth"] = request.ByMonth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUid))
            {
                body["SubUid"] = request.SubUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCipStats",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCipStatsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询调用量
         *
         * @param request GetCipStatsRequest
         * @return GetCipStatsResponse
         */
        public GetCipStatsResponse GetCipStats(GetCipStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCipStatsWithOptions(request, runtime);
        }

        /**
         * @summary 查询调用量
         *
         * @param request GetCipStatsRequest
         * @return GetCipStatsResponse
         */
        public async Task<GetCipStatsResponse> GetCipStatsAsync(GetCipStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCipStatsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取定时任务预计执行时间
         *
         * @param request GetExecuteTimeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetExecuteTimeResponse
         */
        public GetExecuteTimeResponse GetExecuteTimeWithOptions(GetExecuteTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetExecuteTime",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExecuteTimeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取定时任务预计执行时间
         *
         * @param request GetExecuteTimeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetExecuteTimeResponse
         */
        public async Task<GetExecuteTimeResponse> GetExecuteTimeWithOptionsAsync(GetExecuteTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetExecuteTime",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExecuteTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取定时任务预计执行时间
         *
         * @param request GetExecuteTimeRequest
         * @return GetExecuteTimeResponse
         */
        public GetExecuteTimeResponse GetExecuteTime(GetExecuteTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetExecuteTimeWithOptions(request, runtime);
        }

        /**
         * @summary 获取定时任务预计执行时间
         *
         * @param request GetExecuteTimeRequest
         * @return GetExecuteTimeResponse
         */
        public async Task<GetExecuteTimeResponse> GetExecuteTimeAsync(GetExecuteTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetExecuteTimeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取图片规则标签信息
         *
         * @param request GetImageSceneLabelListConfRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetImageSceneLabelListConfResponse
         */
        public GetImageSceneLabelListConfResponse GetImageSceneLabelListConfWithOptions(GetImageSceneLabelListConfRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageServiceCode))
            {
                query["ImageServiceCode"] = request.ImageServiceCode;
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
                Action = "GetImageSceneLabelListConf",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageSceneLabelListConfResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取图片规则标签信息
         *
         * @param request GetImageSceneLabelListConfRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetImageSceneLabelListConfResponse
         */
        public async Task<GetImageSceneLabelListConfResponse> GetImageSceneLabelListConfWithOptionsAsync(GetImageSceneLabelListConfRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageServiceCode))
            {
                query["ImageServiceCode"] = request.ImageServiceCode;
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
                Action = "GetImageSceneLabelListConf",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageSceneLabelListConfResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取图片规则标签信息
         *
         * @param request GetImageSceneLabelListConfRequest
         * @return GetImageSceneLabelListConfResponse
         */
        public GetImageSceneLabelListConfResponse GetImageSceneLabelListConf(GetImageSceneLabelListConfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageSceneLabelListConfWithOptions(request, runtime);
        }

        /**
         * @summary 获取图片规则标签信息
         *
         * @param request GetImageSceneLabelListConfRequest
         * @return GetImageSceneLabelListConfResponse
         */
        public async Task<GetImageSceneLabelListConfResponse> GetImageSceneLabelListConfAsync(GetImageSceneLabelListConfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageSceneLabelListConfWithOptionsAsync(request, runtime);
        }

        /**
         * @summary oss定时扫描检测周期查询
         *
         * @param tmpReq GetJobNameListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobNameListResponse
         */
        public GetJobNameListResponse GetJobNameListWithOptions(GetJobNameListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetJobNameListShrinkRequest request = new GetJobNameListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sort))
            {
                request.SortShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sort, "Sort", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortShrink))
            {
                query["Sort"] = request.SortShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobNameList",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobNameListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary oss定时扫描检测周期查询
         *
         * @param tmpReq GetJobNameListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobNameListResponse
         */
        public async Task<GetJobNameListResponse> GetJobNameListWithOptionsAsync(GetJobNameListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetJobNameListShrinkRequest request = new GetJobNameListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sort))
            {
                request.SortShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sort, "Sort", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortShrink))
            {
                query["Sort"] = request.SortShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobNameList",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobNameListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary oss定时扫描检测周期查询
         *
         * @param request GetJobNameListRequest
         * @return GetJobNameListResponse
         */
        public GetJobNameListResponse GetJobNameList(GetJobNameListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobNameListWithOptions(request, runtime);
        }

        /**
         * @summary oss定时扫描检测周期查询
         *
         * @param request GetJobNameListRequest
         * @return GetJobNameListResponse
         */
        public async Task<GetJobNameListResponse> GetJobNameListAsync(GetJobNameListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobNameListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询导入关键词结果
         *
         * @param request GetKeywordImportResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetKeywordImportResultResponse
         */
        public GetKeywordImportResultResponse GetKeywordImportResultWithOptions(GetKeywordImportResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKeywordImportResult",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKeywordImportResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询导入关键词结果
         *
         * @param request GetKeywordImportResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetKeywordImportResultResponse
         */
        public async Task<GetKeywordImportResultResponse> GetKeywordImportResultWithOptionsAsync(GetKeywordImportResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKeywordImportResult",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKeywordImportResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询导入关键词结果
         *
         * @param request GetKeywordImportResultRequest
         * @return GetKeywordImportResultResponse
         */
        public GetKeywordImportResultResponse GetKeywordImportResult(GetKeywordImportResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetKeywordImportResultWithOptions(request, runtime);
        }

        /**
         * @summary 查询导入关键词结果
         *
         * @param request GetKeywordImportResultRequest
         * @return GetKeywordImportResultResponse
         */
        public async Task<GetKeywordImportResultResponse> GetKeywordImportResultAsync(GetKeywordImportResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetKeywordImportResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取OSS检测用户状态
         *
         * @param request GetOssCheckStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOssCheckStatusResponse
         */
        public GetOssCheckStatusResponse GetOssCheckStatusWithOptions(GetOssCheckStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetOssCheckStatus",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOssCheckStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取OSS检测用户状态
         *
         * @param request GetOssCheckStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOssCheckStatusResponse
         */
        public async Task<GetOssCheckStatusResponse> GetOssCheckStatusWithOptionsAsync(GetOssCheckStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetOssCheckStatus",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOssCheckStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取OSS检测用户状态
         *
         * @param request GetOssCheckStatusRequest
         * @return GetOssCheckStatusResponse
         */
        public GetOssCheckStatusResponse GetOssCheckStatus(GetOssCheckStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOssCheckStatusWithOptions(request, runtime);
        }

        /**
         * @summary 获取OSS检测用户状态
         *
         * @param request GetOssCheckStatusRequest
         * @return GetOssCheckStatusResponse
         */
        public async Task<GetOssCheckStatusResponse> GetOssCheckStatusAsync(GetOssCheckStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOssCheckStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 用户待检测信息
         *
         * @param request GetScanNumRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetScanNumResponse
         */
        public GetScanNumResponse GetScanNumWithOptions(GetScanNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Buckets))
            {
                query["Buckets"] = request.Buckets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
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
                Action = "GetScanNum",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScanNumResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 用户待检测信息
         *
         * @param request GetScanNumRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetScanNumResponse
         */
        public async Task<GetScanNumResponse> GetScanNumWithOptionsAsync(GetScanNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Buckets))
            {
                query["Buckets"] = request.Buckets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
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
                Action = "GetScanNum",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScanNumResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 用户待检测信息
         *
         * @param request GetScanNumRequest
         * @return GetScanNumResponse
         */
        public GetScanNumResponse GetScanNum(GetScanNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetScanNumWithOptions(request, runtime);
        }

        /**
         * @summary 用户待检测信息
         *
         * @param request GetScanNumRequest
         * @return GetScanNumResponse
         */
        public async Task<GetScanNumResponse> GetScanNumAsync(GetScanNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetScanNumWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询调用结果
         *
         * @param tmpReq GetScanResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetScanResultResponse
         */
        public GetScanResultResponse GetScanResultWithOptions(GetScanResultRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetScanResultShrinkRequest request = new GetScanResultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Query))
            {
                request.QueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Query, "Query", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sort))
            {
                request.SortShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sort, "Sort", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryShrink))
            {
                body["Query"] = request.QueryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortShrink))
            {
                body["Sort"] = request.SortShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScanResult",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScanResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询调用结果
         *
         * @param tmpReq GetScanResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetScanResultResponse
         */
        public async Task<GetScanResultResponse> GetScanResultWithOptionsAsync(GetScanResultRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetScanResultShrinkRequest request = new GetScanResultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Query))
            {
                request.QueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Query, "Query", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sort))
            {
                request.SortShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sort, "Sort", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryShrink))
            {
                body["Query"] = request.QueryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortShrink))
            {
                body["Sort"] = request.SortShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScanResult",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScanResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询调用结果
         *
         * @param request GetScanResultRequest
         * @return GetScanResultResponse
         */
        public GetScanResultResponse GetScanResult(GetScanResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetScanResultWithOptions(request, runtime);
        }

        /**
         * @summary 查询调用结果
         *
         * @param request GetScanResultRequest
         * @return GetScanResultResponse
         */
        public async Task<GetScanResultResponse> GetScanResultAsync(GetScanResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetScanResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取单个服务
         *
         * @param request GetServiceConfRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceConfResponse
         */
        public GetServiceConfResponse GetServiceConfWithOptions(GetServiceConfRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ByDefault))
            {
                body["ByDefault"] = request.ByDefault;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceConf",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceConfResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取单个服务
         *
         * @param request GetServiceConfRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceConfResponse
         */
        public async Task<GetServiceConfResponse> GetServiceConfWithOptionsAsync(GetServiceConfRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ByDefault))
            {
                body["ByDefault"] = request.ByDefault;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceConf",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceConfResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取单个服务
         *
         * @param request GetServiceConfRequest
         * @return GetServiceConfResponse
         */
        public GetServiceConfResponse GetServiceConf(GetServiceConfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceConfWithOptions(request, runtime);
        }

        /**
         * @summary 获取单个服务
         *
         * @param request GetServiceConfRequest
         * @return GetServiceConfResponse
         */
        public async Task<GetServiceConfResponse> GetServiceConfAsync(GetServiceConfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceConfWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取单个服务
         *
         * @param request GetServiceConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceConfigResponse
         */
        public GetServiceConfigResponse GetServiceConfigWithOptions(GetServiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceConfig",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取单个服务
         *
         * @param request GetServiceConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceConfigResponse
         */
        public async Task<GetServiceConfigResponse> GetServiceConfigWithOptionsAsync(GetServiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceConfig",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取单个服务
         *
         * @param request GetServiceConfigRequest
         * @return GetServiceConfigResponse
         */
        public GetServiceConfigResponse GetServiceConfig(GetServiceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceConfigWithOptions(request, runtime);
        }

        /**
         * @summary 获取单个服务
         *
         * @param request GetServiceConfigRequest
         * @return GetServiceConfigResponse
         */
        public async Task<GetServiceConfigResponse> GetServiceConfigAsync(GetServiceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取单个服务的标签配置
         *
         * @param request GetServiceLabelConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceLabelConfigResponse
         */
        public GetServiceLabelConfigResponse GetServiceLabelConfigWithOptions(GetServiceLabelConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceLabelConfig",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceLabelConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取单个服务的标签配置
         *
         * @param request GetServiceLabelConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetServiceLabelConfigResponse
         */
        public async Task<GetServiceLabelConfigResponse> GetServiceLabelConfigWithOptionsAsync(GetServiceLabelConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceLabelConfig",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceLabelConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取单个服务的标签配置
         *
         * @param request GetServiceLabelConfigRequest
         * @return GetServiceLabelConfigResponse
         */
        public GetServiceLabelConfigResponse GetServiceLabelConfig(GetServiceLabelConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceLabelConfigWithOptions(request, runtime);
        }

        /**
         * @summary 获取单个服务的标签配置
         *
         * @param request GetServiceLabelConfigRequest
         * @return GetServiceLabelConfigResponse
         */
        public async Task<GetServiceLabelConfigResponse> GetServiceLabelConfigAsync(GetServiceLabelConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceLabelConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询oss扫描任务列表
         *
         * @param tmpReq GetStockOssCheckTasksListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetStockOssCheckTasksListResponse
         */
        public GetStockOssCheckTasksListResponse GetStockOssCheckTasksListWithOptions(GetStockOssCheckTasksListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetStockOssCheckTasksListShrinkRequest request = new GetStockOssCheckTasksListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sort))
            {
                request.SortShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sort, "Sort", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsInc))
            {
                query["IsInc"] = request.IsInc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                body["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortShrink))
            {
                body["Sort"] = request.SortShrink;
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
                Action = "GetStockOssCheckTasksList",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStockOssCheckTasksListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询oss扫描任务列表
         *
         * @param tmpReq GetStockOssCheckTasksListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetStockOssCheckTasksListResponse
         */
        public async Task<GetStockOssCheckTasksListResponse> GetStockOssCheckTasksListWithOptionsAsync(GetStockOssCheckTasksListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetStockOssCheckTasksListShrinkRequest request = new GetStockOssCheckTasksListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sort))
            {
                request.SortShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sort, "Sort", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsInc))
            {
                query["IsInc"] = request.IsInc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                body["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortShrink))
            {
                body["Sort"] = request.SortShrink;
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
                Action = "GetStockOssCheckTasksList",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStockOssCheckTasksListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询oss扫描任务列表
         *
         * @param request GetStockOssCheckTasksListRequest
         * @return GetStockOssCheckTasksListResponse
         */
        public GetStockOssCheckTasksListResponse GetStockOssCheckTasksList(GetStockOssCheckTasksListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStockOssCheckTasksListWithOptions(request, runtime);
        }

        /**
         * @summary 查询oss扫描任务列表
         *
         * @param request GetStockOssCheckTasksListRequest
         * @return GetStockOssCheckTasksListResponse
         */
        public async Task<GetStockOssCheckTasksListResponse> GetStockOssCheckTasksListAsync(GetStockOssCheckTasksListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStockOssCheckTasksListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询调用结果
         *
         * @param tmpReq GetTextScanResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTextScanResultResponse
         */
        public GetTextScanResultResponse GetTextScanResultWithOptions(GetTextScanResultRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetTextScanResultShrinkRequest request = new GetTextScanResultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Query))
            {
                request.QueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Query, "Query", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sort))
            {
                request.SortShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sort, "Sort", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryShrink))
            {
                body["Query"] = request.QueryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortShrink))
            {
                body["Sort"] = request.SortShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTextScanResult",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTextScanResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询调用结果
         *
         * @param tmpReq GetTextScanResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTextScanResultResponse
         */
        public async Task<GetTextScanResultResponse> GetTextScanResultWithOptionsAsync(GetTextScanResultRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetTextScanResultShrinkRequest request = new GetTextScanResultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Query))
            {
                request.QueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Query, "Query", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sort))
            {
                request.SortShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sort, "Sort", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryShrink))
            {
                body["Query"] = request.QueryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortShrink))
            {
                body["Sort"] = request.SortShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTextScanResult",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTextScanResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询调用结果
         *
         * @param request GetTextScanResultRequest
         * @return GetTextScanResultResponse
         */
        public GetTextScanResultResponse GetTextScanResult(GetTextScanResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTextScanResultWithOptions(request, runtime);
        }

        /**
         * @summary 查询调用结果
         *
         * @param request GetTextScanResultRequest
         * @return GetTextScanResultResponse
         */
        public async Task<GetTextScanResultResponse> GetTextScanResultAsync(GetTextScanResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTextScanResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 文件上传获取相应信息
         *
         * @param request GetUploadInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUploadInfoResponse
         */
        public GetUploadInfoResponse GetUploadInfoWithOptions(GetUploadInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUploadInfo",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 文件上传获取相应信息
         *
         * @param request GetUploadInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUploadInfoResponse
         */
        public async Task<GetUploadInfoResponse> GetUploadInfoWithOptionsAsync(GetUploadInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUploadInfo",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 文件上传获取相应信息
         *
         * @param request GetUploadInfoRequest
         * @return GetUploadInfoResponse
         */
        public GetUploadInfoResponse GetUploadInfo(GetUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUploadInfoWithOptions(request, runtime);
        }

        /**
         * @summary 文件上传获取相应信息
         *
         * @param request GetUploadInfoRequest
         * @return GetUploadInfoResponse
         */
        public async Task<GetUploadInfoResponse> GetUploadInfoAsync(GetUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUploadInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取用户购买状态
         *
         * @param request GetUserBuyStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserBuyStatusResponse
         */
        public GetUserBuyStatusResponse GetUserBuyStatusWithOptions(GetUserBuyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetUserBuyStatus",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserBuyStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取用户购买状态
         *
         * @param request GetUserBuyStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserBuyStatusResponse
         */
        public async Task<GetUserBuyStatusResponse> GetUserBuyStatusWithOptionsAsync(GetUserBuyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetUserBuyStatus",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserBuyStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户购买状态
         *
         * @param request GetUserBuyStatusRequest
         * @return GetUserBuyStatusResponse
         */
        public GetUserBuyStatusResponse GetUserBuyStatus(GetUserBuyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserBuyStatusWithOptions(request, runtime);
        }

        /**
         * @summary 获取用户购买状态
         *
         * @param request GetUserBuyStatusRequest
         * @return GetUserBuyStatusResponse
         */
        public async Task<GetUserBuyStatusResponse> GetUserBuyStatusAsync(GetUserBuyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserBuyStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 图库列表
         *
         * @param request ListImageLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListImageLibResponse
         */
        public ListImageLibResponse ListImageLibWithOptions(ListImageLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListImageLib",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImageLibResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 图库列表
         *
         * @param request ListImageLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListImageLibResponse
         */
        public async Task<ListImageLibResponse> ListImageLibWithOptionsAsync(ListImageLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListImageLib",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImageLibResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 图库列表
         *
         * @param request ListImageLibRequest
         * @return ListImageLibResponse
         */
        public ListImageLibResponse ListImageLib(ListImageLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListImageLibWithOptions(request, runtime);
        }

        /**
         * @summary 图库列表
         *
         * @param request ListImageLibRequest
         * @return ListImageLibResponse
         */
        public async Task<ListImageLibResponse> ListImageLibAsync(ListImageLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListImageLibWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 图片列表 分页
         *
         * @param tmpReq ListImagesFromLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListImagesFromLibResponse
         */
        public ListImagesFromLibResponse ListImagesFromLibWithOptions(ListImagesFromLibRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListImagesFromLibShrinkRequest request = new ListImagesFromLibShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sort))
            {
                request.SortShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sort, "Sort", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImgId))
            {
                body["ImgId"] = request.ImgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibId))
            {
                body["LibId"] = request.LibId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortShrink))
            {
                body["Sort"] = request.SortShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListImagesFromLib",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImagesFromLibResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 图片列表 分页
         *
         * @param tmpReq ListImagesFromLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListImagesFromLibResponse
         */
        public async Task<ListImagesFromLibResponse> ListImagesFromLibWithOptionsAsync(ListImagesFromLibRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListImagesFromLibShrinkRequest request = new ListImagesFromLibShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sort))
            {
                request.SortShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sort, "Sort", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImgId))
            {
                body["ImgId"] = request.ImgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibId))
            {
                body["LibId"] = request.LibId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortShrink))
            {
                body["Sort"] = request.SortShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListImagesFromLib",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImagesFromLibResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 图片列表 分页
         *
         * @param request ListImagesFromLibRequest
         * @return ListImagesFromLibResponse
         */
        public ListImagesFromLibResponse ListImagesFromLib(ListImagesFromLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListImagesFromLibWithOptions(request, runtime);
        }

        /**
         * @summary 图片列表 分页
         *
         * @param request ListImagesFromLibRequest
         * @return ListImagesFromLibResponse
         */
        public async Task<ListImagesFromLibResponse> ListImagesFromLibAsync(ListImagesFromLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListImagesFromLibWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 关键词库列表
         *
         * @param request ListKeywordLibsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListKeywordLibsResponse
         */
        public ListKeywordLibsResponse ListKeywordLibsWithOptions(ListKeywordLibsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListKeywordLibs",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKeywordLibsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 关键词库列表
         *
         * @param request ListKeywordLibsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListKeywordLibsResponse
         */
        public async Task<ListKeywordLibsResponse> ListKeywordLibsWithOptionsAsync(ListKeywordLibsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListKeywordLibs",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKeywordLibsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 关键词库列表
         *
         * @param request ListKeywordLibsRequest
         * @return ListKeywordLibsResponse
         */
        public ListKeywordLibsResponse ListKeywordLibs(ListKeywordLibsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListKeywordLibsWithOptions(request, runtime);
        }

        /**
         * @summary 关键词库列表
         *
         * @param request ListKeywordLibsRequest
         * @return ListKeywordLibsResponse
         */
        public async Task<ListKeywordLibsResponse> ListKeywordLibsAsync(ListKeywordLibsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListKeywordLibsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询关键词列表
         *
         * @param tmpReq ListKeywordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListKeywordsResponse
         */
        public ListKeywordsResponse ListKeywordsWithOptions(ListKeywordsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListKeywordsShrinkRequest request = new ListKeywordsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sort))
            {
                request.SortShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sort, "Sort", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibId))
            {
                body["LibId"] = request.LibId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortShrink))
            {
                body["Sort"] = request.SortShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Word))
            {
                body["Word"] = request.Word;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKeywords",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKeywordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询关键词列表
         *
         * @param tmpReq ListKeywordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListKeywordsResponse
         */
        public async Task<ListKeywordsResponse> ListKeywordsWithOptionsAsync(ListKeywordsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListKeywordsShrinkRequest request = new ListKeywordsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sort))
            {
                request.SortShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sort, "Sort", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibId))
            {
                body["LibId"] = request.LibId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortShrink))
            {
                body["Sort"] = request.SortShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Word))
            {
                body["Word"] = request.Word;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKeywords",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKeywordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询关键词列表
         *
         * @param request ListKeywordsRequest
         * @return ListKeywordsResponse
         */
        public ListKeywordsResponse ListKeywords(ListKeywordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListKeywordsWithOptions(request, runtime);
        }

        /**
         * @summary 查询关键词列表
         *
         * @param request ListKeywordsRequest
         * @return ListKeywordsResponse
         */
        public async Task<ListKeywordsResponse> ListKeywordsAsync(ListKeywordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListKeywordsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary oss扫描结果查询
         *
         * @param tmpReq ListOssCheckResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOssCheckResultResponse
         */
        public ListOssCheckResultResponse ListOssCheckResultWithOptions(ListOssCheckResultRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListOssCheckResultShrinkRequest request = new ListOssCheckResultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sort))
            {
                request.SortShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sort, "Sort", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinishNum))
            {
                query["FinishNum"] = request.FinishNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortShrink))
            {
                query["Sort"] = request.SortShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
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
                Action = "ListOssCheckResult",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOssCheckResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary oss扫描结果查询
         *
         * @param tmpReq ListOssCheckResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOssCheckResultResponse
         */
        public async Task<ListOssCheckResultResponse> ListOssCheckResultWithOptionsAsync(ListOssCheckResultRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListOssCheckResultShrinkRequest request = new ListOssCheckResultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sort))
            {
                request.SortShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sort, "Sort", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinishNum))
            {
                query["FinishNum"] = request.FinishNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortShrink))
            {
                query["Sort"] = request.SortShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
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
                Action = "ListOssCheckResult",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOssCheckResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary oss扫描结果查询
         *
         * @param request ListOssCheckResultRequest
         * @return ListOssCheckResultResponse
         */
        public ListOssCheckResultResponse ListOssCheckResult(ListOssCheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOssCheckResultWithOptions(request, runtime);
        }

        /**
         * @summary oss扫描结果查询
         *
         * @param request ListOssCheckResultRequest
         * @return ListOssCheckResultResponse
         */
        public async Task<ListOssCheckResultResponse> ListOssCheckResultAsync(ListOssCheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOssCheckResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取服务列表
         *
         * @param request ListServiceConfigsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceConfigsResponse
         */
        public ListServiceConfigsResponse ListServiceConfigsWithOptions(ListServiceConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classify))
            {
                query["Classify"] = request.Classify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseStatus))
            {
                query["UseStatus"] = request.UseStatus;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceConfigs",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceConfigsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取服务列表
         *
         * @param request ListServiceConfigsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceConfigsResponse
         */
        public async Task<ListServiceConfigsResponse> ListServiceConfigsWithOptionsAsync(ListServiceConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Classify))
            {
                query["Classify"] = request.Classify;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseStatus))
            {
                query["UseStatus"] = request.UseStatus;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceConfigs",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取服务列表
         *
         * @param request ListServiceConfigsRequest
         * @return ListServiceConfigsResponse
         */
        public ListServiceConfigsResponse ListServiceConfigs(ListServiceConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServiceConfigsWithOptions(request, runtime);
        }

        /**
         * @summary 获取服务列表
         *
         * @param request ListServiceConfigsRequest
         * @return ListServiceConfigsResponse
         */
        public async Task<ListServiceConfigsResponse> ListServiceConfigsAsync(ListServiceConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServiceConfigsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 编辑服务
         *
         * @param request ModifyServiceInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyServiceInfoResponse
         */
        public ModifyServiceInfoResponse ModifyServiceInfoWithOptions(ModifyServiceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceDesc))
            {
                body["ServiceDesc"] = request.ServiceDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["ServiceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyServiceInfo",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyServiceInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 编辑服务
         *
         * @param request ModifyServiceInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyServiceInfoResponse
         */
        public async Task<ModifyServiceInfoResponse> ModifyServiceInfoWithOptionsAsync(ModifyServiceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceDesc))
            {
                body["ServiceDesc"] = request.ServiceDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["ServiceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyServiceInfo",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyServiceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 编辑服务
         *
         * @param request ModifyServiceInfoRequest
         * @return ModifyServiceInfoResponse
         */
        public ModifyServiceInfoResponse ModifyServiceInfo(ModifyServiceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyServiceInfoWithOptions(request, runtime);
        }

        /**
         * @summary 编辑服务
         *
         * @param request ModifyServiceInfoRequest
         * @return ModifyServiceInfoResponse
         */
        public async Task<ModifyServiceInfoResponse> ModifyServiceInfoAsync(ModifyServiceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyServiceInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新证据转存配置
         *
         * @param request UpdateBackupConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateBackupConfigResponse
         */
        public UpdateBackupConfigResponse UpdateBackupConfigWithOptions(UpdateBackupConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupConfig))
            {
                query["BackupConfig"] = request.BackupConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                query["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBackupConfig",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBackupConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新证据转存配置
         *
         * @param request UpdateBackupConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateBackupConfigResponse
         */
        public async Task<UpdateBackupConfigResponse> UpdateBackupConfigWithOptionsAsync(UpdateBackupConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupConfig))
            {
                query["BackupConfig"] = request.BackupConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                query["ServiceCode"] = request.ServiceCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBackupConfig",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBackupConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新证据转存配置
         *
         * @param request UpdateBackupConfigRequest
         * @return UpdateBackupConfigResponse
         */
        public UpdateBackupConfigResponse UpdateBackupConfig(UpdateBackupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateBackupConfigWithOptions(request, runtime);
        }

        /**
         * @summary 更新证据转存配置
         *
         * @param request UpdateBackupConfigRequest
         * @return UpdateBackupConfigResponse
         */
        public async Task<UpdateBackupConfigResponse> UpdateBackupConfigAsync(UpdateBackupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateBackupConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 编辑图库
         *
         * @param request UpdateImageLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateImageLibResponse
         */
        public UpdateImageLibResponse UpdateImageLibWithOptions(UpdateImageLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                body["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeInspection))
            {
                body["FreeInspection"] = request.FreeInspection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibId))
            {
                body["LibId"] = request.LibId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibName))
            {
                body["LibName"] = request.LibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateImageLib",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateImageLibResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 编辑图库
         *
         * @param request UpdateImageLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateImageLibResponse
         */
        public async Task<UpdateImageLibResponse> UpdateImageLibWithOptionsAsync(UpdateImageLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                body["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeInspection))
            {
                body["FreeInspection"] = request.FreeInspection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibId))
            {
                body["LibId"] = request.LibId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibName))
            {
                body["LibName"] = request.LibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateImageLib",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateImageLibResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 编辑图库
         *
         * @param request UpdateImageLibRequest
         * @return UpdateImageLibResponse
         */
        public UpdateImageLibResponse UpdateImageLib(UpdateImageLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateImageLibWithOptions(request, runtime);
        }

        /**
         * @summary 编辑图库
         *
         * @param request UpdateImageLibRequest
         * @return UpdateImageLibResponse
         */
        public async Task<UpdateImageLibResponse> UpdateImageLibAsync(UpdateImageLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateImageLibWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 编辑图库免检配置
         *
         * @param tmpReq UpdateImageLibFreeInspectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateImageLibFreeInspectionResponse
         */
        public UpdateImageLibFreeInspectionResponse UpdateImageLibFreeInspectionWithOptions(UpdateImageLibFreeInspectionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateImageLibFreeInspectionShrinkRequest request = new UpdateImageLibFreeInspectionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Config))
            {
                request.ConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Config, "Config", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigShrink))
            {
                body["Config"] = request.ConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateImageLibFreeInspection",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateImageLibFreeInspectionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 编辑图库免检配置
         *
         * @param tmpReq UpdateImageLibFreeInspectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateImageLibFreeInspectionResponse
         */
        public async Task<UpdateImageLibFreeInspectionResponse> UpdateImageLibFreeInspectionWithOptionsAsync(UpdateImageLibFreeInspectionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateImageLibFreeInspectionShrinkRequest request = new UpdateImageLibFreeInspectionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Config))
            {
                request.ConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Config, "Config", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigShrink))
            {
                body["Config"] = request.ConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateImageLibFreeInspection",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateImageLibFreeInspectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 编辑图库免检配置
         *
         * @param request UpdateImageLibFreeInspectionRequest
         * @return UpdateImageLibFreeInspectionResponse
         */
        public UpdateImageLibFreeInspectionResponse UpdateImageLibFreeInspection(UpdateImageLibFreeInspectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateImageLibFreeInspectionWithOptions(request, runtime);
        }

        /**
         * @summary 编辑图库免检配置
         *
         * @param request UpdateImageLibFreeInspectionRequest
         * @return UpdateImageLibFreeInspectionResponse
         */
        public async Task<UpdateImageLibFreeInspectionResponse> UpdateImageLibFreeInspectionAsync(UpdateImageLibFreeInspectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateImageLibFreeInspectionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 编辑关键词库
         *
         * @param request UpdateKeywordLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateKeywordLibResponse
         */
        public UpdateKeywordLibResponse UpdateKeywordLibWithOptions(UpdateKeywordLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibId))
            {
                body["LibId"] = request.LibId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibName))
            {
                body["LibName"] = request.LibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKeywordLib",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKeywordLibResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 编辑关键词库
         *
         * @param request UpdateKeywordLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateKeywordLibResponse
         */
        public async Task<UpdateKeywordLibResponse> UpdateKeywordLibWithOptionsAsync(UpdateKeywordLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibId))
            {
                body["LibId"] = request.LibId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LibName))
            {
                body["LibName"] = request.LibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKeywordLib",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKeywordLibResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 编辑关键词库
         *
         * @param request UpdateKeywordLibRequest
         * @return UpdateKeywordLibResponse
         */
        public UpdateKeywordLibResponse UpdateKeywordLib(UpdateKeywordLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateKeywordLibWithOptions(request, runtime);
        }

        /**
         * @summary 编辑关键词库
         *
         * @param request UpdateKeywordLibRequest
         * @return UpdateKeywordLibResponse
         */
        public async Task<UpdateKeywordLibResponse> UpdateKeywordLibAsync(UpdateKeywordLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateKeywordLibWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 检测结果反馈
         *
         * @param request UpdateScanResultFeedbackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateScanResultFeedbackResponse
         */
        public UpdateScanResultFeedbackResponse UpdateScanResultFeedbackWithOptions(UpdateScanResultFeedbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Feedback))
            {
                body["Feedback"] = request.Feedback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryRequestId))
            {
                body["QueryRequestId"] = request.QueryRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateScanResultFeedback",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScanResultFeedbackResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 检测结果反馈
         *
         * @param request UpdateScanResultFeedbackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateScanResultFeedbackResponse
         */
        public async Task<UpdateScanResultFeedbackResponse> UpdateScanResultFeedbackWithOptionsAsync(UpdateScanResultFeedbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Feedback))
            {
                body["Feedback"] = request.Feedback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryRequestId))
            {
                body["QueryRequestId"] = request.QueryRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateScanResultFeedback",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScanResultFeedbackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 检测结果反馈
         *
         * @param request UpdateScanResultFeedbackRequest
         * @return UpdateScanResultFeedbackResponse
         */
        public UpdateScanResultFeedbackResponse UpdateScanResultFeedback(UpdateScanResultFeedbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateScanResultFeedbackWithOptions(request, runtime);
        }

        /**
         * @summary 检测结果反馈
         *
         * @param request UpdateScanResultFeedbackRequest
         * @return UpdateScanResultFeedbackResponse
         */
        public async Task<UpdateScanResultFeedbackResponse> UpdateScanResultFeedbackAsync(UpdateScanResultFeedbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateScanResultFeedbackWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新服务
         *
         * @param request UpdateServiceConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceConfigResponse
         */
        public UpdateServiceConfigResponse UpdateServiceConfigWithOptions(UpdateServiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileConfig))
            {
                body["FileConfig"] = request.FileConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordFilterLibs))
            {
                body["KeywordFilterLibs"] = request.KeywordFilterLibs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordHitLibs))
            {
                body["KeywordHitLibs"] = request.KeywordHitLibs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneConfig))
            {
                body["SceneConfig"] = request.SceneConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoConfig))
            {
                body["VideoConfig"] = request.VideoConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceConfig",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新服务
         *
         * @param request UpdateServiceConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceConfigResponse
         */
        public async Task<UpdateServiceConfigResponse> UpdateServiceConfigWithOptionsAsync(UpdateServiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileConfig))
            {
                body["FileConfig"] = request.FileConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordFilterLibs))
            {
                body["KeywordFilterLibs"] = request.KeywordFilterLibs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordHitLibs))
            {
                body["KeywordHitLibs"] = request.KeywordHitLibs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneConfig))
            {
                body["SceneConfig"] = request.SceneConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["ServiceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoConfig))
            {
                body["VideoConfig"] = request.VideoConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceConfig",
                Version = "2022-09-26",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新服务
         *
         * @param request UpdateServiceConfigRequest
         * @return UpdateServiceConfigResponse
         */
        public UpdateServiceConfigResponse UpdateServiceConfig(UpdateServiceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateServiceConfigWithOptions(request, runtime);
        }

        /**
         * @summary 更新服务
         *
         * @param request UpdateServiceConfigRequest
         * @return UpdateServiceConfigResponse
         */
        public async Task<UpdateServiceConfigResponse> UpdateServiceConfigAsync(UpdateServiceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateServiceConfigWithOptionsAsync(request, runtime);
        }

    }
}
