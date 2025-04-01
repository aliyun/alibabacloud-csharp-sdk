// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Advisor20180120.Models;

namespace AlibabaCloud.SDK.Advisor20180120
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("advisor", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>根据多个维度获取用户最新的巡检结果，全量返回-openApi</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdvicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvicesResponse
        /// </returns>
        public DescribeAdvicesResponse DescribeAdvicesWithOptions(DescribeAdvicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdviceId))
            {
                query["AdviceId"] = request.AdviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckId))
            {
                query["CheckId"] = request.CheckId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckPlanId))
            {
                query["CheckPlanId"] = request.CheckPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeAdviceId))
            {
                query["ExcludeAdviceId"] = request.ExcludeAdviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAdvices",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeAdvicesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeAdvicesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据多个维度获取用户最新的巡检结果，全量返回-openApi</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdvicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvicesResponse
        /// </returns>
        public async Task<DescribeAdvicesResponse> DescribeAdvicesWithOptionsAsync(DescribeAdvicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdviceId))
            {
                query["AdviceId"] = request.AdviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckId))
            {
                query["CheckId"] = request.CheckId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckPlanId))
            {
                query["CheckPlanId"] = request.CheckPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeAdviceId))
            {
                query["ExcludeAdviceId"] = request.ExcludeAdviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAdvices",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeAdvicesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeAdvicesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据多个维度获取用户最新的巡检结果，全量返回-openApi</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdvicesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvicesResponse
        /// </returns>
        public DescribeAdvicesResponse DescribeAdvices(DescribeAdvicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAdvicesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据多个维度获取用户最新的巡检结果，全量返回-openApi</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdvicesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvicesResponse
        /// </returns>
        public async Task<DescribeAdvicesResponse> DescribeAdvicesAsync(DescribeAdvicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAdvicesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeAdvicesFlat分页</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdvicesFlatPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvicesFlatPageResponse
        /// </returns>
        public DescribeAdvicesFlatPageResponse DescribeAdvicesFlatPageWithOptions(DescribeAdvicesFlatPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdviceId))
            {
                query["AdviceId"] = request.AdviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckId))
            {
                query["CheckId"] = request.CheckId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAdvicesFlatPage",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeAdvicesFlatPageResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeAdvicesFlatPageResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeAdvicesFlat分页</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdvicesFlatPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvicesFlatPageResponse
        /// </returns>
        public async Task<DescribeAdvicesFlatPageResponse> DescribeAdvicesFlatPageWithOptionsAsync(DescribeAdvicesFlatPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdviceId))
            {
                query["AdviceId"] = request.AdviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckId))
            {
                query["CheckId"] = request.CheckId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAdvicesFlatPage",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeAdvicesFlatPageResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeAdvicesFlatPageResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeAdvicesFlat分页</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdvicesFlatPageRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvicesFlatPageResponse
        /// </returns>
        public DescribeAdvicesFlatPageResponse DescribeAdvicesFlatPage(DescribeAdvicesFlatPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAdvicesFlatPageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeAdvicesFlat分页</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdvicesFlatPageRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvicesFlatPageResponse
        /// </returns>
        public async Task<DescribeAdvicesFlatPageResponse> DescribeAdvicesFlatPageAsync(DescribeAdvicesFlatPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAdvicesFlatPageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeAdvices分页</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdvicesPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvicesPageResponse
        /// </returns>
        public DescribeAdvicesPageResponse DescribeAdvicesPageWithOptions(DescribeAdvicesPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdviceId))
            {
                query["AdviceId"] = request.AdviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckId))
            {
                query["CheckId"] = request.CheckId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckPlanId))
            {
                query["CheckPlanId"] = request.CheckPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAdvicesPage",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeAdvicesPageResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeAdvicesPageResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeAdvices分页</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdvicesPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvicesPageResponse
        /// </returns>
        public async Task<DescribeAdvicesPageResponse> DescribeAdvicesPageWithOptionsAsync(DescribeAdvicesPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdviceId))
            {
                query["AdviceId"] = request.AdviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckId))
            {
                query["CheckId"] = request.CheckId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckPlanId))
            {
                query["CheckPlanId"] = request.CheckPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAdvicesPage",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeAdvicesPageResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeAdvicesPageResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeAdvices分页</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdvicesPageRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvicesPageResponse
        /// </returns>
        public DescribeAdvicesPageResponse DescribeAdvicesPage(DescribeAdvicesPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAdvicesPageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DescribeAdvices分页</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdvicesPageRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvicesPageResponse
        /// </returns>
        public async Task<DescribeAdvicesPageResponse> DescribeAdvicesPageAsync(DescribeAdvicesPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAdvicesPageWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeAdvisorChecksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvisorChecksResponse
        /// </returns>
        public DescribeAdvisorChecksResponse DescribeAdvisorChecksWithOptions(DescribeAdvisorChecksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAdvisorChecks",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeAdvisorChecksResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeAdvisorChecksResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeAdvisorChecksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvisorChecksResponse
        /// </returns>
        public async Task<DescribeAdvisorChecksResponse> DescribeAdvisorChecksWithOptionsAsync(DescribeAdvisorChecksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAdvisorChecks",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeAdvisorChecksResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeAdvisorChecksResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeAdvisorChecksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvisorChecksResponse
        /// </returns>
        public DescribeAdvisorChecksResponse DescribeAdvisorChecks(DescribeAdvisorChecksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAdvisorChecksWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeAdvisorChecksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvisorChecksResponse
        /// </returns>
        public async Task<DescribeAdvisorChecksResponse> DescribeAdvisorChecksAsync(DescribeAdvisorChecksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAdvisorChecksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>巡检项设置-分页</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeAdvisorChecksFoPagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvisorChecksFoPagesResponse
        /// </returns>
        public DescribeAdvisorChecksFoPagesResponse DescribeAdvisorChecksFoPagesWithOptions(DescribeAdvisorChecksFoPagesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeAdvisorChecksFoPagesShrinkRequest request = new DescribeAdvisorChecksFoPagesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CheckTypes))
            {
                request.CheckTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CheckTypes, "CheckTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeAliyunId))
            {
                query["AssumeAliyunId"] = request.AssumeAliyunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCategory))
            {
                query["BizCategory"] = request.BizCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckTypesShrink))
            {
                query["CheckTypes"] = request.CheckTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAdvisorChecksFoPages",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeAdvisorChecksFoPagesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeAdvisorChecksFoPagesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>巡检项设置-分页</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeAdvisorChecksFoPagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvisorChecksFoPagesResponse
        /// </returns>
        public async Task<DescribeAdvisorChecksFoPagesResponse> DescribeAdvisorChecksFoPagesWithOptionsAsync(DescribeAdvisorChecksFoPagesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeAdvisorChecksFoPagesShrinkRequest request = new DescribeAdvisorChecksFoPagesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CheckTypes))
            {
                request.CheckTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CheckTypes, "CheckTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeAliyunId))
            {
                query["AssumeAliyunId"] = request.AssumeAliyunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCategory))
            {
                query["BizCategory"] = request.BizCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckTypesShrink))
            {
                query["CheckTypes"] = request.CheckTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAdvisorChecksFoPages",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeAdvisorChecksFoPagesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeAdvisorChecksFoPagesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>巡检项设置-分页</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdvisorChecksFoPagesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvisorChecksFoPagesResponse
        /// </returns>
        public DescribeAdvisorChecksFoPagesResponse DescribeAdvisorChecksFoPages(DescribeAdvisorChecksFoPagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAdvisorChecksFoPagesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>巡检项设置-分页</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAdvisorChecksFoPagesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvisorChecksFoPagesResponse
        /// </returns>
        public async Task<DescribeAdvisorChecksFoPagesResponse> DescribeAdvisorChecksFoPagesAsync(DescribeAdvisorChecksFoPagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAdvisorChecksFoPagesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeAdvisorResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvisorResourcesResponse
        /// </returns>
        public DescribeAdvisorResourcesResponse DescribeAdvisorResourcesWithOptions(DescribeAdvisorResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAdvisorResources",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeAdvisorResourcesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeAdvisorResourcesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeAdvisorResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvisorResourcesResponse
        /// </returns>
        public async Task<DescribeAdvisorResourcesResponse> DescribeAdvisorResourcesWithOptionsAsync(DescribeAdvisorResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAdvisorResources",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeAdvisorResourcesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeAdvisorResourcesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// DescribeAdvisorResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvisorResourcesResponse
        /// </returns>
        public DescribeAdvisorResourcesResponse DescribeAdvisorResources(DescribeAdvisorResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAdvisorResourcesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeAdvisorResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAdvisorResourcesResponse
        /// </returns>
        public async Task<DescribeAdvisorResourcesResponse> DescribeAdvisorResourcesAsync(DescribeAdvisorResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAdvisorResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询成本优化结果详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeCostCheckAdvicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCostCheckAdvicesResponse
        /// </returns>
        public DescribeCostCheckAdvicesResponse DescribeCostCheckAdvicesWithOptions(DescribeCostCheckAdvicesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeCostCheckAdvicesShrinkRequest request = new DescribeCostCheckAdvicesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AssumeAliyunIdList))
            {
                request.AssumeAliyunIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AssumeAliyunIdList, "AssumeAliyunIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RegionIds))
            {
                request.RegionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RegionIds, "RegionIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIds))
            {
                request.ResourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIds, "ResourceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagKeys))
            {
                request.TagKeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagKeys, "TagKeys", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagList))
            {
                request.TagListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagList, "TagList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagValues))
            {
                request.TagValuesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagValues, "TagValues", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeAliyunIdListShrink))
            {
                query["AssumeAliyunIdList"] = request.AssumeAliyunIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckId))
            {
                query["CheckId"] = request.CheckId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsShrink))
            {
                query["RegionIds"] = request.RegionIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdsShrink))
            {
                query["ResourceIds"] = request.ResourceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Severity))
            {
                query["Severity"] = request.Severity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeysShrink))
            {
                query["TagKeys"] = request.TagKeysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagListShrink))
            {
                query["TagList"] = request.TagListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagValuesShrink))
            {
                query["TagValues"] = request.TagValuesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCostCheckAdvices",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeCostCheckAdvicesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeCostCheckAdvicesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询成本优化结果详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeCostCheckAdvicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCostCheckAdvicesResponse
        /// </returns>
        public async Task<DescribeCostCheckAdvicesResponse> DescribeCostCheckAdvicesWithOptionsAsync(DescribeCostCheckAdvicesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeCostCheckAdvicesShrinkRequest request = new DescribeCostCheckAdvicesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AssumeAliyunIdList))
            {
                request.AssumeAliyunIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AssumeAliyunIdList, "AssumeAliyunIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RegionIds))
            {
                request.RegionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RegionIds, "RegionIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIds))
            {
                request.ResourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIds, "ResourceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagKeys))
            {
                request.TagKeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagKeys, "TagKeys", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagList))
            {
                request.TagListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagList, "TagList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagValues))
            {
                request.TagValuesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagValues, "TagValues", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeAliyunIdListShrink))
            {
                query["AssumeAliyunIdList"] = request.AssumeAliyunIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckId))
            {
                query["CheckId"] = request.CheckId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsShrink))
            {
                query["RegionIds"] = request.RegionIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdsShrink))
            {
                query["ResourceIds"] = request.ResourceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Severity))
            {
                query["Severity"] = request.Severity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeysShrink))
            {
                query["TagKeys"] = request.TagKeysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagListShrink))
            {
                query["TagList"] = request.TagListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagValuesShrink))
            {
                query["TagValues"] = request.TagValuesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCostCheckAdvices",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeCostCheckAdvicesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeCostCheckAdvicesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询成本优化结果详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCostCheckAdvicesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCostCheckAdvicesResponse
        /// </returns>
        public DescribeCostCheckAdvicesResponse DescribeCostCheckAdvices(DescribeCostCheckAdvicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCostCheckAdvicesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询成本优化结果详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCostCheckAdvicesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCostCheckAdvicesResponse
        /// </returns>
        public async Task<DescribeCostCheckAdvicesResponse> DescribeCostCheckAdvicesAsync(DescribeCostCheckAdvicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCostCheckAdvicesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询巡检项聚合成本优化结果概览</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeCostCheckResultsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCostCheckResultsResponse
        /// </returns>
        public DescribeCostCheckResultsResponse DescribeCostCheckResultsWithOptions(DescribeCostCheckResultsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeCostCheckResultsShrinkRequest request = new DescribeCostCheckResultsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AssumeAliyunIdList))
            {
                request.AssumeAliyunIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AssumeAliyunIdList, "AssumeAliyunIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CheckIds))
            {
                request.CheckIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CheckIds, "CheckIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RegionIds))
            {
                request.RegionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RegionIds, "RegionIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceGroupIdList))
            {
                request.ResourceGroupIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceGroupIdList, "ResourceGroupIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIds))
            {
                request.ResourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIds, "ResourceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagKeys))
            {
                request.TagKeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagKeys, "TagKeys", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagList))
            {
                request.TagListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagList, "TagList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagValues))
            {
                request.TagValuesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagValues, "TagValues", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeAliyunIdListShrink))
            {
                query["AssumeAliyunIdList"] = request.AssumeAliyunIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckIdsShrink))
            {
                query["CheckIds"] = request.CheckIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["GroupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsShrink))
            {
                query["RegionIds"] = request.RegionIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIdListShrink))
            {
                query["ResourceGroupIdList"] = request.ResourceGroupIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdsShrink))
            {
                query["ResourceIds"] = request.ResourceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Severity))
            {
                query["Severity"] = request.Severity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeysShrink))
            {
                query["TagKeys"] = request.TagKeysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagListShrink))
            {
                query["TagList"] = request.TagListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagValuesShrink))
            {
                query["TagValues"] = request.TagValuesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCostCheckResults",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeCostCheckResultsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeCostCheckResultsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询巡检项聚合成本优化结果概览</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeCostCheckResultsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCostCheckResultsResponse
        /// </returns>
        public async Task<DescribeCostCheckResultsResponse> DescribeCostCheckResultsWithOptionsAsync(DescribeCostCheckResultsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeCostCheckResultsShrinkRequest request = new DescribeCostCheckResultsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AssumeAliyunIdList))
            {
                request.AssumeAliyunIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AssumeAliyunIdList, "AssumeAliyunIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CheckIds))
            {
                request.CheckIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CheckIds, "CheckIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RegionIds))
            {
                request.RegionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RegionIds, "RegionIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceGroupIdList))
            {
                request.ResourceGroupIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceGroupIdList, "ResourceGroupIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIds))
            {
                request.ResourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIds, "ResourceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagKeys))
            {
                request.TagKeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagKeys, "TagKeys", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagList))
            {
                request.TagListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagList, "TagList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagValues))
            {
                request.TagValuesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagValues, "TagValues", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeAliyunIdListShrink))
            {
                query["AssumeAliyunIdList"] = request.AssumeAliyunIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckIdsShrink))
            {
                query["CheckIds"] = request.CheckIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["GroupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIdsShrink))
            {
                query["RegionIds"] = request.RegionIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIdListShrink))
            {
                query["ResourceGroupIdList"] = request.ResourceGroupIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdsShrink))
            {
                query["ResourceIds"] = request.ResourceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Severity))
            {
                query["Severity"] = request.Severity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeysShrink))
            {
                query["TagKeys"] = request.TagKeysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagListShrink))
            {
                query["TagList"] = request.TagListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagValuesShrink))
            {
                query["TagValues"] = request.TagValuesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCostCheckResults",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeCostCheckResultsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeCostCheckResultsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询巡检项聚合成本优化结果概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCostCheckResultsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCostCheckResultsResponse
        /// </returns>
        public DescribeCostCheckResultsResponse DescribeCostCheckResults(DescribeCostCheckResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCostCheckResultsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询巡检项聚合成本优化结果概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCostCheckResultsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCostCheckResultsResponse
        /// </returns>
        public async Task<DescribeCostCheckResultsResponse> DescribeCostCheckResultsAsync(DescribeCostCheckResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCostCheckResultsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>成本优化-概览</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeCostOptimizationOverviewRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCostOptimizationOverviewResponse
        /// </returns>
        public DescribeCostOptimizationOverviewResponse DescribeCostOptimizationOverviewWithOptions(DescribeCostOptimizationOverviewRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeCostOptimizationOverviewShrinkRequest request = new DescribeCostOptimizationOverviewShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AssumeAliyunIdList))
            {
                request.AssumeAliyunIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AssumeAliyunIdList, "AssumeAliyunIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeAliyunId))
            {
                query["AssumeAliyunId"] = request.AssumeAliyunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeAliyunIdListShrink))
            {
                query["AssumeAliyunIdList"] = request.AssumeAliyunIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCostOptimizationOverview",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeCostOptimizationOverviewResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeCostOptimizationOverviewResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>成本优化-概览</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeCostOptimizationOverviewRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCostOptimizationOverviewResponse
        /// </returns>
        public async Task<DescribeCostOptimizationOverviewResponse> DescribeCostOptimizationOverviewWithOptionsAsync(DescribeCostOptimizationOverviewRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeCostOptimizationOverviewShrinkRequest request = new DescribeCostOptimizationOverviewShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AssumeAliyunIdList))
            {
                request.AssumeAliyunIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AssumeAliyunIdList, "AssumeAliyunIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeAliyunId))
            {
                query["AssumeAliyunId"] = request.AssumeAliyunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeAliyunIdListShrink))
            {
                query["AssumeAliyunIdList"] = request.AssumeAliyunIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCostOptimizationOverview",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeCostOptimizationOverviewResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeCostOptimizationOverviewResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>成本优化-概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCostOptimizationOverviewRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCostOptimizationOverviewResponse
        /// </returns>
        public DescribeCostOptimizationOverviewResponse DescribeCostOptimizationOverview(DescribeCostOptimizationOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCostOptimizationOverviewWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>成本优化-概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCostOptimizationOverviewRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCostOptimizationOverviewResponse
        /// </returns>
        public async Task<DescribeCostOptimizationOverviewResponse> DescribeCostOptimizationOverviewAsync(DescribeCostOptimizationOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCostOptimizationOverviewWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetHistoryAdvicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHistoryAdvicesResponse
        /// </returns>
        public GetHistoryAdvicesResponse GetHistoryAdvicesWithOptions(GetHistoryAdvicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["Reverse"] = request.Reverse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Severity))
            {
                query["Severity"] = request.Severity;
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
                Action = "GetHistoryAdvices",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHistoryAdvicesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHistoryAdvicesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// GetHistoryAdvicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHistoryAdvicesResponse
        /// </returns>
        public async Task<GetHistoryAdvicesResponse> GetHistoryAdvicesWithOptionsAsync(GetHistoryAdvicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["Reverse"] = request.Reverse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Severity))
            {
                query["Severity"] = request.Severity;
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
                Action = "GetHistoryAdvices",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetHistoryAdvicesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetHistoryAdvicesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// GetHistoryAdvicesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHistoryAdvicesResponse
        /// </returns>
        public GetHistoryAdvicesResponse GetHistoryAdvices(GetHistoryAdvicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHistoryAdvicesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetHistoryAdvicesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHistoryAdvicesResponse
        /// </returns>
        public async Task<GetHistoryAdvicesResponse> GetHistoryAdvicesAsync(GetHistoryAdvicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHistoryAdvicesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务执行进度(普通用户、RD单账号)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInspectProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInspectProgressResponse
        /// </returns>
        public GetInspectProgressResponse GetInspectProgressWithOptions(GetInspectProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeAliyunId))
            {
                query["AssumeAliyunId"] = request.AssumeAliyunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInspectProgress",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetInspectProgressResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetInspectProgressResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务执行进度(普通用户、RD单账号)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInspectProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInspectProgressResponse
        /// </returns>
        public async Task<GetInspectProgressResponse> GetInspectProgressWithOptionsAsync(GetInspectProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeAliyunId))
            {
                query["AssumeAliyunId"] = request.AssumeAliyunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInspectProgress",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetInspectProgressResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetInspectProgressResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务执行进度(普通用户、RD单账号)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInspectProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInspectProgressResponse
        /// </returns>
        public GetInspectProgressResponse GetInspectProgress(GetInspectProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInspectProgressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务执行进度(普通用户、RD单账号)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInspectProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInspectProgressResponse
        /// </returns>
        public async Task<GetInspectProgressResponse> GetInspectProgressAsync(GetInspectProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInspectProgressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取云产品的列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProductListResponse
        /// </returns>
        public GetProductListResponse GetProductListWithOptions(GetProductListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProductList",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetProductListResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetProductListResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取云产品的列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProductListResponse
        /// </returns>
        public async Task<GetProductListResponse> GetProductListWithOptionsAsync(GetProductListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProductList",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetProductListResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetProductListResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取云产品的列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProductListResponse
        /// </returns>
        public GetProductListResponse GetProductList(GetProductListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProductListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取云产品的列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProductListResponse
        /// </returns>
        public async Task<GetProductListResponse> GetProductListAsync(GetProductListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProductListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据id获取任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskStatusByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskStatusByIdResponse
        /// </returns>
        public GetTaskStatusByIdResponse GetTaskStatusByIdWithOptions(GetTaskStatusByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskStatusById",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetTaskStatusByIdResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetTaskStatusByIdResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据id获取任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskStatusByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskStatusByIdResponse
        /// </returns>
        public async Task<GetTaskStatusByIdResponse> GetTaskStatusByIdWithOptionsAsync(GetTaskStatusByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskStatusById",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetTaskStatusByIdResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetTaskStatusByIdResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据id获取任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskStatusByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskStatusByIdResponse
        /// </returns>
        public GetTaskStatusByIdResponse GetTaskStatusById(GetTaskStatusByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTaskStatusByIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据id获取任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskStatusByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskStatusByIdResponse
        /// </returns>
        public async Task<GetTaskStatusByIdResponse> GetTaskStatusByIdAsync(GetTaskStatusByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTaskStatusByIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>触发立即巡检</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RefreshAdvisorCheckRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefreshAdvisorCheckResponse
        /// </returns>
        public RefreshAdvisorCheckResponse RefreshAdvisorCheckWithOptions(RefreshAdvisorCheckRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RefreshAdvisorCheckShrinkRequest request = new RefreshAdvisorCheckShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceDimensionList))
            {
                request.ResourceDimensionListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceDimensionList, "ResourceDimensionList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeAliyunId))
            {
                query["AssumeAliyunId"] = request.AssumeAliyunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckId))
            {
                query["CheckId"] = request.CheckId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckPlanId))
            {
                query["CheckPlanId"] = request.CheckPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceDimensionListShrink))
            {
                body["ResourceDimensionList"] = request.ResourceDimensionListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshAdvisorCheck",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RefreshAdvisorCheckResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RefreshAdvisorCheckResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>触发立即巡检</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RefreshAdvisorCheckRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefreshAdvisorCheckResponse
        /// </returns>
        public async Task<RefreshAdvisorCheckResponse> RefreshAdvisorCheckWithOptionsAsync(RefreshAdvisorCheckRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RefreshAdvisorCheckShrinkRequest request = new RefreshAdvisorCheckShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceDimensionList))
            {
                request.ResourceDimensionListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceDimensionList, "ResourceDimensionList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeAliyunId))
            {
                query["AssumeAliyunId"] = request.AssumeAliyunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckId))
            {
                query["CheckId"] = request.CheckId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckPlanId))
            {
                query["CheckPlanId"] = request.CheckPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceDimensionListShrink))
            {
                body["ResourceDimensionList"] = request.ResourceDimensionListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshAdvisorCheck",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RefreshAdvisorCheckResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RefreshAdvisorCheckResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>触发立即巡检</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefreshAdvisorCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// RefreshAdvisorCheckResponse
        /// </returns>
        public RefreshAdvisorCheckResponse RefreshAdvisorCheck(RefreshAdvisorCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshAdvisorCheckWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>触发立即巡检</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefreshAdvisorCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// RefreshAdvisorCheckResponse
        /// </returns>
        public async Task<RefreshAdvisorCheckResponse> RefreshAdvisorCheckAsync(RefreshAdvisorCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshAdvisorCheckWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发起成本优化巡检</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RefreshAdvisorCostCheckRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefreshAdvisorCostCheckResponse
        /// </returns>
        public RefreshAdvisorCostCheckResponse RefreshAdvisorCostCheckWithOptions(RefreshAdvisorCostCheckRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RefreshAdvisorCostCheckShrinkRequest request = new RefreshAdvisorCostCheckShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AssumeAliyunIdList))
            {
                request.AssumeAliyunIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AssumeAliyunIdList, "AssumeAliyunIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CheckIds))
            {
                request.CheckIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CheckIds, "CheckIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIds))
            {
                request.ResourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIds, "ResourceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeAliyunIdListShrink))
            {
                query["AssumeAliyunIdList"] = request.AssumeAliyunIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckIdsShrink))
            {
                query["CheckIds"] = request.CheckIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefreshResource))
            {
                query["RefreshResource"] = request.RefreshResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdsShrink))
            {
                query["ResourceIds"] = request.ResourceIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshAdvisorCostCheck",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RefreshAdvisorCostCheckResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RefreshAdvisorCostCheckResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发起成本优化巡检</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RefreshAdvisorCostCheckRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefreshAdvisorCostCheckResponse
        /// </returns>
        public async Task<RefreshAdvisorCostCheckResponse> RefreshAdvisorCostCheckWithOptionsAsync(RefreshAdvisorCostCheckRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RefreshAdvisorCostCheckShrinkRequest request = new RefreshAdvisorCostCheckShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AssumeAliyunIdList))
            {
                request.AssumeAliyunIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AssumeAliyunIdList, "AssumeAliyunIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CheckIds))
            {
                request.CheckIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CheckIds, "CheckIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIds))
            {
                request.ResourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIds, "ResourceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeAliyunIdListShrink))
            {
                query["AssumeAliyunIdList"] = request.AssumeAliyunIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckIdsShrink))
            {
                query["CheckIds"] = request.CheckIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefreshResource))
            {
                query["RefreshResource"] = request.RefreshResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdsShrink))
            {
                query["ResourceIds"] = request.ResourceIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshAdvisorCostCheck",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RefreshAdvisorCostCheckResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RefreshAdvisorCostCheckResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发起成本优化巡检</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefreshAdvisorCostCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// RefreshAdvisorCostCheckResponse
        /// </returns>
        public RefreshAdvisorCostCheckResponse RefreshAdvisorCostCheck(RefreshAdvisorCostCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshAdvisorCostCheckWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发起成本优化巡检</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefreshAdvisorCostCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// RefreshAdvisorCostCheckResponse
        /// </returns>
        public async Task<RefreshAdvisorCostCheckResponse> RefreshAdvisorCostCheckAsync(RefreshAdvisorCostCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshAdvisorCostCheckWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// RefreshAdvisorResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefreshAdvisorResourceResponse
        /// </returns>
        public RefreshAdvisorResourceResponse RefreshAdvisorResourceWithOptions(RefreshAdvisorResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshAdvisorResource",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RefreshAdvisorResourceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RefreshAdvisorResourceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// RefreshAdvisorResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefreshAdvisorResourceResponse
        /// </returns>
        public async Task<RefreshAdvisorResourceResponse> RefreshAdvisorResourceWithOptionsAsync(RefreshAdvisorResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                query["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshAdvisorResource",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RefreshAdvisorResourceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RefreshAdvisorResourceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// RefreshAdvisorResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// RefreshAdvisorResourceResponse
        /// </returns>
        public RefreshAdvisorResourceResponse RefreshAdvisorResource(RefreshAdvisorResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshAdvisorResourceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RefreshAdvisorResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// RefreshAdvisorResourceResponse
        /// </returns>
        public async Task<RefreshAdvisorResourceResponse> RefreshAdvisorResourceAsync(RefreshAdvisorResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshAdvisorResourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上报用户业务报警信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ReportBizAlertInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReportBizAlertInfoResponse
        /// </returns>
        public ReportBizAlertInfoResponse ReportBizAlertInfoWithOptions(ReportBizAlertInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ReportBizAlertInfoShrinkRequest request = new ReportBizAlertInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AlertUid))
            {
                request.AlertUidShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AlertUid, "AlertUid", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertDescription))
            {
                query["AlertDescription"] = request.AlertDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertDetail))
            {
                query["AlertDetail"] = request.AlertDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertGrade))
            {
                query["AlertGrade"] = request.AlertGrade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertLabels))
            {
                query["AlertLabels"] = request.AlertLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertScene))
            {
                query["AlertScene"] = request.AlertScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertToken))
            {
                query["AlertToken"] = request.AlertToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertUidShrink))
            {
                query["AlertUid"] = request.AlertUidShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportBizAlertInfo",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ReportBizAlertInfoResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ReportBizAlertInfoResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上报用户业务报警信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ReportBizAlertInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReportBizAlertInfoResponse
        /// </returns>
        public async Task<ReportBizAlertInfoResponse> ReportBizAlertInfoWithOptionsAsync(ReportBizAlertInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ReportBizAlertInfoShrinkRequest request = new ReportBizAlertInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AlertUid))
            {
                request.AlertUidShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AlertUid, "AlertUid", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertDescription))
            {
                query["AlertDescription"] = request.AlertDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertDetail))
            {
                query["AlertDetail"] = request.AlertDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertGrade))
            {
                query["AlertGrade"] = request.AlertGrade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertLabels))
            {
                query["AlertLabels"] = request.AlertLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertScene))
            {
                query["AlertScene"] = request.AlertScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertToken))
            {
                query["AlertToken"] = request.AlertToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertUidShrink))
            {
                query["AlertUid"] = request.AlertUidShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportBizAlertInfo",
                Version = "2018-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ReportBizAlertInfoResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ReportBizAlertInfoResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上报用户业务报警信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReportBizAlertInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ReportBizAlertInfoResponse
        /// </returns>
        public ReportBizAlertInfoResponse ReportBizAlertInfo(ReportBizAlertInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportBizAlertInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上报用户业务报警信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReportBizAlertInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ReportBizAlertInfoResponse
        /// </returns>
        public async Task<ReportBizAlertInfoResponse> ReportBizAlertInfoAsync(ReportBizAlertInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportBizAlertInfoWithOptionsAsync(request, runtime);
        }

    }
}
