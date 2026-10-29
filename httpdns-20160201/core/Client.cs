// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Httpdns20160201.Models;

namespace AlibabaCloud.SDK.Httpdns20160201
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-hangzhou", "httpdns-api.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("httpdns", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Adds a domain name based on the specified parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDomainResponse
        /// </returns>
        public AddDomainResponse AddDomainWithOptions(AddDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDomain",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a domain name based on the specified parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddDomainResponse
        /// </returns>
        public async Task<AddDomainResponse> AddDomainWithOptionsAsync(AddDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDomain",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a domain name based on the specified parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDomainResponse
        /// </returns>
        public AddDomainResponse AddDomain(AddDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDomainWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a domain name based on the specified parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// AddDomainResponse
        /// </returns>
        public async Task<AddDomainResponse> AddDomainAsync(AddDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDomainWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom resolution policy for a domain name connected to the current account. This operation supports the LINE mode and the IP_RANGE mode. IP address ranges can include IPv4 and IPv6 addresses. When a match occurs, A or AAAA records are returned based on the rules. By default, the policy is created in the disabled state. If Enable is set to true, the policy is enabled upon creation, but actual resolution still requires waiting for configuration propagation. The returned Id is used for subsequent queries, updates, enabling, disabling, and deletion. Create a disabled policy first, and then enable it after querying and verifying it. The policy type and the bound domain name cannot be modified after creation. If the response times out or is lost, query the list first to verify and avoid duplicate creation.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateSdnsRuleCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSdnsRuleCategoryResponse
        /// </returns>
        public CreateSdnsRuleCategoryResponse CreateSdnsRuleCategoryWithOptions(CreateSdnsRuleCategoryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSdnsRuleCategoryShrinkRequest request = new CreateSdnsRuleCategoryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClientIpRanges))
            {
                request.ClientIpRangesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClientIpRanges, "ClientIpRanges", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Paths))
            {
                request.PathsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Paths, "Paths", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rules))
            {
                request.RulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rules, "Rules", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIpRangesShrink))
            {
                body["ClientIpRanges"] = request.ClientIpRangesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LineId))
            {
                body["LineId"] = request.LineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchType))
            {
                body["MatchType"] = request.MatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PathsShrink))
            {
                body["Paths"] = request.PathsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RulesShrink))
            {
                body["Rules"] = request.RulesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSdnsRuleCategory",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSdnsRuleCategoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom resolution policy for a domain name connected to the current account. This operation supports the LINE mode and the IP_RANGE mode. IP address ranges can include IPv4 and IPv6 addresses. When a match occurs, A or AAAA records are returned based on the rules. By default, the policy is created in the disabled state. If Enable is set to true, the policy is enabled upon creation, but actual resolution still requires waiting for configuration propagation. The returned Id is used for subsequent queries, updates, enabling, disabling, and deletion. Create a disabled policy first, and then enable it after querying and verifying it. The policy type and the bound domain name cannot be modified after creation. If the response times out or is lost, query the list first to verify and avoid duplicate creation.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateSdnsRuleCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSdnsRuleCategoryResponse
        /// </returns>
        public async Task<CreateSdnsRuleCategoryResponse> CreateSdnsRuleCategoryWithOptionsAsync(CreateSdnsRuleCategoryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSdnsRuleCategoryShrinkRequest request = new CreateSdnsRuleCategoryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClientIpRanges))
            {
                request.ClientIpRangesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClientIpRanges, "ClientIpRanges", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Paths))
            {
                request.PathsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Paths, "Paths", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rules))
            {
                request.RulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rules, "Rules", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIpRangesShrink))
            {
                body["ClientIpRanges"] = request.ClientIpRangesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LineId))
            {
                body["LineId"] = request.LineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchType))
            {
                body["MatchType"] = request.MatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PathsShrink))
            {
                body["Paths"] = request.PathsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RulesShrink))
            {
                body["Rules"] = request.RulesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSdnsRuleCategory",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSdnsRuleCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom resolution policy for a domain name connected to the current account. This operation supports the LINE mode and the IP_RANGE mode. IP address ranges can include IPv4 and IPv6 addresses. When a match occurs, A or AAAA records are returned based on the rules. By default, the policy is created in the disabled state. If Enable is set to true, the policy is enabled upon creation, but actual resolution still requires waiting for configuration propagation. The returned Id is used for subsequent queries, updates, enabling, disabling, and deletion. Create a disabled policy first, and then enable it after querying and verifying it. The policy type and the bound domain name cannot be modified after creation. If the response times out or is lost, query the list first to verify and avoid duplicate creation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSdnsRuleCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSdnsRuleCategoryResponse
        /// </returns>
        public CreateSdnsRuleCategoryResponse CreateSdnsRuleCategory(CreateSdnsRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSdnsRuleCategoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom resolution policy for a domain name connected to the current account. This operation supports the LINE mode and the IP_RANGE mode. IP address ranges can include IPv4 and IPv6 addresses. When a match occurs, A or AAAA records are returned based on the rules. By default, the policy is created in the disabled state. If Enable is set to true, the policy is enabled upon creation, but actual resolution still requires waiting for configuration propagation. The returned Id is used for subsequent queries, updates, enabling, disabling, and deletion. Create a disabled policy first, and then enable it after querying and verifying it. The policy type and the bound domain name cannot be modified after creation. If the response times out or is lost, query the list first to verify and avoid duplicate creation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSdnsRuleCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSdnsRuleCategoryResponse
        /// </returns>
        public async Task<CreateSdnsRuleCategoryResponse> CreateSdnsRuleCategoryAsync(CreateSdnsRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSdnsRuleCategoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a domain name based on the specified parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDomainResponse
        /// </returns>
        public DeleteDomainResponse DeleteDomainWithOptions(DeleteDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomain",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a domain name based on the specified parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDomainResponse
        /// </returns>
        public async Task<DeleteDomainResponse> DeleteDomainWithOptionsAsync(DeleteDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomain",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a domain name based on the specified parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDomainResponse
        /// </returns>
        public DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDomainWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a domain name based on the specified parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDomainResponse
        /// </returns>
        public async Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDomainWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the domain names of a user based on the specified parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDomainsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainsResponse
        /// </returns>
        public DescribeDomainsResponse DescribeDomainsWithOptions(DescribeDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomains",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the domain names of a user based on the specified parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDomainsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainsResponse
        /// </returns>
        public async Task<DescribeDomainsResponse> DescribeDomainsWithOptionsAsync(DescribeDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomains",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the domain names of a user based on the specified parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainsResponse
        /// </returns>
        public DescribeDomainsResponse DescribeDomains(DescribeDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the domain names of a user based on the specified parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDomainsResponse
        /// </returns>
        public async Task<DescribeDomainsResponse> DescribeDomainsAsync(DescribeDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the current HTTPDNS account information.</para>
        /// </summary>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccountInfoResponse
        /// </returns>
        public GetAccountInfoResponse GetAccountInfoWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountInfo",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the current HTTPDNS account information.</para>
        /// </summary>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccountInfoResponse
        /// </returns>
        public async Task<GetAccountInfoResponse> GetAccountInfoWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountInfo",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the current HTTPDNS account information.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAccountInfoResponse
        /// </returns>
        public GetAccountInfoResponse GetAccountInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccountInfoWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the current HTTPDNS account information.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAccountInfoResponse
        /// </returns>
        public async Task<GetAccountInfoResponse> GetAccountInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccountInfoWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves parse and billing statistics, corresponding to the &quot;Billing&quot; page feature in the console.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResolveCountSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResolveCountSummaryResponse
        /// </returns>
        public GetResolveCountSummaryResponse GetResolveCountSummaryWithOptions(GetResolveCountSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeSpan))
            {
                query["TimeSpan"] = request.TimeSpan;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResolveCountSummary",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResolveCountSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves parse and billing statistics, corresponding to the &quot;Billing&quot; page feature in the console.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResolveCountSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResolveCountSummaryResponse
        /// </returns>
        public async Task<GetResolveCountSummaryResponse> GetResolveCountSummaryWithOptionsAsync(GetResolveCountSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeSpan))
            {
                query["TimeSpan"] = request.TimeSpan;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResolveCountSummary",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResolveCountSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves parse and billing statistics, corresponding to the &quot;Billing&quot; page feature in the console.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResolveCountSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResolveCountSummaryResponse
        /// </returns>
        public GetResolveCountSummaryResponse GetResolveCountSummary(GetResolveCountSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResolveCountSummaryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves parse and billing statistics, corresponding to the &quot;Billing&quot; page feature in the console.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResolveCountSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResolveCountSummaryResponse
        /// </returns>
        public async Task<GetResolveCountSummaryResponse> GetResolveCountSummaryAsync(GetResolveCountSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResolveCountSummaryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the statistics information of parse requests for a specific domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResolveStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResolveStatisticsResponse
        /// </returns>
        public GetResolveStatisticsResponse GetResolveStatisticsWithOptions(GetResolveStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolName))
            {
                query["ProtocolName"] = request.ProtocolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeSpan))
            {
                query["TimeSpan"] = request.TimeSpan;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResolveStatistics",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResolveStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the statistics information of parse requests for a specific domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResolveStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResolveStatisticsResponse
        /// </returns>
        public async Task<GetResolveStatisticsResponse> GetResolveStatisticsWithOptionsAsync(GetResolveStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Granularity))
            {
                query["Granularity"] = request.Granularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolName))
            {
                query["ProtocolName"] = request.ProtocolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeSpan))
            {
                query["TimeSpan"] = request.TimeSpan;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResolveStatistics",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResolveStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the statistics information of parse requests for a specific domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResolveStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResolveStatisticsResponse
        /// </returns>
        public GetResolveStatisticsResponse GetResolveStatistics(GetResolveStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResolveStatisticsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the statistics information of parse requests for a specific domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResolveStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResolveStatisticsResponse
        /// </returns>
        public async Task<GetResolveStatisticsResponse> GetResolveStatisticsAsync(GetResolveStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResolveStatisticsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the domain names and resolution counts of a user based on the specified parameters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Operation description</h1>
        /// <list type="bullet">
        /// <item><description>You can specify the page number (PageNumber) and the number of entries per page (PageSize) for the query.</description></item>
        /// <item><description>By default, the domain name list is sorted in descending order of the time when the domain names were added.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDomainsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDomainsResponse
        /// </returns>
        public ListDomainsResponse ListDomainsWithOptions(ListDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithoutMeteringData))
            {
                query["WithoutMeteringData"] = request.WithoutMeteringData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDomains",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDomainsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the domain names and resolution counts of a user based on the specified parameters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Operation description</h1>
        /// <list type="bullet">
        /// <item><description>You can specify the page number (PageNumber) and the number of entries per page (PageSize) for the query.</description></item>
        /// <item><description>By default, the domain name list is sorted in descending order of the time when the domain names were added.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDomainsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDomainsResponse
        /// </returns>
        public async Task<ListDomainsResponse> ListDomainsWithOptionsAsync(ListDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithoutMeteringData))
            {
                query["WithoutMeteringData"] = request.WithoutMeteringData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDomains",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the domain names and resolution counts of a user based on the specified parameters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Operation description</h1>
        /// <list type="bullet">
        /// <item><description>You can specify the page number (PageNumber) and the number of entries per page (PageSize) for the query.</description></item>
        /// <item><description>By default, the domain name list is sorted in descending order of the time when the domain names were added.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDomainsResponse
        /// </returns>
        public ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDomainsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the domain names and resolution counts of a user based on the specified parameters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Operation description</h1>
        /// <list type="bullet">
        /// <item><description>You can specify the page number (PageNumber) and the number of entries per page (PageSize) for the query.</description></item>
        /// <item><description>By default, the domain name list is sorted in descending order of the time when the domain names were added.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDomainsResponse
        /// </returns>
        public async Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDomainsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Refreshes the domain name cache.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RefreshResolveCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefreshResolveCacheResponse
        /// </returns>
        public RefreshResolveCacheResponse RefreshResolveCacheWithOptions(RefreshResolveCacheRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RefreshResolveCacheShrinkRequest request = new RefreshResolveCacheShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Domains))
            {
                request.DomainsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Domains, "Domains", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainsShrink))
            {
                query["Domains"] = request.DomainsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshResolveCache",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshResolveCacheResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Refreshes the domain name cache.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RefreshResolveCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefreshResolveCacheResponse
        /// </returns>
        public async Task<RefreshResolveCacheResponse> RefreshResolveCacheWithOptionsAsync(RefreshResolveCacheRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RefreshResolveCacheShrinkRequest request = new RefreshResolveCacheShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Domains))
            {
                request.DomainsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Domains, "Domains", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainsShrink))
            {
                query["Domains"] = request.DomainsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshResolveCache",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshResolveCacheResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Refreshes the domain name cache.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefreshResolveCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// RefreshResolveCacheResponse
        /// </returns>
        public RefreshResolveCacheResponse RefreshResolveCache(RefreshResolveCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshResolveCacheWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Refreshes the domain name cache.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RefreshResolveCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// RefreshResolveCacheResponse
        /// </returns>
        public async Task<RefreshResolveCacheResponse> RefreshResolveCacheAsync(RefreshResolveCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshResolveCacheWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom resolution policy of the current account by policy ID. A deleted policy cannot be recovered by using its original ID, and a new ID is generated when the policy is recreated. Disable the policy and verify the resolution results before deletion. After an address block policy is deleted, its scope is excluded from overlap checks with other policies. Actual resolution takes effect after configuration propagation. You can call SdnsListRuleCategories to verify the deletion.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SdnsDeleteRuleCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SdnsDeleteRuleCategoryResponse
        /// </returns>
        public SdnsDeleteRuleCategoryResponse SdnsDeleteRuleCategoryWithOptions(SdnsDeleteRuleCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SdnsDeleteRuleCategory",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SdnsDeleteRuleCategoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom resolution policy of the current account by policy ID. A deleted policy cannot be recovered by using its original ID, and a new ID is generated when the policy is recreated. Disable the policy and verify the resolution results before deletion. After an address block policy is deleted, its scope is excluded from overlap checks with other policies. Actual resolution takes effect after configuration propagation. You can call SdnsListRuleCategories to verify the deletion.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SdnsDeleteRuleCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SdnsDeleteRuleCategoryResponse
        /// </returns>
        public async Task<SdnsDeleteRuleCategoryResponse> SdnsDeleteRuleCategoryWithOptionsAsync(SdnsDeleteRuleCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SdnsDeleteRuleCategory",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SdnsDeleteRuleCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom resolution policy of the current account by policy ID. A deleted policy cannot be recovered by using its original ID, and a new ID is generated when the policy is recreated. Disable the policy and verify the resolution results before deletion. After an address block policy is deleted, its scope is excluded from overlap checks with other policies. Actual resolution takes effect after configuration propagation. You can call SdnsListRuleCategories to verify the deletion.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SdnsDeleteRuleCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// SdnsDeleteRuleCategoryResponse
        /// </returns>
        public SdnsDeleteRuleCategoryResponse SdnsDeleteRuleCategory(SdnsDeleteRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SdnsDeleteRuleCategoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom resolution policy of the current account by policy ID. A deleted policy cannot be recovered by using its original ID, and a new ID is generated when the policy is recreated. Disable the policy and verify the resolution results before deletion. After an address block policy is deleted, its scope is excluded from overlap checks with other policies. Actual resolution takes effect after configuration propagation. You can call SdnsListRuleCategories to verify the deletion.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SdnsDeleteRuleCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// SdnsDeleteRuleCategoryResponse
        /// </returns>
        public async Task<SdnsDeleteRuleCategoryResponse> SdnsDeleteRuleCategoryAsync(SdnsDeleteRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SdnsDeleteRuleCategoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID获取规则策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SdnsGetRuleCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SdnsGetRuleCategoryResponse
        /// </returns>
        public SdnsGetRuleCategoryResponse SdnsGetRuleCategoryWithOptions(SdnsGetRuleCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SdnsGetRuleCategory",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SdnsGetRuleCategoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID获取规则策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SdnsGetRuleCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SdnsGetRuleCategoryResponse
        /// </returns>
        public async Task<SdnsGetRuleCategoryResponse> SdnsGetRuleCategoryWithOptionsAsync(SdnsGetRuleCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SdnsGetRuleCategory",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SdnsGetRuleCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID获取规则策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SdnsGetRuleCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// SdnsGetRuleCategoryResponse
        /// </returns>
        public SdnsGetRuleCategoryResponse SdnsGetRuleCategory(SdnsGetRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SdnsGetRuleCategoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据ID获取规则策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SdnsGetRuleCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// SdnsGetRuleCategoryResponse
        /// </returns>
        public async Task<SdnsGetRuleCategoryResponse> SdnsGetRuleCategoryAsync(SdnsGetRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SdnsGetRuleCategoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the custom resolution policies for a specified domain name under the current account, including line policies, client CIDR block policies, and policies in enabled or disabled states. The returned IDs can be used to query details, update, enable, disable, or delete policies. This operation does not provide pagination parameters and does not guarantee the order of returned results. CIDR blocks are returned in the original input format.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SdnsListRuleCategoriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SdnsListRuleCategoriesResponse
        /// </returns>
        public SdnsListRuleCategoriesResponse SdnsListRuleCategoriesWithOptions(SdnsListRuleCategoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SdnsListRuleCategories",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SdnsListRuleCategoriesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the custom resolution policies for a specified domain name under the current account, including line policies, client CIDR block policies, and policies in enabled or disabled states. The returned IDs can be used to query details, update, enable, disable, or delete policies. This operation does not provide pagination parameters and does not guarantee the order of returned results. CIDR blocks are returned in the original input format.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SdnsListRuleCategoriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SdnsListRuleCategoriesResponse
        /// </returns>
        public async Task<SdnsListRuleCategoriesResponse> SdnsListRuleCategoriesWithOptionsAsync(SdnsListRuleCategoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SdnsListRuleCategories",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SdnsListRuleCategoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the custom resolution policies for a specified domain name under the current account, including line policies, client CIDR block policies, and policies in enabled or disabled states. The returned IDs can be used to query details, update, enable, disable, or delete policies. This operation does not provide pagination parameters and does not guarantee the order of returned results. CIDR blocks are returned in the original input format.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SdnsListRuleCategoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// SdnsListRuleCategoriesResponse
        /// </returns>
        public SdnsListRuleCategoriesResponse SdnsListRuleCategories(SdnsListRuleCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SdnsListRuleCategoriesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the custom resolution policies for a specified domain name under the current account, including line policies, client CIDR block policies, and policies in enabled or disabled states. The returned IDs can be used to query details, update, enable, disable, or delete policies. This operation does not provide pagination parameters and does not guarantee the order of returned results. CIDR blocks are returned in the original input format.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SdnsListRuleCategoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// SdnsListRuleCategoriesResponse
        /// </returns>
        public async Task<SdnsListRuleCategoriesResponse> SdnsListRuleCategoriesAsync(SdnsListRuleCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SdnsListRuleCategoriesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启用、禁用规则策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SdnsSwitchRuleCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SdnsSwitchRuleCategoryResponse
        /// </returns>
        public SdnsSwitchRuleCategoryResponse SdnsSwitchRuleCategoryWithOptions(SdnsSwitchRuleCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SdnsSwitchRuleCategory",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SdnsSwitchRuleCategoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启用、禁用规则策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SdnsSwitchRuleCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SdnsSwitchRuleCategoryResponse
        /// </returns>
        public async Task<SdnsSwitchRuleCategoryResponse> SdnsSwitchRuleCategoryWithOptionsAsync(SdnsSwitchRuleCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SdnsSwitchRuleCategory",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SdnsSwitchRuleCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启用、禁用规则策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SdnsSwitchRuleCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// SdnsSwitchRuleCategoryResponse
        /// </returns>
        public SdnsSwitchRuleCategoryResponse SdnsSwitchRuleCategory(SdnsSwitchRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SdnsSwitchRuleCategoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启用、禁用规则策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SdnsSwitchRuleCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// SdnsSwitchRuleCategoryResponse
        /// </returns>
        public async Task<SdnsSwitchRuleCategoryResponse> SdnsSwitchRuleCategoryAsync(SdnsSwitchRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SdnsSwitchRuleCategoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validates the submitted rules without saving or enabling any policies. In IP_RANGE mode, the Cip parameter is used to simulate a client IPv4 or IPv6 address. The system checks for CIDR block matches first and then returns the matched rules. If no custom parameters are used, pass an empty JSON object {} for the top-level Args parameter. If no rules are matched, the Data field is empty or omitted. A successful API call does not indicate a policy match. This operation does not check for CIDR block conflicts with existing policies, perform A/AAAA query type filtering or weight sampling, or simulate the complete resolution chain such as legacy CIDR block configurations, line fallback, or Function Compute. After saving and enabling the policies, verify them by using the actual resolution API.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SdnsVerifyRuleCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SdnsVerifyRuleCategoryResponse
        /// </returns>
        public SdnsVerifyRuleCategoryResponse SdnsVerifyRuleCategoryWithOptions(SdnsVerifyRuleCategoryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SdnsVerifyRuleCategoryShrinkRequest request = new SdnsVerifyRuleCategoryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Args))
            {
                request.ArgsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Args, "Args", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClientIpRanges))
            {
                request.ClientIpRangesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClientIpRanges, "ClientIpRanges", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rules))
            {
                request.RulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rules, "Rules", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArgsShrink))
            {
                body["Args"] = request.ArgsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cip))
            {
                body["Cip"] = request.Cip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIpRangesShrink))
            {
                body["ClientIpRanges"] = request.ClientIpRangesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchType))
            {
                body["MatchType"] = request.MatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RulesShrink))
            {
                body["Rules"] = request.RulesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SdnsVerifyRuleCategory",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SdnsVerifyRuleCategoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validates the submitted rules without saving or enabling any policies. In IP_RANGE mode, the Cip parameter is used to simulate a client IPv4 or IPv6 address. The system checks for CIDR block matches first and then returns the matched rules. If no custom parameters are used, pass an empty JSON object {} for the top-level Args parameter. If no rules are matched, the Data field is empty or omitted. A successful API call does not indicate a policy match. This operation does not check for CIDR block conflicts with existing policies, perform A/AAAA query type filtering or weight sampling, or simulate the complete resolution chain such as legacy CIDR block configurations, line fallback, or Function Compute. After saving and enabling the policies, verify them by using the actual resolution API.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SdnsVerifyRuleCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SdnsVerifyRuleCategoryResponse
        /// </returns>
        public async Task<SdnsVerifyRuleCategoryResponse> SdnsVerifyRuleCategoryWithOptionsAsync(SdnsVerifyRuleCategoryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SdnsVerifyRuleCategoryShrinkRequest request = new SdnsVerifyRuleCategoryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Args))
            {
                request.ArgsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Args, "Args", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClientIpRanges))
            {
                request.ClientIpRangesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClientIpRanges, "ClientIpRanges", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rules))
            {
                request.RulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rules, "Rules", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArgsShrink))
            {
                body["Args"] = request.ArgsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cip))
            {
                body["Cip"] = request.Cip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIpRangesShrink))
            {
                body["ClientIpRanges"] = request.ClientIpRangesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchType))
            {
                body["MatchType"] = request.MatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RulesShrink))
            {
                body["Rules"] = request.RulesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SdnsVerifyRuleCategory",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SdnsVerifyRuleCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validates the submitted rules without saving or enabling any policies. In IP_RANGE mode, the Cip parameter is used to simulate a client IPv4 or IPv6 address. The system checks for CIDR block matches first and then returns the matched rules. If no custom parameters are used, pass an empty JSON object {} for the top-level Args parameter. If no rules are matched, the Data field is empty or omitted. A successful API call does not indicate a policy match. This operation does not check for CIDR block conflicts with existing policies, perform A/AAAA query type filtering or weight sampling, or simulate the complete resolution chain such as legacy CIDR block configurations, line fallback, or Function Compute. After saving and enabling the policies, verify them by using the actual resolution API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SdnsVerifyRuleCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// SdnsVerifyRuleCategoryResponse
        /// </returns>
        public SdnsVerifyRuleCategoryResponse SdnsVerifyRuleCategory(SdnsVerifyRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SdnsVerifyRuleCategoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validates the submitted rules without saving or enabling any policies. In IP_RANGE mode, the Cip parameter is used to simulate a client IPv4 or IPv6 address. The system checks for CIDR block matches first and then returns the matched rules. If no custom parameters are used, pass an empty JSON object {} for the top-level Args parameter. If no rules are matched, the Data field is empty or omitted. A successful API call does not indicate a policy match. This operation does not check for CIDR block conflicts with existing policies, perform A/AAAA query type filtering or weight sampling, or simulate the complete resolution chain such as legacy CIDR block configurations, line fallback, or Function Compute. After saving and enabling the policies, verify them by using the actual resolution API.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SdnsVerifyRuleCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// SdnsVerifyRuleCategoryResponse
        /// </returns>
        public async Task<SdnsVerifyRuleCategoryResponse> SdnsVerifyRuleCategoryAsync(SdnsVerifyRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SdnsVerifyRuleCategoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the complete rule list of an existing policy for the current account. For IP_RANGE policies, the client IP address ranges can be replaced as a whole at the same time. If ClientIpRanges is omitted, the original IP address ranges are retained. Explicitly passing an empty array is not allowed. The update does not change the bound domain names, match types, or enabled status of the policy. The new ranges are checked for conflicts only with other IP address range policies under the same domain name. If the validation fails, the update is not saved. After a successful update, you can call SdnsGetRuleCategory to verify the configuration. Actual DNS resolution requires waiting for configuration propagation.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateSdnsRuleCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSdnsRuleCategoryResponse
        /// </returns>
        public UpdateSdnsRuleCategoryResponse UpdateSdnsRuleCategoryWithOptions(UpdateSdnsRuleCategoryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSdnsRuleCategoryShrinkRequest request = new UpdateSdnsRuleCategoryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rules))
            {
                request.RulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rules, "Rules", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIpRanges))
            {
                body["ClientIpRanges"] = request.ClientIpRanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RulesShrink))
            {
                body["Rules"] = request.RulesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSdnsRuleCategory",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSdnsRuleCategoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the complete rule list of an existing policy for the current account. For IP_RANGE policies, the client IP address ranges can be replaced as a whole at the same time. If ClientIpRanges is omitted, the original IP address ranges are retained. Explicitly passing an empty array is not allowed. The update does not change the bound domain names, match types, or enabled status of the policy. The new ranges are checked for conflicts only with other IP address range policies under the same domain name. If the validation fails, the update is not saved. After a successful update, you can call SdnsGetRuleCategory to verify the configuration. Actual DNS resolution requires waiting for configuration propagation.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateSdnsRuleCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSdnsRuleCategoryResponse
        /// </returns>
        public async Task<UpdateSdnsRuleCategoryResponse> UpdateSdnsRuleCategoryWithOptionsAsync(UpdateSdnsRuleCategoryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSdnsRuleCategoryShrinkRequest request = new UpdateSdnsRuleCategoryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rules))
            {
                request.RulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rules, "Rules", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIpRanges))
            {
                body["ClientIpRanges"] = request.ClientIpRanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RulesShrink))
            {
                body["Rules"] = request.RulesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSdnsRuleCategory",
                Version = "2016-02-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSdnsRuleCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the complete rule list of an existing policy for the current account. For IP_RANGE policies, the client IP address ranges can be replaced as a whole at the same time. If ClientIpRanges is omitted, the original IP address ranges are retained. Explicitly passing an empty array is not allowed. The update does not change the bound domain names, match types, or enabled status of the policy. The new ranges are checked for conflicts only with other IP address range policies under the same domain name. If the validation fails, the update is not saved. After a successful update, you can call SdnsGetRuleCategory to verify the configuration. Actual DNS resolution requires waiting for configuration propagation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSdnsRuleCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSdnsRuleCategoryResponse
        /// </returns>
        public UpdateSdnsRuleCategoryResponse UpdateSdnsRuleCategory(UpdateSdnsRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSdnsRuleCategoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the complete rule list of an existing policy for the current account. For IP_RANGE policies, the client IP address ranges can be replaced as a whole at the same time. If ClientIpRanges is omitted, the original IP address ranges are retained. Explicitly passing an empty array is not allowed. The update does not change the bound domain names, match types, or enabled status of the policy. The new ranges are checked for conflicts only with other IP address range policies under the same domain name. If the validation fails, the update is not saved. After a successful update, you can call SdnsGetRuleCategory to verify the configuration. Actual DNS resolution requires waiting for configuration propagation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSdnsRuleCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSdnsRuleCategoryResponse
        /// </returns>
        public async Task<UpdateSdnsRuleCategoryResponse> UpdateSdnsRuleCategoryAsync(UpdateSdnsRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSdnsRuleCategoryWithOptionsAsync(request, runtime);
        }

    }
}
