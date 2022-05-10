// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Vdc20201214.Models;

namespace AlibabaCloud.SDK.Vdc20201214
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("vdc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public DeleteAppExpMetricRuleResponse DeleteAppExpMetricRule(DeleteAppExpMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAppExpMetricRuleWithOptions(request, headers, runtime);
        }

        public async Task<DeleteAppExpMetricRuleResponse> DeleteAppExpMetricRuleAsync(DeleteAppExpMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAppExpMetricRuleWithOptionsAsync(request, headers, runtime);
        }

        public DeleteAppExpMetricRuleResponse DeleteAppExpMetricRuleWithOptions(DeleteAppExpMetricRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppExpMetricRule",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/config/deleteAppExpMetricRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppExpMetricRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteAppExpMetricRuleResponse> DeleteAppExpMetricRuleWithOptionsAsync(DeleteAppExpMetricRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppExpMetricRule",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/config/deleteAppExpMetricRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppExpMetricRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteAppFollowCallRuleResponse DeleteAppFollowCallRule(DeleteAppFollowCallRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAppFollowCallRuleWithOptions(request, headers, runtime);
        }

        public async Task<DeleteAppFollowCallRuleResponse> DeleteAppFollowCallRuleAsync(DeleteAppFollowCallRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAppFollowCallRuleWithOptionsAsync(request, headers, runtime);
        }

        public DeleteAppFollowCallRuleResponse DeleteAppFollowCallRuleWithOptions(DeleteAppFollowCallRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppFollowCallRule",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/config/deleteAppFollowCallRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppFollowCallRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteAppFollowCallRuleResponse> DeleteAppFollowCallRuleWithOptionsAsync(DeleteAppFollowCallRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppFollowCallRule",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/config/deleteAppFollowCallRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppFollowCallRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAppConfigResponse DescribeAppConfig(DescribeAppConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAppConfigWithOptions(request, headers, runtime);
        }

        public async Task<DescribeAppConfigResponse> DescribeAppConfigAsync(DescribeAppConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAppConfigWithOptionsAsync(request, headers, runtime);
        }

        public DescribeAppConfigResponse DescribeAppConfigWithOptions(DescribeAppConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppConfig",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/config/describeAppConfig",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAppConfigResponse> DescribeAppConfigWithOptionsAsync(DescribeAppConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppConfig",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/config/describeAppConfig",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAppExpMetricRuleResponse DescribeAppExpMetricRule(DescribeAppExpMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAppExpMetricRuleWithOptions(request, headers, runtime);
        }

        public async Task<DescribeAppExpMetricRuleResponse> DescribeAppExpMetricRuleAsync(DescribeAppExpMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAppExpMetricRuleWithOptionsAsync(request, headers, runtime);
        }

        public DescribeAppExpMetricRuleResponse DescribeAppExpMetricRuleWithOptions(DescribeAppExpMetricRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppExpMetricRule",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/config/describeAppExpMetricRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppExpMetricRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAppExpMetricRuleResponse> DescribeAppExpMetricRuleWithOptionsAsync(DescribeAppExpMetricRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppExpMetricRule",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/config/describeAppExpMetricRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppExpMetricRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAppExpMetricRuleListResponse DescribeAppExpMetricRuleList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAppExpMetricRuleListWithOptions(headers, runtime);
        }

        public async Task<DescribeAppExpMetricRuleListResponse> DescribeAppExpMetricRuleListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAppExpMetricRuleListWithOptionsAsync(headers, runtime);
        }

        public DescribeAppExpMetricRuleListResponse DescribeAppExpMetricRuleListWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppExpMetricRuleList",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/config/describeAppExpMetricRuleList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppExpMetricRuleListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAppExpMetricRuleListResponse> DescribeAppExpMetricRuleListWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppExpMetricRuleList",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/config/describeAppExpMetricRuleList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppExpMetricRuleListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAppFollowCallRuleResponse DescribeAppFollowCallRule(DescribeAppFollowCallRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAppFollowCallRuleWithOptions(request, headers, runtime);
        }

        public async Task<DescribeAppFollowCallRuleResponse> DescribeAppFollowCallRuleAsync(DescribeAppFollowCallRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAppFollowCallRuleWithOptionsAsync(request, headers, runtime);
        }

        public DescribeAppFollowCallRuleResponse DescribeAppFollowCallRuleWithOptions(DescribeAppFollowCallRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppFollowCallRule",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/config/describeAppFollowCallRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppFollowCallRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAppFollowCallRuleResponse> DescribeAppFollowCallRuleWithOptionsAsync(DescribeAppFollowCallRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppFollowCallRule",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/config/describeAppFollowCallRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppFollowCallRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAppFollowCallRuleListResponse DescribeAppFollowCallRuleList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAppFollowCallRuleListWithOptions(headers, runtime);
        }

        public async Task<DescribeAppFollowCallRuleListResponse> DescribeAppFollowCallRuleListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAppFollowCallRuleListWithOptionsAsync(headers, runtime);
        }

        public DescribeAppFollowCallRuleListResponse DescribeAppFollowCallRuleListWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppFollowCallRuleList",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/config/describeAppFollowCallRuleList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppFollowCallRuleListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAppFollowCallRuleListResponse> DescribeAppFollowCallRuleListWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppFollowCallRuleList",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/config/describeAppFollowCallRuleList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppFollowCallRuleListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCallResponse DescribeCall(DescribeCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeCallWithOptions(request, headers, runtime);
        }

        public async Task<DescribeCallResponse> DescribeCallAsync(DescribeCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeCallWithOptionsAsync(request, headers, runtime);
        }

        public DescribeCallResponse DescribeCallWithOptions(DescribeCallRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtDataType))
            {
                query["ExtDataType"] = request.ExtDataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryExpInfo))
            {
                query["QueryExpInfo"] = request.QueryExpInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCall",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describeCall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCallResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCallResponse> DescribeCallWithOptionsAsync(DescribeCallRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtDataType))
            {
                query["ExtDataType"] = request.ExtDataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryExpInfo))
            {
                query["QueryExpInfo"] = request.QueryExpInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCall",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describeCall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCallInfoResponse DescribeCallInfo(DescribeCallInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeCallInfoWithOptions(request, headers, runtime);
        }

        public async Task<DescribeCallInfoResponse> DescribeCallInfoAsync(DescribeCallInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeCallInfoWithOptionsAsync(request, headers, runtime);
        }

        public DescribeCallInfoResponse DescribeCallInfoWithOptions(DescribeCallInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCallInfo",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describeCallInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCallInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCallInfoResponse> DescribeCallInfoWithOptionsAsync(DescribeCallInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCallInfo",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describeCallInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCallInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCallListResponse DescribeCallList(DescribeCallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeCallListWithOptions(request, headers, runtime);
        }

        public async Task<DescribeCallListResponse> DescribeCallListAsync(DescribeCallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeCallListWithOptionsAsync(request, headers, runtime);
        }

        public DescribeCallListResponse DescribeCallListWithOptions(DescribeCallListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallStatus))
            {
                query["CallStatus"] = request.CallStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryMode))
            {
                query["QueryMode"] = request.QueryMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCallList",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describeCallList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCallListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCallListResponse> DescribeCallListWithOptionsAsync(DescribeCallListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallStatus))
            {
                query["CallStatus"] = request.CallStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryMode))
            {
                query["QueryMode"] = request.QueryMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCallList",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describeCallList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCallListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCallListTestResponse DescribeCallListTest(DescribeCallListTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeCallListTestWithOptions(request, headers, runtime);
        }

        public async Task<DescribeCallListTestResponse> DescribeCallListTestAsync(DescribeCallListTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeCallListTestWithOptionsAsync(request, headers, runtime);
        }

        public DescribeCallListTestResponse DescribeCallListTestWithOptions(DescribeCallListTestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCallListTest",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describeCallListTest",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCallListTestResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCallListTestResponse> DescribeCallListTestWithOptionsAsync(DescribeCallListTestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCallListTest",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describeCallListTest",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCallListTestResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCallUserExpResponse DescribeCallUserExp(DescribeCallUserExpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeCallUserExpWithOptions(request, headers, runtime);
        }

        public async Task<DescribeCallUserExpResponse> DescribeCallUserExpAsync(DescribeCallUserExpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeCallUserExpWithOptionsAsync(request, headers, runtime);
        }

        public DescribeCallUserExpResponse DescribeCallUserExpWithOptions(DescribeCallUserExpRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCallUserExp",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describeCallUserExp",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCallUserExpResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCallUserExpResponse> DescribeCallUserExpWithOptionsAsync(DescribeCallUserExpRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCallUserExp",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describeCallUserExp",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCallUserExpResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCallUserListResponse DescribeCallUserList(DescribeCallUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeCallUserListWithOptions(request, headers, runtime);
        }

        public async Task<DescribeCallUserListResponse> DescribeCallUserListAsync(DescribeCallUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeCallUserListWithOptionsAsync(request, headers, runtime);
        }

        public DescribeCallUserListResponse DescribeCallUserListWithOptions(DescribeCallUserListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtDataType))
            {
                query["ExtDataType"] = request.ExtDataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryExpInfo))
            {
                query["QueryExpInfo"] = request.QueryExpInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                query["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCallUserList",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describeCallUserList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCallUserListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCallUserListResponse> DescribeCallUserListWithOptionsAsync(DescribeCallUserListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtDataType))
            {
                query["ExtDataType"] = request.ExtDataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryExpInfo))
            {
                query["QueryExpInfo"] = request.QueryExpInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                query["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCallUserList",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describeCallUserList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCallUserListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeChannelAreaDistributionStatDataResponse DescribeChannelAreaDistributionStatData(DescribeChannelAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeChannelAreaDistributionStatDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeChannelAreaDistributionStatDataResponse> DescribeChannelAreaDistributionStatDataAsync(DescribeChannelAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeChannelAreaDistributionStatDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeChannelAreaDistributionStatDataResponse DescribeChannelAreaDistributionStatDataWithOptions(DescribeChannelAreaDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentArea))
            {
                query["ParentArea"] = request.ParentArea;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelAreaDistributionStatData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/channel/describeChannelAreaDistributionStatData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelAreaDistributionStatDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeChannelAreaDistributionStatDataResponse> DescribeChannelAreaDistributionStatDataWithOptionsAsync(DescribeChannelAreaDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentArea))
            {
                query["ParentArea"] = request.ParentArea;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelAreaDistributionStatData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/channel/describeChannelAreaDistributionStatData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelAreaDistributionStatDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeChannelDistributionStatDataResponse DescribeChannelDistributionStatData(DescribeChannelDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeChannelDistributionStatDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeChannelDistributionStatDataResponse> DescribeChannelDistributionStatDataAsync(DescribeChannelDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeChannelDistributionStatDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeChannelDistributionStatDataResponse DescribeChannelDistributionStatDataWithOptions(DescribeChannelDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelDistributionStatData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/channel/describeChannelDistributionStatData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelDistributionStatDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeChannelDistributionStatDataResponse> DescribeChannelDistributionStatDataWithOptionsAsync(DescribeChannelDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelDistributionStatData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/channel/describeChannelDistributionStatData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelDistributionStatDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeChannelJoinInfoResponse DescribeChannelJoinInfo(DescribeChannelJoinInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeChannelJoinInfoWithOptions(request, headers, runtime);
        }

        public async Task<DescribeChannelJoinInfoResponse> DescribeChannelJoinInfoAsync(DescribeChannelJoinInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeChannelJoinInfoWithOptionsAsync(request, headers, runtime);
        }

        public DescribeChannelJoinInfoResponse DescribeChannelJoinInfoWithOptions(DescribeChannelJoinInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelJoinInfo",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/channel/describeChannelJoinInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelJoinInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeChannelJoinInfoResponse> DescribeChannelJoinInfoWithOptionsAsync(DescribeChannelJoinInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelJoinInfo",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/channel/describeChannelJoinInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelJoinInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeChannelOverallDataResponse DescribeChannelOverallData(DescribeChannelOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeChannelOverallDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeChannelOverallDataResponse> DescribeChannelOverallDataAsync(DescribeChannelOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeChannelOverallDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeChannelOverallDataResponse DescribeChannelOverallDataWithOptions(DescribeChannelOverallDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelOverallData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/channel/describeChannelOverallData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelOverallDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeChannelOverallDataResponse> DescribeChannelOverallDataWithOptionsAsync(DescribeChannelOverallDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelOverallData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/channel/describeChannelOverallData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelOverallDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeChannelTopPubUserListResponse DescribeChannelTopPubUserList(DescribeChannelTopPubUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeChannelTopPubUserListWithOptions(request, headers, runtime);
        }

        public async Task<DescribeChannelTopPubUserListResponse> DescribeChannelTopPubUserListAsync(DescribeChannelTopPubUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeChannelTopPubUserListWithOptionsAsync(request, headers, runtime);
        }

        public DescribeChannelTopPubUserListResponse DescribeChannelTopPubUserListWithOptions(DescribeChannelTopPubUserListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelTopPubUserList",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/channel/describeChannelTopPubUserList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelTopPubUserListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeChannelTopPubUserListResponse> DescribeChannelTopPubUserListWithOptionsAsync(DescribeChannelTopPubUserListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelTopPubUserList",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/channel/describeChannelTopPubUserList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelTopPubUserListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeChannelUserMetricsResponse DescribeChannelUserMetrics(DescribeChannelUserMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeChannelUserMetricsWithOptions(request, headers, runtime);
        }

        public async Task<DescribeChannelUserMetricsResponse> DescribeChannelUserMetricsAsync(DescribeChannelUserMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeChannelUserMetricsWithOptionsAsync(request, headers, runtime);
        }

        public DescribeChannelUserMetricsResponse DescribeChannelUserMetricsWithOptions(DescribeChannelUserMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelUserMetrics",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/channel/describeChannelUserMetrics",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelUserMetricsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeChannelUserMetricsResponse> DescribeChannelUserMetricsWithOptionsAsync(DescribeChannelUserMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChannelUserMetrics",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/channel/describeChannelUserMetrics",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChannelUserMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeEndPointEventListResponse DescribeEndPointEventList(DescribeEndPointEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeEndPointEventListWithOptions(request, headers, runtime);
        }

        public async Task<DescribeEndPointEventListResponse> DescribeEndPointEventListAsync(DescribeEndPointEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeEndPointEventListWithOptionsAsync(request, headers, runtime);
        }

        public DescribeEndPointEventListResponse DescribeEndPointEventListWithOptions(DescribeEndPointEventListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                query["UserIdList"] = request.UserIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEndPointEventList",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describeEndPointEventList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEndPointEventListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeEndPointEventListResponse> DescribeEndPointEventListWithOptionsAsync(DescribeEndPointEventListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                query["UserIdList"] = request.UserIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEndPointEventList",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describeEndPointEventList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEndPointEventListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeEndPointMetricDataResponse DescribeEndPointMetricData(DescribeEndPointMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeEndPointMetricDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeEndPointMetricDataResponse> DescribeEndPointMetricDataAsync(DescribeEndPointMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeEndPointMetricDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeEndPointMetricDataResponse DescribeEndPointMetricDataWithOptions(DescribeEndPointMetricDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                query["Metrics"] = request.Metrics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PubCallIdList))
            {
                query["PubCallIdList"] = request.PubCallIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PubUserId))
            {
                query["PubUserId"] = request.PubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEndPointMetricData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describeEndPointMetricData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEndPointMetricDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeEndPointMetricDataResponse> DescribeEndPointMetricDataWithOptionsAsync(DescribeEndPointMetricDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                query["Metrics"] = request.Metrics;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PubCallIdList))
            {
                query["PubCallIdList"] = request.PubCallIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PubUserId))
            {
                query["PubUserId"] = request.PubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEndPointMetricData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describeEndPointMetricData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEndPointMetricDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeFaultDiagnosisFactorDistributionStatResponse DescribeFaultDiagnosisFactorDistributionStat(DescribeFaultDiagnosisFactorDistributionStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeFaultDiagnosisFactorDistributionStatWithOptions(request, headers, runtime);
        }

        public async Task<DescribeFaultDiagnosisFactorDistributionStatResponse> DescribeFaultDiagnosisFactorDistributionStatAsync(DescribeFaultDiagnosisFactorDistributionStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeFaultDiagnosisFactorDistributionStatWithOptionsAsync(request, headers, runtime);
        }

        public DescribeFaultDiagnosisFactorDistributionStatResponse DescribeFaultDiagnosisFactorDistributionStatWithOptions(DescribeFaultDiagnosisFactorDistributionStatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFaultDiagnosisFactorDistributionStat",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/diagnosis/describeFaultDiagnosisFactorDistributionStat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisFactorDistributionStatResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeFaultDiagnosisFactorDistributionStatResponse> DescribeFaultDiagnosisFactorDistributionStatWithOptionsAsync(DescribeFaultDiagnosisFactorDistributionStatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFaultDiagnosisFactorDistributionStat",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/diagnosis/describeFaultDiagnosisFactorDistributionStat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisFactorDistributionStatResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeFaultDiagnosisOverallDataResponse DescribeFaultDiagnosisOverallData(DescribeFaultDiagnosisOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeFaultDiagnosisOverallDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeFaultDiagnosisOverallDataResponse> DescribeFaultDiagnosisOverallDataAsync(DescribeFaultDiagnosisOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeFaultDiagnosisOverallDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeFaultDiagnosisOverallDataResponse DescribeFaultDiagnosisOverallDataWithOptions(DescribeFaultDiagnosisOverallDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFaultDiagnosisOverallData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/diagnosis/describeFaultDiagnosisOverallData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisOverallDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeFaultDiagnosisOverallDataResponse> DescribeFaultDiagnosisOverallDataWithOptionsAsync(DescribeFaultDiagnosisOverallDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFaultDiagnosisOverallData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/diagnosis/describeFaultDiagnosisOverallData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisOverallDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeFaultDiagnosisUserDetailResponse DescribeFaultDiagnosisUserDetail(DescribeFaultDiagnosisUserDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeFaultDiagnosisUserDetailWithOptions(request, headers, runtime);
        }

        public async Task<DescribeFaultDiagnosisUserDetailResponse> DescribeFaultDiagnosisUserDetailAsync(DescribeFaultDiagnosisUserDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeFaultDiagnosisUserDetailWithOptionsAsync(request, headers, runtime);
        }

        public DescribeFaultDiagnosisUserDetailResponse DescribeFaultDiagnosisUserDetailWithOptions(DescribeFaultDiagnosisUserDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaultType))
            {
                query["FaultType"] = request.FaultType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCallUserInfo))
            {
                query["QueryCallUserInfo"] = request.QueryCallUserInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFaultDiagnosisUserDetail",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/diagnosis/describeFaultDiagnosisUserDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisUserDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeFaultDiagnosisUserDetailResponse> DescribeFaultDiagnosisUserDetailWithOptionsAsync(DescribeFaultDiagnosisUserDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaultType))
            {
                query["FaultType"] = request.FaultType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCallUserInfo))
            {
                query["QueryCallUserInfo"] = request.QueryCallUserInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFaultDiagnosisUserDetail",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/diagnosis/describeFaultDiagnosisUserDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisUserDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeFaultDiagnosisUserListResponse DescribeFaultDiagnosisUserList(DescribeFaultDiagnosisUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeFaultDiagnosisUserListWithOptions(request, headers, runtime);
        }

        public async Task<DescribeFaultDiagnosisUserListResponse> DescribeFaultDiagnosisUserListAsync(DescribeFaultDiagnosisUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeFaultDiagnosisUserListWithOptionsAsync(request, headers, runtime);
        }

        public DescribeFaultDiagnosisUserListResponse DescribeFaultDiagnosisUserListWithOptions(DescribeFaultDiagnosisUserListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaultTypes))
            {
                query["FaultTypes"] = request.FaultTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFaultDiagnosisUserList",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/diagnosis/describeFaultDiagnosisUserList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisUserListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeFaultDiagnosisUserListResponse> DescribeFaultDiagnosisUserListWithOptionsAsync(DescribeFaultDiagnosisUserListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaultTypes))
            {
                query["FaultTypes"] = request.FaultTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFaultDiagnosisUserList",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/diagnosis/describeFaultDiagnosisUserList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisUserListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeIceDurPeriodByDaySubTypeResponse DescribeIceDurPeriodByDaySubType(DescribeIceDurPeriodByDaySubTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeIceDurPeriodByDaySubTypeWithOptions(request, headers, runtime);
        }

        public async Task<DescribeIceDurPeriodByDaySubTypeResponse> DescribeIceDurPeriodByDaySubTypeAsync(DescribeIceDurPeriodByDaySubTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeIceDurPeriodByDaySubTypeWithOptionsAsync(request, headers, runtime);
        }

        public DescribeIceDurPeriodByDaySubTypeResponse DescribeIceDurPeriodByDaySubTypeWithOptions(DescribeIceDurPeriodByDaySubTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                query["TimeZone"] = request.TimeZone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIceDurPeriodByDaySubType",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/ice/describeIceDurPeriodByDaySubType",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIceDurPeriodByDaySubTypeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeIceDurPeriodByDaySubTypeResponse> DescribeIceDurPeriodByDaySubTypeWithOptionsAsync(DescribeIceDurPeriodByDaySubTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                query["TimeZone"] = request.TimeZone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIceDurPeriodByDaySubType",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/ice/describeIceDurPeriodByDaySubType",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIceDurPeriodByDaySubTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeIceDurSummaryOverviewResponse DescribeIceDurSummaryOverview(DescribeIceDurSummaryOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeIceDurSummaryOverviewWithOptions(request, headers, runtime);
        }

        public async Task<DescribeIceDurSummaryOverviewResponse> DescribeIceDurSummaryOverviewAsync(DescribeIceDurSummaryOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeIceDurSummaryOverviewWithOptionsAsync(request, headers, runtime);
        }

        public DescribeIceDurSummaryOverviewResponse DescribeIceDurSummaryOverviewWithOptions(DescribeIceDurSummaryOverviewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurTs))
            {
                query["CurTs"] = request.CurTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                query["TimeZone"] = request.TimeZone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIceDurSummaryOverview",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/ice/describeIceDurSummaryOverview",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIceDurSummaryOverviewResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeIceDurSummaryOverviewResponse> DescribeIceDurSummaryOverviewWithOptionsAsync(DescribeIceDurSummaryOverviewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurTs))
            {
                query["CurTs"] = request.CurTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                query["TimeZone"] = request.TimeZone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIceDurSummaryOverview",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/ice/describeIceDurSummaryOverview",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIceDurSummaryOverviewResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribePubUserListBySubUserResponse DescribePubUserListBySubUser(DescribePubUserListBySubUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribePubUserListBySubUserWithOptions(request, headers, runtime);
        }

        public async Task<DescribePubUserListBySubUserResponse> DescribePubUserListBySubUserAsync(DescribePubUserListBySubUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribePubUserListBySubUserWithOptionsAsync(request, headers, runtime);
        }

        public DescribePubUserListBySubUserResponse DescribePubUserListBySubUserWithOptions(DescribePubUserListBySubUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePubUserListBySubUser",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describePubUserListBySubUser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePubUserListBySubUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribePubUserListBySubUserResponse> DescribePubUserListBySubUserWithOptionsAsync(DescribePubUserListBySubUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePubUserListBySubUser",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describePubUserListBySubUser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePubUserListBySubUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeQoeMetricDataResponse DescribeQoeMetricData(DescribeQoeMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeQoeMetricDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeQoeMetricDataResponse> DescribeQoeMetricDataAsync(DescribeQoeMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeQoeMetricDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeQoeMetricDataResponse DescribeQoeMetricDataWithOptions(DescribeQoeMetricDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQoeMetricData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describeQoeMetricData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQoeMetricDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeQoeMetricDataResponse> DescribeQoeMetricDataWithOptionsAsync(DescribeQoeMetricDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQoeMetricData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describeQoeMetricData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQoeMetricDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeQualityAreaDistributionStatDataResponse DescribeQualityAreaDistributionStatData(DescribeQualityAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeQualityAreaDistributionStatDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeQualityAreaDistributionStatDataResponse> DescribeQualityAreaDistributionStatDataAsync(DescribeQualityAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeQualityAreaDistributionStatDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeQualityAreaDistributionStatDataResponse DescribeQualityAreaDistributionStatDataWithOptions(DescribeQualityAreaDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentArea))
            {
                query["ParentArea"] = request.ParentArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQualityAreaDistributionStatData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/quality/describeQualityAreaDistributionStatData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQualityAreaDistributionStatDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeQualityAreaDistributionStatDataResponse> DescribeQualityAreaDistributionStatDataWithOptionsAsync(DescribeQualityAreaDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentArea))
            {
                query["ParentArea"] = request.ParentArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQualityAreaDistributionStatData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/quality/describeQualityAreaDistributionStatData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQualityAreaDistributionStatDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeQualityDistributionStatDataResponse DescribeQualityDistributionStatData(DescribeQualityDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeQualityDistributionStatDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeQualityDistributionStatDataResponse> DescribeQualityDistributionStatDataAsync(DescribeQualityDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeQualityDistributionStatDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeQualityDistributionStatDataResponse DescribeQualityDistributionStatDataWithOptions(DescribeQualityDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQualityDistributionStatData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/quality/describeQualityDistributionStatData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQualityDistributionStatDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeQualityDistributionStatDataResponse> DescribeQualityDistributionStatDataWithOptionsAsync(DescribeQualityDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQualityDistributionStatData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/quality/describeQualityDistributionStatData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQualityDistributionStatDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeQualityOsSdkVersionDistributionStatDataResponse DescribeQualityOsSdkVersionDistributionStatData(DescribeQualityOsSdkVersionDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeQualityOsSdkVersionDistributionStatDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeQualityOsSdkVersionDistributionStatDataResponse> DescribeQualityOsSdkVersionDistributionStatDataAsync(DescribeQualityOsSdkVersionDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeQualityOsSdkVersionDistributionStatDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeQualityOsSdkVersionDistributionStatDataResponse DescribeQualityOsSdkVersionDistributionStatDataWithOptions(DescribeQualityOsSdkVersionDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQualityOsSdkVersionDistributionStatData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/quality/describeQualityOsSdkVersionDistributionStatData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQualityOsSdkVersionDistributionStatDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeQualityOsSdkVersionDistributionStatDataResponse> DescribeQualityOsSdkVersionDistributionStatDataWithOptionsAsync(DescribeQualityOsSdkVersionDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQualityOsSdkVersionDistributionStatData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/quality/describeQualityOsSdkVersionDistributionStatData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQualityOsSdkVersionDistributionStatDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeQualityOverallDataResponse DescribeQualityOverallData(DescribeQualityOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeQualityOverallDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeQualityOverallDataResponse> DescribeQualityOverallDataAsync(DescribeQualityOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeQualityOverallDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeQualityOverallDataResponse DescribeQualityOverallDataWithOptions(DescribeQualityOverallDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["Types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQualityOverallData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/quality/describeQualityOverallData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQualityOverallDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeQualityOverallDataResponse> DescribeQualityOverallDataWithOptionsAsync(DescribeQualityOverallDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["Types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQualityOverallData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/quality/describeQualityOverallData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQualityOverallDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRtcChannelDetailsResponse DescribeRtcChannelDetails(DescribeRtcChannelDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRtcChannelDetailsWithOptions(request, headers, runtime);
        }

        public async Task<DescribeRtcChannelDetailsResponse> DescribeRtcChannelDetailsAsync(DescribeRtcChannelDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRtcChannelDetailsWithOptionsAsync(request, headers, runtime);
        }

        public DescribeRtcChannelDetailsResponse DescribeRtcChannelDetailsWithOptions(DescribeRtcChannelDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRtcChannelDetails",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/channel/describeRtcChannelDetails",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRtcChannelDetailsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRtcChannelDetailsResponse> DescribeRtcChannelDetailsWithOptionsAsync(DescribeRtcChannelDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRtcChannelDetails",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/channel/describeRtcChannelDetails",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRtcChannelDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRtcChannelListResponse DescribeRtcChannelList(DescribeRtcChannelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRtcChannelListWithOptions(request, headers, runtime);
        }

        public async Task<DescribeRtcChannelListResponse> DescribeRtcChannelListAsync(DescribeRtcChannelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRtcChannelListWithOptionsAsync(request, headers, runtime);
        }

        public DescribeRtcChannelListResponse DescribeRtcChannelListWithOptions(DescribeRtcChannelListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRtcChannelList",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/channel/describeRtcChannelList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRtcChannelListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRtcChannelListResponse> DescribeRtcChannelListWithOptionsAsync(DescribeRtcChannelListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRtcChannelList",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/channel/describeRtcChannelList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRtcChannelListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRtcChannelMetricListResponse DescribeRtcChannelMetricList(DescribeRtcChannelMetricListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRtcChannelMetricListWithOptions(request, headers, runtime);
        }

        public async Task<DescribeRtcChannelMetricListResponse> DescribeRtcChannelMetricListAsync(DescribeRtcChannelMetricListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRtcChannelMetricListWithOptionsAsync(request, headers, runtime);
        }

        public DescribeRtcChannelMetricListResponse DescribeRtcChannelMetricListWithOptions(DescribeRtcChannelMetricListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PubUid))
            {
                query["PubUid"] = request.PubUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUid))
            {
                query["SubUid"] = request.SubUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRtcChannelMetricList",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describeRtcChannelMetricList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRtcChannelMetricListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRtcChannelMetricListResponse> DescribeRtcChannelMetricListWithOptionsAsync(DescribeRtcChannelMetricListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PubUid))
            {
                query["PubUid"] = request.PubUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUid))
            {
                query["SubUid"] = request.SubUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRtcChannelMetricList",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describeRtcChannelMetricList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRtcChannelMetricListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRtcChannelUsersResponse DescribeRtcChannelUsers(DescribeRtcChannelUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRtcChannelUsersWithOptions(request, headers, runtime);
        }

        public async Task<DescribeRtcChannelUsersResponse> DescribeRtcChannelUsersAsync(DescribeRtcChannelUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRtcChannelUsersWithOptionsAsync(request, headers, runtime);
        }

        public DescribeRtcChannelUsersResponse DescribeRtcChannelUsersWithOptions(DescribeRtcChannelUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePoint))
            {
                query["TimePoint"] = request.TimePoint;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRtcChannelUsers",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/channel/describeRtcChannelUsers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRtcChannelUsersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRtcChannelUsersResponse> DescribeRtcChannelUsersWithOptionsAsync(DescribeRtcChannelUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePoint))
            {
                query["TimePoint"] = request.TimePoint;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRtcChannelUsers",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/channel/describeRtcChannelUsers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRtcChannelUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRtcRecordMetricDataResponse DescribeRtcRecordMetricData(DescribeRtcRecordMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRtcRecordMetricDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeRtcRecordMetricDataResponse> DescribeRtcRecordMetricDataAsync(DescribeRtcRecordMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRtcRecordMetricDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeRtcRecordMetricDataResponse DescribeRtcRecordMetricDataWithOptions(DescribeRtcRecordMetricDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRtcRecordMetricData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/record/describeRtcRecordMetricData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRtcRecordMetricDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRtcRecordMetricDataResponse> DescribeRtcRecordMetricDataWithOptionsAsync(DescribeRtcRecordMetricDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRtcRecordMetricData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/record/describeRtcRecordMetricData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRtcRecordMetricDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRtcUserEventListResponse DescribeRtcUserEventList(DescribeRtcUserEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRtcUserEventListWithOptions(request, headers, runtime);
        }

        public async Task<DescribeRtcUserEventListResponse> DescribeRtcUserEventListAsync(DescribeRtcUserEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRtcUserEventListWithOptionsAsync(request, headers, runtime);
        }

        public DescribeRtcUserEventListResponse DescribeRtcUserEventListWithOptions(DescribeRtcUserEventListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRtcUserEventList",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describeRtcUserEventList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRtcUserEventListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRtcUserEventListResponse> DescribeRtcUserEventListWithOptionsAsync(DescribeRtcUserEventListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRtcUserEventList",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/call/describeRtcUserEventList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRtcUserEventListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeUsageAreaDistributionStatDataResponse DescribeUsageAreaDistributionStatData(DescribeUsageAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeUsageAreaDistributionStatDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeUsageAreaDistributionStatDataResponse> DescribeUsageAreaDistributionStatDataAsync(DescribeUsageAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeUsageAreaDistributionStatDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeUsageAreaDistributionStatDataResponse DescribeUsageAreaDistributionStatDataWithOptions(DescribeUsageAreaDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentArea))
            {
                query["ParentArea"] = request.ParentArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsageAreaDistributionStatData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/usage/describeUsageAreaDistributionStatData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsageAreaDistributionStatDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeUsageAreaDistributionStatDataResponse> DescribeUsageAreaDistributionStatDataWithOptionsAsync(DescribeUsageAreaDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentArea))
            {
                query["ParentArea"] = request.ParentArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsageAreaDistributionStatData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/usage/describeUsageAreaDistributionStatData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsageAreaDistributionStatDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeUsageDistributionStatDataResponse DescribeUsageDistributionStatData(DescribeUsageDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeUsageDistributionStatDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeUsageDistributionStatDataResponse> DescribeUsageDistributionStatDataAsync(DescribeUsageDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeUsageDistributionStatDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeUsageDistributionStatDataResponse DescribeUsageDistributionStatDataWithOptions(DescribeUsageDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsageDistributionStatData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/usage/describeUsageDistributionStatData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsageDistributionStatDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeUsageDistributionStatDataResponse> DescribeUsageDistributionStatDataWithOptionsAsync(DescribeUsageDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsageDistributionStatData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/usage/describeUsageDistributionStatData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsageDistributionStatDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeUsageOsSdkVersionDistributionStatDataResponse DescribeUsageOsSdkVersionDistributionStatData(DescribeUsageOsSdkVersionDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeUsageOsSdkVersionDistributionStatDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeUsageOsSdkVersionDistributionStatDataResponse> DescribeUsageOsSdkVersionDistributionStatDataAsync(DescribeUsageOsSdkVersionDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeUsageOsSdkVersionDistributionStatDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeUsageOsSdkVersionDistributionStatDataResponse DescribeUsageOsSdkVersionDistributionStatDataWithOptions(DescribeUsageOsSdkVersionDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsageOsSdkVersionDistributionStatData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/usage/describeUsageOsSdkVersionDistributionStatData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsageOsSdkVersionDistributionStatDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeUsageOsSdkVersionDistributionStatDataResponse> DescribeUsageOsSdkVersionDistributionStatDataWithOptionsAsync(DescribeUsageOsSdkVersionDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsageOsSdkVersionDistributionStatData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/usage/describeUsageOsSdkVersionDistributionStatData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsageOsSdkVersionDistributionStatDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeUsageOverallDataResponse DescribeUsageOverallData(DescribeUsageOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeUsageOverallDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeUsageOverallDataResponse> DescribeUsageOverallDataAsync(DescribeUsageOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeUsageOverallDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeUsageOverallDataResponse DescribeUsageOverallDataWithOptions(DescribeUsageOverallDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["Types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsageOverallData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/usage/describeUsageOverallData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsageOverallDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeUsageOverallDataResponse> DescribeUsageOverallDataWithOptionsAsync(DescribeUsageOverallDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["Types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUsageOverallData",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/usage/describeUsageOverallData",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUsageOverallDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateAppExpMetricRuleResponse UpdateAppExpMetricRule(UpdateAppExpMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAppExpMetricRuleWithOptions(request, headers, runtime);
        }

        public async Task<UpdateAppExpMetricRuleResponse> UpdateAppExpMetricRuleAsync(UpdateAppExpMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAppExpMetricRuleWithOptionsAsync(request, headers, runtime);
        }

        public UpdateAppExpMetricRuleResponse UpdateAppExpMetricRuleWithOptions(UpdateAppExpMetricRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                query["Rule"] = request.Rule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAppExpMetricRule",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/config/updateAppExpMetricRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppExpMetricRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateAppExpMetricRuleResponse> UpdateAppExpMetricRuleWithOptionsAsync(UpdateAppExpMetricRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                query["Rule"] = request.Rule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAppExpMetricRule",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/config/updateAppExpMetricRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppExpMetricRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateAppFollowCallRuleResponse UpdateAppFollowCallRule(UpdateAppFollowCallRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAppFollowCallRuleWithOptions(request, headers, runtime);
        }

        public async Task<UpdateAppFollowCallRuleResponse> UpdateAppFollowCallRuleAsync(UpdateAppFollowCallRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAppFollowCallRuleWithOptionsAsync(request, headers, runtime);
        }

        public UpdateAppFollowCallRuleResponse UpdateAppFollowCallRuleWithOptions(UpdateAppFollowCallRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                query["Rule"] = request.Rule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAppFollowCallRule",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/config/updateAppFollowCallRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppFollowCallRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateAppFollowCallRuleResponse> UpdateAppFollowCallRuleWithOptionsAsync(UpdateAppFollowCallRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                query["Rule"] = request.Rule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAppFollowCallRule",
                Version = "2020-12-14",
                Protocol = "HTTPS",
                Pathname = "/api/config/updateAppFollowCallRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppFollowCallRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

    }
}
